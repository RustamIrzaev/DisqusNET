using System.Runtime.Serialization;

namespace DisqusNET.Model.Threads
{
    [DataContract]
    public class ThreadResponse
    {
        [DataMember(Name = "category")]
        public string Category { get; set; }

        [DataMember(Name = "reactions")]
        public int Reactions { get; set; }

        // identifiers

        [DataMember(Name = "forum")]
        public string Forum { get; set; }

        [DataMember(Name = "title")]
        public string Title { get; set; }

        [DataMember(Name = "dislikes")]
        public int Dislikes { get; set; }

        [DataMember(Name = "isDeleted")]
        public bool IsDeleted { get; set; }

        [DataMember(Name = "author")]
        public string Author { get; set; }

        [DataMember(Name = "userScore")]
        public int UserScore { get; set; }

        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "isClosed")]
        public bool IsClosed { get; set; }

        [DataMember(Name = "posts")]
        public int Posts { get; set; }

        [DataMember(Name = "link")]
        public string Link { get; set; }

        [DataMember(Name = "likes")]
        public int Likes { get; set; }

        [DataMember(Name = "message")]
        public string Message { get; set; }

        [DataMember(Name = "ipAddress")]
        public string IPAddress { get; set; }

        [DataMember(Name = "slug")]
        public string Slug { get; set; }

        // createdAt
    }
}