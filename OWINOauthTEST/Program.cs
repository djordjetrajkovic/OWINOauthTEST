using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OWINOauthTEST
{
    class Program
    {
        public static void Main(string[] args)
        {
            string hostUrl = "http://localhost:1234";
            using (WebApp.Start<Startup>(hostUrl))
            {
                System.Console.WriteLine(string.Format("Start listening at {0} ....", hostUrl));
                System.Console.ReadKey();
            }
        }
    }
}
