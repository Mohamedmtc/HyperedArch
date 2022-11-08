﻿	

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
	/// An component type implementation of the 'CTR_MENU_ITEM' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class CtrMenuItemService : UMIS_VER2.CtrMenuItemServiceBase
	{
		#region Fields
		private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
		private static readonly bool noTranByDefault = false;
		#endregion
		
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the CtrMenuItemService class.
		/// </summary>
		public CtrMenuItemService() : base()
		{
		}
		#endregion Constructors

        public virtual DataTable GetMealItemDetails(System.Decimal _CTR_CDE_MEAL_ITEM_ID, System.Decimal _CTR_CDE_MEAL_ID)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetMealItemDetails");
            #endregion Security check

            #region Initialisation
            DataTable entity = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                entity = dataProvider.CtrMenuItemProvider.GetMealItemDetails(transactionManager, _CTR_CDE_MEAL_ITEM_ID,_CTR_CDE_MEAL_ID);
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

            return entity;
        }
		
	}//End Class

} // end namespace