	

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
	/// An component type implementation of the 'FEE_STUD_VOUCHER_ITEM' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class FeeStudVoucherItemService : UMIS_VER2.FeeStudVoucherItemServiceBase
	{
        #region Fields
        private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
        private static readonly bool noTranByDefault = false;
        #endregion

        #region Constructors
		/// <summary>
		/// Initializes a new instance of the FeeStudVoucherItemService class.
		/// </summary>
		public FeeStudVoucherItemService() : base()
		{
		}
		#endregion Constructors

        #region Custom Methods
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual DataTable GetStudVoucherItem(System.Decimal _EdStudId, System.Decimal _FacEntityMainId,
            System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _CurrEdCodeSemId
            , System.Decimal _SelectFeesFlag, System.Decimal _FeeCodeTypeId, System.Decimal _GsCodeCurrencyId)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStudVoucherItem");
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

                list = (dataProvider.FeeStudVoucherItemProvider.GetStudVoucherItem(transactionManager, _EdStudId,
             _FacEntityMainId, _AsFacultyInfoId, _EdAcadYearId, _CurrEdCodeSemId, _SelectFeesFlag, _FeeCodeTypeId, _GsCodeCurrencyId));
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

        
             public virtual DataTable GetStudVoucherItemBalance(System.Decimal _EdStudId, System.Decimal _FacEntityMainId,
            System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _CurrEdCodeSemId
            , System.Decimal _SelectFeesFlag, System.Decimal _FeeCodeTypeId, System.Decimal _GsCodeCurrencyId)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStudVoucherItem");
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

                list = (dataProvider.FeeStudVoucherItemProvider.GetStudVoucherItemBalance(transactionManager, _EdStudId,
             _FacEntityMainId, _AsFacultyInfoId, _EdAcadYearId, _CurrEdCodeSemId, _SelectFeesFlag, _FeeCodeTypeId, _GsCodeCurrencyId));
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


        public virtual DataTable LoadStudVoucherItem(System.Decimal _FeeStudVoucherID)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("LoadStudVoucherItem");
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

                list = (dataProvider.FeeStudVoucherItemProvider.LoadStudVoucherItem(transactionManager, _FeeStudVoucherID ));
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
        public virtual DataTable GetStuditemsDiscound(System.Decimal _EdStudId, System.Decimal _FacEntityMainId,
            System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _CurrEdCodeSemId
            , System.Decimal _SelectFeesFlag, System.Decimal _FeeCodeTypeId, System.Decimal _GsCodeCurrencyId, System.Decimal _FeeCdeDiscCatId)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStuditemsDiscound");
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

                list = (dataProvider.FeeStudVoucherItemProvider.GetStuditemsDiscound(transactionManager, _EdStudId,
             _FacEntityMainId, _AsFacultyInfoId, _EdAcadYearId, _CurrEdCodeSemId, _SelectFeesFlag, _FeeCodeTypeId, _GsCodeCurrencyId, _FeeCdeDiscCatId));
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

        public virtual DataTable GetStuditemsDiscoundAll(System.Decimal _EdStudId, System.Decimal _FacEntityMainId,
           System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _CurrEdCodeSemId
           , System.Decimal _SelectFeesFlag, System.Decimal _FeeCodeTypeId, System.Decimal _GsCodeCurrencyId, System.Decimal _FeeStudDisc, System.Decimal _FeeCdeDiscCatId)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStuditemsDiscoundAll");
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

                list = (dataProvider.FeeStudVoucherItemProvider.GetStuditemsDiscoundAll(transactionManager, _EdStudId,
             _FacEntityMainId, _AsFacultyInfoId, _EdAcadYearId, _CurrEdCodeSemId, _SelectFeesFlag, _FeeCodeTypeId, _GsCodeCurrencyId, _FeeStudDisc, _FeeCdeDiscCatId));
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
        public virtual DataTable LoadStuditemsDiscound(System.Decimal _FeeStudDiscId)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("LoadStuditemsDiscound");
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

                list = (dataProvider.FeeStudVoucherItemProvider.LoadStuditemsDiscound(transactionManager, _FeeStudDiscId));
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
        public virtual DataTable GetHistoricalFees(System.Decimal _EdStudId, System.Decimal _FacEntityMainId,
            System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _CurrEdCodeSemId
            , System.Decimal _FeeCodeTypeId)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetHistoricalFees");
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

                list = (dataProvider.FeeStudVoucherItemProvider.GetHistoricalFees(transactionManager, _EdStudId,
             _FacEntityMainId, _AsFacultyInfoId, _EdAcadYearId, _CurrEdCodeSemId, _FeeCodeTypeId));
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

        public virtual decimal GetStudentPayed(System.Decimal FeeStudFeeItemId)
        {
            NetTiersProvider dataProvider = null;
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetHistoricalFees");
            #endregion Security check
            dataProvider = ConnectionScope.Current.DataProvider;
            #region Initialisation
          return  dataProvider.FeeStudVoucherItemProvider.GetStudentPayed(FeeStudFeeItemId);
 
  
            #endregion Initialisation

          
        }


        #endregion

	}//End Class

} // end namespace
