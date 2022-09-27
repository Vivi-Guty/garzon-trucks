using inercya.EntityLite;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Server.IIS.Core;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using NLog.Fluent;
using System.Configuration;
using System.DirectoryServices.AccountManagement;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Security.Claims;
using System.Text;
using System.Web.Http;
using WebApi.Entities;
using WebApi.Models;

namespace WebApi.Services
{
    public interface IUserService
    {
        Task<AuthenticateResponse?> Authenticate(Login loginModel);
        Task<User> GetByIdAsync(int id);
        void SetCurrentUserId(int userId);
    }

    public class UserService : IUserService
    {
        private readonly string _secret;        
        private readonly MapDataService _dataService;
        public IConfiguration _configuration;

        public UserService(IConfiguration configuration, MapDataService dataService, UserPasswordService userPasswordService)
        {
            _configuration = configuration;
            _secret = configuration.GetSection("JWTSecret").Get<string>();
            _dataService = dataService;
        }

        public async Task<AuthenticateResponse?> Authenticate(Login loginModel)
        {
            if (loginModel == null)
            {
                SaveFailureLogin(loginModel, "The selected user does not exist in the application or is disabled");
                return new AuthenticateResponse(null, string.Empty, new OkResultModel
                {
                    ResultCode = OkResultCodesModel.ResultCodeError,
                    Message = "The selected user does not exist in the application or is disabled"
                });
            }

            var loginName = loginModel.Domain + @"\" + loginModel.LoginName;

            User? user = await this._dataService.UserRepository.Query(Projection.BaseTable)
                    .Where(nameof(User.LoginName), loginName)
                    .And(nameof(User.IsActive), true)
            .FirstOrDefaultAsync();            

            ///if (user == null) return null;
            if (user == null)
            {
                SaveFailureLogin(loginModel, "The selected user does not exist in the application or is disabled");
                return new AuthenticateResponse(null, string.Empty, new OkResultModel
                {
                    ResultCode = OkResultCodesModel.ResultCodeError,
                    Message = "The selected user does not exist in the application or is disabled"
                });
            }

            this._dataService.UserRepository.SetContextInfo(user.CultureCode.Substring(0, 2), user.UserId);

            int maxNumberOfFailedAttemptsToLogin = _configuration.GetValue<int>("AppSettings:MaxNumberOfFailedAttemptsToLogin");
            int blockMinutesAfterLimitFailedAttemptsToLogin = _configuration.GetValue<int>("AppSettings:BlockMinutesAfterLimitFailedAttemptsToLogin");

            if (user.LoginFailedAttemptsCount >= maxNumberOfFailedAttemptsToLogin
             && user.LastLoginAttempt.HasValue
             && DateTime.UtcNow < user.LastLoginAttempt.Value.AddMinutes(blockMinutesAfterLimitFailedAttemptsToLogin))
            {
                /// Login is blocked, need to break the process. Return error message "Your account was blocked for a 15 minutes, please try again later
                SaveFailureLogin(loginModel, "Your account was blocked for " + blockMinutesAfterLimitFailedAttemptsToLogin + " minutes, please try again later.");
                return new AuthenticateResponse(null, string.Empty, new OkResultModel
                {
                    ResultCode = OkResultCodesModel.ResultCodeError,
                    Message = "Your account was blocked for " + blockMinutesAfterLimitFailedAttemptsToLogin + " minutes, please try again later."
                });
            }
            // si ya hemos cumplido los 5 minutos, reseteamos
            else if (user.LoginFailedAttemptsCount >= maxNumberOfFailedAttemptsToLogin
             && user.LastLoginAttempt.HasValue
             && DateTime.UtcNow > user.LastLoginAttempt.Value.AddMinutes(blockMinutesAfterLimitFailedAttemptsToLogin))
            {
                user.LoginFailedAttemptsCount = 0;
                user.LastLoginAttempt = DateTime.UtcNow;

                this._dataService.UserRepository.Update(user, UserFields.LastLoginAttempt, UserFields.LoginFailedAttemptsCount);
            }

            

            if (string.IsNullOrEmpty(loginModel.Password))
            {
                SaveFailureLogin(loginModel, "You must enter a password");
                return new AuthenticateResponse(null, string.Empty, new OkResultModel
                {
                    ResultCode = OkResultCodesModel.ResultCodeError,
                    Message = "You must enter a password"
                });
            }
            if (AreCredentialsValidInActiveDirectory(loginModel))
            {
                user.LastLoginAttempt = DateTime.UtcNow;
                user.LoginFailedAttemptsCount = 0;
                this._dataService.UserRepository.Update(user, UserFields.LastLoginAttempt, UserFields.LoginFailedAttemptsCount);

                //FormsAuthentication.SetAuthCookie(login.LoginName, true);
                var token = generateJwtToken(user);
                return new AuthenticateResponse(user, token, new OkResultModel { ResultCode = OkResultCodesModel.ResultCodeOk, Message = "Login successfully" });
            }
            else
            {
                user.LastLoginAttempt = DateTime.UtcNow;
                user.LoginFailedAttemptsCount++;
                this._dataService.UserRepository.Update(user, UserFields.LastLoginAttempt, UserFields.LoginFailedAttemptsCount);

                SaveFailureLogin(loginModel, "Incorrect password");
                return new AuthenticateResponse(null, string.Empty, new OkResultModel
                {
                    ResultCode = OkResultCodesModel.ResultCodeError,
                    Message = "Incorrect password"
                });
            }
            //return new AuthenticateResponse(user, token, new OkResultModel { ResultCode = OkResultCodesModel.ResultCodeOk, Message = "Login successfully" });
        }

        private bool AreCredentialsValidInActiveDirectory(Login login)
        {            
            string domain = _configuration.GetValue<string>("AppSettings:Domain");
            using (PrincipalContext pc = new PrincipalContext(ContextType.Domain, domain))
            {
                bool isValid = pc.ValidateCredentials(login.LoginName, login.Password);
                return isValid;
            }
        }

        private void SaveFailureLogin(Login? loginModel, string errorMessage)
        {
            FailureLogin failureLogin = new FailureLogin()
            {
                Domain = loginModel != null ? loginModel.Domain : null,
                Username = loginModel != null ? loginModel.UserName : null,
                CreatedBy = 1,
                CreatedDate = DateTime.Now,
                ErrorMessage = errorMessage
            };
            this._dataService.FailureLoginRepository.Insert(failureLogin);
        }

        public async Task<User> GetByIdAsync(int id)
        {
            return await this._dataService.UserRepository.Query(Projection.BaseTable)
                .GetAsync(nameof(User.UserId), id);
        }

        private string generateJwtToken(User user)
        {
            // generate token that is valid for 7 days
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] { new Claim("id", user.UserId.ToString()) }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        public void SetCurrentUserId(int userId)
        {
            this._dataService.CurrentUserId = userId;
        }

    }
}