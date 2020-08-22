using System.Runtime.Serialization;

namespace MT.Site.Api.WebApi.Contracts
{
    [DataContract]
    public class BaseContract
    {
        [DataMember(Name = "text")]
        public string Text { get; set; }
    }
}
