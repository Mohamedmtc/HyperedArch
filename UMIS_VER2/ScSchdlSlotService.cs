
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
	/// An component type implementation of the 'SC_SCHDL_SLOT' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class ScSchdlSlotService : UMIS_VER2.ScSchdlSlotServiceBase
	{
		#region Fields
		private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
		private static readonly bool noTranByDefault = false;
		#endregion
		
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the ScSchdlSlotService class.
		/// </summary>
		public ScSchdlSlotService() : base()
		{
		}
		#endregion Constructors
		
        /*--- copy from nub -- maha ---24-12-2020--- task 15565--*/
        public virtual TList<ScSchdlSlot> GetSchdlSlot(TransactionManager transactionManager, System.DateTime _DayDate, System.Decimal _ScTchngSlotId, System.Decimal _GsCodeWeekDayId, System.Decimal _ScGroupInfoId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetSchdlSlot");
            #endregion Security check

            #region Initialisation
            TList<ScSchdlSlot> list = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.ScSchdlSlotProvider.GetSchdlSlot(transactionManager, _DayDate, _ScTchngSlotId, _GsCodeWeekDayId, _ScGroupInfoId);
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

        public virtual DataTable GetSlotContent_Schdule(TransactionManager transactionManager, decimal _objSchdlSlotID)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetSlotContent_Schdule");
            #endregion Security check

            #region Initialisation
            DataTable list = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.ScSchdlSlotProvider.GetSlotContent_Schdule(transactionManager, _objSchdlSlotID);
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
        
    }//End Class

} // end namespace
