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
	/// This class is the base class for any <see cref="ScScheduleRsrvProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class ScScheduleRsrvProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.ScScheduleRsrv, UMIS_VER2.BusinessLyer.ScScheduleRsrvKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScScheduleRsrvKey key)
		{
			return Delete(transactionManager, key.ScScheduleDtlRsrvId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_scScheduleDtlRsrvId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _scScheduleDtlRsrvId)
		{
			return Delete(null, _scScheduleDtlRsrvId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleDtlRsrvId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _scScheduleDtlRsrvId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_RSRV_AS_CODE_DEGREE key.
		///		FK_SC_SCHEDULE_RSRV_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="_asCodeDegreeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleRsrv objects.</returns>
		public TList<ScScheduleRsrv> GetByAsCodeDegreeId(System.Decimal? _asCodeDegreeId)
		{
			int count = -1;
			return GetByAsCodeDegreeId(_asCodeDegreeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_RSRV_AS_CODE_DEGREE key.
		///		FK_SC_SCHEDULE_RSRV_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleRsrv objects.</returns>
		/// <remarks></remarks>
		public TList<ScScheduleRsrv> GetByAsCodeDegreeId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeId)
		{
			int count = -1;
			return GetByAsCodeDegreeId(transactionManager, _asCodeDegreeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_RSRV_AS_CODE_DEGREE key.
		///		FK_SC_SCHEDULE_RSRV_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleRsrv objects.</returns>
		public TList<ScScheduleRsrv> GetByAsCodeDegreeId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsCodeDegreeId(transactionManager, _asCodeDegreeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_RSRV_AS_CODE_DEGREE key.
		///		fkScScheduleRsrvAsCodeDegree Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleRsrv objects.</returns>
		public TList<ScScheduleRsrv> GetByAsCodeDegreeId(System.Decimal? _asCodeDegreeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsCodeDegreeId(null, _asCodeDegreeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_RSRV_AS_CODE_DEGREE key.
		///		fkScScheduleRsrvAsCodeDegree Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleRsrv objects.</returns>
		public TList<ScScheduleRsrv> GetByAsCodeDegreeId(System.Decimal? _asCodeDegreeId, int start, int pageLength,out int count)
		{
			return GetByAsCodeDegreeId(null, _asCodeDegreeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_RSRV_AS_CODE_DEGREE key.
		///		FK_SC_SCHEDULE_RSRV_AS_CODE_DEGREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleRsrv objects.</returns>
		public abstract TList<ScScheduleRsrv> GetByAsCodeDegreeId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_RSRV_AS_FACULTY_INFO key.
		///		FK_SC_SCHEDULE_RSRV_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleRsrv objects.</returns>
		public TList<ScScheduleRsrv> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(_asFacultyInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_RSRV_AS_FACULTY_INFO key.
		///		FK_SC_SCHEDULE_RSRV_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleRsrv objects.</returns>
		/// <remarks></remarks>
		public TList<ScScheduleRsrv> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_RSRV_AS_FACULTY_INFO key.
		///		FK_SC_SCHEDULE_RSRV_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleRsrv objects.</returns>
		public TList<ScScheduleRsrv> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_RSRV_AS_FACULTY_INFO key.
		///		fkScScheduleRsrvAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleRsrv objects.</returns>
		public TList<ScScheduleRsrv> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_RSRV_AS_FACULTY_INFO key.
		///		fkScScheduleRsrvAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleRsrv objects.</returns>
		public TList<ScScheduleRsrv> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength,out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_RSRV_AS_FACULTY_INFO key.
		///		FK_SC_SCHEDULE_RSRV_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleRsrv objects.</returns>
		public abstract TList<ScScheduleRsrv> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_RSRV_ENTITY_MAIN key.
		///		FK_SC_SCHEDULE_RSRV_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="_entMainId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleRsrv objects.</returns>
		public TList<ScScheduleRsrv> GetByEntMainId(System.Decimal? _entMainId)
		{
			int count = -1;
			return GetByEntMainId(_entMainId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_RSRV_ENTITY_MAIN key.
		///		FK_SC_SCHEDULE_RSRV_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleRsrv objects.</returns>
		/// <remarks></remarks>
		public TList<ScScheduleRsrv> GetByEntMainId(TransactionManager transactionManager, System.Decimal? _entMainId)
		{
			int count = -1;
			return GetByEntMainId(transactionManager, _entMainId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_RSRV_ENTITY_MAIN key.
		///		FK_SC_SCHEDULE_RSRV_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleRsrv objects.</returns>
		public TList<ScScheduleRsrv> GetByEntMainId(TransactionManager transactionManager, System.Decimal? _entMainId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMainId(transactionManager, _entMainId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_RSRV_ENTITY_MAIN key.
		///		fkScScheduleRsrvEntityMain Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleRsrv objects.</returns>
		public TList<ScScheduleRsrv> GetByEntMainId(System.Decimal? _entMainId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEntMainId(null, _entMainId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_RSRV_ENTITY_MAIN key.
		///		fkScScheduleRsrvEntityMain Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleRsrv objects.</returns>
		public TList<ScScheduleRsrv> GetByEntMainId(System.Decimal? _entMainId, int start, int pageLength,out int count)
		{
			return GetByEntMainId(null, _entMainId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_RSRV_ENTITY_MAIN key.
		///		FK_SC_SCHEDULE_RSRV_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleRsrv objects.</returns>
		public abstract TList<ScScheduleRsrv> GetByEntMainId(TransactionManager transactionManager, System.Decimal? _entMainId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_RSRV_SC_GROUP_INFO key.
		///		FK_SC_SCHEDULE_RSRV_SC_GROUP_INFO Description: 
		/// </summary>
		/// <param name="_scGroupInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleRsrv objects.</returns>
		public TList<ScScheduleRsrv> GetByScGroupInfoId(System.Decimal? _scGroupInfoId)
		{
			int count = -1;
			return GetByScGroupInfoId(_scGroupInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_RSRV_SC_GROUP_INFO key.
		///		FK_SC_SCHEDULE_RSRV_SC_GROUP_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scGroupInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleRsrv objects.</returns>
		/// <remarks></remarks>
		public TList<ScScheduleRsrv> GetByScGroupInfoId(TransactionManager transactionManager, System.Decimal? _scGroupInfoId)
		{
			int count = -1;
			return GetByScGroupInfoId(transactionManager, _scGroupInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_RSRV_SC_GROUP_INFO key.
		///		FK_SC_SCHEDULE_RSRV_SC_GROUP_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scGroupInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleRsrv objects.</returns>
		public TList<ScScheduleRsrv> GetByScGroupInfoId(TransactionManager transactionManager, System.Decimal? _scGroupInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByScGroupInfoId(transactionManager, _scGroupInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_RSRV_SC_GROUP_INFO key.
		///		fkScScheduleRsrvScGroupInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scGroupInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleRsrv objects.</returns>
		public TList<ScScheduleRsrv> GetByScGroupInfoId(System.Decimal? _scGroupInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByScGroupInfoId(null, _scGroupInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_RSRV_SC_GROUP_INFO key.
		///		fkScScheduleRsrvScGroupInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scGroupInfoId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleRsrv objects.</returns>
		public TList<ScScheduleRsrv> GetByScGroupInfoId(System.Decimal? _scGroupInfoId, int start, int pageLength,out int count)
		{
			return GetByScGroupInfoId(null, _scGroupInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_RSRV_SC_GROUP_INFO key.
		///		FK_SC_SCHEDULE_RSRV_SC_GROUP_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scGroupInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleRsrv objects.</returns>
		public abstract TList<ScScheduleRsrv> GetByScGroupInfoId(TransactionManager transactionManager, System.Decimal? _scGroupInfoId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_RSRV_SC_SCHEDULE_DTL key.
		///		FK_SC_SCHEDULE_RSRV_SC_SCHEDULE_DTL Description: 
		/// </summary>
		/// <param name="_scScheduleDtlId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleRsrv objects.</returns>
		public TList<ScScheduleRsrv> GetByScScheduleDtlId(System.Decimal _scScheduleDtlId)
		{
			int count = -1;
			return GetByScScheduleDtlId(_scScheduleDtlId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_RSRV_SC_SCHEDULE_DTL key.
		///		FK_SC_SCHEDULE_RSRV_SC_SCHEDULE_DTL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleDtlId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleRsrv objects.</returns>
		/// <remarks></remarks>
		public TList<ScScheduleRsrv> GetByScScheduleDtlId(TransactionManager transactionManager, System.Decimal _scScheduleDtlId)
		{
			int count = -1;
			return GetByScScheduleDtlId(transactionManager, _scScheduleDtlId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_RSRV_SC_SCHEDULE_DTL key.
		///		FK_SC_SCHEDULE_RSRV_SC_SCHEDULE_DTL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleRsrv objects.</returns>
		public TList<ScScheduleRsrv> GetByScScheduleDtlId(TransactionManager transactionManager, System.Decimal _scScheduleDtlId, int start, int pageLength)
		{
			int count = -1;
			return GetByScScheduleDtlId(transactionManager, _scScheduleDtlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_RSRV_SC_SCHEDULE_DTL key.
		///		fkScScheduleRsrvScScheduleDtl Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scScheduleDtlId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleRsrv objects.</returns>
		public TList<ScScheduleRsrv> GetByScScheduleDtlId(System.Decimal _scScheduleDtlId, int start, int pageLength)
		{
			int count =  -1;
			return GetByScScheduleDtlId(null, _scScheduleDtlId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_RSRV_SC_SCHEDULE_DTL key.
		///		fkScScheduleRsrvScScheduleDtl Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scScheduleDtlId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleRsrv objects.</returns>
		public TList<ScScheduleRsrv> GetByScScheduleDtlId(System.Decimal _scScheduleDtlId, int start, int pageLength,out int count)
		{
			return GetByScScheduleDtlId(null, _scScheduleDtlId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_RSRV_SC_SCHEDULE_DTL key.
		///		FK_SC_SCHEDULE_RSRV_SC_SCHEDULE_DTL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleRsrv objects.</returns>
		public abstract TList<ScScheduleRsrv> GetByScScheduleDtlId(TransactionManager transactionManager, System.Decimal _scScheduleDtlId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.ScScheduleRsrv Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScScheduleRsrvKey key, int start, int pageLength)
		{
			return GetByScScheduleDtlRsrvId(transactionManager, key.ScScheduleDtlRsrvId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SC_SCHEDULE_RSRV index.
		/// </summary>
		/// <param name="_scScheduleDtlRsrvId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleRsrv"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScScheduleRsrv GetByScScheduleDtlRsrvId(System.Decimal _scScheduleDtlRsrvId)
		{
			int count = -1;
			return GetByScScheduleDtlRsrvId(null,_scScheduleDtlRsrvId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_SCHEDULE_RSRV index.
		/// </summary>
		/// <param name="_scScheduleDtlRsrvId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleRsrv"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScScheduleRsrv GetByScScheduleDtlRsrvId(System.Decimal _scScheduleDtlRsrvId, int start, int pageLength)
		{
			int count = -1;
			return GetByScScheduleDtlRsrvId(null, _scScheduleDtlRsrvId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_SCHEDULE_RSRV index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleDtlRsrvId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleRsrv"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScScheduleRsrv GetByScScheduleDtlRsrvId(TransactionManager transactionManager, System.Decimal _scScheduleDtlRsrvId)
		{
			int count = -1;
			return GetByScScheduleDtlRsrvId(transactionManager, _scScheduleDtlRsrvId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_SCHEDULE_RSRV index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleDtlRsrvId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleRsrv"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScScheduleRsrv GetByScScheduleDtlRsrvId(TransactionManager transactionManager, System.Decimal _scScheduleDtlRsrvId, int start, int pageLength)
		{
			int count = -1;
			return GetByScScheduleDtlRsrvId(transactionManager, _scScheduleDtlRsrvId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_SCHEDULE_RSRV index.
		/// </summary>
		/// <param name="_scScheduleDtlRsrvId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleRsrv"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScScheduleRsrv GetByScScheduleDtlRsrvId(System.Decimal _scScheduleDtlRsrvId, int start, int pageLength, out int count)
		{
			return GetByScScheduleDtlRsrvId(null, _scScheduleDtlRsrvId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_SCHEDULE_RSRV index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleDtlRsrvId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleRsrv"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.ScScheduleRsrv GetByScScheduleDtlRsrvId(TransactionManager transactionManager, System.Decimal _scScheduleDtlRsrvId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;ScScheduleRsrv&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;ScScheduleRsrv&gt;"/></returns>
		public static TList<ScScheduleRsrv> Fill(IDataReader reader, TList<ScScheduleRsrv> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.ScScheduleRsrv c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("ScScheduleRsrv")
					.Append("|").Append((System.Decimal)reader["SC_SCHEDULE_DTL_RSRV_ID"]).ToString();
					c = EntityManager.LocateOrCreate<ScScheduleRsrv>(
					key.ToString(), // EntityTrackingKey
					"ScScheduleRsrv",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.ScScheduleRsrv();
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
					c.ScScheduleDtlRsrvId = (System.Decimal)reader["SC_SCHEDULE_DTL_RSRV_ID"];
					c.OriginalScScheduleDtlRsrvId = c.ScScheduleDtlRsrvId;
					c.ScScheduleDtlId = (System.Decimal)reader["SC_SCHEDULE_DTL_ID"];
					c.AsFacultyInfoId = Convert.IsDBNull(reader["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)reader["AS_FACULTY_INFO_ID"];
					c.AsCodeDegreeId = Convert.IsDBNull(reader["AS_CODE_DEGREE_ID"]) ? null : (System.Decimal?)reader["AS_CODE_DEGREE_ID"];
					c.EntMainId = Convert.IsDBNull(reader["ENT_MAIN_ID"]) ? null : (System.Decimal?)reader["ENT_MAIN_ID"];
					c.ExpFlg = (System.Decimal)reader["EXP_FLG"];
					c.ScGroupInfoId = Convert.IsDBNull(reader["SC_GROUP_INFO_ID"]) ? null : (System.Decimal?)reader["SC_GROUP_INFO_ID"];
					c.StudCodeFrom = Convert.IsDBNull(reader["STUD_CODE_FROM"]) ? null : (System.String)reader["STUD_CODE_FROM"];
					c.StudCodeTo = Convert.IsDBNull(reader["STUD_CODE_TO"]) ? null : (System.String)reader["STUD_CODE_TO"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.ScScheduleRsrv"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScScheduleRsrv"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.ScScheduleRsrv entity)
		{
			if (!reader.Read()) return;
			
			entity.ScScheduleDtlRsrvId = (System.Decimal)reader[((int)ScScheduleRsrvColumn.ScScheduleDtlRsrvId - 1)];
			entity.OriginalScScheduleDtlRsrvId = (System.Decimal)reader["SC_SCHEDULE_DTL_RSRV_ID"];
			entity.ScScheduleDtlId = (System.Decimal)reader[((int)ScScheduleRsrvColumn.ScScheduleDtlId - 1)];
			entity.AsFacultyInfoId = (reader.IsDBNull(((int)ScScheduleRsrvColumn.AsFacultyInfoId - 1)))?null:(System.Decimal?)reader[((int)ScScheduleRsrvColumn.AsFacultyInfoId - 1)];
			entity.AsCodeDegreeId = (reader.IsDBNull(((int)ScScheduleRsrvColumn.AsCodeDegreeId - 1)))?null:(System.Decimal?)reader[((int)ScScheduleRsrvColumn.AsCodeDegreeId - 1)];
			entity.EntMainId = (reader.IsDBNull(((int)ScScheduleRsrvColumn.EntMainId - 1)))?null:(System.Decimal?)reader[((int)ScScheduleRsrvColumn.EntMainId - 1)];
			entity.ExpFlg = (System.Decimal)reader[((int)ScScheduleRsrvColumn.ExpFlg - 1)];
			entity.ScGroupInfoId = (reader.IsDBNull(((int)ScScheduleRsrvColumn.ScGroupInfoId - 1)))?null:(System.Decimal?)reader[((int)ScScheduleRsrvColumn.ScGroupInfoId - 1)];
			entity.StudCodeFrom = (reader.IsDBNull(((int)ScScheduleRsrvColumn.StudCodeFrom - 1)))?null:(System.String)reader[((int)ScScheduleRsrvColumn.StudCodeFrom - 1)];
			entity.StudCodeTo = (reader.IsDBNull(((int)ScScheduleRsrvColumn.StudCodeTo - 1)))?null:(System.String)reader[((int)ScScheduleRsrvColumn.StudCodeTo - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.ScScheduleRsrv"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScScheduleRsrv"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.ScScheduleRsrv entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.ScScheduleDtlRsrvId = (System.Decimal)dataRow["SC_SCHEDULE_DTL_RSRV_ID"];
			entity.OriginalScScheduleDtlRsrvId = (System.Decimal)dataRow["SC_SCHEDULE_DTL_RSRV_ID"];
			entity.ScScheduleDtlId = (System.Decimal)dataRow["SC_SCHEDULE_DTL_ID"];
			entity.AsFacultyInfoId = Convert.IsDBNull(dataRow["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)dataRow["AS_FACULTY_INFO_ID"];
			entity.AsCodeDegreeId = Convert.IsDBNull(dataRow["AS_CODE_DEGREE_ID"]) ? null : (System.Decimal?)dataRow["AS_CODE_DEGREE_ID"];
			entity.EntMainId = Convert.IsDBNull(dataRow["ENT_MAIN_ID"]) ? null : (System.Decimal?)dataRow["ENT_MAIN_ID"];
			entity.ExpFlg = (System.Decimal)dataRow["EXP_FLG"];
			entity.ScGroupInfoId = Convert.IsDBNull(dataRow["SC_GROUP_INFO_ID"]) ? null : (System.Decimal?)dataRow["SC_GROUP_INFO_ID"];
			entity.StudCodeFrom = Convert.IsDBNull(dataRow["STUD_CODE_FROM"]) ? null : (System.String)dataRow["STUD_CODE_FROM"];
			entity.StudCodeTo = Convert.IsDBNull(dataRow["STUD_CODE_TO"]) ? null : (System.String)dataRow["STUD_CODE_TO"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScScheduleRsrv"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.ScScheduleRsrv Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScScheduleRsrv entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

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

			#region EntMainIdSource	
			if (CanDeepLoad(entity, "EntityMain|EntMainIdSource", deepLoadType, innerList) 
				&& entity.EntMainIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EntMainId ?? 0.0m);
				EntityMain tmpEntity = EntityManager.LocateEntity<EntityMain>(EntityLocator.ConstructKeyFromPkItems(typeof(EntityMain), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EntMainIdSource = tmpEntity;
				else
					entity.EntMainIdSource = DataRepository.EntityMainProvider.GetByEntMainId(transactionManager, (entity.EntMainId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntMainIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EntMainIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EntityMainProvider.DeepLoad(transactionManager, entity.EntMainIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EntMainIdSource

			#region ScGroupInfoIdSource	
			if (CanDeepLoad(entity, "ScGroupInfo|ScGroupInfoIdSource", deepLoadType, innerList) 
				&& entity.ScGroupInfoIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.ScGroupInfoId ?? 0.0m);
				ScGroupInfo tmpEntity = EntityManager.LocateEntity<ScGroupInfo>(EntityLocator.ConstructKeyFromPkItems(typeof(ScGroupInfo), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.ScGroupInfoIdSource = tmpEntity;
				else
					entity.ScGroupInfoIdSource = DataRepository.ScGroupInfoProvider.GetByScGroupInfoId(transactionManager, (entity.ScGroupInfoId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScGroupInfoIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.ScGroupInfoIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.ScGroupInfoProvider.DeepLoad(transactionManager, entity.ScGroupInfoIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion ScGroupInfoIdSource

			#region ScScheduleDtlIdSource	
			if (CanDeepLoad(entity, "ScScheduleDtl|ScScheduleDtlIdSource", deepLoadType, innerList) 
				&& entity.ScScheduleDtlIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.ScScheduleDtlId;
				ScScheduleDtl tmpEntity = EntityManager.LocateEntity<ScScheduleDtl>(EntityLocator.ConstructKeyFromPkItems(typeof(ScScheduleDtl), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.ScScheduleDtlIdSource = tmpEntity;
				else
					entity.ScScheduleDtlIdSource = DataRepository.ScScheduleDtlProvider.GetByScScheduleDtlId(transactionManager, entity.ScScheduleDtlId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScScheduleDtlIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.ScScheduleDtlIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.ScScheduleDtlProvider.DeepLoad(transactionManager, entity.ScScheduleDtlIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion ScScheduleDtlIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.ScScheduleRsrv object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.ScScheduleRsrv instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.ScScheduleRsrv Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScScheduleRsrv entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AsCodeDegreeIdSource
			if (CanDeepSave(entity, "AsCodeDegree|AsCodeDegreeIdSource", deepSaveType, innerList) 
				&& entity.AsCodeDegreeIdSource != null)
			{
				DataRepository.AsCodeDegreeProvider.Save(transactionManager, entity.AsCodeDegreeIdSource);
				entity.AsCodeDegreeId = entity.AsCodeDegreeIdSource.AsCodeDegreeId;
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
			
			#region EntMainIdSource
			if (CanDeepSave(entity, "EntityMain|EntMainIdSource", deepSaveType, innerList) 
				&& entity.EntMainIdSource != null)
			{
				DataRepository.EntityMainProvider.Save(transactionManager, entity.EntMainIdSource);
				entity.EntMainId = entity.EntMainIdSource.EntMainId;
			}
			#endregion 
			
			#region ScGroupInfoIdSource
			if (CanDeepSave(entity, "ScGroupInfo|ScGroupInfoIdSource", deepSaveType, innerList) 
				&& entity.ScGroupInfoIdSource != null)
			{
				DataRepository.ScGroupInfoProvider.Save(transactionManager, entity.ScGroupInfoIdSource);
				entity.ScGroupInfoId = entity.ScGroupInfoIdSource.ScGroupInfoId;
			}
			#endregion 
			
			#region ScScheduleDtlIdSource
			if (CanDeepSave(entity, "ScScheduleDtl|ScScheduleDtlIdSource", deepSaveType, innerList) 
				&& entity.ScScheduleDtlIdSource != null)
			{
				DataRepository.ScScheduleDtlProvider.Save(transactionManager, entity.ScScheduleDtlIdSource);
				entity.ScScheduleDtlId = entity.ScScheduleDtlIdSource.ScScheduleDtlId;
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
	
	#region ScScheduleRsrvChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.ScScheduleRsrv</c>
	///</summary>
	public enum ScScheduleRsrvChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AsCodeDegree</c> at AsCodeDegreeIdSource
		///</summary>
		[ChildEntityType(typeof(AsCodeDegree))]
		AsCodeDegree,
		
		///<summary>
		/// Composite Property for <c>AsFacultyInfo</c> at AsFacultyInfoIdSource
		///</summary>
		[ChildEntityType(typeof(AsFacultyInfo))]
		AsFacultyInfo,
		
		///<summary>
		/// Composite Property for <c>EntityMain</c> at EntMainIdSource
		///</summary>
		[ChildEntityType(typeof(EntityMain))]
		EntityMain,
		
		///<summary>
		/// Composite Property for <c>ScGroupInfo</c> at ScGroupInfoIdSource
		///</summary>
		[ChildEntityType(typeof(ScGroupInfo))]
		ScGroupInfo,
		
		///<summary>
		/// Composite Property for <c>ScScheduleDtl</c> at ScScheduleDtlIdSource
		///</summary>
		[ChildEntityType(typeof(ScScheduleDtl))]
		ScScheduleDtl,
	}
	
	#endregion ScScheduleRsrvChildEntityTypes
	
	#region ScScheduleRsrvFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;ScScheduleRsrvColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScScheduleRsrv"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ScScheduleRsrvFilterBuilder : SqlFilterBuilder<ScScheduleRsrvColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScScheduleRsrvFilterBuilder class.
		/// </summary>
		public ScScheduleRsrvFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ScScheduleRsrvFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ScScheduleRsrvFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ScScheduleRsrvFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ScScheduleRsrvFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ScScheduleRsrvFilterBuilder
	
	#region ScScheduleRsrvParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;ScScheduleRsrvColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScScheduleRsrv"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ScScheduleRsrvParameterBuilder : ParameterizedSqlFilterBuilder<ScScheduleRsrvColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScScheduleRsrvParameterBuilder class.
		/// </summary>
		public ScScheduleRsrvParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ScScheduleRsrvParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ScScheduleRsrvParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ScScheduleRsrvParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ScScheduleRsrvParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ScScheduleRsrvParameterBuilder
	
	#region ScScheduleRsrvSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;ScScheduleRsrvColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScScheduleRsrv"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ScScheduleRsrvSortBuilder : SqlSortBuilder<ScScheduleRsrvColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScScheduleRsrvSqlSortBuilder class.
		/// </summary>
		public ScScheduleRsrvSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ScScheduleRsrvSortBuilder
	
} // end namespace
