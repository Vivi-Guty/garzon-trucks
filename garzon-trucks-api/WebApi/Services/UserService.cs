using inercya.EntityLite;
using Microsoft.AspNetCore.Server.IIS.Core;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using WebApi.Entities;
using WebApi.Models;

namespace WebApi.Services
{
    public interface IUserService
    {
        Task<AuthenticateResponse?> Authenticate(AuthenticateRequest model);
        Task<User> GetByIdAsync(int id);
        void SetCurrentUserId(int userId);
    }

    public class UserService: IUserService
    {
        private readonly string secret;
        private readonly InsurancesDataService _dataService;
        private readonly UserPasswordService _userPasswordService;
        public UserService(IConfiguration configuration, InsurancesDataService dataService, UserPasswordService userPasswordService)
        {
            secret = configuration.GetSection("JWTSecret").Get<string>();
            _dataService = dataService;
            _userPasswordService = userPasswordService;
        }

        public async Task<AuthenticateResponse?> Authenticate(AuthenticateRequest model)
        {
            var userProperty = await this._dataService.UserPropertiesRepository.Query(Projection.Basic)
                .Where(nameof(UserProperties.LoginName), model.LoginName)
                .FirstOrDefaultAsync();

            if (userProperty == null) return null;

            var isPasswordValid = userProperty.IsPasswordValid(model.Password, _userPasswordService);

            User? user = null;
            if (userProperty != null && isPasswordValid)
            {
                user = await this._dataService.UserRepository.Query(Projection.BaseTable)
                    .Where(nameof(User.LoginName), model.LoginName)
                    .And(nameof(User.IsActive), true)
                    .FirstOrDefaultAsync();
            }

            // return null if user not found
            if (user == null) return null;

            // authentication successful so generate jwt token
            var token = generateJwtToken(user);

            return new AuthenticateResponse(user, token);
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
            var key = Encoding.ASCII.GetBytes(secret);
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
