	

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
	/// An component type implementation of the 'ED_STUD_TRANS_FROM_REQ' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class EdStudTransFromReqService : UMIS_VER2.EdStudTransFromReqServiceBase
	{
        #region Fields
        private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
        private static readonly bool noTranByDefault = false;
        #endregion

        #region Constructors
		/// <summary>
		/// Initializes a new instance of the EdStudTransFromReqService class.
		/// </summary>
		public EdStudTransFromReqService() : base()
		{
		}
		#endregion Constructors

        #region Custom Methods
        public virtual DataTable GetTransferFromFacultyRequests(decimal asFacultyInfoId, decimal edAcadYearId, decimal edCodeSemesterId, decimal gsCodeReqStatusId,
           DateTime? reqFromDate, DateTime? reqToDate, decimal asCodeDegreeId)
        {

            #region Security and validation check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetTransferFromFacultyRequests");


            #endregion Security and validation check

            #region Initialisation
            DataTable TransferFromFacultyRequests = null;
            bool isBorrowedTransaction = false;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider;
            #endregion Initialisation

            try
            {
                isBorrowedTransaction = ConnectionScope.Current.HasTransaction;
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                TransferFromFacultyRequests = dataProvider.EdStudTransFromReqProvider.GetTransferFromFacultyRequests(transactionManager,asFacultyInfoId, edAcadYearId, edCodeSemesterId,
                    gsCodeReqStatusId, reqFromDate, reqToDate, asCodeDegreeId);

                if (!isBorrowedTransaction && transactionManager != null && transactionManager.IsOpen)
                    transactionManager.Commit();
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

            return TransferFromFacultyRequests;
        }
        #endregion

	}//End Class

} // end namespace
