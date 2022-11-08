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
	/// This class is the base class for any <see cref="AdmPlaceExamLocProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AdmPlaceExamLocProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AdmPlaceExamLoc, UMIS_VER2.BusinessLyer.AdmPlaceExamLocKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmPlaceExamLocKey key)
		{
			return Delete(transactionManager, key.AdmPlaceExamLocId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_admPlaceExamLocId">EJUSTموعد امتحان القبول فى اكتر من قاعة. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _admPlaceExamLocId)
		{
			return Delete(null, _admPlaceExamLocId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admPlaceExamLocId">EJUSTموعد امتحان القبول فى اكتر من قاعة. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _admPlaceExamLocId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_LOC_ADM_PLACE_EXAM_DATETIME key.
		///		FK_ADM_PLACE_EXAM_LOC_ADM_PLACE_EXAM_DATETIME Description: 
		/// </summary>
		/// <param name="_admPlaceExamDatetimeId">موعد امتحان قبول</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamLoc objects.</returns>
		public TList<AdmPlaceExamLoc> GetByAdmPlaceExamDatetimeId(System.Decimal _admPlaceExamDatetimeId)
		{
			int count = -1;
			return GetByAdmPlaceExamDatetimeId(_admPlaceExamDatetimeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_LOC_ADM_PLACE_EXAM_DATETIME key.
		///		FK_ADM_PLACE_EXAM_LOC_ADM_PLACE_EXAM_DATETIME Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admPlaceExamDatetimeId">موعد امتحان قبول</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamLoc objects.</returns>
		/// <remarks></remarks>
		public TList<AdmPlaceExamLoc> GetByAdmPlaceExamDatetimeId(TransactionManager transactionManager, System.Decimal _admPlaceExamDatetimeId)
		{
			int count = -1;
			return GetByAdmPlaceExamDatetimeId(transactionManager, _admPlaceExamDatetimeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_LOC_ADM_PLACE_EXAM_DATETIME key.
		///		FK_ADM_PLACE_EXAM_LOC_ADM_PLACE_EXAM_DATETIME Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admPlaceExamDatetimeId">موعد امتحان قبول</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamLoc objects.</returns>
		public TList<AdmPlaceExamLoc> GetByAdmPlaceExamDatetimeId(TransactionManager transactionManager, System.Decimal _admPlaceExamDatetimeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmPlaceExamDatetimeId(transactionManager, _admPlaceExamDatetimeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_LOC_ADM_PLACE_EXAM_DATETIME key.
		///		fkAdmPlaceExamLocAdmPlaceExamDatetime Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admPlaceExamDatetimeId">موعد امتحان قبول</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamLoc objects.</returns>
		public TList<AdmPlaceExamLoc> GetByAdmPlaceExamDatetimeId(System.Decimal _admPlaceExamDatetimeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmPlaceExamDatetimeId(null, _admPlaceExamDatetimeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_LOC_ADM_PLACE_EXAM_DATETIME key.
		///		fkAdmPlaceExamLocAdmPlaceExamDatetime Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admPlaceExamDatetimeId">موعد امتحان قبول</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamLoc objects.</returns>
		public TList<AdmPlaceExamLoc> GetByAdmPlaceExamDatetimeId(System.Decimal _admPlaceExamDatetimeId, int start, int pageLength,out int count)
		{
			return GetByAdmPlaceExamDatetimeId(null, _admPlaceExamDatetimeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_LOC_ADM_PLACE_EXAM_DATETIME key.
		///		FK_ADM_PLACE_EXAM_LOC_ADM_PLACE_EXAM_DATETIME Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admPlaceExamDatetimeId">موعد امتحان قبول</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamLoc objects.</returns>
		public abstract TList<AdmPlaceExamLoc> GetByAdmPlaceExamDatetimeId(TransactionManager transactionManager, System.Decimal _admPlaceExamDatetimeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_LOC_SC_BUILDING key.
		///		FK_ADM_PLACE_EXAM_LOC_SC_BUILDING Description: 
		/// </summary>
		/// <param name="_scBuildingId">XXX</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamLoc objects.</returns>
		public TList<AdmPlaceExamLoc> GetByScBuildingId(System.Decimal? _scBuildingId)
		{
			int count = -1;
			return GetByScBuildingId(_scBuildingId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_LOC_SC_BUILDING key.
		///		FK_ADM_PLACE_EXAM_LOC_SC_BUILDING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scBuildingId">XXX</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamLoc objects.</returns>
		/// <remarks></remarks>
		public TList<AdmPlaceExamLoc> GetByScBuildingId(TransactionManager transactionManager, System.Decimal? _scBuildingId)
		{
			int count = -1;
			return GetByScBuildingId(transactionManager, _scBuildingId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_LOC_SC_BUILDING key.
		///		FK_ADM_PLACE_EXAM_LOC_SC_BUILDING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scBuildingId">XXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamLoc objects.</returns>
		public TList<AdmPlaceExamLoc> GetByScBuildingId(TransactionManager transactionManager, System.Decimal? _scBuildingId, int start, int pageLength)
		{
			int count = -1;
			return GetByScBuildingId(transactionManager, _scBuildingId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_LOC_SC_BUILDING key.
		///		fkAdmPlaceExamLocScBuilding Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scBuildingId">XXX</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamLoc objects.</returns>
		public TList<AdmPlaceExamLoc> GetByScBuildingId(System.Decimal? _scBuildingId, int start, int pageLength)
		{
			int count =  -1;
			return GetByScBuildingId(null, _scBuildingId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_LOC_SC_BUILDING key.
		///		fkAdmPlaceExamLocScBuilding Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scBuildingId">XXX</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamLoc objects.</returns>
		public TList<AdmPlaceExamLoc> GetByScBuildingId(System.Decimal? _scBuildingId, int start, int pageLength,out int count)
		{
			return GetByScBuildingId(null, _scBuildingId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_LOC_SC_BUILDING key.
		///		FK_ADM_PLACE_EXAM_LOC_SC_BUILDING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scBuildingId">XXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamLoc objects.</returns>
		public abstract TList<AdmPlaceExamLoc> GetByScBuildingId(TransactionManager transactionManager, System.Decimal? _scBuildingId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_LOC_SC_HALL key.
		///		FK_ADM_PLACE_EXAM_LOC_SC_HALL Description: 
		/// </summary>
		/// <param name="_scHallId">XXX</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamLoc objects.</returns>
		public TList<AdmPlaceExamLoc> GetByScHallId(System.Decimal? _scHallId)
		{
			int count = -1;
			return GetByScHallId(_scHallId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_LOC_SC_HALL key.
		///		FK_ADM_PLACE_EXAM_LOC_SC_HALL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scHallId">XXX</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamLoc objects.</returns>
		/// <remarks></remarks>
		public TList<AdmPlaceExamLoc> GetByScHallId(TransactionManager transactionManager, System.Decimal? _scHallId)
		{
			int count = -1;
			return GetByScHallId(transactionManager, _scHallId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_LOC_SC_HALL key.
		///		FK_ADM_PLACE_EXAM_LOC_SC_HALL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scHallId">XXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamLoc objects.</returns>
		public TList<AdmPlaceExamLoc> GetByScHallId(TransactionManager transactionManager, System.Decimal? _scHallId, int start, int pageLength)
		{
			int count = -1;
			return GetByScHallId(transactionManager, _scHallId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_LOC_SC_HALL key.
		///		fkAdmPlaceExamLocScHall Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scHallId">XXX</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamLoc objects.</returns>
		public TList<AdmPlaceExamLoc> GetByScHallId(System.Decimal? _scHallId, int start, int pageLength)
		{
			int count =  -1;
			return GetByScHallId(null, _scHallId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_LOC_SC_HALL key.
		///		fkAdmPlaceExamLocScHall Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scHallId">XXX</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamLoc objects.</returns>
		public TList<AdmPlaceExamLoc> GetByScHallId(System.Decimal? _scHallId, int start, int pageLength,out int count)
		{
			return GetByScHallId(null, _scHallId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_PLACE_EXAM_LOC_SC_HALL key.
		///		FK_ADM_PLACE_EXAM_LOC_SC_HALL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scHallId">XXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmPlaceExamLoc objects.</returns>
		public abstract TList<AdmPlaceExamLoc> GetByScHallId(TransactionManager transactionManager, System.Decimal? _scHallId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.AdmPlaceExamLoc Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmPlaceExamLocKey key, int start, int pageLength)
		{
			return GetByAdmPlaceExamLocId(transactionManager, key.AdmPlaceExamLocId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ADM_PLACE_EXAM_LOC index.
		/// </summary>
		/// <param name="_admPlaceExamLocId">EJUSTموعد امتحان القبول فى اكتر من قاعة</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmPlaceExamLoc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmPlaceExamLoc GetByAdmPlaceExamLocId(System.Decimal _admPlaceExamLocId)
		{
			int count = -1;
			return GetByAdmPlaceExamLocId(null,_admPlaceExamLocId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_PLACE_EXAM_LOC index.
		/// </summary>
		/// <param name="_admPlaceExamLocId">EJUSTموعد امتحان القبول فى اكتر من قاعة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmPlaceExamLoc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmPlaceExamLoc GetByAdmPlaceExamLocId(System.Decimal _admPlaceExamLocId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmPlaceExamLocId(null, _admPlaceExamLocId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_PLACE_EXAM_LOC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admPlaceExamLocId">EJUSTموعد امتحان القبول فى اكتر من قاعة</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmPlaceExamLoc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmPlaceExamLoc GetByAdmPlaceExamLocId(TransactionManager transactionManager, System.Decimal _admPlaceExamLocId)
		{
			int count = -1;
			return GetByAdmPlaceExamLocId(transactionManager, _admPlaceExamLocId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_PLACE_EXAM_LOC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admPlaceExamLocId">EJUSTموعد امتحان القبول فى اكتر من قاعة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmPlaceExamLoc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmPlaceExamLoc GetByAdmPlaceExamLocId(TransactionManager transactionManager, System.Decimal _admPlaceExamLocId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmPlaceExamLocId(transactionManager, _admPlaceExamLocId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_PLACE_EXAM_LOC index.
		/// </summary>
		/// <param name="_admPlaceExamLocId">EJUSTموعد امتحان القبول فى اكتر من قاعة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmPlaceExamLoc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmPlaceExamLoc GetByAdmPlaceExamLocId(System.Decimal _admPlaceExamLocId, int start, int pageLength, out int count)
		{
			return GetByAdmPlaceExamLocId(null, _admPlaceExamLocId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_PLACE_EXAM_LOC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admPlaceExamLocId">EJUSTموعد امتحان القبول فى اكتر من قاعة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmPlaceExamLoc"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmPlaceExamLoc GetByAdmPlaceExamLocId(TransactionManager transactionManager, System.Decimal _admPlaceExamLocId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ADM_PLACE_EXAM_LOC index.
		/// </summary>
		/// <param name="_admPlaceExamDatetimeId">موعد امتحان قبول</param>
		/// <param name="_scBuildingId">XXX</param>
		/// <param name="_scHallId">XXX</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmPlaceExamLoc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmPlaceExamLoc GetByAdmPlaceExamDatetimeIdScBuildingIdScHallId(System.Decimal _admPlaceExamDatetimeId, System.Decimal? _scBuildingId, System.Decimal? _scHallId)
		{
			int count = -1;
			return GetByAdmPlaceExamDatetimeIdScBuildingIdScHallId(null,_admPlaceExamDatetimeId, _scBuildingId, _scHallId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_PLACE_EXAM_LOC index.
		/// </summary>
		/// <param name="_admPlaceExamDatetimeId">موعد امتحان قبول</param>
		/// <param name="_scBuildingId">XXX</param>
		/// <param name="_scHallId">XXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmPlaceExamLoc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmPlaceExamLoc GetByAdmPlaceExamDatetimeIdScBuildingIdScHallId(System.Decimal _admPlaceExamDatetimeId, System.Decimal? _scBuildingId, System.Decimal? _scHallId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmPlaceExamDatetimeIdScBuildingIdScHallId(null, _admPlaceExamDatetimeId, _scBuildingId, _scHallId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_PLACE_EXAM_LOC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admPlaceExamDatetimeId">موعد امتحان قبول</param>
		/// <param name="_scBuildingId">XXX</param>
		/// <param name="_scHallId">XXX</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmPlaceExamLoc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmPlaceExamLoc GetByAdmPlaceExamDatetimeIdScBuildingIdScHallId(TransactionManager transactionManager, System.Decimal _admPlaceExamDatetimeId, System.Decimal? _scBuildingId, System.Decimal? _scHallId)
		{
			int count = -1;
			return GetByAdmPlaceExamDatetimeIdScBuildingIdScHallId(transactionManager, _admPlaceExamDatetimeId, _scBuildingId, _scHallId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_PLACE_EXAM_LOC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admPlaceExamDatetimeId">موعد امتحان قبول</param>
		/// <param name="_scBuildingId">XXX</param>
		/// <param name="_scHallId">XXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmPlaceExamLoc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmPlaceExamLoc GetByAdmPlaceExamDatetimeIdScBuildingIdScHallId(TransactionManager transactionManager, System.Decimal _admPlaceExamDatetimeId, System.Decimal? _scBuildingId, System.Decimal? _scHallId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmPlaceExamDatetimeIdScBuildingIdScHallId(transactionManager, _admPlaceExamDatetimeId, _scBuildingId, _scHallId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_PLACE_EXAM_LOC index.
		/// </summary>
		/// <param name="_admPlaceExamDatetimeId">موعد امتحان قبول</param>
		/// <param name="_scBuildingId">XXX</param>
		/// <param name="_scHallId">XXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmPlaceExamLoc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmPlaceExamLoc GetByAdmPlaceExamDatetimeIdScBuildingIdScHallId(System.Decimal _admPlaceExamDatetimeId, System.Decimal? _scBuildingId, System.Decimal? _scHallId, int start, int pageLength, out int count)
		{
			return GetByAdmPlaceExamDatetimeIdScBuildingIdScHallId(null, _admPlaceExamDatetimeId, _scBuildingId, _scHallId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_PLACE_EXAM_LOC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admPlaceExamDatetimeId">موعد امتحان قبول</param>
		/// <param name="_scBuildingId">XXX</param>
		/// <param name="_scHallId">XXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmPlaceExamLoc"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmPlaceExamLoc GetByAdmPlaceExamDatetimeIdScBuildingIdScHallId(TransactionManager transactionManager, System.Decimal _admPlaceExamDatetimeId, System.Decimal? _scBuildingId, System.Decimal? _scHallId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AdmPlaceExamLoc&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AdmPlaceExamLoc&gt;"/></returns>
		public static TList<AdmPlaceExamLoc> Fill(IDataReader reader, TList<AdmPlaceExamLoc> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AdmPlaceExamLoc c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AdmPlaceExamLoc")
					.Append("|").Append((System.Decimal)reader["ADM_PLACE_EXAM_LOC_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AdmPlaceExamLoc>(
					key.ToString(), // EntityTrackingKey
					"AdmPlaceExamLoc",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AdmPlaceExamLoc();
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
					c.AdmPlaceExamLocId = (System.Decimal)reader["ADM_PLACE_EXAM_LOC_ID"];
					c.OriginalAdmPlaceExamLocId = c.AdmPlaceExamLocId;
					c.AdmPlaceExamDatetimeId = (System.Decimal)reader["ADM_PLACE_EXAM_DATETIME_ID"];
					c.ScBuildingId = Convert.IsDBNull(reader["SC_BUILDING_ID"]) ? null : (System.Decimal?)reader["SC_BUILDING_ID"];
					c.ScHallId = Convert.IsDBNull(reader["SC_HALL_ID"]) ? null : (System.Decimal?)reader["SC_HALL_ID"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmPlaceExamLoc"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmPlaceExamLoc"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AdmPlaceExamLoc entity)
		{
			if (!reader.Read()) return;
			
			entity.AdmPlaceExamLocId = (System.Decimal)reader[((int)AdmPlaceExamLocColumn.AdmPlaceExamLocId - 1)];
			entity.OriginalAdmPlaceExamLocId = (System.Decimal)reader["ADM_PLACE_EXAM_LOC_ID"];
			entity.AdmPlaceExamDatetimeId = (System.Decimal)reader[((int)AdmPlaceExamLocColumn.AdmPlaceExamDatetimeId - 1)];
			entity.ScBuildingId = (reader.IsDBNull(((int)AdmPlaceExamLocColumn.ScBuildingId - 1)))?null:(System.Decimal?)reader[((int)AdmPlaceExamLocColumn.ScBuildingId - 1)];
			entity.ScHallId = (reader.IsDBNull(((int)AdmPlaceExamLocColumn.ScHallId - 1)))?null:(System.Decimal?)reader[((int)AdmPlaceExamLocColumn.ScHallId - 1)];
			entity.Notes = (reader.IsDBNull(((int)AdmPlaceExamLocColumn.Notes - 1)))?null:(System.String)reader[((int)AdmPlaceExamLocColumn.Notes - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)AdmPlaceExamLocColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)AdmPlaceExamLocColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)AdmPlaceExamLocColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)AdmPlaceExamLocColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmPlaceExamLoc"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmPlaceExamLoc"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AdmPlaceExamLoc entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AdmPlaceExamLocId = (System.Decimal)dataRow["ADM_PLACE_EXAM_LOC_ID"];
			entity.OriginalAdmPlaceExamLocId = (System.Decimal)dataRow["ADM_PLACE_EXAM_LOC_ID"];
			entity.AdmPlaceExamDatetimeId = (System.Decimal)dataRow["ADM_PLACE_EXAM_DATETIME_ID"];
			entity.ScBuildingId = Convert.IsDBNull(dataRow["SC_BUILDING_ID"]) ? null : (System.Decimal?)dataRow["SC_BUILDING_ID"];
			entity.ScHallId = Convert.IsDBNull(dataRow["SC_HALL_ID"]) ? null : (System.Decimal?)dataRow["SC_HALL_ID"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmPlaceExamLoc"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmPlaceExamLoc Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmPlaceExamLoc entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AdmPlaceExamDatetimeIdSource	
			if (CanDeepLoad(entity, "AdmPlaceExamDatetime|AdmPlaceExamDatetimeIdSource", deepLoadType, innerList) 
				&& entity.AdmPlaceExamDatetimeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AdmPlaceExamDatetimeId;
				AdmPlaceExamDatetime tmpEntity = EntityManager.LocateEntity<AdmPlaceExamDatetime>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmPlaceExamDatetime), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmPlaceExamDatetimeIdSource = tmpEntity;
				else
					entity.AdmPlaceExamDatetimeIdSource = DataRepository.AdmPlaceExamDatetimeProvider.GetByAdmPlaceExamDatetimeId(transactionManager, entity.AdmPlaceExamDatetimeId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmPlaceExamDatetimeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmPlaceExamDatetimeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmPlaceExamDatetimeProvider.DeepLoad(transactionManager, entity.AdmPlaceExamDatetimeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmPlaceExamDatetimeIdSource

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
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByAdmPlaceExamLocId methods when available
			
			#region AdmAppPlacementExamCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppPlacementExam>|AdmAppPlacementExamCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppPlacementExamCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppPlacementExamCollection = DataRepository.AdmAppPlacementExamProvider.GetByAdmPlaceExamLocId(transactionManager, entity.AdmPlaceExamLocId);

				if (deep && entity.AdmAppPlacementExamCollection.Count > 0)
				{
					deepHandles.Add("AdmAppPlacementExamCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppPlacementExam>) DataRepository.AdmAppPlacementExamProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppPlacementExamCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AdmPlaceExamLoc object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AdmPlaceExamLoc instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmPlaceExamLoc Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmPlaceExamLoc entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AdmPlaceExamDatetimeIdSource
			if (CanDeepSave(entity, "AdmPlaceExamDatetime|AdmPlaceExamDatetimeIdSource", deepSaveType, innerList) 
				&& entity.AdmPlaceExamDatetimeIdSource != null)
			{
				DataRepository.AdmPlaceExamDatetimeProvider.Save(transactionManager, entity.AdmPlaceExamDatetimeIdSource);
				entity.AdmPlaceExamDatetimeId = entity.AdmPlaceExamDatetimeIdSource.AdmPlaceExamDatetimeId;
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
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<AdmAppPlacementExam>
				if (CanDeepSave(entity.AdmAppPlacementExamCollection, "List<AdmAppPlacementExam>|AdmAppPlacementExamCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppPlacementExam child in entity.AdmAppPlacementExamCollection)
					{
						if(child.AdmPlaceExamLocIdSource != null)
						{
							child.AdmPlaceExamLocId = child.AdmPlaceExamLocIdSource.AdmPlaceExamLocId;
						}
						else
						{
							child.AdmPlaceExamLocId = entity.AdmPlaceExamLocId;
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
	
	#region AdmPlaceExamLocChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AdmPlaceExamLoc</c>
	///</summary>
	public enum AdmPlaceExamLocChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AdmPlaceExamDatetime</c> at AdmPlaceExamDatetimeIdSource
		///</summary>
		[ChildEntityType(typeof(AdmPlaceExamDatetime))]
		AdmPlaceExamDatetime,
		
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
		/// Collection of <c>AdmPlaceExamLoc</c> as OneToMany for AdmAppPlacementExamCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppPlacementExam>))]
		AdmAppPlacementExamCollection,
	}
	
	#endregion AdmPlaceExamLocChildEntityTypes
	
	#region AdmPlaceExamLocFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AdmPlaceExamLocColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmPlaceExamLoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmPlaceExamLocFilterBuilder : SqlFilterBuilder<AdmPlaceExamLocColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmPlaceExamLocFilterBuilder class.
		/// </summary>
		public AdmPlaceExamLocFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmPlaceExamLocFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmPlaceExamLocFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmPlaceExamLocFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmPlaceExamLocFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmPlaceExamLocFilterBuilder
	
	#region AdmPlaceExamLocParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AdmPlaceExamLocColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmPlaceExamLoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmPlaceExamLocParameterBuilder : ParameterizedSqlFilterBuilder<AdmPlaceExamLocColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmPlaceExamLocParameterBuilder class.
		/// </summary>
		public AdmPlaceExamLocParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmPlaceExamLocParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmPlaceExamLocParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmPlaceExamLocParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmPlaceExamLocParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmPlaceExamLocParameterBuilder
	
	#region AdmPlaceExamLocSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AdmPlaceExamLocColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmPlaceExamLoc"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AdmPlaceExamLocSortBuilder : SqlSortBuilder<AdmPlaceExamLocColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmPlaceExamLocSqlSortBuilder class.
		/// </summary>
		public AdmPlaceExamLocSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AdmPlaceExamLocSortBuilder
	
} // end namespace
