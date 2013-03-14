using System.Collections.Generic;
using System.Runtime.Serialization;

namespace DisqusNET.Model.Users
{
    [DataContract]
    public class ListPostsModel
    {
        [DataMember(Name = "cursor")]
        public CursorModel Cursor { get; set; }

        [DataMember(Name = "code")]
        public int Code { get; set; }

        [DataMember(Name = "response")]
        public List<UserResponseModel> Response { get; set; }
    }
}