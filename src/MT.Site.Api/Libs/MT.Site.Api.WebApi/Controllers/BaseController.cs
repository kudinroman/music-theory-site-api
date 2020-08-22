using Microsoft.AspNetCore.Mvc;
using MT.Site.Api.WebApi.Contracts;

namespace MT.Site.Api.WebApi.Controllers
{
    public class BaseController : ControllerBase
    {
        [Route("api/base")]
        [HttpGet]
        public IActionResult GetBase(string text)
        {
            var baseContract = new BaseContract() { Text = text };
            return Ok(baseContract);
        }
    }
}
