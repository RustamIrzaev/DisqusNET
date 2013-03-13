using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace DisqusNET
{
    public static class UrlHelper
    {
        public static string ToQueryString(this object @object, string separator = ",")
        {
            if (@object == null)
                throw new ArgumentNullException("object");

            var properties = new Dictionary<string, string>();
            foreach (var property in @object.GetType().GetProperties())
            {
                if (property.CanRead && property.GetValue(@object, null) != null)
                {
                    var attributes = property.GetCustomAttributes(typeof(DataMemberAttribute), false);
                    if (attributes.Any())
                    {
                        properties.Add((attributes[0] as DataMemberAttribute).Name, property.GetValue(@object, null).ToString());
                    }
                    else
                    {
                        properties.Add(property.Name, property.GetValue(@object, null).ToString());
                    }
                }
            }

            var propertyNames = properties
                .Where(x => !(x.Value is string) && x.Value is IEnumerable)
                .Select(x => x.Key)
                .ToList();

            foreach (var key in propertyNames)
            {
                var valueType = properties[key].GetType();
                var valueElemType = valueType.IsGenericType
                                        ? valueType.GetGenericArguments()[0]
                                        : valueType.GetElementType();
                if (valueElemType.IsPrimitive || valueElemType == typeof(string))
                {
                    var enumerable = properties[key] as IEnumerable;
                    properties[key] = string.Join(separator, enumerable.Cast<object>());
                }
            }

            return string.Join("&", properties
                .Select(x => string.Concat(
                    Uri.EscapeDataString(x.Key), "=",
                    Uri.EscapeDataString(x.Value.ToString()))));
        }
    }
}