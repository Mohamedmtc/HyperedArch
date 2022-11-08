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
	/// This class is the base class for any <see cref="CoExamSchdlPlaceProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class CoExamSchdlPlaceProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.CoExamSchdlPlace, UMIS_VER2.BusinessLyer.CoExamSchdlPlaceKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CoExamSchdlPlaceKey key)
		{
			return Delete(transactionManager, key.CoExamSchdlPlaceId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_coExamSchdlPlaceId">اماكن الامتحان - لجان الامتحان. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _coExamSchdlPlaceId)
		{
			return Delete(null, _coExamSchdlPlaceId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coExamSchdlPlaceId">اماكن الامتحان - لجان الامتحان. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _coExamSchdlPlaceId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_EXAM_SCHDL_PLACE_CO_EXAM_COMMITTEE key.
		///		FK_CO_EXAM_SCHDL_PLACE_CO_EXAM_COMMITTEE Description: 
		/// </summary>
		/// <param name="_coExamCommitteeId">لجان الامتحان</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoExamSchdlPlace objects.</returns>
		public TList<CoExamSchdlPlace> GetByCoExamCommitteeId(System.Decimal? _coExamCommitteeId)
		{
			int count = -1;
			return GetByCoExamCommitteeId(_coExamCommitteeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_EXAM_SCHDL_PLACE_CO_EXAM_COMMITTEE key.
		///		FK_CO_EXAM_SCHDL_PLACE_CO_EXAM_COMMITTEE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coExamCommitteeId">لجان الامتحان</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoExamSchdlPlace objects.</returns>
		/// <remarks></remarks>
		public TList<CoExamSchdlPlace> GetByCoExamCommitteeId(TransactionManager transactionManager, System.Decimal? _coExamCommitteeId)
		{
			int count = -1;
			return GetByCoExamCommitteeId(transactionManager, _coExamCommitteeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_EXAM_SCHDL_PLACE_CO_EXAM_COMMITTEE key.
		///		FK_CO_EXAM_SCHDL_PLACE_CO_EXAM_COMMITTEE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coExamCommitteeId">لجان الامتحان</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoExamSchdlPlace objects.</returns>
		public TList<CoExamSchdlPlace> GetByCoExamCommitteeId(TransactionManager transactionManager, System.Decimal? _coExamCommitteeId, int start, int pageLength)
		{
			int count = -1;
			return GetByCoExamCommitteeId(transactionManager, _coExamCommitteeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_EXAM_SCHDL_PLACE_CO_EXAM_COMMITTEE key.
		///		fkCoExamSchdlPlaceCoExamCommittee Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_coExamCommitteeId">لجان الامتحان</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoExamSchdlPlace objects.</returns>
		public TList<CoExamSchdlPlace> GetByCoExamCommitteeId(System.Decimal? _coExamCommitteeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByCoExamCommitteeId(null, _coExamCommitteeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_EXAM_SCHDL_PLACE_CO_EXAM_COMMITTEE key.
		///		fkCoExamSchdlPlaceCoExamCommittee Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_coExamCommitteeId">لجان الامتحان</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoExamSchdlPlace objects.</returns>
		public TList<CoExamSchdlPlace> GetByCoExamCommitteeId(System.Decimal? _coExamCommitteeId, int start, int pageLength,out int count)
		{
			return GetByCoExamCommitteeId(null, _coExamCommitteeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_EXAM_SCHDL_PLACE_CO_EXAM_COMMITTEE key.
		///		FK_CO_EXAM_SCHDL_PLACE_CO_EXAM_COMMITTEE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coExamCommitteeId">لجان الامتحان</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoExamSchdlPlace objects.</returns>
		public abstract TList<CoExamSchdlPlace> GetByCoExamCommitteeId(TransactionManager transactionManager, System.Decimal? _coExamCommitteeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_EXAM_SCHDL_PLACE_ED_EXAM_SCHDL key.
		///		FK_CO_EXAM_SCHDL_PLACE_ED_EXAM_SCHDL Description: 
		/// </summary>
		/// <param name="_edExamSchdlId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoExamSchdlPlace objects.</returns>
		public TList<CoExamSchdlPlace> GetByEdExamSchdlId(System.Decimal _edExamSchdlId)
		{
			int count = -1;
			return GetByEdExamSchdlId(_edExamSchdlId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_EXAM_SCHDL_PLACE_ED_EXAM_SCHDL key.
		///		FK_CO_EXAM_SCHDL_PLACE_ED_EXAM_SCHDL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edExamSchdlId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoExamSchdlPlace objects.</returns>
		/// <remarks></remarks>
		public TList<CoExamSchdlPlace> GetByEdExamSchdlId(TransactionManager transactionManager, System.Decimal _edExamSchdlId)
		{
			int count = -1;
			return GetByEdExamSchdlId(transactionManager, _edExamSchdlId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_EXAM_SCHDL_PLACE_ED_EXAM_SCHDL key.
		///		FK_CO_EXAM_SCHDL_PLACE_ED_EXAM_SCHDL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edExamSchdlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoExamSchdlPlace objects.</returns>
		public TList<CoExamSchdlPlace> GetByEdExamSchdlId(TransactionManager transactionManager, System.Decimal _edExamSchdlId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdExamSchdlId(transactionManager, _edExamSchdlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_EXAM_SCHDL_PLACE_ED_EXAM_SCHDL key.
		///		fkCoExamSchdlPlaceEdExamSchdl Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edExamSchdlId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoExamSchdlPlace objects.</returns>
		public TList<CoExamSchdlPlace> GetByEdExamSchdlId(System.Decimal _edExamSchdlId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdExamSchdlId(null, _edExamSchdlId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_EXAM_SCHDL_PLACE_ED_EXAM_SCHDL key.
		///		fkCoExamSchdlPlaceEdExamSchdl Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edExamSchdlId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoExamSchdlPlace objects.</returns>
		public TList<CoExamSchdlPlace> GetByEdExamSchdlId(System.Decimal _edExamSchdlId, int start, int pageLength,out int count)
		{
			return GetByEdExamSchdlId(null, _edExamSchdlId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_EXAM_SCHDL_PLACE_ED_EXAM_SCHDL key.
		///		FK_CO_EXAM_SCHDL_PLACE_ED_EXAM_SCHDL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edExamSchdlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoExamSchdlPlace objects.</returns>
		public abstract TList<CoExamSchdlPlace> GetByEdExamSchdlId(TransactionManager transactionManager, System.Decimal _edExamSchdlId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_EXAM_SCHDL_PLACE_SC_BUILDING key.
		///		FK_CO_EXAM_SCHDL_PLACE_SC_BUILDING Description: 
		/// </summary>
		/// <param name="_scBuildingId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoExamSchdlPlace objects.</returns>
		public TList<CoExamSchdlPlace> GetByScBuildingId(System.Decimal? _scBuildingId)
		{
			int count = -1;
			return GetByScBuildingId(_scBuildingId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_EXAM_SCHDL_PLACE_SC_BUILDING key.
		///		FK_CO_EXAM_SCHDL_PLACE_SC_BUILDING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scBuildingId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoExamSchdlPlace objects.</returns>
		/// <remarks></remarks>
		public TList<CoExamSchdlPlace> GetByScBuildingId(TransactionManager transactionManager, System.Decimal? _scBuildingId)
		{
			int count = -1;
			return GetByScBuildingId(transactionManager, _scBuildingId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_EXAM_SCHDL_PLACE_SC_BUILDING key.
		///		FK_CO_EXAM_SCHDL_PLACE_SC_BUILDING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scBuildingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoExamSchdlPlace objects.</returns>
		public TList<CoExamSchdlPlace> GetByScBuildingId(TransactionManager transactionManager, System.Decimal? _scBuildingId, int start, int pageLength)
		{
			int count = -1;
			return GetByScBuildingId(transactionManager, _scBuildingId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_EXAM_SCHDL_PLACE_SC_BUILDING key.
		///		fkCoExamSchdlPlaceScBuilding Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scBuildingId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoExamSchdlPlace objects.</returns>
		public TList<CoExamSchdlPlace> GetByScBuildingId(System.Decimal? _scBuildingId, int start, int pageLength)
		{
			int count =  -1;
			return GetByScBuildingId(null, _scBuildingId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_EXAM_SCHDL_PLACE_SC_BUILDING key.
		///		fkCoExamSchdlPlaceScBuilding Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scBuildingId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoExamSchdlPlace objects.</returns>
		public TList<CoExamSchdlPlace> GetByScBuildingId(System.Decimal? _scBuildingId, int start, int pageLength,out int count)
		{
			return GetByScBuildingId(null, _scBuildingId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_EXAM_SCHDL_PLACE_SC_BUILDING key.
		///		FK_CO_EXAM_SCHDL_PLACE_SC_BUILDING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scBuildingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoExamSchdlPlace objects.</returns>
		public abstract TList<CoExamSchdlPlace> GetByScBuildingId(TransactionManager transactionManager, System.Decimal? _scBuildingId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_EXAM_SCHDL_PLACE_SC_HALL key.
		///		FK_CO_EXAM_SCHDL_PLACE_SC_HALL Description: 
		/// </summary>
		/// <param name="_scHallId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoExamSchdlPlace objects.</returns>
		public TList<CoExamSchdlPlace> GetByScHallId(System.Decimal? _scHallId)
		{
			int count = -1;
			return GetByScHallId(_scHallId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_EXAM_SCHDL_PLACE_SC_HALL key.
		///		FK_CO_EXAM_SCHDL_PLACE_SC_HALL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scHallId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoExamSchdlPlace objects.</returns>
		/// <remarks></remarks>
		public TList<CoExamSchdlPlace> GetByScHallId(TransactionManager transactionManager, System.Decimal? _scHallId)
		{
			int count = -1;
			return GetByScHallId(transactionManager, _scHallId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_EXAM_SCHDL_PLACE_SC_HALL key.
		///		FK_CO_EXAM_SCHDL_PLACE_SC_HALL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scHallId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoExamSchdlPlace objects.</returns>
		public TList<CoExamSchdlPlace> GetByScHallId(TransactionManager transactionManager, System.Decimal? _scHallId, int start, int pageLength)
		{
			int count = -1;
			return GetByScHallId(transactionManager, _scHallId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_EXAM_SCHDL_PLACE_SC_HALL key.
		///		fkCoExamSchdlPlaceScHall Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scHallId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoExamSchdlPlace objects.</returns>
		public TList<CoExamSchdlPlace> GetByScHallId(System.Decimal? _scHallId, int start, int pageLength)
		{
			int count =  -1;
			return GetByScHallId(null, _scHallId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_EXAM_SCHDL_PLACE_SC_HALL key.
		///		fkCoExamSchdlPlaceScHall Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scHallId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoExamSchdlPlace objects.</returns>
		public TList<CoExamSchdlPlace> GetByScHallId(System.Decimal? _scHallId, int start, int pageLength,out int count)
		{
			return GetByScHallId(null, _scHallId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_EXAM_SCHDL_PLACE_SC_HALL key.
		///		FK_CO_EXAM_SCHDL_PLACE_SC_HALL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scHallId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoExamSchdlPlace objects.</returns>
		public abstract TList<CoExamSchdlPlace> GetByScHallId(TransactionManager transactionManager, System.Decimal? _scHallId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_EXAM_SCHDL_PLACE_SC_SCHEDULE_DTL key.
		///		FK_CO_EXAM_SCHDL_PLACE_SC_SCHEDULE_DTL Description: 
		/// </summary>
		/// <param name="_scScheduleDtlId">XXOLDUOBXX</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoExamSchdlPlace objects.</returns>
		public TList<CoExamSchdlPlace> GetByScScheduleDtlId(System.Decimal? _scScheduleDtlId)
		{
			int count = -1;
			return GetByScScheduleDtlId(_scScheduleDtlId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_EXAM_SCHDL_PLACE_SC_SCHEDULE_DTL key.
		///		FK_CO_EXAM_SCHDL_PLACE_SC_SCHEDULE_DTL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleDtlId">XXOLDUOBXX</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoExamSchdlPlace objects.</returns>
		/// <remarks></remarks>
		public TList<CoExamSchdlPlace> GetByScScheduleDtlId(TransactionManager transactionManager, System.Decimal? _scScheduleDtlId)
		{
			int count = -1;
			return GetByScScheduleDtlId(transactionManager, _scScheduleDtlId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_EXAM_SCHDL_PLACE_SC_SCHEDULE_DTL key.
		///		FK_CO_EXAM_SCHDL_PLACE_SC_SCHEDULE_DTL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleDtlId">XXOLDUOBXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoExamSchdlPlace objects.</returns>
		public TList<CoExamSchdlPlace> GetByScScheduleDtlId(TransactionManager transactionManager, System.Decimal? _scScheduleDtlId, int start, int pageLength)
		{
			int count = -1;
			return GetByScScheduleDtlId(transactionManager, _scScheduleDtlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_EXAM_SCHDL_PLACE_SC_SCHEDULE_DTL key.
		///		fkCoExamSchdlPlaceScScheduleDtl Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scScheduleDtlId">XXOLDUOBXX</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoExamSchdlPlace objects.</returns>
		public TList<CoExamSchdlPlace> GetByScScheduleDtlId(System.Decimal? _scScheduleDtlId, int start, int pageLength)
		{
			int count =  -1;
			return GetByScScheduleDtlId(null, _scScheduleDtlId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_EXAM_SCHDL_PLACE_SC_SCHEDULE_DTL key.
		///		fkCoExamSchdlPlaceScScheduleDtl Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scScheduleDtlId">XXOLDUOBXX</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoExamSchdlPlace objects.</returns>
		public TList<CoExamSchdlPlace> GetByScScheduleDtlId(System.Decimal? _scScheduleDtlId, int start, int pageLength,out int count)
		{
			return GetByScScheduleDtlId(null, _scScheduleDtlId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CO_EXAM_SCHDL_PLACE_SC_SCHEDULE_DTL key.
		///		FK_CO_EXAM_SCHDL_PLACE_SC_SCHEDULE_DTL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleDtlId">XXOLDUOBXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CoExamSchdlPlace objects.</returns>
		public abstract TList<CoExamSchdlPlace> GetByScScheduleDtlId(TransactionManager transactionManager, System.Decimal? _scScheduleDtlId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.CoExamSchdlPlace Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CoExamSchdlPlaceKey key, int start, int pageLength)
		{
			return GetByCoExamSchdlPlaceId(transactionManager, key.CoExamSchdlPlaceId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_CO_EXAM_SCHDL_PLACE index.
		/// </summary>
		/// <param name="_coExamSchdlPlaceId">اماكن الامتحان - لجان الامتحان</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoExamSchdlPlace"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoExamSchdlPlace GetByCoExamSchdlPlaceId(System.Decimal _coExamSchdlPlaceId)
		{
			int count = -1;
			return GetByCoExamSchdlPlaceId(null,_coExamSchdlPlaceId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_EXAM_SCHDL_PLACE index.
		/// </summary>
		/// <param name="_coExamSchdlPlaceId">اماكن الامتحان - لجان الامتحان</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoExamSchdlPlace"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoExamSchdlPlace GetByCoExamSchdlPlaceId(System.Decimal _coExamSchdlPlaceId, int start, int pageLength)
		{
			int count = -1;
			return GetByCoExamSchdlPlaceId(null, _coExamSchdlPlaceId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_EXAM_SCHDL_PLACE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coExamSchdlPlaceId">اماكن الامتحان - لجان الامتحان</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoExamSchdlPlace"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoExamSchdlPlace GetByCoExamSchdlPlaceId(TransactionManager transactionManager, System.Decimal _coExamSchdlPlaceId)
		{
			int count = -1;
			return GetByCoExamSchdlPlaceId(transactionManager, _coExamSchdlPlaceId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_EXAM_SCHDL_PLACE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coExamSchdlPlaceId">اماكن الامتحان - لجان الامتحان</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoExamSchdlPlace"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoExamSchdlPlace GetByCoExamSchdlPlaceId(TransactionManager transactionManager, System.Decimal _coExamSchdlPlaceId, int start, int pageLength)
		{
			int count = -1;
			return GetByCoExamSchdlPlaceId(transactionManager, _coExamSchdlPlaceId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_EXAM_SCHDL_PLACE index.
		/// </summary>
		/// <param name="_coExamSchdlPlaceId">اماكن الامتحان - لجان الامتحان</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoExamSchdlPlace"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoExamSchdlPlace GetByCoExamSchdlPlaceId(System.Decimal _coExamSchdlPlaceId, int start, int pageLength, out int count)
		{
			return GetByCoExamSchdlPlaceId(null, _coExamSchdlPlaceId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_EXAM_SCHDL_PLACE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coExamSchdlPlaceId">اماكن الامتحان - لجان الامتحان</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoExamSchdlPlace"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.CoExamSchdlPlace GetByCoExamSchdlPlaceId(TransactionManager transactionManager, System.Decimal _coExamSchdlPlaceId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;CoExamSchdlPlace&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;CoExamSchdlPlace&gt;"/></returns>
		public static TList<CoExamSchdlPlace> Fill(IDataReader reader, TList<CoExamSchdlPlace> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.CoExamSchdlPlace c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("CoExamSchdlPlace")
					.Append("|").Append((System.Decimal)reader["CO_EXAM_SCHDL_PLACE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<CoExamSchdlPlace>(
					key.ToString(), // EntityTrackingKey
					"CoExamSchdlPlace",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.CoExamSchdlPlace();
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
					c.CoExamSchdlPlaceId = (System.Decimal)reader["CO_EXAM_SCHDL_PLACE_ID"];
					c.OriginalCoExamSchdlPlaceId = c.CoExamSchdlPlaceId;
					c.ScBuildingId = Convert.IsDBNull(reader["SC_BUILDING_ID"]) ? null : (System.Decimal?)reader["SC_BUILDING_ID"];
					c.ScHallId = Convert.IsDBNull(reader["SC_HALL_ID"]) ? null : (System.Decimal?)reader["SC_HALL_ID"];
					c.EdExamSchdlId = (System.Decimal)reader["ED_EXAM_SCHDL_ID"];
					c.StudCount = Convert.IsDBNull(reader["STUD_COUNT"]) ? null : (System.Decimal?)reader["STUD_COUNT"];
					c.ScScheduleDtlId = Convert.IsDBNull(reader["SC_SCHEDULE_DTL_ID"]) ? null : (System.Decimal?)reader["SC_SCHEDULE_DTL_ID"];
					c.CoExamCommitteeId = Convert.IsDBNull(reader["CO_EXAM_COMMITTEE_ID"]) ? null : (System.Decimal?)reader["CO_EXAM_COMMITTEE_ID"];
					c.SeatNumFrom = Convert.IsDBNull(reader["SEAT_NUM_FROM"]) ? null : (System.String)reader["SEAT_NUM_FROM"];
					c.SeatNumTo = Convert.IsDBNull(reader["SEAT_NUM_TO"]) ? null : (System.String)reader["SEAT_NUM_TO"];
					c.SeFormId = Convert.IsDBNull(reader["SE_FORM_ID"]) ? null : (System.Decimal?)reader["SE_FORM_ID"];
					c.LastDate = Convert.IsDBNull(reader["LAST_DATE"]) ? null : (System.DateTime?)reader["LAST_DATE"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.CoExamSchdlPlace"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CoExamSchdlPlace"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.CoExamSchdlPlace entity)
		{
			if (!reader.Read()) return;
			
			entity.CoExamSchdlPlaceId = (System.Decimal)reader[((int)CoExamSchdlPlaceColumn.CoExamSchdlPlaceId - 1)];
			entity.OriginalCoExamSchdlPlaceId = (System.Decimal)reader["CO_EXAM_SCHDL_PLACE_ID"];
			entity.ScBuildingId = (reader.IsDBNull(((int)CoExamSchdlPlaceColumn.ScBuildingId - 1)))?null:(System.Decimal?)reader[((int)CoExamSchdlPlaceColumn.ScBuildingId - 1)];
			entity.ScHallId = (reader.IsDBNull(((int)CoExamSchdlPlaceColumn.ScHallId - 1)))?null:(System.Decimal?)reader[((int)CoExamSchdlPlaceColumn.ScHallId - 1)];
			entity.EdExamSchdlId = (System.Decimal)reader[((int)CoExamSchdlPlaceColumn.EdExamSchdlId - 1)];
			entity.StudCount = (reader.IsDBNull(((int)CoExamSchdlPlaceColumn.StudCount - 1)))?null:(System.Decimal?)reader[((int)CoExamSchdlPlaceColumn.StudCount - 1)];
			entity.ScScheduleDtlId = (reader.IsDBNull(((int)CoExamSchdlPlaceColumn.ScScheduleDtlId - 1)))?null:(System.Decimal?)reader[((int)CoExamSchdlPlaceColumn.ScScheduleDtlId - 1)];
			entity.CoExamCommitteeId = (reader.IsDBNull(((int)CoExamSchdlPlaceColumn.CoExamCommitteeId - 1)))?null:(System.Decimal?)reader[((int)CoExamSchdlPlaceColumn.CoExamCommitteeId - 1)];
			entity.SeatNumFrom = (reader.IsDBNull(((int)CoExamSchdlPlaceColumn.SeatNumFrom - 1)))?null:(System.String)reader[((int)CoExamSchdlPlaceColumn.SeatNumFrom - 1)];
			entity.SeatNumTo = (reader.IsDBNull(((int)CoExamSchdlPlaceColumn.SeatNumTo - 1)))?null:(System.String)reader[((int)CoExamSchdlPlaceColumn.SeatNumTo - 1)];
			entity.SeFormId = (reader.IsDBNull(((int)CoExamSchdlPlaceColumn.SeFormId - 1)))?null:(System.Decimal?)reader[((int)CoExamSchdlPlaceColumn.SeFormId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)CoExamSchdlPlaceColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)CoExamSchdlPlaceColumn.LastDate - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)CoExamSchdlPlaceColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)CoExamSchdlPlaceColumn.SeUserId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.CoExamSchdlPlace"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CoExamSchdlPlace"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.CoExamSchdlPlace entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.CoExamSchdlPlaceId = (System.Decimal)dataRow["CO_EXAM_SCHDL_PLACE_ID"];
			entity.OriginalCoExamSchdlPlaceId = (System.Decimal)dataRow["CO_EXAM_SCHDL_PLACE_ID"];
			entity.ScBuildingId = Convert.IsDBNull(dataRow["SC_BUILDING_ID"]) ? null : (System.Decimal?)dataRow["SC_BUILDING_ID"];
			entity.ScHallId = Convert.IsDBNull(dataRow["SC_HALL_ID"]) ? null : (System.Decimal?)dataRow["SC_HALL_ID"];
			entity.EdExamSchdlId = (System.Decimal)dataRow["ED_EXAM_SCHDL_ID"];
			entity.StudCount = Convert.IsDBNull(dataRow["STUD_COUNT"]) ? null : (System.Decimal?)dataRow["STUD_COUNT"];
			entity.ScScheduleDtlId = Convert.IsDBNull(dataRow["SC_SCHEDULE_DTL_ID"]) ? null : (System.Decimal?)dataRow["SC_SCHEDULE_DTL_ID"];
			entity.CoExamCommitteeId = Convert.IsDBNull(dataRow["CO_EXAM_COMMITTEE_ID"]) ? null : (System.Decimal?)dataRow["CO_EXAM_COMMITTEE_ID"];
			entity.SeatNumFrom = Convert.IsDBNull(dataRow["SEAT_NUM_FROM"]) ? null : (System.String)dataRow["SEAT_NUM_FROM"];
			entity.SeatNumTo = Convert.IsDBNull(dataRow["SEAT_NUM_TO"]) ? null : (System.String)dataRow["SEAT_NUM_TO"];
			entity.SeFormId = Convert.IsDBNull(dataRow["SE_FORM_ID"]) ? null : (System.Decimal?)dataRow["SE_FORM_ID"];
			entity.LastDate = Convert.IsDBNull(dataRow["LAST_DATE"]) ? null : (System.DateTime?)dataRow["LAST_DATE"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CoExamSchdlPlace"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.CoExamSchdlPlace Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CoExamSchdlPlace entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region CoExamCommitteeIdSource	
			if (CanDeepLoad(entity, "CoExamCommittee|CoExamCommitteeIdSource", deepLoadType, innerList) 
				&& entity.CoExamCommitteeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.CoExamCommitteeId ?? 0.0m);
				CoExamCommittee tmpEntity = EntityManager.LocateEntity<CoExamCommittee>(EntityLocator.ConstructKeyFromPkItems(typeof(CoExamCommittee), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.CoExamCommitteeIdSource = tmpEntity;
				else
					entity.CoExamCommitteeIdSource = DataRepository.CoExamCommitteeProvider.GetByCoExamCommitteeId(transactionManager, (entity.CoExamCommitteeId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CoExamCommitteeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.CoExamCommitteeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.CoExamCommitteeProvider.DeepLoad(transactionManager, entity.CoExamCommitteeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion CoExamCommitteeIdSource

			#region EdExamSchdlIdSource	
			if (CanDeepLoad(entity, "EdExamSchdl|EdExamSchdlIdSource", deepLoadType, innerList) 
				&& entity.EdExamSchdlIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdExamSchdlId;
				EdExamSchdl tmpEntity = EntityManager.LocateEntity<EdExamSchdl>(EntityLocator.ConstructKeyFromPkItems(typeof(EdExamSchdl), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdExamSchdlIdSource = tmpEntity;
				else
					entity.EdExamSchdlIdSource = DataRepository.EdExamSchdlProvider.GetByEdExamSchdlId(transactionManager, entity.EdExamSchdlId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdExamSchdlIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdExamSchdlIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdExamSchdlProvider.DeepLoad(transactionManager, entity.EdExamSchdlIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdExamSchdlIdSource

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
				pkItems[0] = (entity.ScScheduleDtlId ?? 0.0m);
				ScScheduleDtl tmpEntity = EntityManager.LocateEntity<ScScheduleDtl>(EntityLocator.ConstructKeyFromPkItems(typeof(ScScheduleDtl), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.ScScheduleDtlIdSource = tmpEntity;
				else
					entity.ScScheduleDtlIdSource = DataRepository.ScScheduleDtlProvider.GetByScScheduleDtlId(transactionManager, (entity.ScScheduleDtlId ?? 0.0m));		
				
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
			// Deep load child collections  - Call GetByCoExamSchdlPlaceId methods when available
			
			#region CoExamCommSupervisorCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<CoExamCommSupervisor>|CoExamCommSupervisorCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CoExamCommSupervisorCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.CoExamCommSupervisorCollection = DataRepository.CoExamCommSupervisorProvider.GetByCoExamSchdlPlaceId(transactionManager, entity.CoExamSchdlPlaceId);

				if (deep && entity.CoExamCommSupervisorCollection.Count > 0)
				{
					deepHandles.Add("CoExamCommSupervisorCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CoExamCommSupervisor>) DataRepository.CoExamCommSupervisorProvider.DeepLoad,
						new object[] { transactionManager, entity.CoExamCommSupervisorCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region CoExamPlaceStudCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<CoExamPlaceStud>|CoExamPlaceStudCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CoExamPlaceStudCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.CoExamPlaceStudCollection = DataRepository.CoExamPlaceStudProvider.GetByCoExamSchdlPlaceId(transactionManager, entity.CoExamSchdlPlaceId);

				if (deep && entity.CoExamPlaceStudCollection.Count > 0)
				{
					deepHandles.Add("CoExamPlaceStudCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CoExamPlaceStud>) DataRepository.CoExamPlaceStudProvider.DeepLoad,
						new object[] { transactionManager, entity.CoExamPlaceStudCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region CoStudCheatCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<CoStudCheat>|CoStudCheatCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CoStudCheatCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.CoStudCheatCollection = DataRepository.CoStudCheatProvider.GetByCoExamSchdlPlaceId(transactionManager, entity.CoExamSchdlPlaceId);

				if (deep && entity.CoStudCheatCollection.Count > 0)
				{
					deepHandles.Add("CoStudCheatCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CoStudCheat>) DataRepository.CoStudCheatProvider.DeepLoad,
						new object[] { transactionManager, entity.CoStudCheatCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.CoExamSchdlPlace object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.CoExamSchdlPlace instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.CoExamSchdlPlace Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CoExamSchdlPlace entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region CoExamCommitteeIdSource
			if (CanDeepSave(entity, "CoExamCommittee|CoExamCommitteeIdSource", deepSaveType, innerList) 
				&& entity.CoExamCommitteeIdSource != null)
			{
				DataRepository.CoExamCommitteeProvider.Save(transactionManager, entity.CoExamCommitteeIdSource);
				entity.CoExamCommitteeId = entity.CoExamCommitteeIdSource.CoExamCommitteeId;
			}
			#endregion 
			
			#region EdExamSchdlIdSource
			if (CanDeepSave(entity, "EdExamSchdl|EdExamSchdlIdSource", deepSaveType, innerList) 
				&& entity.EdExamSchdlIdSource != null)
			{
				DataRepository.EdExamSchdlProvider.Save(transactionManager, entity.EdExamSchdlIdSource);
				entity.EdExamSchdlId = entity.EdExamSchdlIdSource.EdExamSchdlId;
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
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<CoExamCommSupervisor>
				if (CanDeepSave(entity.CoExamCommSupervisorCollection, "List<CoExamCommSupervisor>|CoExamCommSupervisorCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CoExamCommSupervisor child in entity.CoExamCommSupervisorCollection)
					{
						if(child.CoExamSchdlPlaceIdSource != null)
						{
							child.CoExamSchdlPlaceId = child.CoExamSchdlPlaceIdSource.CoExamSchdlPlaceId;
						}
						else
						{
							child.CoExamSchdlPlaceId = entity.CoExamSchdlPlaceId;
						}

					}

					if (entity.CoExamCommSupervisorCollection.Count > 0 || entity.CoExamCommSupervisorCollection.DeletedItems.Count > 0)
					{
						//DataRepository.CoExamCommSupervisorProvider.Save(transactionManager, entity.CoExamCommSupervisorCollection);
						
						deepHandles.Add("CoExamCommSupervisorCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< CoExamCommSupervisor >) DataRepository.CoExamCommSupervisorProvider.DeepSave,
							new object[] { transactionManager, entity.CoExamCommSupervisorCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<CoExamPlaceStud>
				if (CanDeepSave(entity.CoExamPlaceStudCollection, "List<CoExamPlaceStud>|CoExamPlaceStudCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CoExamPlaceStud child in entity.CoExamPlaceStudCollection)
					{
						if(child.CoExamSchdlPlaceIdSource != null)
						{
							child.CoExamSchdlPlaceId = child.CoExamSchdlPlaceIdSource.CoExamSchdlPlaceId;
						}
						else
						{
							child.CoExamSchdlPlaceId = entity.CoExamSchdlPlaceId;
						}

					}

					if (entity.CoExamPlaceStudCollection.Count > 0 || entity.CoExamPlaceStudCollection.DeletedItems.Count > 0)
					{
						//DataRepository.CoExamPlaceStudProvider.Save(transactionManager, entity.CoExamPlaceStudCollection);
						
						deepHandles.Add("CoExamPlaceStudCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< CoExamPlaceStud >) DataRepository.CoExamPlaceStudProvider.DeepSave,
							new object[] { transactionManager, entity.CoExamPlaceStudCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<CoStudCheat>
				if (CanDeepSave(entity.CoStudCheatCollection, "List<CoStudCheat>|CoStudCheatCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CoStudCheat child in entity.CoStudCheatCollection)
					{
						if(child.CoExamSchdlPlaceIdSource != null)
						{
							child.CoExamSchdlPlaceId = child.CoExamSchdlPlaceIdSource.CoExamSchdlPlaceId;
						}
						else
						{
							child.CoExamSchdlPlaceId = entity.CoExamSchdlPlaceId;
						}

					}

					if (entity.CoStudCheatCollection.Count > 0 || entity.CoStudCheatCollection.DeletedItems.Count > 0)
					{
						//DataRepository.CoStudCheatProvider.Save(transactionManager, entity.CoStudCheatCollection);
						
						deepHandles.Add("CoStudCheatCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< CoStudCheat >) DataRepository.CoStudCheatProvider.DeepSave,
							new object[] { transactionManager, entity.CoStudCheatCollection, deepSaveType, childTypes, innerList }
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
	
	#region CoExamSchdlPlaceChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.CoExamSchdlPlace</c>
	///</summary>
	public enum CoExamSchdlPlaceChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>CoExamCommittee</c> at CoExamCommitteeIdSource
		///</summary>
		[ChildEntityType(typeof(CoExamCommittee))]
		CoExamCommittee,
		
		///<summary>
		/// Composite Property for <c>EdExamSchdl</c> at EdExamSchdlIdSource
		///</summary>
		[ChildEntityType(typeof(EdExamSchdl))]
		EdExamSchdl,
		
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
		/// Collection of <c>CoExamSchdlPlace</c> as OneToMany for CoExamCommSupervisorCollection
		///</summary>
		[ChildEntityType(typeof(TList<CoExamCommSupervisor>))]
		CoExamCommSupervisorCollection,
		///<summary>
		/// Collection of <c>CoExamSchdlPlace</c> as OneToMany for CoExamPlaceStudCollection
		///</summary>
		[ChildEntityType(typeof(TList<CoExamPlaceStud>))]
		CoExamPlaceStudCollection,
		///<summary>
		/// Collection of <c>CoExamSchdlPlace</c> as OneToMany for CoStudCheatCollection
		///</summary>
		[ChildEntityType(typeof(TList<CoStudCheat>))]
		CoStudCheatCollection,
	}
	
	#endregion CoExamSchdlPlaceChildEntityTypes
	
	#region CoExamSchdlPlaceFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;CoExamSchdlPlaceColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CoExamSchdlPlace"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CoExamSchdlPlaceFilterBuilder : SqlFilterBuilder<CoExamSchdlPlaceColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CoExamSchdlPlaceFilterBuilder class.
		/// </summary>
		public CoExamSchdlPlaceFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CoExamSchdlPlaceFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CoExamSchdlPlaceFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CoExamSchdlPlaceFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CoExamSchdlPlaceFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CoExamSchdlPlaceFilterBuilder
	
	#region CoExamSchdlPlaceParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;CoExamSchdlPlaceColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CoExamSchdlPlace"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CoExamSchdlPlaceParameterBuilder : ParameterizedSqlFilterBuilder<CoExamSchdlPlaceColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CoExamSchdlPlaceParameterBuilder class.
		/// </summary>
		public CoExamSchdlPlaceParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CoExamSchdlPlaceParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CoExamSchdlPlaceParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CoExamSchdlPlaceParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CoExamSchdlPlaceParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CoExamSchdlPlaceParameterBuilder
	
	#region CoExamSchdlPlaceSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;CoExamSchdlPlaceColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CoExamSchdlPlace"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class CoExamSchdlPlaceSortBuilder : SqlSortBuilder<CoExamSchdlPlaceColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CoExamSchdlPlaceSqlSortBuilder class.
		/// </summary>
		public CoExamSchdlPlaceSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion CoExamSchdlPlaceSortBuilder
	
} // end namespace
