using System.Runtime.Serialization;

namespace DisqusNET.Model
{
    [DataContract]
    public class CursorModel
    {
        [DataMember(Name = "prev")]
        public string Prev { get; set; }

        [DataMember(Name = "hasNext")]
        public bool HasNext { get; set; }

        [DataMember(Name = "next")]
        public string Next { get; set; }

        [DataMember(Name = "hasPrev")]
        public bool HasPrev { get; set; }

        [DataMember(Name = "total")]
        public string Total { get; set; }

        [DataMember(Name = "more")]
        public bool More { get; set; }

        [DataMember(Name = "id")]
        public string Id { get; set; }
    }
}