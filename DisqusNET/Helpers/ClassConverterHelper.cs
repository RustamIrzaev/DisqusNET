using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DisqusNET.Helpers
{
    public static class ClassConverterHelper
    {
        public static string FromClassToString(this object @object)
        {
            if (@object == null)
                throw new ArgumentNullException("object");

            return "";
        }
    }
}