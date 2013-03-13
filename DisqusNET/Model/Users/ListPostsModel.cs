using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace DisqusNET.Model.Users
{
    [DataContract]
    public class ListPostsModel
    {
        [DataMember(Name = "cursor")]
        public Cursor Cursor { get; set; }

        [DataMember(Name = "code")]
        public int Code { get; set; }

        [DataMember(Name = "response")]
        public List<Response> Response { get; set; }
    }

    [DataContract]
    public class Response
    {
        [DataMember(Name = "type")]
        public string Type { get; set; }
    }

    [DataContract]
    public class Cursor
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }
    }
}