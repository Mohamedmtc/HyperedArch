

using Informatique.Base.Core.Messages;

namespace UMISHypered.WebAPI.EndPoints.AsCodeDegreeClassEndPoint
{
    public class GetAllDegreeClassEndPointRequest : BaseRequest
    {
        public const string Route = "/api/postgraduate/Search/GetAllDegreeClass/";

        /// <summary>
        /// the  id of execluding degree class
        /// </summary>
        ///<example>1</example>
        public int IdNotEqual { get; set; }

    }
}
