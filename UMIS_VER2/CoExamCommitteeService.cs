	

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
	/// An component type implementation of the 'CO_EXAM_COMMITTEE' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class CoExamCommitteeService : UMIS_VER2.CoExamCommitteeServiceBase
	{
		#region Fields
		private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
		private static readonly bool noTranByDefault = false;
		#endregion
		
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the CoExamCommitteeService class.
		/// </summary>
		public CoExamCommitteeService() : base()
		{
		}
		#endregion Constructors
		
        /*----Task Status Details added by maha 01-6-2021   task 16756---*/
        public virtual DataTable ValidateExamCommitteChaneCapacity(decimal CoExamCommitteID)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("ValidateExamCommitteChaneCapacity");
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

                ReturnedTbl = dataProvider.CoExamCommitteeProvider.ValidateExamCommitteChaneCapacity(CoExamCommitteID);
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

        public virtual DataTable UpdateNextSeatFromTo(decimal CoExamCommitteID, decimal DifferanceCapacityVal)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("UpdateNextSeatFromTo");
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

                ReturnedTbl = dataProvider.CoExamCommitteeProvider.UpdateNextSeatFromTo(CoExamCommitteID ,DifferanceCapacityVal);
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
		
	}//End Class

} // end namespace
