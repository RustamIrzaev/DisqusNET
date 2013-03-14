using System.Runtime.Serialization;

namespace DisqusNET.Model.Threads
{
    [DataContract]
    public class ThreadsDetails
    {
        [DataMember(Name = "code")]
        public int Code { get; set; }

        [DataMember(Name = "response")]
        public ThreadResponse Response { get; set; }
    }
}