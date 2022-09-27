using inercya.EntityLite;
using Microsoft.AspNetCore.Mvc;
using System.Security.Permissions;
using WebApi.Entities;
using WebApi.Infrastructure.Authorization;
using WebApi.Models;
using WebApi.Services;

namespace WebApi.Controllers
{
    [ApiController]
    public class UsersController : BaseController
    {
        private IUserService _userService;
        private readonly ILogger<UsersController> _logger;

        public UsersController(IUserService userService, ILogger<UsersController> logger)
        {
            _userService = userService;
            _logger = logger;
            _logger.LogDebug("NLog injected into UsersController");
        }

        [HttpGet("api/users/me")]
        public IActionResult Me()
        {
            return Json(this.CurrentUser);
        }

        [HttpPost("api/users/authenticate")]
        public async Task<IActionResult> Authenticate([FromBody] Login loginModel)
        {
            var response = await _userService.Authenticate(loginModel);

            if (response == null || response.Result.ResultCode == OkResultCodesModel.ResultCodeError) {
                var messageError = (response == null || string.IsNullOrEmpty(response.Result.Message)) ? "Username or password is incorrect" : response.Result.Message;
                return BadRequest(new { message = messageError });                
            }                

            return Ok(response);
        }

        [HttpPost]
        [Route("api/admin/search-users")]
        public async Task<IActionResult> SearchUsers(UserCriteria userCriteria)
        {
            await CheckHaveThisPermission(PermissionId.AdminUsers);

            return this.Ok(await this.DataService.UserRepository.Query(Projection.BaseTable).ToListAsync());
        }
    }
}
