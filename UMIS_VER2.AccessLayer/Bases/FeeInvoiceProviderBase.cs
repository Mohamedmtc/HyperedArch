#region Using directives

using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;

using System.Diagnostics;
using UMIS_VER2.BusinessLyer;
using UMIS_VER2.AccessLayer;

#endregion

namespace UMIS_VER2.AccessLayer.Bases
{	
	///<summary>
	/// This class is the base class for any <see cref="FeeInvoiceProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class FeeInvoiceProviderBase : FeeInvoiceProviderBaseCore
	{
        public abstract DataTable GetInvoiceItems(TransactionManager transactionManager, System.Decimal _InvoiveId, System.String _InvoiceStudId, System.Decimal _VoucherId);
        public abstract DataTable GetSponsoreInvoices(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _AsFacultyInfoId, System.Decimal _EntMainId, System.Decimal _EdStudId, System.Decimal _CPR, System.DateTime? _DateFrom, System.DateTime? _DateTo, System.Decimal _SpoSponsorId, System.String _InvoiceNum, System.Decimal _InvoiceType, System.String _InvoiceId, System.String _SpoCode, System.Decimal _InvoiceCdeStaus, System.Decimal _PageIndex, System.Decimal _PageSize);
        public abstract DataTable GetSponsoreInvoicesToPay(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EntMainId, System.Decimal _EdStudId, System.Decimal _CPR, System.DateTime? _DateFrom, System.DateTime? _DateTo, System.Decimal _SpoSponsorId, System.String _InvoiceNum, System.Decimal _InvoiceType, System.String _InvoiceId, System.String _SpoCode, System.Decimal _InvoiceCdeStaus, System.Decimal VoucherId, System.Decimal _PageIndex, System.Decimal _PageSize);

        public abstract DataTable GetStudFeeForSposor(TransactionManager transactionManager, System.Decimal _FeeInvoice, System.Decimal _SponsorId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _GsCodeCurrency, System.Decimal _PageIndex, System.Decimal _PageSize);
        public abstract DataTable GetSpoStudFeeItem(TransactionManager transactionManager, System.Decimal _FeeInvoice, System.Decimal _SpoSponsorStudId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId);

        public abstract DataTable GetSpoStudFeeItemForPayment(TransactionManager transactionManager, System.Decimal _FeeInvoice, System.Decimal _SpoSponsorStudId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _VoucherId);

    } // end class
} // end namespace
