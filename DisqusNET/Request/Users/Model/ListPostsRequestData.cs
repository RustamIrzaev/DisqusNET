using System.Runtime.Serialization;

namespace DisqusNET.Request.Users.Model
{
    [DataContract]
    public class ListPostsRequestData
    {
        [DataMember(Name = "access_token")]
        public string AccessToken { get; set; }

        [DataMember(Name = "limit")]
        public int Limit { get; set; }
    }
}