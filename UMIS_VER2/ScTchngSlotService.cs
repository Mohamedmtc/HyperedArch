	

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
using System.Security;

#endregion

namespace UMIS_VER2
{		
	/// <summary>
	/// An component type implementation of the 'SC_TCHNG_SLOT' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class ScTchngSlotService : UMIS_VER2.ScTchngSlotServiceBase
	{
        #region Fields
        private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
        private static readonly bool noTranByDefault = false;
        #endregion

        #region Constructors
		/// <summary>
		/// Initializes a new instance of the ScTchngSlotService class.
		/// </summary>
		public ScTchngSlotService() : base()
		{
		}
		#endregion Constructors

        #region Custom Methods

        public virtual DataTable IfSlotReserved(System.Decimal edAcadYearId, System.Decimal edCodeSemesterId, System.Decimal ScTchngSlotId)
        {
            #region Security check
            SecurityContext.IsAuthorized("IfSlotReserved");
            #endregion Security check

            #region Initialisation
            DataTable list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.ScTchngSlotProvider.IfSlotReserved(transactionManager, edAcadYearId, edCodeSemesterId, ScTchngSlotId);
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
            return list;
        }
        //Marwa 14/2/2022  
        public virtual DataTable IfSlotReservedForModular( System.Decimal ScTchngSlotId)
        {
            #region Security check
            SecurityContext.IsAuthorized("IfSlotReservedForModular");
            #endregion Security check

            #region Initialisation
            DataTable list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.ScTchngSlotProvider.IfSlotReservedForModular(transactionManager, ScTchngSlotId);
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
            return list;
        }

        /// <summary>
        /// Get Time Slotes for Day of week in selected Teaching Day
        /// </summary>
        /// <param name="_scTchngDayId">Teaching Day</param>
        /// <param name="_isActive">-1 for All</param>
        /// <param name="_examFlg">-1 for All</param>
        public virtual DataTable GetSlotes(System.Decimal _scTchngDayId, System.Decimal _isActive, System.Decimal _examFlg)
        {
            #region Security check
            SecurityContext.IsAuthorized("GetSlotes");
            #endregion Security check

            #region Initialisation
            DataTable list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.ScTchngSlotProvider.GetSlotes(transactionManager, _scTchngDayId, _isActive, _examFlg);
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
            return list;
        }
        


        #endregion

	}//End Class

} // end namespace
