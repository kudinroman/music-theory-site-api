using MT.Site.Api.Domain.Interfaces.Games.Managers;
using MT.Site.Api.Domain.Interfaces.Games.Models;
using MT.Site.Api.WebApi.Contracts.Game;
using System.Threading.Tasks;

namespace MT.Site.Api.WebApi.ProcessingServices
{
    public sealed class GameProcessingService
    {
        private readonly IGameManager _gameManager;

        public GameProcessingService(IGameManager gameManager)
        {
            _gameManager = gameManager;
        }

        public async Task<GameOutContract> CreateGame(StartGameInContract startGameInContract)
        {
            var game = await _gameManager.CreateGame(startGameInContract.PlayerName);
            var outContract = ConvertToGameOutContract(game);

            return outContract;
        }

        private static GameOutContract ConvertToGameOutContract(IGame game)
        {
            var gameOutContract = new GameOutContract
            {
                PlayerName = game.PlayerName,
                Level = game.Level,
                Score = game.Score
            };

            return gameOutContract;
        }
    }
}
