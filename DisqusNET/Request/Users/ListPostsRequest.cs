using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.Serialization;
using DisqusNET.Model.Users;
using DisqusNET.Request.Users.Model;

namespace DisqusNET.Request.Users
{
    public class ListPostsRequest : BaseRequest
    {
        public static ExecutionResult<List<ListPostsModel>> Execute()
        {
            try
            {
                var data = new ListPostsRequestData
                               {
                                   AccessToken = DisqusOptions.GetInstance().AccessToken,
                                   Limit = 1
                               };

                var memoryStream = SerializeContentJson(data);
                var request = BuildRequest("https://disqus.com/api/3.0/users/listActivity.json", HttpMethod.GET, memoryStream);
                var response = (HttpWebResponse)request.GetResponse();

                using (var stream = new StreamReader(response.GetResponseStream()))
                {
                    var serializer = new DataContractSerializer(typeof(List<ListPostsModel>));
                    var result = (List<ListPostsModel>) serializer.ReadObject(stream.BaseStream);

                    return ExecutionResult<List<ListPostsModel>>.Create(result);
                }
            }
            catch (Exception e)
            {
                return ExecutionResult<List<ListPostsModel>>.CreateError(e);
            }
        }
    }
}