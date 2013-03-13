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
                                   Limit = 2
                               };

                var request = BuildRequest("https://disqus.com/api/3.0/users/listActivity.json", HttpMethod.GET, data);
                var response = (HttpWebResponse)request.GetResponse();

                using (var stream = new StreamReader(response.GetResponseStream()))
                {
                    var serializer = new DataContractJsonSerializer(typeof(ListPostsModel));
                    var result = serializer.ReadObject(stream.BaseStream) as ListPostsModel;

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

//public static T Deserialise<T>(string json) {
//  var obj = Activator.CreateInstance<T>();
//  using (var memoryStream = new MemoryStream(Encoding.Unicode.GetBytes(json))) {
//    var serializer = new DataContractJsonSerializer(obj.GetType());
//    obj = (T) serializer.ReadObject(memoryStream);
//    return obj;
//  }
//}
