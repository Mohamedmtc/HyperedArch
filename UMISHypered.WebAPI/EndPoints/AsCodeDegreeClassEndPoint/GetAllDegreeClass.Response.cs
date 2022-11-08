
using Informatique.Base.Core.Messages;
using System;
using System.Collections.Generic;

namespace UMISHypered.WebAPI.EndPoints.AsCodeDegreeClassEndPoint
{
    public class GetAllDegreeClassEndPointResponse : BaseResponse
    {
        public GetAllDegreeClassEndPointResponse() { }
        public GetAllDegreeClassEndPointResponse(Guid correlationId) : base(correlationId) { }

        public List<AscodeDegreeClassObject> result { get; set; }
    }

    public class AscodeDegreeClassObject
    {
        public decimal AsCodeDegreeClassId { get; set; }
        public string ClassDescrEn { get; set; }
        public string ClassDescrAr { get; set; }
    }
}
