using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OWINOauthTEST
{
    internal class WelcomeOption
    {
        public string HostName { get; set; }
        public string Welcome { get; set; }

        public WelcomeOption(string hostname, string welcome)
        {
            HostName = hostname;
            Welcome = welcome;
        }
    }
}
