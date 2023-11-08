using inercya.EntityLite;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    public class ReferenceDataController : BaseController
    {
        [HttpGet]
        [Route("api/reference-data/master-data")]
        public async Task<IActionResult> GetMasterData()
        {
            return Ok(await this.DataService.MasterDataRepository.Query(Projection.BaseTable).ToListAsync());
        }
    }
}
