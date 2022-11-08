	

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
	/// An component type implementation of the 'SE_FORM' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class SeFormService : UMIS_VER2.SeFormServiceBase
	{
		#region Fields
		private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
		private static readonly bool noTranByDefault = false;
		#endregion
		
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the SeFormService class.
		/// </summary>
		public SeFormService() : base()
		{
		}
		#endregion Constructors

        #region Custom Methods

        public virtual TList<SeForm> GetBySeModuleId_AllForms(System.Decimal _seModuleId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetBySeModuleId_AllForms");
            #endregion Security check

            #region Initialisation
            TList<SeForm> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.SeFormProvider.GetBySeModuleId_AllForms(transactionManager, _seModuleId);
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


        public virtual TList<SeForm> GetSeform_ForUser(System.Decimal _seModuleId, System.Decimal _SeAccnt)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetBySeModuleId_AllForms");
            #endregion Security check

            #region Initialisation
            TList<SeForm> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.SeFormProvider.GetSeform_ForUser(transactionManager, _seModuleId, _SeAccnt);
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
