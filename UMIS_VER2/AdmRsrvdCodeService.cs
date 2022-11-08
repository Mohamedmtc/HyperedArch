	

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
	/// An component type implementation of the 'ADM_RSRVD_CODE' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class AdmRsrvdCodeService : UMIS_VER2.AdmRsrvdCodeServiceBase
	{
		#region Fields
		private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
		private static readonly bool noTranByDefault = false;
		#endregion
		
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the AdmRsrvdCodeService class.
		/// </summary>
		public AdmRsrvdCodeService() : base()
		{
		}
		#endregion Constructors

        #region Insert
        #region Custom Methods

    
        #region Insert Entity
        /// <summary>
        /// public virtual method that Inserts a AdmRsrvdCode object into the datasource using a transaction.
        /// </summary>
        /// <param name="entity">AdmRsrvdCode object to Insert.</param>
        /// <remarks>After Inserting into the datasource, the AdmRsrvdCode object will be updated
        /// to refelect any changes made by the datasource. (ie: identity or computed columns)
        /// </remarks>
        /// <returns>Returns bool that the operation is successful.</returns>
        /// <example>
        /// The following code shows the usage of the Insert Method with an already open transaction.
        /// <code>
        /// AdmRsrvdCode entity = new AdmRsrvdCode();
        /// entity.StringProperty = "foo";
        /// entity.IntProperty = 12;
        /// entity.ChildObjectSource.StringProperty = "bar";
        /// TransactionManager tm = null;
        /// try
        ///	{
        /// 	tm = ConnectionContext.CreateTransaction();
        ///		//Insert Child entity, Then Parent Entity
        /// 	ChildObjectTypeService.Insert(entity.ChildObjectSource);
        ///		AdmRsrvdCodeService.Insert(entity);
        ///	}
        ///	catch (Exception e)
        ///	{
        ///		if (tm != null &amp;&amp; tm.IsOpen) tm.Rollback();
        ///		if (DomainUtil.HandleException(e, name)) throw;
        ///	}
        /// </code>
        /// </example>
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public override bool Insert(AdmRsrvdCode entity)
        {
            #region Security and validation check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("Insert");

            if (!entity.IsValid)
                throw new EntityNotValidException(entity, "Insert", entity.Error);
            #endregion Security and validation check

            #region Initialisation
            bool result = false;
            bool isBorrowedTransaction = false;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider;
            #endregion Initialisation

            try
            {
                isBorrowedTransaction = ConnectionScope.Current.HasTransaction;
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                result = dataProvider.AdmRsrvdCodeProvider.Insert(transactionManager, entity);

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
        #endregion Insert Entity

        #region Update Entity
        /// <summary>
        /// public virtual method that Updates a AdmRsrvdCode object into the datasource using a transaction.
        /// </summary>
        /// <param name="entity">AdmRsrvdCode object to Update.</param>
        /// <remarks>After Updateing into the datasource, the AdmRsrvdCode object will be updated
        /// to refelect any changes made by the datasource. (ie: identity or computed columns)
        /// </remarks>
        /// <returns>Returns bool that the operation is successful.</returns>
        /// <example>
        /// The following code shows the usage of the Update Method with an already open transaction.
        /// <code>
        ///	AdmRsrvdCode entity = AdmRsrvdCodeService.GetByPrimaryKeyColumn(1234);
        /// entity.StringProperty = "foo";
        /// entity.IntProperty = 12;
        /// entity.ChildObjectSource.StringProperty = "bar";
        /// TransactionManager tm = null;
        /// try
        ///	{
        /// 	tm = ConnectionContext.CreateTransaction();
        ///		//Update Child entity, Then Parent Entity
        /// 	ChildObjectTypeService.Update(entity.ChildObjectSource);
        ///		AdmRsrvdCodeService.Update(entity);
        ///	}
        ///	catch (Exception e)
        ///	{
        ///		if (tm != null &amp;&amp; tm.IsOpen) tm.Rollback();
        ///		if (DomainUtil.HandleException(e, name)) throw;
        ///	}
        /// </code>
        /// </example>
        [DataObjectMethod(DataObjectMethodType.Update)]
        public override bool Update(AdmRsrvdCode entity)
        {
            #region Security and validation check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("Update");

            if (!entity.IsValid)
                throw new EntityNotValidException(entity, "Update", entity.Error);
            #endregion Security and validation check

            #region Initialisation
            bool result = false;
            bool isBorrowedTransaction = false;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider;
            #endregion Initialisation

            try
            {
                isBorrowedTransaction = ConnectionScope.Current.HasTransaction;
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                result = dataProvider.AdmRsrvdCodeProvider.Update(transactionManager, entity);

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
        #endregion Update Entity
		
        #endregion
        #endregion
    }//End Class

} // end namespace
