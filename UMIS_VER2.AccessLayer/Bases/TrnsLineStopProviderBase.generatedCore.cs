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
	/// This class is the base class for any <see cref="TrnsLineStopProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class TrnsLineStopProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.TrnsLineStop, UMIS_VER2.BusinessLyer.TrnsLineStopKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.TrnsLineStopKey key)
		{
			return Delete(transactionManager, key.TrnsLineStopId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_trnsLineStopId">محطات خط باص. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _trnsLineStopId)
		{
			return Delete(null, _trnsLineStopId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_trnsLineStopId">محطات خط باص. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _trnsLineStopId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_LINE_STOP_TRNS_CDE_STOP1 key.
		///		FK_TRNS_LINE_STOP_TRNS_CDE_STOP1 Description: 
		/// </summary>
		/// <param name="_trnsCdeStopId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsLineStop objects.</returns>
		public TList<TrnsLineStop> GetByTrnsCdeStopId(System.Decimal _trnsCdeStopId)
		{
			int count = -1;
			return GetByTrnsCdeStopId(_trnsCdeStopId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_LINE_STOP_TRNS_CDE_STOP1 key.
		///		FK_TRNS_LINE_STOP_TRNS_CDE_STOP1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_trnsCdeStopId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsLineStop objects.</returns>
		/// <remarks></remarks>
		public TList<TrnsLineStop> GetByTrnsCdeStopId(TransactionManager transactionManager, System.Decimal _trnsCdeStopId)
		{
			int count = -1;
			return GetByTrnsCdeStopId(transactionManager, _trnsCdeStopId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_LINE_STOP_TRNS_CDE_STOP1 key.
		///		FK_TRNS_LINE_STOP_TRNS_CDE_STOP1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_trnsCdeStopId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsLineStop objects.</returns>
		public TList<TrnsLineStop> GetByTrnsCdeStopId(TransactionManager transactionManager, System.Decimal _trnsCdeStopId, int start, int pageLength)
		{
			int count = -1;
			return GetByTrnsCdeStopId(transactionManager, _trnsCdeStopId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_LINE_STOP_TRNS_CDE_STOP1 key.
		///		fkTrnsLineStopTrnsCdeStop1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_trnsCdeStopId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsLineStop objects.</returns>
		public TList<TrnsLineStop> GetByTrnsCdeStopId(System.Decimal _trnsCdeStopId, int start, int pageLength)
		{
			int count =  -1;
			return GetByTrnsCdeStopId(null, _trnsCdeStopId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_LINE_STOP_TRNS_CDE_STOP1 key.
		///		fkTrnsLineStopTrnsCdeStop1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_trnsCdeStopId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsLineStop objects.</returns>
		public TList<TrnsLineStop> GetByTrnsCdeStopId(System.Decimal _trnsCdeStopId, int start, int pageLength,out int count)
		{
			return GetByTrnsCdeStopId(null, _trnsCdeStopId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_LINE_STOP_TRNS_CDE_STOP1 key.
		///		FK_TRNS_LINE_STOP_TRNS_CDE_STOP1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_trnsCdeStopId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsLineStop objects.</returns>
		public abstract TList<TrnsLineStop> GetByTrnsCdeStopId(TransactionManager transactionManager, System.Decimal _trnsCdeStopId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_LINE_STOP_TRNS_LINE1 key.
		///		FK_TRNS_LINE_STOP_TRNS_LINE1 Description: 
		/// </summary>
		/// <param name="_trnsLineId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsLineStop objects.</returns>
		public TList<TrnsLineStop> GetByTrnsLineId(System.Decimal _trnsLineId)
		{
			int count = -1;
			return GetByTrnsLineId(_trnsLineId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_LINE_STOP_TRNS_LINE1 key.
		///		FK_TRNS_LINE_STOP_TRNS_LINE1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_trnsLineId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsLineStop objects.</returns>
		/// <remarks></remarks>
		public TList<TrnsLineStop> GetByTrnsLineId(TransactionManager transactionManager, System.Decimal _trnsLineId)
		{
			int count = -1;
			return GetByTrnsLineId(transactionManager, _trnsLineId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_LINE_STOP_TRNS_LINE1 key.
		///		FK_TRNS_LINE_STOP_TRNS_LINE1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_trnsLineId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsLineStop objects.</returns>
		public TList<TrnsLineStop> GetByTrnsLineId(TransactionManager transactionManager, System.Decimal _trnsLineId, int start, int pageLength)
		{
			int count = -1;
			return GetByTrnsLineId(transactionManager, _trnsLineId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_LINE_STOP_TRNS_LINE1 key.
		///		fkTrnsLineStopTrnsLine1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_trnsLineId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsLineStop objects.</returns>
		public TList<TrnsLineStop> GetByTrnsLineId(System.Decimal _trnsLineId, int start, int pageLength)
		{
			int count =  -1;
			return GetByTrnsLineId(null, _trnsLineId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_LINE_STOP_TRNS_LINE1 key.
		///		fkTrnsLineStopTrnsLine1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_trnsLineId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsLineStop objects.</returns>
		public TList<TrnsLineStop> GetByTrnsLineId(System.Decimal _trnsLineId, int start, int pageLength,out int count)
		{
			return GetByTrnsLineId(null, _trnsLineId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_TRNS_LINE_STOP_TRNS_LINE1 key.
		///		FK_TRNS_LINE_STOP_TRNS_LINE1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_trnsLineId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.TrnsLineStop objects.</returns>
		public abstract TList<TrnsLineStop> GetByTrnsLineId(TransactionManager transactionManager, System.Decimal _trnsLineId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.TrnsLineStop Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.TrnsLineStopKey key, int start, int pageLength)
		{
			return GetByTrnsLineStopId(transactionManager, key.TrnsLineStopId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_TRNS_LINE_STOP_1 index.
		/// </summary>
		/// <param name="_trnsLineStopId">محطات خط باص</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsLineStop"/> class.</returns>
		public UMIS_VER2.BusinessLyer.TrnsLineStop GetByTrnsLineStopId(System.Decimal _trnsLineStopId)
		{
			int count = -1;
			return GetByTrnsLineStopId(null,_trnsLineStopId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_TRNS_LINE_STOP_1 index.
		/// </summary>
		/// <param name="_trnsLineStopId">محطات خط باص</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsLineStop"/> class.</returns>
		public UMIS_VER2.BusinessLyer.TrnsLineStop GetByTrnsLineStopId(System.Decimal _trnsLineStopId, int start, int pageLength)
		{
			int count = -1;
			return GetByTrnsLineStopId(null, _trnsLineStopId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_TRNS_LINE_STOP_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_trnsLineStopId">محطات خط باص</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsLineStop"/> class.</returns>
		public UMIS_VER2.BusinessLyer.TrnsLineStop GetByTrnsLineStopId(TransactionManager transactionManager, System.Decimal _trnsLineStopId)
		{
			int count = -1;
			return GetByTrnsLineStopId(transactionManager, _trnsLineStopId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_TRNS_LINE_STOP_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_trnsLineStopId">محطات خط باص</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsLineStop"/> class.</returns>
		public UMIS_VER2.BusinessLyer.TrnsLineStop GetByTrnsLineStopId(TransactionManager transactionManager, System.Decimal _trnsLineStopId, int start, int pageLength)
		{
			int count = -1;
			return GetByTrnsLineStopId(transactionManager, _trnsLineStopId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_TRNS_LINE_STOP_1 index.
		/// </summary>
		/// <param name="_trnsLineStopId">محطات خط باص</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsLineStop"/> class.</returns>
		public UMIS_VER2.BusinessLyer.TrnsLineStop GetByTrnsLineStopId(System.Decimal _trnsLineStopId, int start, int pageLength, out int count)
		{
			return GetByTrnsLineStopId(null, _trnsLineStopId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_TRNS_LINE_STOP_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_trnsLineStopId">محطات خط باص</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsLineStop"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.TrnsLineStop GetByTrnsLineStopId(TransactionManager transactionManager, System.Decimal _trnsLineStopId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;TrnsLineStop&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;TrnsLineStop&gt;"/></returns>
		public static TList<TrnsLineStop> Fill(IDataReader reader, TList<TrnsLineStop> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.TrnsLineStop c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("TrnsLineStop")
					.Append("|").Append((System.Decimal)reader["TRNS_LINE_STOP_ID"]).ToString();
					c = EntityManager.LocateOrCreate<TrnsLineStop>(
					key.ToString(), // EntityTrackingKey
					"TrnsLineStop",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.TrnsLineStop();
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
					c.TrnsLineStopId = (System.Decimal)reader["TRNS_LINE_STOP_ID"];
					c.OriginalTrnsLineStopId = c.TrnsLineStopId;
					c.TrnsLineId = (System.Decimal)reader["TRNS_LINE_ID"];
					c.TrnsCdeStopId = (System.Decimal)reader["TRNS_CDE_STOP_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.TrnsLineStop"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.TrnsLineStop"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.TrnsLineStop entity)
		{
			if (!reader.Read()) return;
			
			entity.TrnsLineStopId = (System.Decimal)reader[((int)TrnsLineStopColumn.TrnsLineStopId - 1)];
			entity.OriginalTrnsLineStopId = (System.Decimal)reader["TRNS_LINE_STOP_ID"];
			entity.TrnsLineId = (System.Decimal)reader[((int)TrnsLineStopColumn.TrnsLineId - 1)];
			entity.TrnsCdeStopId = (System.Decimal)reader[((int)TrnsLineStopColumn.TrnsCdeStopId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.TrnsLineStop"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.TrnsLineStop"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.TrnsLineStop entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.TrnsLineStopId = (System.Decimal)dataRow["TRNS_LINE_STOP_ID"];
			entity.OriginalTrnsLineStopId = (System.Decimal)dataRow["TRNS_LINE_STOP_ID"];
			entity.TrnsLineId = (System.Decimal)dataRow["TRNS_LINE_ID"];
			entity.TrnsCdeStopId = (System.Decimal)dataRow["TRNS_CDE_STOP_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.TrnsLineStop"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.TrnsLineStop Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.TrnsLineStop entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region TrnsCdeStopIdSource	
			if (CanDeepLoad(entity, "TrnsCdeStop|TrnsCdeStopIdSource", deepLoadType, innerList) 
				&& entity.TrnsCdeStopIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.TrnsCdeStopId;
				TrnsCdeStop tmpEntity = EntityManager.LocateEntity<TrnsCdeStop>(EntityLocator.ConstructKeyFromPkItems(typeof(TrnsCdeStop), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.TrnsCdeStopIdSource = tmpEntity;
				else
					entity.TrnsCdeStopIdSource = DataRepository.TrnsCdeStopProvider.GetByTrnsCdeStopId(transactionManager, entity.TrnsCdeStopId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'TrnsCdeStopIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.TrnsCdeStopIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.TrnsCdeStopProvider.DeepLoad(transactionManager, entity.TrnsCdeStopIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion TrnsCdeStopIdSource

			#region TrnsLineIdSource	
			if (CanDeepLoad(entity, "TrnsLine|TrnsLineIdSource", deepLoadType, innerList) 
				&& entity.TrnsLineIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.TrnsLineId;
				TrnsLine tmpEntity = EntityManager.LocateEntity<TrnsLine>(EntityLocator.ConstructKeyFromPkItems(typeof(TrnsLine), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.TrnsLineIdSource = tmpEntity;
				else
					entity.TrnsLineIdSource = DataRepository.TrnsLineProvider.GetByTrnsLineId(transactionManager, entity.TrnsLineId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'TrnsLineIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.TrnsLineIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.TrnsLineProvider.DeepLoad(transactionManager, entity.TrnsLineIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion TrnsLineIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.TrnsLineStop object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.TrnsLineStop instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.TrnsLineStop Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.TrnsLineStop entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region TrnsCdeStopIdSource
			if (CanDeepSave(entity, "TrnsCdeStop|TrnsCdeStopIdSource", deepSaveType, innerList) 
				&& entity.TrnsCdeStopIdSource != null)
			{
				DataRepository.TrnsCdeStopProvider.Save(transactionManager, entity.TrnsCdeStopIdSource);
				entity.TrnsCdeStopId = entity.TrnsCdeStopIdSource.TrnsCdeStopId;
			}
			#endregion 
			
			#region TrnsLineIdSource
			if (CanDeepSave(entity, "TrnsLine|TrnsLineIdSource", deepSaveType, innerList) 
				&& entity.TrnsLineIdSource != null)
			{
				DataRepository.TrnsLineProvider.Save(transactionManager, entity.TrnsLineIdSource);
				entity.TrnsLineId = entity.TrnsLineIdSource.TrnsLineId;
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
	
	#region TrnsLineStopChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.TrnsLineStop</c>
	///</summary>
	public enum TrnsLineStopChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>TrnsCdeStop</c> at TrnsCdeStopIdSource
		///</summary>
		[ChildEntityType(typeof(TrnsCdeStop))]
		TrnsCdeStop,
		
		///<summary>
		/// Composite Property for <c>TrnsLine</c> at TrnsLineIdSource
		///</summary>
		[ChildEntityType(typeof(TrnsLine))]
		TrnsLine,
	}
	
	#endregion TrnsLineStopChildEntityTypes
	
	#region TrnsLineStopFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;TrnsLineStopColumn&gt;"/> class
	/// that is used exclusively with a <see cref="TrnsLineStop"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TrnsLineStopFilterBuilder : SqlFilterBuilder<TrnsLineStopColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TrnsLineStopFilterBuilder class.
		/// </summary>
		public TrnsLineStopFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the TrnsLineStopFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public TrnsLineStopFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the TrnsLineStopFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public TrnsLineStopFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion TrnsLineStopFilterBuilder
	
	#region TrnsLineStopParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;TrnsLineStopColumn&gt;"/> class
	/// that is used exclusively with a <see cref="TrnsLineStop"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TrnsLineStopParameterBuilder : ParameterizedSqlFilterBuilder<TrnsLineStopColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TrnsLineStopParameterBuilder class.
		/// </summary>
		public TrnsLineStopParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the TrnsLineStopParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public TrnsLineStopParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the TrnsLineStopParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public TrnsLineStopParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion TrnsLineStopParameterBuilder
	
	#region TrnsLineStopSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;TrnsLineStopColumn&gt;"/> class
	/// that is used exclusively with a <see cref="TrnsLineStop"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class TrnsLineStopSortBuilder : SqlSortBuilder<TrnsLineStopColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TrnsLineStopSqlSortBuilder class.
		/// </summary>
		public TrnsLineStopSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion TrnsLineStopSortBuilder
	
} // end namespace
