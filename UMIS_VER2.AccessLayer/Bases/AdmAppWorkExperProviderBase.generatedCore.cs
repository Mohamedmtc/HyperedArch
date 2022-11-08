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
	/// This class is the base class for any <see cref="AdmAppWorkExperProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AdmAppWorkExperProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AdmAppWorkExper, UMIS_VER2.BusinessLyer.AdmAppWorkExperKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppWorkExperKey key)
		{
			return Delete(transactionManager, key.AdmAppWorkExperId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_admAppWorkExperId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _admAppWorkExperId)
		{
			return Delete(null, _admAppWorkExperId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppWorkExperId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _admAppWorkExperId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_WORK_EXPER_ADM_APP_REG_HISTORY key.
		///		FK_ADM_APP_WORK_EXPER_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="_admAppRegHistoryId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppWorkExper objects.</returns>
		public TList<AdmAppWorkExper> GetByAdmAppRegHistoryId(System.Decimal? _admAppRegHistoryId)
		{
			int count = -1;
			return GetByAdmAppRegHistoryId(_admAppRegHistoryId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_WORK_EXPER_ADM_APP_REG_HISTORY key.
		///		FK_ADM_APP_WORK_EXPER_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppWorkExper objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAppWorkExper> GetByAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal? _admAppRegHistoryId)
		{
			int count = -1;
			return GetByAdmAppRegHistoryId(transactionManager, _admAppRegHistoryId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_WORK_EXPER_ADM_APP_REG_HISTORY key.
		///		FK_ADM_APP_WORK_EXPER_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppWorkExper objects.</returns>
		public TList<AdmAppWorkExper> GetByAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal? _admAppRegHistoryId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppRegHistoryId(transactionManager, _admAppRegHistoryId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_WORK_EXPER_ADM_APP_REG_HISTORY key.
		///		fkAdmAppWorkExperAdmAppRegHistory Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppWorkExper objects.</returns>
		public TList<AdmAppWorkExper> GetByAdmAppRegHistoryId(System.Decimal? _admAppRegHistoryId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmAppRegHistoryId(null, _admAppRegHistoryId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_WORK_EXPER_ADM_APP_REG_HISTORY key.
		///		fkAdmAppWorkExperAdmAppRegHistory Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppWorkExper objects.</returns>
		public TList<AdmAppWorkExper> GetByAdmAppRegHistoryId(System.Decimal? _admAppRegHistoryId, int start, int pageLength,out int count)
		{
			return GetByAdmAppRegHistoryId(null, _admAppRegHistoryId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_WORK_EXPER_ADM_APP_REG_HISTORY key.
		///		FK_ADM_APP_WORK_EXPER_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppWorkExper objects.</returns>
		public abstract TList<AdmAppWorkExper> GetByAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal? _admAppRegHistoryId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_WORK_EXPER_ADM_APPLICANT key.
		///		FK_ADM_APP_WORK_EXPER_ADM_APPLICANT Description: 
		/// </summary>
		/// <param name="_admApplicantId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppWorkExper objects.</returns>
		public TList<AdmAppWorkExper> GetByAdmApplicantId(System.Decimal? _admApplicantId)
		{
			int count = -1;
			return GetByAdmApplicantId(_admApplicantId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_WORK_EXPER_ADM_APPLICANT key.
		///		FK_ADM_APP_WORK_EXPER_ADM_APPLICANT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppWorkExper objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAppWorkExper> GetByAdmApplicantId(TransactionManager transactionManager, System.Decimal? _admApplicantId)
		{
			int count = -1;
			return GetByAdmApplicantId(transactionManager, _admApplicantId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_WORK_EXPER_ADM_APPLICANT key.
		///		FK_ADM_APP_WORK_EXPER_ADM_APPLICANT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppWorkExper objects.</returns>
		public TList<AdmAppWorkExper> GetByAdmApplicantId(TransactionManager transactionManager, System.Decimal? _admApplicantId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmApplicantId(transactionManager, _admApplicantId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_WORK_EXPER_ADM_APPLICANT key.
		///		fkAdmAppWorkExperAdmApplicant Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admApplicantId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppWorkExper objects.</returns>
		public TList<AdmAppWorkExper> GetByAdmApplicantId(System.Decimal? _admApplicantId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmApplicantId(null, _admApplicantId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_WORK_EXPER_ADM_APPLICANT key.
		///		fkAdmAppWorkExperAdmApplicant Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppWorkExper objects.</returns>
		public TList<AdmAppWorkExper> GetByAdmApplicantId(System.Decimal? _admApplicantId, int start, int pageLength,out int count)
		{
			return GetByAdmApplicantId(null, _admApplicantId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_WORK_EXPER_ADM_APPLICANT key.
		///		FK_ADM_APP_WORK_EXPER_ADM_APPLICANT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppWorkExper objects.</returns>
		public abstract TList<AdmAppWorkExper> GetByAdmApplicantId(TransactionManager transactionManager, System.Decimal? _admApplicantId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_WORK_EXPER_ED_STUD key.
		///		FK_ADM_APP_WORK_EXPER_ED_STUD Description: 
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppWorkExper objects.</returns>
		public TList<AdmAppWorkExper> GetByEdStudId(System.Decimal? _edStudId)
		{
			int count = -1;
			return GetByEdStudId(_edStudId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_WORK_EXPER_ED_STUD key.
		///		FK_ADM_APP_WORK_EXPER_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppWorkExper objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAppWorkExper> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_WORK_EXPER_ED_STUD key.
		///		FK_ADM_APP_WORK_EXPER_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppWorkExper objects.</returns>
		public TList<AdmAppWorkExper> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_WORK_EXPER_ED_STUD key.
		///		fkAdmAppWorkExperEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppWorkExper objects.</returns>
		public TList<AdmAppWorkExper> GetByEdStudId(System.Decimal? _edStudId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudId(null, _edStudId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_WORK_EXPER_ED_STUD key.
		///		fkAdmAppWorkExperEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppWorkExper objects.</returns>
		public TList<AdmAppWorkExper> GetByEdStudId(System.Decimal? _edStudId, int start, int pageLength,out int count)
		{
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_WORK_EXPER_ED_STUD key.
		///		FK_ADM_APP_WORK_EXPER_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppWorkExper objects.</returns>
		public abstract TList<AdmAppWorkExper> GetByEdStudId(TransactionManager transactionManager, System.Decimal? _edStudId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_WORK_EXPER_GS_CDE_UNIVERSITIES key.
		///		FK_ADM_APP_WORK_EXPER_GS_CDE_UNIVERSITIES Description: 
		/// </summary>
		/// <param name="_gsCdeUniversitiesId">الجامعة- الكلية</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppWorkExper objects.</returns>
		public TList<AdmAppWorkExper> GetByGsCdeUniversitiesId(System.Decimal? _gsCdeUniversitiesId)
		{
			int count = -1;
			return GetByGsCdeUniversitiesId(_gsCdeUniversitiesId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_WORK_EXPER_GS_CDE_UNIVERSITIES key.
		///		FK_ADM_APP_WORK_EXPER_GS_CDE_UNIVERSITIES Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeUniversitiesId">الجامعة- الكلية</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppWorkExper objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAppWorkExper> GetByGsCdeUniversitiesId(TransactionManager transactionManager, System.Decimal? _gsCdeUniversitiesId)
		{
			int count = -1;
			return GetByGsCdeUniversitiesId(transactionManager, _gsCdeUniversitiesId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_WORK_EXPER_GS_CDE_UNIVERSITIES key.
		///		FK_ADM_APP_WORK_EXPER_GS_CDE_UNIVERSITIES Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeUniversitiesId">الجامعة- الكلية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppWorkExper objects.</returns>
		public TList<AdmAppWorkExper> GetByGsCdeUniversitiesId(TransactionManager transactionManager, System.Decimal? _gsCdeUniversitiesId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeUniversitiesId(transactionManager, _gsCdeUniversitiesId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_WORK_EXPER_GS_CDE_UNIVERSITIES key.
		///		fkAdmAppWorkExperGsCdeUniversities Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCdeUniversitiesId">الجامعة- الكلية</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppWorkExper objects.</returns>
		public TList<AdmAppWorkExper> GetByGsCdeUniversitiesId(System.Decimal? _gsCdeUniversitiesId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCdeUniversitiesId(null, _gsCdeUniversitiesId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_WORK_EXPER_GS_CDE_UNIVERSITIES key.
		///		fkAdmAppWorkExperGsCdeUniversities Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCdeUniversitiesId">الجامعة- الكلية</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppWorkExper objects.</returns>
		public TList<AdmAppWorkExper> GetByGsCdeUniversitiesId(System.Decimal? _gsCdeUniversitiesId, int start, int pageLength,out int count)
		{
			return GetByGsCdeUniversitiesId(null, _gsCdeUniversitiesId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_WORK_EXPER_GS_CDE_UNIVERSITIES key.
		///		FK_ADM_APP_WORK_EXPER_GS_CDE_UNIVERSITIES Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeUniversitiesId">الجامعة- الكلية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppWorkExper objects.</returns>
		public abstract TList<AdmAppWorkExper> GetByGsCdeUniversitiesId(TransactionManager transactionManager, System.Decimal? _gsCdeUniversitiesId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_WORK_EXPER_GS_COUNTRY_NODE key.
		///		FK_ADM_APP_WORK_EXPER_GS_COUNTRY_NODE Description: 
		/// </summary>
		/// <param name="_gsCountryNodeId">البلد- المحافظة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppWorkExper objects.</returns>
		public TList<AdmAppWorkExper> GetByGsCountryNodeId(System.Decimal? _gsCountryNodeId)
		{
			int count = -1;
			return GetByGsCountryNodeId(_gsCountryNodeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_WORK_EXPER_GS_COUNTRY_NODE key.
		///		FK_ADM_APP_WORK_EXPER_GS_COUNTRY_NODE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryNodeId">البلد- المحافظة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppWorkExper objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAppWorkExper> GetByGsCountryNodeId(TransactionManager transactionManager, System.Decimal? _gsCountryNodeId)
		{
			int count = -1;
			return GetByGsCountryNodeId(transactionManager, _gsCountryNodeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_WORK_EXPER_GS_COUNTRY_NODE key.
		///		FK_ADM_APP_WORK_EXPER_GS_COUNTRY_NODE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryNodeId">البلد- المحافظة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppWorkExper objects.</returns>
		public TList<AdmAppWorkExper> GetByGsCountryNodeId(TransactionManager transactionManager, System.Decimal? _gsCountryNodeId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCountryNodeId(transactionManager, _gsCountryNodeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_WORK_EXPER_GS_COUNTRY_NODE key.
		///		fkAdmAppWorkExperGsCountryNode Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCountryNodeId">البلد- المحافظة</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppWorkExper objects.</returns>
		public TList<AdmAppWorkExper> GetByGsCountryNodeId(System.Decimal? _gsCountryNodeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCountryNodeId(null, _gsCountryNodeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_WORK_EXPER_GS_COUNTRY_NODE key.
		///		fkAdmAppWorkExperGsCountryNode Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCountryNodeId">البلد- المحافظة</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppWorkExper objects.</returns>
		public TList<AdmAppWorkExper> GetByGsCountryNodeId(System.Decimal? _gsCountryNodeId, int start, int pageLength,out int count)
		{
			return GetByGsCountryNodeId(null, _gsCountryNodeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_WORK_EXPER_GS_COUNTRY_NODE key.
		///		FK_ADM_APP_WORK_EXPER_GS_COUNTRY_NODE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryNodeId">البلد- المحافظة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppWorkExper objects.</returns>
		public abstract TList<AdmAppWorkExper> GetByGsCountryNodeId(TransactionManager transactionManager, System.Decimal? _gsCountryNodeId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.AdmAppWorkExper Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppWorkExperKey key, int start, int pageLength)
		{
			return GetByAdmAppWorkExperId(transactionManager, key.AdmAppWorkExperId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ADM_APP_WORK_EXPER index.
		/// </summary>
		/// <param name="_admAppWorkExperId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppWorkExper"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppWorkExper GetByAdmAppWorkExperId(System.Decimal _admAppWorkExperId)
		{
			int count = -1;
			return GetByAdmAppWorkExperId(null,_admAppWorkExperId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_WORK_EXPER index.
		/// </summary>
		/// <param name="_admAppWorkExperId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppWorkExper"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppWorkExper GetByAdmAppWorkExperId(System.Decimal _admAppWorkExperId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppWorkExperId(null, _admAppWorkExperId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_WORK_EXPER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppWorkExperId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppWorkExper"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppWorkExper GetByAdmAppWorkExperId(TransactionManager transactionManager, System.Decimal _admAppWorkExperId)
		{
			int count = -1;
			return GetByAdmAppWorkExperId(transactionManager, _admAppWorkExperId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_WORK_EXPER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppWorkExperId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppWorkExper"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppWorkExper GetByAdmAppWorkExperId(TransactionManager transactionManager, System.Decimal _admAppWorkExperId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppWorkExperId(transactionManager, _admAppWorkExperId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_WORK_EXPER index.
		/// </summary>
		/// <param name="_admAppWorkExperId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppWorkExper"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppWorkExper GetByAdmAppWorkExperId(System.Decimal _admAppWorkExperId, int start, int pageLength, out int count)
		{
			return GetByAdmAppWorkExperId(null, _admAppWorkExperId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_WORK_EXPER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppWorkExperId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppWorkExper"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmAppWorkExper GetByAdmAppWorkExperId(TransactionManager transactionManager, System.Decimal _admAppWorkExperId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AdmAppWorkExper&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AdmAppWorkExper&gt;"/></returns>
		public static TList<AdmAppWorkExper> Fill(IDataReader reader, TList<AdmAppWorkExper> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AdmAppWorkExper c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AdmAppWorkExper")
					.Append("|").Append((System.Decimal)reader["ADM_APP_WORK_EXPER_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AdmAppWorkExper>(
					key.ToString(), // EntityTrackingKey
					"AdmAppWorkExper",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AdmAppWorkExper();
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
					c.AdmAppWorkExperId = (System.Decimal)reader["ADM_APP_WORK_EXPER_ID"];
					c.OriginalAdmAppWorkExperId = c.AdmAppWorkExperId;
					c.OrgName = Convert.IsDBNull(reader["ORG_NAME"]) ? null : (System.String)reader["ORG_NAME"];
					c.OrgAddress = Convert.IsDBNull(reader["ORG_ADDRESS"]) ? null : (System.String)reader["ORG_ADDRESS"];
					c.GsCountryNodeId = Convert.IsDBNull(reader["GS_COUNTRY_NODE_ID"]) ? null : (System.Decimal?)reader["GS_COUNTRY_NODE_ID"];
					c.JobTitle = Convert.IsDBNull(reader["JOB_TITLE"]) ? null : (System.String)reader["JOB_TITLE"];
					c.JobDescr = Convert.IsDBNull(reader["JOB_DESCR"]) ? null : (System.String)reader["JOB_DESCR"];
					c.FromDate = (System.DateTime)reader["FROM_DATE"];
					c.ToDate = Convert.IsDBNull(reader["TO_DATE"]) ? null : (System.DateTime?)reader["TO_DATE"];
					c.CurrentFlg = Convert.IsDBNull(reader["CURRENT_FLG"]) ? null : (System.Boolean?)reader["CURRENT_FLG"];
					c.AdmApplicantId = Convert.IsDBNull(reader["ADM_APPLICANT_ID"]) ? null : (System.Decimal?)reader["ADM_APPLICANT_ID"];
					c.EdStudId = Convert.IsDBNull(reader["ED_STUD_ID"]) ? null : (System.Decimal?)reader["ED_STUD_ID"];
					c.PhoneNo = Convert.IsDBNull(reader["PHONE_NO"]) ? null : (System.Decimal?)reader["PHONE_NO"];
					c.MobNo = Convert.IsDBNull(reader["MOB_NO"]) ? null : (System.Decimal?)reader["MOB_NO"];
					c.EMail = Convert.IsDBNull(reader["E_MAIL"]) ? null : (System.String)reader["E_MAIL"];
					c.WebSite = Convert.IsDBNull(reader["WEB_SITE"]) ? null : (System.String)reader["WEB_SITE"];
					c.GsCdeUniversitiesId = Convert.IsDBNull(reader["GS_CDE_UNIVERSITIES_ID"]) ? null : (System.Decimal?)reader["GS_CDE_UNIVERSITIES_ID"];
					c.WorkNotes = Convert.IsDBNull(reader["WORK_NOTES"]) ? null : (System.String)reader["WORK_NOTES"];
					c.DeptDescrEn = Convert.IsDBNull(reader["DEPT_DESCR_EN"]) ? null : (System.String)reader["DEPT_DESCR_EN"];
					c.AdmAppRegHistoryId = Convert.IsDBNull(reader["ADM_APP_REG_HISTORY_ID"]) ? null : (System.Decimal?)reader["ADM_APP_REG_HISTORY_ID"];
					c.AwkafFlg = Convert.IsDBNull(reader["AWKAF_FLG"]) ? null : (System.Boolean?)reader["AWKAF_FLG"];
					c.PrivFlg = Convert.IsDBNull(reader["PRIV_FLG"]) ? null : (System.Boolean?)reader["PRIV_FLG"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmAppWorkExper"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAppWorkExper"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AdmAppWorkExper entity)
		{
			if (!reader.Read()) return;
			
			entity.AdmAppWorkExperId = (System.Decimal)reader[((int)AdmAppWorkExperColumn.AdmAppWorkExperId - 1)];
			entity.OriginalAdmAppWorkExperId = (System.Decimal)reader["ADM_APP_WORK_EXPER_ID"];
			entity.OrgName = (reader.IsDBNull(((int)AdmAppWorkExperColumn.OrgName - 1)))?null:(System.String)reader[((int)AdmAppWorkExperColumn.OrgName - 1)];
			entity.OrgAddress = (reader.IsDBNull(((int)AdmAppWorkExperColumn.OrgAddress - 1)))?null:(System.String)reader[((int)AdmAppWorkExperColumn.OrgAddress - 1)];
			entity.GsCountryNodeId = (reader.IsDBNull(((int)AdmAppWorkExperColumn.GsCountryNodeId - 1)))?null:(System.Decimal?)reader[((int)AdmAppWorkExperColumn.GsCountryNodeId - 1)];
			entity.JobTitle = (reader.IsDBNull(((int)AdmAppWorkExperColumn.JobTitle - 1)))?null:(System.String)reader[((int)AdmAppWorkExperColumn.JobTitle - 1)];
			entity.JobDescr = (reader.IsDBNull(((int)AdmAppWorkExperColumn.JobDescr - 1)))?null:(System.String)reader[((int)AdmAppWorkExperColumn.JobDescr - 1)];
			entity.FromDate = (System.DateTime)reader[((int)AdmAppWorkExperColumn.FromDate - 1)];
			entity.ToDate = (reader.IsDBNull(((int)AdmAppWorkExperColumn.ToDate - 1)))?null:(System.DateTime?)reader[((int)AdmAppWorkExperColumn.ToDate - 1)];
			entity.CurrentFlg = (reader.IsDBNull(((int)AdmAppWorkExperColumn.CurrentFlg - 1)))?null:(System.Boolean?)reader[((int)AdmAppWorkExperColumn.CurrentFlg - 1)];
			entity.AdmApplicantId = (reader.IsDBNull(((int)AdmAppWorkExperColumn.AdmApplicantId - 1)))?null:(System.Decimal?)reader[((int)AdmAppWorkExperColumn.AdmApplicantId - 1)];
			entity.EdStudId = (reader.IsDBNull(((int)AdmAppWorkExperColumn.EdStudId - 1)))?null:(System.Decimal?)reader[((int)AdmAppWorkExperColumn.EdStudId - 1)];
			entity.PhoneNo = (reader.IsDBNull(((int)AdmAppWorkExperColumn.PhoneNo - 1)))?null:(System.Decimal?)reader[((int)AdmAppWorkExperColumn.PhoneNo - 1)];
			entity.MobNo = (reader.IsDBNull(((int)AdmAppWorkExperColumn.MobNo - 1)))?null:(System.Decimal?)reader[((int)AdmAppWorkExperColumn.MobNo - 1)];
			entity.EMail = (reader.IsDBNull(((int)AdmAppWorkExperColumn.EMail - 1)))?null:(System.String)reader[((int)AdmAppWorkExperColumn.EMail - 1)];
			entity.WebSite = (reader.IsDBNull(((int)AdmAppWorkExperColumn.WebSite - 1)))?null:(System.String)reader[((int)AdmAppWorkExperColumn.WebSite - 1)];
			entity.GsCdeUniversitiesId = (reader.IsDBNull(((int)AdmAppWorkExperColumn.GsCdeUniversitiesId - 1)))?null:(System.Decimal?)reader[((int)AdmAppWorkExperColumn.GsCdeUniversitiesId - 1)];
			entity.WorkNotes = (reader.IsDBNull(((int)AdmAppWorkExperColumn.WorkNotes - 1)))?null:(System.String)reader[((int)AdmAppWorkExperColumn.WorkNotes - 1)];
			entity.DeptDescrEn = (reader.IsDBNull(((int)AdmAppWorkExperColumn.DeptDescrEn - 1)))?null:(System.String)reader[((int)AdmAppWorkExperColumn.DeptDescrEn - 1)];
			entity.AdmAppRegHistoryId = (reader.IsDBNull(((int)AdmAppWorkExperColumn.AdmAppRegHistoryId - 1)))?null:(System.Decimal?)reader[((int)AdmAppWorkExperColumn.AdmAppRegHistoryId - 1)];
			entity.AwkafFlg = (reader.IsDBNull(((int)AdmAppWorkExperColumn.AwkafFlg - 1)))?null:(System.Boolean?)reader[((int)AdmAppWorkExperColumn.AwkafFlg - 1)];
			entity.PrivFlg = (reader.IsDBNull(((int)AdmAppWorkExperColumn.PrivFlg - 1)))?null:(System.Boolean?)reader[((int)AdmAppWorkExperColumn.PrivFlg - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)AdmAppWorkExperColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)AdmAppWorkExperColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)AdmAppWorkExperColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)AdmAppWorkExperColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmAppWorkExper"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAppWorkExper"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AdmAppWorkExper entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AdmAppWorkExperId = (System.Decimal)dataRow["ADM_APP_WORK_EXPER_ID"];
			entity.OriginalAdmAppWorkExperId = (System.Decimal)dataRow["ADM_APP_WORK_EXPER_ID"];
			entity.OrgName = Convert.IsDBNull(dataRow["ORG_NAME"]) ? null : (System.String)dataRow["ORG_NAME"];
			entity.OrgAddress = Convert.IsDBNull(dataRow["ORG_ADDRESS"]) ? null : (System.String)dataRow["ORG_ADDRESS"];
			entity.GsCountryNodeId = Convert.IsDBNull(dataRow["GS_COUNTRY_NODE_ID"]) ? null : (System.Decimal?)dataRow["GS_COUNTRY_NODE_ID"];
			entity.JobTitle = Convert.IsDBNull(dataRow["JOB_TITLE"]) ? null : (System.String)dataRow["JOB_TITLE"];
			entity.JobDescr = Convert.IsDBNull(dataRow["JOB_DESCR"]) ? null : (System.String)dataRow["JOB_DESCR"];
			entity.FromDate = (System.DateTime)dataRow["FROM_DATE"];
			entity.ToDate = Convert.IsDBNull(dataRow["TO_DATE"]) ? null : (System.DateTime?)dataRow["TO_DATE"];
			entity.CurrentFlg = Convert.IsDBNull(dataRow["CURRENT_FLG"]) ? null : (System.Boolean?)dataRow["CURRENT_FLG"];
			entity.AdmApplicantId = Convert.IsDBNull(dataRow["ADM_APPLICANT_ID"]) ? null : (System.Decimal?)dataRow["ADM_APPLICANT_ID"];
			entity.EdStudId = Convert.IsDBNull(dataRow["ED_STUD_ID"]) ? null : (System.Decimal?)dataRow["ED_STUD_ID"];
			entity.PhoneNo = Convert.IsDBNull(dataRow["PHONE_NO"]) ? null : (System.Decimal?)dataRow["PHONE_NO"];
			entity.MobNo = Convert.IsDBNull(dataRow["MOB_NO"]) ? null : (System.Decimal?)dataRow["MOB_NO"];
			entity.EMail = Convert.IsDBNull(dataRow["E_MAIL"]) ? null : (System.String)dataRow["E_MAIL"];
			entity.WebSite = Convert.IsDBNull(dataRow["WEB_SITE"]) ? null : (System.String)dataRow["WEB_SITE"];
			entity.GsCdeUniversitiesId = Convert.IsDBNull(dataRow["GS_CDE_UNIVERSITIES_ID"]) ? null : (System.Decimal?)dataRow["GS_CDE_UNIVERSITIES_ID"];
			entity.WorkNotes = Convert.IsDBNull(dataRow["WORK_NOTES"]) ? null : (System.String)dataRow["WORK_NOTES"];
			entity.DeptDescrEn = Convert.IsDBNull(dataRow["DEPT_DESCR_EN"]) ? null : (System.String)dataRow["DEPT_DESCR_EN"];
			entity.AdmAppRegHistoryId = Convert.IsDBNull(dataRow["ADM_APP_REG_HISTORY_ID"]) ? null : (System.Decimal?)dataRow["ADM_APP_REG_HISTORY_ID"];
			entity.AwkafFlg = Convert.IsDBNull(dataRow["AWKAF_FLG"]) ? null : (System.Boolean?)dataRow["AWKAF_FLG"];
			entity.PrivFlg = Convert.IsDBNull(dataRow["PRIV_FLG"]) ? null : (System.Boolean?)dataRow["PRIV_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAppWorkExper"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmAppWorkExper Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppWorkExper entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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

			#region GsCdeUniversitiesIdSource	
			if (CanDeepLoad(entity, "GsCdeUniversities|GsCdeUniversitiesIdSource", deepLoadType, innerList) 
				&& entity.GsCdeUniversitiesIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCdeUniversitiesId ?? 0.0m);
				GsCdeUniversities tmpEntity = EntityManager.LocateEntity<GsCdeUniversities>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCdeUniversities), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCdeUniversitiesIdSource = tmpEntity;
				else
					entity.GsCdeUniversitiesIdSource = DataRepository.GsCdeUniversitiesProvider.GetByGsCdeUniversitiesId(transactionManager, (entity.GsCdeUniversitiesId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCdeUniversitiesIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCdeUniversitiesIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCdeUniversitiesProvider.DeepLoad(transactionManager, entity.GsCdeUniversitiesIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCdeUniversitiesIdSource

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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AdmAppWorkExper object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AdmAppWorkExper instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmAppWorkExper Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppWorkExper entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region GsCdeUniversitiesIdSource
			if (CanDeepSave(entity, "GsCdeUniversities|GsCdeUniversitiesIdSource", deepSaveType, innerList) 
				&& entity.GsCdeUniversitiesIdSource != null)
			{
				DataRepository.GsCdeUniversitiesProvider.Save(transactionManager, entity.GsCdeUniversitiesIdSource);
				entity.GsCdeUniversitiesId = entity.GsCdeUniversitiesIdSource.GsCdeUniversitiesId;
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
	
	#region AdmAppWorkExperChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AdmAppWorkExper</c>
	///</summary>
	public enum AdmAppWorkExperChildEntityTypes
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
		/// Composite Property for <c>GsCdeUniversities</c> at GsCdeUniversitiesIdSource
		///</summary>
		[ChildEntityType(typeof(GsCdeUniversities))]
		GsCdeUniversities,
		
		///<summary>
		/// Composite Property for <c>GsCountryNode</c> at GsCountryNodeIdSource
		///</summary>
		[ChildEntityType(typeof(GsCountryNode))]
		GsCountryNode,
	}
	
	#endregion AdmAppWorkExperChildEntityTypes
	
	#region AdmAppWorkExperFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AdmAppWorkExperColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAppWorkExper"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmAppWorkExperFilterBuilder : SqlFilterBuilder<AdmAppWorkExperColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAppWorkExperFilterBuilder class.
		/// </summary>
		public AdmAppWorkExperFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmAppWorkExperFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmAppWorkExperFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmAppWorkExperFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmAppWorkExperFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmAppWorkExperFilterBuilder
	
	#region AdmAppWorkExperParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AdmAppWorkExperColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAppWorkExper"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmAppWorkExperParameterBuilder : ParameterizedSqlFilterBuilder<AdmAppWorkExperColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAppWorkExperParameterBuilder class.
		/// </summary>
		public AdmAppWorkExperParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmAppWorkExperParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmAppWorkExperParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmAppWorkExperParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmAppWorkExperParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmAppWorkExperParameterBuilder
	
	#region AdmAppWorkExperSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AdmAppWorkExperColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAppWorkExper"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AdmAppWorkExperSortBuilder : SqlSortBuilder<AdmAppWorkExperColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAppWorkExperSqlSortBuilder class.
		/// </summary>
		public AdmAppWorkExperSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AdmAppWorkExperSortBuilder
	
} // end namespace
