	

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
	/// An component type implementation of the 'SE_USER' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class SeUserService : UMIS_VER2.SeUserServiceBase
	{
		#region Fields
		private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
		private static readonly bool noTranByDefault = false;
		#endregion
		
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the SeUserService class.
		/// </summary>
		public SeUserService() : base()
		{
		}
		#endregion Constructors
        //public virtual decimal InsertGetID(UMIS_VER2.BusinessLyer.SeUser seUser)
        //{
        //    #region Security check
        //    // throws security exception if not authorized
        //    SecurityContext.IsAuthorized("GetByUNandPWD");
        //    #endregion Security check

        //    #region Initialisation
        //    decimal entity = 0;
        //    TransactionManager transactionManager = null;
        //    NetTiersProvider dataProvider = null;
        //    #endregion Initialisation

        //    try
        //    {
        //        transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
        //        dataProvider = ConnectionScope.Current.DataProvider;

        //        entity = dataProvider.SeUserProvider.InsertGetID(transactionManager, seUser);
        //    }
        //    catch (Exception exc)
        //    {
        //        #region Handle transaction rollback and exception
        //        if (transactionManager != null && transactionManager.IsOpen)
        //            transactionManager.Rollback();

        //        //Handle exception based on policy
        //        if (DomainUtil.HandleException(exc, layerExceptionPolicy))
        //            throw;
        //        #endregion Handle transaction rollback and exception
        //    }

        //    return entity;
        //}

        public virtual DataTable GetByUNandPWD(System.String _UserName, System.String _Password)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetByUNandPWD");
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

                entity = dataProvider.SeUserProvider.GetByUNandPWD(transactionManager, _UserName,_Password);
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

        public virtual DataTable GetUserAccounts(System.Decimal _SeUserId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetUserAccounts");
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

                entity = dataProvider.SeUserProvider.GetUserAccounts(transactionManager, _SeUserId);
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

        public virtual DataTable GetSystemUsers(System.String UserNameEn, string UserNameAr, string AdUserName, decimal SeCodeUserTypeId, decimal SeCodeUserPlaceId, decimal SeCodeUserJobId, decimal PageIndex, decimal PageSize, decimal? ASFACULTYINFOID, decimal? SystemUserStatus)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetSystemUsers");
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

                entity = dataProvider.SeUserProvider.GetSystemUsers(transactionManager, UserNameEn, UserNameAr, AdUserName, SeCodeUserTypeId, SeCodeUserPlaceId, SeCodeUserJobId, PageIndex, PageSize, ASFACULTYINFOID, SystemUserStatus);
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="IsActive"></param>
        /// <returns></returns>
        public virtual DataTable GetUsersByStatus(System.Decimal IsActive)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetUsersByStatus");
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

                entity = dataProvider.SeUserProvider.GetUsersByStatus(transactionManager, IsActive);
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
        public virtual DataTable GetAccountsByUserID(System.Decimal UserID)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetAccountsByUserID");
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

                entity = dataProvider.SeUserProvider.GetAccountsByUserID(transactionManager, UserID);
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
