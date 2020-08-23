using System.Threading.Tasks;

namespace MT.Site.Api.Domain.Interfaces.Games.Models
{
    public interface IGame
    {
        string PlayerName { get; set; }
        int Level { get; set; }
        int Score { get; set; }

        Task Save();
    }
}
