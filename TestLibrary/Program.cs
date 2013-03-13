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
            DisqusNET.DisqusOptions.GetInstance().AccessToken = "10972df3afee436dba59073007dd8d0d";
            DisqusNET.DisqusOptions.GetInstance().ApiKey = "dOtKPN9iTb1jSHWrtIjjoc7utOeJC2sblUkoYDFTt2po21LsuffcnexTWeHNZWSg";
            ListPostsRequest.Execute();
        }
    }
}