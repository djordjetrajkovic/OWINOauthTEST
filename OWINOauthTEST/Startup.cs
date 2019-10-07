using Microsoft.Owin.Security.OAuth;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OWINOauthTEST
{
    internal class Startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            ConfigureAuth(appBuilder);
            appBuilder.
                UseWelcome();
        }

        private void ConfigureAuth(IAppBuilder app)
        {
            var OAuthOptions = new OAuthAuthorizationServerOptions
            {
                TokenEndpointPath = new Microsoft.Owin.PathString("/Token"),
                Provider = new MyOAuthAuthorizationServerProvider(),
                AccessTokenExpireTimeSpan = TimeSpan.FromHours(12),
                AllowInsecureHttp = true
            };

            var oauthConfig = new OAuthBearerAuthenticationOptions
            {
                AuthenticationMode = Microsoft.Owin.Security.AuthenticationMode.Active,
                AuthenticationType = "Bearer"
            };

            app.UseOAuthAuthorizationServer(OAuthOptions);
            app.UseOAuthBearerAuthentication(oauthConfig);
        }
    }
}
