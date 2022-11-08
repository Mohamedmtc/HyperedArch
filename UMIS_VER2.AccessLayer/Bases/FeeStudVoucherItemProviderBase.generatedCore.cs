#region Using directives

using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;

using UMIS_VER2.BusinessLyer;
using UMIS_VER2.AccessLayer;

#endregion

namespace UMIS_VER2.AccessLayer.Bases
{	
	///<summary>
	/// This class is the base class for any <see cref="FeeStudVoucherItemProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class FeeStudVoucherItemProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.FeeStudVoucherItem, UMIS_VER2.BusinessLyer.FeeStudVoucherItemKey>
	{		
		#region Get from Many To Many Relationship Functions
		#endregion	
		
		#region Delete Methods

		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager">A <see cref="TransactionManager"/> object.</param>
		/// <param name="key">The unique identifier of the row to delete.</param>
		/// <returns>Returns true if operation suceeded.</returns>
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeStudVoucherItemKey key)
		{
			return Delete(transactionManager, key.FeeStudVoucherItemId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_feeStudVoucherItemId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _feeStudVoucherItemId)
		{
			return Delete(null, _feeStudVoucherItemId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudVoucherItemId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _feeStudVoucherItemId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_ITEM_ADM_APP_FEES key.
		///		FK_FEE_STUD_VOUCHER_ITEM_ADM_APP_FEES Description: 
		/// </summary>
		/// <param name="_admAppFeesId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucherItem objects.</returns>
		public TList<FeeStudVoucherItem> GetByAdmAppFeesId(System.Decimal? _admAppFeesId)
		{
			int count = -1;
			return GetByAdmAppFeesId(_admAppFeesId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_ITEM_ADM_APP_FEES key.
		///		FK_FEE_STUD_VOUCHER_ITEM_ADM_APP_FEES Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppFeesId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucherItem objects.</returns>
		/// <remarks></remarks>
		public TList<FeeStudVoucherItem> GetByAdmAppFeesId(TransactionManager transactionManager, System.Decimal? _admAppFeesId)
		{
			int count = -1;
			return GetByAdmAppFeesId(transactionManager, _admAppFeesId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_ITEM_ADM_APP_FEES key.
		///		FK_FEE_STUD_VOUCHER_ITEM_ADM_APP_FEES Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppFeesId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucherItem objects.</returns>
		public TList<FeeStudVoucherItem> GetByAdmAppFeesId(TransactionManager transactionManager, System.Decimal? _admAppFeesId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppFeesId(transactionManager, _admAppFeesId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_ITEM_ADM_APP_FEES key.
		///		fkFeeStudVoucherItemAdmAppFees Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admAppFeesId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucherItem objects.</returns>
		public TList<FeeStudVoucherItem> GetByAdmAppFeesId(System.Decimal? _admAppFeesId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmAppFeesId(null, _admAppFeesId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_ITEM_ADM_APP_FEES key.
		///		fkFeeStudVoucherItemAdmAppFees Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admAppFeesId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucherItem objects.</returns>
		public TList<FeeStudVoucherItem> GetByAdmAppFeesId(System.Decimal? _admAppFeesId, int start, int pageLength,out int count)
		{
			return GetByAdmAppFeesId(null, _admAppFeesId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_ITEM_ADM_APP_FEES key.
		///		FK_FEE_STUD_VOUCHER_ITEM_ADM_APP_FEES Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppFeesId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucherItem objects.</returns>
		public abstract TList<FeeStudVoucherItem> GetByAdmAppFeesId(TransactionManager transactionManager, System.Decimal? _admAppFeesId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_ITEM_FEE_INVOICE key.
		///		FK_FEE_STUD_VOUCHER_ITEM_FEE_INVOICE Description: 
		/// </summary>
		/// <param name="_feeInvoiceId">فاتورة كفيل- or credit memo</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucherItem objects.</returns>
		public TList<FeeStudVoucherItem> GetByFeeInvoiceId(System.Decimal? _feeInvoiceId)
		{
			int count = -1;
			return GetByFeeInvoiceId(_feeInvoiceId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_ITEM_FEE_INVOICE key.
		///		FK_FEE_STUD_VOUCHER_ITEM_FEE_INVOICE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeInvoiceId">فاتورة كفيل- or credit memo</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucherItem objects.</returns>
		/// <remarks></remarks>
		public TList<FeeStudVoucherItem> GetByFeeInvoiceId(TransactionManager transactionManager, System.Decimal? _feeInvoiceId)
		{
			int count = -1;
			return GetByFeeInvoiceId(transactionManager, _feeInvoiceId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_ITEM_FEE_INVOICE key.
		///		FK_FEE_STUD_VOUCHER_ITEM_FEE_INVOICE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeInvoiceId">فاتورة كفيل- or credit memo</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucherItem objects.</returns>
		public TList<FeeStudVoucherItem> GetByFeeInvoiceId(TransactionManager transactionManager, System.Decimal? _feeInvoiceId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeInvoiceId(transactionManager, _feeInvoiceId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_ITEM_FEE_INVOICE key.
		///		fkFeeStudVoucherItemFeeInvoice Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeInvoiceId">فاتورة كفيل- or credit memo</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucherItem objects.</returns>
		public TList<FeeStudVoucherItem> GetByFeeInvoiceId(System.Decimal? _feeInvoiceId, int start, int pageLength)
		{
			int count =  -1;
			return GetByFeeInvoiceId(null, _feeInvoiceId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_ITEM_FEE_INVOICE key.
		///		fkFeeStudVoucherItemFeeInvoice Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeInvoiceId">فاتورة كفيل- or credit memo</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucherItem objects.</returns>
		public TList<FeeStudVoucherItem> GetByFeeInvoiceId(System.Decimal? _feeInvoiceId, int start, int pageLength,out int count)
		{
			return GetByFeeInvoiceId(null, _feeInvoiceId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_ITEM_FEE_INVOICE key.
		///		FK_FEE_STUD_VOUCHER_ITEM_FEE_INVOICE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeInvoiceId">فاتورة كفيل- or credit memo</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucherItem objects.</returns>
		public abstract TList<FeeStudVoucherItem> GetByFeeInvoiceId(TransactionManager transactionManager, System.Decimal? _feeInvoiceId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_ITEM_FEE_STUD_FEE_ITEM key.
		///		FK_FEE_STUD_VOUCHER_ITEM_FEE_STUD_FEE_ITEM Description: 
		/// </summary>
		/// <param name="_feeStudFeeItemId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucherItem objects.</returns>
		public TList<FeeStudVoucherItem> GetByFeeStudFeeItemId(System.Decimal? _feeStudFeeItemId)
		{
			int count = -1;
			return GetByFeeStudFeeItemId(_feeStudFeeItemId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_ITEM_FEE_STUD_FEE_ITEM key.
		///		FK_FEE_STUD_VOUCHER_ITEM_FEE_STUD_FEE_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudFeeItemId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucherItem objects.</returns>
		/// <remarks></remarks>
		public TList<FeeStudVoucherItem> GetByFeeStudFeeItemId(TransactionManager transactionManager, System.Decimal? _feeStudFeeItemId)
		{
			int count = -1;
			return GetByFeeStudFeeItemId(transactionManager, _feeStudFeeItemId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_ITEM_FEE_STUD_FEE_ITEM key.
		///		FK_FEE_STUD_VOUCHER_ITEM_FEE_STUD_FEE_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudFeeItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucherItem objects.</returns>
		public TList<FeeStudVoucherItem> GetByFeeStudFeeItemId(TransactionManager transactionManager, System.Decimal? _feeStudFeeItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeStudFeeItemId(transactionManager, _feeStudFeeItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_ITEM_FEE_STUD_FEE_ITEM key.
		///		fkFeeStudVoucherItemFeeStudFeeItem Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeStudFeeItemId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucherItem objects.</returns>
		public TList<FeeStudVoucherItem> GetByFeeStudFeeItemId(System.Decimal? _feeStudFeeItemId, int start, int pageLength)
		{
			int count =  -1;
			return GetByFeeStudFeeItemId(null, _feeStudFeeItemId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_ITEM_FEE_STUD_FEE_ITEM key.
		///		fkFeeStudVoucherItemFeeStudFeeItem Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeStudFeeItemId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucherItem objects.</returns>
		public TList<FeeStudVoucherItem> GetByFeeStudFeeItemId(System.Decimal? _feeStudFeeItemId, int start, int pageLength,out int count)
		{
			return GetByFeeStudFeeItemId(null, _feeStudFeeItemId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_ITEM_FEE_STUD_FEE_ITEM key.
		///		FK_FEE_STUD_VOUCHER_ITEM_FEE_STUD_FEE_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudFeeItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucherItem objects.</returns>
		public abstract TList<FeeStudVoucherItem> GetByFeeStudFeeItemId(TransactionManager transactionManager, System.Decimal? _feeStudFeeItemId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_ITEM_FEE_STUD_INSTALLMENT key.
		///		FK_FEE_STUD_VOUCHER_ITEM_FEE_STUD_INSTALLMENT Description: 
		/// </summary>
		/// <param name="_feeStudInstallmentId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucherItem objects.</returns>
		public TList<FeeStudVoucherItem> GetByFeeStudInstallmentId(System.Decimal? _feeStudInstallmentId)
		{
			int count = -1;
			return GetByFeeStudInstallmentId(_feeStudInstallmentId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_ITEM_FEE_STUD_INSTALLMENT key.
		///		FK_FEE_STUD_VOUCHER_ITEM_FEE_STUD_INSTALLMENT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudInstallmentId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucherItem objects.</returns>
		/// <remarks></remarks>
		public TList<FeeStudVoucherItem> GetByFeeStudInstallmentId(TransactionManager transactionManager, System.Decimal? _feeStudInstallmentId)
		{
			int count = -1;
			return GetByFeeStudInstallmentId(transactionManager, _feeStudInstallmentId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_ITEM_FEE_STUD_INSTALLMENT key.
		///		FK_FEE_STUD_VOUCHER_ITEM_FEE_STUD_INSTALLMENT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudInstallmentId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucherItem objects.</returns>
		public TList<FeeStudVoucherItem> GetByFeeStudInstallmentId(TransactionManager transactionManager, System.Decimal? _feeStudInstallmentId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeStudInstallmentId(transactionManager, _feeStudInstallmentId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_ITEM_FEE_STUD_INSTALLMENT key.
		///		fkFeeStudVoucherItemFeeStudInstallment Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeStudInstallmentId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucherItem objects.</returns>
		public TList<FeeStudVoucherItem> GetByFeeStudInstallmentId(System.Decimal? _feeStudInstallmentId, int start, int pageLength)
		{
			int count =  -1;
			return GetByFeeStudInstallmentId(null, _feeStudInstallmentId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_ITEM_FEE_STUD_INSTALLMENT key.
		///		fkFeeStudVoucherItemFeeStudInstallment Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeStudInstallmentId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucherItem objects.</returns>
		public TList<FeeStudVoucherItem> GetByFeeStudInstallmentId(System.Decimal? _feeStudInstallmentId, int start, int pageLength,out int count)
		{
			return GetByFeeStudInstallmentId(null, _feeStudInstallmentId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_ITEM_FEE_STUD_INSTALLMENT key.
		///		FK_FEE_STUD_VOUCHER_ITEM_FEE_STUD_INSTALLMENT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudInstallmentId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucherItem objects.</returns>
		public abstract TList<FeeStudVoucherItem> GetByFeeStudInstallmentId(TransactionManager transactionManager, System.Decimal? _feeStudInstallmentId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_ITEM_SE_USER key.
		///		FK_FEE_STUD_VOUCHER_ITEM_SE_USER Description: 
		/// </summary>
		/// <param name="_seUserId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucherItem objects.</returns>
		public TList<FeeStudVoucherItem> GetBySeUserId(System.Decimal? _seUserId)
		{
			int count = -1;
			return GetBySeUserId(_seUserId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_ITEM_SE_USER key.
		///		FK_FEE_STUD_VOUCHER_ITEM_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucherItem objects.</returns>
		/// <remarks></remarks>
		public TList<FeeStudVoucherItem> GetBySeUserId(TransactionManager transactionManager, System.Decimal? _seUserId)
		{
			int count = -1;
			return GetBySeUserId(transactionManager, _seUserId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_ITEM_SE_USER key.
		///		FK_FEE_STUD_VOUCHER_ITEM_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucherItem objects.</returns>
		public TList<FeeStudVoucherItem> GetBySeUserId(TransactionManager transactionManager, System.Decimal? _seUserId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeUserId(transactionManager, _seUserId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_ITEM_SE_USER key.
		///		fkFeeStudVoucherItemSeUser Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucherItem objects.</returns>
		public TList<FeeStudVoucherItem> GetBySeUserId(System.Decimal? _seUserId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySeUserId(null, _seUserId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_ITEM_SE_USER key.
		///		fkFeeStudVoucherItemSeUser Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucherItem objects.</returns>
		public TList<FeeStudVoucherItem> GetBySeUserId(System.Decimal? _seUserId, int start, int pageLength,out int count)
		{
			return GetBySeUserId(null, _seUserId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_ITEM_SE_USER key.
		///		FK_FEE_STUD_VOUCHER_ITEM_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucherItem objects.</returns>
		public abstract TList<FeeStudVoucherItem> GetBySeUserId(TransactionManager transactionManager, System.Decimal? _seUserId, int start, int pageLength, out int count);
		
		#endregion

		#region Get By Index Functions
		
		/// <summary>
		/// 	Gets a row from the DataSource based on its primary key.
		/// </summary>
		/// <param name="transactionManager">A <see cref="TransactionManager"/> object.</param>
		/// <param name="key">The unique identifier of the row to retrieve.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <returns>Returns an instance of the Entity class.</returns>
		public override UMIS_VER2.BusinessLyer.FeeStudVoucherItem Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeStudVoucherItemKey key, int start, int pageLength)
		{
			return GetByFeeStudVoucherItemId(transactionManager, key.FeeStudVoucherItemId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_FEE_STUD_VOUCHER_ID_1 index.
		/// </summary>
		/// <param name="_feeStudVoucherId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudVoucherItem&gt;"/> class.</returns>
		public TList<FeeStudVoucherItem> GetByFeeStudVoucherId(System.Decimal _feeStudVoucherId)
		{
			int count = -1;
			return GetByFeeStudVoucherId(null,_feeStudVoucherId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_FEE_STUD_VOUCHER_ID_1 index.
		/// </summary>
		/// <param name="_feeStudVoucherId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudVoucherItem&gt;"/> class.</returns>
		public TList<FeeStudVoucherItem> GetByFeeStudVoucherId(System.Decimal _feeStudVoucherId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeStudVoucherId(null, _feeStudVoucherId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_FEE_STUD_VOUCHER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudVoucherId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudVoucherItem&gt;"/> class.</returns>
		public TList<FeeStudVoucherItem> GetByFeeStudVoucherId(TransactionManager transactionManager, System.Decimal _feeStudVoucherId)
		{
			int count = -1;
			return GetByFeeStudVoucherId(transactionManager, _feeStudVoucherId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_FEE_STUD_VOUCHER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudVoucherId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudVoucherItem&gt;"/> class.</returns>
		public TList<FeeStudVoucherItem> GetByFeeStudVoucherId(TransactionManager transactionManager, System.Decimal _feeStudVoucherId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeStudVoucherId(transactionManager, _feeStudVoucherId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_FEE_STUD_VOUCHER_ID_1 index.
		/// </summary>
		/// <param name="_feeStudVoucherId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudVoucherItem&gt;"/> class.</returns>
		public TList<FeeStudVoucherItem> GetByFeeStudVoucherId(System.Decimal _feeStudVoucherId, int start, int pageLength, out int count)
		{
			return GetByFeeStudVoucherId(null, _feeStudVoucherId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_FEE_STUD_VOUCHER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudVoucherId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudVoucherItem&gt;"/> class.</returns>
		public abstract TList<FeeStudVoucherItem> GetByFeeStudVoucherId(TransactionManager transactionManager, System.Decimal _feeStudVoucherId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_FEE_STUD_VOUCHER_ITEM index.
		/// </summary>
		/// <param name="_feeStudVoucherItemId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudVoucherItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudVoucherItem GetByFeeStudVoucherItemId(System.Decimal _feeStudVoucherItemId)
		{
			int count = -1;
			return GetByFeeStudVoucherItemId(null,_feeStudVoucherItemId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_STUD_VOUCHER_ITEM index.
		/// </summary>
		/// <param name="_feeStudVoucherItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudVoucherItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudVoucherItem GetByFeeStudVoucherItemId(System.Decimal _feeStudVoucherItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeStudVoucherItemId(null, _feeStudVoucherItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_STUD_VOUCHER_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudVoucherItemId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudVoucherItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudVoucherItem GetByFeeStudVoucherItemId(TransactionManager transactionManager, System.Decimal _feeStudVoucherItemId)
		{
			int count = -1;
			return GetByFeeStudVoucherItemId(transactionManager, _feeStudVoucherItemId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_STUD_VOUCHER_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudVoucherItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudVoucherItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudVoucherItem GetByFeeStudVoucherItemId(TransactionManager transactionManager, System.Decimal _feeStudVoucherItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeStudVoucherItemId(transactionManager, _feeStudVoucherItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_STUD_VOUCHER_ITEM index.
		/// </summary>
		/// <param name="_feeStudVoucherItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudVoucherItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudVoucherItem GetByFeeStudVoucherItemId(System.Decimal _feeStudVoucherItemId, int start, int pageLength, out int count)
		{
			return GetByFeeStudVoucherItemId(null, _feeStudVoucherItemId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_STUD_VOUCHER_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudVoucherItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudVoucherItem"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.FeeStudVoucherItem GetByFeeStudVoucherItemId(TransactionManager transactionManager, System.Decimal _feeStudVoucherItemId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_FEE_STUD_VOUCHER_ITEM index.
		/// </summary>
		/// <param name="_feeStudVoucherId"></param>
		/// <param name="_feeStudFeeItemId"></param>
		/// <param name="_admAppFeesId"></param>
		/// <param name="_feeInvoiceId">فاتورة كفيل- or credit memo</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudVoucherItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudVoucherItem GetByFeeStudVoucherIdFeeStudFeeItemIdAdmAppFeesIdFeeInvoiceId(System.Decimal _feeStudVoucherId, System.Decimal? _feeStudFeeItemId, System.Decimal? _admAppFeesId, System.Decimal? _feeInvoiceId)
		{
			int count = -1;
			return GetByFeeStudVoucherIdFeeStudFeeItemIdAdmAppFeesIdFeeInvoiceId(null,_feeStudVoucherId, _feeStudFeeItemId, _admAppFeesId, _feeInvoiceId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_STUD_VOUCHER_ITEM index.
		/// </summary>
		/// <param name="_feeStudVoucherId"></param>
		/// <param name="_feeStudFeeItemId"></param>
		/// <param name="_admAppFeesId"></param>
		/// <param name="_feeInvoiceId">فاتورة كفيل- or credit memo</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudVoucherItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudVoucherItem GetByFeeStudVoucherIdFeeStudFeeItemIdAdmAppFeesIdFeeInvoiceId(System.Decimal _feeStudVoucherId, System.Decimal? _feeStudFeeItemId, System.Decimal? _admAppFeesId, System.Decimal? _feeInvoiceId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeStudVoucherIdFeeStudFeeItemIdAdmAppFeesIdFeeInvoiceId(null, _feeStudVoucherId, _feeStudFeeItemId, _admAppFeesId, _feeInvoiceId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_STUD_VOUCHER_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudVoucherId"></param>
		/// <param name="_feeStudFeeItemId"></param>
		/// <param name="_admAppFeesId"></param>
		/// <param name="_feeInvoiceId">فاتورة كفيل- or credit memo</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudVoucherItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudVoucherItem GetByFeeStudVoucherIdFeeStudFeeItemIdAdmAppFeesIdFeeInvoiceId(TransactionManager transactionManager, System.Decimal _feeStudVoucherId, System.Decimal? _feeStudFeeItemId, System.Decimal? _admAppFeesId, System.Decimal? _feeInvoiceId)
		{
			int count = -1;
			return GetByFeeStudVoucherIdFeeStudFeeItemIdAdmAppFeesIdFeeInvoiceId(transactionManager, _feeStudVoucherId, _feeStudFeeItemId, _admAppFeesId, _feeInvoiceId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_STUD_VOUCHER_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudVoucherId"></param>
		/// <param name="_feeStudFeeItemId"></param>
		/// <param name="_admAppFeesId"></param>
		/// <param name="_feeInvoiceId">فاتورة كفيل- or credit memo</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudVoucherItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudVoucherItem GetByFeeStudVoucherIdFeeStudFeeItemIdAdmAppFeesIdFeeInvoiceId(TransactionManager transactionManager, System.Decimal _feeStudVoucherId, System.Decimal? _feeStudFeeItemId, System.Decimal? _admAppFeesId, System.Decimal? _feeInvoiceId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeStudVoucherIdFeeStudFeeItemIdAdmAppFeesIdFeeInvoiceId(transactionManager, _feeStudVoucherId, _feeStudFeeItemId, _admAppFeesId, _feeInvoiceId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_STUD_VOUCHER_ITEM index.
		/// </summary>
		/// <param name="_feeStudVoucherId"></param>
		/// <param name="_feeStudFeeItemId"></param>
		/// <param name="_admAppFeesId"></param>
		/// <param name="_feeInvoiceId">فاتورة كفيل- or credit memo</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudVoucherItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudVoucherItem GetByFeeStudVoucherIdFeeStudFeeItemIdAdmAppFeesIdFeeInvoiceId(System.Decimal _feeStudVoucherId, System.Decimal? _feeStudFeeItemId, System.Decimal? _admAppFeesId, System.Decimal? _feeInvoiceId, int start, int pageLength, out int count)
		{
			return GetByFeeStudVoucherIdFeeStudFeeItemIdAdmAppFeesIdFeeInvoiceId(null, _feeStudVoucherId, _feeStudFeeItemId, _admAppFeesId, _feeInvoiceId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_STUD_VOUCHER_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudVoucherId"></param>
		/// <param name="_feeStudFeeItemId"></param>
		/// <param name="_admAppFeesId"></param>
		/// <param name="_feeInvoiceId">فاتورة كفيل- or credit memo</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudVoucherItem"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.FeeStudVoucherItem GetByFeeStudVoucherIdFeeStudFeeItemIdAdmAppFeesIdFeeInvoiceId(TransactionManager transactionManager, System.Decimal _feeStudVoucherId, System.Decimal? _feeStudFeeItemId, System.Decimal? _admAppFeesId, System.Decimal? _feeInvoiceId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;FeeStudVoucherItem&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;FeeStudVoucherItem&gt;"/></returns>
		public static TList<FeeStudVoucherItem> Fill(IDataReader reader, TList<FeeStudVoucherItem> rows, int start, int pageLength)
		{
			NetTiersProvider currentProvider = DataRepository.Provider;
            bool useEntityFactory = currentProvider.UseEntityFactory;
            bool enableEntityTracking = currentProvider.EnableEntityTracking;
            LoadPolicy currentLoadPolicy = currentProvider.CurrentLoadPolicy;
			Type entityCreationFactoryType = currentProvider.EntityCreationalFactoryType;
			
			// advance to the starting row
			for (int i = 0; i < start; i++)
			{
				if (!reader.Read())
				return rows; // not enough rows, just return
			}
			for (int i = 0; i < pageLength; i++)
			{
				if (!reader.Read())
					break; // we are done
					
				string key = null;
				
				UMIS_VER2.BusinessLyer.FeeStudVoucherItem c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("FeeStudVoucherItem")
					.Append("|").Append((System.Decimal)reader["FEE_STUD_VOUCHER_ITEM_ID"]).ToString();
					c = EntityManager.LocateOrCreate<FeeStudVoucherItem>(
					key.ToString(), // EntityTrackingKey
					"FeeStudVoucherItem",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.FeeStudVoucherItem();
				}
				
				if (!enableEntityTracking ||
					c.EntityState == EntityState.Added ||
					(enableEntityTracking &&
					
						(
							(currentLoadPolicy == LoadPolicy.PreserveChanges && c.EntityState == EntityState.Unchanged) ||
							(currentLoadPolicy == LoadPolicy.DiscardChanges && c.EntityState != EntityState.Unchanged)
						)
					))
				{
					c.SuppressEntityEvents = true;
					c.FeeStudVoucherItemId = (System.Decimal)reader["FEE_STUD_VOUCHER_ITEM_ID"];
					c.OriginalFeeStudVoucherItemId = c.FeeStudVoucherItemId;
					c.FeeStudVoucherId = (System.Decimal)reader["FEE_STUD_VOUCHER_ID"];
					c.FeeCurrentAmount = (System.Decimal)reader["FEE_CURRENT_AMOUNT"];
					c.PayAmount = (System.Decimal)reader["PAY_AMOUNT"];
					c.DiscAmount = Convert.IsDBNull(reader["DISC_AMOUNT"]) ? null : (System.Decimal?)reader["DISC_AMOUNT"];
					c.ItemCount = (System.Decimal)reader["ITEM_COUNT"];
					c.DueDate = Convert.IsDBNull(reader["DUE_DATE"]) ? null : (System.DateTime?)reader["DUE_DATE"];
					c.PenaltyAmount = Convert.IsDBNull(reader["PENALTY_AMOUNT"]) ? null : (System.Decimal?)reader["PENALTY_AMOUNT"];
					c.FeeStudInstallmentId = Convert.IsDBNull(reader["FEE_STUD_INSTALLMENT_ID"]) ? null : (System.Decimal?)reader["FEE_STUD_INSTALLMENT_ID"];
					c.FeeStudFeeItemId = Convert.IsDBNull(reader["FEE_STUD_FEE_ITEM_ID"]) ? null : (System.Decimal?)reader["FEE_STUD_FEE_ITEM_ID"];
					c.AdmAppFeesId = Convert.IsDBNull(reader["ADM_APP_FEES_ID"]) ? null : (System.Decimal?)reader["ADM_APP_FEES_ID"];
					c.Notes = (System.String)reader["NOTES"];
					c.ItemDesc = Convert.IsDBNull(reader["ITEM_DESC"]) ? null : (System.String)reader["ITEM_DESC"];
					c.FeeInvoiceId = Convert.IsDBNull(reader["FEE_INVOICE_ID"]) ? null : (System.Decimal?)reader["FEE_INVOICE_ID"];
					c.SeUserId = Convert.IsDBNull(reader["SE_USER_ID"]) ? null : (System.Decimal?)reader["SE_USER_ID"];
					c.LastDate = Convert.IsDBNull(reader["LAST_DATE"]) ? null : (System.DateTime?)reader["LAST_DATE"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeStudVoucherItem"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeStudVoucherItem"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.FeeStudVoucherItem entity)
		{
			if (!reader.Read()) return;
			
			entity.FeeStudVoucherItemId = (System.Decimal)reader[((int)FeeStudVoucherItemColumn.FeeStudVoucherItemId - 1)];
			entity.OriginalFeeStudVoucherItemId = (System.Decimal)reader["FEE_STUD_VOUCHER_ITEM_ID"];
			entity.FeeStudVoucherId = (System.Decimal)reader[((int)FeeStudVoucherItemColumn.FeeStudVoucherId - 1)];
			entity.FeeCurrentAmount = (System.Decimal)reader[((int)FeeStudVoucherItemColumn.FeeCurrentAmount - 1)];
			entity.PayAmount = (System.Decimal)reader[((int)FeeStudVoucherItemColumn.PayAmount - 1)];
			entity.DiscAmount = (reader.IsDBNull(((int)FeeStudVoucherItemColumn.DiscAmount - 1)))?null:(System.Decimal?)reader[((int)FeeStudVoucherItemColumn.DiscAmount - 1)];
			entity.ItemCount = (System.Decimal)reader[((int)FeeStudVoucherItemColumn.ItemCount - 1)];
			entity.DueDate = (reader.IsDBNull(((int)FeeStudVoucherItemColumn.DueDate - 1)))?null:(System.DateTime?)reader[((int)FeeStudVoucherItemColumn.DueDate - 1)];
			entity.PenaltyAmount = (reader.IsDBNull(((int)FeeStudVoucherItemColumn.PenaltyAmount - 1)))?null:(System.Decimal?)reader[((int)FeeStudVoucherItemColumn.PenaltyAmount - 1)];
			entity.FeeStudInstallmentId = (reader.IsDBNull(((int)FeeStudVoucherItemColumn.FeeStudInstallmentId - 1)))?null:(System.Decimal?)reader[((int)FeeStudVoucherItemColumn.FeeStudInstallmentId - 1)];
			entity.FeeStudFeeItemId = (reader.IsDBNull(((int)FeeStudVoucherItemColumn.FeeStudFeeItemId - 1)))?null:(System.Decimal?)reader[((int)FeeStudVoucherItemColumn.FeeStudFeeItemId - 1)];
			entity.AdmAppFeesId = (reader.IsDBNull(((int)FeeStudVoucherItemColumn.AdmAppFeesId - 1)))?null:(System.Decimal?)reader[((int)FeeStudVoucherItemColumn.AdmAppFeesId - 1)];
			entity.Notes = (System.String)reader[((int)FeeStudVoucherItemColumn.Notes - 1)];
			entity.ItemDesc = (reader.IsDBNull(((int)FeeStudVoucherItemColumn.ItemDesc - 1)))?null:(System.String)reader[((int)FeeStudVoucherItemColumn.ItemDesc - 1)];
			entity.FeeInvoiceId = (reader.IsDBNull(((int)FeeStudVoucherItemColumn.FeeInvoiceId - 1)))?null:(System.Decimal?)reader[((int)FeeStudVoucherItemColumn.FeeInvoiceId - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)FeeStudVoucherItemColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)FeeStudVoucherItemColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)FeeStudVoucherItemColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)FeeStudVoucherItemColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeStudVoucherItem"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeStudVoucherItem"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.FeeStudVoucherItem entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.FeeStudVoucherItemId = (System.Decimal)dataRow["FEE_STUD_VOUCHER_ITEM_ID"];
			entity.OriginalFeeStudVoucherItemId = (System.Decimal)dataRow["FEE_STUD_VOUCHER_ITEM_ID"];
			entity.FeeStudVoucherId = (System.Decimal)dataRow["FEE_STUD_VOUCHER_ID"];
			entity.FeeCurrentAmount = (System.Decimal)dataRow["FEE_CURRENT_AMOUNT"];
			entity.PayAmount = (System.Decimal)dataRow["PAY_AMOUNT"];
			entity.DiscAmount = Convert.IsDBNull(dataRow["DISC_AMOUNT"]) ? null : (System.Decimal?)dataRow["DISC_AMOUNT"];
			entity.ItemCount = (System.Decimal)dataRow["ITEM_COUNT"];
			entity.DueDate = Convert.IsDBNull(dataRow["DUE_DATE"]) ? null : (System.DateTime?)dataRow["DUE_DATE"];
			entity.PenaltyAmount = Convert.IsDBNull(dataRow["PENALTY_AMOUNT"]) ? null : (System.Decimal?)dataRow["PENALTY_AMOUNT"];
			entity.FeeStudInstallmentId = Convert.IsDBNull(dataRow["FEE_STUD_INSTALLMENT_ID"]) ? null : (System.Decimal?)dataRow["FEE_STUD_INSTALLMENT_ID"];
			entity.FeeStudFeeItemId = Convert.IsDBNull(dataRow["FEE_STUD_FEE_ITEM_ID"]) ? null : (System.Decimal?)dataRow["FEE_STUD_FEE_ITEM_ID"];
			entity.AdmAppFeesId = Convert.IsDBNull(dataRow["ADM_APP_FEES_ID"]) ? null : (System.Decimal?)dataRow["ADM_APP_FEES_ID"];
			entity.Notes = (System.String)dataRow["NOTES"];
			entity.ItemDesc = Convert.IsDBNull(dataRow["ITEM_DESC"]) ? null : (System.String)dataRow["ITEM_DESC"];
			entity.FeeInvoiceId = Convert.IsDBNull(dataRow["FEE_INVOICE_ID"]) ? null : (System.Decimal?)dataRow["FEE_INVOICE_ID"];
			entity.SeUserId = Convert.IsDBNull(dataRow["SE_USER_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_ID"];
			entity.LastDate = Convert.IsDBNull(dataRow["LAST_DATE"]) ? null : (System.DateTime?)dataRow["LAST_DATE"];
			entity.AcceptChanges();
		}
		#endregion 
		
		#region DeepLoad Methods
		/// <summary>
		/// Deep Loads the <see cref="IEntity"/> object with criteria based of the child 
		/// property collections only N Levels Deep based on the <see cref="DeepLoadType"/>.
		/// </summary>
		/// <remarks>
		/// Use this method with caution as it is possible to DeepLoad with Recursion and traverse an entire object graph.
		/// </remarks>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeStudVoucherItem"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeStudVoucherItem Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeStudVoucherItem entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AdmAppFeesIdSource	
			if (CanDeepLoad(entity, "AdmAppFees|AdmAppFeesIdSource", deepLoadType, innerList) 
				&& entity.AdmAppFeesIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AdmAppFeesId ?? 0.0m);
				AdmAppFees tmpEntity = EntityManager.LocateEntity<AdmAppFees>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmAppFees), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmAppFeesIdSource = tmpEntity;
				else
					entity.AdmAppFeesIdSource = DataRepository.AdmAppFeesProvider.GetByAdmAppFeesId(transactionManager, (entity.AdmAppFeesId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppFeesIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmAppFeesIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmAppFeesProvider.DeepLoad(transactionManager, entity.AdmAppFeesIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmAppFeesIdSource

			#region FeeInvoiceIdSource	
			if (CanDeepLoad(entity, "FeeInvoice|FeeInvoiceIdSource", deepLoadType, innerList) 
				&& entity.FeeInvoiceIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.FeeInvoiceId ?? 0.0m);
				FeeInvoice tmpEntity = EntityManager.LocateEntity<FeeInvoice>(EntityLocator.ConstructKeyFromPkItems(typeof(FeeInvoice), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.FeeInvoiceIdSource = tmpEntity;
				else
					entity.FeeInvoiceIdSource = DataRepository.FeeInvoiceProvider.GetByFeeInvoiceId(transactionManager, (entity.FeeInvoiceId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeInvoiceIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.FeeInvoiceIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.FeeInvoiceProvider.DeepLoad(transactionManager, entity.FeeInvoiceIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion FeeInvoiceIdSource

			#region FeeStudFeeItemIdSource	
			if (CanDeepLoad(entity, "FeeStudFeeItem|FeeStudFeeItemIdSource", deepLoadType, innerList) 
				&& entity.FeeStudFeeItemIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.FeeStudFeeItemId ?? 0.0m);
				FeeStudFeeItem tmpEntity = EntityManager.LocateEntity<FeeStudFeeItem>(EntityLocator.ConstructKeyFromPkItems(typeof(FeeStudFeeItem), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.FeeStudFeeItemIdSource = tmpEntity;
				else
					entity.FeeStudFeeItemIdSource = DataRepository.FeeStudFeeItemProvider.GetByFeeStudFeeItemId(transactionManager, (entity.FeeStudFeeItemId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudFeeItemIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.FeeStudFeeItemIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.FeeStudFeeItemProvider.DeepLoad(transactionManager, entity.FeeStudFeeItemIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion FeeStudFeeItemIdSource

			#region FeeStudInstallmentIdSource	
			if (CanDeepLoad(entity, "FeeStudInstallment|FeeStudInstallmentIdSource", deepLoadType, innerList) 
				&& entity.FeeStudInstallmentIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.FeeStudInstallmentId ?? 0.0m);
				FeeStudInstallment tmpEntity = EntityManager.LocateEntity<FeeStudInstallment>(EntityLocator.ConstructKeyFromPkItems(typeof(FeeStudInstallment), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.FeeStudInstallmentIdSource = tmpEntity;
				else
					entity.FeeStudInstallmentIdSource = DataRepository.FeeStudInstallmentProvider.GetByFeeStudInstallmentId(transactionManager, (entity.FeeStudInstallmentId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudInstallmentIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.FeeStudInstallmentIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.FeeStudInstallmentProvider.DeepLoad(transactionManager, entity.FeeStudInstallmentIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion FeeStudInstallmentIdSource

			#region FeeStudVoucherIdSource	
			if (CanDeepLoad(entity, "FeeStudVoucher|FeeStudVoucherIdSource", deepLoadType, innerList) 
				&& entity.FeeStudVoucherIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.FeeStudVoucherId;
				FeeStudVoucher tmpEntity = EntityManager.LocateEntity<FeeStudVoucher>(EntityLocator.ConstructKeyFromPkItems(typeof(FeeStudVoucher), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.FeeStudVoucherIdSource = tmpEntity;
				else
					entity.FeeStudVoucherIdSource = DataRepository.FeeStudVoucherProvider.GetByFeeStudVoucherId(transactionManager, entity.FeeStudVoucherId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudVoucherIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.FeeStudVoucherIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.FeeStudVoucherProvider.DeepLoad(transactionManager, entity.FeeStudVoucherIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion FeeStudVoucherIdSource

			#region SeUserIdSource	
			if (CanDeepLoad(entity, "SeUser|SeUserIdSource", deepLoadType, innerList) 
				&& entity.SeUserIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SeUserId ?? 0.0m);
				SeUser tmpEntity = EntityManager.LocateEntity<SeUser>(EntityLocator.ConstructKeyFromPkItems(typeof(SeUser), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SeUserIdSource = tmpEntity;
				else
					entity.SeUserIdSource = DataRepository.SeUserProvider.GetBySeUserId(transactionManager, (entity.SeUserId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeUserIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SeUserIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SeUserProvider.DeepLoad(transactionManager, entity.SeUserIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SeUserIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByFeeStudVoucherItemId methods when available
			
			#region FeeStudVoucherCrsItemCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeStudVoucherCrsItem>|FeeStudVoucherCrsItemCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudVoucherCrsItemCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeStudVoucherCrsItemCollection = DataRepository.FeeStudVoucherCrsItemProvider.GetByFeeStudVoucherItemId(transactionManager, entity.FeeStudVoucherItemId);

				if (deep && entity.FeeStudVoucherCrsItemCollection.Count > 0)
				{
					deepHandles.Add("FeeStudVoucherCrsItemCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudVoucherCrsItem>) DataRepository.FeeStudVoucherCrsItemProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudVoucherCrsItemCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeItemTrnsBlncCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeItemTrnsBlnc>|FeeItemTrnsBlncCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeItemTrnsBlncCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeItemTrnsBlncCollection = DataRepository.FeeItemTrnsBlncProvider.GetByFeeStudVoucherItemId(transactionManager, entity.FeeStudVoucherItemId);

				if (deep && entity.FeeItemTrnsBlncCollection.Count > 0)
				{
					deepHandles.Add("FeeItemTrnsBlncCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeItemTrnsBlnc>) DataRepository.FeeItemTrnsBlncProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeItemTrnsBlncCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			//Fire all DeepLoad Items
			foreach(KeyValuePair<Delegate, object> pair in deepHandles.Values)
		    {
                pair.Key.DynamicInvoke((object[])pair.Value);
		    }
			deepHandles = null;
		}
		
		#endregion 
		
		#region DeepSave Methods

		/// <summary>
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.FeeStudVoucherItem object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.FeeStudVoucherItem instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeStudVoucherItem Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeStudVoucherItem entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AdmAppFeesIdSource
			if (CanDeepSave(entity, "AdmAppFees|AdmAppFeesIdSource", deepSaveType, innerList) 
				&& entity.AdmAppFeesIdSource != null)
			{
				DataRepository.AdmAppFeesProvider.Save(transactionManager, entity.AdmAppFeesIdSource);
				entity.AdmAppFeesId = entity.AdmAppFeesIdSource.AdmAppFeesId;
			}
			#endregion 
			
			#region FeeInvoiceIdSource
			if (CanDeepSave(entity, "FeeInvoice|FeeInvoiceIdSource", deepSaveType, innerList) 
				&& entity.FeeInvoiceIdSource != null)
			{
				DataRepository.FeeInvoiceProvider.Save(transactionManager, entity.FeeInvoiceIdSource);
				entity.FeeInvoiceId = entity.FeeInvoiceIdSource.FeeInvoiceId;
			}
			#endregion 
			
			#region FeeStudFeeItemIdSource
			if (CanDeepSave(entity, "FeeStudFeeItem|FeeStudFeeItemIdSource", deepSaveType, innerList) 
				&& entity.FeeStudFeeItemIdSource != null)
			{
				DataRepository.FeeStudFeeItemProvider.Save(transactionManager, entity.FeeStudFeeItemIdSource);
				entity.FeeStudFeeItemId = entity.FeeStudFeeItemIdSource.FeeStudFeeItemId;
			}
			#endregion 
			
			#region FeeStudInstallmentIdSource
			if (CanDeepSave(entity, "FeeStudInstallment|FeeStudInstallmentIdSource", deepSaveType, innerList) 
				&& entity.FeeStudInstallmentIdSource != null)
			{
				DataRepository.FeeStudInstallmentProvider.Save(transactionManager, entity.FeeStudInstallmentIdSource);
				entity.FeeStudInstallmentId = entity.FeeStudInstallmentIdSource.FeeStudInstallmentId;
			}
			#endregion 
			
			#region FeeStudVoucherIdSource
			if (CanDeepSave(entity, "FeeStudVoucher|FeeStudVoucherIdSource", deepSaveType, innerList) 
				&& entity.FeeStudVoucherIdSource != null)
			{
				DataRepository.FeeStudVoucherProvider.Save(transactionManager, entity.FeeStudVoucherIdSource);
				entity.FeeStudVoucherId = entity.FeeStudVoucherIdSource.FeeStudVoucherId;
			}
			#endregion 
			
			#region SeUserIdSource
			if (CanDeepSave(entity, "SeUser|SeUserIdSource", deepSaveType, innerList) 
				&& entity.SeUserIdSource != null)
			{
				DataRepository.SeUserProvider.Save(transactionManager, entity.SeUserIdSource);
				entity.SeUserId = entity.SeUserIdSource.SeUserId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<FeeStudVoucherCrsItem>
				if (CanDeepSave(entity.FeeStudVoucherCrsItemCollection, "List<FeeStudVoucherCrsItem>|FeeStudVoucherCrsItemCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeStudVoucherCrsItem child in entity.FeeStudVoucherCrsItemCollection)
					{
						if(child.FeeStudVoucherItemIdSource != null)
						{
							child.FeeStudVoucherItemId = child.FeeStudVoucherItemIdSource.FeeStudVoucherItemId;
						}
						else
						{
							child.FeeStudVoucherItemId = entity.FeeStudVoucherItemId;
						}

					}

					if (entity.FeeStudVoucherCrsItemCollection.Count > 0 || entity.FeeStudVoucherCrsItemCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeStudVoucherCrsItemProvider.Save(transactionManager, entity.FeeStudVoucherCrsItemCollection);
						
						deepHandles.Add("FeeStudVoucherCrsItemCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeStudVoucherCrsItem >) DataRepository.FeeStudVoucherCrsItemProvider.DeepSave,
							new object[] { transactionManager, entity.FeeStudVoucherCrsItemCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeItemTrnsBlnc>
				if (CanDeepSave(entity.FeeItemTrnsBlncCollection, "List<FeeItemTrnsBlnc>|FeeItemTrnsBlncCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeItemTrnsBlnc child in entity.FeeItemTrnsBlncCollection)
					{
						if(child.FeeStudVoucherItemIdSource != null)
						{
							child.FeeStudVoucherItemId = child.FeeStudVoucherItemIdSource.FeeStudVoucherItemId;
						}
						else
						{
							child.FeeStudVoucherItemId = entity.FeeStudVoucherItemId;
						}

					}

					if (entity.FeeItemTrnsBlncCollection.Count > 0 || entity.FeeItemTrnsBlncCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeItemTrnsBlncProvider.Save(transactionManager, entity.FeeItemTrnsBlncCollection);
						
						deepHandles.Add("FeeItemTrnsBlncCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeItemTrnsBlnc >) DataRepository.FeeItemTrnsBlncProvider.DeepSave,
							new object[] { transactionManager, entity.FeeItemTrnsBlncCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
			//Fire all DeepSave Items
			foreach(KeyValuePair<Delegate, object> pair in deepHandles.Values)
		    {
                pair.Key.DynamicInvoke((object[])pair.Value);
		    }
			
			// Save Root Entity through Provider, if not already saved in delete mode
			if (entity.IsDeleted)
				this.Save(transactionManager, entity);
				

			deepHandles = null;
						
			return true;
		}
		#endregion
	} // end class
	
	#region FeeStudVoucherItemChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.FeeStudVoucherItem</c>
	///</summary>
	public enum FeeStudVoucherItemChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AdmAppFees</c> at AdmAppFeesIdSource
		///</summary>
		[ChildEntityType(typeof(AdmAppFees))]
		AdmAppFees,
		
		///<summary>
		/// Composite Property for <c>FeeInvoice</c> at FeeInvoiceIdSource
		///</summary>
		[ChildEntityType(typeof(FeeInvoice))]
		FeeInvoice,
		
		///<summary>
		/// Composite Property for <c>FeeStudFeeItem</c> at FeeStudFeeItemIdSource
		///</summary>
		[ChildEntityType(typeof(FeeStudFeeItem))]
		FeeStudFeeItem,
		
		///<summary>
		/// Composite Property for <c>FeeStudInstallment</c> at FeeStudInstallmentIdSource
		///</summary>
		[ChildEntityType(typeof(FeeStudInstallment))]
		FeeStudInstallment,
		
		///<summary>
		/// Composite Property for <c>FeeStudVoucher</c> at FeeStudVoucherIdSource
		///</summary>
		[ChildEntityType(typeof(FeeStudVoucher))]
		FeeStudVoucher,
		
		///<summary>
		/// Composite Property for <c>SeUser</c> at SeUserIdSource
		///</summary>
		[ChildEntityType(typeof(SeUser))]
		SeUser,
		///<summary>
		/// Collection of <c>FeeStudVoucherItem</c> as OneToMany for FeeStudVoucherCrsItemCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudVoucherCrsItem>))]
		FeeStudVoucherCrsItemCollection,
		///<summary>
		/// Collection of <c>FeeStudVoucherItem</c> as OneToMany for FeeItemTrnsBlncCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeItemTrnsBlnc>))]
		FeeItemTrnsBlncCollection,
	}
	
	#endregion FeeStudVoucherItemChildEntityTypes
	
	#region FeeStudVoucherItemFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;FeeStudVoucherItemColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeStudVoucherItem"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeStudVoucherItemFilterBuilder : SqlFilterBuilder<FeeStudVoucherItemColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeStudVoucherItemFilterBuilder class.
		/// </summary>
		public FeeStudVoucherItemFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeStudVoucherItemFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeStudVoucherItemFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeStudVoucherItemFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeStudVoucherItemFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeStudVoucherItemFilterBuilder
	
	#region FeeStudVoucherItemParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;FeeStudVoucherItemColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeStudVoucherItem"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeStudVoucherItemParameterBuilder : ParameterizedSqlFilterBuilder<FeeStudVoucherItemColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeStudVoucherItemParameterBuilder class.
		/// </summary>
		public FeeStudVoucherItemParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeStudVoucherItemParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeStudVoucherItemParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeStudVoucherItemParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeStudVoucherItemParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeStudVoucherItemParameterBuilder
	
	#region FeeStudVoucherItemSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;FeeStudVoucherItemColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeStudVoucherItem"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class FeeStudVoucherItemSortBuilder : SqlSortBuilder<FeeStudVoucherItemColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeStudVoucherItemSqlSortBuilder class.
		/// </summary>
		public FeeStudVoucherItemSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion FeeStudVoucherItemSortBuilder
	
} // end namespace
