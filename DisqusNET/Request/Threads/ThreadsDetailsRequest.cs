using System;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Json;
using DisqusNET.Model.Threads;
using DisqusNET.Request.Threads.Model;

namespace DisqusNET.Request.Threads
{
    public class ThreadsDetailsRequest : BaseRequest
    {
        public static ExecutionResult<ThreadsDetails> Execute(int threadId)
        {
            try
            {
                var data = new ThreadsDetailsRequestData { ThreadId = threadId };

                var request = BuildRequest("https://disqus.com/api/3.0/threads/details.json", HttpMethod.GET, data);
                var response = (HttpWebResponse)request.GetResponse();

                using (var stream = new StreamReader(response.GetResponseStream()))
                {
                    var serializer = new DataContractJsonSerializer(typeof(ThreadsDetails));
                    var result = serializer.ReadObject(stream.BaseStream) as ThreadsDetails;

                    return ExecutionResult<ThreadsDetails>.Create(result);
                }
            }
            catch (Exception e)
            {
                return ExecutionResult<ThreadsDetails>.CreateError(e);
            }
        }
    }
}