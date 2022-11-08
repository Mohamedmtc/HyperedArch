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
	/// This class is the base class for any <see cref="EdCodeStudyMethodProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdCodeStudyMethodProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdCodeStudyMethod, UMIS_VER2.BusinessLyer.EdCodeStudyMethodKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeStudyMethodKey key)
		{
			return Delete(transactionManager, key.EdCodeStudyMethodId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edCodeStudyMethodId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edCodeStudyMethodId)
		{
			return Delete(null, _edCodeStudyMethodId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeStudyMethodId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edCodeStudyMethodId);		
		
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
		public override UMIS_VER2.BusinessLyer.EdCodeStudyMethod Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeStudyMethodKey key, int start, int pageLength)
		{
			return GetByEdCodeStudyMethodId(transactionManager, key.EdCodeStudyMethodId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_CODE_STUDY_METHOD index.
		/// </summary>
		/// <param name="_edCodeStudyMethodId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeStudyMethod"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeStudyMethod GetByEdCodeStudyMethodId(System.Decimal _edCodeStudyMethodId)
		{
			int count = -1;
			return GetByEdCodeStudyMethodId(null,_edCodeStudyMethodId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_STUDY_METHOD index.
		/// </summary>
		/// <param name="_edCodeStudyMethodId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeStudyMethod"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeStudyMethod GetByEdCodeStudyMethodId(System.Decimal _edCodeStudyMethodId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeStudyMethodId(null, _edCodeStudyMethodId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_STUDY_METHOD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeStudyMethodId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeStudyMethod"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeStudyMethod GetByEdCodeStudyMethodId(TransactionManager transactionManager, System.Decimal _edCodeStudyMethodId)
		{
			int count = -1;
			return GetByEdCodeStudyMethodId(transactionManager, _edCodeStudyMethodId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_STUDY_METHOD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeStudyMethodId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeStudyMethod"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeStudyMethod GetByEdCodeStudyMethodId(TransactionManager transactionManager, System.Decimal _edCodeStudyMethodId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeStudyMethodId(transactionManager, _edCodeStudyMethodId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_STUDY_METHOD index.
		/// </summary>
		/// <param name="_edCodeStudyMethodId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeStudyMethod"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeStudyMethod GetByEdCodeStudyMethodId(System.Decimal _edCodeStudyMethodId, int start, int pageLength, out int count)
		{
			return GetByEdCodeStudyMethodId(null, _edCodeStudyMethodId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_STUDY_METHOD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeStudyMethodId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeStudyMethod"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdCodeStudyMethod GetByEdCodeStudyMethodId(TransactionManager transactionManager, System.Decimal _edCodeStudyMethodId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdCodeStudyMethod&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdCodeStudyMethod&gt;"/></returns>
		public static TList<EdCodeStudyMethod> Fill(IDataReader reader, TList<EdCodeStudyMethod> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdCodeStudyMethod c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdCodeStudyMethod")
					.Append("|").Append((System.Decimal)reader["ED_CODE_STUDY_METHOD_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdCodeStudyMethod>(
					key.ToString(), // EntityTrackingKey
					"EdCodeStudyMethod",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdCodeStudyMethod();
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
					c.EdCodeStudyMethodId = (System.Decimal)reader["ED_CODE_STUDY_METHOD_ID"];
					c.OriginalEdCodeStudyMethodId = c.EdCodeStudyMethodId;
					c.MethodDescrAr = (System.String)reader["METHOD_DESCR_AR"];
					c.MethodDescrEn = Convert.IsDBNull(reader["METHOD_DESCR_EN"]) ? null : (System.String)reader["METHOD_DESCR_EN"];
					c.MethodCode = Convert.IsDBNull(reader["METHOD_CODE"]) ? null : (System.String)reader["METHOD_CODE"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCodeStudyMethod"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeStudyMethod"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdCodeStudyMethod entity)
		{
			if (!reader.Read()) return;
			
			entity.EdCodeStudyMethodId = (System.Decimal)reader[((int)EdCodeStudyMethodColumn.EdCodeStudyMethodId - 1)];
			entity.OriginalEdCodeStudyMethodId = (System.Decimal)reader["ED_CODE_STUDY_METHOD_ID"];
			entity.MethodDescrAr = (System.String)reader[((int)EdCodeStudyMethodColumn.MethodDescrAr - 1)];
			entity.MethodDescrEn = (reader.IsDBNull(((int)EdCodeStudyMethodColumn.MethodDescrEn - 1)))?null:(System.String)reader[((int)EdCodeStudyMethodColumn.MethodDescrEn - 1)];
			entity.MethodCode = (reader.IsDBNull(((int)EdCodeStudyMethodColumn.MethodCode - 1)))?null:(System.String)reader[((int)EdCodeStudyMethodColumn.MethodCode - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCodeStudyMethod"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeStudyMethod"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdCodeStudyMethod entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdCodeStudyMethodId = (System.Decimal)dataRow["ED_CODE_STUDY_METHOD_ID"];
			entity.OriginalEdCodeStudyMethodId = (System.Decimal)dataRow["ED_CODE_STUDY_METHOD_ID"];
			entity.MethodDescrAr = (System.String)dataRow["METHOD_DESCR_AR"];
			entity.MethodDescrEn = Convert.IsDBNull(dataRow["METHOD_DESCR_EN"]) ? null : (System.String)dataRow["METHOD_DESCR_EN"];
			entity.MethodCode = Convert.IsDBNull(dataRow["METHOD_CODE"]) ? null : (System.String)dataRow["METHOD_CODE"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeStudyMethod"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCodeStudyMethod Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeStudyMethod entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEdCodeStudyMethodId methods when available
			
			#region SeFormCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SeForm>|SeFormCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeFormCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SeFormCollection = DataRepository.SeFormProvider.GetByEdCodeStudyMethodId(transactionManager, entity.EdCodeStudyMethodId);

				if (deep && entity.SeFormCollection.Count > 0)
				{
					deepHandles.Add("SeFormCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SeForm>) DataRepository.SeFormProvider.DeepLoad,
						new object[] { transactionManager, entity.SeFormCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntCodeFullfillMetadataCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntCodeFullfillMetadata>|EntCodeFullfillMetadataCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntCodeFullfillMetadataCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntCodeFullfillMetadataCollection = DataRepository.EntCodeFullfillMetadataProvider.GetByEdCodeStudyMethodId(transactionManager, entity.EdCodeStudyMethodId);

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

				entity.EntCodePolicyMetadataCollection = DataRepository.EntCodePolicyMetadataProvider.GetByEdCodeStudyMethodId(transactionManager, entity.EdCodeStudyMethodId);

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

				entity.EntCodeIntroMetadataCollection = DataRepository.EntCodeIntroMetadataProvider.GetByEdCodeStudyMethodId(transactionManager, entity.EdCodeStudyMethodId);

				if (deep && entity.EntCodeIntroMetadataCollection.Count > 0)
				{
					deepHandles.Add("EntCodeIntroMetadataCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntCodeIntroMetadata>) DataRepository.EntCodeIntroMetadataProvider.DeepLoad,
						new object[] { transactionManager, entity.EntCodeIntroMetadataCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdSemesterOpenCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdSemesterOpen>|EdSemesterOpenCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdSemesterOpenCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdSemesterOpenCollection = DataRepository.EdSemesterOpenProvider.GetByEdCodeStudyMethodId(transactionManager, entity.EdCodeStudyMethodId);

				if (deep && entity.EdSemesterOpenCollection.Count > 0)
				{
					deepHandles.Add("EdSemesterOpenCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdSemesterOpen>) DataRepository.EdSemesterOpenProvider.DeepLoad,
						new object[] { transactionManager, entity.EdSemesterOpenCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntityMainCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntityMain>|EntityMainCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntityMainCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntityMainCollection = DataRepository.EntityMainProvider.GetByEdStudyMethodId(transactionManager, entity.EdCodeStudyMethodId);

				if (deep && entity.EntityMainCollection.Count > 0)
				{
					deepHandles.Add("EntityMainCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntityMain>) DataRepository.EntityMainProvider.DeepLoad,
						new object[] { transactionManager, entity.EntityMainCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdCodeRatingCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdCodeRating>|EdCodeRatingCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeRatingCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdCodeRatingCollection = DataRepository.EdCodeRatingProvider.GetByEdCodeStudyMethodId(transactionManager, entity.EdCodeStudyMethodId);

				if (deep && entity.EdCodeRatingCollection.Count > 0)
				{
					deepHandles.Add("EdCodeRatingCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdCodeRating>) DataRepository.EdCodeRatingProvider.DeepLoad,
						new object[] { transactionManager, entity.EdCodeRatingCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.EntCodeGradingMetadataCollection = DataRepository.EntCodeGradingMetadataProvider.GetByEdCodeStudyMethodId(transactionManager, entity.EdCodeStudyMethodId);

				if (deep && entity.EntCodeGradingMetadataCollection.Count > 0)
				{
					deepHandles.Add("EntCodeGradingMetadataCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntCodeGradingMetadata>) DataRepository.EntCodeGradingMetadataProvider.DeepLoad,
						new object[] { transactionManager, entity.EntCodeGradingMetadataCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.EntCodePrecondMetadataCollection = DataRepository.EntCodePrecondMetadataProvider.GetByEdCodeStudyMethodId(transactionManager, entity.EdCodeStudyMethodId);

				if (deep && entity.EntCodePrecondMetadataCollection.Count > 0)
				{
					deepHandles.Add("EntCodePrecondMetadataCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntCodePrecondMetadata>) DataRepository.EntCodePrecondMetadataProvider.DeepLoad,
						new object[] { transactionManager, entity.EntCodePrecondMetadataCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdBylawCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdBylaw>|EdBylawCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdBylawCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdBylawCollection = DataRepository.EdBylawProvider.GetByEdCodeStudyMethodId(transactionManager, entity.EdCodeStudyMethodId);

				if (deep && entity.EdBylawCollection.Count > 0)
				{
					deepHandles.Add("EdBylawCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdBylaw>) DataRepository.EdBylawProvider.DeepLoad,
						new object[] { transactionManager, entity.EdBylawCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdCodeStudyMethod object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdCodeStudyMethod instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCodeStudyMethod Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeStudyMethod entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<SeForm>
				if (CanDeepSave(entity.SeFormCollection, "List<SeForm>|SeFormCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SeForm child in entity.SeFormCollection)
					{
						if(child.EdCodeStudyMethodIdSource != null)
						{
							child.EdCodeStudyMethodId = child.EdCodeStudyMethodIdSource.EdCodeStudyMethodId;
						}
						else
						{
							child.EdCodeStudyMethodId = entity.EdCodeStudyMethodId;
						}

					}

					if (entity.SeFormCollection.Count > 0 || entity.SeFormCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SeFormProvider.Save(transactionManager, entity.SeFormCollection);
						
						deepHandles.Add("SeFormCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SeForm >) DataRepository.SeFormProvider.DeepSave,
							new object[] { transactionManager, entity.SeFormCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntCodeFullfillMetadata>
				if (CanDeepSave(entity.EntCodeFullfillMetadataCollection, "List<EntCodeFullfillMetadata>|EntCodeFullfillMetadataCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntCodeFullfillMetadata child in entity.EntCodeFullfillMetadataCollection)
					{
						if(child.EdCodeStudyMethodIdSource != null)
						{
							child.EdCodeStudyMethodId = child.EdCodeStudyMethodIdSource.EdCodeStudyMethodId;
						}
						else
						{
							child.EdCodeStudyMethodId = entity.EdCodeStudyMethodId;
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
						if(child.EdCodeStudyMethodIdSource != null)
						{
							child.EdCodeStudyMethodId = child.EdCodeStudyMethodIdSource.EdCodeStudyMethodId;
						}
						else
						{
							child.EdCodeStudyMethodId = entity.EdCodeStudyMethodId;
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
						if(child.EdCodeStudyMethodIdSource != null)
						{
							child.EdCodeStudyMethodId = child.EdCodeStudyMethodIdSource.EdCodeStudyMethodId;
						}
						else
						{
							child.EdCodeStudyMethodId = entity.EdCodeStudyMethodId;
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
				
	
			#region List<EdSemesterOpen>
				if (CanDeepSave(entity.EdSemesterOpenCollection, "List<EdSemesterOpen>|EdSemesterOpenCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdSemesterOpen child in entity.EdSemesterOpenCollection)
					{
						if(child.EdCodeStudyMethodIdSource != null)
						{
							child.EdCodeStudyMethodId = child.EdCodeStudyMethodIdSource.EdCodeStudyMethodId;
						}
						else
						{
							child.EdCodeStudyMethodId = entity.EdCodeStudyMethodId;
						}

					}

					if (entity.EdSemesterOpenCollection.Count > 0 || entity.EdSemesterOpenCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdSemesterOpenProvider.Save(transactionManager, entity.EdSemesterOpenCollection);
						
						deepHandles.Add("EdSemesterOpenCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdSemesterOpen >) DataRepository.EdSemesterOpenProvider.DeepSave,
							new object[] { transactionManager, entity.EdSemesterOpenCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntityMain>
				if (CanDeepSave(entity.EntityMainCollection, "List<EntityMain>|EntityMainCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntityMain child in entity.EntityMainCollection)
					{
						if(child.EdStudyMethodIdSource != null)
						{
							child.EdStudyMethodId = child.EdStudyMethodIdSource.EdCodeStudyMethodId;
						}
						else
						{
							child.EdStudyMethodId = entity.EdCodeStudyMethodId;
						}

					}

					if (entity.EntityMainCollection.Count > 0 || entity.EntityMainCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntityMainProvider.Save(transactionManager, entity.EntityMainCollection);
						
						deepHandles.Add("EntityMainCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntityMain >) DataRepository.EntityMainProvider.DeepSave,
							new object[] { transactionManager, entity.EntityMainCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdCodeRating>
				if (CanDeepSave(entity.EdCodeRatingCollection, "List<EdCodeRating>|EdCodeRatingCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdCodeRating child in entity.EdCodeRatingCollection)
					{
						if(child.EdCodeStudyMethodIdSource != null)
						{
							child.EdCodeStudyMethodId = child.EdCodeStudyMethodIdSource.EdCodeStudyMethodId;
						}
						else
						{
							child.EdCodeStudyMethodId = entity.EdCodeStudyMethodId;
						}

					}

					if (entity.EdCodeRatingCollection.Count > 0 || entity.EdCodeRatingCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdCodeRatingProvider.Save(transactionManager, entity.EdCodeRatingCollection);
						
						deepHandles.Add("EdCodeRatingCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdCodeRating >) DataRepository.EdCodeRatingProvider.DeepSave,
							new object[] { transactionManager, entity.EdCodeRatingCollection, deepSaveType, childTypes, innerList }
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
						if(child.EdCodeStudyMethodIdSource != null)
						{
							child.EdCodeStudyMethodId = child.EdCodeStudyMethodIdSource.EdCodeStudyMethodId;
						}
						else
						{
							child.EdCodeStudyMethodId = entity.EdCodeStudyMethodId;
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
				
	
			#region List<EntCodePrecondMetadata>
				if (CanDeepSave(entity.EntCodePrecondMetadataCollection, "List<EntCodePrecondMetadata>|EntCodePrecondMetadataCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntCodePrecondMetadata child in entity.EntCodePrecondMetadataCollection)
					{
						if(child.EdCodeStudyMethodIdSource != null)
						{
							child.EdCodeStudyMethodId = child.EdCodeStudyMethodIdSource.EdCodeStudyMethodId;
						}
						else
						{
							child.EdCodeStudyMethodId = entity.EdCodeStudyMethodId;
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
				
	
			#region List<EdBylaw>
				if (CanDeepSave(entity.EdBylawCollection, "List<EdBylaw>|EdBylawCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdBylaw child in entity.EdBylawCollection)
					{
						if(child.EdCodeStudyMethodIdSource != null)
						{
							child.EdCodeStudyMethodId = child.EdCodeStudyMethodIdSource.EdCodeStudyMethodId;
						}
						else
						{
							child.EdCodeStudyMethodId = entity.EdCodeStudyMethodId;
						}

					}

					if (entity.EdBylawCollection.Count > 0 || entity.EdBylawCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdBylawProvider.Save(transactionManager, entity.EdBylawCollection);
						
						deepHandles.Add("EdBylawCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdBylaw >) DataRepository.EdBylawProvider.DeepSave,
							new object[] { transactionManager, entity.EdBylawCollection, deepSaveType, childTypes, innerList }
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
	
	#region EdCodeStudyMethodChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdCodeStudyMethod</c>
	///</summary>
	public enum EdCodeStudyMethodChildEntityTypes
	{
		///<summary>
		/// Collection of <c>EdCodeStudyMethod</c> as OneToMany for SeFormCollection
		///</summary>
		[ChildEntityType(typeof(TList<SeForm>))]
		SeFormCollection,
		///<summary>
		/// Collection of <c>EdCodeStudyMethod</c> as OneToMany for EntCodeFullfillMetadataCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntCodeFullfillMetadata>))]
		EntCodeFullfillMetadataCollection,
		///<summary>
		/// Collection of <c>EdCodeStudyMethod</c> as OneToMany for EntCodePolicyMetadataCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntCodePolicyMetadata>))]
		EntCodePolicyMetadataCollection,
		///<summary>
		/// Collection of <c>EdCodeStudyMethod</c> as OneToMany for EntCodeIntroMetadataCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntCodeIntroMetadata>))]
		EntCodeIntroMetadataCollection,
		///<summary>
		/// Collection of <c>EdCodeStudyMethod</c> as OneToMany for EdSemesterOpenCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdSemesterOpen>))]
		EdSemesterOpenCollection,
		///<summary>
		/// Collection of <c>EdCodeStudyMethod</c> as OneToMany for EntityMainCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntityMain>))]
		EntityMainCollection,
		///<summary>
		/// Collection of <c>EdCodeStudyMethod</c> as OneToMany for EdCodeRatingCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdCodeRating>))]
		EdCodeRatingCollection,
		///<summary>
		/// Collection of <c>EdCodeStudyMethod</c> as OneToMany for EntCodeGradingMetadataCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntCodeGradingMetadata>))]
		EntCodeGradingMetadataCollection,
		///<summary>
		/// Collection of <c>EdCodeStudyMethod</c> as OneToMany for EntCodePrecondMetadataCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntCodePrecondMetadata>))]
		EntCodePrecondMetadataCollection,
		///<summary>
		/// Collection of <c>EdCodeStudyMethod</c> as OneToMany for EdBylawCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdBylaw>))]
		EdBylawCollection,
	}
	
	#endregion EdCodeStudyMethodChildEntityTypes
	
	#region EdCodeStudyMethodFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdCodeStudyMethodColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeStudyMethod"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCodeStudyMethodFilterBuilder : SqlFilterBuilder<EdCodeStudyMethodColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeStudyMethodFilterBuilder class.
		/// </summary>
		public EdCodeStudyMethodFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCodeStudyMethodFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCodeStudyMethodFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCodeStudyMethodFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCodeStudyMethodFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCodeStudyMethodFilterBuilder
	
	#region EdCodeStudyMethodParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdCodeStudyMethodColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeStudyMethod"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCodeStudyMethodParameterBuilder : ParameterizedSqlFilterBuilder<EdCodeStudyMethodColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeStudyMethodParameterBuilder class.
		/// </summary>
		public EdCodeStudyMethodParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCodeStudyMethodParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCodeStudyMethodParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCodeStudyMethodParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCodeStudyMethodParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCodeStudyMethodParameterBuilder
	
	#region EdCodeStudyMethodSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdCodeStudyMethodColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeStudyMethod"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdCodeStudyMethodSortBuilder : SqlSortBuilder<EdCodeStudyMethodColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeStudyMethodSqlSortBuilder class.
		/// </summary>
		public EdCodeStudyMethodSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdCodeStudyMethodSortBuilder
	
} // end namespace
