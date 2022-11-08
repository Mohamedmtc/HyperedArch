	

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
	/// An component type implementation of the 'ADM_APP_TRANS_TO_COURSE' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class AdmAppTransToCourseService : UMIS_VER2.AdmAppTransToCourseServiceBase
	{
        #region Fields
        private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
        private static readonly bool noTranByDefault = false;
        #endregion

        #region Constructors
		/// <summary>
		/// Initializes a new instance of the AdmAppTransToCourseService class.
		/// </summary>
		public AdmAppTransToCourseService() : base()
		{
		}
		#endregion Constructors

        #region Custom Methods
        public virtual decimal InsertWithOutputID(AdmAppTransToCourse entity)
        {
            #region Security and validation check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("InsertWithOutputID");

            if (!entity.IsValid)
                throw new EntityNotValidException(entity, "InsertWithOutputID", entity.Error);
            #endregion Security and validation check

            #region Initialisation
            decimal AdmAppTransToCourse = 0;
            bool isBorrowedTransaction = false;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider;
            #endregion Initialisation

            try
            {
                isBorrowedTransaction = ConnectionScope.Current.HasTransaction;
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                AdmAppTransToCourse = dataProvider.AdmAppTransToCourseProvider.InsertWithOutputID(transactionManager, entity);

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

            return AdmAppTransToCourse;
        }
        #endregion

	}//End Class

} // end namespace
