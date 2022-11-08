using System.Text;
using System.Web.Configuration;
using System.Web.Http;
using Informatique.Base.NetFrameWork.Core.AppSettings;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Jwt;
using Owin;
using TestWebApi.App_Start;
using AuthenticationMode = Microsoft.Owin.Security.AuthenticationMode;

[assembly: OwinStartup(typeof(TestWebApi.Startup))]

namespace TestWebApi
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //MessageBusConfig.Configure();
            ///////////////////////////////////
            HttpConfiguration config = new HttpConfiguration();
            WebApiConfig.Register(config); // bootstrap your existing WebApi config 
            AuthenticationAppSetting authenticationAppSetting = WebConfigurationManager.GetSection("AuthenticationAppSetting") as AuthenticationAppSetting;
            app.UseJwtBearerAuthentication(new JwtBearerAuthenticationOptions
            {
                AuthenticationMode = AuthenticationMode.Active,
                TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateIssuerSigningKey = true, // I guess you don't even have to sign the token
                    ValidIssuer = "http://localhost",
                    ValidAudience = "http://localhost",
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(authenticationAppSetting.Jwt.secretKey))
                }
            });
            app.UseWebApi(config); // instruct OWIN to take over
        }
    }
}
