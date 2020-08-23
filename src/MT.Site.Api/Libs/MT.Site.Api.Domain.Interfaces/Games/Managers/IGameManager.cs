using MT.Site.Api.Domain.Interfaces.Games.Models;
using System.Threading.Tasks;

namespace MT.Site.Api.Domain.Interfaces.Games.Managers
{
    public interface IGameManager
    {
        Task<IGame> CreateGame(string playerName);
    }
}
