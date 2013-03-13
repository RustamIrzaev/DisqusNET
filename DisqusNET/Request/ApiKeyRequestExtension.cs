using System.Runtime.Serialization;

namespace DisqusNET.Request
{
    public class ApiKeyRequestExtension
    {
        [DataMember(Name = "api_key")]
        public string ApiKey { get { return DisqusOptions.GetInstance().ApiKey; } }
    }
}