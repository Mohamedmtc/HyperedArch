	

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
	/// An component type implementation of the 'ENT_POLICY_LOAD' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class EntPolicyLoadService : UMIS_VER2.EntPolicyLoadServiceBase
	{
        #region Fields
        private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
        private static readonly bool noTranByDefault = false;
        #endregion

        #region Constructors
		/// <summary>
		/// Initializes a new instance of the EntPolicyLoadService class.
		/// </summary>
		public EntPolicyLoadService() : base()
		{
		}
		#endregion Constructors

        #region Custom Methods
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual TList<EntPolicyLoad> GetByAsFacultyInfoId(decimal asFacultyInfoId, decimal edCodeSemesterTypeId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetByAsFacultyInfoId");
            #endregion Security check

            #region Initialisation
            TList<EntPolicyLoad> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.EntPolicyLoadProvider.GetByAsFacultyInfoId(transactionManager, asFacultyInfoId, edCodeSemesterTypeId);
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

        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual TList<EntPolicyLoad> GetByStudSemesterId(System.Decimal _StudSemesterId)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetByStudSemesterId");
            #endregion Security check

            #region Initialisation
            TList<EntPolicyLoad> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<EntPolicyLoad>(dataProvider.EntPolicyLoadProvider.GetByStudSemesterId(transactionManager, _StudSemesterId));
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

        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual TList<EntPolicyLoad> GetByStudSemesterId(System.Decimal _StudSemesterId, int start, int pageLength, out int totalCount)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetByStudSemesterId");
            #endregion Security check

            #region Initialisation
            totalCount = -1;
            TList<EntPolicyLoad> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<EntPolicyLoad>(dataProvider.EntPolicyLoadProvider.GetByStudSemesterId(transactionManager, _StudSemesterId, start, pageLength, out totalCount));
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
