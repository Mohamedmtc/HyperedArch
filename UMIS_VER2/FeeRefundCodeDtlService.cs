
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
	/// An component type implementation of the 'FEE_REFUND_CODE_DTL' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class FeeRefundCodeDtlService : UMIS_VER2.FeeRefundCodeDtlServiceBase
	{
		#region Fields
		private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
		private static readonly bool noTranByDefault = false;
		#endregion
		
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the FeeRefundCodeDtlService class.
		/// </summary>
		public FeeRefundCodeDtlService() : base()
		{
		}
		#endregion Constructors

        //added by mmq at 02-05-2017
        public virtual DataTable GetFeeRefundCodeDtlByFeeRefundCodeId_custum(decimal FeeRefundCodeId, string FeeType, decimal lang)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetFeeRefundCodeDtlByFeeRefundCodeId_custum");
            #endregion Security check

            #region Initialisation
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                return dataProvider.FeeRefundCodeDtlProvider.GetFeeRefundCodeDtlByFeeRefundCodeId_custum(transactionManager, FeeRefundCodeId, FeeType, lang);
            }
            catch (Exception exc)
            {
                #region Handle transaction rollback and exception
                if (transactionManager != null && transactionManager.IsOpen)
                    transactionManager.Rollback();

                //Handle exception based on policy
                if (DomainUtil.HandleException(exc, layerExceptionPolicy))
                    throw;
                #endregion Handle transaction rollback and exception
            }

            return null;
        }

        public virtual DataTable DeployRefundRule( decimal EdStudId, decimal facultyID, decimal edAcadYearId, decimal EdCodeSemesterId, decimal CurrentYear, decimal CurrentSemester, DateTime? ReqDate, decimal Lang, decimal FeeRefundReqId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("DeployRefundRule");
            #endregion Security check

            #region Initialisation
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                return dataProvider.FeeRefundCodeDtlProvider.DeployRefundRule(transactionManager, EdStudId,  facultyID,  edAcadYearId,  EdCodeSemesterId,  CurrentYear,  CurrentSemester,  ReqDate,  Lang,  FeeRefundReqId);
            }
            catch (Exception exc)
            {
                #region Handle transaction rollback and exception
                if (transactionManager != null && transactionManager.IsOpen)
                    transactionManager.Rollback();

                //Handle exception based on policy
                if (DomainUtil.HandleException(exc, layerExceptionPolicy))
                    throw;
                #endregion Handle transaction rollback and exception
            }

            return null;
        }
		
	}//End Class

} // end namespace
