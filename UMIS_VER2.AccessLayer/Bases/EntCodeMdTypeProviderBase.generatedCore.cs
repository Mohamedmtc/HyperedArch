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
	/// This class is the base class for any <see cref="EntCodeMdTypeProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EntCodeMdTypeProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EntCodeMdType, UMIS_VER2.BusinessLyer.EntCodeMdTypeKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntCodeMdTypeKey key)
		{
			return Delete(transactionManager, key.EntCodeMdTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_entCodeMdTypeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _entCodeMdTypeId)
		{
			return Delete(null, _entCodeMdTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodeMdTypeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _entCodeMdTypeId);		
		
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
		public override UMIS_VER2.BusinessLyer.EntCodeMdType Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntCodeMdTypeKey key, int start, int pageLength)
		{
			return GetByEntCodeMdTypeId(transactionManager, key.EntCodeMdTypeId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_CODE_MD_TYPE index.
		/// </summary>
		/// <param name="_entCodeMdTypeId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntCodeMdType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntCodeMdType GetByEntCodeMdTypeId(System.Decimal _entCodeMdTypeId)
		{
			int count = -1;
			return GetByEntCodeMdTypeId(null,_entCodeMdTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_MD_TYPE index.
		/// </summary>
		/// <param name="_entCodeMdTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntCodeMdType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntCodeMdType GetByEntCodeMdTypeId(System.Decimal _entCodeMdTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntCodeMdTypeId(null, _entCodeMdTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_MD_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodeMdTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntCodeMdType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntCodeMdType GetByEntCodeMdTypeId(TransactionManager transactionManager, System.Decimal _entCodeMdTypeId)
		{
			int count = -1;
			return GetByEntCodeMdTypeId(transactionManager, _entCodeMdTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_MD_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodeMdTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntCodeMdType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntCodeMdType GetByEntCodeMdTypeId(TransactionManager transactionManager, System.Decimal _entCodeMdTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntCodeMdTypeId(transactionManager, _entCodeMdTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_MD_TYPE index.
		/// </summary>
		/// <param name="_entCodeMdTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntCodeMdType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntCodeMdType GetByEntCodeMdTypeId(System.Decimal _entCodeMdTypeId, int start, int pageLength, out int count)
		{
			return GetByEntCodeMdTypeId(null, _entCodeMdTypeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_MD_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodeMdTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntCodeMdType"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EntCodeMdType GetByEntCodeMdTypeId(TransactionManager transactionManager, System.Decimal _entCodeMdTypeId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EntCodeMdType&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EntCodeMdType&gt;"/></returns>
		public static TList<EntCodeMdType> Fill(IDataReader reader, TList<EntCodeMdType> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EntCodeMdType c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EntCodeMdType")
					.Append("|").Append((System.Decimal)reader["ENT_CODE_MD_TYPE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EntCodeMdType>(
					key.ToString(), // EntityTrackingKey
					"EntCodeMdType",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EntCodeMdType();
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
					c.EntCodeMdTypeId = (System.Decimal)reader["ENT_CODE_MD_TYPE_ID"];
					c.OriginalEntCodeMdTypeId = c.EntCodeMdTypeId;
					c.MdTypeDescrAr = Convert.IsDBNull(reader["MD_TYPE_DESCR_AR"]) ? null : (System.String)reader["MD_TYPE_DESCR_AR"];
					c.MdTypeDescrEn = Convert.IsDBNull(reader["MD_TYPE_DESCR_EN"]) ? null : (System.String)reader["MD_TYPE_DESCR_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntCodeMdType"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntCodeMdType"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EntCodeMdType entity)
		{
			if (!reader.Read()) return;
			
			entity.EntCodeMdTypeId = (System.Decimal)reader[((int)EntCodeMdTypeColumn.EntCodeMdTypeId - 1)];
			entity.OriginalEntCodeMdTypeId = (System.Decimal)reader["ENT_CODE_MD_TYPE_ID"];
			entity.MdTypeDescrAr = (reader.IsDBNull(((int)EntCodeMdTypeColumn.MdTypeDescrAr - 1)))?null:(System.String)reader[((int)EntCodeMdTypeColumn.MdTypeDescrAr - 1)];
			entity.MdTypeDescrEn = (reader.IsDBNull(((int)EntCodeMdTypeColumn.MdTypeDescrEn - 1)))?null:(System.String)reader[((int)EntCodeMdTypeColumn.MdTypeDescrEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntCodeMdType"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntCodeMdType"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EntCodeMdType entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EntCodeMdTypeId = (System.Decimal)dataRow["ENT_CODE_MD_TYPE_ID"];
			entity.OriginalEntCodeMdTypeId = (System.Decimal)dataRow["ENT_CODE_MD_TYPE_ID"];
			entity.MdTypeDescrAr = Convert.IsDBNull(dataRow["MD_TYPE_DESCR_AR"]) ? null : (System.String)dataRow["MD_TYPE_DESCR_AR"];
			entity.MdTypeDescrEn = Convert.IsDBNull(dataRow["MD_TYPE_DESCR_EN"]) ? null : (System.String)dataRow["MD_TYPE_DESCR_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntCodeMdType"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntCodeMdType Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntCodeMdType entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEntCodeMdTypeId methods when available
			
			#region EntCodeFullfillMetadataCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntCodeFullfillMetadata>|EntCodeFullfillMetadataCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntCodeFullfillMetadataCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntCodeFullfillMetadataCollection = DataRepository.EntCodeFullfillMetadataProvider.GetByEntCodeMdTypeId(transactionManager, entity.EntCodeMdTypeId);

				if (deep && entity.EntCodeFullfillMetadataCollection.Count > 0)
				{
					deepHandles.Add("EntCodeFullfillMetadataCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntCodeFullfillMetadata>) DataRepository.EntCodeFullfillMetadataProvider.DeepLoad,
						new object[] { transactionManager, entity.EntCodeFullfillMetadataCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntCodePolicyMetadataCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntCodePolicyMetadata>|EntCodePolicyMetadataCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntCodePolicyMetadataCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntCodePolicyMetadataCollection = DataRepository.EntCodePolicyMetadataProvider.GetByEntCodeMdTypeId(transactionManager, entity.EntCodeMdTypeId);

				if (deep && entity.EntCodePolicyMetadataCollection.Count > 0)
				{
					deepHandles.Add("EntCodePolicyMetadataCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntCodePolicyMetadata>) DataRepository.EntCodePolicyMetadataProvider.DeepLoad,
						new object[] { transactionManager, entity.EntCodePolicyMetadataCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntCodeIntroMetadataCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntCodeIntroMetadata>|EntCodeIntroMetadataCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntCodeIntroMetadataCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntCodeIntroMetadataCollection = DataRepository.EntCodeIntroMetadataProvider.GetByEntCodeMdTypeId(transactionManager, entity.EntCodeMdTypeId);

				if (deep && entity.EntCodeIntroMetadataCollection.Count > 0)
				{
					deepHandles.Add("EntCodeIntroMetadataCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntCodeIntroMetadata>) DataRepository.EntCodeIntroMetadataProvider.DeepLoad,
						new object[] { transactionManager, entity.EntCodeIntroMetadataCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AccomCdePrecondCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AccomCdePrecond>|AccomCdePrecondCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AccomCdePrecondCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AccomCdePrecondCollection = DataRepository.AccomCdePrecondProvider.GetByEntCodeMdTypeId(transactionManager, entity.EntCodeMdTypeId);

				if (deep && entity.AccomCdePrecondCollection.Count > 0)
				{
					deepHandles.Add("AccomCdePrecondCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AccomCdePrecond>) DataRepository.AccomCdePrecondProvider.DeepLoad,
						new object[] { transactionManager, entity.AccomCdePrecondCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntCodePrecondMetadataCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntCodePrecondMetadata>|EntCodePrecondMetadataCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntCodePrecondMetadataCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntCodePrecondMetadataCollection = DataRepository.EntCodePrecondMetadataProvider.GetByEntCodeMdTypeId(transactionManager, entity.EntCodeMdTypeId);

				if (deep && entity.EntCodePrecondMetadataCollection.Count > 0)
				{
					deepHandles.Add("EntCodePrecondMetadataCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntCodePrecondMetadata>) DataRepository.EntCodePrecondMetadataProvider.DeepLoad,
						new object[] { transactionManager, entity.EntCodePrecondMetadataCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntCodeGradingMetadataCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntCodeGradingMetadata>|EntCodeGradingMetadataCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntCodeGradingMetadataCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntCodeGradingMetadataCollection = DataRepository.EntCodeGradingMetadataProvider.GetByEntCodeMdTypeId(transactionManager, entity.EntCodeMdTypeId);

				if (deep && entity.EntCodeGradingMetadataCollection.Count > 0)
				{
					deepHandles.Add("EntCodeGradingMetadataCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntCodeGradingMetadata>) DataRepository.EntCodeGradingMetadataProvider.DeepLoad,
						new object[] { transactionManager, entity.EntCodeGradingMetadataCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EntCodeMdType object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EntCodeMdType instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntCodeMdType Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntCodeMdType entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<EntCodeFullfillMetadata>
				if (CanDeepSave(entity.EntCodeFullfillMetadataCollection, "List<EntCodeFullfillMetadata>|EntCodeFullfillMetadataCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntCodeFullfillMetadata child in entity.EntCodeFullfillMetadataCollection)
					{
						if(child.EntCodeMdTypeIdSource != null)
						{
							child.EntCodeMdTypeId = child.EntCodeMdTypeIdSource.EntCodeMdTypeId;
						}
						else
						{
							child.EntCodeMdTypeId = entity.EntCodeMdTypeId;
						}

					}

					if (entity.EntCodeFullfillMetadataCollection.Count > 0 || entity.EntCodeFullfillMetadataCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntCodeFullfillMetadataProvider.Save(transactionManager, entity.EntCodeFullfillMetadataCollection);
						
						deepHandles.Add("EntCodeFullfillMetadataCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntCodeFullfillMetadata >) DataRepository.EntCodeFullfillMetadataProvider.DeepSave,
							new object[] { transactionManager, entity.EntCodeFullfillMetadataCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntCodePolicyMetadata>
				if (CanDeepSave(entity.EntCodePolicyMetadataCollection, "List<EntCodePolicyMetadata>|EntCodePolicyMetadataCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntCodePolicyMetadata child in entity.EntCodePolicyMetadataCollection)
					{
						if(child.EntCodeMdTypeIdSource != null)
						{
							child.EntCodeMdTypeId = child.EntCodeMdTypeIdSource.EntCodeMdTypeId;
						}
						else
						{
							child.EntCodeMdTypeId = entity.EntCodeMdTypeId;
						}

					}

					if (entity.EntCodePolicyMetadataCollection.Count > 0 || entity.EntCodePolicyMetadataCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntCodePolicyMetadataProvider.Save(transactionManager, entity.EntCodePolicyMetadataCollection);
						
						deepHandles.Add("EntCodePolicyMetadataCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntCodePolicyMetadata >) DataRepository.EntCodePolicyMetadataProvider.DeepSave,
							new object[] { transactionManager, entity.EntCodePolicyMetadataCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntCodeIntroMetadata>
				if (CanDeepSave(entity.EntCodeIntroMetadataCollection, "List<EntCodeIntroMetadata>|EntCodeIntroMetadataCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntCodeIntroMetadata child in entity.EntCodeIntroMetadataCollection)
					{
						if(child.EntCodeMdTypeIdSource != null)
						{
							child.EntCodeMdTypeId = child.EntCodeMdTypeIdSource.EntCodeMdTypeId;
						}
						else
						{
							child.EntCodeMdTypeId = entity.EntCodeMdTypeId;
						}

					}

					if (entity.EntCodeIntroMetadataCollection.Count > 0 || entity.EntCodeIntroMetadataCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntCodeIntroMetadataProvider.Save(transactionManager, entity.EntCodeIntroMetadataCollection);
						
						deepHandles.Add("EntCodeIntroMetadataCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntCodeIntroMetadata >) DataRepository.EntCodeIntroMetadataProvider.DeepSave,
							new object[] { transactionManager, entity.EntCodeIntroMetadataCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AccomCdePrecond>
				if (CanDeepSave(entity.AccomCdePrecondCollection, "List<AccomCdePrecond>|AccomCdePrecondCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AccomCdePrecond child in entity.AccomCdePrecondCollection)
					{
						if(child.EntCodeMdTypeIdSource != null)
						{
							child.EntCodeMdTypeId = child.EntCodeMdTypeIdSource.EntCodeMdTypeId;
						}
						else
						{
							child.EntCodeMdTypeId = entity.EntCodeMdTypeId;
						}

					}

					if (entity.AccomCdePrecondCollection.Count > 0 || entity.AccomCdePrecondCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AccomCdePrecondProvider.Save(transactionManager, entity.AccomCdePrecondCollection);
						
						deepHandles.Add("AccomCdePrecondCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AccomCdePrecond >) DataRepository.AccomCdePrecondProvider.DeepSave,
							new object[] { transactionManager, entity.AccomCdePrecondCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntCodePrecondMetadata>
				if (CanDeepSave(entity.EntCodePrecondMetadataCollection, "List<EntCodePrecondMetadata>|EntCodePrecondMetadataCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntCodePrecondMetadata child in entity.EntCodePrecondMetadataCollection)
					{
						if(child.EntCodeMdTypeIdSource != null)
						{
							child.EntCodeMdTypeId = child.EntCodeMdTypeIdSource.EntCodeMdTypeId;
						}
						else
						{
							child.EntCodeMdTypeId = entity.EntCodeMdTypeId;
						}

					}

					if (entity.EntCodePrecondMetadataCollection.Count > 0 || entity.EntCodePrecondMetadataCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntCodePrecondMetadataProvider.Save(transactionManager, entity.EntCodePrecondMetadataCollection);
						
						deepHandles.Add("EntCodePrecondMetadataCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntCodePrecondMetadata >) DataRepository.EntCodePrecondMetadataProvider.DeepSave,
							new object[] { transactionManager, entity.EntCodePrecondMetadataCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntCodeGradingMetadata>
				if (CanDeepSave(entity.EntCodeGradingMetadataCollection, "List<EntCodeGradingMetadata>|EntCodeGradingMetadataCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntCodeGradingMetadata child in entity.EntCodeGradingMetadataCollection)
					{
						if(child.EntCodeMdTypeIdSource != null)
						{
							child.EntCodeMdTypeId = child.EntCodeMdTypeIdSource.EntCodeMdTypeId;
						}
						else
						{
							child.EntCodeMdTypeId = entity.EntCodeMdTypeId;
						}

					}

					if (entity.EntCodeGradingMetadataCollection.Count > 0 || entity.EntCodeGradingMetadataCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntCodeGradingMetadataProvider.Save(transactionManager, entity.EntCodeGradingMetadataCollection);
						
						deepHandles.Add("EntCodeGradingMetadataCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntCodeGradingMetadata >) DataRepository.EntCodeGradingMetadataProvider.DeepSave,
							new object[] { transactionManager, entity.EntCodeGradingMetadataCollection, deepSaveType, childTypes, innerList }
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
	
	#region EntCodeMdTypeChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EntCodeMdType</c>
	///</summary>
	public enum EntCodeMdTypeChildEntityTypes
	{
		///<summary>
		/// Collection of <c>EntCodeMdType</c> as OneToMany for EntCodeFullfillMetadataCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntCodeFullfillMetadata>))]
		EntCodeFullfillMetadataCollection,
		///<summary>
		/// Collection of <c>EntCodeMdType</c> as OneToMany for EntCodePolicyMetadataCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntCodePolicyMetadata>))]
		EntCodePolicyMetadataCollection,
		///<summary>
		/// Collection of <c>EntCodeMdType</c> as OneToMany for EntCodeIntroMetadataCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntCodeIntroMetadata>))]
		EntCodeIntroMetadataCollection,
		///<summary>
		/// Collection of <c>EntCodeMdType</c> as OneToMany for AccomCdePrecondCollection
		///</summary>
		[ChildEntityType(typeof(TList<AccomCdePrecond>))]
		AccomCdePrecondCollection,
		///<summary>
		/// Collection of <c>EntCodeMdType</c> as OneToMany for EntCodePrecondMetadataCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntCodePrecondMetadata>))]
		EntCodePrecondMetadataCollection,
		///<summary>
		/// Collection of <c>EntCodeMdType</c> as OneToMany for EntCodeGradingMetadataCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntCodeGradingMetadata>))]
		EntCodeGradingMetadataCollection,
	}
	
	#endregion EntCodeMdTypeChildEntityTypes
	
	#region EntCodeMdTypeFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntCodeMdTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntCodeMdType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntCodeMdTypeFilterBuilder : SqlFilterBuilder<EntCodeMdTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntCodeMdTypeFilterBuilder class.
		/// </summary>
		public EntCodeMdTypeFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntCodeMdTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntCodeMdTypeFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntCodeMdTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntCodeMdTypeFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntCodeMdTypeFilterBuilder
	
	#region EntCodeMdTypeParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntCodeMdTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntCodeMdType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntCodeMdTypeParameterBuilder : ParameterizedSqlFilterBuilder<EntCodeMdTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntCodeMdTypeParameterBuilder class.
		/// </summary>
		public EntCodeMdTypeParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntCodeMdTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntCodeMdTypeParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntCodeMdTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntCodeMdTypeParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntCodeMdTypeParameterBuilder
	
	#region EntCodeMdTypeSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntCodeMdTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntCodeMdType"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EntCodeMdTypeSortBuilder : SqlSortBuilder<EntCodeMdTypeColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntCodeMdTypeSqlSortBuilder class.
		/// </summary>
		public EntCodeMdTypeSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EntCodeMdTypeSortBuilder
	
} // end namespace
