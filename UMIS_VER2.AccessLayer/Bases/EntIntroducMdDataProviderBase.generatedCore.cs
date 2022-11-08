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
	/// This class is the base class for any <see cref="EntIntroducMdDataProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EntIntroducMdDataProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EntIntroducMdData, UMIS_VER2.BusinessLyer.EntIntroducMdDataKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntIntroducMdDataKey key)
		{
			return Delete(transactionManager, key.EntIntroducMdDataId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_entIntroducMdDataId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _entIntroducMdDataId)
		{
			return Delete(null, _entIntroducMdDataId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entIntroducMdDataId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _entIntroducMdDataId);		
		
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
		public override UMIS_VER2.BusinessLyer.EntIntroducMdData Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntIntroducMdDataKey key, int start, int pageLength)
		{
			return GetByEntIntroducMdDataId(transactionManager, key.EntIntroducMdDataId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ENT_INTRODUC_MD_ID_1 index.
		/// </summary>
		/// <param name="_entIntroducMdId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntIntroducMdData&gt;"/> class.</returns>
		public TList<EntIntroducMdData> GetByEntIntroducMdId(System.Decimal _entIntroducMdId)
		{
			int count = -1;
			return GetByEntIntroducMdId(null,_entIntroducMdId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_INTRODUC_MD_ID_1 index.
		/// </summary>
		/// <param name="_entIntroducMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntIntroducMdData&gt;"/> class.</returns>
		public TList<EntIntroducMdData> GetByEntIntroducMdId(System.Decimal _entIntroducMdId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntIntroducMdId(null, _entIntroducMdId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_INTRODUC_MD_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entIntroducMdId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntIntroducMdData&gt;"/> class.</returns>
		public TList<EntIntroducMdData> GetByEntIntroducMdId(TransactionManager transactionManager, System.Decimal _entIntroducMdId)
		{
			int count = -1;
			return GetByEntIntroducMdId(transactionManager, _entIntroducMdId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_INTRODUC_MD_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entIntroducMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntIntroducMdData&gt;"/> class.</returns>
		public TList<EntIntroducMdData> GetByEntIntroducMdId(TransactionManager transactionManager, System.Decimal _entIntroducMdId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntIntroducMdId(transactionManager, _entIntroducMdId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_INTRODUC_MD_ID_1 index.
		/// </summary>
		/// <param name="_entIntroducMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntIntroducMdData&gt;"/> class.</returns>
		public TList<EntIntroducMdData> GetByEntIntroducMdId(System.Decimal _entIntroducMdId, int start, int pageLength, out int count)
		{
			return GetByEntIntroducMdId(null, _entIntroducMdId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_INTRODUC_MD_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entIntroducMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntIntroducMdData&gt;"/> class.</returns>
		public abstract TList<EntIntroducMdData> GetByEntIntroducMdId(TransactionManager transactionManager, System.Decimal _entIntroducMdId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ENT_MAIN_ID_1 index.
		/// </summary>
		/// <param name="_entMainId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntIntroducMdData&gt;"/> class.</returns>
		public TList<EntIntroducMdData> GetByEntMainId(System.Decimal _entMainId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EntIntroducMdData&gt;"/> class.</returns>
		public TList<EntIntroducMdData> GetByEntMainId(System.Decimal _entMainId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EntIntroducMdData&gt;"/> class.</returns>
		public TList<EntIntroducMdData> GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EntIntroducMdData&gt;"/> class.</returns>
		public TList<EntIntroducMdData> GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EntIntroducMdData&gt;"/> class.</returns>
		public TList<EntIntroducMdData> GetByEntMainId(System.Decimal _entMainId, int start, int pageLength, out int count)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EntIntroducMdData&gt;"/> class.</returns>
		public abstract TList<EntIntroducMdData> GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ENT_INTRODUC_MD_DATA_ID index.
		/// </summary>
		/// <param name="_entIntroducMdDataId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntIntroducMdData"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntIntroducMdData GetByEntIntroducMdDataId(System.Decimal _entIntroducMdDataId)
		{
			int count = -1;
			return GetByEntIntroducMdDataId(null,_entIntroducMdDataId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_INTRODUC_MD_DATA_ID index.
		/// </summary>
		/// <param name="_entIntroducMdDataId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntIntroducMdData"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntIntroducMdData GetByEntIntroducMdDataId(System.Decimal _entIntroducMdDataId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntIntroducMdDataId(null, _entIntroducMdDataId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_INTRODUC_MD_DATA_ID index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entIntroducMdDataId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntIntroducMdData"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntIntroducMdData GetByEntIntroducMdDataId(TransactionManager transactionManager, System.Decimal _entIntroducMdDataId)
		{
			int count = -1;
			return GetByEntIntroducMdDataId(transactionManager, _entIntroducMdDataId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_INTRODUC_MD_DATA_ID index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entIntroducMdDataId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntIntroducMdData"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntIntroducMdData GetByEntIntroducMdDataId(TransactionManager transactionManager, System.Decimal _entIntroducMdDataId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntIntroducMdDataId(transactionManager, _entIntroducMdDataId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_INTRODUC_MD_DATA_ID index.
		/// </summary>
		/// <param name="_entIntroducMdDataId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntIntroducMdData"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntIntroducMdData GetByEntIntroducMdDataId(System.Decimal _entIntroducMdDataId, int start, int pageLength, out int count)
		{
			return GetByEntIntroducMdDataId(null, _entIntroducMdDataId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_INTRODUC_MD_DATA_ID index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entIntroducMdDataId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntIntroducMdData"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EntIntroducMdData GetByEntIntroducMdDataId(TransactionManager transactionManager, System.Decimal _entIntroducMdDataId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EntIntroducMdData&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EntIntroducMdData&gt;"/></returns>
		public static TList<EntIntroducMdData> Fill(IDataReader reader, TList<EntIntroducMdData> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EntIntroducMdData c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EntIntroducMdData")
					.Append("|").Append((System.Decimal)reader["ENT_INTRODUC_MD_DATA_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EntIntroducMdData>(
					key.ToString(), // EntityTrackingKey
					"EntIntroducMdData",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EntIntroducMdData();
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
					c.EntIntroducMdDataId = (System.Decimal)reader["ENT_INTRODUC_MD_DATA_ID"];
					c.OriginalEntIntroducMdDataId = c.EntIntroducMdDataId;
					c.EntIntroducMdId = (System.Decimal)reader["ENT_INTRODUC_MD_ID"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntIntroducMdData"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntIntroducMdData"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EntIntroducMdData entity)
		{
			if (!reader.Read()) return;
			
			entity.EntIntroducMdDataId = (System.Decimal)reader[((int)EntIntroducMdDataColumn.EntIntroducMdDataId - 1)];
			entity.OriginalEntIntroducMdDataId = (System.Decimal)reader["ENT_INTRODUC_MD_DATA_ID"];
			entity.EntIntroducMdId = (System.Decimal)reader[((int)EntIntroducMdDataColumn.EntIntroducMdId - 1)];
			entity.MdValue = (reader.IsDBNull(((int)EntIntroducMdDataColumn.MdValue - 1)))?null:(System.String)reader[((int)EntIntroducMdDataColumn.MdValue - 1)];
			entity.EntMainId = (System.Decimal)reader[((int)EntIntroducMdDataColumn.EntMainId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntIntroducMdData"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntIntroducMdData"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EntIntroducMdData entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EntIntroducMdDataId = (System.Decimal)dataRow["ENT_INTRODUC_MD_DATA_ID"];
			entity.OriginalEntIntroducMdDataId = (System.Decimal)dataRow["ENT_INTRODUC_MD_DATA_ID"];
			entity.EntIntroducMdId = (System.Decimal)dataRow["ENT_INTRODUC_MD_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntIntroducMdData"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntIntroducMdData Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntIntroducMdData entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EntIntroducMdIdSource	
			if (CanDeepLoad(entity, "EntIntroducMetadata|EntIntroducMdIdSource", deepLoadType, innerList) 
				&& entity.EntIntroducMdIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EntIntroducMdId;
				EntIntroducMetadata tmpEntity = EntityManager.LocateEntity<EntIntroducMetadata>(EntityLocator.ConstructKeyFromPkItems(typeof(EntIntroducMetadata), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EntIntroducMdIdSource = tmpEntity;
				else
					entity.EntIntroducMdIdSource = DataRepository.EntIntroducMetadataProvider.GetByEntIntroducMdId(transactionManager, entity.EntIntroducMdId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntIntroducMdIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EntIntroducMdIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EntIntroducMetadataProvider.DeepLoad(transactionManager, entity.EntIntroducMdIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EntIntroducMdIdSource

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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EntIntroducMdData object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EntIntroducMdData instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntIntroducMdData Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntIntroducMdData entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EntIntroducMdIdSource
			if (CanDeepSave(entity, "EntIntroducMetadata|EntIntroducMdIdSource", deepSaveType, innerList) 
				&& entity.EntIntroducMdIdSource != null)
			{
				DataRepository.EntIntroducMetadataProvider.Save(transactionManager, entity.EntIntroducMdIdSource);
				entity.EntIntroducMdId = entity.EntIntroducMdIdSource.EntIntroducMdId;
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
	
	#region EntIntroducMdDataChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EntIntroducMdData</c>
	///</summary>
	public enum EntIntroducMdDataChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EntIntroducMetadata</c> at EntIntroducMdIdSource
		///</summary>
		[ChildEntityType(typeof(EntIntroducMetadata))]
		EntIntroducMetadata,
		
		///<summary>
		/// Composite Property for <c>EntityMain</c> at EntMainIdSource
		///</summary>
		[ChildEntityType(typeof(EntityMain))]
		EntityMain,
	}
	
	#endregion EntIntroducMdDataChildEntityTypes
	
	#region EntIntroducMdDataFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntIntroducMdDataColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntIntroducMdData"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntIntroducMdDataFilterBuilder : SqlFilterBuilder<EntIntroducMdDataColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntIntroducMdDataFilterBuilder class.
		/// </summary>
		public EntIntroducMdDataFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntIntroducMdDataFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntIntroducMdDataFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntIntroducMdDataFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntIntroducMdDataFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntIntroducMdDataFilterBuilder
	
	#region EntIntroducMdDataParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntIntroducMdDataColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntIntroducMdData"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntIntroducMdDataParameterBuilder : ParameterizedSqlFilterBuilder<EntIntroducMdDataColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntIntroducMdDataParameterBuilder class.
		/// </summary>
		public EntIntroducMdDataParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntIntroducMdDataParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntIntroducMdDataParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntIntroducMdDataParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntIntroducMdDataParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntIntroducMdDataParameterBuilder
	
	#region EntIntroducMdDataSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntIntroducMdDataColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntIntroducMdData"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EntIntroducMdDataSortBuilder : SqlSortBuilder<EntIntroducMdDataColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntIntroducMdDataSqlSortBuilder class.
		/// </summary>
		public EntIntroducMdDataSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EntIntroducMdDataSortBuilder
	
} // end namespace
