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
	/// This class is the base class for any <see cref="ScScheduleDtlDayProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class ScScheduleDtlDayProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.ScScheduleDtlDay, UMIS_VER2.BusinessLyer.ScScheduleDtlDayKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScScheduleDtlDayKey key)
		{
			return Delete(transactionManager, key.ScScheduleDtlDayId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_scScheduleDtlDayId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _scScheduleDtlDayId)
		{
			return Delete(null, _scScheduleDtlDayId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleDtlDayId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _scScheduleDtlDayId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_DAY_ED_CODE_COURSE_TEACHING key.
		///		FK_SC_SCHEDULE_DTL_DAY_ED_CODE_COURSE_TEACHING Description: 
		/// </summary>
		/// <param name="_edCodeCourseTeachingId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtlDay objects.</returns>
		public TList<ScScheduleDtlDay> GetByEdCodeCourseTeachingId(System.Decimal? _edCodeCourseTeachingId)
		{
			int count = -1;
			return GetByEdCodeCourseTeachingId(_edCodeCourseTeachingId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_DAY_ED_CODE_COURSE_TEACHING key.
		///		FK_SC_SCHEDULE_DTL_DAY_ED_CODE_COURSE_TEACHING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseTeachingId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtlDay objects.</returns>
		/// <remarks></remarks>
		public TList<ScScheduleDtlDay> GetByEdCodeCourseTeachingId(TransactionManager transactionManager, System.Decimal? _edCodeCourseTeachingId)
		{
			int count = -1;
			return GetByEdCodeCourseTeachingId(transactionManager, _edCodeCourseTeachingId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_DAY_ED_CODE_COURSE_TEACHING key.
		///		FK_SC_SCHEDULE_DTL_DAY_ED_CODE_COURSE_TEACHING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseTeachingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtlDay objects.</returns>
		public TList<ScScheduleDtlDay> GetByEdCodeCourseTeachingId(TransactionManager transactionManager, System.Decimal? _edCodeCourseTeachingId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeCourseTeachingId(transactionManager, _edCodeCourseTeachingId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_DAY_ED_CODE_COURSE_TEACHING key.
		///		fkScScheduleDtlDayEdCodeCourseTeaching Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeCourseTeachingId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtlDay objects.</returns>
		public TList<ScScheduleDtlDay> GetByEdCodeCourseTeachingId(System.Decimal? _edCodeCourseTeachingId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeCourseTeachingId(null, _edCodeCourseTeachingId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_DAY_ED_CODE_COURSE_TEACHING key.
		///		fkScScheduleDtlDayEdCodeCourseTeaching Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeCourseTeachingId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtlDay objects.</returns>
		public TList<ScScheduleDtlDay> GetByEdCodeCourseTeachingId(System.Decimal? _edCodeCourseTeachingId, int start, int pageLength,out int count)
		{
			return GetByEdCodeCourseTeachingId(null, _edCodeCourseTeachingId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_DAY_ED_CODE_COURSE_TEACHING key.
		///		FK_SC_SCHEDULE_DTL_DAY_ED_CODE_COURSE_TEACHING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseTeachingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtlDay objects.</returns>
		public abstract TList<ScScheduleDtlDay> GetByEdCodeCourseTeachingId(TransactionManager transactionManager, System.Decimal? _edCodeCourseTeachingId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_DAY_GS_CODE_WEEK_DAY key.
		///		FK_SC_SCHEDULE_DTL_DAY_GS_CODE_WEEK_DAY Description: 
		/// </summary>
		/// <param name="_gsCodeWeekDayId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtlDay objects.</returns>
		public TList<ScScheduleDtlDay> GetByGsCodeWeekDayId(System.Decimal? _gsCodeWeekDayId)
		{
			int count = -1;
			return GetByGsCodeWeekDayId(_gsCodeWeekDayId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_DAY_GS_CODE_WEEK_DAY key.
		///		FK_SC_SCHEDULE_DTL_DAY_GS_CODE_WEEK_DAY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeWeekDayId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtlDay objects.</returns>
		/// <remarks></remarks>
		public TList<ScScheduleDtlDay> GetByGsCodeWeekDayId(TransactionManager transactionManager, System.Decimal? _gsCodeWeekDayId)
		{
			int count = -1;
			return GetByGsCodeWeekDayId(transactionManager, _gsCodeWeekDayId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_DAY_GS_CODE_WEEK_DAY key.
		///		FK_SC_SCHEDULE_DTL_DAY_GS_CODE_WEEK_DAY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeWeekDayId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtlDay objects.</returns>
		public TList<ScScheduleDtlDay> GetByGsCodeWeekDayId(TransactionManager transactionManager, System.Decimal? _gsCodeWeekDayId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeWeekDayId(transactionManager, _gsCodeWeekDayId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_DAY_GS_CODE_WEEK_DAY key.
		///		fkScScheduleDtlDayGsCodeWeekDay Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeWeekDayId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtlDay objects.</returns>
		public TList<ScScheduleDtlDay> GetByGsCodeWeekDayId(System.Decimal? _gsCodeWeekDayId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodeWeekDayId(null, _gsCodeWeekDayId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_DAY_GS_CODE_WEEK_DAY key.
		///		fkScScheduleDtlDayGsCodeWeekDay Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeWeekDayId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtlDay objects.</returns>
		public TList<ScScheduleDtlDay> GetByGsCodeWeekDayId(System.Decimal? _gsCodeWeekDayId, int start, int pageLength,out int count)
		{
			return GetByGsCodeWeekDayId(null, _gsCodeWeekDayId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_DAY_GS_CODE_WEEK_DAY key.
		///		FK_SC_SCHEDULE_DTL_DAY_GS_CODE_WEEK_DAY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeWeekDayId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtlDay objects.</returns>
		public abstract TList<ScScheduleDtlDay> GetByGsCodeWeekDayId(TransactionManager transactionManager, System.Decimal? _gsCodeWeekDayId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_DAY_SC_BUILDING key.
		///		FK_SC_SCHEDULE_DTL_DAY_SC_BUILDING Description: 
		/// </summary>
		/// <param name="_scBuildingId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtlDay objects.</returns>
		public TList<ScScheduleDtlDay> GetByScBuildingId(System.Decimal? _scBuildingId)
		{
			int count = -1;
			return GetByScBuildingId(_scBuildingId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_DAY_SC_BUILDING key.
		///		FK_SC_SCHEDULE_DTL_DAY_SC_BUILDING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scBuildingId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtlDay objects.</returns>
		/// <remarks></remarks>
		public TList<ScScheduleDtlDay> GetByScBuildingId(TransactionManager transactionManager, System.Decimal? _scBuildingId)
		{
			int count = -1;
			return GetByScBuildingId(transactionManager, _scBuildingId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_DAY_SC_BUILDING key.
		///		FK_SC_SCHEDULE_DTL_DAY_SC_BUILDING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scBuildingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtlDay objects.</returns>
		public TList<ScScheduleDtlDay> GetByScBuildingId(TransactionManager transactionManager, System.Decimal? _scBuildingId, int start, int pageLength)
		{
			int count = -1;
			return GetByScBuildingId(transactionManager, _scBuildingId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_DAY_SC_BUILDING key.
		///		fkScScheduleDtlDayScBuilding Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scBuildingId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtlDay objects.</returns>
		public TList<ScScheduleDtlDay> GetByScBuildingId(System.Decimal? _scBuildingId, int start, int pageLength)
		{
			int count =  -1;
			return GetByScBuildingId(null, _scBuildingId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_DAY_SC_BUILDING key.
		///		fkScScheduleDtlDayScBuilding Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scBuildingId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtlDay objects.</returns>
		public TList<ScScheduleDtlDay> GetByScBuildingId(System.Decimal? _scBuildingId, int start, int pageLength,out int count)
		{
			return GetByScBuildingId(null, _scBuildingId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_DAY_SC_BUILDING key.
		///		FK_SC_SCHEDULE_DTL_DAY_SC_BUILDING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scBuildingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtlDay objects.</returns>
		public abstract TList<ScScheduleDtlDay> GetByScBuildingId(TransactionManager transactionManager, System.Decimal? _scBuildingId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_DAY_SC_HALL key.
		///		FK_SC_SCHEDULE_DTL_DAY_SC_HALL Description: 
		/// </summary>
		/// <param name="_scHallId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtlDay objects.</returns>
		public TList<ScScheduleDtlDay> GetByScHallId(System.Decimal? _scHallId)
		{
			int count = -1;
			return GetByScHallId(_scHallId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_DAY_SC_HALL key.
		///		FK_SC_SCHEDULE_DTL_DAY_SC_HALL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scHallId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtlDay objects.</returns>
		/// <remarks></remarks>
		public TList<ScScheduleDtlDay> GetByScHallId(TransactionManager transactionManager, System.Decimal? _scHallId)
		{
			int count = -1;
			return GetByScHallId(transactionManager, _scHallId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_DAY_SC_HALL key.
		///		FK_SC_SCHEDULE_DTL_DAY_SC_HALL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scHallId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtlDay objects.</returns>
		public TList<ScScheduleDtlDay> GetByScHallId(TransactionManager transactionManager, System.Decimal? _scHallId, int start, int pageLength)
		{
			int count = -1;
			return GetByScHallId(transactionManager, _scHallId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_DAY_SC_HALL key.
		///		fkScScheduleDtlDayScHall Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scHallId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtlDay objects.</returns>
		public TList<ScScheduleDtlDay> GetByScHallId(System.Decimal? _scHallId, int start, int pageLength)
		{
			int count =  -1;
			return GetByScHallId(null, _scHallId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_DAY_SC_HALL key.
		///		fkScScheduleDtlDayScHall Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scHallId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtlDay objects.</returns>
		public TList<ScScheduleDtlDay> GetByScHallId(System.Decimal? _scHallId, int start, int pageLength,out int count)
		{
			return GetByScHallId(null, _scHallId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_DAY_SC_HALL key.
		///		FK_SC_SCHEDULE_DTL_DAY_SC_HALL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scHallId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtlDay objects.</returns>
		public abstract TList<ScScheduleDtlDay> GetByScHallId(TransactionManager transactionManager, System.Decimal? _scHallId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_DAY_SC_SCHEDULE_DTL1 key.
		///		FK_SC_SCHEDULE_DTL_DAY_SC_SCHEDULE_DTL1 Description: 
		/// </summary>
		/// <param name="_scScheduleDtlId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtlDay objects.</returns>
		public TList<ScScheduleDtlDay> GetByScScheduleDtlId(System.Decimal _scScheduleDtlId)
		{
			int count = -1;
			return GetByScScheduleDtlId(_scScheduleDtlId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_DAY_SC_SCHEDULE_DTL1 key.
		///		FK_SC_SCHEDULE_DTL_DAY_SC_SCHEDULE_DTL1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleDtlId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtlDay objects.</returns>
		/// <remarks></remarks>
		public TList<ScScheduleDtlDay> GetByScScheduleDtlId(TransactionManager transactionManager, System.Decimal _scScheduleDtlId)
		{
			int count = -1;
			return GetByScScheduleDtlId(transactionManager, _scScheduleDtlId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_DAY_SC_SCHEDULE_DTL1 key.
		///		FK_SC_SCHEDULE_DTL_DAY_SC_SCHEDULE_DTL1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtlDay objects.</returns>
		public TList<ScScheduleDtlDay> GetByScScheduleDtlId(TransactionManager transactionManager, System.Decimal _scScheduleDtlId, int start, int pageLength)
		{
			int count = -1;
			return GetByScScheduleDtlId(transactionManager, _scScheduleDtlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_DAY_SC_SCHEDULE_DTL1 key.
		///		fkScScheduleDtlDayScScheduleDtl1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scScheduleDtlId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtlDay objects.</returns>
		public TList<ScScheduleDtlDay> GetByScScheduleDtlId(System.Decimal _scScheduleDtlId, int start, int pageLength)
		{
			int count =  -1;
			return GetByScScheduleDtlId(null, _scScheduleDtlId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_DAY_SC_SCHEDULE_DTL1 key.
		///		fkScScheduleDtlDayScScheduleDtl1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scScheduleDtlId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtlDay objects.</returns>
		public TList<ScScheduleDtlDay> GetByScScheduleDtlId(System.Decimal _scScheduleDtlId, int start, int pageLength,out int count)
		{
			return GetByScScheduleDtlId(null, _scScheduleDtlId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_DAY_SC_SCHEDULE_DTL1 key.
		///		FK_SC_SCHEDULE_DTL_DAY_SC_SCHEDULE_DTL1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtlDay objects.</returns>
		public abstract TList<ScScheduleDtlDay> GetByScScheduleDtlId(TransactionManager transactionManager, System.Decimal _scScheduleDtlId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_DAY_SC_TCHNG_SLOT key.
		///		FK_SC_SCHEDULE_DTL_DAY_SC_TCHNG_SLOT Description: 
		/// </summary>
		/// <param name="_scTchngSlotId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtlDay objects.</returns>
		public TList<ScScheduleDtlDay> GetByScTchngSlotId(System.Decimal? _scTchngSlotId)
		{
			int count = -1;
			return GetByScTchngSlotId(_scTchngSlotId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_DAY_SC_TCHNG_SLOT key.
		///		FK_SC_SCHEDULE_DTL_DAY_SC_TCHNG_SLOT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scTchngSlotId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtlDay objects.</returns>
		/// <remarks></remarks>
		public TList<ScScheduleDtlDay> GetByScTchngSlotId(TransactionManager transactionManager, System.Decimal? _scTchngSlotId)
		{
			int count = -1;
			return GetByScTchngSlotId(transactionManager, _scTchngSlotId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_DAY_SC_TCHNG_SLOT key.
		///		FK_SC_SCHEDULE_DTL_DAY_SC_TCHNG_SLOT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scTchngSlotId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtlDay objects.</returns>
		public TList<ScScheduleDtlDay> GetByScTchngSlotId(TransactionManager transactionManager, System.Decimal? _scTchngSlotId, int start, int pageLength)
		{
			int count = -1;
			return GetByScTchngSlotId(transactionManager, _scTchngSlotId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_DAY_SC_TCHNG_SLOT key.
		///		fkScScheduleDtlDayScTchngSlot Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scTchngSlotId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtlDay objects.</returns>
		public TList<ScScheduleDtlDay> GetByScTchngSlotId(System.Decimal? _scTchngSlotId, int start, int pageLength)
		{
			int count =  -1;
			return GetByScTchngSlotId(null, _scTchngSlotId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_DAY_SC_TCHNG_SLOT key.
		///		fkScScheduleDtlDayScTchngSlot Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scTchngSlotId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtlDay objects.</returns>
		public TList<ScScheduleDtlDay> GetByScTchngSlotId(System.Decimal? _scTchngSlotId, int start, int pageLength,out int count)
		{
			return GetByScTchngSlotId(null, _scTchngSlotId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_DAY_SC_TCHNG_SLOT key.
		///		FK_SC_SCHEDULE_DTL_DAY_SC_TCHNG_SLOT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scTchngSlotId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtlDay objects.</returns>
		public abstract TList<ScScheduleDtlDay> GetByScTchngSlotId(TransactionManager transactionManager, System.Decimal? _scTchngSlotId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.ScScheduleDtlDay Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScScheduleDtlDayKey key, int start, int pageLength)
		{
			return GetByScScheduleDtlDayId(transactionManager, key.ScScheduleDtlDayId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SC_SCHEDULE_DTL_DAY index.
		/// </summary>
		/// <param name="_scScheduleDtlDayId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtlDay"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScScheduleDtlDay GetByScScheduleDtlDayId(System.Decimal _scScheduleDtlDayId)
		{
			int count = -1;
			return GetByScScheduleDtlDayId(null,_scScheduleDtlDayId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_SCHEDULE_DTL_DAY index.
		/// </summary>
		/// <param name="_scScheduleDtlDayId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtlDay"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScScheduleDtlDay GetByScScheduleDtlDayId(System.Decimal _scScheduleDtlDayId, int start, int pageLength)
		{
			int count = -1;
			return GetByScScheduleDtlDayId(null, _scScheduleDtlDayId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_SCHEDULE_DTL_DAY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleDtlDayId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtlDay"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScScheduleDtlDay GetByScScheduleDtlDayId(TransactionManager transactionManager, System.Decimal _scScheduleDtlDayId)
		{
			int count = -1;
			return GetByScScheduleDtlDayId(transactionManager, _scScheduleDtlDayId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_SCHEDULE_DTL_DAY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleDtlDayId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtlDay"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScScheduleDtlDay GetByScScheduleDtlDayId(TransactionManager transactionManager, System.Decimal _scScheduleDtlDayId, int start, int pageLength)
		{
			int count = -1;
			return GetByScScheduleDtlDayId(transactionManager, _scScheduleDtlDayId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_SCHEDULE_DTL_DAY index.
		/// </summary>
		/// <param name="_scScheduleDtlDayId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtlDay"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScScheduleDtlDay GetByScScheduleDtlDayId(System.Decimal _scScheduleDtlDayId, int start, int pageLength, out int count)
		{
			return GetByScScheduleDtlDayId(null, _scScheduleDtlDayId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_SCHEDULE_DTL_DAY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleDtlDayId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtlDay"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.ScScheduleDtlDay GetByScScheduleDtlDayId(TransactionManager transactionManager, System.Decimal _scScheduleDtlDayId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_SC_SCHEDULE_DTL_DAY index.
		/// </summary>
		/// <param name="_scScheduleDtlId"></param>
		/// <param name="_gsCodeWeekDayId"></param>
		/// <param name="_fromTime"></param>
		/// <param name="_toTime"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtlDay"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScScheduleDtlDay GetByScScheduleDtlIdGsCodeWeekDayIdFromTimeToTime(System.Decimal _scScheduleDtlId, System.Decimal? _gsCodeWeekDayId, System.DateTime? _fromTime, System.DateTime? _toTime)
		{
			int count = -1;
			return GetByScScheduleDtlIdGsCodeWeekDayIdFromTimeToTime(null,_scScheduleDtlId, _gsCodeWeekDayId, _fromTime, _toTime, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SC_SCHEDULE_DTL_DAY index.
		/// </summary>
		/// <param name="_scScheduleDtlId"></param>
		/// <param name="_gsCodeWeekDayId"></param>
		/// <param name="_fromTime"></param>
		/// <param name="_toTime"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtlDay"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScScheduleDtlDay GetByScScheduleDtlIdGsCodeWeekDayIdFromTimeToTime(System.Decimal _scScheduleDtlId, System.Decimal? _gsCodeWeekDayId, System.DateTime? _fromTime, System.DateTime? _toTime, int start, int pageLength)
		{
			int count = -1;
			return GetByScScheduleDtlIdGsCodeWeekDayIdFromTimeToTime(null, _scScheduleDtlId, _gsCodeWeekDayId, _fromTime, _toTime, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SC_SCHEDULE_DTL_DAY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleDtlId"></param>
		/// <param name="_gsCodeWeekDayId"></param>
		/// <param name="_fromTime"></param>
		/// <param name="_toTime"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtlDay"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScScheduleDtlDay GetByScScheduleDtlIdGsCodeWeekDayIdFromTimeToTime(TransactionManager transactionManager, System.Decimal _scScheduleDtlId, System.Decimal? _gsCodeWeekDayId, System.DateTime? _fromTime, System.DateTime? _toTime)
		{
			int count = -1;
			return GetByScScheduleDtlIdGsCodeWeekDayIdFromTimeToTime(transactionManager, _scScheduleDtlId, _gsCodeWeekDayId, _fromTime, _toTime, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SC_SCHEDULE_DTL_DAY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleDtlId"></param>
		/// <param name="_gsCodeWeekDayId"></param>
		/// <param name="_fromTime"></param>
		/// <param name="_toTime"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtlDay"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScScheduleDtlDay GetByScScheduleDtlIdGsCodeWeekDayIdFromTimeToTime(TransactionManager transactionManager, System.Decimal _scScheduleDtlId, System.Decimal? _gsCodeWeekDayId, System.DateTime? _fromTime, System.DateTime? _toTime, int start, int pageLength)
		{
			int count = -1;
			return GetByScScheduleDtlIdGsCodeWeekDayIdFromTimeToTime(transactionManager, _scScheduleDtlId, _gsCodeWeekDayId, _fromTime, _toTime, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SC_SCHEDULE_DTL_DAY index.
		/// </summary>
		/// <param name="_scScheduleDtlId"></param>
		/// <param name="_gsCodeWeekDayId"></param>
		/// <param name="_fromTime"></param>
		/// <param name="_toTime"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtlDay"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScScheduleDtlDay GetByScScheduleDtlIdGsCodeWeekDayIdFromTimeToTime(System.Decimal _scScheduleDtlId, System.Decimal? _gsCodeWeekDayId, System.DateTime? _fromTime, System.DateTime? _toTime, int start, int pageLength, out int count)
		{
			return GetByScScheduleDtlIdGsCodeWeekDayIdFromTimeToTime(null, _scScheduleDtlId, _gsCodeWeekDayId, _fromTime, _toTime, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SC_SCHEDULE_DTL_DAY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleDtlId"></param>
		/// <param name="_gsCodeWeekDayId"></param>
		/// <param name="_fromTime"></param>
		/// <param name="_toTime"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtlDay"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.ScScheduleDtlDay GetByScScheduleDtlIdGsCodeWeekDayIdFromTimeToTime(TransactionManager transactionManager, System.Decimal _scScheduleDtlId, System.Decimal? _gsCodeWeekDayId, System.DateTime? _fromTime, System.DateTime? _toTime, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;ScScheduleDtlDay&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;ScScheduleDtlDay&gt;"/></returns>
		public static TList<ScScheduleDtlDay> Fill(IDataReader reader, TList<ScScheduleDtlDay> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.ScScheduleDtlDay c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("ScScheduleDtlDay")
					.Append("|").Append((System.Decimal)reader["SC_SCHEDULE_DTL_DAY_ID"]).ToString();
					c = EntityManager.LocateOrCreate<ScScheduleDtlDay>(
					key.ToString(), // EntityTrackingKey
					"ScScheduleDtlDay",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.ScScheduleDtlDay();
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
					c.ScScheduleDtlDayId = (System.Decimal)reader["SC_SCHEDULE_DTL_DAY_ID"];
					c.OriginalScScheduleDtlDayId = c.ScScheduleDtlDayId;
					c.ScScheduleDtlId = (System.Decimal)reader["SC_SCHEDULE_DTL_ID"];
					c.GsCodeWeekDayId = Convert.IsDBNull(reader["GS_CODE_WEEK_DAY_ID"]) ? null : (System.Decimal?)reader["GS_CODE_WEEK_DAY_ID"];
					c.ScTchngSlotId = Convert.IsDBNull(reader["SC_TCHNG_SLOT_ID"]) ? null : (System.Decimal?)reader["SC_TCHNG_SLOT_ID"];
					c.ScBuildingId = Convert.IsDBNull(reader["SC_BUILDING_ID"]) ? null : (System.Decimal?)reader["SC_BUILDING_ID"];
					c.ScHallId = Convert.IsDBNull(reader["SC_HALL_ID"]) ? null : (System.Decimal?)reader["SC_HALL_ID"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
					c.FromTime = Convert.IsDBNull(reader["FROM_TIME"]) ? null : (System.DateTime?)reader["FROM_TIME"];
					c.ToTime = Convert.IsDBNull(reader["TO_TIME"]) ? null : (System.DateTime?)reader["TO_TIME"];
					c.EdCodeCourseTeachingId = Convert.IsDBNull(reader["ED_CODE_COURSE_TEACHING_ID"]) ? null : (System.Decimal?)reader["ED_CODE_COURSE_TEACHING_ID"];
					c.LastDate = Convert.IsDBNull(reader["LAST_DATE"]) ? null : (System.DateTime?)reader["LAST_DATE"];
					c.SeFormId = Convert.IsDBNull(reader["SE_FORM_ID"]) ? null : (System.Decimal?)reader["SE_FORM_ID"];
					c.SeUserId = Convert.IsDBNull(reader["SE_USER_ID"]) ? null : (System.Decimal?)reader["SE_USER_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtlDay"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtlDay"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.ScScheduleDtlDay entity)
		{
			if (!reader.Read()) return;
			
			entity.ScScheduleDtlDayId = (System.Decimal)reader[((int)ScScheduleDtlDayColumn.ScScheduleDtlDayId - 1)];
			entity.OriginalScScheduleDtlDayId = (System.Decimal)reader["SC_SCHEDULE_DTL_DAY_ID"];
			entity.ScScheduleDtlId = (System.Decimal)reader[((int)ScScheduleDtlDayColumn.ScScheduleDtlId - 1)];
			entity.GsCodeWeekDayId = (reader.IsDBNull(((int)ScScheduleDtlDayColumn.GsCodeWeekDayId - 1)))?null:(System.Decimal?)reader[((int)ScScheduleDtlDayColumn.GsCodeWeekDayId - 1)];
			entity.ScTchngSlotId = (reader.IsDBNull(((int)ScScheduleDtlDayColumn.ScTchngSlotId - 1)))?null:(System.Decimal?)reader[((int)ScScheduleDtlDayColumn.ScTchngSlotId - 1)];
			entity.ScBuildingId = (reader.IsDBNull(((int)ScScheduleDtlDayColumn.ScBuildingId - 1)))?null:(System.Decimal?)reader[((int)ScScheduleDtlDayColumn.ScBuildingId - 1)];
			entity.ScHallId = (reader.IsDBNull(((int)ScScheduleDtlDayColumn.ScHallId - 1)))?null:(System.Decimal?)reader[((int)ScScheduleDtlDayColumn.ScHallId - 1)];
			entity.Notes = (reader.IsDBNull(((int)ScScheduleDtlDayColumn.Notes - 1)))?null:(System.String)reader[((int)ScScheduleDtlDayColumn.Notes - 1)];
			entity.FromTime = (reader.IsDBNull(((int)ScScheduleDtlDayColumn.FromTime - 1)))?null:(System.DateTime?)reader[((int)ScScheduleDtlDayColumn.FromTime - 1)];
			entity.ToTime = (reader.IsDBNull(((int)ScScheduleDtlDayColumn.ToTime - 1)))?null:(System.DateTime?)reader[((int)ScScheduleDtlDayColumn.ToTime - 1)];
			entity.EdCodeCourseTeachingId = (reader.IsDBNull(((int)ScScheduleDtlDayColumn.EdCodeCourseTeachingId - 1)))?null:(System.Decimal?)reader[((int)ScScheduleDtlDayColumn.EdCodeCourseTeachingId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)ScScheduleDtlDayColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)ScScheduleDtlDayColumn.LastDate - 1)];
			entity.SeFormId = (reader.IsDBNull(((int)ScScheduleDtlDayColumn.SeFormId - 1)))?null:(System.Decimal?)reader[((int)ScScheduleDtlDayColumn.SeFormId - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)ScScheduleDtlDayColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)ScScheduleDtlDayColumn.SeUserId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtlDay"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtlDay"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.ScScheduleDtlDay entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.ScScheduleDtlDayId = (System.Decimal)dataRow["SC_SCHEDULE_DTL_DAY_ID"];
			entity.OriginalScScheduleDtlDayId = (System.Decimal)dataRow["SC_SCHEDULE_DTL_DAY_ID"];
			entity.ScScheduleDtlId = (System.Decimal)dataRow["SC_SCHEDULE_DTL_ID"];
			entity.GsCodeWeekDayId = Convert.IsDBNull(dataRow["GS_CODE_WEEK_DAY_ID"]) ? null : (System.Decimal?)dataRow["GS_CODE_WEEK_DAY_ID"];
			entity.ScTchngSlotId = Convert.IsDBNull(dataRow["SC_TCHNG_SLOT_ID"]) ? null : (System.Decimal?)dataRow["SC_TCHNG_SLOT_ID"];
			entity.ScBuildingId = Convert.IsDBNull(dataRow["SC_BUILDING_ID"]) ? null : (System.Decimal?)dataRow["SC_BUILDING_ID"];
			entity.ScHallId = Convert.IsDBNull(dataRow["SC_HALL_ID"]) ? null : (System.Decimal?)dataRow["SC_HALL_ID"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
			entity.FromTime = Convert.IsDBNull(dataRow["FROM_TIME"]) ? null : (System.DateTime?)dataRow["FROM_TIME"];
			entity.ToTime = Convert.IsDBNull(dataRow["TO_TIME"]) ? null : (System.DateTime?)dataRow["TO_TIME"];
			entity.EdCodeCourseTeachingId = Convert.IsDBNull(dataRow["ED_CODE_COURSE_TEACHING_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_COURSE_TEACHING_ID"];
			entity.LastDate = Convert.IsDBNull(dataRow["LAST_DATE"]) ? null : (System.DateTime?)dataRow["LAST_DATE"];
			entity.SeFormId = Convert.IsDBNull(dataRow["SE_FORM_ID"]) ? null : (System.Decimal?)dataRow["SE_FORM_ID"];
			entity.SeUserId = Convert.IsDBNull(dataRow["SE_USER_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtlDay"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.ScScheduleDtlDay Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScScheduleDtlDay entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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

			#region GsCodeWeekDayIdSource	
			if (CanDeepLoad(entity, "GsCodeWeekDay|GsCodeWeekDayIdSource", deepLoadType, innerList) 
				&& entity.GsCodeWeekDayIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCodeWeekDayId ?? 0.0m);
				GsCodeWeekDay tmpEntity = EntityManager.LocateEntity<GsCodeWeekDay>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodeWeekDay), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodeWeekDayIdSource = tmpEntity;
				else
					entity.GsCodeWeekDayIdSource = DataRepository.GsCodeWeekDayProvider.GetByGsCodeWeekDayId(transactionManager, (entity.GsCodeWeekDayId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodeWeekDayIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCodeWeekDayIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodeWeekDayProvider.DeepLoad(transactionManager, entity.GsCodeWeekDayIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCodeWeekDayIdSource

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

			#region ScHallIdSource	
			if (CanDeepLoad(entity, "ScHall|ScHallIdSource", deepLoadType, innerList) 
				&& entity.ScHallIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.ScHallId ?? 0.0m);
				ScHall tmpEntity = EntityManager.LocateEntity<ScHall>(EntityLocator.ConstructKeyFromPkItems(typeof(ScHall), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.ScHallIdSource = tmpEntity;
				else
					entity.ScHallIdSource = DataRepository.ScHallProvider.GetByScHallId(transactionManager, (entity.ScHallId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScHallIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.ScHallIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.ScHallProvider.DeepLoad(transactionManager, entity.ScHallIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion ScHallIdSource

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

			#region ScTchngSlotIdSource	
			if (CanDeepLoad(entity, "ScTchngSlot|ScTchngSlotIdSource", deepLoadType, innerList) 
				&& entity.ScTchngSlotIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.ScTchngSlotId ?? 0.0m);
				ScTchngSlot tmpEntity = EntityManager.LocateEntity<ScTchngSlot>(EntityLocator.ConstructKeyFromPkItems(typeof(ScTchngSlot), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.ScTchngSlotIdSource = tmpEntity;
				else
					entity.ScTchngSlotIdSource = DataRepository.ScTchngSlotProvider.GetByScTchngSlotId(transactionManager, (entity.ScTchngSlotId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScTchngSlotIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.ScTchngSlotIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.ScTchngSlotProvider.DeepLoad(transactionManager, entity.ScTchngSlotIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion ScTchngSlotIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByScScheduleDtlDayId methods when available
			
			#region ScScheduleDtlDayExceptionCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ScScheduleDtlDayException>|ScScheduleDtlDayExceptionCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScScheduleDtlDayExceptionCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ScScheduleDtlDayExceptionCollection = DataRepository.ScScheduleDtlDayExceptionProvider.GetByScScheduleDtlDayId(transactionManager, entity.ScScheduleDtlDayId);

				if (deep && entity.ScScheduleDtlDayExceptionCollection.Count > 0)
				{
					deepHandles.Add("ScScheduleDtlDayExceptionCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScScheduleDtlDayException>) DataRepository.ScScheduleDtlDayExceptionProvider.DeepLoad,
						new object[] { transactionManager, entity.ScScheduleDtlDayExceptionCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudAbsenceCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudAbsence>|EdStudAbsenceCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudAbsenceCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudAbsenceCollection = DataRepository.EdStudAbsenceProvider.GetByScScheduleDtlDayId(transactionManager, entity.ScScheduleDtlDayId);

				if (deep && entity.EdStudAbsenceCollection.Count > 0)
				{
					deepHandles.Add("EdStudAbsenceCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudAbsence>) DataRepository.EdStudAbsenceProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudAbsenceCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudLatenessCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudLateness>|EdStudLatenessCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudLatenessCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudLatenessCollection = DataRepository.EdStudLatenessProvider.GetByScScheduleDtlDayId(transactionManager, entity.ScScheduleDtlDayId);

				if (deep && entity.EdStudLatenessCollection.Count > 0)
				{
					deepHandles.Add("EdStudLatenessCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudLateness>) DataRepository.EdStudLatenessProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudLatenessCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdAbsenceApproveCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdAbsenceApprove>|EdAbsenceApproveCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdAbsenceApproveCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdAbsenceApproveCollection = DataRepository.EdAbsenceApproveProvider.GetByScScheduleDtlDayId(transactionManager, entity.ScScheduleDtlDayId);

				if (deep && entity.EdAbsenceApproveCollection.Count > 0)
				{
					deepHandles.Add("EdAbsenceApproveCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdAbsenceApprove>) DataRepository.EdAbsenceApproveProvider.DeepLoad,
						new object[] { transactionManager, entity.EdAbsenceApproveCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.ScScheduleDtlDay object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.ScScheduleDtlDay instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.ScScheduleDtlDay Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScScheduleDtlDay entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region GsCodeWeekDayIdSource
			if (CanDeepSave(entity, "GsCodeWeekDay|GsCodeWeekDayIdSource", deepSaveType, innerList) 
				&& entity.GsCodeWeekDayIdSource != null)
			{
				DataRepository.GsCodeWeekDayProvider.Save(transactionManager, entity.GsCodeWeekDayIdSource);
				entity.GsCodeWeekDayId = entity.GsCodeWeekDayIdSource.GsCodeWeekDayId;
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
			
			#region ScHallIdSource
			if (CanDeepSave(entity, "ScHall|ScHallIdSource", deepSaveType, innerList) 
				&& entity.ScHallIdSource != null)
			{
				DataRepository.ScHallProvider.Save(transactionManager, entity.ScHallIdSource);
				entity.ScHallId = entity.ScHallIdSource.ScHallId;
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
			
			#region ScTchngSlotIdSource
			if (CanDeepSave(entity, "ScTchngSlot|ScTchngSlotIdSource", deepSaveType, innerList) 
				&& entity.ScTchngSlotIdSource != null)
			{
				DataRepository.ScTchngSlotProvider.Save(transactionManager, entity.ScTchngSlotIdSource);
				entity.ScTchngSlotId = entity.ScTchngSlotIdSource.ScTchngSlotId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<ScScheduleDtlDayException>
				if (CanDeepSave(entity.ScScheduleDtlDayExceptionCollection, "List<ScScheduleDtlDayException>|ScScheduleDtlDayExceptionCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScScheduleDtlDayException child in entity.ScScheduleDtlDayExceptionCollection)
					{
						if(child.ScScheduleDtlDayIdSource != null)
						{
							child.ScScheduleDtlDayId = child.ScScheduleDtlDayIdSource.ScScheduleDtlDayId;
						}
						else
						{
							child.ScScheduleDtlDayId = entity.ScScheduleDtlDayId;
						}

					}

					if (entity.ScScheduleDtlDayExceptionCollection.Count > 0 || entity.ScScheduleDtlDayExceptionCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ScScheduleDtlDayExceptionProvider.Save(transactionManager, entity.ScScheduleDtlDayExceptionCollection);
						
						deepHandles.Add("ScScheduleDtlDayExceptionCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ScScheduleDtlDayException >) DataRepository.ScScheduleDtlDayExceptionProvider.DeepSave,
							new object[] { transactionManager, entity.ScScheduleDtlDayExceptionCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudAbsence>
				if (CanDeepSave(entity.EdStudAbsenceCollection, "List<EdStudAbsence>|EdStudAbsenceCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudAbsence child in entity.EdStudAbsenceCollection)
					{
						if(child.ScScheduleDtlDayIdSource != null)
						{
							child.ScScheduleDtlDayId = child.ScScheduleDtlDayIdSource.ScScheduleDtlDayId;
						}
						else
						{
							child.ScScheduleDtlDayId = entity.ScScheduleDtlDayId;
						}

					}

					if (entity.EdStudAbsenceCollection.Count > 0 || entity.EdStudAbsenceCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudAbsenceProvider.Save(transactionManager, entity.EdStudAbsenceCollection);
						
						deepHandles.Add("EdStudAbsenceCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudAbsence >) DataRepository.EdStudAbsenceProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudAbsenceCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudLateness>
				if (CanDeepSave(entity.EdStudLatenessCollection, "List<EdStudLateness>|EdStudLatenessCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudLateness child in entity.EdStudLatenessCollection)
					{
						if(child.ScScheduleDtlDayIdSource != null)
						{
							child.ScScheduleDtlDayId = child.ScScheduleDtlDayIdSource.ScScheduleDtlDayId;
						}
						else
						{
							child.ScScheduleDtlDayId = entity.ScScheduleDtlDayId;
						}

					}

					if (entity.EdStudLatenessCollection.Count > 0 || entity.EdStudLatenessCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudLatenessProvider.Save(transactionManager, entity.EdStudLatenessCollection);
						
						deepHandles.Add("EdStudLatenessCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudLateness >) DataRepository.EdStudLatenessProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudLatenessCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdAbsenceApprove>
				if (CanDeepSave(entity.EdAbsenceApproveCollection, "List<EdAbsenceApprove>|EdAbsenceApproveCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdAbsenceApprove child in entity.EdAbsenceApproveCollection)
					{
						if(child.ScScheduleDtlDayIdSource != null)
						{
							child.ScScheduleDtlDayId = child.ScScheduleDtlDayIdSource.ScScheduleDtlDayId;
						}
						else
						{
							child.ScScheduleDtlDayId = entity.ScScheduleDtlDayId;
						}

					}

					if (entity.EdAbsenceApproveCollection.Count > 0 || entity.EdAbsenceApproveCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdAbsenceApproveProvider.Save(transactionManager, entity.EdAbsenceApproveCollection);
						
						deepHandles.Add("EdAbsenceApproveCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdAbsenceApprove >) DataRepository.EdAbsenceApproveProvider.DeepSave,
							new object[] { transactionManager, entity.EdAbsenceApproveCollection, deepSaveType, childTypes, innerList }
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
	
	#region ScScheduleDtlDayChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.ScScheduleDtlDay</c>
	///</summary>
	public enum ScScheduleDtlDayChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdCodeCourseTeaching</c> at EdCodeCourseTeachingIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeCourseTeaching))]
		EdCodeCourseTeaching,
		
		///<summary>
		/// Composite Property for <c>GsCodeWeekDay</c> at GsCodeWeekDayIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeWeekDay))]
		GsCodeWeekDay,
		
		///<summary>
		/// Composite Property for <c>ScBuilding</c> at ScBuildingIdSource
		///</summary>
		[ChildEntityType(typeof(ScBuilding))]
		ScBuilding,
		
		///<summary>
		/// Composite Property for <c>ScHall</c> at ScHallIdSource
		///</summary>
		[ChildEntityType(typeof(ScHall))]
		ScHall,
		
		///<summary>
		/// Composite Property for <c>ScScheduleDtl</c> at ScScheduleDtlIdSource
		///</summary>
		[ChildEntityType(typeof(ScScheduleDtl))]
		ScScheduleDtl,
		
		///<summary>
		/// Composite Property for <c>ScTchngSlot</c> at ScTchngSlotIdSource
		///</summary>
		[ChildEntityType(typeof(ScTchngSlot))]
		ScTchngSlot,
		///<summary>
		/// Collection of <c>ScScheduleDtlDay</c> as OneToMany for ScScheduleDtlDayExceptionCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScScheduleDtlDayException>))]
		ScScheduleDtlDayExceptionCollection,
		///<summary>
		/// Collection of <c>ScScheduleDtlDay</c> as OneToMany for EdStudAbsenceCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudAbsence>))]
		EdStudAbsenceCollection,
		///<summary>
		/// Collection of <c>ScScheduleDtlDay</c> as OneToMany for EdStudLatenessCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudLateness>))]
		EdStudLatenessCollection,
		///<summary>
		/// Collection of <c>ScScheduleDtlDay</c> as OneToMany for EdAbsenceApproveCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdAbsenceApprove>))]
		EdAbsenceApproveCollection,
	}
	
	#endregion ScScheduleDtlDayChildEntityTypes
	
	#region ScScheduleDtlDayFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;ScScheduleDtlDayColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScScheduleDtlDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ScScheduleDtlDayFilterBuilder : SqlFilterBuilder<ScScheduleDtlDayColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScScheduleDtlDayFilterBuilder class.
		/// </summary>
		public ScScheduleDtlDayFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ScScheduleDtlDayFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ScScheduleDtlDayFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ScScheduleDtlDayFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ScScheduleDtlDayFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ScScheduleDtlDayFilterBuilder
	
	#region ScScheduleDtlDayParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;ScScheduleDtlDayColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScScheduleDtlDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ScScheduleDtlDayParameterBuilder : ParameterizedSqlFilterBuilder<ScScheduleDtlDayColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScScheduleDtlDayParameterBuilder class.
		/// </summary>
		public ScScheduleDtlDayParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ScScheduleDtlDayParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ScScheduleDtlDayParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ScScheduleDtlDayParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ScScheduleDtlDayParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ScScheduleDtlDayParameterBuilder
	
	#region ScScheduleDtlDaySortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;ScScheduleDtlDayColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScScheduleDtlDay"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ScScheduleDtlDaySortBuilder : SqlSortBuilder<ScScheduleDtlDayColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScScheduleDtlDaySqlSortBuilder class.
		/// </summary>
		public ScScheduleDtlDaySortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ScScheduleDtlDaySortBuilder
	
} // end namespace
