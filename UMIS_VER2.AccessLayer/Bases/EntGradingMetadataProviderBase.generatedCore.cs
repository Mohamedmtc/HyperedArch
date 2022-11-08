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
	/// This class is the base class for any <see cref="EntGradingMetadataProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EntGradingMetadataProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EntGradingMetadata, UMIS_VER2.BusinessLyer.EntGradingMetadataKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntGradingMetadataKey key)
		{
			return Delete(transactionManager, key.EntGradingMdId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_entGradingMdId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _entGradingMdId)
		{
			return Delete(null, _entGradingMdId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entGradingMdId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _entGradingMdId);		
		
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
		public override UMIS_VER2.BusinessLyer.EntGradingMetadata Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntGradingMetadataKey key, int start, int pageLength)
		{
			return GetByEntGradingMdId(transactionManager, key.EntGradingMdId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ENT_CODE_ENTITY_TYPE_1 index.
		/// </summary>
		/// <param name="_entCodeEntityTypeId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntGradingMetadata&gt;"/> class.</returns>
		public TList<EntGradingMetadata> GetByEntCodeEntityTypeId(System.Decimal _entCodeEntityTypeId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EntGradingMetadata&gt;"/> class.</returns>
		public TList<EntGradingMetadata> GetByEntCodeEntityTypeId(System.Decimal _entCodeEntityTypeId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EntGradingMetadata&gt;"/> class.</returns>
		public TList<EntGradingMetadata> GetByEntCodeEntityTypeId(TransactionManager transactionManager, System.Decimal _entCodeEntityTypeId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EntGradingMetadata&gt;"/> class.</returns>
		public TList<EntGradingMetadata> GetByEntCodeEntityTypeId(TransactionManager transactionManager, System.Decimal _entCodeEntityTypeId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EntGradingMetadata&gt;"/> class.</returns>
		public TList<EntGradingMetadata> GetByEntCodeEntityTypeId(System.Decimal _entCodeEntityTypeId, int start, int pageLength, out int count)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EntGradingMetadata&gt;"/> class.</returns>
		public abstract TList<EntGradingMetadata> GetByEntCodeEntityTypeId(TransactionManager transactionManager, System.Decimal _entCodeEntityTypeId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ENT_CODE_GRADING_MD__1 index.
		/// </summary>
		/// <param name="_entCodeGradingMdId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntGradingMetadata&gt;"/> class.</returns>
		public TList<EntGradingMetadata> GetByEntCodeGradingMdId(System.Decimal _entCodeGradingMdId)
		{
			int count = -1;
			return GetByEntCodeGradingMdId(null,_entCodeGradingMdId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_CODE_GRADING_MD__1 index.
		/// </summary>
		/// <param name="_entCodeGradingMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntGradingMetadata&gt;"/> class.</returns>
		public TList<EntGradingMetadata> GetByEntCodeGradingMdId(System.Decimal _entCodeGradingMdId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntCodeGradingMdId(null, _entCodeGradingMdId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_CODE_GRADING_MD__1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodeGradingMdId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntGradingMetadata&gt;"/> class.</returns>
		public TList<EntGradingMetadata> GetByEntCodeGradingMdId(TransactionManager transactionManager, System.Decimal _entCodeGradingMdId)
		{
			int count = -1;
			return GetByEntCodeGradingMdId(transactionManager, _entCodeGradingMdId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_CODE_GRADING_MD__1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodeGradingMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntGradingMetadata&gt;"/> class.</returns>
		public TList<EntGradingMetadata> GetByEntCodeGradingMdId(TransactionManager transactionManager, System.Decimal _entCodeGradingMdId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntCodeGradingMdId(transactionManager, _entCodeGradingMdId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_CODE_GRADING_MD__1 index.
		/// </summary>
		/// <param name="_entCodeGradingMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntGradingMetadata&gt;"/> class.</returns>
		public TList<EntGradingMetadata> GetByEntCodeGradingMdId(System.Decimal _entCodeGradingMdId, int start, int pageLength, out int count)
		{
			return GetByEntCodeGradingMdId(null, _entCodeGradingMdId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_CODE_GRADING_MD__1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodeGradingMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntGradingMetadata&gt;"/> class.</returns>
		public abstract TList<EntGradingMetadata> GetByEntCodeGradingMdId(TransactionManager transactionManager, System.Decimal _entCodeGradingMdId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ENT_GRADING_METADATA index.
		/// </summary>
		/// <param name="_entGradingMdId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntGradingMetadata"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntGradingMetadata GetByEntGradingMdId(System.Decimal _entGradingMdId)
		{
			int count = -1;
			return GetByEntGradingMdId(null,_entGradingMdId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_GRADING_METADATA index.
		/// </summary>
		/// <param name="_entGradingMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntGradingMetadata"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntGradingMetadata GetByEntGradingMdId(System.Decimal _entGradingMdId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntGradingMdId(null, _entGradingMdId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_GRADING_METADATA index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entGradingMdId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntGradingMetadata"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntGradingMetadata GetByEntGradingMdId(TransactionManager transactionManager, System.Decimal _entGradingMdId)
		{
			int count = -1;
			return GetByEntGradingMdId(transactionManager, _entGradingMdId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_GRADING_METADATA index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entGradingMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntGradingMetadata"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntGradingMetadata GetByEntGradingMdId(TransactionManager transactionManager, System.Decimal _entGradingMdId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntGradingMdId(transactionManager, _entGradingMdId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_GRADING_METADATA index.
		/// </summary>
		/// <param name="_entGradingMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntGradingMetadata"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntGradingMetadata GetByEntGradingMdId(System.Decimal _entGradingMdId, int start, int pageLength, out int count)
		{
			return GetByEntGradingMdId(null, _entGradingMdId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_GRADING_METADATA index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entGradingMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntGradingMetadata"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EntGradingMetadata GetByEntGradingMdId(TransactionManager transactionManager, System.Decimal _entGradingMdId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EntGradingMetadata&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EntGradingMetadata&gt;"/></returns>
		public static TList<EntGradingMetadata> Fill(IDataReader reader, TList<EntGradingMetadata> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EntGradingMetadata c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EntGradingMetadata")
					.Append("|").Append((System.Decimal)reader["ENT_GRADING_MD_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EntGradingMetadata>(
					key.ToString(), // EntityTrackingKey
					"EntGradingMetadata",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EntGradingMetadata();
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
					c.EntCodeGradingMdId = (System.Decimal)reader["ENT_CODE_GRADING_MD_ID"];
					c.EntCodeEntityTypeId = (System.Decimal)reader["ENT_CODE_ENTITY_TYPE_ID"];
					c.EntGradingMdId = (System.Decimal)reader["ENT_GRADING_MD_ID"];
					c.OriginalEntGradingMdId = c.EntGradingMdId;
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntGradingMetadata"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntGradingMetadata"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EntGradingMetadata entity)
		{
			if (!reader.Read()) return;
			
			entity.EntCodeGradingMdId = (System.Decimal)reader[((int)EntGradingMetadataColumn.EntCodeGradingMdId - 1)];
			entity.EntCodeEntityTypeId = (System.Decimal)reader[((int)EntGradingMetadataColumn.EntCodeEntityTypeId - 1)];
			entity.EntGradingMdId = (System.Decimal)reader[((int)EntGradingMetadataColumn.EntGradingMdId - 1)];
			entity.OriginalEntGradingMdId = (System.Decimal)reader["ENT_GRADING_MD_ID"];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntGradingMetadata"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntGradingMetadata"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EntGradingMetadata entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EntCodeGradingMdId = (System.Decimal)dataRow["ENT_CODE_GRADING_MD_ID"];
			entity.EntCodeEntityTypeId = (System.Decimal)dataRow["ENT_CODE_ENTITY_TYPE_ID"];
			entity.EntGradingMdId = (System.Decimal)dataRow["ENT_GRADING_MD_ID"];
			entity.OriginalEntGradingMdId = (System.Decimal)dataRow["ENT_GRADING_MD_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntGradingMetadata"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntGradingMetadata Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntGradingMetadata entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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

			#region EntCodeGradingMdIdSource	
			if (CanDeepLoad(entity, "EntCodeGradingMetadata|EntCodeGradingMdIdSource", deepLoadType, innerList) 
				&& entity.EntCodeGradingMdIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EntCodeGradingMdId;
				EntCodeGradingMetadata tmpEntity = EntityManager.LocateEntity<EntCodeGradingMetadata>(EntityLocator.ConstructKeyFromPkItems(typeof(EntCodeGradingMetadata), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EntCodeGradingMdIdSource = tmpEntity;
				else
					entity.EntCodeGradingMdIdSource = DataRepository.EntCodeGradingMetadataProvider.GetByEntCodeGradingMdId(transactionManager, entity.EntCodeGradingMdId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntCodeGradingMdIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EntCodeGradingMdIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EntCodeGradingMetadataProvider.DeepLoad(transactionManager, entity.EntCodeGradingMdIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EntCodeGradingMdIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEntGradingMdId methods when available
			
			#region EntGradingMdDataCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntGradingMdData>|EntGradingMdDataCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntGradingMdDataCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntGradingMdDataCollection = DataRepository.EntGradingMdDataProvider.GetByEntGradingMdId(transactionManager, entity.EntGradingMdId);

				if (deep && entity.EntGradingMdDataCollection.Count > 0)
				{
					deepHandles.Add("EntGradingMdDataCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntGradingMdData>) DataRepository.EntGradingMdDataProvider.DeepLoad,
						new object[] { transactionManager, entity.EntGradingMdDataCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EntGradingMetadata object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EntGradingMetadata instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntGradingMetadata Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntGradingMetadata entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region EntCodeGradingMdIdSource
			if (CanDeepSave(entity, "EntCodeGradingMetadata|EntCodeGradingMdIdSource", deepSaveType, innerList) 
				&& entity.EntCodeGradingMdIdSource != null)
			{
				DataRepository.EntCodeGradingMetadataProvider.Save(transactionManager, entity.EntCodeGradingMdIdSource);
				entity.EntCodeGradingMdId = entity.EntCodeGradingMdIdSource.EntCodeGradingMdId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<EntGradingMdData>
				if (CanDeepSave(entity.EntGradingMdDataCollection, "List<EntGradingMdData>|EntGradingMdDataCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntGradingMdData child in entity.EntGradingMdDataCollection)
					{
						if(child.EntGradingMdIdSource != null)
						{
							child.EntGradingMdId = child.EntGradingMdIdSource.EntGradingMdId;
						}
						else
						{
							child.EntGradingMdId = entity.EntGradingMdId;
						}

					}

					if (entity.EntGradingMdDataCollection.Count > 0 || entity.EntGradingMdDataCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntGradingMdDataProvider.Save(transactionManager, entity.EntGradingMdDataCollection);
						
						deepHandles.Add("EntGradingMdDataCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntGradingMdData >) DataRepository.EntGradingMdDataProvider.DeepSave,
							new object[] { transactionManager, entity.EntGradingMdDataCollection, deepSaveType, childTypes, innerList }
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
	
	#region EntGradingMetadataChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EntGradingMetadata</c>
	///</summary>
	public enum EntGradingMetadataChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EntCodeEntityType</c> at EntCodeEntityTypeIdSource
		///</summary>
		[ChildEntityType(typeof(EntCodeEntityType))]
		EntCodeEntityType,
		
		///<summary>
		/// Composite Property for <c>EntCodeGradingMetadata</c> at EntCodeGradingMdIdSource
		///</summary>
		[ChildEntityType(typeof(EntCodeGradingMetadata))]
		EntCodeGradingMetadata,
		///<summary>
		/// Collection of <c>EntGradingMetadata</c> as OneToMany for EntGradingMdDataCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntGradingMdData>))]
		EntGradingMdDataCollection,
	}
	
	#endregion EntGradingMetadataChildEntityTypes
	
	#region EntGradingMetadataFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntGradingMetadataColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntGradingMetadata"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntGradingMetadataFilterBuilder : SqlFilterBuilder<EntGradingMetadataColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntGradingMetadataFilterBuilder class.
		/// </summary>
		public EntGradingMetadataFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntGradingMetadataFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntGradingMetadataFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntGradingMetadataFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntGradingMetadataFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntGradingMetadataFilterBuilder
	
	#region EntGradingMetadataParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntGradingMetadataColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntGradingMetadata"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntGradingMetadataParameterBuilder : ParameterizedSqlFilterBuilder<EntGradingMetadataColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntGradingMetadataParameterBuilder class.
		/// </summary>
		public EntGradingMetadataParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntGradingMetadataParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntGradingMetadataParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntGradingMetadataParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntGradingMetadataParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntGradingMetadataParameterBuilder
	
	#region EntGradingMetadataSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntGradingMetadataColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntGradingMetadata"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EntGradingMetadataSortBuilder : SqlSortBuilder<EntGradingMetadataColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntGradingMetadataSqlSortBuilder class.
		/// </summary>
		public EntGradingMetadataSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EntGradingMetadataSortBuilder
	
} // end namespace
