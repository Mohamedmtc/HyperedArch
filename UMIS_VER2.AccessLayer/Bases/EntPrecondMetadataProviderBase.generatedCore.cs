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
	/// This class is the base class for any <see cref="EntPrecondMetadataProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EntPrecondMetadataProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EntPrecondMetadata, UMIS_VER2.BusinessLyer.EntPrecondMetadataKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPrecondMetadataKey key)
		{
			return Delete(transactionManager, key.EntPrecondMdId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_entPrecondMdId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _entPrecondMdId)
		{
			return Delete(null, _entPrecondMdId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPrecondMdId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _entPrecondMdId);		
		
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
		public override UMIS_VER2.BusinessLyer.EntPrecondMetadata Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPrecondMetadataKey key, int start, int pageLength)
		{
			return GetByEntPrecondMdId(transactionManager, key.EntPrecondMdId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ENT_CODE_ENTITY_TYPE_1 index.
		/// </summary>
		/// <param name="_entCodeEntityTypeId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPrecondMetadata&gt;"/> class.</returns>
		public TList<EntPrecondMetadata> GetByEntCodeEntityTypeId(System.Decimal _entCodeEntityTypeId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPrecondMetadata&gt;"/> class.</returns>
		public TList<EntPrecondMetadata> GetByEntCodeEntityTypeId(System.Decimal _entCodeEntityTypeId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPrecondMetadata&gt;"/> class.</returns>
		public TList<EntPrecondMetadata> GetByEntCodeEntityTypeId(TransactionManager transactionManager, System.Decimal _entCodeEntityTypeId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPrecondMetadata&gt;"/> class.</returns>
		public TList<EntPrecondMetadata> GetByEntCodeEntityTypeId(TransactionManager transactionManager, System.Decimal _entCodeEntityTypeId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPrecondMetadata&gt;"/> class.</returns>
		public TList<EntPrecondMetadata> GetByEntCodeEntityTypeId(System.Decimal _entCodeEntityTypeId, int start, int pageLength, out int count)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPrecondMetadata&gt;"/> class.</returns>
		public abstract TList<EntPrecondMetadata> GetByEntCodeEntityTypeId(TransactionManager transactionManager, System.Decimal _entCodeEntityTypeId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ENT_CODE_PRECOND_MD__1 index.
		/// </summary>
		/// <param name="_entCodePrecondMdId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPrecondMetadata&gt;"/> class.</returns>
		public TList<EntPrecondMetadata> GetByEntCodePrecondMdId(System.Decimal _entCodePrecondMdId)
		{
			int count = -1;
			return GetByEntCodePrecondMdId(null,_entCodePrecondMdId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_CODE_PRECOND_MD__1 index.
		/// </summary>
		/// <param name="_entCodePrecondMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPrecondMetadata&gt;"/> class.</returns>
		public TList<EntPrecondMetadata> GetByEntCodePrecondMdId(System.Decimal _entCodePrecondMdId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntCodePrecondMdId(null, _entCodePrecondMdId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_CODE_PRECOND_MD__1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodePrecondMdId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPrecondMetadata&gt;"/> class.</returns>
		public TList<EntPrecondMetadata> GetByEntCodePrecondMdId(TransactionManager transactionManager, System.Decimal _entCodePrecondMdId)
		{
			int count = -1;
			return GetByEntCodePrecondMdId(transactionManager, _entCodePrecondMdId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_CODE_PRECOND_MD__1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodePrecondMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPrecondMetadata&gt;"/> class.</returns>
		public TList<EntPrecondMetadata> GetByEntCodePrecondMdId(TransactionManager transactionManager, System.Decimal _entCodePrecondMdId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntCodePrecondMdId(transactionManager, _entCodePrecondMdId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_CODE_PRECOND_MD__1 index.
		/// </summary>
		/// <param name="_entCodePrecondMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPrecondMetadata&gt;"/> class.</returns>
		public TList<EntPrecondMetadata> GetByEntCodePrecondMdId(System.Decimal _entCodePrecondMdId, int start, int pageLength, out int count)
		{
			return GetByEntCodePrecondMdId(null, _entCodePrecondMdId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_CODE_PRECOND_MD__1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodePrecondMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntPrecondMetadata&gt;"/> class.</returns>
		public abstract TList<EntPrecondMetadata> GetByEntCodePrecondMdId(TransactionManager transactionManager, System.Decimal _entCodePrecondMdId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ENT_PRECOND_METADATA index.
		/// </summary>
		/// <param name="_entPrecondMdId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPrecondMetadata"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPrecondMetadata GetByEntPrecondMdId(System.Decimal _entPrecondMdId)
		{
			int count = -1;
			return GetByEntPrecondMdId(null,_entPrecondMdId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_PRECOND_METADATA index.
		/// </summary>
		/// <param name="_entPrecondMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPrecondMetadata"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPrecondMetadata GetByEntPrecondMdId(System.Decimal _entPrecondMdId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntPrecondMdId(null, _entPrecondMdId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_PRECOND_METADATA index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPrecondMdId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPrecondMetadata"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPrecondMetadata GetByEntPrecondMdId(TransactionManager transactionManager, System.Decimal _entPrecondMdId)
		{
			int count = -1;
			return GetByEntPrecondMdId(transactionManager, _entPrecondMdId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_PRECOND_METADATA index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPrecondMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPrecondMetadata"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPrecondMetadata GetByEntPrecondMdId(TransactionManager transactionManager, System.Decimal _entPrecondMdId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntPrecondMdId(transactionManager, _entPrecondMdId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_PRECOND_METADATA index.
		/// </summary>
		/// <param name="_entPrecondMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPrecondMetadata"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntPrecondMetadata GetByEntPrecondMdId(System.Decimal _entPrecondMdId, int start, int pageLength, out int count)
		{
			return GetByEntPrecondMdId(null, _entPrecondMdId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_PRECOND_METADATA index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entPrecondMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntPrecondMetadata"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EntPrecondMetadata GetByEntPrecondMdId(TransactionManager transactionManager, System.Decimal _entPrecondMdId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EntPrecondMetadata&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EntPrecondMetadata&gt;"/></returns>
		public static TList<EntPrecondMetadata> Fill(IDataReader reader, TList<EntPrecondMetadata> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EntPrecondMetadata c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EntPrecondMetadata")
					.Append("|").Append((System.Decimal)reader["ENT_PRECOND_MD_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EntPrecondMetadata>(
					key.ToString(), // EntityTrackingKey
					"EntPrecondMetadata",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EntPrecondMetadata();
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
					c.EntCodePrecondMdId = (System.Decimal)reader["ENT_CODE_PRECOND_MD_ID"];
					c.EntCodeEntityTypeId = (System.Decimal)reader["ENT_CODE_ENTITY_TYPE_ID"];
					c.EntPrecondMdId = (System.Decimal)reader["ENT_PRECOND_MD_ID"];
					c.OriginalEntPrecondMdId = c.EntPrecondMdId;
					c.ObligFlg = Convert.IsDBNull(reader["OBLIG_FLG"]) ? null : (System.Decimal?)reader["OBLIG_FLG"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntPrecondMetadata"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntPrecondMetadata"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EntPrecondMetadata entity)
		{
			if (!reader.Read()) return;
			
			entity.EntCodePrecondMdId = (System.Decimal)reader[((int)EntPrecondMetadataColumn.EntCodePrecondMdId - 1)];
			entity.EntCodeEntityTypeId = (System.Decimal)reader[((int)EntPrecondMetadataColumn.EntCodeEntityTypeId - 1)];
			entity.EntPrecondMdId = (System.Decimal)reader[((int)EntPrecondMetadataColumn.EntPrecondMdId - 1)];
			entity.OriginalEntPrecondMdId = (System.Decimal)reader["ENT_PRECOND_MD_ID"];
			entity.ObligFlg = (reader.IsDBNull(((int)EntPrecondMetadataColumn.ObligFlg - 1)))?null:(System.Decimal?)reader[((int)EntPrecondMetadataColumn.ObligFlg - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntPrecondMetadata"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntPrecondMetadata"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EntPrecondMetadata entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EntCodePrecondMdId = (System.Decimal)dataRow["ENT_CODE_PRECOND_MD_ID"];
			entity.EntCodeEntityTypeId = (System.Decimal)dataRow["ENT_CODE_ENTITY_TYPE_ID"];
			entity.EntPrecondMdId = (System.Decimal)dataRow["ENT_PRECOND_MD_ID"];
			entity.OriginalEntPrecondMdId = (System.Decimal)dataRow["ENT_PRECOND_MD_ID"];
			entity.ObligFlg = Convert.IsDBNull(dataRow["OBLIG_FLG"]) ? null : (System.Decimal?)dataRow["OBLIG_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntPrecondMetadata"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntPrecondMetadata Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPrecondMetadata entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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

			#region EntCodePrecondMdIdSource	
			if (CanDeepLoad(entity, "EntCodePrecondMetadata|EntCodePrecondMdIdSource", deepLoadType, innerList) 
				&& entity.EntCodePrecondMdIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EntCodePrecondMdId;
				EntCodePrecondMetadata tmpEntity = EntityManager.LocateEntity<EntCodePrecondMetadata>(EntityLocator.ConstructKeyFromPkItems(typeof(EntCodePrecondMetadata), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EntCodePrecondMdIdSource = tmpEntity;
				else
					entity.EntCodePrecondMdIdSource = DataRepository.EntCodePrecondMetadataProvider.GetByEntCodePrecondMdId(transactionManager, entity.EntCodePrecondMdId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntCodePrecondMdIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EntCodePrecondMdIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EntCodePrecondMetadataProvider.DeepLoad(transactionManager, entity.EntCodePrecondMdIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EntCodePrecondMdIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEntPrecondMdId methods when available
			
			#region EntPrecondMdDataCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntPrecondMdData>|EntPrecondMdDataCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPrecondMdDataCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntPrecondMdDataCollection = DataRepository.EntPrecondMdDataProvider.GetByEntPrecondMdId(transactionManager, entity.EntPrecondMdId);

				if (deep && entity.EntPrecondMdDataCollection.Count > 0)
				{
					deepHandles.Add("EntPrecondMdDataCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntPrecondMdData>) DataRepository.EntPrecondMdDataProvider.DeepLoad,
						new object[] { transactionManager, entity.EntPrecondMdDataCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EntPrecondMetadata object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EntPrecondMetadata instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntPrecondMetadata Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntPrecondMetadata entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region EntCodePrecondMdIdSource
			if (CanDeepSave(entity, "EntCodePrecondMetadata|EntCodePrecondMdIdSource", deepSaveType, innerList) 
				&& entity.EntCodePrecondMdIdSource != null)
			{
				DataRepository.EntCodePrecondMetadataProvider.Save(transactionManager, entity.EntCodePrecondMdIdSource);
				entity.EntCodePrecondMdId = entity.EntCodePrecondMdIdSource.EntCodePrecondMdId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<EntPrecondMdData>
				if (CanDeepSave(entity.EntPrecondMdDataCollection, "List<EntPrecondMdData>|EntPrecondMdDataCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntPrecondMdData child in entity.EntPrecondMdDataCollection)
					{
						if(child.EntPrecondMdIdSource != null)
						{
							child.EntPrecondMdId = child.EntPrecondMdIdSource.EntPrecondMdId;
						}
						else
						{
							child.EntPrecondMdId = entity.EntPrecondMdId;
						}

					}

					if (entity.EntPrecondMdDataCollection.Count > 0 || entity.EntPrecondMdDataCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntPrecondMdDataProvider.Save(transactionManager, entity.EntPrecondMdDataCollection);
						
						deepHandles.Add("EntPrecondMdDataCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntPrecondMdData >) DataRepository.EntPrecondMdDataProvider.DeepSave,
							new object[] { transactionManager, entity.EntPrecondMdDataCollection, deepSaveType, childTypes, innerList }
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
	
	#region EntPrecondMetadataChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EntPrecondMetadata</c>
	///</summary>
	public enum EntPrecondMetadataChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EntCodeEntityType</c> at EntCodeEntityTypeIdSource
		///</summary>
		[ChildEntityType(typeof(EntCodeEntityType))]
		EntCodeEntityType,
		
		///<summary>
		/// Composite Property for <c>EntCodePrecondMetadata</c> at EntCodePrecondMdIdSource
		///</summary>
		[ChildEntityType(typeof(EntCodePrecondMetadata))]
		EntCodePrecondMetadata,
		///<summary>
		/// Collection of <c>EntPrecondMetadata</c> as OneToMany for EntPrecondMdDataCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntPrecondMdData>))]
		EntPrecondMdDataCollection,
	}
	
	#endregion EntPrecondMetadataChildEntityTypes
	
	#region EntPrecondMetadataFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntPrecondMetadataColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntPrecondMetadata"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntPrecondMetadataFilterBuilder : SqlFilterBuilder<EntPrecondMetadataColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntPrecondMetadataFilterBuilder class.
		/// </summary>
		public EntPrecondMetadataFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntPrecondMetadataFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntPrecondMetadataFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntPrecondMetadataFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntPrecondMetadataFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntPrecondMetadataFilterBuilder
	
	#region EntPrecondMetadataParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntPrecondMetadataColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntPrecondMetadata"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntPrecondMetadataParameterBuilder : ParameterizedSqlFilterBuilder<EntPrecondMetadataColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntPrecondMetadataParameterBuilder class.
		/// </summary>
		public EntPrecondMetadataParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntPrecondMetadataParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntPrecondMetadataParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntPrecondMetadataParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntPrecondMetadataParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntPrecondMetadataParameterBuilder
	
	#region EntPrecondMetadataSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntPrecondMetadataColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntPrecondMetadata"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EntPrecondMetadataSortBuilder : SqlSortBuilder<EntPrecondMetadataColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntPrecondMetadataSqlSortBuilder class.
		/// </summary>
		public EntPrecondMetadataSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EntPrecondMetadataSortBuilder
	
} // end namespace
