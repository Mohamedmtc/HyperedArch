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
	/// This class is the base class for any <see cref="EntPolicyMdDataProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EntPolicyMdDataProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EntPolicyMdData, UMIS_VER2.BusinessLyer.EntPolicyMdDataKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPolicyMdDataKey key)
		{
			return Delete(transactionManager, key.EntPolicyMdDataId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_entPolicyMdDataId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _entPolicyMdDataId)
		{
			return Delete(null, _entPolicyMdDataId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyMdDataId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _entPolicyMdDataId);		
		
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
		public override UMIS_VER2.BusinessLyer.EntPolicyMdData Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPolicyMdDataKey key, int start, int pageLength)
		{
			return GetByEntPolicyMdDataId(transactionManager, key.EntPolicyMdDataId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ENT_MAIN_ID_1 index.
		/// </summary>
		/// <param name="_entMainId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyMdData&gt;"/> class.</returns>
		public TList<EntPolicyMdData> GetByEntMainId(System.Decimal _entMainId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyMdData&gt;"/> class.</returns>
		public TList<EntPolicyMdData> GetByEntMainId(System.Decimal _entMainId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyMdData&gt;"/> class.</returns>
		public TList<EntPolicyMdData> GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyMdData&gt;"/> class.</returns>
		public TList<EntPolicyMdData> GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyMdData&gt;"/> class.</returns>
		public TList<EntPolicyMdData> GetByEntMainId(System.Decimal _entMainId, int start, int pageLength, out int count)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyMdData&gt;"/> class.</returns>
		public abstract TList<EntPolicyMdData> GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ENT_POLICY_MD_ID_1 index.
		/// </summary>
		/// <param name="_entPolicyMdId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyMdData&gt;"/> class.</returns>
		public TList<EntPolicyMdData> GetByEntPolicyMdId(System.Decimal _entPolicyMdId)
		{
			int count = -1;
			return GetByEntPolicyMdId(null,_entPolicyMdId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_POLICY_MD_ID_1 index.
		/// </summary>
		/// <param name="_entPolicyMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyMdData&gt;"/> class.</returns>
		public TList<EntPolicyMdData> GetByEntPolicyMdId(System.Decimal _entPolicyMdId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntPolicyMdId(null, _entPolicyMdId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_POLICY_MD_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyMdId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyMdData&gt;"/> class.</returns>
		public TList<EntPolicyMdData> GetByEntPolicyMdId(TransactionManager transactionManager, System.Decimal _entPolicyMdId)
		{
			int count = -1;
			return GetByEntPolicyMdId(transactionManager, _entPolicyMdId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_POLICY_MD_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyMdData&gt;"/> class.</returns>
		public TList<EntPolicyMdData> GetByEntPolicyMdId(TransactionManager transactionManager, System.Decimal _entPolicyMdId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntPolicyMdId(transactionManager, _entPolicyMdId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_POLICY_MD_ID_1 index.
		/// </summary>
		/// <param name="_entPolicyMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyMdData&gt;"/> class.</returns>
		public TList<EntPolicyMdData> GetByEntPolicyMdId(System.Decimal _entPolicyMdId, int start, int pageLength, out int count)
		{
			return GetByEntPolicyMdId(null, _entPolicyMdId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_POLICY_MD_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyMdData&gt;"/> class.</returns>
		public abstract TList<EntPolicyMdData> GetByEntPolicyMdId(TransactionManager transactionManager, System.Decimal _entPolicyMdId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ENT_POLICY_MD_DATA index.
		/// </summary>
		/// <param name="_entPolicyMdDataId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyMdData"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyMdData GetByEntPolicyMdDataId(System.Decimal _entPolicyMdDataId)
		{
			int count = -1;
			return GetByEntPolicyMdDataId(null,_entPolicyMdDataId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_POLICY_MD_DATA index.
		/// </summary>
		/// <param name="_entPolicyMdDataId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyMdData"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyMdData GetByEntPolicyMdDataId(System.Decimal _entPolicyMdDataId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntPolicyMdDataId(null, _entPolicyMdDataId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_POLICY_MD_DATA index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyMdDataId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyMdData"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyMdData GetByEntPolicyMdDataId(TransactionManager transactionManager, System.Decimal _entPolicyMdDataId)
		{
			int count = -1;
			return GetByEntPolicyMdDataId(transactionManager, _entPolicyMdDataId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_POLICY_MD_DATA index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyMdDataId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyMdData"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyMdData GetByEntPolicyMdDataId(TransactionManager transactionManager, System.Decimal _entPolicyMdDataId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntPolicyMdDataId(transactionManager, _entPolicyMdDataId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_POLICY_MD_DATA index.
		/// </summary>
		/// <param name="_entPolicyMdDataId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyMdData"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyMdData GetByEntPolicyMdDataId(System.Decimal _entPolicyMdDataId, int start, int pageLength, out int count)
		{
			return GetByEntPolicyMdDataId(null, _entPolicyMdDataId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_POLICY_MD_DATA index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyMdDataId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyMdData"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EntPolicyMdData GetByEntPolicyMdDataId(TransactionManager transactionManager, System.Decimal _entPolicyMdDataId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EntPolicyMdData&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EntPolicyMdData&gt;"/></returns>
		public static TList<EntPolicyMdData> Fill(IDataReader reader, TList<EntPolicyMdData> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EntPolicyMdData c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EntPolicyMdData")
					.Append("|").Append((System.Decimal)reader["ENT_POLICY_MD_DATA_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EntPolicyMdData>(
					key.ToString(), // EntityTrackingKey
					"EntPolicyMdData",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EntPolicyMdData();
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
					c.EntPolicyMdDataId = (System.Decimal)reader["ENT_POLICY_MD_DATA_ID"];
					c.OriginalEntPolicyMdDataId = c.EntPolicyMdDataId;
					c.EntPolicyMdId = (System.Decimal)reader["ENT_POLICY_MD_ID"];
					c.MdValue = Convert.IsDBNull(reader["MD_VALUE"]) ? null : (System.String)reader["MD_VALUE"];
					c.EntMainId = (System.Decimal)reader["ENT_MAIN_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntPolicyMdData"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntPolicyMdData"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EntPolicyMdData entity)
		{
			if (!reader.Read()) return;
			
			entity.EntPolicyMdDataId = (System.Decimal)reader[((int)EntPolicyMdDataColumn.EntPolicyMdDataId - 1)];
			entity.OriginalEntPolicyMdDataId = (System.Decimal)reader["ENT_POLICY_MD_DATA_ID"];
			entity.EntPolicyMdId = (System.Decimal)reader[((int)EntPolicyMdDataColumn.EntPolicyMdId - 1)];
			entity.MdValue = (reader.IsDBNull(((int)EntPolicyMdDataColumn.MdValue - 1)))?null:(System.String)reader[((int)EntPolicyMdDataColumn.MdValue - 1)];
			entity.EntMainId = (System.Decimal)reader[((int)EntPolicyMdDataColumn.EntMainId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntPolicyMdData"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntPolicyMdData"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EntPolicyMdData entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EntPolicyMdDataId = (System.Decimal)dataRow["ENT_POLICY_MD_DATA_ID"];
			entity.OriginalEntPolicyMdDataId = (System.Decimal)dataRow["ENT_POLICY_MD_DATA_ID"];
			entity.EntPolicyMdId = (System.Decimal)dataRow["ENT_POLICY_MD_ID"];
			entity.MdValue = Convert.IsDBNull(dataRow["MD_VALUE"]) ? null : (System.String)dataRow["MD_VALUE"];
			entity.EntMainId = (System.Decimal)dataRow["ENT_MAIN_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntPolicyMdData"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntPolicyMdData Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPolicyMdData entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EntPolicyMdIdSource	
			if (CanDeepLoad(entity, "EntPolicyMetadata|EntPolicyMdIdSource", deepLoadType, innerList) 
				&& entity.EntPolicyMdIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EntPolicyMdId;
				EntPolicyMetadata tmpEntity = EntityManager.LocateEntity<EntPolicyMetadata>(EntityLocator.ConstructKeyFromPkItems(typeof(EntPolicyMetadata), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EntPolicyMdIdSource = tmpEntity;
				else
					entity.EntPolicyMdIdSource = DataRepository.EntPolicyMetadataProvider.GetByEntPolicyMdId(transactionManager, entity.EntPolicyMdId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPolicyMdIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EntPolicyMdIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EntPolicyMetadataProvider.DeepLoad(transactionManager, entity.EntPolicyMdIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EntPolicyMdIdSource

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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EntPolicyMdData object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EntPolicyMdData instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntPolicyMdData Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPolicyMdData entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EntPolicyMdIdSource
			if (CanDeepSave(entity, "EntPolicyMetadata|EntPolicyMdIdSource", deepSaveType, innerList) 
				&& entity.EntPolicyMdIdSource != null)
			{
				DataRepository.EntPolicyMetadataProvider.Save(transactionManager, entity.EntPolicyMdIdSource);
				entity.EntPolicyMdId = entity.EntPolicyMdIdSource.EntPolicyMdId;
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
	
	#region EntPolicyMdDataChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EntPolicyMdData</c>
	///</summary>
	public enum EntPolicyMdDataChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EntPolicyMetadata</c> at EntPolicyMdIdSource
		///</summary>
		[ChildEntityType(typeof(EntPolicyMetadata))]
		EntPolicyMetadata,
		
		///<summary>
		/// Composite Property for <c>EntityMain</c> at EntMainIdSource
		///</summary>
		[ChildEntityType(typeof(EntityMain))]
		EntityMain,
	}
	
	#endregion EntPolicyMdDataChildEntityTypes
	
	#region EntPolicyMdDataFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntPolicyMdDataColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntPolicyMdData"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntPolicyMdDataFilterBuilder : SqlFilterBuilder<EntPolicyMdDataColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntPolicyMdDataFilterBuilder class.
		/// </summary>
		public EntPolicyMdDataFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntPolicyMdDataFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntPolicyMdDataFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntPolicyMdDataFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntPolicyMdDataFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntPolicyMdDataFilterBuilder
	
	#region EntPolicyMdDataParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntPolicyMdDataColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntPolicyMdData"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntPolicyMdDataParameterBuilder : ParameterizedSqlFilterBuilder<EntPolicyMdDataColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntPolicyMdDataParameterBuilder class.
		/// </summary>
		public EntPolicyMdDataParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntPolicyMdDataParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntPolicyMdDataParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntPolicyMdDataParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntPolicyMdDataParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntPolicyMdDataParameterBuilder
	
	#region EntPolicyMdDataSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntPolicyMdDataColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntPolicyMdData"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EntPolicyMdDataSortBuilder : SqlSortBuilder<EntPolicyMdDataColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntPolicyMdDataSqlSortBuilder class.
		/// </summary>
		public EntPolicyMdDataSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EntPolicyMdDataSortBuilder
	
} // end namespace
