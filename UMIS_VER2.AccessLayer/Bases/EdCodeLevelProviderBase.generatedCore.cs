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
	/// This class is the base class for any <see cref="EdCodeLevelProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdCodeLevelProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdCodeLevel, UMIS_VER2.BusinessLyer.EdCodeLevelKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeLevelKey key)
		{
			return Delete(transactionManager, key.EdCodeLevelId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edCodeLevelId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edCodeLevelId)
		{
			return Delete(null, _edCodeLevelId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLevelId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edCodeLevelId);		
		
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
		public override UMIS_VER2.BusinessLyer.EdCodeLevel Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeLevelKey key, int start, int pageLength)
		{
			return GetByEdCodeLevelId(transactionManager, key.EdCodeLevelId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdCodeLevel&gt;"/> class.</returns>
		public TList<EdCodeLevel> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(null,_asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdCodeLevel&gt;"/> class.</returns>
		public TList<EdCodeLevel> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdCodeLevel&gt;"/> class.</returns>
		public TList<EdCodeLevel> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdCodeLevel&gt;"/> class.</returns>
		public TList<EdCodeLevel> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdCodeLevel&gt;"/> class.</returns>
		public TList<EdCodeLevel> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdCodeLevel&gt;"/> class.</returns>
		public abstract TList<EdCodeLevel> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_CODE_LEVEL index.
		/// </summary>
		/// <param name="_edCodeLevelId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeLevel"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeLevel GetByEdCodeLevelId(System.Decimal _edCodeLevelId)
		{
			int count = -1;
			return GetByEdCodeLevelId(null,_edCodeLevelId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_LEVEL index.
		/// </summary>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeLevel"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeLevel GetByEdCodeLevelId(System.Decimal _edCodeLevelId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeLevelId(null, _edCodeLevelId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_LEVEL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLevelId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeLevel"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeLevel GetByEdCodeLevelId(TransactionManager transactionManager, System.Decimal _edCodeLevelId)
		{
			int count = -1;
			return GetByEdCodeLevelId(transactionManager, _edCodeLevelId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_LEVEL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeLevel"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeLevel GetByEdCodeLevelId(TransactionManager transactionManager, System.Decimal _edCodeLevelId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeLevelId(transactionManager, _edCodeLevelId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_LEVEL index.
		/// </summary>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeLevel"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeLevel GetByEdCodeLevelId(System.Decimal _edCodeLevelId, int start, int pageLength, out int count)
		{
			return GetByEdCodeLevelId(null, _edCodeLevelId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_LEVEL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeLevelId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeLevel"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdCodeLevel GetByEdCodeLevelId(TransactionManager transactionManager, System.Decimal _edCodeLevelId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdCodeLevel&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdCodeLevel&gt;"/></returns>
		public static TList<EdCodeLevel> Fill(IDataReader reader, TList<EdCodeLevel> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdCodeLevel c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdCodeLevel")
					.Append("|").Append((System.Decimal)reader["ED_CODE_LEVEL_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdCodeLevel>(
					key.ToString(), // EntityTrackingKey
					"EdCodeLevel",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdCodeLevel();
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
					c.EdCodeLevelId = (System.Decimal)reader["ED_CODE_LEVEL_ID"];
					c.OriginalEdCodeLevelId = c.EdCodeLevelId;
					c.DescrEn = (System.String)reader["DESCR_EN"];
					c.DescrAr = Convert.IsDBNull(reader["DESCR_AR"]) ? null : (System.String)reader["DESCR_AR"];
					c.LevelOrder = Convert.IsDBNull(reader["LEVEL_ORDER"]) ? null : (System.Decimal?)reader["LEVEL_ORDER"];
					c.AsFacultyInfoId = Convert.IsDBNull(reader["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)reader["AS_FACULTY_INFO_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCodeLevel"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeLevel"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdCodeLevel entity)
		{
			if (!reader.Read()) return;
			
			entity.EdCodeLevelId = (System.Decimal)reader[((int)EdCodeLevelColumn.EdCodeLevelId - 1)];
			entity.OriginalEdCodeLevelId = (System.Decimal)reader["ED_CODE_LEVEL_ID"];
			entity.DescrEn = (System.String)reader[((int)EdCodeLevelColumn.DescrEn - 1)];
			entity.DescrAr = (reader.IsDBNull(((int)EdCodeLevelColumn.DescrAr - 1)))?null:(System.String)reader[((int)EdCodeLevelColumn.DescrAr - 1)];
			entity.LevelOrder = (reader.IsDBNull(((int)EdCodeLevelColumn.LevelOrder - 1)))?null:(System.Decimal?)reader[((int)EdCodeLevelColumn.LevelOrder - 1)];
			entity.AsFacultyInfoId = (reader.IsDBNull(((int)EdCodeLevelColumn.AsFacultyInfoId - 1)))?null:(System.Decimal?)reader[((int)EdCodeLevelColumn.AsFacultyInfoId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCodeLevel"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeLevel"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdCodeLevel entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdCodeLevelId = (System.Decimal)dataRow["ED_CODE_LEVEL_ID"];
			entity.OriginalEdCodeLevelId = (System.Decimal)dataRow["ED_CODE_LEVEL_ID"];
			entity.DescrEn = (System.String)dataRow["DESCR_EN"];
			entity.DescrAr = Convert.IsDBNull(dataRow["DESCR_AR"]) ? null : (System.String)dataRow["DESCR_AR"];
			entity.LevelOrder = Convert.IsDBNull(dataRow["LEVEL_ORDER"]) ? null : (System.Decimal?)dataRow["LEVEL_ORDER"];
			entity.AsFacultyInfoId = Convert.IsDBNull(dataRow["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)dataRow["AS_FACULTY_INFO_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeLevel"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCodeLevel Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeLevel entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AsFacultyInfoIdSource	
			if (CanDeepLoad(entity, "AsFacultyInfo|AsFacultyInfoIdSource", deepLoadType, innerList) 
				&& entity.AsFacultyInfoIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AsFacultyInfoId ?? 0.0m);
				AsFacultyInfo tmpEntity = EntityManager.LocateEntity<AsFacultyInfo>(EntityLocator.ConstructKeyFromPkItems(typeof(AsFacultyInfo), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AsFacultyInfoIdSource = tmpEntity;
				else
					entity.AsFacultyInfoIdSource = DataRepository.AsFacultyInfoProvider.GetByAsFacultyInfoId(transactionManager, (entity.AsFacultyInfoId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AsFacultyInfoIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AsFacultyInfoIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AsFacultyInfoProvider.DeepLoad(transactionManager, entity.AsFacultyInfoIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AsFacultyInfoIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEdCodeLevelId methods when available
			
			#region AdmAppTransReqCollectionGetByEdCodeLevelReqId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppTransReq>|AdmAppTransReqCollectionGetByEdCodeLevelReqId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppTransReqCollectionGetByEdCodeLevelReqId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppTransReqCollectionGetByEdCodeLevelReqId = DataRepository.AdmAppTransReqProvider.GetByEdCodeLevelReqId(transactionManager, entity.EdCodeLevelId);

				if (deep && entity.AdmAppTransReqCollectionGetByEdCodeLevelReqId.Count > 0)
				{
					deepHandles.Add("AdmAppTransReqCollectionGetByEdCodeLevelReqId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppTransReq>) DataRepository.AdmAppTransReqProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppTransReqCollectionGetByEdCodeLevelReqId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntMajorPhaseCollectionGetByEdCodeLevelFromId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntMajorPhase>|EntMajorPhaseCollectionGetByEdCodeLevelFromId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntMajorPhaseCollectionGetByEdCodeLevelFromId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntMajorPhaseCollectionGetByEdCodeLevelFromId = DataRepository.EntMajorPhaseProvider.GetByEdCodeLevelFromId(transactionManager, entity.EdCodeLevelId);

				if (deep && entity.EntMajorPhaseCollectionGetByEdCodeLevelFromId.Count > 0)
				{
					deepHandles.Add("EntMajorPhaseCollectionGetByEdCodeLevelFromId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntMajorPhase>) DataRepository.EntMajorPhaseProvider.DeepLoad,
						new object[] { transactionManager, entity.EntMajorPhaseCollectionGetByEdCodeLevelFromId, deep, deepLoadType, childTypes, innerList }
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

				entity.EdSemesterOpenCollection = DataRepository.EdSemesterOpenProvider.GetByEdCodeLevelId(transactionManager, entity.EdCodeLevelId);

				if (deep && entity.EdSemesterOpenCollection.Count > 0)
				{
					deepHandles.Add("EdSemesterOpenCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdSemesterOpen>) DataRepository.EdSemesterOpenProvider.DeepLoad,
						new object[] { transactionManager, entity.EdSemesterOpenCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region CoControlRoomCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<CoControlRoom>|CoControlRoomCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CoControlRoomCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.CoControlRoomCollection = DataRepository.CoControlRoomProvider.GetByEdCodeLevelId(transactionManager, entity.EdCodeLevelId);

				if (deep && entity.CoControlRoomCollection.Count > 0)
				{
					deepHandles.Add("CoControlRoomCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CoControlRoom>) DataRepository.CoControlRoomProvider.DeepLoad,
						new object[] { transactionManager, entity.CoControlRoomCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region MltLvlBhvrAttndcCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<MltLvlBhvrAttndc>|MltLvlBhvrAttndcCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MltLvlBhvrAttndcCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.MltLvlBhvrAttndcCollection = DataRepository.MltLvlBhvrAttndcProvider.GetByEdCodeLevelId(transactionManager, entity.EdCodeLevelId);

				if (deep && entity.MltLvlBhvrAttndcCollection.Count > 0)
				{
					deepHandles.Add("MltLvlBhvrAttndcCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<MltLvlBhvrAttndc>) DataRepository.MltLvlBhvrAttndcProvider.DeepLoad,
						new object[] { transactionManager, entity.MltLvlBhvrAttndcCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SvStaffEvlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvStaffEvl>|SvStaffEvlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvStaffEvlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvStaffEvlCollection = DataRepository.SvStaffEvlProvider.GetByEdCodeLevelId(transactionManager, entity.EdCodeLevelId);

				if (deep && entity.SvStaffEvlCollection.Count > 0)
				{
					deepHandles.Add("SvStaffEvlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvStaffEvl>) DataRepository.SvStaffEvlProvider.DeepLoad,
						new object[] { transactionManager, entity.SvStaffEvlCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntPolcyGrdngHdrCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntPolcyGrdngHdr>|EntPolcyGrdngHdrCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPolcyGrdngHdrCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntPolcyGrdngHdrCollection = DataRepository.EntPolcyGrdngHdrProvider.GetByEdCodeLevelId(transactionManager, entity.EdCodeLevelId);

				if (deep && entity.EntPolcyGrdngHdrCollection.Count > 0)
				{
					deepHandles.Add("EntPolcyGrdngHdrCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntPolcyGrdngHdr>) DataRepository.EntPolcyGrdngHdrProvider.DeepLoad,
						new object[] { transactionManager, entity.EntPolcyGrdngHdrCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntPolicyGradingLevelCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntPolicyGradingLevel>|EntPolicyGradingLevelCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPolicyGradingLevelCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntPolicyGradingLevelCollection = DataRepository.EntPolicyGradingLevelProvider.GetByEdCodeLevelId(transactionManager, entity.EdCodeLevelId);

				if (deep && entity.EntPolicyGradingLevelCollection.Count > 0)
				{
					deepHandles.Add("EntPolicyGradingLevelCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntPolicyGradingLevel>) DataRepository.EntPolicyGradingLevelProvider.DeepLoad,
						new object[] { transactionManager, entity.EntPolicyGradingLevelCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmAppRegHistoryCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppRegHistory>|AdmAppRegHistoryCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppRegHistoryCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppRegHistoryCollection = DataRepository.AdmAppRegHistoryProvider.GetByEdCodeLevelId(transactionManager, entity.EdCodeLevelId);

				if (deep && entity.AdmAppRegHistoryCollection.Count > 0)
				{
					deepHandles.Add("AdmAppRegHistoryCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppRegHistory>) DataRepository.AdmAppRegHistoryProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppRegHistoryCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeFacultyRuleCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeFacultyRule>|FeeFacultyRuleCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeFacultyRuleCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeFacultyRuleCollection = DataRepository.FeeFacultyRuleProvider.GetByEdCodeLevelId(transactionManager, entity.EdCodeLevelId);

				if (deep && entity.FeeFacultyRuleCollection.Count > 0)
				{
					deepHandles.Add("FeeFacultyRuleCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeFacultyRule>) DataRepository.FeeFacultyRuleProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeFacultyRuleCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudSemesterCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudSemester>|EdStudSemesterCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudSemesterCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudSemesterCollection = DataRepository.EdStudSemesterProvider.GetByEdCodeLevelId(transactionManager, entity.EdCodeLevelId);

				if (deep && entity.EdStudSemesterCollection.Count > 0)
				{
					deepHandles.Add("EdStudSemesterCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudSemester>) DataRepository.EdStudSemesterProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudSemesterCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntPolicyAbsenceCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntPolicyAbsence>|EntPolicyAbsenceCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPolicyAbsenceCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntPolicyAbsenceCollection = DataRepository.EntPolicyAbsenceProvider.GetByEdCodeLevelId(transactionManager, entity.EdCodeLevelId);

				if (deep && entity.EntPolicyAbsenceCollection.Count > 0)
				{
					deepHandles.Add("EntPolicyAbsenceCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntPolicyAbsence>) DataRepository.EntPolicyAbsenceProvider.DeepLoad,
						new object[] { transactionManager, entity.EntPolicyAbsenceCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudSemesterTempCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudSemesterTemp>|EdStudSemesterTempCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudSemesterTempCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudSemesterTempCollection = DataRepository.EdStudSemesterTempProvider.GetByEdCodeLevelId(transactionManager, entity.EdCodeLevelId);

				if (deep && entity.EdStudSemesterTempCollection.Count > 0)
				{
					deepHandles.Add("EdStudSemesterTempCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudSemesterTemp>) DataRepository.EdStudSemesterTempProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudSemesterTempCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdCourseInfoCollectionGetByEdCodeLevelToId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdCourseInfo>|EdCourseInfoCollectionGetByEdCodeLevelToId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCourseInfoCollectionGetByEdCodeLevelToId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdCourseInfoCollectionGetByEdCodeLevelToId = DataRepository.EdCourseInfoProvider.GetByEdCodeLevelToId(transactionManager, entity.EdCodeLevelId);

				if (deep && entity.EdCourseInfoCollectionGetByEdCodeLevelToId.Count > 0)
				{
					deepHandles.Add("EdCourseInfoCollectionGetByEdCodeLevelToId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdCourseInfo>) DataRepository.EdCourseInfoProvider.DeepLoad,
						new object[] { transactionManager, entity.EdCourseInfoCollectionGetByEdCodeLevelToId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SeUserCrsAssessCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SeUserCrsAssess>|SeUserCrsAssessCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeUserCrsAssessCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SeUserCrsAssessCollection = DataRepository.SeUserCrsAssessProvider.GetByEdCodeLevelId(transactionManager, entity.EdCodeLevelId);

				if (deep && entity.SeUserCrsAssessCollection.Count > 0)
				{
					deepHandles.Add("SeUserCrsAssessCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SeUserCrsAssess>) DataRepository.SeUserCrsAssessProvider.DeepLoad,
						new object[] { transactionManager, entity.SeUserCrsAssessCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmAppTransReqCollectionGetByEdCodeLevelAppId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppTransReq>|AdmAppTransReqCollectionGetByEdCodeLevelAppId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppTransReqCollectionGetByEdCodeLevelAppId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppTransReqCollectionGetByEdCodeLevelAppId = DataRepository.AdmAppTransReqProvider.GetByEdCodeLevelAppId(transactionManager, entity.EdCodeLevelId);

				if (deep && entity.AdmAppTransReqCollectionGetByEdCodeLevelAppId.Count > 0)
				{
					deepHandles.Add("AdmAppTransReqCollectionGetByEdCodeLevelAppId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppTransReq>) DataRepository.AdmAppTransReqProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppTransReqCollectionGetByEdCodeLevelAppId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region ScGroupInfoCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ScGroupInfo>|ScGroupInfoCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScGroupInfoCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ScGroupInfoCollection = DataRepository.ScGroupInfoProvider.GetByEdCodeLevelId(transactionManager, entity.EdCodeLevelId);

				if (deep && entity.ScGroupInfoCollection.Count > 0)
				{
					deepHandles.Add("ScGroupInfoCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScGroupInfo>) DataRepository.ScGroupInfoProvider.DeepLoad,
						new object[] { transactionManager, entity.ScGroupInfoCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdAcadPlanHdrCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdAcadPlanHdr>|EdAcadPlanHdrCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdAcadPlanHdrCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdAcadPlanHdrCollection = DataRepository.EdAcadPlanHdrProvider.GetByEdCodeLevelId(transactionManager, entity.EdCodeLevelId);

				if (deep && entity.EdAcadPlanHdrCollection.Count > 0)
				{
					deepHandles.Add("EdAcadPlanHdrCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdAcadPlanHdr>) DataRepository.EdAcadPlanHdrProvider.DeepLoad,
						new object[] { transactionManager, entity.EdAcadPlanHdrCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntMajorPhaseCollectionGetByEdCodeLevelToId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntMajorPhase>|EntMajorPhaseCollectionGetByEdCodeLevelToId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntMajorPhaseCollectionGetByEdCodeLevelToId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntMajorPhaseCollectionGetByEdCodeLevelToId = DataRepository.EntMajorPhaseProvider.GetByEdCodeLevelToId(transactionManager, entity.EdCodeLevelId);

				if (deep && entity.EntMajorPhaseCollectionGetByEdCodeLevelToId.Count > 0)
				{
					deepHandles.Add("EntMajorPhaseCollectionGetByEdCodeLevelToId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntMajorPhase>) DataRepository.EntMajorPhaseProvider.DeepLoad,
						new object[] { transactionManager, entity.EntMajorPhaseCollectionGetByEdCodeLevelToId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdSemAgendaDtlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdSemAgendaDtl>|EdSemAgendaDtlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdSemAgendaDtlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdSemAgendaDtlCollection = DataRepository.EdSemAgendaDtlProvider.GetByEdCodeLevelId(transactionManager, entity.EdCodeLevelId);

				if (deep && entity.EdSemAgendaDtlCollection.Count > 0)
				{
					deepHandles.Add("EdSemAgendaDtlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdSemAgendaDtl>) DataRepository.EdSemAgendaDtlProvider.DeepLoad,
						new object[] { transactionManager, entity.EdSemAgendaDtlCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntPolicyLoadCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntPolicyLoad>|EntPolicyLoadCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPolicyLoadCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntPolicyLoadCollection = DataRepository.EntPolicyLoadProvider.GetByEdCodeLevelId(transactionManager, entity.EdCodeLevelId);

				if (deep && entity.EntPolicyLoadCollection.Count > 0)
				{
					deepHandles.Add("EntPolicyLoadCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntPolicyLoad>) DataRepository.EntPolicyLoadProvider.DeepLoad,
						new object[] { transactionManager, entity.EntPolicyLoadCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdCourseInfoCollectionGetByEdCodeLevelFromId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdCourseInfo>|EdCourseInfoCollectionGetByEdCodeLevelFromId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCourseInfoCollectionGetByEdCodeLevelFromId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdCourseInfoCollectionGetByEdCodeLevelFromId = DataRepository.EdCourseInfoProvider.GetByEdCodeLevelFromId(transactionManager, entity.EdCodeLevelId);

				if (deep && entity.EdCourseInfoCollectionGetByEdCodeLevelFromId.Count > 0)
				{
					deepHandles.Add("EdCourseInfoCollectionGetByEdCodeLevelFromId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdCourseInfo>) DataRepository.EdCourseInfoProvider.DeepLoad,
						new object[] { transactionManager, entity.EdCourseInfoCollectionGetByEdCodeLevelFromId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdBranchRuleCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdBranchRule>|EdBranchRuleCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdBranchRuleCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdBranchRuleCollection = DataRepository.EdBranchRuleProvider.GetByEdCodeLevelId(transactionManager, entity.EdCodeLevelId);

				if (deep && entity.EdBranchRuleCollection.Count > 0)
				{
					deepHandles.Add("EdBranchRuleCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdBranchRule>) DataRepository.EdBranchRuleProvider.DeepLoad,
						new object[] { transactionManager, entity.EdBranchRuleCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region ScSectionGroupHdrCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ScSectionGroupHdr>|ScSectionGroupHdrCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScSectionGroupHdrCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ScSectionGroupHdrCollection = DataRepository.ScSectionGroupHdrProvider.GetByEdCodeLevelId(transactionManager, entity.EdCodeLevelId);

				if (deep && entity.ScSectionGroupHdrCollection.Count > 0)
				{
					deepHandles.Add("ScSectionGroupHdrCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScSectionGroupHdr>) DataRepository.ScSectionGroupHdrProvider.DeepLoad,
						new object[] { transactionManager, entity.ScSectionGroupHdrCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.EntityMainCollection = DataRepository.EntityMainProvider.GetByEdCodeLevelId(transactionManager, entity.EdCodeLevelId);

				if (deep && entity.EntityMainCollection.Count > 0)
				{
					deepHandles.Add("EntityMainCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntityMain>) DataRepository.EntityMainProvider.DeepLoad,
						new object[] { transactionManager, entity.EntityMainCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdCodeLevel object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdCodeLevel instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCodeLevel Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeLevel entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AsFacultyInfoIdSource
			if (CanDeepSave(entity, "AsFacultyInfo|AsFacultyInfoIdSource", deepSaveType, innerList) 
				&& entity.AsFacultyInfoIdSource != null)
			{
				DataRepository.AsFacultyInfoProvider.Save(transactionManager, entity.AsFacultyInfoIdSource);
				entity.AsFacultyInfoId = entity.AsFacultyInfoIdSource.AsFacultyInfoId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<AdmAppTransReq>
				if (CanDeepSave(entity.AdmAppTransReqCollectionGetByEdCodeLevelReqId, "List<AdmAppTransReq>|AdmAppTransReqCollectionGetByEdCodeLevelReqId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppTransReq child in entity.AdmAppTransReqCollectionGetByEdCodeLevelReqId)
					{
						if(child.EdCodeLevelReqIdSource != null)
						{
							child.EdCodeLevelReqId = child.EdCodeLevelReqIdSource.EdCodeLevelId;
						}
						else
						{
							child.EdCodeLevelReqId = entity.EdCodeLevelId;
						}

					}

					if (entity.AdmAppTransReqCollectionGetByEdCodeLevelReqId.Count > 0 || entity.AdmAppTransReqCollectionGetByEdCodeLevelReqId.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppTransReqProvider.Save(transactionManager, entity.AdmAppTransReqCollectionGetByEdCodeLevelReqId);
						
						deepHandles.Add("AdmAppTransReqCollectionGetByEdCodeLevelReqId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppTransReq >) DataRepository.AdmAppTransReqProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppTransReqCollectionGetByEdCodeLevelReqId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntMajorPhase>
				if (CanDeepSave(entity.EntMajorPhaseCollectionGetByEdCodeLevelFromId, "List<EntMajorPhase>|EntMajorPhaseCollectionGetByEdCodeLevelFromId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntMajorPhase child in entity.EntMajorPhaseCollectionGetByEdCodeLevelFromId)
					{
						if(child.EdCodeLevelFromIdSource != null)
						{
							child.EdCodeLevelFromId = child.EdCodeLevelFromIdSource.EdCodeLevelId;
						}
						else
						{
							child.EdCodeLevelFromId = entity.EdCodeLevelId;
						}

					}

					if (entity.EntMajorPhaseCollectionGetByEdCodeLevelFromId.Count > 0 || entity.EntMajorPhaseCollectionGetByEdCodeLevelFromId.DeletedItems.Count > 0)
					{
						//DataRepository.EntMajorPhaseProvider.Save(transactionManager, entity.EntMajorPhaseCollectionGetByEdCodeLevelFromId);
						
						deepHandles.Add("EntMajorPhaseCollectionGetByEdCodeLevelFromId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntMajorPhase >) DataRepository.EntMajorPhaseProvider.DeepSave,
							new object[] { transactionManager, entity.EntMajorPhaseCollectionGetByEdCodeLevelFromId, deepSaveType, childTypes, innerList }
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
						if(child.EdCodeLevelIdSource != null)
						{
							child.EdCodeLevelId = child.EdCodeLevelIdSource.EdCodeLevelId;
						}
						else
						{
							child.EdCodeLevelId = entity.EdCodeLevelId;
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
				
	
			#region List<CoControlRoom>
				if (CanDeepSave(entity.CoControlRoomCollection, "List<CoControlRoom>|CoControlRoomCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CoControlRoom child in entity.CoControlRoomCollection)
					{
						if(child.EdCodeLevelIdSource != null)
						{
							child.EdCodeLevelId = child.EdCodeLevelIdSource.EdCodeLevelId;
						}
						else
						{
							child.EdCodeLevelId = entity.EdCodeLevelId;
						}

					}

					if (entity.CoControlRoomCollection.Count > 0 || entity.CoControlRoomCollection.DeletedItems.Count > 0)
					{
						//DataRepository.CoControlRoomProvider.Save(transactionManager, entity.CoControlRoomCollection);
						
						deepHandles.Add("CoControlRoomCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< CoControlRoom >) DataRepository.CoControlRoomProvider.DeepSave,
							new object[] { transactionManager, entity.CoControlRoomCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<MltLvlBhvrAttndc>
				if (CanDeepSave(entity.MltLvlBhvrAttndcCollection, "List<MltLvlBhvrAttndc>|MltLvlBhvrAttndcCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(MltLvlBhvrAttndc child in entity.MltLvlBhvrAttndcCollection)
					{
						if(child.EdCodeLevelIdSource != null)
						{
							child.EdCodeLevelId = child.EdCodeLevelIdSource.EdCodeLevelId;
						}
						else
						{
							child.EdCodeLevelId = entity.EdCodeLevelId;
						}

					}

					if (entity.MltLvlBhvrAttndcCollection.Count > 0 || entity.MltLvlBhvrAttndcCollection.DeletedItems.Count > 0)
					{
						//DataRepository.MltLvlBhvrAttndcProvider.Save(transactionManager, entity.MltLvlBhvrAttndcCollection);
						
						deepHandles.Add("MltLvlBhvrAttndcCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< MltLvlBhvrAttndc >) DataRepository.MltLvlBhvrAttndcProvider.DeepSave,
							new object[] { transactionManager, entity.MltLvlBhvrAttndcCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SvStaffEvl>
				if (CanDeepSave(entity.SvStaffEvlCollection, "List<SvStaffEvl>|SvStaffEvlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvStaffEvl child in entity.SvStaffEvlCollection)
					{
						if(child.EdCodeLevelIdSource != null)
						{
							child.EdCodeLevelId = child.EdCodeLevelIdSource.EdCodeLevelId;
						}
						else
						{
							child.EdCodeLevelId = entity.EdCodeLevelId;
						}

					}

					if (entity.SvStaffEvlCollection.Count > 0 || entity.SvStaffEvlCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvStaffEvlProvider.Save(transactionManager, entity.SvStaffEvlCollection);
						
						deepHandles.Add("SvStaffEvlCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvStaffEvl >) DataRepository.SvStaffEvlProvider.DeepSave,
							new object[] { transactionManager, entity.SvStaffEvlCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntPolcyGrdngHdr>
				if (CanDeepSave(entity.EntPolcyGrdngHdrCollection, "List<EntPolcyGrdngHdr>|EntPolcyGrdngHdrCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntPolcyGrdngHdr child in entity.EntPolcyGrdngHdrCollection)
					{
						if(child.EdCodeLevelIdSource != null)
						{
							child.EdCodeLevelId = child.EdCodeLevelIdSource.EdCodeLevelId;
						}
						else
						{
							child.EdCodeLevelId = entity.EdCodeLevelId;
						}

					}

					if (entity.EntPolcyGrdngHdrCollection.Count > 0 || entity.EntPolcyGrdngHdrCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntPolcyGrdngHdrProvider.Save(transactionManager, entity.EntPolcyGrdngHdrCollection);
						
						deepHandles.Add("EntPolcyGrdngHdrCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntPolcyGrdngHdr >) DataRepository.EntPolcyGrdngHdrProvider.DeepSave,
							new object[] { transactionManager, entity.EntPolcyGrdngHdrCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntPolicyGradingLevel>
				if (CanDeepSave(entity.EntPolicyGradingLevelCollection, "List<EntPolicyGradingLevel>|EntPolicyGradingLevelCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntPolicyGradingLevel child in entity.EntPolicyGradingLevelCollection)
					{
						if(child.EdCodeLevelIdSource != null)
						{
							child.EdCodeLevelId = child.EdCodeLevelIdSource.EdCodeLevelId;
						}
						else
						{
							child.EdCodeLevelId = entity.EdCodeLevelId;
						}

					}

					if (entity.EntPolicyGradingLevelCollection.Count > 0 || entity.EntPolicyGradingLevelCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntPolicyGradingLevelProvider.Save(transactionManager, entity.EntPolicyGradingLevelCollection);
						
						deepHandles.Add("EntPolicyGradingLevelCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntPolicyGradingLevel >) DataRepository.EntPolicyGradingLevelProvider.DeepSave,
							new object[] { transactionManager, entity.EntPolicyGradingLevelCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmAppRegHistory>
				if (CanDeepSave(entity.AdmAppRegHistoryCollection, "List<AdmAppRegHistory>|AdmAppRegHistoryCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppRegHistory child in entity.AdmAppRegHistoryCollection)
					{
						if(child.EdCodeLevelIdSource != null)
						{
							child.EdCodeLevelId = child.EdCodeLevelIdSource.EdCodeLevelId;
						}
						else
						{
							child.EdCodeLevelId = entity.EdCodeLevelId;
						}

					}

					if (entity.AdmAppRegHistoryCollection.Count > 0 || entity.AdmAppRegHistoryCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppRegHistoryProvider.Save(transactionManager, entity.AdmAppRegHistoryCollection);
						
						deepHandles.Add("AdmAppRegHistoryCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppRegHistory >) DataRepository.AdmAppRegHistoryProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppRegHistoryCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeFacultyRule>
				if (CanDeepSave(entity.FeeFacultyRuleCollection, "List<FeeFacultyRule>|FeeFacultyRuleCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeFacultyRule child in entity.FeeFacultyRuleCollection)
					{
						if(child.EdCodeLevelIdSource != null)
						{
							child.EdCodeLevelId = child.EdCodeLevelIdSource.EdCodeLevelId;
						}
						else
						{
							child.EdCodeLevelId = entity.EdCodeLevelId;
						}

					}

					if (entity.FeeFacultyRuleCollection.Count > 0 || entity.FeeFacultyRuleCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeFacultyRuleProvider.Save(transactionManager, entity.FeeFacultyRuleCollection);
						
						deepHandles.Add("FeeFacultyRuleCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeFacultyRule >) DataRepository.FeeFacultyRuleProvider.DeepSave,
							new object[] { transactionManager, entity.FeeFacultyRuleCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudSemester>
				if (CanDeepSave(entity.EdStudSemesterCollection, "List<EdStudSemester>|EdStudSemesterCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudSemester child in entity.EdStudSemesterCollection)
					{
						if(child.EdCodeLevelIdSource != null)
						{
							child.EdCodeLevelId = child.EdCodeLevelIdSource.EdCodeLevelId;
						}
						else
						{
							child.EdCodeLevelId = entity.EdCodeLevelId;
						}

					}

					if (entity.EdStudSemesterCollection.Count > 0 || entity.EdStudSemesterCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudSemesterProvider.Save(transactionManager, entity.EdStudSemesterCollection);
						
						deepHandles.Add("EdStudSemesterCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudSemester >) DataRepository.EdStudSemesterProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudSemesterCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntPolicyAbsence>
				if (CanDeepSave(entity.EntPolicyAbsenceCollection, "List<EntPolicyAbsence>|EntPolicyAbsenceCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntPolicyAbsence child in entity.EntPolicyAbsenceCollection)
					{
						if(child.EdCodeLevelIdSource != null)
						{
							child.EdCodeLevelId = child.EdCodeLevelIdSource.EdCodeLevelId;
						}
						else
						{
							child.EdCodeLevelId = entity.EdCodeLevelId;
						}

					}

					if (entity.EntPolicyAbsenceCollection.Count > 0 || entity.EntPolicyAbsenceCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntPolicyAbsenceProvider.Save(transactionManager, entity.EntPolicyAbsenceCollection);
						
						deepHandles.Add("EntPolicyAbsenceCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntPolicyAbsence >) DataRepository.EntPolicyAbsenceProvider.DeepSave,
							new object[] { transactionManager, entity.EntPolicyAbsenceCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudSemesterTemp>
				if (CanDeepSave(entity.EdStudSemesterTempCollection, "List<EdStudSemesterTemp>|EdStudSemesterTempCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudSemesterTemp child in entity.EdStudSemesterTempCollection)
					{
						if(child.EdCodeLevelIdSource != null)
						{
							child.EdCodeLevelId = child.EdCodeLevelIdSource.EdCodeLevelId;
						}
						else
						{
							child.EdCodeLevelId = entity.EdCodeLevelId;
						}

					}

					if (entity.EdStudSemesterTempCollection.Count > 0 || entity.EdStudSemesterTempCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudSemesterTempProvider.Save(transactionManager, entity.EdStudSemesterTempCollection);
						
						deepHandles.Add("EdStudSemesterTempCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudSemesterTemp >) DataRepository.EdStudSemesterTempProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudSemesterTempCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdCourseInfo>
				if (CanDeepSave(entity.EdCourseInfoCollectionGetByEdCodeLevelToId, "List<EdCourseInfo>|EdCourseInfoCollectionGetByEdCodeLevelToId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdCourseInfo child in entity.EdCourseInfoCollectionGetByEdCodeLevelToId)
					{
						if(child.EdCodeLevelToIdSource != null)
						{
							child.EdCodeLevelToId = child.EdCodeLevelToIdSource.EdCodeLevelId;
						}
						else
						{
							child.EdCodeLevelToId = entity.EdCodeLevelId;
						}

					}

					if (entity.EdCourseInfoCollectionGetByEdCodeLevelToId.Count > 0 || entity.EdCourseInfoCollectionGetByEdCodeLevelToId.DeletedItems.Count > 0)
					{
						//DataRepository.EdCourseInfoProvider.Save(transactionManager, entity.EdCourseInfoCollectionGetByEdCodeLevelToId);
						
						deepHandles.Add("EdCourseInfoCollectionGetByEdCodeLevelToId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdCourseInfo >) DataRepository.EdCourseInfoProvider.DeepSave,
							new object[] { transactionManager, entity.EdCourseInfoCollectionGetByEdCodeLevelToId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SeUserCrsAssess>
				if (CanDeepSave(entity.SeUserCrsAssessCollection, "List<SeUserCrsAssess>|SeUserCrsAssessCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SeUserCrsAssess child in entity.SeUserCrsAssessCollection)
					{
						if(child.EdCodeLevelIdSource != null)
						{
							child.EdCodeLevelId = child.EdCodeLevelIdSource.EdCodeLevelId;
						}
						else
						{
							child.EdCodeLevelId = entity.EdCodeLevelId;
						}

					}

					if (entity.SeUserCrsAssessCollection.Count > 0 || entity.SeUserCrsAssessCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SeUserCrsAssessProvider.Save(transactionManager, entity.SeUserCrsAssessCollection);
						
						deepHandles.Add("SeUserCrsAssessCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SeUserCrsAssess >) DataRepository.SeUserCrsAssessProvider.DeepSave,
							new object[] { transactionManager, entity.SeUserCrsAssessCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmAppTransReq>
				if (CanDeepSave(entity.AdmAppTransReqCollectionGetByEdCodeLevelAppId, "List<AdmAppTransReq>|AdmAppTransReqCollectionGetByEdCodeLevelAppId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppTransReq child in entity.AdmAppTransReqCollectionGetByEdCodeLevelAppId)
					{
						if(child.EdCodeLevelAppIdSource != null)
						{
							child.EdCodeLevelAppId = child.EdCodeLevelAppIdSource.EdCodeLevelId;
						}
						else
						{
							child.EdCodeLevelAppId = entity.EdCodeLevelId;
						}

					}

					if (entity.AdmAppTransReqCollectionGetByEdCodeLevelAppId.Count > 0 || entity.AdmAppTransReqCollectionGetByEdCodeLevelAppId.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppTransReqProvider.Save(transactionManager, entity.AdmAppTransReqCollectionGetByEdCodeLevelAppId);
						
						deepHandles.Add("AdmAppTransReqCollectionGetByEdCodeLevelAppId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppTransReq >) DataRepository.AdmAppTransReqProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppTransReqCollectionGetByEdCodeLevelAppId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<ScGroupInfo>
				if (CanDeepSave(entity.ScGroupInfoCollection, "List<ScGroupInfo>|ScGroupInfoCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScGroupInfo child in entity.ScGroupInfoCollection)
					{
						if(child.EdCodeLevelIdSource != null)
						{
							child.EdCodeLevelId = child.EdCodeLevelIdSource.EdCodeLevelId;
						}
						else
						{
							child.EdCodeLevelId = entity.EdCodeLevelId;
						}

					}

					if (entity.ScGroupInfoCollection.Count > 0 || entity.ScGroupInfoCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ScGroupInfoProvider.Save(transactionManager, entity.ScGroupInfoCollection);
						
						deepHandles.Add("ScGroupInfoCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ScGroupInfo >) DataRepository.ScGroupInfoProvider.DeepSave,
							new object[] { transactionManager, entity.ScGroupInfoCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdAcadPlanHdr>
				if (CanDeepSave(entity.EdAcadPlanHdrCollection, "List<EdAcadPlanHdr>|EdAcadPlanHdrCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdAcadPlanHdr child in entity.EdAcadPlanHdrCollection)
					{
						if(child.EdCodeLevelIdSource != null)
						{
							child.EdCodeLevelId = child.EdCodeLevelIdSource.EdCodeLevelId;
						}
						else
						{
							child.EdCodeLevelId = entity.EdCodeLevelId;
						}

					}

					if (entity.EdAcadPlanHdrCollection.Count > 0 || entity.EdAcadPlanHdrCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdAcadPlanHdrProvider.Save(transactionManager, entity.EdAcadPlanHdrCollection);
						
						deepHandles.Add("EdAcadPlanHdrCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdAcadPlanHdr >) DataRepository.EdAcadPlanHdrProvider.DeepSave,
							new object[] { transactionManager, entity.EdAcadPlanHdrCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntMajorPhase>
				if (CanDeepSave(entity.EntMajorPhaseCollectionGetByEdCodeLevelToId, "List<EntMajorPhase>|EntMajorPhaseCollectionGetByEdCodeLevelToId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntMajorPhase child in entity.EntMajorPhaseCollectionGetByEdCodeLevelToId)
					{
						if(child.EdCodeLevelToIdSource != null)
						{
							child.EdCodeLevelToId = child.EdCodeLevelToIdSource.EdCodeLevelId;
						}
						else
						{
							child.EdCodeLevelToId = entity.EdCodeLevelId;
						}

					}

					if (entity.EntMajorPhaseCollectionGetByEdCodeLevelToId.Count > 0 || entity.EntMajorPhaseCollectionGetByEdCodeLevelToId.DeletedItems.Count > 0)
					{
						//DataRepository.EntMajorPhaseProvider.Save(transactionManager, entity.EntMajorPhaseCollectionGetByEdCodeLevelToId);
						
						deepHandles.Add("EntMajorPhaseCollectionGetByEdCodeLevelToId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntMajorPhase >) DataRepository.EntMajorPhaseProvider.DeepSave,
							new object[] { transactionManager, entity.EntMajorPhaseCollectionGetByEdCodeLevelToId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdSemAgendaDtl>
				if (CanDeepSave(entity.EdSemAgendaDtlCollection, "List<EdSemAgendaDtl>|EdSemAgendaDtlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdSemAgendaDtl child in entity.EdSemAgendaDtlCollection)
					{
						if(child.EdCodeLevelIdSource != null)
						{
							child.EdCodeLevelId = child.EdCodeLevelIdSource.EdCodeLevelId;
						}
						else
						{
							child.EdCodeLevelId = entity.EdCodeLevelId;
						}

					}

					if (entity.EdSemAgendaDtlCollection.Count > 0 || entity.EdSemAgendaDtlCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdSemAgendaDtlProvider.Save(transactionManager, entity.EdSemAgendaDtlCollection);
						
						deepHandles.Add("EdSemAgendaDtlCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdSemAgendaDtl >) DataRepository.EdSemAgendaDtlProvider.DeepSave,
							new object[] { transactionManager, entity.EdSemAgendaDtlCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntPolicyLoad>
				if (CanDeepSave(entity.EntPolicyLoadCollection, "List<EntPolicyLoad>|EntPolicyLoadCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntPolicyLoad child in entity.EntPolicyLoadCollection)
					{
						if(child.EdCodeLevelIdSource != null)
						{
							child.EdCodeLevelId = child.EdCodeLevelIdSource.EdCodeLevelId;
						}
						else
						{
							child.EdCodeLevelId = entity.EdCodeLevelId;
						}

					}

					if (entity.EntPolicyLoadCollection.Count > 0 || entity.EntPolicyLoadCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntPolicyLoadProvider.Save(transactionManager, entity.EntPolicyLoadCollection);
						
						deepHandles.Add("EntPolicyLoadCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntPolicyLoad >) DataRepository.EntPolicyLoadProvider.DeepSave,
							new object[] { transactionManager, entity.EntPolicyLoadCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdCourseInfo>
				if (CanDeepSave(entity.EdCourseInfoCollectionGetByEdCodeLevelFromId, "List<EdCourseInfo>|EdCourseInfoCollectionGetByEdCodeLevelFromId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdCourseInfo child in entity.EdCourseInfoCollectionGetByEdCodeLevelFromId)
					{
						if(child.EdCodeLevelFromIdSource != null)
						{
							child.EdCodeLevelFromId = child.EdCodeLevelFromIdSource.EdCodeLevelId;
						}
						else
						{
							child.EdCodeLevelFromId = entity.EdCodeLevelId;
						}

					}

					if (entity.EdCourseInfoCollectionGetByEdCodeLevelFromId.Count > 0 || entity.EdCourseInfoCollectionGetByEdCodeLevelFromId.DeletedItems.Count > 0)
					{
						//DataRepository.EdCourseInfoProvider.Save(transactionManager, entity.EdCourseInfoCollectionGetByEdCodeLevelFromId);
						
						deepHandles.Add("EdCourseInfoCollectionGetByEdCodeLevelFromId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdCourseInfo >) DataRepository.EdCourseInfoProvider.DeepSave,
							new object[] { transactionManager, entity.EdCourseInfoCollectionGetByEdCodeLevelFromId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdBranchRule>
				if (CanDeepSave(entity.EdBranchRuleCollection, "List<EdBranchRule>|EdBranchRuleCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdBranchRule child in entity.EdBranchRuleCollection)
					{
						if(child.EdCodeLevelIdSource != null)
						{
							child.EdCodeLevelId = child.EdCodeLevelIdSource.EdCodeLevelId;
						}
						else
						{
							child.EdCodeLevelId = entity.EdCodeLevelId;
						}

					}

					if (entity.EdBranchRuleCollection.Count > 0 || entity.EdBranchRuleCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdBranchRuleProvider.Save(transactionManager, entity.EdBranchRuleCollection);
						
						deepHandles.Add("EdBranchRuleCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdBranchRule >) DataRepository.EdBranchRuleProvider.DeepSave,
							new object[] { transactionManager, entity.EdBranchRuleCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<ScSectionGroupHdr>
				if (CanDeepSave(entity.ScSectionGroupHdrCollection, "List<ScSectionGroupHdr>|ScSectionGroupHdrCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScSectionGroupHdr child in entity.ScSectionGroupHdrCollection)
					{
						if(child.EdCodeLevelIdSource != null)
						{
							child.EdCodeLevelId = child.EdCodeLevelIdSource.EdCodeLevelId;
						}
						else
						{
							child.EdCodeLevelId = entity.EdCodeLevelId;
						}

					}

					if (entity.ScSectionGroupHdrCollection.Count > 0 || entity.ScSectionGroupHdrCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ScSectionGroupHdrProvider.Save(transactionManager, entity.ScSectionGroupHdrCollection);
						
						deepHandles.Add("ScSectionGroupHdrCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ScSectionGroupHdr >) DataRepository.ScSectionGroupHdrProvider.DeepSave,
							new object[] { transactionManager, entity.ScSectionGroupHdrCollection, deepSaveType, childTypes, innerList }
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
						if(child.EdCodeLevelIdSource != null)
						{
							child.EdCodeLevelId = child.EdCodeLevelIdSource.EdCodeLevelId;
						}
						else
						{
							child.EdCodeLevelId = entity.EdCodeLevelId;
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
	
	#region EdCodeLevelChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdCodeLevel</c>
	///</summary>
	public enum EdCodeLevelChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AsFacultyInfo</c> at AsFacultyInfoIdSource
		///</summary>
		[ChildEntityType(typeof(AsFacultyInfo))]
		AsFacultyInfo,
		///<summary>
		/// Collection of <c>EdCodeLevel</c> as OneToMany for AdmAppTransReqCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppTransReq>))]
		AdmAppTransReqCollectionGetByEdCodeLevelReqId,
		///<summary>
		/// Collection of <c>EdCodeLevel</c> as OneToMany for EntMajorPhaseCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntMajorPhase>))]
		EntMajorPhaseCollectionGetByEdCodeLevelFromId,
		///<summary>
		/// Collection of <c>EdCodeLevel</c> as OneToMany for EdSemesterOpenCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdSemesterOpen>))]
		EdSemesterOpenCollection,
		///<summary>
		/// Collection of <c>EdCodeLevel</c> as OneToMany for CoControlRoomCollection
		///</summary>
		[ChildEntityType(typeof(TList<CoControlRoom>))]
		CoControlRoomCollection,
		///<summary>
		/// Collection of <c>EdCodeLevel</c> as OneToMany for MltLvlBhvrAttndcCollection
		///</summary>
		[ChildEntityType(typeof(TList<MltLvlBhvrAttndc>))]
		MltLvlBhvrAttndcCollection,
		///<summary>
		/// Collection of <c>EdCodeLevel</c> as OneToMany for SvStaffEvlCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvStaffEvl>))]
		SvStaffEvlCollection,
		///<summary>
		/// Collection of <c>EdCodeLevel</c> as OneToMany for EntPolcyGrdngHdrCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntPolcyGrdngHdr>))]
		EntPolcyGrdngHdrCollection,
		///<summary>
		/// Collection of <c>EdCodeLevel</c> as OneToMany for EntPolicyGradingLevelCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntPolicyGradingLevel>))]
		EntPolicyGradingLevelCollection,
		///<summary>
		/// Collection of <c>EdCodeLevel</c> as OneToMany for AdmAppRegHistoryCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppRegHistory>))]
		AdmAppRegHistoryCollection,
		///<summary>
		/// Collection of <c>EdCodeLevel</c> as OneToMany for FeeFacultyRuleCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeFacultyRule>))]
		FeeFacultyRuleCollection,
		///<summary>
		/// Collection of <c>EdCodeLevel</c> as OneToMany for EdStudSemesterCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudSemester>))]
		EdStudSemesterCollection,
		///<summary>
		/// Collection of <c>EdCodeLevel</c> as OneToMany for EntPolicyAbsenceCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntPolicyAbsence>))]
		EntPolicyAbsenceCollection,
		///<summary>
		/// Collection of <c>EdCodeLevel</c> as OneToMany for EdStudSemesterTempCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudSemesterTemp>))]
		EdStudSemesterTempCollection,
		///<summary>
		/// Collection of <c>EdCodeLevel</c> as OneToMany for EdCourseInfoCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdCourseInfo>))]
		EdCourseInfoCollectionGetByEdCodeLevelToId,
		///<summary>
		/// Collection of <c>EdCodeLevel</c> as OneToMany for SeUserCrsAssessCollection
		///</summary>
		[ChildEntityType(typeof(TList<SeUserCrsAssess>))]
		SeUserCrsAssessCollection,
		///<summary>
		/// Collection of <c>EdCodeLevel</c> as OneToMany for AdmAppTransReqCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppTransReq>))]
		AdmAppTransReqCollectionGetByEdCodeLevelAppId,
		///<summary>
		/// Collection of <c>EdCodeLevel</c> as OneToMany for ScGroupInfoCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScGroupInfo>))]
		ScGroupInfoCollection,
		///<summary>
		/// Collection of <c>EdCodeLevel</c> as OneToMany for EdAcadPlanHdrCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdAcadPlanHdr>))]
		EdAcadPlanHdrCollection,
		///<summary>
		/// Collection of <c>EdCodeLevel</c> as OneToMany for EntMajorPhaseCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntMajorPhase>))]
		EntMajorPhaseCollectionGetByEdCodeLevelToId,
		///<summary>
		/// Collection of <c>EdCodeLevel</c> as OneToMany for EdSemAgendaDtlCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdSemAgendaDtl>))]
		EdSemAgendaDtlCollection,
		///<summary>
		/// Collection of <c>EdCodeLevel</c> as OneToMany for EntPolicyLoadCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntPolicyLoad>))]
		EntPolicyLoadCollection,
		///<summary>
		/// Collection of <c>EdCodeLevel</c> as OneToMany for EdCourseInfoCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdCourseInfo>))]
		EdCourseInfoCollectionGetByEdCodeLevelFromId,
		///<summary>
		/// Collection of <c>EdCodeLevel</c> as OneToMany for EdBranchRuleCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdBranchRule>))]
		EdBranchRuleCollection,
		///<summary>
		/// Collection of <c>EdCodeLevel</c> as OneToMany for ScSectionGroupHdrCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScSectionGroupHdr>))]
		ScSectionGroupHdrCollection,
		///<summary>
		/// Collection of <c>EdCodeLevel</c> as OneToMany for EntityMainCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntityMain>))]
		EntityMainCollection,
	}
	
	#endregion EdCodeLevelChildEntityTypes
	
	#region EdCodeLevelFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdCodeLevelColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeLevel"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCodeLevelFilterBuilder : SqlFilterBuilder<EdCodeLevelColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeLevelFilterBuilder class.
		/// </summary>
		public EdCodeLevelFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCodeLevelFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCodeLevelFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCodeLevelFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCodeLevelFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCodeLevelFilterBuilder
	
	#region EdCodeLevelParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdCodeLevelColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeLevel"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCodeLevelParameterBuilder : ParameterizedSqlFilterBuilder<EdCodeLevelColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeLevelParameterBuilder class.
		/// </summary>
		public EdCodeLevelParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCodeLevelParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCodeLevelParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCodeLevelParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCodeLevelParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCodeLevelParameterBuilder
	
	#region EdCodeLevelSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdCodeLevelColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeLevel"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdCodeLevelSortBuilder : SqlSortBuilder<EdCodeLevelColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeLevelSqlSortBuilder class.
		/// </summary>
		public EdCodeLevelSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdCodeLevelSortBuilder
	
} // end namespace
