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
	/// This class is the base class for any <see cref="SvCdeLockerProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SvCdeLockerProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SvCdeLocker, UMIS_VER2.BusinessLyer.SvCdeLockerKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvCdeLockerKey key)
		{
			return Delete(transactionManager, key.SvCdeLockerId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_svCdeLockerId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _svCdeLockerId)
		{
			return Delete(null, _svCdeLockerId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeLockerId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _svCdeLockerId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_CDE_LOCKER_SC_BUILDING key.
		///		FK_SV_CDE_LOCKER_SC_BUILDING Description: 
		/// </summary>
		/// <param name="_scBuildingId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvCdeLocker objects.</returns>
		public TList<SvCdeLocker> GetByScBuildingId(System.Decimal _scBuildingId)
		{
			int count = -1;
			return GetByScBuildingId(_scBuildingId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_CDE_LOCKER_SC_BUILDING key.
		///		FK_SV_CDE_LOCKER_SC_BUILDING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scBuildingId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvCdeLocker objects.</returns>
		/// <remarks></remarks>
		public TList<SvCdeLocker> GetByScBuildingId(TransactionManager transactionManager, System.Decimal _scBuildingId)
		{
			int count = -1;
			return GetByScBuildingId(transactionManager, _scBuildingId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_CDE_LOCKER_SC_BUILDING key.
		///		FK_SV_CDE_LOCKER_SC_BUILDING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scBuildingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvCdeLocker objects.</returns>
		public TList<SvCdeLocker> GetByScBuildingId(TransactionManager transactionManager, System.Decimal _scBuildingId, int start, int pageLength)
		{
			int count = -1;
			return GetByScBuildingId(transactionManager, _scBuildingId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_CDE_LOCKER_SC_BUILDING key.
		///		fkSvCdeLockerScBuilding Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scBuildingId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvCdeLocker objects.</returns>
		public TList<SvCdeLocker> GetByScBuildingId(System.Decimal _scBuildingId, int start, int pageLength)
		{
			int count =  -1;
			return GetByScBuildingId(null, _scBuildingId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_CDE_LOCKER_SC_BUILDING key.
		///		fkSvCdeLockerScBuilding Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_scBuildingId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvCdeLocker objects.</returns>
		public TList<SvCdeLocker> GetByScBuildingId(System.Decimal _scBuildingId, int start, int pageLength,out int count)
		{
			return GetByScBuildingId(null, _scBuildingId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_CDE_LOCKER_SC_BUILDING key.
		///		FK_SV_CDE_LOCKER_SC_BUILDING Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scBuildingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvCdeLocker objects.</returns>
		public abstract TList<SvCdeLocker> GetByScBuildingId(TransactionManager transactionManager, System.Decimal _scBuildingId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SvCdeLocker Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvCdeLockerKey key, int start, int pageLength)
		{
			return GetBySvCdeLockerId(transactionManager, key.SvCdeLockerId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SV_CDE_LOCKER index.
		/// </summary>
		/// <param name="_svCdeLockerId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeLocker"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCdeLocker GetBySvCdeLockerId(System.Decimal _svCdeLockerId)
		{
			int count = -1;
			return GetBySvCdeLockerId(null,_svCdeLockerId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_CDE_LOCKER index.
		/// </summary>
		/// <param name="_svCdeLockerId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeLocker"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCdeLocker GetBySvCdeLockerId(System.Decimal _svCdeLockerId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvCdeLockerId(null, _svCdeLockerId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_CDE_LOCKER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeLockerId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeLocker"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCdeLocker GetBySvCdeLockerId(TransactionManager transactionManager, System.Decimal _svCdeLockerId)
		{
			int count = -1;
			return GetBySvCdeLockerId(transactionManager, _svCdeLockerId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_CDE_LOCKER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeLockerId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeLocker"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCdeLocker GetBySvCdeLockerId(TransactionManager transactionManager, System.Decimal _svCdeLockerId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvCdeLockerId(transactionManager, _svCdeLockerId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_CDE_LOCKER index.
		/// </summary>
		/// <param name="_svCdeLockerId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeLocker"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCdeLocker GetBySvCdeLockerId(System.Decimal _svCdeLockerId, int start, int pageLength, out int count)
		{
			return GetBySvCdeLockerId(null, _svCdeLockerId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_CDE_LOCKER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeLockerId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeLocker"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SvCdeLocker GetBySvCdeLockerId(TransactionManager transactionManager, System.Decimal _svCdeLockerId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_SV_CDE_LOCKER index.
		/// </summary>
		/// <param name="_lockerCode"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeLocker"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCdeLocker GetByLockerCode(System.String _lockerCode)
		{
			int count = -1;
			return GetByLockerCode(null,_lockerCode, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_CDE_LOCKER index.
		/// </summary>
		/// <param name="_lockerCode"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeLocker"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCdeLocker GetByLockerCode(System.String _lockerCode, int start, int pageLength)
		{
			int count = -1;
			return GetByLockerCode(null, _lockerCode, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_CDE_LOCKER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_lockerCode"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeLocker"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCdeLocker GetByLockerCode(TransactionManager transactionManager, System.String _lockerCode)
		{
			int count = -1;
			return GetByLockerCode(transactionManager, _lockerCode, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_CDE_LOCKER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_lockerCode"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeLocker"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCdeLocker GetByLockerCode(TransactionManager transactionManager, System.String _lockerCode, int start, int pageLength)
		{
			int count = -1;
			return GetByLockerCode(transactionManager, _lockerCode, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_CDE_LOCKER index.
		/// </summary>
		/// <param name="_lockerCode"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeLocker"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCdeLocker GetByLockerCode(System.String _lockerCode, int start, int pageLength, out int count)
		{
			return GetByLockerCode(null, _lockerCode, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SV_CDE_LOCKER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_lockerCode"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeLocker"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SvCdeLocker GetByLockerCode(TransactionManager transactionManager, System.String _lockerCode, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SvCdeLocker&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SvCdeLocker&gt;"/></returns>
		public static TList<SvCdeLocker> Fill(IDataReader reader, TList<SvCdeLocker> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SvCdeLocker c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SvCdeLocker")
					.Append("|").Append((System.Decimal)reader["SV_CDE_LOCKER_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SvCdeLocker>(
					key.ToString(), // EntityTrackingKey
					"SvCdeLocker",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SvCdeLocker();
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
					c.SvCdeLockerId = (System.Decimal)reader["SV_CDE_LOCKER_ID"];
					c.OriginalSvCdeLockerId = c.SvCdeLockerId;
					c.ScBuildingId = (System.Decimal)reader["SC_BUILDING_ID"];
					c.LockerCode = Convert.IsDBNull(reader["LOCKER_CODE"]) ? null : (System.String)reader["LOCKER_CODE"];
					c.IsBusy = (System.Decimal)reader["IS_BUSY"];
					c.IsActive = (System.Decimal)reader["IS_ACTIVE"];
					c.LockerPlace = Convert.IsDBNull(reader["LOCKER_PLACE"]) ? null : (System.String)reader["LOCKER_PLACE"];
					c.LockerLevel = Convert.IsDBNull(reader["LOCKER_LEVEL"]) ? null : (System.Decimal?)reader["LOCKER_LEVEL"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SvCdeLocker"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvCdeLocker"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SvCdeLocker entity)
		{
			if (!reader.Read()) return;
			
			entity.SvCdeLockerId = (System.Decimal)reader[((int)SvCdeLockerColumn.SvCdeLockerId - 1)];
			entity.OriginalSvCdeLockerId = (System.Decimal)reader["SV_CDE_LOCKER_ID"];
			entity.ScBuildingId = (System.Decimal)reader[((int)SvCdeLockerColumn.ScBuildingId - 1)];
			entity.LockerCode = (reader.IsDBNull(((int)SvCdeLockerColumn.LockerCode - 1)))?null:(System.String)reader[((int)SvCdeLockerColumn.LockerCode - 1)];
			entity.IsBusy = (System.Decimal)reader[((int)SvCdeLockerColumn.IsBusy - 1)];
			entity.IsActive = (System.Decimal)reader[((int)SvCdeLockerColumn.IsActive - 1)];
			entity.LockerPlace = (reader.IsDBNull(((int)SvCdeLockerColumn.LockerPlace - 1)))?null:(System.String)reader[((int)SvCdeLockerColumn.LockerPlace - 1)];
			entity.LockerLevel = (reader.IsDBNull(((int)SvCdeLockerColumn.LockerLevel - 1)))?null:(System.Decimal?)reader[((int)SvCdeLockerColumn.LockerLevel - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SvCdeLocker"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvCdeLocker"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SvCdeLocker entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SvCdeLockerId = (System.Decimal)dataRow["SV_CDE_LOCKER_ID"];
			entity.OriginalSvCdeLockerId = (System.Decimal)dataRow["SV_CDE_LOCKER_ID"];
			entity.ScBuildingId = (System.Decimal)dataRow["SC_BUILDING_ID"];
			entity.LockerCode = Convert.IsDBNull(dataRow["LOCKER_CODE"]) ? null : (System.String)dataRow["LOCKER_CODE"];
			entity.IsBusy = (System.Decimal)dataRow["IS_BUSY"];
			entity.IsActive = (System.Decimal)dataRow["IS_ACTIVE"];
			entity.LockerPlace = Convert.IsDBNull(dataRow["LOCKER_PLACE"]) ? null : (System.String)dataRow["LOCKER_PLACE"];
			entity.LockerLevel = Convert.IsDBNull(dataRow["LOCKER_LEVEL"]) ? null : (System.Decimal?)dataRow["LOCKER_LEVEL"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvCdeLocker"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SvCdeLocker Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvCdeLocker entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region ScBuildingIdSource	
			if (CanDeepLoad(entity, "ScBuilding|ScBuildingIdSource", deepLoadType, innerList) 
				&& entity.ScBuildingIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.ScBuildingId;
				ScBuilding tmpEntity = EntityManager.LocateEntity<ScBuilding>(EntityLocator.ConstructKeyFromPkItems(typeof(ScBuilding), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.ScBuildingIdSource = tmpEntity;
				else
					entity.ScBuildingIdSource = DataRepository.ScBuildingProvider.GetByScBuildingId(transactionManager, entity.ScBuildingId);		
				
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
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetBySvCdeLockerId methods when available
			
			#region SvStudLockerReqCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvStudLockerReq>|SvStudLockerReqCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvStudLockerReqCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvStudLockerReqCollection = DataRepository.SvStudLockerReqProvider.GetBySvCdeLockerId(transactionManager, entity.SvCdeLockerId);

				if (deep && entity.SvStudLockerReqCollection.Count > 0)
				{
					deepHandles.Add("SvStudLockerReqCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvStudLockerReq>) DataRepository.SvStudLockerReqProvider.DeepLoad,
						new object[] { transactionManager, entity.SvStudLockerReqCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SvCdeLocker object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SvCdeLocker instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SvCdeLocker Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvCdeLocker entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<SvStudLockerReq>
				if (CanDeepSave(entity.SvStudLockerReqCollection, "List<SvStudLockerReq>|SvStudLockerReqCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvStudLockerReq child in entity.SvStudLockerReqCollection)
					{
						if(child.SvCdeLockerIdSource != null)
						{
							child.SvCdeLockerId = child.SvCdeLockerIdSource.SvCdeLockerId;
						}
						else
						{
							child.SvCdeLockerId = entity.SvCdeLockerId;
						}

					}

					if (entity.SvStudLockerReqCollection.Count > 0 || entity.SvStudLockerReqCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvStudLockerReqProvider.Save(transactionManager, entity.SvStudLockerReqCollection);
						
						deepHandles.Add("SvStudLockerReqCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvStudLockerReq >) DataRepository.SvStudLockerReqProvider.DeepSave,
							new object[] { transactionManager, entity.SvStudLockerReqCollection, deepSaveType, childTypes, innerList }
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
	
	#region SvCdeLockerChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SvCdeLocker</c>
	///</summary>
	public enum SvCdeLockerChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>ScBuilding</c> at ScBuildingIdSource
		///</summary>
		[ChildEntityType(typeof(ScBuilding))]
		ScBuilding,
		///<summary>
		/// Collection of <c>SvCdeLocker</c> as OneToMany for SvStudLockerReqCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvStudLockerReq>))]
		SvStudLockerReqCollection,
	}
	
	#endregion SvCdeLockerChildEntityTypes
	
	#region SvCdeLockerFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SvCdeLockerColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvCdeLocker"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SvCdeLockerFilterBuilder : SqlFilterBuilder<SvCdeLockerColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvCdeLockerFilterBuilder class.
		/// </summary>
		public SvCdeLockerFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SvCdeLockerFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SvCdeLockerFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SvCdeLockerFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SvCdeLockerFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SvCdeLockerFilterBuilder
	
	#region SvCdeLockerParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SvCdeLockerColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvCdeLocker"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SvCdeLockerParameterBuilder : ParameterizedSqlFilterBuilder<SvCdeLockerColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvCdeLockerParameterBuilder class.
		/// </summary>
		public SvCdeLockerParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SvCdeLockerParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SvCdeLockerParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SvCdeLockerParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SvCdeLockerParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SvCdeLockerParameterBuilder
	
	#region SvCdeLockerSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SvCdeLockerColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvCdeLocker"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SvCdeLockerSortBuilder : SqlSortBuilder<SvCdeLockerColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvCdeLockerSqlSortBuilder class.
		/// </summary>
		public SvCdeLockerSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SvCdeLockerSortBuilder
	
} // end namespace
