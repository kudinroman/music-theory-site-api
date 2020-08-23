using MT.Site.Api.Storage.Interfaces.Models;
using System.Threading.Tasks;

namespace MT.Site.Api.Storage.Interfaces.Providers
{
    public interface IGameStorageProvider
    {
        Task InsertGameAsync(GameStorageModel model);
    }
}
