
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
	/// An component type implementation of the 'ED_STUD_EXMPT_REQ' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class EdStudExmptReqService : UMIS_VER2.EdStudExmptReqServiceBase
	{
		#region Fields
		private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
		private static readonly bool noTranByDefault = false;
		#endregion
		
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the EdStudExmptReqService class.
		/// </summary>
		public EdStudExmptReqService() : base()
		{
		}
		#endregion Constructors


        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual DataTable GetStudExemption(System.Decimal EdAcadYearID, System.Decimal EdCodeSemesterId, System.DateTime? ReqDateFrom, System.DateTime? ReqDateTo, System.Decimal AsFacultyInfoId, System.Int32 ApproveFlg, System.Decimal EdStudId, System.Decimal ED_CDE_EXMPT_Id)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStudExemption");
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

                dt = dataProvider.EdStudExmptReqProvider.GetStudExemption(transactionManager, EdAcadYearID, EdCodeSemesterId, ReqDateFrom, ReqDateTo, AsFacultyInfoId, ApproveFlg, EdStudId, ED_CDE_EXMPT_Id);
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
            return dt;
        }
	}//End Class

} // end namespace
