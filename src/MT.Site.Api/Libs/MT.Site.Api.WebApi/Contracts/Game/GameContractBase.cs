using System.Runtime.Serialization;

namespace MT.Site.Api.WebApi.Contracts.Game
{
    [DataContract]
    public class GameContractBase
    {
        [DataMember(Name = "playerName")]
        public string PlayerName { get; set; }
    }
}
