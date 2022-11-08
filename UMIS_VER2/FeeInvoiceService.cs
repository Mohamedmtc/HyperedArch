
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
	/// An component type implementation of the 'FEE_INVOICE' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class FeeInvoiceService : UMIS_VER2.FeeInvoiceServiceBase
	{
		#region Fields
		private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
		private static readonly bool noTranByDefault = false;
		#endregion
		
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the FeeInvoiceService class.
		/// </summary>
		public FeeInvoiceService() : base()
		{
		}
		#endregion Constructors

        #region Custom 
        public virtual DataTable GetInvoiceItems(System.Decimal _FeeInvoice, System.Decimal _InvoiveId, System.String _InvoiceStudId, System.Decimal _VoucherId)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetInvoiceItems");
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

                list = dataProvider.FeeInvoiceProvider.GetInvoiceItems(transactionManager, _InvoiveId, _InvoiceStudId, _VoucherId);
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

        public virtual DataTable GetSponsoreInvoices(System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _AsFacultyInfoId, System.Decimal _EntMainId, System.Decimal _EdStudId, System.Decimal _CPR, System.DateTime? _DateFrom, System.DateTime? _DateTo, System.Decimal _SpoSponsorId, System.String _InvoiceNum, System.Decimal _InvoiceType, System.String _InvoiceId, System.String _SpoCode, System.Decimal _InvoiceCdeStaus, System.Decimal _PageIndex, System.Decimal _PageSize)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetSponsoreInvoices");
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

                list = dataProvider.FeeInvoiceProvider.GetSponsoreInvoices(transactionManager, _EdAcadYearId, _EdCodeSemesterId, _AsFacultyInfoId, _EntMainId, _EdStudId, _CPR, _DateFrom, _DateTo, _SpoSponsorId, _InvoiceNum, _InvoiceType, _InvoiceId, _SpoCode, _InvoiceCdeStaus, _PageIndex, _PageSize);
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

        public virtual DataTable GetSponsoreInvoicesToPay(System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EntMainId, System.Decimal _EdStudId, System.Decimal _CPR, System.DateTime? _DateFrom, System.DateTime? _DateTo, System.Decimal _SpoSponsorId, System.String _InvoiceNum, System.Decimal _InvoiceType, System.String _InvoiceId, System.String _SpoCode, System.Decimal _InvoiceCdeStaus, System.Decimal _VoucherId, System.Decimal _PageIndex, System.Decimal _PageSize)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetSponsoreInvoicesToPay");
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

                list = dataProvider.FeeInvoiceProvider.GetSponsoreInvoicesToPay(transactionManager, _EdAcadYearId, _EdCodeSemesterId, _EntMainId, _EdStudId, _CPR, _DateFrom, _DateTo,_SpoSponsorId, _InvoiceNum, _InvoiceType, _InvoiceId, _SpoCode, _InvoiceCdeStaus, _VoucherId,  _PageIndex, _PageSize);
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

        public virtual DataTable GetStudFeeForSposor(System.Decimal _FeeInvoice, System.Decimal _SponsorId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _GsCodeCurrency, System.Decimal _PageIndex, System.Decimal _PageSize)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetStudFeeForSposor");
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

                list = dataProvider.FeeInvoiceProvider.GetStudFeeForSposor(transactionManager, _FeeInvoice, _SponsorId, _EdAcadYearId, _EdCodeSemesterId, _GsCodeCurrency, _PageIndex, _PageSize);
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


        public virtual DataTable GetSpoStudFeeItem(System.Decimal _FeeInvoice, System.Decimal _SpoSponsorStudId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetSpoStudFeeItem");
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

                list = dataProvider.FeeInvoiceProvider.GetSpoStudFeeItem(transactionManager, _FeeInvoice, _SpoSponsorStudId, _EdAcadYearId, _EdCodeSemesterId);
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

        public virtual DataTable GetSpoStudFeeItemForPayment(System.Decimal _FeeInvoice, System.Decimal _SpoSponsorStudId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _VoucherId)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetSpoStudFeeItemForPayment");
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

                list = dataProvider.FeeInvoiceProvider.GetSpoStudFeeItemForPayment(transactionManager, _FeeInvoice, _SpoSponsorStudId, _EdAcadYearId, _EdCodeSemesterId, _VoucherId);
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
