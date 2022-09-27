using inercya.EntityLite;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    public class ReferenceDataController : BaseController
    {
        [HttpGet]
        [Route("api/reference-data/users")]
        public async Task<IActionResult> GetUsers()
        {
            return Ok(await this.DataService.UserRepository.Query(Projection.BaseTable).ToListAsync());
        }
    }
}
