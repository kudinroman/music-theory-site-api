using MT.Site.Api.Domain.Interfaces.Games.Models;
using MT.Site.Api.Storage.Interfaces.Models;
using MT.Site.Api.Storage.Interfaces.Providers;
using System.Threading.Tasks;

namespace MT.Site.Api.Domain.Games.Models
{
    public class Game : IGame
    {
        private readonly IGameStorageProvider _storageProvider;

        public string PlayerName { get; set; }
        public int Level { get; set; }
        public int Score { get; set; }

        public Game(IGameStorageProvider storageProvider, string playerName)
        {
            _storageProvider = storageProvider;
            PlayerName = playerName;
            Level = 0;
            Score = 0;
        }

        public Task Save()
        {
            var storageModel = ConvertToStorageModel();
            return _storageProvider.InsertGameAsync(storageModel);
        }

        private GameStorageModel ConvertToStorageModel()
        {
            var storageModel = new GameStorageModel
            {
                PlayerName = PlayerName,
                Level = Level,
                Score = Score
            };

            return storageModel;
        }
    }
}
