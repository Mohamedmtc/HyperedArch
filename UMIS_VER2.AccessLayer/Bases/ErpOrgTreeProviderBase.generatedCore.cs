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
	/// This class is the base class for any <see cref="ErpOrgTreeProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class ErpOrgTreeProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.ErpOrgTree, UMIS_VER2.BusinessLyer.ErpOrgTreeKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ErpOrgTreeKey key)
		{
			return Delete(transactionManager, key.ErpOrgTreeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_erpOrgTreeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _erpOrgTreeId)
		{
			return Delete(null, _erpOrgTreeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_erpOrgTreeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _erpOrgTreeId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ERP_ORG_TREE_ERP_ORG_TREE key.
		///		FK_ERP_ORG_TREE_ERP_ORG_TREE Description: 
		/// </summary>
		/// <param name="_parentId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ErpOrgTree objects.</returns>
		public TList<ErpOrgTree> GetByParentId(System.Decimal? _parentId)
		{
			int count = -1;
			return GetByParentId(_parentId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ERP_ORG_TREE_ERP_ORG_TREE key.
		///		FK_ERP_ORG_TREE_ERP_ORG_TREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_parentId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ErpOrgTree objects.</returns>
		/// <remarks></remarks>
		public TList<ErpOrgTree> GetByParentId(TransactionManager transactionManager, System.Decimal? _parentId)
		{
			int count = -1;
			return GetByParentId(transactionManager, _parentId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ERP_ORG_TREE_ERP_ORG_TREE key.
		///		FK_ERP_ORG_TREE_ERP_ORG_TREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_parentId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ErpOrgTree objects.</returns>
		public TList<ErpOrgTree> GetByParentId(TransactionManager transactionManager, System.Decimal? _parentId, int start, int pageLength)
		{
			int count = -1;
			return GetByParentId(transactionManager, _parentId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ERP_ORG_TREE_ERP_ORG_TREE key.
		///		fkErpOrgTreeErpOrgTree Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_parentId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ErpOrgTree objects.</returns>
		public TList<ErpOrgTree> GetByParentId(System.Decimal? _parentId, int start, int pageLength)
		{
			int count =  -1;
			return GetByParentId(null, _parentId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ERP_ORG_TREE_ERP_ORG_TREE key.
		///		fkErpOrgTreeErpOrgTree Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_parentId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ErpOrgTree objects.</returns>
		public TList<ErpOrgTree> GetByParentId(System.Decimal? _parentId, int start, int pageLength,out int count)
		{
			return GetByParentId(null, _parentId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ERP_ORG_TREE_ERP_ORG_TREE key.
		///		FK_ERP_ORG_TREE_ERP_ORG_TREE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_parentId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.ErpOrgTree objects.</returns>
		public abstract TList<ErpOrgTree> GetByParentId(TransactionManager transactionManager, System.Decimal? _parentId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.ErpOrgTree Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ErpOrgTreeKey key, int start, int pageLength)
		{
			return GetByErpOrgTreeId(transactionManager, key.ErpOrgTreeId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ERP_ORG_TREE index.
		/// </summary>
		/// <param name="_erpOrgTreeId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ErpOrgTree"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ErpOrgTree GetByErpOrgTreeId(System.Decimal _erpOrgTreeId)
		{
			int count = -1;
			return GetByErpOrgTreeId(null,_erpOrgTreeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ERP_ORG_TREE index.
		/// </summary>
		/// <param name="_erpOrgTreeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ErpOrgTree"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ErpOrgTree GetByErpOrgTreeId(System.Decimal _erpOrgTreeId, int start, int pageLength)
		{
			int count = -1;
			return GetByErpOrgTreeId(null, _erpOrgTreeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ERP_ORG_TREE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_erpOrgTreeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ErpOrgTree"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ErpOrgTree GetByErpOrgTreeId(TransactionManager transactionManager, System.Decimal _erpOrgTreeId)
		{
			int count = -1;
			return GetByErpOrgTreeId(transactionManager, _erpOrgTreeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ERP_ORG_TREE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_erpOrgTreeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ErpOrgTree"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ErpOrgTree GetByErpOrgTreeId(TransactionManager transactionManager, System.Decimal _erpOrgTreeId, int start, int pageLength)
		{
			int count = -1;
			return GetByErpOrgTreeId(transactionManager, _erpOrgTreeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ERP_ORG_TREE index.
		/// </summary>
		/// <param name="_erpOrgTreeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ErpOrgTree"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ErpOrgTree GetByErpOrgTreeId(System.Decimal _erpOrgTreeId, int start, int pageLength, out int count)
		{
			return GetByErpOrgTreeId(null, _erpOrgTreeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ERP_ORG_TREE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_erpOrgTreeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ErpOrgTree"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.ErpOrgTree GetByErpOrgTreeId(TransactionManager transactionManager, System.Decimal _erpOrgTreeId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;ErpOrgTree&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;ErpOrgTree&gt;"/></returns>
		public static TList<ErpOrgTree> Fill(IDataReader reader, TList<ErpOrgTree> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.ErpOrgTree c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("ErpOrgTree")
					.Append("|").Append((System.Decimal)reader["ERP_ORG_TREE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<ErpOrgTree>(
					key.ToString(), // EntityTrackingKey
					"ErpOrgTree",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.ErpOrgTree();
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
					c.ErpOrgTreeId = (System.Decimal)reader["ERP_ORG_TREE_ID"];
					c.OriginalErpOrgTreeId = c.ErpOrgTreeId;
					c.ParentId = Convert.IsDBNull(reader["PARENT_ID"]) ? null : (System.Decimal?)reader["PARENT_ID"];
					c.DescrEn = Convert.IsDBNull(reader["DESCR_EN"]) ? null : (System.String)reader["DESCR_EN"];
					c.DescrAr = (System.String)reader["DESCR_AR"];
					c.NodeTypeId = (System.Decimal)reader["NODE_TYPE_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.ErpOrgTree"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ErpOrgTree"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.ErpOrgTree entity)
		{
			if (!reader.Read()) return;
			
			entity.ErpOrgTreeId = (System.Decimal)reader[((int)ErpOrgTreeColumn.ErpOrgTreeId - 1)];
			entity.OriginalErpOrgTreeId = (System.Decimal)reader["ERP_ORG_TREE_ID"];
			entity.ParentId = (reader.IsDBNull(((int)ErpOrgTreeColumn.ParentId - 1)))?null:(System.Decimal?)reader[((int)ErpOrgTreeColumn.ParentId - 1)];
			entity.DescrEn = (reader.IsDBNull(((int)ErpOrgTreeColumn.DescrEn - 1)))?null:(System.String)reader[((int)ErpOrgTreeColumn.DescrEn - 1)];
			entity.DescrAr = (System.String)reader[((int)ErpOrgTreeColumn.DescrAr - 1)];
			entity.NodeTypeId = (System.Decimal)reader[((int)ErpOrgTreeColumn.NodeTypeId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.ErpOrgTree"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ErpOrgTree"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.ErpOrgTree entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.ErpOrgTreeId = (System.Decimal)dataRow["ERP_ORG_TREE_ID"];
			entity.OriginalErpOrgTreeId = (System.Decimal)dataRow["ERP_ORG_TREE_ID"];
			entity.ParentId = Convert.IsDBNull(dataRow["PARENT_ID"]) ? null : (System.Decimal?)dataRow["PARENT_ID"];
			entity.DescrEn = Convert.IsDBNull(dataRow["DESCR_EN"]) ? null : (System.String)dataRow["DESCR_EN"];
			entity.DescrAr = (System.String)dataRow["DESCR_AR"];
			entity.NodeTypeId = (System.Decimal)dataRow["NODE_TYPE_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ErpOrgTree"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.ErpOrgTree Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ErpOrgTree entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region ParentIdSource	
			if (CanDeepLoad(entity, "ErpOrgTree|ParentIdSource", deepLoadType, innerList) 
				&& entity.ParentIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.ParentId ?? 0.0m);
				ErpOrgTree tmpEntity = EntityManager.LocateEntity<ErpOrgTree>(EntityLocator.ConstructKeyFromPkItems(typeof(ErpOrgTree), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.ParentIdSource = tmpEntity;
				else
					entity.ParentIdSource = DataRepository.ErpOrgTreeProvider.GetByErpOrgTreeId(transactionManager, (entity.ParentId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ParentIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.ParentIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.ErpOrgTreeProvider.DeepLoad(transactionManager, entity.ParentIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion ParentIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByErpOrgTreeId methods when available
			
			#region EdStudViolCollectionGetByErpOrgTreeToId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudViol>|EdStudViolCollectionGetByErpOrgTreeToId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudViolCollectionGetByErpOrgTreeToId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudViolCollectionGetByErpOrgTreeToId = DataRepository.EdStudViolProvider.GetByErpOrgTreeToId(transactionManager, entity.ErpOrgTreeId);

				if (deep && entity.EdStudViolCollectionGetByErpOrgTreeToId.Count > 0)
				{
					deepHandles.Add("EdStudViolCollectionGetByErpOrgTreeToId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudViol>) DataRepository.EdStudViolProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudViolCollectionGetByErpOrgTreeToId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region ErpOrgTreeCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ErpOrgTree>|ErpOrgTreeCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ErpOrgTreeCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ErpOrgTreeCollection = DataRepository.ErpOrgTreeProvider.GetByParentId(transactionManager, entity.ErpOrgTreeId);

				if (deep && entity.ErpOrgTreeCollection.Count > 0)
				{
					deepHandles.Add("ErpOrgTreeCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ErpOrgTree>) DataRepository.ErpOrgTreeProvider.DeepLoad,
						new object[] { transactionManager, entity.ErpOrgTreeCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudViolCollectionGetByErpOrgTreeFromId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudViol>|EdStudViolCollectionGetByErpOrgTreeFromId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudViolCollectionGetByErpOrgTreeFromId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudViolCollectionGetByErpOrgTreeFromId = DataRepository.EdStudViolProvider.GetByErpOrgTreeFromId(transactionManager, entity.ErpOrgTreeId);

				if (deep && entity.EdStudViolCollectionGetByErpOrgTreeFromId.Count > 0)
				{
					deepHandles.Add("EdStudViolCollectionGetByErpOrgTreeFromId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudViol>) DataRepository.EdStudViolProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudViolCollectionGetByErpOrgTreeFromId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudProblemCollectionGetByErpOrgTreeIdTo
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudProblem>|EdStudProblemCollectionGetByErpOrgTreeIdTo", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudProblemCollectionGetByErpOrgTreeIdTo' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudProblemCollectionGetByErpOrgTreeIdTo = DataRepository.EdStudProblemProvider.GetByErpOrgTreeIdTo(transactionManager, entity.ErpOrgTreeId);

				if (deep && entity.EdStudProblemCollectionGetByErpOrgTreeIdTo.Count > 0)
				{
					deepHandles.Add("EdStudProblemCollectionGetByErpOrgTreeIdTo",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudProblem>) DataRepository.EdStudProblemProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudProblemCollectionGetByErpOrgTreeIdTo, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SeUserCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SeUser>|SeUserCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeUserCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SeUserCollection = DataRepository.SeUserProvider.GetByErpOrgTreeId(transactionManager, entity.ErpOrgTreeId);

				if (deep && entity.SeUserCollection.Count > 0)
				{
					deepHandles.Add("SeUserCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SeUser>) DataRepository.SeUserProvider.DeepLoad,
						new object[] { transactionManager, entity.SeUserCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudProblemCollectionGetByErpOrgTreeIdFrm
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudProblem>|EdStudProblemCollectionGetByErpOrgTreeIdFrm", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudProblemCollectionGetByErpOrgTreeIdFrm' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudProblemCollectionGetByErpOrgTreeIdFrm = DataRepository.EdStudProblemProvider.GetByErpOrgTreeIdFrm(transactionManager, entity.ErpOrgTreeId);

				if (deep && entity.EdStudProblemCollectionGetByErpOrgTreeIdFrm.Count > 0)
				{
					deepHandles.Add("EdStudProblemCollectionGetByErpOrgTreeIdFrm",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudProblem>) DataRepository.EdStudProblemProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudProblemCollectionGetByErpOrgTreeIdFrm, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.ErpOrgTree object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.ErpOrgTree instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.ErpOrgTree Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ErpOrgTree entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region ParentIdSource
			if (CanDeepSave(entity, "ErpOrgTree|ParentIdSource", deepSaveType, innerList) 
				&& entity.ParentIdSource != null)
			{
				DataRepository.ErpOrgTreeProvider.Save(transactionManager, entity.ParentIdSource);
				entity.ParentId = entity.ParentIdSource.ErpOrgTreeId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<EdStudViol>
				if (CanDeepSave(entity.EdStudViolCollectionGetByErpOrgTreeToId, "List<EdStudViol>|EdStudViolCollectionGetByErpOrgTreeToId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudViol child in entity.EdStudViolCollectionGetByErpOrgTreeToId)
					{
						if(child.ErpOrgTreeToIdSource != null)
						{
							child.ErpOrgTreeToId = child.ErpOrgTreeToIdSource.ErpOrgTreeId;
						}
						else
						{
							child.ErpOrgTreeToId = entity.ErpOrgTreeId;
						}

					}

					if (entity.EdStudViolCollectionGetByErpOrgTreeToId.Count > 0 || entity.EdStudViolCollectionGetByErpOrgTreeToId.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudViolProvider.Save(transactionManager, entity.EdStudViolCollectionGetByErpOrgTreeToId);
						
						deepHandles.Add("EdStudViolCollectionGetByErpOrgTreeToId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudViol >) DataRepository.EdStudViolProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudViolCollectionGetByErpOrgTreeToId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<ErpOrgTree>
				if (CanDeepSave(entity.ErpOrgTreeCollection, "List<ErpOrgTree>|ErpOrgTreeCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ErpOrgTree child in entity.ErpOrgTreeCollection)
					{
						if(child.ParentIdSource != null)
						{
							child.ParentId = child.ParentIdSource.ErpOrgTreeId;
						}
						else
						{
							child.ParentId = entity.ErpOrgTreeId;
						}

					}

					if (entity.ErpOrgTreeCollection.Count > 0 || entity.ErpOrgTreeCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ErpOrgTreeProvider.Save(transactionManager, entity.ErpOrgTreeCollection);
						
						deepHandles.Add("ErpOrgTreeCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ErpOrgTree >) DataRepository.ErpOrgTreeProvider.DeepSave,
							new object[] { transactionManager, entity.ErpOrgTreeCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudViol>
				if (CanDeepSave(entity.EdStudViolCollectionGetByErpOrgTreeFromId, "List<EdStudViol>|EdStudViolCollectionGetByErpOrgTreeFromId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudViol child in entity.EdStudViolCollectionGetByErpOrgTreeFromId)
					{
						if(child.ErpOrgTreeFromIdSource != null)
						{
							child.ErpOrgTreeFromId = child.ErpOrgTreeFromIdSource.ErpOrgTreeId;
						}
						else
						{
							child.ErpOrgTreeFromId = entity.ErpOrgTreeId;
						}

					}

					if (entity.EdStudViolCollectionGetByErpOrgTreeFromId.Count > 0 || entity.EdStudViolCollectionGetByErpOrgTreeFromId.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudViolProvider.Save(transactionManager, entity.EdStudViolCollectionGetByErpOrgTreeFromId);
						
						deepHandles.Add("EdStudViolCollectionGetByErpOrgTreeFromId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudViol >) DataRepository.EdStudViolProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudViolCollectionGetByErpOrgTreeFromId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudProblem>
				if (CanDeepSave(entity.EdStudProblemCollectionGetByErpOrgTreeIdTo, "List<EdStudProblem>|EdStudProblemCollectionGetByErpOrgTreeIdTo", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudProblem child in entity.EdStudProblemCollectionGetByErpOrgTreeIdTo)
					{
						if(child.ErpOrgTreeIdToSource != null)
						{
							child.ErpOrgTreeIdTo = child.ErpOrgTreeIdToSource.ErpOrgTreeId;
						}
						else
						{
							child.ErpOrgTreeIdTo = entity.ErpOrgTreeId;
						}

					}

					if (entity.EdStudProblemCollectionGetByErpOrgTreeIdTo.Count > 0 || entity.EdStudProblemCollectionGetByErpOrgTreeIdTo.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudProblemProvider.Save(transactionManager, entity.EdStudProblemCollectionGetByErpOrgTreeIdTo);
						
						deepHandles.Add("EdStudProblemCollectionGetByErpOrgTreeIdTo",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudProblem >) DataRepository.EdStudProblemProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudProblemCollectionGetByErpOrgTreeIdTo, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SeUser>
				if (CanDeepSave(entity.SeUserCollection, "List<SeUser>|SeUserCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SeUser child in entity.SeUserCollection)
					{
						if(child.ErpOrgTreeIdSource != null)
						{
							child.ErpOrgTreeId = child.ErpOrgTreeIdSource.ErpOrgTreeId;
						}
						else
						{
							child.ErpOrgTreeId = entity.ErpOrgTreeId;
						}

					}

					if (entity.SeUserCollection.Count > 0 || entity.SeUserCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SeUserProvider.Save(transactionManager, entity.SeUserCollection);
						
						deepHandles.Add("SeUserCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SeUser >) DataRepository.SeUserProvider.DeepSave,
							new object[] { transactionManager, entity.SeUserCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudProblem>
				if (CanDeepSave(entity.EdStudProblemCollectionGetByErpOrgTreeIdFrm, "List<EdStudProblem>|EdStudProblemCollectionGetByErpOrgTreeIdFrm", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudProblem child in entity.EdStudProblemCollectionGetByErpOrgTreeIdFrm)
					{
						if(child.ErpOrgTreeIdFrmSource != null)
						{
							child.ErpOrgTreeIdFrm = child.ErpOrgTreeIdFrmSource.ErpOrgTreeId;
						}
						else
						{
							child.ErpOrgTreeIdFrm = entity.ErpOrgTreeId;
						}

					}

					if (entity.EdStudProblemCollectionGetByErpOrgTreeIdFrm.Count > 0 || entity.EdStudProblemCollectionGetByErpOrgTreeIdFrm.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudProblemProvider.Save(transactionManager, entity.EdStudProblemCollectionGetByErpOrgTreeIdFrm);
						
						deepHandles.Add("EdStudProblemCollectionGetByErpOrgTreeIdFrm",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudProblem >) DataRepository.EdStudProblemProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudProblemCollectionGetByErpOrgTreeIdFrm, deepSaveType, childTypes, innerList }
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
	
	#region ErpOrgTreeChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.ErpOrgTree</c>
	///</summary>
	public enum ErpOrgTreeChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>ErpOrgTree</c> at ParentIdSource
		///</summary>
		[ChildEntityType(typeof(ErpOrgTree))]
		ErpOrgTree,
		///<summary>
		/// Collection of <c>ErpOrgTree</c> as OneToMany for EdStudViolCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudViol>))]
		EdStudViolCollectionGetByErpOrgTreeToId,
		///<summary>
		/// Collection of <c>ErpOrgTree</c> as OneToMany for ErpOrgTreeCollection
		///</summary>
		[ChildEntityType(typeof(TList<ErpOrgTree>))]
		ErpOrgTreeCollection,
		///<summary>
		/// Collection of <c>ErpOrgTree</c> as OneToMany for EdStudViolCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudViol>))]
		EdStudViolCollectionGetByErpOrgTreeFromId,
		///<summary>
		/// Collection of <c>ErpOrgTree</c> as OneToMany for EdStudProblemCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudProblem>))]
		EdStudProblemCollectionGetByErpOrgTreeIdTo,
		///<summary>
		/// Collection of <c>ErpOrgTree</c> as OneToMany for SeUserCollection
		///</summary>
		[ChildEntityType(typeof(TList<SeUser>))]
		SeUserCollection,
		///<summary>
		/// Collection of <c>ErpOrgTree</c> as OneToMany for EdStudProblemCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudProblem>))]
		EdStudProblemCollectionGetByErpOrgTreeIdFrm,
	}
	
	#endregion ErpOrgTreeChildEntityTypes
	
	#region ErpOrgTreeFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;ErpOrgTreeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ErpOrgTree"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ErpOrgTreeFilterBuilder : SqlFilterBuilder<ErpOrgTreeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ErpOrgTreeFilterBuilder class.
		/// </summary>
		public ErpOrgTreeFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ErpOrgTreeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ErpOrgTreeFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ErpOrgTreeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ErpOrgTreeFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ErpOrgTreeFilterBuilder
	
	#region ErpOrgTreeParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;ErpOrgTreeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ErpOrgTree"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ErpOrgTreeParameterBuilder : ParameterizedSqlFilterBuilder<ErpOrgTreeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ErpOrgTreeParameterBuilder class.
		/// </summary>
		public ErpOrgTreeParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ErpOrgTreeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ErpOrgTreeParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ErpOrgTreeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ErpOrgTreeParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ErpOrgTreeParameterBuilder
	
	#region ErpOrgTreeSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;ErpOrgTreeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ErpOrgTree"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ErpOrgTreeSortBuilder : SqlSortBuilder<ErpOrgTreeColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ErpOrgTreeSqlSortBuilder class.
		/// </summary>
		public ErpOrgTreeSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ErpOrgTreeSortBuilder
	
} // end namespace
