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
	/// This class is the base class for any <see cref="FeeRefndStdReqProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class FeeRefndStdReqProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.FeeRefndStdReq, UMIS_VER2.BusinessLyer.FeeRefndStdReqKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeRefndStdReqKey key)
		{
			return Delete(transactionManager, key.FeeRefndStdReqId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_feeRefndStdReqId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _feeRefndStdReqId)
		{
			return Delete(null, _feeRefndStdReqId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeRefndStdReqId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _feeRefndStdReqId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_REFND_STD_REQ_ADM_APPLICANT key.
		///		FK_FEE_REFND_STD_REQ_ADM_APPLICANT Description: 
		/// </summary>
		/// <param name="_admApplicantId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeRefndStdReq objects.</returns>
		public TList<FeeRefndStdReq> GetByAdmApplicantId(System.Decimal? _admApplicantId)
		{
			int count = -1;
			return GetByAdmApplicantId(_admApplicantId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_REFND_STD_REQ_ADM_APPLICANT key.
		///		FK_FEE_REFND_STD_REQ_ADM_APPLICANT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeRefndStdReq objects.</returns>
		/// <remarks></remarks>
		public TList<FeeRefndStdReq> GetByAdmApplicantId(TransactionManager transactionManager, System.Decimal? _admApplicantId)
		{
			int count = -1;
			return GetByAdmApplicantId(transactionManager, _admApplicantId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_REFND_STD_REQ_ADM_APPLICANT key.
		///		FK_FEE_REFND_STD_REQ_ADM_APPLICANT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeRefndStdReq objects.</returns>
		public TList<FeeRefndStdReq> GetByAdmApplicantId(TransactionManager transactionManager, System.Decimal? _admApplicantId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmApplicantId(transactionManager, _admApplicantId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_REFND_STD_REQ_ADM_APPLICANT key.
		///		fkFeeRefndStdReqAdmApplicant Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admApplicantId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeRefndStdReq objects.</returns>
		public TList<FeeRefndStdReq> GetByAdmApplicantId(System.Decimal? _admApplicantId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmApplicantId(null, _admApplicantId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_REFND_STD_REQ_ADM_APPLICANT key.
		///		fkFeeRefndStdReqAdmApplicant Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeRefndStdReq objects.</returns>
		public TList<FeeRefndStdReq> GetByAdmApplicantId(System.Decimal? _admApplicantId, int start, int pageLength,out int count)
		{
			return GetByAdmApplicantId(null, _admApplicantId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_REFND_STD_REQ_ADM_APPLICANT key.
		///		FK_FEE_REFND_STD_REQ_ADM_APPLICANT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeRefndStdReq objects.</returns>
		public abstract TList<FeeRefndStdReq> GetByAdmApplicantId(TransactionManager transactionManager, System.Decimal? _admApplicantId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_REFND_STD_REQ_FEE_CODE_BANKS key.
		///		FK_FEE_REFND_STD_REQ_FEE_CODE_BANKS Description: 
		/// </summary>
		/// <param name="_feeCodeBankId">في حالة وسيلة الدفع "شيك" يتم ادخال البنك ورقم الحساب ورقم الشيك وتاريخ استحقاق الشيك</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeRefndStdReq objects.</returns>
		public TList<FeeRefndStdReq> GetByFeeCodeBankId(System.Decimal? _feeCodeBankId)
		{
			int count = -1;
			return GetByFeeCodeBankId(_feeCodeBankId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_REFND_STD_REQ_FEE_CODE_BANKS key.
		///		FK_FEE_REFND_STD_REQ_FEE_CODE_BANKS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeBankId">في حالة وسيلة الدفع "شيك" يتم ادخال البنك ورقم الحساب ورقم الشيك وتاريخ استحقاق الشيك</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeRefndStdReq objects.</returns>
		/// <remarks></remarks>
		public TList<FeeRefndStdReq> GetByFeeCodeBankId(TransactionManager transactionManager, System.Decimal? _feeCodeBankId)
		{
			int count = -1;
			return GetByFeeCodeBankId(transactionManager, _feeCodeBankId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_REFND_STD_REQ_FEE_CODE_BANKS key.
		///		FK_FEE_REFND_STD_REQ_FEE_CODE_BANKS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeBankId">في حالة وسيلة الدفع "شيك" يتم ادخال البنك ورقم الحساب ورقم الشيك وتاريخ استحقاق الشيك</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeRefndStdReq objects.</returns>
		public TList<FeeRefndStdReq> GetByFeeCodeBankId(TransactionManager transactionManager, System.Decimal? _feeCodeBankId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCodeBankId(transactionManager, _feeCodeBankId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_REFND_STD_REQ_FEE_CODE_BANKS key.
		///		fkFeeRefndStdReqFeeCodeBanks Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeCodeBankId">في حالة وسيلة الدفع "شيك" يتم ادخال البنك ورقم الحساب ورقم الشيك وتاريخ استحقاق الشيك</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeRefndStdReq objects.</returns>
		public TList<FeeRefndStdReq> GetByFeeCodeBankId(System.Decimal? _feeCodeBankId, int start, int pageLength)
		{
			int count =  -1;
			return GetByFeeCodeBankId(null, _feeCodeBankId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_REFND_STD_REQ_FEE_CODE_BANKS key.
		///		fkFeeRefndStdReqFeeCodeBanks Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeCodeBankId">في حالة وسيلة الدفع "شيك" يتم ادخال البنك ورقم الحساب ورقم الشيك وتاريخ استحقاق الشيك</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeRefndStdReq objects.</returns>
		public TList<FeeRefndStdReq> GetByFeeCodeBankId(System.Decimal? _feeCodeBankId, int start, int pageLength,out int count)
		{
			return GetByFeeCodeBankId(null, _feeCodeBankId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_REFND_STD_REQ_FEE_CODE_BANKS key.
		///		FK_FEE_REFND_STD_REQ_FEE_CODE_BANKS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeBankId">في حالة وسيلة الدفع "شيك" يتم ادخال البنك ورقم الحساب ورقم الشيك وتاريخ استحقاق الشيك</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeRefndStdReq objects.</returns>
		public abstract TList<FeeRefndStdReq> GetByFeeCodeBankId(TransactionManager transactionManager, System.Decimal? _feeCodeBankId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.FeeRefndStdReq Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeRefndStdReqKey key, int start, int pageLength)
		{
			return GetByFeeRefndStdReqId(transactionManager, key.FeeRefndStdReqId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeRefndStdReq&gt;"/> class.</returns>
		public TList<FeeRefndStdReq> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeRefndStdReq&gt;"/> class.</returns>
		public TList<FeeRefndStdReq> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeRefndStdReq&gt;"/> class.</returns>
		public TList<FeeRefndStdReq> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeRefndStdReq&gt;"/> class.</returns>
		public TList<FeeRefndStdReq> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeRefndStdReq&gt;"/> class.</returns>
		public TList<FeeRefndStdReq> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength, out int count)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeRefndStdReq&gt;"/> class.</returns>
		public abstract TList<FeeRefndStdReq> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_CURRENCY_ID_1 index.
		/// </summary>
		/// <param name="_currencyId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeRefndStdReq&gt;"/> class.</returns>
		public TList<FeeRefndStdReq> GetByCurrencyId(System.Decimal _currencyId)
		{
			int count = -1;
			return GetByCurrencyId(null,_currencyId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_CURRENCY_ID_1 index.
		/// </summary>
		/// <param name="_currencyId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeRefndStdReq&gt;"/> class.</returns>
		public TList<FeeRefndStdReq> GetByCurrencyId(System.Decimal _currencyId, int start, int pageLength)
		{
			int count = -1;
			return GetByCurrencyId(null, _currencyId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_CURRENCY_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_currencyId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeRefndStdReq&gt;"/> class.</returns>
		public TList<FeeRefndStdReq> GetByCurrencyId(TransactionManager transactionManager, System.Decimal _currencyId)
		{
			int count = -1;
			return GetByCurrencyId(transactionManager, _currencyId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_CURRENCY_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_currencyId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeRefndStdReq&gt;"/> class.</returns>
		public TList<FeeRefndStdReq> GetByCurrencyId(TransactionManager transactionManager, System.Decimal _currencyId, int start, int pageLength)
		{
			int count = -1;
			return GetByCurrencyId(transactionManager, _currencyId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_CURRENCY_ID_1 index.
		/// </summary>
		/// <param name="_currencyId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeRefndStdReq&gt;"/> class.</returns>
		public TList<FeeRefndStdReq> GetByCurrencyId(System.Decimal _currencyId, int start, int pageLength, out int count)
		{
			return GetByCurrencyId(null, _currencyId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_CURRENCY_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_currencyId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeRefndStdReq&gt;"/> class.</returns>
		public abstract TList<FeeRefndStdReq> GetByCurrencyId(TransactionManager transactionManager, System.Decimal _currencyId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_ACAD_YEAR_ID_1 index.
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeRefndStdReq&gt;"/> class.</returns>
		public TList<FeeRefndStdReq> GetByEdAcadYearId(System.Decimal _edAcadYearId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeRefndStdReq&gt;"/> class.</returns>
		public TList<FeeRefndStdReq> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeRefndStdReq&gt;"/> class.</returns>
		public TList<FeeRefndStdReq> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeRefndStdReq&gt;"/> class.</returns>
		public TList<FeeRefndStdReq> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeRefndStdReq&gt;"/> class.</returns>
		public TList<FeeRefndStdReq> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength, out int count)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeRefndStdReq&gt;"/> class.</returns>
		public abstract TList<FeeRefndStdReq> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_CODE_SEMESTER_ID_1 index.
		/// </summary>
		/// <param name="_edCodeSemesterId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeRefndStdReq&gt;"/> class.</returns>
		public TList<FeeRefndStdReq> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(null,_edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_SEMESTER_ID_1 index.
		/// </summary>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeRefndStdReq&gt;"/> class.</returns>
		public TList<FeeRefndStdReq> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_SEMESTER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeRefndStdReq&gt;"/> class.</returns>
		public TList<FeeRefndStdReq> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_SEMESTER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeRefndStdReq&gt;"/> class.</returns>
		public TList<FeeRefndStdReq> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_SEMESTER_ID_1 index.
		/// </summary>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeRefndStdReq&gt;"/> class.</returns>
		public TList<FeeRefndStdReq> GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId, int start, int pageLength, out int count)
		{
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_SEMESTER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeRefndStdReq&gt;"/> class.</returns>
		public abstract TList<FeeRefndStdReq> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_STUD_ID_1 index.
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeRefndStdReq&gt;"/> class.</returns>
		public TList<FeeRefndStdReq> GetByEdStudId(System.Decimal? _edStudId)
		{
			int count = -1;
			return GetByEdStudId(null,_edStudId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_ID_1 index.
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeRefndStdReq&gt;"/> class.</returns>
		public TList<FeeRefndStdReq> GetByEdStudId(System.Decimal? _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeRefndStdReq&gt;"/> class.</returns>
		public TList<FeeRefndStdReq> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeRefndStdReq&gt;"/> class.</returns>
		public TList<FeeRefndStdReq> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_ID_1 index.
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeRefndStdReq&gt;"/> class.</returns>
		public TList<FeeRefndStdReq> GetByEdStudId(System.Decimal? _edStudId, int start, int pageLength, out int count)
		{
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeRefndStdReq&gt;"/> class.</returns>
		public abstract TList<FeeRefndStdReq> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_GS_CODE_REQ_STATUS_I_1 index.
		/// </summary>
		/// <param name="_gsCodeReqStatusId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeRefndStdReq&gt;"/> class.</returns>
		public TList<FeeRefndStdReq> GetByGsCodeReqStatusId(System.Decimal? _gsCodeReqStatusId)
		{
			int count = -1;
			return GetByGsCodeReqStatusId(null,_gsCodeReqStatusId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_REQ_STATUS_I_1 index.
		/// </summary>
		/// <param name="_gsCodeReqStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeRefndStdReq&gt;"/> class.</returns>
		public TList<FeeRefndStdReq> GetByGsCodeReqStatusId(System.Decimal? _gsCodeReqStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeReqStatusId(null, _gsCodeReqStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_REQ_STATUS_I_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeReqStatusId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeRefndStdReq&gt;"/> class.</returns>
		public TList<FeeRefndStdReq> GetByGsCodeReqStatusId(TransactionManager transactionManager, System.Decimal? _gsCodeReqStatusId)
		{
			int count = -1;
			return GetByGsCodeReqStatusId(transactionManager, _gsCodeReqStatusId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_REQ_STATUS_I_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeReqStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeRefndStdReq&gt;"/> class.</returns>
		public TList<FeeRefndStdReq> GetByGsCodeReqStatusId(TransactionManager transactionManager, System.Decimal? _gsCodeReqStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeReqStatusId(transactionManager, _gsCodeReqStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_REQ_STATUS_I_1 index.
		/// </summary>
		/// <param name="_gsCodeReqStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeRefndStdReq&gt;"/> class.</returns>
		public TList<FeeRefndStdReq> GetByGsCodeReqStatusId(System.Decimal? _gsCodeReqStatusId, int start, int pageLength, out int count)
		{
			return GetByGsCodeReqStatusId(null, _gsCodeReqStatusId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_REQ_STATUS_I_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeReqStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeRefndStdReq&gt;"/> class.</returns>
		public abstract TList<FeeRefndStdReq> GetByGsCodeReqStatusId(TransactionManager transactionManager, System.Decimal? _gsCodeReqStatusId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_REFUND_STUD_REQ_MASTER index.
		/// </summary>
		/// <param name="_feeRefndStdReqId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeRefndStdReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeRefndStdReq GetByFeeRefndStdReqId(System.Decimal _feeRefndStdReqId)
		{
			int count = -1;
			return GetByFeeRefndStdReqId(null,_feeRefndStdReqId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_REFUND_STUD_REQ_MASTER index.
		/// </summary>
		/// <param name="_feeRefndStdReqId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeRefndStdReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeRefndStdReq GetByFeeRefndStdReqId(System.Decimal _feeRefndStdReqId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeRefndStdReqId(null, _feeRefndStdReqId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_REFUND_STUD_REQ_MASTER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeRefndStdReqId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeRefndStdReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeRefndStdReq GetByFeeRefndStdReqId(TransactionManager transactionManager, System.Decimal _feeRefndStdReqId)
		{
			int count = -1;
			return GetByFeeRefndStdReqId(transactionManager, _feeRefndStdReqId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_REFUND_STUD_REQ_MASTER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeRefndStdReqId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeRefndStdReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeRefndStdReq GetByFeeRefndStdReqId(TransactionManager transactionManager, System.Decimal _feeRefndStdReqId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeRefndStdReqId(transactionManager, _feeRefndStdReqId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_REFUND_STUD_REQ_MASTER index.
		/// </summary>
		/// <param name="_feeRefndStdReqId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeRefndStdReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeRefndStdReq GetByFeeRefndStdReqId(System.Decimal _feeRefndStdReqId, int start, int pageLength, out int count)
		{
			return GetByFeeRefndStdReqId(null, _feeRefndStdReqId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_REFUND_STUD_REQ_MASTER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeRefndStdReqId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeRefndStdReq"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.FeeRefndStdReq GetByFeeRefndStdReqId(TransactionManager transactionManager, System.Decimal _feeRefndStdReqId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_FEE_REFND_STD_REQ_NUM index.
		/// </summary>
		/// <param name="_rfndNumber"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeRefndStdReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeRefndStdReq GetByRfndNumber(System.String _rfndNumber)
		{
			int count = -1;
			return GetByRfndNumber(null,_rfndNumber, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_REFND_STD_REQ_NUM index.
		/// </summary>
		/// <param name="_rfndNumber"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeRefndStdReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeRefndStdReq GetByRfndNumber(System.String _rfndNumber, int start, int pageLength)
		{
			int count = -1;
			return GetByRfndNumber(null, _rfndNumber, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_REFND_STD_REQ_NUM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_rfndNumber"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeRefndStdReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeRefndStdReq GetByRfndNumber(TransactionManager transactionManager, System.String _rfndNumber)
		{
			int count = -1;
			return GetByRfndNumber(transactionManager, _rfndNumber, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_REFND_STD_REQ_NUM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_rfndNumber"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeRefndStdReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeRefndStdReq GetByRfndNumber(TransactionManager transactionManager, System.String _rfndNumber, int start, int pageLength)
		{
			int count = -1;
			return GetByRfndNumber(transactionManager, _rfndNumber, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_REFND_STD_REQ_NUM index.
		/// </summary>
		/// <param name="_rfndNumber"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeRefndStdReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeRefndStdReq GetByRfndNumber(System.String _rfndNumber, int start, int pageLength, out int count)
		{
			return GetByRfndNumber(null, _rfndNumber, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_REFND_STD_REQ_NUM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_rfndNumber"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeRefndStdReq"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.FeeRefndStdReq GetByRfndNumber(TransactionManager transactionManager, System.String _rfndNumber, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;FeeRefndStdReq&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;FeeRefndStdReq&gt;"/></returns>
		public static TList<FeeRefndStdReq> Fill(IDataReader reader, TList<FeeRefndStdReq> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.FeeRefndStdReq c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("FeeRefndStdReq")
					.Append("|").Append((System.Decimal)reader["FEE_REFND_STD_REQ_ID"]).ToString();
					c = EntityManager.LocateOrCreate<FeeRefndStdReq>(
					key.ToString(), // EntityTrackingKey
					"FeeRefndStdReq",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.FeeRefndStdReq();
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
					c.FeeRefndStdReqId = (System.Decimal)reader["FEE_REFND_STD_REQ_ID"];
					c.OriginalFeeRefndStdReqId = c.FeeRefndStdReqId;
					c.RfndDate = (System.DateTime)reader["RFND_DATE"];
					c.AsFacultyInfoId = (System.Decimal)reader["AS_FACULTY_INFO_ID"];
					c.EdStudId = Convert.IsDBNull(reader["ED_STUD_ID"]) ? null : (System.Decimal?)reader["ED_STUD_ID"];
					c.EdAcadYearId = (System.Decimal)reader["ED_ACAD_YEAR_ID"];
					c.EdCodeSemesterId = (System.Decimal)reader["ED_CODE_SEMESTER_ID"];
					c.TotRfndValue = Convert.IsDBNull(reader["TOT_RFND_VALUE"]) ? null : (System.Decimal?)reader["TOT_RFND_VALUE"];
					c.TotRfndPrcnt = Convert.IsDBNull(reader["TOT_RFND_PRCNT"]) ? null : (System.Decimal?)reader["TOT_RFND_PRCNT"];
					c.RfndReason = Convert.IsDBNull(reader["RFND_REASON"]) ? null : (System.String)reader["RFND_REASON"];
					c.CurrencyId = (System.Decimal)reader["CURRENCY_ID"];
					c.GsCodeReqStatusId = Convert.IsDBNull(reader["GS_CODE_REQ_STATUS_ID"]) ? null : (System.Decimal?)reader["GS_CODE_REQ_STATUS_ID"];
					c.Notes = (System.String)reader["NOTES"];
					c.RfndNumber = Convert.IsDBNull(reader["RFND_NUMBER"]) ? null : (System.String)reader["RFND_NUMBER"];
					c.CalcRfndValue = Convert.IsDBNull(reader["CALC_RFND_VALUE"]) ? null : (System.Decimal?)reader["CALC_RFND_VALUE"];
					c.CalcRfndPrcnt = Convert.IsDBNull(reader["CALC_RFND_PRCNT"]) ? null : (System.Decimal?)reader["CALC_RFND_PRCNT"];
					c.StudFeeBalance = Convert.IsDBNull(reader["STUD_FEE_BALANCE"]) ? null : (System.Decimal?)reader["STUD_FEE_BALANCE"];
					c.RefndTypeId = Convert.IsDBNull(reader["REFND_TYPE_ID"]) ? null : (System.Int32?)reader["REFND_TYPE_ID"];
					c.AdmApplicantId = Convert.IsDBNull(reader["ADM_APPLICANT_ID"]) ? null : (System.Decimal?)reader["ADM_APPLICANT_ID"];
					c.CancelFlg = Convert.IsDBNull(reader["CANCEL_FLG"]) ? null : (System.Boolean?)reader["CANCEL_FLG"];
					c.CancelDate = Convert.IsDBNull(reader["CANCEL_DATE"]) ? null : (System.DateTime?)reader["CANCEL_DATE"];
					c.SeUserCnclId = Convert.IsDBNull(reader["SE_USER_CNCL_ID"]) ? null : (System.Decimal?)reader["SE_USER_CNCL_ID"];
					c.SeUserId = Convert.IsDBNull(reader["SE_USER_ID"]) ? null : (System.Decimal?)reader["SE_USER_ID"];
					c.UserName = Convert.IsDBNull(reader["USER_NAME"]) ? null : (System.String)reader["USER_NAME"];
					c.LastDate = Convert.IsDBNull(reader["LAST_DATE"]) ? null : (System.DateTime?)reader["LAST_DATE"];
					c.CheqNum = Convert.IsDBNull(reader["CHEQ_NUM"]) ? null : (System.String)reader["CHEQ_NUM"];
					c.AccntNum = Convert.IsDBNull(reader["ACCNT_NUM"]) ? null : (System.String)reader["ACCNT_NUM"];
					c.FeeCodeBankId = Convert.IsDBNull(reader["FEE_CODE_BANK_ID"]) ? null : (System.Decimal?)reader["FEE_CODE_BANK_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeRefndStdReq"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeRefndStdReq"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.FeeRefndStdReq entity)
		{
			if (!reader.Read()) return;
			
			entity.FeeRefndStdReqId = (System.Decimal)reader[((int)FeeRefndStdReqColumn.FeeRefndStdReqId - 1)];
			entity.OriginalFeeRefndStdReqId = (System.Decimal)reader["FEE_REFND_STD_REQ_ID"];
			entity.RfndDate = (System.DateTime)reader[((int)FeeRefndStdReqColumn.RfndDate - 1)];
			entity.AsFacultyInfoId = (System.Decimal)reader[((int)FeeRefndStdReqColumn.AsFacultyInfoId - 1)];
			entity.EdStudId = (reader.IsDBNull(((int)FeeRefndStdReqColumn.EdStudId - 1)))?null:(System.Decimal?)reader[((int)FeeRefndStdReqColumn.EdStudId - 1)];
			entity.EdAcadYearId = (System.Decimal)reader[((int)FeeRefndStdReqColumn.EdAcadYearId - 1)];
			entity.EdCodeSemesterId = (System.Decimal)reader[((int)FeeRefndStdReqColumn.EdCodeSemesterId - 1)];
			entity.TotRfndValue = (reader.IsDBNull(((int)FeeRefndStdReqColumn.TotRfndValue - 1)))?null:(System.Decimal?)reader[((int)FeeRefndStdReqColumn.TotRfndValue - 1)];
			entity.TotRfndPrcnt = (reader.IsDBNull(((int)FeeRefndStdReqColumn.TotRfndPrcnt - 1)))?null:(System.Decimal?)reader[((int)FeeRefndStdReqColumn.TotRfndPrcnt - 1)];
			entity.RfndReason = (reader.IsDBNull(((int)FeeRefndStdReqColumn.RfndReason - 1)))?null:(System.String)reader[((int)FeeRefndStdReqColumn.RfndReason - 1)];
			entity.CurrencyId = (System.Decimal)reader[((int)FeeRefndStdReqColumn.CurrencyId - 1)];
			entity.GsCodeReqStatusId = (reader.IsDBNull(((int)FeeRefndStdReqColumn.GsCodeReqStatusId - 1)))?null:(System.Decimal?)reader[((int)FeeRefndStdReqColumn.GsCodeReqStatusId - 1)];
			entity.Notes = (System.String)reader[((int)FeeRefndStdReqColumn.Notes - 1)];
			entity.RfndNumber = (reader.IsDBNull(((int)FeeRefndStdReqColumn.RfndNumber - 1)))?null:(System.String)reader[((int)FeeRefndStdReqColumn.RfndNumber - 1)];
			entity.CalcRfndValue = (reader.IsDBNull(((int)FeeRefndStdReqColumn.CalcRfndValue - 1)))?null:(System.Decimal?)reader[((int)FeeRefndStdReqColumn.CalcRfndValue - 1)];
			entity.CalcRfndPrcnt = (reader.IsDBNull(((int)FeeRefndStdReqColumn.CalcRfndPrcnt - 1)))?null:(System.Decimal?)reader[((int)FeeRefndStdReqColumn.CalcRfndPrcnt - 1)];
			entity.StudFeeBalance = (reader.IsDBNull(((int)FeeRefndStdReqColumn.StudFeeBalance - 1)))?null:(System.Decimal?)reader[((int)FeeRefndStdReqColumn.StudFeeBalance - 1)];
			entity.RefndTypeId = (reader.IsDBNull(((int)FeeRefndStdReqColumn.RefndTypeId - 1)))?null:(System.Int32?)reader[((int)FeeRefndStdReqColumn.RefndTypeId - 1)];
			entity.AdmApplicantId = (reader.IsDBNull(((int)FeeRefndStdReqColumn.AdmApplicantId - 1)))?null:(System.Decimal?)reader[((int)FeeRefndStdReqColumn.AdmApplicantId - 1)];
			entity.CancelFlg = (reader.IsDBNull(((int)FeeRefndStdReqColumn.CancelFlg - 1)))?null:(System.Boolean?)reader[((int)FeeRefndStdReqColumn.CancelFlg - 1)];
			entity.CancelDate = (reader.IsDBNull(((int)FeeRefndStdReqColumn.CancelDate - 1)))?null:(System.DateTime?)reader[((int)FeeRefndStdReqColumn.CancelDate - 1)];
			entity.SeUserCnclId = (reader.IsDBNull(((int)FeeRefndStdReqColumn.SeUserCnclId - 1)))?null:(System.Decimal?)reader[((int)FeeRefndStdReqColumn.SeUserCnclId - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)FeeRefndStdReqColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)FeeRefndStdReqColumn.SeUserId - 1)];
			entity.UserName = (reader.IsDBNull(((int)FeeRefndStdReqColumn.UserName - 1)))?null:(System.String)reader[((int)FeeRefndStdReqColumn.UserName - 1)];
			entity.LastDate = (reader.IsDBNull(((int)FeeRefndStdReqColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)FeeRefndStdReqColumn.LastDate - 1)];
			entity.CheqNum = (reader.IsDBNull(((int)FeeRefndStdReqColumn.CheqNum - 1)))?null:(System.String)reader[((int)FeeRefndStdReqColumn.CheqNum - 1)];
			entity.AccntNum = (reader.IsDBNull(((int)FeeRefndStdReqColumn.AccntNum - 1)))?null:(System.String)reader[((int)FeeRefndStdReqColumn.AccntNum - 1)];
			entity.FeeCodeBankId = (reader.IsDBNull(((int)FeeRefndStdReqColumn.FeeCodeBankId - 1)))?null:(System.Decimal?)reader[((int)FeeRefndStdReqColumn.FeeCodeBankId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeRefndStdReq"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeRefndStdReq"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.FeeRefndStdReq entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.FeeRefndStdReqId = (System.Decimal)dataRow["FEE_REFND_STD_REQ_ID"];
			entity.OriginalFeeRefndStdReqId = (System.Decimal)dataRow["FEE_REFND_STD_REQ_ID"];
			entity.RfndDate = (System.DateTime)dataRow["RFND_DATE"];
			entity.AsFacultyInfoId = (System.Decimal)dataRow["AS_FACULTY_INFO_ID"];
			entity.EdStudId = Convert.IsDBNull(dataRow["ED_STUD_ID"]) ? null : (System.Decimal?)dataRow["ED_STUD_ID"];
			entity.EdAcadYearId = (System.Decimal)dataRow["ED_ACAD_YEAR_ID"];
			entity.EdCodeSemesterId = (System.Decimal)dataRow["ED_CODE_SEMESTER_ID"];
			entity.TotRfndValue = Convert.IsDBNull(dataRow["TOT_RFND_VALUE"]) ? null : (System.Decimal?)dataRow["TOT_RFND_VALUE"];
			entity.TotRfndPrcnt = Convert.IsDBNull(dataRow["TOT_RFND_PRCNT"]) ? null : (System.Decimal?)dataRow["TOT_RFND_PRCNT"];
			entity.RfndReason = Convert.IsDBNull(dataRow["RFND_REASON"]) ? null : (System.String)dataRow["RFND_REASON"];
			entity.CurrencyId = (System.Decimal)dataRow["CURRENCY_ID"];
			entity.GsCodeReqStatusId = Convert.IsDBNull(dataRow["GS_CODE_REQ_STATUS_ID"]) ? null : (System.Decimal?)dataRow["GS_CODE_REQ_STATUS_ID"];
			entity.Notes = (System.String)dataRow["NOTES"];
			entity.RfndNumber = Convert.IsDBNull(dataRow["RFND_NUMBER"]) ? null : (System.String)dataRow["RFND_NUMBER"];
			entity.CalcRfndValue = Convert.IsDBNull(dataRow["CALC_RFND_VALUE"]) ? null : (System.Decimal?)dataRow["CALC_RFND_VALUE"];
			entity.CalcRfndPrcnt = Convert.IsDBNull(dataRow["CALC_RFND_PRCNT"]) ? null : (System.Decimal?)dataRow["CALC_RFND_PRCNT"];
			entity.StudFeeBalance = Convert.IsDBNull(dataRow["STUD_FEE_BALANCE"]) ? null : (System.Decimal?)dataRow["STUD_FEE_BALANCE"];
			entity.RefndTypeId = Convert.IsDBNull(dataRow["REFND_TYPE_ID"]) ? null : (System.Int32?)dataRow["REFND_TYPE_ID"];
			entity.AdmApplicantId = Convert.IsDBNull(dataRow["ADM_APPLICANT_ID"]) ? null : (System.Decimal?)dataRow["ADM_APPLICANT_ID"];
			entity.CancelFlg = Convert.IsDBNull(dataRow["CANCEL_FLG"]) ? null : (System.Boolean?)dataRow["CANCEL_FLG"];
			entity.CancelDate = Convert.IsDBNull(dataRow["CANCEL_DATE"]) ? null : (System.DateTime?)dataRow["CANCEL_DATE"];
			entity.SeUserCnclId = Convert.IsDBNull(dataRow["SE_USER_CNCL_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_CNCL_ID"];
			entity.SeUserId = Convert.IsDBNull(dataRow["SE_USER_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_ID"];
			entity.UserName = Convert.IsDBNull(dataRow["USER_NAME"]) ? null : (System.String)dataRow["USER_NAME"];
			entity.LastDate = Convert.IsDBNull(dataRow["LAST_DATE"]) ? null : (System.DateTime?)dataRow["LAST_DATE"];
			entity.CheqNum = Convert.IsDBNull(dataRow["CHEQ_NUM"]) ? null : (System.String)dataRow["CHEQ_NUM"];
			entity.AccntNum = Convert.IsDBNull(dataRow["ACCNT_NUM"]) ? null : (System.String)dataRow["ACCNT_NUM"];
			entity.FeeCodeBankId = Convert.IsDBNull(dataRow["FEE_CODE_BANK_ID"]) ? null : (System.Decimal?)dataRow["FEE_CODE_BANK_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeRefndStdReq"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeRefndStdReq Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeRefndStdReq entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

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

			#region GsCodeReqStatusIdSource	
			if (CanDeepLoad(entity, "GsCodeReqStatus|GsCodeReqStatusIdSource", deepLoadType, innerList) 
				&& entity.GsCodeReqStatusIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCodeReqStatusId ?? 0.0m);
				GsCodeReqStatus tmpEntity = EntityManager.LocateEntity<GsCodeReqStatus>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodeReqStatus), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodeReqStatusIdSource = tmpEntity;
				else
					entity.GsCodeReqStatusIdSource = DataRepository.GsCodeReqStatusProvider.GetByGsCodeReqStatusId(transactionManager, (entity.GsCodeReqStatusId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodeReqStatusIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCodeReqStatusIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodeReqStatusProvider.DeepLoad(transactionManager, entity.GsCodeReqStatusIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCodeReqStatusIdSource

			#region AsFacultyInfoIdSource	
			if (CanDeepLoad(entity, "AsFacultyInfo|AsFacultyInfoIdSource", deepLoadType, innerList) 
				&& entity.AsFacultyInfoIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AsFacultyInfoId;
				AsFacultyInfo tmpEntity = EntityManager.LocateEntity<AsFacultyInfo>(EntityLocator.ConstructKeyFromPkItems(typeof(AsFacultyInfo), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AsFacultyInfoIdSource = tmpEntity;
				else
					entity.AsFacultyInfoIdSource = DataRepository.AsFacultyInfoProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);		
				
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

			#region CurrencyIdSource	
			if (CanDeepLoad(entity, "GsCodeCurrency|CurrencyIdSource", deepLoadType, innerList) 
				&& entity.CurrencyIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.CurrencyId;
				GsCodeCurrency tmpEntity = EntityManager.LocateEntity<GsCodeCurrency>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodeCurrency), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.CurrencyIdSource = tmpEntity;
				else
					entity.CurrencyIdSource = DataRepository.GsCodeCurrencyProvider.GetByGsCodeCurrencyId(transactionManager, entity.CurrencyId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CurrencyIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.CurrencyIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodeCurrencyProvider.DeepLoad(transactionManager, entity.CurrencyIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion CurrencyIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByFeeRefndStdReqId methods when available
			
			#region FeeRefndStdDetCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeRefndStdDet>|FeeRefndStdDetCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeRefndStdDetCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeRefndStdDetCollection = DataRepository.FeeRefndStdDetProvider.GetByFeeRefndStdReqId(transactionManager, entity.FeeRefndStdReqId);

				if (deep && entity.FeeRefndStdDetCollection.Count > 0)
				{
					deepHandles.Add("FeeRefndStdDetCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeRefndStdDet>) DataRepository.FeeRefndStdDetProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeRefndStdDetCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.FeeRefndStdReq object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.FeeRefndStdReq instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeRefndStdReq Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeRefndStdReq entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AdmApplicantIdSource
			if (CanDeepSave(entity, "AdmApplicant|AdmApplicantIdSource", deepSaveType, innerList) 
				&& entity.AdmApplicantIdSource != null)
			{
				DataRepository.AdmApplicantProvider.Save(transactionManager, entity.AdmApplicantIdSource);
				entity.AdmApplicantId = entity.AdmApplicantIdSource.AdmApplicantId;
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
			
			#region GsCodeReqStatusIdSource
			if (CanDeepSave(entity, "GsCodeReqStatus|GsCodeReqStatusIdSource", deepSaveType, innerList) 
				&& entity.GsCodeReqStatusIdSource != null)
			{
				DataRepository.GsCodeReqStatusProvider.Save(transactionManager, entity.GsCodeReqStatusIdSource);
				entity.GsCodeReqStatusId = entity.GsCodeReqStatusIdSource.GsCodeReqStatusId;
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
			
			#region CurrencyIdSource
			if (CanDeepSave(entity, "GsCodeCurrency|CurrencyIdSource", deepSaveType, innerList) 
				&& entity.CurrencyIdSource != null)
			{
				DataRepository.GsCodeCurrencyProvider.Save(transactionManager, entity.CurrencyIdSource);
				entity.CurrencyId = entity.CurrencyIdSource.GsCodeCurrencyId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<FeeRefndStdDet>
				if (CanDeepSave(entity.FeeRefndStdDetCollection, "List<FeeRefndStdDet>|FeeRefndStdDetCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeRefndStdDet child in entity.FeeRefndStdDetCollection)
					{
						if(child.FeeRefndStdReqIdSource != null)
						{
							child.FeeRefndStdReqId = child.FeeRefndStdReqIdSource.FeeRefndStdReqId;
						}
						else
						{
							child.FeeRefndStdReqId = entity.FeeRefndStdReqId;
						}

					}

					if (entity.FeeRefndStdDetCollection.Count > 0 || entity.FeeRefndStdDetCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeRefndStdDetProvider.Save(transactionManager, entity.FeeRefndStdDetCollection);
						
						deepHandles.Add("FeeRefndStdDetCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeRefndStdDet >) DataRepository.FeeRefndStdDetProvider.DeepSave,
							new object[] { transactionManager, entity.FeeRefndStdDetCollection, deepSaveType, childTypes, innerList }
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
	
	#region FeeRefndStdReqChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.FeeRefndStdReq</c>
	///</summary>
	public enum FeeRefndStdReqChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AdmApplicant</c> at AdmApplicantIdSource
		///</summary>
		[ChildEntityType(typeof(AdmApplicant))]
		AdmApplicant,
		
		///<summary>
		/// Composite Property for <c>FeeCodeBanks</c> at FeeCodeBankIdSource
		///</summary>
		[ChildEntityType(typeof(FeeCodeBanks))]
		FeeCodeBanks,
		
		///<summary>
		/// Composite Property for <c>GsCodeReqStatus</c> at GsCodeReqStatusIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeReqStatus))]
		GsCodeReqStatus,
		
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
		/// Composite Property for <c>GsCodeCurrency</c> at CurrencyIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeCurrency))]
		GsCodeCurrency,
		///<summary>
		/// Collection of <c>FeeRefndStdReq</c> as OneToMany for FeeRefndStdDetCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeRefndStdDet>))]
		FeeRefndStdDetCollection,
	}
	
	#endregion FeeRefndStdReqChildEntityTypes
	
	#region FeeRefndStdReqFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;FeeRefndStdReqColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeRefndStdReq"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeRefndStdReqFilterBuilder : SqlFilterBuilder<FeeRefndStdReqColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeRefndStdReqFilterBuilder class.
		/// </summary>
		public FeeRefndStdReqFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeRefndStdReqFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeRefndStdReqFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeRefndStdReqFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeRefndStdReqFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeRefndStdReqFilterBuilder
	
	#region FeeRefndStdReqParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;FeeRefndStdReqColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeRefndStdReq"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeRefndStdReqParameterBuilder : ParameterizedSqlFilterBuilder<FeeRefndStdReqColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeRefndStdReqParameterBuilder class.
		/// </summary>
		public FeeRefndStdReqParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeRefndStdReqParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeRefndStdReqParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeRefndStdReqParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeRefndStdReqParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeRefndStdReqParameterBuilder
	
	#region FeeRefndStdReqSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;FeeRefndStdReqColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeRefndStdReq"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class FeeRefndStdReqSortBuilder : SqlSortBuilder<FeeRefndStdReqColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeRefndStdReqSqlSortBuilder class.
		/// </summary>
		public FeeRefndStdReqSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion FeeRefndStdReqSortBuilder
	
} // end namespace
