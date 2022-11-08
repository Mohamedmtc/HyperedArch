using Ardalis.ApiEndpoints;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;
using Informatique.Base.Core.Messages;
using System;
using Swashbuckle.Swagger.Annotations;


namespace TestWebApi.EndPoints
{
    [Authorize]
    public class AtiaController : EndpointBaseAsync
    .WithRequest<GetAllDegreeClassEndPointRequest>
    .WithActionResult<GetAllDegreeClassEndPointResponse>
    {
        [HttpGet]
        [SwaggerOperation( OperationId = "Search.GetAllDegreeClass",Tags = new[] { "Search" })]
        [System.Web.Http.Route(GetAllDegreeClassEndPointRequest.Route)]
        public override async Task<IHttpActionResult> HandleAsync(GetAllDegreeClassEndPointRequest request, CancellationToken cancellationToken = default)
        {
            GetAllDegreeClassEndPointResponse output = new GetAllDegreeClassEndPointResponse();

            output.result = "hi";
            await Task.CompletedTask;
            return Ok(output);
        }
    }
    public class GetAllDegreeClassEndPointResponse : BaseResponse
    {
        public GetAllDegreeClassEndPointResponse() { }
        public GetAllDegreeClassEndPointResponse(Guid correlationId) : base(correlationId) { }

        public string result { get; set; }
    }

    public class AscodeDegreeClassObject
    {
        public decimal AsCodeDegreeClassId { get; set; }
        public string ClassDescrEn { get; set; }
        public string ClassDescrAr { get; set; }
    }
    public class GetAllDegreeClassEndPointRequest : BaseRequest
    {
        public const string Route = "api/course/Search/GetAllDegreeClass/";
    }
}
