using inercya.EntityLite;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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
        public async Task<IActionResult> Authenticate([FromBody] AuthenticateRequest model)
        {
            var response = await _userService.Authenticate(model);

            if (response == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            return Ok(response);
        }

        [HttpGet]
        [Route("api/users/get-all")]
        public async Task<IActionResult> GetAll()
        {
            var currentUser = this.CurrentUser;
            var users = await this.DataService.UserRepository.Query(Projection.BaseTable).ToListAsync();
            _logger.LogInformation("GetAll method with {0} users", users.Count);
            return Ok(users);
        }
    }
}
