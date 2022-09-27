using inercya.EntityLite;
using Microsoft.AspNetCore.Mvc;
using WebApi.Entities;
using WebApi.Models;
using WebApi.Services;
using WebApi.Extensions;
using Microsoft.Extensions.Primitives;

namespace WebApi.Controllers
{
    [ApiController]
    public class TextsController : BaseController
    {
        private readonly ILogger<UsersController> _logger;

        public TextsController(ILogger<UsersController> logger)
        {
            _logger = logger;
            _logger.LogDebug("NLog injected into TextsController");
        }

        [HttpGet]
        [Route("api/texts")]
        public async Task<IActionResult> Get(string languageCode)
        {
            var textsData = await this.DataService.TextRepository.GetTextsByLanguageCode();
            Dictionary<string, string>? texts;
            if (!textsData.TryGetValue(languageCode, out texts))
            {
                texts = textsData["en"];
            }           

            return Ok(texts);
        }
    }
}
