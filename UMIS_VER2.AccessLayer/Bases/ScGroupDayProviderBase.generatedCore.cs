﻿#region Using directives

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
	/// This class is the base class for any <see cref="ScGroupDayProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class ScGroupDayProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.ScGroupDay, UMIS_VER2.BusinessLyer.ScGroupDayKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScGroupDayKey key)
		{
			return Delete(transactionManager, key.ScGroupDayId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_scGroupDayId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _scGroupDayId)
		{
			return Delete(null, _scGroupDayId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scGroupDayId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _scGroupDayId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_DAY_ED_CDE_TCHNG_MTHD key.
		///		FK_SC_GROUP_DAY_ED_CDE_TCHNG_MTHD Description: 
		/// </summary>
		/// <param name="_edCdeTchngMthdId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupDay objects.</returns>
		public TList<ScGroupDay> GetByEdCdeTchngMthdId(System.Decimal? _edCdeTchngMthdId)
		{
			int count = -1;
			return GetByEdCdeTchngMthdId(_edCdeTchngMthdId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_DAY_ED_CDE_TCHNG_MTHD key.
		///		FK_SC_GROUP_DAY_ED_CDE_TCHNG_MTHD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeTchngMthdId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupDay objects.</returns>
		/// <remarks></remarks>
		public TList<ScGroupDay> GetByEdCdeTchngMthdId(TransactionManager transactionManager, System.Decimal? _edCdeTchngMthdId)
		{
			int count = -1;
			return GetByEdCdeTchngMthdId(transactionManager, _edCdeTchngMthdId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_DAY_ED_CDE_TCHNG_MTHD key.
		///		FK_SC_GROUP_DAY_ED_CDE_TCHNG_MTHD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeTchngMthdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupDay objects.</returns>
		public TList<ScGroupDay> GetByEdCdeTchngMthdId(TransactionManager transactionManager, System.Decimal? _edCdeTchngMthdId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCdeTchngMthdId(transactionManager, _edCdeTchngMthdId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_DAY_ED_CDE_TCHNG_MTHD key.
		///		fkScGroupDayEdCdeTchngMthd Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCdeTchngMthdId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupDay objects.</returns>
		public TList<ScGroupDay> GetByEdCdeTchngMthdId(System.Decimal? _edCdeTchngMthdId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCdeTchngMthdId(null, _edCdeTchngMthdId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_DAY_ED_CDE_TCHNG_MTHD key.
		///		fkScGroupDayEdCdeTchngMthd Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCdeTchngMthdId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupDay objects.</returns>
		public TList<ScGroupDay> GetByEdCdeTchngMthdId(System.Decimal? _edCdeTchngMthdId, int start, int pageLength,out int count)
		{
			return GetByEdCdeTchngMthdId(null, _edCdeTchngMthdId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_DAY_ED_CDE_TCHNG_MTHD key.
		///		FK_SC_GROUP_DAY_ED_CDE_TCHNG_MTHD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeTchngMthdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupDay objects.</returns>
		public abstract TList<ScGroupDay> GetByEdCdeTchngMthdId(TransactionManager transactionManager, System.Decimal? _edCdeTchngMthdId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_DAY_ED_COURSE key.
		///		FK_SC_GROUP_DAY_ED_COURSE Description: 
		/// </summary>
		/// <param name="_edCourseId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupDay objects.</returns>
		public TList<ScGroupDay> GetByEdCourseId(System.Decimal? _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(_edCourseId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_DAY_ED_COURSE key.
		///		FK_SC_GROUP_DAY_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupDay objects.</returns>
		/// <remarks></remarks>
		public TList<ScGroupDay> GetByEdCourseId(TransactionManager transactionManager, System.Decimal? _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_DAY_ED_COURSE key.
		///		FK_SC_GROUP_DAY_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupDay objects.</returns>
		public TList<ScGroupDay> GetByEdCourseId(TransactionManager transactionManager, System.Decimal? _edCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_DAY_ED_COURSE key.
		///		fkScGroupDayEdCourse Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupDay objects.</returns>
		public TList<ScGroupDay> GetByEdCourseId(System.Decimal? _edCourseId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCourseId(null, _edCourseId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_DAY_ED_COURSE key.
		///		fkScGroupDayEdCourse Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCourseId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupDay objects.</returns>
		public TList<ScGroupDay> GetByEdCourseId(System.Decimal? _edCourseId, int start, int pageLength,out int count)
		{
			return GetByEdCourseId(null, _edCourseId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_DAY_ED_COURSE key.
		///		FK_SC_GROUP_DAY_ED_COURSE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupDay objects.</returns>
		public abstract TList<ScGroupDay> GetByEdCourseId(TransactionManager transactionManager, System.Decimal? _edCourseId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_DAY_SC_BUILDING key.
		///		FK_SC_GROUP_DAY_SC_BUILDING Description: 
		/// </summary>
		/// <param name="_scBuildingId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupDay objects.</returns>
		public TList<ScGroupDay> GetByScBuildingId(System.Decimal? _scBuildingId)
		{
			int count = -1;
			return GetByScBuildingId(_scBuildingId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_DAY_SC_BUILDING key.
		///		FK_SC_GROUP_DAY_SC_BUILDING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scBuildingId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupDay objects.</returns>
		/// <remarks></remarks>
		public TList<ScGroupDay> GetByScBuildingId(TransactionManager transactionManager, System.Decimal? _scBuildingId)
		{
			int count = -1;
			return GetByScBuildingId(transactionManager, _scBuildingId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_DAY_SC_BUILDING key.
		///		FK_SC_GROUP_DAY_SC_BUILDING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scBuildingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupDay objects.</returns>
		public TList<ScGroupDay> GetByScBuildingId(TransactionManager transactionManager, System.Decimal? _scBuildingId, int start, int pageLength)
		{
			int count = -1;
			return GetByScBuildingId(transactionManager, _scBuildingId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_DAY_SC_BUILDING key.
		///		fkScGroupDayScBuilding Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scBuildingId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupDay objects.</returns>
		public TList<ScGroupDay> GetByScBuildingId(System.Decimal? _scBuildingId, int start, int pageLength)
		{
			int count =  -1;
			return GetByScBuildingId(null, _scBuildingId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_DAY_SC_BUILDING key.
		///		fkScGroupDayScBuilding Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scBuildingId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupDay objects.</returns>
		public TList<ScGroupDay> GetByScBuildingId(System.Decimal? _scBuildingId, int start, int pageLength,out int count)
		{
			return GetByScBuildingId(null, _scBuildingId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_DAY_SC_BUILDING key.
		///		FK_SC_GROUP_DAY_SC_BUILDING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scBuildingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupDay objects.</returns>
		public abstract TList<ScGroupDay> GetByScBuildingId(TransactionManager transactionManager, System.Decimal? _scBuildingId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_DAY_SC_GROUP_INFO key.
		///		FK_SC_GROUP_DAY_SC_GROUP_INFO Description: 
		/// </summary>
		/// <param name="_scGroupInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupDay objects.</returns>
		public TList<ScGroupDay> GetByScGroupInfoId(System.Decimal _scGroupInfoId)
		{
			int count = -1;
			return GetByScGroupInfoId(_scGroupInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_DAY_SC_GROUP_INFO key.
		///		FK_SC_GROUP_DAY_SC_GROUP_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scGroupInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupDay objects.</returns>
		/// <remarks></remarks>
		public TList<ScGroupDay> GetByScGroupInfoId(TransactionManager transactionManager, System.Decimal _scGroupInfoId)
		{
			int count = -1;
			return GetByScGroupInfoId(transactionManager, _scGroupInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_DAY_SC_GROUP_INFO key.
		///		FK_SC_GROUP_DAY_SC_GROUP_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scGroupInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupDay objects.</returns>
		public TList<ScGroupDay> GetByScGroupInfoId(TransactionManager transactionManager, System.Decimal _scGroupInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByScGroupInfoId(transactionManager, _scGroupInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_DAY_SC_GROUP_INFO key.
		///		fkScGroupDayScGroupInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scGroupInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupDay objects.</returns>
		public TList<ScGroupDay> GetByScGroupInfoId(System.Decimal _scGroupInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByScGroupInfoId(null, _scGroupInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_DAY_SC_GROUP_INFO key.
		///		fkScGroupDayScGroupInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scGroupInfoId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupDay objects.</returns>
		public TList<ScGroupDay> GetByScGroupInfoId(System.Decimal _scGroupInfoId, int start, int pageLength,out int count)
		{
			return GetByScGroupInfoId(null, _scGroupInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_DAY_SC_GROUP_INFO key.
		///		FK_SC_GROUP_DAY_SC_GROUP_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scGroupInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupDay objects.</returns>
		public abstract TList<ScGroupDay> GetByScGroupInfoId(TransactionManager transactionManager, System.Decimal _scGroupInfoId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_DAY_SC_HALL key.
		///		FK_SC_GROUP_DAY_SC_HALL Description: 
		/// </summary>
		/// <param name="_scHallId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupDay objects.</returns>
		public TList<ScGroupDay> GetByScHallId(System.Decimal? _scHallId)
		{
			int count = -1;
			return GetByScHallId(_scHallId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_DAY_SC_HALL key.
		///		FK_SC_GROUP_DAY_SC_HALL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scHallId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupDay objects.</returns>
		/// <remarks></remarks>
		public TList<ScGroupDay> GetByScHallId(TransactionManager transactionManager, System.Decimal? _scHallId)
		{
			int count = -1;
			return GetByScHallId(transactionManager, _scHallId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_DAY_SC_HALL key.
		///		FK_SC_GROUP_DAY_SC_HALL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scHallId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupDay objects.</returns>
		public TList<ScGroupDay> GetByScHallId(TransactionManager transactionManager, System.Decimal? _scHallId, int start, int pageLength)
		{
			int count = -1;
			return GetByScHallId(transactionManager, _scHallId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_DAY_SC_HALL key.
		///		fkScGroupDayScHall Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scHallId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupDay objects.</returns>
		public TList<ScGroupDay> GetByScHallId(System.Decimal? _scHallId, int start, int pageLength)
		{
			int count =  -1;
			return GetByScHallId(null, _scHallId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_DAY_SC_HALL key.
		///		fkScGroupDayScHall Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scHallId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupDay objects.</returns>
		public TList<ScGroupDay> GetByScHallId(System.Decimal? _scHallId, int start, int pageLength,out int count)
		{
			return GetByScHallId(null, _scHallId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_DAY_SC_HALL key.
		///		FK_SC_GROUP_DAY_SC_HALL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scHallId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupDay objects.</returns>
		public abstract TList<ScGroupDay> GetByScHallId(TransactionManager transactionManager, System.Decimal? _scHallId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_DAY_SC_TCHNG_DAY key.
		///		FK_SC_GROUP_DAY_SC_TCHNG_DAY Description: 
		/// </summary>
		/// <param name="_scTchngDayId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupDay objects.</returns>
		public TList<ScGroupDay> GetByScTchngDayId(System.Decimal _scTchngDayId)
		{
			int count = -1;
			return GetByScTchngDayId(_scTchngDayId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_DAY_SC_TCHNG_DAY key.
		///		FK_SC_GROUP_DAY_SC_TCHNG_DAY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scTchngDayId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupDay objects.</returns>
		/// <remarks></remarks>
		public TList<ScGroupDay> GetByScTchngDayId(TransactionManager transactionManager, System.Decimal _scTchngDayId)
		{
			int count = -1;
			return GetByScTchngDayId(transactionManager, _scTchngDayId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_DAY_SC_TCHNG_DAY key.
		///		FK_SC_GROUP_DAY_SC_TCHNG_DAY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scTchngDayId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupDay objects.</returns>
		public TList<ScGroupDay> GetByScTchngDayId(TransactionManager transactionManager, System.Decimal _scTchngDayId, int start, int pageLength)
		{
			int count = -1;
			return GetByScTchngDayId(transactionManager, _scTchngDayId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_DAY_SC_TCHNG_DAY key.
		///		fkScGroupDayScTchngDay Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scTchngDayId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupDay objects.</returns>
		public TList<ScGroupDay> GetByScTchngDayId(System.Decimal _scTchngDayId, int start, int pageLength)
		{
			int count =  -1;
			return GetByScTchngDayId(null, _scTchngDayId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_DAY_SC_TCHNG_DAY key.
		///		fkScGroupDayScTchngDay Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scTchngDayId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupDay objects.</returns>
		public TList<ScGroupDay> GetByScTchngDayId(System.Decimal _scTchngDayId, int start, int pageLength,out int count)
		{
			return GetByScTchngDayId(null, _scTchngDayId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_DAY_SC_TCHNG_DAY key.
		///		FK_SC_GROUP_DAY_SC_TCHNG_DAY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scTchngDayId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupDay objects.</returns>
		public abstract TList<ScGroupDay> GetByScTchngDayId(TransactionManager transactionManager, System.Decimal _scTchngDayId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_DAY_SC_TCHNG_SLOT key.
		///		FK_SC_GROUP_DAY_SC_TCHNG_SLOT Description: 
		/// </summary>
		/// <param name="_scTchngSlotFrmId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupDay objects.</returns>
		public TList<ScGroupDay> GetByScTchngSlotFrmId(System.Decimal? _scTchngSlotFrmId)
		{
			int count = -1;
			return GetByScTchngSlotFrmId(_scTchngSlotFrmId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_DAY_SC_TCHNG_SLOT key.
		///		FK_SC_GROUP_DAY_SC_TCHNG_SLOT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scTchngSlotFrmId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupDay objects.</returns>
		/// <remarks></remarks>
		public TList<ScGroupDay> GetByScTchngSlotFrmId(TransactionManager transactionManager, System.Decimal? _scTchngSlotFrmId)
		{
			int count = -1;
			return GetByScTchngSlotFrmId(transactionManager, _scTchngSlotFrmId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_DAY_SC_TCHNG_SLOT key.
		///		FK_SC_GROUP_DAY_SC_TCHNG_SLOT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scTchngSlotFrmId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupDay objects.</returns>
		public TList<ScGroupDay> GetByScTchngSlotFrmId(TransactionManager transactionManager, System.Decimal? _scTchngSlotFrmId, int start, int pageLength)
		{
			int count = -1;
			return GetByScTchngSlotFrmId(transactionManager, _scTchngSlotFrmId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_DAY_SC_TCHNG_SLOT key.
		///		fkScGroupDayScTchngSlot Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scTchngSlotFrmId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupDay objects.</returns>
		public TList<ScGroupDay> GetByScTchngSlotFrmId(System.Decimal? _scTchngSlotFrmId, int start, int pageLength)
		{
			int count =  -1;
			return GetByScTchngSlotFrmId(null, _scTchngSlotFrmId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_DAY_SC_TCHNG_SLOT key.
		///		fkScGroupDayScTchngSlot Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scTchngSlotFrmId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupDay objects.</returns>
		public TList<ScGroupDay> GetByScTchngSlotFrmId(System.Decimal? _scTchngSlotFrmId, int start, int pageLength,out int count)
		{
			return GetByScTchngSlotFrmId(null, _scTchngSlotFrmId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_DAY_SC_TCHNG_SLOT key.
		///		FK_SC_GROUP_DAY_SC_TCHNG_SLOT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scTchngSlotFrmId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupDay objects.</returns>
		public abstract TList<ScGroupDay> GetByScTchngSlotFrmId(TransactionManager transactionManager, System.Decimal? _scTchngSlotFrmId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_DAY_SC_TCHNG_SLOT1 key.
		///		FK_SC_GROUP_DAY_SC_TCHNG_SLOT1 Description: 
		/// </summary>
		/// <param name="_scTchngSlotToId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupDay objects.</returns>
		public TList<ScGroupDay> GetByScTchngSlotToId(System.Decimal? _scTchngSlotToId)
		{
			int count = -1;
			return GetByScTchngSlotToId(_scTchngSlotToId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_DAY_SC_TCHNG_SLOT1 key.
		///		FK_SC_GROUP_DAY_SC_TCHNG_SLOT1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scTchngSlotToId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupDay objects.</returns>
		/// <remarks></remarks>
		public TList<ScGroupDay> GetByScTchngSlotToId(TransactionManager transactionManager, System.Decimal? _scTchngSlotToId)
		{
			int count = -1;
			return GetByScTchngSlotToId(transactionManager, _scTchngSlotToId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_DAY_SC_TCHNG_SLOT1 key.
		///		FK_SC_GROUP_DAY_SC_TCHNG_SLOT1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scTchngSlotToId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupDay objects.</returns>
		public TList<ScGroupDay> GetByScTchngSlotToId(TransactionManager transactionManager, System.Decimal? _scTchngSlotToId, int start, int pageLength)
		{
			int count = -1;
			return GetByScTchngSlotToId(transactionManager, _scTchngSlotToId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_DAY_SC_TCHNG_SLOT1 key.
		///		fkScGroupDayScTchngSlot1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scTchngSlotToId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupDay objects.</returns>
		public TList<ScGroupDay> GetByScTchngSlotToId(System.Decimal? _scTchngSlotToId, int start, int pageLength)
		{
			int count =  -1;
			return GetByScTchngSlotToId(null, _scTchngSlotToId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_DAY_SC_TCHNG_SLOT1 key.
		///		fkScGroupDayScTchngSlot1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scTchngSlotToId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupDay objects.</returns>
		public TList<ScGroupDay> GetByScTchngSlotToId(System.Decimal? _scTchngSlotToId, int start, int pageLength,out int count)
		{
			return GetByScTchngSlotToId(null, _scTchngSlotToId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_GROUP_DAY_SC_TCHNG_SLOT1 key.
		///		FK_SC_GROUP_DAY_SC_TCHNG_SLOT1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scTchngSlotToId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScGroupDay objects.</returns>
		public abstract TList<ScGroupDay> GetByScTchngSlotToId(TransactionManager transactionManager, System.Decimal? _scTchngSlotToId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.ScGroupDay Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScGroupDayKey key, int start, int pageLength)
		{
			return GetByScGroupDayId(transactionManager, key.ScGroupDayId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SC_GROUP_DAYS index.
		/// </summary>
		/// <param name="_scGroupDayId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScGroupDay"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScGroupDay GetByScGroupDayId(System.Decimal _scGroupDayId)
		{
			int count = -1;
			return GetByScGroupDayId(null,_scGroupDayId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_GROUP_DAYS index.
		/// </summary>
		/// <param name="_scGroupDayId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScGroupDay"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScGroupDay GetByScGroupDayId(System.Decimal _scGroupDayId, int start, int pageLength)
		{
			int count = -1;
			return GetByScGroupDayId(null, _scGroupDayId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_GROUP_DAYS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scGroupDayId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScGroupDay"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScGroupDay GetByScGroupDayId(TransactionManager transactionManager, System.Decimal _scGroupDayId)
		{
			int count = -1;
			return GetByScGroupDayId(transactionManager, _scGroupDayId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_GROUP_DAYS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scGroupDayId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScGroupDay"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScGroupDay GetByScGroupDayId(TransactionManager transactionManager, System.Decimal _scGroupDayId, int start, int pageLength)
		{
			int count = -1;
			return GetByScGroupDayId(transactionManager, _scGroupDayId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_GROUP_DAYS index.
		/// </summary>
		/// <param name="_scGroupDayId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScGroupDay"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScGroupDay GetByScGroupDayId(System.Decimal _scGroupDayId, int start, int pageLength, out int count)
		{
			return GetByScGroupDayId(null, _scGroupDayId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_GROUP_DAYS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scGroupDayId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScGroupDay"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.ScGroupDay GetByScGroupDayId(TransactionManager transactionManager, System.Decimal _scGroupDayId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;ScGroupDay&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;ScGroupDay&gt;"/></returns>
		public static TList<ScGroupDay> Fill(IDataReader reader, TList<ScGroupDay> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.ScGroupDay c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("ScGroupDay")
					.Append("|").Append((System.Decimal)reader["SC_GROUP_DAY_ID"]).ToString();
					c = EntityManager.LocateOrCreate<ScGroupDay>(
					key.ToString(), // EntityTrackingKey
					"ScGroupDay",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.ScGroupDay();
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
					c.ScGroupDayId = (System.Decimal)reader["SC_GROUP_DAY_ID"];
					c.OriginalScGroupDayId = c.ScGroupDayId;
					c.ScGroupInfoId = (System.Decimal)reader["SC_GROUP_INFO_ID"];
					c.ScTchngDayId = (System.Decimal)reader["SC_TCHNG_DAY_ID"];
					c.ScTchngSlotFrmId = Convert.IsDBNull(reader["SC_TCHNG_SLOT_FRM_ID"]) ? null : (System.Decimal?)reader["SC_TCHNG_SLOT_FRM_ID"];
					c.ScTchngSlotToId = Convert.IsDBNull(reader["SC_TCHNG_SLOT_TO_ID"]) ? null : (System.Decimal?)reader["SC_TCHNG_SLOT_TO_ID"];
					c.EdCourseId = Convert.IsDBNull(reader["ED_COURSE_ID"]) ? null : (System.Decimal?)reader["ED_COURSE_ID"];
					c.EdCdeTchngMthdId = Convert.IsDBNull(reader["ED_CDE_TCHNG_MTHD_ID"]) ? null : (System.Decimal?)reader["ED_CDE_TCHNG_MTHD_ID"];
					c.ScBuildingId = Convert.IsDBNull(reader["SC_BUILDING_ID"]) ? null : (System.Decimal?)reader["SC_BUILDING_ID"];
					c.ScHallId = Convert.IsDBNull(reader["SC_HALL_ID"]) ? null : (System.Decimal?)reader["SC_HALL_ID"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
					c.CourseTopic = Convert.IsDBNull(reader["COURSE_TOPIC"]) ? null : (System.String)reader["COURSE_TOPIC"];
					c.GroupId = Convert.IsDBNull(reader["GROUP_ID"]) ? null : (System.Decimal?)reader["GROUP_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.ScGroupDay"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScGroupDay"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.ScGroupDay entity)
		{
			if (!reader.Read()) return;
			
			entity.ScGroupDayId = (System.Decimal)reader[((int)ScGroupDayColumn.ScGroupDayId - 1)];
			entity.OriginalScGroupDayId = (System.Decimal)reader["SC_GROUP_DAY_ID"];
			entity.ScGroupInfoId = (System.Decimal)reader[((int)ScGroupDayColumn.ScGroupInfoId - 1)];
			entity.ScTchngDayId = (System.Decimal)reader[((int)ScGroupDayColumn.ScTchngDayId - 1)];
			entity.ScTchngSlotFrmId = (reader.IsDBNull(((int)ScGroupDayColumn.ScTchngSlotFrmId - 1)))?null:(System.Decimal?)reader[((int)ScGroupDayColumn.ScTchngSlotFrmId - 1)];
			entity.ScTchngSlotToId = (reader.IsDBNull(((int)ScGroupDayColumn.ScTchngSlotToId - 1)))?null:(System.Decimal?)reader[((int)ScGroupDayColumn.ScTchngSlotToId - 1)];
			entity.EdCourseId = (reader.IsDBNull(((int)ScGroupDayColumn.EdCourseId - 1)))?null:(System.Decimal?)reader[((int)ScGroupDayColumn.EdCourseId - 1)];
			entity.EdCdeTchngMthdId = (reader.IsDBNull(((int)ScGroupDayColumn.EdCdeTchngMthdId - 1)))?null:(System.Decimal?)reader[((int)ScGroupDayColumn.EdCdeTchngMthdId - 1)];
			entity.ScBuildingId = (reader.IsDBNull(((int)ScGroupDayColumn.ScBuildingId - 1)))?null:(System.Decimal?)reader[((int)ScGroupDayColumn.ScBuildingId - 1)];
			entity.ScHallId = (reader.IsDBNull(((int)ScGroupDayColumn.ScHallId - 1)))?null:(System.Decimal?)reader[((int)ScGroupDayColumn.ScHallId - 1)];
			entity.Notes = (reader.IsDBNull(((int)ScGroupDayColumn.Notes - 1)))?null:(System.String)reader[((int)ScGroupDayColumn.Notes - 1)];
			entity.CourseTopic = (reader.IsDBNull(((int)ScGroupDayColumn.CourseTopic - 1)))?null:(System.String)reader[((int)ScGroupDayColumn.CourseTopic - 1)];
			entity.GroupId = (reader.IsDBNull(((int)ScGroupDayColumn.GroupId - 1)))?null:(System.Decimal?)reader[((int)ScGroupDayColumn.GroupId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.ScGroupDay"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScGroupDay"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.ScGroupDay entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.ScGroupDayId = (System.Decimal)dataRow["SC_GROUP_DAY_ID"];
			entity.OriginalScGroupDayId = (System.Decimal)dataRow["SC_GROUP_DAY_ID"];
			entity.ScGroupInfoId = (System.Decimal)dataRow["SC_GROUP_INFO_ID"];
			entity.ScTchngDayId = (System.Decimal)dataRow["SC_TCHNG_DAY_ID"];
			entity.ScTchngSlotFrmId = Convert.IsDBNull(dataRow["SC_TCHNG_SLOT_FRM_ID"]) ? null : (System.Decimal?)dataRow["SC_TCHNG_SLOT_FRM_ID"];
			entity.ScTchngSlotToId = Convert.IsDBNull(dataRow["SC_TCHNG_SLOT_TO_ID"]) ? null : (System.Decimal?)dataRow["SC_TCHNG_SLOT_TO_ID"];
			entity.EdCourseId = Convert.IsDBNull(dataRow["ED_COURSE_ID"]) ? null : (System.Decimal?)dataRow["ED_COURSE_ID"];
			entity.EdCdeTchngMthdId = Convert.IsDBNull(dataRow["ED_CDE_TCHNG_MTHD_ID"]) ? null : (System.Decimal?)dataRow["ED_CDE_TCHNG_MTHD_ID"];
			entity.ScBuildingId = Convert.IsDBNull(dataRow["SC_BUILDING_ID"]) ? null : (System.Decimal?)dataRow["SC_BUILDING_ID"];
			entity.ScHallId = Convert.IsDBNull(dataRow["SC_HALL_ID"]) ? null : (System.Decimal?)dataRow["SC_HALL_ID"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
			entity.CourseTopic = Convert.IsDBNull(dataRow["COURSE_TOPIC"]) ? null : (System.String)dataRow["COURSE_TOPIC"];
			entity.GroupId = Convert.IsDBNull(dataRow["GROUP_ID"]) ? null : (System.Decimal?)dataRow["GROUP_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScGroupDay"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.ScGroupDay Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScGroupDay entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdCdeTchngMthdIdSource	
			if (CanDeepLoad(entity, "EdCdeTchngMthd|EdCdeTchngMthdIdSource", deepLoadType, innerList) 
				&& entity.EdCdeTchngMthdIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCdeTchngMthdId ?? 0.0m);
				EdCdeTchngMthd tmpEntity = EntityManager.LocateEntity<EdCdeTchngMthd>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCdeTchngMthd), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCdeTchngMthdIdSource = tmpEntity;
				else
					entity.EdCdeTchngMthdIdSource = DataRepository.EdCdeTchngMthdProvider.GetByEdCdeTchngMthdId(transactionManager, (entity.EdCdeTchngMthdId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCdeTchngMthdIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCdeTchngMthdIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCdeTchngMthdProvider.DeepLoad(transactionManager, entity.EdCdeTchngMthdIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCdeTchngMthdIdSource

			#region EdCourseIdSource	
			if (CanDeepLoad(entity, "EdCourse|EdCourseIdSource", deepLoadType, innerList) 
				&& entity.EdCourseIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCourseId ?? 0.0m);
				EdCourse tmpEntity = EntityManager.LocateEntity<EdCourse>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCourse), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCourseIdSource = tmpEntity;
				else
					entity.EdCourseIdSource = DataRepository.EdCourseProvider.GetByEdCourseId(transactionManager, (entity.EdCourseId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCourseIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCourseIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCourseProvider.DeepLoad(transactionManager, entity.EdCourseIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCourseIdSource

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

			#region ScGroupInfoIdSource	
			if (CanDeepLoad(entity, "ScGroupInfo|ScGroupInfoIdSource", deepLoadType, innerList) 
				&& entity.ScGroupInfoIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.ScGroupInfoId;
				ScGroupInfo tmpEntity = EntityManager.LocateEntity<ScGroupInfo>(EntityLocator.ConstructKeyFromPkItems(typeof(ScGroupInfo), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.ScGroupInfoIdSource = tmpEntity;
				else
					entity.ScGroupInfoIdSource = DataRepository.ScGroupInfoProvider.GetByScGroupInfoId(transactionManager, entity.ScGroupInfoId);		
				
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

			#region ScTchngDayIdSource	
			if (CanDeepLoad(entity, "ScTchngDay|ScTchngDayIdSource", deepLoadType, innerList) 
				&& entity.ScTchngDayIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.ScTchngDayId;
				ScTchngDay tmpEntity = EntityManager.LocateEntity<ScTchngDay>(EntityLocator.ConstructKeyFromPkItems(typeof(ScTchngDay), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.ScTchngDayIdSource = tmpEntity;
				else
					entity.ScTchngDayIdSource = DataRepository.ScTchngDayProvider.GetByScTchngDayId(transactionManager, entity.ScTchngDayId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScTchngDayIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.ScTchngDayIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.ScTchngDayProvider.DeepLoad(transactionManager, entity.ScTchngDayIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion ScTchngDayIdSource

			#region ScTchngSlotFrmIdSource	
			if (CanDeepLoad(entity, "ScTchngSlot|ScTchngSlotFrmIdSource", deepLoadType, innerList) 
				&& entity.ScTchngSlotFrmIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.ScTchngSlotFrmId ?? 0.0m);
				ScTchngSlot tmpEntity = EntityManager.LocateEntity<ScTchngSlot>(EntityLocator.ConstructKeyFromPkItems(typeof(ScTchngSlot), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.ScTchngSlotFrmIdSource = tmpEntity;
				else
					entity.ScTchngSlotFrmIdSource = DataRepository.ScTchngSlotProvider.GetByScTchngSlotId(transactionManager, (entity.ScTchngSlotFrmId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScTchngSlotFrmIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.ScTchngSlotFrmIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.ScTchngSlotProvider.DeepLoad(transactionManager, entity.ScTchngSlotFrmIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion ScTchngSlotFrmIdSource

			#region ScTchngSlotToIdSource	
			if (CanDeepLoad(entity, "ScTchngSlot|ScTchngSlotToIdSource", deepLoadType, innerList) 
				&& entity.ScTchngSlotToIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.ScTchngSlotToId ?? 0.0m);
				ScTchngSlot tmpEntity = EntityManager.LocateEntity<ScTchngSlot>(EntityLocator.ConstructKeyFromPkItems(typeof(ScTchngSlot), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.ScTchngSlotToIdSource = tmpEntity;
				else
					entity.ScTchngSlotToIdSource = DataRepository.ScTchngSlotProvider.GetByScTchngSlotId(transactionManager, (entity.ScTchngSlotToId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScTchngSlotToIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.ScTchngSlotToIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.ScTchngSlotProvider.DeepLoad(transactionManager, entity.ScTchngSlotToIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion ScTchngSlotToIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByScGroupDayId methods when available
			
			#region ScGroupStaffCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ScGroupStaff>|ScGroupStaffCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScGroupStaffCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ScGroupStaffCollection = DataRepository.ScGroupStaffProvider.GetByScGroupDayId(transactionManager, entity.ScGroupDayId);

				if (deep && entity.ScGroupStaffCollection.Count > 0)
				{
					deepHandles.Add("ScGroupStaffCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScGroupStaff>) DataRepository.ScGroupStaffProvider.DeepLoad,
						new object[] { transactionManager, entity.ScGroupStaffCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.ScGroupDay object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.ScGroupDay instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.ScGroupDay Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScGroupDay entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdCdeTchngMthdIdSource
			if (CanDeepSave(entity, "EdCdeTchngMthd|EdCdeTchngMthdIdSource", deepSaveType, innerList) 
				&& entity.EdCdeTchngMthdIdSource != null)
			{
				DataRepository.EdCdeTchngMthdProvider.Save(transactionManager, entity.EdCdeTchngMthdIdSource);
				entity.EdCdeTchngMthdId = entity.EdCdeTchngMthdIdSource.EdCdeTchngMthdId;
			}
			#endregion 
			
			#region EdCourseIdSource
			if (CanDeepSave(entity, "EdCourse|EdCourseIdSource", deepSaveType, innerList) 
				&& entity.EdCourseIdSource != null)
			{
				DataRepository.EdCourseProvider.Save(transactionManager, entity.EdCourseIdSource);
				entity.EdCourseId = entity.EdCourseIdSource.EdCourseId;
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
			
			#region ScGroupInfoIdSource
			if (CanDeepSave(entity, "ScGroupInfo|ScGroupInfoIdSource", deepSaveType, innerList) 
				&& entity.ScGroupInfoIdSource != null)
			{
				DataRepository.ScGroupInfoProvider.Save(transactionManager, entity.ScGroupInfoIdSource);
				entity.ScGroupInfoId = entity.ScGroupInfoIdSource.ScGroupInfoId;
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
			
			#region ScTchngDayIdSource
			if (CanDeepSave(entity, "ScTchngDay|ScTchngDayIdSource", deepSaveType, innerList) 
				&& entity.ScTchngDayIdSource != null)
			{
				DataRepository.ScTchngDayProvider.Save(transactionManager, entity.ScTchngDayIdSource);
				entity.ScTchngDayId = entity.ScTchngDayIdSource.ScTchngDayId;
			}
			#endregion 
			
			#region ScTchngSlotFrmIdSource
			if (CanDeepSave(entity, "ScTchngSlot|ScTchngSlotFrmIdSource", deepSaveType, innerList) 
				&& entity.ScTchngSlotFrmIdSource != null)
			{
				DataRepository.ScTchngSlotProvider.Save(transactionManager, entity.ScTchngSlotFrmIdSource);
				entity.ScTchngSlotFrmId = entity.ScTchngSlotFrmIdSource.ScTchngSlotId;
			}
			#endregion 
			
			#region ScTchngSlotToIdSource
			if (CanDeepSave(entity, "ScTchngSlot|ScTchngSlotToIdSource", deepSaveType, innerList) 
				&& entity.ScTchngSlotToIdSource != null)
			{
				DataRepository.ScTchngSlotProvider.Save(transactionManager, entity.ScTchngSlotToIdSource);
				entity.ScTchngSlotToId = entity.ScTchngSlotToIdSource.ScTchngSlotId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<ScGroupStaff>
				if (CanDeepSave(entity.ScGroupStaffCollection, "List<ScGroupStaff>|ScGroupStaffCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScGroupStaff child in entity.ScGroupStaffCollection)
					{
						if(child.ScGroupDayIdSource != null)
						{
							child.ScGroupDayId = child.ScGroupDayIdSource.ScGroupDayId;
						}
						else
						{
							child.ScGroupDayId = entity.ScGroupDayId;
						}

					}

					if (entity.ScGroupStaffCollection.Count > 0 || entity.ScGroupStaffCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ScGroupStaffProvider.Save(transactionManager, entity.ScGroupStaffCollection);
						
						deepHandles.Add("ScGroupStaffCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ScGroupStaff >) DataRepository.ScGroupStaffProvider.DeepSave,
							new object[] { transactionManager, entity.ScGroupStaffCollection, deepSaveType, childTypes, innerList }
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
	
	#region ScGroupDayChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.ScGroupDay</c>
	///</summary>
	public enum ScGroupDayChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdCdeTchngMthd</c> at EdCdeTchngMthdIdSource
		///</summary>
		[ChildEntityType(typeof(EdCdeTchngMthd))]
		EdCdeTchngMthd,
		
		///<summary>
		/// Composite Property for <c>EdCourse</c> at EdCourseIdSource
		///</summary>
		[ChildEntityType(typeof(EdCourse))]
		EdCourse,
		
		///<summary>
		/// Composite Property for <c>ScBuilding</c> at ScBuildingIdSource
		///</summary>
		[ChildEntityType(typeof(ScBuilding))]
		ScBuilding,
		
		///<summary>
		/// Composite Property for <c>ScGroupInfo</c> at ScGroupInfoIdSource
		///</summary>
		[ChildEntityType(typeof(ScGroupInfo))]
		ScGroupInfo,
		
		///<summary>
		/// Composite Property for <c>ScHall</c> at ScHallIdSource
		///</summary>
		[ChildEntityType(typeof(ScHall))]
		ScHall,
		
		///<summary>
		/// Composite Property for <c>ScTchngDay</c> at ScTchngDayIdSource
		///</summary>
		[ChildEntityType(typeof(ScTchngDay))]
		ScTchngDay,
		
		///<summary>
		/// Composite Property for <c>ScTchngSlot</c> at ScTchngSlotFrmIdSource
		///</summary>
		[ChildEntityType(typeof(ScTchngSlot))]
		ScTchngSlot,
		///<summary>
		/// Collection of <c>ScGroupDay</c> as OneToMany for ScGroupStaffCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScGroupStaff>))]
		ScGroupStaffCollection,
	}
	
	#endregion ScGroupDayChildEntityTypes
	
	#region ScGroupDayFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;ScGroupDayColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScGroupDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ScGroupDayFilterBuilder : SqlFilterBuilder<ScGroupDayColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScGroupDayFilterBuilder class.
		/// </summary>
		public ScGroupDayFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ScGroupDayFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ScGroupDayFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ScGroupDayFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ScGroupDayFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ScGroupDayFilterBuilder
	
	#region ScGroupDayParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;ScGroupDayColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScGroupDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ScGroupDayParameterBuilder : ParameterizedSqlFilterBuilder<ScGroupDayColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScGroupDayParameterBuilder class.
		/// </summary>
		public ScGroupDayParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ScGroupDayParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ScGroupDayParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ScGroupDayParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ScGroupDayParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ScGroupDayParameterBuilder
	
	#region ScGroupDaySortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;ScGroupDayColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScGroupDay"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ScGroupDaySortBuilder : SqlSortBuilder<ScGroupDayColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScGroupDaySqlSortBuilder class.
		/// </summary>
		public ScGroupDaySortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ScGroupDaySortBuilder
	
} // end namespace
