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
	/// This class is the base class for any <see cref="FeeStudVoucherPayMthodProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class FeeStudVoucherPayMthodProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.FeeStudVoucherPayMthod, UMIS_VER2.BusinessLyer.FeeStudVoucherPayMthodKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeStudVoucherPayMthodKey key)
		{
			return Delete(transactionManager, key.FeeStudVoucherPayMthodId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_feeStudVoucherPayMthodId">دفع باكتر من طريقةKU( 53=MULTI_PAYMENT). Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _feeStudVoucherPayMthodId)
		{
			return Delete(null, _feeStudVoucherPayMthodId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudVoucherPayMthodId">دفع باكتر من طريقةKU( 53=MULTI_PAYMENT). Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _feeStudVoucherPayMthodId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_PAY_MTHOD_FEE_CODE_BANKS key.
		///		FK_FEE_STUD_VOUCHER_PAY_MTHOD_FEE_CODE_BANKS Description: 
		/// </summary>
		/// <param name="_feeCodeBankId">في حالة وسيلة الدفع "شيك" يتم ادخال البنك ورقم الحساب ورقم الشيك وتاريخ استحقاق الشيك</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucherPayMthod objects.</returns>
		public TList<FeeStudVoucherPayMthod> GetByFeeCodeBankId(System.Decimal? _feeCodeBankId)
		{
			int count = -1;
			return GetByFeeCodeBankId(_feeCodeBankId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_PAY_MTHOD_FEE_CODE_BANKS key.
		///		FK_FEE_STUD_VOUCHER_PAY_MTHOD_FEE_CODE_BANKS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeBankId">في حالة وسيلة الدفع "شيك" يتم ادخال البنك ورقم الحساب ورقم الشيك وتاريخ استحقاق الشيك</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucherPayMthod objects.</returns>
		/// <remarks></remarks>
		public TList<FeeStudVoucherPayMthod> GetByFeeCodeBankId(TransactionManager transactionManager, System.Decimal? _feeCodeBankId)
		{
			int count = -1;
			return GetByFeeCodeBankId(transactionManager, _feeCodeBankId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_PAY_MTHOD_FEE_CODE_BANKS key.
		///		FK_FEE_STUD_VOUCHER_PAY_MTHOD_FEE_CODE_BANKS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeBankId">في حالة وسيلة الدفع "شيك" يتم ادخال البنك ورقم الحساب ورقم الشيك وتاريخ استحقاق الشيك</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucherPayMthod objects.</returns>
		public TList<FeeStudVoucherPayMthod> GetByFeeCodeBankId(TransactionManager transactionManager, System.Decimal? _feeCodeBankId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCodeBankId(transactionManager, _feeCodeBankId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_PAY_MTHOD_FEE_CODE_BANKS key.
		///		fkFeeStudVoucherPayMthodFeeCodeBanks Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeCodeBankId">في حالة وسيلة الدفع "شيك" يتم ادخال البنك ورقم الحساب ورقم الشيك وتاريخ استحقاق الشيك</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucherPayMthod objects.</returns>
		public TList<FeeStudVoucherPayMthod> GetByFeeCodeBankId(System.Decimal? _feeCodeBankId, int start, int pageLength)
		{
			int count =  -1;
			return GetByFeeCodeBankId(null, _feeCodeBankId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_PAY_MTHOD_FEE_CODE_BANKS key.
		///		fkFeeStudVoucherPayMthodFeeCodeBanks Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeCodeBankId">في حالة وسيلة الدفع "شيك" يتم ادخال البنك ورقم الحساب ورقم الشيك وتاريخ استحقاق الشيك</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucherPayMthod objects.</returns>
		public TList<FeeStudVoucherPayMthod> GetByFeeCodeBankId(System.Decimal? _feeCodeBankId, int start, int pageLength,out int count)
		{
			return GetByFeeCodeBankId(null, _feeCodeBankId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_PAY_MTHOD_FEE_CODE_BANKS key.
		///		FK_FEE_STUD_VOUCHER_PAY_MTHOD_FEE_CODE_BANKS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeBankId">في حالة وسيلة الدفع "شيك" يتم ادخال البنك ورقم الحساب ورقم الشيك وتاريخ استحقاق الشيك</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucherPayMthod objects.</returns>
		public abstract TList<FeeStudVoucherPayMthod> GetByFeeCodeBankId(TransactionManager transactionManager, System.Decimal? _feeCodeBankId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_PAY_MTHOD_FEE_STUD_VOUCHER key.
		///		FK_FEE_STUD_VOUCHER_PAY_MTHOD_FEE_STUD_VOUCHER Description: 
		/// </summary>
		/// <param name="_feeStudVoucherId">اذن دفع/ايصال سداد</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucherPayMthod objects.</returns>
		public TList<FeeStudVoucherPayMthod> GetByFeeStudVoucherId(System.Decimal _feeStudVoucherId)
		{
			int count = -1;
			return GetByFeeStudVoucherId(_feeStudVoucherId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_PAY_MTHOD_FEE_STUD_VOUCHER key.
		///		FK_FEE_STUD_VOUCHER_PAY_MTHOD_FEE_STUD_VOUCHER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudVoucherId">اذن دفع/ايصال سداد</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucherPayMthod objects.</returns>
		/// <remarks></remarks>
		public TList<FeeStudVoucherPayMthod> GetByFeeStudVoucherId(TransactionManager transactionManager, System.Decimal _feeStudVoucherId)
		{
			int count = -1;
			return GetByFeeStudVoucherId(transactionManager, _feeStudVoucherId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_PAY_MTHOD_FEE_STUD_VOUCHER key.
		///		FK_FEE_STUD_VOUCHER_PAY_MTHOD_FEE_STUD_VOUCHER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudVoucherId">اذن دفع/ايصال سداد</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucherPayMthod objects.</returns>
		public TList<FeeStudVoucherPayMthod> GetByFeeStudVoucherId(TransactionManager transactionManager, System.Decimal _feeStudVoucherId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeStudVoucherId(transactionManager, _feeStudVoucherId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_PAY_MTHOD_FEE_STUD_VOUCHER key.
		///		fkFeeStudVoucherPayMthodFeeStudVoucher Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeStudVoucherId">اذن دفع/ايصال سداد</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucherPayMthod objects.</returns>
		public TList<FeeStudVoucherPayMthod> GetByFeeStudVoucherId(System.Decimal _feeStudVoucherId, int start, int pageLength)
		{
			int count =  -1;
			return GetByFeeStudVoucherId(null, _feeStudVoucherId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_PAY_MTHOD_FEE_STUD_VOUCHER key.
		///		fkFeeStudVoucherPayMthodFeeStudVoucher Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeStudVoucherId">اذن دفع/ايصال سداد</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucherPayMthod objects.</returns>
		public TList<FeeStudVoucherPayMthod> GetByFeeStudVoucherId(System.Decimal _feeStudVoucherId, int start, int pageLength,out int count)
		{
			return GetByFeeStudVoucherId(null, _feeStudVoucherId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_PAY_MTHOD_FEE_STUD_VOUCHER key.
		///		FK_FEE_STUD_VOUCHER_PAY_MTHOD_FEE_STUD_VOUCHER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudVoucherId">اذن دفع/ايصال سداد</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucherPayMthod objects.</returns>
		public abstract TList<FeeStudVoucherPayMthod> GetByFeeStudVoucherId(TransactionManager transactionManager, System.Decimal _feeStudVoucherId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_PAY_MTHOD_GS_CODE_PAY_METHOD key.
		///		FK_FEE_STUD_VOUCHER_PAY_MTHOD_GS_CODE_PAY_METHOD Description: 
		/// </summary>
		/// <param name="_gsCodePayMethodId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucherPayMthod objects.</returns>
		public TList<FeeStudVoucherPayMthod> GetByGsCodePayMethodId(System.Decimal _gsCodePayMethodId)
		{
			int count = -1;
			return GetByGsCodePayMethodId(_gsCodePayMethodId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_PAY_MTHOD_GS_CODE_PAY_METHOD key.
		///		FK_FEE_STUD_VOUCHER_PAY_MTHOD_GS_CODE_PAY_METHOD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodePayMethodId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucherPayMthod objects.</returns>
		/// <remarks></remarks>
		public TList<FeeStudVoucherPayMthod> GetByGsCodePayMethodId(TransactionManager transactionManager, System.Decimal _gsCodePayMethodId)
		{
			int count = -1;
			return GetByGsCodePayMethodId(transactionManager, _gsCodePayMethodId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_PAY_MTHOD_GS_CODE_PAY_METHOD key.
		///		FK_FEE_STUD_VOUCHER_PAY_MTHOD_GS_CODE_PAY_METHOD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodePayMethodId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucherPayMthod objects.</returns>
		public TList<FeeStudVoucherPayMthod> GetByGsCodePayMethodId(TransactionManager transactionManager, System.Decimal _gsCodePayMethodId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodePayMethodId(transactionManager, _gsCodePayMethodId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_PAY_MTHOD_GS_CODE_PAY_METHOD key.
		///		fkFeeStudVoucherPayMthodGsCodePayMethod Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodePayMethodId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucherPayMthod objects.</returns>
		public TList<FeeStudVoucherPayMthod> GetByGsCodePayMethodId(System.Decimal _gsCodePayMethodId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodePayMethodId(null, _gsCodePayMethodId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_PAY_MTHOD_GS_CODE_PAY_METHOD key.
		///		fkFeeStudVoucherPayMthodGsCodePayMethod Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodePayMethodId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucherPayMthod objects.</returns>
		public TList<FeeStudVoucherPayMthod> GetByGsCodePayMethodId(System.Decimal _gsCodePayMethodId, int start, int pageLength,out int count)
		{
			return GetByGsCodePayMethodId(null, _gsCodePayMethodId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_PAY_MTHOD_GS_CODE_PAY_METHOD key.
		///		FK_FEE_STUD_VOUCHER_PAY_MTHOD_GS_CODE_PAY_METHOD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodePayMethodId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucherPayMthod objects.</returns>
		public abstract TList<FeeStudVoucherPayMthod> GetByGsCodePayMethodId(TransactionManager transactionManager, System.Decimal _gsCodePayMethodId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_PAY_MTHOD_GS_CODE_PAY_MTHD_TYPE key.
		///		FK_FEE_STUD_VOUCHER_PAY_MTHOD_GS_CODE_PAY_MTHD_TYPE Description: 
		/// </summary>
		/// <param name="_gsCodePayMthdTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucherPayMthod objects.</returns>
		public TList<FeeStudVoucherPayMthod> GetByGsCodePayMthdTypeId(System.Int32? _gsCodePayMthdTypeId)
		{
			int count = -1;
			return GetByGsCodePayMthdTypeId(_gsCodePayMthdTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_PAY_MTHOD_GS_CODE_PAY_MTHD_TYPE key.
		///		FK_FEE_STUD_VOUCHER_PAY_MTHOD_GS_CODE_PAY_MTHD_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodePayMthdTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucherPayMthod objects.</returns>
		/// <remarks></remarks>
		public TList<FeeStudVoucherPayMthod> GetByGsCodePayMthdTypeId(TransactionManager transactionManager, System.Int32? _gsCodePayMthdTypeId)
		{
			int count = -1;
			return GetByGsCodePayMthdTypeId(transactionManager, _gsCodePayMthdTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_PAY_MTHOD_GS_CODE_PAY_MTHD_TYPE key.
		///		FK_FEE_STUD_VOUCHER_PAY_MTHOD_GS_CODE_PAY_MTHD_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodePayMthdTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucherPayMthod objects.</returns>
		public TList<FeeStudVoucherPayMthod> GetByGsCodePayMthdTypeId(TransactionManager transactionManager, System.Int32? _gsCodePayMthdTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodePayMthdTypeId(transactionManager, _gsCodePayMthdTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_PAY_MTHOD_GS_CODE_PAY_MTHD_TYPE key.
		///		fkFeeStudVoucherPayMthodGsCodePayMthdType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodePayMthdTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucherPayMthod objects.</returns>
		public TList<FeeStudVoucherPayMthod> GetByGsCodePayMthdTypeId(System.Int32? _gsCodePayMthdTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodePayMthdTypeId(null, _gsCodePayMthdTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_PAY_MTHOD_GS_CODE_PAY_MTHD_TYPE key.
		///		fkFeeStudVoucherPayMthodGsCodePayMthdType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodePayMthdTypeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucherPayMthod objects.</returns>
		public TList<FeeStudVoucherPayMthod> GetByGsCodePayMthdTypeId(System.Int32? _gsCodePayMthdTypeId, int start, int pageLength,out int count)
		{
			return GetByGsCodePayMthdTypeId(null, _gsCodePayMthdTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_PAY_MTHOD_GS_CODE_PAY_MTHD_TYPE key.
		///		FK_FEE_STUD_VOUCHER_PAY_MTHOD_GS_CODE_PAY_MTHD_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodePayMthdTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucherPayMthod objects.</returns>
		public abstract TList<FeeStudVoucherPayMthod> GetByGsCodePayMthdTypeId(TransactionManager transactionManager, System.Int32? _gsCodePayMthdTypeId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.FeeStudVoucherPayMthod Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeStudVoucherPayMthodKey key, int start, int pageLength)
		{
			return GetByFeeStudVoucherPayMthodId(transactionManager, key.FeeStudVoucherPayMthodId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_FEE_STUD_VOUCHER_PAY_MTHOD index.
		/// </summary>
		/// <param name="_feeStudVoucherPayMthodId">دفع باكتر من طريقةKU( 53=MULTI_PAYMENT)</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudVoucherPayMthod"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudVoucherPayMthod GetByFeeStudVoucherPayMthodId(System.Decimal _feeStudVoucherPayMthodId)
		{
			int count = -1;
			return GetByFeeStudVoucherPayMthodId(null,_feeStudVoucherPayMthodId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_STUD_VOUCHER_PAY_MTHOD index.
		/// </summary>
		/// <param name="_feeStudVoucherPayMthodId">دفع باكتر من طريقةKU( 53=MULTI_PAYMENT)</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudVoucherPayMthod"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudVoucherPayMthod GetByFeeStudVoucherPayMthodId(System.Decimal _feeStudVoucherPayMthodId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeStudVoucherPayMthodId(null, _feeStudVoucherPayMthodId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_STUD_VOUCHER_PAY_MTHOD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudVoucherPayMthodId">دفع باكتر من طريقةKU( 53=MULTI_PAYMENT)</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudVoucherPayMthod"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudVoucherPayMthod GetByFeeStudVoucherPayMthodId(TransactionManager transactionManager, System.Decimal _feeStudVoucherPayMthodId)
		{
			int count = -1;
			return GetByFeeStudVoucherPayMthodId(transactionManager, _feeStudVoucherPayMthodId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_STUD_VOUCHER_PAY_MTHOD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudVoucherPayMthodId">دفع باكتر من طريقةKU( 53=MULTI_PAYMENT)</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudVoucherPayMthod"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudVoucherPayMthod GetByFeeStudVoucherPayMthodId(TransactionManager transactionManager, System.Decimal _feeStudVoucherPayMthodId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeStudVoucherPayMthodId(transactionManager, _feeStudVoucherPayMthodId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_STUD_VOUCHER_PAY_MTHOD index.
		/// </summary>
		/// <param name="_feeStudVoucherPayMthodId">دفع باكتر من طريقةKU( 53=MULTI_PAYMENT)</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudVoucherPayMthod"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudVoucherPayMthod GetByFeeStudVoucherPayMthodId(System.Decimal _feeStudVoucherPayMthodId, int start, int pageLength, out int count)
		{
			return GetByFeeStudVoucherPayMthodId(null, _feeStudVoucherPayMthodId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_STUD_VOUCHER_PAY_MTHOD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudVoucherPayMthodId">دفع باكتر من طريقةKU( 53=MULTI_PAYMENT)</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudVoucherPayMthod"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.FeeStudVoucherPayMthod GetByFeeStudVoucherPayMthodId(TransactionManager transactionManager, System.Decimal _feeStudVoucherPayMthodId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_FEE_STUD_VOUCHER_PAY_MTHOD index.
		/// </summary>
		/// <param name="_feeStudVoucherId">اذن دفع/ايصال سداد</param>
		/// <param name="_gsCodePayMethodId"></param>
		/// <param name="_gsCodePayMthdTypeId"></param>
		/// <param name="_accntNum">رقم حساب البنك  فى حالة ايداع&&في حالة السداد من نوع "الشيك"  يجب اظهار البنوك للاختيار منها وبعد اختيار البنك يقوم النظام باظهار رقم الحساب الخاص بالبنك</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudVoucherPayMthod"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudVoucherPayMthod GetByFeeStudVoucherIdGsCodePayMethodIdGsCodePayMthdTypeIdAccntNum(System.Decimal _feeStudVoucherId, System.Decimal _gsCodePayMethodId, System.Int32? _gsCodePayMthdTypeId, System.String _accntNum)
		{
			int count = -1;
			return GetByFeeStudVoucherIdGsCodePayMethodIdGsCodePayMthdTypeIdAccntNum(null,_feeStudVoucherId, _gsCodePayMethodId, _gsCodePayMthdTypeId, _accntNum, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_STUD_VOUCHER_PAY_MTHOD index.
		/// </summary>
		/// <param name="_feeStudVoucherId">اذن دفع/ايصال سداد</param>
		/// <param name="_gsCodePayMethodId"></param>
		/// <param name="_gsCodePayMthdTypeId"></param>
		/// <param name="_accntNum">رقم حساب البنك  فى حالة ايداع&&في حالة السداد من نوع "الشيك"  يجب اظهار البنوك للاختيار منها وبعد اختيار البنك يقوم النظام باظهار رقم الحساب الخاص بالبنك</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudVoucherPayMthod"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudVoucherPayMthod GetByFeeStudVoucherIdGsCodePayMethodIdGsCodePayMthdTypeIdAccntNum(System.Decimal _feeStudVoucherId, System.Decimal _gsCodePayMethodId, System.Int32? _gsCodePayMthdTypeId, System.String _accntNum, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeStudVoucherIdGsCodePayMethodIdGsCodePayMthdTypeIdAccntNum(null, _feeStudVoucherId, _gsCodePayMethodId, _gsCodePayMthdTypeId, _accntNum, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_STUD_VOUCHER_PAY_MTHOD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudVoucherId">اذن دفع/ايصال سداد</param>
		/// <param name="_gsCodePayMethodId"></param>
		/// <param name="_gsCodePayMthdTypeId"></param>
		/// <param name="_accntNum">رقم حساب البنك  فى حالة ايداع&&في حالة السداد من نوع "الشيك"  يجب اظهار البنوك للاختيار منها وبعد اختيار البنك يقوم النظام باظهار رقم الحساب الخاص بالبنك</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudVoucherPayMthod"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudVoucherPayMthod GetByFeeStudVoucherIdGsCodePayMethodIdGsCodePayMthdTypeIdAccntNum(TransactionManager transactionManager, System.Decimal _feeStudVoucherId, System.Decimal _gsCodePayMethodId, System.Int32? _gsCodePayMthdTypeId, System.String _accntNum)
		{
			int count = -1;
			return GetByFeeStudVoucherIdGsCodePayMethodIdGsCodePayMthdTypeIdAccntNum(transactionManager, _feeStudVoucherId, _gsCodePayMethodId, _gsCodePayMthdTypeId, _accntNum, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_STUD_VOUCHER_PAY_MTHOD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudVoucherId">اذن دفع/ايصال سداد</param>
		/// <param name="_gsCodePayMethodId"></param>
		/// <param name="_gsCodePayMthdTypeId"></param>
		/// <param name="_accntNum">رقم حساب البنك  فى حالة ايداع&&في حالة السداد من نوع "الشيك"  يجب اظهار البنوك للاختيار منها وبعد اختيار البنك يقوم النظام باظهار رقم الحساب الخاص بالبنك</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudVoucherPayMthod"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudVoucherPayMthod GetByFeeStudVoucherIdGsCodePayMethodIdGsCodePayMthdTypeIdAccntNum(TransactionManager transactionManager, System.Decimal _feeStudVoucherId, System.Decimal _gsCodePayMethodId, System.Int32? _gsCodePayMthdTypeId, System.String _accntNum, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeStudVoucherIdGsCodePayMethodIdGsCodePayMthdTypeIdAccntNum(transactionManager, _feeStudVoucherId, _gsCodePayMethodId, _gsCodePayMthdTypeId, _accntNum, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_STUD_VOUCHER_PAY_MTHOD index.
		/// </summary>
		/// <param name="_feeStudVoucherId">اذن دفع/ايصال سداد</param>
		/// <param name="_gsCodePayMethodId"></param>
		/// <param name="_gsCodePayMthdTypeId"></param>
		/// <param name="_accntNum">رقم حساب البنك  فى حالة ايداع&&في حالة السداد من نوع "الشيك"  يجب اظهار البنوك للاختيار منها وبعد اختيار البنك يقوم النظام باظهار رقم الحساب الخاص بالبنك</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudVoucherPayMthod"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudVoucherPayMthod GetByFeeStudVoucherIdGsCodePayMethodIdGsCodePayMthdTypeIdAccntNum(System.Decimal _feeStudVoucherId, System.Decimal _gsCodePayMethodId, System.Int32? _gsCodePayMthdTypeId, System.String _accntNum, int start, int pageLength, out int count)
		{
			return GetByFeeStudVoucherIdGsCodePayMethodIdGsCodePayMthdTypeIdAccntNum(null, _feeStudVoucherId, _gsCodePayMethodId, _gsCodePayMthdTypeId, _accntNum, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_STUD_VOUCHER_PAY_MTHOD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudVoucherId">اذن دفع/ايصال سداد</param>
		/// <param name="_gsCodePayMethodId"></param>
		/// <param name="_gsCodePayMthdTypeId"></param>
		/// <param name="_accntNum">رقم حساب البنك  فى حالة ايداع&&في حالة السداد من نوع "الشيك"  يجب اظهار البنوك للاختيار منها وبعد اختيار البنك يقوم النظام باظهار رقم الحساب الخاص بالبنك</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudVoucherPayMthod"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.FeeStudVoucherPayMthod GetByFeeStudVoucherIdGsCodePayMethodIdGsCodePayMthdTypeIdAccntNum(TransactionManager transactionManager, System.Decimal _feeStudVoucherId, System.Decimal _gsCodePayMethodId, System.Int32? _gsCodePayMthdTypeId, System.String _accntNum, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;FeeStudVoucherPayMthod&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;FeeStudVoucherPayMthod&gt;"/></returns>
		public static TList<FeeStudVoucherPayMthod> Fill(IDataReader reader, TList<FeeStudVoucherPayMthod> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.FeeStudVoucherPayMthod c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("FeeStudVoucherPayMthod")
					.Append("|").Append((System.Decimal)reader["FEE_STUD_VOUCHER_PAY_MTHOD_ID"]).ToString();
					c = EntityManager.LocateOrCreate<FeeStudVoucherPayMthod>(
					key.ToString(), // EntityTrackingKey
					"FeeStudVoucherPayMthod",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.FeeStudVoucherPayMthod();
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
					c.FeeStudVoucherPayMthodId = (System.Decimal)reader["FEE_STUD_VOUCHER_PAY_MTHOD_ID"];
					c.OriginalFeeStudVoucherPayMthodId = c.FeeStudVoucherPayMthodId;
					c.FeeStudVoucherId = (System.Decimal)reader["FEE_STUD_VOUCHER_ID"];
					c.GsCodePayMethodId = (System.Decimal)reader["GS_CODE_PAY_METHOD_ID"];
					c.GsCodePayMthdTypeId = Convert.IsDBNull(reader["GS_CODE_PAY_MTHD_TYPE_ID"]) ? null : (System.Int32?)reader["GS_CODE_PAY_MTHD_TYPE_ID"];
					c.PayAmnt = Convert.IsDBNull(reader["PAY_AMNT"]) ? null : (System.Decimal?)reader["PAY_AMNT"];
					c.BankTrnsDate = Convert.IsDBNull(reader["BANK_TRNS_DATE"]) ? null : (System.DateTime?)reader["BANK_TRNS_DATE"];
					c.FeeCodeBankId = Convert.IsDBNull(reader["FEE_CODE_BANK_ID"]) ? null : (System.Decimal?)reader["FEE_CODE_BANK_ID"];
					c.AccntNum = Convert.IsDBNull(reader["ACCNT_NUM"]) ? null : (System.String)reader["ACCNT_NUM"];
					c.CheqNum = Convert.IsDBNull(reader["CHEQ_NUM"]) ? null : (System.String)reader["CHEQ_NUM"];
					c.CardNum = Convert.IsDBNull(reader["CARD_NUM"]) ? null : (System.String)reader["CARD_NUM"];
					c.OnlineFlg = Convert.IsDBNull(reader["ONLINE_FLG"]) ? null : (System.Boolean?)reader["ONLINE_FLG"];
					c.OnlinePayInd = Convert.IsDBNull(reader["ONLINE_PAY_IND"]) ? null : (System.String)reader["ONLINE_PAY_IND"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeStudVoucherPayMthod"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeStudVoucherPayMthod"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.FeeStudVoucherPayMthod entity)
		{
			if (!reader.Read()) return;
			
			entity.FeeStudVoucherPayMthodId = (System.Decimal)reader[((int)FeeStudVoucherPayMthodColumn.FeeStudVoucherPayMthodId - 1)];
			entity.OriginalFeeStudVoucherPayMthodId = (System.Decimal)reader["FEE_STUD_VOUCHER_PAY_MTHOD_ID"];
			entity.FeeStudVoucherId = (System.Decimal)reader[((int)FeeStudVoucherPayMthodColumn.FeeStudVoucherId - 1)];
			entity.GsCodePayMethodId = (System.Decimal)reader[((int)FeeStudVoucherPayMthodColumn.GsCodePayMethodId - 1)];
			entity.GsCodePayMthdTypeId = (reader.IsDBNull(((int)FeeStudVoucherPayMthodColumn.GsCodePayMthdTypeId - 1)))?null:(System.Int32?)reader[((int)FeeStudVoucherPayMthodColumn.GsCodePayMthdTypeId - 1)];
			entity.PayAmnt = (reader.IsDBNull(((int)FeeStudVoucherPayMthodColumn.PayAmnt - 1)))?null:(System.Decimal?)reader[((int)FeeStudVoucherPayMthodColumn.PayAmnt - 1)];
			entity.BankTrnsDate = (reader.IsDBNull(((int)FeeStudVoucherPayMthodColumn.BankTrnsDate - 1)))?null:(System.DateTime?)reader[((int)FeeStudVoucherPayMthodColumn.BankTrnsDate - 1)];
			entity.FeeCodeBankId = (reader.IsDBNull(((int)FeeStudVoucherPayMthodColumn.FeeCodeBankId - 1)))?null:(System.Decimal?)reader[((int)FeeStudVoucherPayMthodColumn.FeeCodeBankId - 1)];
			entity.AccntNum = (reader.IsDBNull(((int)FeeStudVoucherPayMthodColumn.AccntNum - 1)))?null:(System.String)reader[((int)FeeStudVoucherPayMthodColumn.AccntNum - 1)];
			entity.CheqNum = (reader.IsDBNull(((int)FeeStudVoucherPayMthodColumn.CheqNum - 1)))?null:(System.String)reader[((int)FeeStudVoucherPayMthodColumn.CheqNum - 1)];
			entity.CardNum = (reader.IsDBNull(((int)FeeStudVoucherPayMthodColumn.CardNum - 1)))?null:(System.String)reader[((int)FeeStudVoucherPayMthodColumn.CardNum - 1)];
			entity.OnlineFlg = (reader.IsDBNull(((int)FeeStudVoucherPayMthodColumn.OnlineFlg - 1)))?null:(System.Boolean?)reader[((int)FeeStudVoucherPayMthodColumn.OnlineFlg - 1)];
			entity.OnlinePayInd = (reader.IsDBNull(((int)FeeStudVoucherPayMthodColumn.OnlinePayInd - 1)))?null:(System.String)reader[((int)FeeStudVoucherPayMthodColumn.OnlinePayInd - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)FeeStudVoucherPayMthodColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)FeeStudVoucherPayMthodColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)FeeStudVoucherPayMthodColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)FeeStudVoucherPayMthodColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeStudVoucherPayMthod"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeStudVoucherPayMthod"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.FeeStudVoucherPayMthod entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.FeeStudVoucherPayMthodId = (System.Decimal)dataRow["FEE_STUD_VOUCHER_PAY_MTHOD_ID"];
			entity.OriginalFeeStudVoucherPayMthodId = (System.Decimal)dataRow["FEE_STUD_VOUCHER_PAY_MTHOD_ID"];
			entity.FeeStudVoucherId = (System.Decimal)dataRow["FEE_STUD_VOUCHER_ID"];
			entity.GsCodePayMethodId = (System.Decimal)dataRow["GS_CODE_PAY_METHOD_ID"];
			entity.GsCodePayMthdTypeId = Convert.IsDBNull(dataRow["GS_CODE_PAY_MTHD_TYPE_ID"]) ? null : (System.Int32?)dataRow["GS_CODE_PAY_MTHD_TYPE_ID"];
			entity.PayAmnt = Convert.IsDBNull(dataRow["PAY_AMNT"]) ? null : (System.Decimal?)dataRow["PAY_AMNT"];
			entity.BankTrnsDate = Convert.IsDBNull(dataRow["BANK_TRNS_DATE"]) ? null : (System.DateTime?)dataRow["BANK_TRNS_DATE"];
			entity.FeeCodeBankId = Convert.IsDBNull(dataRow["FEE_CODE_BANK_ID"]) ? null : (System.Decimal?)dataRow["FEE_CODE_BANK_ID"];
			entity.AccntNum = Convert.IsDBNull(dataRow["ACCNT_NUM"]) ? null : (System.String)dataRow["ACCNT_NUM"];
			entity.CheqNum = Convert.IsDBNull(dataRow["CHEQ_NUM"]) ? null : (System.String)dataRow["CHEQ_NUM"];
			entity.CardNum = Convert.IsDBNull(dataRow["CARD_NUM"]) ? null : (System.String)dataRow["CARD_NUM"];
			entity.OnlineFlg = Convert.IsDBNull(dataRow["ONLINE_FLG"]) ? null : (System.Boolean?)dataRow["ONLINE_FLG"];
			entity.OnlinePayInd = Convert.IsDBNull(dataRow["ONLINE_PAY_IND"]) ? null : (System.String)dataRow["ONLINE_PAY_IND"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeStudVoucherPayMthod"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeStudVoucherPayMthod Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeStudVoucherPayMthod entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region FeeCodeBankIdSource	
			if (CanDeepLoad(entity, "FeeCodeBanks|FeeCodeBankIdSource", deepLoadType, innerList) 
				&& entity.FeeCodeBankIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.FeeCodeBankId ?? 0.0m);
				FeeCodeBanks tmpEntity = EntityManager.LocateEntity<FeeCodeBanks>(EntityLocator.ConstructKeyFromPkItems(typeof(FeeCodeBanks), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.FeeCodeBankIdSource = tmpEntity;
				else
					entity.FeeCodeBankIdSource = DataRepository.FeeCodeBanksProvider.GetByFeeCodeBankId(transactionManager, (entity.FeeCodeBankId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeCodeBankIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.FeeCodeBankIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.FeeCodeBanksProvider.DeepLoad(transactionManager, entity.FeeCodeBankIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion FeeCodeBankIdSource

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

			#region GsCodePayMethodIdSource	
			if (CanDeepLoad(entity, "GsCodePayMethod|GsCodePayMethodIdSource", deepLoadType, innerList) 
				&& entity.GsCodePayMethodIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.GsCodePayMethodId;
				GsCodePayMethod tmpEntity = EntityManager.LocateEntity<GsCodePayMethod>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodePayMethod), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodePayMethodIdSource = tmpEntity;
				else
					entity.GsCodePayMethodIdSource = DataRepository.GsCodePayMethodProvider.GetByGsCodePayMethodId(transactionManager, entity.GsCodePayMethodId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodePayMethodIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCodePayMethodIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodePayMethodProvider.DeepLoad(transactionManager, entity.GsCodePayMethodIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCodePayMethodIdSource

			#region GsCodePayMthdTypeIdSource	
			if (CanDeepLoad(entity, "GsCodePayMthdType|GsCodePayMthdTypeIdSource", deepLoadType, innerList) 
				&& entity.GsCodePayMthdTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCodePayMthdTypeId ?? (int)0);
				GsCodePayMthdType tmpEntity = EntityManager.LocateEntity<GsCodePayMthdType>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodePayMthdType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodePayMthdTypeIdSource = tmpEntity;
				else
					entity.GsCodePayMthdTypeIdSource = DataRepository.GsCodePayMthdTypeProvider.GetByGsCodePayMthdTypeId(transactionManager, (entity.GsCodePayMthdTypeId ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodePayMthdTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCodePayMthdTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodePayMthdTypeProvider.DeepLoad(transactionManager, entity.GsCodePayMthdTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCodePayMthdTypeIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.FeeStudVoucherPayMthod object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.FeeStudVoucherPayMthod instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeStudVoucherPayMthod Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeStudVoucherPayMthod entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region FeeCodeBankIdSource
			if (CanDeepSave(entity, "FeeCodeBanks|FeeCodeBankIdSource", deepSaveType, innerList) 
				&& entity.FeeCodeBankIdSource != null)
			{
				DataRepository.FeeCodeBanksProvider.Save(transactionManager, entity.FeeCodeBankIdSource);
				entity.FeeCodeBankId = entity.FeeCodeBankIdSource.FeeCodeBankId;
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
			
			#region GsCodePayMethodIdSource
			if (CanDeepSave(entity, "GsCodePayMethod|GsCodePayMethodIdSource", deepSaveType, innerList) 
				&& entity.GsCodePayMethodIdSource != null)
			{
				DataRepository.GsCodePayMethodProvider.Save(transactionManager, entity.GsCodePayMethodIdSource);
				entity.GsCodePayMethodId = entity.GsCodePayMethodIdSource.GsCodePayMethodId;
			}
			#endregion 
			
			#region GsCodePayMthdTypeIdSource
			if (CanDeepSave(entity, "GsCodePayMthdType|GsCodePayMthdTypeIdSource", deepSaveType, innerList) 
				&& entity.GsCodePayMthdTypeIdSource != null)
			{
				DataRepository.GsCodePayMthdTypeProvider.Save(transactionManager, entity.GsCodePayMthdTypeIdSource);
				entity.GsCodePayMthdTypeId = entity.GsCodePayMthdTypeIdSource.GsCodePayMthdTypeId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
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
	
	#region FeeStudVoucherPayMthodChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.FeeStudVoucherPayMthod</c>
	///</summary>
	public enum FeeStudVoucherPayMthodChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>FeeCodeBanks</c> at FeeCodeBankIdSource
		///</summary>
		[ChildEntityType(typeof(FeeCodeBanks))]
		FeeCodeBanks,
		
		///<summary>
		/// Composite Property for <c>FeeStudVoucher</c> at FeeStudVoucherIdSource
		///</summary>
		[ChildEntityType(typeof(FeeStudVoucher))]
		FeeStudVoucher,
		
		///<summary>
		/// Composite Property for <c>GsCodePayMethod</c> at GsCodePayMethodIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodePayMethod))]
		GsCodePayMethod,
		
		///<summary>
		/// Composite Property for <c>GsCodePayMthdType</c> at GsCodePayMthdTypeIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodePayMthdType))]
		GsCodePayMthdType,
	}
	
	#endregion FeeStudVoucherPayMthodChildEntityTypes
	
	#region FeeStudVoucherPayMthodFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;FeeStudVoucherPayMthodColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeStudVoucherPayMthod"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeStudVoucherPayMthodFilterBuilder : SqlFilterBuilder<FeeStudVoucherPayMthodColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeStudVoucherPayMthodFilterBuilder class.
		/// </summary>
		public FeeStudVoucherPayMthodFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeStudVoucherPayMthodFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeStudVoucherPayMthodFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeStudVoucherPayMthodFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeStudVoucherPayMthodFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeStudVoucherPayMthodFilterBuilder
	
	#region FeeStudVoucherPayMthodParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;FeeStudVoucherPayMthodColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeStudVoucherPayMthod"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeStudVoucherPayMthodParameterBuilder : ParameterizedSqlFilterBuilder<FeeStudVoucherPayMthodColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeStudVoucherPayMthodParameterBuilder class.
		/// </summary>
		public FeeStudVoucherPayMthodParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeStudVoucherPayMthodParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeStudVoucherPayMthodParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeStudVoucherPayMthodParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeStudVoucherPayMthodParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeStudVoucherPayMthodParameterBuilder
	
	#region FeeStudVoucherPayMthodSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;FeeStudVoucherPayMthodColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeStudVoucherPayMthod"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class FeeStudVoucherPayMthodSortBuilder : SqlSortBuilder<FeeStudVoucherPayMthodColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeStudVoucherPayMthodSqlSortBuilder class.
		/// </summary>
		public FeeStudVoucherPayMthodSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion FeeStudVoucherPayMthodSortBuilder
	
} // end namespace
