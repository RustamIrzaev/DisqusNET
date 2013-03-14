using System.Runtime.Serialization;

namespace DisqusNET.Request.Posts.Model
{
    [DataContract]
    public class ListRequestData : ApiKeyRequestExtension
    {
        [DataMember(Name = "access_token")]
        public string AccessToken { get; set; }

        [DataMember(Name = "forum")]
        public string Forum { get; set; }

        [DataMember(Name = "order")]
        public string Order { get; set; }

        [DataMember(Name = "limit")]
        public int Limit { get; set; }

        public ListRequestData()
        {
            Order = "desc";
            Limit = 25;
        }
    }
}