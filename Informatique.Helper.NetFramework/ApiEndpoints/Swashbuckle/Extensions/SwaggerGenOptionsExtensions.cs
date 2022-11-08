using Ardalis.ApiEndpoints;

using Swashbuckle.Application;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.Description;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class SwaggerGenOptionsExtensions
    {
        /// <summary>
        /// Updates Swagger document to support ApiEndpoints.<br/><br/>
        /// For controllers inherited from <see cref="EndpointBase"/>:<br/>
        /// - Replaces action Tag with <c>[namespace]</c><br/>
        /// </summary>
        public static void UseApiEndpoints(this SwaggerDocsConfig options)
        {
            options.GroupActionsBy(EndpointNamespaceOrDefaultGroup);
        }

        private static string EndpointNamespaceOrDefaultGroup(ApiDescription api)
        {
            if (api.ActionDescriptor.ControllerDescriptor.ControllerType.GetBaseTypesAndThis().Any(t => t == typeof(EndpointBase)))
            {
                return  api.ActionDescriptor.ControllerDescriptor.ControllerType.Namespace?.Split('.').Last() ;
            }

            return  api.ActionDescriptor.ControllerDescriptor.ControllerName ;
        }

        private static IList<string> EndpointNamespaceOrDefault(ApiDescription api)
        {

            if (api.ActionDescriptor.ControllerDescriptor.ControllerType.GetBaseTypesAndThis().Any(t => t == typeof(EndpointBase)))
            {
                return new[] { api.ActionDescriptor.ControllerDescriptor.ControllerType.Namespace?.Split('.').Last() };
            }

            return new[] { api.ActionDescriptor.ControllerDescriptor.ControllerName };
        }
    }
}
