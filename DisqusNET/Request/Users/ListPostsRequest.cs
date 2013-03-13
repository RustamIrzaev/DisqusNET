using System;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Json;
using DisqusNET.Model.Users;
using DisqusNET.Request.Users.Model;

namespace DisqusNET.Request.Users
{
    public class ListPostsRequest : BaseRequest
    {
        public static ExecutionResult<ListPostsModel> Execute()
        {
            try
            {
                var data = new ListPostsRequestData
                               {
                                   AccessToken = DisqusOptions.GetInstance().AccessToken,
                                   Limit = 1
                               };

                var request = BuildRequest("https://disqus.com/api/3.0/users/listActivity.json", HttpMethod.GET, data);
                var response = (HttpWebResponse)request.GetResponse();

                using (var stream = new StreamReader(response.GetResponseStream()))
                {
                    var serializer = new DataContractJsonSerializer(typeof(ListPostsModel));
                    var result = (ListPostsModel) serializer.ReadObject(stream.BaseStream);

                    return ExecutionResult<ListPostsModel>.Create(result);
                }
            }
            catch (Exception e)
            {
                return ExecutionResult<ListPostsModel>.CreateError(e);
            }
        }
    }
}