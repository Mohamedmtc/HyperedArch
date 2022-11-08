	

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
	/// An component type implementation of the 'ENT_COURSE_PKG_HDR' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class EntCoursePkgHdrService : UMIS_VER2.EntCoursePkgHdrServiceBase
	{
        #region Fields
        private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
        private static readonly bool noTranByDefault = false;
        #endregion

        #region Constructors
		/// <summary>
		/// Initializes a new instance of the EntCoursePkgHdrService class.
		/// </summary>
		public EntCoursePkgHdrService() : base()
		{
		}
		#endregion Constructors

        #region Custom Methods
        public virtual DataTable GetEntityMains()
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetEntityMains");
            #endregion Security check

            #region Initialisation
            DataTable list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.EntCoursePkgHdrProvider.GetEntityMains(transactionManager);
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

        public virtual TList<EntCoursePkgHdr> GetByParentEntityMain(System.Decimal _entMainId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetByParentEntityMain");
            #endregion Security check

            #region Initialisation
            TList<EntCoursePkgHdr> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.EntCoursePkgHdrProvider.GetByParentEntityMain(transactionManager, _entMainId);
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


        public virtual bool InsertImportedCoursePkg(System.Decimal EntMainFromID, System.Decimal EDACADPLANFromID, System.Decimal EntMainToID, System.Decimal EDACADPLANToID, System.Decimal EntCoursePkgHdrID)
        {
            #region Security and validation check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("InsertImportedCoursePkg");

            //if (!entity.IsValid)
            //    throw new EntityNotValidException(entity, "InsertImportedPlan", entity.Error);
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

                result = dataProvider.EntCoursePkgHdrProvider.InsertImportedCoursePkg(transactionManager, EntMainFromID, EDACADPLANFromID, EntMainToID, EDACADPLANToID, EntCoursePkgHdrID);

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
