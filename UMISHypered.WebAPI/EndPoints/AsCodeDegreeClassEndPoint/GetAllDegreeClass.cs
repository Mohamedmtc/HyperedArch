using Ardalis.ApiEndpoints;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;
using UMIS_VER2.AccessLayer.Bases;
using UMIS_VER2.AccessLayer;
using UMIS_VER2.BusinessLyer;
using UMIS_VER2.AccessLayer.Bases;
using UMIS_VER2.AccessLayer;
using UMIS_VER2.BusinessLyer;
using System.Web.Mvc;
using System.Linq;

namespace UMISHypered.WebAPI.EndPoints.AsCodeDegreeClassEndPoint
{
    public class GetAllDegreeClassEndPoint : EndpointBaseAsync
    .WithRequest<GetAllDegreeClassEndPointRequest>
    .WithActionResult<GetAllDegreeClassEndPointResponse>
    {

        public GetAllDegreeClassEndPoint()
        {


        }

        public override async Task<IHttpActionResult> HandleAsync(GetAllDegreeClassEndPointRequest request, CancellationToken cancellationToken = default)
        {
            GetAllDegreeClassEndPointResponse output = new GetAllDegreeClassEndPointResponse();
            AsCodeDegreeClassParameterBuilder objAsCodeDegreeClassParameterBuilder = new AsCodeDegreeClassParameterBuilder();
            TList<AsCodeDegreeClass> lstAsCodeDegreeClass = DataRepository.AsCodeDegreeClassProvider.Find(objAsCodeDegreeClassParameterBuilder.GetParameters());
            output.result = lstAsCodeDegreeClass.Select(o => new AscodeDegreeClassObject
            {
                AsCodeDegreeClassId = o.AsCodeDegreeClassId,
                ClassDescrEn = o.ClassDescrEn,
                ClassDescrAr = o.ClassDescrAr
            }).ToList();
            return Ok(output);
        }
    }
}
