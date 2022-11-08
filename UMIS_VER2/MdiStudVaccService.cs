

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
    /// An component type implementation of the 'MDI_STUD_VACC' table.
    /// </summary>
    /// <remarks>
    /// All custom implementations should be done here.
    /// </remarks>
    [CLSCompliant(true)]
    public partial class MdiStudVaccService : UMIS_VER2.MdiStudVaccServiceBase
    {
        #region Fields
        private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
        private static readonly bool noTranByDefault = false;
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the MdiStudVaccService class.
        /// </summary>
        public MdiStudVaccService()
            : base()
        {
        }
        #endregion Constructors

        #region Custom
        public virtual DataTable SearchStudVacc(System.Decimal _AsFacultyInfoID, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.String _StudCode, System.Decimal _MdiCdeVacc, System.Decimal _MdiVaccSrl, string _FromDt, string _ToDt)
        {
            #region Security check
            SecurityContext.IsAuthorized("SearchStudVacc");
            #endregion Security check
            #region Initialisation
            DataTable Dt = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                Dt = dataProvider.MdiStudVaccProvider.SearchStudVacc(transactionManager, _AsFacultyInfoID, _EdAcadYearId, _EdCodeSemesterId, _StudCode, _MdiCdeVacc, _MdiVaccSrl, _FromDt, _ToDt);
                return Dt;
            }
            catch (Exception exc)
            {
                #region Handle transaction rollback and exception
                if (transactionManager != null && transactionManager.IsOpen)
                    transactionManager.Rollback();
                if (DomainUtil.HandleException(exc, layerExceptionPolicy))
                    throw;
                #endregion Handle transaction rollback and exception
            }
            return Dt;
        }
        public virtual int GetStudVaccSerial(System.Decimal _EdStudID, System.Decimal _MdiCdeVaccID,System.Decimal _RptSerial)
        {
            #region Security check
            SecurityContext.IsAuthorized("GetStudVaccSerial");
            #endregion Security check
            #region Initialisation
            int count = 0;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                count = dataProvider.MdiStudVaccProvider.GetStudVaccSerial(transactionManager, _EdStudID, _MdiCdeVaccID, _RptSerial);
                return count;
            }
            catch (Exception exc)
            {
                #region Handle transaction rollback and exception
                if (transactionManager != null && transactionManager.IsOpen)
                    transactionManager.Rollback();
                if (DomainUtil.HandleException(exc, layerExceptionPolicy))
                    throw;
                #endregion Handle transaction rollback and exception
            }
            return count;
        }
        public virtual int Delete_Custom(System.Decimal _MdiStudVaccId)
        {
            #region Security check
            SecurityContext.IsAuthorized("Delete_Custom");
            #endregion Security check
            #region Initialisation
            int count = 0;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                count = dataProvider.MdiStudVaccProvider.Delete_Custom(transactionManager, _MdiStudVaccId);
                return count;
            }
            catch (Exception exc)
            {
                #region Handle transaction rollback and exception
                if (transactionManager != null && transactionManager.IsOpen)
                    transactionManager.Rollback();
                if (DomainUtil.HandleException(exc, layerExceptionPolicy))
                    throw;
                #endregion Handle transaction rollback and exception
            }
            return count;
        }
        #endregion

    }//End Class

} // end namespace
