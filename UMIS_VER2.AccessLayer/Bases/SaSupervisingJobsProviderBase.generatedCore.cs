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
	/// This class is the base class for any <see cref="SaSupervisingJobsProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SaSupervisingJobsProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SaSupervisingJobs, UMIS_VER2.BusinessLyer.SaSupervisingJobsKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaSupervisingJobsKey key)
		{
			return Delete(transactionManager, key.SaSupervisingJobsId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_saSupervisingJobsId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _saSupervisingJobsId)
		{
			return Delete(null, _saSupervisingJobsId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saSupervisingJobsId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _saSupervisingJobsId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_036f key.
		///		FK_AUTO_036f Description: 
		/// </summary>
		/// <param name="_saCodeScDegId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaSupervisingJobs objects.</returns>
		public TList<SaSupervisingJobs> GetBySaCodeScDegId(System.Decimal _saCodeScDegId)
		{
			int count = -1;
			return GetBySaCodeScDegId(_saCodeScDegId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_036f key.
		///		FK_AUTO_036f Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeScDegId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaSupervisingJobs objects.</returns>
		/// <remarks></remarks>
		public TList<SaSupervisingJobs> GetBySaCodeScDegId(TransactionManager transactionManager, System.Decimal _saCodeScDegId)
		{
			int count = -1;
			return GetBySaCodeScDegId(transactionManager, _saCodeScDegId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_036f key.
		///		FK_AUTO_036f Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeScDegId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaSupervisingJobs objects.</returns>
		public TList<SaSupervisingJobs> GetBySaCodeScDegId(TransactionManager transactionManager, System.Decimal _saCodeScDegId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeScDegId(transactionManager, _saCodeScDegId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_036f key.
		///		fkAuto036f Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saCodeScDegId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaSupervisingJobs objects.</returns>
		public TList<SaSupervisingJobs> GetBySaCodeScDegId(System.Decimal _saCodeScDegId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaCodeScDegId(null, _saCodeScDegId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_036f key.
		///		fkAuto036f Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saCodeScDegId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaSupervisingJobs objects.</returns>
		public TList<SaSupervisingJobs> GetBySaCodeScDegId(System.Decimal _saCodeScDegId, int start, int pageLength,out int count)
		{
			return GetBySaCodeScDegId(null, _saCodeScDegId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_036f key.
		///		FK_AUTO_036f Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeScDegId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaSupervisingJobs objects.</returns>
		public abstract TList<SaSupervisingJobs> GetBySaCodeScDegId(TransactionManager transactionManager, System.Decimal _saCodeScDegId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SUPERVISING_JOBS_AS_FACULTY_INFO key.
		///		FK_SA_SUPERVISING_JOBS_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaSupervisingJobs objects.</returns>
		public TList<SaSupervisingJobs> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(_asFacultyInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SUPERVISING_JOBS_AS_FACULTY_INFO key.
		///		FK_SA_SUPERVISING_JOBS_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaSupervisingJobs objects.</returns>
		/// <remarks></remarks>
		public TList<SaSupervisingJobs> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SUPERVISING_JOBS_AS_FACULTY_INFO key.
		///		FK_SA_SUPERVISING_JOBS_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaSupervisingJobs objects.</returns>
		public TList<SaSupervisingJobs> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SUPERVISING_JOBS_AS_FACULTY_INFO key.
		///		fkSaSupervisingJobsAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaSupervisingJobs objects.</returns>
		public TList<SaSupervisingJobs> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SUPERVISING_JOBS_AS_FACULTY_INFO key.
		///		fkSaSupervisingJobsAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaSupervisingJobs objects.</returns>
		public TList<SaSupervisingJobs> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength,out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SUPERVISING_JOBS_AS_FACULTY_INFO key.
		///		FK_SA_SUPERVISING_JOBS_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaSupervisingJobs objects.</returns>
		public abstract TList<SaSupervisingJobs> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SUPERVISING_JOBS_ENTITY_MAIN key.
		///		FK_SA_SUPERVISING_JOBS_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="_asNodeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaSupervisingJobs objects.</returns>
		public TList<SaSupervisingJobs> GetByAsNodeId(System.Decimal? _asNodeId)
		{
			int count = -1;
			return GetByAsNodeId(_asNodeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SUPERVISING_JOBS_ENTITY_MAIN key.
		///		FK_SA_SUPERVISING_JOBS_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asNodeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaSupervisingJobs objects.</returns>
		/// <remarks></remarks>
		public TList<SaSupervisingJobs> GetByAsNodeId(TransactionManager transactionManager, System.Decimal? _asNodeId)
		{
			int count = -1;
			return GetByAsNodeId(transactionManager, _asNodeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SUPERVISING_JOBS_ENTITY_MAIN key.
		///		FK_SA_SUPERVISING_JOBS_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asNodeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaSupervisingJobs objects.</returns>
		public TList<SaSupervisingJobs> GetByAsNodeId(TransactionManager transactionManager, System.Decimal? _asNodeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsNodeId(transactionManager, _asNodeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SUPERVISING_JOBS_ENTITY_MAIN key.
		///		fkSaSupervisingJobsEntityMain Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asNodeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaSupervisingJobs objects.</returns>
		public TList<SaSupervisingJobs> GetByAsNodeId(System.Decimal? _asNodeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsNodeId(null, _asNodeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SUPERVISING_JOBS_ENTITY_MAIN key.
		///		fkSaSupervisingJobsEntityMain Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asNodeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaSupervisingJobs objects.</returns>
		public TList<SaSupervisingJobs> GetByAsNodeId(System.Decimal? _asNodeId, int start, int pageLength,out int count)
		{
			return GetByAsNodeId(null, _asNodeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SUPERVISING_JOBS_ENTITY_MAIN key.
		///		FK_SA_SUPERVISING_JOBS_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asNodeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaSupervisingJobs objects.</returns>
		public abstract TList<SaSupervisingJobs> GetByAsNodeId(TransactionManager transactionManager, System.Decimal? _asNodeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SUPERVISING_JOBS_SA_CODE_SUPERVISE_JOB key.
		///		FK_SA_SUPERVISING_JOBS_SA_CODE_SUPERVISE_JOB Description: 
		/// </summary>
		/// <param name="_saCodeSuperviseJobId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaSupervisingJobs objects.</returns>
		public TList<SaSupervisingJobs> GetBySaCodeSuperviseJobId(System.Decimal _saCodeSuperviseJobId)
		{
			int count = -1;
			return GetBySaCodeSuperviseJobId(_saCodeSuperviseJobId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SUPERVISING_JOBS_SA_CODE_SUPERVISE_JOB key.
		///		FK_SA_SUPERVISING_JOBS_SA_CODE_SUPERVISE_JOB Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeSuperviseJobId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaSupervisingJobs objects.</returns>
		/// <remarks></remarks>
		public TList<SaSupervisingJobs> GetBySaCodeSuperviseJobId(TransactionManager transactionManager, System.Decimal _saCodeSuperviseJobId)
		{
			int count = -1;
			return GetBySaCodeSuperviseJobId(transactionManager, _saCodeSuperviseJobId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SUPERVISING_JOBS_SA_CODE_SUPERVISE_JOB key.
		///		FK_SA_SUPERVISING_JOBS_SA_CODE_SUPERVISE_JOB Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeSuperviseJobId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaSupervisingJobs objects.</returns>
		public TList<SaSupervisingJobs> GetBySaCodeSuperviseJobId(TransactionManager transactionManager, System.Decimal _saCodeSuperviseJobId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeSuperviseJobId(transactionManager, _saCodeSuperviseJobId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SUPERVISING_JOBS_SA_CODE_SUPERVISE_JOB key.
		///		fkSaSupervisingJobsSaCodeSuperviseJob Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saCodeSuperviseJobId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaSupervisingJobs objects.</returns>
		public TList<SaSupervisingJobs> GetBySaCodeSuperviseJobId(System.Decimal _saCodeSuperviseJobId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaCodeSuperviseJobId(null, _saCodeSuperviseJobId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SUPERVISING_JOBS_SA_CODE_SUPERVISE_JOB key.
		///		fkSaSupervisingJobsSaCodeSuperviseJob Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saCodeSuperviseJobId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaSupervisingJobs objects.</returns>
		public TList<SaSupervisingJobs> GetBySaCodeSuperviseJobId(System.Decimal _saCodeSuperviseJobId, int start, int pageLength,out int count)
		{
			return GetBySaCodeSuperviseJobId(null, _saCodeSuperviseJobId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SUPERVISING_JOBS_SA_CODE_SUPERVISE_JOB key.
		///		FK_SA_SUPERVISING_JOBS_SA_CODE_SUPERVISE_JOB Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeSuperviseJobId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaSupervisingJobs objects.</returns>
		public abstract TList<SaSupervisingJobs> GetBySaCodeSuperviseJobId(TransactionManager transactionManager, System.Decimal _saCodeSuperviseJobId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SUPERVISING_JOBS_SA_STF_MEMBER key.
		///		FK_SA_SUPERVISING_JOBS_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="_saStfMemberId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaSupervisingJobs objects.</returns>
		public TList<SaSupervisingJobs> GetBySaStfMemberId(System.Decimal _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(_saStfMemberId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SUPERVISING_JOBS_SA_STF_MEMBER key.
		///		FK_SA_SUPERVISING_JOBS_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaSupervisingJobs objects.</returns>
		/// <remarks></remarks>
		public TList<SaSupervisingJobs> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SUPERVISING_JOBS_SA_STF_MEMBER key.
		///		FK_SA_SUPERVISING_JOBS_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaSupervisingJobs objects.</returns>
		public TList<SaSupervisingJobs> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SUPERVISING_JOBS_SA_STF_MEMBER key.
		///		fkSaSupervisingJobsSaStfMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemberId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaSupervisingJobs objects.</returns>
		public TList<SaSupervisingJobs> GetBySaStfMemberId(System.Decimal _saStfMemberId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SUPERVISING_JOBS_SA_STF_MEMBER key.
		///		fkSaSupervisingJobsSaStfMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaSupervisingJobs objects.</returns>
		public TList<SaSupervisingJobs> GetBySaStfMemberId(System.Decimal _saStfMemberId, int start, int pageLength,out int count)
		{
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SUPERVISING_JOBS_SA_STF_MEMBER key.
		///		FK_SA_SUPERVISING_JOBS_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaSupervisingJobs objects.</returns>
		public abstract TList<SaSupervisingJobs> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SaSupervisingJobs Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaSupervisingJobsKey key, int start, int pageLength)
		{
			return GetBySaSupervisingJobsId(transactionManager, key.SaSupervisingJobsId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SA_SUPERVISING_JOBS index.
		/// </summary>
		/// <param name="_saSupervisingJobsId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaSupervisingJobs"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaSupervisingJobs GetBySaSupervisingJobsId(System.Decimal _saSupervisingJobsId)
		{
			int count = -1;
			return GetBySaSupervisingJobsId(null,_saSupervisingJobsId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_SUPERVISING_JOBS index.
		/// </summary>
		/// <param name="_saSupervisingJobsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaSupervisingJobs"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaSupervisingJobs GetBySaSupervisingJobsId(System.Decimal _saSupervisingJobsId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaSupervisingJobsId(null, _saSupervisingJobsId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_SUPERVISING_JOBS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saSupervisingJobsId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaSupervisingJobs"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaSupervisingJobs GetBySaSupervisingJobsId(TransactionManager transactionManager, System.Decimal _saSupervisingJobsId)
		{
			int count = -1;
			return GetBySaSupervisingJobsId(transactionManager, _saSupervisingJobsId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_SUPERVISING_JOBS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saSupervisingJobsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaSupervisingJobs"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaSupervisingJobs GetBySaSupervisingJobsId(TransactionManager transactionManager, System.Decimal _saSupervisingJobsId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaSupervisingJobsId(transactionManager, _saSupervisingJobsId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_SUPERVISING_JOBS index.
		/// </summary>
		/// <param name="_saSupervisingJobsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaSupervisingJobs"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaSupervisingJobs GetBySaSupervisingJobsId(System.Decimal _saSupervisingJobsId, int start, int pageLength, out int count)
		{
			return GetBySaSupervisingJobsId(null, _saSupervisingJobsId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_SUPERVISING_JOBS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saSupervisingJobsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaSupervisingJobs"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SaSupervisingJobs GetBySaSupervisingJobsId(TransactionManager transactionManager, System.Decimal _saSupervisingJobsId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SaSupervisingJobs&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SaSupervisingJobs&gt;"/></returns>
		public static TList<SaSupervisingJobs> Fill(IDataReader reader, TList<SaSupervisingJobs> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SaSupervisingJobs c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SaSupervisingJobs")
					.Append("|").Append((System.Decimal)reader["SA_SUPERVISING_JOBS_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SaSupervisingJobs>(
					key.ToString(), // EntityTrackingKey
					"SaSupervisingJobs",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SaSupervisingJobs();
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
					c.SaSupervisingJobsId = (System.Decimal)reader["SA_SUPERVISING_JOBS_ID"];
					c.OriginalSaSupervisingJobsId = c.SaSupervisingJobsId;
					c.StartDate = (System.DateTime)reader["START_DATE"];
					c.EndDate = Convert.IsDBNull(reader["END_DATE"]) ? null : (System.DateTime?)reader["END_DATE"];
					c.DecisionNum = (System.String)reader["DECISION_NUM"];
					c.DecisionDate = (System.DateTime)reader["DECISION_DATE"];
					c.PeriodCount = (System.Decimal)reader["PERIOD_COUNT"];
					c.Comments = Convert.IsDBNull(reader["COMMENTS"]) ? null : (System.String)reader["COMMENTS"];
					c.SaCodeSuperviseJobId = (System.Decimal)reader["SA_CODE_SUPERVISE_JOB_ID"];
					c.IsSupervising = (System.Decimal)reader["IS_SUPERVISING"];
					c.SaStfMemberId = (System.Decimal)reader["SA_STF_MEMBER_ID"];
					c.AsNodeId = Convert.IsDBNull(reader["AS_NODE_ID"]) ? null : (System.Decimal?)reader["AS_NODE_ID"];
					c.AsFacultyInfoId = (System.Decimal)reader["AS_FACULTY_INFO_ID"];
					c.SaCodeScDegId = (System.Decimal)reader["SA_CODE_SC_DEG_ID"];
					c.JobTermReason = Convert.IsDBNull(reader["JOB_TERM_REASON"]) ? null : (System.String)reader["JOB_TERM_REASON"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaSupervisingJobs"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaSupervisingJobs"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SaSupervisingJobs entity)
		{
			if (!reader.Read()) return;
			
			entity.SaSupervisingJobsId = (System.Decimal)reader[((int)SaSupervisingJobsColumn.SaSupervisingJobsId - 1)];
			entity.OriginalSaSupervisingJobsId = (System.Decimal)reader["SA_SUPERVISING_JOBS_ID"];
			entity.StartDate = (System.DateTime)reader[((int)SaSupervisingJobsColumn.StartDate - 1)];
			entity.EndDate = (reader.IsDBNull(((int)SaSupervisingJobsColumn.EndDate - 1)))?null:(System.DateTime?)reader[((int)SaSupervisingJobsColumn.EndDate - 1)];
			entity.DecisionNum = (System.String)reader[((int)SaSupervisingJobsColumn.DecisionNum - 1)];
			entity.DecisionDate = (System.DateTime)reader[((int)SaSupervisingJobsColumn.DecisionDate - 1)];
			entity.PeriodCount = (System.Decimal)reader[((int)SaSupervisingJobsColumn.PeriodCount - 1)];
			entity.Comments = (reader.IsDBNull(((int)SaSupervisingJobsColumn.Comments - 1)))?null:(System.String)reader[((int)SaSupervisingJobsColumn.Comments - 1)];
			entity.SaCodeSuperviseJobId = (System.Decimal)reader[((int)SaSupervisingJobsColumn.SaCodeSuperviseJobId - 1)];
			entity.IsSupervising = (System.Decimal)reader[((int)SaSupervisingJobsColumn.IsSupervising - 1)];
			entity.SaStfMemberId = (System.Decimal)reader[((int)SaSupervisingJobsColumn.SaStfMemberId - 1)];
			entity.AsNodeId = (reader.IsDBNull(((int)SaSupervisingJobsColumn.AsNodeId - 1)))?null:(System.Decimal?)reader[((int)SaSupervisingJobsColumn.AsNodeId - 1)];
			entity.AsFacultyInfoId = (System.Decimal)reader[((int)SaSupervisingJobsColumn.AsFacultyInfoId - 1)];
			entity.SaCodeScDegId = (System.Decimal)reader[((int)SaSupervisingJobsColumn.SaCodeScDegId - 1)];
			entity.JobTermReason = (reader.IsDBNull(((int)SaSupervisingJobsColumn.JobTermReason - 1)))?null:(System.String)reader[((int)SaSupervisingJobsColumn.JobTermReason - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaSupervisingJobs"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaSupervisingJobs"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SaSupervisingJobs entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SaSupervisingJobsId = (System.Decimal)dataRow["SA_SUPERVISING_JOBS_ID"];
			entity.OriginalSaSupervisingJobsId = (System.Decimal)dataRow["SA_SUPERVISING_JOBS_ID"];
			entity.StartDate = (System.DateTime)dataRow["START_DATE"];
			entity.EndDate = Convert.IsDBNull(dataRow["END_DATE"]) ? null : (System.DateTime?)dataRow["END_DATE"];
			entity.DecisionNum = (System.String)dataRow["DECISION_NUM"];
			entity.DecisionDate = (System.DateTime)dataRow["DECISION_DATE"];
			entity.PeriodCount = (System.Decimal)dataRow["PERIOD_COUNT"];
			entity.Comments = Convert.IsDBNull(dataRow["COMMENTS"]) ? null : (System.String)dataRow["COMMENTS"];
			entity.SaCodeSuperviseJobId = (System.Decimal)dataRow["SA_CODE_SUPERVISE_JOB_ID"];
			entity.IsSupervising = (System.Decimal)dataRow["IS_SUPERVISING"];
			entity.SaStfMemberId = (System.Decimal)dataRow["SA_STF_MEMBER_ID"];
			entity.AsNodeId = Convert.IsDBNull(dataRow["AS_NODE_ID"]) ? null : (System.Decimal?)dataRow["AS_NODE_ID"];
			entity.AsFacultyInfoId = (System.Decimal)dataRow["AS_FACULTY_INFO_ID"];
			entity.SaCodeScDegId = (System.Decimal)dataRow["SA_CODE_SC_DEG_ID"];
			entity.JobTermReason = Convert.IsDBNull(dataRow["JOB_TERM_REASON"]) ? null : (System.String)dataRow["JOB_TERM_REASON"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaSupervisingJobs"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaSupervisingJobs Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaSupervisingJobs entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region SaCodeScDegIdSource	
			if (CanDeepLoad(entity, "SaCodeScDeg|SaCodeScDegIdSource", deepLoadType, innerList) 
				&& entity.SaCodeScDegIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SaCodeScDegId;
				SaCodeScDeg tmpEntity = EntityManager.LocateEntity<SaCodeScDeg>(EntityLocator.ConstructKeyFromPkItems(typeof(SaCodeScDeg), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaCodeScDegIdSource = tmpEntity;
				else
					entity.SaCodeScDegIdSource = DataRepository.SaCodeScDegProvider.GetBySaCodeScDegId(transactionManager, entity.SaCodeScDegId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaCodeScDegIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaCodeScDegIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaCodeScDegProvider.DeepLoad(transactionManager, entity.SaCodeScDegIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaCodeScDegIdSource

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

			#region AsNodeIdSource	
			if (CanDeepLoad(entity, "EntityMain|AsNodeIdSource", deepLoadType, innerList) 
				&& entity.AsNodeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AsNodeId ?? 0.0m);
				EntityMain tmpEntity = EntityManager.LocateEntity<EntityMain>(EntityLocator.ConstructKeyFromPkItems(typeof(EntityMain), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AsNodeIdSource = tmpEntity;
				else
					entity.AsNodeIdSource = DataRepository.EntityMainProvider.GetByEntMainId(transactionManager, (entity.AsNodeId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AsNodeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AsNodeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EntityMainProvider.DeepLoad(transactionManager, entity.AsNodeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AsNodeIdSource

			#region SaCodeSuperviseJobIdSource	
			if (CanDeepLoad(entity, "SaCodeSuperviseJob|SaCodeSuperviseJobIdSource", deepLoadType, innerList) 
				&& entity.SaCodeSuperviseJobIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SaCodeSuperviseJobId;
				SaCodeSuperviseJob tmpEntity = EntityManager.LocateEntity<SaCodeSuperviseJob>(EntityLocator.ConstructKeyFromPkItems(typeof(SaCodeSuperviseJob), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaCodeSuperviseJobIdSource = tmpEntity;
				else
					entity.SaCodeSuperviseJobIdSource = DataRepository.SaCodeSuperviseJobProvider.GetBySaCodeSuperviseJobId(transactionManager, entity.SaCodeSuperviseJobId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaCodeSuperviseJobIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaCodeSuperviseJobIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaCodeSuperviseJobProvider.DeepLoad(transactionManager, entity.SaCodeSuperviseJobIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaCodeSuperviseJobIdSource

			#region SaStfMemberIdSource	
			if (CanDeepLoad(entity, "SaStfMember|SaStfMemberIdSource", deepLoadType, innerList) 
				&& entity.SaStfMemberIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SaStfMemberId;
				SaStfMember tmpEntity = EntityManager.LocateEntity<SaStfMember>(EntityLocator.ConstructKeyFromPkItems(typeof(SaStfMember), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaStfMemberIdSource = tmpEntity;
				else
					entity.SaStfMemberIdSource = DataRepository.SaStfMemberProvider.GetBySaStfMemberId(transactionManager, entity.SaStfMemberId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaStfMemberIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaStfMemberIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaStfMemberProvider.DeepLoad(transactionManager, entity.SaStfMemberIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaStfMemberIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SaSupervisingJobs object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SaSupervisingJobs instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaSupervisingJobs Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaSupervisingJobs entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region SaCodeScDegIdSource
			if (CanDeepSave(entity, "SaCodeScDeg|SaCodeScDegIdSource", deepSaveType, innerList) 
				&& entity.SaCodeScDegIdSource != null)
			{
				DataRepository.SaCodeScDegProvider.Save(transactionManager, entity.SaCodeScDegIdSource);
				entity.SaCodeScDegId = entity.SaCodeScDegIdSource.SaCodeScDegId;
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
			
			#region AsNodeIdSource
			if (CanDeepSave(entity, "EntityMain|AsNodeIdSource", deepSaveType, innerList) 
				&& entity.AsNodeIdSource != null)
			{
				DataRepository.EntityMainProvider.Save(transactionManager, entity.AsNodeIdSource);
				entity.AsNodeId = entity.AsNodeIdSource.EntMainId;
			}
			#endregion 
			
			#region SaCodeSuperviseJobIdSource
			if (CanDeepSave(entity, "SaCodeSuperviseJob|SaCodeSuperviseJobIdSource", deepSaveType, innerList) 
				&& entity.SaCodeSuperviseJobIdSource != null)
			{
				DataRepository.SaCodeSuperviseJobProvider.Save(transactionManager, entity.SaCodeSuperviseJobIdSource);
				entity.SaCodeSuperviseJobId = entity.SaCodeSuperviseJobIdSource.SaCodeSuperviseJobId;
			}
			#endregion 
			
			#region SaStfMemberIdSource
			if (CanDeepSave(entity, "SaStfMember|SaStfMemberIdSource", deepSaveType, innerList) 
				&& entity.SaStfMemberIdSource != null)
			{
				DataRepository.SaStfMemberProvider.Save(transactionManager, entity.SaStfMemberIdSource);
				entity.SaStfMemberId = entity.SaStfMemberIdSource.SaStfMemberId;
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
	
	#region SaSupervisingJobsChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SaSupervisingJobs</c>
	///</summary>
	public enum SaSupervisingJobsChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>SaCodeScDeg</c> at SaCodeScDegIdSource
		///</summary>
		[ChildEntityType(typeof(SaCodeScDeg))]
		SaCodeScDeg,
		
		///<summary>
		/// Composite Property for <c>AsFacultyInfo</c> at AsFacultyInfoIdSource
		///</summary>
		[ChildEntityType(typeof(AsFacultyInfo))]
		AsFacultyInfo,
		
		///<summary>
		/// Composite Property for <c>EntityMain</c> at AsNodeIdSource
		///</summary>
		[ChildEntityType(typeof(EntityMain))]
		EntityMain,
		
		///<summary>
		/// Composite Property for <c>SaCodeSuperviseJob</c> at SaCodeSuperviseJobIdSource
		///</summary>
		[ChildEntityType(typeof(SaCodeSuperviseJob))]
		SaCodeSuperviseJob,
		
		///<summary>
		/// Composite Property for <c>SaStfMember</c> at SaStfMemberIdSource
		///</summary>
		[ChildEntityType(typeof(SaStfMember))]
		SaStfMember,
	}
	
	#endregion SaSupervisingJobsChildEntityTypes
	
	#region SaSupervisingJobsFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SaSupervisingJobsColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaSupervisingJobs"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaSupervisingJobsFilterBuilder : SqlFilterBuilder<SaSupervisingJobsColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaSupervisingJobsFilterBuilder class.
		/// </summary>
		public SaSupervisingJobsFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaSupervisingJobsFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaSupervisingJobsFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaSupervisingJobsFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaSupervisingJobsFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaSupervisingJobsFilterBuilder
	
	#region SaSupervisingJobsParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SaSupervisingJobsColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaSupervisingJobs"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaSupervisingJobsParameterBuilder : ParameterizedSqlFilterBuilder<SaSupervisingJobsColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaSupervisingJobsParameterBuilder class.
		/// </summary>
		public SaSupervisingJobsParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaSupervisingJobsParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaSupervisingJobsParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaSupervisingJobsParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaSupervisingJobsParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaSupervisingJobsParameterBuilder
	
	#region SaSupervisingJobsSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SaSupervisingJobsColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaSupervisingJobs"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SaSupervisingJobsSortBuilder : SqlSortBuilder<SaSupervisingJobsColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaSupervisingJobsSqlSortBuilder class.
		/// </summary>
		public SaSupervisingJobsSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SaSupervisingJobsSortBuilder
	
} // end namespace
