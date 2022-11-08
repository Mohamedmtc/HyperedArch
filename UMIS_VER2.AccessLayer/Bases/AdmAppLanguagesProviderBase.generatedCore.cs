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
	/// This class is the base class for any <see cref="AdmAppLanguagesProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AdmAppLanguagesProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AdmAppLanguages, UMIS_VER2.BusinessLyer.AdmAppLanguagesKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppLanguagesKey key)
		{
			return Delete(transactionManager, key.AdmAppLanguagesId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_admAppLanguagesId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _admAppLanguagesId)
		{
			return Delete(null, _admAppLanguagesId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppLanguagesId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _admAppLanguagesId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_LANGUAGES_ADM_APP_REG_HISTORY key.
		///		FK_ADM_APP_LANGUAGES_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="_admAppRegHistoryId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppLanguages objects.</returns>
		public TList<AdmAppLanguages> GetByAdmAppRegHistoryId(System.Decimal? _admAppRegHistoryId)
		{
			int count = -1;
			return GetByAdmAppRegHistoryId(_admAppRegHistoryId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_LANGUAGES_ADM_APP_REG_HISTORY key.
		///		FK_ADM_APP_LANGUAGES_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppLanguages objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAppLanguages> GetByAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal? _admAppRegHistoryId)
		{
			int count = -1;
			return GetByAdmAppRegHistoryId(transactionManager, _admAppRegHistoryId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_LANGUAGES_ADM_APP_REG_HISTORY key.
		///		FK_ADM_APP_LANGUAGES_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppLanguages objects.</returns>
		public TList<AdmAppLanguages> GetByAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal? _admAppRegHistoryId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppRegHistoryId(transactionManager, _admAppRegHistoryId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_LANGUAGES_ADM_APP_REG_HISTORY key.
		///		fkAdmAppLanguagesAdmAppRegHistory Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppLanguages objects.</returns>
		public TList<AdmAppLanguages> GetByAdmAppRegHistoryId(System.Decimal? _admAppRegHistoryId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmAppRegHistoryId(null, _admAppRegHistoryId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_LANGUAGES_ADM_APP_REG_HISTORY key.
		///		fkAdmAppLanguagesAdmAppRegHistory Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppLanguages objects.</returns>
		public TList<AdmAppLanguages> GetByAdmAppRegHistoryId(System.Decimal? _admAppRegHistoryId, int start, int pageLength,out int count)
		{
			return GetByAdmAppRegHistoryId(null, _admAppRegHistoryId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_LANGUAGES_ADM_APP_REG_HISTORY key.
		///		FK_ADM_APP_LANGUAGES_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppLanguages objects.</returns>
		public abstract TList<AdmAppLanguages> GetByAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal? _admAppRegHistoryId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_LANGUAGES_ADM_APPLICANT key.
		///		FK_ADM_APP_LANGUAGES_ADM_APPLICANT Description: 
		/// </summary>
		/// <param name="_admApplicantId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppLanguages objects.</returns>
		public TList<AdmAppLanguages> GetByAdmApplicantId(System.Decimal? _admApplicantId)
		{
			int count = -1;
			return GetByAdmApplicantId(_admApplicantId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_LANGUAGES_ADM_APPLICANT key.
		///		FK_ADM_APP_LANGUAGES_ADM_APPLICANT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppLanguages objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAppLanguages> GetByAdmApplicantId(TransactionManager transactionManager, System.Decimal? _admApplicantId)
		{
			int count = -1;
			return GetByAdmApplicantId(transactionManager, _admApplicantId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_LANGUAGES_ADM_APPLICANT key.
		///		FK_ADM_APP_LANGUAGES_ADM_APPLICANT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppLanguages objects.</returns>
		public TList<AdmAppLanguages> GetByAdmApplicantId(TransactionManager transactionManager, System.Decimal? _admApplicantId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmApplicantId(transactionManager, _admApplicantId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_LANGUAGES_ADM_APPLICANT key.
		///		fkAdmAppLanguagesAdmApplicant Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admApplicantId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppLanguages objects.</returns>
		public TList<AdmAppLanguages> GetByAdmApplicantId(System.Decimal? _admApplicantId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmApplicantId(null, _admApplicantId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_LANGUAGES_ADM_APPLICANT key.
		///		fkAdmAppLanguagesAdmApplicant Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppLanguages objects.</returns>
		public TList<AdmAppLanguages> GetByAdmApplicantId(System.Decimal? _admApplicantId, int start, int pageLength,out int count)
		{
			return GetByAdmApplicantId(null, _admApplicantId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_LANGUAGES_ADM_APPLICANT key.
		///		FK_ADM_APP_LANGUAGES_ADM_APPLICANT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppLanguages objects.</returns>
		public abstract TList<AdmAppLanguages> GetByAdmApplicantId(TransactionManager transactionManager, System.Decimal? _admApplicantId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_LANGUAGES_ED_STUD key.
		///		FK_ADM_APP_LANGUAGES_ED_STUD Description: 
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppLanguages objects.</returns>
		public TList<AdmAppLanguages> GetByEdStudId(System.Decimal? _edStudId)
		{
			int count = -1;
			return GetByEdStudId(_edStudId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_LANGUAGES_ED_STUD key.
		///		FK_ADM_APP_LANGUAGES_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppLanguages objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAppLanguages> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_LANGUAGES_ED_STUD key.
		///		FK_ADM_APP_LANGUAGES_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppLanguages objects.</returns>
		public TList<AdmAppLanguages> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_LANGUAGES_ED_STUD key.
		///		fkAdmAppLanguagesEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppLanguages objects.</returns>
		public TList<AdmAppLanguages> GetByEdStudId(System.Decimal? _edStudId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudId(null, _edStudId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_LANGUAGES_ED_STUD key.
		///		fkAdmAppLanguagesEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppLanguages objects.</returns>
		public TList<AdmAppLanguages> GetByEdStudId(System.Decimal? _edStudId, int start, int pageLength,out int count)
		{
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_LANGUAGES_ED_STUD key.
		///		FK_ADM_APP_LANGUAGES_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppLanguages objects.</returns>
		public abstract TList<AdmAppLanguages> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_LANGUAGES_GS_CODE_LANGUAGE key.
		///		FK_ADM_APP_LANGUAGES_GS_CODE_LANGUAGE Description: 
		/// </summary>
		/// <param name="_gsCodeLanguageId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppLanguages objects.</returns>
		public TList<AdmAppLanguages> GetByGsCodeLanguageId(System.Decimal _gsCodeLanguageId)
		{
			int count = -1;
			return GetByGsCodeLanguageId(_gsCodeLanguageId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_LANGUAGES_GS_CODE_LANGUAGE key.
		///		FK_ADM_APP_LANGUAGES_GS_CODE_LANGUAGE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeLanguageId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppLanguages objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAppLanguages> GetByGsCodeLanguageId(TransactionManager transactionManager, System.Decimal _gsCodeLanguageId)
		{
			int count = -1;
			return GetByGsCodeLanguageId(transactionManager, _gsCodeLanguageId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_LANGUAGES_GS_CODE_LANGUAGE key.
		///		FK_ADM_APP_LANGUAGES_GS_CODE_LANGUAGE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeLanguageId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppLanguages objects.</returns>
		public TList<AdmAppLanguages> GetByGsCodeLanguageId(TransactionManager transactionManager, System.Decimal _gsCodeLanguageId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeLanguageId(transactionManager, _gsCodeLanguageId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_LANGUAGES_GS_CODE_LANGUAGE key.
		///		fkAdmAppLanguagesGsCodeLanguage Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeLanguageId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppLanguages objects.</returns>
		public TList<AdmAppLanguages> GetByGsCodeLanguageId(System.Decimal _gsCodeLanguageId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodeLanguageId(null, _gsCodeLanguageId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_LANGUAGES_GS_CODE_LANGUAGE key.
		///		fkAdmAppLanguagesGsCodeLanguage Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeLanguageId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppLanguages objects.</returns>
		public TList<AdmAppLanguages> GetByGsCodeLanguageId(System.Decimal _gsCodeLanguageId, int start, int pageLength,out int count)
		{
			return GetByGsCodeLanguageId(null, _gsCodeLanguageId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_LANGUAGES_GS_CODE_LANGUAGE key.
		///		FK_ADM_APP_LANGUAGES_GS_CODE_LANGUAGE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeLanguageId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppLanguages objects.</returns>
		public abstract TList<AdmAppLanguages> GetByGsCodeLanguageId(TransactionManager transactionManager, System.Decimal _gsCodeLanguageId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.AdmAppLanguages Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppLanguagesKey key, int start, int pageLength)
		{
			return GetByAdmAppLanguagesId(transactionManager, key.AdmAppLanguagesId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ADM_APP_LANGUAGES index.
		/// </summary>
		/// <param name="_admAppLanguagesId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppLanguages"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppLanguages GetByAdmAppLanguagesId(System.Decimal _admAppLanguagesId)
		{
			int count = -1;
			return GetByAdmAppLanguagesId(null,_admAppLanguagesId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_LANGUAGES index.
		/// </summary>
		/// <param name="_admAppLanguagesId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppLanguages"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppLanguages GetByAdmAppLanguagesId(System.Decimal _admAppLanguagesId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppLanguagesId(null, _admAppLanguagesId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_LANGUAGES index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppLanguagesId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppLanguages"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppLanguages GetByAdmAppLanguagesId(TransactionManager transactionManager, System.Decimal _admAppLanguagesId)
		{
			int count = -1;
			return GetByAdmAppLanguagesId(transactionManager, _admAppLanguagesId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_LANGUAGES index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppLanguagesId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppLanguages"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppLanguages GetByAdmAppLanguagesId(TransactionManager transactionManager, System.Decimal _admAppLanguagesId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppLanguagesId(transactionManager, _admAppLanguagesId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_LANGUAGES index.
		/// </summary>
		/// <param name="_admAppLanguagesId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppLanguages"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppLanguages GetByAdmAppLanguagesId(System.Decimal _admAppLanguagesId, int start, int pageLength, out int count)
		{
			return GetByAdmAppLanguagesId(null, _admAppLanguagesId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_LANGUAGES index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppLanguagesId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppLanguages"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmAppLanguages GetByAdmAppLanguagesId(TransactionManager transactionManager, System.Decimal _admAppLanguagesId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AdmAppLanguages&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AdmAppLanguages&gt;"/></returns>
		public static TList<AdmAppLanguages> Fill(IDataReader reader, TList<AdmAppLanguages> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AdmAppLanguages c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AdmAppLanguages")
					.Append("|").Append((System.Decimal)reader["ADM_APP_LANGUAGES_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AdmAppLanguages>(
					key.ToString(), // EntityTrackingKey
					"AdmAppLanguages",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AdmAppLanguages();
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
					c.AdmAppLanguagesId = (System.Decimal)reader["ADM_APP_LANGUAGES_ID"];
					c.OriginalAdmAppLanguagesId = c.AdmAppLanguagesId;
					c.GsCodeLanguageId = (System.Decimal)reader["GS_CODE_LANGUAGE_ID"];
					c.AdmApplicantId = Convert.IsDBNull(reader["ADM_APPLICANT_ID"]) ? null : (System.Decimal?)reader["ADM_APPLICANT_ID"];
					c.EdStudId = Convert.IsDBNull(reader["ED_STUD_ID"]) ? null : (System.Decimal?)reader["ED_STUD_ID"];
					c.MainLangFlg = Convert.IsDBNull(reader["MAIN_LANG_FLG"]) ? null : (System.Decimal?)reader["MAIN_LANG_FLG"];
					c.AdmAppRegHistoryId = Convert.IsDBNull(reader["ADM_APP_REG_HISTORY_ID"]) ? null : (System.Decimal?)reader["ADM_APP_REG_HISTORY_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmAppLanguages"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAppLanguages"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AdmAppLanguages entity)
		{
			if (!reader.Read()) return;
			
			entity.AdmAppLanguagesId = (System.Decimal)reader[((int)AdmAppLanguagesColumn.AdmAppLanguagesId - 1)];
			entity.OriginalAdmAppLanguagesId = (System.Decimal)reader["ADM_APP_LANGUAGES_ID"];
			entity.GsCodeLanguageId = (System.Decimal)reader[((int)AdmAppLanguagesColumn.GsCodeLanguageId - 1)];
			entity.AdmApplicantId = (reader.IsDBNull(((int)AdmAppLanguagesColumn.AdmApplicantId - 1)))?null:(System.Decimal?)reader[((int)AdmAppLanguagesColumn.AdmApplicantId - 1)];
			entity.EdStudId = (reader.IsDBNull(((int)AdmAppLanguagesColumn.EdStudId - 1)))?null:(System.Decimal?)reader[((int)AdmAppLanguagesColumn.EdStudId - 1)];
			entity.MainLangFlg = (reader.IsDBNull(((int)AdmAppLanguagesColumn.MainLangFlg - 1)))?null:(System.Decimal?)reader[((int)AdmAppLanguagesColumn.MainLangFlg - 1)];
			entity.AdmAppRegHistoryId = (reader.IsDBNull(((int)AdmAppLanguagesColumn.AdmAppRegHistoryId - 1)))?null:(System.Decimal?)reader[((int)AdmAppLanguagesColumn.AdmAppRegHistoryId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmAppLanguages"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAppLanguages"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AdmAppLanguages entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AdmAppLanguagesId = (System.Decimal)dataRow["ADM_APP_LANGUAGES_ID"];
			entity.OriginalAdmAppLanguagesId = (System.Decimal)dataRow["ADM_APP_LANGUAGES_ID"];
			entity.GsCodeLanguageId = (System.Decimal)dataRow["GS_CODE_LANGUAGE_ID"];
			entity.AdmApplicantId = Convert.IsDBNull(dataRow["ADM_APPLICANT_ID"]) ? null : (System.Decimal?)dataRow["ADM_APPLICANT_ID"];
			entity.EdStudId = Convert.IsDBNull(dataRow["ED_STUD_ID"]) ? null : (System.Decimal?)dataRow["ED_STUD_ID"];
			entity.MainLangFlg = Convert.IsDBNull(dataRow["MAIN_LANG_FLG"]) ? null : (System.Decimal?)dataRow["MAIN_LANG_FLG"];
			entity.AdmAppRegHistoryId = Convert.IsDBNull(dataRow["ADM_APP_REG_HISTORY_ID"]) ? null : (System.Decimal?)dataRow["ADM_APP_REG_HISTORY_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAppLanguages"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmAppLanguages Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppLanguages entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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

			#region GsCodeLanguageIdSource	
			if (CanDeepLoad(entity, "GsCodeLanguage|GsCodeLanguageIdSource", deepLoadType, innerList) 
				&& entity.GsCodeLanguageIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.GsCodeLanguageId;
				GsCodeLanguage tmpEntity = EntityManager.LocateEntity<GsCodeLanguage>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodeLanguage), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodeLanguageIdSource = tmpEntity;
				else
					entity.GsCodeLanguageIdSource = DataRepository.GsCodeLanguageProvider.GetByGsCodeLanguageId(transactionManager, entity.GsCodeLanguageId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodeLanguageIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCodeLanguageIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodeLanguageProvider.DeepLoad(transactionManager, entity.GsCodeLanguageIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCodeLanguageIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByAdmAppLanguagesId methods when available
			
			#region AdmAppLanguagesDtlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppLanguagesDtl>|AdmAppLanguagesDtlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppLanguagesDtlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppLanguagesDtlCollection = DataRepository.AdmAppLanguagesDtlProvider.GetByAdmAppLanguagesId(transactionManager, entity.AdmAppLanguagesId);

				if (deep && entity.AdmAppLanguagesDtlCollection.Count > 0)
				{
					deepHandles.Add("AdmAppLanguagesDtlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppLanguagesDtl>) DataRepository.AdmAppLanguagesDtlProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppLanguagesDtlCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AdmAppLanguages object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AdmAppLanguages instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmAppLanguages Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppLanguages entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region EdStudIdSource
			if (CanDeepSave(entity, "EdStud|EdStudIdSource", deepSaveType, innerList) 
				&& entity.EdStudIdSource != null)
			{
				DataRepository.EdStudProvider.Save(transactionManager, entity.EdStudIdSource);
				entity.EdStudId = entity.EdStudIdSource.EdStudId;
			}
			#endregion 
			
			#region GsCodeLanguageIdSource
			if (CanDeepSave(entity, "GsCodeLanguage|GsCodeLanguageIdSource", deepSaveType, innerList) 
				&& entity.GsCodeLanguageIdSource != null)
			{
				DataRepository.GsCodeLanguageProvider.Save(transactionManager, entity.GsCodeLanguageIdSource);
				entity.GsCodeLanguageId = entity.GsCodeLanguageIdSource.GsCodeLanguageId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<AdmAppLanguagesDtl>
				if (CanDeepSave(entity.AdmAppLanguagesDtlCollection, "List<AdmAppLanguagesDtl>|AdmAppLanguagesDtlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppLanguagesDtl child in entity.AdmAppLanguagesDtlCollection)
					{
						if(child.AdmAppLanguagesIdSource != null)
						{
							child.AdmAppLanguagesId = child.AdmAppLanguagesIdSource.AdmAppLanguagesId;
						}
						else
						{
							child.AdmAppLanguagesId = entity.AdmAppLanguagesId;
						}

					}

					if (entity.AdmAppLanguagesDtlCollection.Count > 0 || entity.AdmAppLanguagesDtlCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppLanguagesDtlProvider.Save(transactionManager, entity.AdmAppLanguagesDtlCollection);
						
						deepHandles.Add("AdmAppLanguagesDtlCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppLanguagesDtl >) DataRepository.AdmAppLanguagesDtlProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppLanguagesDtlCollection, deepSaveType, childTypes, innerList }
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
	
	#region AdmAppLanguagesChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AdmAppLanguages</c>
	///</summary>
	public enum AdmAppLanguagesChildEntityTypes
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
		/// Composite Property for <c>EdStud</c> at EdStudIdSource
		///</summary>
		[ChildEntityType(typeof(EdStud))]
		EdStud,
		
		///<summary>
		/// Composite Property for <c>GsCodeLanguage</c> at GsCodeLanguageIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeLanguage))]
		GsCodeLanguage,
		///<summary>
		/// Collection of <c>AdmAppLanguages</c> as OneToMany for AdmAppLanguagesDtlCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppLanguagesDtl>))]
		AdmAppLanguagesDtlCollection,
	}
	
	#endregion AdmAppLanguagesChildEntityTypes
	
	#region AdmAppLanguagesFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AdmAppLanguagesColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAppLanguages"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmAppLanguagesFilterBuilder : SqlFilterBuilder<AdmAppLanguagesColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAppLanguagesFilterBuilder class.
		/// </summary>
		public AdmAppLanguagesFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmAppLanguagesFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmAppLanguagesFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmAppLanguagesFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmAppLanguagesFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmAppLanguagesFilterBuilder
	
	#region AdmAppLanguagesParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AdmAppLanguagesColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAppLanguages"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmAppLanguagesParameterBuilder : ParameterizedSqlFilterBuilder<AdmAppLanguagesColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAppLanguagesParameterBuilder class.
		/// </summary>
		public AdmAppLanguagesParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmAppLanguagesParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmAppLanguagesParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmAppLanguagesParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmAppLanguagesParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmAppLanguagesParameterBuilder
	
	#region AdmAppLanguagesSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AdmAppLanguagesColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAppLanguages"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AdmAppLanguagesSortBuilder : SqlSortBuilder<AdmAppLanguagesColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAppLanguagesSqlSortBuilder class.
		/// </summary>
		public AdmAppLanguagesSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AdmAppLanguagesSortBuilder
	
} // end namespace
