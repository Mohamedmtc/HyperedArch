	

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
	/// An component type implementation of the 'SC_SCHDL_PERIOD' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class ScSchdlPeriodService : UMIS_VER2.ScSchdlPeriodServiceBase
	{
		#region Fields
		private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
		private static readonly bool noTranByDefault = false;
		#endregion
		
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the ScSchdlPeriodService class.
		/// </summary>
		public ScSchdlPeriodService() : base()
		{
		}
		#endregion Constructors

        /*--task 11634 -- copy from nub  task 15565*/
        public virtual DataTable GetScSchdlPeriodByCodeSem_Acadyear(decimal CodeSemstID, decimal AcadyearID)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetScSchdlPeriodByCodeSem_Acadyear");
            #endregion Security check
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            DataTable dtScSchdlePeriod = new DataTable();
            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                dtScSchdlePeriod = dataProvider.ScSchdlPeriodProvider.GetScSchdlPeriodByCodeSem_Acadyear(transactionManager, CodeSemstID, AcadyearID);
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
            return dtScSchdlePeriod;
        }
        /* -- copy from nub  task 15565 --- maha */
        public virtual DataTable SelectAllDaysbySchedlePeriod(decimal schdulePeriodID)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("SelectAllDaysbySchedlePeriod");
            #endregion Security check
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            DataTable dtScSchdlePeriod = new DataTable();
            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                dtScSchdlePeriod = dataProvider.ScSchdlPeriodProvider.SelectAllDaysbySchedlePeriod(transactionManager, schdulePeriodID);
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
            return dtScSchdlePeriod;
        }
		
	}//End Class

} // end namespace
