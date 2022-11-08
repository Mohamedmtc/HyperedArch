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
	/// This class is the base class for any <see cref="ScScheduleDtlExtStfProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class ScScheduleDtlExtStfProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.ScScheduleDtlExtStf, UMIS_VER2.BusinessLyer.ScScheduleDtlExtStfKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScScheduleDtlExtStfKey key)
		{
			return Delete(transactionManager, key.ScSchDtlExtStfId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_scSchDtlExtStfId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _scSchDtlExtStfId)
		{
			return Delete(null, _scSchDtlExtStfId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scSchDtlExtStfId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _scSchDtlExtStfId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_EXT_STF_ED_CODE_COURSE_TEACHING key.
		///		FK_SC_SCHEDULE_DTL_EXT_STF_ED_CODE_COURSE_TEACHING Description: 
		/// </summary>
		/// <param name="_edCodeCourseTeachingId">XXXX</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtlExtStf objects.</returns>
		public TList<ScScheduleDtlExtStf> GetByEdCodeCourseTeachingId(System.Decimal? _edCodeCourseTeachingId)
		{
			int count = -1;
			return GetByEdCodeCourseTeachingId(_edCodeCourseTeachingId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_EXT_STF_ED_CODE_COURSE_TEACHING key.
		///		FK_SC_SCHEDULE_DTL_EXT_STF_ED_CODE_COURSE_TEACHING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseTeachingId">XXXX</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtlExtStf objects.</returns>
		/// <remarks></remarks>
		public TList<ScScheduleDtlExtStf> GetByEdCodeCourseTeachingId(TransactionManager transactionManager, System.Decimal? _edCodeCourseTeachingId)
		{
			int count = -1;
			return GetByEdCodeCourseTeachingId(transactionManager, _edCodeCourseTeachingId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_EXT_STF_ED_CODE_COURSE_TEACHING key.
		///		FK_SC_SCHEDULE_DTL_EXT_STF_ED_CODE_COURSE_TEACHING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseTeachingId">XXXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtlExtStf objects.</returns>
		public TList<ScScheduleDtlExtStf> GetByEdCodeCourseTeachingId(TransactionManager transactionManager, System.Decimal? _edCodeCourseTeachingId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeCourseTeachingId(transactionManager, _edCodeCourseTeachingId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_EXT_STF_ED_CODE_COURSE_TEACHING key.
		///		fkScScheduleDtlExtStfEdCodeCourseTeaching Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeCourseTeachingId">XXXX</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtlExtStf objects.</returns>
		public TList<ScScheduleDtlExtStf> GetByEdCodeCourseTeachingId(System.Decimal? _edCodeCourseTeachingId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeCourseTeachingId(null, _edCodeCourseTeachingId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_EXT_STF_ED_CODE_COURSE_TEACHING key.
		///		fkScScheduleDtlExtStfEdCodeCourseTeaching Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeCourseTeachingId">XXXX</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtlExtStf objects.</returns>
		public TList<ScScheduleDtlExtStf> GetByEdCodeCourseTeachingId(System.Decimal? _edCodeCourseTeachingId, int start, int pageLength,out int count)
		{
			return GetByEdCodeCourseTeachingId(null, _edCodeCourseTeachingId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_EXT_STF_ED_CODE_COURSE_TEACHING key.
		///		FK_SC_SCHEDULE_DTL_EXT_STF_ED_CODE_COURSE_TEACHING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseTeachingId">XXXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtlExtStf objects.</returns>
		public abstract TList<ScScheduleDtlExtStf> GetByEdCodeCourseTeachingId(TransactionManager transactionManager, System.Decimal? _edCodeCourseTeachingId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_EXT_STF_SA_STF_MEMBER key.
		///		FK_SC_SCHEDULE_DTL_EXT_STF_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="_saStfMamberId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtlExtStf objects.</returns>
		public TList<ScScheduleDtlExtStf> GetBySaStfMamberId(System.Decimal _saStfMamberId)
		{
			int count = -1;
			return GetBySaStfMamberId(_saStfMamberId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_EXT_STF_SA_STF_MEMBER key.
		///		FK_SC_SCHEDULE_DTL_EXT_STF_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMamberId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtlExtStf objects.</returns>
		/// <remarks></remarks>
		public TList<ScScheduleDtlExtStf> GetBySaStfMamberId(TransactionManager transactionManager, System.Decimal _saStfMamberId)
		{
			int count = -1;
			return GetBySaStfMamberId(transactionManager, _saStfMamberId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_EXT_STF_SA_STF_MEMBER key.
		///		FK_SC_SCHEDULE_DTL_EXT_STF_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMamberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtlExtStf objects.</returns>
		public TList<ScScheduleDtlExtStf> GetBySaStfMamberId(TransactionManager transactionManager, System.Decimal _saStfMamberId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaStfMamberId(transactionManager, _saStfMamberId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_EXT_STF_SA_STF_MEMBER key.
		///		fkScScheduleDtlExtStfSaStfMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMamberId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtlExtStf objects.</returns>
		public TList<ScScheduleDtlExtStf> GetBySaStfMamberId(System.Decimal _saStfMamberId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaStfMamberId(null, _saStfMamberId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_EXT_STF_SA_STF_MEMBER key.
		///		fkScScheduleDtlExtStfSaStfMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMamberId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtlExtStf objects.</returns>
		public TList<ScScheduleDtlExtStf> GetBySaStfMamberId(System.Decimal _saStfMamberId, int start, int pageLength,out int count)
		{
			return GetBySaStfMamberId(null, _saStfMamberId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_EXT_STF_SA_STF_MEMBER key.
		///		FK_SC_SCHEDULE_DTL_EXT_STF_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMamberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtlExtStf objects.</returns>
		public abstract TList<ScScheduleDtlExtStf> GetBySaStfMamberId(TransactionManager transactionManager, System.Decimal _saStfMamberId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_EXT_STF_SC_SCHEDULE_DTL key.
		///		FK_SC_SCHEDULE_DTL_EXT_STF_SC_SCHEDULE_DTL Description: 
		/// </summary>
		/// <param name="_scScheduleDtlId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtlExtStf objects.</returns>
		public TList<ScScheduleDtlExtStf> GetByScScheduleDtlId(System.Decimal _scScheduleDtlId)
		{
			int count = -1;
			return GetByScScheduleDtlId(_scScheduleDtlId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_EXT_STF_SC_SCHEDULE_DTL key.
		///		FK_SC_SCHEDULE_DTL_EXT_STF_SC_SCHEDULE_DTL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleDtlId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtlExtStf objects.</returns>
		/// <remarks></remarks>
		public TList<ScScheduleDtlExtStf> GetByScScheduleDtlId(TransactionManager transactionManager, System.Decimal _scScheduleDtlId)
		{
			int count = -1;
			return GetByScScheduleDtlId(transactionManager, _scScheduleDtlId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_EXT_STF_SC_SCHEDULE_DTL key.
		///		FK_SC_SCHEDULE_DTL_EXT_STF_SC_SCHEDULE_DTL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtlExtStf objects.</returns>
		public TList<ScScheduleDtlExtStf> GetByScScheduleDtlId(TransactionManager transactionManager, System.Decimal _scScheduleDtlId, int start, int pageLength)
		{
			int count = -1;
			return GetByScScheduleDtlId(transactionManager, _scScheduleDtlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_EXT_STF_SC_SCHEDULE_DTL key.
		///		fkScScheduleDtlExtStfScScheduleDtl Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scScheduleDtlId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtlExtStf objects.</returns>
		public TList<ScScheduleDtlExtStf> GetByScScheduleDtlId(System.Decimal _scScheduleDtlId, int start, int pageLength)
		{
			int count =  -1;
			return GetByScScheduleDtlId(null, _scScheduleDtlId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_EXT_STF_SC_SCHEDULE_DTL key.
		///		fkScScheduleDtlExtStfScScheduleDtl Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scScheduleDtlId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtlExtStf objects.</returns>
		public TList<ScScheduleDtlExtStf> GetByScScheduleDtlId(System.Decimal _scScheduleDtlId, int start, int pageLength,out int count)
		{
			return GetByScScheduleDtlId(null, _scScheduleDtlId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_EXT_STF_SC_SCHEDULE_DTL key.
		///		FK_SC_SCHEDULE_DTL_EXT_STF_SC_SCHEDULE_DTL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtlExtStf objects.</returns>
		public abstract TList<ScScheduleDtlExtStf> GetByScScheduleDtlId(TransactionManager transactionManager, System.Decimal _scScheduleDtlId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.ScScheduleDtlExtStf Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScScheduleDtlExtStfKey key, int start, int pageLength)
		{
			return GetByScSchDtlExtStfId(transactionManager, key.ScSchDtlExtStfId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SC_SCHEDULE_DTL_EXT_STF index.
		/// </summary>
		/// <param name="_scSchDtlExtStfId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtlExtStf"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScScheduleDtlExtStf GetByScSchDtlExtStfId(System.Decimal _scSchDtlExtStfId)
		{
			int count = -1;
			return GetByScSchDtlExtStfId(null,_scSchDtlExtStfId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_SCHEDULE_DTL_EXT_STF index.
		/// </summary>
		/// <param name="_scSchDtlExtStfId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtlExtStf"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScScheduleDtlExtStf GetByScSchDtlExtStfId(System.Decimal _scSchDtlExtStfId, int start, int pageLength)
		{
			int count = -1;
			return GetByScSchDtlExtStfId(null, _scSchDtlExtStfId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_SCHEDULE_DTL_EXT_STF index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scSchDtlExtStfId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtlExtStf"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScScheduleDtlExtStf GetByScSchDtlExtStfId(TransactionManager transactionManager, System.Decimal _scSchDtlExtStfId)
		{
			int count = -1;
			return GetByScSchDtlExtStfId(transactionManager, _scSchDtlExtStfId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_SCHEDULE_DTL_EXT_STF index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scSchDtlExtStfId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtlExtStf"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScScheduleDtlExtStf GetByScSchDtlExtStfId(TransactionManager transactionManager, System.Decimal _scSchDtlExtStfId, int start, int pageLength)
		{
			int count = -1;
			return GetByScSchDtlExtStfId(transactionManager, _scSchDtlExtStfId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_SCHEDULE_DTL_EXT_STF index.
		/// </summary>
		/// <param name="_scSchDtlExtStfId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtlExtStf"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScScheduleDtlExtStf GetByScSchDtlExtStfId(System.Decimal _scSchDtlExtStfId, int start, int pageLength, out int count)
		{
			return GetByScSchDtlExtStfId(null, _scSchDtlExtStfId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_SCHEDULE_DTL_EXT_STF index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scSchDtlExtStfId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtlExtStf"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.ScScheduleDtlExtStf GetByScSchDtlExtStfId(TransactionManager transactionManager, System.Decimal _scSchDtlExtStfId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_SC_SCHEDULE_DTL_EXT_STF index.
		/// </summary>
		/// <param name="_scScheduleDtlId"></param>
		/// <param name="_saStfMamberId"></param>
		/// <param name="_edCodeCourseTeachingId">XXXX</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtlExtStf"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScScheduleDtlExtStf GetByScScheduleDtlIdSaStfMamberIdEdCodeCourseTeachingId(System.Decimal _scScheduleDtlId, System.Decimal _saStfMamberId, System.Decimal? _edCodeCourseTeachingId)
		{
			int count = -1;
			return GetByScScheduleDtlIdSaStfMamberIdEdCodeCourseTeachingId(null,_scScheduleDtlId, _saStfMamberId, _edCodeCourseTeachingId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SC_SCHEDULE_DTL_EXT_STF index.
		/// </summary>
		/// <param name="_scScheduleDtlId"></param>
		/// <param name="_saStfMamberId"></param>
		/// <param name="_edCodeCourseTeachingId">XXXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtlExtStf"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScScheduleDtlExtStf GetByScScheduleDtlIdSaStfMamberIdEdCodeCourseTeachingId(System.Decimal _scScheduleDtlId, System.Decimal _saStfMamberId, System.Decimal? _edCodeCourseTeachingId, int start, int pageLength)
		{
			int count = -1;
			return GetByScScheduleDtlIdSaStfMamberIdEdCodeCourseTeachingId(null, _scScheduleDtlId, _saStfMamberId, _edCodeCourseTeachingId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SC_SCHEDULE_DTL_EXT_STF index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleDtlId"></param>
		/// <param name="_saStfMamberId"></param>
		/// <param name="_edCodeCourseTeachingId">XXXX</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtlExtStf"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScScheduleDtlExtStf GetByScScheduleDtlIdSaStfMamberIdEdCodeCourseTeachingId(TransactionManager transactionManager, System.Decimal _scScheduleDtlId, System.Decimal _saStfMamberId, System.Decimal? _edCodeCourseTeachingId)
		{
			int count = -1;
			return GetByScScheduleDtlIdSaStfMamberIdEdCodeCourseTeachingId(transactionManager, _scScheduleDtlId, _saStfMamberId, _edCodeCourseTeachingId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SC_SCHEDULE_DTL_EXT_STF index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleDtlId"></param>
		/// <param name="_saStfMamberId"></param>
		/// <param name="_edCodeCourseTeachingId">XXXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtlExtStf"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScScheduleDtlExtStf GetByScScheduleDtlIdSaStfMamberIdEdCodeCourseTeachingId(TransactionManager transactionManager, System.Decimal _scScheduleDtlId, System.Decimal _saStfMamberId, System.Decimal? _edCodeCourseTeachingId, int start, int pageLength)
		{
			int count = -1;
			return GetByScScheduleDtlIdSaStfMamberIdEdCodeCourseTeachingId(transactionManager, _scScheduleDtlId, _saStfMamberId, _edCodeCourseTeachingId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SC_SCHEDULE_DTL_EXT_STF index.
		/// </summary>
		/// <param name="_scScheduleDtlId"></param>
		/// <param name="_saStfMamberId"></param>
		/// <param name="_edCodeCourseTeachingId">XXXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtlExtStf"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScScheduleDtlExtStf GetByScScheduleDtlIdSaStfMamberIdEdCodeCourseTeachingId(System.Decimal _scScheduleDtlId, System.Decimal _saStfMamberId, System.Decimal? _edCodeCourseTeachingId, int start, int pageLength, out int count)
		{
			return GetByScScheduleDtlIdSaStfMamberIdEdCodeCourseTeachingId(null, _scScheduleDtlId, _saStfMamberId, _edCodeCourseTeachingId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SC_SCHEDULE_DTL_EXT_STF index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleDtlId"></param>
		/// <param name="_saStfMamberId"></param>
		/// <param name="_edCodeCourseTeachingId">XXXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtlExtStf"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.ScScheduleDtlExtStf GetByScScheduleDtlIdSaStfMamberIdEdCodeCourseTeachingId(TransactionManager transactionManager, System.Decimal _scScheduleDtlId, System.Decimal _saStfMamberId, System.Decimal? _edCodeCourseTeachingId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;ScScheduleDtlExtStf&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;ScScheduleDtlExtStf&gt;"/></returns>
		public static TList<ScScheduleDtlExtStf> Fill(IDataReader reader, TList<ScScheduleDtlExtStf> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.ScScheduleDtlExtStf c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("ScScheduleDtlExtStf")
					.Append("|").Append((System.Decimal)reader["SC_SCH_DTL_EXT_STF_ID"]).ToString();
					c = EntityManager.LocateOrCreate<ScScheduleDtlExtStf>(
					key.ToString(), // EntityTrackingKey
					"ScScheduleDtlExtStf",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.ScScheduleDtlExtStf();
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
					c.ScSchDtlExtStfId = (System.Decimal)reader["SC_SCH_DTL_EXT_STF_ID"];
					c.OriginalScSchDtlExtStfId = c.ScSchDtlExtStfId;
					c.ScScheduleDtlId = (System.Decimal)reader["SC_SCHEDULE_DTL_ID"];
					c.SaStfMamberId = (System.Decimal)reader["SA_STF_MAMBER_ID"];
					c.StfRoleFlg = Convert.IsDBNull(reader["STF_ROLE_FLG"]) ? null : (System.Decimal?)reader["STF_ROLE_FLG"];
					c.NoHours = Convert.IsDBNull(reader["NO_HOURS"]) ? null : (System.Decimal?)reader["NO_HOURS"];
					c.EdCodeCourseTeachingId = Convert.IsDBNull(reader["ED_CODE_COURSE_TEACHING_ID"]) ? null : (System.Decimal?)reader["ED_CODE_COURSE_TEACHING_ID"];
					c.ExtLoadFlg = Convert.IsDBNull(reader["EXT_LOAD_FLG"]) ? null : (System.Decimal?)reader["EXT_LOAD_FLG"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtlExtStf"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtlExtStf"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.ScScheduleDtlExtStf entity)
		{
			if (!reader.Read()) return;
			
			entity.ScSchDtlExtStfId = (System.Decimal)reader[((int)ScScheduleDtlExtStfColumn.ScSchDtlExtStfId - 1)];
			entity.OriginalScSchDtlExtStfId = (System.Decimal)reader["SC_SCH_DTL_EXT_STF_ID"];
			entity.ScScheduleDtlId = (System.Decimal)reader[((int)ScScheduleDtlExtStfColumn.ScScheduleDtlId - 1)];
			entity.SaStfMamberId = (System.Decimal)reader[((int)ScScheduleDtlExtStfColumn.SaStfMamberId - 1)];
			entity.StfRoleFlg = (reader.IsDBNull(((int)ScScheduleDtlExtStfColumn.StfRoleFlg - 1)))?null:(System.Decimal?)reader[((int)ScScheduleDtlExtStfColumn.StfRoleFlg - 1)];
			entity.NoHours = (reader.IsDBNull(((int)ScScheduleDtlExtStfColumn.NoHours - 1)))?null:(System.Decimal?)reader[((int)ScScheduleDtlExtStfColumn.NoHours - 1)];
			entity.EdCodeCourseTeachingId = (reader.IsDBNull(((int)ScScheduleDtlExtStfColumn.EdCodeCourseTeachingId - 1)))?null:(System.Decimal?)reader[((int)ScScheduleDtlExtStfColumn.EdCodeCourseTeachingId - 1)];
			entity.ExtLoadFlg = (reader.IsDBNull(((int)ScScheduleDtlExtStfColumn.ExtLoadFlg - 1)))?null:(System.Decimal?)reader[((int)ScScheduleDtlExtStfColumn.ExtLoadFlg - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)ScScheduleDtlExtStfColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)ScScheduleDtlExtStfColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)ScScheduleDtlExtStfColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)ScScheduleDtlExtStfColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtlExtStf"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtlExtStf"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.ScScheduleDtlExtStf entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.ScSchDtlExtStfId = (System.Decimal)dataRow["SC_SCH_DTL_EXT_STF_ID"];
			entity.OriginalScSchDtlExtStfId = (System.Decimal)dataRow["SC_SCH_DTL_EXT_STF_ID"];
			entity.ScScheduleDtlId = (System.Decimal)dataRow["SC_SCHEDULE_DTL_ID"];
			entity.SaStfMamberId = (System.Decimal)dataRow["SA_STF_MAMBER_ID"];
			entity.StfRoleFlg = Convert.IsDBNull(dataRow["STF_ROLE_FLG"]) ? null : (System.Decimal?)dataRow["STF_ROLE_FLG"];
			entity.NoHours = Convert.IsDBNull(dataRow["NO_HOURS"]) ? null : (System.Decimal?)dataRow["NO_HOURS"];
			entity.EdCodeCourseTeachingId = Convert.IsDBNull(dataRow["ED_CODE_COURSE_TEACHING_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_COURSE_TEACHING_ID"];
			entity.ExtLoadFlg = Convert.IsDBNull(dataRow["EXT_LOAD_FLG"]) ? null : (System.Decimal?)dataRow["EXT_LOAD_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtlExtStf"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.ScScheduleDtlExtStf Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScScheduleDtlExtStf entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdCodeCourseTeachingIdSource	
			if (CanDeepLoad(entity, "EdCodeCourseTeaching|EdCodeCourseTeachingIdSource", deepLoadType, innerList) 
				&& entity.EdCodeCourseTeachingIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCodeCourseTeachingId ?? 0.0m);
				EdCodeCourseTeaching tmpEntity = EntityManager.LocateEntity<EdCodeCourseTeaching>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeCourseTeaching), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeCourseTeachingIdSource = tmpEntity;
				else
					entity.EdCodeCourseTeachingIdSource = DataRepository.EdCodeCourseTeachingProvider.GetByEdCodeCourseTeachingId(transactionManager, (entity.EdCodeCourseTeachingId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeCourseTeachingIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeCourseTeachingIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeCourseTeachingProvider.DeepLoad(transactionManager, entity.EdCodeCourseTeachingIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeCourseTeachingIdSource

			#region SaStfMamberIdSource	
			if (CanDeepLoad(entity, "SaStfMember|SaStfMamberIdSource", deepLoadType, innerList) 
				&& entity.SaStfMamberIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SaStfMamberId;
				SaStfMember tmpEntity = EntityManager.LocateEntity<SaStfMember>(EntityLocator.ConstructKeyFromPkItems(typeof(SaStfMember), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaStfMamberIdSource = tmpEntity;
				else
					entity.SaStfMamberIdSource = DataRepository.SaStfMemberProvider.GetBySaStfMemberId(transactionManager, entity.SaStfMamberId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaStfMamberIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaStfMamberIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaStfMemberProvider.DeepLoad(transactionManager, entity.SaStfMamberIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaStfMamberIdSource

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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.ScScheduleDtlExtStf object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.ScScheduleDtlExtStf instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.ScScheduleDtlExtStf Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScScheduleDtlExtStf entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdCodeCourseTeachingIdSource
			if (CanDeepSave(entity, "EdCodeCourseTeaching|EdCodeCourseTeachingIdSource", deepSaveType, innerList) 
				&& entity.EdCodeCourseTeachingIdSource != null)
			{
				DataRepository.EdCodeCourseTeachingProvider.Save(transactionManager, entity.EdCodeCourseTeachingIdSource);
				entity.EdCodeCourseTeachingId = entity.EdCodeCourseTeachingIdSource.EdCodeCourseTeachingId;
			}
			#endregion 
			
			#region SaStfMamberIdSource
			if (CanDeepSave(entity, "SaStfMember|SaStfMamberIdSource", deepSaveType, innerList) 
				&& entity.SaStfMamberIdSource != null)
			{
				DataRepository.SaStfMemberProvider.Save(transactionManager, entity.SaStfMamberIdSource);
				entity.SaStfMamberId = entity.SaStfMamberIdSource.SaStfMemberId;
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
	
	#region ScScheduleDtlExtStfChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.ScScheduleDtlExtStf</c>
	///</summary>
	public enum ScScheduleDtlExtStfChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdCodeCourseTeaching</c> at EdCodeCourseTeachingIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeCourseTeaching))]
		EdCodeCourseTeaching,
		
		///<summary>
		/// Composite Property for <c>SaStfMember</c> at SaStfMamberIdSource
		///</summary>
		[ChildEntityType(typeof(SaStfMember))]
		SaStfMember,
		
		///<summary>
		/// Composite Property for <c>ScScheduleDtl</c> at ScScheduleDtlIdSource
		///</summary>
		[ChildEntityType(typeof(ScScheduleDtl))]
		ScScheduleDtl,
	}
	
	#endregion ScScheduleDtlExtStfChildEntityTypes
	
	#region ScScheduleDtlExtStfFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;ScScheduleDtlExtStfColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScScheduleDtlExtStf"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ScScheduleDtlExtStfFilterBuilder : SqlFilterBuilder<ScScheduleDtlExtStfColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScScheduleDtlExtStfFilterBuilder class.
		/// </summary>
		public ScScheduleDtlExtStfFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ScScheduleDtlExtStfFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ScScheduleDtlExtStfFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ScScheduleDtlExtStfFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ScScheduleDtlExtStfFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ScScheduleDtlExtStfFilterBuilder
	
	#region ScScheduleDtlExtStfParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;ScScheduleDtlExtStfColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScScheduleDtlExtStf"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ScScheduleDtlExtStfParameterBuilder : ParameterizedSqlFilterBuilder<ScScheduleDtlExtStfColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScScheduleDtlExtStfParameterBuilder class.
		/// </summary>
		public ScScheduleDtlExtStfParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ScScheduleDtlExtStfParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ScScheduleDtlExtStfParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ScScheduleDtlExtStfParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ScScheduleDtlExtStfParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ScScheduleDtlExtStfParameterBuilder
	
	#region ScScheduleDtlExtStfSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;ScScheduleDtlExtStfColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScScheduleDtlExtStf"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ScScheduleDtlExtStfSortBuilder : SqlSortBuilder<ScScheduleDtlExtStfColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScScheduleDtlExtStfSqlSortBuilder class.
		/// </summary>
		public ScScheduleDtlExtStfSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ScScheduleDtlExtStfSortBuilder
	
} // end namespace
