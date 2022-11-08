//using AutoMapper;
//using Informatique.Base.Core.Messages;
//using Informatique.SIS.EntityManagement.Application.Business.Search.Query;
//using Microsoft.AspNetCore.Mvc;

//namespace Informatique.SIS.EntityManagement.WebApi.EndPoints.Search.Query
//{
//    public class GetAllDegreeClassMapper : Profile
//    {
//        public GetAllDegreeClassMapper()
//        {
//            CreateMap<GetAllDegreeClassEndPointRequest, GetAllDegreeClassHandlerInput>()
//                .ConstructUsing(src => new GetAllDegreeClassHandlerInput(src.CorrelationId()));
//            CreateMap<GetAllDegreeClassHandlerOutput, GetAllDegreeClassEndPointResponse>()
//               .ConstructUsing(src => new GetAllDegreeClassEndPointResponse(src.CorrelationId()));
//        }

//    }
//}
