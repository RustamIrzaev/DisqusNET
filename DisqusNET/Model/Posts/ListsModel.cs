using System.Collections.Generic;
using System.Runtime.Serialization;
using DisqusNET.Model.Users;

namespace DisqusNET.Model.Posts
{
    [DataContract]
    public class ListsModel
    {
        [DataMember(Name = "cursor")]
        public CursorModel Cursor { get; set; }

        [DataMember(Name = "code")]
        public int Code { get; set; }

        [DataMember(Name = "response")]
        public IEnumerable<UserResponseModel> Response { get; set; }
    }
}