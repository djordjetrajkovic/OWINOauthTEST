using Microsoft.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OWINOauthTEST
{
    internal class WelcomeMiddleware : OwinMiddleware
    {
        private readonly WelcomeOption welcomeOption;

        public WelcomeMiddleware(OwinMiddleware next, WelcomeOption option) : base(next)
        {
            welcomeOption = option;
        }

        public override async Task Invoke(IOwinContext context)
        {
            System.Console.WriteLine("Http request received at " + DateTime.UtcNow.ToString());
            await Next.Invoke(context);
            string welcome = string.Format("I am {0}. {1}{2}", welcomeOption.HostName, welcomeOption.Welcome, Environment.NewLine);
            await context.Response.WriteAsync(welcome).ConfigureAwait(false);
        }
    }
}
