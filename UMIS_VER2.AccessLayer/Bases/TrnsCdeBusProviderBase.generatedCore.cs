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
	/// This class is the base class for any <see cref="TrnsCdeBusProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class TrnsCdeBusProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.TrnsCdeBus, UMIS_VER2.BusinessLyer.TrnsCdeBusKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.TrnsCdeBusKey key)
		{
			return Delete(transactionManager, key.TrnsCdeBusId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_trnsCdeBusId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _trnsCdeBusId)
		{
			return Delete(null, _trnsCdeBusId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_trnsCdeBusId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _trnsCdeBusId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
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
		public override UMIS_VER2.BusinessLyer.TrnsCdeBus Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.TrnsCdeBusKey key, int start, int pageLength)
		{
			return GetByTrnsCdeBusId(transactionManager, key.TrnsCdeBusId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_TRNS_CDE_BUS index.
		/// </summary>
		/// <param name="_trnsCdeBusId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsCdeBus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.TrnsCdeBus GetByTrnsCdeBusId(System.Decimal _trnsCdeBusId)
		{
			int count = -1;
			return GetByTrnsCdeBusId(null,_trnsCdeBusId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_TRNS_CDE_BUS index.
		/// </summary>
		/// <param name="_trnsCdeBusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsCdeBus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.TrnsCdeBus GetByTrnsCdeBusId(System.Decimal _trnsCdeBusId, int start, int pageLength)
		{
			int count = -1;
			return GetByTrnsCdeBusId(null, _trnsCdeBusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_TRNS_CDE_BUS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_trnsCdeBusId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsCdeBus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.TrnsCdeBus GetByTrnsCdeBusId(TransactionManager transactionManager, System.Decimal _trnsCdeBusId)
		{
			int count = -1;
			return GetByTrnsCdeBusId(transactionManager, _trnsCdeBusId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_TRNS_CDE_BUS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_trnsCdeBusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsCdeBus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.TrnsCdeBus GetByTrnsCdeBusId(TransactionManager transactionManager, System.Decimal _trnsCdeBusId, int start, int pageLength)
		{
			int count = -1;
			return GetByTrnsCdeBusId(transactionManager, _trnsCdeBusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_TRNS_CDE_BUS index.
		/// </summary>
		/// <param name="_trnsCdeBusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsCdeBus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.TrnsCdeBus GetByTrnsCdeBusId(System.Decimal _trnsCdeBusId, int start, int pageLength, out int count)
		{
			return GetByTrnsCdeBusId(null, _trnsCdeBusId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_TRNS_CDE_BUS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_trnsCdeBusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsCdeBus"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.TrnsCdeBus GetByTrnsCdeBusId(TransactionManager transactionManager, System.Decimal _trnsCdeBusId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_TRNS_CDE_BUS index.
		/// </summary>
		/// <param name="_busNo"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsCdeBus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.TrnsCdeBus GetByBusNo(System.Decimal _busNo)
		{
			int count = -1;
			return GetByBusNo(null,_busNo, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_TRNS_CDE_BUS index.
		/// </summary>
		/// <param name="_busNo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsCdeBus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.TrnsCdeBus GetByBusNo(System.Decimal _busNo, int start, int pageLength)
		{
			int count = -1;
			return GetByBusNo(null, _busNo, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_TRNS_CDE_BUS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_busNo"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsCdeBus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.TrnsCdeBus GetByBusNo(TransactionManager transactionManager, System.Decimal _busNo)
		{
			int count = -1;
			return GetByBusNo(transactionManager, _busNo, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_TRNS_CDE_BUS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_busNo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsCdeBus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.TrnsCdeBus GetByBusNo(TransactionManager transactionManager, System.Decimal _busNo, int start, int pageLength)
		{
			int count = -1;
			return GetByBusNo(transactionManager, _busNo, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_TRNS_CDE_BUS index.
		/// </summary>
		/// <param name="_busNo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsCdeBus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.TrnsCdeBus GetByBusNo(System.Decimal _busNo, int start, int pageLength, out int count)
		{
			return GetByBusNo(null, _busNo, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_TRNS_CDE_BUS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_busNo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.TrnsCdeBus"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.TrnsCdeBus GetByBusNo(TransactionManager transactionManager, System.Decimal _busNo, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_TRNS_CDE_BUS_BOARD index.
		/// </summary>
		/// <param name="_boardNo"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;TrnsCdeBus&gt;"/> class.</returns>
		public TList<TrnsCdeBus> GetByBoardNo(System.String _boardNo)
		{
			int count = -1;
			return GetByBoardNo(null,_boardNo, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_TRNS_CDE_BUS_BOARD index.
		/// </summary>
		/// <param name="_boardNo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;TrnsCdeBus&gt;"/> class.</returns>
		public TList<TrnsCdeBus> GetByBoardNo(System.String _boardNo, int start, int pageLength)
		{
			int count = -1;
			return GetByBoardNo(null, _boardNo, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_TRNS_CDE_BUS_BOARD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_boardNo"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;TrnsCdeBus&gt;"/> class.</returns>
		public TList<TrnsCdeBus> GetByBoardNo(TransactionManager transactionManager, System.String _boardNo)
		{
			int count = -1;
			return GetByBoardNo(transactionManager, _boardNo, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_TRNS_CDE_BUS_BOARD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_boardNo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;TrnsCdeBus&gt;"/> class.</returns>
		public TList<TrnsCdeBus> GetByBoardNo(TransactionManager transactionManager, System.String _boardNo, int start, int pageLength)
		{
			int count = -1;
			return GetByBoardNo(transactionManager, _boardNo, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_TRNS_CDE_BUS_BOARD index.
		/// </summary>
		/// <param name="_boardNo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;TrnsCdeBus&gt;"/> class.</returns>
		public TList<TrnsCdeBus> GetByBoardNo(System.String _boardNo, int start, int pageLength, out int count)
		{
			return GetByBoardNo(null, _boardNo, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_TRNS_CDE_BUS_BOARD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_boardNo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;TrnsCdeBus&gt;"/> class.</returns>
		public abstract TList<TrnsCdeBus> GetByBoardNo(TransactionManager transactionManager, System.String _boardNo, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;TrnsCdeBus&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;TrnsCdeBus&gt;"/></returns>
		public static TList<TrnsCdeBus> Fill(IDataReader reader, TList<TrnsCdeBus> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.TrnsCdeBus c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("TrnsCdeBus")
					.Append("|").Append((System.Decimal)reader["TRNS_CDE_BUS_ID"]).ToString();
					c = EntityManager.LocateOrCreate<TrnsCdeBus>(
					key.ToString(), // EntityTrackingKey
					"TrnsCdeBus",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.TrnsCdeBus();
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
					c.TrnsCdeBusId = (System.Decimal)reader["TRNS_CDE_BUS_ID"];
					c.OriginalTrnsCdeBusId = c.TrnsCdeBusId;
					c.BusNo = (System.Decimal)reader["BUS_NO"];
					c.BoardNo = Convert.IsDBNull(reader["BOARD_NO"]) ? null : (System.String)reader["BOARD_NO"];
					c.ModelNo = Convert.IsDBNull(reader["MODEL_NO"]) ? null : (System.String)reader["MODEL_NO"];
					c.SeatCount = (System.Decimal)reader["SEAT_COUNT"];
					c.IsActive = (System.Decimal)reader["IS_ACTIVE"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.TrnsCdeBus"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.TrnsCdeBus"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.TrnsCdeBus entity)
		{
			if (!reader.Read()) return;
			
			entity.TrnsCdeBusId = (System.Decimal)reader[((int)TrnsCdeBusColumn.TrnsCdeBusId - 1)];
			entity.OriginalTrnsCdeBusId = (System.Decimal)reader["TRNS_CDE_BUS_ID"];
			entity.BusNo = (System.Decimal)reader[((int)TrnsCdeBusColumn.BusNo - 1)];
			entity.BoardNo = (reader.IsDBNull(((int)TrnsCdeBusColumn.BoardNo - 1)))?null:(System.String)reader[((int)TrnsCdeBusColumn.BoardNo - 1)];
			entity.ModelNo = (reader.IsDBNull(((int)TrnsCdeBusColumn.ModelNo - 1)))?null:(System.String)reader[((int)TrnsCdeBusColumn.ModelNo - 1)];
			entity.SeatCount = (System.Decimal)reader[((int)TrnsCdeBusColumn.SeatCount - 1)];
			entity.IsActive = (System.Decimal)reader[((int)TrnsCdeBusColumn.IsActive - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.TrnsCdeBus"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.TrnsCdeBus"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.TrnsCdeBus entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.TrnsCdeBusId = (System.Decimal)dataRow["TRNS_CDE_BUS_ID"];
			entity.OriginalTrnsCdeBusId = (System.Decimal)dataRow["TRNS_CDE_BUS_ID"];
			entity.BusNo = (System.Decimal)dataRow["BUS_NO"];
			entity.BoardNo = Convert.IsDBNull(dataRow["BOARD_NO"]) ? null : (System.String)dataRow["BOARD_NO"];
			entity.ModelNo = Convert.IsDBNull(dataRow["MODEL_NO"]) ? null : (System.String)dataRow["MODEL_NO"];
			entity.SeatCount = (System.Decimal)dataRow["SEAT_COUNT"];
			entity.IsActive = (System.Decimal)dataRow["IS_ACTIVE"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.TrnsCdeBus"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.TrnsCdeBus Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.TrnsCdeBus entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByTrnsCdeBusId methods when available
			
			#region TrnsLineCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<TrnsLine>|TrnsLineCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'TrnsLineCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.TrnsLineCollection = DataRepository.TrnsLineProvider.GetByTrnsCdeBusId(transactionManager, entity.TrnsCdeBusId);

				if (deep && entity.TrnsLineCollection.Count > 0)
				{
					deepHandles.Add("TrnsLineCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<TrnsLine>) DataRepository.TrnsLineProvider.DeepLoad,
						new object[] { transactionManager, entity.TrnsLineCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.TrnsCdeBus object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.TrnsCdeBus instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.TrnsCdeBus Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.TrnsCdeBus entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<TrnsLine>
				if (CanDeepSave(entity.TrnsLineCollection, "List<TrnsLine>|TrnsLineCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(TrnsLine child in entity.TrnsLineCollection)
					{
						if(child.TrnsCdeBusIdSource != null)
						{
							child.TrnsCdeBusId = child.TrnsCdeBusIdSource.TrnsCdeBusId;
						}
						else
						{
							child.TrnsCdeBusId = entity.TrnsCdeBusId;
						}

					}

					if (entity.TrnsLineCollection.Count > 0 || entity.TrnsLineCollection.DeletedItems.Count > 0)
					{
						//DataRepository.TrnsLineProvider.Save(transactionManager, entity.TrnsLineCollection);
						
						deepHandles.Add("TrnsLineCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< TrnsLine >) DataRepository.TrnsLineProvider.DeepSave,
							new object[] { transactionManager, entity.TrnsLineCollection, deepSaveType, childTypes, innerList }
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
	
	#region TrnsCdeBusChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.TrnsCdeBus</c>
	///</summary>
	public enum TrnsCdeBusChildEntityTypes
	{
		///<summary>
		/// Collection of <c>TrnsCdeBus</c> as OneToMany for TrnsLineCollection
		///</summary>
		[ChildEntityType(typeof(TList<TrnsLine>))]
		TrnsLineCollection,
	}
	
	#endregion TrnsCdeBusChildEntityTypes
	
	#region TrnsCdeBusFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;TrnsCdeBusColumn&gt;"/> class
	/// that is used exclusively with a <see cref="TrnsCdeBus"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TrnsCdeBusFilterBuilder : SqlFilterBuilder<TrnsCdeBusColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TrnsCdeBusFilterBuilder class.
		/// </summary>
		public TrnsCdeBusFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the TrnsCdeBusFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public TrnsCdeBusFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the TrnsCdeBusFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public TrnsCdeBusFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion TrnsCdeBusFilterBuilder
	
	#region TrnsCdeBusParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;TrnsCdeBusColumn&gt;"/> class
	/// that is used exclusively with a <see cref="TrnsCdeBus"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TrnsCdeBusParameterBuilder : ParameterizedSqlFilterBuilder<TrnsCdeBusColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TrnsCdeBusParameterBuilder class.
		/// </summary>
		public TrnsCdeBusParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the TrnsCdeBusParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public TrnsCdeBusParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the TrnsCdeBusParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public TrnsCdeBusParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion TrnsCdeBusParameterBuilder
	
	#region TrnsCdeBusSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;TrnsCdeBusColumn&gt;"/> class
	/// that is used exclusively with a <see cref="TrnsCdeBus"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class TrnsCdeBusSortBuilder : SqlSortBuilder<TrnsCdeBusColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TrnsCdeBusSqlSortBuilder class.
		/// </summary>
		public TrnsCdeBusSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion TrnsCdeBusSortBuilder
	
} // end namespace
