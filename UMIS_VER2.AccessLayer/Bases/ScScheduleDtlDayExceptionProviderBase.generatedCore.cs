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
	/// This class is the base class for any <see cref="ScScheduleDtlDayExceptionProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class ScScheduleDtlDayExceptionProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.ScScheduleDtlDayException, UMIS_VER2.BusinessLyer.ScScheduleDtlDayExceptionKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScScheduleDtlDayExceptionKey key)
		{
			return Delete(transactionManager, key.ScScheduleDtlDayExceptionId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_scScheduleDtlDayExceptionId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _scScheduleDtlDayExceptionId)
		{
			return Delete(null, _scScheduleDtlDayExceptionId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleDtlDayExceptionId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _scScheduleDtlDayExceptionId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_DAY_Exception_SC_BUILDING key.
		///		FK_SC_SCHEDULE_DTL_DAY_Exception_SC_BUILDING Description: 
		/// </summary>
		/// <param name="_scBuildingId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtlDayException objects.</returns>
		public TList<ScScheduleDtlDayException> GetByScBuildingId(System.Decimal? _scBuildingId)
		{
			int count = -1;
			return GetByScBuildingId(_scBuildingId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_DAY_Exception_SC_BUILDING key.
		///		FK_SC_SCHEDULE_DTL_DAY_Exception_SC_BUILDING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scBuildingId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtlDayException objects.</returns>
		/// <remarks></remarks>
		public TList<ScScheduleDtlDayException> GetByScBuildingId(TransactionManager transactionManager, System.Decimal? _scBuildingId)
		{
			int count = -1;
			return GetByScBuildingId(transactionManager, _scBuildingId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_DAY_Exception_SC_BUILDING key.
		///		FK_SC_SCHEDULE_DTL_DAY_Exception_SC_BUILDING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scBuildingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtlDayException objects.</returns>
		public TList<ScScheduleDtlDayException> GetByScBuildingId(TransactionManager transactionManager, System.Decimal? _scBuildingId, int start, int pageLength)
		{
			int count = -1;
			return GetByScBuildingId(transactionManager, _scBuildingId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_DAY_Exception_SC_BUILDING key.
		///		fkScScheduleDtlDayExceptionScBuilding Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scBuildingId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtlDayException objects.</returns>
		public TList<ScScheduleDtlDayException> GetByScBuildingId(System.Decimal? _scBuildingId, int start, int pageLength)
		{
			int count =  -1;
			return GetByScBuildingId(null, _scBuildingId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_DAY_Exception_SC_BUILDING key.
		///		fkScScheduleDtlDayExceptionScBuilding Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scBuildingId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtlDayException objects.</returns>
		public TList<ScScheduleDtlDayException> GetByScBuildingId(System.Decimal? _scBuildingId, int start, int pageLength,out int count)
		{
			return GetByScBuildingId(null, _scBuildingId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_DAY_Exception_SC_BUILDING key.
		///		FK_SC_SCHEDULE_DTL_DAY_Exception_SC_BUILDING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scBuildingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtlDayException objects.</returns>
		public abstract TList<ScScheduleDtlDayException> GetByScBuildingId(TransactionManager transactionManager, System.Decimal? _scBuildingId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_DAY_Exception_SC_HALL key.
		///		FK_SC_SCHEDULE_DTL_DAY_Exception_SC_HALL Description: 
		/// </summary>
		/// <param name="_scHallId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtlDayException objects.</returns>
		public TList<ScScheduleDtlDayException> GetByScHallId(System.Decimal? _scHallId)
		{
			int count = -1;
			return GetByScHallId(_scHallId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_DAY_Exception_SC_HALL key.
		///		FK_SC_SCHEDULE_DTL_DAY_Exception_SC_HALL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scHallId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtlDayException objects.</returns>
		/// <remarks></remarks>
		public TList<ScScheduleDtlDayException> GetByScHallId(TransactionManager transactionManager, System.Decimal? _scHallId)
		{
			int count = -1;
			return GetByScHallId(transactionManager, _scHallId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_DAY_Exception_SC_HALL key.
		///		FK_SC_SCHEDULE_DTL_DAY_Exception_SC_HALL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scHallId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtlDayException objects.</returns>
		public TList<ScScheduleDtlDayException> GetByScHallId(TransactionManager transactionManager, System.Decimal? _scHallId, int start, int pageLength)
		{
			int count = -1;
			return GetByScHallId(transactionManager, _scHallId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_DAY_Exception_SC_HALL key.
		///		fkScScheduleDtlDayExceptionScHall Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scHallId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtlDayException objects.</returns>
		public TList<ScScheduleDtlDayException> GetByScHallId(System.Decimal? _scHallId, int start, int pageLength)
		{
			int count =  -1;
			return GetByScHallId(null, _scHallId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_DAY_Exception_SC_HALL key.
		///		fkScScheduleDtlDayExceptionScHall Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scHallId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtlDayException objects.</returns>
		public TList<ScScheduleDtlDayException> GetByScHallId(System.Decimal? _scHallId, int start, int pageLength,out int count)
		{
			return GetByScHallId(null, _scHallId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_DAY_Exception_SC_HALL key.
		///		FK_SC_SCHEDULE_DTL_DAY_Exception_SC_HALL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scHallId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtlDayException objects.</returns>
		public abstract TList<ScScheduleDtlDayException> GetByScHallId(TransactionManager transactionManager, System.Decimal? _scHallId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_DAY_Exception_SC_SCHEDULE_DTL_DAY key.
		///		FK_SC_SCHEDULE_DTL_DAY_Exception_SC_SCHEDULE_DTL_DAY Description: 
		/// </summary>
		/// <param name="_scScheduleDtlDayId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtlDayException objects.</returns>
		public TList<ScScheduleDtlDayException> GetByScScheduleDtlDayId(System.Decimal _scScheduleDtlDayId)
		{
			int count = -1;
			return GetByScScheduleDtlDayId(_scScheduleDtlDayId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_DAY_Exception_SC_SCHEDULE_DTL_DAY key.
		///		FK_SC_SCHEDULE_DTL_DAY_Exception_SC_SCHEDULE_DTL_DAY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleDtlDayId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtlDayException objects.</returns>
		/// <remarks></remarks>
		public TList<ScScheduleDtlDayException> GetByScScheduleDtlDayId(TransactionManager transactionManager, System.Decimal _scScheduleDtlDayId)
		{
			int count = -1;
			return GetByScScheduleDtlDayId(transactionManager, _scScheduleDtlDayId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_DAY_Exception_SC_SCHEDULE_DTL_DAY key.
		///		FK_SC_SCHEDULE_DTL_DAY_Exception_SC_SCHEDULE_DTL_DAY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleDtlDayId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtlDayException objects.</returns>
		public TList<ScScheduleDtlDayException> GetByScScheduleDtlDayId(TransactionManager transactionManager, System.Decimal _scScheduleDtlDayId, int start, int pageLength)
		{
			int count = -1;
			return GetByScScheduleDtlDayId(transactionManager, _scScheduleDtlDayId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_DAY_Exception_SC_SCHEDULE_DTL_DAY key.
		///		fkScScheduleDtlDayExceptionScScheduleDtlDay Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scScheduleDtlDayId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtlDayException objects.</returns>
		public TList<ScScheduleDtlDayException> GetByScScheduleDtlDayId(System.Decimal _scScheduleDtlDayId, int start, int pageLength)
		{
			int count =  -1;
			return GetByScScheduleDtlDayId(null, _scScheduleDtlDayId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_DAY_Exception_SC_SCHEDULE_DTL_DAY key.
		///		fkScScheduleDtlDayExceptionScScheduleDtlDay Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scScheduleDtlDayId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtlDayException objects.</returns>
		public TList<ScScheduleDtlDayException> GetByScScheduleDtlDayId(System.Decimal _scScheduleDtlDayId, int start, int pageLength,out int count)
		{
			return GetByScScheduleDtlDayId(null, _scScheduleDtlDayId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SC_SCHEDULE_DTL_DAY_Exception_SC_SCHEDULE_DTL_DAY key.
		///		FK_SC_SCHEDULE_DTL_DAY_Exception_SC_SCHEDULE_DTL_DAY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleDtlDayId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ScScheduleDtlDayException objects.</returns>
		public abstract TList<ScScheduleDtlDayException> GetByScScheduleDtlDayId(TransactionManager transactionManager, System.Decimal _scScheduleDtlDayId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.ScScheduleDtlDayException Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScScheduleDtlDayExceptionKey key, int start, int pageLength)
		{
			return GetByScScheduleDtlDayExceptionId(transactionManager, key.ScScheduleDtlDayExceptionId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SC_SCHEDULE_DTL_DAY_Exception index.
		/// </summary>
		/// <param name="_scScheduleDtlDayExceptionId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtlDayException"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScScheduleDtlDayException GetByScScheduleDtlDayExceptionId(System.Decimal _scScheduleDtlDayExceptionId)
		{
			int count = -1;
			return GetByScScheduleDtlDayExceptionId(null,_scScheduleDtlDayExceptionId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_SCHEDULE_DTL_DAY_Exception index.
		/// </summary>
		/// <param name="_scScheduleDtlDayExceptionId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtlDayException"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScScheduleDtlDayException GetByScScheduleDtlDayExceptionId(System.Decimal _scScheduleDtlDayExceptionId, int start, int pageLength)
		{
			int count = -1;
			return GetByScScheduleDtlDayExceptionId(null, _scScheduleDtlDayExceptionId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_SCHEDULE_DTL_DAY_Exception index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleDtlDayExceptionId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtlDayException"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScScheduleDtlDayException GetByScScheduleDtlDayExceptionId(TransactionManager transactionManager, System.Decimal _scScheduleDtlDayExceptionId)
		{
			int count = -1;
			return GetByScScheduleDtlDayExceptionId(transactionManager, _scScheduleDtlDayExceptionId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_SCHEDULE_DTL_DAY_Exception index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleDtlDayExceptionId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtlDayException"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScScheduleDtlDayException GetByScScheduleDtlDayExceptionId(TransactionManager transactionManager, System.Decimal _scScheduleDtlDayExceptionId, int start, int pageLength)
		{
			int count = -1;
			return GetByScScheduleDtlDayExceptionId(transactionManager, _scScheduleDtlDayExceptionId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_SCHEDULE_DTL_DAY_Exception index.
		/// </summary>
		/// <param name="_scScheduleDtlDayExceptionId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtlDayException"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScScheduleDtlDayException GetByScScheduleDtlDayExceptionId(System.Decimal _scScheduleDtlDayExceptionId, int start, int pageLength, out int count)
		{
			return GetByScScheduleDtlDayExceptionId(null, _scScheduleDtlDayExceptionId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_SCHEDULE_DTL_DAY_Exception index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleDtlDayExceptionId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtlDayException"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.ScScheduleDtlDayException GetByScScheduleDtlDayExceptionId(TransactionManager transactionManager, System.Decimal _scScheduleDtlDayExceptionId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;ScScheduleDtlDayException&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;ScScheduleDtlDayException&gt;"/></returns>
		public static TList<ScScheduleDtlDayException> Fill(IDataReader reader, TList<ScScheduleDtlDayException> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.ScScheduleDtlDayException c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("ScScheduleDtlDayException")
					.Append("|").Append((System.Decimal)reader["SC_SCHEDULE_DTL_DAY_Exception_Id"]).ToString();
					c = EntityManager.LocateOrCreate<ScScheduleDtlDayException>(
					key.ToString(), // EntityTrackingKey
					"ScScheduleDtlDayException",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.ScScheduleDtlDayException();
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
					c.ScScheduleDtlDayExceptionId = (System.Decimal)reader["SC_SCHEDULE_DTL_DAY_Exception_Id"];
					c.OriginalScScheduleDtlDayExceptionId = c.ScScheduleDtlDayExceptionId;
					c.ScScheduleDtlDayId = (System.Decimal)reader["SC_SCHEDULE_DTL_DAY_ID"];
					c.ScBuildingId = Convert.IsDBNull(reader["SC_BUILDING_ID"]) ? null : (System.Decimal?)reader["SC_BUILDING_ID"];
					c.ScHallId = Convert.IsDBNull(reader["SC_HALL_ID"]) ? null : (System.Decimal?)reader["SC_HALL_ID"];
					c.FromTime = Convert.IsDBNull(reader["FROM_TIME"]) ? null : (System.DateTime?)reader["FROM_TIME"];
					c.ToTime = Convert.IsDBNull(reader["TO_TIME"]) ? null : (System.DateTime?)reader["TO_TIME"];
					c.ExceptionDate = Convert.IsDBNull(reader["Exception_Date"]) ? null : (System.DateTime?)reader["Exception_Date"];
					c.CancleFlg = Convert.IsDBNull(reader["Cancle_FLG"]) ? null : (System.Boolean?)reader["Cancle_FLG"];
					c.OldDateChanged = (System.DateTime)reader["OLD_Date_Changed"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtlDayException"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtlDayException"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.ScScheduleDtlDayException entity)
		{
			if (!reader.Read()) return;
			
			entity.ScScheduleDtlDayExceptionId = (System.Decimal)reader[((int)ScScheduleDtlDayExceptionColumn.ScScheduleDtlDayExceptionId - 1)];
			entity.OriginalScScheduleDtlDayExceptionId = (System.Decimal)reader["SC_SCHEDULE_DTL_DAY_Exception_Id"];
			entity.ScScheduleDtlDayId = (System.Decimal)reader[((int)ScScheduleDtlDayExceptionColumn.ScScheduleDtlDayId - 1)];
			entity.ScBuildingId = (reader.IsDBNull(((int)ScScheduleDtlDayExceptionColumn.ScBuildingId - 1)))?null:(System.Decimal?)reader[((int)ScScheduleDtlDayExceptionColumn.ScBuildingId - 1)];
			entity.ScHallId = (reader.IsDBNull(((int)ScScheduleDtlDayExceptionColumn.ScHallId - 1)))?null:(System.Decimal?)reader[((int)ScScheduleDtlDayExceptionColumn.ScHallId - 1)];
			entity.FromTime = (reader.IsDBNull(((int)ScScheduleDtlDayExceptionColumn.FromTime - 1)))?null:(System.DateTime?)reader[((int)ScScheduleDtlDayExceptionColumn.FromTime - 1)];
			entity.ToTime = (reader.IsDBNull(((int)ScScheduleDtlDayExceptionColumn.ToTime - 1)))?null:(System.DateTime?)reader[((int)ScScheduleDtlDayExceptionColumn.ToTime - 1)];
			entity.ExceptionDate = (reader.IsDBNull(((int)ScScheduleDtlDayExceptionColumn.ExceptionDate - 1)))?null:(System.DateTime?)reader[((int)ScScheduleDtlDayExceptionColumn.ExceptionDate - 1)];
			entity.CancleFlg = (reader.IsDBNull(((int)ScScheduleDtlDayExceptionColumn.CancleFlg - 1)))?null:(System.Boolean?)reader[((int)ScScheduleDtlDayExceptionColumn.CancleFlg - 1)];
			entity.OldDateChanged = (System.DateTime)reader[((int)ScScheduleDtlDayExceptionColumn.OldDateChanged - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtlDayException"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtlDayException"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.ScScheduleDtlDayException entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.ScScheduleDtlDayExceptionId = (System.Decimal)dataRow["SC_SCHEDULE_DTL_DAY_Exception_Id"];
			entity.OriginalScScheduleDtlDayExceptionId = (System.Decimal)dataRow["SC_SCHEDULE_DTL_DAY_Exception_Id"];
			entity.ScScheduleDtlDayId = (System.Decimal)dataRow["SC_SCHEDULE_DTL_DAY_ID"];
			entity.ScBuildingId = Convert.IsDBNull(dataRow["SC_BUILDING_ID"]) ? null : (System.Decimal?)dataRow["SC_BUILDING_ID"];
			entity.ScHallId = Convert.IsDBNull(dataRow["SC_HALL_ID"]) ? null : (System.Decimal?)dataRow["SC_HALL_ID"];
			entity.FromTime = Convert.IsDBNull(dataRow["FROM_TIME"]) ? null : (System.DateTime?)dataRow["FROM_TIME"];
			entity.ToTime = Convert.IsDBNull(dataRow["TO_TIME"]) ? null : (System.DateTime?)dataRow["TO_TIME"];
			entity.ExceptionDate = Convert.IsDBNull(dataRow["Exception_Date"]) ? null : (System.DateTime?)dataRow["Exception_Date"];
			entity.CancleFlg = Convert.IsDBNull(dataRow["Cancle_FLG"]) ? null : (System.Boolean?)dataRow["Cancle_FLG"];
			entity.OldDateChanged = (System.DateTime)dataRow["OLD_Date_Changed"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScScheduleDtlDayException"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.ScScheduleDtlDayException Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScScheduleDtlDayException entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

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

			#region ScScheduleDtlDayIdSource	
			if (CanDeepLoad(entity, "ScScheduleDtlDay|ScScheduleDtlDayIdSource", deepLoadType, innerList) 
				&& entity.ScScheduleDtlDayIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.ScScheduleDtlDayId;
				ScScheduleDtlDay tmpEntity = EntityManager.LocateEntity<ScScheduleDtlDay>(EntityLocator.ConstructKeyFromPkItems(typeof(ScScheduleDtlDay), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.ScScheduleDtlDayIdSource = tmpEntity;
				else
					entity.ScScheduleDtlDayIdSource = DataRepository.ScScheduleDtlDayProvider.GetByScScheduleDtlDayId(transactionManager, entity.ScScheduleDtlDayId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScScheduleDtlDayIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.ScScheduleDtlDayIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.ScScheduleDtlDayProvider.DeepLoad(transactionManager, entity.ScScheduleDtlDayIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion ScScheduleDtlDayIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.ScScheduleDtlDayException object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.ScScheduleDtlDayException instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.ScScheduleDtlDayException Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScScheduleDtlDayException entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
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
			
			#region ScScheduleDtlDayIdSource
			if (CanDeepSave(entity, "ScScheduleDtlDay|ScScheduleDtlDayIdSource", deepSaveType, innerList) 
				&& entity.ScScheduleDtlDayIdSource != null)
			{
				DataRepository.ScScheduleDtlDayProvider.Save(transactionManager, entity.ScScheduleDtlDayIdSource);
				entity.ScScheduleDtlDayId = entity.ScScheduleDtlDayIdSource.ScScheduleDtlDayId;
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
	
	#region ScScheduleDtlDayExceptionChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.ScScheduleDtlDayException</c>
	///</summary>
	public enum ScScheduleDtlDayExceptionChildEntityTypes
	{
		
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
		/// Composite Property for <c>ScScheduleDtlDay</c> at ScScheduleDtlDayIdSource
		///</summary>
		[ChildEntityType(typeof(ScScheduleDtlDay))]
		ScScheduleDtlDay,
	}
	
	#endregion ScScheduleDtlDayExceptionChildEntityTypes
	
	#region ScScheduleDtlDayExceptionFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;ScScheduleDtlDayExceptionColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScScheduleDtlDayException"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ScScheduleDtlDayExceptionFilterBuilder : SqlFilterBuilder<ScScheduleDtlDayExceptionColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScScheduleDtlDayExceptionFilterBuilder class.
		/// </summary>
		public ScScheduleDtlDayExceptionFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ScScheduleDtlDayExceptionFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ScScheduleDtlDayExceptionFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ScScheduleDtlDayExceptionFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ScScheduleDtlDayExceptionFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ScScheduleDtlDayExceptionFilterBuilder
	
	#region ScScheduleDtlDayExceptionParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;ScScheduleDtlDayExceptionColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScScheduleDtlDayException"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ScScheduleDtlDayExceptionParameterBuilder : ParameterizedSqlFilterBuilder<ScScheduleDtlDayExceptionColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScScheduleDtlDayExceptionParameterBuilder class.
		/// </summary>
		public ScScheduleDtlDayExceptionParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ScScheduleDtlDayExceptionParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ScScheduleDtlDayExceptionParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ScScheduleDtlDayExceptionParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ScScheduleDtlDayExceptionParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ScScheduleDtlDayExceptionParameterBuilder
	
	#region ScScheduleDtlDayExceptionSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;ScScheduleDtlDayExceptionColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScScheduleDtlDayException"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ScScheduleDtlDayExceptionSortBuilder : SqlSortBuilder<ScScheduleDtlDayExceptionColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScScheduleDtlDayExceptionSqlSortBuilder class.
		/// </summary>
		public ScScheduleDtlDayExceptionSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ScScheduleDtlDayExceptionSortBuilder
	
} // end namespace
