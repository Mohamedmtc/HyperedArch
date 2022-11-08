using Ardalis.ApiEndpoints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Description;

namespace TestWebApi.App_Start
{
    public static class SwaggerExtension
    {
        public static string EndpointNamespaceOrDefaultGroup(ApiDescription api)
        {
            if (api.ActionDescriptor.ControllerDescriptor.ControllerType.GetBaseTypesAndThis().Any(t => t == typeof(EndpointBase)))
            {
                return api.ActionDescriptor.ControllerDescriptor.ControllerType.Namespace?.Split('.').Last();
            }

            return api.ActionDescriptor.ControllerDescriptor.ControllerName;
        }
    }
}