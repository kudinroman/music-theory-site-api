using Microsoft.AspNetCore.Mvc;
using MT.Site.Api.WebApi.Contracts.Game;
using MT.Site.Api.WebApi.ProcessingServices;

namespace MT.Site.Api.WebApi.Controllers
{
    public class GameController : ControllerBase
    {
        private readonly GameProcessingService _processingService;

        public GameController(GameProcessingService processingService)
        {
            _processingService = processingService;
        }

        [HttpPost]
        [Route("api/games")]
        public IActionResult CreateGame([FromBody] StartGameInContract startGameInContract)
        {
            if (startGameInContract == null)
            {
                return BadRequest();
            }

            var outContract = _processingService.CreateGame(startGameInContract);
            return Ok(outContract);
        }
    }
}
