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
	/// This class is the base class for any <see cref="EntPolicyMetadataProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EntPolicyMetadataProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EntPolicyMetadata, UMIS_VER2.BusinessLyer.EntPolicyMetadataKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPolicyMetadataKey key)
		{
			return Delete(transactionManager, key.EntPolicyMdId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_entPolicyMdId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _entPolicyMdId)
		{
			return Delete(null, _entPolicyMdId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyMdId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _entPolicyMdId);		
		
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
		public override UMIS_VER2.BusinessLyer.EntPolicyMetadata Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPolicyMetadataKey key, int start, int pageLength)
		{
			return GetByEntPolicyMdId(transactionManager, key.EntPolicyMdId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ENT_CODE_ENTITY_TYPE_1 index.
		/// </summary>
		/// <param name="_entCodeEntityTypeId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyMetadata&gt;"/> class.</returns>
		public TList<EntPolicyMetadata> GetByEntCodeEntityTypeId(System.Decimal _entCodeEntityTypeId)
		{
			int count = -1;
			return GetByEntCodeEntityTypeId(null,_entCodeEntityTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_CODE_ENTITY_TYPE_1 index.
		/// </summary>
		/// <param name="_entCodeEntityTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyMetadata&gt;"/> class.</returns>
		public TList<EntPolicyMetadata> GetByEntCodeEntityTypeId(System.Decimal _entCodeEntityTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntCodeEntityTypeId(null, _entCodeEntityTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_CODE_ENTITY_TYPE_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodeEntityTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyMetadata&gt;"/> class.</returns>
		public TList<EntPolicyMetadata> GetByEntCodeEntityTypeId(TransactionManager transactionManager, System.Decimal _entCodeEntityTypeId)
		{
			int count = -1;
			return GetByEntCodeEntityTypeId(transactionManager, _entCodeEntityTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_CODE_ENTITY_TYPE_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodeEntityTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyMetadata&gt;"/> class.</returns>
		public TList<EntPolicyMetadata> GetByEntCodeEntityTypeId(TransactionManager transactionManager, System.Decimal _entCodeEntityTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntCodeEntityTypeId(transactionManager, _entCodeEntityTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_CODE_ENTITY_TYPE_1 index.
		/// </summary>
		/// <param name="_entCodeEntityTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyMetadata&gt;"/> class.</returns>
		public TList<EntPolicyMetadata> GetByEntCodeEntityTypeId(System.Decimal _entCodeEntityTypeId, int start, int pageLength, out int count)
		{
			return GetByEntCodeEntityTypeId(null, _entCodeEntityTypeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_CODE_ENTITY_TYPE_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodeEntityTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyMetadata&gt;"/> class.</returns>
		public abstract TList<EntPolicyMetadata> GetByEntCodeEntityTypeId(TransactionManager transactionManager, System.Decimal _entCodeEntityTypeId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ENT_CODE_POLICY_MD_I_1 index.
		/// </summary>
		/// <param name="_entCodePolicyMdId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyMetadata&gt;"/> class.</returns>
		public TList<EntPolicyMetadata> GetByEntCodePolicyMdId(System.Decimal _entCodePolicyMdId)
		{
			int count = -1;
			return GetByEntCodePolicyMdId(null,_entCodePolicyMdId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_CODE_POLICY_MD_I_1 index.
		/// </summary>
		/// <param name="_entCodePolicyMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyMetadata&gt;"/> class.</returns>
		public TList<EntPolicyMetadata> GetByEntCodePolicyMdId(System.Decimal _entCodePolicyMdId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntCodePolicyMdId(null, _entCodePolicyMdId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_CODE_POLICY_MD_I_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodePolicyMdId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyMetadata&gt;"/> class.</returns>
		public TList<EntPolicyMetadata> GetByEntCodePolicyMdId(TransactionManager transactionManager, System.Decimal _entCodePolicyMdId)
		{
			int count = -1;
			return GetByEntCodePolicyMdId(transactionManager, _entCodePolicyMdId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_CODE_POLICY_MD_I_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodePolicyMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyMetadata&gt;"/> class.</returns>
		public TList<EntPolicyMetadata> GetByEntCodePolicyMdId(TransactionManager transactionManager, System.Decimal _entCodePolicyMdId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntCodePolicyMdId(transactionManager, _entCodePolicyMdId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_CODE_POLICY_MD_I_1 index.
		/// </summary>
		/// <param name="_entCodePolicyMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyMetadata&gt;"/> class.</returns>
		public TList<EntPolicyMetadata> GetByEntCodePolicyMdId(System.Decimal _entCodePolicyMdId, int start, int pageLength, out int count)
		{
			return GetByEntCodePolicyMdId(null, _entCodePolicyMdId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_CODE_POLICY_MD_I_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodePolicyMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPolicyMetadata&gt;"/> class.</returns>
		public abstract TList<EntPolicyMetadata> GetByEntCodePolicyMdId(TransactionManager transactionManager, System.Decimal _entCodePolicyMdId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ENT_POLICY_REQ_METADATA index.
		/// </summary>
		/// <param name="_entPolicyMdId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyMetadata"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyMetadata GetByEntPolicyMdId(System.Decimal _entPolicyMdId)
		{
			int count = -1;
			return GetByEntPolicyMdId(null,_entPolicyMdId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_POLICY_REQ_METADATA index.
		/// </summary>
		/// <param name="_entPolicyMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyMetadata"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyMetadata GetByEntPolicyMdId(System.Decimal _entPolicyMdId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntPolicyMdId(null, _entPolicyMdId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_POLICY_REQ_METADATA index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyMdId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyMetadata"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyMetadata GetByEntPolicyMdId(TransactionManager transactionManager, System.Decimal _entPolicyMdId)
		{
			int count = -1;
			return GetByEntPolicyMdId(transactionManager, _entPolicyMdId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_POLICY_REQ_METADATA index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyMetadata"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyMetadata GetByEntPolicyMdId(TransactionManager transactionManager, System.Decimal _entPolicyMdId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntPolicyMdId(transactionManager, _entPolicyMdId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_POLICY_REQ_METADATA index.
		/// </summary>
		/// <param name="_entPolicyMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyMetadata"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPolicyMetadata GetByEntPolicyMdId(System.Decimal _entPolicyMdId, int start, int pageLength, out int count)
		{
			return GetByEntPolicyMdId(null, _entPolicyMdId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_POLICY_REQ_METADATA index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPolicyMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPolicyMetadata"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EntPolicyMetadata GetByEntPolicyMdId(TransactionManager transactionManager, System.Decimal _entPolicyMdId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EntPolicyMetadata&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EntPolicyMetadata&gt;"/></returns>
		public static TList<EntPolicyMetadata> Fill(IDataReader reader, TList<EntPolicyMetadata> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EntPolicyMetadata c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EntPolicyMetadata")
					.Append("|").Append((System.Decimal)reader["ENT_POLICY_MD_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EntPolicyMetadata>(
					key.ToString(), // EntityTrackingKey
					"EntPolicyMetadata",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EntPolicyMetadata();
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
					c.EntPolicyMdId = (System.Decimal)reader["ENT_POLICY_MD_ID"];
					c.OriginalEntPolicyMdId = c.EntPolicyMdId;
					c.EntCodeEntityTypeId = (System.Decimal)reader["ENT_CODE_ENTITY_TYPE_ID"];
					c.EntCodePolicyMdId = (System.Decimal)reader["ENT_CODE_POLICY_MD_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntPolicyMetadata"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntPolicyMetadata"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EntPolicyMetadata entity)
		{
			if (!reader.Read()) return;
			
			entity.EntPolicyMdId = (System.Decimal)reader[((int)EntPolicyMetadataColumn.EntPolicyMdId - 1)];
			entity.OriginalEntPolicyMdId = (System.Decimal)reader["ENT_POLICY_MD_ID"];
			entity.EntCodeEntityTypeId = (System.Decimal)reader[((int)EntPolicyMetadataColumn.EntCodeEntityTypeId - 1)];
			entity.EntCodePolicyMdId = (System.Decimal)reader[((int)EntPolicyMetadataColumn.EntCodePolicyMdId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntPolicyMetadata"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntPolicyMetadata"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EntPolicyMetadata entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EntPolicyMdId = (System.Decimal)dataRow["ENT_POLICY_MD_ID"];
			entity.OriginalEntPolicyMdId = (System.Decimal)dataRow["ENT_POLICY_MD_ID"];
			entity.EntCodeEntityTypeId = (System.Decimal)dataRow["ENT_CODE_ENTITY_TYPE_ID"];
			entity.EntCodePolicyMdId = (System.Decimal)dataRow["ENT_CODE_POLICY_MD_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntPolicyMetadata"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntPolicyMetadata Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPolicyMetadata entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EntCodeEntityTypeIdSource	
			if (CanDeepLoad(entity, "EntCodeEntityType|EntCodeEntityTypeIdSource", deepLoadType, innerList) 
				&& entity.EntCodeEntityTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EntCodeEntityTypeId;
				EntCodeEntityType tmpEntity = EntityManager.LocateEntity<EntCodeEntityType>(EntityLocator.ConstructKeyFromPkItems(typeof(EntCodeEntityType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EntCodeEntityTypeIdSource = tmpEntity;
				else
					entity.EntCodeEntityTypeIdSource = DataRepository.EntCodeEntityTypeProvider.GetByEntCodeEntityTypeId(transactionManager, entity.EntCodeEntityTypeId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntCodeEntityTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EntCodeEntityTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EntCodeEntityTypeProvider.DeepLoad(transactionManager, entity.EntCodeEntityTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EntCodeEntityTypeIdSource

			#region EntCodePolicyMdIdSource	
			if (CanDeepLoad(entity, "EntCodePolicyMetadata|EntCodePolicyMdIdSource", deepLoadType, innerList) 
				&& entity.EntCodePolicyMdIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EntCodePolicyMdId;
				EntCodePolicyMetadata tmpEntity = EntityManager.LocateEntity<EntCodePolicyMetadata>(EntityLocator.ConstructKeyFromPkItems(typeof(EntCodePolicyMetadata), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EntCodePolicyMdIdSource = tmpEntity;
				else
					entity.EntCodePolicyMdIdSource = DataRepository.EntCodePolicyMetadataProvider.GetByEntCodePolicyMdId(transactionManager, entity.EntCodePolicyMdId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntCodePolicyMdIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EntCodePolicyMdIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EntCodePolicyMetadataProvider.DeepLoad(transactionManager, entity.EntCodePolicyMdIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EntCodePolicyMdIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEntPolicyMdId methods when available
			
			#region EntPolicyMdDataCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntPolicyMdData>|EntPolicyMdDataCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPolicyMdDataCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntPolicyMdDataCollection = DataRepository.EntPolicyMdDataProvider.GetByEntPolicyMdId(transactionManager, entity.EntPolicyMdId);

				if (deep && entity.EntPolicyMdDataCollection.Count > 0)
				{
					deepHandles.Add("EntPolicyMdDataCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntPolicyMdData>) DataRepository.EntPolicyMdDataProvider.DeepLoad,
						new object[] { transactionManager, entity.EntPolicyMdDataCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EntPolicyMetadata object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EntPolicyMetadata instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntPolicyMetadata Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPolicyMetadata entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EntCodeEntityTypeIdSource
			if (CanDeepSave(entity, "EntCodeEntityType|EntCodeEntityTypeIdSource", deepSaveType, innerList) 
				&& entity.EntCodeEntityTypeIdSource != null)
			{
				DataRepository.EntCodeEntityTypeProvider.Save(transactionManager, entity.EntCodeEntityTypeIdSource);
				entity.EntCodeEntityTypeId = entity.EntCodeEntityTypeIdSource.EntCodeEntityTypeId;
			}
			#endregion 
			
			#region EntCodePolicyMdIdSource
			if (CanDeepSave(entity, "EntCodePolicyMetadata|EntCodePolicyMdIdSource", deepSaveType, innerList) 
				&& entity.EntCodePolicyMdIdSource != null)
			{
				DataRepository.EntCodePolicyMetadataProvider.Save(transactionManager, entity.EntCodePolicyMdIdSource);
				entity.EntCodePolicyMdId = entity.EntCodePolicyMdIdSource.EntCodePolicyMdId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<EntPolicyMdData>
				if (CanDeepSave(entity.EntPolicyMdDataCollection, "List<EntPolicyMdData>|EntPolicyMdDataCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntPolicyMdData child in entity.EntPolicyMdDataCollection)
					{
						if(child.EntPolicyMdIdSource != null)
						{
							child.EntPolicyMdId = child.EntPolicyMdIdSource.EntPolicyMdId;
						}
						else
						{
							child.EntPolicyMdId = entity.EntPolicyMdId;
						}

					}

					if (entity.EntPolicyMdDataCollection.Count > 0 || entity.EntPolicyMdDataCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntPolicyMdDataProvider.Save(transactionManager, entity.EntPolicyMdDataCollection);
						
						deepHandles.Add("EntPolicyMdDataCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntPolicyMdData >) DataRepository.EntPolicyMdDataProvider.DeepSave,
							new object[] { transactionManager, entity.EntPolicyMdDataCollection, deepSaveType, childTypes, innerList }
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
	
	#region EntPolicyMetadataChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EntPolicyMetadata</c>
	///</summary>
	public enum EntPolicyMetadataChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EntCodeEntityType</c> at EntCodeEntityTypeIdSource
		///</summary>
		[ChildEntityType(typeof(EntCodeEntityType))]
		EntCodeEntityType,
		
		///<summary>
		/// Composite Property for <c>EntCodePolicyMetadata</c> at EntCodePolicyMdIdSource
		///</summary>
		[ChildEntityType(typeof(EntCodePolicyMetadata))]
		EntCodePolicyMetadata,
		///<summary>
		/// Collection of <c>EntPolicyMetadata</c> as OneToMany for EntPolicyMdDataCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntPolicyMdData>))]
		EntPolicyMdDataCollection,
	}
	
	#endregion EntPolicyMetadataChildEntityTypes
	
	#region EntPolicyMetadataFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntPolicyMetadataColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntPolicyMetadata"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntPolicyMetadataFilterBuilder : SqlFilterBuilder<EntPolicyMetadataColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntPolicyMetadataFilterBuilder class.
		/// </summary>
		public EntPolicyMetadataFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntPolicyMetadataFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntPolicyMetadataFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntPolicyMetadataFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntPolicyMetadataFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntPolicyMetadataFilterBuilder
	
	#region EntPolicyMetadataParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntPolicyMetadataColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntPolicyMetadata"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntPolicyMetadataParameterBuilder : ParameterizedSqlFilterBuilder<EntPolicyMetadataColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntPolicyMetadataParameterBuilder class.
		/// </summary>
		public EntPolicyMetadataParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntPolicyMetadataParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntPolicyMetadataParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntPolicyMetadataParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntPolicyMetadataParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntPolicyMetadataParameterBuilder
	
	#region EntPolicyMetadataSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntPolicyMetadataColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntPolicyMetadata"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EntPolicyMetadataSortBuilder : SqlSortBuilder<EntPolicyMetadataColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntPolicyMetadataSqlSortBuilder class.
		/// </summary>
		public EntPolicyMetadataSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EntPolicyMetadataSortBuilder
	
} // end namespace
