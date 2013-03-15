using System;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Json;
using DisqusNET.Model.Posts;
using DisqusNET.Request.Posts.Model;

namespace DisqusNET.Request.Posts
{
    public class ListRequest : BaseRequest
    {
        public static ExecutionResult<ListsModel> Execute(ListRequestData data = null)
        {
            try
            {
                if (data == null)
                {
                    data = new ListRequestData();
                }

                data.AccessToken = DisqusOptions.GetInstance().AccessToken;

                var request = BuildRequest("https://disqus.com/api/3.0/posts/list.json", HttpMethod.GET, data);
                var response = (HttpWebResponse)request.GetResponse();

                using (var stream = new StreamReader(response.GetResponseStream()))
                {
                    var serializer = new DataContractJsonSerializer(typeof(ListsModel));
                    var result = serializer.ReadObject(stream.BaseStream) as ListsModel;

                    return ExecutionResult<ListsModel>.Create(result);
                }
            }
            catch (Exception e)
            {
                return ExecutionResult<ListsModel>.CreateError(e);
            }
        }
    }
}