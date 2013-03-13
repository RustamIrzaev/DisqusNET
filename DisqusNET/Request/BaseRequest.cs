using System.IO;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Xml;
using System.Xml.Serialization;

namespace DisqusNET.Request
{
    public class BaseRequest
    {
        public enum HttpMethod { POST, GET };

        public static HttpWebRequest BuildRequest(string url, HttpMethod method)
        {
            return BuildRequest<object>(url, method);
        }

        public static HttpWebRequest BuildRequest<T>(string url, HttpMethod httpMethod, T data = default(T))
        {
            url += "?" + data.ToQueryString();

            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = httpMethod.ToString();
            request.ContentType = "application/json";

            return request;
        }

        public static MemoryStream SerializeContentXml<T>(T container) where T : class
        {
            var memoryStream = new MemoryStream();
            var xmlTextWriter = new XmlTextWriter(memoryStream, null);

            var namespaces = new XmlSerializerNamespaces();
            namespaces.Add("", "");

            var serializer = new XmlSerializer(typeof(T));
            serializer.Serialize(xmlTextWriter, container, namespaces);

            memoryStream.Seek(0, SeekOrigin.Begin);

            return memoryStream;
        }

        public static MemoryStream SerializeContentJson<T>(T container) where T : class
        {
            var memoryStream = new MemoryStream();

            var serializer = new DataContractJsonSerializer(typeof(T));
            serializer.WriteObject(memoryStream, container);

            memoryStream.Seek(0, SeekOrigin.Begin);

            return memoryStream;
        }
    }
}