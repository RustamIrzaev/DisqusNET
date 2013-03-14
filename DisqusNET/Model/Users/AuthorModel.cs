using System.Runtime.Serialization;

namespace DisqusNET.Model.Users
{
    [DataContract]
    public class AuthorModel
    {
        [DataMember(Name = "username")]
        public string UserName { get; set; }

        [DataMember(Name = "about")]
        public string About { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "url")]
        public string Url { get; set; }

        // joinedAt

        [DataMember(Name = "rep")]
        public float Rep { get; set; }

        [DataMember(Name = "isFollowing")]
        public bool IsFollowing { get; set; }

        [DataMember(Name = "isFollowedBy")]
        public bool IsFollowedBy { get; set; }

        [DataMember(Name = "profileUrl")]
        public string ProfileUrl { get; set; }

        [DataMember(Name = "emailHash")]
        public string EmailHash { get; set; }

        [DataMember(Name = "reputation")]
        public float Reputation { get; set; }

        [DataMember(Name = "location")]
        public string Location { get; set; }

        [DataMember(Name = "isPrimary")]
        public bool IsPrimary { get; set; }

        [DataMember(Name = "isAnonymous")]
        public bool IsAnonymous { get; set; }

        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "avatar")]
        public AvatarModel Avatar { get; set; }
    }
}