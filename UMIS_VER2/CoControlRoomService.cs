	

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
	/// An component type implementation of the 'CO_CONTROL_ROOM' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class CoControlRoomService : UMIS_VER2.CoControlRoomServiceBase
	{
		#region Fields
		private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
		private static readonly bool noTranByDefault = false;
		#endregion
		
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the CoControlRoomService class.
		/// </summary>
		public CoControlRoomService() : base()
		{
		}
		#endregion Constructors

        #region Custom Methods
        
        public virtual bool InsertNewControlRoomWithHeadMember(System.Decimal _AsFacultyInfoId, System.Decimal _EntMainId, System.Decimal _EdCodeLevelId, System.Decimal _SaStfMemberId, System.Decimal _CoControlId, System.String _UserName, System.String _Password, System.String _SecretQuestion, System.String _SecretAnswer, System.Decimal _CreatorSeUserId, System.Decimal _ControlRoomHeadAccount)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("InsertNewControlRoomWithHeadMember");
            #endregion Security check

            #region Initialisation
            bool list = false;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.CoControlRoomProvider.InsertNewControlRoomWithHeadMember(transactionManager, _AsFacultyInfoId, _EntMainId, _EdCodeLevelId, _SaStfMemberId, _CoControlId, _UserName, _Password, _SecretQuestion, _SecretAnswer, _CreatorSeUserId, _ControlRoomHeadAccount);
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

        public virtual bool InsertNewControlRoomWithHeadMember(System.Decimal _AsFacultyInfoId, System.Decimal _EntMainId, System.Decimal _EdCodeLevelId, System.Decimal _SaStfMemberId, System.Decimal _CoControlId, System.Decimal _ControlRoomHeadAccount)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("InsertNewControlRoomWithHeadMember");
            #endregion Security check

            #region Initialisation
            bool list = false;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.CoControlRoomProvider.InsertNewControlRoomWithHeadMember(transactionManager, _AsFacultyInfoId, _EntMainId, _EdCodeLevelId, _SaStfMemberId, _CoControlId, _ControlRoomHeadAccount);
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

        public virtual bool UpdateControlRoom(System.Decimal _AsFacultyInfoId, System.Decimal _EntMainId, System.Decimal _EdCodeLevelId, System.Decimal _SaStfMemberId, System.Decimal _CoControlId, System.String _UserName, System.String _Password, System.String _SecretQuestion, System.String _SecretAnswer, System.Decimal _CreatorSeUserId, System.Decimal _ControlRoomHeadAccount, System.Decimal _ControlRoomId)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("UpdateControlRoom");
            #endregion Security check

            #region Initialisation
            bool list = false;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.CoControlRoomProvider.UpdateControlRoom(transactionManager, _AsFacultyInfoId, _EntMainId, _EdCodeLevelId, _SaStfMemberId, _CoControlId, _UserName, _Password, _SecretQuestion, _SecretAnswer, _CreatorSeUserId, _ControlRoomHeadAccount, _ControlRoomId);
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

        public virtual bool UpdateControlRoom(System.Decimal _AsFacultyInfoId, System.Decimal _EntMainId, System.Decimal _EdCodeLevelId, System.Decimal _SaStfMemberId, System.Decimal _CoControlId, System.Decimal _ControlRoomHeadAccount, System.Decimal _ControlRoomId)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("UpdateControlRoom");
            #endregion Security check

            #region Initialisation
            bool list = false;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.CoControlRoomProvider.UpdateControlRoom(transactionManager, _AsFacultyInfoId, _EntMainId, _EdCodeLevelId, _SaStfMemberId, _CoControlId, _ControlRoomHeadAccount, _ControlRoomId);
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

        public virtual bool DeleteControlRoomWithAllItsData(System.Decimal _ControlRoomId, System.Decimal _ControlRoomHeadAccount, System.Decimal _ControlRoomMemberAccount)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("DeleteControlRoomWithAllItsData");
            #endregion Security check

            #region Initialisation
            bool list = false;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.CoControlRoomProvider.DeleteControlRoomWithAllItsData(transactionManager, _ControlRoomId, _ControlRoomHeadAccount, _ControlRoomMemberAccount);
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

        public virtual bool InsertNewRoomMember(System.Decimal _CoControlRoomId, System.Decimal _SaStfMemberId, System.String _UserName, System.String _Password, System.String _SecretQuestion, System.String _SecretAnswer, System.Decimal _CreatorSeUserId, System.Decimal _ControlRoomMemberAccount, System.String _Notes)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("InsertNewRoomMember");
            #endregion Security check

            #region Initialisation
            bool list = false;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.CoControlRoomProvider.InsertNewRoomMember(transactionManager, _CoControlRoomId, _SaStfMemberId, _UserName, _Password, _SecretQuestion, _SecretAnswer, _CreatorSeUserId, _ControlRoomMemberAccount, _Notes);
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

        public virtual bool InsertNewRoomMember(System.Decimal _CoControlRoomId, System.Decimal _SaStfMemberId, System.Decimal _ControlRoomMemberAccount, System.String _Notes)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("InsertNewRoomMember");
            #endregion Security check

            #region Initialisation
            bool list = false;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.CoControlRoomProvider.InsertNewRoomMember(transactionManager, _CoControlRoomId, _SaStfMemberId, _ControlRoomMemberAccount, _Notes);
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
