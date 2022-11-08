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
	/// This class is the base class for any <see cref="GsCdeDocProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GsCdeDocProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.GsCdeDoc, UMIS_VER2.BusinessLyer.GsCdeDocKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeDocKey key)
		{
			return Delete(transactionManager, key.GsCdeDocId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_gsCdeDocId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _gsCdeDocId)
		{
			return Delete(null, _gsCdeDocId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeDocId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _gsCdeDocId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CDE_DOC_GS_CODE_DOC_TYPE key.
		///		FK_GS_CDE_DOC_GS_CODE_DOC_TYPE Description: 
		/// </summary>
		/// <param name="_gsCodeDocTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCdeDoc objects.</returns>
		public TList<GsCdeDoc> GetByGsCodeDocTypeId(System.Decimal? _gsCodeDocTypeId)
		{
			int count = -1;
			return GetByGsCodeDocTypeId(_gsCodeDocTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CDE_DOC_GS_CODE_DOC_TYPE key.
		///		FK_GS_CDE_DOC_GS_CODE_DOC_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeDocTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCdeDoc objects.</returns>
		/// <remarks></remarks>
		public TList<GsCdeDoc> GetByGsCodeDocTypeId(TransactionManager transactionManager, System.Decimal? _gsCodeDocTypeId)
		{
			int count = -1;
			return GetByGsCodeDocTypeId(transactionManager, _gsCodeDocTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CDE_DOC_GS_CODE_DOC_TYPE key.
		///		FK_GS_CDE_DOC_GS_CODE_DOC_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeDocTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCdeDoc objects.</returns>
		public TList<GsCdeDoc> GetByGsCodeDocTypeId(TransactionManager transactionManager, System.Decimal? _gsCodeDocTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeDocTypeId(transactionManager, _gsCodeDocTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CDE_DOC_GS_CODE_DOC_TYPE key.
		///		fkGsCdeDocGsCodeDocType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeDocTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCdeDoc objects.</returns>
		public TList<GsCdeDoc> GetByGsCodeDocTypeId(System.Decimal? _gsCodeDocTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodeDocTypeId(null, _gsCodeDocTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CDE_DOC_GS_CODE_DOC_TYPE key.
		///		fkGsCdeDocGsCodeDocType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeDocTypeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCdeDoc objects.</returns>
		public TList<GsCdeDoc> GetByGsCodeDocTypeId(System.Decimal? _gsCodeDocTypeId, int start, int pageLength,out int count)
		{
			return GetByGsCodeDocTypeId(null, _gsCodeDocTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CDE_DOC_GS_CODE_DOC_TYPE key.
		///		FK_GS_CDE_DOC_GS_CODE_DOC_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeDocTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCdeDoc objects.</returns>
		public abstract TList<GsCdeDoc> GetByGsCodeDocTypeId(TransactionManager transactionManager, System.Decimal? _gsCodeDocTypeId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.GsCdeDoc Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeDocKey key, int start, int pageLength)
		{
			return GetByGsCdeDocId(transactionManager, key.GsCdeDocId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_GS_CDE_DOC index.
		/// </summary>
		/// <param name="_gsCdeDocId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeDoc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeDoc GetByGsCdeDocId(System.Int32 _gsCdeDocId)
		{
			int count = -1;
			return GetByGsCdeDocId(null,_gsCdeDocId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_DOC index.
		/// </summary>
		/// <param name="_gsCdeDocId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeDoc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeDoc GetByGsCdeDocId(System.Int32 _gsCdeDocId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeDocId(null, _gsCdeDocId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_DOC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeDocId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeDoc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeDoc GetByGsCdeDocId(TransactionManager transactionManager, System.Int32 _gsCdeDocId)
		{
			int count = -1;
			return GetByGsCdeDocId(transactionManager, _gsCdeDocId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_DOC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeDocId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeDoc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeDoc GetByGsCdeDocId(TransactionManager transactionManager, System.Int32 _gsCdeDocId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeDocId(transactionManager, _gsCdeDocId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_DOC index.
		/// </summary>
		/// <param name="_gsCdeDocId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeDoc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeDoc GetByGsCdeDocId(System.Int32 _gsCdeDocId, int start, int pageLength, out int count)
		{
			return GetByGsCdeDocId(null, _gsCdeDocId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_DOC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeDocId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeDoc"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsCdeDoc GetByGsCdeDocId(TransactionManager transactionManager, System.Int32 _gsCdeDocId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GsCdeDoc&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GsCdeDoc&gt;"/></returns>
		public static TList<GsCdeDoc> Fill(IDataReader reader, TList<GsCdeDoc> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.GsCdeDoc c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GsCdeDoc")
					.Append("|").Append((System.Int32)reader["GS_CDE_DOC_ID"]).ToString();
					c = EntityManager.LocateOrCreate<GsCdeDoc>(
					key.ToString(), // EntityTrackingKey
					"GsCdeDoc",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.GsCdeDoc();
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
					c.GsCdeDocId = (System.Int32)reader["GS_CDE_DOC_ID"];
					c.OriginalGsCdeDocId = c.GsCdeDocId;
					c.DocNameAr = Convert.IsDBNull(reader["DOC_NAME_AR"]) ? null : (System.String)reader["DOC_NAME_AR"];
					c.DocNameEn = Convert.IsDBNull(reader["DOC_NAME_EN"]) ? null : (System.String)reader["DOC_NAME_EN"];
					c.GsCodeDocTypeId = Convert.IsDBNull(reader["GS_CODE_DOC_TYPE_ID"]) ? null : (System.Decimal?)reader["GS_CODE_DOC_TYPE_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCdeDoc"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCdeDoc"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.GsCdeDoc entity)
		{
			if (!reader.Read()) return;
			
			entity.GsCdeDocId = (System.Int32)reader[((int)GsCdeDocColumn.GsCdeDocId - 1)];
			entity.OriginalGsCdeDocId = (System.Int32)reader["GS_CDE_DOC_ID"];
			entity.DocNameAr = (reader.IsDBNull(((int)GsCdeDocColumn.DocNameAr - 1)))?null:(System.String)reader[((int)GsCdeDocColumn.DocNameAr - 1)];
			entity.DocNameEn = (reader.IsDBNull(((int)GsCdeDocColumn.DocNameEn - 1)))?null:(System.String)reader[((int)GsCdeDocColumn.DocNameEn - 1)];
			entity.GsCodeDocTypeId = (reader.IsDBNull(((int)GsCdeDocColumn.GsCodeDocTypeId - 1)))?null:(System.Decimal?)reader[((int)GsCdeDocColumn.GsCodeDocTypeId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCdeDoc"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCdeDoc"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.GsCdeDoc entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.GsCdeDocId = (System.Int32)dataRow["GS_CDE_DOC_ID"];
			entity.OriginalGsCdeDocId = (System.Int32)dataRow["GS_CDE_DOC_ID"];
			entity.DocNameAr = Convert.IsDBNull(dataRow["DOC_NAME_AR"]) ? null : (System.String)dataRow["DOC_NAME_AR"];
			entity.DocNameEn = Convert.IsDBNull(dataRow["DOC_NAME_EN"]) ? null : (System.String)dataRow["DOC_NAME_EN"];
			entity.GsCodeDocTypeId = Convert.IsDBNull(dataRow["GS_CODE_DOC_TYPE_ID"]) ? null : (System.Decimal?)dataRow["GS_CODE_DOC_TYPE_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCdeDoc"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCdeDoc Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeDoc entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region GsCodeDocTypeIdSource	
			if (CanDeepLoad(entity, "GsCodeDocType|GsCodeDocTypeIdSource", deepLoadType, innerList) 
				&& entity.GsCodeDocTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCodeDocTypeId ?? 0.0m);
				GsCodeDocType tmpEntity = EntityManager.LocateEntity<GsCodeDocType>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodeDocType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodeDocTypeIdSource = tmpEntity;
				else
					entity.GsCodeDocTypeIdSource = DataRepository.GsCodeDocTypeProvider.GetByGsCodeDocTypeId(transactionManager, (entity.GsCodeDocTypeId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodeDocTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCodeDocTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodeDocTypeProvider.DeepLoad(transactionManager, entity.GsCodeDocTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCodeDocTypeIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByGsCdeDocId methods when available
			
			#region AdmAppDocCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppDoc>|AdmAppDocCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppDocCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppDocCollection = DataRepository.AdmAppDocProvider.GetByGsCdeDocId(transactionManager, entity.GsCdeDocId);

				if (deep && entity.AdmAppDocCollection.Count > 0)
				{
					deepHandles.Add("AdmAppDocCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppDoc>) DataRepository.AdmAppDocProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppDocCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmReqDocCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmReqDoc>|AdmReqDocCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmReqDocCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmReqDocCollection = DataRepository.AdmReqDocProvider.GetByGsCdeDocId(transactionManager, entity.GsCdeDocId);

				if (deep && entity.AdmReqDocCollection.Count > 0)
				{
					deepHandles.Add("AdmReqDocCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmReqDoc>) DataRepository.AdmReqDocProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmReqDocCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.GsCdeDoc object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.GsCdeDoc instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCdeDoc Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeDoc entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region GsCodeDocTypeIdSource
			if (CanDeepSave(entity, "GsCodeDocType|GsCodeDocTypeIdSource", deepSaveType, innerList) 
				&& entity.GsCodeDocTypeIdSource != null)
			{
				DataRepository.GsCodeDocTypeProvider.Save(transactionManager, entity.GsCodeDocTypeIdSource);
				entity.GsCodeDocTypeId = entity.GsCodeDocTypeIdSource.GsCodeDocTypeId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<AdmAppDoc>
				if (CanDeepSave(entity.AdmAppDocCollection, "List<AdmAppDoc>|AdmAppDocCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppDoc child in entity.AdmAppDocCollection)
					{
						if(child.GsCdeDocIdSource != null)
						{
							child.GsCdeDocId = child.GsCdeDocIdSource.GsCdeDocId;
						}
						else
						{
							child.GsCdeDocId = entity.GsCdeDocId;
						}

					}

					if (entity.AdmAppDocCollection.Count > 0 || entity.AdmAppDocCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppDocProvider.Save(transactionManager, entity.AdmAppDocCollection);
						
						deepHandles.Add("AdmAppDocCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppDoc >) DataRepository.AdmAppDocProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppDocCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmReqDoc>
				if (CanDeepSave(entity.AdmReqDocCollection, "List<AdmReqDoc>|AdmReqDocCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmReqDoc child in entity.AdmReqDocCollection)
					{
						if(child.GsCdeDocIdSource != null)
						{
							child.GsCdeDocId = child.GsCdeDocIdSource.GsCdeDocId;
						}
						else
						{
							child.GsCdeDocId = entity.GsCdeDocId;
						}

					}

					if (entity.AdmReqDocCollection.Count > 0 || entity.AdmReqDocCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmReqDocProvider.Save(transactionManager, entity.AdmReqDocCollection);
						
						deepHandles.Add("AdmReqDocCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmReqDoc >) DataRepository.AdmReqDocProvider.DeepSave,
							new object[] { transactionManager, entity.AdmReqDocCollection, deepSaveType, childTypes, innerList }
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
	
	#region GsCdeDocChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.GsCdeDoc</c>
	///</summary>
	public enum GsCdeDocChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>GsCodeDocType</c> at GsCodeDocTypeIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeDocType))]
		GsCodeDocType,
		///<summary>
		/// Collection of <c>GsCdeDoc</c> as OneToMany for AdmAppDocCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppDoc>))]
		AdmAppDocCollection,
		///<summary>
		/// Collection of <c>GsCdeDoc</c> as OneToMany for AdmReqDocCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmReqDoc>))]
		AdmReqDocCollection,
	}
	
	#endregion GsCdeDocChildEntityTypes
	
	#region GsCdeDocFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GsCdeDocColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCdeDoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCdeDocFilterBuilder : SqlFilterBuilder<GsCdeDocColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCdeDocFilterBuilder class.
		/// </summary>
		public GsCdeDocFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCdeDocFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCdeDocFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCdeDocFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCdeDocFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCdeDocFilterBuilder
	
	#region GsCdeDocParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GsCdeDocColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCdeDoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCdeDocParameterBuilder : ParameterizedSqlFilterBuilder<GsCdeDocColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCdeDocParameterBuilder class.
		/// </summary>
		public GsCdeDocParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCdeDocParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCdeDocParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCdeDocParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCdeDocParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCdeDocParameterBuilder
	
	#region GsCdeDocSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GsCdeDocColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCdeDoc"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GsCdeDocSortBuilder : SqlSortBuilder<GsCdeDocColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCdeDocSqlSortBuilder class.
		/// </summary>
		public GsCdeDocSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GsCdeDocSortBuilder
	
} // end namespace
