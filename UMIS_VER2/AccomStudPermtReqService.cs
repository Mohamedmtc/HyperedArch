
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
	/// An component type implementation of the 'ACCOM_STUD_PERMT_REQ' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class AccomStudPermtReqService : UMIS_VER2.AccomStudPermtReqServiceBase
	{
		#region Fields
		private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
		private static readonly bool noTranByDefault = false;
		#endregion
		
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the AccomStudPermtReqService class.
		/// </summary>
		public AccomStudPermtReqService() : base()
		{
		}
		#endregion Constructors
        #region Methods
        public DataTable GetAccomStudPermtRequests(decimal AcadYearID, decimal SemesterID,Decimal AsFacultyinfoId,decimal DegreeId,decimal MajorId, decimal MinorId,decimal levelId,string StudName,decimal LangNum, decimal NamePolicy, string StudCode,int CodeReqState ,int RequestType) 

        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetAccomStudPermtRequests");
            #endregion Security check

            #region Initialisation
            DataTable dt = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                dt = dataProvider.AccomStudPermtReqProvider.GetAccomStudPermtRequests(AcadYearID, SemesterID, AsFacultyinfoId, DegreeId, MajorId, MinorId, levelId, StudName, LangNum, NamePolicy, StudCode, CodeReqState, RequestType);
            }
            catch (Exception exc)
            {
                #region Handle transaction rollback and exception
                if (transactionManager != null && transactionManager.IsOpen)
                    transactionManager.Rollback();

                if (DomainUtil.HandleException(exc, layerExceptionPolicy))
                    throw;
                #endregion Handle transaction rollback and exception
            }
            return dt;

        }
        #endregion

    }//End Class

} // end namespace
