using System.Runtime.Serialization;

namespace DisqusNET.Model.Users
{
    [DataContract]
    public class ListPostsModel
    {
        [DataMember(Name = "code")]
        public int Code { get; set; }
    }
}