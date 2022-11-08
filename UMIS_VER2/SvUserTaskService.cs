
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
	/// An component type implementation of the 'SV_USER_TASK' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class SvUserTaskService : UMIS_VER2.SvUserTaskServiceBase
	{
		#region Fields
		private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
		private static readonly bool noTranByDefault = false;
		#endregion
		
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the SvUserTaskService class.
		/// </summary>
		public SvUserTaskService() : base()
		{
		}
		#endregion Constructors

        /*---custom Method --added by maha 21-8-2019   task 10817--*/
        public virtual DataTable GetUserTasksData( UMIS_VER2.BusinessLyer.SvUserTask obj, string FromDate, string ToDate)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetUserTasksData");
            #endregion Security check

            #region Initialisation
            DataTable  ReturnedTbl = new DataTable();
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                ReturnedTbl = dataProvider.SvUserTaskProvider.GetUserTasksData(obj, FromDate, ToDate);
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

            return ReturnedTbl;
        }
        /*----Task Status Details added by maha 25-8-2019   task 10817---*/
        public virtual DataTable GetUserTasksDetails(decimal ID , int Lang)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetUserTasksDetails");
            #endregion Security check

            #region Initialisation
            DataTable ReturnedTbl = new DataTable();
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                ReturnedTbl = dataProvider.SvUserTaskProvider.GetUserTaskDetails(ID, Lang);
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

            return ReturnedTbl;
        }
        /*----end---*/
	}//End Class

} // end namespace
