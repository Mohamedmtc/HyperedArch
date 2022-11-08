using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UMIS_VER2.AccessLayer.Bases;
using UMIS_VER2.AccessLayer;
using UMIS_VER2.BusinessLyer;

namespace TestWebApi.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public object Get()
        {
            TList<AsCodeDegreeClass> lstAsCodeDegreeClass = new TList<AsCodeDegreeClass>();
            AsCodeDegreeClassParameterBuilder objAsCodeDegreeClassParameterBuilder = new AsCodeDegreeClassParameterBuilder();
            lstAsCodeDegreeClass = DataRepository.AsCodeDegreeClassProvider.Find(objAsCodeDegreeClassParameterBuilder.GetParameters());
            return lstAsCodeDegreeClass.Select(o => new { o.AsCodeDegreeClassId, o.ClassDescrEn, o.ClassDescrAr }).ToList();
        }
    }
}
