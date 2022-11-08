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
	/// This class is the base class for any <see cref="GsCdeMaritalStatusProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GsCdeMaritalStatusProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.GsCdeMaritalStatus, UMIS_VER2.BusinessLyer.GsCdeMaritalStatusKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeMaritalStatusKey key)
		{
			return Delete(transactionManager, key.GsCdeMaritalStatusId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_gsCdeMaritalStatusId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _gsCdeMaritalStatusId)
		{
			return Delete(null, _gsCdeMaritalStatusId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeMaritalStatusId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _gsCdeMaritalStatusId);		
		
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
		public override UMIS_VER2.BusinessLyer.GsCdeMaritalStatus Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeMaritalStatusKey key, int start, int pageLength)
		{
			return GetByGsCdeMaritalStatusId(transactionManager, key.GsCdeMaritalStatusId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_GS_CDE_MARITAL_STATUS index.
		/// </summary>
		/// <param name="_gsCdeMaritalStatusId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeMaritalStatus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeMaritalStatus GetByGsCdeMaritalStatusId(System.Decimal _gsCdeMaritalStatusId)
		{
			int count = -1;
			return GetByGsCdeMaritalStatusId(null,_gsCdeMaritalStatusId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_MARITAL_STATUS index.
		/// </summary>
		/// <param name="_gsCdeMaritalStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeMaritalStatus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeMaritalStatus GetByGsCdeMaritalStatusId(System.Decimal _gsCdeMaritalStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeMaritalStatusId(null, _gsCdeMaritalStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_MARITAL_STATUS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeMaritalStatusId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeMaritalStatus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeMaritalStatus GetByGsCdeMaritalStatusId(TransactionManager transactionManager, System.Decimal _gsCdeMaritalStatusId)
		{
			int count = -1;
			return GetByGsCdeMaritalStatusId(transactionManager, _gsCdeMaritalStatusId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_MARITAL_STATUS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeMaritalStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeMaritalStatus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeMaritalStatus GetByGsCdeMaritalStatusId(TransactionManager transactionManager, System.Decimal _gsCdeMaritalStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeMaritalStatusId(transactionManager, _gsCdeMaritalStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_MARITAL_STATUS index.
		/// </summary>
		/// <param name="_gsCdeMaritalStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeMaritalStatus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeMaritalStatus GetByGsCdeMaritalStatusId(System.Decimal _gsCdeMaritalStatusId, int start, int pageLength, out int count)
		{
			return GetByGsCdeMaritalStatusId(null, _gsCdeMaritalStatusId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_MARITAL_STATUS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeMaritalStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeMaritalStatus"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsCdeMaritalStatus GetByGsCdeMaritalStatusId(TransactionManager transactionManager, System.Decimal _gsCdeMaritalStatusId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GsCdeMaritalStatus&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GsCdeMaritalStatus&gt;"/></returns>
		public static TList<GsCdeMaritalStatus> Fill(IDataReader reader, TList<GsCdeMaritalStatus> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.GsCdeMaritalStatus c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GsCdeMaritalStatus")
					.Append("|").Append((System.Decimal)reader["GS_CDE_MARITAL_STATUS_ID"]).ToString();
					c = EntityManager.LocateOrCreate<GsCdeMaritalStatus>(
					key.ToString(), // EntityTrackingKey
					"GsCdeMaritalStatus",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.GsCdeMaritalStatus();
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
					c.GsCdeMaritalStatusId = (System.Decimal)reader["GS_CDE_MARITAL_STATUS_ID"];
					c.OriginalGsCdeMaritalStatusId = c.GsCdeMaritalStatusId;
					c.DescrAr = (System.String)reader["DESCR_AR"];
					c.DescrEn = Convert.IsDBNull(reader["DESCR_EN"]) ? null : (System.String)reader["DESCR_EN"];
					c.EditFlg = Convert.IsDBNull(reader["EDIT_FLG"]) ? null : (System.Boolean?)reader["EDIT_FLG"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCdeMaritalStatus"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCdeMaritalStatus"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.GsCdeMaritalStatus entity)
		{
			if (!reader.Read()) return;
			
			entity.GsCdeMaritalStatusId = (System.Decimal)reader[((int)GsCdeMaritalStatusColumn.GsCdeMaritalStatusId - 1)];
			entity.OriginalGsCdeMaritalStatusId = (System.Decimal)reader["GS_CDE_MARITAL_STATUS_ID"];
			entity.DescrAr = (System.String)reader[((int)GsCdeMaritalStatusColumn.DescrAr - 1)];
			entity.DescrEn = (reader.IsDBNull(((int)GsCdeMaritalStatusColumn.DescrEn - 1)))?null:(System.String)reader[((int)GsCdeMaritalStatusColumn.DescrEn - 1)];
			entity.EditFlg = (reader.IsDBNull(((int)GsCdeMaritalStatusColumn.EditFlg - 1)))?null:(System.Boolean?)reader[((int)GsCdeMaritalStatusColumn.EditFlg - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCdeMaritalStatus"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCdeMaritalStatus"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.GsCdeMaritalStatus entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.GsCdeMaritalStatusId = (System.Decimal)dataRow["GS_CDE_MARITAL_STATUS_ID"];
			entity.OriginalGsCdeMaritalStatusId = (System.Decimal)dataRow["GS_CDE_MARITAL_STATUS_ID"];
			entity.DescrAr = (System.String)dataRow["DESCR_AR"];
			entity.DescrEn = Convert.IsDBNull(dataRow["DESCR_EN"]) ? null : (System.String)dataRow["DESCR_EN"];
			entity.EditFlg = Convert.IsDBNull(dataRow["EDIT_FLG"]) ? null : (System.Boolean?)dataRow["EDIT_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCdeMaritalStatus"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCdeMaritalStatus Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeMaritalStatus entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByGsCdeMaritalStatusId methods when available
			
			#region AdmReqDocCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmReqDoc>|AdmReqDocCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmReqDocCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmReqDocCollection = DataRepository.AdmReqDocProvider.GetByGsCdeMaritalStatusId(transactionManager, entity.GsCdeMaritalStatusId);

				if (deep && entity.AdmReqDocCollection.Count > 0)
				{
					deepHandles.Add("AdmReqDocCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmReqDoc>) DataRepository.AdmReqDocProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmReqDocCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.SaStfMemberCollection = DataRepository.SaStfMemberProvider.GetByGsCodeMaritalStateId(transactionManager, entity.GsCdeMaritalStatusId);

				if (deep && entity.SaStfMemberCollection.Count > 0)
				{
					deepHandles.Add("SaStfMemberCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaStfMember>) DataRepository.SaStfMemberProvider.DeepLoad,
						new object[] { transactionManager, entity.SaStfMemberCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmApplicantCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmApplicant>|AdmApplicantCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmApplicantCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmApplicantCollection = DataRepository.AdmApplicantProvider.GetByGsCdeMaritalStatusId(transactionManager, entity.GsCdeMaritalStatusId);

				if (deep && entity.AdmApplicantCollection.Count > 0)
				{
					deepHandles.Add("AdmApplicantCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmApplicant>) DataRepository.AdmApplicantProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmApplicantCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStud>|EdStudCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCollection = DataRepository.EdStudProvider.GetByGsCdeMaritalStatusId(transactionManager, entity.GsCdeMaritalStatusId);

				if (deep && entity.EdStudCollection.Count > 0)
				{
					deepHandles.Add("EdStudCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStud>) DataRepository.EdStudProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdGuardCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdGuard>|EdGuardCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdGuardCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdGuardCollection = DataRepository.EdGuardProvider.GetByGsCodeMaritalStateId(transactionManager, entity.GsCdeMaritalStatusId);

				if (deep && entity.EdGuardCollection.Count > 0)
				{
					deepHandles.Add("EdGuardCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdGuard>) DataRepository.EdGuardProvider.DeepLoad,
						new object[] { transactionManager, entity.EdGuardCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.GsCdeMaritalStatus object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.GsCdeMaritalStatus instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCdeMaritalStatus Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeMaritalStatus entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<AdmReqDoc>
				if (CanDeepSave(entity.AdmReqDocCollection, "List<AdmReqDoc>|AdmReqDocCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmReqDoc child in entity.AdmReqDocCollection)
					{
						if(child.GsCdeMaritalStatusIdSource != null)
						{
							child.GsCdeMaritalStatusId = child.GsCdeMaritalStatusIdSource.GsCdeMaritalStatusId;
						}
						else
						{
							child.GsCdeMaritalStatusId = entity.GsCdeMaritalStatusId;
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
				
	
			#region List<SaStfMember>
				if (CanDeepSave(entity.SaStfMemberCollection, "List<SaStfMember>|SaStfMemberCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaStfMember child in entity.SaStfMemberCollection)
					{
						if(child.GsCodeMaritalStateIdSource != null)
						{
							child.GsCodeMaritalStateId = child.GsCodeMaritalStateIdSource.GsCdeMaritalStatusId;
						}
						else
						{
							child.GsCodeMaritalStateId = entity.GsCdeMaritalStatusId;
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
				
	
			#region List<AdmApplicant>
				if (CanDeepSave(entity.AdmApplicantCollection, "List<AdmApplicant>|AdmApplicantCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmApplicant child in entity.AdmApplicantCollection)
					{
						if(child.GsCdeMaritalStatusIdSource != null)
						{
							child.GsCdeMaritalStatusId = child.GsCdeMaritalStatusIdSource.GsCdeMaritalStatusId;
						}
						else
						{
							child.GsCdeMaritalStatusId = entity.GsCdeMaritalStatusId;
						}

					}

					if (entity.AdmApplicantCollection.Count > 0 || entity.AdmApplicantCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmApplicantProvider.Save(transactionManager, entity.AdmApplicantCollection);
						
						deepHandles.Add("AdmApplicantCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmApplicant >) DataRepository.AdmApplicantProvider.DeepSave,
							new object[] { transactionManager, entity.AdmApplicantCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStud>
				if (CanDeepSave(entity.EdStudCollection, "List<EdStud>|EdStudCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStud child in entity.EdStudCollection)
					{
						if(child.GsCdeMaritalStatusIdSource != null)
						{
							child.GsCdeMaritalStatusId = child.GsCdeMaritalStatusIdSource.GsCdeMaritalStatusId;
						}
						else
						{
							child.GsCdeMaritalStatusId = entity.GsCdeMaritalStatusId;
						}

					}

					if (entity.EdStudCollection.Count > 0 || entity.EdStudCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudProvider.Save(transactionManager, entity.EdStudCollection);
						
						deepHandles.Add("EdStudCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStud >) DataRepository.EdStudProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdGuard>
				if (CanDeepSave(entity.EdGuardCollection, "List<EdGuard>|EdGuardCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdGuard child in entity.EdGuardCollection)
					{
						if(child.GsCodeMaritalStateIdSource != null)
						{
							child.GsCodeMaritalStateId = child.GsCodeMaritalStateIdSource.GsCdeMaritalStatusId;
						}
						else
						{
							child.GsCodeMaritalStateId = entity.GsCdeMaritalStatusId;
						}

					}

					if (entity.EdGuardCollection.Count > 0 || entity.EdGuardCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdGuardProvider.Save(transactionManager, entity.EdGuardCollection);
						
						deepHandles.Add("EdGuardCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdGuard >) DataRepository.EdGuardProvider.DeepSave,
							new object[] { transactionManager, entity.EdGuardCollection, deepSaveType, childTypes, innerList }
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
	
	#region GsCdeMaritalStatusChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.GsCdeMaritalStatus</c>
	///</summary>
	public enum GsCdeMaritalStatusChildEntityTypes
	{
		///<summary>
		/// Collection of <c>GsCdeMaritalStatus</c> as OneToMany for AdmReqDocCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmReqDoc>))]
		AdmReqDocCollection,
		///<summary>
		/// Collection of <c>GsCdeMaritalStatus</c> as OneToMany for SaStfMemberCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaStfMember>))]
		SaStfMemberCollection,
		///<summary>
		/// Collection of <c>GsCdeMaritalStatus</c> as OneToMany for AdmApplicantCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmApplicant>))]
		AdmApplicantCollection,
		///<summary>
		/// Collection of <c>GsCdeMaritalStatus</c> as OneToMany for EdStudCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStud>))]
		EdStudCollection,
		///<summary>
		/// Collection of <c>GsCdeMaritalStatus</c> as OneToMany for EdGuardCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdGuard>))]
		EdGuardCollection,
	}
	
	#endregion GsCdeMaritalStatusChildEntityTypes
	
	#region GsCdeMaritalStatusFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GsCdeMaritalStatusColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCdeMaritalStatus"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCdeMaritalStatusFilterBuilder : SqlFilterBuilder<GsCdeMaritalStatusColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCdeMaritalStatusFilterBuilder class.
		/// </summary>
		public GsCdeMaritalStatusFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCdeMaritalStatusFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCdeMaritalStatusFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCdeMaritalStatusFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCdeMaritalStatusFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCdeMaritalStatusFilterBuilder
	
	#region GsCdeMaritalStatusParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GsCdeMaritalStatusColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCdeMaritalStatus"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCdeMaritalStatusParameterBuilder : ParameterizedSqlFilterBuilder<GsCdeMaritalStatusColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCdeMaritalStatusParameterBuilder class.
		/// </summary>
		public GsCdeMaritalStatusParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCdeMaritalStatusParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCdeMaritalStatusParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCdeMaritalStatusParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCdeMaritalStatusParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCdeMaritalStatusParameterBuilder
	
	#region GsCdeMaritalStatusSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GsCdeMaritalStatusColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCdeMaritalStatus"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GsCdeMaritalStatusSortBuilder : SqlSortBuilder<GsCdeMaritalStatusColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCdeMaritalStatusSqlSortBuilder class.
		/// </summary>
		public GsCdeMaritalStatusSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GsCdeMaritalStatusSortBuilder
	
} // end namespace
