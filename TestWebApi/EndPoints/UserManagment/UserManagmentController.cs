using Ardalis.ApiEndpoints;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;


using System.Web.Mvc;
using System.Linq;
using Informatique.Base.Core.Messages;
using System.Collections.Generic;
using System;
using Swashbuckle.Swagger;
using Swashbuckle.Swagger.Annotations;
using System.Web.UI.WebControls;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Web.Configuration;
using Informatique.Base.NetFrameWork.Core.AppSettings;
using Informatique.Base.NetFrameWork.MicroService;

namespace TestWebApi.EndPoints.UserManagment
{
    public class UserManagmentController : EndpointBaseAsync
    .WithRequest<UserManagmentRequest>
    .WithActionResult<string>
    {
        AuthenticationAppSetting authenticationAppSetting= WebConfigurationManager.GetSection("AuthenticationAppSetting") as AuthenticationAppSetting;

        [System.Web.Http.Route(UserManagmentRequest.Route)]

        [SwaggerOperation(OperationId = "Search.GetAllDegreeClass", Tags = new[] { "UserManagment" })]
        public override async Task<IHttpActionResult> HandleAsync(UserManagmentRequest request, CancellationToken cancellationToken = default)
        {
            //WebApiApplication.ApplicationBus.Publish<IProduceTestMessage>(new { Id = 5 });
            string key = authenticationAppSetting.Jwt.secretKey;

           
            var issuer = "http://localhost";

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(authenticationAppSetting.Jwt.secretKey));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var permClaims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim("valid", "1"),
                new Claim("userid", "1"),
                new Claim("name", "test")
            };

            var token = new JwtSecurityToken(issuer,
                issuer,
                permClaims,
                expires: DateTime.Now.AddMinutes(authenticationAppSetting.Jwt.expiryMinutes),
                signingCredentials: credentials);
            var output= new JwtSecurityTokenHandler().WriteToken(token);
            return Ok(output);
        }

        
    }
    
    public class UserManagmentRequest : BaseRequest
    {
        public const string Route = "api/course/usermanagment/login/";
    }
}
