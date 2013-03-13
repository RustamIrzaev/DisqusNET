using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DisqusNET.Request.Users;

namespace TestLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            DisqusNET.DisqusOptions.GetInstance().AccessToken = "";
            DisqusNET.DisqusOptions.GetInstance().ApiKey = "";
            ListPostsRequest.Execute();
        }
    }
}