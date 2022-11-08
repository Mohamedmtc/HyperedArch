
#region Using Directives
using System;
using System.ComponentModel;
using System.Collections;
using System.Xml.Serialization;
using System.Data;

using UMIS_VER2.BusinessLyer;
using UMIS_VER2.BusinessLyer.Validation;

using UMIS_VER2.AccessLayer;
using Microsoft.Practices.EnterpriseLibrary.Logging;
using UMIS_VER2.AccessLayer.Bases;

#endregion

namespace UMIS_VER2
{		
	/// <summary>
	/// An component type implementation of the 'FEE_REFND_STD_REQ' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class FeeRefndStdReqService : UMIS_VER2.FeeRefndStdReqServiceBase
	{
		#region Fields
		private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
		private static readonly bool noTranByDefault = false;
		#endregion


        public virtual DataTable GetStudentRefendReq(decimal? SemesterID, decimal? AsFacultyInfoID, decimal? EdAcadYearID, int? GsCodeReqStatusID, DateTime? FromDate, DateTime? ToDate, bool? Canceled, string StudentCode, string ApplicantCode, int IsApplicant,int? ApplicantID,int?UserId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetByStudent");
            #endregion Security check
            NetTiersProvider dataProvider = null;
            dataProvider = ConnectionScope.Current.DataProvider;
            return dataProvider.FeeRefndStdReqProvider.GetStudentRefendReq(SemesterID, AsFacultyInfoID, EdAcadYearID, GsCodeReqStatusID, FromDate, ToDate, Canceled, StudentCode, ApplicantCode, IsApplicant, ApplicantID,UserId);
        }

        public virtual DataTable GetAdmAppFeesForCurrentSemsterRef(decimal AdmApplicantId )
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetByStudent");
            #endregion Security check
            NetTiersProvider dataProvider = null;
            dataProvider = ConnectionScope.Current.DataProvider;
            return dataProvider.FeeRefndStdReqProvider.GetAdmAppFeesForCurrentSemsterRef(AdmApplicantId);
        }

  


		#region Constructors
		/// <summary>
		/// Initializes a new instance of the FeeRefndStdReqService class.
		/// </summary>
		public FeeRefndStdReqService() : base()
		{
		}
		#endregion Constructors
		
	}//End Class

} // end namespace
