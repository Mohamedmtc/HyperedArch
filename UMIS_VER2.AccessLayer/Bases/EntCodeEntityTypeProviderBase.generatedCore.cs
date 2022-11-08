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
	/// This class is the base class for any <see cref="EntCodeEntityTypeProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EntCodeEntityTypeProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EntCodeEntityType, UMIS_VER2.BusinessLyer.EntCodeEntityTypeKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntCodeEntityTypeKey key)
		{
			return Delete(transactionManager, key.EntCodeEntityTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_entCodeEntityTypeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _entCodeEntityTypeId)
		{
			return Delete(null, _entCodeEntityTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodeEntityTypeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _entCodeEntityTypeId);		
		
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
		public override UMIS_VER2.BusinessLyer.EntCodeEntityType Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntCodeEntityTypeKey key, int start, int pageLength)
		{
			return GetByEntCodeEntityTypeId(transactionManager, key.EntCodeEntityTypeId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ENTITY_TYPE index.
		/// </summary>
		/// <param name="_entCodeEntityTypeId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntCodeEntityType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntCodeEntityType GetByEntCodeEntityTypeId(System.Decimal _entCodeEntityTypeId)
		{
			int count = -1;
			return GetByEntCodeEntityTypeId(null,_entCodeEntityTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENTITY_TYPE index.
		/// </summary>
		/// <param name="_entCodeEntityTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntCodeEntityType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntCodeEntityType GetByEntCodeEntityTypeId(System.Decimal _entCodeEntityTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntCodeEntityTypeId(null, _entCodeEntityTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENTITY_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodeEntityTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntCodeEntityType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntCodeEntityType GetByEntCodeEntityTypeId(TransactionManager transactionManager, System.Decimal _entCodeEntityTypeId)
		{
			int count = -1;
			return GetByEntCodeEntityTypeId(transactionManager, _entCodeEntityTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENTITY_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodeEntityTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntCodeEntityType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntCodeEntityType GetByEntCodeEntityTypeId(TransactionManager transactionManager, System.Decimal _entCodeEntityTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntCodeEntityTypeId(transactionManager, _entCodeEntityTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENTITY_TYPE index.
		/// </summary>
		/// <param name="_entCodeEntityTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntCodeEntityType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntCodeEntityType GetByEntCodeEntityTypeId(System.Decimal _entCodeEntityTypeId, int start, int pageLength, out int count)
		{
			return GetByEntCodeEntityTypeId(null, _entCodeEntityTypeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENTITY_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodeEntityTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntCodeEntityType"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EntCodeEntityType GetByEntCodeEntityTypeId(TransactionManager transactionManager, System.Decimal _entCodeEntityTypeId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EntCodeEntityType&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EntCodeEntityType&gt;"/></returns>
		public static TList<EntCodeEntityType> Fill(IDataReader reader, TList<EntCodeEntityType> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EntCodeEntityType c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EntCodeEntityType")
					.Append("|").Append((System.Decimal)reader["ENT_CODE_ENTITY_TYPE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EntCodeEntityType>(
					key.ToString(), // EntityTrackingKey
					"EntCodeEntityType",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EntCodeEntityType();
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
					c.EntCodeEntityTypeId = (System.Decimal)reader["ENT_CODE_ENTITY_TYPE_ID"];
					c.OriginalEntCodeEntityTypeId = c.EntCodeEntityTypeId;
					c.EntTypeDscrAr = (System.String)reader["ENT_TYPE_DSCR_AR"];
					c.EntTypeDscrEn = Convert.IsDBNull(reader["ENT_TYPE_DSCR_EN"]) ? null : (System.String)reader["ENT_TYPE_DSCR_EN"];
					c.StateAbbrvAr = Convert.IsDBNull(reader["STATE_ABBRV_AR"]) ? null : (System.String)reader["STATE_ABBRV_AR"];
					c.StateAbbrvEn = Convert.IsDBNull(reader["STATE_ABBRV_EN"]) ? null : (System.String)reader["STATE_ABBRV_EN"];
					c.BylawRltdFlg = (System.Decimal)reader["BYLAW_RLTD_FLG"];
					c.SubMnuIntroduction = (System.Decimal)reader["SUB_MNU_INTRODUCTION"];
					c.SubMnuPrecondition = (System.Decimal)reader["SUB_MNU_PRECONDITION"];
					c.SubMnuFullfilment = (System.Decimal)reader["SUB_MNU_FULLFILMENT"];
					c.SubMnuPolicies = (System.Decimal)reader["SUB_MNU_POLICIES"];
					c.SubMnuGrading = (System.Decimal)reader["SUB_MNU_GRADING"];
					c.SubMnuCoursePackage = (System.Decimal)reader["SUB_MNU_COURSE_PACKAGE"];
					c.SubMnuAcadPlan = (System.Decimal)reader["SUB_MNU_ACAD_PLAN"];
					c.SubMnuBylaw = (System.Decimal)reader["SUB_MNU_BYLAW"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntCodeEntityType"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntCodeEntityType"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EntCodeEntityType entity)
		{
			if (!reader.Read()) return;
			
			entity.EntCodeEntityTypeId = (System.Decimal)reader[((int)EntCodeEntityTypeColumn.EntCodeEntityTypeId - 1)];
			entity.OriginalEntCodeEntityTypeId = (System.Decimal)reader["ENT_CODE_ENTITY_TYPE_ID"];
			entity.EntTypeDscrAr = (System.String)reader[((int)EntCodeEntityTypeColumn.EntTypeDscrAr - 1)];
			entity.EntTypeDscrEn = (reader.IsDBNull(((int)EntCodeEntityTypeColumn.EntTypeDscrEn - 1)))?null:(System.String)reader[((int)EntCodeEntityTypeColumn.EntTypeDscrEn - 1)];
			entity.StateAbbrvAr = (reader.IsDBNull(((int)EntCodeEntityTypeColumn.StateAbbrvAr - 1)))?null:(System.String)reader[((int)EntCodeEntityTypeColumn.StateAbbrvAr - 1)];
			entity.StateAbbrvEn = (reader.IsDBNull(((int)EntCodeEntityTypeColumn.StateAbbrvEn - 1)))?null:(System.String)reader[((int)EntCodeEntityTypeColumn.StateAbbrvEn - 1)];
			entity.BylawRltdFlg = (System.Decimal)reader[((int)EntCodeEntityTypeColumn.BylawRltdFlg - 1)];
			entity.SubMnuIntroduction = (System.Decimal)reader[((int)EntCodeEntityTypeColumn.SubMnuIntroduction - 1)];
			entity.SubMnuPrecondition = (System.Decimal)reader[((int)EntCodeEntityTypeColumn.SubMnuPrecondition - 1)];
			entity.SubMnuFullfilment = (System.Decimal)reader[((int)EntCodeEntityTypeColumn.SubMnuFullfilment - 1)];
			entity.SubMnuPolicies = (System.Decimal)reader[((int)EntCodeEntityTypeColumn.SubMnuPolicies - 1)];
			entity.SubMnuGrading = (System.Decimal)reader[((int)EntCodeEntityTypeColumn.SubMnuGrading - 1)];
			entity.SubMnuCoursePackage = (System.Decimal)reader[((int)EntCodeEntityTypeColumn.SubMnuCoursePackage - 1)];
			entity.SubMnuAcadPlan = (System.Decimal)reader[((int)EntCodeEntityTypeColumn.SubMnuAcadPlan - 1)];
			entity.SubMnuBylaw = (System.Decimal)reader[((int)EntCodeEntityTypeColumn.SubMnuBylaw - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntCodeEntityType"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntCodeEntityType"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EntCodeEntityType entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EntCodeEntityTypeId = (System.Decimal)dataRow["ENT_CODE_ENTITY_TYPE_ID"];
			entity.OriginalEntCodeEntityTypeId = (System.Decimal)dataRow["ENT_CODE_ENTITY_TYPE_ID"];
			entity.EntTypeDscrAr = (System.String)dataRow["ENT_TYPE_DSCR_AR"];
			entity.EntTypeDscrEn = Convert.IsDBNull(dataRow["ENT_TYPE_DSCR_EN"]) ? null : (System.String)dataRow["ENT_TYPE_DSCR_EN"];
			entity.StateAbbrvAr = Convert.IsDBNull(dataRow["STATE_ABBRV_AR"]) ? null : (System.String)dataRow["STATE_ABBRV_AR"];
			entity.StateAbbrvEn = Convert.IsDBNull(dataRow["STATE_ABBRV_EN"]) ? null : (System.String)dataRow["STATE_ABBRV_EN"];
			entity.BylawRltdFlg = (System.Decimal)dataRow["BYLAW_RLTD_FLG"];
			entity.SubMnuIntroduction = (System.Decimal)dataRow["SUB_MNU_INTRODUCTION"];
			entity.SubMnuPrecondition = (System.Decimal)dataRow["SUB_MNU_PRECONDITION"];
			entity.SubMnuFullfilment = (System.Decimal)dataRow["SUB_MNU_FULLFILMENT"];
			entity.SubMnuPolicies = (System.Decimal)dataRow["SUB_MNU_POLICIES"];
			entity.SubMnuGrading = (System.Decimal)dataRow["SUB_MNU_GRADING"];
			entity.SubMnuCoursePackage = (System.Decimal)dataRow["SUB_MNU_COURSE_PACKAGE"];
			entity.SubMnuAcadPlan = (System.Decimal)dataRow["SUB_MNU_ACAD_PLAN"];
			entity.SubMnuBylaw = (System.Decimal)dataRow["SUB_MNU_BYLAW"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntCodeEntityType"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntCodeEntityType Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntCodeEntityType entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEntCodeEntityTypeId methods when available
			
			#region EdStudStateCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudState>|EdStudStateCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudStateCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudStateCollection = DataRepository.EdStudStateProvider.GetByEntCodeEntityTypeId(transactionManager, entity.EntCodeEntityTypeId);

				if (deep && entity.EdStudStateCollection.Count > 0)
				{
					deepHandles.Add("EdStudStateCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudState>) DataRepository.EdStudStateProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudStateCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntAvailPrntTypeCollectionGetByEntCodeEntityTypePrntId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntAvailPrntType>|EntAvailPrntTypeCollectionGetByEntCodeEntityTypePrntId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntAvailPrntTypeCollectionGetByEntCodeEntityTypePrntId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntAvailPrntTypeCollectionGetByEntCodeEntityTypePrntId = DataRepository.EntAvailPrntTypeProvider.GetByEntCodeEntityTypePrntId(transactionManager, entity.EntCodeEntityTypeId);

				if (deep && entity.EntAvailPrntTypeCollectionGetByEntCodeEntityTypePrntId.Count > 0)
				{
					deepHandles.Add("EntAvailPrntTypeCollectionGetByEntCodeEntityTypePrntId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntAvailPrntType>) DataRepository.EntAvailPrntTypeProvider.DeepLoad,
						new object[] { transactionManager, entity.EntAvailPrntTypeCollectionGetByEntCodeEntityTypePrntId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntIntroducMetadataCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntIntroducMetadata>|EntIntroducMetadataCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntIntroducMetadataCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntIntroducMetadataCollection = DataRepository.EntIntroducMetadataProvider.GetByEntCodeEntityTypeId(transactionManager, entity.EntCodeEntityTypeId);

				if (deep && entity.EntIntroducMetadataCollection.Count > 0)
				{
					deepHandles.Add("EntIntroducMetadataCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntIntroducMetadata>) DataRepository.EntIntroducMetadataProvider.DeepLoad,
						new object[] { transactionManager, entity.EntIntroducMetadataCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntAvailPrntTypeCollectionGetByEntCodeEntityTypeId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntAvailPrntType>|EntAvailPrntTypeCollectionGetByEntCodeEntityTypeId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntAvailPrntTypeCollectionGetByEntCodeEntityTypeId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntAvailPrntTypeCollectionGetByEntCodeEntityTypeId = DataRepository.EntAvailPrntTypeProvider.GetByEntCodeEntityTypeId(transactionManager, entity.EntCodeEntityTypeId);

				if (deep && entity.EntAvailPrntTypeCollectionGetByEntCodeEntityTypeId.Count > 0)
				{
					deepHandles.Add("EntAvailPrntTypeCollectionGetByEntCodeEntityTypeId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntAvailPrntType>) DataRepository.EntAvailPrntTypeProvider.DeepLoad,
						new object[] { transactionManager, entity.EntAvailPrntTypeCollectionGetByEntCodeEntityTypeId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntPolicyMetadataCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntPolicyMetadata>|EntPolicyMetadataCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPolicyMetadataCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntPolicyMetadataCollection = DataRepository.EntPolicyMetadataProvider.GetByEntCodeEntityTypeId(transactionManager, entity.EntCodeEntityTypeId);

				if (deep && entity.EntPolicyMetadataCollection.Count > 0)
				{
					deepHandles.Add("EntPolicyMetadataCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntPolicyMetadata>) DataRepository.EntPolicyMetadataProvider.DeepLoad,
						new object[] { transactionManager, entity.EntPolicyMetadataCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.EntityMainCollection = DataRepository.EntityMainProvider.GetByEntCodeEntityTypeId(transactionManager, entity.EntCodeEntityTypeId);

				if (deep && entity.EntityMainCollection.Count > 0)
				{
					deepHandles.Add("EntityMainCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntityMain>) DataRepository.EntityMainProvider.DeepLoad,
						new object[] { transactionManager, entity.EntityMainCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntPrecondMetadataCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntPrecondMetadata>|EntPrecondMetadataCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPrecondMetadataCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntPrecondMetadataCollection = DataRepository.EntPrecondMetadataProvider.GetByEntCodeEntityTypeId(transactionManager, entity.EntCodeEntityTypeId);

				if (deep && entity.EntPrecondMetadataCollection.Count > 0)
				{
					deepHandles.Add("EntPrecondMetadataCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntPrecondMetadata>) DataRepository.EntPrecondMetadataProvider.DeepLoad,
						new object[] { transactionManager, entity.EntPrecondMetadataCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntFullfillMetadataCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntFullfillMetadata>|EntFullfillMetadataCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntFullfillMetadataCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntFullfillMetadataCollection = DataRepository.EntFullfillMetadataProvider.GetByEntCodeEntityTypeId(transactionManager, entity.EntCodeEntityTypeId);

				if (deep && entity.EntFullfillMetadataCollection.Count > 0)
				{
					deepHandles.Add("EntFullfillMetadataCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntFullfillMetadata>) DataRepository.EntFullfillMetadataProvider.DeepLoad,
						new object[] { transactionManager, entity.EntFullfillMetadataCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudStateTempCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudStateTemp>|EdStudStateTempCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudStateTempCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudStateTempCollection = DataRepository.EdStudStateTempProvider.GetByEntCodeEntityTypeId(transactionManager, entity.EntCodeEntityTypeId);

				if (deep && entity.EdStudStateTempCollection.Count > 0)
				{
					deepHandles.Add("EdStudStateTempCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudStateTemp>) DataRepository.EdStudStateTempProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudStateTempCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntGradingMetadataCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntGradingMetadata>|EntGradingMetadataCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntGradingMetadataCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntGradingMetadataCollection = DataRepository.EntGradingMetadataProvider.GetByEntCodeEntityTypeId(transactionManager, entity.EntCodeEntityTypeId);

				if (deep && entity.EntGradingMetadataCollection.Count > 0)
				{
					deepHandles.Add("EntGradingMetadataCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntGradingMetadata>) DataRepository.EntGradingMetadataProvider.DeepLoad,
						new object[] { transactionManager, entity.EntGradingMetadataCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EntCodeEntityType object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EntCodeEntityType instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntCodeEntityType Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntCodeEntityType entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<EdStudState>
				if (CanDeepSave(entity.EdStudStateCollection, "List<EdStudState>|EdStudStateCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudState child in entity.EdStudStateCollection)
					{
						if(child.EntCodeEntityTypeIdSource != null)
						{
							child.EntCodeEntityTypeId = child.EntCodeEntityTypeIdSource.EntCodeEntityTypeId;
						}
						else
						{
							child.EntCodeEntityTypeId = entity.EntCodeEntityTypeId;
						}

					}

					if (entity.EdStudStateCollection.Count > 0 || entity.EdStudStateCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudStateProvider.Save(transactionManager, entity.EdStudStateCollection);
						
						deepHandles.Add("EdStudStateCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudState >) DataRepository.EdStudStateProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudStateCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntAvailPrntType>
				if (CanDeepSave(entity.EntAvailPrntTypeCollectionGetByEntCodeEntityTypePrntId, "List<EntAvailPrntType>|EntAvailPrntTypeCollectionGetByEntCodeEntityTypePrntId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntAvailPrntType child in entity.EntAvailPrntTypeCollectionGetByEntCodeEntityTypePrntId)
					{
						if(child.EntCodeEntityTypePrntIdSource != null)
						{
							child.EntCodeEntityTypePrntId = child.EntCodeEntityTypePrntIdSource.EntCodeEntityTypeId;
						}
						else
						{
							child.EntCodeEntityTypePrntId = entity.EntCodeEntityTypeId;
						}

					}

					if (entity.EntAvailPrntTypeCollectionGetByEntCodeEntityTypePrntId.Count > 0 || entity.EntAvailPrntTypeCollectionGetByEntCodeEntityTypePrntId.DeletedItems.Count > 0)
					{
						//DataRepository.EntAvailPrntTypeProvider.Save(transactionManager, entity.EntAvailPrntTypeCollectionGetByEntCodeEntityTypePrntId);
						
						deepHandles.Add("EntAvailPrntTypeCollectionGetByEntCodeEntityTypePrntId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntAvailPrntType >) DataRepository.EntAvailPrntTypeProvider.DeepSave,
							new object[] { transactionManager, entity.EntAvailPrntTypeCollectionGetByEntCodeEntityTypePrntId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntIntroducMetadata>
				if (CanDeepSave(entity.EntIntroducMetadataCollection, "List<EntIntroducMetadata>|EntIntroducMetadataCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntIntroducMetadata child in entity.EntIntroducMetadataCollection)
					{
						if(child.EntCodeEntityTypeIdSource != null)
						{
							child.EntCodeEntityTypeId = child.EntCodeEntityTypeIdSource.EntCodeEntityTypeId;
						}
						else
						{
							child.EntCodeEntityTypeId = entity.EntCodeEntityTypeId;
						}

					}

					if (entity.EntIntroducMetadataCollection.Count > 0 || entity.EntIntroducMetadataCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntIntroducMetadataProvider.Save(transactionManager, entity.EntIntroducMetadataCollection);
						
						deepHandles.Add("EntIntroducMetadataCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntIntroducMetadata >) DataRepository.EntIntroducMetadataProvider.DeepSave,
							new object[] { transactionManager, entity.EntIntroducMetadataCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntAvailPrntType>
				if (CanDeepSave(entity.EntAvailPrntTypeCollectionGetByEntCodeEntityTypeId, "List<EntAvailPrntType>|EntAvailPrntTypeCollectionGetByEntCodeEntityTypeId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntAvailPrntType child in entity.EntAvailPrntTypeCollectionGetByEntCodeEntityTypeId)
					{
						if(child.EntCodeEntityTypeIdSource != null)
						{
							child.EntCodeEntityTypeId = child.EntCodeEntityTypeIdSource.EntCodeEntityTypeId;
						}
						else
						{
							child.EntCodeEntityTypeId = entity.EntCodeEntityTypeId;
						}

					}

					if (entity.EntAvailPrntTypeCollectionGetByEntCodeEntityTypeId.Count > 0 || entity.EntAvailPrntTypeCollectionGetByEntCodeEntityTypeId.DeletedItems.Count > 0)
					{
						//DataRepository.EntAvailPrntTypeProvider.Save(transactionManager, entity.EntAvailPrntTypeCollectionGetByEntCodeEntityTypeId);
						
						deepHandles.Add("EntAvailPrntTypeCollectionGetByEntCodeEntityTypeId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntAvailPrntType >) DataRepository.EntAvailPrntTypeProvider.DeepSave,
							new object[] { transactionManager, entity.EntAvailPrntTypeCollectionGetByEntCodeEntityTypeId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntPolicyMetadata>
				if (CanDeepSave(entity.EntPolicyMetadataCollection, "List<EntPolicyMetadata>|EntPolicyMetadataCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntPolicyMetadata child in entity.EntPolicyMetadataCollection)
					{
						if(child.EntCodeEntityTypeIdSource != null)
						{
							child.EntCodeEntityTypeId = child.EntCodeEntityTypeIdSource.EntCodeEntityTypeId;
						}
						else
						{
							child.EntCodeEntityTypeId = entity.EntCodeEntityTypeId;
						}

					}

					if (entity.EntPolicyMetadataCollection.Count > 0 || entity.EntPolicyMetadataCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntPolicyMetadataProvider.Save(transactionManager, entity.EntPolicyMetadataCollection);
						
						deepHandles.Add("EntPolicyMetadataCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntPolicyMetadata >) DataRepository.EntPolicyMetadataProvider.DeepSave,
							new object[] { transactionManager, entity.EntPolicyMetadataCollection, deepSaveType, childTypes, innerList }
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
						if(child.EntCodeEntityTypeIdSource != null)
						{
							child.EntCodeEntityTypeId = child.EntCodeEntityTypeIdSource.EntCodeEntityTypeId;
						}
						else
						{
							child.EntCodeEntityTypeId = entity.EntCodeEntityTypeId;
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
				
	
			#region List<EntPrecondMetadata>
				if (CanDeepSave(entity.EntPrecondMetadataCollection, "List<EntPrecondMetadata>|EntPrecondMetadataCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntPrecondMetadata child in entity.EntPrecondMetadataCollection)
					{
						if(child.EntCodeEntityTypeIdSource != null)
						{
							child.EntCodeEntityTypeId = child.EntCodeEntityTypeIdSource.EntCodeEntityTypeId;
						}
						else
						{
							child.EntCodeEntityTypeId = entity.EntCodeEntityTypeId;
						}

					}

					if (entity.EntPrecondMetadataCollection.Count > 0 || entity.EntPrecondMetadataCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntPrecondMetadataProvider.Save(transactionManager, entity.EntPrecondMetadataCollection);
						
						deepHandles.Add("EntPrecondMetadataCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntPrecondMetadata >) DataRepository.EntPrecondMetadataProvider.DeepSave,
							new object[] { transactionManager, entity.EntPrecondMetadataCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntFullfillMetadata>
				if (CanDeepSave(entity.EntFullfillMetadataCollection, "List<EntFullfillMetadata>|EntFullfillMetadataCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntFullfillMetadata child in entity.EntFullfillMetadataCollection)
					{
						if(child.EntCodeEntityTypeIdSource != null)
						{
							child.EntCodeEntityTypeId = child.EntCodeEntityTypeIdSource.EntCodeEntityTypeId;
						}
						else
						{
							child.EntCodeEntityTypeId = entity.EntCodeEntityTypeId;
						}

					}

					if (entity.EntFullfillMetadataCollection.Count > 0 || entity.EntFullfillMetadataCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntFullfillMetadataProvider.Save(transactionManager, entity.EntFullfillMetadataCollection);
						
						deepHandles.Add("EntFullfillMetadataCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntFullfillMetadata >) DataRepository.EntFullfillMetadataProvider.DeepSave,
							new object[] { transactionManager, entity.EntFullfillMetadataCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudStateTemp>
				if (CanDeepSave(entity.EdStudStateTempCollection, "List<EdStudStateTemp>|EdStudStateTempCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudStateTemp child in entity.EdStudStateTempCollection)
					{
						if(child.EntCodeEntityTypeIdSource != null)
						{
							child.EntCodeEntityTypeId = child.EntCodeEntityTypeIdSource.EntCodeEntityTypeId;
						}
						else
						{
							child.EntCodeEntityTypeId = entity.EntCodeEntityTypeId;
						}

					}

					if (entity.EdStudStateTempCollection.Count > 0 || entity.EdStudStateTempCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudStateTempProvider.Save(transactionManager, entity.EdStudStateTempCollection);
						
						deepHandles.Add("EdStudStateTempCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudStateTemp >) DataRepository.EdStudStateTempProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudStateTempCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntGradingMetadata>
				if (CanDeepSave(entity.EntGradingMetadataCollection, "List<EntGradingMetadata>|EntGradingMetadataCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntGradingMetadata child in entity.EntGradingMetadataCollection)
					{
						if(child.EntCodeEntityTypeIdSource != null)
						{
							child.EntCodeEntityTypeId = child.EntCodeEntityTypeIdSource.EntCodeEntityTypeId;
						}
						else
						{
							child.EntCodeEntityTypeId = entity.EntCodeEntityTypeId;
						}

					}

					if (entity.EntGradingMetadataCollection.Count > 0 || entity.EntGradingMetadataCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntGradingMetadataProvider.Save(transactionManager, entity.EntGradingMetadataCollection);
						
						deepHandles.Add("EntGradingMetadataCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntGradingMetadata >) DataRepository.EntGradingMetadataProvider.DeepSave,
							new object[] { transactionManager, entity.EntGradingMetadataCollection, deepSaveType, childTypes, innerList }
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
	
	#region EntCodeEntityTypeChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EntCodeEntityType</c>
	///</summary>
	public enum EntCodeEntityTypeChildEntityTypes
	{
		///<summary>
		/// Collection of <c>EntCodeEntityType</c> as OneToMany for EdStudStateCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudState>))]
		EdStudStateCollection,
		///<summary>
		/// Collection of <c>EntCodeEntityType</c> as OneToMany for EntAvailPrntTypeCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntAvailPrntType>))]
		EntAvailPrntTypeCollectionGetByEntCodeEntityTypePrntId,
		///<summary>
		/// Collection of <c>EntCodeEntityType</c> as OneToMany for EntIntroducMetadataCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntIntroducMetadata>))]
		EntIntroducMetadataCollection,
		///<summary>
		/// Collection of <c>EntCodeEntityType</c> as OneToMany for EntAvailPrntTypeCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntAvailPrntType>))]
		EntAvailPrntTypeCollectionGetByEntCodeEntityTypeId,
		///<summary>
		/// Collection of <c>EntCodeEntityType</c> as OneToMany for EntPolicyMetadataCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntPolicyMetadata>))]
		EntPolicyMetadataCollection,
		///<summary>
		/// Collection of <c>EntCodeEntityType</c> as OneToMany for EntityMainCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntityMain>))]
		EntityMainCollection,
		///<summary>
		/// Collection of <c>EntCodeEntityType</c> as OneToMany for EntPrecondMetadataCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntPrecondMetadata>))]
		EntPrecondMetadataCollection,
		///<summary>
		/// Collection of <c>EntCodeEntityType</c> as OneToMany for EntFullfillMetadataCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntFullfillMetadata>))]
		EntFullfillMetadataCollection,
		///<summary>
		/// Collection of <c>EntCodeEntityType</c> as OneToMany for EdStudStateTempCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudStateTemp>))]
		EdStudStateTempCollection,
		///<summary>
		/// Collection of <c>EntCodeEntityType</c> as OneToMany for EntGradingMetadataCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntGradingMetadata>))]
		EntGradingMetadataCollection,
	}
	
	#endregion EntCodeEntityTypeChildEntityTypes
	
	#region EntCodeEntityTypeFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntCodeEntityTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntCodeEntityType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntCodeEntityTypeFilterBuilder : SqlFilterBuilder<EntCodeEntityTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntCodeEntityTypeFilterBuilder class.
		/// </summary>
		public EntCodeEntityTypeFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntCodeEntityTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntCodeEntityTypeFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntCodeEntityTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntCodeEntityTypeFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntCodeEntityTypeFilterBuilder
	
	#region EntCodeEntityTypeParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntCodeEntityTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntCodeEntityType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntCodeEntityTypeParameterBuilder : ParameterizedSqlFilterBuilder<EntCodeEntityTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntCodeEntityTypeParameterBuilder class.
		/// </summary>
		public EntCodeEntityTypeParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntCodeEntityTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntCodeEntityTypeParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntCodeEntityTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntCodeEntityTypeParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntCodeEntityTypeParameterBuilder
	
	#region EntCodeEntityTypeSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntCodeEntityTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntCodeEntityType"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EntCodeEntityTypeSortBuilder : SqlSortBuilder<EntCodeEntityTypeColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntCodeEntityTypeSqlSortBuilder class.
		/// </summary>
		public EntCodeEntityTypeSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EntCodeEntityTypeSortBuilder
	
} // end namespace
