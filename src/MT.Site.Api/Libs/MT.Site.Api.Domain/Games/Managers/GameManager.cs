using MT.Site.Api.Domain.Games.Models;
using MT.Site.Api.Domain.Interfaces.Games.Managers;
using MT.Site.Api.Domain.Interfaces.Games.Models;
using MT.Site.Api.Storage.Interfaces.Providers;
using System.Threading.Tasks;

namespace MT.Site.Api.Domain.Games.Managers
{
    public class GameManager : IGameManager
    {
        private readonly IGameStorageProvider _gameStorageProvider;

        public GameManager(IGameStorageProvider gameStorageProvider)
        {
            _gameStorageProvider = gameStorageProvider;
        }

        public async Task<IGame> CreateGame(string playerName)
        {
            var game = new Game(_gameStorageProvider, playerName);
            await game.Save();
            return game;
        }
    }
}
