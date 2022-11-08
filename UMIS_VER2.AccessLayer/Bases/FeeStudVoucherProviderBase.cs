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
	/// This class is the base class for any <see cref="FeeStudVoucherProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class FeeStudVoucherProviderBase : FeeStudVoucherProviderBaseCore
	{
        #region Custom Methods
        public abstract DataTable GetDetailedItems(TransactionManager transactionManager, decimal feeStudVoucherID);
        public abstract DataTable GetVoucherPayOnlineNotPayed(decimal? edStudID, decimal? AppID);    
       public abstract void DeleteByVoucherID(decimal VoucherID);
       public abstract void DeleteByVoucherForApplicantID(decimal VoucherID);
        public abstract decimal GetTotalPayment(TransactionManager transactionManager, decimal edStudID, decimal asFacultyID, decimal edAcadYearID);
        public abstract TList<FeeStudVoucher> SearchStudVoucher(TransactionManager transactionManager, DateTime? _VoucherDateFrom, DateTime? _VoucherDateTo
            , decimal? _FeeCodeTypeId, decimal? _GsCodeCurrencyId, decimal _EdStudId, decimal _AsFacultyInfoId);

        public abstract DataTable SearchStudVoucher_Custum(TransactionManager transactionManager, DateTime? _VoucherDateFrom, DateTime? _VoucherDateTo
           , decimal? _FeeCodeTypeId, decimal? _GsCodeCurrencyId, decimal? _EdStudId, decimal? _AsFacultyInfoId, decimal? BankId, string FromReciptNum, string ToReciptNum
            , decimal? PaymentMehodId, decimal? AcadYearId, decimal? CodeSemesterId, decimal? SeUserId);


        public abstract decimal GetSerialVoucher(decimal VoucherSerial, TransactionManager transactionManager=null);


        public abstract DataTable SearchStudVoucher_Delete(TransactionManager transactionManager, DateTime? _VoucherDateFrom, DateTime? _VoucherDateTo
           , decimal? _FeeCodeTypeId, decimal? _GsCodeCurrencyId, decimal? _EdStudId, decimal? _AsFacultyInfoId, decimal? BankId, string FromReciptNum,
            string ToReciptNum, decimal? PaymentMehodId, int TypeId,int CancelVoucherDurationDays,decimal? AcadYearId,decimal?  CodeSemesterId);
       

        
        #endregion
	} // end class
} // end namespace
