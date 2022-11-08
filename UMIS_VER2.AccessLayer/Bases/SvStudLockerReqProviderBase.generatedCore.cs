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
	/// This class is the base class for any <see cref="SvStudLockerReqProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SvStudLockerReqProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SvStudLockerReq, UMIS_VER2.BusinessLyer.SvStudLockerReqKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvStudLockerReqKey key)
		{
			return Delete(transactionManager, key.SvStudLockerReqId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_svStudLockerReqId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _svStudLockerReqId)
		{
			return Delete(null, _svStudLockerReqId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svStudLockerReqId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _svStudLockerReqId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_LOCKER_REQ_ED_STUD key.
		///		FK_SV_STUD_LOCKER_REQ_ED_STUD Description: 
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudLockerReq objects.</returns>
		public TList<SvStudLockerReq> GetByEdStudId(System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(_edStudId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_LOCKER_REQ_ED_STUD key.
		///		FK_SV_STUD_LOCKER_REQ_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudLockerReq objects.</returns>
		/// <remarks></remarks>
		public TList<SvStudLockerReq> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_LOCKER_REQ_ED_STUD key.
		///		FK_SV_STUD_LOCKER_REQ_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudLockerReq objects.</returns>
		public TList<SvStudLockerReq> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_LOCKER_REQ_ED_STUD key.
		///		fkSvStudLockerReqEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudLockerReq objects.</returns>
		public TList<SvStudLockerReq> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudId(null, _edStudId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_LOCKER_REQ_ED_STUD key.
		///		fkSvStudLockerReqEdStud Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudLockerReq objects.</returns>
		public TList<SvStudLockerReq> GetByEdStudId(System.Decimal _edStudId, int start, int pageLength,out int count)
		{
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_LOCKER_REQ_ED_STUD key.
		///		FK_SV_STUD_LOCKER_REQ_ED_STUD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudLockerReq objects.</returns>
		public abstract TList<SvStudLockerReq> GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_LOCKER_REQ_SC_BUILDING key.
		///		FK_SV_STUD_LOCKER_REQ_SC_BUILDING Description: 
		/// </summary>
		/// <param name="_scBuildingId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudLockerReq objects.</returns>
		public TList<SvStudLockerReq> GetByScBuildingId(System.Decimal? _scBuildingId)
		{
			int count = -1;
			return GetByScBuildingId(_scBuildingId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_LOCKER_REQ_SC_BUILDING key.
		///		FK_SV_STUD_LOCKER_REQ_SC_BUILDING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scBuildingId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudLockerReq objects.</returns>
		/// <remarks></remarks>
		public TList<SvStudLockerReq> GetByScBuildingId(TransactionManager transactionManager, System.Decimal? _scBuildingId)
		{
			int count = -1;
			return GetByScBuildingId(transactionManager, _scBuildingId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_LOCKER_REQ_SC_BUILDING key.
		///		FK_SV_STUD_LOCKER_REQ_SC_BUILDING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scBuildingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudLockerReq objects.</returns>
		public TList<SvStudLockerReq> GetByScBuildingId(TransactionManager transactionManager, System.Decimal? _scBuildingId, int start, int pageLength)
		{
			int count = -1;
			return GetByScBuildingId(transactionManager, _scBuildingId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_LOCKER_REQ_SC_BUILDING key.
		///		fkSvStudLockerReqScBuilding Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scBuildingId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudLockerReq objects.</returns>
		public TList<SvStudLockerReq> GetByScBuildingId(System.Decimal? _scBuildingId, int start, int pageLength)
		{
			int count =  -1;
			return GetByScBuildingId(null, _scBuildingId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_LOCKER_REQ_SC_BUILDING key.
		///		fkSvStudLockerReqScBuilding Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scBuildingId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudLockerReq objects.</returns>
		public TList<SvStudLockerReq> GetByScBuildingId(System.Decimal? _scBuildingId, int start, int pageLength,out int count)
		{
			return GetByScBuildingId(null, _scBuildingId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_LOCKER_REQ_SC_BUILDING key.
		///		FK_SV_STUD_LOCKER_REQ_SC_BUILDING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scBuildingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudLockerReq objects.</returns>
		public abstract TList<SvStudLockerReq> GetByScBuildingId(TransactionManager transactionManager, System.Decimal? _scBuildingId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_LOCKER_REQ_SE_USER key.
		///		FK_SV_STUD_LOCKER_REQ_SE_USER Description: 
		/// </summary>
		/// <param name="_seUserId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudLockerReq objects.</returns>
		public TList<SvStudLockerReq> GetBySeUserId(System.Decimal? _seUserId)
		{
			int count = -1;
			return GetBySeUserId(_seUserId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_LOCKER_REQ_SE_USER key.
		///		FK_SV_STUD_LOCKER_REQ_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudLockerReq objects.</returns>
		/// <remarks></remarks>
		public TList<SvStudLockerReq> GetBySeUserId(TransactionManager transactionManager, System.Decimal? _seUserId)
		{
			int count = -1;
			return GetBySeUserId(transactionManager, _seUserId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_LOCKER_REQ_SE_USER key.
		///		FK_SV_STUD_LOCKER_REQ_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudLockerReq objects.</returns>
		public TList<SvStudLockerReq> GetBySeUserId(TransactionManager transactionManager, System.Decimal? _seUserId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeUserId(transactionManager, _seUserId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_LOCKER_REQ_SE_USER key.
		///		fkSvStudLockerReqSeUser Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudLockerReq objects.</returns>
		public TList<SvStudLockerReq> GetBySeUserId(System.Decimal? _seUserId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySeUserId(null, _seUserId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_LOCKER_REQ_SE_USER key.
		///		fkSvStudLockerReqSeUser Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seUserId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudLockerReq objects.</returns>
		public TList<SvStudLockerReq> GetBySeUserId(System.Decimal? _seUserId, int start, int pageLength,out int count)
		{
			return GetBySeUserId(null, _seUserId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_LOCKER_REQ_SE_USER key.
		///		FK_SV_STUD_LOCKER_REQ_SE_USER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seUserId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudLockerReq objects.</returns>
		public abstract TList<SvStudLockerReq> GetBySeUserId(TransactionManager transactionManager, System.Decimal? _seUserId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_LOCKER_REQ_SV_CDE_LOCKER key.
		///		FK_SV_STUD_LOCKER_REQ_SV_CDE_LOCKER Description: 
		/// </summary>
		/// <param name="_svCdeLockerId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudLockerReq objects.</returns>
		public TList<SvStudLockerReq> GetBySvCdeLockerId(System.Decimal? _svCdeLockerId)
		{
			int count = -1;
			return GetBySvCdeLockerId(_svCdeLockerId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_LOCKER_REQ_SV_CDE_LOCKER key.
		///		FK_SV_STUD_LOCKER_REQ_SV_CDE_LOCKER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeLockerId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudLockerReq objects.</returns>
		/// <remarks></remarks>
		public TList<SvStudLockerReq> GetBySvCdeLockerId(TransactionManager transactionManager, System.Decimal? _svCdeLockerId)
		{
			int count = -1;
			return GetBySvCdeLockerId(transactionManager, _svCdeLockerId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_LOCKER_REQ_SV_CDE_LOCKER key.
		///		FK_SV_STUD_LOCKER_REQ_SV_CDE_LOCKER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeLockerId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudLockerReq objects.</returns>
		public TList<SvStudLockerReq> GetBySvCdeLockerId(TransactionManager transactionManager, System.Decimal? _svCdeLockerId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvCdeLockerId(transactionManager, _svCdeLockerId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_LOCKER_REQ_SV_CDE_LOCKER key.
		///		fkSvStudLockerReqSvCdeLocker Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_svCdeLockerId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudLockerReq objects.</returns>
		public TList<SvStudLockerReq> GetBySvCdeLockerId(System.Decimal? _svCdeLockerId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySvCdeLockerId(null, _svCdeLockerId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_LOCKER_REQ_SV_CDE_LOCKER key.
		///		fkSvStudLockerReqSvCdeLocker Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_svCdeLockerId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudLockerReq objects.</returns>
		public TList<SvStudLockerReq> GetBySvCdeLockerId(System.Decimal? _svCdeLockerId, int start, int pageLength,out int count)
		{
			return GetBySvCdeLockerId(null, _svCdeLockerId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STUD_LOCKER_REQ_SV_CDE_LOCKER key.
		///		FK_SV_STUD_LOCKER_REQ_SV_CDE_LOCKER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeLockerId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStudLockerReq objects.</returns>
		public abstract TList<SvStudLockerReq> GetBySvCdeLockerId(TransactionManager transactionManager, System.Decimal? _svCdeLockerId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SvStudLockerReq Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvStudLockerReqKey key, int start, int pageLength)
		{
			return GetBySvStudLockerReqId(transactionManager, key.SvStudLockerReqId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SV_STUD_LOCKER_REQ index.
		/// </summary>
		/// <param name="_svStudLockerReqId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvStudLockerReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvStudLockerReq GetBySvStudLockerReqId(System.Decimal _svStudLockerReqId)
		{
			int count = -1;
			return GetBySvStudLockerReqId(null,_svStudLockerReqId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_STUD_LOCKER_REQ index.
		/// </summary>
		/// <param name="_svStudLockerReqId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvStudLockerReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvStudLockerReq GetBySvStudLockerReqId(System.Decimal _svStudLockerReqId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvStudLockerReqId(null, _svStudLockerReqId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_STUD_LOCKER_REQ index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svStudLockerReqId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvStudLockerReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvStudLockerReq GetBySvStudLockerReqId(TransactionManager transactionManager, System.Decimal _svStudLockerReqId)
		{
			int count = -1;
			return GetBySvStudLockerReqId(transactionManager, _svStudLockerReqId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_STUD_LOCKER_REQ index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svStudLockerReqId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvStudLockerReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvStudLockerReq GetBySvStudLockerReqId(TransactionManager transactionManager, System.Decimal _svStudLockerReqId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvStudLockerReqId(transactionManager, _svStudLockerReqId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_STUD_LOCKER_REQ index.
		/// </summary>
		/// <param name="_svStudLockerReqId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvStudLockerReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvStudLockerReq GetBySvStudLockerReqId(System.Decimal _svStudLockerReqId, int start, int pageLength, out int count)
		{
			return GetBySvStudLockerReqId(null, _svStudLockerReqId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_STUD_LOCKER_REQ index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svStudLockerReqId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvStudLockerReq"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SvStudLockerReq GetBySvStudLockerReqId(TransactionManager transactionManager, System.Decimal _svStudLockerReqId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_SV_STUD_LOCKER_REQ index.
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <param name="_svCdeLockerId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvStudLockerReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvStudLockerReq GetByEdStudIdSvCdeLockerId(System.Decimal _edStudId, System.Decimal? _svCdeLockerId)
		{
			int count = -1;
			return GetByEdStudIdSvCdeLockerId(null,_edStudId, _svCdeLockerId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_STUD_LOCKER_REQ index.
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <param name="_svCdeLockerId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvStudLockerReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvStudLockerReq GetByEdStudIdSvCdeLockerId(System.Decimal _edStudId, System.Decimal? _svCdeLockerId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudIdSvCdeLockerId(null, _edStudId, _svCdeLockerId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_STUD_LOCKER_REQ index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="_svCdeLockerId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvStudLockerReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvStudLockerReq GetByEdStudIdSvCdeLockerId(TransactionManager transactionManager, System.Decimal _edStudId, System.Decimal? _svCdeLockerId)
		{
			int count = -1;
			return GetByEdStudIdSvCdeLockerId(transactionManager, _edStudId, _svCdeLockerId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_STUD_LOCKER_REQ index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="_svCdeLockerId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvStudLockerReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvStudLockerReq GetByEdStudIdSvCdeLockerId(TransactionManager transactionManager, System.Decimal _edStudId, System.Decimal? _svCdeLockerId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudIdSvCdeLockerId(transactionManager, _edStudId, _svCdeLockerId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_STUD_LOCKER_REQ index.
		/// </summary>
		/// <param name="_edStudId"></param>
		/// <param name="_svCdeLockerId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvStudLockerReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvStudLockerReq GetByEdStudIdSvCdeLockerId(System.Decimal _edStudId, System.Decimal? _svCdeLockerId, int start, int pageLength, out int count)
		{
			return GetByEdStudIdSvCdeLockerId(null, _edStudId, _svCdeLockerId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_STUD_LOCKER_REQ index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId"></param>
		/// <param name="_svCdeLockerId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvStudLockerReq"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SvStudLockerReq GetByEdStudIdSvCdeLockerId(TransactionManager transactionManager, System.Decimal _edStudId, System.Decimal? _svCdeLockerId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SvStudLockerReq&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SvStudLockerReq&gt;"/></returns>
		public static TList<SvStudLockerReq> Fill(IDataReader reader, TList<SvStudLockerReq> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SvStudLockerReq c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SvStudLockerReq")
					.Append("|").Append((System.Decimal)reader["SV_STUD_LOCKER_REQ_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SvStudLockerReq>(
					key.ToString(), // EntityTrackingKey
					"SvStudLockerReq",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SvStudLockerReq();
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
					c.SvStudLockerReqId = (System.Decimal)reader["SV_STUD_LOCKER_REQ_ID"];
					c.OriginalSvStudLockerReqId = c.SvStudLockerReqId;
					c.SvCdeLockerId = Convert.IsDBNull(reader["SV_CDE_LOCKER_ID"]) ? null : (System.Decimal?)reader["SV_CDE_LOCKER_ID"];
					c.EdStudId = (System.Decimal)reader["ED_STUD_ID"];
					c.ReqDate = (System.DateTime)reader["REQ_DATE"];
					c.KeyNo = Convert.IsDBNull(reader["KEY_NO"]) ? null : (System.String)reader["KEY_NO"];
					c.RecptNo = Convert.IsDBNull(reader["RECPT_NO"]) ? null : (System.String)reader["RECPT_NO"];
					c.ReturnDate = Convert.IsDBNull(reader["RETURN_DATE"]) ? null : (System.DateTime?)reader["RETURN_DATE"];
					c.ReturnReason = Convert.IsDBNull(reader["RETURN_REASON"]) ? null : (System.String)reader["RETURN_REASON"];
					c.SeUserId = Convert.IsDBNull(reader["SE_USER_ID"]) ? null : (System.Decimal?)reader["SE_USER_ID"];
					c.ScBuildingId = Convert.IsDBNull(reader["SC_BUILDING_ID"]) ? null : (System.Decimal?)reader["SC_BUILDING_ID"];
					c.CloseFlg = Convert.IsDBNull(reader["CLOSE_FLG"]) ? null : (System.Decimal?)reader["CLOSE_FLG"];
					c.EmployeeName = Convert.IsDBNull(reader["EMPLOYEE_NAME"]) ? null : (System.String)reader["EMPLOYEE_NAME"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SvStudLockerReq"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvStudLockerReq"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SvStudLockerReq entity)
		{
			if (!reader.Read()) return;
			
			entity.SvStudLockerReqId = (System.Decimal)reader[((int)SvStudLockerReqColumn.SvStudLockerReqId - 1)];
			entity.OriginalSvStudLockerReqId = (System.Decimal)reader["SV_STUD_LOCKER_REQ_ID"];
			entity.SvCdeLockerId = (reader.IsDBNull(((int)SvStudLockerReqColumn.SvCdeLockerId - 1)))?null:(System.Decimal?)reader[((int)SvStudLockerReqColumn.SvCdeLockerId - 1)];
			entity.EdStudId = (System.Decimal)reader[((int)SvStudLockerReqColumn.EdStudId - 1)];
			entity.ReqDate = (System.DateTime)reader[((int)SvStudLockerReqColumn.ReqDate - 1)];
			entity.KeyNo = (reader.IsDBNull(((int)SvStudLockerReqColumn.KeyNo - 1)))?null:(System.String)reader[((int)SvStudLockerReqColumn.KeyNo - 1)];
			entity.RecptNo = (reader.IsDBNull(((int)SvStudLockerReqColumn.RecptNo - 1)))?null:(System.String)reader[((int)SvStudLockerReqColumn.RecptNo - 1)];
			entity.ReturnDate = (reader.IsDBNull(((int)SvStudLockerReqColumn.ReturnDate - 1)))?null:(System.DateTime?)reader[((int)SvStudLockerReqColumn.ReturnDate - 1)];
			entity.ReturnReason = (reader.IsDBNull(((int)SvStudLockerReqColumn.ReturnReason - 1)))?null:(System.String)reader[((int)SvStudLockerReqColumn.ReturnReason - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)SvStudLockerReqColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)SvStudLockerReqColumn.SeUserId - 1)];
			entity.ScBuildingId = (reader.IsDBNull(((int)SvStudLockerReqColumn.ScBuildingId - 1)))?null:(System.Decimal?)reader[((int)SvStudLockerReqColumn.ScBuildingId - 1)];
			entity.CloseFlg = (reader.IsDBNull(((int)SvStudLockerReqColumn.CloseFlg - 1)))?null:(System.Decimal?)reader[((int)SvStudLockerReqColumn.CloseFlg - 1)];
			entity.EmployeeName = (reader.IsDBNull(((int)SvStudLockerReqColumn.EmployeeName - 1)))?null:(System.String)reader[((int)SvStudLockerReqColumn.EmployeeName - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SvStudLockerReq"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvStudLockerReq"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SvStudLockerReq entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SvStudLockerReqId = (System.Decimal)dataRow["SV_STUD_LOCKER_REQ_ID"];
			entity.OriginalSvStudLockerReqId = (System.Decimal)dataRow["SV_STUD_LOCKER_REQ_ID"];
			entity.SvCdeLockerId = Convert.IsDBNull(dataRow["SV_CDE_LOCKER_ID"]) ? null : (System.Decimal?)dataRow["SV_CDE_LOCKER_ID"];
			entity.EdStudId = (System.Decimal)dataRow["ED_STUD_ID"];
			entity.ReqDate = (System.DateTime)dataRow["REQ_DATE"];
			entity.KeyNo = Convert.IsDBNull(dataRow["KEY_NO"]) ? null : (System.String)dataRow["KEY_NO"];
			entity.RecptNo = Convert.IsDBNull(dataRow["RECPT_NO"]) ? null : (System.String)dataRow["RECPT_NO"];
			entity.ReturnDate = Convert.IsDBNull(dataRow["RETURN_DATE"]) ? null : (System.DateTime?)dataRow["RETURN_DATE"];
			entity.ReturnReason = Convert.IsDBNull(dataRow["RETURN_REASON"]) ? null : (System.String)dataRow["RETURN_REASON"];
			entity.SeUserId = Convert.IsDBNull(dataRow["SE_USER_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_ID"];
			entity.ScBuildingId = Convert.IsDBNull(dataRow["SC_BUILDING_ID"]) ? null : (System.Decimal?)dataRow["SC_BUILDING_ID"];
			entity.CloseFlg = Convert.IsDBNull(dataRow["CLOSE_FLG"]) ? null : (System.Decimal?)dataRow["CLOSE_FLG"];
			entity.EmployeeName = Convert.IsDBNull(dataRow["EMPLOYEE_NAME"]) ? null : (System.String)dataRow["EMPLOYEE_NAME"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvStudLockerReq"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SvStudLockerReq Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvStudLockerReq entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdStudIdSource	
			if (CanDeepLoad(entity, "EdStud|EdStudIdSource", deepLoadType, innerList) 
				&& entity.EdStudIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdStudId;
				EdStud tmpEntity = EntityManager.LocateEntity<EdStud>(EntityLocator.ConstructKeyFromPkItems(typeof(EdStud), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdStudIdSource = tmpEntity;
				else
					entity.EdStudIdSource = DataRepository.EdStudProvider.GetByEdStudId(transactionManager, entity.EdStudId);		
				
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

			#region ScBuildingIdSource	
			if (CanDeepLoad(entity, "ScBuilding|ScBuildingIdSource", deepLoadType, innerList) 
				&& entity.ScBuildingIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.ScBuildingId ?? 0.0m);
				ScBuilding tmpEntity = EntityManager.LocateEntity<ScBuilding>(EntityLocator.ConstructKeyFromPkItems(typeof(ScBuilding), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.ScBuildingIdSource = tmpEntity;
				else
					entity.ScBuildingIdSource = DataRepository.ScBuildingProvider.GetByScBuildingId(transactionManager, (entity.ScBuildingId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScBuildingIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.ScBuildingIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.ScBuildingProvider.DeepLoad(transactionManager, entity.ScBuildingIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion ScBuildingIdSource

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

			#region SvCdeLockerIdSource	
			if (CanDeepLoad(entity, "SvCdeLocker|SvCdeLockerIdSource", deepLoadType, innerList) 
				&& entity.SvCdeLockerIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SvCdeLockerId ?? 0.0m);
				SvCdeLocker tmpEntity = EntityManager.LocateEntity<SvCdeLocker>(EntityLocator.ConstructKeyFromPkItems(typeof(SvCdeLocker), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SvCdeLockerIdSource = tmpEntity;
				else
					entity.SvCdeLockerIdSource = DataRepository.SvCdeLockerProvider.GetBySvCdeLockerId(transactionManager, (entity.SvCdeLockerId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvCdeLockerIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SvCdeLockerIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SvCdeLockerProvider.DeepLoad(transactionManager, entity.SvCdeLockerIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SvCdeLockerIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SvStudLockerReq object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SvStudLockerReq instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SvStudLockerReq Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvStudLockerReq entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdStudIdSource
			if (CanDeepSave(entity, "EdStud|EdStudIdSource", deepSaveType, innerList) 
				&& entity.EdStudIdSource != null)
			{
				DataRepository.EdStudProvider.Save(transactionManager, entity.EdStudIdSource);
				entity.EdStudId = entity.EdStudIdSource.EdStudId;
			}
			#endregion 
			
			#region ScBuildingIdSource
			if (CanDeepSave(entity, "ScBuilding|ScBuildingIdSource", deepSaveType, innerList) 
				&& entity.ScBuildingIdSource != null)
			{
				DataRepository.ScBuildingProvider.Save(transactionManager, entity.ScBuildingIdSource);
				entity.ScBuildingId = entity.ScBuildingIdSource.ScBuildingId;
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
			
			#region SvCdeLockerIdSource
			if (CanDeepSave(entity, "SvCdeLocker|SvCdeLockerIdSource", deepSaveType, innerList) 
				&& entity.SvCdeLockerIdSource != null)
			{
				DataRepository.SvCdeLockerProvider.Save(transactionManager, entity.SvCdeLockerIdSource);
				entity.SvCdeLockerId = entity.SvCdeLockerIdSource.SvCdeLockerId;
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
	
	#region SvStudLockerReqChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SvStudLockerReq</c>
	///</summary>
	public enum SvStudLockerReqChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdStud</c> at EdStudIdSource
		///</summary>
		[ChildEntityType(typeof(EdStud))]
		EdStud,
		
		///<summary>
		/// Composite Property for <c>ScBuilding</c> at ScBuildingIdSource
		///</summary>
		[ChildEntityType(typeof(ScBuilding))]
		ScBuilding,
		
		///<summary>
		/// Composite Property for <c>SeUser</c> at SeUserIdSource
		///</summary>
		[ChildEntityType(typeof(SeUser))]
		SeUser,
		
		///<summary>
		/// Composite Property for <c>SvCdeLocker</c> at SvCdeLockerIdSource
		///</summary>
		[ChildEntityType(typeof(SvCdeLocker))]
		SvCdeLocker,
	}
	
	#endregion SvStudLockerReqChildEntityTypes
	
	#region SvStudLockerReqFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SvStudLockerReqColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvStudLockerReq"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SvStudLockerReqFilterBuilder : SqlFilterBuilder<SvStudLockerReqColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvStudLockerReqFilterBuilder class.
		/// </summary>
		public SvStudLockerReqFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SvStudLockerReqFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SvStudLockerReqFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SvStudLockerReqFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SvStudLockerReqFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SvStudLockerReqFilterBuilder
	
	#region SvStudLockerReqParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SvStudLockerReqColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvStudLockerReq"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SvStudLockerReqParameterBuilder : ParameterizedSqlFilterBuilder<SvStudLockerReqColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvStudLockerReqParameterBuilder class.
		/// </summary>
		public SvStudLockerReqParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SvStudLockerReqParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SvStudLockerReqParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SvStudLockerReqParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SvStudLockerReqParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SvStudLockerReqParameterBuilder
	
	#region SvStudLockerReqSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SvStudLockerReqColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvStudLockerReq"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SvStudLockerReqSortBuilder : SqlSortBuilder<SvStudLockerReqColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvStudLockerReqSqlSortBuilder class.
		/// </summary>
		public SvStudLockerReqSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SvStudLockerReqSortBuilder
	
} // end namespace
