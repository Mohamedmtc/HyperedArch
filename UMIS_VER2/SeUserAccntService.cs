	

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
	/// An component type implementation of the 'SE_USER_ACCNT' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class SeUserAccntService : UMIS_VER2.SeUserAccntServiceBase
	{
		#region Fields
		private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
		private static readonly bool noTranByDefault = false;
		#endregion
		
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the SeUserAccntService class.
		/// </summary>
		public SeUserAccntService() : base()
		{
		}
		#endregion Constructors
        #region Custom Methods
       
        public virtual decimal insertDateTimeforUserAccunt(SeUserAccnt objSeUserAccnt)
        {
            #region Security and validation check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("insertDateTimeforUserAccunt");

            if (!objSeUserAccnt.IsValid)
                throw new EntityNotValidException(objSeUserAccnt, "insertDateTimeforUserAccunt", objSeUserAccnt.Error);
            #endregion Security and validation check

            #region Initialisation
            decimal result = 0;
            bool isBorrowedTransaction = false;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider;
            #endregion Initialisation

            try
            {
                isBorrowedTransaction = ConnectionScope.Current.HasTransaction;
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                result = dataProvider.SeUserAccntProvider.insertDateTimeforUserAccunt(transactionManager, objSeUserAccnt);

                if (!isBorrowedTransaction && transactionManager != null && transactionManager.IsOpen)
                    transactionManager.Commit();
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

            return result;
        }

        public virtual TList<SeUserAccnt> GetSeUserAccountIdByUserTypeAndUserTableId( System.Decimal _UserType, System.Decimal _SeUserId, System.Decimal _UserTableId)
        {
            #region Security and validation check
            // throws security exception if not authorized
            //SecurityContext.IsAuthorized("insertDateTimeforUserAccunt");

            //if (!objSeUserAccnt.IsValid)
            //    throw new EntityNotValidException(objSeUserAccnt, "insertDateTimeforUserAccunt", objSeUserAccnt.Error);
           #endregion Security and validation check

            #region Initialisation
            TList<SeUserAccnt> result =null;
            bool isBorrowedTransaction = false;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider;
            #endregion Initialisation

            try
            {
                isBorrowedTransaction = ConnectionScope.Current.HasTransaction;
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                result = dataProvider.SeUserAccntProvider.GetSeUserAccountIdByUserTypeAndUserTableId(transactionManager,_UserType,_SeUserId,_UserTableId);

                if (!isBorrowedTransaction && transactionManager != null && transactionManager.IsOpen)
                    transactionManager.Commit();
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

            return result;
        }
        #endregion
		
	}//End Class

} // end namespace
