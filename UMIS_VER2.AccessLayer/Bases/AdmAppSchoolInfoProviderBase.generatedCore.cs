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
	/// This class is the base class for any <see cref="AdmAppSchoolInfoProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AdmAppSchoolInfoProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AdmAppSchoolInfo, UMIS_VER2.BusinessLyer.AdmAppSchoolInfoKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppSchoolInfoKey key)
		{
			return Delete(transactionManager, key.AdmAppSchoolInfoId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_admAppSchoolInfoId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _admAppSchoolInfoId)
		{
			return Delete(null, _admAppSchoolInfoId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppSchoolInfoId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _admAppSchoolInfoId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_SCHOOL_INFO_ADM_APP key.
		///		FK_ADM_APP_SCHOOL_INFO_ADM_APP Description: 
		/// </summary>
		/// <param name="_admApplicantId">مسلسل المتقدم</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppSchoolInfo objects.</returns>
		public TList<AdmAppSchoolInfo> GetByAdmApplicantId(System.Decimal _admApplicantId)
		{
			int count = -1;
			return GetByAdmApplicantId(_admApplicantId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_SCHOOL_INFO_ADM_APP key.
		///		FK_ADM_APP_SCHOOL_INFO_ADM_APP Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId">مسلسل المتقدم</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppSchoolInfo objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAppSchoolInfo> GetByAdmApplicantId(TransactionManager transactionManager, System.Decimal _admApplicantId)
		{
			int count = -1;
			return GetByAdmApplicantId(transactionManager, _admApplicantId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_SCHOOL_INFO_ADM_APP key.
		///		FK_ADM_APP_SCHOOL_INFO_ADM_APP Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId">مسلسل المتقدم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppSchoolInfo objects.</returns>
		public TList<AdmAppSchoolInfo> GetByAdmApplicantId(TransactionManager transactionManager, System.Decimal _admApplicantId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmApplicantId(transactionManager, _admApplicantId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_SCHOOL_INFO_ADM_APP key.
		///		fkAdmAppSchoolInfoAdmApp Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admApplicantId">مسلسل المتقدم</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppSchoolInfo objects.</returns>
		public TList<AdmAppSchoolInfo> GetByAdmApplicantId(System.Decimal _admApplicantId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmApplicantId(null, _admApplicantId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_SCHOOL_INFO_ADM_APP key.
		///		fkAdmAppSchoolInfoAdmApp Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admApplicantId">مسلسل المتقدم</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppSchoolInfo objects.</returns>
		public TList<AdmAppSchoolInfo> GetByAdmApplicantId(System.Decimal _admApplicantId, int start, int pageLength,out int count)
		{
			return GetByAdmApplicantId(null, _admApplicantId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_SCHOOL_INFO_ADM_APP key.
		///		FK_ADM_APP_SCHOOL_INFO_ADM_APP Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId">مسلسل المتقدم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppSchoolInfo objects.</returns>
		public abstract TList<AdmAppSchoolInfo> GetByAdmApplicantId(TransactionManager transactionManager, System.Decimal _admApplicantId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_SCHOOL_INFO_ED_CODE_QUAL key.
		///		FK_ADM_APP_SCHOOL_INFO_ED_CODE_QUAL Description: 
		/// </summary>
		/// <param name="_edCodeQualId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppSchoolInfo objects.</returns>
		public TList<AdmAppSchoolInfo> GetByEdCodeQualId(System.Decimal? _edCodeQualId)
		{
			int count = -1;
			return GetByEdCodeQualId(_edCodeQualId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_SCHOOL_INFO_ED_CODE_QUAL key.
		///		FK_ADM_APP_SCHOOL_INFO_ED_CODE_QUAL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeQualId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppSchoolInfo objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAppSchoolInfo> GetByEdCodeQualId(TransactionManager transactionManager, System.Decimal? _edCodeQualId)
		{
			int count = -1;
			return GetByEdCodeQualId(transactionManager, _edCodeQualId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_SCHOOL_INFO_ED_CODE_QUAL key.
		///		FK_ADM_APP_SCHOOL_INFO_ED_CODE_QUAL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeQualId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppSchoolInfo objects.</returns>
		public TList<AdmAppSchoolInfo> GetByEdCodeQualId(TransactionManager transactionManager, System.Decimal? _edCodeQualId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeQualId(transactionManager, _edCodeQualId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_SCHOOL_INFO_ED_CODE_QUAL key.
		///		fkAdmAppSchoolInfoEdCodeQual Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeQualId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppSchoolInfo objects.</returns>
		public TList<AdmAppSchoolInfo> GetByEdCodeQualId(System.Decimal? _edCodeQualId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeQualId(null, _edCodeQualId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_SCHOOL_INFO_ED_CODE_QUAL key.
		///		fkAdmAppSchoolInfoEdCodeQual Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeQualId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppSchoolInfo objects.</returns>
		public TList<AdmAppSchoolInfo> GetByEdCodeQualId(System.Decimal? _edCodeQualId, int start, int pageLength,out int count)
		{
			return GetByEdCodeQualId(null, _edCodeQualId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_SCHOOL_INFO_ED_CODE_QUAL key.
		///		FK_ADM_APP_SCHOOL_INFO_ED_CODE_QUAL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeQualId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppSchoolInfo objects.</returns>
		public abstract TList<AdmAppSchoolInfo> GetByEdCodeQualId(TransactionManager transactionManager, System.Decimal? _edCodeQualId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_SCHOOL_INFO_GS_CDE_SCHOOL key.
		///		FK_ADM_APP_SCHOOL_INFO_GS_CDE_SCHOOL Description: 
		/// </summary>
		/// <param name="_gsCdeSchoolId">مسلسل مدرسة الثانوية</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppSchoolInfo objects.</returns>
		public TList<AdmAppSchoolInfo> GetByGsCdeSchoolId(System.Decimal? _gsCdeSchoolId)
		{
			int count = -1;
			return GetByGsCdeSchoolId(_gsCdeSchoolId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_SCHOOL_INFO_GS_CDE_SCHOOL key.
		///		FK_ADM_APP_SCHOOL_INFO_GS_CDE_SCHOOL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeSchoolId">مسلسل مدرسة الثانوية</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppSchoolInfo objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAppSchoolInfo> GetByGsCdeSchoolId(TransactionManager transactionManager, System.Decimal? _gsCdeSchoolId)
		{
			int count = -1;
			return GetByGsCdeSchoolId(transactionManager, _gsCdeSchoolId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_SCHOOL_INFO_GS_CDE_SCHOOL key.
		///		FK_ADM_APP_SCHOOL_INFO_GS_CDE_SCHOOL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeSchoolId">مسلسل مدرسة الثانوية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppSchoolInfo objects.</returns>
		public TList<AdmAppSchoolInfo> GetByGsCdeSchoolId(TransactionManager transactionManager, System.Decimal? _gsCdeSchoolId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeSchoolId(transactionManager, _gsCdeSchoolId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_SCHOOL_INFO_GS_CDE_SCHOOL key.
		///		fkAdmAppSchoolInfoGsCdeSchool Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCdeSchoolId">مسلسل مدرسة الثانوية</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppSchoolInfo objects.</returns>
		public TList<AdmAppSchoolInfo> GetByGsCdeSchoolId(System.Decimal? _gsCdeSchoolId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCdeSchoolId(null, _gsCdeSchoolId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_SCHOOL_INFO_GS_CDE_SCHOOL key.
		///		fkAdmAppSchoolInfoGsCdeSchool Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCdeSchoolId">مسلسل مدرسة الثانوية</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppSchoolInfo objects.</returns>
		public TList<AdmAppSchoolInfo> GetByGsCdeSchoolId(System.Decimal? _gsCdeSchoolId, int start, int pageLength,out int count)
		{
			return GetByGsCdeSchoolId(null, _gsCdeSchoolId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_SCHOOL_INFO_GS_CDE_SCHOOL key.
		///		FK_ADM_APP_SCHOOL_INFO_GS_CDE_SCHOOL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeSchoolId">مسلسل مدرسة الثانوية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppSchoolInfo objects.</returns>
		public abstract TList<AdmAppSchoolInfo> GetByGsCdeSchoolId(TransactionManager transactionManager, System.Decimal? _gsCdeSchoolId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_SCHOOL_INFO_GS_CODE_LANGUAGE key.
		///		FK_ADM_APP_SCHOOL_INFO_GS_CODE_LANGUAGE Description: 
		/// </summary>
		/// <param name="_gsCodeLanguageId">لغة الدراسة الرئيسية</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppSchoolInfo objects.</returns>
		public TList<AdmAppSchoolInfo> GetByGsCodeLanguageId(System.Decimal? _gsCodeLanguageId)
		{
			int count = -1;
			return GetByGsCodeLanguageId(_gsCodeLanguageId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_SCHOOL_INFO_GS_CODE_LANGUAGE key.
		///		FK_ADM_APP_SCHOOL_INFO_GS_CODE_LANGUAGE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeLanguageId">لغة الدراسة الرئيسية</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppSchoolInfo objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAppSchoolInfo> GetByGsCodeLanguageId(TransactionManager transactionManager, System.Decimal? _gsCodeLanguageId)
		{
			int count = -1;
			return GetByGsCodeLanguageId(transactionManager, _gsCodeLanguageId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_SCHOOL_INFO_GS_CODE_LANGUAGE key.
		///		FK_ADM_APP_SCHOOL_INFO_GS_CODE_LANGUAGE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeLanguageId">لغة الدراسة الرئيسية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppSchoolInfo objects.</returns>
		public TList<AdmAppSchoolInfo> GetByGsCodeLanguageId(TransactionManager transactionManager, System.Decimal? _gsCodeLanguageId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeLanguageId(transactionManager, _gsCodeLanguageId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_SCHOOL_INFO_GS_CODE_LANGUAGE key.
		///		fkAdmAppSchoolInfoGsCodeLanguage Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeLanguageId">لغة الدراسة الرئيسية</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppSchoolInfo objects.</returns>
		public TList<AdmAppSchoolInfo> GetByGsCodeLanguageId(System.Decimal? _gsCodeLanguageId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodeLanguageId(null, _gsCodeLanguageId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_SCHOOL_INFO_GS_CODE_LANGUAGE key.
		///		fkAdmAppSchoolInfoGsCodeLanguage Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeLanguageId">لغة الدراسة الرئيسية</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppSchoolInfo objects.</returns>
		public TList<AdmAppSchoolInfo> GetByGsCodeLanguageId(System.Decimal? _gsCodeLanguageId, int start, int pageLength,out int count)
		{
			return GetByGsCodeLanguageId(null, _gsCodeLanguageId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_SCHOOL_INFO_GS_CODE_LANGUAGE key.
		///		FK_ADM_APP_SCHOOL_INFO_GS_CODE_LANGUAGE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeLanguageId">لغة الدراسة الرئيسية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppSchoolInfo objects.</returns>
		public abstract TList<AdmAppSchoolInfo> GetByGsCodeLanguageId(TransactionManager transactionManager, System.Decimal? _gsCodeLanguageId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_SCHOOL_INFO_GS_COUNTRY_NODE key.
		///		FK_ADM_APP_SCHOOL_INFO_GS_COUNTRY_NODE Description: 
		/// </summary>
		/// <param name="_gsCountryNodeId">بلد المدرسة فى حالة اختار الطالب مدرسة غير موجودة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppSchoolInfo objects.</returns>
		public TList<AdmAppSchoolInfo> GetByGsCountryNodeId(System.Decimal? _gsCountryNodeId)
		{
			int count = -1;
			return GetByGsCountryNodeId(_gsCountryNodeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_SCHOOL_INFO_GS_COUNTRY_NODE key.
		///		FK_ADM_APP_SCHOOL_INFO_GS_COUNTRY_NODE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryNodeId">بلد المدرسة فى حالة اختار الطالب مدرسة غير موجودة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppSchoolInfo objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAppSchoolInfo> GetByGsCountryNodeId(TransactionManager transactionManager, System.Decimal? _gsCountryNodeId)
		{
			int count = -1;
			return GetByGsCountryNodeId(transactionManager, _gsCountryNodeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_SCHOOL_INFO_GS_COUNTRY_NODE key.
		///		FK_ADM_APP_SCHOOL_INFO_GS_COUNTRY_NODE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryNodeId">بلد المدرسة فى حالة اختار الطالب مدرسة غير موجودة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppSchoolInfo objects.</returns>
		public TList<AdmAppSchoolInfo> GetByGsCountryNodeId(TransactionManager transactionManager, System.Decimal? _gsCountryNodeId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCountryNodeId(transactionManager, _gsCountryNodeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_SCHOOL_INFO_GS_COUNTRY_NODE key.
		///		fkAdmAppSchoolInfoGsCountryNode Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCountryNodeId">بلد المدرسة فى حالة اختار الطالب مدرسة غير موجودة</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppSchoolInfo objects.</returns>
		public TList<AdmAppSchoolInfo> GetByGsCountryNodeId(System.Decimal? _gsCountryNodeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCountryNodeId(null, _gsCountryNodeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_SCHOOL_INFO_GS_COUNTRY_NODE key.
		///		fkAdmAppSchoolInfoGsCountryNode Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCountryNodeId">بلد المدرسة فى حالة اختار الطالب مدرسة غير موجودة</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppSchoolInfo objects.</returns>
		public TList<AdmAppSchoolInfo> GetByGsCountryNodeId(System.Decimal? _gsCountryNodeId, int start, int pageLength,out int count)
		{
			return GetByGsCountryNodeId(null, _gsCountryNodeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_SCHOOL_INFO_GS_COUNTRY_NODE key.
		///		FK_ADM_APP_SCHOOL_INFO_GS_COUNTRY_NODE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryNodeId">بلد المدرسة فى حالة اختار الطالب مدرسة غير موجودة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppSchoolInfo objects.</returns>
		public abstract TList<AdmAppSchoolInfo> GetByGsCountryNodeId(TransactionManager transactionManager, System.Decimal? _gsCountryNodeId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.AdmAppSchoolInfo Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppSchoolInfoKey key, int start, int pageLength)
		{
			return GetByAdmAppSchoolInfoId(transactionManager, key.AdmAppSchoolInfoId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ADM_APP_SCHOOL_INFO index.
		/// </summary>
		/// <param name="_admAppSchoolInfoId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppSchoolInfo"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppSchoolInfo GetByAdmAppSchoolInfoId(System.Decimal _admAppSchoolInfoId)
		{
			int count = -1;
			return GetByAdmAppSchoolInfoId(null,_admAppSchoolInfoId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_SCHOOL_INFO index.
		/// </summary>
		/// <param name="_admAppSchoolInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppSchoolInfo"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppSchoolInfo GetByAdmAppSchoolInfoId(System.Decimal _admAppSchoolInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppSchoolInfoId(null, _admAppSchoolInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_SCHOOL_INFO index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppSchoolInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppSchoolInfo"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppSchoolInfo GetByAdmAppSchoolInfoId(TransactionManager transactionManager, System.Decimal _admAppSchoolInfoId)
		{
			int count = -1;
			return GetByAdmAppSchoolInfoId(transactionManager, _admAppSchoolInfoId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_SCHOOL_INFO index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppSchoolInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppSchoolInfo"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppSchoolInfo GetByAdmAppSchoolInfoId(TransactionManager transactionManager, System.Decimal _admAppSchoolInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppSchoolInfoId(transactionManager, _admAppSchoolInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_SCHOOL_INFO index.
		/// </summary>
		/// <param name="_admAppSchoolInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppSchoolInfo"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppSchoolInfo GetByAdmAppSchoolInfoId(System.Decimal _admAppSchoolInfoId, int start, int pageLength, out int count)
		{
			return GetByAdmAppSchoolInfoId(null, _admAppSchoolInfoId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_SCHOOL_INFO index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppSchoolInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppSchoolInfo"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmAppSchoolInfo GetByAdmAppSchoolInfoId(TransactionManager transactionManager, System.Decimal _admAppSchoolInfoId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AdmAppSchoolInfo&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AdmAppSchoolInfo&gt;"/></returns>
		public static TList<AdmAppSchoolInfo> Fill(IDataReader reader, TList<AdmAppSchoolInfo> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AdmAppSchoolInfo c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AdmAppSchoolInfo")
					.Append("|").Append((System.Decimal)reader["ADM_APP_SCHOOL_INFO_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AdmAppSchoolInfo>(
					key.ToString(), // EntityTrackingKey
					"AdmAppSchoolInfo",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AdmAppSchoolInfo();
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
					c.AdmAppSchoolInfoId = (System.Decimal)reader["ADM_APP_SCHOOL_INFO_ID"];
					c.OriginalAdmAppSchoolInfoId = c.AdmAppSchoolInfoId;
					c.AdmApplicantId = (System.Decimal)reader["ADM_APPLICANT_ID"];
					c.GsCdeSchoolId = Convert.IsDBNull(reader["GS_CDE_SCHOOL_ID"]) ? null : (System.Decimal?)reader["GS_CDE_SCHOOL_ID"];
					c.SchoolOtherName = Convert.IsDBNull(reader["SCHOOL_OTHER_NAME"]) ? null : (System.String)reader["SCHOOL_OTHER_NAME"];
					c.GsCountryNodeId = Convert.IsDBNull(reader["GS_COUNTRY_NODE_ID"]) ? null : (System.Decimal?)reader["GS_COUNTRY_NODE_ID"];
					c.SchoolOther = Convert.IsDBNull(reader["SCHOOL_OTHER_"]) ? null : (System.String)reader["SCHOOL_OTHER_"];
					c.CertDate = Convert.IsDBNull(reader["CERT_DATE"]) ? null : (System.DateTime?)reader["CERT_DATE"];
					c.EdCodeQualId = Convert.IsDBNull(reader["ED_CODE_QUAL_ID"]) ? null : (System.Decimal?)reader["ED_CODE_QUAL_ID"];
					c.CertTypeOtherName = Convert.IsDBNull(reader["CERT_TYPE_OTHER_NAME"]) ? null : (System.String)reader["CERT_TYPE_OTHER_NAME"];
					c.CertfEngPrcnt = Convert.IsDBNull(reader["CERTF_ENG_PRCNT"]) ? null : (System.Decimal?)reader["CERTF_ENG_PRCNT"];
					c.CertfPercent = Convert.IsDBNull(reader["CERTF_PERCENT"]) ? null : (System.Decimal?)reader["CERTF_PERCENT"];
					c.GsCodeLanguageId = Convert.IsDBNull(reader["GS_CODE_LANGUAGE_ID"]) ? null : (System.Decimal?)reader["GS_CODE_LANGUAGE_ID"];
					c.CertfDegree = Convert.IsDBNull(reader["CERTF_DEGREE"]) ? null : (System.String)reader["CERTF_DEGREE"];
					c.Cgpa = Convert.IsDBNull(reader["CGPA"]) ? null : (System.Decimal?)reader["CGPA"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmAppSchoolInfo"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAppSchoolInfo"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AdmAppSchoolInfo entity)
		{
			if (!reader.Read()) return;
			
			entity.AdmAppSchoolInfoId = (System.Decimal)reader[((int)AdmAppSchoolInfoColumn.AdmAppSchoolInfoId - 1)];
			entity.OriginalAdmAppSchoolInfoId = (System.Decimal)reader["ADM_APP_SCHOOL_INFO_ID"];
			entity.AdmApplicantId = (System.Decimal)reader[((int)AdmAppSchoolInfoColumn.AdmApplicantId - 1)];
			entity.GsCdeSchoolId = (reader.IsDBNull(((int)AdmAppSchoolInfoColumn.GsCdeSchoolId - 1)))?null:(System.Decimal?)reader[((int)AdmAppSchoolInfoColumn.GsCdeSchoolId - 1)];
			entity.SchoolOtherName = (reader.IsDBNull(((int)AdmAppSchoolInfoColumn.SchoolOtherName - 1)))?null:(System.String)reader[((int)AdmAppSchoolInfoColumn.SchoolOtherName - 1)];
			entity.GsCountryNodeId = (reader.IsDBNull(((int)AdmAppSchoolInfoColumn.GsCountryNodeId - 1)))?null:(System.Decimal?)reader[((int)AdmAppSchoolInfoColumn.GsCountryNodeId - 1)];
			entity.SchoolOther = (reader.IsDBNull(((int)AdmAppSchoolInfoColumn.SchoolOther - 1)))?null:(System.String)reader[((int)AdmAppSchoolInfoColumn.SchoolOther - 1)];
			entity.CertDate = (reader.IsDBNull(((int)AdmAppSchoolInfoColumn.CertDate - 1)))?null:(System.DateTime?)reader[((int)AdmAppSchoolInfoColumn.CertDate - 1)];
			entity.EdCodeQualId = (reader.IsDBNull(((int)AdmAppSchoolInfoColumn.EdCodeQualId - 1)))?null:(System.Decimal?)reader[((int)AdmAppSchoolInfoColumn.EdCodeQualId - 1)];
			entity.CertTypeOtherName = (reader.IsDBNull(((int)AdmAppSchoolInfoColumn.CertTypeOtherName - 1)))?null:(System.String)reader[((int)AdmAppSchoolInfoColumn.CertTypeOtherName - 1)];
			entity.CertfEngPrcnt = (reader.IsDBNull(((int)AdmAppSchoolInfoColumn.CertfEngPrcnt - 1)))?null:(System.Decimal?)reader[((int)AdmAppSchoolInfoColumn.CertfEngPrcnt - 1)];
			entity.CertfPercent = (reader.IsDBNull(((int)AdmAppSchoolInfoColumn.CertfPercent - 1)))?null:(System.Decimal?)reader[((int)AdmAppSchoolInfoColumn.CertfPercent - 1)];
			entity.GsCodeLanguageId = (reader.IsDBNull(((int)AdmAppSchoolInfoColumn.GsCodeLanguageId - 1)))?null:(System.Decimal?)reader[((int)AdmAppSchoolInfoColumn.GsCodeLanguageId - 1)];
			entity.CertfDegree = (reader.IsDBNull(((int)AdmAppSchoolInfoColumn.CertfDegree - 1)))?null:(System.String)reader[((int)AdmAppSchoolInfoColumn.CertfDegree - 1)];
			entity.Cgpa = (reader.IsDBNull(((int)AdmAppSchoolInfoColumn.Cgpa - 1)))?null:(System.Decimal?)reader[((int)AdmAppSchoolInfoColumn.Cgpa - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmAppSchoolInfo"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAppSchoolInfo"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AdmAppSchoolInfo entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AdmAppSchoolInfoId = (System.Decimal)dataRow["ADM_APP_SCHOOL_INFO_ID"];
			entity.OriginalAdmAppSchoolInfoId = (System.Decimal)dataRow["ADM_APP_SCHOOL_INFO_ID"];
			entity.AdmApplicantId = (System.Decimal)dataRow["ADM_APPLICANT_ID"];
			entity.GsCdeSchoolId = Convert.IsDBNull(dataRow["GS_CDE_SCHOOL_ID"]) ? null : (System.Decimal?)dataRow["GS_CDE_SCHOOL_ID"];
			entity.SchoolOtherName = Convert.IsDBNull(dataRow["SCHOOL_OTHER_NAME"]) ? null : (System.String)dataRow["SCHOOL_OTHER_NAME"];
			entity.GsCountryNodeId = Convert.IsDBNull(dataRow["GS_COUNTRY_NODE_ID"]) ? null : (System.Decimal?)dataRow["GS_COUNTRY_NODE_ID"];
			entity.SchoolOther = Convert.IsDBNull(dataRow["SCHOOL_OTHER_"]) ? null : (System.String)dataRow["SCHOOL_OTHER_"];
			entity.CertDate = Convert.IsDBNull(dataRow["CERT_DATE"]) ? null : (System.DateTime?)dataRow["CERT_DATE"];
			entity.EdCodeQualId = Convert.IsDBNull(dataRow["ED_CODE_QUAL_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_QUAL_ID"];
			entity.CertTypeOtherName = Convert.IsDBNull(dataRow["CERT_TYPE_OTHER_NAME"]) ? null : (System.String)dataRow["CERT_TYPE_OTHER_NAME"];
			entity.CertfEngPrcnt = Convert.IsDBNull(dataRow["CERTF_ENG_PRCNT"]) ? null : (System.Decimal?)dataRow["CERTF_ENG_PRCNT"];
			entity.CertfPercent = Convert.IsDBNull(dataRow["CERTF_PERCENT"]) ? null : (System.Decimal?)dataRow["CERTF_PERCENT"];
			entity.GsCodeLanguageId = Convert.IsDBNull(dataRow["GS_CODE_LANGUAGE_ID"]) ? null : (System.Decimal?)dataRow["GS_CODE_LANGUAGE_ID"];
			entity.CertfDegree = Convert.IsDBNull(dataRow["CERTF_DEGREE"]) ? null : (System.String)dataRow["CERTF_DEGREE"];
			entity.Cgpa = Convert.IsDBNull(dataRow["CGPA"]) ? null : (System.Decimal?)dataRow["CGPA"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAppSchoolInfo"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmAppSchoolInfo Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppSchoolInfo entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AdmApplicantIdSource	
			if (CanDeepLoad(entity, "AdmApplicant|AdmApplicantIdSource", deepLoadType, innerList) 
				&& entity.AdmApplicantIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AdmApplicantId;
				AdmApplicant tmpEntity = EntityManager.LocateEntity<AdmApplicant>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmApplicant), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmApplicantIdSource = tmpEntity;
				else
					entity.AdmApplicantIdSource = DataRepository.AdmApplicantProvider.GetByAdmApplicantId(transactionManager, entity.AdmApplicantId);		
				
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

			#region EdCodeQualIdSource	
			if (CanDeepLoad(entity, "EdCodeQual|EdCodeQualIdSource", deepLoadType, innerList) 
				&& entity.EdCodeQualIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCodeQualId ?? 0.0m);
				EdCodeQual tmpEntity = EntityManager.LocateEntity<EdCodeQual>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeQual), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeQualIdSource = tmpEntity;
				else
					entity.EdCodeQualIdSource = DataRepository.EdCodeQualProvider.GetByEdCodeQualId(transactionManager, (entity.EdCodeQualId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeQualIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeQualIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeQualProvider.DeepLoad(transactionManager, entity.EdCodeQualIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeQualIdSource

			#region GsCdeSchoolIdSource	
			if (CanDeepLoad(entity, "GsCdeSchool|GsCdeSchoolIdSource", deepLoadType, innerList) 
				&& entity.GsCdeSchoolIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCdeSchoolId ?? 0.0m);
				GsCdeSchool tmpEntity = EntityManager.LocateEntity<GsCdeSchool>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCdeSchool), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCdeSchoolIdSource = tmpEntity;
				else
					entity.GsCdeSchoolIdSource = DataRepository.GsCdeSchoolProvider.GetByGsCdeSchoolId(transactionManager, (entity.GsCdeSchoolId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCdeSchoolIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCdeSchoolIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCdeSchoolProvider.DeepLoad(transactionManager, entity.GsCdeSchoolIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCdeSchoolIdSource

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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AdmAppSchoolInfo object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AdmAppSchoolInfo instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmAppSchoolInfo Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppSchoolInfo entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region EdCodeQualIdSource
			if (CanDeepSave(entity, "EdCodeQual|EdCodeQualIdSource", deepSaveType, innerList) 
				&& entity.EdCodeQualIdSource != null)
			{
				DataRepository.EdCodeQualProvider.Save(transactionManager, entity.EdCodeQualIdSource);
				entity.EdCodeQualId = entity.EdCodeQualIdSource.EdCodeQualId;
			}
			#endregion 
			
			#region GsCdeSchoolIdSource
			if (CanDeepSave(entity, "GsCdeSchool|GsCdeSchoolIdSource", deepSaveType, innerList) 
				&& entity.GsCdeSchoolIdSource != null)
			{
				DataRepository.GsCdeSchoolProvider.Save(transactionManager, entity.GsCdeSchoolIdSource);
				entity.GsCdeSchoolId = entity.GsCdeSchoolIdSource.GsCdeSchoolId;
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
	
	#region AdmAppSchoolInfoChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AdmAppSchoolInfo</c>
	///</summary>
	public enum AdmAppSchoolInfoChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AdmApplicant</c> at AdmApplicantIdSource
		///</summary>
		[ChildEntityType(typeof(AdmApplicant))]
		AdmApplicant,
			
		///<summary>
		/// Composite Property for <c>EdCodeQual</c> at EdCodeQualIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeQual))]
		EdCodeQual,
			
		///<summary>
		/// Composite Property for <c>GsCdeSchool</c> at GsCdeSchoolIdSource
		///</summary>
		[ChildEntityType(typeof(GsCdeSchool))]
		GsCdeSchool,
			
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
		}
	
	#endregion AdmAppSchoolInfoChildEntityTypes
	
	#region AdmAppSchoolInfoFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AdmAppSchoolInfoColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAppSchoolInfo"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmAppSchoolInfoFilterBuilder : SqlFilterBuilder<AdmAppSchoolInfoColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAppSchoolInfoFilterBuilder class.
		/// </summary>
		public AdmAppSchoolInfoFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmAppSchoolInfoFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmAppSchoolInfoFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmAppSchoolInfoFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmAppSchoolInfoFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmAppSchoolInfoFilterBuilder
	
	#region AdmAppSchoolInfoParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AdmAppSchoolInfoColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAppSchoolInfo"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmAppSchoolInfoParameterBuilder : ParameterizedSqlFilterBuilder<AdmAppSchoolInfoColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAppSchoolInfoParameterBuilder class.
		/// </summary>
		public AdmAppSchoolInfoParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmAppSchoolInfoParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmAppSchoolInfoParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmAppSchoolInfoParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmAppSchoolInfoParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmAppSchoolInfoParameterBuilder
	
	#region AdmAppSchoolInfoSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AdmAppSchoolInfoColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAppSchoolInfo"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AdmAppSchoolInfoSortBuilder : SqlSortBuilder<AdmAppSchoolInfoColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAppSchoolInfoSqlSortBuilder class.
		/// </summary>
		public AdmAppSchoolInfoSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AdmAppSchoolInfoSortBuilder
	
} // end namespace
