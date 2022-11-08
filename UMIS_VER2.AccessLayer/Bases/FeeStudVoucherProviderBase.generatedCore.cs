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
	/// This class is the base class for any <see cref="FeeStudVoucherProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class FeeStudVoucherProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.FeeStudVoucher, UMIS_VER2.BusinessLyer.FeeStudVoucherKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeStudVoucherKey key)
		{
			return Delete(transactionManager, key.FeeStudVoucherId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_feeStudVoucherId">اذن دفع/ايصال سداد. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _feeStudVoucherId)
		{
			return Delete(null, _feeStudVoucherId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudVoucherId">اذن دفع/ايصال سداد. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _feeStudVoucherId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_000c key.
		///		FK_AUTO_000c Description: 
		/// </summary>
		/// <param name="_feeCodeTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucher objects.</returns>
		public TList<FeeStudVoucher> GetByFeeCodeTypeId(System.Decimal? _feeCodeTypeId)
		{
			int count = -1;
			return GetByFeeCodeTypeId(_feeCodeTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_000c key.
		///		FK_AUTO_000c Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucher objects.</returns>
		/// <remarks></remarks>
		public TList<FeeStudVoucher> GetByFeeCodeTypeId(TransactionManager transactionManager, System.Decimal? _feeCodeTypeId)
		{
			int count = -1;
			return GetByFeeCodeTypeId(transactionManager, _feeCodeTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_000c key.
		///		FK_AUTO_000c Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucher objects.</returns>
		public TList<FeeStudVoucher> GetByFeeCodeTypeId(TransactionManager transactionManager, System.Decimal? _feeCodeTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCodeTypeId(transactionManager, _feeCodeTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_000c key.
		///		fkAuto000c Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeCodeTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucher objects.</returns>
		public TList<FeeStudVoucher> GetByFeeCodeTypeId(System.Decimal? _feeCodeTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByFeeCodeTypeId(null, _feeCodeTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_000c key.
		///		fkAuto000c Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeCodeTypeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucher objects.</returns>
		public TList<FeeStudVoucher> GetByFeeCodeTypeId(System.Decimal? _feeCodeTypeId, int start, int pageLength,out int count)
		{
			return GetByFeeCodeTypeId(null, _feeCodeTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_000c key.
		///		FK_AUTO_000c Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucher objects.</returns>
		public abstract TList<FeeStudVoucher> GetByFeeCodeTypeId(TransactionManager transactionManager, System.Decimal? _feeCodeTypeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_ADM_APPLICANT key.
		///		FK_FEE_STUD_VOUCHER_ADM_APPLICANT Description: 
		/// </summary>
		/// <param name="_admApplicantId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucher objects.</returns>
		public TList<FeeStudVoucher> GetByAdmApplicantId(System.Decimal? _admApplicantId)
		{
			int count = -1;
			return GetByAdmApplicantId(_admApplicantId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_ADM_APPLICANT key.
		///		FK_FEE_STUD_VOUCHER_ADM_APPLICANT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucher objects.</returns>
		/// <remarks></remarks>
		public TList<FeeStudVoucher> GetByAdmApplicantId(TransactionManager transactionManager, System.Decimal? _admApplicantId)
		{
			int count = -1;
			return GetByAdmApplicantId(transactionManager, _admApplicantId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_ADM_APPLICANT key.
		///		FK_FEE_STUD_VOUCHER_ADM_APPLICANT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucher objects.</returns>
		public TList<FeeStudVoucher> GetByAdmApplicantId(TransactionManager transactionManager, System.Decimal? _admApplicantId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmApplicantId(transactionManager, _admApplicantId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_ADM_APPLICANT key.
		///		fkFeeStudVoucherAdmApplicant Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admApplicantId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucher objects.</returns>
		public TList<FeeStudVoucher> GetByAdmApplicantId(System.Decimal? _admApplicantId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmApplicantId(null, _admApplicantId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_ADM_APPLICANT key.
		///		fkFeeStudVoucherAdmApplicant Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucher objects.</returns>
		public TList<FeeStudVoucher> GetByAdmApplicantId(System.Decimal? _admApplicantId, int start, int pageLength,out int count)
		{
			return GetByAdmApplicantId(null, _admApplicantId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_ADM_APPLICANT key.
		///		FK_FEE_STUD_VOUCHER_ADM_APPLICANT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucher objects.</returns>
		public abstract TList<FeeStudVoucher> GetByAdmApplicantId(TransactionManager transactionManager, System.Decimal? _admApplicantId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_ED_CODE_SEMESTER key.
		///		FK_FEE_STUD_VOUCHER_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="_edCodeSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucher objects.</returns>
		public TList<FeeStudVoucher> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(_edCodeSemesterId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_ED_CODE_SEMESTER key.
		///		FK_FEE_STUD_VOUCHER_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucher objects.</returns>
		/// <remarks></remarks>
		public TList<FeeStudVoucher> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_ED_CODE_SEMESTER key.
		///		FK_FEE_STUD_VOUCHER_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucher objects.</returns>
		public TList<FeeStudVoucher> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_ED_CODE_SEMESTER key.
		///		fkFeeStudVoucherEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucher objects.</returns>
		public TList<FeeStudVoucher> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_ED_CODE_SEMESTER key.
		///		fkFeeStudVoucherEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucher objects.</returns>
		public TList<FeeStudVoucher> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId, int start, int pageLength,out int count)
		{
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_ED_CODE_SEMESTER key.
		///		FK_FEE_STUD_VOUCHER_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucher objects.</returns>
		public abstract TList<FeeStudVoucher> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_SE_USER key.
		///		FK_FEE_STUD_VOUCHER_SE_USER Description: 
		/// </summary>
		/// <param name="_seUserId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucher objects.</returns>
		public TList<FeeStudVoucher> GetBySeUserId(System.Decimal? _seUserId)
		{
			int count = -1;
			return GetBySeUserId(_seUserId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_SE_USER key.
		///		FK_FEE_STUD_VOUCHER_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucher objects.</returns>
		/// <remarks></remarks>
		public TList<FeeStudVoucher> GetBySeUserId(TransactionManager transactionManager, System.Decimal? _seUserId)
		{
			int count = -1;
			return GetBySeUserId(transactionManager, _seUserId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_SE_USER key.
		///		FK_FEE_STUD_VOUCHER_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucher objects.</returns>
		public TList<FeeStudVoucher> GetBySeUserId(TransactionManager transactionManager, System.Decimal? _seUserId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeUserId(transactionManager, _seUserId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_SE_USER key.
		///		fkFeeStudVoucherSeUser Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucher objects.</returns>
		public TList<FeeStudVoucher> GetBySeUserId(System.Decimal? _seUserId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySeUserId(null, _seUserId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_SE_USER key.
		///		fkFeeStudVoucherSeUser Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucher objects.</returns>
		public TList<FeeStudVoucher> GetBySeUserId(System.Decimal? _seUserId, int start, int pageLength,out int count)
		{
			return GetBySeUserId(null, _seUserId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_SE_USER key.
		///		FK_FEE_STUD_VOUCHER_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucher objects.</returns>
		public abstract TList<FeeStudVoucher> GetBySeUserId(TransactionManager transactionManager, System.Decimal? _seUserId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_SE_USER1 key.
		///		FK_FEE_STUD_VOUCHER_SE_USER1 Description: 
		/// </summary>
		/// <param name="_seUserCnclId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucher objects.</returns>
		public TList<FeeStudVoucher> GetBySeUserCnclId(System.Decimal? _seUserCnclId)
		{
			int count = -1;
			return GetBySeUserCnclId(_seUserCnclId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_SE_USER1 key.
		///		FK_FEE_STUD_VOUCHER_SE_USER1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserCnclId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucher objects.</returns>
		/// <remarks></remarks>
		public TList<FeeStudVoucher> GetBySeUserCnclId(TransactionManager transactionManager, System.Decimal? _seUserCnclId)
		{
			int count = -1;
			return GetBySeUserCnclId(transactionManager, _seUserCnclId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_SE_USER1 key.
		///		FK_FEE_STUD_VOUCHER_SE_USER1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserCnclId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucher objects.</returns>
		public TList<FeeStudVoucher> GetBySeUserCnclId(TransactionManager transactionManager, System.Decimal? _seUserCnclId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeUserCnclId(transactionManager, _seUserCnclId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_SE_USER1 key.
		///		fkFeeStudVoucherSeUser1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserCnclId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucher objects.</returns>
		public TList<FeeStudVoucher> GetBySeUserCnclId(System.Decimal? _seUserCnclId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySeUserCnclId(null, _seUserCnclId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_SE_USER1 key.
		///		fkFeeStudVoucherSeUser1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserCnclId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucher objects.</returns>
		public TList<FeeStudVoucher> GetBySeUserCnclId(System.Decimal? _seUserCnclId, int start, int pageLength,out int count)
		{
			return GetBySeUserCnclId(null, _seUserCnclId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_SE_USER1 key.
		///		FK_FEE_STUD_VOUCHER_SE_USER1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserCnclId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucher objects.</returns>
		public abstract TList<FeeStudVoucher> GetBySeUserCnclId(TransactionManager transactionManager, System.Decimal? _seUserCnclId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_SPO_SPONSOR key.
		///		FK_FEE_STUD_VOUCHER_SPO_SPONSOR Description: 
		/// </summary>
		/// <param name="_spoSponsorId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucher objects.</returns>
		public TList<FeeStudVoucher> GetBySpoSponsorId(System.Decimal? _spoSponsorId)
		{
			int count = -1;
			return GetBySpoSponsorId(_spoSponsorId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_SPO_SPONSOR key.
		///		FK_FEE_STUD_VOUCHER_SPO_SPONSOR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucher objects.</returns>
		/// <remarks></remarks>
		public TList<FeeStudVoucher> GetBySpoSponsorId(TransactionManager transactionManager, System.Decimal? _spoSponsorId)
		{
			int count = -1;
			return GetBySpoSponsorId(transactionManager, _spoSponsorId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_SPO_SPONSOR key.
		///		FK_FEE_STUD_VOUCHER_SPO_SPONSOR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucher objects.</returns>
		public TList<FeeStudVoucher> GetBySpoSponsorId(TransactionManager transactionManager, System.Decimal? _spoSponsorId, int start, int pageLength)
		{
			int count = -1;
			return GetBySpoSponsorId(transactionManager, _spoSponsorId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_SPO_SPONSOR key.
		///		fkFeeStudVoucherSpoSponsor Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_spoSponsorId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucher objects.</returns>
		public TList<FeeStudVoucher> GetBySpoSponsorId(System.Decimal? _spoSponsorId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySpoSponsorId(null, _spoSponsorId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_SPO_SPONSOR key.
		///		fkFeeStudVoucherSpoSponsor Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_spoSponsorId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucher objects.</returns>
		public TList<FeeStudVoucher> GetBySpoSponsorId(System.Decimal? _spoSponsorId, int start, int pageLength,out int count)
		{
			return GetBySpoSponsorId(null, _spoSponsorId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_VOUCHER_SPO_SPONSOR key.
		///		FK_FEE_STUD_VOUCHER_SPO_SPONSOR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudVoucher objects.</returns>
		public abstract TList<FeeStudVoucher> GetBySpoSponsorId(TransactionManager transactionManager, System.Decimal? _spoSponsorId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.FeeStudVoucher Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeStudVoucherKey key, int start, int pageLength)
		{
			return GetByFeeStudVoucherId(transactionManager, key.FeeStudVoucherId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudVoucher&gt;"/> class.</returns>
		public TList<FeeStudVoucher> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(null,_asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudVoucher&gt;"/> class.</returns>
		public TList<FeeStudVoucher> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudVoucher&gt;"/> class.</returns>
		public TList<FeeStudVoucher> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudVoucher&gt;"/> class.</returns>
		public TList<FeeStudVoucher> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudVoucher&gt;"/> class.</returns>
		public TList<FeeStudVoucher> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudVoucher&gt;"/> class.</returns>
		public abstract TList<FeeStudVoucher> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_ACAD_YEAR_ID_1 index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudVoucher&gt;"/> class.</returns>
		public TList<FeeStudVoucher> GetByEdAcadYearId(System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(null,_edAcadYearId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_ACAD_YEAR_ID_1 index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudVoucher&gt;"/> class.</returns>
		public TList<FeeStudVoucher> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_ACAD_YEAR_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudVoucher&gt;"/> class.</returns>
		public TList<FeeStudVoucher> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_ACAD_YEAR_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudVoucher&gt;"/> class.</returns>
		public TList<FeeStudVoucher> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_ACAD_YEAR_ID_1 index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudVoucher&gt;"/> class.</returns>
		public TList<FeeStudVoucher> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength, out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_ACAD_YEAR_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudVoucher&gt;"/> class.</returns>
		public abstract TList<FeeStudVoucher> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_STUD_ID_1 index.
		/// </summary>
		/// <param name="_edStudId">KU sponsor</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudVoucher&gt;"/> class.</returns>
		public TList<FeeStudVoucher> GetByEdStudId(System.Decimal? _edStudId)
		{
			int count = -1;
			return GetByEdStudId(null,_edStudId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_ID_1 index.
		/// </summary>
		/// <param name="_edStudId">KU sponsor</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudVoucher&gt;"/> class.</returns>
		public TList<FeeStudVoucher> GetByEdStudId(System.Decimal? _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">KU sponsor</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudVoucher&gt;"/> class.</returns>
		public TList<FeeStudVoucher> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">KU sponsor</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudVoucher&gt;"/> class.</returns>
		public TList<FeeStudVoucher> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_ID_1 index.
		/// </summary>
		/// <param name="_edStudId">KU sponsor</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudVoucher&gt;"/> class.</returns>
		public TList<FeeStudVoucher> GetByEdStudId(System.Decimal? _edStudId, int start, int pageLength, out int count)
		{
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">KU sponsor</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudVoucher&gt;"/> class.</returns>
		public abstract TList<FeeStudVoucher> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_FEE_CODE_BANK_ID_1 index.
		/// </summary>
		/// <param name="_feeCodeBankId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudVoucher&gt;"/> class.</returns>
		public TList<FeeStudVoucher> GetByFeeCodeBankId(System.Decimal? _feeCodeBankId)
		{
			int count = -1;
			return GetByFeeCodeBankId(null,_feeCodeBankId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_FEE_CODE_BANK_ID_1 index.
		/// </summary>
		/// <param name="_feeCodeBankId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudVoucher&gt;"/> class.</returns>
		public TList<FeeStudVoucher> GetByFeeCodeBankId(System.Decimal? _feeCodeBankId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCodeBankId(null, _feeCodeBankId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_FEE_CODE_BANK_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeBankId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudVoucher&gt;"/> class.</returns>
		public TList<FeeStudVoucher> GetByFeeCodeBankId(TransactionManager transactionManager, System.Decimal? _feeCodeBankId)
		{
			int count = -1;
			return GetByFeeCodeBankId(transactionManager, _feeCodeBankId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_FEE_CODE_BANK_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeBankId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudVoucher&gt;"/> class.</returns>
		public TList<FeeStudVoucher> GetByFeeCodeBankId(TransactionManager transactionManager, System.Decimal? _feeCodeBankId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCodeBankId(transactionManager, _feeCodeBankId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_FEE_CODE_BANK_ID_1 index.
		/// </summary>
		/// <param name="_feeCodeBankId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudVoucher&gt;"/> class.</returns>
		public TList<FeeStudVoucher> GetByFeeCodeBankId(System.Decimal? _feeCodeBankId, int start, int pageLength, out int count)
		{
			return GetByFeeCodeBankId(null, _feeCodeBankId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_FEE_CODE_BANK_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeBankId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudVoucher&gt;"/> class.</returns>
		public abstract TList<FeeStudVoucher> GetByFeeCodeBankId(TransactionManager transactionManager, System.Decimal? _feeCodeBankId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_GS_CODE_CURRENCY_ID_1 index.
		/// </summary>
		/// <param name="_gsCodeCurrencyId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudVoucher&gt;"/> class.</returns>
		public TList<FeeStudVoucher> GetByGsCodeCurrencyId(System.Decimal _gsCodeCurrencyId)
		{
			int count = -1;
			return GetByGsCodeCurrencyId(null,_gsCodeCurrencyId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_CURRENCY_ID_1 index.
		/// </summary>
		/// <param name="_gsCodeCurrencyId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudVoucher&gt;"/> class.</returns>
		public TList<FeeStudVoucher> GetByGsCodeCurrencyId(System.Decimal _gsCodeCurrencyId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeCurrencyId(null, _gsCodeCurrencyId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_CURRENCY_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeCurrencyId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudVoucher&gt;"/> class.</returns>
		public TList<FeeStudVoucher> GetByGsCodeCurrencyId(TransactionManager transactionManager, System.Decimal _gsCodeCurrencyId)
		{
			int count = -1;
			return GetByGsCodeCurrencyId(transactionManager, _gsCodeCurrencyId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_CURRENCY_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeCurrencyId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudVoucher&gt;"/> class.</returns>
		public TList<FeeStudVoucher> GetByGsCodeCurrencyId(TransactionManager transactionManager, System.Decimal _gsCodeCurrencyId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeCurrencyId(transactionManager, _gsCodeCurrencyId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_CURRENCY_ID_1 index.
		/// </summary>
		/// <param name="_gsCodeCurrencyId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudVoucher&gt;"/> class.</returns>
		public TList<FeeStudVoucher> GetByGsCodeCurrencyId(System.Decimal _gsCodeCurrencyId, int start, int pageLength, out int count)
		{
			return GetByGsCodeCurrencyId(null, _gsCodeCurrencyId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_CURRENCY_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeCurrencyId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudVoucher&gt;"/> class.</returns>
		public abstract TList<FeeStudVoucher> GetByGsCodeCurrencyId(TransactionManager transactionManager, System.Decimal _gsCodeCurrencyId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_GS_CODE_PAY_METHOD_I_1 index.
		/// </summary>
		/// <param name="_gsCodePayMethodId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudVoucher&gt;"/> class.</returns>
		public TList<FeeStudVoucher> GetByGsCodePayMethodId(System.Decimal? _gsCodePayMethodId)
		{
			int count = -1;
			return GetByGsCodePayMethodId(null,_gsCodePayMethodId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_PAY_METHOD_I_1 index.
		/// </summary>
		/// <param name="_gsCodePayMethodId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudVoucher&gt;"/> class.</returns>
		public TList<FeeStudVoucher> GetByGsCodePayMethodId(System.Decimal? _gsCodePayMethodId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodePayMethodId(null, _gsCodePayMethodId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_PAY_METHOD_I_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodePayMethodId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudVoucher&gt;"/> class.</returns>
		public TList<FeeStudVoucher> GetByGsCodePayMethodId(TransactionManager transactionManager, System.Decimal? _gsCodePayMethodId)
		{
			int count = -1;
			return GetByGsCodePayMethodId(transactionManager, _gsCodePayMethodId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_PAY_METHOD_I_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodePayMethodId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudVoucher&gt;"/> class.</returns>
		public TList<FeeStudVoucher> GetByGsCodePayMethodId(TransactionManager transactionManager, System.Decimal? _gsCodePayMethodId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodePayMethodId(transactionManager, _gsCodePayMethodId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_PAY_METHOD_I_1 index.
		/// </summary>
		/// <param name="_gsCodePayMethodId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudVoucher&gt;"/> class.</returns>
		public TList<FeeStudVoucher> GetByGsCodePayMethodId(System.Decimal? _gsCodePayMethodId, int start, int pageLength, out int count)
		{
			return GetByGsCodePayMethodId(null, _gsCodePayMethodId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_PAY_METHOD_I_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodePayMethodId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudVoucher&gt;"/> class.</returns>
		public abstract TList<FeeStudVoucher> GetByGsCodePayMethodId(TransactionManager transactionManager, System.Decimal? _gsCodePayMethodId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_FEE_STUD_VOUCHER index.
		/// </summary>
		/// <param name="_feeStudVoucherId">اذن دفع/ايصال سداد</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudVoucher"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudVoucher GetByFeeStudVoucherId(System.Decimal _feeStudVoucherId)
		{
			int count = -1;
			return GetByFeeStudVoucherId(null,_feeStudVoucherId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_STUD_VOUCHER index.
		/// </summary>
		/// <param name="_feeStudVoucherId">اذن دفع/ايصال سداد</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudVoucher"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudVoucher GetByFeeStudVoucherId(System.Decimal _feeStudVoucherId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeStudVoucherId(null, _feeStudVoucherId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_STUD_VOUCHER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudVoucherId">اذن دفع/ايصال سداد</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudVoucher"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudVoucher GetByFeeStudVoucherId(TransactionManager transactionManager, System.Decimal _feeStudVoucherId)
		{
			int count = -1;
			return GetByFeeStudVoucherId(transactionManager, _feeStudVoucherId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_STUD_VOUCHER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudVoucherId">اذن دفع/ايصال سداد</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudVoucher"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudVoucher GetByFeeStudVoucherId(TransactionManager transactionManager, System.Decimal _feeStudVoucherId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeStudVoucherId(transactionManager, _feeStudVoucherId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_STUD_VOUCHER index.
		/// </summary>
		/// <param name="_feeStudVoucherId">اذن دفع/ايصال سداد</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudVoucher"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudVoucher GetByFeeStudVoucherId(System.Decimal _feeStudVoucherId, int start, int pageLength, out int count)
		{
			return GetByFeeStudVoucherId(null, _feeStudVoucherId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_STUD_VOUCHER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudVoucherId">اذن دفع/ايصال سداد</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudVoucher"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.FeeStudVoucher GetByFeeStudVoucherId(TransactionManager transactionManager, System.Decimal _feeStudVoucherId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_FEE_STUD_VOUCHER_VCHR index.
		/// </summary>
		/// <param name="_voucherSerial"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudVoucher&gt;"/> class.</returns>
		public TList<FeeStudVoucher> GetByVoucherSerial(System.Decimal? _voucherSerial)
		{
			int count = -1;
			return GetByVoucherSerial(null,_voucherSerial, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_STUD_VOUCHER_VCHR index.
		/// </summary>
		/// <param name="_voucherSerial"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudVoucher&gt;"/> class.</returns>
		public TList<FeeStudVoucher> GetByVoucherSerial(System.Decimal? _voucherSerial, int start, int pageLength)
		{
			int count = -1;
			return GetByVoucherSerial(null, _voucherSerial, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_STUD_VOUCHER_VCHR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_voucherSerial"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudVoucher&gt;"/> class.</returns>
		public TList<FeeStudVoucher> GetByVoucherSerial(TransactionManager transactionManager, System.Decimal? _voucherSerial)
		{
			int count = -1;
			return GetByVoucherSerial(transactionManager, _voucherSerial, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_STUD_VOUCHER_VCHR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_voucherSerial"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudVoucher&gt;"/> class.</returns>
		public TList<FeeStudVoucher> GetByVoucherSerial(TransactionManager transactionManager, System.Decimal? _voucherSerial, int start, int pageLength)
		{
			int count = -1;
			return GetByVoucherSerial(transactionManager, _voucherSerial, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_STUD_VOUCHER_VCHR index.
		/// </summary>
		/// <param name="_voucherSerial"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudVoucher&gt;"/> class.</returns>
		public TList<FeeStudVoucher> GetByVoucherSerial(System.Decimal? _voucherSerial, int start, int pageLength, out int count)
		{
			return GetByVoucherSerial(null, _voucherSerial, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_STUD_VOUCHER_VCHR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_voucherSerial"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeStudVoucher&gt;"/> class.</returns>
		public abstract TList<FeeStudVoucher> GetByVoucherSerial(TransactionManager transactionManager, System.Decimal? _voucherSerial, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;FeeStudVoucher&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;FeeStudVoucher&gt;"/></returns>
		public static TList<FeeStudVoucher> Fill(IDataReader reader, TList<FeeStudVoucher> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.FeeStudVoucher c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("FeeStudVoucher")
					.Append("|").Append((System.Decimal)reader["FEE_STUD_VOUCHER_ID"]).ToString();
					c = EntityManager.LocateOrCreate<FeeStudVoucher>(
					key.ToString(), // EntityTrackingKey
					"FeeStudVoucher",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.FeeStudVoucher();
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
					c.FeeStudVoucherId = (System.Decimal)reader["FEE_STUD_VOUCHER_ID"];
					c.OriginalFeeStudVoucherId = c.FeeStudVoucherId;
					c.VoucherSerial = Convert.IsDBNull(reader["VOUCHER_SERIAL"]) ? null : (System.Decimal?)reader["VOUCHER_SERIAL"];
					c.VoucherDate = (System.DateTime)reader["VOUCHER_DATE"];
					c.EdStudId = Convert.IsDBNull(reader["ED_STUD_ID"]) ? null : (System.Decimal?)reader["ED_STUD_ID"];
					c.EdAcadYearId = (System.Decimal)reader["ED_ACAD_YEAR_ID"];
					c.AsFacultyInfoId = Convert.IsDBNull(reader["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)reader["AS_FACULTY_INFO_ID"];
					c.TotalAmount = (System.Decimal)reader["TOTAL_AMOUNT"];
					c.ReceiptNum = Convert.IsDBNull(reader["RECEIPT_NUM"]) ? null : (System.String)reader["RECEIPT_NUM"];
					c.ReceiptDate = Convert.IsDBNull(reader["RECEIPT_DATE"]) ? null : (System.DateTime?)reader["RECEIPT_DATE"];
					c.GsCodeCurrencyId = (System.Decimal)reader["GS_CODE_CURRENCY_ID"];
					c.GsCodePayMethodId = Convert.IsDBNull(reader["GS_CODE_PAY_METHOD_ID"]) ? null : (System.Decimal?)reader["GS_CODE_PAY_METHOD_ID"];
					c.FeeCodeBankId = Convert.IsDBNull(reader["FEE_CODE_BANK_ID"]) ? null : (System.Decimal?)reader["FEE_CODE_BANK_ID"];
					c.FeeCodeTypeId = Convert.IsDBNull(reader["FEE_CODE_TYPE_ID"]) ? null : (System.Decimal?)reader["FEE_CODE_TYPE_ID"];
					c.PayFlg = Convert.IsDBNull(reader["PAY_FLG"]) ? null : (System.Decimal?)reader["PAY_FLG"];
					c.BalanceFlg = (System.Decimal)reader["BALANCE_FLG"];
					c.CancelFlg = Convert.IsDBNull(reader["CANCEL_FLG"]) ? null : (System.Boolean?)reader["CANCEL_FLG"];
					c.EdCodeSemesterId = (System.Decimal)reader["ED_CODE_SEMESTER_ID"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
					c.SeUserId = Convert.IsDBNull(reader["SE_USER_ID"]) ? null : (System.Decimal?)reader["SE_USER_ID"];
					c.UserName = Convert.IsDBNull(reader["User_Name"]) ? null : (System.String)reader["User_Name"];
					c.CheqNum = Convert.IsDBNull(reader["CHEQ_NUM"]) ? null : (System.String)reader["CHEQ_NUM"];
					c.AccntNum = Convert.IsDBNull(reader["ACCNT_NUM"]) ? null : (System.String)reader["ACCNT_NUM"];
					c.AttchdDoc = Convert.IsDBNull(reader["ATTCHD_DOC"]) ? null : (System.String)reader["ATTCHD_DOC"];
					c.StudFeeBalance = Convert.IsDBNull(reader["STUD_FEE_BALANCE"]) ? null : (System.Decimal?)reader["STUD_FEE_BALANCE"];
					c.TotalPayed = Convert.IsDBNull(reader["TOTAL_PAYED"]) ? null : (System.Decimal?)reader["TOTAL_PAYED"];
					c.LastDate = Convert.IsDBNull(reader["LAST_DATE"]) ? null : (System.DateTime?)reader["LAST_DATE"];
					c.OnlineFlg = Convert.IsDBNull(reader["ONLINE_FLG"]) ? null : (System.Int32?)reader["ONLINE_FLG"];
					c.CancelDate = Convert.IsDBNull(reader["CANCEL_DATE"]) ? null : (System.DateTime?)reader["CANCEL_DATE"];
					c.SeUserCnclId = Convert.IsDBNull(reader["SE_USER_CNCL_ID"]) ? null : (System.Decimal?)reader["SE_USER_CNCL_ID"];
					c.SpoSponsorId = Convert.IsDBNull(reader["SPO_SPONSOR_ID"]) ? null : (System.Decimal?)reader["SPO_SPONSOR_ID"];
					c.SpoFeeBalance = Convert.IsDBNull(reader["SPO_FEE_BALANCE"]) ? null : (System.Decimal?)reader["SPO_FEE_BALANCE"];
					c.AdmApplicantId = Convert.IsDBNull(reader["ADM_APPLICANT_ID"]) ? null : (System.Decimal?)reader["ADM_APPLICANT_ID"];
					c.DiscAmount = Convert.IsDBNull(reader["DISC_AMOUNT"]) ? null : (System.Decimal?)reader["DISC_AMOUNT"];
					c.CurTotBalance = Convert.IsDBNull(reader["CUR_TOT_BALANCE"]) ? null : (System.Decimal?)reader["CUR_TOT_BALANCE"];
					c.CurTotRemain = Convert.IsDBNull(reader["CUR_TOT_REMAIN"]) ? null : (System.Decimal?)reader["CUR_TOT_REMAIN"];
					c.ExchangeRate = Convert.IsDBNull(reader["EXCHANGE_RATE"]) ? null : (System.Decimal?)reader["EXCHANGE_RATE"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeStudVoucher"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeStudVoucher"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.FeeStudVoucher entity)
		{
			if (!reader.Read()) return;
			
			entity.FeeStudVoucherId = (System.Decimal)reader[((int)FeeStudVoucherColumn.FeeStudVoucherId - 1)];
			entity.OriginalFeeStudVoucherId = (System.Decimal)reader["FEE_STUD_VOUCHER_ID"];
			entity.VoucherSerial = (reader.IsDBNull(((int)FeeStudVoucherColumn.VoucherSerial - 1)))?null:(System.Decimal?)reader[((int)FeeStudVoucherColumn.VoucherSerial - 1)];
			entity.VoucherDate = (System.DateTime)reader[((int)FeeStudVoucherColumn.VoucherDate - 1)];
			entity.EdStudId = (reader.IsDBNull(((int)FeeStudVoucherColumn.EdStudId - 1)))?null:(System.Decimal?)reader[((int)FeeStudVoucherColumn.EdStudId - 1)];
			entity.EdAcadYearId = (System.Decimal)reader[((int)FeeStudVoucherColumn.EdAcadYearId - 1)];
			entity.AsFacultyInfoId = (reader.IsDBNull(((int)FeeStudVoucherColumn.AsFacultyInfoId - 1)))?null:(System.Decimal?)reader[((int)FeeStudVoucherColumn.AsFacultyInfoId - 1)];
			entity.TotalAmount = (System.Decimal)reader[((int)FeeStudVoucherColumn.TotalAmount - 1)];
			entity.ReceiptNum = (reader.IsDBNull(((int)FeeStudVoucherColumn.ReceiptNum - 1)))?null:(System.String)reader[((int)FeeStudVoucherColumn.ReceiptNum - 1)];
			entity.ReceiptDate = (reader.IsDBNull(((int)FeeStudVoucherColumn.ReceiptDate - 1)))?null:(System.DateTime?)reader[((int)FeeStudVoucherColumn.ReceiptDate - 1)];
			entity.GsCodeCurrencyId = (System.Decimal)reader[((int)FeeStudVoucherColumn.GsCodeCurrencyId - 1)];
			entity.GsCodePayMethodId = (reader.IsDBNull(((int)FeeStudVoucherColumn.GsCodePayMethodId - 1)))?null:(System.Decimal?)reader[((int)FeeStudVoucherColumn.GsCodePayMethodId - 1)];
			entity.FeeCodeBankId = (reader.IsDBNull(((int)FeeStudVoucherColumn.FeeCodeBankId - 1)))?null:(System.Decimal?)reader[((int)FeeStudVoucherColumn.FeeCodeBankId - 1)];
			entity.FeeCodeTypeId = (reader.IsDBNull(((int)FeeStudVoucherColumn.FeeCodeTypeId - 1)))?null:(System.Decimal?)reader[((int)FeeStudVoucherColumn.FeeCodeTypeId - 1)];
			entity.PayFlg = (reader.IsDBNull(((int)FeeStudVoucherColumn.PayFlg - 1)))?null:(System.Decimal?)reader[((int)FeeStudVoucherColumn.PayFlg - 1)];
			entity.BalanceFlg = (System.Decimal)reader[((int)FeeStudVoucherColumn.BalanceFlg - 1)];
			entity.CancelFlg = (reader.IsDBNull(((int)FeeStudVoucherColumn.CancelFlg - 1)))?null:(System.Boolean?)reader[((int)FeeStudVoucherColumn.CancelFlg - 1)];
			entity.EdCodeSemesterId = (System.Decimal)reader[((int)FeeStudVoucherColumn.EdCodeSemesterId - 1)];
			entity.Notes = (reader.IsDBNull(((int)FeeStudVoucherColumn.Notes - 1)))?null:(System.String)reader[((int)FeeStudVoucherColumn.Notes - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)FeeStudVoucherColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)FeeStudVoucherColumn.SeUserId - 1)];
			entity.UserName = (reader.IsDBNull(((int)FeeStudVoucherColumn.UserName - 1)))?null:(System.String)reader[((int)FeeStudVoucherColumn.UserName - 1)];
			entity.CheqNum = (reader.IsDBNull(((int)FeeStudVoucherColumn.CheqNum - 1)))?null:(System.String)reader[((int)FeeStudVoucherColumn.CheqNum - 1)];
			entity.AccntNum = (reader.IsDBNull(((int)FeeStudVoucherColumn.AccntNum - 1)))?null:(System.String)reader[((int)FeeStudVoucherColumn.AccntNum - 1)];
			entity.AttchdDoc = (reader.IsDBNull(((int)FeeStudVoucherColumn.AttchdDoc - 1)))?null:(System.String)reader[((int)FeeStudVoucherColumn.AttchdDoc - 1)];
			entity.StudFeeBalance = (reader.IsDBNull(((int)FeeStudVoucherColumn.StudFeeBalance - 1)))?null:(System.Decimal?)reader[((int)FeeStudVoucherColumn.StudFeeBalance - 1)];
			entity.TotalPayed = (reader.IsDBNull(((int)FeeStudVoucherColumn.TotalPayed - 1)))?null:(System.Decimal?)reader[((int)FeeStudVoucherColumn.TotalPayed - 1)];
			entity.LastDate = (reader.IsDBNull(((int)FeeStudVoucherColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)FeeStudVoucherColumn.LastDate - 1)];
			entity.OnlineFlg = (reader.IsDBNull(((int)FeeStudVoucherColumn.OnlineFlg - 1)))?null:(System.Int32?)reader[((int)FeeStudVoucherColumn.OnlineFlg - 1)];
			entity.CancelDate = (reader.IsDBNull(((int)FeeStudVoucherColumn.CancelDate - 1)))?null:(System.DateTime?)reader[((int)FeeStudVoucherColumn.CancelDate - 1)];
			entity.SeUserCnclId = (reader.IsDBNull(((int)FeeStudVoucherColumn.SeUserCnclId - 1)))?null:(System.Decimal?)reader[((int)FeeStudVoucherColumn.SeUserCnclId - 1)];
			entity.SpoSponsorId = (reader.IsDBNull(((int)FeeStudVoucherColumn.SpoSponsorId - 1)))?null:(System.Decimal?)reader[((int)FeeStudVoucherColumn.SpoSponsorId - 1)];
			entity.SpoFeeBalance = (reader.IsDBNull(((int)FeeStudVoucherColumn.SpoFeeBalance - 1)))?null:(System.Decimal?)reader[((int)FeeStudVoucherColumn.SpoFeeBalance - 1)];
			entity.AdmApplicantId = (reader.IsDBNull(((int)FeeStudVoucherColumn.AdmApplicantId - 1)))?null:(System.Decimal?)reader[((int)FeeStudVoucherColumn.AdmApplicantId - 1)];
			entity.DiscAmount = (reader.IsDBNull(((int)FeeStudVoucherColumn.DiscAmount - 1)))?null:(System.Decimal?)reader[((int)FeeStudVoucherColumn.DiscAmount - 1)];
			entity.CurTotBalance = (reader.IsDBNull(((int)FeeStudVoucherColumn.CurTotBalance - 1)))?null:(System.Decimal?)reader[((int)FeeStudVoucherColumn.CurTotBalance - 1)];
			entity.CurTotRemain = (reader.IsDBNull(((int)FeeStudVoucherColumn.CurTotRemain - 1)))?null:(System.Decimal?)reader[((int)FeeStudVoucherColumn.CurTotRemain - 1)];
			entity.ExchangeRate = (reader.IsDBNull(((int)FeeStudVoucherColumn.ExchangeRate - 1)))?null:(System.Decimal?)reader[((int)FeeStudVoucherColumn.ExchangeRate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeStudVoucher"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeStudVoucher"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.FeeStudVoucher entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.FeeStudVoucherId = (System.Decimal)dataRow["FEE_STUD_VOUCHER_ID"];
			entity.OriginalFeeStudVoucherId = (System.Decimal)dataRow["FEE_STUD_VOUCHER_ID"];
			entity.VoucherSerial = Convert.IsDBNull(dataRow["VOUCHER_SERIAL"]) ? null : (System.Decimal?)dataRow["VOUCHER_SERIAL"];
			entity.VoucherDate = (System.DateTime)dataRow["VOUCHER_DATE"];
			entity.EdStudId = Convert.IsDBNull(dataRow["ED_STUD_ID"]) ? null : (System.Decimal?)dataRow["ED_STUD_ID"];
			entity.EdAcadYearId = (System.Decimal)dataRow["ED_ACAD_YEAR_ID"];
			entity.AsFacultyInfoId = Convert.IsDBNull(dataRow["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)dataRow["AS_FACULTY_INFO_ID"];
			entity.TotalAmount = (System.Decimal)dataRow["TOTAL_AMOUNT"];
			entity.ReceiptNum = Convert.IsDBNull(dataRow["RECEIPT_NUM"]) ? null : (System.String)dataRow["RECEIPT_NUM"];
			entity.ReceiptDate = Convert.IsDBNull(dataRow["RECEIPT_DATE"]) ? null : (System.DateTime?)dataRow["RECEIPT_DATE"];
			entity.GsCodeCurrencyId = (System.Decimal)dataRow["GS_CODE_CURRENCY_ID"];
			entity.GsCodePayMethodId = Convert.IsDBNull(dataRow["GS_CODE_PAY_METHOD_ID"]) ? null : (System.Decimal?)dataRow["GS_CODE_PAY_METHOD_ID"];
			entity.FeeCodeBankId = Convert.IsDBNull(dataRow["FEE_CODE_BANK_ID"]) ? null : (System.Decimal?)dataRow["FEE_CODE_BANK_ID"];
			entity.FeeCodeTypeId = Convert.IsDBNull(dataRow["FEE_CODE_TYPE_ID"]) ? null : (System.Decimal?)dataRow["FEE_CODE_TYPE_ID"];
			entity.PayFlg = Convert.IsDBNull(dataRow["PAY_FLG"]) ? null : (System.Decimal?)dataRow["PAY_FLG"];
			entity.BalanceFlg = (System.Decimal)dataRow["BALANCE_FLG"];
			entity.CancelFlg = Convert.IsDBNull(dataRow["CANCEL_FLG"]) ? null : (System.Boolean?)dataRow["CANCEL_FLG"];
			entity.EdCodeSemesterId = (System.Decimal)dataRow["ED_CODE_SEMESTER_ID"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
			entity.SeUserId = Convert.IsDBNull(dataRow["SE_USER_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_ID"];
			entity.UserName = Convert.IsDBNull(dataRow["User_Name"]) ? null : (System.String)dataRow["User_Name"];
			entity.CheqNum = Convert.IsDBNull(dataRow["CHEQ_NUM"]) ? null : (System.String)dataRow["CHEQ_NUM"];
			entity.AccntNum = Convert.IsDBNull(dataRow["ACCNT_NUM"]) ? null : (System.String)dataRow["ACCNT_NUM"];
			entity.AttchdDoc = Convert.IsDBNull(dataRow["ATTCHD_DOC"]) ? null : (System.String)dataRow["ATTCHD_DOC"];
			entity.StudFeeBalance = Convert.IsDBNull(dataRow["STUD_FEE_BALANCE"]) ? null : (System.Decimal?)dataRow["STUD_FEE_BALANCE"];
			entity.TotalPayed = Convert.IsDBNull(dataRow["TOTAL_PAYED"]) ? null : (System.Decimal?)dataRow["TOTAL_PAYED"];
			entity.LastDate = Convert.IsDBNull(dataRow["LAST_DATE"]) ? null : (System.DateTime?)dataRow["LAST_DATE"];
			entity.OnlineFlg = Convert.IsDBNull(dataRow["ONLINE_FLG"]) ? null : (System.Int32?)dataRow["ONLINE_FLG"];
			entity.CancelDate = Convert.IsDBNull(dataRow["CANCEL_DATE"]) ? null : (System.DateTime?)dataRow["CANCEL_DATE"];
			entity.SeUserCnclId = Convert.IsDBNull(dataRow["SE_USER_CNCL_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_CNCL_ID"];
			entity.SpoSponsorId = Convert.IsDBNull(dataRow["SPO_SPONSOR_ID"]) ? null : (System.Decimal?)dataRow["SPO_SPONSOR_ID"];
			entity.SpoFeeBalance = Convert.IsDBNull(dataRow["SPO_FEE_BALANCE"]) ? null : (System.Decimal?)dataRow["SPO_FEE_BALANCE"];
			entity.AdmApplicantId = Convert.IsDBNull(dataRow["ADM_APPLICANT_ID"]) ? null : (System.Decimal?)dataRow["ADM_APPLICANT_ID"];
			entity.DiscAmount = Convert.IsDBNull(dataRow["DISC_AMOUNT"]) ? null : (System.Decimal?)dataRow["DISC_AMOUNT"];
			entity.CurTotBalance = Convert.IsDBNull(dataRow["CUR_TOT_BALANCE"]) ? null : (System.Decimal?)dataRow["CUR_TOT_BALANCE"];
			entity.CurTotRemain = Convert.IsDBNull(dataRow["CUR_TOT_REMAIN"]) ? null : (System.Decimal?)dataRow["CUR_TOT_REMAIN"];
			entity.ExchangeRate = Convert.IsDBNull(dataRow["EXCHANGE_RATE"]) ? null : (System.Decimal?)dataRow["EXCHANGE_RATE"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeStudVoucher"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeStudVoucher Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeStudVoucher entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region FeeCodeTypeIdSource	
			if (CanDeepLoad(entity, "FeeCodeType|FeeCodeTypeIdSource", deepLoadType, innerList) 
				&& entity.FeeCodeTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.FeeCodeTypeId ?? 0.0m);
				FeeCodeType tmpEntity = EntityManager.LocateEntity<FeeCodeType>(EntityLocator.ConstructKeyFromPkItems(typeof(FeeCodeType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.FeeCodeTypeIdSource = tmpEntity;
				else
					entity.FeeCodeTypeIdSource = DataRepository.FeeCodeTypeProvider.GetByFeeCodeTypeId(transactionManager, (entity.FeeCodeTypeId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeCodeTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.FeeCodeTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.FeeCodeTypeProvider.DeepLoad(transactionManager, entity.FeeCodeTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion FeeCodeTypeIdSource

			#region AdmApplicantIdSource	
			if (CanDeepLoad(entity, "AdmApplicant|AdmApplicantIdSource", deepLoadType, innerList) 
				&& entity.AdmApplicantIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AdmApplicantId ?? 0.0m);
				AdmApplicant tmpEntity = EntityManager.LocateEntity<AdmApplicant>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmApplicant), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmApplicantIdSource = tmpEntity;
				else
					entity.AdmApplicantIdSource = DataRepository.AdmApplicantProvider.GetByAdmApplicantId(transactionManager, (entity.AdmApplicantId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmApplicantIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmApplicantIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmApplicantProvider.DeepLoad(transactionManager, entity.AdmApplicantIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmApplicantIdSource

			#region AsFacultyInfoIdSource	
			if (CanDeepLoad(entity, "AsFacultyInfo|AsFacultyInfoIdSource", deepLoadType, innerList) 
				&& entity.AsFacultyInfoIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AsFacultyInfoId ?? 0.0m);
				AsFacultyInfo tmpEntity = EntityManager.LocateEntity<AsFacultyInfo>(EntityLocator.ConstructKeyFromPkItems(typeof(AsFacultyInfo), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AsFacultyInfoIdSource = tmpEntity;
				else
					entity.AsFacultyInfoIdSource = DataRepository.AsFacultyInfoProvider.GetByAsFacultyInfoId(transactionManager, (entity.AsFacultyInfoId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AsFacultyInfoIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AsFacultyInfoIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AsFacultyInfoProvider.DeepLoad(transactionManager, entity.AsFacultyInfoIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AsFacultyInfoIdSource

			#region EdAcadYearIdSource	
			if (CanDeepLoad(entity, "EdAcadYear|EdAcadYearIdSource", deepLoadType, innerList) 
				&& entity.EdAcadYearIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdAcadYearId;
				EdAcadYear tmpEntity = EntityManager.LocateEntity<EdAcadYear>(EntityLocator.ConstructKeyFromPkItems(typeof(EdAcadYear), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdAcadYearIdSource = tmpEntity;
				else
					entity.EdAcadYearIdSource = DataRepository.EdAcadYearProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdAcadYearIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdAcadYearIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdAcadYearProvider.DeepLoad(transactionManager, entity.EdAcadYearIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdAcadYearIdSource

			#region EdCodeSemesterIdSource	
			if (CanDeepLoad(entity, "EdCodeSemester|EdCodeSemesterIdSource", deepLoadType, innerList) 
				&& entity.EdCodeSemesterIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdCodeSemesterId;
				EdCodeSemester tmpEntity = EntityManager.LocateEntity<EdCodeSemester>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeSemester), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeSemesterIdSource = tmpEntity;
				else
					entity.EdCodeSemesterIdSource = DataRepository.EdCodeSemesterProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeSemesterIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeSemesterIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeSemesterProvider.DeepLoad(transactionManager, entity.EdCodeSemesterIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeSemesterIdSource

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

			#region GsCodePayMethodIdSource	
			if (CanDeepLoad(entity, "GsCodePayMethod|GsCodePayMethodIdSource", deepLoadType, innerList) 
				&& entity.GsCodePayMethodIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCodePayMethodId ?? 0.0m);
				GsCodePayMethod tmpEntity = EntityManager.LocateEntity<GsCodePayMethod>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodePayMethod), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodePayMethodIdSource = tmpEntity;
				else
					entity.GsCodePayMethodIdSource = DataRepository.GsCodePayMethodProvider.GetByGsCodePayMethodId(transactionManager, (entity.GsCodePayMethodId ?? 0.0m));		
				
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

			#region SeUserCnclIdSource	
			if (CanDeepLoad(entity, "SeUser|SeUserCnclIdSource", deepLoadType, innerList) 
				&& entity.SeUserCnclIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SeUserCnclId ?? 0.0m);
				SeUser tmpEntity = EntityManager.LocateEntity<SeUser>(EntityLocator.ConstructKeyFromPkItems(typeof(SeUser), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SeUserCnclIdSource = tmpEntity;
				else
					entity.SeUserCnclIdSource = DataRepository.SeUserProvider.GetBySeUserId(transactionManager, (entity.SeUserCnclId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeUserCnclIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SeUserCnclIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SeUserProvider.DeepLoad(transactionManager, entity.SeUserCnclIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SeUserCnclIdSource

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
			// Deep load child collections  - Call GetByFeeStudVoucherId methods when available
			
			#region FeeTreasuryCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeTreasury>|FeeTreasuryCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeTreasuryCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeTreasuryCollection = DataRepository.FeeTreasuryProvider.GetByFeeStudVoucherId(transactionManager, entity.FeeStudVoucherId);

				if (deep && entity.FeeTreasuryCollection.Count > 0)
				{
					deepHandles.Add("FeeTreasuryCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeTreasury>) DataRepository.FeeTreasuryProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeTreasuryCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeStudVoucherPayMthodCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeStudVoucherPayMthod>|FeeStudVoucherPayMthodCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudVoucherPayMthodCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeStudVoucherPayMthodCollection = DataRepository.FeeStudVoucherPayMthodProvider.GetByFeeStudVoucherId(transactionManager, entity.FeeStudVoucherId);

				if (deep && entity.FeeStudVoucherPayMthodCollection.Count > 0)
				{
					deepHandles.Add("FeeStudVoucherPayMthodCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudVoucherPayMthod>) DataRepository.FeeStudVoucherPayMthodProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudVoucherPayMthodCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeStudVoucherItemCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeStudVoucherItem>|FeeStudVoucherItemCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudVoucherItemCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeStudVoucherItemCollection = DataRepository.FeeStudVoucherItemProvider.GetByFeeStudVoucherId(transactionManager, entity.FeeStudVoucherId);

				if (deep && entity.FeeStudVoucherItemCollection.Count > 0)
				{
					deepHandles.Add("FeeStudVoucherItemCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudVoucherItem>) DataRepository.FeeStudVoucherItemProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudVoucherItemCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.FeeVoucherInvocCollection = DataRepository.FeeVoucherInvocProvider.GetByFeeStudVoucherId(transactionManager, entity.FeeStudVoucherId);

				if (deep && entity.FeeVoucherInvocCollection.Count > 0)
				{
					deepHandles.Add("FeeVoucherInvocCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeVoucherInvoc>) DataRepository.FeeVoucherInvocProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeVoucherInvocCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.FeeStudVoucher object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.FeeStudVoucher instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeStudVoucher Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeStudVoucher entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region FeeCodeTypeIdSource
			if (CanDeepSave(entity, "FeeCodeType|FeeCodeTypeIdSource", deepSaveType, innerList) 
				&& entity.FeeCodeTypeIdSource != null)
			{
				DataRepository.FeeCodeTypeProvider.Save(transactionManager, entity.FeeCodeTypeIdSource);
				entity.FeeCodeTypeId = entity.FeeCodeTypeIdSource.FeeCodeTypeId;
			}
			#endregion 
			
			#region AdmApplicantIdSource
			if (CanDeepSave(entity, "AdmApplicant|AdmApplicantIdSource", deepSaveType, innerList) 
				&& entity.AdmApplicantIdSource != null)
			{
				DataRepository.AdmApplicantProvider.Save(transactionManager, entity.AdmApplicantIdSource);
				entity.AdmApplicantId = entity.AdmApplicantIdSource.AdmApplicantId;
			}
			#endregion 
			
			#region AsFacultyInfoIdSource
			if (CanDeepSave(entity, "AsFacultyInfo|AsFacultyInfoIdSource", deepSaveType, innerList) 
				&& entity.AsFacultyInfoIdSource != null)
			{
				DataRepository.AsFacultyInfoProvider.Save(transactionManager, entity.AsFacultyInfoIdSource);
				entity.AsFacultyInfoId = entity.AsFacultyInfoIdSource.AsFacultyInfoId;
			}
			#endregion 
			
			#region EdAcadYearIdSource
			if (CanDeepSave(entity, "EdAcadYear|EdAcadYearIdSource", deepSaveType, innerList) 
				&& entity.EdAcadYearIdSource != null)
			{
				DataRepository.EdAcadYearProvider.Save(transactionManager, entity.EdAcadYearIdSource);
				entity.EdAcadYearId = entity.EdAcadYearIdSource.EdAcadYearId;
			}
			#endregion 
			
			#region EdCodeSemesterIdSource
			if (CanDeepSave(entity, "EdCodeSemester|EdCodeSemesterIdSource", deepSaveType, innerList) 
				&& entity.EdCodeSemesterIdSource != null)
			{
				DataRepository.EdCodeSemesterProvider.Save(transactionManager, entity.EdCodeSemesterIdSource);
				entity.EdCodeSemesterId = entity.EdCodeSemesterIdSource.EdCodeSemesterId;
			}
			#endregion 
			
			#region EdStudIdSource
			if (CanDeepSave(entity, "EdStud|EdStudIdSource", deepSaveType, innerList) 
				&& entity.EdStudIdSource != null)
			{
				DataRepository.EdStudProvider.Save(transactionManager, entity.EdStudIdSource);
				entity.EdStudId = entity.EdStudIdSource.EdStudId;
			}
			#endregion 
			
			#region FeeCodeBankIdSource
			if (CanDeepSave(entity, "FeeCodeBanks|FeeCodeBankIdSource", deepSaveType, innerList) 
				&& entity.FeeCodeBankIdSource != null)
			{
				DataRepository.FeeCodeBanksProvider.Save(transactionManager, entity.FeeCodeBankIdSource);
				entity.FeeCodeBankId = entity.FeeCodeBankIdSource.FeeCodeBankId;
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
			
			#region GsCodePayMethodIdSource
			if (CanDeepSave(entity, "GsCodePayMethod|GsCodePayMethodIdSource", deepSaveType, innerList) 
				&& entity.GsCodePayMethodIdSource != null)
			{
				DataRepository.GsCodePayMethodProvider.Save(transactionManager, entity.GsCodePayMethodIdSource);
				entity.GsCodePayMethodId = entity.GsCodePayMethodIdSource.GsCodePayMethodId;
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
			
			#region SeUserCnclIdSource
			if (CanDeepSave(entity, "SeUser|SeUserCnclIdSource", deepSaveType, innerList) 
				&& entity.SeUserCnclIdSource != null)
			{
				DataRepository.SeUserProvider.Save(transactionManager, entity.SeUserCnclIdSource);
				entity.SeUserCnclId = entity.SeUserCnclIdSource.SeUserId;
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
	
			#region List<FeeTreasury>
				if (CanDeepSave(entity.FeeTreasuryCollection, "List<FeeTreasury>|FeeTreasuryCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeTreasury child in entity.FeeTreasuryCollection)
					{
						if(child.FeeStudVoucherIdSource != null)
						{
							child.FeeStudVoucherId = child.FeeStudVoucherIdSource.FeeStudVoucherId;
						}
						else
						{
							child.FeeStudVoucherId = entity.FeeStudVoucherId;
						}

					}

					if (entity.FeeTreasuryCollection.Count > 0 || entity.FeeTreasuryCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeTreasuryProvider.Save(transactionManager, entity.FeeTreasuryCollection);
						
						deepHandles.Add("FeeTreasuryCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeTreasury >) DataRepository.FeeTreasuryProvider.DeepSave,
							new object[] { transactionManager, entity.FeeTreasuryCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeStudVoucherPayMthod>
				if (CanDeepSave(entity.FeeStudVoucherPayMthodCollection, "List<FeeStudVoucherPayMthod>|FeeStudVoucherPayMthodCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeStudVoucherPayMthod child in entity.FeeStudVoucherPayMthodCollection)
					{
						if(child.FeeStudVoucherIdSource != null)
						{
							child.FeeStudVoucherId = child.FeeStudVoucherIdSource.FeeStudVoucherId;
						}
						else
						{
							child.FeeStudVoucherId = entity.FeeStudVoucherId;
						}

					}

					if (entity.FeeStudVoucherPayMthodCollection.Count > 0 || entity.FeeStudVoucherPayMthodCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeStudVoucherPayMthodProvider.Save(transactionManager, entity.FeeStudVoucherPayMthodCollection);
						
						deepHandles.Add("FeeStudVoucherPayMthodCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeStudVoucherPayMthod >) DataRepository.FeeStudVoucherPayMthodProvider.DeepSave,
							new object[] { transactionManager, entity.FeeStudVoucherPayMthodCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeStudVoucherItem>
				if (CanDeepSave(entity.FeeStudVoucherItemCollection, "List<FeeStudVoucherItem>|FeeStudVoucherItemCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeStudVoucherItem child in entity.FeeStudVoucherItemCollection)
					{
						if(child.FeeStudVoucherIdSource != null)
						{
							child.FeeStudVoucherId = child.FeeStudVoucherIdSource.FeeStudVoucherId;
						}
						else
						{
							child.FeeStudVoucherId = entity.FeeStudVoucherId;
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
				
	
			#region List<FeeVoucherInvoc>
				if (CanDeepSave(entity.FeeVoucherInvocCollection, "List<FeeVoucherInvoc>|FeeVoucherInvocCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeVoucherInvoc child in entity.FeeVoucherInvocCollection)
					{
						if(child.FeeStudVoucherIdSource != null)
						{
							child.FeeStudVoucherId = child.FeeStudVoucherIdSource.FeeStudVoucherId;
						}
						else
						{
							child.FeeStudVoucherId = entity.FeeStudVoucherId;
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
	
	#region FeeStudVoucherChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.FeeStudVoucher</c>
	///</summary>
	public enum FeeStudVoucherChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>FeeCodeType</c> at FeeCodeTypeIdSource
		///</summary>
		[ChildEntityType(typeof(FeeCodeType))]
		FeeCodeType,
		
		///<summary>
		/// Composite Property for <c>AdmApplicant</c> at AdmApplicantIdSource
		///</summary>
		[ChildEntityType(typeof(AdmApplicant))]
		AdmApplicant,
		
		///<summary>
		/// Composite Property for <c>AsFacultyInfo</c> at AsFacultyInfoIdSource
		///</summary>
		[ChildEntityType(typeof(AsFacultyInfo))]
		AsFacultyInfo,
		
		///<summary>
		/// Composite Property for <c>EdAcadYear</c> at EdAcadYearIdSource
		///</summary>
		[ChildEntityType(typeof(EdAcadYear))]
		EdAcadYear,
		
		///<summary>
		/// Composite Property for <c>EdCodeSemester</c> at EdCodeSemesterIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeSemester))]
		EdCodeSemester,
		
		///<summary>
		/// Composite Property for <c>EdStud</c> at EdStudIdSource
		///</summary>
		[ChildEntityType(typeof(EdStud))]
		EdStud,
		
		///<summary>
		/// Composite Property for <c>FeeCodeBanks</c> at FeeCodeBankIdSource
		///</summary>
		[ChildEntityType(typeof(FeeCodeBanks))]
		FeeCodeBanks,
		
		///<summary>
		/// Composite Property for <c>GsCodeCurrency</c> at GsCodeCurrencyIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeCurrency))]
		GsCodeCurrency,
		
		///<summary>
		/// Composite Property for <c>GsCodePayMethod</c> at GsCodePayMethodIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodePayMethod))]
		GsCodePayMethod,
		
		///<summary>
		/// Composite Property for <c>SeUser</c> at SeUserIdSource
		///</summary>
		[ChildEntityType(typeof(SeUser))]
		SeUser,
		
		///<summary>
		/// Composite Property for <c>SpoSponsor</c> at SpoSponsorIdSource
		///</summary>
		[ChildEntityType(typeof(SpoSponsor))]
		SpoSponsor,
		///<summary>
		/// Collection of <c>FeeStudVoucher</c> as OneToMany for FeeTreasuryCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeTreasury>))]
		FeeTreasuryCollection,
		///<summary>
		/// Collection of <c>FeeStudVoucher</c> as OneToMany for FeeStudVoucherPayMthodCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudVoucherPayMthod>))]
		FeeStudVoucherPayMthodCollection,
		///<summary>
		/// Collection of <c>FeeStudVoucher</c> as OneToMany for FeeStudVoucherItemCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudVoucherItem>))]
		FeeStudVoucherItemCollection,
		///<summary>
		/// Collection of <c>FeeStudVoucher</c> as OneToMany for FeeVoucherInvocCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeVoucherInvoc>))]
		FeeVoucherInvocCollection,
	}
	
	#endregion FeeStudVoucherChildEntityTypes
	
	#region FeeStudVoucherFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;FeeStudVoucherColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeStudVoucher"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeStudVoucherFilterBuilder : SqlFilterBuilder<FeeStudVoucherColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeStudVoucherFilterBuilder class.
		/// </summary>
		public FeeStudVoucherFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeStudVoucherFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeStudVoucherFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeStudVoucherFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeStudVoucherFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeStudVoucherFilterBuilder
	
	#region FeeStudVoucherParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;FeeStudVoucherColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeStudVoucher"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeStudVoucherParameterBuilder : ParameterizedSqlFilterBuilder<FeeStudVoucherColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeStudVoucherParameterBuilder class.
		/// </summary>
		public FeeStudVoucherParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeStudVoucherParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeStudVoucherParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeStudVoucherParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeStudVoucherParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeStudVoucherParameterBuilder
	
	#region FeeStudVoucherSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;FeeStudVoucherColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeStudVoucher"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class FeeStudVoucherSortBuilder : SqlSortBuilder<FeeStudVoucherColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeStudVoucherSqlSortBuilder class.
		/// </summary>
		public FeeStudVoucherSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion FeeStudVoucherSortBuilder
	
} // end namespace
