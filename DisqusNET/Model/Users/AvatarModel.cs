using System.Runtime.Serialization;

namespace DisqusNET.Model.Users
{
    [DataContract]
    public class AvatarModel
    {
        [DataMember(Name = "small")]
        public PermalinkCacheModel PermalinkCache { get; set; }

        [DataMember(Name = "isCustom")]
        public bool IsCustom { get; set; }

        [DataMember(Name = "permalink")]
        public string Permalink { get; set; }

        [DataMember(Name = "cache")]
        public string Cache { get; set; }

        [DataMember(Name = "large")]
        public PermalinkCacheModel Large { get; set; }
    }

    [DataContract]
    public class PermalinkCacheModel
    {
        [DataMember(Name = "permalink")]
        public string Permalink { get; set; }

        [DataMember(Name = "cache")]
        public string Cache { get; set; }
    }
}