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
    }
}