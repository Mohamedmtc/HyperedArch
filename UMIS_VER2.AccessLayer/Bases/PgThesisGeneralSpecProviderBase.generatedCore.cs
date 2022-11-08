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
	/// This class is the base class for any <see cref="PgThesisGeneralSpecProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class PgThesisGeneralSpecProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.PgThesisGeneralSpec, UMIS_VER2.BusinessLyer.PgThesisGeneralSpecKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgThesisGeneralSpecKey key)
		{
			return Delete(transactionManager, key.PgThesisGeneralSpecId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_pgThesisGeneralSpecId">xxx. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _pgThesisGeneralSpecId)
		{
			return Delete(null, _pgThesisGeneralSpecId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisGeneralSpecId">xxx. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _pgThesisGeneralSpecId);		
		
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
		public override UMIS_VER2.BusinessLyer.PgThesisGeneralSpec Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgThesisGeneralSpecKey key, int start, int pageLength)
		{
			return GetByPgThesisGeneralSpecId(transactionManager, key.PgThesisGeneralSpecId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_AS_NODE_ID_1 index.
		/// </summary>
		/// <param name="_asNodeId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;PgThesisGeneralSpec&gt;"/> class.</returns>
		public TList<PgThesisGeneralSpec> GetByAsNodeId(System.Decimal _asNodeId)
		{
			int count = -1;
			return GetByAsNodeId(null,_asNodeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_NODE_ID_1 index.
		/// </summary>
		/// <param name="_asNodeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;PgThesisGeneralSpec&gt;"/> class.</returns>
		public TList<PgThesisGeneralSpec> GetByAsNodeId(System.Decimal _asNodeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsNodeId(null, _asNodeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_NODE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asNodeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;PgThesisGeneralSpec&gt;"/> class.</returns>
		public TList<PgThesisGeneralSpec> GetByAsNodeId(TransactionManager transactionManager, System.Decimal _asNodeId)
		{
			int count = -1;
			return GetByAsNodeId(transactionManager, _asNodeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_NODE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asNodeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;PgThesisGeneralSpec&gt;"/> class.</returns>
		public TList<PgThesisGeneralSpec> GetByAsNodeId(TransactionManager transactionManager, System.Decimal _asNodeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsNodeId(transactionManager, _asNodeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_NODE_ID_1 index.
		/// </summary>
		/// <param name="_asNodeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;PgThesisGeneralSpec&gt;"/> class.</returns>
		public TList<PgThesisGeneralSpec> GetByAsNodeId(System.Decimal _asNodeId, int start, int pageLength, out int count)
		{
			return GetByAsNodeId(null, _asNodeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_NODE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asNodeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;PgThesisGeneralSpec&gt;"/> class.</returns>
		public abstract TList<PgThesisGeneralSpec> GetByAsNodeId(TransactionManager transactionManager, System.Decimal _asNodeId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_PG_THESIS_GENERAL_SPEC index.
		/// </summary>
		/// <param name="_pgThesisGeneralSpecId">xxx</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisGeneralSpec"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisGeneralSpec GetByPgThesisGeneralSpecId(System.Decimal _pgThesisGeneralSpecId)
		{
			int count = -1;
			return GetByPgThesisGeneralSpecId(null,_pgThesisGeneralSpecId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_GENERAL_SPEC index.
		/// </summary>
		/// <param name="_pgThesisGeneralSpecId">xxx</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisGeneralSpec"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisGeneralSpec GetByPgThesisGeneralSpecId(System.Decimal _pgThesisGeneralSpecId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisGeneralSpecId(null, _pgThesisGeneralSpecId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_GENERAL_SPEC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisGeneralSpecId">xxx</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisGeneralSpec"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisGeneralSpec GetByPgThesisGeneralSpecId(TransactionManager transactionManager, System.Decimal _pgThesisGeneralSpecId)
		{
			int count = -1;
			return GetByPgThesisGeneralSpecId(transactionManager, _pgThesisGeneralSpecId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_GENERAL_SPEC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisGeneralSpecId">xxx</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisGeneralSpec"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisGeneralSpec GetByPgThesisGeneralSpecId(TransactionManager transactionManager, System.Decimal _pgThesisGeneralSpecId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgThesisGeneralSpecId(transactionManager, _pgThesisGeneralSpecId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_GENERAL_SPEC index.
		/// </summary>
		/// <param name="_pgThesisGeneralSpecId">xxx</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisGeneralSpec"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgThesisGeneralSpec GetByPgThesisGeneralSpecId(System.Decimal _pgThesisGeneralSpecId, int start, int pageLength, out int count)
		{
			return GetByPgThesisGeneralSpecId(null, _pgThesisGeneralSpecId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_THESIS_GENERAL_SPEC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgThesisGeneralSpecId">xxx</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgThesisGeneralSpec"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.PgThesisGeneralSpec GetByPgThesisGeneralSpecId(TransactionManager transactionManager, System.Decimal _pgThesisGeneralSpecId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;PgThesisGeneralSpec&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;PgThesisGeneralSpec&gt;"/></returns>
		public static TList<PgThesisGeneralSpec> Fill(IDataReader reader, TList<PgThesisGeneralSpec> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.PgThesisGeneralSpec c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("PgThesisGeneralSpec")
					.Append("|").Append((System.Decimal)reader["PG_THESIS_GENERAL_SPEC_ID"]).ToString();
					c = EntityManager.LocateOrCreate<PgThesisGeneralSpec>(
					key.ToString(), // EntityTrackingKey
					"PgThesisGeneralSpec",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.PgThesisGeneralSpec();
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
					c.PgThesisGeneralSpecId = (System.Decimal)reader["PG_THESIS_GENERAL_SPEC_ID"];
					c.OriginalPgThesisGeneralSpecId = c.PgThesisGeneralSpecId;
					c.AsNodeId = (System.Decimal)reader["AS_NODE_ID"];
					c.GeneralSpecCode = Convert.IsDBNull(reader["GENERAL_SPEC_CODE"]) ? null : (System.String)reader["GENERAL_SPEC_CODE"];
					c.GeneralSpecDescrAr = (System.String)reader["GENERAL_SPEC_DESCR_AR"];
					c.GeneralSpecDescrEn = Convert.IsDBNull(reader["GENERAL_SPEC_DESCR_EN"]) ? null : (System.String)reader["GENERAL_SPEC_DESCR_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.PgThesisGeneralSpec"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgThesisGeneralSpec"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.PgThesisGeneralSpec entity)
		{
			if (!reader.Read()) return;
			
			entity.PgThesisGeneralSpecId = (System.Decimal)reader[((int)PgThesisGeneralSpecColumn.PgThesisGeneralSpecId - 1)];
			entity.OriginalPgThesisGeneralSpecId = (System.Decimal)reader["PG_THESIS_GENERAL_SPEC_ID"];
			entity.AsNodeId = (System.Decimal)reader[((int)PgThesisGeneralSpecColumn.AsNodeId - 1)];
			entity.GeneralSpecCode = (reader.IsDBNull(((int)PgThesisGeneralSpecColumn.GeneralSpecCode - 1)))?null:(System.String)reader[((int)PgThesisGeneralSpecColumn.GeneralSpecCode - 1)];
			entity.GeneralSpecDescrAr = (System.String)reader[((int)PgThesisGeneralSpecColumn.GeneralSpecDescrAr - 1)];
			entity.GeneralSpecDescrEn = (reader.IsDBNull(((int)PgThesisGeneralSpecColumn.GeneralSpecDescrEn - 1)))?null:(System.String)reader[((int)PgThesisGeneralSpecColumn.GeneralSpecDescrEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.PgThesisGeneralSpec"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgThesisGeneralSpec"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.PgThesisGeneralSpec entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.PgThesisGeneralSpecId = (System.Decimal)dataRow["PG_THESIS_GENERAL_SPEC_ID"];
			entity.OriginalPgThesisGeneralSpecId = (System.Decimal)dataRow["PG_THESIS_GENERAL_SPEC_ID"];
			entity.AsNodeId = (System.Decimal)dataRow["AS_NODE_ID"];
			entity.GeneralSpecCode = Convert.IsDBNull(dataRow["GENERAL_SPEC_CODE"]) ? null : (System.String)dataRow["GENERAL_SPEC_CODE"];
			entity.GeneralSpecDescrAr = (System.String)dataRow["GENERAL_SPEC_DESCR_AR"];
			entity.GeneralSpecDescrEn = Convert.IsDBNull(dataRow["GENERAL_SPEC_DESCR_EN"]) ? null : (System.String)dataRow["GENERAL_SPEC_DESCR_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgThesisGeneralSpec"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.PgThesisGeneralSpec Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgThesisGeneralSpec entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AsNodeIdSource	
			if (CanDeepLoad(entity, "EntityMain|AsNodeIdSource", deepLoadType, innerList) 
				&& entity.AsNodeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AsNodeId;
				EntityMain tmpEntity = EntityManager.LocateEntity<EntityMain>(EntityLocator.ConstructKeyFromPkItems(typeof(EntityMain), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AsNodeIdSource = tmpEntity;
				else
					entity.AsNodeIdSource = DataRepository.EntityMainProvider.GetByEntMainId(transactionManager, entity.AsNodeId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AsNodeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AsNodeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EntityMainProvider.DeepLoad(transactionManager, entity.AsNodeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AsNodeIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByPgThesisGeneralSpecId methods when available
			
			#region SaScQualCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaScQual>|SaScQualCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaScQualCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaScQualCollection = DataRepository.SaScQualProvider.GetByPgThesisGeneralSpecId(transactionManager, entity.PgThesisGeneralSpecId);

				if (deep && entity.SaScQualCollection.Count > 0)
				{
					deepHandles.Add("SaScQualCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaScQual>) DataRepository.SaScQualProvider.DeepLoad,
						new object[] { transactionManager, entity.SaScQualCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaStfMemberCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaStfMember>|SaStfMemberCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaStfMemberCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaStfMemberCollection = DataRepository.SaStfMemberProvider.GetByPgThesisGeneralSpecId(transactionManager, entity.PgThesisGeneralSpecId);

				if (deep && entity.SaStfMemberCollection.Count > 0)
				{
					deepHandles.Add("SaStfMemberCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaStfMember>) DataRepository.SaStfMemberProvider.DeepLoad,
						new object[] { transactionManager, entity.SaStfMemberCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region PgThesisDetailedSpecCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgThesisDetailedSpec>|PgThesisDetailedSpecCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisDetailedSpecCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgThesisDetailedSpecCollection = DataRepository.PgThesisDetailedSpecProvider.GetByPgThesisGeneralSpecId(transactionManager, entity.PgThesisGeneralSpecId);

				if (deep && entity.PgThesisDetailedSpecCollection.Count > 0)
				{
					deepHandles.Add("PgThesisDetailedSpecCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgThesisDetailedSpec>) DataRepository.PgThesisDetailedSpecProvider.DeepLoad,
						new object[] { transactionManager, entity.PgThesisDetailedSpecCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaEmploymentCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaEmployment>|SaEmploymentCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaEmploymentCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaEmploymentCollection = DataRepository.SaEmploymentProvider.GetByPgThesisGeneralSpecId(transactionManager, entity.PgThesisGeneralSpecId);

				if (deep && entity.SaEmploymentCollection.Count > 0)
				{
					deepHandles.Add("SaEmploymentCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaEmployment>) DataRepository.SaEmploymentProvider.DeepLoad,
						new object[] { transactionManager, entity.SaEmploymentCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.PgThesisGeneralSpec object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.PgThesisGeneralSpec instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.PgThesisGeneralSpec Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgThesisGeneralSpec entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AsNodeIdSource
			if (CanDeepSave(entity, "EntityMain|AsNodeIdSource", deepSaveType, innerList) 
				&& entity.AsNodeIdSource != null)
			{
				DataRepository.EntityMainProvider.Save(transactionManager, entity.AsNodeIdSource);
				entity.AsNodeId = entity.AsNodeIdSource.EntMainId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<SaScQual>
				if (CanDeepSave(entity.SaScQualCollection, "List<SaScQual>|SaScQualCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaScQual child in entity.SaScQualCollection)
					{
						if(child.PgThesisGeneralSpecIdSource != null)
						{
							child.PgThesisGeneralSpecId = child.PgThesisGeneralSpecIdSource.PgThesisGeneralSpecId;
						}
						else
						{
							child.PgThesisGeneralSpecId = entity.PgThesisGeneralSpecId;
						}

					}

					if (entity.SaScQualCollection.Count > 0 || entity.SaScQualCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaScQualProvider.Save(transactionManager, entity.SaScQualCollection);
						
						deepHandles.Add("SaScQualCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaScQual >) DataRepository.SaScQualProvider.DeepSave,
							new object[] { transactionManager, entity.SaScQualCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaStfMember>
				if (CanDeepSave(entity.SaStfMemberCollection, "List<SaStfMember>|SaStfMemberCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaStfMember child in entity.SaStfMemberCollection)
					{
						if(child.PgThesisGeneralSpecIdSource != null)
						{
							child.PgThesisGeneralSpecId = child.PgThesisGeneralSpecIdSource.PgThesisGeneralSpecId;
						}
						else
						{
							child.PgThesisGeneralSpecId = entity.PgThesisGeneralSpecId;
						}

					}

					if (entity.SaStfMemberCollection.Count > 0 || entity.SaStfMemberCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaStfMemberProvider.Save(transactionManager, entity.SaStfMemberCollection);
						
						deepHandles.Add("SaStfMemberCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaStfMember >) DataRepository.SaStfMemberProvider.DeepSave,
							new object[] { transactionManager, entity.SaStfMemberCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<PgThesisDetailedSpec>
				if (CanDeepSave(entity.PgThesisDetailedSpecCollection, "List<PgThesisDetailedSpec>|PgThesisDetailedSpecCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgThesisDetailedSpec child in entity.PgThesisDetailedSpecCollection)
					{
						if(child.PgThesisGeneralSpecIdSource != null)
						{
							child.PgThesisGeneralSpecId = child.PgThesisGeneralSpecIdSource.PgThesisGeneralSpecId;
						}
						else
						{
							child.PgThesisGeneralSpecId = entity.PgThesisGeneralSpecId;
						}

					}

					if (entity.PgThesisDetailedSpecCollection.Count > 0 || entity.PgThesisDetailedSpecCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgThesisDetailedSpecProvider.Save(transactionManager, entity.PgThesisDetailedSpecCollection);
						
						deepHandles.Add("PgThesisDetailedSpecCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgThesisDetailedSpec >) DataRepository.PgThesisDetailedSpecProvider.DeepSave,
							new object[] { transactionManager, entity.PgThesisDetailedSpecCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaEmployment>
				if (CanDeepSave(entity.SaEmploymentCollection, "List<SaEmployment>|SaEmploymentCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaEmployment child in entity.SaEmploymentCollection)
					{
						if(child.PgThesisGeneralSpecIdSource != null)
						{
							child.PgThesisGeneralSpecId = child.PgThesisGeneralSpecIdSource.PgThesisGeneralSpecId;
						}
						else
						{
							child.PgThesisGeneralSpecId = entity.PgThesisGeneralSpecId;
						}

					}

					if (entity.SaEmploymentCollection.Count > 0 || entity.SaEmploymentCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaEmploymentProvider.Save(transactionManager, entity.SaEmploymentCollection);
						
						deepHandles.Add("SaEmploymentCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaEmployment >) DataRepository.SaEmploymentProvider.DeepSave,
							new object[] { transactionManager, entity.SaEmploymentCollection, deepSaveType, childTypes, innerList }
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
	
	#region PgThesisGeneralSpecChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.PgThesisGeneralSpec</c>
	///</summary>
	public enum PgThesisGeneralSpecChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EntityMain</c> at AsNodeIdSource
		///</summary>
		[ChildEntityType(typeof(EntityMain))]
		EntityMain,
		///<summary>
		/// Collection of <c>PgThesisGeneralSpec</c> as OneToMany for SaScQualCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaScQual>))]
		SaScQualCollection,
		///<summary>
		/// Collection of <c>PgThesisGeneralSpec</c> as OneToMany for SaStfMemberCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaStfMember>))]
		SaStfMemberCollection,
		///<summary>
		/// Collection of <c>PgThesisGeneralSpec</c> as OneToMany for PgThesisDetailedSpecCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgThesisDetailedSpec>))]
		PgThesisDetailedSpecCollection,
		///<summary>
		/// Collection of <c>PgThesisGeneralSpec</c> as OneToMany for SaEmploymentCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaEmployment>))]
		SaEmploymentCollection,
	}
	
	#endregion PgThesisGeneralSpecChildEntityTypes
	
	#region PgThesisGeneralSpecFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;PgThesisGeneralSpecColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgThesisGeneralSpec"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PgThesisGeneralSpecFilterBuilder : SqlFilterBuilder<PgThesisGeneralSpecColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgThesisGeneralSpecFilterBuilder class.
		/// </summary>
		public PgThesisGeneralSpecFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PgThesisGeneralSpecFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PgThesisGeneralSpecFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PgThesisGeneralSpecFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PgThesisGeneralSpecFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PgThesisGeneralSpecFilterBuilder
	
	#region PgThesisGeneralSpecParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;PgThesisGeneralSpecColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgThesisGeneralSpec"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PgThesisGeneralSpecParameterBuilder : ParameterizedSqlFilterBuilder<PgThesisGeneralSpecColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgThesisGeneralSpecParameterBuilder class.
		/// </summary>
		public PgThesisGeneralSpecParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PgThesisGeneralSpecParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PgThesisGeneralSpecParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PgThesisGeneralSpecParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PgThesisGeneralSpecParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PgThesisGeneralSpecParameterBuilder
	
	#region PgThesisGeneralSpecSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;PgThesisGeneralSpecColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgThesisGeneralSpec"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class PgThesisGeneralSpecSortBuilder : SqlSortBuilder<PgThesisGeneralSpecColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgThesisGeneralSpecSqlSortBuilder class.
		/// </summary>
		public PgThesisGeneralSpecSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion PgThesisGeneralSpecSortBuilder
	
} // end namespace
