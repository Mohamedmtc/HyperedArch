

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
    /// An component type implementation of the 'ED_ACAD_PLAN' table.
    /// </summary>
    /// <remarks>
    /// All custom implementations should be done here.
    /// </remarks>
    [CLSCompliant(true)]
    public partial class EdAcadPlanService : UMIS_VER2.EdAcadPlanServiceBase
    {
        #region Fields
        private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
        private static readonly bool noTranByDefault = false;
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the EdAcadPlanService class.
        /// </summary>
        public EdAcadPlanService()
            : base()
        {
        }
        #endregion Constructors

        #region Custom Methods
        public virtual DataTable Search(System.Decimal _asFacultyInfoId, System.Decimal _entMainId, System.Decimal _edAcadYearId, System.Decimal _codeDegreeClassId, System.Decimal _isClosed)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("Search");
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

                list = dataProvider.EdAcadPlanProvider.Search(transactionManager, _asFacultyInfoId, _entMainId, _edAcadYearId, _codeDegreeClassId, _isClosed);
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

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public virtual bool InsertImportedPlan(System.Decimal EDAcadOldPlanId, System.Decimal EdAcadNewPlanId)
        {
            #region Security and validation check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("InsertImportedPlan");

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

                result = dataProvider.EdAcadPlanProvider.InsertImportedPlan(transactionManager, EDAcadOldPlanId, EdAcadNewPlanId);

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
        public virtual bool InsertImportedBylaw(System.Decimal EDAcadOldBylawId, System.Decimal EdAcadNewBylawId)
        {
            #region Security and validation check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("InsertImportedBylaw");

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

                result = dataProvider.EdAcadPlanProvider.InsertImportedBylaw(transactionManager, EDAcadOldBylawId, EdAcadNewBylawId);

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

        public virtual TList<EdAcadYear> GetAcadYears(System.Decimal _asFacultyInfoId, System.Decimal _entMainId)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetAcadYears");
            #endregion Security check

            #region Initialisation
            TList<EdAcadYear> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<EdAcadYear>(dataProvider.EdAcadPlanProvider.GetAcadYears(transactionManager, _asFacultyInfoId, _entMainId));
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

        public virtual TList<EdAcadYear> GetAcadYears(System.Decimal _asFacultyInfoId, System.Decimal _entMainId, System.Decimal _asCodeDeegreeClassId)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetAcadYears");
            #endregion Security check

            #region Initialisation
            TList<EdAcadYear> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = new TList<EdAcadYear>(dataProvider.EdAcadPlanProvider.GetAcadYears(transactionManager, _asFacultyInfoId, _entMainId, _asCodeDeegreeClassId));
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
