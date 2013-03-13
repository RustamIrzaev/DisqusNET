using System.Runtime.Serialization;

namespace DisqusNET.Model.Users
{
    [DataContract(Namespace = "")]
    public class ListPostsModel
    {
        [DataMember(Name = "code")]
        public int Code { get; set; }
    }
}