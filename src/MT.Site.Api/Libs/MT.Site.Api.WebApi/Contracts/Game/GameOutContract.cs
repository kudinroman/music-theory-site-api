using System.Runtime.Serialization;

namespace MT.Site.Api.WebApi.Contracts.Game
{
    [DataContract]
    public class GameOutContract : GameContractBase
    {
        [DataMember(Name = "level")]
        public int Level { get; set; }

        [DataMember(Name = "score")]
        public int Score { get; set; }
    }
}
