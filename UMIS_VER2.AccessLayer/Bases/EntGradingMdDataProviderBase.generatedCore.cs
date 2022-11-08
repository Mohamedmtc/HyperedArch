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
	/// This class is the base class for any <see cref="EntGradingMdDataProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EntGradingMdDataProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EntGradingMdData, UMIS_VER2.BusinessLyer.EntGradingMdDataKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntGradingMdDataKey key)
		{
			return Delete(transactionManager, key.EntGradingMdDataId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_entGradingMdDataId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _entGradingMdDataId)
		{
			return Delete(null, _entGradingMdDataId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entGradingMdDataId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _entGradingMdDataId);		
		
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
		public override UMIS_VER2.BusinessLyer.EntGradingMdData Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntGradingMdDataKey key, int start, int pageLength)
		{
			return GetByEntGradingMdDataId(transactionManager, key.EntGradingMdDataId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ENT_GRADING_MD_ID_1 index.
		/// </summary>
		/// <param name="_entGradingMdId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntGradingMdData&gt;"/> class.</returns>
		public TList<EntGradingMdData> GetByEntGradingMdId(System.Decimal _entGradingMdId)
		{
			int count = -1;
			return GetByEntGradingMdId(null,_entGradingMdId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_GRADING_MD_ID_1 index.
		/// </summary>
		/// <param name="_entGradingMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntGradingMdData&gt;"/> class.</returns>
		public TList<EntGradingMdData> GetByEntGradingMdId(System.Decimal _entGradingMdId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntGradingMdId(null, _entGradingMdId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_GRADING_MD_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entGradingMdId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntGradingMdData&gt;"/> class.</returns>
		public TList<EntGradingMdData> GetByEntGradingMdId(TransactionManager transactionManager, System.Decimal _entGradingMdId)
		{
			int count = -1;
			return GetByEntGradingMdId(transactionManager, _entGradingMdId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_GRADING_MD_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entGradingMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntGradingMdData&gt;"/> class.</returns>
		public TList<EntGradingMdData> GetByEntGradingMdId(TransactionManager transactionManager, System.Decimal _entGradingMdId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntGradingMdId(transactionManager, _entGradingMdId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_GRADING_MD_ID_1 index.
		/// </summary>
		/// <param name="_entGradingMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntGradingMdData&gt;"/> class.</returns>
		public TList<EntGradingMdData> GetByEntGradingMdId(System.Decimal _entGradingMdId, int start, int pageLength, out int count)
		{
			return GetByEntGradingMdId(null, _entGradingMdId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_GRADING_MD_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entGradingMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntGradingMdData&gt;"/> class.</returns>
		public abstract TList<EntGradingMdData> GetByEntGradingMdId(TransactionManager transactionManager, System.Decimal _entGradingMdId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ENT_MAIN_ID_1 index.
		/// </summary>
		/// <param name="_entMainId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntGradingMdData&gt;"/> class.</returns>
		public TList<EntGradingMdData> GetByEntMainId(System.Decimal _entMainId)
		{
			int count = -1;
			return GetByEntMainId(null,_entMainId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_MAIN_ID_1 index.
		/// </summary>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntGradingMdData&gt;"/> class.</returns>
		public TList<EntGradingMdData> GetByEntMainId(System.Decimal _entMainId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMainId(null, _entMainId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_MAIN_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntGradingMdData&gt;"/> class.</returns>
		public TList<EntGradingMdData> GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId)
		{
			int count = -1;
			return GetByEntMainId(transactionManager, _entMainId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_MAIN_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntGradingMdData&gt;"/> class.</returns>
		public TList<EntGradingMdData> GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMainId(transactionManager, _entMainId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_MAIN_ID_1 index.
		/// </summary>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntGradingMdData&gt;"/> class.</returns>
		public TList<EntGradingMdData> GetByEntMainId(System.Decimal _entMainId, int start, int pageLength, out int count)
		{
			return GetByEntMainId(null, _entMainId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_MAIN_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntGradingMdData&gt;"/> class.</returns>
		public abstract TList<EntGradingMdData> GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ENT_GRADING_MD_DATA index.
		/// </summary>
		/// <param name="_entGradingMdDataId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntGradingMdData"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntGradingMdData GetByEntGradingMdDataId(System.Decimal _entGradingMdDataId)
		{
			int count = -1;
			return GetByEntGradingMdDataId(null,_entGradingMdDataId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_GRADING_MD_DATA index.
		/// </summary>
		/// <param name="_entGradingMdDataId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntGradingMdData"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntGradingMdData GetByEntGradingMdDataId(System.Decimal _entGradingMdDataId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntGradingMdDataId(null, _entGradingMdDataId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_GRADING_MD_DATA index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entGradingMdDataId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntGradingMdData"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntGradingMdData GetByEntGradingMdDataId(TransactionManager transactionManager, System.Decimal _entGradingMdDataId)
		{
			int count = -1;
			return GetByEntGradingMdDataId(transactionManager, _entGradingMdDataId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_GRADING_MD_DATA index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entGradingMdDataId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntGradingMdData"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntGradingMdData GetByEntGradingMdDataId(TransactionManager transactionManager, System.Decimal _entGradingMdDataId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntGradingMdDataId(transactionManager, _entGradingMdDataId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_GRADING_MD_DATA index.
		/// </summary>
		/// <param name="_entGradingMdDataId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntGradingMdData"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntGradingMdData GetByEntGradingMdDataId(System.Decimal _entGradingMdDataId, int start, int pageLength, out int count)
		{
			return GetByEntGradingMdDataId(null, _entGradingMdDataId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_GRADING_MD_DATA index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entGradingMdDataId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntGradingMdData"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EntGradingMdData GetByEntGradingMdDataId(TransactionManager transactionManager, System.Decimal _entGradingMdDataId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EntGradingMdData&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EntGradingMdData&gt;"/></returns>
		public static TList<EntGradingMdData> Fill(IDataReader reader, TList<EntGradingMdData> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EntGradingMdData c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EntGradingMdData")
					.Append("|").Append((System.Decimal)reader["ENT_GRADING_MD_DATA_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EntGradingMdData>(
					key.ToString(), // EntityTrackingKey
					"EntGradingMdData",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EntGradingMdData();
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
					c.EntGradingMdDataId = (System.Decimal)reader["ENT_GRADING_MD_DATA_ID"];
					c.OriginalEntGradingMdDataId = c.EntGradingMdDataId;
					c.EntGradingMdId = (System.Decimal)reader["ENT_GRADING_MD_ID"];
					c.EntMainId = (System.Decimal)reader["ENT_MAIN_ID"];
					c.MdValue = (System.String)reader["MD_VALUE"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntGradingMdData"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntGradingMdData"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EntGradingMdData entity)
		{
			if (!reader.Read()) return;
			
			entity.EntGradingMdDataId = (System.Decimal)reader[((int)EntGradingMdDataColumn.EntGradingMdDataId - 1)];
			entity.OriginalEntGradingMdDataId = (System.Decimal)reader["ENT_GRADING_MD_DATA_ID"];
			entity.EntGradingMdId = (System.Decimal)reader[((int)EntGradingMdDataColumn.EntGradingMdId - 1)];
			entity.EntMainId = (System.Decimal)reader[((int)EntGradingMdDataColumn.EntMainId - 1)];
			entity.MdValue = (System.String)reader[((int)EntGradingMdDataColumn.MdValue - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntGradingMdData"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntGradingMdData"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EntGradingMdData entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EntGradingMdDataId = (System.Decimal)dataRow["ENT_GRADING_MD_DATA_ID"];
			entity.OriginalEntGradingMdDataId = (System.Decimal)dataRow["ENT_GRADING_MD_DATA_ID"];
			entity.EntGradingMdId = (System.Decimal)dataRow["ENT_GRADING_MD_ID"];
			entity.EntMainId = (System.Decimal)dataRow["ENT_MAIN_ID"];
			entity.MdValue = (System.String)dataRow["MD_VALUE"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntGradingMdData"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntGradingMdData Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntGradingMdData entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EntGradingMdIdSource	
			if (CanDeepLoad(entity, "EntGradingMetadata|EntGradingMdIdSource", deepLoadType, innerList) 
				&& entity.EntGradingMdIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EntGradingMdId;
				EntGradingMetadata tmpEntity = EntityManager.LocateEntity<EntGradingMetadata>(EntityLocator.ConstructKeyFromPkItems(typeof(EntGradingMetadata), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EntGradingMdIdSource = tmpEntity;
				else
					entity.EntGradingMdIdSource = DataRepository.EntGradingMetadataProvider.GetByEntGradingMdId(transactionManager, entity.EntGradingMdId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntGradingMdIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EntGradingMdIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EntGradingMetadataProvider.DeepLoad(transactionManager, entity.EntGradingMdIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EntGradingMdIdSource

			#region EntMainIdSource	
			if (CanDeepLoad(entity, "EntityMain|EntMainIdSource", deepLoadType, innerList) 
				&& entity.EntMainIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EntMainId;
				EntityMain tmpEntity = EntityManager.LocateEntity<EntityMain>(EntityLocator.ConstructKeyFromPkItems(typeof(EntityMain), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EntMainIdSource = tmpEntity;
				else
					entity.EntMainIdSource = DataRepository.EntityMainProvider.GetByEntMainId(transactionManager, entity.EntMainId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntMainIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EntMainIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EntityMainProvider.DeepLoad(transactionManager, entity.EntMainIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EntMainIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EntGradingMdData object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EntGradingMdData instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntGradingMdData Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntGradingMdData entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EntGradingMdIdSource
			if (CanDeepSave(entity, "EntGradingMetadata|EntGradingMdIdSource", deepSaveType, innerList) 
				&& entity.EntGradingMdIdSource != null)
			{
				DataRepository.EntGradingMetadataProvider.Save(transactionManager, entity.EntGradingMdIdSource);
				entity.EntGradingMdId = entity.EntGradingMdIdSource.EntGradingMdId;
			}
			#endregion 
			
			#region EntMainIdSource
			if (CanDeepSave(entity, "EntityMain|EntMainIdSource", deepSaveType, innerList) 
				&& entity.EntMainIdSource != null)
			{
				DataRepository.EntityMainProvider.Save(transactionManager, entity.EntMainIdSource);
				entity.EntMainId = entity.EntMainIdSource.EntMainId;
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
	
	#region EntGradingMdDataChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EntGradingMdData</c>
	///</summary>
	public enum EntGradingMdDataChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EntGradingMetadata</c> at EntGradingMdIdSource
		///</summary>
		[ChildEntityType(typeof(EntGradingMetadata))]
		EntGradingMetadata,
		
		///<summary>
		/// Composite Property for <c>EntityMain</c> at EntMainIdSource
		///</summary>
		[ChildEntityType(typeof(EntityMain))]
		EntityMain,
	}
	
	#endregion EntGradingMdDataChildEntityTypes
	
	#region EntGradingMdDataFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntGradingMdDataColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntGradingMdData"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntGradingMdDataFilterBuilder : SqlFilterBuilder<EntGradingMdDataColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntGradingMdDataFilterBuilder class.
		/// </summary>
		public EntGradingMdDataFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntGradingMdDataFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntGradingMdDataFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntGradingMdDataFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntGradingMdDataFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntGradingMdDataFilterBuilder
	
	#region EntGradingMdDataParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntGradingMdDataColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntGradingMdData"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntGradingMdDataParameterBuilder : ParameterizedSqlFilterBuilder<EntGradingMdDataColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntGradingMdDataParameterBuilder class.
		/// </summary>
		public EntGradingMdDataParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntGradingMdDataParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntGradingMdDataParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntGradingMdDataParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntGradingMdDataParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntGradingMdDataParameterBuilder
	
	#region EntGradingMdDataSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntGradingMdDataColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntGradingMdData"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EntGradingMdDataSortBuilder : SqlSortBuilder<EntGradingMdDataColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntGradingMdDataSqlSortBuilder class.
		/// </summary>
		public EntGradingMdDataSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EntGradingMdDataSortBuilder
	
} // end namespace
