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
	/// This class is the base class for any <see cref="AdmEnglishProficiencyProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AdmEnglishProficiencyProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AdmEnglishProficiency, UMIS_VER2.BusinessLyer.AdmEnglishProficiencyKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmEnglishProficiencyKey key)
		{
			return Delete(transactionManager, key.AdmEnglishProficiencyId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_admEnglishProficiencyId">XXXEnglish Ielts,TOEFL.... Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _admEnglishProficiencyId)
		{
			return Delete(null, _admEnglishProficiencyId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admEnglishProficiencyId">XXXEnglish Ielts,TOEFL.... Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _admEnglishProficiencyId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_ENGLISH_PROFICIENCY_ADM_APP_REG_HISTORY key.
		///		FK_ADM_ENGLISH_PROFICIENCY_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="_admAppRegHistoryId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmEnglishProficiency objects.</returns>
		public TList<AdmEnglishProficiency> GetByAdmAppRegHistoryId(System.Decimal? _admAppRegHistoryId)
		{
			int count = -1;
			return GetByAdmAppRegHistoryId(_admAppRegHistoryId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_ENGLISH_PROFICIENCY_ADM_APP_REG_HISTORY key.
		///		FK_ADM_ENGLISH_PROFICIENCY_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmEnglishProficiency objects.</returns>
		/// <remarks></remarks>
		public TList<AdmEnglishProficiency> GetByAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal? _admAppRegHistoryId)
		{
			int count = -1;
			return GetByAdmAppRegHistoryId(transactionManager, _admAppRegHistoryId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_ENGLISH_PROFICIENCY_ADM_APP_REG_HISTORY key.
		///		FK_ADM_ENGLISH_PROFICIENCY_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmEnglishProficiency objects.</returns>
		public TList<AdmEnglishProficiency> GetByAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal? _admAppRegHistoryId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppRegHistoryId(transactionManager, _admAppRegHistoryId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_ENGLISH_PROFICIENCY_ADM_APP_REG_HISTORY key.
		///		fkAdmEnglishProficiencyAdmAppRegHistory Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmEnglishProficiency objects.</returns>
		public TList<AdmEnglishProficiency> GetByAdmAppRegHistoryId(System.Decimal? _admAppRegHistoryId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmAppRegHistoryId(null, _admAppRegHistoryId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_ENGLISH_PROFICIENCY_ADM_APP_REG_HISTORY key.
		///		fkAdmEnglishProficiencyAdmAppRegHistory Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmEnglishProficiency objects.</returns>
		public TList<AdmEnglishProficiency> GetByAdmAppRegHistoryId(System.Decimal? _admAppRegHistoryId, int start, int pageLength,out int count)
		{
			return GetByAdmAppRegHistoryId(null, _admAppRegHistoryId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_ENGLISH_PROFICIENCY_ADM_APP_REG_HISTORY key.
		///		FK_ADM_ENGLISH_PROFICIENCY_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmEnglishProficiency objects.</returns>
		public abstract TList<AdmEnglishProficiency> GetByAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal? _admAppRegHistoryId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_ENGLISH_PROFICIENCY_ADM_APPLICANT key.
		///		FK_ADM_ENGLISH_PROFICIENCY_ADM_APPLICANT Description: 
		/// </summary>
		/// <param name="_admApplicantId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmEnglishProficiency objects.</returns>
		public TList<AdmEnglishProficiency> GetByAdmApplicantId(System.Decimal? _admApplicantId)
		{
			int count = -1;
			return GetByAdmApplicantId(_admApplicantId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_ENGLISH_PROFICIENCY_ADM_APPLICANT key.
		///		FK_ADM_ENGLISH_PROFICIENCY_ADM_APPLICANT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmEnglishProficiency objects.</returns>
		/// <remarks></remarks>
		public TList<AdmEnglishProficiency> GetByAdmApplicantId(TransactionManager transactionManager, System.Decimal? _admApplicantId)
		{
			int count = -1;
			return GetByAdmApplicantId(transactionManager, _admApplicantId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_ENGLISH_PROFICIENCY_ADM_APPLICANT key.
		///		FK_ADM_ENGLISH_PROFICIENCY_ADM_APPLICANT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmEnglishProficiency objects.</returns>
		public TList<AdmEnglishProficiency> GetByAdmApplicantId(TransactionManager transactionManager, System.Decimal? _admApplicantId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmApplicantId(transactionManager, _admApplicantId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_ENGLISH_PROFICIENCY_ADM_APPLICANT key.
		///		fkAdmEnglishProficiencyAdmApplicant Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admApplicantId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmEnglishProficiency objects.</returns>
		public TList<AdmEnglishProficiency> GetByAdmApplicantId(System.Decimal? _admApplicantId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmApplicantId(null, _admApplicantId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_ENGLISH_PROFICIENCY_ADM_APPLICANT key.
		///		fkAdmEnglishProficiencyAdmApplicant Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmEnglishProficiency objects.</returns>
		public TList<AdmEnglishProficiency> GetByAdmApplicantId(System.Decimal? _admApplicantId, int start, int pageLength,out int count)
		{
			return GetByAdmApplicantId(null, _admApplicantId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_ENGLISH_PROFICIENCY_ADM_APPLICANT key.
		///		FK_ADM_ENGLISH_PROFICIENCY_ADM_APPLICANT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmEnglishProficiency objects.</returns>
		public abstract TList<AdmEnglishProficiency> GetByAdmApplicantId(TransactionManager transactionManager, System.Decimal? _admApplicantId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_ENGLISH_PROFICIENCY_ADM_CODE_ENG_TEST key.
		///		FK_ADM_ENGLISH_PROFICIENCY_ADM_CODE_ENG_TEST Description: 
		/// </summary>
		/// <param name="_admCodeEngTestId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmEnglishProficiency objects.</returns>
		public TList<AdmEnglishProficiency> GetByAdmCodeEngTestId(System.Decimal _admCodeEngTestId)
		{
			int count = -1;
			return GetByAdmCodeEngTestId(_admCodeEngTestId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_ENGLISH_PROFICIENCY_ADM_CODE_ENG_TEST key.
		///		FK_ADM_ENGLISH_PROFICIENCY_ADM_CODE_ENG_TEST Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCodeEngTestId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmEnglishProficiency objects.</returns>
		/// <remarks></remarks>
		public TList<AdmEnglishProficiency> GetByAdmCodeEngTestId(TransactionManager transactionManager, System.Decimal _admCodeEngTestId)
		{
			int count = -1;
			return GetByAdmCodeEngTestId(transactionManager, _admCodeEngTestId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_ENGLISH_PROFICIENCY_ADM_CODE_ENG_TEST key.
		///		FK_ADM_ENGLISH_PROFICIENCY_ADM_CODE_ENG_TEST Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCodeEngTestId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmEnglishProficiency objects.</returns>
		public TList<AdmEnglishProficiency> GetByAdmCodeEngTestId(TransactionManager transactionManager, System.Decimal _admCodeEngTestId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCodeEngTestId(transactionManager, _admCodeEngTestId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_ENGLISH_PROFICIENCY_ADM_CODE_ENG_TEST key.
		///		fkAdmEnglishProficiencyAdmCodeEngTest Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admCodeEngTestId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmEnglishProficiency objects.</returns>
		public TList<AdmEnglishProficiency> GetByAdmCodeEngTestId(System.Decimal _admCodeEngTestId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmCodeEngTestId(null, _admCodeEngTestId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_ENGLISH_PROFICIENCY_ADM_CODE_ENG_TEST key.
		///		fkAdmEnglishProficiencyAdmCodeEngTest Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admCodeEngTestId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmEnglishProficiency objects.</returns>
		public TList<AdmEnglishProficiency> GetByAdmCodeEngTestId(System.Decimal _admCodeEngTestId, int start, int pageLength,out int count)
		{
			return GetByAdmCodeEngTestId(null, _admCodeEngTestId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_ENGLISH_PROFICIENCY_ADM_CODE_ENG_TEST key.
		///		FK_ADM_ENGLISH_PROFICIENCY_ADM_CODE_ENG_TEST Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCodeEngTestId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmEnglishProficiency objects.</returns>
		public abstract TList<AdmEnglishProficiency> GetByAdmCodeEngTestId(TransactionManager transactionManager, System.Decimal _admCodeEngTestId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_ENGLISH_PROFICIENCY_ED_STUD key.
		///		FK_ADM_ENGLISH_PROFICIENCY_ED_STUD Description: 
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmEnglishProficiency objects.</returns>
		public TList<AdmEnglishProficiency> GetByEdStudId(System.Decimal? _edStudId)
		{
			int count = -1;
			return GetByEdStudId(_edStudId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_ENGLISH_PROFICIENCY_ED_STUD key.
		///		FK_ADM_ENGLISH_PROFICIENCY_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmEnglishProficiency objects.</returns>
		/// <remarks></remarks>
		public TList<AdmEnglishProficiency> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_ENGLISH_PROFICIENCY_ED_STUD key.
		///		FK_ADM_ENGLISH_PROFICIENCY_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmEnglishProficiency objects.</returns>
		public TList<AdmEnglishProficiency> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_ENGLISH_PROFICIENCY_ED_STUD key.
		///		fkAdmEnglishProficiencyEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmEnglishProficiency objects.</returns>
		public TList<AdmEnglishProficiency> GetByEdStudId(System.Decimal? _edStudId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudId(null, _edStudId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_ENGLISH_PROFICIENCY_ED_STUD key.
		///		fkAdmEnglishProficiencyEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmEnglishProficiency objects.</returns>
		public TList<AdmEnglishProficiency> GetByEdStudId(System.Decimal? _edStudId, int start, int pageLength,out int count)
		{
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_ENGLISH_PROFICIENCY_ED_STUD key.
		///		FK_ADM_ENGLISH_PROFICIENCY_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmEnglishProficiency objects.</returns>
		public abstract TList<AdmEnglishProficiency> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.AdmEnglishProficiency Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmEnglishProficiencyKey key, int start, int pageLength)
		{
			return GetByAdmEnglishProficiencyId(transactionManager, key.AdmEnglishProficiencyId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ADM_ENGLISH_PROFICIENCY index.
		/// </summary>
		/// <param name="_admEnglishProficiencyId">XXXEnglish Ielts,TOEFL...</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmEnglishProficiency"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmEnglishProficiency GetByAdmEnglishProficiencyId(System.Decimal _admEnglishProficiencyId)
		{
			int count = -1;
			return GetByAdmEnglishProficiencyId(null,_admEnglishProficiencyId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_ENGLISH_PROFICIENCY index.
		/// </summary>
		/// <param name="_admEnglishProficiencyId">XXXEnglish Ielts,TOEFL...</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmEnglishProficiency"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmEnglishProficiency GetByAdmEnglishProficiencyId(System.Decimal _admEnglishProficiencyId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmEnglishProficiencyId(null, _admEnglishProficiencyId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_ENGLISH_PROFICIENCY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admEnglishProficiencyId">XXXEnglish Ielts,TOEFL...</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmEnglishProficiency"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmEnglishProficiency GetByAdmEnglishProficiencyId(TransactionManager transactionManager, System.Decimal _admEnglishProficiencyId)
		{
			int count = -1;
			return GetByAdmEnglishProficiencyId(transactionManager, _admEnglishProficiencyId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_ENGLISH_PROFICIENCY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admEnglishProficiencyId">XXXEnglish Ielts,TOEFL...</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmEnglishProficiency"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmEnglishProficiency GetByAdmEnglishProficiencyId(TransactionManager transactionManager, System.Decimal _admEnglishProficiencyId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmEnglishProficiencyId(transactionManager, _admEnglishProficiencyId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_ENGLISH_PROFICIENCY index.
		/// </summary>
		/// <param name="_admEnglishProficiencyId">XXXEnglish Ielts,TOEFL...</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmEnglishProficiency"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmEnglishProficiency GetByAdmEnglishProficiencyId(System.Decimal _admEnglishProficiencyId, int start, int pageLength, out int count)
		{
			return GetByAdmEnglishProficiencyId(null, _admEnglishProficiencyId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_ENGLISH_PROFICIENCY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admEnglishProficiencyId">XXXEnglish Ielts,TOEFL...</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmEnglishProficiency"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmEnglishProficiency GetByAdmEnglishProficiencyId(TransactionManager transactionManager, System.Decimal _admEnglishProficiencyId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AdmEnglishProficiency&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AdmEnglishProficiency&gt;"/></returns>
		public static TList<AdmEnglishProficiency> Fill(IDataReader reader, TList<AdmEnglishProficiency> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AdmEnglishProficiency c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AdmEnglishProficiency")
					.Append("|").Append((System.Decimal)reader["ADM_ENGLISH_PROFICIENCY_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AdmEnglishProficiency>(
					key.ToString(), // EntityTrackingKey
					"AdmEnglishProficiency",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AdmEnglishProficiency();
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
					c.AdmEnglishProficiencyId = (System.Decimal)reader["ADM_ENGLISH_PROFICIENCY_ID"];
					c.OriginalAdmEnglishProficiencyId = c.AdmEnglishProficiencyId;
					c.AdmCodeEngTestId = (System.Decimal)reader["ADM_CODE_ENG_TEST_ID"];
					c.Score = (System.Decimal)reader["SCORE"];
					c.AdmApplicantId = Convert.IsDBNull(reader["ADM_APPLICANT_ID"]) ? null : (System.Decimal?)reader["ADM_APPLICANT_ID"];
					c.EdStudId = Convert.IsDBNull(reader["ED_STUD_ID"]) ? null : (System.Decimal?)reader["ED_STUD_ID"];
					c.TestDate = Convert.IsDBNull(reader["TEST_DATE"]) ? null : (System.DateTime?)reader["TEST_DATE"];
					c.AdmAppRegHistoryId = Convert.IsDBNull(reader["ADM_APP_REG_HISTORY_ID"]) ? null : (System.Decimal?)reader["ADM_APP_REG_HISTORY_ID"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
					c.AttchCertPath = Convert.IsDBNull(reader["ATTCH_CERT_PATH"]) ? null : (System.String)reader["ATTCH_CERT_PATH"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmEnglishProficiency"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmEnglishProficiency"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AdmEnglishProficiency entity)
		{
			if (!reader.Read()) return;
			
			entity.AdmEnglishProficiencyId = (System.Decimal)reader[((int)AdmEnglishProficiencyColumn.AdmEnglishProficiencyId - 1)];
			entity.OriginalAdmEnglishProficiencyId = (System.Decimal)reader["ADM_ENGLISH_PROFICIENCY_ID"];
			entity.AdmCodeEngTestId = (System.Decimal)reader[((int)AdmEnglishProficiencyColumn.AdmCodeEngTestId - 1)];
			entity.Score = (System.Decimal)reader[((int)AdmEnglishProficiencyColumn.Score - 1)];
			entity.AdmApplicantId = (reader.IsDBNull(((int)AdmEnglishProficiencyColumn.AdmApplicantId - 1)))?null:(System.Decimal?)reader[((int)AdmEnglishProficiencyColumn.AdmApplicantId - 1)];
			entity.EdStudId = (reader.IsDBNull(((int)AdmEnglishProficiencyColumn.EdStudId - 1)))?null:(System.Decimal?)reader[((int)AdmEnglishProficiencyColumn.EdStudId - 1)];
			entity.TestDate = (reader.IsDBNull(((int)AdmEnglishProficiencyColumn.TestDate - 1)))?null:(System.DateTime?)reader[((int)AdmEnglishProficiencyColumn.TestDate - 1)];
			entity.AdmAppRegHistoryId = (reader.IsDBNull(((int)AdmEnglishProficiencyColumn.AdmAppRegHistoryId - 1)))?null:(System.Decimal?)reader[((int)AdmEnglishProficiencyColumn.AdmAppRegHistoryId - 1)];
			entity.Notes = (reader.IsDBNull(((int)AdmEnglishProficiencyColumn.Notes - 1)))?null:(System.String)reader[((int)AdmEnglishProficiencyColumn.Notes - 1)];
			entity.AttchCertPath = (reader.IsDBNull(((int)AdmEnglishProficiencyColumn.AttchCertPath - 1)))?null:(System.String)reader[((int)AdmEnglishProficiencyColumn.AttchCertPath - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)AdmEnglishProficiencyColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)AdmEnglishProficiencyColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)AdmEnglishProficiencyColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)AdmEnglishProficiencyColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmEnglishProficiency"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmEnglishProficiency"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AdmEnglishProficiency entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AdmEnglishProficiencyId = (System.Decimal)dataRow["ADM_ENGLISH_PROFICIENCY_ID"];
			entity.OriginalAdmEnglishProficiencyId = (System.Decimal)dataRow["ADM_ENGLISH_PROFICIENCY_ID"];
			entity.AdmCodeEngTestId = (System.Decimal)dataRow["ADM_CODE_ENG_TEST_ID"];
			entity.Score = (System.Decimal)dataRow["SCORE"];
			entity.AdmApplicantId = Convert.IsDBNull(dataRow["ADM_APPLICANT_ID"]) ? null : (System.Decimal?)dataRow["ADM_APPLICANT_ID"];
			entity.EdStudId = Convert.IsDBNull(dataRow["ED_STUD_ID"]) ? null : (System.Decimal?)dataRow["ED_STUD_ID"];
			entity.TestDate = Convert.IsDBNull(dataRow["TEST_DATE"]) ? null : (System.DateTime?)dataRow["TEST_DATE"];
			entity.AdmAppRegHistoryId = Convert.IsDBNull(dataRow["ADM_APP_REG_HISTORY_ID"]) ? null : (System.Decimal?)dataRow["ADM_APP_REG_HISTORY_ID"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
			entity.AttchCertPath = Convert.IsDBNull(dataRow["ATTCH_CERT_PATH"]) ? null : (System.String)dataRow["ATTCH_CERT_PATH"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmEnglishProficiency"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmEnglishProficiency Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmEnglishProficiency entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AdmAppRegHistoryIdSource	
			if (CanDeepLoad(entity, "AdmAppRegHistory|AdmAppRegHistoryIdSource", deepLoadType, innerList) 
				&& entity.AdmAppRegHistoryIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AdmAppRegHistoryId ?? 0.0m);
				AdmAppRegHistory tmpEntity = EntityManager.LocateEntity<AdmAppRegHistory>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmAppRegHistory), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmAppRegHistoryIdSource = tmpEntity;
				else
					entity.AdmAppRegHistoryIdSource = DataRepository.AdmAppRegHistoryProvider.GetByAdmAppRegHistoryId(transactionManager, (entity.AdmAppRegHistoryId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppRegHistoryIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmAppRegHistoryIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmAppRegHistoryProvider.DeepLoad(transactionManager, entity.AdmAppRegHistoryIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmAppRegHistoryIdSource

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

			#region AdmCodeEngTestIdSource	
			if (CanDeepLoad(entity, "AdmCodeEngTest|AdmCodeEngTestIdSource", deepLoadType, innerList) 
				&& entity.AdmCodeEngTestIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AdmCodeEngTestId;
				AdmCodeEngTest tmpEntity = EntityManager.LocateEntity<AdmCodeEngTest>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmCodeEngTest), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmCodeEngTestIdSource = tmpEntity;
				else
					entity.AdmCodeEngTestIdSource = DataRepository.AdmCodeEngTestProvider.GetByAdmCodeEngTestId(transactionManager, entity.AdmCodeEngTestId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmCodeEngTestIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmCodeEngTestIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmCodeEngTestProvider.DeepLoad(transactionManager, entity.AdmCodeEngTestIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmCodeEngTestIdSource

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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AdmEnglishProficiency object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AdmEnglishProficiency instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmEnglishProficiency Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmEnglishProficiency entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AdmAppRegHistoryIdSource
			if (CanDeepSave(entity, "AdmAppRegHistory|AdmAppRegHistoryIdSource", deepSaveType, innerList) 
				&& entity.AdmAppRegHistoryIdSource != null)
			{
				DataRepository.AdmAppRegHistoryProvider.Save(transactionManager, entity.AdmAppRegHistoryIdSource);
				entity.AdmAppRegHistoryId = entity.AdmAppRegHistoryIdSource.AdmAppRegHistoryId;
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
			
			#region AdmCodeEngTestIdSource
			if (CanDeepSave(entity, "AdmCodeEngTest|AdmCodeEngTestIdSource", deepSaveType, innerList) 
				&& entity.AdmCodeEngTestIdSource != null)
			{
				DataRepository.AdmCodeEngTestProvider.Save(transactionManager, entity.AdmCodeEngTestIdSource);
				entity.AdmCodeEngTestId = entity.AdmCodeEngTestIdSource.AdmCodeEngTestId;
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
	
	#region AdmEnglishProficiencyChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AdmEnglishProficiency</c>
	///</summary>
	public enum AdmEnglishProficiencyChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AdmAppRegHistory</c> at AdmAppRegHistoryIdSource
		///</summary>
		[ChildEntityType(typeof(AdmAppRegHistory))]
		AdmAppRegHistory,
		
		///<summary>
		/// Composite Property for <c>AdmApplicant</c> at AdmApplicantIdSource
		///</summary>
		[ChildEntityType(typeof(AdmApplicant))]
		AdmApplicant,
		
		///<summary>
		/// Composite Property for <c>AdmCodeEngTest</c> at AdmCodeEngTestIdSource
		///</summary>
		[ChildEntityType(typeof(AdmCodeEngTest))]
		AdmCodeEngTest,
		
		///<summary>
		/// Composite Property for <c>EdStud</c> at EdStudIdSource
		///</summary>
		[ChildEntityType(typeof(EdStud))]
		EdStud,
	}
	
	#endregion AdmEnglishProficiencyChildEntityTypes
	
	#region AdmEnglishProficiencyFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AdmEnglishProficiencyColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmEnglishProficiency"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmEnglishProficiencyFilterBuilder : SqlFilterBuilder<AdmEnglishProficiencyColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmEnglishProficiencyFilterBuilder class.
		/// </summary>
		public AdmEnglishProficiencyFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmEnglishProficiencyFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmEnglishProficiencyFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmEnglishProficiencyFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmEnglishProficiencyFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmEnglishProficiencyFilterBuilder
	
	#region AdmEnglishProficiencyParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AdmEnglishProficiencyColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmEnglishProficiency"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmEnglishProficiencyParameterBuilder : ParameterizedSqlFilterBuilder<AdmEnglishProficiencyColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmEnglishProficiencyParameterBuilder class.
		/// </summary>
		public AdmEnglishProficiencyParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmEnglishProficiencyParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmEnglishProficiencyParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmEnglishProficiencyParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmEnglishProficiencyParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmEnglishProficiencyParameterBuilder
	
	#region AdmEnglishProficiencySortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AdmEnglishProficiencyColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmEnglishProficiency"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AdmEnglishProficiencySortBuilder : SqlSortBuilder<AdmEnglishProficiencyColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmEnglishProficiencySqlSortBuilder class.
		/// </summary>
		public AdmEnglishProficiencySortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AdmEnglishProficiencySortBuilder
	
} // end namespace
