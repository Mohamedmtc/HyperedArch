using Ardalis.ApiEndpoints;
using NSwag.Generation;
using NSwag.Generation.Processors;
using NSwag.Generation.Processors.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class NSwagSwaggerGeneratorSettingsExtensions
    {
        /// <summary>
        /// Updates Swagger document to support ApiEndpoints.<br/><br/>
        /// For controllers inherited from <see cref="EndpointBase"/>:<br/>
        /// - Replaces action Tag with <c>[namespace]</c><br/>
        /// - Replaces action OperationId with <c>[namespace]_[controller]</c>
        /// </summary>
        public static void UseApiEndpoints(this OpenApiDocumentGeneratorSettings settings)
        {
            settings.OperationProcessors.Add(new EndpointsOperationProcessor());
        }

        private class EndpointsOperationProcessor : IOperationProcessor
        {
            public bool Process(OperationProcessorContext context)
            {
                if (context.ControllerType.GetBaseTypesAndThis().Any(t => t == typeof(EndpointBase)))
                {
                    var namespaceValue = context.ControllerType.Namespace?.Split('.').Last();

                    context.OperationDescription.Operation.Tags = new List<string> { namespaceValue };
                    context.OperationDescription.Operation.OperationId = $"{namespaceValue}_{context.ControllerType.Name}";
                }

                return true;
            }

        }
    }
}
