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
	/// An component type implementation of the 'ENT_CODE_ENTITY_TYPE' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class EntCodeEntityTypeService : UMIS_VER2.EntCodeEntityTypeServiceBase
	{
        #region Fields
        private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
        private static readonly bool noTranByDefault = false;
        #endregion

        #region Constructors
		/// <summary>
		/// Initializes a new instance of the EntCodeEntityTypeService class.
		/// </summary>
		public EntCodeEntityTypeService() : base()
		{
		}
		#endregion Constructors

        #region Custom Methods
        public virtual TList<EntCodeEntityType> GetEntityTypeChildes(System.Decimal _entCodeEntityTypeId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetEntityTypeChildes");
            #endregion Security check

            #region Initialisation
            TList<EntCodeEntityType> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.EntCodeEntityTypeProvider.GetEntityTypeChildes(transactionManager, _entCodeEntityTypeId);
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

        public virtual TList<EntCodeEntityType> GetEntityTypeChildes(System.Decimal _entCodeEntityTypeId, int start, int pageLength, out int totalCount)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetEntityTypeChildes");
            #endregion Security check

            #region Initialisation
            totalCount = -1;
            TList<EntCodeEntityType> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.EntCodeEntityTypeProvider.GetEntityTypeChildes(transactionManager, _entCodeEntityTypeId, start, pageLength, out totalCount);
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