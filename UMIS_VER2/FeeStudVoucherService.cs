	

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
	/// An component type implementation of the 'FEE_STUD_VOUCHER' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class FeeStudVoucherService : UMIS_VER2.FeeStudVoucherServiceBase
	{
        #region Fields
        private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
        private static readonly bool noTranByDefault = false;
        #endregion

        #region Constructors
		/// <summary>
		/// Initializes a new instance of the FeeStudVoucherService class.
		/// </summary>
		public FeeStudVoucherService() : base()
		{
		}
		#endregion Constructors

        #region Custom Methods
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual DataTable GetDetailedItems(decimal feeStudVoucherID)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetDetailedItems");
            #endregion Security check

            #region Initialisation
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                return dataProvider.FeeStudVoucherProvider.GetDetailedItems(transactionManager, feeStudVoucherID);
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

            return null;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual decimal GetTotalPayment(decimal edStudID, decimal asFacultyID, decimal edAcadYearID)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetTotalPayment");
            #endregion Security check

            #region Initialisation
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                return dataProvider.FeeStudVoucherProvider.GetTotalPayment(transactionManager, edStudID, asFacultyID, edAcadYearID);
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

            return 0;
        }
        public virtual void DeleteByVoucherID(decimal VoucherID)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetTotalPayment");
            #endregion Security check

            #region Initialisation
   
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

                dataProvider = ConnectionScope.Current.DataProvider;

                 dataProvider.FeeStudVoucherProvider.DeleteByVoucherID( VoucherID);
            
         
        }
        public virtual void DeleteByVoucherForApplicantID(decimal VoucherID)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetTotalPayment");
            #endregion Security check

            #region Initialisation

            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            dataProvider = ConnectionScope.Current.DataProvider;

            dataProvider.FeeStudVoucherProvider.DeleteByVoucherForApplicantID(VoucherID);
        }

        public virtual DataTable GetVoucherPayOnlineNotPayed(decimal? edStudID, decimal? AppID)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetTotalPayment");
            #endregion Security check

            #region Initialisation
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                return dataProvider.FeeStudVoucherProvider.GetVoucherPayOnlineNotPayed(edStudID,AppID);
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

            return null;
        }


        public virtual TList<FeeStudVoucher> SearchStudVoucher(DateTime? _VoucherDateFrom, DateTime? _VoucherDateTo
            , decimal? _FeeCodeTypeId, decimal? _GsCodeCurrencyId, decimal _EdStudId, decimal _AsFacultyInfoId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("SearchStudVoucher");
            #endregion Security check

            #region Initialisation
            TList<FeeStudVoucher> list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.FeeStudVoucherProvider.SearchStudVoucher(transactionManager, _VoucherDateFrom, _VoucherDateTo
                    , _FeeCodeTypeId, _GsCodeCurrencyId, _EdStudId, _AsFacultyInfoId);
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
        //Task_3732 Add PaymentID
        public virtual DataTable SearchStudVoucher_Custum(DateTime? _VoucherDateFrom, DateTime? _VoucherDateTo
           , decimal? _FeeCodeTypeId, decimal? _GsCodeCurrencyId, decimal? _EdStudId, decimal? _AsFacultyInfoId, decimal? BankId, string FromReciptNum, string ToReciptNum, decimal? PaymentMehodId, decimal? AcadYearId, decimal? CodeSemesterId, decimal? SeUserId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("SearchStudVoucher");
            #endregion Security check

            #region Initialisation
            DataTable list = new DataTable();
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;
                //Task_3732 Add PaymentID
                list = dataProvider.FeeStudVoucherProvider.SearchStudVoucher_Custum(transactionManager, _VoucherDateFrom, _VoucherDateTo
                   , _FeeCodeTypeId, _GsCodeCurrencyId, _EdStudId, _AsFacultyInfoId, BankId, FromReciptNum, ToReciptNum, PaymentMehodId, AcadYearId, CodeSemesterId, SeUserId);
                //list = dataProvider.FeeStudVoucherProvider.SearchStudVoucher_Custum(transactionManager, _VoucherDateFrom, _VoucherDateTo
                //    , _FeeCodeTypeId, _GsCodeCurrencyId, _EdStudId, _AsFacultyInfoId, BankId, FromReciptNum, ToReciptNum);
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


        public virtual decimal GetSerialVoucher(decimal VoucherSerial)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetSerialVoucher");
            #endregion Security check

            #region Initialisation
            decimal res = 0;
            NetTiersProvider dataProvider = null;
            TransactionManager transactionManager = null;
            #endregion Initialisation
            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;
                //Task_3732 Add PaymentID
                res = dataProvider.FeeStudVoucherProvider.GetSerialVoucher(VoucherSerial, transactionManager);//walaa 9/8/2022 -Handle Transaction
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
                return res;
        }




        public virtual DataTable SearchStudVoucher_Delete(DateTime? _VoucherDateFrom, DateTime? _VoucherDateTo
         , decimal? _FeeCodeTypeId, decimal? _GsCodeCurrencyId, decimal? _EdStudId, decimal? _AsFacultyInfoId, decimal? BankId, string FromReciptNum,
            string ToReciptNum, decimal? PaymentMehodId,int TypeId,int CancelVoucherDurationDays ,decimal?AcadYearId,decimal? CodeSemesterId)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("SearchStudVoucher");
            #endregion Security check

            #region Initialisation
            DataTable list = new DataTable();
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;
                //Task_3732 Add PaymentID
                list = dataProvider.FeeStudVoucherProvider.SearchStudVoucher_Delete(transactionManager, _VoucherDateFrom, _VoucherDateTo
                   , _FeeCodeTypeId, _GsCodeCurrencyId, _EdStudId, _AsFacultyInfoId, BankId, FromReciptNum, ToReciptNum, PaymentMehodId, TypeId, CancelVoucherDurationDays,AcadYearId, CodeSemesterId);
                //list = dataProvider.FeeStudVoucherProvider.SearchStudVoucher_Custum(transactionManager, _VoucherDateFrom, _VoucherDateTo
                //    , _FeeCodeTypeId, _GsCodeCurrencyId, _EdStudId, _AsFacultyInfoId, BankId, FromReciptNum, ToReciptNum);
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
