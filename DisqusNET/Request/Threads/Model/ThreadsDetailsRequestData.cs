using System.Runtime.Serialization;

namespace DisqusNET.Request.Threads.Model
{
    [DataContract]
    public class ThreadsDetailsRequestData : ApiKeyRequestExtension
    {
        [DataMember(Name = "thread")]
        public int ThreadId { get; set; }
    }
}