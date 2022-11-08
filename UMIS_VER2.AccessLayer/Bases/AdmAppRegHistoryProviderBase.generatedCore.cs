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
	/// This class is the base class for any <see cref="AdmAppRegHistoryProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AdmAppRegHistoryProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AdmAppRegHistory, UMIS_VER2.BusinessLyer.AdmAppRegHistoryKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppRegHistoryKey key)
		{
			return Delete(transactionManager, key.AdmAppRegHistoryId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_admAppRegHistoryId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _admAppRegHistoryId)
		{
			return Delete(null, _admAppRegHistoryId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppRegHistoryId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _admAppRegHistoryId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_ADM_CDE_APP_STATUS key.
		///		FK_ADM_APP_REG_HISTORY_ADM_CDE_APP_STATUS Description: 
		/// </summary>
		/// <param name="_admCdeAppStatusId">حالة المتقدم</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		public TList<AdmAppRegHistory> GetByAdmCdeAppStatusId(System.Decimal? _admCdeAppStatusId)
		{
			int count = -1;
			return GetByAdmCdeAppStatusId(_admCdeAppStatusId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_ADM_CDE_APP_STATUS key.
		///		FK_ADM_APP_REG_HISTORY_ADM_CDE_APP_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeAppStatusId">حالة المتقدم</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAppRegHistory> GetByAdmCdeAppStatusId(TransactionManager transactionManager, System.Decimal? _admCdeAppStatusId)
		{
			int count = -1;
			return GetByAdmCdeAppStatusId(transactionManager, _admCdeAppStatusId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_ADM_CDE_APP_STATUS key.
		///		FK_ADM_APP_REG_HISTORY_ADM_CDE_APP_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeAppStatusId">حالة المتقدم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		public TList<AdmAppRegHistory> GetByAdmCdeAppStatusId(TransactionManager transactionManager, System.Decimal? _admCdeAppStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCdeAppStatusId(transactionManager, _admCdeAppStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_ADM_CDE_APP_STATUS key.
		///		fkAdmAppRegHistoryAdmCdeAppStatus Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admCdeAppStatusId">حالة المتقدم</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		public TList<AdmAppRegHistory> GetByAdmCdeAppStatusId(System.Decimal? _admCdeAppStatusId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmCdeAppStatusId(null, _admCdeAppStatusId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_ADM_CDE_APP_STATUS key.
		///		fkAdmAppRegHistoryAdmCdeAppStatus Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admCdeAppStatusId">حالة المتقدم</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		public TList<AdmAppRegHistory> GetByAdmCdeAppStatusId(System.Decimal? _admCdeAppStatusId, int start, int pageLength,out int count)
		{
			return GetByAdmCdeAppStatusId(null, _admCdeAppStatusId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_ADM_CDE_APP_STATUS key.
		///		FK_ADM_APP_REG_HISTORY_ADM_CDE_APP_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeAppStatusId">حالة المتقدم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		public abstract TList<AdmAppRegHistory> GetByAdmCdeAppStatusId(TransactionManager transactionManager, System.Decimal? _admCdeAppStatusId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_ADM_CDE_STATUS_RSN key.
		///		FK_ADM_APP_REG_HISTORY_ADM_CDE_STATUS_RSN Description: 
		/// </summary>
		/// <param name="_admCdeStatusRsnId">XXسبب الرفضXX</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		public TList<AdmAppRegHistory> GetByAdmCdeStatusRsnId(System.Int32? _admCdeStatusRsnId)
		{
			int count = -1;
			return GetByAdmCdeStatusRsnId(_admCdeStatusRsnId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_ADM_CDE_STATUS_RSN key.
		///		FK_ADM_APP_REG_HISTORY_ADM_CDE_STATUS_RSN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeStatusRsnId">XXسبب الرفضXX</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAppRegHistory> GetByAdmCdeStatusRsnId(TransactionManager transactionManager, System.Int32? _admCdeStatusRsnId)
		{
			int count = -1;
			return GetByAdmCdeStatusRsnId(transactionManager, _admCdeStatusRsnId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_ADM_CDE_STATUS_RSN key.
		///		FK_ADM_APP_REG_HISTORY_ADM_CDE_STATUS_RSN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeStatusRsnId">XXسبب الرفضXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		public TList<AdmAppRegHistory> GetByAdmCdeStatusRsnId(TransactionManager transactionManager, System.Int32? _admCdeStatusRsnId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCdeStatusRsnId(transactionManager, _admCdeStatusRsnId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_ADM_CDE_STATUS_RSN key.
		///		fkAdmAppRegHistoryAdmCdeStatusRsn Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admCdeStatusRsnId">XXسبب الرفضXX</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		public TList<AdmAppRegHistory> GetByAdmCdeStatusRsnId(System.Int32? _admCdeStatusRsnId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmCdeStatusRsnId(null, _admCdeStatusRsnId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_ADM_CDE_STATUS_RSN key.
		///		fkAdmAppRegHistoryAdmCdeStatusRsn Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admCdeStatusRsnId">XXسبب الرفضXX</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		public TList<AdmAppRegHistory> GetByAdmCdeStatusRsnId(System.Int32? _admCdeStatusRsnId, int start, int pageLength,out int count)
		{
			return GetByAdmCdeStatusRsnId(null, _admCdeStatusRsnId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_ADM_CDE_STATUS_RSN key.
		///		FK_ADM_APP_REG_HISTORY_ADM_CDE_STATUS_RSN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeStatusRsnId">XXسبب الرفضXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		public abstract TList<AdmAppRegHistory> GetByAdmCdeStatusRsnId(TransactionManager transactionManager, System.Int32? _admCdeStatusRsnId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_ADM_CDE_STATUS1 key.
		///		FK_ADM_APP_REG_HISTORY_ADM_CDE_STATUS1 Description: 
		/// </summary>
		/// <param name="_admCdeStatusOldId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		public TList<AdmAppRegHistory> GetByAdmCdeStatusOldId(System.Decimal? _admCdeStatusOldId)
		{
			int count = -1;
			return GetByAdmCdeStatusOldId(_admCdeStatusOldId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_ADM_CDE_STATUS1 key.
		///		FK_ADM_APP_REG_HISTORY_ADM_CDE_STATUS1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeStatusOldId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAppRegHistory> GetByAdmCdeStatusOldId(TransactionManager transactionManager, System.Decimal? _admCdeStatusOldId)
		{
			int count = -1;
			return GetByAdmCdeStatusOldId(transactionManager, _admCdeStatusOldId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_ADM_CDE_STATUS1 key.
		///		FK_ADM_APP_REG_HISTORY_ADM_CDE_STATUS1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeStatusOldId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		public TList<AdmAppRegHistory> GetByAdmCdeStatusOldId(TransactionManager transactionManager, System.Decimal? _admCdeStatusOldId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCdeStatusOldId(transactionManager, _admCdeStatusOldId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_ADM_CDE_STATUS1 key.
		///		fkAdmAppRegHistoryAdmCdeStatus1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admCdeStatusOldId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		public TList<AdmAppRegHistory> GetByAdmCdeStatusOldId(System.Decimal? _admCdeStatusOldId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmCdeStatusOldId(null, _admCdeStatusOldId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_ADM_CDE_STATUS1 key.
		///		fkAdmAppRegHistoryAdmCdeStatus1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admCdeStatusOldId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		public TList<AdmAppRegHistory> GetByAdmCdeStatusOldId(System.Decimal? _admCdeStatusOldId, int start, int pageLength,out int count)
		{
			return GetByAdmCdeStatusOldId(null, _admCdeStatusOldId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_ADM_CDE_STATUS1 key.
		///		FK_ADM_APP_REG_HISTORY_ADM_CDE_STATUS1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeStatusOldId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		public abstract TList<AdmAppRegHistory> GetByAdmCdeStatusOldId(TransactionManager transactionManager, System.Decimal? _admCdeStatusOldId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_Adm_Decision_Status key.
		///		FK_ADM_APP_REG_HISTORY_Adm_Decision_Status Description: 
		/// </summary>
		/// <param name="_admDecisionStatusId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		public TList<AdmAppRegHistory> GetByAdmDecisionStatusId(System.Decimal? _admDecisionStatusId)
		{
			int count = -1;
			return GetByAdmDecisionStatusId(_admDecisionStatusId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_Adm_Decision_Status key.
		///		FK_ADM_APP_REG_HISTORY_Adm_Decision_Status Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admDecisionStatusId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAppRegHistory> GetByAdmDecisionStatusId(TransactionManager transactionManager, System.Decimal? _admDecisionStatusId)
		{
			int count = -1;
			return GetByAdmDecisionStatusId(transactionManager, _admDecisionStatusId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_Adm_Decision_Status key.
		///		FK_ADM_APP_REG_HISTORY_Adm_Decision_Status Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admDecisionStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		public TList<AdmAppRegHistory> GetByAdmDecisionStatusId(TransactionManager transactionManager, System.Decimal? _admDecisionStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmDecisionStatusId(transactionManager, _admDecisionStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_Adm_Decision_Status key.
		///		fkAdmAppRegHistoryAdmDecisionStatus Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admDecisionStatusId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		public TList<AdmAppRegHistory> GetByAdmDecisionStatusId(System.Decimal? _admDecisionStatusId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmDecisionStatusId(null, _admDecisionStatusId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_Adm_Decision_Status key.
		///		fkAdmAppRegHistoryAdmDecisionStatus Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admDecisionStatusId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		public TList<AdmAppRegHistory> GetByAdmDecisionStatusId(System.Decimal? _admDecisionStatusId, int start, int pageLength,out int count)
		{
			return GetByAdmDecisionStatusId(null, _admDecisionStatusId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_Adm_Decision_Status key.
		///		FK_ADM_APP_REG_HISTORY_Adm_Decision_Status Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admDecisionStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		public abstract TList<AdmAppRegHistory> GetByAdmDecisionStatusId(TransactionManager transactionManager, System.Decimal? _admDecisionStatusId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_ADM_OPEN_ACAD_SEMESTER key.
		///		FK_ADM_APP_REG_HISTORY_ADM_OPEN_ACAD_SEMESTER Description: 
		/// </summary>
		/// <param name="_admOpenAcadSemesterId">عام وفصل طلب الالتحاق</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		public TList<AdmAppRegHistory> GetByAdmOpenAcadSemesterId(System.Decimal? _admOpenAcadSemesterId)
		{
			int count = -1;
			return GetByAdmOpenAcadSemesterId(_admOpenAcadSemesterId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_ADM_OPEN_ACAD_SEMESTER key.
		///		FK_ADM_APP_REG_HISTORY_ADM_OPEN_ACAD_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admOpenAcadSemesterId">عام وفصل طلب الالتحاق</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAppRegHistory> GetByAdmOpenAcadSemesterId(TransactionManager transactionManager, System.Decimal? _admOpenAcadSemesterId)
		{
			int count = -1;
			return GetByAdmOpenAcadSemesterId(transactionManager, _admOpenAcadSemesterId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_ADM_OPEN_ACAD_SEMESTER key.
		///		FK_ADM_APP_REG_HISTORY_ADM_OPEN_ACAD_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admOpenAcadSemesterId">عام وفصل طلب الالتحاق</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		public TList<AdmAppRegHistory> GetByAdmOpenAcadSemesterId(TransactionManager transactionManager, System.Decimal? _admOpenAcadSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmOpenAcadSemesterId(transactionManager, _admOpenAcadSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_ADM_OPEN_ACAD_SEMESTER key.
		///		fkAdmAppRegHistoryAdmOpenAcadSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admOpenAcadSemesterId">عام وفصل طلب الالتحاق</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		public TList<AdmAppRegHistory> GetByAdmOpenAcadSemesterId(System.Decimal? _admOpenAcadSemesterId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmOpenAcadSemesterId(null, _admOpenAcadSemesterId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_ADM_OPEN_ACAD_SEMESTER key.
		///		fkAdmAppRegHistoryAdmOpenAcadSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admOpenAcadSemesterId">عام وفصل طلب الالتحاق</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		public TList<AdmAppRegHistory> GetByAdmOpenAcadSemesterId(System.Decimal? _admOpenAcadSemesterId, int start, int pageLength,out int count)
		{
			return GetByAdmOpenAcadSemesterId(null, _admOpenAcadSemesterId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_ADM_OPEN_ACAD_SEMESTER key.
		///		FK_ADM_APP_REG_HISTORY_ADM_OPEN_ACAD_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admOpenAcadSemesterId">عام وفصل طلب الالتحاق</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		public abstract TList<AdmAppRegHistory> GetByAdmOpenAcadSemesterId(TransactionManager transactionManager, System.Decimal? _admOpenAcadSemesterId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_AS_CODE_DEGREE key.
		///		FK_ADM_APP_REG_HISTORY_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="_asCodeDegreeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		public TList<AdmAppRegHistory> GetByAsCodeDegreeId(System.Decimal? _asCodeDegreeId)
		{
			int count = -1;
			return GetByAsCodeDegreeId(_asCodeDegreeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_AS_CODE_DEGREE key.
		///		FK_ADM_APP_REG_HISTORY_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAppRegHistory> GetByAsCodeDegreeId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeId)
		{
			int count = -1;
			return GetByAsCodeDegreeId(transactionManager, _asCodeDegreeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_AS_CODE_DEGREE key.
		///		FK_ADM_APP_REG_HISTORY_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		public TList<AdmAppRegHistory> GetByAsCodeDegreeId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsCodeDegreeId(transactionManager, _asCodeDegreeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_AS_CODE_DEGREE key.
		///		fkAdmAppRegHistoryAsCodeDegree Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		public TList<AdmAppRegHistory> GetByAsCodeDegreeId(System.Decimal? _asCodeDegreeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsCodeDegreeId(null, _asCodeDegreeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_AS_CODE_DEGREE key.
		///		fkAdmAppRegHistoryAsCodeDegree Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		public TList<AdmAppRegHistory> GetByAsCodeDegreeId(System.Decimal? _asCodeDegreeId, int start, int pageLength,out int count)
		{
			return GetByAsCodeDegreeId(null, _asCodeDegreeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_AS_CODE_DEGREE key.
		///		FK_ADM_APP_REG_HISTORY_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		public abstract TList<AdmAppRegHistory> GetByAsCodeDegreeId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_AS_CODE_DEGREE_CLASS key.
		///		FK_ADM_APP_REG_HISTORY_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		public TList<AdmAppRegHistory> GetByAsCodeDegreeClassId(System.Decimal? _asCodeDegreeClassId)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(_asCodeDegreeClassId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_AS_CODE_DEGREE_CLASS key.
		///		FK_ADM_APP_REG_HISTORY_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAppRegHistory> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeClassId)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(transactionManager, _asCodeDegreeClassId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_AS_CODE_DEGREE_CLASS key.
		///		FK_ADM_APP_REG_HISTORY_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		public TList<AdmAppRegHistory> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeClassId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(transactionManager, _asCodeDegreeClassId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_AS_CODE_DEGREE_CLASS key.
		///		fkAdmAppRegHistoryAsCodeDegreeClass Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		public TList<AdmAppRegHistory> GetByAsCodeDegreeClassId(System.Decimal? _asCodeDegreeClassId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsCodeDegreeClassId(null, _asCodeDegreeClassId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_AS_CODE_DEGREE_CLASS key.
		///		fkAdmAppRegHistoryAsCodeDegreeClass Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		public TList<AdmAppRegHistory> GetByAsCodeDegreeClassId(System.Decimal? _asCodeDegreeClassId, int start, int pageLength,out int count)
		{
			return GetByAsCodeDegreeClassId(null, _asCodeDegreeClassId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_AS_CODE_DEGREE_CLASS key.
		///		FK_ADM_APP_REG_HISTORY_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		public abstract TList<AdmAppRegHistory> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeClassId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_ED_ACAD_YEAR key.
		///		FK_ADM_APP_REG_HISTORY_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="_edAcadYearId">عام الالتحاق الفعلى</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		public TList<AdmAppRegHistory> GetByEdAcadYearId(System.Decimal? _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(_edAcadYearId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_ED_ACAD_YEAR key.
		///		FK_ADM_APP_REG_HISTORY_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">عام الالتحاق الفعلى</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAppRegHistory> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal? _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_ED_ACAD_YEAR key.
		///		FK_ADM_APP_REG_HISTORY_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">عام الالتحاق الفعلى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		public TList<AdmAppRegHistory> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal? _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_ED_ACAD_YEAR key.
		///		fkAdmAppRegHistoryEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId">عام الالتحاق الفعلى</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		public TList<AdmAppRegHistory> GetByEdAcadYearId(System.Decimal? _edAcadYearId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_ED_ACAD_YEAR key.
		///		fkAdmAppRegHistoryEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId">عام الالتحاق الفعلى</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		public TList<AdmAppRegHistory> GetByEdAcadYearId(System.Decimal? _edAcadYearId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_ED_ACAD_YEAR key.
		///		FK_ADM_APP_REG_HISTORY_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">عام الالتحاق الفعلى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		public abstract TList<AdmAppRegHistory> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal? _edAcadYearId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_ED_CODE_LEVEL key.
		///		FK_ADM_APP_REG_HISTORY_ED_CODE_LEVEL Description: 
		/// </summary>
		/// <param name="_edCodeLevelId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		public TList<AdmAppRegHistory> GetByEdCodeLevelId(System.Decimal? _edCodeLevelId)
		{
			int count = -1;
			return GetByEdCodeLevelId(_edCodeLevelId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_ED_CODE_LEVEL key.
		///		FK_ADM_APP_REG_HISTORY_ED_CODE_LEVEL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLevelId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAppRegHistory> GetByEdCodeLevelId(TransactionManager transactionManager, System.Decimal? _edCodeLevelId)
		{
			int count = -1;
			return GetByEdCodeLevelId(transactionManager, _edCodeLevelId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_ED_CODE_LEVEL key.
		///		FK_ADM_APP_REG_HISTORY_ED_CODE_LEVEL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		public TList<AdmAppRegHistory> GetByEdCodeLevelId(TransactionManager transactionManager, System.Decimal? _edCodeLevelId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeLevelId(transactionManager, _edCodeLevelId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_ED_CODE_LEVEL key.
		///		fkAdmAppRegHistoryEdCodeLevel Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeLevelId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		public TList<AdmAppRegHistory> GetByEdCodeLevelId(System.Decimal? _edCodeLevelId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeLevelId(null, _edCodeLevelId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_ED_CODE_LEVEL key.
		///		fkAdmAppRegHistoryEdCodeLevel Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		public TList<AdmAppRegHistory> GetByEdCodeLevelId(System.Decimal? _edCodeLevelId, int start, int pageLength,out int count)
		{
			return GetByEdCodeLevelId(null, _edCodeLevelId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_ED_CODE_LEVEL key.
		///		FK_ADM_APP_REG_HISTORY_ED_CODE_LEVEL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		public abstract TList<AdmAppRegHistory> GetByEdCodeLevelId(TransactionManager transactionManager, System.Decimal? _edCodeLevelId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_ED_CODE_SEMESTER key.
		///		FK_ADM_APP_REG_HISTORY_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="_edCodeSemesterId">فصل الالتحاق الفعلى</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		public TList<AdmAppRegHistory> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(_edCodeSemesterId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_ED_CODE_SEMESTER key.
		///		FK_ADM_APP_REG_HISTORY_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">فصل الالتحاق الفعلى</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAppRegHistory> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_ED_CODE_SEMESTER key.
		///		FK_ADM_APP_REG_HISTORY_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">فصل الالتحاق الفعلى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		public TList<AdmAppRegHistory> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_ED_CODE_SEMESTER key.
		///		fkAdmAppRegHistoryEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId">فصل الالتحاق الفعلى</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		public TList<AdmAppRegHistory> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_ED_CODE_SEMESTER key.
		///		fkAdmAppRegHistoryEdCodeSemester Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeSemesterId">فصل الالتحاق الفعلى</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		public TList<AdmAppRegHistory> GetByEdCodeSemesterId(System.Decimal? _edCodeSemesterId, int start, int pageLength,out int count)
		{
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_ED_CODE_SEMESTER key.
		///		FK_ADM_APP_REG_HISTORY_ED_CODE_SEMESTER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">فصل الالتحاق الفعلى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		public abstract TList<AdmAppRegHistory> GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_FEE_CDE_DISC_CAT key.
		///		FK_ADM_APP_REG_HISTORY_FEE_CDE_DISC_CAT Description: 
		/// </summary>
		/// <param name="_feeCdeDiscCatId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		public TList<AdmAppRegHistory> GetByFeeCdeDiscCatId(System.Int32? _feeCdeDiscCatId)
		{
			int count = -1;
			return GetByFeeCdeDiscCatId(_feeCdeDiscCatId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_FEE_CDE_DISC_CAT key.
		///		FK_ADM_APP_REG_HISTORY_FEE_CDE_DISC_CAT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeDiscCatId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAppRegHistory> GetByFeeCdeDiscCatId(TransactionManager transactionManager, System.Int32? _feeCdeDiscCatId)
		{
			int count = -1;
			return GetByFeeCdeDiscCatId(transactionManager, _feeCdeDiscCatId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_FEE_CDE_DISC_CAT key.
		///		FK_ADM_APP_REG_HISTORY_FEE_CDE_DISC_CAT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeDiscCatId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		public TList<AdmAppRegHistory> GetByFeeCdeDiscCatId(TransactionManager transactionManager, System.Int32? _feeCdeDiscCatId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCdeDiscCatId(transactionManager, _feeCdeDiscCatId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_FEE_CDE_DISC_CAT key.
		///		fkAdmAppRegHistoryFeeCdeDiscCat Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeCdeDiscCatId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		public TList<AdmAppRegHistory> GetByFeeCdeDiscCatId(System.Int32? _feeCdeDiscCatId, int start, int pageLength)
		{
			int count =  -1;
			return GetByFeeCdeDiscCatId(null, _feeCdeDiscCatId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_FEE_CDE_DISC_CAT key.
		///		fkAdmAppRegHistoryFeeCdeDiscCat Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeCdeDiscCatId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		public TList<AdmAppRegHistory> GetByFeeCdeDiscCatId(System.Int32? _feeCdeDiscCatId, int start, int pageLength,out int count)
		{
			return GetByFeeCdeDiscCatId(null, _feeCdeDiscCatId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_FEE_CDE_DISC_CAT key.
		///		FK_ADM_APP_REG_HISTORY_FEE_CDE_DISC_CAT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeDiscCatId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		public abstract TList<AdmAppRegHistory> GetByFeeCdeDiscCatId(TransactionManager transactionManager, System.Int32? _feeCdeDiscCatId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_FEE_CDE_DISC_TYPE key.
		///		FK_ADM_APP_REG_HISTORY_FEE_CDE_DISC_TYPE Description: 
		/// </summary>
		/// <param name="_feeCdeDiscTypeId">منحة تفوق مؤهل</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		public TList<AdmAppRegHistory> GetByFeeCdeDiscTypeId(System.Decimal? _feeCdeDiscTypeId)
		{
			int count = -1;
			return GetByFeeCdeDiscTypeId(_feeCdeDiscTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_FEE_CDE_DISC_TYPE key.
		///		FK_ADM_APP_REG_HISTORY_FEE_CDE_DISC_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeDiscTypeId">منحة تفوق مؤهل</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAppRegHistory> GetByFeeCdeDiscTypeId(TransactionManager transactionManager, System.Decimal? _feeCdeDiscTypeId)
		{
			int count = -1;
			return GetByFeeCdeDiscTypeId(transactionManager, _feeCdeDiscTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_FEE_CDE_DISC_TYPE key.
		///		FK_ADM_APP_REG_HISTORY_FEE_CDE_DISC_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeDiscTypeId">منحة تفوق مؤهل</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		public TList<AdmAppRegHistory> GetByFeeCdeDiscTypeId(TransactionManager transactionManager, System.Decimal? _feeCdeDiscTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCdeDiscTypeId(transactionManager, _feeCdeDiscTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_FEE_CDE_DISC_TYPE key.
		///		fkAdmAppRegHistoryFeeCdeDiscType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeCdeDiscTypeId">منحة تفوق مؤهل</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		public TList<AdmAppRegHistory> GetByFeeCdeDiscTypeId(System.Decimal? _feeCdeDiscTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByFeeCdeDiscTypeId(null, _feeCdeDiscTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_FEE_CDE_DISC_TYPE key.
		///		fkAdmAppRegHistoryFeeCdeDiscType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeCdeDiscTypeId">منحة تفوق مؤهل</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		public TList<AdmAppRegHistory> GetByFeeCdeDiscTypeId(System.Decimal? _feeCdeDiscTypeId, int start, int pageLength,out int count)
		{
			return GetByFeeCdeDiscTypeId(null, _feeCdeDiscTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_FEE_CDE_DISC_TYPE key.
		///		FK_ADM_APP_REG_HISTORY_FEE_CDE_DISC_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeDiscTypeId">منحة تفوق مؤهل</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		public abstract TList<AdmAppRegHistory> GetByFeeCdeDiscTypeId(TransactionManager transactionManager, System.Decimal? _feeCdeDiscTypeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_FEE_CDE_SCHSHIP_TYPE key.
		///		FK_ADM_APP_REG_HISTORY_FEE_CDE_SCHSHIP_TYPE Description: 
		/// </summary>
		/// <param name="_feeCdeSchshipTypeId">XXNU:انواع المنح الدراسية</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		public TList<AdmAppRegHistory> GetByFeeCdeSchshipTypeId(System.Int32? _feeCdeSchshipTypeId)
		{
			int count = -1;
			return GetByFeeCdeSchshipTypeId(_feeCdeSchshipTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_FEE_CDE_SCHSHIP_TYPE key.
		///		FK_ADM_APP_REG_HISTORY_FEE_CDE_SCHSHIP_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeSchshipTypeId">XXNU:انواع المنح الدراسية</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAppRegHistory> GetByFeeCdeSchshipTypeId(TransactionManager transactionManager, System.Int32? _feeCdeSchshipTypeId)
		{
			int count = -1;
			return GetByFeeCdeSchshipTypeId(transactionManager, _feeCdeSchshipTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_FEE_CDE_SCHSHIP_TYPE key.
		///		FK_ADM_APP_REG_HISTORY_FEE_CDE_SCHSHIP_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeSchshipTypeId">XXNU:انواع المنح الدراسية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		public TList<AdmAppRegHistory> GetByFeeCdeSchshipTypeId(TransactionManager transactionManager, System.Int32? _feeCdeSchshipTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCdeSchshipTypeId(transactionManager, _feeCdeSchshipTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_FEE_CDE_SCHSHIP_TYPE key.
		///		fkAdmAppRegHistoryFeeCdeSchshipType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeCdeSchshipTypeId">XXNU:انواع المنح الدراسية</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		public TList<AdmAppRegHistory> GetByFeeCdeSchshipTypeId(System.Int32? _feeCdeSchshipTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByFeeCdeSchshipTypeId(null, _feeCdeSchshipTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_FEE_CDE_SCHSHIP_TYPE key.
		///		fkAdmAppRegHistoryFeeCdeSchshipType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeCdeSchshipTypeId">XXNU:انواع المنح الدراسية</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		public TList<AdmAppRegHistory> GetByFeeCdeSchshipTypeId(System.Int32? _feeCdeSchshipTypeId, int start, int pageLength,out int count)
		{
			return GetByFeeCdeSchshipTypeId(null, _feeCdeSchshipTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_FEE_CDE_SCHSHIP_TYPE key.
		///		FK_ADM_APP_REG_HISTORY_FEE_CDE_SCHSHIP_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeSchshipTypeId">XXNU:انواع المنح الدراسية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		public abstract TList<AdmAppRegHistory> GetByFeeCdeSchshipTypeId(TransactionManager transactionManager, System.Int32? _feeCdeSchshipTypeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_SE_USER key.
		///		FK_ADM_APP_REG_HISTORY_SE_USER Description: 
		/// </summary>
		/// <param name="_seUserId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		public TList<AdmAppRegHistory> GetBySeUserId(System.Decimal? _seUserId)
		{
			int count = -1;
			return GetBySeUserId(_seUserId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_SE_USER key.
		///		FK_ADM_APP_REG_HISTORY_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAppRegHistory> GetBySeUserId(TransactionManager transactionManager, System.Decimal? _seUserId)
		{
			int count = -1;
			return GetBySeUserId(transactionManager, _seUserId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_SE_USER key.
		///		FK_ADM_APP_REG_HISTORY_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		public TList<AdmAppRegHistory> GetBySeUserId(TransactionManager transactionManager, System.Decimal? _seUserId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeUserId(transactionManager, _seUserId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_SE_USER key.
		///		fkAdmAppRegHistorySeUser Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		public TList<AdmAppRegHistory> GetBySeUserId(System.Decimal? _seUserId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySeUserId(null, _seUserId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_SE_USER key.
		///		fkAdmAppRegHistorySeUser Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		public TList<AdmAppRegHistory> GetBySeUserId(System.Decimal? _seUserId, int start, int pageLength,out int count)
		{
			return GetBySeUserId(null, _seUserId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_SE_USER key.
		///		FK_ADM_APP_REG_HISTORY_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		public abstract TList<AdmAppRegHistory> GetBySeUserId(TransactionManager transactionManager, System.Decimal? _seUserId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_SPO_SPONSOR key.
		///		FK_ADM_APP_REG_HISTORY_SPO_SPONSOR Description: 
		/// </summary>
		/// <param name="_spoSponsorId">الجهة المانحة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		public TList<AdmAppRegHistory> GetBySpoSponsorId(System.Decimal? _spoSponsorId)
		{
			int count = -1;
			return GetBySpoSponsorId(_spoSponsorId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_SPO_SPONSOR key.
		///		FK_ADM_APP_REG_HISTORY_SPO_SPONSOR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorId">الجهة المانحة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAppRegHistory> GetBySpoSponsorId(TransactionManager transactionManager, System.Decimal? _spoSponsorId)
		{
			int count = -1;
			return GetBySpoSponsorId(transactionManager, _spoSponsorId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_SPO_SPONSOR key.
		///		FK_ADM_APP_REG_HISTORY_SPO_SPONSOR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorId">الجهة المانحة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		public TList<AdmAppRegHistory> GetBySpoSponsorId(TransactionManager transactionManager, System.Decimal? _spoSponsorId, int start, int pageLength)
		{
			int count = -1;
			return GetBySpoSponsorId(transactionManager, _spoSponsorId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_SPO_SPONSOR key.
		///		fkAdmAppRegHistorySpoSponsor Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_spoSponsorId">الجهة المانحة</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		public TList<AdmAppRegHistory> GetBySpoSponsorId(System.Decimal? _spoSponsorId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySpoSponsorId(null, _spoSponsorId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_SPO_SPONSOR key.
		///		fkAdmAppRegHistorySpoSponsor Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_spoSponsorId">الجهة المانحة</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		public TList<AdmAppRegHistory> GetBySpoSponsorId(System.Decimal? _spoSponsorId, int start, int pageLength,out int count)
		{
			return GetBySpoSponsorId(null, _spoSponsorId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_SPO_SPONSOR key.
		///		FK_ADM_APP_REG_HISTORY_SPO_SPONSOR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorId">الجهة المانحة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		public abstract TList<AdmAppRegHistory> GetBySpoSponsorId(TransactionManager transactionManager, System.Decimal? _spoSponsorId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_SPO_SPONSOR_TYPE key.
		///		FK_ADM_APP_REG_HISTORY_SPO_SPONSOR_TYPE Description: 
		/// </summary>
		/// <param name="_spoSponsorTypeId">Ejust نوع الكفيل حكومى-خاص-جامعة....</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		public TList<AdmAppRegHistory> GetBySpoSponsorTypeId(System.Decimal? _spoSponsorTypeId)
		{
			int count = -1;
			return GetBySpoSponsorTypeId(_spoSponsorTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_SPO_SPONSOR_TYPE key.
		///		FK_ADM_APP_REG_HISTORY_SPO_SPONSOR_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorTypeId">Ejust نوع الكفيل حكومى-خاص-جامعة....</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAppRegHistory> GetBySpoSponsorTypeId(TransactionManager transactionManager, System.Decimal? _spoSponsorTypeId)
		{
			int count = -1;
			return GetBySpoSponsorTypeId(transactionManager, _spoSponsorTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_SPO_SPONSOR_TYPE key.
		///		FK_ADM_APP_REG_HISTORY_SPO_SPONSOR_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorTypeId">Ejust نوع الكفيل حكومى-خاص-جامعة....</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		public TList<AdmAppRegHistory> GetBySpoSponsorTypeId(TransactionManager transactionManager, System.Decimal? _spoSponsorTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetBySpoSponsorTypeId(transactionManager, _spoSponsorTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_SPO_SPONSOR_TYPE key.
		///		fkAdmAppRegHistorySpoSponsorType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_spoSponsorTypeId">Ejust نوع الكفيل حكومى-خاص-جامعة....</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		public TList<AdmAppRegHistory> GetBySpoSponsorTypeId(System.Decimal? _spoSponsorTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySpoSponsorTypeId(null, _spoSponsorTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_SPO_SPONSOR_TYPE key.
		///		fkAdmAppRegHistorySpoSponsorType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_spoSponsorTypeId">Ejust نوع الكفيل حكومى-خاص-جامعة....</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		public TList<AdmAppRegHistory> GetBySpoSponsorTypeId(System.Decimal? _spoSponsorTypeId, int start, int pageLength,out int count)
		{
			return GetBySpoSponsorTypeId(null, _spoSponsorTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_REG_HISTORY_SPO_SPONSOR_TYPE key.
		///		FK_ADM_APP_REG_HISTORY_SPO_SPONSOR_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorTypeId">Ejust نوع الكفيل حكومى-خاص-جامعة....</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppRegHistory objects.</returns>
		public abstract TList<AdmAppRegHistory> GetBySpoSponsorTypeId(TransactionManager transactionManager, System.Decimal? _spoSponsorTypeId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.AdmAppRegHistory Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppRegHistoryKey key, int start, int pageLength)
		{
			return GetByAdmAppRegHistoryId(transactionManager, key.AdmAppRegHistoryId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key _dta_index_ADM_APP_REG_HISTORY_6_970797795__K1_K6_K7 index.
		/// </summary>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppRegHistory&gt;"/> class.</returns>
		public TList<AdmAppRegHistory> GetByAdmAppRegHistoryIdAsCodeDegreeIdAsCodeDegreeClassId(System.Decimal _admAppRegHistoryId, System.Decimal? _asCodeDegreeId, System.Decimal? _asCodeDegreeClassId)
		{
			int count = -1;
			return GetByAdmAppRegHistoryIdAsCodeDegreeIdAsCodeDegreeClassId(null,_admAppRegHistoryId, _asCodeDegreeId, _asCodeDegreeClassId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the _dta_index_ADM_APP_REG_HISTORY_6_970797795__K1_K6_K7 index.
		/// </summary>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppRegHistory&gt;"/> class.</returns>
		public TList<AdmAppRegHistory> GetByAdmAppRegHistoryIdAsCodeDegreeIdAsCodeDegreeClassId(System.Decimal _admAppRegHistoryId, System.Decimal? _asCodeDegreeId, System.Decimal? _asCodeDegreeClassId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppRegHistoryIdAsCodeDegreeIdAsCodeDegreeClassId(null, _admAppRegHistoryId, _asCodeDegreeId, _asCodeDegreeClassId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the _dta_index_ADM_APP_REG_HISTORY_6_970797795__K1_K6_K7 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppRegHistory&gt;"/> class.</returns>
		public TList<AdmAppRegHistory> GetByAdmAppRegHistoryIdAsCodeDegreeIdAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal _admAppRegHistoryId, System.Decimal? _asCodeDegreeId, System.Decimal? _asCodeDegreeClassId)
		{
			int count = -1;
			return GetByAdmAppRegHistoryIdAsCodeDegreeIdAsCodeDegreeClassId(transactionManager, _admAppRegHistoryId, _asCodeDegreeId, _asCodeDegreeClassId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the _dta_index_ADM_APP_REG_HISTORY_6_970797795__K1_K6_K7 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppRegHistory&gt;"/> class.</returns>
		public TList<AdmAppRegHistory> GetByAdmAppRegHistoryIdAsCodeDegreeIdAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal _admAppRegHistoryId, System.Decimal? _asCodeDegreeId, System.Decimal? _asCodeDegreeClassId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppRegHistoryIdAsCodeDegreeIdAsCodeDegreeClassId(transactionManager, _admAppRegHistoryId, _asCodeDegreeId, _asCodeDegreeClassId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the _dta_index_ADM_APP_REG_HISTORY_6_970797795__K1_K6_K7 index.
		/// </summary>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppRegHistory&gt;"/> class.</returns>
		public TList<AdmAppRegHistory> GetByAdmAppRegHistoryIdAsCodeDegreeIdAsCodeDegreeClassId(System.Decimal _admAppRegHistoryId, System.Decimal? _asCodeDegreeId, System.Decimal? _asCodeDegreeClassId, int start, int pageLength, out int count)
		{
			return GetByAdmAppRegHistoryIdAsCodeDegreeIdAsCodeDegreeClassId(null, _admAppRegHistoryId, _asCodeDegreeId, _asCodeDegreeClassId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the _dta_index_ADM_APP_REG_HISTORY_6_970797795__K1_K6_K7 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppRegHistory&gt;"/> class.</returns>
		public abstract TList<AdmAppRegHistory> GetByAdmAppRegHistoryIdAsCodeDegreeIdAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal _admAppRegHistoryId, System.Decimal? _asCodeDegreeId, System.Decimal? _asCodeDegreeClassId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key _dta_index_ADM_APP_REG_HISTORY_6_970797795__K11_K4_K7_K5_K9 index.
		/// </summary>
		/// <param name="_admCdeStatusId"></param>
		/// <param name="_admCdeAppTypeId"></param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="_currentFlg"></param>
		/// <param name="_admOpenAcadSemesterId">عام وفصل طلب الالتحاق</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppRegHistory&gt;"/> class.</returns>
		public TList<AdmAppRegHistory> GetByAdmCdeStatusIdAdmCdeAppTypeIdAsCodeDegreeClassIdCurrentFlgAdmOpenAcadSemesterId(System.Decimal? _admCdeStatusId, System.Decimal? _admCdeAppTypeId, System.Decimal? _asCodeDegreeClassId, System.Decimal? _currentFlg, System.Decimal? _admOpenAcadSemesterId)
		{
			int count = -1;
			return GetByAdmCdeStatusIdAdmCdeAppTypeIdAsCodeDegreeClassIdCurrentFlgAdmOpenAcadSemesterId(null,_admCdeStatusId, _admCdeAppTypeId, _asCodeDegreeClassId, _currentFlg, _admOpenAcadSemesterId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the _dta_index_ADM_APP_REG_HISTORY_6_970797795__K11_K4_K7_K5_K9 index.
		/// </summary>
		/// <param name="_admCdeStatusId"></param>
		/// <param name="_admCdeAppTypeId"></param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="_currentFlg"></param>
		/// <param name="_admOpenAcadSemesterId">عام وفصل طلب الالتحاق</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppRegHistory&gt;"/> class.</returns>
		public TList<AdmAppRegHistory> GetByAdmCdeStatusIdAdmCdeAppTypeIdAsCodeDegreeClassIdCurrentFlgAdmOpenAcadSemesterId(System.Decimal? _admCdeStatusId, System.Decimal? _admCdeAppTypeId, System.Decimal? _asCodeDegreeClassId, System.Decimal? _currentFlg, System.Decimal? _admOpenAcadSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCdeStatusIdAdmCdeAppTypeIdAsCodeDegreeClassIdCurrentFlgAdmOpenAcadSemesterId(null, _admCdeStatusId, _admCdeAppTypeId, _asCodeDegreeClassId, _currentFlg, _admOpenAcadSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the _dta_index_ADM_APP_REG_HISTORY_6_970797795__K11_K4_K7_K5_K9 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeStatusId"></param>
		/// <param name="_admCdeAppTypeId"></param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="_currentFlg"></param>
		/// <param name="_admOpenAcadSemesterId">عام وفصل طلب الالتحاق</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppRegHistory&gt;"/> class.</returns>
		public TList<AdmAppRegHistory> GetByAdmCdeStatusIdAdmCdeAppTypeIdAsCodeDegreeClassIdCurrentFlgAdmOpenAcadSemesterId(TransactionManager transactionManager, System.Decimal? _admCdeStatusId, System.Decimal? _admCdeAppTypeId, System.Decimal? _asCodeDegreeClassId, System.Decimal? _currentFlg, System.Decimal? _admOpenAcadSemesterId)
		{
			int count = -1;
			return GetByAdmCdeStatusIdAdmCdeAppTypeIdAsCodeDegreeClassIdCurrentFlgAdmOpenAcadSemesterId(transactionManager, _admCdeStatusId, _admCdeAppTypeId, _asCodeDegreeClassId, _currentFlg, _admOpenAcadSemesterId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the _dta_index_ADM_APP_REG_HISTORY_6_970797795__K11_K4_K7_K5_K9 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeStatusId"></param>
		/// <param name="_admCdeAppTypeId"></param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="_currentFlg"></param>
		/// <param name="_admOpenAcadSemesterId">عام وفصل طلب الالتحاق</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppRegHistory&gt;"/> class.</returns>
		public TList<AdmAppRegHistory> GetByAdmCdeStatusIdAdmCdeAppTypeIdAsCodeDegreeClassIdCurrentFlgAdmOpenAcadSemesterId(TransactionManager transactionManager, System.Decimal? _admCdeStatusId, System.Decimal? _admCdeAppTypeId, System.Decimal? _asCodeDegreeClassId, System.Decimal? _currentFlg, System.Decimal? _admOpenAcadSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCdeStatusIdAdmCdeAppTypeIdAsCodeDegreeClassIdCurrentFlgAdmOpenAcadSemesterId(transactionManager, _admCdeStatusId, _admCdeAppTypeId, _asCodeDegreeClassId, _currentFlg, _admOpenAcadSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the _dta_index_ADM_APP_REG_HISTORY_6_970797795__K11_K4_K7_K5_K9 index.
		/// </summary>
		/// <param name="_admCdeStatusId"></param>
		/// <param name="_admCdeAppTypeId"></param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="_currentFlg"></param>
		/// <param name="_admOpenAcadSemesterId">عام وفصل طلب الالتحاق</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppRegHistory&gt;"/> class.</returns>
		public TList<AdmAppRegHistory> GetByAdmCdeStatusIdAdmCdeAppTypeIdAsCodeDegreeClassIdCurrentFlgAdmOpenAcadSemesterId(System.Decimal? _admCdeStatusId, System.Decimal? _admCdeAppTypeId, System.Decimal? _asCodeDegreeClassId, System.Decimal? _currentFlg, System.Decimal? _admOpenAcadSemesterId, int start, int pageLength, out int count)
		{
			return GetByAdmCdeStatusIdAdmCdeAppTypeIdAsCodeDegreeClassIdCurrentFlgAdmOpenAcadSemesterId(null, _admCdeStatusId, _admCdeAppTypeId, _asCodeDegreeClassId, _currentFlg, _admOpenAcadSemesterId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the _dta_index_ADM_APP_REG_HISTORY_6_970797795__K11_K4_K7_K5_K9 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeStatusId"></param>
		/// <param name="_admCdeAppTypeId"></param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="_currentFlg"></param>
		/// <param name="_admOpenAcadSemesterId">عام وفصل طلب الالتحاق</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppRegHistory&gt;"/> class.</returns>
		public abstract TList<AdmAppRegHistory> GetByAdmCdeStatusIdAdmCdeAppTypeIdAsCodeDegreeClassIdCurrentFlgAdmOpenAcadSemesterId(TransactionManager transactionManager, System.Decimal? _admCdeStatusId, System.Decimal? _admCdeAppTypeId, System.Decimal? _asCodeDegreeClassId, System.Decimal? _currentFlg, System.Decimal? _admOpenAcadSemesterId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key ADM_ADMISSION_BAND_ID_NonClusteredIndex-20131121-211257 index.
		/// </summary>
		/// <param name="_admAdmissionBandId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppRegHistory&gt;"/> class.</returns>
		public TList<AdmAppRegHistory> GetByAdmAdmissionBandId(System.Decimal? _admAdmissionBandId)
		{
			int count = -1;
			return GetByAdmAdmissionBandId(null,_admAdmissionBandId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the ADM_ADMISSION_BAND_ID_NonClusteredIndex-20131121-211257 index.
		/// </summary>
		/// <param name="_admAdmissionBandId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppRegHistory&gt;"/> class.</returns>
		public TList<AdmAppRegHistory> GetByAdmAdmissionBandId(System.Decimal? _admAdmissionBandId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAdmissionBandId(null, _admAdmissionBandId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the ADM_ADMISSION_BAND_ID_NonClusteredIndex-20131121-211257 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAdmissionBandId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppRegHistory&gt;"/> class.</returns>
		public TList<AdmAppRegHistory> GetByAdmAdmissionBandId(TransactionManager transactionManager, System.Decimal? _admAdmissionBandId)
		{
			int count = -1;
			return GetByAdmAdmissionBandId(transactionManager, _admAdmissionBandId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the ADM_ADMISSION_BAND_ID_NonClusteredIndex-20131121-211257 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAdmissionBandId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppRegHistory&gt;"/> class.</returns>
		public TList<AdmAppRegHistory> GetByAdmAdmissionBandId(TransactionManager transactionManager, System.Decimal? _admAdmissionBandId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAdmissionBandId(transactionManager, _admAdmissionBandId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the ADM_ADMISSION_BAND_ID_NonClusteredIndex-20131121-211257 index.
		/// </summary>
		/// <param name="_admAdmissionBandId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppRegHistory&gt;"/> class.</returns>
		public TList<AdmAppRegHistory> GetByAdmAdmissionBandId(System.Decimal? _admAdmissionBandId, int start, int pageLength, out int count)
		{
			return GetByAdmAdmissionBandId(null, _admAdmissionBandId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the ADM_ADMISSION_BAND_ID_NonClusteredIndex-20131121-211257 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAdmissionBandId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppRegHistory&gt;"/> class.</returns>
		public abstract TList<AdmAppRegHistory> GetByAdmAdmissionBandId(TransactionManager transactionManager, System.Decimal? _admAdmissionBandId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key ADM_APP_REG_HISTORY_UNIQUE_INDEX index.
		/// </summary>
		/// <param name="_admApplicantId"></param>
		/// <param name="_admCdeAppTypeId"></param>
		/// <param name="_admOpenAcadSemesterId">عام وفصل طلب الالتحاق</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppRegHistory"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppRegHistory GetByAdmApplicantIdAdmCdeAppTypeIdAdmOpenAcadSemesterId(System.Decimal? _admApplicantId, System.Decimal? _admCdeAppTypeId, System.Decimal? _admOpenAcadSemesterId)
		{
			int count = -1;
			return GetByAdmApplicantIdAdmCdeAppTypeIdAdmOpenAcadSemesterId(null,_admApplicantId, _admCdeAppTypeId, _admOpenAcadSemesterId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the ADM_APP_REG_HISTORY_UNIQUE_INDEX index.
		/// </summary>
		/// <param name="_admApplicantId"></param>
		/// <param name="_admCdeAppTypeId"></param>
		/// <param name="_admOpenAcadSemesterId">عام وفصل طلب الالتحاق</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppRegHistory"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppRegHistory GetByAdmApplicantIdAdmCdeAppTypeIdAdmOpenAcadSemesterId(System.Decimal? _admApplicantId, System.Decimal? _admCdeAppTypeId, System.Decimal? _admOpenAcadSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmApplicantIdAdmCdeAppTypeIdAdmOpenAcadSemesterId(null, _admApplicantId, _admCdeAppTypeId, _admOpenAcadSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the ADM_APP_REG_HISTORY_UNIQUE_INDEX index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="_admCdeAppTypeId"></param>
		/// <param name="_admOpenAcadSemesterId">عام وفصل طلب الالتحاق</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppRegHistory"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppRegHistory GetByAdmApplicantIdAdmCdeAppTypeIdAdmOpenAcadSemesterId(TransactionManager transactionManager, System.Decimal? _admApplicantId, System.Decimal? _admCdeAppTypeId, System.Decimal? _admOpenAcadSemesterId)
		{
			int count = -1;
			return GetByAdmApplicantIdAdmCdeAppTypeIdAdmOpenAcadSemesterId(transactionManager, _admApplicantId, _admCdeAppTypeId, _admOpenAcadSemesterId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the ADM_APP_REG_HISTORY_UNIQUE_INDEX index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="_admCdeAppTypeId"></param>
		/// <param name="_admOpenAcadSemesterId">عام وفصل طلب الالتحاق</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppRegHistory"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppRegHistory GetByAdmApplicantIdAdmCdeAppTypeIdAdmOpenAcadSemesterId(TransactionManager transactionManager, System.Decimal? _admApplicantId, System.Decimal? _admCdeAppTypeId, System.Decimal? _admOpenAcadSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmApplicantIdAdmCdeAppTypeIdAdmOpenAcadSemesterId(transactionManager, _admApplicantId, _admCdeAppTypeId, _admOpenAcadSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the ADM_APP_REG_HISTORY_UNIQUE_INDEX index.
		/// </summary>
		/// <param name="_admApplicantId"></param>
		/// <param name="_admCdeAppTypeId"></param>
		/// <param name="_admOpenAcadSemesterId">عام وفصل طلب الالتحاق</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppRegHistory"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppRegHistory GetByAdmApplicantIdAdmCdeAppTypeIdAdmOpenAcadSemesterId(System.Decimal? _admApplicantId, System.Decimal? _admCdeAppTypeId, System.Decimal? _admOpenAcadSemesterId, int start, int pageLength, out int count)
		{
			return GetByAdmApplicantIdAdmCdeAppTypeIdAdmOpenAcadSemesterId(null, _admApplicantId, _admCdeAppTypeId, _admOpenAcadSemesterId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the ADM_APP_REG_HISTORY_UNIQUE_INDEX index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="_admCdeAppTypeId"></param>
		/// <param name="_admOpenAcadSemesterId">عام وفصل طلب الالتحاق</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppRegHistory"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmAppRegHistory GetByAdmApplicantIdAdmCdeAppTypeIdAdmOpenAcadSemesterId(TransactionManager transactionManager, System.Decimal? _admApplicantId, System.Decimal? _admCdeAppTypeId, System.Decimal? _admOpenAcadSemesterId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key ADM_APPLICANT_ID_NonClusteredIndex-20131121-211006 index.
		/// </summary>
		/// <param name="_admApplicantId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppRegHistory&gt;"/> class.</returns>
		public TList<AdmAppRegHistory> GetByAdmApplicantId(System.Decimal? _admApplicantId)
		{
			int count = -1;
			return GetByAdmApplicantId(null,_admApplicantId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the ADM_APPLICANT_ID_NonClusteredIndex-20131121-211006 index.
		/// </summary>
		/// <param name="_admApplicantId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppRegHistory&gt;"/> class.</returns>
		public TList<AdmAppRegHistory> GetByAdmApplicantId(System.Decimal? _admApplicantId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmApplicantId(null, _admApplicantId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the ADM_APPLICANT_ID_NonClusteredIndex-20131121-211006 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppRegHistory&gt;"/> class.</returns>
		public TList<AdmAppRegHistory> GetByAdmApplicantId(TransactionManager transactionManager, System.Decimal? _admApplicantId)
		{
			int count = -1;
			return GetByAdmApplicantId(transactionManager, _admApplicantId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the ADM_APPLICANT_ID_NonClusteredIndex-20131121-211006 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppRegHistory&gt;"/> class.</returns>
		public TList<AdmAppRegHistory> GetByAdmApplicantId(TransactionManager transactionManager, System.Decimal? _admApplicantId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmApplicantId(transactionManager, _admApplicantId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the ADM_APPLICANT_ID_NonClusteredIndex-20131121-211006 index.
		/// </summary>
		/// <param name="_admApplicantId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppRegHistory&gt;"/> class.</returns>
		public TList<AdmAppRegHistory> GetByAdmApplicantId(System.Decimal? _admApplicantId, int start, int pageLength, out int count)
		{
			return GetByAdmApplicantId(null, _admApplicantId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the ADM_APPLICANT_ID_NonClusteredIndex-20131121-211006 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppRegHistory&gt;"/> class.</returns>
		public abstract TList<AdmAppRegHistory> GetByAdmApplicantId(TransactionManager transactionManager, System.Decimal? _admApplicantId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key ADM_CDE_APP_TYPE_ID_NonClusteredIndex-20131121-211029 index.
		/// </summary>
		/// <param name="_admCdeAppTypeId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppRegHistory&gt;"/> class.</returns>
		public TList<AdmAppRegHistory> GetByAdmCdeAppTypeId(System.Decimal? _admCdeAppTypeId)
		{
			int count = -1;
			return GetByAdmCdeAppTypeId(null,_admCdeAppTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the ADM_CDE_APP_TYPE_ID_NonClusteredIndex-20131121-211029 index.
		/// </summary>
		/// <param name="_admCdeAppTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppRegHistory&gt;"/> class.</returns>
		public TList<AdmAppRegHistory> GetByAdmCdeAppTypeId(System.Decimal? _admCdeAppTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCdeAppTypeId(null, _admCdeAppTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the ADM_CDE_APP_TYPE_ID_NonClusteredIndex-20131121-211029 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeAppTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppRegHistory&gt;"/> class.</returns>
		public TList<AdmAppRegHistory> GetByAdmCdeAppTypeId(TransactionManager transactionManager, System.Decimal? _admCdeAppTypeId)
		{
			int count = -1;
			return GetByAdmCdeAppTypeId(transactionManager, _admCdeAppTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the ADM_CDE_APP_TYPE_ID_NonClusteredIndex-20131121-211029 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeAppTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppRegHistory&gt;"/> class.</returns>
		public TList<AdmAppRegHistory> GetByAdmCdeAppTypeId(TransactionManager transactionManager, System.Decimal? _admCdeAppTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCdeAppTypeId(transactionManager, _admCdeAppTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the ADM_CDE_APP_TYPE_ID_NonClusteredIndex-20131121-211029 index.
		/// </summary>
		/// <param name="_admCdeAppTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppRegHistory&gt;"/> class.</returns>
		public TList<AdmAppRegHistory> GetByAdmCdeAppTypeId(System.Decimal? _admCdeAppTypeId, int start, int pageLength, out int count)
		{
			return GetByAdmCdeAppTypeId(null, _admCdeAppTypeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the ADM_CDE_APP_TYPE_ID_NonClusteredIndex-20131121-211029 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeAppTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppRegHistory&gt;"/> class.</returns>
		public abstract TList<AdmAppRegHistory> GetByAdmCdeAppTypeId(TransactionManager transactionManager, System.Decimal? _admCdeAppTypeId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key ADM_CDE_STATUS_ID_NonClusteredIndex-20131121-211142 index.
		/// </summary>
		/// <param name="_admCdeStatusId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppRegHistory&gt;"/> class.</returns>
		public TList<AdmAppRegHistory> GetByAdmCdeStatusId(System.Decimal? _admCdeStatusId)
		{
			int count = -1;
			return GetByAdmCdeStatusId(null,_admCdeStatusId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the ADM_CDE_STATUS_ID_NonClusteredIndex-20131121-211142 index.
		/// </summary>
		/// <param name="_admCdeStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppRegHistory&gt;"/> class.</returns>
		public TList<AdmAppRegHistory> GetByAdmCdeStatusId(System.Decimal? _admCdeStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCdeStatusId(null, _admCdeStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the ADM_CDE_STATUS_ID_NonClusteredIndex-20131121-211142 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeStatusId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppRegHistory&gt;"/> class.</returns>
		public TList<AdmAppRegHistory> GetByAdmCdeStatusId(TransactionManager transactionManager, System.Decimal? _admCdeStatusId)
		{
			int count = -1;
			return GetByAdmCdeStatusId(transactionManager, _admCdeStatusId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the ADM_CDE_STATUS_ID_NonClusteredIndex-20131121-211142 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppRegHistory&gt;"/> class.</returns>
		public TList<AdmAppRegHistory> GetByAdmCdeStatusId(TransactionManager transactionManager, System.Decimal? _admCdeStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCdeStatusId(transactionManager, _admCdeStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the ADM_CDE_STATUS_ID_NonClusteredIndex-20131121-211142 index.
		/// </summary>
		/// <param name="_admCdeStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppRegHistory&gt;"/> class.</returns>
		public TList<AdmAppRegHistory> GetByAdmCdeStatusId(System.Decimal? _admCdeStatusId, int start, int pageLength, out int count)
		{
			return GetByAdmCdeStatusId(null, _admCdeStatusId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the ADM_CDE_STATUS_ID_NonClusteredIndex-20131121-211142 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppRegHistory&gt;"/> class.</returns>
		public abstract TList<AdmAppRegHistory> GetByAdmCdeStatusId(TransactionManager transactionManager, System.Decimal? _admCdeStatusId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key NonClusteredIndex-20131121-211105 index.
		/// </summary>
		/// <param name="_admApplicantId"></param>
		/// <param name="_currentFlg"></param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="_admOpenAcadSemesterId">عام وفصل طلب الالتحاق</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppRegHistory&gt;"/> class.</returns>
		public TList<AdmAppRegHistory> GetByAdmApplicantIdCurrentFlgAsCodeDegreeIdAsCodeDegreeClassIdAdmOpenAcadSemesterId(System.Decimal? _admApplicantId, System.Decimal? _currentFlg, System.Decimal? _asCodeDegreeId, System.Decimal? _asCodeDegreeClassId, System.Decimal? _admOpenAcadSemesterId)
		{
			int count = -1;
			return GetByAdmApplicantIdCurrentFlgAsCodeDegreeIdAsCodeDegreeClassIdAdmOpenAcadSemesterId(null,_admApplicantId, _currentFlg, _asCodeDegreeId, _asCodeDegreeClassId, _admOpenAcadSemesterId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the NonClusteredIndex-20131121-211105 index.
		/// </summary>
		/// <param name="_admApplicantId"></param>
		/// <param name="_currentFlg"></param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="_admOpenAcadSemesterId">عام وفصل طلب الالتحاق</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppRegHistory&gt;"/> class.</returns>
		public TList<AdmAppRegHistory> GetByAdmApplicantIdCurrentFlgAsCodeDegreeIdAsCodeDegreeClassIdAdmOpenAcadSemesterId(System.Decimal? _admApplicantId, System.Decimal? _currentFlg, System.Decimal? _asCodeDegreeId, System.Decimal? _asCodeDegreeClassId, System.Decimal? _admOpenAcadSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmApplicantIdCurrentFlgAsCodeDegreeIdAsCodeDegreeClassIdAdmOpenAcadSemesterId(null, _admApplicantId, _currentFlg, _asCodeDegreeId, _asCodeDegreeClassId, _admOpenAcadSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the NonClusteredIndex-20131121-211105 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="_currentFlg"></param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="_admOpenAcadSemesterId">عام وفصل طلب الالتحاق</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppRegHistory&gt;"/> class.</returns>
		public TList<AdmAppRegHistory> GetByAdmApplicantIdCurrentFlgAsCodeDegreeIdAsCodeDegreeClassIdAdmOpenAcadSemesterId(TransactionManager transactionManager, System.Decimal? _admApplicantId, System.Decimal? _currentFlg, System.Decimal? _asCodeDegreeId, System.Decimal? _asCodeDegreeClassId, System.Decimal? _admOpenAcadSemesterId)
		{
			int count = -1;
			return GetByAdmApplicantIdCurrentFlgAsCodeDegreeIdAsCodeDegreeClassIdAdmOpenAcadSemesterId(transactionManager, _admApplicantId, _currentFlg, _asCodeDegreeId, _asCodeDegreeClassId, _admOpenAcadSemesterId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the NonClusteredIndex-20131121-211105 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="_currentFlg"></param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="_admOpenAcadSemesterId">عام وفصل طلب الالتحاق</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppRegHistory&gt;"/> class.</returns>
		public TList<AdmAppRegHistory> GetByAdmApplicantIdCurrentFlgAsCodeDegreeIdAsCodeDegreeClassIdAdmOpenAcadSemesterId(TransactionManager transactionManager, System.Decimal? _admApplicantId, System.Decimal? _currentFlg, System.Decimal? _asCodeDegreeId, System.Decimal? _asCodeDegreeClassId, System.Decimal? _admOpenAcadSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmApplicantIdCurrentFlgAsCodeDegreeIdAsCodeDegreeClassIdAdmOpenAcadSemesterId(transactionManager, _admApplicantId, _currentFlg, _asCodeDegreeId, _asCodeDegreeClassId, _admOpenAcadSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the NonClusteredIndex-20131121-211105 index.
		/// </summary>
		/// <param name="_admApplicantId"></param>
		/// <param name="_currentFlg"></param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="_admOpenAcadSemesterId">عام وفصل طلب الالتحاق</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppRegHistory&gt;"/> class.</returns>
		public TList<AdmAppRegHistory> GetByAdmApplicantIdCurrentFlgAsCodeDegreeIdAsCodeDegreeClassIdAdmOpenAcadSemesterId(System.Decimal? _admApplicantId, System.Decimal? _currentFlg, System.Decimal? _asCodeDegreeId, System.Decimal? _asCodeDegreeClassId, System.Decimal? _admOpenAcadSemesterId, int start, int pageLength, out int count)
		{
			return GetByAdmApplicantIdCurrentFlgAsCodeDegreeIdAsCodeDegreeClassIdAdmOpenAcadSemesterId(null, _admApplicantId, _currentFlg, _asCodeDegreeId, _asCodeDegreeClassId, _admOpenAcadSemesterId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the NonClusteredIndex-20131121-211105 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="_currentFlg"></param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="_admOpenAcadSemesterId">عام وفصل طلب الالتحاق</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppRegHistory&gt;"/> class.</returns>
		public abstract TList<AdmAppRegHistory> GetByAdmApplicantIdCurrentFlgAsCodeDegreeIdAsCodeDegreeClassIdAdmOpenAcadSemesterId(TransactionManager transactionManager, System.Decimal? _admApplicantId, System.Decimal? _currentFlg, System.Decimal? _asCodeDegreeId, System.Decimal? _asCodeDegreeClassId, System.Decimal? _admOpenAcadSemesterId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key NonClusteredIndex-20131121-211215 index.
		/// </summary>
		/// <param name="_overAllAcceptanceFlg"></param>
		/// <param name="_orintationFlg">oriented -provisonal</param>
		/// <param name="_distributionFlg"></param>
		/// <param name="_enrolledFlg"></param>
		/// <param name="_autoDistrFlg"></param>
		/// <param name="_fullTimeFlg"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppRegHistory&gt;"/> class.</returns>
		public TList<AdmAppRegHistory> GetByOverAllAcceptanceFlgOrintationFlgDistributionFlgEnrolledFlgAutoDistrFlgFullTimeFlg(System.Decimal _overAllAcceptanceFlg, System.Decimal _orintationFlg, System.Decimal _distributionFlg, System.Decimal _enrolledFlg, System.Decimal _autoDistrFlg, System.Decimal? _fullTimeFlg)
		{
			int count = -1;
			return GetByOverAllAcceptanceFlgOrintationFlgDistributionFlgEnrolledFlgAutoDistrFlgFullTimeFlg(null,_overAllAcceptanceFlg, _orintationFlg, _distributionFlg, _enrolledFlg, _autoDistrFlg, _fullTimeFlg, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the NonClusteredIndex-20131121-211215 index.
		/// </summary>
		/// <param name="_overAllAcceptanceFlg"></param>
		/// <param name="_orintationFlg">oriented -provisonal</param>
		/// <param name="_distributionFlg"></param>
		/// <param name="_enrolledFlg"></param>
		/// <param name="_autoDistrFlg"></param>
		/// <param name="_fullTimeFlg"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppRegHistory&gt;"/> class.</returns>
		public TList<AdmAppRegHistory> GetByOverAllAcceptanceFlgOrintationFlgDistributionFlgEnrolledFlgAutoDistrFlgFullTimeFlg(System.Decimal _overAllAcceptanceFlg, System.Decimal _orintationFlg, System.Decimal _distributionFlg, System.Decimal _enrolledFlg, System.Decimal _autoDistrFlg, System.Decimal? _fullTimeFlg, int start, int pageLength)
		{
			int count = -1;
			return GetByOverAllAcceptanceFlgOrintationFlgDistributionFlgEnrolledFlgAutoDistrFlgFullTimeFlg(null, _overAllAcceptanceFlg, _orintationFlg, _distributionFlg, _enrolledFlg, _autoDistrFlg, _fullTimeFlg, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the NonClusteredIndex-20131121-211215 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_overAllAcceptanceFlg"></param>
		/// <param name="_orintationFlg">oriented -provisonal</param>
		/// <param name="_distributionFlg"></param>
		/// <param name="_enrolledFlg"></param>
		/// <param name="_autoDistrFlg"></param>
		/// <param name="_fullTimeFlg"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppRegHistory&gt;"/> class.</returns>
		public TList<AdmAppRegHistory> GetByOverAllAcceptanceFlgOrintationFlgDistributionFlgEnrolledFlgAutoDistrFlgFullTimeFlg(TransactionManager transactionManager, System.Decimal _overAllAcceptanceFlg, System.Decimal _orintationFlg, System.Decimal _distributionFlg, System.Decimal _enrolledFlg, System.Decimal _autoDistrFlg, System.Decimal? _fullTimeFlg)
		{
			int count = -1;
			return GetByOverAllAcceptanceFlgOrintationFlgDistributionFlgEnrolledFlgAutoDistrFlgFullTimeFlg(transactionManager, _overAllAcceptanceFlg, _orintationFlg, _distributionFlg, _enrolledFlg, _autoDistrFlg, _fullTimeFlg, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the NonClusteredIndex-20131121-211215 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_overAllAcceptanceFlg"></param>
		/// <param name="_orintationFlg">oriented -provisonal</param>
		/// <param name="_distributionFlg"></param>
		/// <param name="_enrolledFlg"></param>
		/// <param name="_autoDistrFlg"></param>
		/// <param name="_fullTimeFlg"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppRegHistory&gt;"/> class.</returns>
		public TList<AdmAppRegHistory> GetByOverAllAcceptanceFlgOrintationFlgDistributionFlgEnrolledFlgAutoDistrFlgFullTimeFlg(TransactionManager transactionManager, System.Decimal _overAllAcceptanceFlg, System.Decimal _orintationFlg, System.Decimal _distributionFlg, System.Decimal _enrolledFlg, System.Decimal _autoDistrFlg, System.Decimal? _fullTimeFlg, int start, int pageLength)
		{
			int count = -1;
			return GetByOverAllAcceptanceFlgOrintationFlgDistributionFlgEnrolledFlgAutoDistrFlgFullTimeFlg(transactionManager, _overAllAcceptanceFlg, _orintationFlg, _distributionFlg, _enrolledFlg, _autoDistrFlg, _fullTimeFlg, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the NonClusteredIndex-20131121-211215 index.
		/// </summary>
		/// <param name="_overAllAcceptanceFlg"></param>
		/// <param name="_orintationFlg">oriented -provisonal</param>
		/// <param name="_distributionFlg"></param>
		/// <param name="_enrolledFlg"></param>
		/// <param name="_autoDistrFlg"></param>
		/// <param name="_fullTimeFlg"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppRegHistory&gt;"/> class.</returns>
		public TList<AdmAppRegHistory> GetByOverAllAcceptanceFlgOrintationFlgDistributionFlgEnrolledFlgAutoDistrFlgFullTimeFlg(System.Decimal _overAllAcceptanceFlg, System.Decimal _orintationFlg, System.Decimal _distributionFlg, System.Decimal _enrolledFlg, System.Decimal _autoDistrFlg, System.Decimal? _fullTimeFlg, int start, int pageLength, out int count)
		{
			return GetByOverAllAcceptanceFlgOrintationFlgDistributionFlgEnrolledFlgAutoDistrFlgFullTimeFlg(null, _overAllAcceptanceFlg, _orintationFlg, _distributionFlg, _enrolledFlg, _autoDistrFlg, _fullTimeFlg, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the NonClusteredIndex-20131121-211215 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_overAllAcceptanceFlg"></param>
		/// <param name="_orintationFlg">oriented -provisonal</param>
		/// <param name="_distributionFlg"></param>
		/// <param name="_enrolledFlg"></param>
		/// <param name="_autoDistrFlg"></param>
		/// <param name="_fullTimeFlg"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppRegHistory&gt;"/> class.</returns>
		public abstract TList<AdmAppRegHistory> GetByOverAllAcceptanceFlgOrintationFlgDistributionFlgEnrolledFlgAutoDistrFlgFullTimeFlg(TransactionManager transactionManager, System.Decimal _overAllAcceptanceFlg, System.Decimal _orintationFlg, System.Decimal _distributionFlg, System.Decimal _enrolledFlg, System.Decimal _autoDistrFlg, System.Decimal? _fullTimeFlg, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ADM_APP_REG_HISTORY index.
		/// </summary>
		/// <param name="_admAppRegHistoryId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppRegHistory"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppRegHistory GetByAdmAppRegHistoryId(System.Decimal _admAppRegHistoryId)
		{
			int count = -1;
			return GetByAdmAppRegHistoryId(null,_admAppRegHistoryId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_REG_HISTORY index.
		/// </summary>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppRegHistory"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppRegHistory GetByAdmAppRegHistoryId(System.Decimal _admAppRegHistoryId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppRegHistoryId(null, _admAppRegHistoryId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_REG_HISTORY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppRegHistory"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppRegHistory GetByAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal _admAppRegHistoryId)
		{
			int count = -1;
			return GetByAdmAppRegHistoryId(transactionManager, _admAppRegHistoryId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_REG_HISTORY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppRegHistory"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppRegHistory GetByAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal _admAppRegHistoryId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppRegHistoryId(transactionManager, _admAppRegHistoryId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_REG_HISTORY index.
		/// </summary>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppRegHistory"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppRegHistory GetByAdmAppRegHistoryId(System.Decimal _admAppRegHistoryId, int start, int pageLength, out int count)
		{
			return GetByAdmAppRegHistoryId(null, _admAppRegHistoryId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_REG_HISTORY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppRegHistory"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmAppRegHistory GetByAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal _admAppRegHistoryId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ADM_APP_REG_HISTORY index.
		/// </summary>
		/// <param name="_admOpenAcadSemesterId">عام وفصل طلب الالتحاق</param>
		/// <param name="_admApplicantId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppRegHistory"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppRegHistory GetByAdmOpenAcadSemesterIdAdmApplicantId(System.Decimal? _admOpenAcadSemesterId, System.Decimal? _admApplicantId)
		{
			int count = -1;
			return GetByAdmOpenAcadSemesterIdAdmApplicantId(null,_admOpenAcadSemesterId, _admApplicantId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_APP_REG_HISTORY index.
		/// </summary>
		/// <param name="_admOpenAcadSemesterId">عام وفصل طلب الالتحاق</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppRegHistory"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppRegHistory GetByAdmOpenAcadSemesterIdAdmApplicantId(System.Decimal? _admOpenAcadSemesterId, System.Decimal? _admApplicantId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmOpenAcadSemesterIdAdmApplicantId(null, _admOpenAcadSemesterId, _admApplicantId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_APP_REG_HISTORY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admOpenAcadSemesterId">عام وفصل طلب الالتحاق</param>
		/// <param name="_admApplicantId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppRegHistory"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppRegHistory GetByAdmOpenAcadSemesterIdAdmApplicantId(TransactionManager transactionManager, System.Decimal? _admOpenAcadSemesterId, System.Decimal? _admApplicantId)
		{
			int count = -1;
			return GetByAdmOpenAcadSemesterIdAdmApplicantId(transactionManager, _admOpenAcadSemesterId, _admApplicantId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_APP_REG_HISTORY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admOpenAcadSemesterId">عام وفصل طلب الالتحاق</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppRegHistory"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppRegHistory GetByAdmOpenAcadSemesterIdAdmApplicantId(TransactionManager transactionManager, System.Decimal? _admOpenAcadSemesterId, System.Decimal? _admApplicantId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmOpenAcadSemesterIdAdmApplicantId(transactionManager, _admOpenAcadSemesterId, _admApplicantId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_APP_REG_HISTORY index.
		/// </summary>
		/// <param name="_admOpenAcadSemesterId">عام وفصل طلب الالتحاق</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppRegHistory"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppRegHistory GetByAdmOpenAcadSemesterIdAdmApplicantId(System.Decimal? _admOpenAcadSemesterId, System.Decimal? _admApplicantId, int start, int pageLength, out int count)
		{
			return GetByAdmOpenAcadSemesterIdAdmApplicantId(null, _admOpenAcadSemesterId, _admApplicantId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_APP_REG_HISTORY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admOpenAcadSemesterId">عام وفصل طلب الالتحاق</param>
		/// <param name="_admApplicantId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppRegHistory"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmAppRegHistory GetByAdmOpenAcadSemesterIdAdmApplicantId(TransactionManager transactionManager, System.Decimal? _admOpenAcadSemesterId, System.Decimal? _admApplicantId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AdmAppRegHistory&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AdmAppRegHistory&gt;"/></returns>
		public static TList<AdmAppRegHistory> Fill(IDataReader reader, TList<AdmAppRegHistory> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AdmAppRegHistory c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AdmAppRegHistory")
					.Append("|").Append((System.Decimal)reader["ADM_APP_REG_HISTORY_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AdmAppRegHistory>(
					key.ToString(), // EntityTrackingKey
					"AdmAppRegHistory",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AdmAppRegHistory();
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
					c.AdmAppRegHistoryId = (System.Decimal)reader["ADM_APP_REG_HISTORY_ID"];
					c.OriginalAdmAppRegHistoryId = c.AdmAppRegHistoryId;
					c.AdmApplicantId = Convert.IsDBNull(reader["ADM_APPLICANT_ID"]) ? null : (System.Decimal?)reader["ADM_APPLICANT_ID"];
					c.AppDate = Convert.IsDBNull(reader["APP_DATE"]) ? null : (System.DateTime?)reader["APP_DATE"];
					c.AdmCdeAppTypeId = Convert.IsDBNull(reader["ADM_CDE_APP_TYPE_ID"]) ? null : (System.Decimal?)reader["ADM_CDE_APP_TYPE_ID"];
					c.CurrentFlg = Convert.IsDBNull(reader["CURRENT_FLG"]) ? null : (System.Decimal?)reader["CURRENT_FLG"];
					c.AsCodeDegreeId = Convert.IsDBNull(reader["AS_CODE_DEGREE_ID"]) ? null : (System.Decimal?)reader["AS_CODE_DEGREE_ID"];
					c.AsCodeDegreeClassId = Convert.IsDBNull(reader["AS_CODE_DEGREE_CLASS_ID"]) ? null : (System.Decimal?)reader["AS_CODE_DEGREE_CLASS_ID"];
					c.ComptativeRate = Convert.IsDBNull(reader["COMPTATIVE_RATE"]) ? null : (System.Decimal?)reader["COMPTATIVE_RATE"];
					c.AdmOpenAcadSemesterId = Convert.IsDBNull(reader["ADM_OPEN_ACAD_SEMESTER_ID"]) ? null : (System.Decimal?)reader["ADM_OPEN_ACAD_SEMESTER_ID"];
					c.SeUserId = Convert.IsDBNull(reader["SE_USER_ID"]) ? null : (System.Decimal?)reader["SE_USER_ID"];
					c.AdmCdeStatusId = Convert.IsDBNull(reader["ADM_CDE_STATUS_ID"]) ? null : (System.Decimal?)reader["ADM_CDE_STATUS_ID"];
					c.OverAllAcceptanceFlg = (System.Decimal)reader["OVER_ALL_ACCEPTANCE_FLG"];
					c.OrintationFlg = (System.Decimal)reader["ORINTATION_FLG"];
					c.AdmAdmissionBandId = Convert.IsDBNull(reader["ADM_ADMISSION_BAND_ID"]) ? null : (System.Decimal?)reader["ADM_ADMISSION_BAND_ID"];
					c.DistributionFlg = (System.Decimal)reader["DISTRIBUTION_FLG"];
					c.EnrolledFlg = (System.Decimal)reader["ENROLLED_FLG"];
					c.AutoDistrFlg = (System.Decimal)reader["AUTO_DISTR_FLG"];
					c.FullTimeFlg = Convert.IsDBNull(reader["FULL_TIME_FLG"]) ? null : (System.Decimal?)reader["FULL_TIME_FLG"];
					c.OnlneFlg = Convert.IsDBNull(reader["ONLNE_FLG"]) ? null : (System.Boolean?)reader["ONLNE_FLG"];
					c.FeeCdeDiscTypeId = Convert.IsDBNull(reader["FEE_CDE_DISC_TYPE_ID"]) ? null : (System.Decimal?)reader["FEE_CDE_DISC_TYPE_ID"];
					c.LmsUsr = Convert.IsDBNull(reader["LMS_USR"]) ? null : (System.String)reader["LMS_USR"];
					c.LmsPwd = Convert.IsDBNull(reader["LMS_PWD"]) ? null : (System.String)reader["LMS_PWD"];
					c.AdmAppHstryCode = Convert.IsDBNull(reader["ADM_APP_HSTRY_CODE"]) ? null : (System.String)reader["ADM_APP_HSTRY_CODE"];
					c.BusFlg = Convert.IsDBNull(reader["BUS_FLG"]) ? null : (System.Boolean?)reader["BUS_FLG"];
					c.FeeCdeSchshipTypeId = Convert.IsDBNull(reader["FEE_CDE_SCHSHIP_TYPE_ID"]) ? null : (System.Int32?)reader["FEE_CDE_SCHSHIP_TYPE_ID"];
					c.SchshipNote = Convert.IsDBNull(reader["SCHSHIP_NOTE"]) ? null : (System.String)reader["SCHSHIP_NOTE"];
					c.SpoSponsorId = Convert.IsDBNull(reader["SPO_SPONSOR_ID"]) ? null : (System.Decimal?)reader["SPO_SPONSOR_ID"];
					c.SubmitFlg = Convert.IsDBNull(reader["SUBMIT_FLG"]) ? null : (System.Boolean?)reader["SUBMIT_FLG"];
					c.FeeCdeDiscCatId = Convert.IsDBNull(reader["FEE_CDE_DISC_CAT_ID"]) ? null : (System.Int32?)reader["FEE_CDE_DISC_CAT_ID"];
					c.SchshipTypeFlg = Convert.IsDBNull(reader["SCHSHIP_TYPE_FLG"]) ? null : (System.Boolean?)reader["SCHSHIP_TYPE_FLG"];
					c.FincaidTypeFlg = Convert.IsDBNull(reader["FINCAID_TYPE_FLG"]) ? null : (System.Boolean?)reader["FINCAID_TYPE_FLG"];
					c.HasRa = Convert.IsDBNull(reader["HAS_RA"]) ? null : (System.Boolean?)reader["HAS_RA"];
					c.SubmitDate = Convert.IsDBNull(reader["SUBMIT_DATE"]) ? null : (System.DateTime?)reader["SUBMIT_DATE"];
					c.LastDate = Convert.IsDBNull(reader["LAST_DATE"]) ? null : (System.DateTime?)reader["LAST_DATE"];
					c.AdmCdeStatusRsnId = Convert.IsDBNull(reader["ADM_CDE_STATUS_RSN_ID"]) ? null : (System.Int32?)reader["ADM_CDE_STATUS_RSN_ID"];
					c.TermcondFlg = Convert.IsDBNull(reader["TERMCOND_FLG"]) ? null : (System.Boolean?)reader["TERMCOND_FLG"];
					c.DormFlg = Convert.IsDBNull(reader["DORM_FLG"]) ? null : (System.Boolean?)reader["DORM_FLG"];
					c.EngNativeFlg = Convert.IsDBNull(reader["ENG_NATIVE_FLG"]) ? null : (System.Decimal?)reader["ENG_NATIVE_FLG"];
					c.EngGradChkFlg = Convert.IsDBNull(reader["ENG_GRAD_CHK_FLG"]) ? null : (System.Boolean?)reader["ENG_GRAD_CHK_FLG"];
					c.WaitFlg = Convert.IsDBNull(reader["WAIT_FLG"]) ? null : (System.Boolean?)reader["WAIT_FLG"];
					c.EdAcadYearId = Convert.IsDBNull(reader["ED_ACAD_YEAR_ID"]) ? null : (System.Decimal?)reader["ED_ACAD_YEAR_ID"];
					c.EdCodeSemesterId = Convert.IsDBNull(reader["ED_CODE_SEMESTER_ID"]) ? null : (System.Decimal?)reader["ED_CODE_SEMESTER_ID"];
					c.MasterPhdFlg = Convert.IsDBNull(reader["MASTER_PHD_FLG"]) ? null : (System.Boolean?)reader["MASTER_PHD_FLG"];
					c.EdCodeLevelId = Convert.IsDBNull(reader["ED_CODE_LEVEL_ID"]) ? null : (System.Decimal?)reader["ED_CODE_LEVEL_ID"];
					c.SpoSponsorTypeId = Convert.IsDBNull(reader["SPO_SPONSOR_TYPE_ID"]) ? null : (System.Decimal?)reader["SPO_SPONSOR_TYPE_ID"];
					c.UrlReference = Convert.IsDBNull(reader["URL_REFERENCE"]) ? null : (System.String)reader["URL_REFERENCE"];
					c.AdmCdeStatusOldId = Convert.IsDBNull(reader["ADM_CDE_STATUS_OLD_ID"]) ? null : (System.Decimal?)reader["ADM_CDE_STATUS_OLD_ID"];
					c.ProvisionalFlg = Convert.IsDBNull(reader["PROVISIONAL_FLG"]) ? null : (System.Boolean?)reader["PROVISIONAL_FLG"];
					c.AdmCdeAppStatusId = Convert.IsDBNull(reader["ADM_CDE_APP_STATUS_ID"]) ? null : (System.Decimal?)reader["ADM_CDE_APP_STATUS_ID"];
					c.TansikFlg = Convert.IsDBNull(reader["TansiK_FLG"]) ? null : (System.Boolean?)reader["TansiK_FLG"];
					c.AdmDecisionStatusId = Convert.IsDBNull(reader["Adm_Decision_Status_Id"]) ? null : (System.Decimal?)reader["Adm_Decision_Status_Id"];
					c.PartTimeFlg = Convert.IsDBNull(reader["PART_TIME_FLG"]) ? null : (System.Boolean?)reader["PART_TIME_FLG"];
					c.DataSentFlg = Convert.IsDBNull(reader["DATA_SENT_FLG"]) ? null : (System.Boolean?)reader["DATA_SENT_FLG"];
					c.CovidFlg = Convert.IsDBNull(reader["COVID_FLG"]) ? null : (System.Boolean?)reader["COVID_FLG"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmAppRegHistory"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAppRegHistory"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AdmAppRegHistory entity)
		{
			if (!reader.Read()) return;
			
			entity.AdmAppRegHistoryId = (System.Decimal)reader[((int)AdmAppRegHistoryColumn.AdmAppRegHistoryId - 1)];
			entity.OriginalAdmAppRegHistoryId = (System.Decimal)reader["ADM_APP_REG_HISTORY_ID"];
			entity.AdmApplicantId = (reader.IsDBNull(((int)AdmAppRegHistoryColumn.AdmApplicantId - 1)))?null:(System.Decimal?)reader[((int)AdmAppRegHistoryColumn.AdmApplicantId - 1)];
			entity.AppDate = (reader.IsDBNull(((int)AdmAppRegHistoryColumn.AppDate - 1)))?null:(System.DateTime?)reader[((int)AdmAppRegHistoryColumn.AppDate - 1)];
			entity.AdmCdeAppTypeId = (reader.IsDBNull(((int)AdmAppRegHistoryColumn.AdmCdeAppTypeId - 1)))?null:(System.Decimal?)reader[((int)AdmAppRegHistoryColumn.AdmCdeAppTypeId - 1)];
			entity.CurrentFlg = (reader.IsDBNull(((int)AdmAppRegHistoryColumn.CurrentFlg - 1)))?null:(System.Decimal?)reader[((int)AdmAppRegHistoryColumn.CurrentFlg - 1)];
			entity.AsCodeDegreeId = (reader.IsDBNull(((int)AdmAppRegHistoryColumn.AsCodeDegreeId - 1)))?null:(System.Decimal?)reader[((int)AdmAppRegHistoryColumn.AsCodeDegreeId - 1)];
			entity.AsCodeDegreeClassId = (reader.IsDBNull(((int)AdmAppRegHistoryColumn.AsCodeDegreeClassId - 1)))?null:(System.Decimal?)reader[((int)AdmAppRegHistoryColumn.AsCodeDegreeClassId - 1)];
			entity.ComptativeRate = (reader.IsDBNull(((int)AdmAppRegHistoryColumn.ComptativeRate - 1)))?null:(System.Decimal?)reader[((int)AdmAppRegHistoryColumn.ComptativeRate - 1)];
			entity.AdmOpenAcadSemesterId = (reader.IsDBNull(((int)AdmAppRegHistoryColumn.AdmOpenAcadSemesterId - 1)))?null:(System.Decimal?)reader[((int)AdmAppRegHistoryColumn.AdmOpenAcadSemesterId - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)AdmAppRegHistoryColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)AdmAppRegHistoryColumn.SeUserId - 1)];
			entity.AdmCdeStatusId = (reader.IsDBNull(((int)AdmAppRegHistoryColumn.AdmCdeStatusId - 1)))?null:(System.Decimal?)reader[((int)AdmAppRegHistoryColumn.AdmCdeStatusId - 1)];
			entity.OverAllAcceptanceFlg = (System.Decimal)reader[((int)AdmAppRegHistoryColumn.OverAllAcceptanceFlg - 1)];
			entity.OrintationFlg = (System.Decimal)reader[((int)AdmAppRegHistoryColumn.OrintationFlg - 1)];
			entity.AdmAdmissionBandId = (reader.IsDBNull(((int)AdmAppRegHistoryColumn.AdmAdmissionBandId - 1)))?null:(System.Decimal?)reader[((int)AdmAppRegHistoryColumn.AdmAdmissionBandId - 1)];
			entity.DistributionFlg = (System.Decimal)reader[((int)AdmAppRegHistoryColumn.DistributionFlg - 1)];
			entity.EnrolledFlg = (System.Decimal)reader[((int)AdmAppRegHistoryColumn.EnrolledFlg - 1)];
			entity.AutoDistrFlg = (System.Decimal)reader[((int)AdmAppRegHistoryColumn.AutoDistrFlg - 1)];
			entity.FullTimeFlg = (reader.IsDBNull(((int)AdmAppRegHistoryColumn.FullTimeFlg - 1)))?null:(System.Decimal?)reader[((int)AdmAppRegHistoryColumn.FullTimeFlg - 1)];
			entity.OnlneFlg = (reader.IsDBNull(((int)AdmAppRegHistoryColumn.OnlneFlg - 1)))?null:(System.Boolean?)reader[((int)AdmAppRegHistoryColumn.OnlneFlg - 1)];
			entity.FeeCdeDiscTypeId = (reader.IsDBNull(((int)AdmAppRegHistoryColumn.FeeCdeDiscTypeId - 1)))?null:(System.Decimal?)reader[((int)AdmAppRegHistoryColumn.FeeCdeDiscTypeId - 1)];
			entity.LmsUsr = (reader.IsDBNull(((int)AdmAppRegHistoryColumn.LmsUsr - 1)))?null:(System.String)reader[((int)AdmAppRegHistoryColumn.LmsUsr - 1)];
			entity.LmsPwd = (reader.IsDBNull(((int)AdmAppRegHistoryColumn.LmsPwd - 1)))?null:(System.String)reader[((int)AdmAppRegHistoryColumn.LmsPwd - 1)];
			entity.AdmAppHstryCode = (reader.IsDBNull(((int)AdmAppRegHistoryColumn.AdmAppHstryCode - 1)))?null:(System.String)reader[((int)AdmAppRegHistoryColumn.AdmAppHstryCode - 1)];
			entity.BusFlg = (reader.IsDBNull(((int)AdmAppRegHistoryColumn.BusFlg - 1)))?null:(System.Boolean?)reader[((int)AdmAppRegHistoryColumn.BusFlg - 1)];
			entity.FeeCdeSchshipTypeId = (reader.IsDBNull(((int)AdmAppRegHistoryColumn.FeeCdeSchshipTypeId - 1)))?null:(System.Int32?)reader[((int)AdmAppRegHistoryColumn.FeeCdeSchshipTypeId - 1)];
			entity.SchshipNote = (reader.IsDBNull(((int)AdmAppRegHistoryColumn.SchshipNote - 1)))?null:(System.String)reader[((int)AdmAppRegHistoryColumn.SchshipNote - 1)];
			entity.SpoSponsorId = (reader.IsDBNull(((int)AdmAppRegHistoryColumn.SpoSponsorId - 1)))?null:(System.Decimal?)reader[((int)AdmAppRegHistoryColumn.SpoSponsorId - 1)];
			entity.SubmitFlg = (reader.IsDBNull(((int)AdmAppRegHistoryColumn.SubmitFlg - 1)))?null:(System.Boolean?)reader[((int)AdmAppRegHistoryColumn.SubmitFlg - 1)];
			entity.FeeCdeDiscCatId = (reader.IsDBNull(((int)AdmAppRegHistoryColumn.FeeCdeDiscCatId - 1)))?null:(System.Int32?)reader[((int)AdmAppRegHistoryColumn.FeeCdeDiscCatId - 1)];
			entity.SchshipTypeFlg = (reader.IsDBNull(((int)AdmAppRegHistoryColumn.SchshipTypeFlg - 1)))?null:(System.Boolean?)reader[((int)AdmAppRegHistoryColumn.SchshipTypeFlg - 1)];
			entity.FincaidTypeFlg = (reader.IsDBNull(((int)AdmAppRegHistoryColumn.FincaidTypeFlg - 1)))?null:(System.Boolean?)reader[((int)AdmAppRegHistoryColumn.FincaidTypeFlg - 1)];
			entity.HasRa = (reader.IsDBNull(((int)AdmAppRegHistoryColumn.HasRa - 1)))?null:(System.Boolean?)reader[((int)AdmAppRegHistoryColumn.HasRa - 1)];
			entity.SubmitDate = (reader.IsDBNull(((int)AdmAppRegHistoryColumn.SubmitDate - 1)))?null:(System.DateTime?)reader[((int)AdmAppRegHistoryColumn.SubmitDate - 1)];
			entity.LastDate = (reader.IsDBNull(((int)AdmAppRegHistoryColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)AdmAppRegHistoryColumn.LastDate - 1)];
			entity.AdmCdeStatusRsnId = (reader.IsDBNull(((int)AdmAppRegHistoryColumn.AdmCdeStatusRsnId - 1)))?null:(System.Int32?)reader[((int)AdmAppRegHistoryColumn.AdmCdeStatusRsnId - 1)];
			entity.TermcondFlg = (reader.IsDBNull(((int)AdmAppRegHistoryColumn.TermcondFlg - 1)))?null:(System.Boolean?)reader[((int)AdmAppRegHistoryColumn.TermcondFlg - 1)];
			entity.DormFlg = (reader.IsDBNull(((int)AdmAppRegHistoryColumn.DormFlg - 1)))?null:(System.Boolean?)reader[((int)AdmAppRegHistoryColumn.DormFlg - 1)];
			entity.EngNativeFlg = (reader.IsDBNull(((int)AdmAppRegHistoryColumn.EngNativeFlg - 1)))?null:(System.Decimal?)reader[((int)AdmAppRegHistoryColumn.EngNativeFlg - 1)];
			entity.EngGradChkFlg = (reader.IsDBNull(((int)AdmAppRegHistoryColumn.EngGradChkFlg - 1)))?null:(System.Boolean?)reader[((int)AdmAppRegHistoryColumn.EngGradChkFlg - 1)];
			entity.WaitFlg = (reader.IsDBNull(((int)AdmAppRegHistoryColumn.WaitFlg - 1)))?null:(System.Boolean?)reader[((int)AdmAppRegHistoryColumn.WaitFlg - 1)];
			entity.EdAcadYearId = (reader.IsDBNull(((int)AdmAppRegHistoryColumn.EdAcadYearId - 1)))?null:(System.Decimal?)reader[((int)AdmAppRegHistoryColumn.EdAcadYearId - 1)];
			entity.EdCodeSemesterId = (reader.IsDBNull(((int)AdmAppRegHistoryColumn.EdCodeSemesterId - 1)))?null:(System.Decimal?)reader[((int)AdmAppRegHistoryColumn.EdCodeSemesterId - 1)];
			entity.MasterPhdFlg = (reader.IsDBNull(((int)AdmAppRegHistoryColumn.MasterPhdFlg - 1)))?null:(System.Boolean?)reader[((int)AdmAppRegHistoryColumn.MasterPhdFlg - 1)];
			entity.EdCodeLevelId = (reader.IsDBNull(((int)AdmAppRegHistoryColumn.EdCodeLevelId - 1)))?null:(System.Decimal?)reader[((int)AdmAppRegHistoryColumn.EdCodeLevelId - 1)];
			entity.SpoSponsorTypeId = (reader.IsDBNull(((int)AdmAppRegHistoryColumn.SpoSponsorTypeId - 1)))?null:(System.Decimal?)reader[((int)AdmAppRegHistoryColumn.SpoSponsorTypeId - 1)];
			entity.UrlReference = (reader.IsDBNull(((int)AdmAppRegHistoryColumn.UrlReference - 1)))?null:(System.String)reader[((int)AdmAppRegHistoryColumn.UrlReference - 1)];
			entity.AdmCdeStatusOldId = (reader.IsDBNull(((int)AdmAppRegHistoryColumn.AdmCdeStatusOldId - 1)))?null:(System.Decimal?)reader[((int)AdmAppRegHistoryColumn.AdmCdeStatusOldId - 1)];
			entity.ProvisionalFlg = (reader.IsDBNull(((int)AdmAppRegHistoryColumn.ProvisionalFlg - 1)))?null:(System.Boolean?)reader[((int)AdmAppRegHistoryColumn.ProvisionalFlg - 1)];
			entity.AdmCdeAppStatusId = (reader.IsDBNull(((int)AdmAppRegHistoryColumn.AdmCdeAppStatusId - 1)))?null:(System.Decimal?)reader[((int)AdmAppRegHistoryColumn.AdmCdeAppStatusId - 1)];
			entity.TansikFlg = (reader.IsDBNull(((int)AdmAppRegHistoryColumn.TansikFlg - 1)))?null:(System.Boolean?)reader[((int)AdmAppRegHistoryColumn.TansikFlg - 1)];
			entity.AdmDecisionStatusId = (reader.IsDBNull(((int)AdmAppRegHistoryColumn.AdmDecisionStatusId - 1)))?null:(System.Decimal?)reader[((int)AdmAppRegHistoryColumn.AdmDecisionStatusId - 1)];
			entity.PartTimeFlg = (reader.IsDBNull(((int)AdmAppRegHistoryColumn.PartTimeFlg - 1)))?null:(System.Boolean?)reader[((int)AdmAppRegHistoryColumn.PartTimeFlg - 1)];
			entity.DataSentFlg = (reader.IsDBNull(((int)AdmAppRegHistoryColumn.DataSentFlg - 1)))?null:(System.Boolean?)reader[((int)AdmAppRegHistoryColumn.DataSentFlg - 1)];
			entity.CovidFlg = (reader.IsDBNull(((int)AdmAppRegHistoryColumn.CovidFlg - 1)))?null:(System.Boolean?)reader[((int)AdmAppRegHistoryColumn.CovidFlg - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmAppRegHistory"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAppRegHistory"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AdmAppRegHistory entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AdmAppRegHistoryId = (System.Decimal)dataRow["ADM_APP_REG_HISTORY_ID"];
			entity.OriginalAdmAppRegHistoryId = (System.Decimal)dataRow["ADM_APP_REG_HISTORY_ID"];
			entity.AdmApplicantId = Convert.IsDBNull(dataRow["ADM_APPLICANT_ID"]) ? null : (System.Decimal?)dataRow["ADM_APPLICANT_ID"];
			entity.AppDate = Convert.IsDBNull(dataRow["APP_DATE"]) ? null : (System.DateTime?)dataRow["APP_DATE"];
			entity.AdmCdeAppTypeId = Convert.IsDBNull(dataRow["ADM_CDE_APP_TYPE_ID"]) ? null : (System.Decimal?)dataRow["ADM_CDE_APP_TYPE_ID"];
			entity.CurrentFlg = Convert.IsDBNull(dataRow["CURRENT_FLG"]) ? null : (System.Decimal?)dataRow["CURRENT_FLG"];
			entity.AsCodeDegreeId = Convert.IsDBNull(dataRow["AS_CODE_DEGREE_ID"]) ? null : (System.Decimal?)dataRow["AS_CODE_DEGREE_ID"];
			entity.AsCodeDegreeClassId = Convert.IsDBNull(dataRow["AS_CODE_DEGREE_CLASS_ID"]) ? null : (System.Decimal?)dataRow["AS_CODE_DEGREE_CLASS_ID"];
			entity.ComptativeRate = Convert.IsDBNull(dataRow["COMPTATIVE_RATE"]) ? null : (System.Decimal?)dataRow["COMPTATIVE_RATE"];
			entity.AdmOpenAcadSemesterId = Convert.IsDBNull(dataRow["ADM_OPEN_ACAD_SEMESTER_ID"]) ? null : (System.Decimal?)dataRow["ADM_OPEN_ACAD_SEMESTER_ID"];
			entity.SeUserId = Convert.IsDBNull(dataRow["SE_USER_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_ID"];
			entity.AdmCdeStatusId = Convert.IsDBNull(dataRow["ADM_CDE_STATUS_ID"]) ? null : (System.Decimal?)dataRow["ADM_CDE_STATUS_ID"];
			entity.OverAllAcceptanceFlg = (System.Decimal)dataRow["OVER_ALL_ACCEPTANCE_FLG"];
			entity.OrintationFlg = (System.Decimal)dataRow["ORINTATION_FLG"];
			entity.AdmAdmissionBandId = Convert.IsDBNull(dataRow["ADM_ADMISSION_BAND_ID"]) ? null : (System.Decimal?)dataRow["ADM_ADMISSION_BAND_ID"];
			entity.DistributionFlg = (System.Decimal)dataRow["DISTRIBUTION_FLG"];
			entity.EnrolledFlg = (System.Decimal)dataRow["ENROLLED_FLG"];
			entity.AutoDistrFlg = (System.Decimal)dataRow["AUTO_DISTR_FLG"];
			entity.FullTimeFlg = Convert.IsDBNull(dataRow["FULL_TIME_FLG"]) ? null : (System.Decimal?)dataRow["FULL_TIME_FLG"];
			entity.OnlneFlg = Convert.IsDBNull(dataRow["ONLNE_FLG"]) ? null : (System.Boolean?)dataRow["ONLNE_FLG"];
			entity.FeeCdeDiscTypeId = Convert.IsDBNull(dataRow["FEE_CDE_DISC_TYPE_ID"]) ? null : (System.Decimal?)dataRow["FEE_CDE_DISC_TYPE_ID"];
			entity.LmsUsr = Convert.IsDBNull(dataRow["LMS_USR"]) ? null : (System.String)dataRow["LMS_USR"];
			entity.LmsPwd = Convert.IsDBNull(dataRow["LMS_PWD"]) ? null : (System.String)dataRow["LMS_PWD"];
			entity.AdmAppHstryCode = Convert.IsDBNull(dataRow["ADM_APP_HSTRY_CODE"]) ? null : (System.String)dataRow["ADM_APP_HSTRY_CODE"];
			entity.BusFlg = Convert.IsDBNull(dataRow["BUS_FLG"]) ? null : (System.Boolean?)dataRow["BUS_FLG"];
			entity.FeeCdeSchshipTypeId = Convert.IsDBNull(dataRow["FEE_CDE_SCHSHIP_TYPE_ID"]) ? null : (System.Int32?)dataRow["FEE_CDE_SCHSHIP_TYPE_ID"];
			entity.SchshipNote = Convert.IsDBNull(dataRow["SCHSHIP_NOTE"]) ? null : (System.String)dataRow["SCHSHIP_NOTE"];
			entity.SpoSponsorId = Convert.IsDBNull(dataRow["SPO_SPONSOR_ID"]) ? null : (System.Decimal?)dataRow["SPO_SPONSOR_ID"];
			entity.SubmitFlg = Convert.IsDBNull(dataRow["SUBMIT_FLG"]) ? null : (System.Boolean?)dataRow["SUBMIT_FLG"];
			entity.FeeCdeDiscCatId = Convert.IsDBNull(dataRow["FEE_CDE_DISC_CAT_ID"]) ? null : (System.Int32?)dataRow["FEE_CDE_DISC_CAT_ID"];
			entity.SchshipTypeFlg = Convert.IsDBNull(dataRow["SCHSHIP_TYPE_FLG"]) ? null : (System.Boolean?)dataRow["SCHSHIP_TYPE_FLG"];
			entity.FincaidTypeFlg = Convert.IsDBNull(dataRow["FINCAID_TYPE_FLG"]) ? null : (System.Boolean?)dataRow["FINCAID_TYPE_FLG"];
			entity.HasRa = Convert.IsDBNull(dataRow["HAS_RA"]) ? null : (System.Boolean?)dataRow["HAS_RA"];
			entity.SubmitDate = Convert.IsDBNull(dataRow["SUBMIT_DATE"]) ? null : (System.DateTime?)dataRow["SUBMIT_DATE"];
			entity.LastDate = Convert.IsDBNull(dataRow["LAST_DATE"]) ? null : (System.DateTime?)dataRow["LAST_DATE"];
			entity.AdmCdeStatusRsnId = Convert.IsDBNull(dataRow["ADM_CDE_STATUS_RSN_ID"]) ? null : (System.Int32?)dataRow["ADM_CDE_STATUS_RSN_ID"];
			entity.TermcondFlg = Convert.IsDBNull(dataRow["TERMCOND_FLG"]) ? null : (System.Boolean?)dataRow["TERMCOND_FLG"];
			entity.DormFlg = Convert.IsDBNull(dataRow["DORM_FLG"]) ? null : (System.Boolean?)dataRow["DORM_FLG"];
			entity.EngNativeFlg = Convert.IsDBNull(dataRow["ENG_NATIVE_FLG"]) ? null : (System.Decimal?)dataRow["ENG_NATIVE_FLG"];
			entity.EngGradChkFlg = Convert.IsDBNull(dataRow["ENG_GRAD_CHK_FLG"]) ? null : (System.Boolean?)dataRow["ENG_GRAD_CHK_FLG"];
			entity.WaitFlg = Convert.IsDBNull(dataRow["WAIT_FLG"]) ? null : (System.Boolean?)dataRow["WAIT_FLG"];
			entity.EdAcadYearId = Convert.IsDBNull(dataRow["ED_ACAD_YEAR_ID"]) ? null : (System.Decimal?)dataRow["ED_ACAD_YEAR_ID"];
			entity.EdCodeSemesterId = Convert.IsDBNull(dataRow["ED_CODE_SEMESTER_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_SEMESTER_ID"];
			entity.MasterPhdFlg = Convert.IsDBNull(dataRow["MASTER_PHD_FLG"]) ? null : (System.Boolean?)dataRow["MASTER_PHD_FLG"];
			entity.EdCodeLevelId = Convert.IsDBNull(dataRow["ED_CODE_LEVEL_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_LEVEL_ID"];
			entity.SpoSponsorTypeId = Convert.IsDBNull(dataRow["SPO_SPONSOR_TYPE_ID"]) ? null : (System.Decimal?)dataRow["SPO_SPONSOR_TYPE_ID"];
			entity.UrlReference = Convert.IsDBNull(dataRow["URL_REFERENCE"]) ? null : (System.String)dataRow["URL_REFERENCE"];
			entity.AdmCdeStatusOldId = Convert.IsDBNull(dataRow["ADM_CDE_STATUS_OLD_ID"]) ? null : (System.Decimal?)dataRow["ADM_CDE_STATUS_OLD_ID"];
			entity.ProvisionalFlg = Convert.IsDBNull(dataRow["PROVISIONAL_FLG"]) ? null : (System.Boolean?)dataRow["PROVISIONAL_FLG"];
			entity.AdmCdeAppStatusId = Convert.IsDBNull(dataRow["ADM_CDE_APP_STATUS_ID"]) ? null : (System.Decimal?)dataRow["ADM_CDE_APP_STATUS_ID"];
			entity.TansikFlg = Convert.IsDBNull(dataRow["TansiK_FLG"]) ? null : (System.Boolean?)dataRow["TansiK_FLG"];
			entity.AdmDecisionStatusId = Convert.IsDBNull(dataRow["Adm_Decision_Status_Id"]) ? null : (System.Decimal?)dataRow["Adm_Decision_Status_Id"];
			entity.PartTimeFlg = Convert.IsDBNull(dataRow["PART_TIME_FLG"]) ? null : (System.Boolean?)dataRow["PART_TIME_FLG"];
			entity.DataSentFlg = Convert.IsDBNull(dataRow["DATA_SENT_FLG"]) ? null : (System.Boolean?)dataRow["DATA_SENT_FLG"];
			entity.CovidFlg = Convert.IsDBNull(dataRow["COVID_FLG"]) ? null : (System.Boolean?)dataRow["COVID_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAppRegHistory"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmAppRegHistory Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppRegHistory entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AdmAdmissionBandIdSource	
			if (CanDeepLoad(entity, "AdmAdmissionBand|AdmAdmissionBandIdSource", deepLoadType, innerList) 
				&& entity.AdmAdmissionBandIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AdmAdmissionBandId ?? 0.0m);
				AdmAdmissionBand tmpEntity = EntityManager.LocateEntity<AdmAdmissionBand>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmAdmissionBand), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmAdmissionBandIdSource = tmpEntity;
				else
					entity.AdmAdmissionBandIdSource = DataRepository.AdmAdmissionBandProvider.GetByAdmAdmissionBandId(transactionManager, (entity.AdmAdmissionBandId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAdmissionBandIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmAdmissionBandIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmAdmissionBandProvider.DeepLoad(transactionManager, entity.AdmAdmissionBandIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmAdmissionBandIdSource

			#region AdmCdeAppStatusIdSource	
			if (CanDeepLoad(entity, "AdmCdeAppStatus|AdmCdeAppStatusIdSource", deepLoadType, innerList) 
				&& entity.AdmCdeAppStatusIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AdmCdeAppStatusId ?? 0.0m);
				AdmCdeAppStatus tmpEntity = EntityManager.LocateEntity<AdmCdeAppStatus>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmCdeAppStatus), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmCdeAppStatusIdSource = tmpEntity;
				else
					entity.AdmCdeAppStatusIdSource = DataRepository.AdmCdeAppStatusProvider.GetByAdmCdeAppStatusId(transactionManager, (entity.AdmCdeAppStatusId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmCdeAppStatusIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmCdeAppStatusIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmCdeAppStatusProvider.DeepLoad(transactionManager, entity.AdmCdeAppStatusIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmCdeAppStatusIdSource

			#region AdmCdeAppTypeIdSource	
			if (CanDeepLoad(entity, "AdmCdeAppType|AdmCdeAppTypeIdSource", deepLoadType, innerList) 
				&& entity.AdmCdeAppTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AdmCdeAppTypeId ?? 0.0m);
				AdmCdeAppType tmpEntity = EntityManager.LocateEntity<AdmCdeAppType>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmCdeAppType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmCdeAppTypeIdSource = tmpEntity;
				else
					entity.AdmCdeAppTypeIdSource = DataRepository.AdmCdeAppTypeProvider.GetByAdmCdeAppTypeId(transactionManager, (entity.AdmCdeAppTypeId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmCdeAppTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmCdeAppTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmCdeAppTypeProvider.DeepLoad(transactionManager, entity.AdmCdeAppTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmCdeAppTypeIdSource

			#region AdmCdeStatusIdSource	
			if (CanDeepLoad(entity, "AdmCdeStatus|AdmCdeStatusIdSource", deepLoadType, innerList) 
				&& entity.AdmCdeStatusIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AdmCdeStatusId ?? 0.0m);
				AdmCdeStatus tmpEntity = EntityManager.LocateEntity<AdmCdeStatus>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmCdeStatus), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmCdeStatusIdSource = tmpEntity;
				else
					entity.AdmCdeStatusIdSource = DataRepository.AdmCdeStatusProvider.GetByAdmCdeStatusId(transactionManager, (entity.AdmCdeStatusId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmCdeStatusIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmCdeStatusIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmCdeStatusProvider.DeepLoad(transactionManager, entity.AdmCdeStatusIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmCdeStatusIdSource

			#region AdmCdeStatusRsnIdSource	
			if (CanDeepLoad(entity, "AdmCdeStatusRsn|AdmCdeStatusRsnIdSource", deepLoadType, innerList) 
				&& entity.AdmCdeStatusRsnIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AdmCdeStatusRsnId ?? (int)0);
				AdmCdeStatusRsn tmpEntity = EntityManager.LocateEntity<AdmCdeStatusRsn>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmCdeStatusRsn), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmCdeStatusRsnIdSource = tmpEntity;
				else
					entity.AdmCdeStatusRsnIdSource = DataRepository.AdmCdeStatusRsnProvider.GetByAdmCdeStatusRsnId(transactionManager, (entity.AdmCdeStatusRsnId ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmCdeStatusRsnIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmCdeStatusRsnIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmCdeStatusRsnProvider.DeepLoad(transactionManager, entity.AdmCdeStatusRsnIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmCdeStatusRsnIdSource

			#region AdmCdeStatusOldIdSource	
			if (CanDeepLoad(entity, "AdmCdeStatus|AdmCdeStatusOldIdSource", deepLoadType, innerList) 
				&& entity.AdmCdeStatusOldIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AdmCdeStatusOldId ?? 0.0m);
				AdmCdeStatus tmpEntity = EntityManager.LocateEntity<AdmCdeStatus>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmCdeStatus), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmCdeStatusOldIdSource = tmpEntity;
				else
					entity.AdmCdeStatusOldIdSource = DataRepository.AdmCdeStatusProvider.GetByAdmCdeStatusId(transactionManager, (entity.AdmCdeStatusOldId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmCdeStatusOldIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmCdeStatusOldIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmCdeStatusProvider.DeepLoad(transactionManager, entity.AdmCdeStatusOldIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmCdeStatusOldIdSource

			#region AdmDecisionStatusIdSource	
			if (CanDeepLoad(entity, "AdmDecisionStatus|AdmDecisionStatusIdSource", deepLoadType, innerList) 
				&& entity.AdmDecisionStatusIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AdmDecisionStatusId ?? 0.0m);
				AdmDecisionStatus tmpEntity = EntityManager.LocateEntity<AdmDecisionStatus>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmDecisionStatus), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmDecisionStatusIdSource = tmpEntity;
				else
					entity.AdmDecisionStatusIdSource = DataRepository.AdmDecisionStatusProvider.GetByAdmDecisionStatusId(transactionManager, (entity.AdmDecisionStatusId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmDecisionStatusIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmDecisionStatusIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmDecisionStatusProvider.DeepLoad(transactionManager, entity.AdmDecisionStatusIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmDecisionStatusIdSource

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

			#region AdmOpenAcadSemesterIdSource	
			if (CanDeepLoad(entity, "AdmOpenAcadSemester|AdmOpenAcadSemesterIdSource", deepLoadType, innerList) 
				&& entity.AdmOpenAcadSemesterIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AdmOpenAcadSemesterId ?? 0.0m);
				AdmOpenAcadSemester tmpEntity = EntityManager.LocateEntity<AdmOpenAcadSemester>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmOpenAcadSemester), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmOpenAcadSemesterIdSource = tmpEntity;
				else
					entity.AdmOpenAcadSemesterIdSource = DataRepository.AdmOpenAcadSemesterProvider.GetByAdmOpenAcadSemesterId(transactionManager, (entity.AdmOpenAcadSemesterId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmOpenAcadSemesterIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmOpenAcadSemesterIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmOpenAcadSemesterProvider.DeepLoad(transactionManager, entity.AdmOpenAcadSemesterIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmOpenAcadSemesterIdSource

			#region AsCodeDegreeIdSource	
			if (CanDeepLoad(entity, "AsCodeDegree|AsCodeDegreeIdSource", deepLoadType, innerList) 
				&& entity.AsCodeDegreeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AsCodeDegreeId ?? 0.0m);
				AsCodeDegree tmpEntity = EntityManager.LocateEntity<AsCodeDegree>(EntityLocator.ConstructKeyFromPkItems(typeof(AsCodeDegree), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AsCodeDegreeIdSource = tmpEntity;
				else
					entity.AsCodeDegreeIdSource = DataRepository.AsCodeDegreeProvider.GetByAsCodeDegreeId(transactionManager, (entity.AsCodeDegreeId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AsCodeDegreeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AsCodeDegreeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AsCodeDegreeProvider.DeepLoad(transactionManager, entity.AsCodeDegreeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AsCodeDegreeIdSource

			#region AsCodeDegreeClassIdSource	
			if (CanDeepLoad(entity, "AsCodeDegreeClass|AsCodeDegreeClassIdSource", deepLoadType, innerList) 
				&& entity.AsCodeDegreeClassIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AsCodeDegreeClassId ?? 0.0m);
				AsCodeDegreeClass tmpEntity = EntityManager.LocateEntity<AsCodeDegreeClass>(EntityLocator.ConstructKeyFromPkItems(typeof(AsCodeDegreeClass), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AsCodeDegreeClassIdSource = tmpEntity;
				else
					entity.AsCodeDegreeClassIdSource = DataRepository.AsCodeDegreeClassProvider.GetByAsCodeDegreeClassId(transactionManager, (entity.AsCodeDegreeClassId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AsCodeDegreeClassIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AsCodeDegreeClassIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AsCodeDegreeClassProvider.DeepLoad(transactionManager, entity.AsCodeDegreeClassIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AsCodeDegreeClassIdSource

			#region EdAcadYearIdSource	
			if (CanDeepLoad(entity, "EdAcadYear|EdAcadYearIdSource", deepLoadType, innerList) 
				&& entity.EdAcadYearIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdAcadYearId ?? 0.0m);
				EdAcadYear tmpEntity = EntityManager.LocateEntity<EdAcadYear>(EntityLocator.ConstructKeyFromPkItems(typeof(EdAcadYear), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdAcadYearIdSource = tmpEntity;
				else
					entity.EdAcadYearIdSource = DataRepository.EdAcadYearProvider.GetByEdAcadYearId(transactionManager, (entity.EdAcadYearId ?? 0.0m));		
				
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

			#region EdCodeLevelIdSource	
			if (CanDeepLoad(entity, "EdCodeLevel|EdCodeLevelIdSource", deepLoadType, innerList) 
				&& entity.EdCodeLevelIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCodeLevelId ?? 0.0m);
				EdCodeLevel tmpEntity = EntityManager.LocateEntity<EdCodeLevel>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeLevel), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeLevelIdSource = tmpEntity;
				else
					entity.EdCodeLevelIdSource = DataRepository.EdCodeLevelProvider.GetByEdCodeLevelId(transactionManager, (entity.EdCodeLevelId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeLevelIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeLevelIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeLevelProvider.DeepLoad(transactionManager, entity.EdCodeLevelIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeLevelIdSource

			#region EdCodeSemesterIdSource	
			if (CanDeepLoad(entity, "EdCodeSemester|EdCodeSemesterIdSource", deepLoadType, innerList) 
				&& entity.EdCodeSemesterIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCodeSemesterId ?? 0.0m);
				EdCodeSemester tmpEntity = EntityManager.LocateEntity<EdCodeSemester>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeSemester), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeSemesterIdSource = tmpEntity;
				else
					entity.EdCodeSemesterIdSource = DataRepository.EdCodeSemesterProvider.GetByEdCodeSemesterId(transactionManager, (entity.EdCodeSemesterId ?? 0.0m));		
				
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

			#region FeeCdeDiscCatIdSource	
			if (CanDeepLoad(entity, "FeeCdeDiscCat|FeeCdeDiscCatIdSource", deepLoadType, innerList) 
				&& entity.FeeCdeDiscCatIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.FeeCdeDiscCatId ?? (int)0);
				FeeCdeDiscCat tmpEntity = EntityManager.LocateEntity<FeeCdeDiscCat>(EntityLocator.ConstructKeyFromPkItems(typeof(FeeCdeDiscCat), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.FeeCdeDiscCatIdSource = tmpEntity;
				else
					entity.FeeCdeDiscCatIdSource = DataRepository.FeeCdeDiscCatProvider.GetByFeeCdeDiscCatId(transactionManager, (entity.FeeCdeDiscCatId ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeCdeDiscCatIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.FeeCdeDiscCatIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.FeeCdeDiscCatProvider.DeepLoad(transactionManager, entity.FeeCdeDiscCatIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion FeeCdeDiscCatIdSource

			#region FeeCdeDiscTypeIdSource	
			if (CanDeepLoad(entity, "FeeCdeDiscType|FeeCdeDiscTypeIdSource", deepLoadType, innerList) 
				&& entity.FeeCdeDiscTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.FeeCdeDiscTypeId ?? 0.0m);
				FeeCdeDiscType tmpEntity = EntityManager.LocateEntity<FeeCdeDiscType>(EntityLocator.ConstructKeyFromPkItems(typeof(FeeCdeDiscType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.FeeCdeDiscTypeIdSource = tmpEntity;
				else
					entity.FeeCdeDiscTypeIdSource = DataRepository.FeeCdeDiscTypeProvider.GetByFeeCdeDiscTypeId(transactionManager, (entity.FeeCdeDiscTypeId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeCdeDiscTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.FeeCdeDiscTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.FeeCdeDiscTypeProvider.DeepLoad(transactionManager, entity.FeeCdeDiscTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion FeeCdeDiscTypeIdSource

			#region FeeCdeSchshipTypeIdSource	
			if (CanDeepLoad(entity, "FeeCdeSchshipType|FeeCdeSchshipTypeIdSource", deepLoadType, innerList) 
				&& entity.FeeCdeSchshipTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.FeeCdeSchshipTypeId ?? (int)0);
				FeeCdeSchshipType tmpEntity = EntityManager.LocateEntity<FeeCdeSchshipType>(EntityLocator.ConstructKeyFromPkItems(typeof(FeeCdeSchshipType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.FeeCdeSchshipTypeIdSource = tmpEntity;
				else
					entity.FeeCdeSchshipTypeIdSource = DataRepository.FeeCdeSchshipTypeProvider.GetByFeeCdeSchshipTypeId(transactionManager, (entity.FeeCdeSchshipTypeId ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeCdeSchshipTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.FeeCdeSchshipTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.FeeCdeSchshipTypeProvider.DeepLoad(transactionManager, entity.FeeCdeSchshipTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion FeeCdeSchshipTypeIdSource

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

			#region SpoSponsorTypeIdSource	
			if (CanDeepLoad(entity, "SpoSponsorType|SpoSponsorTypeIdSource", deepLoadType, innerList) 
				&& entity.SpoSponsorTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SpoSponsorTypeId ?? 0.0m);
				SpoSponsorType tmpEntity = EntityManager.LocateEntity<SpoSponsorType>(EntityLocator.ConstructKeyFromPkItems(typeof(SpoSponsorType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SpoSponsorTypeIdSource = tmpEntity;
				else
					entity.SpoSponsorTypeIdSource = DataRepository.SpoSponsorTypeProvider.GetBySpoSponsorTypeId(transactionManager, (entity.SpoSponsorTypeId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SpoSponsorTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SpoSponsorTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SpoSponsorTypeProvider.DeepLoad(transactionManager, entity.SpoSponsorTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SpoSponsorTypeIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByAdmAppRegHistoryId methods when available
			
			#region SpoSponsorStudCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SpoSponsorStud>|SpoSponsorStudCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SpoSponsorStudCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SpoSponsorStudCollection = DataRepository.SpoSponsorStudProvider.GetByAdmAppRegHistoryId(transactionManager, entity.AdmAppRegHistoryId);

				if (deep && entity.SpoSponsorStudCollection.Count > 0)
				{
					deepHandles.Add("SpoSponsorStudCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SpoSponsorStud>) DataRepository.SpoSponsorStudProvider.DeepLoad,
						new object[] { transactionManager, entity.SpoSponsorStudCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmApplicantAcceptanceCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmApplicantAcceptance>|AdmApplicantAcceptanceCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmApplicantAcceptanceCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmApplicantAcceptanceCollection = DataRepository.AdmApplicantAcceptanceProvider.GetByAdmAppRegHistoryId(transactionManager, entity.AdmAppRegHistoryId);

				if (deep && entity.AdmApplicantAcceptanceCollection.Count > 0)
				{
					deepHandles.Add("AdmApplicantAcceptanceCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmApplicantAcceptance>) DataRepository.AdmApplicantAcceptanceProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmApplicantAcceptanceCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmAppInterviewExamCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppInterviewExam>|AdmAppInterviewExamCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppInterviewExamCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppInterviewExamCollection = DataRepository.AdmAppInterviewExamProvider.GetByAdmAppRegHistoryId(transactionManager, entity.AdmAppRegHistoryId);

				if (deep && entity.AdmAppInterviewExamCollection.Count > 0)
				{
					deepHandles.Add("AdmAppInterviewExamCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppInterviewExam>) DataRepository.AdmAppInterviewExamProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppInterviewExamCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.AdmAppPlaceExamCourseCollection = DataRepository.AdmAppPlaceExamCourseProvider.GetByAdmAppRegHistoryId(transactionManager, entity.AdmAppRegHistoryId);

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

				entity.AdmAppHonorCollection = DataRepository.AdmAppHonorProvider.GetByAdmAppRegHistoryId(transactionManager, entity.AdmAppRegHistoryId);

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

				entity.AdmAppDocCollection = DataRepository.AdmAppDocProvider.GetByAdmAppRegHistoryId(transactionManager, entity.AdmAppRegHistoryId);

				if (deep && entity.AdmAppDocCollection.Count > 0)
				{
					deepHandles.Add("AdmAppDocCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppDoc>) DataRepository.AdmAppDocProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppDocCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmAppExmptCourseCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppExmptCourse>|AdmAppExmptCourseCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppExmptCourseCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppExmptCourseCollection = DataRepository.AdmAppExmptCourseProvider.GetByAdmAppRegHistoryId(transactionManager, entity.AdmAppRegHistoryId);

				if (deep && entity.AdmAppExmptCourseCollection.Count > 0)
				{
					deepHandles.Add("AdmAppExmptCourseCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppExmptCourse>) DataRepository.AdmAppExmptCourseProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppExmptCourseCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmAppFeePromocodeCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppFeePromocode>|AdmAppFeePromocodeCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppFeePromocodeCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppFeePromocodeCollection = DataRepository.AdmAppFeePromocodeProvider.GetByAdmAppRegHistoryId(transactionManager, entity.AdmAppRegHistoryId);

				if (deep && entity.AdmAppFeePromocodeCollection.Count > 0)
				{
					deepHandles.Add("AdmAppFeePromocodeCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppFeePromocode>) DataRepository.AdmAppFeePromocodeProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppFeePromocodeCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeStudDiscCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeStudDisc>|FeeStudDiscCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudDiscCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeStudDiscCollection = DataRepository.FeeStudDiscProvider.GetByAdmAppRegHistoryId(transactionManager, entity.AdmAppRegHistoryId);

				if (deep && entity.FeeStudDiscCollection.Count > 0)
				{
					deepHandles.Add("FeeStudDiscCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudDisc>) DataRepository.FeeStudDiscProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudDiscCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.AdmAppInfoCollection = DataRepository.AdmAppInfoProvider.GetByAdmAppRegHistoryId(transactionManager, entity.AdmAppRegHistoryId);

				if (deep && entity.AdmAppInfoCollection.Count > 0)
				{
					deepHandles.Add("AdmAppInfoCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppInfo>) DataRepository.AdmAppInfoProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppInfoCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.AdmAppPrefCollection = DataRepository.AdmAppPrefProvider.GetByAdmAppRegHistoryId(transactionManager, entity.AdmAppRegHistoryId);

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

				entity.AdmAppPlacementExamCollection = DataRepository.AdmAppPlacementExamProvider.GetByAdmAppRegHistoryId(transactionManager, entity.AdmAppRegHistoryId);

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

				entity.EdStudQualCollection = DataRepository.EdStudQualProvider.GetByAdmAppRegHistoryId(transactionManager, entity.AdmAppRegHistoryId);

				if (deep && entity.EdStudQualCollection.Count > 0)
				{
					deepHandles.Add("EdStudQualCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudQual>) DataRepository.EdStudQualProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudQualCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmTansikAppCodesCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmTansikAppCodes>|AdmTansikAppCodesCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmTansikAppCodesCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmTansikAppCodesCollection = DataRepository.AdmTansikAppCodesProvider.GetByAdmAppRegHistoryId(transactionManager, entity.AdmAppRegHistoryId);

				if (deep && entity.AdmTansikAppCodesCollection.Count > 0)
				{
					deepHandles.Add("AdmTansikAppCodesCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmTansikAppCodes>) DataRepository.AdmTansikAppCodesProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmTansikAppCodesCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudMilitaryStateCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudMilitaryState>|EdStudMilitaryStateCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudMilitaryStateCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudMilitaryStateCollection = DataRepository.EdStudMilitaryStateProvider.GetByAdmAppRegHistoryId(transactionManager, entity.AdmAppRegHistoryId);

				if (deep && entity.EdStudMilitaryStateCollection.Count > 0)
				{
					deepHandles.Add("EdStudMilitaryStateCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudMilitaryState>) DataRepository.EdStudMilitaryStateProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudMilitaryStateCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.AdmAppGuardianCollection = DataRepository.AdmAppGuardianProvider.GetByAdmAppRegHistoryId(transactionManager, entity.AdmAppRegHistoryId);

				if (deep && entity.AdmAppGuardianCollection.Count > 0)
				{
					deepHandles.Add("AdmAppGuardianCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppGuardian>) DataRepository.AdmAppGuardianProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppGuardianCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudMilitaryInfoCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudMilitaryInfo>|EdStudMilitaryInfoCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudMilitaryInfoCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudMilitaryInfoCollection = DataRepository.EdStudMilitaryInfoProvider.GetByAdmAppRegHistoryId(transactionManager, entity.AdmAppRegHistoryId);

				if (deep && entity.EdStudMilitaryInfoCollection.Count > 0)
				{
					deepHandles.Add("EdStudMilitaryInfoCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudMilitaryInfo>) DataRepository.EdStudMilitaryInfoProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudMilitaryInfoCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.AdmAppProcStepsCollection = DataRepository.AdmAppProcStepsProvider.GetByAdmAppRegHistoryId(transactionManager, entity.AdmAppRegHistoryId);

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

				entity.AdmAppEssayCollection = DataRepository.AdmAppEssayProvider.GetByAdmAppRegHistoryId(transactionManager, entity.AdmAppRegHistoryId);

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

				entity.AdmAppLanguagesCollection = DataRepository.AdmAppLanguagesProvider.GetByAdmAppRegHistoryId(transactionManager, entity.AdmAppRegHistoryId);

				if (deep && entity.AdmAppLanguagesCollection.Count > 0)
				{
					deepHandles.Add("AdmAppLanguagesCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppLanguages>) DataRepository.AdmAppLanguagesProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppLanguagesCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmAppAlumniPrefCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppAlumniPref>|AdmAppAlumniPrefCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppAlumniPrefCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppAlumniPrefCollection = DataRepository.AdmAppAlumniPrefProvider.GetByAdmAppRegHistoryId(transactionManager, entity.AdmAppRegHistoryId);

				if (deep && entity.AdmAppAlumniPrefCollection.Count > 0)
				{
					deepHandles.Add("AdmAppAlumniPrefCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppAlumniPref>) DataRepository.AdmAppAlumniPrefProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppAlumniPrefCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.AdmAppMediaCollection = DataRepository.AdmAppMediaProvider.GetByAdmAppRegHistoryId(transactionManager, entity.AdmAppRegHistoryId);

				if (deep && entity.AdmAppMediaCollection.Count > 0)
				{
					deepHandles.Add("AdmAppMediaCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppMedia>) DataRepository.AdmAppMediaProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppMediaCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmAppSponsorCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppSponsor>|AdmAppSponsorCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppSponsorCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppSponsorCollection = DataRepository.AdmAppSponsorProvider.GetByAdmAppRegHistoryId(transactionManager, entity.AdmAppRegHistoryId);

				if (deep && entity.AdmAppSponsorCollection.Count > 0)
				{
					deepHandles.Add("AdmAppSponsorCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppSponsor>) DataRepository.AdmAppSponsorProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppSponsorCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.AdmEnglishProficiencyCollection = DataRepository.AdmEnglishProficiencyProvider.GetByAdmAppRegHistoryId(transactionManager, entity.AdmAppRegHistoryId);

				if (deep && entity.AdmEnglishProficiencyCollection.Count > 0)
				{
					deepHandles.Add("AdmEnglishProficiencyCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmEnglishProficiency>) DataRepository.AdmEnglishProficiencyProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmEnglishProficiencyCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmAppTransReqCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppTransReq>|AdmAppTransReqCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppTransReqCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppTransReqCollection = DataRepository.AdmAppTransReqProvider.GetByAdmAppRegHistoryId(transactionManager, entity.AdmAppRegHistoryId);

				if (deep && entity.AdmAppTransReqCollection.Count > 0)
				{
					deepHandles.Add("AdmAppTransReqCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppTransReq>) DataRepository.AdmAppTransReqProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppTransReqCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.AdmAppWorkExperCollection = DataRepository.AdmAppWorkExperProvider.GetByAdmAppRegHistoryId(transactionManager, entity.AdmAppRegHistoryId);

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

				entity.AdmAppLtrRecomCollection = DataRepository.AdmAppLtrRecomProvider.GetByAdmAppRegHistoryId(transactionManager, entity.AdmAppRegHistoryId);

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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AdmAppRegHistory object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AdmAppRegHistory instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmAppRegHistory Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppRegHistory entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AdmAdmissionBandIdSource
			if (CanDeepSave(entity, "AdmAdmissionBand|AdmAdmissionBandIdSource", deepSaveType, innerList) 
				&& entity.AdmAdmissionBandIdSource != null)
			{
				DataRepository.AdmAdmissionBandProvider.Save(transactionManager, entity.AdmAdmissionBandIdSource);
				entity.AdmAdmissionBandId = entity.AdmAdmissionBandIdSource.AdmAdmissionBandId;
			}
			#endregion 
			
			#region AdmCdeAppStatusIdSource
			if (CanDeepSave(entity, "AdmCdeAppStatus|AdmCdeAppStatusIdSource", deepSaveType, innerList) 
				&& entity.AdmCdeAppStatusIdSource != null)
			{
				DataRepository.AdmCdeAppStatusProvider.Save(transactionManager, entity.AdmCdeAppStatusIdSource);
				entity.AdmCdeAppStatusId = entity.AdmCdeAppStatusIdSource.AdmCdeAppStatusId;
			}
			#endregion 
			
			#region AdmCdeAppTypeIdSource
			if (CanDeepSave(entity, "AdmCdeAppType|AdmCdeAppTypeIdSource", deepSaveType, innerList) 
				&& entity.AdmCdeAppTypeIdSource != null)
			{
				DataRepository.AdmCdeAppTypeProvider.Save(transactionManager, entity.AdmCdeAppTypeIdSource);
				entity.AdmCdeAppTypeId = entity.AdmCdeAppTypeIdSource.AdmCdeAppTypeId;
			}
			#endregion 
			
			#region AdmCdeStatusIdSource
			if (CanDeepSave(entity, "AdmCdeStatus|AdmCdeStatusIdSource", deepSaveType, innerList) 
				&& entity.AdmCdeStatusIdSource != null)
			{
				DataRepository.AdmCdeStatusProvider.Save(transactionManager, entity.AdmCdeStatusIdSource);
				entity.AdmCdeStatusId = entity.AdmCdeStatusIdSource.AdmCdeStatusId;
			}
			#endregion 
			
			#region AdmCdeStatusRsnIdSource
			if (CanDeepSave(entity, "AdmCdeStatusRsn|AdmCdeStatusRsnIdSource", deepSaveType, innerList) 
				&& entity.AdmCdeStatusRsnIdSource != null)
			{
				DataRepository.AdmCdeStatusRsnProvider.Save(transactionManager, entity.AdmCdeStatusRsnIdSource);
				entity.AdmCdeStatusRsnId = entity.AdmCdeStatusRsnIdSource.AdmCdeStatusRsnId;
			}
			#endregion 
			
			#region AdmCdeStatusOldIdSource
			if (CanDeepSave(entity, "AdmCdeStatus|AdmCdeStatusOldIdSource", deepSaveType, innerList) 
				&& entity.AdmCdeStatusOldIdSource != null)
			{
				DataRepository.AdmCdeStatusProvider.Save(transactionManager, entity.AdmCdeStatusOldIdSource);
				entity.AdmCdeStatusOldId = entity.AdmCdeStatusOldIdSource.AdmCdeStatusId;
			}
			#endregion 
			
			#region AdmDecisionStatusIdSource
			if (CanDeepSave(entity, "AdmDecisionStatus|AdmDecisionStatusIdSource", deepSaveType, innerList) 
				&& entity.AdmDecisionStatusIdSource != null)
			{
				DataRepository.AdmDecisionStatusProvider.Save(transactionManager, entity.AdmDecisionStatusIdSource);
				entity.AdmDecisionStatusId = entity.AdmDecisionStatusIdSource.AdmDecisionStatusId;
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
			
			#region AdmOpenAcadSemesterIdSource
			if (CanDeepSave(entity, "AdmOpenAcadSemester|AdmOpenAcadSemesterIdSource", deepSaveType, innerList) 
				&& entity.AdmOpenAcadSemesterIdSource != null)
			{
				DataRepository.AdmOpenAcadSemesterProvider.Save(transactionManager, entity.AdmOpenAcadSemesterIdSource);
				entity.AdmOpenAcadSemesterId = entity.AdmOpenAcadSemesterIdSource.AdmOpenAcadSemesterId;
			}
			#endregion 
			
			#region AsCodeDegreeIdSource
			if (CanDeepSave(entity, "AsCodeDegree|AsCodeDegreeIdSource", deepSaveType, innerList) 
				&& entity.AsCodeDegreeIdSource != null)
			{
				DataRepository.AsCodeDegreeProvider.Save(transactionManager, entity.AsCodeDegreeIdSource);
				entity.AsCodeDegreeId = entity.AsCodeDegreeIdSource.AsCodeDegreeId;
			}
			#endregion 
			
			#region AsCodeDegreeClassIdSource
			if (CanDeepSave(entity, "AsCodeDegreeClass|AsCodeDegreeClassIdSource", deepSaveType, innerList) 
				&& entity.AsCodeDegreeClassIdSource != null)
			{
				DataRepository.AsCodeDegreeClassProvider.Save(transactionManager, entity.AsCodeDegreeClassIdSource);
				entity.AsCodeDegreeClassId = entity.AsCodeDegreeClassIdSource.AsCodeDegreeClassId;
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
			
			#region EdCodeLevelIdSource
			if (CanDeepSave(entity, "EdCodeLevel|EdCodeLevelIdSource", deepSaveType, innerList) 
				&& entity.EdCodeLevelIdSource != null)
			{
				DataRepository.EdCodeLevelProvider.Save(transactionManager, entity.EdCodeLevelIdSource);
				entity.EdCodeLevelId = entity.EdCodeLevelIdSource.EdCodeLevelId;
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
			
			#region FeeCdeDiscCatIdSource
			if (CanDeepSave(entity, "FeeCdeDiscCat|FeeCdeDiscCatIdSource", deepSaveType, innerList) 
				&& entity.FeeCdeDiscCatIdSource != null)
			{
				DataRepository.FeeCdeDiscCatProvider.Save(transactionManager, entity.FeeCdeDiscCatIdSource);
				entity.FeeCdeDiscCatId = entity.FeeCdeDiscCatIdSource.FeeCdeDiscCatId;
			}
			#endregion 
			
			#region FeeCdeDiscTypeIdSource
			if (CanDeepSave(entity, "FeeCdeDiscType|FeeCdeDiscTypeIdSource", deepSaveType, innerList) 
				&& entity.FeeCdeDiscTypeIdSource != null)
			{
				DataRepository.FeeCdeDiscTypeProvider.Save(transactionManager, entity.FeeCdeDiscTypeIdSource);
				entity.FeeCdeDiscTypeId = entity.FeeCdeDiscTypeIdSource.FeeCdeDiscTypeId;
			}
			#endregion 
			
			#region FeeCdeSchshipTypeIdSource
			if (CanDeepSave(entity, "FeeCdeSchshipType|FeeCdeSchshipTypeIdSource", deepSaveType, innerList) 
				&& entity.FeeCdeSchshipTypeIdSource != null)
			{
				DataRepository.FeeCdeSchshipTypeProvider.Save(transactionManager, entity.FeeCdeSchshipTypeIdSource);
				entity.FeeCdeSchshipTypeId = entity.FeeCdeSchshipTypeIdSource.FeeCdeSchshipTypeId;
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
			
			#region SpoSponsorIdSource
			if (CanDeepSave(entity, "SpoSponsor|SpoSponsorIdSource", deepSaveType, innerList) 
				&& entity.SpoSponsorIdSource != null)
			{
				DataRepository.SpoSponsorProvider.Save(transactionManager, entity.SpoSponsorIdSource);
				entity.SpoSponsorId = entity.SpoSponsorIdSource.SpoSponsorId;
			}
			#endregion 
			
			#region SpoSponsorTypeIdSource
			if (CanDeepSave(entity, "SpoSponsorType|SpoSponsorTypeIdSource", deepSaveType, innerList) 
				&& entity.SpoSponsorTypeIdSource != null)
			{
				DataRepository.SpoSponsorTypeProvider.Save(transactionManager, entity.SpoSponsorTypeIdSource);
				entity.SpoSponsorTypeId = entity.SpoSponsorTypeIdSource.SpoSponsorTypeId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<SpoSponsorStud>
				if (CanDeepSave(entity.SpoSponsorStudCollection, "List<SpoSponsorStud>|SpoSponsorStudCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SpoSponsorStud child in entity.SpoSponsorStudCollection)
					{
						if(child.AdmAppRegHistoryIdSource != null)
						{
							child.AdmAppRegHistoryId = child.AdmAppRegHistoryIdSource.AdmAppRegHistoryId;
						}
						else
						{
							child.AdmAppRegHistoryId = entity.AdmAppRegHistoryId;
						}

					}

					if (entity.SpoSponsorStudCollection.Count > 0 || entity.SpoSponsorStudCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SpoSponsorStudProvider.Save(transactionManager, entity.SpoSponsorStudCollection);
						
						deepHandles.Add("SpoSponsorStudCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SpoSponsorStud >) DataRepository.SpoSponsorStudProvider.DeepSave,
							new object[] { transactionManager, entity.SpoSponsorStudCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmApplicantAcceptance>
				if (CanDeepSave(entity.AdmApplicantAcceptanceCollection, "List<AdmApplicantAcceptance>|AdmApplicantAcceptanceCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmApplicantAcceptance child in entity.AdmApplicantAcceptanceCollection)
					{
						if(child.AdmAppRegHistoryIdSource != null)
						{
							child.AdmAppRegHistoryId = child.AdmAppRegHistoryIdSource.AdmAppRegHistoryId;
						}
						else
						{
							child.AdmAppRegHistoryId = entity.AdmAppRegHistoryId;
						}

					}

					if (entity.AdmApplicantAcceptanceCollection.Count > 0 || entity.AdmApplicantAcceptanceCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmApplicantAcceptanceProvider.Save(transactionManager, entity.AdmApplicantAcceptanceCollection);
						
						deepHandles.Add("AdmApplicantAcceptanceCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmApplicantAcceptance >) DataRepository.AdmApplicantAcceptanceProvider.DeepSave,
							new object[] { transactionManager, entity.AdmApplicantAcceptanceCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmAppInterviewExam>
				if (CanDeepSave(entity.AdmAppInterviewExamCollection, "List<AdmAppInterviewExam>|AdmAppInterviewExamCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppInterviewExam child in entity.AdmAppInterviewExamCollection)
					{
						if(child.AdmAppRegHistoryIdSource != null)
						{
							child.AdmAppRegHistoryId = child.AdmAppRegHistoryIdSource.AdmAppRegHistoryId;
						}
						else
						{
							child.AdmAppRegHistoryId = entity.AdmAppRegHistoryId;
						}

					}

					if (entity.AdmAppInterviewExamCollection.Count > 0 || entity.AdmAppInterviewExamCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppInterviewExamProvider.Save(transactionManager, entity.AdmAppInterviewExamCollection);
						
						deepHandles.Add("AdmAppInterviewExamCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppInterviewExam >) DataRepository.AdmAppInterviewExamProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppInterviewExamCollection, deepSaveType, childTypes, innerList }
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
						if(child.AdmAppRegHistoryIdSource != null)
						{
							child.AdmAppRegHistoryId = child.AdmAppRegHistoryIdSource.AdmAppRegHistoryId;
						}
						else
						{
							child.AdmAppRegHistoryId = entity.AdmAppRegHistoryId;
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
						if(child.AdmAppRegHistoryIdSource != null)
						{
							child.AdmAppRegHistoryId = child.AdmAppRegHistoryIdSource.AdmAppRegHistoryId;
						}
						else
						{
							child.AdmAppRegHistoryId = entity.AdmAppRegHistoryId;
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
						if(child.AdmAppRegHistoryIdSource != null)
						{
							child.AdmAppRegHistoryId = child.AdmAppRegHistoryIdSource.AdmAppRegHistoryId;
						}
						else
						{
							child.AdmAppRegHistoryId = entity.AdmAppRegHistoryId;
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
				
	
			#region List<AdmAppExmptCourse>
				if (CanDeepSave(entity.AdmAppExmptCourseCollection, "List<AdmAppExmptCourse>|AdmAppExmptCourseCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppExmptCourse child in entity.AdmAppExmptCourseCollection)
					{
						if(child.AdmAppRegHistoryIdSource != null)
						{
							child.AdmAppRegHistoryId = child.AdmAppRegHistoryIdSource.AdmAppRegHistoryId;
						}
						else
						{
							child.AdmAppRegHistoryId = entity.AdmAppRegHistoryId;
						}

					}

					if (entity.AdmAppExmptCourseCollection.Count > 0 || entity.AdmAppExmptCourseCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppExmptCourseProvider.Save(transactionManager, entity.AdmAppExmptCourseCollection);
						
						deepHandles.Add("AdmAppExmptCourseCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppExmptCourse >) DataRepository.AdmAppExmptCourseProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppExmptCourseCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmAppFeePromocode>
				if (CanDeepSave(entity.AdmAppFeePromocodeCollection, "List<AdmAppFeePromocode>|AdmAppFeePromocodeCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppFeePromocode child in entity.AdmAppFeePromocodeCollection)
					{
						if(child.AdmAppRegHistoryIdSource != null)
						{
							child.AdmAppRegHistoryId = child.AdmAppRegHistoryIdSource.AdmAppRegHistoryId;
						}
						else
						{
							child.AdmAppRegHistoryId = entity.AdmAppRegHistoryId;
						}

					}

					if (entity.AdmAppFeePromocodeCollection.Count > 0 || entity.AdmAppFeePromocodeCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppFeePromocodeProvider.Save(transactionManager, entity.AdmAppFeePromocodeCollection);
						
						deepHandles.Add("AdmAppFeePromocodeCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppFeePromocode >) DataRepository.AdmAppFeePromocodeProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppFeePromocodeCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeStudDisc>
				if (CanDeepSave(entity.FeeStudDiscCollection, "List<FeeStudDisc>|FeeStudDiscCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeStudDisc child in entity.FeeStudDiscCollection)
					{
						if(child.AdmAppRegHistoryIdSource != null)
						{
							child.AdmAppRegHistoryId = child.AdmAppRegHistoryIdSource.AdmAppRegHistoryId;
						}
						else
						{
							child.AdmAppRegHistoryId = entity.AdmAppRegHistoryId;
						}

					}

					if (entity.FeeStudDiscCollection.Count > 0 || entity.FeeStudDiscCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeStudDiscProvider.Save(transactionManager, entity.FeeStudDiscCollection);
						
						deepHandles.Add("FeeStudDiscCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeStudDisc >) DataRepository.FeeStudDiscProvider.DeepSave,
							new object[] { transactionManager, entity.FeeStudDiscCollection, deepSaveType, childTypes, innerList }
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
						if(child.AdmAppRegHistoryIdSource != null)
						{
							child.AdmAppRegHistoryId = child.AdmAppRegHistoryIdSource.AdmAppRegHistoryId;
						}
						else
						{
							child.AdmAppRegHistoryId = entity.AdmAppRegHistoryId;
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
				
	
			#region List<AdmAppPref>
				if (CanDeepSave(entity.AdmAppPrefCollection, "List<AdmAppPref>|AdmAppPrefCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppPref child in entity.AdmAppPrefCollection)
					{
						if(child.AdmAppRegHistoryIdSource != null)
						{
							child.AdmAppRegHistoryId = child.AdmAppRegHistoryIdSource.AdmAppRegHistoryId;
						}
						else
						{
							child.AdmAppRegHistoryId = entity.AdmAppRegHistoryId;
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
						if(child.AdmAppRegHistoryIdSource != null)
						{
							child.AdmAppRegHistoryId = child.AdmAppRegHistoryIdSource.AdmAppRegHistoryId;
						}
						else
						{
							child.AdmAppRegHistoryId = entity.AdmAppRegHistoryId;
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
						if(child.AdmAppRegHistoryIdSource != null)
						{
							child.AdmAppRegHistoryId = child.AdmAppRegHistoryIdSource.AdmAppRegHistoryId;
						}
						else
						{
							child.AdmAppRegHistoryId = entity.AdmAppRegHistoryId;
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
				
	
			#region List<AdmTansikAppCodes>
				if (CanDeepSave(entity.AdmTansikAppCodesCollection, "List<AdmTansikAppCodes>|AdmTansikAppCodesCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmTansikAppCodes child in entity.AdmTansikAppCodesCollection)
					{
						if(child.AdmAppRegHistoryIdSource != null)
						{
							child.AdmAppRegHistoryId = child.AdmAppRegHistoryIdSource.AdmAppRegHistoryId;
						}
						else
						{
							child.AdmAppRegHistoryId = entity.AdmAppRegHistoryId;
						}

					}

					if (entity.AdmTansikAppCodesCollection.Count > 0 || entity.AdmTansikAppCodesCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmTansikAppCodesProvider.Save(transactionManager, entity.AdmTansikAppCodesCollection);
						
						deepHandles.Add("AdmTansikAppCodesCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmTansikAppCodes >) DataRepository.AdmTansikAppCodesProvider.DeepSave,
							new object[] { transactionManager, entity.AdmTansikAppCodesCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudMilitaryState>
				if (CanDeepSave(entity.EdStudMilitaryStateCollection, "List<EdStudMilitaryState>|EdStudMilitaryStateCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudMilitaryState child in entity.EdStudMilitaryStateCollection)
					{
						if(child.AdmAppRegHistoryIdSource != null)
						{
							child.AdmAppRegHistoryId = child.AdmAppRegHistoryIdSource.AdmAppRegHistoryId;
						}
						else
						{
							child.AdmAppRegHistoryId = entity.AdmAppRegHistoryId;
						}

					}

					if (entity.EdStudMilitaryStateCollection.Count > 0 || entity.EdStudMilitaryStateCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudMilitaryStateProvider.Save(transactionManager, entity.EdStudMilitaryStateCollection);
						
						deepHandles.Add("EdStudMilitaryStateCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudMilitaryState >) DataRepository.EdStudMilitaryStateProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudMilitaryStateCollection, deepSaveType, childTypes, innerList }
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
						if(child.AdmAppRegHistoryIdSource != null)
						{
							child.AdmAppRegHistoryId = child.AdmAppRegHistoryIdSource.AdmAppRegHistoryId;
						}
						else
						{
							child.AdmAppRegHistoryId = entity.AdmAppRegHistoryId;
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
				
	
			#region List<EdStudMilitaryInfo>
				if (CanDeepSave(entity.EdStudMilitaryInfoCollection, "List<EdStudMilitaryInfo>|EdStudMilitaryInfoCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudMilitaryInfo child in entity.EdStudMilitaryInfoCollection)
					{
						if(child.AdmAppRegHistoryIdSource != null)
						{
							child.AdmAppRegHistoryId = child.AdmAppRegHistoryIdSource.AdmAppRegHistoryId;
						}
						else
						{
							child.AdmAppRegHistoryId = entity.AdmAppRegHistoryId;
						}

					}

					if (entity.EdStudMilitaryInfoCollection.Count > 0 || entity.EdStudMilitaryInfoCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudMilitaryInfoProvider.Save(transactionManager, entity.EdStudMilitaryInfoCollection);
						
						deepHandles.Add("EdStudMilitaryInfoCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudMilitaryInfo >) DataRepository.EdStudMilitaryInfoProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudMilitaryInfoCollection, deepSaveType, childTypes, innerList }
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
						if(child.AdmAppRegHistoryIdSource != null)
						{
							child.AdmAppRegHistoryId = child.AdmAppRegHistoryIdSource.AdmAppRegHistoryId;
						}
						else
						{
							child.AdmAppRegHistoryId = entity.AdmAppRegHistoryId;
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
						if(child.AdmAppRegHistoryIdSource != null)
						{
							child.AdmAppRegHistoryId = child.AdmAppRegHistoryIdSource.AdmAppRegHistoryId;
						}
						else
						{
							child.AdmAppRegHistoryId = entity.AdmAppRegHistoryId;
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
						if(child.AdmAppRegHistoryIdSource != null)
						{
							child.AdmAppRegHistoryId = child.AdmAppRegHistoryIdSource.AdmAppRegHistoryId;
						}
						else
						{
							child.AdmAppRegHistoryId = entity.AdmAppRegHistoryId;
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
				
	
			#region List<AdmAppAlumniPref>
				if (CanDeepSave(entity.AdmAppAlumniPrefCollection, "List<AdmAppAlumniPref>|AdmAppAlumniPrefCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppAlumniPref child in entity.AdmAppAlumniPrefCollection)
					{
						if(child.AdmAppRegHistoryIdSource != null)
						{
							child.AdmAppRegHistoryId = child.AdmAppRegHistoryIdSource.AdmAppRegHistoryId;
						}
						else
						{
							child.AdmAppRegHistoryId = entity.AdmAppRegHistoryId;
						}

					}

					if (entity.AdmAppAlumniPrefCollection.Count > 0 || entity.AdmAppAlumniPrefCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppAlumniPrefProvider.Save(transactionManager, entity.AdmAppAlumniPrefCollection);
						
						deepHandles.Add("AdmAppAlumniPrefCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppAlumniPref >) DataRepository.AdmAppAlumniPrefProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppAlumniPrefCollection, deepSaveType, childTypes, innerList }
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
						if(child.AdmAppRegHistoryIdSource != null)
						{
							child.AdmAppRegHistoryId = child.AdmAppRegHistoryIdSource.AdmAppRegHistoryId;
						}
						else
						{
							child.AdmAppRegHistoryId = entity.AdmAppRegHistoryId;
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
				
	
			#region List<AdmAppSponsor>
				if (CanDeepSave(entity.AdmAppSponsorCollection, "List<AdmAppSponsor>|AdmAppSponsorCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppSponsor child in entity.AdmAppSponsorCollection)
					{
						if(child.AdmAppRegHistoryIdSource != null)
						{
							child.AdmAppRegHistoryId = child.AdmAppRegHistoryIdSource.AdmAppRegHistoryId;
						}
						else
						{
							child.AdmAppRegHistoryId = entity.AdmAppRegHistoryId;
						}

					}

					if (entity.AdmAppSponsorCollection.Count > 0 || entity.AdmAppSponsorCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppSponsorProvider.Save(transactionManager, entity.AdmAppSponsorCollection);
						
						deepHandles.Add("AdmAppSponsorCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppSponsor >) DataRepository.AdmAppSponsorProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppSponsorCollection, deepSaveType, childTypes, innerList }
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
						if(child.AdmAppRegHistoryIdSource != null)
						{
							child.AdmAppRegHistoryId = child.AdmAppRegHistoryIdSource.AdmAppRegHistoryId;
						}
						else
						{
							child.AdmAppRegHistoryId = entity.AdmAppRegHistoryId;
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
				
	
			#region List<AdmAppTransReq>
				if (CanDeepSave(entity.AdmAppTransReqCollection, "List<AdmAppTransReq>|AdmAppTransReqCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppTransReq child in entity.AdmAppTransReqCollection)
					{
						if(child.AdmAppRegHistoryIdSource != null)
						{
							child.AdmAppRegHistoryId = child.AdmAppRegHistoryIdSource.AdmAppRegHistoryId;
						}
						else
						{
							child.AdmAppRegHistoryId = entity.AdmAppRegHistoryId;
						}

					}

					if (entity.AdmAppTransReqCollection.Count > 0 || entity.AdmAppTransReqCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppTransReqProvider.Save(transactionManager, entity.AdmAppTransReqCollection);
						
						deepHandles.Add("AdmAppTransReqCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppTransReq >) DataRepository.AdmAppTransReqProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppTransReqCollection, deepSaveType, childTypes, innerList }
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
						if(child.AdmAppRegHistoryIdSource != null)
						{
							child.AdmAppRegHistoryId = child.AdmAppRegHistoryIdSource.AdmAppRegHistoryId;
						}
						else
						{
							child.AdmAppRegHistoryId = entity.AdmAppRegHistoryId;
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
						if(child.AdmAppRegHistoryIdSource != null)
						{
							child.AdmAppRegHistoryId = child.AdmAppRegHistoryIdSource.AdmAppRegHistoryId;
						}
						else
						{
							child.AdmAppRegHistoryId = entity.AdmAppRegHistoryId;
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
	
	#region AdmAppRegHistoryChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AdmAppRegHistory</c>
	///</summary>
	public enum AdmAppRegHistoryChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AdmAdmissionBand</c> at AdmAdmissionBandIdSource
		///</summary>
		[ChildEntityType(typeof(AdmAdmissionBand))]
		AdmAdmissionBand,
		
		///<summary>
		/// Composite Property for <c>AdmCdeAppStatus</c> at AdmCdeAppStatusIdSource
		///</summary>
		[ChildEntityType(typeof(AdmCdeAppStatus))]
		AdmCdeAppStatus,
		
		///<summary>
		/// Composite Property for <c>AdmCdeAppType</c> at AdmCdeAppTypeIdSource
		///</summary>
		[ChildEntityType(typeof(AdmCdeAppType))]
		AdmCdeAppType,
		
		///<summary>
		/// Composite Property for <c>AdmCdeStatus</c> at AdmCdeStatusIdSource
		///</summary>
		[ChildEntityType(typeof(AdmCdeStatus))]
		AdmCdeStatus,
		
		///<summary>
		/// Composite Property for <c>AdmCdeStatusRsn</c> at AdmCdeStatusRsnIdSource
		///</summary>
		[ChildEntityType(typeof(AdmCdeStatusRsn))]
		AdmCdeStatusRsn,
		
		///<summary>
		/// Composite Property for <c>AdmDecisionStatus</c> at AdmDecisionStatusIdSource
		///</summary>
		[ChildEntityType(typeof(AdmDecisionStatus))]
		AdmDecisionStatus,
		
		///<summary>
		/// Composite Property for <c>AdmApplicant</c> at AdmApplicantIdSource
		///</summary>
		[ChildEntityType(typeof(AdmApplicant))]
		AdmApplicant,
		
		///<summary>
		/// Composite Property for <c>AdmOpenAcadSemester</c> at AdmOpenAcadSemesterIdSource
		///</summary>
		[ChildEntityType(typeof(AdmOpenAcadSemester))]
		AdmOpenAcadSemester,
		
		///<summary>
		/// Composite Property for <c>AsCodeDegree</c> at AsCodeDegreeIdSource
		///</summary>
		[ChildEntityType(typeof(AsCodeDegree))]
		AsCodeDegree,
		
		///<summary>
		/// Composite Property for <c>AsCodeDegreeClass</c> at AsCodeDegreeClassIdSource
		///</summary>
		[ChildEntityType(typeof(AsCodeDegreeClass))]
		AsCodeDegreeClass,
		
		///<summary>
		/// Composite Property for <c>EdAcadYear</c> at EdAcadYearIdSource
		///</summary>
		[ChildEntityType(typeof(EdAcadYear))]
		EdAcadYear,
		
		///<summary>
		/// Composite Property for <c>EdCodeLevel</c> at EdCodeLevelIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeLevel))]
		EdCodeLevel,
		
		///<summary>
		/// Composite Property for <c>EdCodeSemester</c> at EdCodeSemesterIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeSemester))]
		EdCodeSemester,
		
		///<summary>
		/// Composite Property for <c>FeeCdeDiscCat</c> at FeeCdeDiscCatIdSource
		///</summary>
		[ChildEntityType(typeof(FeeCdeDiscCat))]
		FeeCdeDiscCat,
		
		///<summary>
		/// Composite Property for <c>FeeCdeDiscType</c> at FeeCdeDiscTypeIdSource
		///</summary>
		[ChildEntityType(typeof(FeeCdeDiscType))]
		FeeCdeDiscType,
		
		///<summary>
		/// Composite Property for <c>FeeCdeSchshipType</c> at FeeCdeSchshipTypeIdSource
		///</summary>
		[ChildEntityType(typeof(FeeCdeSchshipType))]
		FeeCdeSchshipType,
		
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
		/// Composite Property for <c>SpoSponsorType</c> at SpoSponsorTypeIdSource
		///</summary>
		[ChildEntityType(typeof(SpoSponsorType))]
		SpoSponsorType,
		///<summary>
		/// Collection of <c>AdmAppRegHistory</c> as OneToMany for SpoSponsorStudCollection
		///</summary>
		[ChildEntityType(typeof(TList<SpoSponsorStud>))]
		SpoSponsorStudCollection,
		///<summary>
		/// Collection of <c>AdmAppRegHistory</c> as OneToMany for AdmApplicantAcceptanceCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmApplicantAcceptance>))]
		AdmApplicantAcceptanceCollection,
		///<summary>
		/// Collection of <c>AdmAppRegHistory</c> as OneToMany for AdmAppInterviewExamCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppInterviewExam>))]
		AdmAppInterviewExamCollection,
		///<summary>
		/// Collection of <c>AdmAppRegHistory</c> as OneToMany for AdmAppPlaceExamCourseCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppPlaceExamCourse>))]
		AdmAppPlaceExamCourseCollection,
		///<summary>
		/// Collection of <c>AdmAppRegHistory</c> as OneToMany for AdmAppHonorCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppHonor>))]
		AdmAppHonorCollection,
		///<summary>
		/// Collection of <c>AdmAppRegHistory</c> as OneToMany for AdmAppDocCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppDoc>))]
		AdmAppDocCollection,
		///<summary>
		/// Collection of <c>AdmAppRegHistory</c> as OneToMany for AdmAppExmptCourseCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppExmptCourse>))]
		AdmAppExmptCourseCollection,
		///<summary>
		/// Collection of <c>AdmAppRegHistory</c> as OneToMany for AdmAppFeePromocodeCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppFeePromocode>))]
		AdmAppFeePromocodeCollection,
		///<summary>
		/// Collection of <c>AdmAppRegHistory</c> as OneToMany for FeeStudDiscCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudDisc>))]
		FeeStudDiscCollection,
		///<summary>
		/// Collection of <c>AdmAppRegHistory</c> as OneToMany for AdmAppInfoCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppInfo>))]
		AdmAppInfoCollection,
		///<summary>
		/// Collection of <c>AdmAppRegHistory</c> as OneToMany for AdmAppPrefCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppPref>))]
		AdmAppPrefCollection,
		///<summary>
		/// Collection of <c>AdmAppRegHistory</c> as OneToMany for AdmAppPlacementExamCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppPlacementExam>))]
		AdmAppPlacementExamCollection,
		///<summary>
		/// Collection of <c>AdmAppRegHistory</c> as OneToMany for EdStudQualCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudQual>))]
		EdStudQualCollection,
		///<summary>
		/// Collection of <c>AdmAppRegHistory</c> as OneToMany for AdmTansikAppCodesCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmTansikAppCodes>))]
		AdmTansikAppCodesCollection,
		///<summary>
		/// Collection of <c>AdmAppRegHistory</c> as OneToMany for EdStudMilitaryStateCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudMilitaryState>))]
		EdStudMilitaryStateCollection,
		///<summary>
		/// Collection of <c>AdmAppRegHistory</c> as OneToMany for AdmAppGuardianCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppGuardian>))]
		AdmAppGuardianCollection,
		///<summary>
		/// Collection of <c>AdmAppRegHistory</c> as OneToMany for EdStudMilitaryInfoCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudMilitaryInfo>))]
		EdStudMilitaryInfoCollection,
		///<summary>
		/// Collection of <c>AdmAppRegHistory</c> as OneToMany for AdmAppProcStepsCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppProcSteps>))]
		AdmAppProcStepsCollection,
		///<summary>
		/// Collection of <c>AdmAppRegHistory</c> as OneToMany for AdmAppEssayCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppEssay>))]
		AdmAppEssayCollection,
		///<summary>
		/// Collection of <c>AdmAppRegHistory</c> as OneToMany for AdmAppLanguagesCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppLanguages>))]
		AdmAppLanguagesCollection,
		///<summary>
		/// Collection of <c>AdmAppRegHistory</c> as OneToMany for AdmAppAlumniPrefCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppAlumniPref>))]
		AdmAppAlumniPrefCollection,
		///<summary>
		/// Collection of <c>AdmAppRegHistory</c> as OneToMany for AdmAppMediaCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppMedia>))]
		AdmAppMediaCollection,
		///<summary>
		/// Collection of <c>AdmAppRegHistory</c> as OneToMany for AdmAppSponsorCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppSponsor>))]
		AdmAppSponsorCollection,
		///<summary>
		/// Collection of <c>AdmAppRegHistory</c> as OneToMany for AdmEnglishProficiencyCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmEnglishProficiency>))]
		AdmEnglishProficiencyCollection,
		///<summary>
		/// Collection of <c>AdmAppRegHistory</c> as OneToMany for AdmAppTransReqCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppTransReq>))]
		AdmAppTransReqCollection,
		///<summary>
		/// Collection of <c>AdmAppRegHistory</c> as OneToMany for AdmAppWorkExperCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppWorkExper>))]
		AdmAppWorkExperCollection,
		///<summary>
		/// Collection of <c>AdmAppRegHistory</c> as OneToMany for AdmAppLtrRecomCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppLtrRecom>))]
		AdmAppLtrRecomCollection,
	}
	
	#endregion AdmAppRegHistoryChildEntityTypes
	
	#region AdmAppRegHistoryFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AdmAppRegHistoryColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAppRegHistory"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmAppRegHistoryFilterBuilder : SqlFilterBuilder<AdmAppRegHistoryColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAppRegHistoryFilterBuilder class.
		/// </summary>
		public AdmAppRegHistoryFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmAppRegHistoryFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmAppRegHistoryFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmAppRegHistoryFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmAppRegHistoryFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmAppRegHistoryFilterBuilder
	
	#region AdmAppRegHistoryParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AdmAppRegHistoryColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAppRegHistory"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmAppRegHistoryParameterBuilder : ParameterizedSqlFilterBuilder<AdmAppRegHistoryColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAppRegHistoryParameterBuilder class.
		/// </summary>
		public AdmAppRegHistoryParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmAppRegHistoryParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmAppRegHistoryParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmAppRegHistoryParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmAppRegHistoryParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmAppRegHistoryParameterBuilder
	
	#region AdmAppRegHistorySortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AdmAppRegHistoryColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAppRegHistory"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AdmAppRegHistorySortBuilder : SqlSortBuilder<AdmAppRegHistoryColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAppRegHistorySqlSortBuilder class.
		/// </summary>
		public AdmAppRegHistorySortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AdmAppRegHistorySortBuilder
	
} // end namespace
