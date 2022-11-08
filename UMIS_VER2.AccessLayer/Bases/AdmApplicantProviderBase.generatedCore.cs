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
	/// This class is the base class for any <see cref="AdmApplicantProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AdmApplicantProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AdmApplicant, UMIS_VER2.BusinessLyer.AdmApplicantKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmApplicantKey key)
		{
			return Delete(transactionManager, key.AdmApplicantId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_admApplicantId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _admApplicantId)
		{
			return Delete(null, _admApplicantId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _admApplicantId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APPLICANT_ED_CDE_SOCIAL_AFFAIR key.
		///		FK_ADM_APPLICANT_ED_CDE_SOCIAL_AFFAIR Description: 
		/// </summary>
		/// <param name="_edCdeSocialAffairId">نوع الشؤن الاجتماعية CSS</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmApplicant objects.</returns>
		public TList<AdmApplicant> GetByEdCdeSocialAffairId(System.Int32? _edCdeSocialAffairId)
		{
			int count = -1;
			return GetByEdCdeSocialAffairId(_edCdeSocialAffairId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APPLICANT_ED_CDE_SOCIAL_AFFAIR key.
		///		FK_ADM_APPLICANT_ED_CDE_SOCIAL_AFFAIR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeSocialAffairId">نوع الشؤن الاجتماعية CSS</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmApplicant objects.</returns>
		/// <remarks></remarks>
		public TList<AdmApplicant> GetByEdCdeSocialAffairId(TransactionManager transactionManager, System.Int32? _edCdeSocialAffairId)
		{
			int count = -1;
			return GetByEdCdeSocialAffairId(transactionManager, _edCdeSocialAffairId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APPLICANT_ED_CDE_SOCIAL_AFFAIR key.
		///		FK_ADM_APPLICANT_ED_CDE_SOCIAL_AFFAIR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeSocialAffairId">نوع الشؤن الاجتماعية CSS</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmApplicant objects.</returns>
		public TList<AdmApplicant> GetByEdCdeSocialAffairId(TransactionManager transactionManager, System.Int32? _edCdeSocialAffairId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCdeSocialAffairId(transactionManager, _edCdeSocialAffairId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APPLICANT_ED_CDE_SOCIAL_AFFAIR key.
		///		fkAdmApplicantEdCdeSocialAffair Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCdeSocialAffairId">نوع الشؤن الاجتماعية CSS</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmApplicant objects.</returns>
		public TList<AdmApplicant> GetByEdCdeSocialAffairId(System.Int32? _edCdeSocialAffairId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCdeSocialAffairId(null, _edCdeSocialAffairId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APPLICANT_ED_CDE_SOCIAL_AFFAIR key.
		///		fkAdmApplicantEdCdeSocialAffair Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCdeSocialAffairId">نوع الشؤن الاجتماعية CSS</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmApplicant objects.</returns>
		public TList<AdmApplicant> GetByEdCdeSocialAffairId(System.Int32? _edCdeSocialAffairId, int start, int pageLength,out int count)
		{
			return GetByEdCdeSocialAffairId(null, _edCdeSocialAffairId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APPLICANT_ED_CDE_SOCIAL_AFFAIR key.
		///		FK_ADM_APPLICANT_ED_CDE_SOCIAL_AFFAIR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeSocialAffairId">نوع الشؤن الاجتماعية CSS</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmApplicant objects.</returns>
		public abstract TList<AdmApplicant> GetByEdCdeSocialAffairId(TransactionManager transactionManager, System.Int32? _edCdeSocialAffairId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APPLICANT_GS_CODE_LANGUAGE key.
		///		FK_ADM_APPLICANT_GS_CODE_LANGUAGE Description: 
		/// </summary>
		/// <param name="_gsCodeLanguageId">لغة التخصص</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmApplicant objects.</returns>
		public TList<AdmApplicant> GetByGsCodeLanguageId(System.Decimal? _gsCodeLanguageId)
		{
			int count = -1;
			return GetByGsCodeLanguageId(_gsCodeLanguageId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APPLICANT_GS_CODE_LANGUAGE key.
		///		FK_ADM_APPLICANT_GS_CODE_LANGUAGE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeLanguageId">لغة التخصص</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmApplicant objects.</returns>
		/// <remarks></remarks>
		public TList<AdmApplicant> GetByGsCodeLanguageId(TransactionManager transactionManager, System.Decimal? _gsCodeLanguageId)
		{
			int count = -1;
			return GetByGsCodeLanguageId(transactionManager, _gsCodeLanguageId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APPLICANT_GS_CODE_LANGUAGE key.
		///		FK_ADM_APPLICANT_GS_CODE_LANGUAGE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeLanguageId">لغة التخصص</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmApplicant objects.</returns>
		public TList<AdmApplicant> GetByGsCodeLanguageId(TransactionManager transactionManager, System.Decimal? _gsCodeLanguageId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeLanguageId(transactionManager, _gsCodeLanguageId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APPLICANT_GS_CODE_LANGUAGE key.
		///		fkAdmApplicantGsCodeLanguage Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeLanguageId">لغة التخصص</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmApplicant objects.</returns>
		public TList<AdmApplicant> GetByGsCodeLanguageId(System.Decimal? _gsCodeLanguageId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodeLanguageId(null, _gsCodeLanguageId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APPLICANT_GS_CODE_LANGUAGE key.
		///		fkAdmApplicantGsCodeLanguage Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeLanguageId">لغة التخصص</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmApplicant objects.</returns>
		public TList<AdmApplicant> GetByGsCodeLanguageId(System.Decimal? _gsCodeLanguageId, int start, int pageLength,out int count)
		{
			return GetByGsCodeLanguageId(null, _gsCodeLanguageId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APPLICANT_GS_CODE_LANGUAGE key.
		///		FK_ADM_APPLICANT_GS_CODE_LANGUAGE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeLanguageId">لغة التخصص</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmApplicant objects.</returns>
		public abstract TList<AdmApplicant> GetByGsCodeLanguageId(TransactionManager transactionManager, System.Decimal? _gsCodeLanguageId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APPLICANT_GS_COUNTRY_NODE key.
		///		FK_ADM_APPLICANT_GS_COUNTRY_NODE Description: 
		/// </summary>
		/// <param name="_gsCountryNodeId">الجنسية</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmApplicant objects.</returns>
		public TList<AdmApplicant> GetByGsCountryNodeId(System.Decimal? _gsCountryNodeId)
		{
			int count = -1;
			return GetByGsCountryNodeId(_gsCountryNodeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APPLICANT_GS_COUNTRY_NODE key.
		///		FK_ADM_APPLICANT_GS_COUNTRY_NODE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryNodeId">الجنسية</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmApplicant objects.</returns>
		/// <remarks></remarks>
		public TList<AdmApplicant> GetByGsCountryNodeId(TransactionManager transactionManager, System.Decimal? _gsCountryNodeId)
		{
			int count = -1;
			return GetByGsCountryNodeId(transactionManager, _gsCountryNodeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APPLICANT_GS_COUNTRY_NODE key.
		///		FK_ADM_APPLICANT_GS_COUNTRY_NODE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryNodeId">الجنسية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmApplicant objects.</returns>
		public TList<AdmApplicant> GetByGsCountryNodeId(TransactionManager transactionManager, System.Decimal? _gsCountryNodeId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCountryNodeId(transactionManager, _gsCountryNodeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APPLICANT_GS_COUNTRY_NODE key.
		///		fkAdmApplicantGsCountryNode Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCountryNodeId">الجنسية</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmApplicant objects.</returns>
		public TList<AdmApplicant> GetByGsCountryNodeId(System.Decimal? _gsCountryNodeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCountryNodeId(null, _gsCountryNodeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APPLICANT_GS_COUNTRY_NODE key.
		///		fkAdmApplicantGsCountryNode Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCountryNodeId">الجنسية</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmApplicant objects.</returns>
		public TList<AdmApplicant> GetByGsCountryNodeId(System.Decimal? _gsCountryNodeId, int start, int pageLength,out int count)
		{
			return GetByGsCountryNodeId(null, _gsCountryNodeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APPLICANT_GS_COUNTRY_NODE key.
		///		FK_ADM_APPLICANT_GS_COUNTRY_NODE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryNodeId">الجنسية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmApplicant objects.</returns>
		public abstract TList<AdmApplicant> GetByGsCountryNodeId(TransactionManager transactionManager, System.Decimal? _gsCountryNodeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APPLICANTS_GS_CDE_MARITAL_STATUS key.
		///		FK_ADM_APPLICANTS_GS_CDE_MARITAL_STATUS Description: 
		/// </summary>
		/// <param name="_gsCdeMaritalStatusId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmApplicant objects.</returns>
		public TList<AdmApplicant> GetByGsCdeMaritalStatusId(System.Decimal? _gsCdeMaritalStatusId)
		{
			int count = -1;
			return GetByGsCdeMaritalStatusId(_gsCdeMaritalStatusId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APPLICANTS_GS_CDE_MARITAL_STATUS key.
		///		FK_ADM_APPLICANTS_GS_CDE_MARITAL_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeMaritalStatusId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmApplicant objects.</returns>
		/// <remarks></remarks>
		public TList<AdmApplicant> GetByGsCdeMaritalStatusId(TransactionManager transactionManager, System.Decimal? _gsCdeMaritalStatusId)
		{
			int count = -1;
			return GetByGsCdeMaritalStatusId(transactionManager, _gsCdeMaritalStatusId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APPLICANTS_GS_CDE_MARITAL_STATUS key.
		///		FK_ADM_APPLICANTS_GS_CDE_MARITAL_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeMaritalStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmApplicant objects.</returns>
		public TList<AdmApplicant> GetByGsCdeMaritalStatusId(TransactionManager transactionManager, System.Decimal? _gsCdeMaritalStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeMaritalStatusId(transactionManager, _gsCdeMaritalStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APPLICANTS_GS_CDE_MARITAL_STATUS key.
		///		fkAdmApplicantsGsCdeMaritalStatus Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCdeMaritalStatusId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmApplicant objects.</returns>
		public TList<AdmApplicant> GetByGsCdeMaritalStatusId(System.Decimal? _gsCdeMaritalStatusId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCdeMaritalStatusId(null, _gsCdeMaritalStatusId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APPLICANTS_GS_CDE_MARITAL_STATUS key.
		///		fkAdmApplicantsGsCdeMaritalStatus Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCdeMaritalStatusId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmApplicant objects.</returns>
		public TList<AdmApplicant> GetByGsCdeMaritalStatusId(System.Decimal? _gsCdeMaritalStatusId, int start, int pageLength,out int count)
		{
			return GetByGsCdeMaritalStatusId(null, _gsCdeMaritalStatusId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APPLICANTS_GS_CDE_MARITAL_STATUS key.
		///		FK_ADM_APPLICANTS_GS_CDE_MARITAL_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeMaritalStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmApplicant objects.</returns>
		public abstract TList<AdmApplicant> GetByGsCdeMaritalStatusId(TransactionManager transactionManager, System.Decimal? _gsCdeMaritalStatusId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APPLICANTS_GS_CODE_RELIGION key.
		///		FK_ADM_APPLICANTS_GS_CODE_RELIGION Description: 
		/// </summary>
		/// <param name="_gsCodeReligionId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmApplicant objects.</returns>
		public TList<AdmApplicant> GetByGsCodeReligionId(System.Decimal? _gsCodeReligionId)
		{
			int count = -1;
			return GetByGsCodeReligionId(_gsCodeReligionId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APPLICANTS_GS_CODE_RELIGION key.
		///		FK_ADM_APPLICANTS_GS_CODE_RELIGION Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeReligionId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmApplicant objects.</returns>
		/// <remarks></remarks>
		public TList<AdmApplicant> GetByGsCodeReligionId(TransactionManager transactionManager, System.Decimal? _gsCodeReligionId)
		{
			int count = -1;
			return GetByGsCodeReligionId(transactionManager, _gsCodeReligionId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APPLICANTS_GS_CODE_RELIGION key.
		///		FK_ADM_APPLICANTS_GS_CODE_RELIGION Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeReligionId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmApplicant objects.</returns>
		public TList<AdmApplicant> GetByGsCodeReligionId(TransactionManager transactionManager, System.Decimal? _gsCodeReligionId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeReligionId(transactionManager, _gsCodeReligionId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APPLICANTS_GS_CODE_RELIGION key.
		///		fkAdmApplicantsGsCodeReligion Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeReligionId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmApplicant objects.</returns>
		public TList<AdmApplicant> GetByGsCodeReligionId(System.Decimal? _gsCodeReligionId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodeReligionId(null, _gsCodeReligionId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APPLICANTS_GS_CODE_RELIGION key.
		///		fkAdmApplicantsGsCodeReligion Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeReligionId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmApplicant objects.</returns>
		public TList<AdmApplicant> GetByGsCodeReligionId(System.Decimal? _gsCodeReligionId, int start, int pageLength,out int count)
		{
			return GetByGsCodeReligionId(null, _gsCodeReligionId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APPLICANTS_GS_CODE_RELIGION key.
		///		FK_ADM_APPLICANTS_GS_CODE_RELIGION Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeReligionId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmApplicant objects.</returns>
		public abstract TList<AdmApplicant> GetByGsCodeReligionId(TransactionManager transactionManager, System.Decimal? _gsCodeReligionId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.AdmApplicant Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmApplicantKey key, int start, int pageLength)
		{
			return GetByAdmApplicantId(transactionManager, key.AdmApplicantId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key ADM_APP_CODE_INDEX index.
		/// </summary>
		/// <param name="_admAppCode"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmApplicant&gt;"/> class.</returns>
		public TList<AdmApplicant> GetByAdmAppCode(System.String _admAppCode)
		{
			int count = -1;
			return GetByAdmAppCode(null,_admAppCode, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the ADM_APP_CODE_INDEX index.
		/// </summary>
		/// <param name="_admAppCode"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmApplicant&gt;"/> class.</returns>
		public TList<AdmApplicant> GetByAdmAppCode(System.String _admAppCode, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppCode(null, _admAppCode, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the ADM_APP_CODE_INDEX index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppCode"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmApplicant&gt;"/> class.</returns>
		public TList<AdmApplicant> GetByAdmAppCode(TransactionManager transactionManager, System.String _admAppCode)
		{
			int count = -1;
			return GetByAdmAppCode(transactionManager, _admAppCode, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the ADM_APP_CODE_INDEX index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppCode"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmApplicant&gt;"/> class.</returns>
		public TList<AdmApplicant> GetByAdmAppCode(TransactionManager transactionManager, System.String _admAppCode, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppCode(transactionManager, _admAppCode, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the ADM_APP_CODE_INDEX index.
		/// </summary>
		/// <param name="_admAppCode"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmApplicant&gt;"/> class.</returns>
		public TList<AdmApplicant> GetByAdmAppCode(System.String _admAppCode, int start, int pageLength, out int count)
		{
			return GetByAdmAppCode(null, _admAppCode, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the ADM_APP_CODE_INDEX index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppCode"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmApplicant&gt;"/> class.</returns>
		public abstract TList<AdmApplicant> GetByAdmAppCode(TransactionManager transactionManager, System.String _admAppCode, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key CPR_NonClusteredIndex index.
		/// </summary>
		/// <param name="_cpr"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmApplicant&gt;"/> class.</returns>
		public TList<AdmApplicant> GetByCpr(System.String _cpr)
		{
			int count = -1;
			return GetByCpr(null,_cpr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the CPR_NonClusteredIndex index.
		/// </summary>
		/// <param name="_cpr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmApplicant&gt;"/> class.</returns>
		public TList<AdmApplicant> GetByCpr(System.String _cpr, int start, int pageLength)
		{
			int count = -1;
			return GetByCpr(null, _cpr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the CPR_NonClusteredIndex index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_cpr"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmApplicant&gt;"/> class.</returns>
		public TList<AdmApplicant> GetByCpr(TransactionManager transactionManager, System.String _cpr)
		{
			int count = -1;
			return GetByCpr(transactionManager, _cpr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the CPR_NonClusteredIndex index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_cpr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmApplicant&gt;"/> class.</returns>
		public TList<AdmApplicant> GetByCpr(TransactionManager transactionManager, System.String _cpr, int start, int pageLength)
		{
			int count = -1;
			return GetByCpr(transactionManager, _cpr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the CPR_NonClusteredIndex index.
		/// </summary>
		/// <param name="_cpr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmApplicant&gt;"/> class.</returns>
		public TList<AdmApplicant> GetByCpr(System.String _cpr, int start, int pageLength, out int count)
		{
			return GetByCpr(null, _cpr, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the CPR_NonClusteredIndex index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_cpr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmApplicant&gt;"/> class.</returns>
		public abstract TList<AdmApplicant> GetByCpr(TransactionManager transactionManager, System.String _cpr, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key ED_STUD_ID_NonClusteredIndex-20131121-210615 index.
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmApplicant&gt;"/> class.</returns>
		public TList<AdmApplicant> GetByEdStudId(System.Decimal? _edStudId)
		{
			int count = -1;
			return GetByEdStudId(null,_edStudId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the ED_STUD_ID_NonClusteredIndex-20131121-210615 index.
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmApplicant&gt;"/> class.</returns>
		public TList<AdmApplicant> GetByEdStudId(System.Decimal? _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the ED_STUD_ID_NonClusteredIndex-20131121-210615 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmApplicant&gt;"/> class.</returns>
		public TList<AdmApplicant> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the ED_STUD_ID_NonClusteredIndex-20131121-210615 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmApplicant&gt;"/> class.</returns>
		public TList<AdmApplicant> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the ED_STUD_ID_NonClusteredIndex-20131121-210615 index.
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmApplicant&gt;"/> class.</returns>
		public TList<AdmApplicant> GetByEdStudId(System.Decimal? _edStudId, int start, int pageLength, out int count)
		{
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the ED_STUD_ID_NonClusteredIndex-20131121-210615 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmApplicant&gt;"/> class.</returns>
		public abstract TList<AdmApplicant> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key GS_BIRTH_COUNTRY_NO_NonClusteredIndex index.
		/// </summary>
		/// <param name="_gsBirthCountryNodeId">مكان الميلاد</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmApplicant&gt;"/> class.</returns>
		public TList<AdmApplicant> GetByGsBirthCountryNodeId(System.Decimal? _gsBirthCountryNodeId)
		{
			int count = -1;
			return GetByGsBirthCountryNodeId(null,_gsBirthCountryNodeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the GS_BIRTH_COUNTRY_NO_NonClusteredIndex index.
		/// </summary>
		/// <param name="_gsBirthCountryNodeId">مكان الميلاد</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmApplicant&gt;"/> class.</returns>
		public TList<AdmApplicant> GetByGsBirthCountryNodeId(System.Decimal? _gsBirthCountryNodeId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsBirthCountryNodeId(null, _gsBirthCountryNodeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the GS_BIRTH_COUNTRY_NO_NonClusteredIndex index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsBirthCountryNodeId">مكان الميلاد</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmApplicant&gt;"/> class.</returns>
		public TList<AdmApplicant> GetByGsBirthCountryNodeId(TransactionManager transactionManager, System.Decimal? _gsBirthCountryNodeId)
		{
			int count = -1;
			return GetByGsBirthCountryNodeId(transactionManager, _gsBirthCountryNodeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the GS_BIRTH_COUNTRY_NO_NonClusteredIndex index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsBirthCountryNodeId">مكان الميلاد</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmApplicant&gt;"/> class.</returns>
		public TList<AdmApplicant> GetByGsBirthCountryNodeId(TransactionManager transactionManager, System.Decimal? _gsBirthCountryNodeId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsBirthCountryNodeId(transactionManager, _gsBirthCountryNodeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the GS_BIRTH_COUNTRY_NO_NonClusteredIndex index.
		/// </summary>
		/// <param name="_gsBirthCountryNodeId">مكان الميلاد</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmApplicant&gt;"/> class.</returns>
		public TList<AdmApplicant> GetByGsBirthCountryNodeId(System.Decimal? _gsBirthCountryNodeId, int start, int pageLength, out int count)
		{
			return GetByGsBirthCountryNodeId(null, _gsBirthCountryNodeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the GS_BIRTH_COUNTRY_NO_NonClusteredIndex index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsBirthCountryNodeId">مكان الميلاد</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmApplicant&gt;"/> class.</returns>
		public abstract TList<AdmApplicant> GetByGsBirthCountryNodeId(TransactionManager transactionManager, System.Decimal? _gsBirthCountryNodeId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key GS_CODE_GENDER_ID_NonClusteredIndex index.
		/// </summary>
		/// <param name="_gsCodeGenderId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmApplicant&gt;"/> class.</returns>
		public TList<AdmApplicant> GetByGsCodeGenderId(System.Decimal? _gsCodeGenderId)
		{
			int count = -1;
			return GetByGsCodeGenderId(null,_gsCodeGenderId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the GS_CODE_GENDER_ID_NonClusteredIndex index.
		/// </summary>
		/// <param name="_gsCodeGenderId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmApplicant&gt;"/> class.</returns>
		public TList<AdmApplicant> GetByGsCodeGenderId(System.Decimal? _gsCodeGenderId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeGenderId(null, _gsCodeGenderId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the GS_CODE_GENDER_ID_NonClusteredIndex index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeGenderId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmApplicant&gt;"/> class.</returns>
		public TList<AdmApplicant> GetByGsCodeGenderId(TransactionManager transactionManager, System.Decimal? _gsCodeGenderId)
		{
			int count = -1;
			return GetByGsCodeGenderId(transactionManager, _gsCodeGenderId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the GS_CODE_GENDER_ID_NonClusteredIndex index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeGenderId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmApplicant&gt;"/> class.</returns>
		public TList<AdmApplicant> GetByGsCodeGenderId(TransactionManager transactionManager, System.Decimal? _gsCodeGenderId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeGenderId(transactionManager, _gsCodeGenderId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the GS_CODE_GENDER_ID_NonClusteredIndex index.
		/// </summary>
		/// <param name="_gsCodeGenderId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmApplicant&gt;"/> class.</returns>
		public TList<AdmApplicant> GetByGsCodeGenderId(System.Decimal? _gsCodeGenderId, int start, int pageLength, out int count)
		{
			return GetByGsCodeGenderId(null, _gsCodeGenderId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the GS_CODE_GENDER_ID_NonClusteredIndex index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeGenderId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmApplicant&gt;"/> class.</returns>
		public abstract TList<AdmApplicant> GetByGsCodeGenderId(TransactionManager transactionManager, System.Decimal? _gsCodeGenderId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ADM_APPLICANT index.
		/// </summary>
		/// <param name="_username"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmApplicant"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmApplicant GetByUsername(System.String _username)
		{
			int count = -1;
			return GetByUsername(null,_username, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ADM_APPLICANT index.
		/// </summary>
		/// <param name="_username"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmApplicant"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmApplicant GetByUsername(System.String _username, int start, int pageLength)
		{
			int count = -1;
			return GetByUsername(null, _username, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ADM_APPLICANT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_username"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmApplicant"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmApplicant GetByUsername(TransactionManager transactionManager, System.String _username)
		{
			int count = -1;
			return GetByUsername(transactionManager, _username, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ADM_APPLICANT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_username"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmApplicant"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmApplicant GetByUsername(TransactionManager transactionManager, System.String _username, int start, int pageLength)
		{
			int count = -1;
			return GetByUsername(transactionManager, _username, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ADM_APPLICANT index.
		/// </summary>
		/// <param name="_username"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmApplicant"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmApplicant GetByUsername(System.String _username, int start, int pageLength, out int count)
		{
			return GetByUsername(null, _username, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ADM_APPLICANT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_username"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmApplicant"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmApplicant GetByUsername(TransactionManager transactionManager, System.String _username, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ADM_N_APP index.
		/// </summary>
		/// <param name="_admApplicantId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmApplicant"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmApplicant GetByAdmApplicantId(System.Decimal _admApplicantId)
		{
			int count = -1;
			return GetByAdmApplicantId(null,_admApplicantId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_N_APP index.
		/// </summary>
		/// <param name="_admApplicantId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmApplicant"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmApplicant GetByAdmApplicantId(System.Decimal _admApplicantId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmApplicantId(null, _admApplicantId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_N_APP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmApplicant"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmApplicant GetByAdmApplicantId(TransactionManager transactionManager, System.Decimal _admApplicantId)
		{
			int count = -1;
			return GetByAdmApplicantId(transactionManager, _admApplicantId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_N_APP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmApplicant"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmApplicant GetByAdmApplicantId(TransactionManager transactionManager, System.Decimal _admApplicantId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmApplicantId(transactionManager, _admApplicantId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_N_APP index.
		/// </summary>
		/// <param name="_admApplicantId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmApplicant"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmApplicant GetByAdmApplicantId(System.Decimal _admApplicantId, int start, int pageLength, out int count)
		{
			return GetByAdmApplicantId(null, _admApplicantId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_N_APP index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmApplicant"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmApplicant GetByAdmApplicantId(TransactionManager transactionManager, System.Decimal _admApplicantId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key SECURITY_QS_NonClusteredIndex index.
		/// </summary>
		/// <param name="_securityQs"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmApplicant&gt;"/> class.</returns>
		public TList<AdmApplicant> GetBySecurityQs(System.String _securityQs)
		{
			int count = -1;
			return GetBySecurityQs(null,_securityQs, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the SECURITY_QS_NonClusteredIndex index.
		/// </summary>
		/// <param name="_securityQs"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmApplicant&gt;"/> class.</returns>
		public TList<AdmApplicant> GetBySecurityQs(System.String _securityQs, int start, int pageLength)
		{
			int count = -1;
			return GetBySecurityQs(null, _securityQs, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the SECURITY_QS_NonClusteredIndex index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_securityQs"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmApplicant&gt;"/> class.</returns>
		public TList<AdmApplicant> GetBySecurityQs(TransactionManager transactionManager, System.String _securityQs)
		{
			int count = -1;
			return GetBySecurityQs(transactionManager, _securityQs, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the SECURITY_QS_NonClusteredIndex index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_securityQs"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmApplicant&gt;"/> class.</returns>
		public TList<AdmApplicant> GetBySecurityQs(TransactionManager transactionManager, System.String _securityQs, int start, int pageLength)
		{
			int count = -1;
			return GetBySecurityQs(transactionManager, _securityQs, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the SECURITY_QS_NonClusteredIndex index.
		/// </summary>
		/// <param name="_securityQs"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmApplicant&gt;"/> class.</returns>
		public TList<AdmApplicant> GetBySecurityQs(System.String _securityQs, int start, int pageLength, out int count)
		{
			return GetBySecurityQs(null, _securityQs, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the SECURITY_QS_NonClusteredIndex index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_securityQs"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmApplicant&gt;"/> class.</returns>
		public abstract TList<AdmApplicant> GetBySecurityQs(TransactionManager transactionManager, System.String _securityQs, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AdmApplicant&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AdmApplicant&gt;"/></returns>
		public static TList<AdmApplicant> Fill(IDataReader reader, TList<AdmApplicant> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AdmApplicant c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AdmApplicant")
					.Append("|").Append((System.Decimal)reader["ADM_APPLICANT_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AdmApplicant>(
					key.ToString(), // EntityTrackingKey
					"AdmApplicant",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AdmApplicant();
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
					c.AdmApplicantId = (System.Decimal)reader["ADM_APPLICANT_ID"];
					c.OriginalAdmApplicantId = c.AdmApplicantId;
					c.AdmAppCode = Convert.IsDBNull(reader["ADM_APP_CODE"]) ? null : (System.String)reader["ADM_APP_CODE"];
					c.Username = Convert.IsDBNull(reader["USERNAME"]) ? null : (System.String)reader["USERNAME"];
					c.PasswordSalt = Convert.IsDBNull(reader["PASSWORD_SALT"]) ? null : (System.String)reader["PASSWORD_SALT"];
					c.PasswordHash = Convert.IsDBNull(reader["PASSWORD_HASH"]) ? null : (System.String)reader["PASSWORD_HASH"];
					c.SecurityQs = Convert.IsDBNull(reader["SECURITY_QS"]) ? null : (System.String)reader["SECURITY_QS"];
					c.SecurityQsAnsSalt = Convert.IsDBNull(reader["SECURITY_QS_ANS_SALT"]) ? null : (System.String)reader["SECURITY_QS_ANS_SALT"];
					c.SecurityQsAnsHash = Convert.IsDBNull(reader["SECURITY_QS_ANS_HASH"]) ? null : (System.String)reader["SECURITY_QS_ANS_HASH"];
					c.ActivationCode = Convert.IsDBNull(reader["ACTIVATION_CODE"]) ? null : (System.String)reader["ACTIVATION_CODE"];
					c.ActivationFlg = Convert.IsDBNull(reader["ACTIVATION_FLG"]) ? null : (System.Decimal?)reader["ACTIVATION_FLG"];
					c.RegDate = Convert.IsDBNull(reader["REG_DATE"]) ? null : (System.DateTime?)reader["REG_DATE"];
					c.FnameAr = Convert.IsDBNull(reader["FNAME_AR"]) ? null : (System.String)reader["FNAME_AR"];
					c.FnameEn = Convert.IsDBNull(reader["FNAME_EN"]) ? null : (System.String)reader["FNAME_EN"];
					c.MnameAr = Convert.IsDBNull(reader["MNAME_AR"]) ? null : (System.String)reader["MNAME_AR"];
					c.MnameEn = Convert.IsDBNull(reader["MNAME_EN"]) ? null : (System.String)reader["MNAME_EN"];
					c.LnameAr = Convert.IsDBNull(reader["LNAME_AR"]) ? null : (System.String)reader["LNAME_AR"];
					c.LnameEn = Convert.IsDBNull(reader["LNAME_EN"]) ? null : (System.String)reader["LNAME_EN"];
					c.FamilyAr = Convert.IsDBNull(reader["FAMILY_AR"]) ? null : (System.String)reader["FAMILY_AR"];
					c.FamilyEn = Convert.IsDBNull(reader["FAMILY_EN"]) ? null : (System.String)reader["FAMILY_EN"];
					c.GsCodeReligionId = Convert.IsDBNull(reader["GS_CODE_RELIGION_ID"]) ? null : (System.Decimal?)reader["GS_CODE_RELIGION_ID"];
					c.Cpr = Convert.IsDBNull(reader["CPR"]) ? null : (System.String)reader["CPR"];
					c.PassporNo = Convert.IsDBNull(reader["PASSPOR_NO"]) ? null : (System.String)reader["PASSPOR_NO"];
					c.PassporExpireDate = Convert.IsDBNull(reader["PASSPOR_EXPIRE_DATE"]) ? null : (System.DateTime?)reader["PASSPOR_EXPIRE_DATE"];
					c.Birthdate = Convert.IsDBNull(reader["BIRTHDATE"]) ? null : (System.DateTime?)reader["BIRTHDATE"];
					c.PhotoPath = Convert.IsDBNull(reader["PHOTO_PATH"]) ? null : (System.String)reader["PHOTO_PATH"];
					c.GsCdeMaritalStatusId = Convert.IsDBNull(reader["GS_CDE_MARITAL_STATUS_ID"]) ? null : (System.Decimal?)reader["GS_CDE_MARITAL_STATUS_ID"];
					c.GsCodeGenderId = Convert.IsDBNull(reader["GS_CODE_GENDER_ID"]) ? null : (System.Decimal?)reader["GS_CODE_GENDER_ID"];
					c.WorkFlg = Convert.IsDBNull(reader["WORK_FLG"]) ? null : (System.Decimal?)reader["WORK_FLG"];
					c.GsCountryNodeId = Convert.IsDBNull(reader["GS_COUNTRY_NODE_ID"]) ? null : (System.Decimal?)reader["GS_COUNTRY_NODE_ID"];
					c.FullNameAr = Convert.IsDBNull(reader["FULL_NAME_AR"]) ? null : (System.String)reader["FULL_NAME_AR"];
					c.FullNameEn = Convert.IsDBNull(reader["FULL_NAME_EN"]) ? null : (System.String)reader["FULL_NAME_EN"];
					c.ResidentId = Convert.IsDBNull(reader["RESIDENT_ID"]) ? null : (System.String)reader["RESIDENT_ID"];
					c.ResidentExpireDate = Convert.IsDBNull(reader["RESIDENT_EXPIRE_DATE"]) ? null : (System.DateTime?)reader["RESIDENT_EXPIRE_DATE"];
					c.GsBirthCountryNodeId = Convert.IsDBNull(reader["GS_BIRTH_COUNTRY_NODE_ID"]) ? null : (System.Decimal?)reader["GS_BIRTH_COUNTRY_NODE_ID"];
					c.EdStudId = Convert.IsDBNull(reader["ED_STUD_ID"]) ? null : (System.Decimal?)reader["ED_STUD_ID"];
					c.LoyaltyFlg = Convert.IsDBNull(reader["LOYALTY_FLG"]) ? null : (System.Decimal?)reader["LOYALTY_FLG"];
					c.GsCodeLanguageId = Convert.IsDBNull(reader["GS_CODE_LANGUAGE_ID"]) ? null : (System.Decimal?)reader["GS_CODE_LANGUAGE_ID"];
					c.PassporIssueDate = Convert.IsDBNull(reader["PASSPOR_ISSUE_DATE"]) ? null : (System.DateTime?)reader["PASSPOR_ISSUE_DATE"];
					c.SpecialNeedFlg = Convert.IsDBNull(reader["SPECIAL_NEED_FLG"]) ? null : (System.Boolean?)reader["SPECIAL_NEED_FLG"];
					c.IdentIssueDate = Convert.IsDBNull(reader["IDENT_ISSUE_DATE"]) ? null : (System.DateTime?)reader["IDENT_ISSUE_DATE"];
					c.IdentExpireDate = Convert.IsDBNull(reader["IDENT_EXPIRE_DATE"]) ? null : (System.DateTime?)reader["IDENT_EXPIRE_DATE"];
					c.IdentIssuePlc = Convert.IsDBNull(reader["IDENT_ISSUE_PLC"]) ? null : (System.String)reader["IDENT_ISSUE_PLC"];
					c.VisaNumber = Convert.IsDBNull(reader["VISA_NUMBER"]) ? null : (System.String)reader["VISA_NUMBER"];
					c.VisaIssueDate = Convert.IsDBNull(reader["VISA_ISSUE_DATE"]) ? null : (System.DateTime?)reader["VISA_ISSUE_DATE"];
					c.VisaExpireDate = Convert.IsDBNull(reader["VISA_EXPIRE_DATE"]) ? null : (System.DateTime?)reader["VISA_EXPIRE_DATE"];
					c.LastDate = Convert.IsDBNull(reader["LAST_DATE"]) ? null : (System.DateTime?)reader["LAST_DATE"];
					c.SeUserId = Convert.IsDBNull(reader["SE_USER_ID"]) ? null : (System.Decimal?)reader["SE_USER_ID"];
					c.EdCdeSocialAffairId = Convert.IsDBNull(reader["ED_CDE_SOCIAL_AFFAIR_ID"]) ? null : (System.Int32?)reader["ED_CDE_SOCIAL_AFFAIR_ID"];
					c.PucFlg = Convert.IsDBNull(reader["PUC_FLG"]) ? null : (System.Boolean?)reader["PUC_FLG"];
					c.NoChild = Convert.IsDBNull(reader["NO_CHILD"]) ? null : (System.Int32?)reader["NO_CHILD"];
					c.HighQualFlg = Convert.IsDBNull(reader["HIGH_QUAL_FLG"]) ? null : (System.Boolean?)reader["HIGH_QUAL_FLG"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmApplicant"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmApplicant"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AdmApplicant entity)
		{
			if (!reader.Read()) return;
			
			entity.AdmApplicantId = (System.Decimal)reader[((int)AdmApplicantColumn.AdmApplicantId - 1)];
			entity.OriginalAdmApplicantId = (System.Decimal)reader["ADM_APPLICANT_ID"];
			entity.AdmAppCode = (reader.IsDBNull(((int)AdmApplicantColumn.AdmAppCode - 1)))?null:(System.String)reader[((int)AdmApplicantColumn.AdmAppCode - 1)];
			entity.Username = (reader.IsDBNull(((int)AdmApplicantColumn.Username - 1)))?null:(System.String)reader[((int)AdmApplicantColumn.Username - 1)];
			entity.PasswordSalt = (reader.IsDBNull(((int)AdmApplicantColumn.PasswordSalt - 1)))?null:(System.String)reader[((int)AdmApplicantColumn.PasswordSalt - 1)];
			entity.PasswordHash = (reader.IsDBNull(((int)AdmApplicantColumn.PasswordHash - 1)))?null:(System.String)reader[((int)AdmApplicantColumn.PasswordHash - 1)];
			entity.SecurityQs = (reader.IsDBNull(((int)AdmApplicantColumn.SecurityQs - 1)))?null:(System.String)reader[((int)AdmApplicantColumn.SecurityQs - 1)];
			entity.SecurityQsAnsSalt = (reader.IsDBNull(((int)AdmApplicantColumn.SecurityQsAnsSalt - 1)))?null:(System.String)reader[((int)AdmApplicantColumn.SecurityQsAnsSalt - 1)];
			entity.SecurityQsAnsHash = (reader.IsDBNull(((int)AdmApplicantColumn.SecurityQsAnsHash - 1)))?null:(System.String)reader[((int)AdmApplicantColumn.SecurityQsAnsHash - 1)];
			entity.ActivationCode = (reader.IsDBNull(((int)AdmApplicantColumn.ActivationCode - 1)))?null:(System.String)reader[((int)AdmApplicantColumn.ActivationCode - 1)];
			entity.ActivationFlg = (reader.IsDBNull(((int)AdmApplicantColumn.ActivationFlg - 1)))?null:(System.Decimal?)reader[((int)AdmApplicantColumn.ActivationFlg - 1)];
			entity.RegDate = (reader.IsDBNull(((int)AdmApplicantColumn.RegDate - 1)))?null:(System.DateTime?)reader[((int)AdmApplicantColumn.RegDate - 1)];
			entity.FnameAr = (reader.IsDBNull(((int)AdmApplicantColumn.FnameAr - 1)))?null:(System.String)reader[((int)AdmApplicantColumn.FnameAr - 1)];
			entity.FnameEn = (reader.IsDBNull(((int)AdmApplicantColumn.FnameEn - 1)))?null:(System.String)reader[((int)AdmApplicantColumn.FnameEn - 1)];
			entity.MnameAr = (reader.IsDBNull(((int)AdmApplicantColumn.MnameAr - 1)))?null:(System.String)reader[((int)AdmApplicantColumn.MnameAr - 1)];
			entity.MnameEn = (reader.IsDBNull(((int)AdmApplicantColumn.MnameEn - 1)))?null:(System.String)reader[((int)AdmApplicantColumn.MnameEn - 1)];
			entity.LnameAr = (reader.IsDBNull(((int)AdmApplicantColumn.LnameAr - 1)))?null:(System.String)reader[((int)AdmApplicantColumn.LnameAr - 1)];
			entity.LnameEn = (reader.IsDBNull(((int)AdmApplicantColumn.LnameEn - 1)))?null:(System.String)reader[((int)AdmApplicantColumn.LnameEn - 1)];
			entity.FamilyAr = (reader.IsDBNull(((int)AdmApplicantColumn.FamilyAr - 1)))?null:(System.String)reader[((int)AdmApplicantColumn.FamilyAr - 1)];
			entity.FamilyEn = (reader.IsDBNull(((int)AdmApplicantColumn.FamilyEn - 1)))?null:(System.String)reader[((int)AdmApplicantColumn.FamilyEn - 1)];
			entity.GsCodeReligionId = (reader.IsDBNull(((int)AdmApplicantColumn.GsCodeReligionId - 1)))?null:(System.Decimal?)reader[((int)AdmApplicantColumn.GsCodeReligionId - 1)];
			entity.Cpr = (reader.IsDBNull(((int)AdmApplicantColumn.Cpr - 1)))?null:(System.String)reader[((int)AdmApplicantColumn.Cpr - 1)];
			entity.PassporNo = (reader.IsDBNull(((int)AdmApplicantColumn.PassporNo - 1)))?null:(System.String)reader[((int)AdmApplicantColumn.PassporNo - 1)];
			entity.PassporExpireDate = (reader.IsDBNull(((int)AdmApplicantColumn.PassporExpireDate - 1)))?null:(System.DateTime?)reader[((int)AdmApplicantColumn.PassporExpireDate - 1)];
			entity.Birthdate = (reader.IsDBNull(((int)AdmApplicantColumn.Birthdate - 1)))?null:(System.DateTime?)reader[((int)AdmApplicantColumn.Birthdate - 1)];
			entity.PhotoPath = (reader.IsDBNull(((int)AdmApplicantColumn.PhotoPath - 1)))?null:(System.String)reader[((int)AdmApplicantColumn.PhotoPath - 1)];
			entity.GsCdeMaritalStatusId = (reader.IsDBNull(((int)AdmApplicantColumn.GsCdeMaritalStatusId - 1)))?null:(System.Decimal?)reader[((int)AdmApplicantColumn.GsCdeMaritalStatusId - 1)];
			entity.GsCodeGenderId = (reader.IsDBNull(((int)AdmApplicantColumn.GsCodeGenderId - 1)))?null:(System.Decimal?)reader[((int)AdmApplicantColumn.GsCodeGenderId - 1)];
			entity.WorkFlg = (reader.IsDBNull(((int)AdmApplicantColumn.WorkFlg - 1)))?null:(System.Decimal?)reader[((int)AdmApplicantColumn.WorkFlg - 1)];
			entity.GsCountryNodeId = (reader.IsDBNull(((int)AdmApplicantColumn.GsCountryNodeId - 1)))?null:(System.Decimal?)reader[((int)AdmApplicantColumn.GsCountryNodeId - 1)];
			entity.FullNameAr = (reader.IsDBNull(((int)AdmApplicantColumn.FullNameAr - 1)))?null:(System.String)reader[((int)AdmApplicantColumn.FullNameAr - 1)];
			entity.FullNameEn = (reader.IsDBNull(((int)AdmApplicantColumn.FullNameEn - 1)))?null:(System.String)reader[((int)AdmApplicantColumn.FullNameEn - 1)];
			entity.ResidentId = (reader.IsDBNull(((int)AdmApplicantColumn.ResidentId - 1)))?null:(System.String)reader[((int)AdmApplicantColumn.ResidentId - 1)];
			entity.ResidentExpireDate = (reader.IsDBNull(((int)AdmApplicantColumn.ResidentExpireDate - 1)))?null:(System.DateTime?)reader[((int)AdmApplicantColumn.ResidentExpireDate - 1)];
			entity.GsBirthCountryNodeId = (reader.IsDBNull(((int)AdmApplicantColumn.GsBirthCountryNodeId - 1)))?null:(System.Decimal?)reader[((int)AdmApplicantColumn.GsBirthCountryNodeId - 1)];
			entity.EdStudId = (reader.IsDBNull(((int)AdmApplicantColumn.EdStudId - 1)))?null:(System.Decimal?)reader[((int)AdmApplicantColumn.EdStudId - 1)];
			entity.LoyaltyFlg = (reader.IsDBNull(((int)AdmApplicantColumn.LoyaltyFlg - 1)))?null:(System.Decimal?)reader[((int)AdmApplicantColumn.LoyaltyFlg - 1)];
			entity.GsCodeLanguageId = (reader.IsDBNull(((int)AdmApplicantColumn.GsCodeLanguageId - 1)))?null:(System.Decimal?)reader[((int)AdmApplicantColumn.GsCodeLanguageId - 1)];
			entity.PassporIssueDate = (reader.IsDBNull(((int)AdmApplicantColumn.PassporIssueDate - 1)))?null:(System.DateTime?)reader[((int)AdmApplicantColumn.PassporIssueDate - 1)];
			entity.SpecialNeedFlg = (reader.IsDBNull(((int)AdmApplicantColumn.SpecialNeedFlg - 1)))?null:(System.Boolean?)reader[((int)AdmApplicantColumn.SpecialNeedFlg - 1)];
			entity.IdentIssueDate = (reader.IsDBNull(((int)AdmApplicantColumn.IdentIssueDate - 1)))?null:(System.DateTime?)reader[((int)AdmApplicantColumn.IdentIssueDate - 1)];
			entity.IdentExpireDate = (reader.IsDBNull(((int)AdmApplicantColumn.IdentExpireDate - 1)))?null:(System.DateTime?)reader[((int)AdmApplicantColumn.IdentExpireDate - 1)];
			entity.IdentIssuePlc = (reader.IsDBNull(((int)AdmApplicantColumn.IdentIssuePlc - 1)))?null:(System.String)reader[((int)AdmApplicantColumn.IdentIssuePlc - 1)];
			entity.VisaNumber = (reader.IsDBNull(((int)AdmApplicantColumn.VisaNumber - 1)))?null:(System.String)reader[((int)AdmApplicantColumn.VisaNumber - 1)];
			entity.VisaIssueDate = (reader.IsDBNull(((int)AdmApplicantColumn.VisaIssueDate - 1)))?null:(System.DateTime?)reader[((int)AdmApplicantColumn.VisaIssueDate - 1)];
			entity.VisaExpireDate = (reader.IsDBNull(((int)AdmApplicantColumn.VisaExpireDate - 1)))?null:(System.DateTime?)reader[((int)AdmApplicantColumn.VisaExpireDate - 1)];
			entity.LastDate = (reader.IsDBNull(((int)AdmApplicantColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)AdmApplicantColumn.LastDate - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)AdmApplicantColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)AdmApplicantColumn.SeUserId - 1)];
			entity.EdCdeSocialAffairId = (reader.IsDBNull(((int)AdmApplicantColumn.EdCdeSocialAffairId - 1)))?null:(System.Int32?)reader[((int)AdmApplicantColumn.EdCdeSocialAffairId - 1)];
			entity.PucFlg = (reader.IsDBNull(((int)AdmApplicantColumn.PucFlg - 1)))?null:(System.Boolean?)reader[((int)AdmApplicantColumn.PucFlg - 1)];
			entity.NoChild = (reader.IsDBNull(((int)AdmApplicantColumn.NoChild - 1)))?null:(System.Int32?)reader[((int)AdmApplicantColumn.NoChild - 1)];
			entity.HighQualFlg = (reader.IsDBNull(((int)AdmApplicantColumn.HighQualFlg - 1)))?null:(System.Boolean?)reader[((int)AdmApplicantColumn.HighQualFlg - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmApplicant"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmApplicant"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AdmApplicant entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AdmApplicantId = (System.Decimal)dataRow["ADM_APPLICANT_ID"];
			entity.OriginalAdmApplicantId = (System.Decimal)dataRow["ADM_APPLICANT_ID"];
			entity.AdmAppCode = Convert.IsDBNull(dataRow["ADM_APP_CODE"]) ? null : (System.String)dataRow["ADM_APP_CODE"];
			entity.Username = Convert.IsDBNull(dataRow["USERNAME"]) ? null : (System.String)dataRow["USERNAME"];
			entity.PasswordSalt = Convert.IsDBNull(dataRow["PASSWORD_SALT"]) ? null : (System.String)dataRow["PASSWORD_SALT"];
			entity.PasswordHash = Convert.IsDBNull(dataRow["PASSWORD_HASH"]) ? null : (System.String)dataRow["PASSWORD_HASH"];
			entity.SecurityQs = Convert.IsDBNull(dataRow["SECURITY_QS"]) ? null : (System.String)dataRow["SECURITY_QS"];
			entity.SecurityQsAnsSalt = Convert.IsDBNull(dataRow["SECURITY_QS_ANS_SALT"]) ? null : (System.String)dataRow["SECURITY_QS_ANS_SALT"];
			entity.SecurityQsAnsHash = Convert.IsDBNull(dataRow["SECURITY_QS_ANS_HASH"]) ? null : (System.String)dataRow["SECURITY_QS_ANS_HASH"];
			entity.ActivationCode = Convert.IsDBNull(dataRow["ACTIVATION_CODE"]) ? null : (System.String)dataRow["ACTIVATION_CODE"];
			entity.ActivationFlg = Convert.IsDBNull(dataRow["ACTIVATION_FLG"]) ? null : (System.Decimal?)dataRow["ACTIVATION_FLG"];
			entity.RegDate = Convert.IsDBNull(dataRow["REG_DATE"]) ? null : (System.DateTime?)dataRow["REG_DATE"];
			entity.FnameAr = Convert.IsDBNull(dataRow["FNAME_AR"]) ? null : (System.String)dataRow["FNAME_AR"];
			entity.FnameEn = Convert.IsDBNull(dataRow["FNAME_EN"]) ? null : (System.String)dataRow["FNAME_EN"];
			entity.MnameAr = Convert.IsDBNull(dataRow["MNAME_AR"]) ? null : (System.String)dataRow["MNAME_AR"];
			entity.MnameEn = Convert.IsDBNull(dataRow["MNAME_EN"]) ? null : (System.String)dataRow["MNAME_EN"];
			entity.LnameAr = Convert.IsDBNull(dataRow["LNAME_AR"]) ? null : (System.String)dataRow["LNAME_AR"];
			entity.LnameEn = Convert.IsDBNull(dataRow["LNAME_EN"]) ? null : (System.String)dataRow["LNAME_EN"];
			entity.FamilyAr = Convert.IsDBNull(dataRow["FAMILY_AR"]) ? null : (System.String)dataRow["FAMILY_AR"];
			entity.FamilyEn = Convert.IsDBNull(dataRow["FAMILY_EN"]) ? null : (System.String)dataRow["FAMILY_EN"];
			entity.GsCodeReligionId = Convert.IsDBNull(dataRow["GS_CODE_RELIGION_ID"]) ? null : (System.Decimal?)dataRow["GS_CODE_RELIGION_ID"];
			entity.Cpr = Convert.IsDBNull(dataRow["CPR"]) ? null : (System.String)dataRow["CPR"];
			entity.PassporNo = Convert.IsDBNull(dataRow["PASSPOR_NO"]) ? null : (System.String)dataRow["PASSPOR_NO"];
			entity.PassporExpireDate = Convert.IsDBNull(dataRow["PASSPOR_EXPIRE_DATE"]) ? null : (System.DateTime?)dataRow["PASSPOR_EXPIRE_DATE"];
			entity.Birthdate = Convert.IsDBNull(dataRow["BIRTHDATE"]) ? null : (System.DateTime?)dataRow["BIRTHDATE"];
			entity.PhotoPath = Convert.IsDBNull(dataRow["PHOTO_PATH"]) ? null : (System.String)dataRow["PHOTO_PATH"];
			entity.GsCdeMaritalStatusId = Convert.IsDBNull(dataRow["GS_CDE_MARITAL_STATUS_ID"]) ? null : (System.Decimal?)dataRow["GS_CDE_MARITAL_STATUS_ID"];
			entity.GsCodeGenderId = Convert.IsDBNull(dataRow["GS_CODE_GENDER_ID"]) ? null : (System.Decimal?)dataRow["GS_CODE_GENDER_ID"];
			entity.WorkFlg = Convert.IsDBNull(dataRow["WORK_FLG"]) ? null : (System.Decimal?)dataRow["WORK_FLG"];
			entity.GsCountryNodeId = Convert.IsDBNull(dataRow["GS_COUNTRY_NODE_ID"]) ? null : (System.Decimal?)dataRow["GS_COUNTRY_NODE_ID"];
			entity.FullNameAr = Convert.IsDBNull(dataRow["FULL_NAME_AR"]) ? null : (System.String)dataRow["FULL_NAME_AR"];
			entity.FullNameEn = Convert.IsDBNull(dataRow["FULL_NAME_EN"]) ? null : (System.String)dataRow["FULL_NAME_EN"];
			entity.ResidentId = Convert.IsDBNull(dataRow["RESIDENT_ID"]) ? null : (System.String)dataRow["RESIDENT_ID"];
			entity.ResidentExpireDate = Convert.IsDBNull(dataRow["RESIDENT_EXPIRE_DATE"]) ? null : (System.DateTime?)dataRow["RESIDENT_EXPIRE_DATE"];
			entity.GsBirthCountryNodeId = Convert.IsDBNull(dataRow["GS_BIRTH_COUNTRY_NODE_ID"]) ? null : (System.Decimal?)dataRow["GS_BIRTH_COUNTRY_NODE_ID"];
			entity.EdStudId = Convert.IsDBNull(dataRow["ED_STUD_ID"]) ? null : (System.Decimal?)dataRow["ED_STUD_ID"];
			entity.LoyaltyFlg = Convert.IsDBNull(dataRow["LOYALTY_FLG"]) ? null : (System.Decimal?)dataRow["LOYALTY_FLG"];
			entity.GsCodeLanguageId = Convert.IsDBNull(dataRow["GS_CODE_LANGUAGE_ID"]) ? null : (System.Decimal?)dataRow["GS_CODE_LANGUAGE_ID"];
			entity.PassporIssueDate = Convert.IsDBNull(dataRow["PASSPOR_ISSUE_DATE"]) ? null : (System.DateTime?)dataRow["PASSPOR_ISSUE_DATE"];
			entity.SpecialNeedFlg = Convert.IsDBNull(dataRow["SPECIAL_NEED_FLG"]) ? null : (System.Boolean?)dataRow["SPECIAL_NEED_FLG"];
			entity.IdentIssueDate = Convert.IsDBNull(dataRow["IDENT_ISSUE_DATE"]) ? null : (System.DateTime?)dataRow["IDENT_ISSUE_DATE"];
			entity.IdentExpireDate = Convert.IsDBNull(dataRow["IDENT_EXPIRE_DATE"]) ? null : (System.DateTime?)dataRow["IDENT_EXPIRE_DATE"];
			entity.IdentIssuePlc = Convert.IsDBNull(dataRow["IDENT_ISSUE_PLC"]) ? null : (System.String)dataRow["IDENT_ISSUE_PLC"];
			entity.VisaNumber = Convert.IsDBNull(dataRow["VISA_NUMBER"]) ? null : (System.String)dataRow["VISA_NUMBER"];
			entity.VisaIssueDate = Convert.IsDBNull(dataRow["VISA_ISSUE_DATE"]) ? null : (System.DateTime?)dataRow["VISA_ISSUE_DATE"];
			entity.VisaExpireDate = Convert.IsDBNull(dataRow["VISA_EXPIRE_DATE"]) ? null : (System.DateTime?)dataRow["VISA_EXPIRE_DATE"];
			entity.LastDate = Convert.IsDBNull(dataRow["LAST_DATE"]) ? null : (System.DateTime?)dataRow["LAST_DATE"];
			entity.SeUserId = Convert.IsDBNull(dataRow["SE_USER_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_ID"];
			entity.EdCdeSocialAffairId = Convert.IsDBNull(dataRow["ED_CDE_SOCIAL_AFFAIR_ID"]) ? null : (System.Int32?)dataRow["ED_CDE_SOCIAL_AFFAIR_ID"];
			entity.PucFlg = Convert.IsDBNull(dataRow["PUC_FLG"]) ? null : (System.Boolean?)dataRow["PUC_FLG"];
			entity.NoChild = Convert.IsDBNull(dataRow["NO_CHILD"]) ? null : (System.Int32?)dataRow["NO_CHILD"];
			entity.HighQualFlg = Convert.IsDBNull(dataRow["HIGH_QUAL_FLG"]) ? null : (System.Boolean?)dataRow["HIGH_QUAL_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmApplicant"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmApplicant Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmApplicant entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdCdeSocialAffairIdSource	
			if (CanDeepLoad(entity, "EdCdeSocialAffair|EdCdeSocialAffairIdSource", deepLoadType, innerList) 
				&& entity.EdCdeSocialAffairIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCdeSocialAffairId ?? (int)0);
				EdCdeSocialAffair tmpEntity = EntityManager.LocateEntity<EdCdeSocialAffair>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCdeSocialAffair), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCdeSocialAffairIdSource = tmpEntity;
				else
					entity.EdCdeSocialAffairIdSource = DataRepository.EdCdeSocialAffairProvider.GetByEdCdeSocialAffairId(transactionManager, (entity.EdCdeSocialAffairId ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCdeSocialAffairIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCdeSocialAffairIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCdeSocialAffairProvider.DeepLoad(transactionManager, entity.EdCdeSocialAffairIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCdeSocialAffairIdSource

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
				pkItems[0] = (entity.GsCodeLanguageId ?? 0.0m);
				GsCodeLanguage tmpEntity = EntityManager.LocateEntity<GsCodeLanguage>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodeLanguage), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodeLanguageIdSource = tmpEntity;
				else
					entity.GsCodeLanguageIdSource = DataRepository.GsCodeLanguageProvider.GetByGsCodeLanguageId(transactionManager, (entity.GsCodeLanguageId ?? 0.0m));		
				
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

			#region GsCountryNodeIdSource	
			if (CanDeepLoad(entity, "GsCountryNode|GsCountryNodeIdSource", deepLoadType, innerList) 
				&& entity.GsCountryNodeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCountryNodeId ?? 0.0m);
				GsCountryNode tmpEntity = EntityManager.LocateEntity<GsCountryNode>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCountryNode), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCountryNodeIdSource = tmpEntity;
				else
					entity.GsCountryNodeIdSource = DataRepository.GsCountryNodeProvider.GetByGsCountryNodeId(transactionManager, (entity.GsCountryNodeId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCountryNodeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCountryNodeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCountryNodeProvider.DeepLoad(transactionManager, entity.GsCountryNodeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCountryNodeIdSource

			#region GsBirthCountryNodeIdSource	
			if (CanDeepLoad(entity, "GsCountryNode|GsBirthCountryNodeIdSource", deepLoadType, innerList) 
				&& entity.GsBirthCountryNodeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsBirthCountryNodeId ?? 0.0m);
				GsCountryNode tmpEntity = EntityManager.LocateEntity<GsCountryNode>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCountryNode), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsBirthCountryNodeIdSource = tmpEntity;
				else
					entity.GsBirthCountryNodeIdSource = DataRepository.GsCountryNodeProvider.GetByGsCountryNodeId(transactionManager, (entity.GsBirthCountryNodeId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsBirthCountryNodeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsBirthCountryNodeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCountryNodeProvider.DeepLoad(transactionManager, entity.GsBirthCountryNodeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsBirthCountryNodeIdSource

			#region GsCdeMaritalStatusIdSource	
			if (CanDeepLoad(entity, "GsCdeMaritalStatus|GsCdeMaritalStatusIdSource", deepLoadType, innerList) 
				&& entity.GsCdeMaritalStatusIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCdeMaritalStatusId ?? 0.0m);
				GsCdeMaritalStatus tmpEntity = EntityManager.LocateEntity<GsCdeMaritalStatus>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCdeMaritalStatus), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCdeMaritalStatusIdSource = tmpEntity;
				else
					entity.GsCdeMaritalStatusIdSource = DataRepository.GsCdeMaritalStatusProvider.GetByGsCdeMaritalStatusId(transactionManager, (entity.GsCdeMaritalStatusId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCdeMaritalStatusIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCdeMaritalStatusIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCdeMaritalStatusProvider.DeepLoad(transactionManager, entity.GsCdeMaritalStatusIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCdeMaritalStatusIdSource

			#region GsCodeGenderIdSource	
			if (CanDeepLoad(entity, "GsCodeGender|GsCodeGenderIdSource", deepLoadType, innerList) 
				&& entity.GsCodeGenderIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCodeGenderId ?? 0.0m);
				GsCodeGender tmpEntity = EntityManager.LocateEntity<GsCodeGender>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodeGender), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodeGenderIdSource = tmpEntity;
				else
					entity.GsCodeGenderIdSource = DataRepository.GsCodeGenderProvider.GetByGsCodeGenderId(transactionManager, (entity.GsCodeGenderId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodeGenderIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCodeGenderIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodeGenderProvider.DeepLoad(transactionManager, entity.GsCodeGenderIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCodeGenderIdSource

			#region GsCodeReligionIdSource	
			if (CanDeepLoad(entity, "GsCodeReligion|GsCodeReligionIdSource", deepLoadType, innerList) 
				&& entity.GsCodeReligionIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCodeReligionId ?? 0.0m);
				GsCodeReligion tmpEntity = EntityManager.LocateEntity<GsCodeReligion>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodeReligion), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodeReligionIdSource = tmpEntity;
				else
					entity.GsCodeReligionIdSource = DataRepository.GsCodeReligionProvider.GetByGsCodeReligionId(transactionManager, (entity.GsCodeReligionId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodeReligionIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCodeReligionIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodeReligionProvider.DeepLoad(transactionManager, entity.GsCodeReligionIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCodeReligionIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByAdmApplicantId methods when available
			
			#region SvUserMessageCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvUserMessage>|SvUserMessageCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvUserMessageCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvUserMessageCollection = DataRepository.SvUserMessageProvider.GetByAdmApplicantId(transactionManager, entity.AdmApplicantId);

				if (deep && entity.SvUserMessageCollection.Count > 0)
				{
					deepHandles.Add("SvUserMessageCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvUserMessage>) DataRepository.SvUserMessageProvider.DeepLoad,
						new object[] { transactionManager, entity.SvUserMessageCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmAppRegHistoryCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppRegHistory>|AdmAppRegHistoryCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppRegHistoryCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppRegHistoryCollection = DataRepository.AdmAppRegHistoryProvider.GetByAdmApplicantId(transactionManager, entity.AdmApplicantId);

				if (deep && entity.AdmAppRegHistoryCollection.Count > 0)
				{
					deepHandles.Add("AdmAppRegHistoryCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppRegHistory>) DataRepository.AdmAppRegHistoryProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppRegHistoryCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SvSrvyRespondQstnCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvSrvyRespondQstn>|SvSrvyRespondQstnCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvSrvyRespondQstnCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvSrvyRespondQstnCollection = DataRepository.SvSrvyRespondQstnProvider.GetByAdmApplicantId(transactionManager, entity.AdmApplicantId);

				if (deep && entity.SvSrvyRespondQstnCollection.Count > 0)
				{
					deepHandles.Add("SvSrvyRespondQstnCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvSrvyRespondQstn>) DataRepository.SvSrvyRespondQstnProvider.DeepLoad,
						new object[] { transactionManager, entity.SvSrvyRespondQstnCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmScholorshipCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmScholorship>|AdmScholorshipCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmScholorshipCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmScholorshipCollection = DataRepository.AdmScholorshipProvider.GetByAdmApplicantId(transactionManager, entity.AdmApplicantId);

				if (deep && entity.AdmScholorshipCollection.Count > 0)
				{
					deepHandles.Add("AdmScholorshipCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmScholorship>) DataRepository.AdmScholorshipProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmScholorshipCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmOutboxCollectionGetByOutMsgAppFrom
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmOutbox>|AdmOutboxCollectionGetByOutMsgAppFrom", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmOutboxCollectionGetByOutMsgAppFrom' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmOutboxCollectionGetByOutMsgAppFrom = DataRepository.AdmOutboxProvider.GetByOutMsgAppFrom(transactionManager, entity.AdmApplicantId);

				if (deep && entity.AdmOutboxCollectionGetByOutMsgAppFrom.Count > 0)
				{
					deepHandles.Add("AdmOutboxCollectionGetByOutMsgAppFrom",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmOutbox>) DataRepository.AdmOutboxProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmOutboxCollectionGetByOutMsgAppFrom, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudGuardCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudGuard>|EdStudGuardCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudGuardCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudGuardCollection = DataRepository.EdStudGuardProvider.GetByAdmApplicantId(transactionManager, entity.AdmApplicantId);

				if (deep && entity.EdStudGuardCollection.Count > 0)
				{
					deepHandles.Add("EdStudGuardCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudGuard>) DataRepository.EdStudGuardProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudGuardCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeRefndStdReqCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeRefndStdReq>|FeeRefndStdReqCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeRefndStdReqCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeRefndStdReqCollection = DataRepository.FeeRefndStdReqProvider.GetByAdmApplicantId(transactionManager, entity.AdmApplicantId);

				if (deep && entity.FeeRefndStdReqCollection.Count > 0)
				{
					deepHandles.Add("FeeRefndStdReqCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeRefndStdReq>) DataRepository.FeeRefndStdReqProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeRefndStdReqCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmAppPlaceExamCourseCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppPlaceExamCourse>|AdmAppPlaceExamCourseCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppPlaceExamCourseCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppPlaceExamCourseCollection = DataRepository.AdmAppPlaceExamCourseProvider.GetByAdmApplicantId(transactionManager, entity.AdmApplicantId);

				if (deep && entity.AdmAppPlaceExamCourseCollection.Count > 0)
				{
					deepHandles.Add("AdmAppPlaceExamCourseCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppPlaceExamCourse>) DataRepository.AdmAppPlaceExamCourseProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppPlaceExamCourseCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmAppHonorCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppHonor>|AdmAppHonorCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppHonorCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppHonorCollection = DataRepository.AdmAppHonorProvider.GetByAdmApplicantId(transactionManager, entity.AdmApplicantId);

				if (deep && entity.AdmAppHonorCollection.Count > 0)
				{
					deepHandles.Add("AdmAppHonorCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppHonor>) DataRepository.AdmAppHonorProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppHonorCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmAppDocCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppDoc>|AdmAppDocCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppDocCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppDocCollection = DataRepository.AdmAppDocProvider.GetByAdmApplicantId(transactionManager, entity.AdmApplicantId);

				if (deep && entity.AdmAppDocCollection.Count > 0)
				{
					deepHandles.Add("AdmAppDocCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppDoc>) DataRepository.AdmAppDocProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppDocCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudNoteCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudNote>|EdStudNoteCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudNoteCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudNoteCollection = DataRepository.EdStudNoteProvider.GetByAdmApplicantId(transactionManager, entity.AdmApplicantId);

				if (deep && entity.EdStudNoteCollection.Count > 0)
				{
					deepHandles.Add("EdStudNoteCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudNote>) DataRepository.EdStudNoteProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudNoteCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudActivityCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudActivity>|EdStudActivityCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudActivityCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudActivityCollection = DataRepository.EdStudActivityProvider.GetByAdmApplicantId(transactionManager, entity.AdmApplicantId);

				if (deep && entity.EdStudActivityCollection.Count > 0)
				{
					deepHandles.Add("EdStudActivityCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudActivity>) DataRepository.EdStudActivityProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudActivityCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmOutboxCollectionGetByOutMsgAppTo
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmOutbox>|AdmOutboxCollectionGetByOutMsgAppTo", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmOutboxCollectionGetByOutMsgAppTo' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmOutboxCollectionGetByOutMsgAppTo = DataRepository.AdmOutboxProvider.GetByOutMsgAppTo(transactionManager, entity.AdmApplicantId);

				if (deep && entity.AdmOutboxCollectionGetByOutMsgAppTo.Count > 0)
				{
					deepHandles.Add("AdmOutboxCollectionGetByOutMsgAppTo",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmOutbox>) DataRepository.AdmOutboxProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmOutboxCollectionGetByOutMsgAppTo, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmRsrvdCodeCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmRsrvdCode>|AdmRsrvdCodeCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmRsrvdCodeCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmRsrvdCodeCollection = DataRepository.AdmRsrvdCodeProvider.GetByAdmApplicantId(transactionManager, entity.AdmApplicantId);

				if (deep && entity.AdmRsrvdCodeCollection.Count > 0)
				{
					deepHandles.Add("AdmRsrvdCodeCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmRsrvdCode>) DataRepository.AdmRsrvdCodeProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmRsrvdCodeCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SvMessageCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvMessage>|SvMessageCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvMessageCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvMessageCollection = DataRepository.SvMessageProvider.GetByAdmApplicantId(transactionManager, entity.AdmApplicantId);

				if (deep && entity.SvMessageCollection.Count > 0)
				{
					deepHandles.Add("SvMessageCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvMessage>) DataRepository.SvMessageProvider.DeepLoad,
						new object[] { transactionManager, entity.SvMessageCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmAppInfoCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppInfo>|AdmAppInfoCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppInfoCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppInfoCollection = DataRepository.AdmAppInfoProvider.GetByAdmApplicantId(transactionManager, entity.AdmApplicantId);

				if (deep && entity.AdmAppInfoCollection.Count > 0)
				{
					deepHandles.Add("AdmAppInfoCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppInfo>) DataRepository.AdmAppInfoProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppInfoCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmAppCourseCompCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppCourseComp>|AdmAppCourseCompCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppCourseCompCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppCourseCompCollection = DataRepository.AdmAppCourseCompProvider.GetByAdmApplicantId(transactionManager, entity.AdmApplicantId);

				if (deep && entity.AdmAppCourseCompCollection.Count > 0)
				{
					deepHandles.Add("AdmAppCourseCompCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppCourseComp>) DataRepository.AdmAppCourseCompProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppCourseCompCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region GsAddressDtlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GsAddressDtl>|GsAddressDtlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsAddressDtlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GsAddressDtlCollection = DataRepository.GsAddressDtlProvider.GetByAdmApplicantId(transactionManager, entity.AdmApplicantId);

				if (deep && entity.GsAddressDtlCollection.Count > 0)
				{
					deepHandles.Add("GsAddressDtlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GsAddressDtl>) DataRepository.GsAddressDtlProvider.DeepLoad,
						new object[] { transactionManager, entity.GsAddressDtlCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudLangCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudLang>|EdStudLangCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudLangCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudLangCollection = DataRepository.EdStudLangProvider.GetByAdmApplicantId(transactionManager, entity.AdmApplicantId);

				if (deep && entity.EdStudLangCollection.Count > 0)
				{
					deepHandles.Add("EdStudLangCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudLang>) DataRepository.EdStudLangProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudLangCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmAppPrefCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppPref>|AdmAppPrefCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppPrefCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppPrefCollection = DataRepository.AdmAppPrefProvider.GetByAdmApplicantId(transactionManager, entity.AdmApplicantId);

				if (deep && entity.AdmAppPrefCollection.Count > 0)
				{
					deepHandles.Add("AdmAppPrefCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppPref>) DataRepository.AdmAppPrefProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppPrefCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmAppPlacementExamCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppPlacementExam>|AdmAppPlacementExamCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppPlacementExamCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppPlacementExamCollection = DataRepository.AdmAppPlacementExamProvider.GetByAdmApplicantId(transactionManager, entity.AdmApplicantId);

				if (deep && entity.AdmAppPlacementExamCollection.Count > 0)
				{
					deepHandles.Add("AdmAppPlacementExamCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppPlacementExam>) DataRepository.AdmAppPlacementExamProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppPlacementExamCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudQualCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudQual>|EdStudQualCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudQualCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudQualCollection = DataRepository.EdStudQualProvider.GetByAdmApplicantId(transactionManager, entity.AdmApplicantId);

				if (deep && entity.EdStudQualCollection.Count > 0)
				{
					deepHandles.Add("EdStudQualCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudQual>) DataRepository.EdStudQualProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudQualCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmAppGuardianCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppGuardian>|AdmAppGuardianCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppGuardianCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppGuardianCollection = DataRepository.AdmAppGuardianProvider.GetByAdmApplicantId(transactionManager, entity.AdmApplicantId);

				if (deep && entity.AdmAppGuardianCollection.Count > 0)
				{
					deepHandles.Add("AdmAppGuardianCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppGuardian>) DataRepository.AdmAppGuardianProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppGuardianCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeStudVoucherCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeStudVoucher>|FeeStudVoucherCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudVoucherCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeStudVoucherCollection = DataRepository.FeeStudVoucherProvider.GetByAdmApplicantId(transactionManager, entity.AdmApplicantId);

				if (deep && entity.FeeStudVoucherCollection.Count > 0)
				{
					deepHandles.Add("FeeStudVoucherCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudVoucher>) DataRepository.FeeStudVoucherProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudVoucherCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudContactMethodCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudContactMethod>|EdStudContactMethodCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudContactMethodCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudContactMethodCollection = DataRepository.EdStudContactMethodProvider.GetByAdmApplicantId(transactionManager, entity.AdmApplicantId);

				if (deep && entity.EdStudContactMethodCollection.Count > 0)
				{
					deepHandles.Add("EdStudContactMethodCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudContactMethod>) DataRepository.EdStudContactMethodProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudContactMethodCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmInboxCollectionGetByInMsgAppFrom
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmInbox>|AdmInboxCollectionGetByInMsgAppFrom", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmInboxCollectionGetByInMsgAppFrom' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmInboxCollectionGetByInMsgAppFrom = DataRepository.AdmInboxProvider.GetByInMsgAppFrom(transactionManager, entity.AdmApplicantId);

				if (deep && entity.AdmInboxCollectionGetByInMsgAppFrom.Count > 0)
				{
					deepHandles.Add("AdmInboxCollectionGetByInMsgAppFrom",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmInbox>) DataRepository.AdmInboxProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmInboxCollectionGetByInMsgAppFrom, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmAppProcStepsCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppProcSteps>|AdmAppProcStepsCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppProcStepsCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppProcStepsCollection = DataRepository.AdmAppProcStepsProvider.GetByAdmApplicantId(transactionManager, entity.AdmApplicantId);

				if (deep && entity.AdmAppProcStepsCollection.Count > 0)
				{
					deepHandles.Add("AdmAppProcStepsCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppProcSteps>) DataRepository.AdmAppProcStepsProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppProcStepsCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmAppEssayCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppEssay>|AdmAppEssayCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppEssayCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppEssayCollection = DataRepository.AdmAppEssayProvider.GetByAdmApplicantId(transactionManager, entity.AdmApplicantId);

				if (deep && entity.AdmAppEssayCollection.Count > 0)
				{
					deepHandles.Add("AdmAppEssayCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppEssay>) DataRepository.AdmAppEssayProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppEssayCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmAppLanguagesCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppLanguages>|AdmAppLanguagesCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppLanguagesCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppLanguagesCollection = DataRepository.AdmAppLanguagesProvider.GetByAdmApplicantId(transactionManager, entity.AdmApplicantId);

				if (deep && entity.AdmAppLanguagesCollection.Count > 0)
				{
					deepHandles.Add("AdmAppLanguagesCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppLanguages>) DataRepository.AdmAppLanguagesProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppLanguagesCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmAppDisabilityCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppDisability>|AdmAppDisabilityCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppDisabilityCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppDisabilityCollection = DataRepository.AdmAppDisabilityProvider.GetByAdmApplicantId(transactionManager, entity.AdmApplicantId);

				if (deep && entity.AdmAppDisabilityCollection.Count > 0)
				{
					deepHandles.Add("AdmAppDisabilityCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppDisability>) DataRepository.AdmAppDisabilityProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppDisabilityCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmAppMediaCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppMedia>|AdmAppMediaCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppMediaCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppMediaCollection = DataRepository.AdmAppMediaProvider.GetByAdmApplicantId(transactionManager, entity.AdmApplicantId);

				if (deep && entity.AdmAppMediaCollection.Count > 0)
				{
					deepHandles.Add("AdmAppMediaCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppMedia>) DataRepository.AdmAppMediaProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppMediaCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmAppFeesCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppFees>|AdmAppFeesCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppFeesCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppFeesCollection = DataRepository.AdmAppFeesProvider.GetByAdmApplicantId(transactionManager, entity.AdmApplicantId);

				if (deep && entity.AdmAppFeesCollection.Count > 0)
				{
					deepHandles.Add("AdmAppFeesCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppFees>) DataRepository.AdmAppFeesProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppFeesCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmEnglishProficiencyCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmEnglishProficiency>|AdmEnglishProficiencyCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmEnglishProficiencyCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmEnglishProficiencyCollection = DataRepository.AdmEnglishProficiencyProvider.GetByAdmApplicantId(transactionManager, entity.AdmApplicantId);

				if (deep && entity.AdmEnglishProficiencyCollection.Count > 0)
				{
					deepHandles.Add("AdmEnglishProficiencyCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmEnglishProficiency>) DataRepository.AdmEnglishProficiencyProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmEnglishProficiencyCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmInboxCollectionGetByInMsgAppTo
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmInbox>|AdmInboxCollectionGetByInMsgAppTo", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmInboxCollectionGetByInMsgAppTo' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmInboxCollectionGetByInMsgAppTo = DataRepository.AdmInboxProvider.GetByInMsgAppTo(transactionManager, entity.AdmApplicantId);

				if (deep && entity.AdmInboxCollectionGetByInMsgAppTo.Count > 0)
				{
					deepHandles.Add("AdmInboxCollectionGetByInMsgAppTo",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmInbox>) DataRepository.AdmInboxProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmInboxCollectionGetByInMsgAppTo, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmAppWorkExperCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppWorkExper>|AdmAppWorkExperCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppWorkExperCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppWorkExperCollection = DataRepository.AdmAppWorkExperProvider.GetByAdmApplicantId(transactionManager, entity.AdmApplicantId);

				if (deep && entity.AdmAppWorkExperCollection.Count > 0)
				{
					deepHandles.Add("AdmAppWorkExperCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppWorkExper>) DataRepository.AdmAppWorkExperProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppWorkExperCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmAppLtrRecomCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppLtrRecom>|AdmAppLtrRecomCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppLtrRecomCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppLtrRecomCollection = DataRepository.AdmAppLtrRecomProvider.GetByAdmApplicantId(transactionManager, entity.AdmApplicantId);

				if (deep && entity.AdmAppLtrRecomCollection.Count > 0)
				{
					deepHandles.Add("AdmAppLtrRecomCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppLtrRecom>) DataRepository.AdmAppLtrRecomProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppLtrRecomCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AdmApplicant object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AdmApplicant instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmApplicant Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmApplicant entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdCdeSocialAffairIdSource
			if (CanDeepSave(entity, "EdCdeSocialAffair|EdCdeSocialAffairIdSource", deepSaveType, innerList) 
				&& entity.EdCdeSocialAffairIdSource != null)
			{
				DataRepository.EdCdeSocialAffairProvider.Save(transactionManager, entity.EdCdeSocialAffairIdSource);
				entity.EdCdeSocialAffairId = entity.EdCdeSocialAffairIdSource.EdCdeSocialAffairId;
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
			
			#region GsCountryNodeIdSource
			if (CanDeepSave(entity, "GsCountryNode|GsCountryNodeIdSource", deepSaveType, innerList) 
				&& entity.GsCountryNodeIdSource != null)
			{
				DataRepository.GsCountryNodeProvider.Save(transactionManager, entity.GsCountryNodeIdSource);
				entity.GsCountryNodeId = entity.GsCountryNodeIdSource.GsCountryNodeId;
			}
			#endregion 
			
			#region GsBirthCountryNodeIdSource
			if (CanDeepSave(entity, "GsCountryNode|GsBirthCountryNodeIdSource", deepSaveType, innerList) 
				&& entity.GsBirthCountryNodeIdSource != null)
			{
				DataRepository.GsCountryNodeProvider.Save(transactionManager, entity.GsBirthCountryNodeIdSource);
				entity.GsBirthCountryNodeId = entity.GsBirthCountryNodeIdSource.GsCountryNodeId;
			}
			#endregion 
			
			#region GsCdeMaritalStatusIdSource
			if (CanDeepSave(entity, "GsCdeMaritalStatus|GsCdeMaritalStatusIdSource", deepSaveType, innerList) 
				&& entity.GsCdeMaritalStatusIdSource != null)
			{
				DataRepository.GsCdeMaritalStatusProvider.Save(transactionManager, entity.GsCdeMaritalStatusIdSource);
				entity.GsCdeMaritalStatusId = entity.GsCdeMaritalStatusIdSource.GsCdeMaritalStatusId;
			}
			#endregion 
			
			#region GsCodeGenderIdSource
			if (CanDeepSave(entity, "GsCodeGender|GsCodeGenderIdSource", deepSaveType, innerList) 
				&& entity.GsCodeGenderIdSource != null)
			{
				DataRepository.GsCodeGenderProvider.Save(transactionManager, entity.GsCodeGenderIdSource);
				entity.GsCodeGenderId = entity.GsCodeGenderIdSource.GsCodeGenderId;
			}
			#endregion 
			
			#region GsCodeReligionIdSource
			if (CanDeepSave(entity, "GsCodeReligion|GsCodeReligionIdSource", deepSaveType, innerList) 
				&& entity.GsCodeReligionIdSource != null)
			{
				DataRepository.GsCodeReligionProvider.Save(transactionManager, entity.GsCodeReligionIdSource);
				entity.GsCodeReligionId = entity.GsCodeReligionIdSource.GsCodeReligionId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<SvUserMessage>
				if (CanDeepSave(entity.SvUserMessageCollection, "List<SvUserMessage>|SvUserMessageCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvUserMessage child in entity.SvUserMessageCollection)
					{
						if(child.AdmApplicantIdSource != null)
						{
							child.AdmApplicantId = child.AdmApplicantIdSource.AdmApplicantId;
						}
						else
						{
							child.AdmApplicantId = entity.AdmApplicantId;
						}

					}

					if (entity.SvUserMessageCollection.Count > 0 || entity.SvUserMessageCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvUserMessageProvider.Save(transactionManager, entity.SvUserMessageCollection);
						
						deepHandles.Add("SvUserMessageCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvUserMessage >) DataRepository.SvUserMessageProvider.DeepSave,
							new object[] { transactionManager, entity.SvUserMessageCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmAppRegHistory>
				if (CanDeepSave(entity.AdmAppRegHistoryCollection, "List<AdmAppRegHistory>|AdmAppRegHistoryCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppRegHistory child in entity.AdmAppRegHistoryCollection)
					{
						if(child.AdmApplicantIdSource != null)
						{
							child.AdmApplicantId = child.AdmApplicantIdSource.AdmApplicantId;
						}
						else
						{
							child.AdmApplicantId = entity.AdmApplicantId;
						}

					}

					if (entity.AdmAppRegHistoryCollection.Count > 0 || entity.AdmAppRegHistoryCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppRegHistoryProvider.Save(transactionManager, entity.AdmAppRegHistoryCollection);
						
						deepHandles.Add("AdmAppRegHistoryCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppRegHistory >) DataRepository.AdmAppRegHistoryProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppRegHistoryCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SvSrvyRespondQstn>
				if (CanDeepSave(entity.SvSrvyRespondQstnCollection, "List<SvSrvyRespondQstn>|SvSrvyRespondQstnCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvSrvyRespondQstn child in entity.SvSrvyRespondQstnCollection)
					{
						if(child.AdmApplicantIdSource != null)
						{
							child.AdmApplicantId = child.AdmApplicantIdSource.AdmApplicantId;
						}
						else
						{
							child.AdmApplicantId = entity.AdmApplicantId;
						}

					}

					if (entity.SvSrvyRespondQstnCollection.Count > 0 || entity.SvSrvyRespondQstnCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvSrvyRespondQstnProvider.Save(transactionManager, entity.SvSrvyRespondQstnCollection);
						
						deepHandles.Add("SvSrvyRespondQstnCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvSrvyRespondQstn >) DataRepository.SvSrvyRespondQstnProvider.DeepSave,
							new object[] { transactionManager, entity.SvSrvyRespondQstnCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmScholorship>
				if (CanDeepSave(entity.AdmScholorshipCollection, "List<AdmScholorship>|AdmScholorshipCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmScholorship child in entity.AdmScholorshipCollection)
					{
						if(child.AdmApplicantIdSource != null)
						{
							child.AdmApplicantId = child.AdmApplicantIdSource.AdmApplicantId;
						}
						else
						{
							child.AdmApplicantId = entity.AdmApplicantId;
						}

					}

					if (entity.AdmScholorshipCollection.Count > 0 || entity.AdmScholorshipCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmScholorshipProvider.Save(transactionManager, entity.AdmScholorshipCollection);
						
						deepHandles.Add("AdmScholorshipCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmScholorship >) DataRepository.AdmScholorshipProvider.DeepSave,
							new object[] { transactionManager, entity.AdmScholorshipCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmOutbox>
				if (CanDeepSave(entity.AdmOutboxCollectionGetByOutMsgAppFrom, "List<AdmOutbox>|AdmOutboxCollectionGetByOutMsgAppFrom", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmOutbox child in entity.AdmOutboxCollectionGetByOutMsgAppFrom)
					{
						if(child.OutMsgAppFromSource != null)
						{
							child.OutMsgAppFrom = child.OutMsgAppFromSource.AdmApplicantId;
						}
						else
						{
							child.OutMsgAppFrom = entity.AdmApplicantId;
						}

					}

					if (entity.AdmOutboxCollectionGetByOutMsgAppFrom.Count > 0 || entity.AdmOutboxCollectionGetByOutMsgAppFrom.DeletedItems.Count > 0)
					{
						//DataRepository.AdmOutboxProvider.Save(transactionManager, entity.AdmOutboxCollectionGetByOutMsgAppFrom);
						
						deepHandles.Add("AdmOutboxCollectionGetByOutMsgAppFrom",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmOutbox >) DataRepository.AdmOutboxProvider.DeepSave,
							new object[] { transactionManager, entity.AdmOutboxCollectionGetByOutMsgAppFrom, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudGuard>
				if (CanDeepSave(entity.EdStudGuardCollection, "List<EdStudGuard>|EdStudGuardCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudGuard child in entity.EdStudGuardCollection)
					{
						if(child.AdmApplicantIdSource != null)
						{
							child.AdmApplicantId = child.AdmApplicantIdSource.AdmApplicantId;
						}
						else
						{
							child.AdmApplicantId = entity.AdmApplicantId;
						}

					}

					if (entity.EdStudGuardCollection.Count > 0 || entity.EdStudGuardCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudGuardProvider.Save(transactionManager, entity.EdStudGuardCollection);
						
						deepHandles.Add("EdStudGuardCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudGuard >) DataRepository.EdStudGuardProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudGuardCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeRefndStdReq>
				if (CanDeepSave(entity.FeeRefndStdReqCollection, "List<FeeRefndStdReq>|FeeRefndStdReqCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeRefndStdReq child in entity.FeeRefndStdReqCollection)
					{
						if(child.AdmApplicantIdSource != null)
						{
							child.AdmApplicantId = child.AdmApplicantIdSource.AdmApplicantId;
						}
						else
						{
							child.AdmApplicantId = entity.AdmApplicantId;
						}

					}

					if (entity.FeeRefndStdReqCollection.Count > 0 || entity.FeeRefndStdReqCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeRefndStdReqProvider.Save(transactionManager, entity.FeeRefndStdReqCollection);
						
						deepHandles.Add("FeeRefndStdReqCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeRefndStdReq >) DataRepository.FeeRefndStdReqProvider.DeepSave,
							new object[] { transactionManager, entity.FeeRefndStdReqCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmAppPlaceExamCourse>
				if (CanDeepSave(entity.AdmAppPlaceExamCourseCollection, "List<AdmAppPlaceExamCourse>|AdmAppPlaceExamCourseCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppPlaceExamCourse child in entity.AdmAppPlaceExamCourseCollection)
					{
						if(child.AdmApplicantIdSource != null)
						{
							child.AdmApplicantId = child.AdmApplicantIdSource.AdmApplicantId;
						}
						else
						{
							child.AdmApplicantId = entity.AdmApplicantId;
						}

					}

					if (entity.AdmAppPlaceExamCourseCollection.Count > 0 || entity.AdmAppPlaceExamCourseCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppPlaceExamCourseProvider.Save(transactionManager, entity.AdmAppPlaceExamCourseCollection);
						
						deepHandles.Add("AdmAppPlaceExamCourseCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppPlaceExamCourse >) DataRepository.AdmAppPlaceExamCourseProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppPlaceExamCourseCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmAppHonor>
				if (CanDeepSave(entity.AdmAppHonorCollection, "List<AdmAppHonor>|AdmAppHonorCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppHonor child in entity.AdmAppHonorCollection)
					{
						if(child.AdmApplicantIdSource != null)
						{
							child.AdmApplicantId = child.AdmApplicantIdSource.AdmApplicantId;
						}
						else
						{
							child.AdmApplicantId = entity.AdmApplicantId;
						}

					}

					if (entity.AdmAppHonorCollection.Count > 0 || entity.AdmAppHonorCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppHonorProvider.Save(transactionManager, entity.AdmAppHonorCollection);
						
						deepHandles.Add("AdmAppHonorCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppHonor >) DataRepository.AdmAppHonorProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppHonorCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmAppDoc>
				if (CanDeepSave(entity.AdmAppDocCollection, "List<AdmAppDoc>|AdmAppDocCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppDoc child in entity.AdmAppDocCollection)
					{
						if(child.AdmApplicantIdSource != null)
						{
							child.AdmApplicantId = child.AdmApplicantIdSource.AdmApplicantId;
						}
						else
						{
							child.AdmApplicantId = entity.AdmApplicantId;
						}

					}

					if (entity.AdmAppDocCollection.Count > 0 || entity.AdmAppDocCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppDocProvider.Save(transactionManager, entity.AdmAppDocCollection);
						
						deepHandles.Add("AdmAppDocCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppDoc >) DataRepository.AdmAppDocProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppDocCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudNote>
				if (CanDeepSave(entity.EdStudNoteCollection, "List<EdStudNote>|EdStudNoteCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudNote child in entity.EdStudNoteCollection)
					{
						if(child.AdmApplicantIdSource != null)
						{
							child.AdmApplicantId = child.AdmApplicantIdSource.AdmApplicantId;
						}
						else
						{
							child.AdmApplicantId = entity.AdmApplicantId;
						}

					}

					if (entity.EdStudNoteCollection.Count > 0 || entity.EdStudNoteCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudNoteProvider.Save(transactionManager, entity.EdStudNoteCollection);
						
						deepHandles.Add("EdStudNoteCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudNote >) DataRepository.EdStudNoteProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudNoteCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudActivity>
				if (CanDeepSave(entity.EdStudActivityCollection, "List<EdStudActivity>|EdStudActivityCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudActivity child in entity.EdStudActivityCollection)
					{
						if(child.AdmApplicantIdSource != null)
						{
							child.AdmApplicantId = child.AdmApplicantIdSource.AdmApplicantId;
						}
						else
						{
							child.AdmApplicantId = entity.AdmApplicantId;
						}

					}

					if (entity.EdStudActivityCollection.Count > 0 || entity.EdStudActivityCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudActivityProvider.Save(transactionManager, entity.EdStudActivityCollection);
						
						deepHandles.Add("EdStudActivityCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudActivity >) DataRepository.EdStudActivityProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudActivityCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmOutbox>
				if (CanDeepSave(entity.AdmOutboxCollectionGetByOutMsgAppTo, "List<AdmOutbox>|AdmOutboxCollectionGetByOutMsgAppTo", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmOutbox child in entity.AdmOutboxCollectionGetByOutMsgAppTo)
					{
						if(child.OutMsgAppToSource != null)
						{
							child.OutMsgAppTo = child.OutMsgAppToSource.AdmApplicantId;
						}
						else
						{
							child.OutMsgAppTo = entity.AdmApplicantId;
						}

					}

					if (entity.AdmOutboxCollectionGetByOutMsgAppTo.Count > 0 || entity.AdmOutboxCollectionGetByOutMsgAppTo.DeletedItems.Count > 0)
					{
						//DataRepository.AdmOutboxProvider.Save(transactionManager, entity.AdmOutboxCollectionGetByOutMsgAppTo);
						
						deepHandles.Add("AdmOutboxCollectionGetByOutMsgAppTo",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmOutbox >) DataRepository.AdmOutboxProvider.DeepSave,
							new object[] { transactionManager, entity.AdmOutboxCollectionGetByOutMsgAppTo, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmRsrvdCode>
				if (CanDeepSave(entity.AdmRsrvdCodeCollection, "List<AdmRsrvdCode>|AdmRsrvdCodeCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmRsrvdCode child in entity.AdmRsrvdCodeCollection)
					{
						if(child.AdmApplicantIdSource != null)
						{
							child.AdmApplicantId = child.AdmApplicantIdSource.AdmApplicantId;
						}
						else
						{
							child.AdmApplicantId = entity.AdmApplicantId;
						}

					}

					if (entity.AdmRsrvdCodeCollection.Count > 0 || entity.AdmRsrvdCodeCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmRsrvdCodeProvider.Save(transactionManager, entity.AdmRsrvdCodeCollection);
						
						deepHandles.Add("AdmRsrvdCodeCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmRsrvdCode >) DataRepository.AdmRsrvdCodeProvider.DeepSave,
							new object[] { transactionManager, entity.AdmRsrvdCodeCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SvMessage>
				if (CanDeepSave(entity.SvMessageCollection, "List<SvMessage>|SvMessageCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvMessage child in entity.SvMessageCollection)
					{
						if(child.AdmApplicantIdSource != null)
						{
							child.AdmApplicantId = child.AdmApplicantIdSource.AdmApplicantId;
						}
						else
						{
							child.AdmApplicantId = entity.AdmApplicantId;
						}

					}

					if (entity.SvMessageCollection.Count > 0 || entity.SvMessageCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvMessageProvider.Save(transactionManager, entity.SvMessageCollection);
						
						deepHandles.Add("SvMessageCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvMessage >) DataRepository.SvMessageProvider.DeepSave,
							new object[] { transactionManager, entity.SvMessageCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmAppInfo>
				if (CanDeepSave(entity.AdmAppInfoCollection, "List<AdmAppInfo>|AdmAppInfoCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppInfo child in entity.AdmAppInfoCollection)
					{
						if(child.AdmApplicantIdSource != null)
						{
							child.AdmApplicantId = child.AdmApplicantIdSource.AdmApplicantId;
						}
						else
						{
							child.AdmApplicantId = entity.AdmApplicantId;
						}

					}

					if (entity.AdmAppInfoCollection.Count > 0 || entity.AdmAppInfoCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppInfoProvider.Save(transactionManager, entity.AdmAppInfoCollection);
						
						deepHandles.Add("AdmAppInfoCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppInfo >) DataRepository.AdmAppInfoProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppInfoCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmAppCourseComp>
				if (CanDeepSave(entity.AdmAppCourseCompCollection, "List<AdmAppCourseComp>|AdmAppCourseCompCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppCourseComp child in entity.AdmAppCourseCompCollection)
					{
						if(child.AdmApplicantIdSource != null)
						{
							child.AdmApplicantId = child.AdmApplicantIdSource.AdmApplicantId;
						}
						else
						{
							child.AdmApplicantId = entity.AdmApplicantId;
						}

					}

					if (entity.AdmAppCourseCompCollection.Count > 0 || entity.AdmAppCourseCompCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppCourseCompProvider.Save(transactionManager, entity.AdmAppCourseCompCollection);
						
						deepHandles.Add("AdmAppCourseCompCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppCourseComp >) DataRepository.AdmAppCourseCompProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppCourseCompCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<GsAddressDtl>
				if (CanDeepSave(entity.GsAddressDtlCollection, "List<GsAddressDtl>|GsAddressDtlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GsAddressDtl child in entity.GsAddressDtlCollection)
					{
						if(child.AdmApplicantIdSource != null)
						{
							child.AdmApplicantId = child.AdmApplicantIdSource.AdmApplicantId;
						}
						else
						{
							child.AdmApplicantId = entity.AdmApplicantId;
						}

					}

					if (entity.GsAddressDtlCollection.Count > 0 || entity.GsAddressDtlCollection.DeletedItems.Count > 0)
					{
						//DataRepository.GsAddressDtlProvider.Save(transactionManager, entity.GsAddressDtlCollection);
						
						deepHandles.Add("GsAddressDtlCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< GsAddressDtl >) DataRepository.GsAddressDtlProvider.DeepSave,
							new object[] { transactionManager, entity.GsAddressDtlCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudLang>
				if (CanDeepSave(entity.EdStudLangCollection, "List<EdStudLang>|EdStudLangCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudLang child in entity.EdStudLangCollection)
					{
						if(child.AdmApplicantIdSource != null)
						{
							child.AdmApplicantId = child.AdmApplicantIdSource.AdmApplicantId;
						}
						else
						{
							child.AdmApplicantId = entity.AdmApplicantId;
						}

					}

					if (entity.EdStudLangCollection.Count > 0 || entity.EdStudLangCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudLangProvider.Save(transactionManager, entity.EdStudLangCollection);
						
						deepHandles.Add("EdStudLangCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudLang >) DataRepository.EdStudLangProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudLangCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmAppPref>
				if (CanDeepSave(entity.AdmAppPrefCollection, "List<AdmAppPref>|AdmAppPrefCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppPref child in entity.AdmAppPrefCollection)
					{
						if(child.AdmApplicantIdSource != null)
						{
							child.AdmApplicantId = child.AdmApplicantIdSource.AdmApplicantId;
						}
						else
						{
							child.AdmApplicantId = entity.AdmApplicantId;
						}

					}

					if (entity.AdmAppPrefCollection.Count > 0 || entity.AdmAppPrefCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppPrefProvider.Save(transactionManager, entity.AdmAppPrefCollection);
						
						deepHandles.Add("AdmAppPrefCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppPref >) DataRepository.AdmAppPrefProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppPrefCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmAppPlacementExam>
				if (CanDeepSave(entity.AdmAppPlacementExamCollection, "List<AdmAppPlacementExam>|AdmAppPlacementExamCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppPlacementExam child in entity.AdmAppPlacementExamCollection)
					{
						if(child.AdmApplicantIdSource != null)
						{
							child.AdmApplicantId = child.AdmApplicantIdSource.AdmApplicantId;
						}
						else
						{
							child.AdmApplicantId = entity.AdmApplicantId;
						}

					}

					if (entity.AdmAppPlacementExamCollection.Count > 0 || entity.AdmAppPlacementExamCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppPlacementExamProvider.Save(transactionManager, entity.AdmAppPlacementExamCollection);
						
						deepHandles.Add("AdmAppPlacementExamCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppPlacementExam >) DataRepository.AdmAppPlacementExamProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppPlacementExamCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudQual>
				if (CanDeepSave(entity.EdStudQualCollection, "List<EdStudQual>|EdStudQualCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudQual child in entity.EdStudQualCollection)
					{
						if(child.AdmApplicantIdSource != null)
						{
							child.AdmApplicantId = child.AdmApplicantIdSource.AdmApplicantId;
						}
						else
						{
							child.AdmApplicantId = entity.AdmApplicantId;
						}

					}

					if (entity.EdStudQualCollection.Count > 0 || entity.EdStudQualCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudQualProvider.Save(transactionManager, entity.EdStudQualCollection);
						
						deepHandles.Add("EdStudQualCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudQual >) DataRepository.EdStudQualProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudQualCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmAppGuardian>
				if (CanDeepSave(entity.AdmAppGuardianCollection, "List<AdmAppGuardian>|AdmAppGuardianCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppGuardian child in entity.AdmAppGuardianCollection)
					{
						if(child.AdmApplicantIdSource != null)
						{
							child.AdmApplicantId = child.AdmApplicantIdSource.AdmApplicantId;
						}
						else
						{
							child.AdmApplicantId = entity.AdmApplicantId;
						}

					}

					if (entity.AdmAppGuardianCollection.Count > 0 || entity.AdmAppGuardianCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppGuardianProvider.Save(transactionManager, entity.AdmAppGuardianCollection);
						
						deepHandles.Add("AdmAppGuardianCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppGuardian >) DataRepository.AdmAppGuardianProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppGuardianCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeStudVoucher>
				if (CanDeepSave(entity.FeeStudVoucherCollection, "List<FeeStudVoucher>|FeeStudVoucherCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeStudVoucher child in entity.FeeStudVoucherCollection)
					{
						if(child.AdmApplicantIdSource != null)
						{
							child.AdmApplicantId = child.AdmApplicantIdSource.AdmApplicantId;
						}
						else
						{
							child.AdmApplicantId = entity.AdmApplicantId;
						}

					}

					if (entity.FeeStudVoucherCollection.Count > 0 || entity.FeeStudVoucherCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeStudVoucherProvider.Save(transactionManager, entity.FeeStudVoucherCollection);
						
						deepHandles.Add("FeeStudVoucherCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeStudVoucher >) DataRepository.FeeStudVoucherProvider.DeepSave,
							new object[] { transactionManager, entity.FeeStudVoucherCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudContactMethod>
				if (CanDeepSave(entity.EdStudContactMethodCollection, "List<EdStudContactMethod>|EdStudContactMethodCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudContactMethod child in entity.EdStudContactMethodCollection)
					{
						if(child.AdmApplicantIdSource != null)
						{
							child.AdmApplicantId = child.AdmApplicantIdSource.AdmApplicantId;
						}
						else
						{
							child.AdmApplicantId = entity.AdmApplicantId;
						}

					}

					if (entity.EdStudContactMethodCollection.Count > 0 || entity.EdStudContactMethodCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudContactMethodProvider.Save(transactionManager, entity.EdStudContactMethodCollection);
						
						deepHandles.Add("EdStudContactMethodCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudContactMethod >) DataRepository.EdStudContactMethodProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudContactMethodCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmInbox>
				if (CanDeepSave(entity.AdmInboxCollectionGetByInMsgAppFrom, "List<AdmInbox>|AdmInboxCollectionGetByInMsgAppFrom", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmInbox child in entity.AdmInboxCollectionGetByInMsgAppFrom)
					{
						if(child.InMsgAppFromSource != null)
						{
							child.InMsgAppFrom = child.InMsgAppFromSource.AdmApplicantId;
						}
						else
						{
							child.InMsgAppFrom = entity.AdmApplicantId;
						}

					}

					if (entity.AdmInboxCollectionGetByInMsgAppFrom.Count > 0 || entity.AdmInboxCollectionGetByInMsgAppFrom.DeletedItems.Count > 0)
					{
						//DataRepository.AdmInboxProvider.Save(transactionManager, entity.AdmInboxCollectionGetByInMsgAppFrom);
						
						deepHandles.Add("AdmInboxCollectionGetByInMsgAppFrom",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmInbox >) DataRepository.AdmInboxProvider.DeepSave,
							new object[] { transactionManager, entity.AdmInboxCollectionGetByInMsgAppFrom, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmAppProcSteps>
				if (CanDeepSave(entity.AdmAppProcStepsCollection, "List<AdmAppProcSteps>|AdmAppProcStepsCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppProcSteps child in entity.AdmAppProcStepsCollection)
					{
						if(child.AdmApplicantIdSource != null)
						{
							child.AdmApplicantId = child.AdmApplicantIdSource.AdmApplicantId;
						}
						else
						{
							child.AdmApplicantId = entity.AdmApplicantId;
						}

					}

					if (entity.AdmAppProcStepsCollection.Count > 0 || entity.AdmAppProcStepsCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppProcStepsProvider.Save(transactionManager, entity.AdmAppProcStepsCollection);
						
						deepHandles.Add("AdmAppProcStepsCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppProcSteps >) DataRepository.AdmAppProcStepsProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppProcStepsCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmAppEssay>
				if (CanDeepSave(entity.AdmAppEssayCollection, "List<AdmAppEssay>|AdmAppEssayCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppEssay child in entity.AdmAppEssayCollection)
					{
						if(child.AdmApplicantIdSource != null)
						{
							child.AdmApplicantId = child.AdmApplicantIdSource.AdmApplicantId;
						}
						else
						{
							child.AdmApplicantId = entity.AdmApplicantId;
						}

					}

					if (entity.AdmAppEssayCollection.Count > 0 || entity.AdmAppEssayCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppEssayProvider.Save(transactionManager, entity.AdmAppEssayCollection);
						
						deepHandles.Add("AdmAppEssayCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppEssay >) DataRepository.AdmAppEssayProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppEssayCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmAppLanguages>
				if (CanDeepSave(entity.AdmAppLanguagesCollection, "List<AdmAppLanguages>|AdmAppLanguagesCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppLanguages child in entity.AdmAppLanguagesCollection)
					{
						if(child.AdmApplicantIdSource != null)
						{
							child.AdmApplicantId = child.AdmApplicantIdSource.AdmApplicantId;
						}
						else
						{
							child.AdmApplicantId = entity.AdmApplicantId;
						}

					}

					if (entity.AdmAppLanguagesCollection.Count > 0 || entity.AdmAppLanguagesCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppLanguagesProvider.Save(transactionManager, entity.AdmAppLanguagesCollection);
						
						deepHandles.Add("AdmAppLanguagesCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppLanguages >) DataRepository.AdmAppLanguagesProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppLanguagesCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmAppDisability>
				if (CanDeepSave(entity.AdmAppDisabilityCollection, "List<AdmAppDisability>|AdmAppDisabilityCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppDisability child in entity.AdmAppDisabilityCollection)
					{
						if(child.AdmApplicantIdSource != null)
						{
							child.AdmApplicantId = child.AdmApplicantIdSource.AdmApplicantId;
						}
						else
						{
							child.AdmApplicantId = entity.AdmApplicantId;
						}

					}

					if (entity.AdmAppDisabilityCollection.Count > 0 || entity.AdmAppDisabilityCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppDisabilityProvider.Save(transactionManager, entity.AdmAppDisabilityCollection);
						
						deepHandles.Add("AdmAppDisabilityCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppDisability >) DataRepository.AdmAppDisabilityProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppDisabilityCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmAppMedia>
				if (CanDeepSave(entity.AdmAppMediaCollection, "List<AdmAppMedia>|AdmAppMediaCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppMedia child in entity.AdmAppMediaCollection)
					{
						if(child.AdmApplicantIdSource != null)
						{
							child.AdmApplicantId = child.AdmApplicantIdSource.AdmApplicantId;
						}
						else
						{
							child.AdmApplicantId = entity.AdmApplicantId;
						}

					}

					if (entity.AdmAppMediaCollection.Count > 0 || entity.AdmAppMediaCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppMediaProvider.Save(transactionManager, entity.AdmAppMediaCollection);
						
						deepHandles.Add("AdmAppMediaCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppMedia >) DataRepository.AdmAppMediaProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppMediaCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmAppFees>
				if (CanDeepSave(entity.AdmAppFeesCollection, "List<AdmAppFees>|AdmAppFeesCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppFees child in entity.AdmAppFeesCollection)
					{
						if(child.AdmApplicantIdSource != null)
						{
							child.AdmApplicantId = child.AdmApplicantIdSource.AdmApplicantId;
						}
						else
						{
							child.AdmApplicantId = entity.AdmApplicantId;
						}

					}

					if (entity.AdmAppFeesCollection.Count > 0 || entity.AdmAppFeesCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppFeesProvider.Save(transactionManager, entity.AdmAppFeesCollection);
						
						deepHandles.Add("AdmAppFeesCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppFees >) DataRepository.AdmAppFeesProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppFeesCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmEnglishProficiency>
				if (CanDeepSave(entity.AdmEnglishProficiencyCollection, "List<AdmEnglishProficiency>|AdmEnglishProficiencyCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmEnglishProficiency child in entity.AdmEnglishProficiencyCollection)
					{
						if(child.AdmApplicantIdSource != null)
						{
							child.AdmApplicantId = child.AdmApplicantIdSource.AdmApplicantId;
						}
						else
						{
							child.AdmApplicantId = entity.AdmApplicantId;
						}

					}

					if (entity.AdmEnglishProficiencyCollection.Count > 0 || entity.AdmEnglishProficiencyCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmEnglishProficiencyProvider.Save(transactionManager, entity.AdmEnglishProficiencyCollection);
						
						deepHandles.Add("AdmEnglishProficiencyCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmEnglishProficiency >) DataRepository.AdmEnglishProficiencyProvider.DeepSave,
							new object[] { transactionManager, entity.AdmEnglishProficiencyCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmInbox>
				if (CanDeepSave(entity.AdmInboxCollectionGetByInMsgAppTo, "List<AdmInbox>|AdmInboxCollectionGetByInMsgAppTo", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmInbox child in entity.AdmInboxCollectionGetByInMsgAppTo)
					{
						if(child.InMsgAppToSource != null)
						{
							child.InMsgAppTo = child.InMsgAppToSource.AdmApplicantId;
						}
						else
						{
							child.InMsgAppTo = entity.AdmApplicantId;
						}

					}

					if (entity.AdmInboxCollectionGetByInMsgAppTo.Count > 0 || entity.AdmInboxCollectionGetByInMsgAppTo.DeletedItems.Count > 0)
					{
						//DataRepository.AdmInboxProvider.Save(transactionManager, entity.AdmInboxCollectionGetByInMsgAppTo);
						
						deepHandles.Add("AdmInboxCollectionGetByInMsgAppTo",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmInbox >) DataRepository.AdmInboxProvider.DeepSave,
							new object[] { transactionManager, entity.AdmInboxCollectionGetByInMsgAppTo, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmAppWorkExper>
				if (CanDeepSave(entity.AdmAppWorkExperCollection, "List<AdmAppWorkExper>|AdmAppWorkExperCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppWorkExper child in entity.AdmAppWorkExperCollection)
					{
						if(child.AdmApplicantIdSource != null)
						{
							child.AdmApplicantId = child.AdmApplicantIdSource.AdmApplicantId;
						}
						else
						{
							child.AdmApplicantId = entity.AdmApplicantId;
						}

					}

					if (entity.AdmAppWorkExperCollection.Count > 0 || entity.AdmAppWorkExperCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppWorkExperProvider.Save(transactionManager, entity.AdmAppWorkExperCollection);
						
						deepHandles.Add("AdmAppWorkExperCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppWorkExper >) DataRepository.AdmAppWorkExperProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppWorkExperCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmAppLtrRecom>
				if (CanDeepSave(entity.AdmAppLtrRecomCollection, "List<AdmAppLtrRecom>|AdmAppLtrRecomCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppLtrRecom child in entity.AdmAppLtrRecomCollection)
					{
						if(child.AdmApplicantIdSource != null)
						{
							child.AdmApplicantId = child.AdmApplicantIdSource.AdmApplicantId;
						}
						else
						{
							child.AdmApplicantId = entity.AdmApplicantId;
						}

					}

					if (entity.AdmAppLtrRecomCollection.Count > 0 || entity.AdmAppLtrRecomCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppLtrRecomProvider.Save(transactionManager, entity.AdmAppLtrRecomCollection);
						
						deepHandles.Add("AdmAppLtrRecomCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppLtrRecom >) DataRepository.AdmAppLtrRecomProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppLtrRecomCollection, deepSaveType, childTypes, innerList }
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
	
	#region AdmApplicantChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AdmApplicant</c>
	///</summary>
	public enum AdmApplicantChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdCdeSocialAffair</c> at EdCdeSocialAffairIdSource
		///</summary>
		[ChildEntityType(typeof(EdCdeSocialAffair))]
		EdCdeSocialAffair,
		
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
		/// Composite Property for <c>GsCountryNode</c> at GsCountryNodeIdSource
		///</summary>
		[ChildEntityType(typeof(GsCountryNode))]
		GsCountryNode,
		
		///<summary>
		/// Composite Property for <c>GsCdeMaritalStatus</c> at GsCdeMaritalStatusIdSource
		///</summary>
		[ChildEntityType(typeof(GsCdeMaritalStatus))]
		GsCdeMaritalStatus,
		
		///<summary>
		/// Composite Property for <c>GsCodeGender</c> at GsCodeGenderIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeGender))]
		GsCodeGender,
		
		///<summary>
		/// Composite Property for <c>GsCodeReligion</c> at GsCodeReligionIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeReligion))]
		GsCodeReligion,
		///<summary>
		/// Collection of <c>AdmApplicant</c> as OneToMany for SvUserMessageCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvUserMessage>))]
		SvUserMessageCollection,
		///<summary>
		/// Collection of <c>AdmApplicant</c> as OneToMany for AdmAppRegHistoryCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppRegHistory>))]
		AdmAppRegHistoryCollection,
		///<summary>
		/// Collection of <c>AdmApplicant</c> as OneToMany for SvSrvyRespondQstnCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvSrvyRespondQstn>))]
		SvSrvyRespondQstnCollection,
		///<summary>
		/// Collection of <c>AdmApplicant</c> as OneToMany for AdmScholorshipCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmScholorship>))]
		AdmScholorshipCollection,
		///<summary>
		/// Collection of <c>AdmApplicant</c> as OneToMany for AdmOutboxCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmOutbox>))]
		AdmOutboxCollectionGetByOutMsgAppFrom,
		///<summary>
		/// Collection of <c>AdmApplicant</c> as OneToMany for EdStudGuardCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudGuard>))]
		EdStudGuardCollection,
		///<summary>
		/// Collection of <c>AdmApplicant</c> as OneToMany for FeeRefndStdReqCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeRefndStdReq>))]
		FeeRefndStdReqCollection,
		///<summary>
		/// Collection of <c>AdmApplicant</c> as OneToMany for AdmAppPlaceExamCourseCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppPlaceExamCourse>))]
		AdmAppPlaceExamCourseCollection,
		///<summary>
		/// Collection of <c>AdmApplicant</c> as OneToMany for AdmAppHonorCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppHonor>))]
		AdmAppHonorCollection,
		///<summary>
		/// Collection of <c>AdmApplicant</c> as OneToMany for AdmAppDocCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppDoc>))]
		AdmAppDocCollection,
		///<summary>
		/// Collection of <c>AdmApplicant</c> as OneToMany for EdStudNoteCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudNote>))]
		EdStudNoteCollection,
		///<summary>
		/// Collection of <c>AdmApplicant</c> as OneToMany for EdStudActivityCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudActivity>))]
		EdStudActivityCollection,
		///<summary>
		/// Collection of <c>AdmApplicant</c> as OneToMany for AdmOutboxCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmOutbox>))]
		AdmOutboxCollectionGetByOutMsgAppTo,
		///<summary>
		/// Collection of <c>AdmApplicant</c> as OneToMany for AdmRsrvdCodeCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmRsrvdCode>))]
		AdmRsrvdCodeCollection,
		///<summary>
		/// Collection of <c>AdmApplicant</c> as OneToMany for SvMessageCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvMessage>))]
		SvMessageCollection,
		///<summary>
		/// Collection of <c>AdmApplicant</c> as OneToMany for AdmAppInfoCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppInfo>))]
		AdmAppInfoCollection,
		///<summary>
		/// Collection of <c>AdmApplicant</c> as OneToMany for AdmAppCourseCompCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppCourseComp>))]
		AdmAppCourseCompCollection,
		///<summary>
		/// Collection of <c>AdmApplicant</c> as OneToMany for GsAddressDtlCollection
		///</summary>
		[ChildEntityType(typeof(TList<GsAddressDtl>))]
		GsAddressDtlCollection,
		///<summary>
		/// Collection of <c>AdmApplicant</c> as OneToMany for EdStudLangCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudLang>))]
		EdStudLangCollection,
		///<summary>
		/// Collection of <c>AdmApplicant</c> as OneToMany for AdmAppPrefCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppPref>))]
		AdmAppPrefCollection,
		///<summary>
		/// Collection of <c>AdmApplicant</c> as OneToMany for AdmAppPlacementExamCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppPlacementExam>))]
		AdmAppPlacementExamCollection,
		///<summary>
		/// Collection of <c>AdmApplicant</c> as OneToMany for EdStudQualCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudQual>))]
		EdStudQualCollection,
		///<summary>
		/// Collection of <c>AdmApplicant</c> as OneToMany for AdmAppGuardianCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppGuardian>))]
		AdmAppGuardianCollection,
		///<summary>
		/// Collection of <c>AdmApplicant</c> as OneToMany for FeeStudVoucherCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudVoucher>))]
		FeeStudVoucherCollection,
		///<summary>
		/// Collection of <c>AdmApplicant</c> as OneToMany for EdStudContactMethodCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudContactMethod>))]
		EdStudContactMethodCollection,
		///<summary>
		/// Collection of <c>AdmApplicant</c> as OneToMany for AdmInboxCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmInbox>))]
		AdmInboxCollectionGetByInMsgAppFrom,
		///<summary>
		/// Collection of <c>AdmApplicant</c> as OneToMany for AdmAppProcStepsCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppProcSteps>))]
		AdmAppProcStepsCollection,
		///<summary>
		/// Collection of <c>AdmApplicant</c> as OneToMany for AdmAppEssayCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppEssay>))]
		AdmAppEssayCollection,
		///<summary>
		/// Collection of <c>AdmApplicant</c> as OneToMany for AdmAppLanguagesCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppLanguages>))]
		AdmAppLanguagesCollection,
		///<summary>
		/// Collection of <c>AdmApplicant</c> as OneToMany for AdmAppDisabilityCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppDisability>))]
		AdmAppDisabilityCollection,
		///<summary>
		/// Collection of <c>AdmApplicant</c> as OneToMany for AdmAppMediaCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppMedia>))]
		AdmAppMediaCollection,
		///<summary>
		/// Collection of <c>AdmApplicant</c> as OneToMany for AdmAppFeesCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppFees>))]
		AdmAppFeesCollection,
		///<summary>
		/// Collection of <c>AdmApplicant</c> as OneToMany for AdmEnglishProficiencyCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmEnglishProficiency>))]
		AdmEnglishProficiencyCollection,
		///<summary>
		/// Collection of <c>AdmApplicant</c> as OneToMany for AdmInboxCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmInbox>))]
		AdmInboxCollectionGetByInMsgAppTo,
		///<summary>
		/// Collection of <c>AdmApplicant</c> as OneToMany for AdmAppWorkExperCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppWorkExper>))]
		AdmAppWorkExperCollection,
		///<summary>
		/// Collection of <c>AdmApplicant</c> as OneToMany for AdmAppLtrRecomCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppLtrRecom>))]
		AdmAppLtrRecomCollection,
	}
	
	#endregion AdmApplicantChildEntityTypes
	
	#region AdmApplicantFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AdmApplicantColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmApplicant"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmApplicantFilterBuilder : SqlFilterBuilder<AdmApplicantColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmApplicantFilterBuilder class.
		/// </summary>
		public AdmApplicantFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmApplicantFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmApplicantFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmApplicantFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmApplicantFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmApplicantFilterBuilder
	
	#region AdmApplicantParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AdmApplicantColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmApplicant"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmApplicantParameterBuilder : ParameterizedSqlFilterBuilder<AdmApplicantColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmApplicantParameterBuilder class.
		/// </summary>
		public AdmApplicantParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmApplicantParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmApplicantParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmApplicantParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmApplicantParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmApplicantParameterBuilder
	
	#region AdmApplicantSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AdmApplicantColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmApplicant"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AdmApplicantSortBuilder : SqlSortBuilder<AdmApplicantColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmApplicantSqlSortBuilder class.
		/// </summary>
		public AdmApplicantSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AdmApplicantSortBuilder
	
} // end namespace
