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
	/// This class is the base class for any <see cref="EntIntroducMetadataProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EntIntroducMetadataProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EntIntroducMetadata, UMIS_VER2.BusinessLyer.EntIntroducMetadataKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntIntroducMetadataKey key)
		{
			return Delete(transactionManager, key.EntIntroducMdId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_entIntroducMdId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _entIntroducMdId)
		{
			return Delete(null, _entIntroducMdId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entIntroducMdId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _entIntroducMdId);		
		
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
		public override UMIS_VER2.BusinessLyer.EntIntroducMetadata Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntIntroducMetadataKey key, int start, int pageLength)
		{
			return GetByEntIntroducMdId(transactionManager, key.EntIntroducMdId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ENT_CODE_ENTITY_TYPE_1 index.
		/// </summary>
		/// <param name="_entCodeEntityTypeId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntIntroducMetadata&gt;"/> class.</returns>
		public TList<EntIntroducMetadata> GetByEntCodeEntityTypeId(System.Decimal _entCodeEntityTypeId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EntIntroducMetadata&gt;"/> class.</returns>
		public TList<EntIntroducMetadata> GetByEntCodeEntityTypeId(System.Decimal _entCodeEntityTypeId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EntIntroducMetadata&gt;"/> class.</returns>
		public TList<EntIntroducMetadata> GetByEntCodeEntityTypeId(TransactionManager transactionManager, System.Decimal _entCodeEntityTypeId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EntIntroducMetadata&gt;"/> class.</returns>
		public TList<EntIntroducMetadata> GetByEntCodeEntityTypeId(TransactionManager transactionManager, System.Decimal _entCodeEntityTypeId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EntIntroducMetadata&gt;"/> class.</returns>
		public TList<EntIntroducMetadata> GetByEntCodeEntityTypeId(System.Decimal _entCodeEntityTypeId, int start, int pageLength, out int count)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EntIntroducMetadata&gt;"/> class.</returns>
		public abstract TList<EntIntroducMetadata> GetByEntCodeEntityTypeId(TransactionManager transactionManager, System.Decimal _entCodeEntityTypeId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ENT_CODE_INTRO_MD_ID_1 index.
		/// </summary>
		/// <param name="_entCodeIntroMdId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntIntroducMetadata&gt;"/> class.</returns>
		public TList<EntIntroducMetadata> GetByEntCodeIntroMdId(System.Decimal _entCodeIntroMdId)
		{
			int count = -1;
			return GetByEntCodeIntroMdId(null,_entCodeIntroMdId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_CODE_INTRO_MD_ID_1 index.
		/// </summary>
		/// <param name="_entCodeIntroMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntIntroducMetadata&gt;"/> class.</returns>
		public TList<EntIntroducMetadata> GetByEntCodeIntroMdId(System.Decimal _entCodeIntroMdId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntCodeIntroMdId(null, _entCodeIntroMdId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_CODE_INTRO_MD_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodeIntroMdId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntIntroducMetadata&gt;"/> class.</returns>
		public TList<EntIntroducMetadata> GetByEntCodeIntroMdId(TransactionManager transactionManager, System.Decimal _entCodeIntroMdId)
		{
			int count = -1;
			return GetByEntCodeIntroMdId(transactionManager, _entCodeIntroMdId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_CODE_INTRO_MD_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodeIntroMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntIntroducMetadata&gt;"/> class.</returns>
		public TList<EntIntroducMetadata> GetByEntCodeIntroMdId(TransactionManager transactionManager, System.Decimal _entCodeIntroMdId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntCodeIntroMdId(transactionManager, _entCodeIntroMdId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_CODE_INTRO_MD_ID_1 index.
		/// </summary>
		/// <param name="_entCodeIntroMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntIntroducMetadata&gt;"/> class.</returns>
		public TList<EntIntroducMetadata> GetByEntCodeIntroMdId(System.Decimal _entCodeIntroMdId, int start, int pageLength, out int count)
		{
			return GetByEntCodeIntroMdId(null, _entCodeIntroMdId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ENT_CODE_INTRO_MD_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodeIntroMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EntIntroducMetadata&gt;"/> class.</returns>
		public abstract TList<EntIntroducMetadata> GetByEntCodeIntroMdId(TransactionManager transactionManager, System.Decimal _entCodeIntroMdId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ENT_INTRODUC_METADATA index.
		/// </summary>
		/// <param name="_entIntroducMdId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntIntroducMetadata"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntIntroducMetadata GetByEntIntroducMdId(System.Decimal _entIntroducMdId)
		{
			int count = -1;
			return GetByEntIntroducMdId(null,_entIntroducMdId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_INTRODUC_METADATA index.
		/// </summary>
		/// <param name="_entIntroducMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntIntroducMetadata"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntIntroducMetadata GetByEntIntroducMdId(System.Decimal _entIntroducMdId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntIntroducMdId(null, _entIntroducMdId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_INTRODUC_METADATA index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entIntroducMdId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntIntroducMetadata"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntIntroducMetadata GetByEntIntroducMdId(TransactionManager transactionManager, System.Decimal _entIntroducMdId)
		{
			int count = -1;
			return GetByEntIntroducMdId(transactionManager, _entIntroducMdId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_INTRODUC_METADATA index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entIntroducMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntIntroducMetadata"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntIntroducMetadata GetByEntIntroducMdId(TransactionManager transactionManager, System.Decimal _entIntroducMdId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntIntroducMdId(transactionManager, _entIntroducMdId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_INTRODUC_METADATA index.
		/// </summary>
		/// <param name="_entIntroducMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntIntroducMetadata"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntIntroducMetadata GetByEntIntroducMdId(System.Decimal _entIntroducMdId, int start, int pageLength, out int count)
		{
			return GetByEntIntroducMdId(null, _entIntroducMdId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_INTRODUC_METADATA index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entIntroducMdId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntIntroducMetadata"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EntIntroducMetadata GetByEntIntroducMdId(TransactionManager transactionManager, System.Decimal _entIntroducMdId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EntIntroducMetadata&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EntIntroducMetadata&gt;"/></returns>
		public static TList<EntIntroducMetadata> Fill(IDataReader reader, TList<EntIntroducMetadata> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EntIntroducMetadata c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EntIntroducMetadata")
					.Append("|").Append((System.Decimal)reader["ENT_INTRODUC_MD_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EntIntroducMetadata>(
					key.ToString(), // EntityTrackingKey
					"EntIntroducMetadata",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EntIntroducMetadata();
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
					c.EntCodeIntroMdId = (System.Decimal)reader["ENT_CODE_INTRO_MD_ID"];
					c.EntCodeEntityTypeId = (System.Decimal)reader["ENT_CODE_ENTITY_TYPE_ID"];
					c.EntIntroducMdId = (System.Decimal)reader["ENT_INTRODUC_MD_ID"];
					c.OriginalEntIntroducMdId = c.EntIntroducMdId;
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntIntroducMetadata"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntIntroducMetadata"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EntIntroducMetadata entity)
		{
			if (!reader.Read()) return;
			
			entity.EntCodeIntroMdId = (System.Decimal)reader[((int)EntIntroducMetadataColumn.EntCodeIntroMdId - 1)];
			entity.EntCodeEntityTypeId = (System.Decimal)reader[((int)EntIntroducMetadataColumn.EntCodeEntityTypeId - 1)];
			entity.EntIntroducMdId = (System.Decimal)reader[((int)EntIntroducMetadataColumn.EntIntroducMdId - 1)];
			entity.OriginalEntIntroducMdId = (System.Decimal)reader["ENT_INTRODUC_MD_ID"];
			entity.ObligFlg = (reader.IsDBNull(((int)EntIntroducMetadataColumn.ObligFlg - 1)))?null:(System.Decimal?)reader[((int)EntIntroducMetadataColumn.ObligFlg - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntIntroducMetadata"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntIntroducMetadata"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EntIntroducMetadata entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EntCodeIntroMdId = (System.Decimal)dataRow["ENT_CODE_INTRO_MD_ID"];
			entity.EntCodeEntityTypeId = (System.Decimal)dataRow["ENT_CODE_ENTITY_TYPE_ID"];
			entity.EntIntroducMdId = (System.Decimal)dataRow["ENT_INTRODUC_MD_ID"];
			entity.OriginalEntIntroducMdId = (System.Decimal)dataRow["ENT_INTRODUC_MD_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntIntroducMetadata"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntIntroducMetadata Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntIntroducMetadata entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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

			#region EntCodeIntroMdIdSource	
			if (CanDeepLoad(entity, "EntCodeIntroMetadata|EntCodeIntroMdIdSource", deepLoadType, innerList) 
				&& entity.EntCodeIntroMdIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EntCodeIntroMdId;
				EntCodeIntroMetadata tmpEntity = EntityManager.LocateEntity<EntCodeIntroMetadata>(EntityLocator.ConstructKeyFromPkItems(typeof(EntCodeIntroMetadata), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EntCodeIntroMdIdSource = tmpEntity;
				else
					entity.EntCodeIntroMdIdSource = DataRepository.EntCodeIntroMetadataProvider.GetByEntCodeIntroMdId(transactionManager, entity.EntCodeIntroMdId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntCodeIntroMdIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EntCodeIntroMdIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EntCodeIntroMetadataProvider.DeepLoad(transactionManager, entity.EntCodeIntroMdIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EntCodeIntroMdIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEntIntroducMdId methods when available
			
			#region EntIntroducMdDataCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntIntroducMdData>|EntIntroducMdDataCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntIntroducMdDataCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntIntroducMdDataCollection = DataRepository.EntIntroducMdDataProvider.GetByEntIntroducMdId(transactionManager, entity.EntIntroducMdId);

				if (deep && entity.EntIntroducMdDataCollection.Count > 0)
				{
					deepHandles.Add("EntIntroducMdDataCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntIntroducMdData>) DataRepository.EntIntroducMdDataProvider.DeepLoad,
						new object[] { transactionManager, entity.EntIntroducMdDataCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EntIntroducMetadata object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EntIntroducMetadata instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntIntroducMetadata Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntIntroducMetadata entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region EntCodeIntroMdIdSource
			if (CanDeepSave(entity, "EntCodeIntroMetadata|EntCodeIntroMdIdSource", deepSaveType, innerList) 
				&& entity.EntCodeIntroMdIdSource != null)
			{
				DataRepository.EntCodeIntroMetadataProvider.Save(transactionManager, entity.EntCodeIntroMdIdSource);
				entity.EntCodeIntroMdId = entity.EntCodeIntroMdIdSource.EntCodeIntroMdId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<EntIntroducMdData>
				if (CanDeepSave(entity.EntIntroducMdDataCollection, "List<EntIntroducMdData>|EntIntroducMdDataCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntIntroducMdData child in entity.EntIntroducMdDataCollection)
					{
						if(child.EntIntroducMdIdSource != null)
						{
							child.EntIntroducMdId = child.EntIntroducMdIdSource.EntIntroducMdId;
						}
						else
						{
							child.EntIntroducMdId = entity.EntIntroducMdId;
						}

					}

					if (entity.EntIntroducMdDataCollection.Count > 0 || entity.EntIntroducMdDataCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntIntroducMdDataProvider.Save(transactionManager, entity.EntIntroducMdDataCollection);
						
						deepHandles.Add("EntIntroducMdDataCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntIntroducMdData >) DataRepository.EntIntroducMdDataProvider.DeepSave,
							new object[] { transactionManager, entity.EntIntroducMdDataCollection, deepSaveType, childTypes, innerList }
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
	
	#region EntIntroducMetadataChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EntIntroducMetadata</c>
	///</summary>
	public enum EntIntroducMetadataChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EntCodeEntityType</c> at EntCodeEntityTypeIdSource
		///</summary>
		[ChildEntityType(typeof(EntCodeEntityType))]
		EntCodeEntityType,
		
		///<summary>
		/// Composite Property for <c>EntCodeIntroMetadata</c> at EntCodeIntroMdIdSource
		///</summary>
		[ChildEntityType(typeof(EntCodeIntroMetadata))]
		EntCodeIntroMetadata,
		///<summary>
		/// Collection of <c>EntIntroducMetadata</c> as OneToMany for EntIntroducMdDataCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntIntroducMdData>))]
		EntIntroducMdDataCollection,
	}
	
	#endregion EntIntroducMetadataChildEntityTypes
	
	#region EntIntroducMetadataFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntIntroducMetadataColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntIntroducMetadata"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntIntroducMetadataFilterBuilder : SqlFilterBuilder<EntIntroducMetadataColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntIntroducMetadataFilterBuilder class.
		/// </summary>
		public EntIntroducMetadataFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntIntroducMetadataFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntIntroducMetadataFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntIntroducMetadataFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntIntroducMetadataFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntIntroducMetadataFilterBuilder
	
	#region EntIntroducMetadataParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntIntroducMetadataColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntIntroducMetadata"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntIntroducMetadataParameterBuilder : ParameterizedSqlFilterBuilder<EntIntroducMetadataColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntIntroducMetadataParameterBuilder class.
		/// </summary>
		public EntIntroducMetadataParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntIntroducMetadataParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntIntroducMetadataParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntIntroducMetadataParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntIntroducMetadataParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntIntroducMetadataParameterBuilder
	
	#region EntIntroducMetadataSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntIntroducMetadataColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntIntroducMetadata"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EntIntroducMetadataSortBuilder : SqlSortBuilder<EntIntroducMetadataColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntIntroducMetadataSqlSortBuilder class.
		/// </summary>
		public EntIntroducMetadataSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EntIntroducMetadataSortBuilder
	
} // end namespace
