using System;
using System.IO;
using System.Net;
using System.Runtime.Serialization;

namespace DisqusNET.Request.Users
{
    public class ListActivityRequest : BaseRequest
    {
        public static ExecutionResult<string> Execute()
        {
            try
            {
                var data = new ListActivityRequestData
                               {
                                   AccessToken = "10972df3afee436dba59073007dd8d0d",
                                   Limit = 1
                               };

                var memoryStream = SerializeContentJson(data);
                var request = BuildRequest("https://disqus.com/api/3.0/users/listActivity.json", HttpMethod.GET,
                                           memoryStream);
                var response = (HttpWebResponse) request.GetResponse();

                using (var stream = new StreamReader(response.GetResponseStream()))
                {
                    var serializer = new DataContractSerializer(typeof (object));

                    return ExecutionResult<string>.Create();
                }
            }
            catch (Exception e)
            {
                return ExecutionResult<string>.CreateError(e);
            }
        }

        [DataContract]
        public class ListActivityRequestData
        {
            [DataMember(Name = "access_token")]
            public string AccessToken { get; set; }

            [DataMember(Name = "limit")]
            public int Limit { get; set; }
        }
    }
}