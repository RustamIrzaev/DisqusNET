using System.Runtime.Serialization;

namespace DisqusNET.Model.Posts
{
    [DataContract]
    public class ListsModel
    {
        [DataMember(Name = "code")]
        public int Code { get; set; }
    }
}