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
	/// This class is the base class for any <see cref="FeeInvoiceProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class FeeInvoiceProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.FeeInvoice, UMIS_VER2.BusinessLyer.FeeInvoiceKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeInvoiceKey key)
		{
			return Delete(transactionManager, key.FeeInvoiceId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_feeInvoiceId">فاتورة كفيل- or credit memo. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _feeInvoiceId)
		{
			return Delete(null, _feeInvoiceId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeInvoiceId">فاتورة كفيل- or credit memo. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _feeInvoiceId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_INVOICE_ED_STUD key.
		///		FK_FEE_INVOICE_ED_STUD Description: 
		/// </summary>
		/// <param name="_edStudId">later on</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeInvoice objects.</returns>
		public TList<FeeInvoice> GetByEdStudId(System.Decimal? _edStudId)
		{
			int count = -1;
			return GetByEdStudId(_edStudId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_INVOICE_ED_STUD key.
		///		FK_FEE_INVOICE_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">later on</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeInvoice objects.</returns>
		/// <remarks></remarks>
		public TList<FeeInvoice> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_INVOICE_ED_STUD key.
		///		FK_FEE_INVOICE_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">later on</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeInvoice objects.</returns>
		public TList<FeeInvoice> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_INVOICE_ED_STUD key.
		///		fkFeeInvoiceEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId">later on</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeInvoice objects.</returns>
		public TList<FeeInvoice> GetByEdStudId(System.Decimal? _edStudId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudId(null, _edStudId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_INVOICE_ED_STUD key.
		///		fkFeeInvoiceEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId">later on</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeInvoice objects.</returns>
		public TList<FeeInvoice> GetByEdStudId(System.Decimal? _edStudId, int start, int pageLength,out int count)
		{
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_INVOICE_ED_STUD key.
		///		FK_FEE_INVOICE_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">later on</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeInvoice objects.</returns>
		public abstract TList<FeeInvoice> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_INVOICE_FEE_CDE_INVOC_STATUS key.
		///		FK_FEE_INVOICE_FEE_CDE_INVOC_STATUS Description: 
		/// </summary>
		/// <param name="_feeCdeInvocStatusId">new-review-paied-cancel</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeInvoice objects.</returns>
		public TList<FeeInvoice> GetByFeeCdeInvocStatusId(System.Int32 _feeCdeInvocStatusId)
		{
			int count = -1;
			return GetByFeeCdeInvocStatusId(_feeCdeInvocStatusId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_INVOICE_FEE_CDE_INVOC_STATUS key.
		///		FK_FEE_INVOICE_FEE_CDE_INVOC_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeInvocStatusId">new-review-paied-cancel</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeInvoice objects.</returns>
		/// <remarks></remarks>
		public TList<FeeInvoice> GetByFeeCdeInvocStatusId(TransactionManager transactionManager, System.Int32 _feeCdeInvocStatusId)
		{
			int count = -1;
			return GetByFeeCdeInvocStatusId(transactionManager, _feeCdeInvocStatusId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_INVOICE_FEE_CDE_INVOC_STATUS key.
		///		FK_FEE_INVOICE_FEE_CDE_INVOC_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeInvocStatusId">new-review-paied-cancel</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeInvoice objects.</returns>
		public TList<FeeInvoice> GetByFeeCdeInvocStatusId(TransactionManager transactionManager, System.Int32 _feeCdeInvocStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCdeInvocStatusId(transactionManager, _feeCdeInvocStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_INVOICE_FEE_CDE_INVOC_STATUS key.
		///		fkFeeInvoiceFeeCdeInvocStatus Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeCdeInvocStatusId">new-review-paied-cancel</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeInvoice objects.</returns>
		public TList<FeeInvoice> GetByFeeCdeInvocStatusId(System.Int32 _feeCdeInvocStatusId, int start, int pageLength)
		{
			int count =  -1;
			return GetByFeeCdeInvocStatusId(null, _feeCdeInvocStatusId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_INVOICE_FEE_CDE_INVOC_STATUS key.
		///		fkFeeInvoiceFeeCdeInvocStatus Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeCdeInvocStatusId">new-review-paied-cancel</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeInvoice objects.</returns>
		public TList<FeeInvoice> GetByFeeCdeInvocStatusId(System.Int32 _feeCdeInvocStatusId, int start, int pageLength,out int count)
		{
			return GetByFeeCdeInvocStatusId(null, _feeCdeInvocStatusId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_INVOICE_FEE_CDE_INVOC_STATUS key.
		///		FK_FEE_INVOICE_FEE_CDE_INVOC_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeInvocStatusId">new-review-paied-cancel</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeInvoice objects.</returns>
		public abstract TList<FeeInvoice> GetByFeeCdeInvocStatusId(TransactionManager transactionManager, System.Int32 _feeCdeInvocStatusId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_INVOICE_FEE_INVOICE key.
		///		FK_FEE_INVOICE_FEE_INVOICE Description: 
		/// </summary>
		/// <param name="_feeInvoicePrntId">in case of Credit memo record type_id=2</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeInvoice objects.</returns>
		public TList<FeeInvoice> GetByFeeInvoicePrntId(System.Decimal? _feeInvoicePrntId)
		{
			int count = -1;
			return GetByFeeInvoicePrntId(_feeInvoicePrntId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_INVOICE_FEE_INVOICE key.
		///		FK_FEE_INVOICE_FEE_INVOICE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeInvoicePrntId">in case of Credit memo record type_id=2</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeInvoice objects.</returns>
		/// <remarks></remarks>
		public TList<FeeInvoice> GetByFeeInvoicePrntId(TransactionManager transactionManager, System.Decimal? _feeInvoicePrntId)
		{
			int count = -1;
			return GetByFeeInvoicePrntId(transactionManager, _feeInvoicePrntId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_INVOICE_FEE_INVOICE key.
		///		FK_FEE_INVOICE_FEE_INVOICE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeInvoicePrntId">in case of Credit memo record type_id=2</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeInvoice objects.</returns>
		public TList<FeeInvoice> GetByFeeInvoicePrntId(TransactionManager transactionManager, System.Decimal? _feeInvoicePrntId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeInvoicePrntId(transactionManager, _feeInvoicePrntId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_INVOICE_FEE_INVOICE key.
		///		fkFeeInvoiceFeeInvoice Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeInvoicePrntId">in case of Credit memo record type_id=2</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeInvoice objects.</returns>
		public TList<FeeInvoice> GetByFeeInvoicePrntId(System.Decimal? _feeInvoicePrntId, int start, int pageLength)
		{
			int count =  -1;
			return GetByFeeInvoicePrntId(null, _feeInvoicePrntId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_INVOICE_FEE_INVOICE key.
		///		fkFeeInvoiceFeeInvoice Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeInvoicePrntId">in case of Credit memo record type_id=2</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeInvoice objects.</returns>
		public TList<FeeInvoice> GetByFeeInvoicePrntId(System.Decimal? _feeInvoicePrntId, int start, int pageLength,out int count)
		{
			return GetByFeeInvoicePrntId(null, _feeInvoicePrntId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_INVOICE_FEE_INVOICE key.
		///		FK_FEE_INVOICE_FEE_INVOICE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeInvoicePrntId">in case of Credit memo record type_id=2</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeInvoice objects.</returns>
		public abstract TList<FeeInvoice> GetByFeeInvoicePrntId(TransactionManager transactionManager, System.Decimal? _feeInvoicePrntId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_INVOICE_GS_CODE_CURRENCY key.
		///		FK_FEE_INVOICE_GS_CODE_CURRENCY Description: 
		/// </summary>
		/// <param name="_gsCodeCurrencyId">عملة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeInvoice objects.</returns>
		public TList<FeeInvoice> GetByGsCodeCurrencyId(System.Decimal _gsCodeCurrencyId)
		{
			int count = -1;
			return GetByGsCodeCurrencyId(_gsCodeCurrencyId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_INVOICE_GS_CODE_CURRENCY key.
		///		FK_FEE_INVOICE_GS_CODE_CURRENCY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeCurrencyId">عملة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeInvoice objects.</returns>
		/// <remarks></remarks>
		public TList<FeeInvoice> GetByGsCodeCurrencyId(TransactionManager transactionManager, System.Decimal _gsCodeCurrencyId)
		{
			int count = -1;
			return GetByGsCodeCurrencyId(transactionManager, _gsCodeCurrencyId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_INVOICE_GS_CODE_CURRENCY key.
		///		FK_FEE_INVOICE_GS_CODE_CURRENCY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeCurrencyId">عملة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeInvoice objects.</returns>
		public TList<FeeInvoice> GetByGsCodeCurrencyId(TransactionManager transactionManager, System.Decimal _gsCodeCurrencyId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeCurrencyId(transactionManager, _gsCodeCurrencyId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_INVOICE_GS_CODE_CURRENCY key.
		///		fkFeeInvoiceGsCodeCurrency Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeCurrencyId">عملة</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeInvoice objects.</returns>
		public TList<FeeInvoice> GetByGsCodeCurrencyId(System.Decimal _gsCodeCurrencyId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodeCurrencyId(null, _gsCodeCurrencyId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_INVOICE_GS_CODE_CURRENCY key.
		///		fkFeeInvoiceGsCodeCurrency Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeCurrencyId">عملة</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeInvoice objects.</returns>
		public TList<FeeInvoice> GetByGsCodeCurrencyId(System.Decimal _gsCodeCurrencyId, int start, int pageLength,out int count)
		{
			return GetByGsCodeCurrencyId(null, _gsCodeCurrencyId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_INVOICE_GS_CODE_CURRENCY key.
		///		FK_FEE_INVOICE_GS_CODE_CURRENCY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeCurrencyId">عملة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeInvoice objects.</returns>
		public abstract TList<FeeInvoice> GetByGsCodeCurrencyId(TransactionManager transactionManager, System.Decimal _gsCodeCurrencyId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_INVOICE_SPO_SPONSOR key.
		///		FK_FEE_INVOICE_SPO_SPONSOR Description: 
		/// </summary>
		/// <param name="_spoSponsorId">XXORGANIZATION_ID</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeInvoice objects.</returns>
		public TList<FeeInvoice> GetBySpoSponsorId(System.Decimal? _spoSponsorId)
		{
			int count = -1;
			return GetBySpoSponsorId(_spoSponsorId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_INVOICE_SPO_SPONSOR key.
		///		FK_FEE_INVOICE_SPO_SPONSOR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorId">XXORGANIZATION_ID</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeInvoice objects.</returns>
		/// <remarks></remarks>
		public TList<FeeInvoice> GetBySpoSponsorId(TransactionManager transactionManager, System.Decimal? _spoSponsorId)
		{
			int count = -1;
			return GetBySpoSponsorId(transactionManager, _spoSponsorId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_INVOICE_SPO_SPONSOR key.
		///		FK_FEE_INVOICE_SPO_SPONSOR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorId">XXORGANIZATION_ID</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeInvoice objects.</returns>
		public TList<FeeInvoice> GetBySpoSponsorId(TransactionManager transactionManager, System.Decimal? _spoSponsorId, int start, int pageLength)
		{
			int count = -1;
			return GetBySpoSponsorId(transactionManager, _spoSponsorId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_INVOICE_SPO_SPONSOR key.
		///		fkFeeInvoiceSpoSponsor Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_spoSponsorId">XXORGANIZATION_ID</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeInvoice objects.</returns>
		public TList<FeeInvoice> GetBySpoSponsorId(System.Decimal? _spoSponsorId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySpoSponsorId(null, _spoSponsorId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_INVOICE_SPO_SPONSOR key.
		///		fkFeeInvoiceSpoSponsor Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_spoSponsorId">XXORGANIZATION_ID</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeInvoice objects.</returns>
		public TList<FeeInvoice> GetBySpoSponsorId(System.Decimal? _spoSponsorId, int start, int pageLength,out int count)
		{
			return GetBySpoSponsorId(null, _spoSponsorId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_INVOICE_SPO_SPONSOR key.
		///		FK_FEE_INVOICE_SPO_SPONSOR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorId">XXORGANIZATION_ID</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeInvoice objects.</returns>
		public abstract TList<FeeInvoice> GetBySpoSponsorId(TransactionManager transactionManager, System.Decimal? _spoSponsorId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.FeeInvoice Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeInvoiceKey key, int start, int pageLength)
		{
			return GetByFeeInvoiceId(transactionManager, key.FeeInvoiceId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_FEE_INVOICE index.
		/// </summary>
		/// <param name="_feeInvoiceId">فاتورة كفيل- or credit memo</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeInvoice"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeInvoice GetByFeeInvoiceId(System.Decimal _feeInvoiceId)
		{
			int count = -1;
			return GetByFeeInvoiceId(null,_feeInvoiceId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_INVOICE index.
		/// </summary>
		/// <param name="_feeInvoiceId">فاتورة كفيل- or credit memo</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeInvoice"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeInvoice GetByFeeInvoiceId(System.Decimal _feeInvoiceId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeInvoiceId(null, _feeInvoiceId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_INVOICE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeInvoiceId">فاتورة كفيل- or credit memo</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeInvoice"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeInvoice GetByFeeInvoiceId(TransactionManager transactionManager, System.Decimal _feeInvoiceId)
		{
			int count = -1;
			return GetByFeeInvoiceId(transactionManager, _feeInvoiceId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_INVOICE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeInvoiceId">فاتورة كفيل- or credit memo</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeInvoice"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeInvoice GetByFeeInvoiceId(TransactionManager transactionManager, System.Decimal _feeInvoiceId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeInvoiceId(transactionManager, _feeInvoiceId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_INVOICE index.
		/// </summary>
		/// <param name="_feeInvoiceId">فاتورة كفيل- or credit memo</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeInvoice"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeInvoice GetByFeeInvoiceId(System.Decimal _feeInvoiceId, int start, int pageLength, out int count)
		{
			return GetByFeeInvoiceId(null, _feeInvoiceId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_INVOICE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeInvoiceId">فاتورة كفيل- or credit memo</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeInvoice"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.FeeInvoice GetByFeeInvoiceId(TransactionManager transactionManager, System.Decimal _feeInvoiceId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;FeeInvoice&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;FeeInvoice&gt;"/></returns>
		public static TList<FeeInvoice> Fill(IDataReader reader, TList<FeeInvoice> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.FeeInvoice c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("FeeInvoice")
					.Append("|").Append((System.Decimal)reader["FEE_INVOICE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<FeeInvoice>(
					key.ToString(), // EntityTrackingKey
					"FeeInvoice",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.FeeInvoice();
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
					c.FeeInvoiceId = (System.Decimal)reader["FEE_INVOICE_ID"];
					c.OriginalFeeInvoiceId = c.FeeInvoiceId;
					c.SpoSponsorId = Convert.IsDBNull(reader["SPO_SPONSOR_ID"]) ? null : (System.Decimal?)reader["SPO_SPONSOR_ID"];
					c.EdStudId = Convert.IsDBNull(reader["ED_STUD_ID"]) ? null : (System.Decimal?)reader["ED_STUD_ID"];
					c.InvocDate = (System.DateTime)reader["INVOC_DATE"];
					c.InvocNum = (System.String)reader["INVOC_NUM"];
					c.SeUserId = Convert.IsDBNull(reader["SE_USER_ID"]) ? null : (System.Decimal?)reader["SE_USER_ID"];
					c.LastDate = Convert.IsDBNull(reader["LAST_DATE"]) ? null : (System.DateTime?)reader["LAST_DATE"];
					c.TotInvocAmnt = (System.Decimal)reader["TOT_INVOC_AMNT"];
					c.TotRemainAmnt = (System.Decimal)reader["TOT_REMAIN_AMNT"];
					c.DiscTypeId = Convert.IsDBNull(reader["DISC_TYPE_ID"]) ? null : (System.Int32?)reader["DISC_TYPE_ID"];
					c.DiscAmount = Convert.IsDBNull(reader["DISC_AMOUNT"]) ? null : (System.Decimal?)reader["DISC_AMOUNT"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
					c.DueDate = Convert.IsDBNull(reader["DUE_DATE"]) ? null : (System.DateTime?)reader["DUE_DATE"];
					c.FeeCdeInvocStatusId = (System.Int32)reader["FEE_CDE_INVOC_STATUS_ID"];
					c.InvocTypeId = (System.Int32)reader["INVOC_TYPE_ID"];
					c.FeeInvoicePrntId = Convert.IsDBNull(reader["FEE_INVOICE_PRNT_ID"]) ? null : (System.Decimal?)reader["FEE_INVOICE_PRNT_ID"];
					c.AttchdDocPath = Convert.IsDBNull(reader["ATTCHD_DOC_PATH"]) ? null : (System.String)reader["ATTCHD_DOC_PATH"];
					c.GsCodeCurrencyId = (System.Decimal)reader["GS_CODE_CURRENCY_ID"];
					c.UserName = Convert.IsDBNull(reader["User_Name"]) ? null : (System.String)reader["User_Name"];
					c.CancelFlg = Convert.IsDBNull(reader["CANCEL_FLG"]) ? null : (System.Boolean?)reader["CANCEL_FLG"];
					c.CancelDate = Convert.IsDBNull(reader["CANCEL_DATE"]) ? null : (System.DateTime?)reader["CANCEL_DATE"];
					c.SeUserCnclId = Convert.IsDBNull(reader["SE_USER_CNCL_ID"]) ? null : (System.Decimal?)reader["SE_USER_CNCL_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeInvoice"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeInvoice"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.FeeInvoice entity)
		{
			if (!reader.Read()) return;
			
			entity.FeeInvoiceId = (System.Decimal)reader[((int)FeeInvoiceColumn.FeeInvoiceId - 1)];
			entity.OriginalFeeInvoiceId = (System.Decimal)reader["FEE_INVOICE_ID"];
			entity.SpoSponsorId = (reader.IsDBNull(((int)FeeInvoiceColumn.SpoSponsorId - 1)))?null:(System.Decimal?)reader[((int)FeeInvoiceColumn.SpoSponsorId - 1)];
			entity.EdStudId = (reader.IsDBNull(((int)FeeInvoiceColumn.EdStudId - 1)))?null:(System.Decimal?)reader[((int)FeeInvoiceColumn.EdStudId - 1)];
			entity.InvocDate = (System.DateTime)reader[((int)FeeInvoiceColumn.InvocDate - 1)];
			entity.InvocNum = (System.String)reader[((int)FeeInvoiceColumn.InvocNum - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)FeeInvoiceColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)FeeInvoiceColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)FeeInvoiceColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)FeeInvoiceColumn.LastDate - 1)];
			entity.TotInvocAmnt = (System.Decimal)reader[((int)FeeInvoiceColumn.TotInvocAmnt - 1)];
			entity.TotRemainAmnt = (System.Decimal)reader[((int)FeeInvoiceColumn.TotRemainAmnt - 1)];
			entity.DiscTypeId = (reader.IsDBNull(((int)FeeInvoiceColumn.DiscTypeId - 1)))?null:(System.Int32?)reader[((int)FeeInvoiceColumn.DiscTypeId - 1)];
			entity.DiscAmount = (reader.IsDBNull(((int)FeeInvoiceColumn.DiscAmount - 1)))?null:(System.Decimal?)reader[((int)FeeInvoiceColumn.DiscAmount - 1)];
			entity.Notes = (reader.IsDBNull(((int)FeeInvoiceColumn.Notes - 1)))?null:(System.String)reader[((int)FeeInvoiceColumn.Notes - 1)];
			entity.DueDate = (reader.IsDBNull(((int)FeeInvoiceColumn.DueDate - 1)))?null:(System.DateTime?)reader[((int)FeeInvoiceColumn.DueDate - 1)];
			entity.FeeCdeInvocStatusId = (System.Int32)reader[((int)FeeInvoiceColumn.FeeCdeInvocStatusId - 1)];
			entity.InvocTypeId = (System.Int32)reader[((int)FeeInvoiceColumn.InvocTypeId - 1)];
			entity.FeeInvoicePrntId = (reader.IsDBNull(((int)FeeInvoiceColumn.FeeInvoicePrntId - 1)))?null:(System.Decimal?)reader[((int)FeeInvoiceColumn.FeeInvoicePrntId - 1)];
			entity.AttchdDocPath = (reader.IsDBNull(((int)FeeInvoiceColumn.AttchdDocPath - 1)))?null:(System.String)reader[((int)FeeInvoiceColumn.AttchdDocPath - 1)];
			entity.GsCodeCurrencyId = (System.Decimal)reader[((int)FeeInvoiceColumn.GsCodeCurrencyId - 1)];
			entity.UserName = (reader.IsDBNull(((int)FeeInvoiceColumn.UserName - 1)))?null:(System.String)reader[((int)FeeInvoiceColumn.UserName - 1)];
			entity.CancelFlg = (reader.IsDBNull(((int)FeeInvoiceColumn.CancelFlg - 1)))?null:(System.Boolean?)reader[((int)FeeInvoiceColumn.CancelFlg - 1)];
			entity.CancelDate = (reader.IsDBNull(((int)FeeInvoiceColumn.CancelDate - 1)))?null:(System.DateTime?)reader[((int)FeeInvoiceColumn.CancelDate - 1)];
			entity.SeUserCnclId = (reader.IsDBNull(((int)FeeInvoiceColumn.SeUserCnclId - 1)))?null:(System.Decimal?)reader[((int)FeeInvoiceColumn.SeUserCnclId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeInvoice"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeInvoice"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.FeeInvoice entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.FeeInvoiceId = (System.Decimal)dataRow["FEE_INVOICE_ID"];
			entity.OriginalFeeInvoiceId = (System.Decimal)dataRow["FEE_INVOICE_ID"];
			entity.SpoSponsorId = Convert.IsDBNull(dataRow["SPO_SPONSOR_ID"]) ? null : (System.Decimal?)dataRow["SPO_SPONSOR_ID"];
			entity.EdStudId = Convert.IsDBNull(dataRow["ED_STUD_ID"]) ? null : (System.Decimal?)dataRow["ED_STUD_ID"];
			entity.InvocDate = (System.DateTime)dataRow["INVOC_DATE"];
			entity.InvocNum = (System.String)dataRow["INVOC_NUM"];
			entity.SeUserId = Convert.IsDBNull(dataRow["SE_USER_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_ID"];
			entity.LastDate = Convert.IsDBNull(dataRow["LAST_DATE"]) ? null : (System.DateTime?)dataRow["LAST_DATE"];
			entity.TotInvocAmnt = (System.Decimal)dataRow["TOT_INVOC_AMNT"];
			entity.TotRemainAmnt = (System.Decimal)dataRow["TOT_REMAIN_AMNT"];
			entity.DiscTypeId = Convert.IsDBNull(dataRow["DISC_TYPE_ID"]) ? null : (System.Int32?)dataRow["DISC_TYPE_ID"];
			entity.DiscAmount = Convert.IsDBNull(dataRow["DISC_AMOUNT"]) ? null : (System.Decimal?)dataRow["DISC_AMOUNT"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
			entity.DueDate = Convert.IsDBNull(dataRow["DUE_DATE"]) ? null : (System.DateTime?)dataRow["DUE_DATE"];
			entity.FeeCdeInvocStatusId = (System.Int32)dataRow["FEE_CDE_INVOC_STATUS_ID"];
			entity.InvocTypeId = (System.Int32)dataRow["INVOC_TYPE_ID"];
			entity.FeeInvoicePrntId = Convert.IsDBNull(dataRow["FEE_INVOICE_PRNT_ID"]) ? null : (System.Decimal?)dataRow["FEE_INVOICE_PRNT_ID"];
			entity.AttchdDocPath = Convert.IsDBNull(dataRow["ATTCHD_DOC_PATH"]) ? null : (System.String)dataRow["ATTCHD_DOC_PATH"];
			entity.GsCodeCurrencyId = (System.Decimal)dataRow["GS_CODE_CURRENCY_ID"];
			entity.UserName = Convert.IsDBNull(dataRow["User_Name"]) ? null : (System.String)dataRow["User_Name"];
			entity.CancelFlg = Convert.IsDBNull(dataRow["CANCEL_FLG"]) ? null : (System.Boolean?)dataRow["CANCEL_FLG"];
			entity.CancelDate = Convert.IsDBNull(dataRow["CANCEL_DATE"]) ? null : (System.DateTime?)dataRow["CANCEL_DATE"];
			entity.SeUserCnclId = Convert.IsDBNull(dataRow["SE_USER_CNCL_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_CNCL_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeInvoice"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeInvoice Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeInvoice entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdStudIdSource	
			if (CanDeepLoad(entity, "EdStud|EdStudIdSource", deepLoadType, innerList) 
				&& entity.EdStudIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdStudId ?? 0.0m);
				EdStud tmpEntity = EntityManager.LocateEntity<EdStud>(EntityLocator.ConstructKeyFromPkItems(typeof(EdStud), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdStudIdSource = tmpEntity;
				else
					entity.EdStudIdSource = DataRepository.EdStudProvider.GetByEdStudId(transactionManager, (entity.EdStudId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdStudIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdStudProvider.DeepLoad(transactionManager, entity.EdStudIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdStudIdSource

			#region FeeCdeInvocStatusIdSource	
			if (CanDeepLoad(entity, "FeeCdeInvocStatus|FeeCdeInvocStatusIdSource", deepLoadType, innerList) 
				&& entity.FeeCdeInvocStatusIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.FeeCdeInvocStatusId;
				FeeCdeInvocStatus tmpEntity = EntityManager.LocateEntity<FeeCdeInvocStatus>(EntityLocator.ConstructKeyFromPkItems(typeof(FeeCdeInvocStatus), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.FeeCdeInvocStatusIdSource = tmpEntity;
				else
					entity.FeeCdeInvocStatusIdSource = DataRepository.FeeCdeInvocStatusProvider.GetByFeeCdeInvocStatusId(transactionManager, entity.FeeCdeInvocStatusId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeCdeInvocStatusIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.FeeCdeInvocStatusIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.FeeCdeInvocStatusProvider.DeepLoad(transactionManager, entity.FeeCdeInvocStatusIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion FeeCdeInvocStatusIdSource

			#region FeeInvoicePrntIdSource	
			if (CanDeepLoad(entity, "FeeInvoice|FeeInvoicePrntIdSource", deepLoadType, innerList) 
				&& entity.FeeInvoicePrntIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.FeeInvoicePrntId ?? 0.0m);
				FeeInvoice tmpEntity = EntityManager.LocateEntity<FeeInvoice>(EntityLocator.ConstructKeyFromPkItems(typeof(FeeInvoice), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.FeeInvoicePrntIdSource = tmpEntity;
				else
					entity.FeeInvoicePrntIdSource = DataRepository.FeeInvoiceProvider.GetByFeeInvoiceId(transactionManager, (entity.FeeInvoicePrntId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeInvoicePrntIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.FeeInvoicePrntIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.FeeInvoiceProvider.DeepLoad(transactionManager, entity.FeeInvoicePrntIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion FeeInvoicePrntIdSource

			#region GsCodeCurrencyIdSource	
			if (CanDeepLoad(entity, "GsCodeCurrency|GsCodeCurrencyIdSource", deepLoadType, innerList) 
				&& entity.GsCodeCurrencyIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.GsCodeCurrencyId;
				GsCodeCurrency tmpEntity = EntityManager.LocateEntity<GsCodeCurrency>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodeCurrency), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodeCurrencyIdSource = tmpEntity;
				else
					entity.GsCodeCurrencyIdSource = DataRepository.GsCodeCurrencyProvider.GetByGsCodeCurrencyId(transactionManager, entity.GsCodeCurrencyId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodeCurrencyIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCodeCurrencyIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodeCurrencyProvider.DeepLoad(transactionManager, entity.GsCodeCurrencyIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCodeCurrencyIdSource

			#region SpoSponsorIdSource	
			if (CanDeepLoad(entity, "SpoSponsor|SpoSponsorIdSource", deepLoadType, innerList) 
				&& entity.SpoSponsorIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SpoSponsorId ?? 0.0m);
				SpoSponsor tmpEntity = EntityManager.LocateEntity<SpoSponsor>(EntityLocator.ConstructKeyFromPkItems(typeof(SpoSponsor), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SpoSponsorIdSource = tmpEntity;
				else
					entity.SpoSponsorIdSource = DataRepository.SpoSponsorProvider.GetBySpoSponsorId(transactionManager, (entity.SpoSponsorId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SpoSponsorIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SpoSponsorIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SpoSponsorProvider.DeepLoad(transactionManager, entity.SpoSponsorIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SpoSponsorIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByFeeInvoiceId methods when available
			
			#region FeeStudVoucherItemCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeStudVoucherItem>|FeeStudVoucherItemCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudVoucherItemCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeStudVoucherItemCollection = DataRepository.FeeStudVoucherItemProvider.GetByFeeInvoiceId(transactionManager, entity.FeeInvoiceId);

				if (deep && entity.FeeStudVoucherItemCollection.Count > 0)
				{
					deepHandles.Add("FeeStudVoucherItemCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudVoucherItem>) DataRepository.FeeStudVoucherItemProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudVoucherItemCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeInvoiceItemCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeInvoiceItem>|FeeInvoiceItemCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeInvoiceItemCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeInvoiceItemCollection = DataRepository.FeeInvoiceItemProvider.GetByFeeInvoiceId(transactionManager, entity.FeeInvoiceId);

				if (deep && entity.FeeInvoiceItemCollection.Count > 0)
				{
					deepHandles.Add("FeeInvoiceItemCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeInvoiceItem>) DataRepository.FeeInvoiceItemProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeInvoiceItemCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeVoucherInvocCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeVoucherInvoc>|FeeVoucherInvocCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeVoucherInvocCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeVoucherInvocCollection = DataRepository.FeeVoucherInvocProvider.GetByFeeInvoiceId(transactionManager, entity.FeeInvoiceId);

				if (deep && entity.FeeVoucherInvocCollection.Count > 0)
				{
					deepHandles.Add("FeeVoucherInvocCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeVoucherInvoc>) DataRepository.FeeVoucherInvocProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeVoucherInvocCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeInvoiceCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeInvoice>|FeeInvoiceCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeInvoiceCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeInvoiceCollection = DataRepository.FeeInvoiceProvider.GetByFeeInvoicePrntId(transactionManager, entity.FeeInvoiceId);

				if (deep && entity.FeeInvoiceCollection.Count > 0)
				{
					deepHandles.Add("FeeInvoiceCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeInvoice>) DataRepository.FeeInvoiceProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeInvoiceCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.FeeInvoice object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.FeeInvoice instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeInvoice Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeInvoice entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdStudIdSource
			if (CanDeepSave(entity, "EdStud|EdStudIdSource", deepSaveType, innerList) 
				&& entity.EdStudIdSource != null)
			{
				DataRepository.EdStudProvider.Save(transactionManager, entity.EdStudIdSource);
				entity.EdStudId = entity.EdStudIdSource.EdStudId;
			}
			#endregion 
			
			#region FeeCdeInvocStatusIdSource
			if (CanDeepSave(entity, "FeeCdeInvocStatus|FeeCdeInvocStatusIdSource", deepSaveType, innerList) 
				&& entity.FeeCdeInvocStatusIdSource != null)
			{
				DataRepository.FeeCdeInvocStatusProvider.Save(transactionManager, entity.FeeCdeInvocStatusIdSource);
				entity.FeeCdeInvocStatusId = entity.FeeCdeInvocStatusIdSource.FeeCdeInvocStatusId;
			}
			#endregion 
			
			#region FeeInvoicePrntIdSource
			if (CanDeepSave(entity, "FeeInvoice|FeeInvoicePrntIdSource", deepSaveType, innerList) 
				&& entity.FeeInvoicePrntIdSource != null)
			{
				DataRepository.FeeInvoiceProvider.Save(transactionManager, entity.FeeInvoicePrntIdSource);
				entity.FeeInvoicePrntId = entity.FeeInvoicePrntIdSource.FeeInvoiceId;
			}
			#endregion 
			
			#region GsCodeCurrencyIdSource
			if (CanDeepSave(entity, "GsCodeCurrency|GsCodeCurrencyIdSource", deepSaveType, innerList) 
				&& entity.GsCodeCurrencyIdSource != null)
			{
				DataRepository.GsCodeCurrencyProvider.Save(transactionManager, entity.GsCodeCurrencyIdSource);
				entity.GsCodeCurrencyId = entity.GsCodeCurrencyIdSource.GsCodeCurrencyId;
			}
			#endregion 
			
			#region SpoSponsorIdSource
			if (CanDeepSave(entity, "SpoSponsor|SpoSponsorIdSource", deepSaveType, innerList) 
				&& entity.SpoSponsorIdSource != null)
			{
				DataRepository.SpoSponsorProvider.Save(transactionManager, entity.SpoSponsorIdSource);
				entity.SpoSponsorId = entity.SpoSponsorIdSource.SpoSponsorId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<FeeStudVoucherItem>
				if (CanDeepSave(entity.FeeStudVoucherItemCollection, "List<FeeStudVoucherItem>|FeeStudVoucherItemCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeStudVoucherItem child in entity.FeeStudVoucherItemCollection)
					{
						if(child.FeeInvoiceIdSource != null)
						{
							child.FeeInvoiceId = child.FeeInvoiceIdSource.FeeInvoiceId;
						}
						else
						{
							child.FeeInvoiceId = entity.FeeInvoiceId;
						}

					}

					if (entity.FeeStudVoucherItemCollection.Count > 0 || entity.FeeStudVoucherItemCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeStudVoucherItemProvider.Save(transactionManager, entity.FeeStudVoucherItemCollection);
						
						deepHandles.Add("FeeStudVoucherItemCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeStudVoucherItem >) DataRepository.FeeStudVoucherItemProvider.DeepSave,
							new object[] { transactionManager, entity.FeeStudVoucherItemCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeInvoiceItem>
				if (CanDeepSave(entity.FeeInvoiceItemCollection, "List<FeeInvoiceItem>|FeeInvoiceItemCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeInvoiceItem child in entity.FeeInvoiceItemCollection)
					{
						if(child.FeeInvoiceIdSource != null)
						{
							child.FeeInvoiceId = child.FeeInvoiceIdSource.FeeInvoiceId;
						}
						else
						{
							child.FeeInvoiceId = entity.FeeInvoiceId;
						}

					}

					if (entity.FeeInvoiceItemCollection.Count > 0 || entity.FeeInvoiceItemCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeInvoiceItemProvider.Save(transactionManager, entity.FeeInvoiceItemCollection);
						
						deepHandles.Add("FeeInvoiceItemCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeInvoiceItem >) DataRepository.FeeInvoiceItemProvider.DeepSave,
							new object[] { transactionManager, entity.FeeInvoiceItemCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeVoucherInvoc>
				if (CanDeepSave(entity.FeeVoucherInvocCollection, "List<FeeVoucherInvoc>|FeeVoucherInvocCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeVoucherInvoc child in entity.FeeVoucherInvocCollection)
					{
						if(child.FeeInvoiceIdSource != null)
						{
							child.FeeInvoiceId = child.FeeInvoiceIdSource.FeeInvoiceId;
						}
						else
						{
							child.FeeInvoiceId = entity.FeeInvoiceId;
						}

					}

					if (entity.FeeVoucherInvocCollection.Count > 0 || entity.FeeVoucherInvocCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeVoucherInvocProvider.Save(transactionManager, entity.FeeVoucherInvocCollection);
						
						deepHandles.Add("FeeVoucherInvocCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeVoucherInvoc >) DataRepository.FeeVoucherInvocProvider.DeepSave,
							new object[] { transactionManager, entity.FeeVoucherInvocCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeInvoice>
				if (CanDeepSave(entity.FeeInvoiceCollection, "List<FeeInvoice>|FeeInvoiceCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeInvoice child in entity.FeeInvoiceCollection)
					{
						if(child.FeeInvoicePrntIdSource != null)
						{
							child.FeeInvoicePrntId = child.FeeInvoicePrntIdSource.FeeInvoiceId;
						}
						else
						{
							child.FeeInvoicePrntId = entity.FeeInvoiceId;
						}

					}

					if (entity.FeeInvoiceCollection.Count > 0 || entity.FeeInvoiceCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeInvoiceProvider.Save(transactionManager, entity.FeeInvoiceCollection);
						
						deepHandles.Add("FeeInvoiceCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeInvoice >) DataRepository.FeeInvoiceProvider.DeepSave,
							new object[] { transactionManager, entity.FeeInvoiceCollection, deepSaveType, childTypes, innerList }
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
	
	#region FeeInvoiceChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.FeeInvoice</c>
	///</summary>
	public enum FeeInvoiceChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdStud</c> at EdStudIdSource
		///</summary>
		[ChildEntityType(typeof(EdStud))]
		EdStud,
		
		///<summary>
		/// Composite Property for <c>FeeCdeInvocStatus</c> at FeeCdeInvocStatusIdSource
		///</summary>
		[ChildEntityType(typeof(FeeCdeInvocStatus))]
		FeeCdeInvocStatus,
		
		///<summary>
		/// Composite Property for <c>FeeInvoice</c> at FeeInvoicePrntIdSource
		///</summary>
		[ChildEntityType(typeof(FeeInvoice))]
		FeeInvoice,
		
		///<summary>
		/// Composite Property for <c>GsCodeCurrency</c> at GsCodeCurrencyIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeCurrency))]
		GsCodeCurrency,
		
		///<summary>
		/// Composite Property for <c>SpoSponsor</c> at SpoSponsorIdSource
		///</summary>
		[ChildEntityType(typeof(SpoSponsor))]
		SpoSponsor,
		///<summary>
		/// Collection of <c>FeeInvoice</c> as OneToMany for FeeStudVoucherItemCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudVoucherItem>))]
		FeeStudVoucherItemCollection,
		///<summary>
		/// Collection of <c>FeeInvoice</c> as OneToMany for FeeInvoiceItemCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeInvoiceItem>))]
		FeeInvoiceItemCollection,
		///<summary>
		/// Collection of <c>FeeInvoice</c> as OneToMany for FeeVoucherInvocCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeVoucherInvoc>))]
		FeeVoucherInvocCollection,
		///<summary>
		/// Collection of <c>FeeInvoice</c> as OneToMany for FeeInvoiceCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeInvoice>))]
		FeeInvoiceCollection,
	}
	
	#endregion FeeInvoiceChildEntityTypes
	
	#region FeeInvoiceFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;FeeInvoiceColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeInvoice"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeInvoiceFilterBuilder : SqlFilterBuilder<FeeInvoiceColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeInvoiceFilterBuilder class.
		/// </summary>
		public FeeInvoiceFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeInvoiceFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeInvoiceFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeInvoiceFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeInvoiceFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeInvoiceFilterBuilder
	
	#region FeeInvoiceParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;FeeInvoiceColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeInvoice"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeInvoiceParameterBuilder : ParameterizedSqlFilterBuilder<FeeInvoiceColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeInvoiceParameterBuilder class.
		/// </summary>
		public FeeInvoiceParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeInvoiceParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeInvoiceParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeInvoiceParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeInvoiceParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeInvoiceParameterBuilder
	
	#region FeeInvoiceSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;FeeInvoiceColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeInvoice"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class FeeInvoiceSortBuilder : SqlSortBuilder<FeeInvoiceColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeInvoiceSqlSortBuilder class.
		/// </summary>
		public FeeInvoiceSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion FeeInvoiceSortBuilder
	
} // end namespace
