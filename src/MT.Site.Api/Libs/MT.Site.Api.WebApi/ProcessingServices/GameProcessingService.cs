using MT.Site.Api.WebApi.Contracts.Game;

namespace MT.Site.Api.WebApi.ProcessingServices
{
    public sealed class GameProcessingService
    {
        public GameOutContract CreateGame(StartGameInContract startGameInContract)
        {
            var outContract = new GameOutContract
            {
                PlayerName = startGameInContract.PlayerName,
                Level = 0,
                Score = 0
            };

            return outContract;
        }
    }
}
