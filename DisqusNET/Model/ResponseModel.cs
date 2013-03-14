using System.Runtime.Serialization;

namespace DisqusNET.Model
{
    [DataContract]
    public class ResponseModel
    {
        [DataMember(Name = "isJuliaFlagged")]
        public bool IsJuliaFlagged { get; set; }

        [DataMember(Name = "isFlagged")]
        public bool IsFlagged { get; set; }

        [DataMember(Name = "forum")]
        public string Forum { get; set; }

        [DataMember(Name = "parent")]
        public string Parent { get; set; }

        [DataMember(Name = "author")]
        public AuthorModel Author { get; set; }

        // media

        [DataMember(Name = "isDeleted")]
        public bool IsDeleted { get; set; }

        [DataMember(Name = "isApproved")]
        public bool IsApproved { get; set; }

        [DataMember(Name = "dislikes")]
        public int Dislikes { get; set; }

        [DataMember(Name = "raw_message")]
        public string RawMessage { get; set; }

        // createdAt

        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "thread")]
        public string Thread { get; set; }

        [DataMember(Name = "numReports")]
        public int NumReports { get; set; }

        [DataMember(Name = "likes")]
        public int Likes { get; set; }

        [DataMember(Name = "isEdited")]
        public bool IsEdited { get; set; }

        [DataMember(Name = "points")]
        public int Points { get; set; }

        [DataMember(Name = "message")]
        public string Message { get; set; }

        [DataMember(Name = "isSpam")]
        public bool IsSpam { get; set; }

        [DataMember(Name = "isHighlighted")]
        public bool IsHighlighted { get; set; }

        [DataMember(Name = "userScore")]
        public int UserScore { get; set; }
    }
}