using System.Collections.Generic;
using System.Runtime.Serialization;

namespace DisqusNET.Model.Users
{
    [DataContract]
    public class ListPostsModel
    {
        [DataMember(Name = "code")]
        public int Code { get; set; }

        [DataMember(Name = "response")]
        public List<Response> Response { get; set; }
    }

    [DataContract]
    public class Response
    {
        [DataMember(Name = "forum")]
        public string Forum { get; set; }

        [DataMember(Name = "isJuliaFlagged")]
        public bool IsJuliaFlagged { get; set; }
    }
}