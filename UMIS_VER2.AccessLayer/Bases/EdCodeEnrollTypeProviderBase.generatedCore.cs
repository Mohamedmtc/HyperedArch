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
	/// This class is the base class for any <see cref="EdCodeEnrollTypeProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdCodeEnrollTypeProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdCodeEnrollType, UMIS_VER2.BusinessLyer.EdCodeEnrollTypeKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeEnrollTypeKey key)
		{
			return Delete(transactionManager, key.EdCodeEnrollTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edCodeEnrollTypeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edCodeEnrollTypeId)
		{
			return Delete(null, _edCodeEnrollTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeEnrollTypeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edCodeEnrollTypeId);		
		
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
		public override UMIS_VER2.BusinessLyer.EdCodeEnrollType Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeEnrollTypeKey key, int start, int pageLength)
		{
			return GetByEdCodeEnrollTypeId(transactionManager, key.EdCodeEnrollTypeId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_CODE_ENROLL_TYPE index.
		/// </summary>
		/// <param name="_edCodeEnrollTypeId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeEnrollType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeEnrollType GetByEdCodeEnrollTypeId(System.Decimal _edCodeEnrollTypeId)
		{
			int count = -1;
			return GetByEdCodeEnrollTypeId(null,_edCodeEnrollTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_ENROLL_TYPE index.
		/// </summary>
		/// <param name="_edCodeEnrollTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeEnrollType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeEnrollType GetByEdCodeEnrollTypeId(System.Decimal _edCodeEnrollTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeEnrollTypeId(null, _edCodeEnrollTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_ENROLL_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeEnrollTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeEnrollType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeEnrollType GetByEdCodeEnrollTypeId(TransactionManager transactionManager, System.Decimal _edCodeEnrollTypeId)
		{
			int count = -1;
			return GetByEdCodeEnrollTypeId(transactionManager, _edCodeEnrollTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_ENROLL_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeEnrollTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeEnrollType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeEnrollType GetByEdCodeEnrollTypeId(TransactionManager transactionManager, System.Decimal _edCodeEnrollTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeEnrollTypeId(transactionManager, _edCodeEnrollTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_ENROLL_TYPE index.
		/// </summary>
		/// <param name="_edCodeEnrollTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeEnrollType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeEnrollType GetByEdCodeEnrollTypeId(System.Decimal _edCodeEnrollTypeId, int start, int pageLength, out int count)
		{
			return GetByEdCodeEnrollTypeId(null, _edCodeEnrollTypeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_ENROLL_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeEnrollTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeEnrollType"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdCodeEnrollType GetByEdCodeEnrollTypeId(TransactionManager transactionManager, System.Decimal _edCodeEnrollTypeId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdCodeEnrollType&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdCodeEnrollType&gt;"/></returns>
		public static TList<EdCodeEnrollType> Fill(IDataReader reader, TList<EdCodeEnrollType> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdCodeEnrollType c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdCodeEnrollType")
					.Append("|").Append((System.Decimal)reader["ED_CODE_ENROLL_TYPE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdCodeEnrollType>(
					key.ToString(), // EntityTrackingKey
					"EdCodeEnrollType",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdCodeEnrollType();
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
					c.EdCodeEnrollTypeId = (System.Decimal)reader["ED_CODE_ENROLL_TYPE_ID"];
					c.OriginalEdCodeEnrollTypeId = c.EdCodeEnrollTypeId;
					c.DescrAr = (System.String)reader["DESCR_AR"];
					c.DescrEn = Convert.IsDBNull(reader["DESCR_EN"]) ? null : (System.String)reader["DESCR_EN"];
					c.EnrollCode = Convert.IsDBNull(reader["ENROLL_CODE"]) ? null : (System.String)reader["ENROLL_CODE"];
					c.ShowFlg = Convert.IsDBNull(reader["SHOW_FLG"]) ? null : (System.Decimal?)reader["SHOW_FLG"];
					c.SemRltdFlg = Convert.IsDBNull(reader["SEM_RLTD_FLG"]) ? null : (System.Decimal?)reader["SEM_RLTD_FLG"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCodeEnrollType"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeEnrollType"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdCodeEnrollType entity)
		{
			if (!reader.Read()) return;
			
			entity.EdCodeEnrollTypeId = (System.Decimal)reader[((int)EdCodeEnrollTypeColumn.EdCodeEnrollTypeId - 1)];
			entity.OriginalEdCodeEnrollTypeId = (System.Decimal)reader["ED_CODE_ENROLL_TYPE_ID"];
			entity.DescrAr = (System.String)reader[((int)EdCodeEnrollTypeColumn.DescrAr - 1)];
			entity.DescrEn = (reader.IsDBNull(((int)EdCodeEnrollTypeColumn.DescrEn - 1)))?null:(System.String)reader[((int)EdCodeEnrollTypeColumn.DescrEn - 1)];
			entity.EnrollCode = (reader.IsDBNull(((int)EdCodeEnrollTypeColumn.EnrollCode - 1)))?null:(System.String)reader[((int)EdCodeEnrollTypeColumn.EnrollCode - 1)];
			entity.ShowFlg = (reader.IsDBNull(((int)EdCodeEnrollTypeColumn.ShowFlg - 1)))?null:(System.Decimal?)reader[((int)EdCodeEnrollTypeColumn.ShowFlg - 1)];
			entity.SemRltdFlg = (reader.IsDBNull(((int)EdCodeEnrollTypeColumn.SemRltdFlg - 1)))?null:(System.Decimal?)reader[((int)EdCodeEnrollTypeColumn.SemRltdFlg - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCodeEnrollType"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeEnrollType"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdCodeEnrollType entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdCodeEnrollTypeId = (System.Decimal)dataRow["ED_CODE_ENROLL_TYPE_ID"];
			entity.OriginalEdCodeEnrollTypeId = (System.Decimal)dataRow["ED_CODE_ENROLL_TYPE_ID"];
			entity.DescrAr = (System.String)dataRow["DESCR_AR"];
			entity.DescrEn = Convert.IsDBNull(dataRow["DESCR_EN"]) ? null : (System.String)dataRow["DESCR_EN"];
			entity.EnrollCode = Convert.IsDBNull(dataRow["ENROLL_CODE"]) ? null : (System.String)dataRow["ENROLL_CODE"];
			entity.ShowFlg = Convert.IsDBNull(dataRow["SHOW_FLG"]) ? null : (System.Decimal?)dataRow["SHOW_FLG"];
			entity.SemRltdFlg = Convert.IsDBNull(dataRow["SEM_RLTD_FLG"]) ? null : (System.Decimal?)dataRow["SEM_RLTD_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeEnrollType"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCodeEnrollType Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeEnrollType entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEdCodeEnrollTypeId methods when available
			
			#region EdStudEnrollChangeCollectionGetByEdCodeEnrollTypeOldId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudEnrollChange>|EdStudEnrollChangeCollectionGetByEdCodeEnrollTypeOldId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudEnrollChangeCollectionGetByEdCodeEnrollTypeOldId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudEnrollChangeCollectionGetByEdCodeEnrollTypeOldId = DataRepository.EdStudEnrollChangeProvider.GetByEdCodeEnrollTypeOldId(transactionManager, entity.EdCodeEnrollTypeId);

				if (deep && entity.EdStudEnrollChangeCollectionGetByEdCodeEnrollTypeOldId.Count > 0)
				{
					deepHandles.Add("EdStudEnrollChangeCollectionGetByEdCodeEnrollTypeOldId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudEnrollChange>) DataRepository.EdStudEnrollChangeProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudEnrollChangeCollectionGetByEdCodeEnrollTypeOldId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudEnrollChangeCollectionGetByEdCodeEnrollTypeNewId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudEnrollChange>|EdStudEnrollChangeCollectionGetByEdCodeEnrollTypeNewId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudEnrollChangeCollectionGetByEdCodeEnrollTypeNewId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudEnrollChangeCollectionGetByEdCodeEnrollTypeNewId = DataRepository.EdStudEnrollChangeProvider.GetByEdCodeEnrollTypeNewId(transactionManager, entity.EdCodeEnrollTypeId);

				if (deep && entity.EdStudEnrollChangeCollectionGetByEdCodeEnrollTypeNewId.Count > 0)
				{
					deepHandles.Add("EdStudEnrollChangeCollectionGetByEdCodeEnrollTypeNewId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudEnrollChange>) DataRepository.EdStudEnrollChangeProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudEnrollChangeCollectionGetByEdCodeEnrollTypeNewId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntPolicyExcuseCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntPolicyExcuse>|EntPolicyExcuseCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPolicyExcuseCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntPolicyExcuseCollection = DataRepository.EntPolicyExcuseProvider.GetByEdCodeEnrollTypeId(transactionManager, entity.EdCodeEnrollTypeId);

				if (deep && entity.EntPolicyExcuseCollection.Count > 0)
				{
					deepHandles.Add("EntPolicyExcuseCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntPolicyExcuse>) DataRepository.EntPolicyExcuseProvider.DeepLoad,
						new object[] { transactionManager, entity.EntPolicyExcuseCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.EdStudSemesterCollection = DataRepository.EdStudSemesterProvider.GetByEdCodeEnrollTypeId(transactionManager, entity.EdCodeEnrollTypeId);

				if (deep && entity.EdStudSemesterCollection.Count > 0)
				{
					deepHandles.Add("EdStudSemesterCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudSemester>) DataRepository.EdStudSemesterProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudSemesterCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.EdStudSemesterTempCollection = DataRepository.EdStudSemesterTempProvider.GetByEdCodeEnrollTypeId(transactionManager, entity.EdCodeEnrollTypeId);

				if (deep && entity.EdStudSemesterTempCollection.Count > 0)
				{
					deepHandles.Add("EdStudSemesterTempCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudSemesterTemp>) DataRepository.EdStudSemesterTempProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudSemesterTempCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdCodeEnrollType object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdCodeEnrollType instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCodeEnrollType Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeEnrollType entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<EdStudEnrollChange>
				if (CanDeepSave(entity.EdStudEnrollChangeCollectionGetByEdCodeEnrollTypeOldId, "List<EdStudEnrollChange>|EdStudEnrollChangeCollectionGetByEdCodeEnrollTypeOldId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudEnrollChange child in entity.EdStudEnrollChangeCollectionGetByEdCodeEnrollTypeOldId)
					{
						if(child.EdCodeEnrollTypeOldIdSource != null)
						{
							child.EdCodeEnrollTypeOldId = child.EdCodeEnrollTypeOldIdSource.EdCodeEnrollTypeId;
						}
						else
						{
							child.EdCodeEnrollTypeOldId = entity.EdCodeEnrollTypeId;
						}

					}

					if (entity.EdStudEnrollChangeCollectionGetByEdCodeEnrollTypeOldId.Count > 0 || entity.EdStudEnrollChangeCollectionGetByEdCodeEnrollTypeOldId.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudEnrollChangeProvider.Save(transactionManager, entity.EdStudEnrollChangeCollectionGetByEdCodeEnrollTypeOldId);
						
						deepHandles.Add("EdStudEnrollChangeCollectionGetByEdCodeEnrollTypeOldId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudEnrollChange >) DataRepository.EdStudEnrollChangeProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudEnrollChangeCollectionGetByEdCodeEnrollTypeOldId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudEnrollChange>
				if (CanDeepSave(entity.EdStudEnrollChangeCollectionGetByEdCodeEnrollTypeNewId, "List<EdStudEnrollChange>|EdStudEnrollChangeCollectionGetByEdCodeEnrollTypeNewId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudEnrollChange child in entity.EdStudEnrollChangeCollectionGetByEdCodeEnrollTypeNewId)
					{
						if(child.EdCodeEnrollTypeNewIdSource != null)
						{
							child.EdCodeEnrollTypeNewId = child.EdCodeEnrollTypeNewIdSource.EdCodeEnrollTypeId;
						}
						else
						{
							child.EdCodeEnrollTypeNewId = entity.EdCodeEnrollTypeId;
						}

					}

					if (entity.EdStudEnrollChangeCollectionGetByEdCodeEnrollTypeNewId.Count > 0 || entity.EdStudEnrollChangeCollectionGetByEdCodeEnrollTypeNewId.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudEnrollChangeProvider.Save(transactionManager, entity.EdStudEnrollChangeCollectionGetByEdCodeEnrollTypeNewId);
						
						deepHandles.Add("EdStudEnrollChangeCollectionGetByEdCodeEnrollTypeNewId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudEnrollChange >) DataRepository.EdStudEnrollChangeProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudEnrollChangeCollectionGetByEdCodeEnrollTypeNewId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntPolicyExcuse>
				if (CanDeepSave(entity.EntPolicyExcuseCollection, "List<EntPolicyExcuse>|EntPolicyExcuseCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntPolicyExcuse child in entity.EntPolicyExcuseCollection)
					{
						if(child.EdCodeEnrollTypeIdSource != null)
						{
							child.EdCodeEnrollTypeId = child.EdCodeEnrollTypeIdSource.EdCodeEnrollTypeId;
						}
						else
						{
							child.EdCodeEnrollTypeId = entity.EdCodeEnrollTypeId;
						}

					}

					if (entity.EntPolicyExcuseCollection.Count > 0 || entity.EntPolicyExcuseCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntPolicyExcuseProvider.Save(transactionManager, entity.EntPolicyExcuseCollection);
						
						deepHandles.Add("EntPolicyExcuseCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntPolicyExcuse >) DataRepository.EntPolicyExcuseProvider.DeepSave,
							new object[] { transactionManager, entity.EntPolicyExcuseCollection, deepSaveType, childTypes, innerList }
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
						if(child.EdCodeEnrollTypeIdSource != null)
						{
							child.EdCodeEnrollTypeId = child.EdCodeEnrollTypeIdSource.EdCodeEnrollTypeId;
						}
						else
						{
							child.EdCodeEnrollTypeId = entity.EdCodeEnrollTypeId;
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
				
	
			#region List<EdStudSemesterTemp>
				if (CanDeepSave(entity.EdStudSemesterTempCollection, "List<EdStudSemesterTemp>|EdStudSemesterTempCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudSemesterTemp child in entity.EdStudSemesterTempCollection)
					{
						if(child.EdCodeEnrollTypeIdSource != null)
						{
							child.EdCodeEnrollTypeId = child.EdCodeEnrollTypeIdSource.EdCodeEnrollTypeId;
						}
						else
						{
							child.EdCodeEnrollTypeId = entity.EdCodeEnrollTypeId;
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
	
	#region EdCodeEnrollTypeChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdCodeEnrollType</c>
	///</summary>
	public enum EdCodeEnrollTypeChildEntityTypes
	{
		///<summary>
		/// Collection of <c>EdCodeEnrollType</c> as OneToMany for EdStudEnrollChangeCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudEnrollChange>))]
		EdStudEnrollChangeCollectionGetByEdCodeEnrollTypeOldId,
		///<summary>
		/// Collection of <c>EdCodeEnrollType</c> as OneToMany for EdStudEnrollChangeCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudEnrollChange>))]
		EdStudEnrollChangeCollectionGetByEdCodeEnrollTypeNewId,
		///<summary>
		/// Collection of <c>EdCodeEnrollType</c> as OneToMany for EntPolicyExcuseCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntPolicyExcuse>))]
		EntPolicyExcuseCollection,
		///<summary>
		/// Collection of <c>EdCodeEnrollType</c> as OneToMany for EdStudSemesterCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudSemester>))]
		EdStudSemesterCollection,
		///<summary>
		/// Collection of <c>EdCodeEnrollType</c> as OneToMany for EdStudSemesterTempCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudSemesterTemp>))]
		EdStudSemesterTempCollection,
	}
	
	#endregion EdCodeEnrollTypeChildEntityTypes
	
	#region EdCodeEnrollTypeFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdCodeEnrollTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeEnrollType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCodeEnrollTypeFilterBuilder : SqlFilterBuilder<EdCodeEnrollTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeEnrollTypeFilterBuilder class.
		/// </summary>
		public EdCodeEnrollTypeFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCodeEnrollTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCodeEnrollTypeFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCodeEnrollTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCodeEnrollTypeFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCodeEnrollTypeFilterBuilder
	
	#region EdCodeEnrollTypeParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdCodeEnrollTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeEnrollType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCodeEnrollTypeParameterBuilder : ParameterizedSqlFilterBuilder<EdCodeEnrollTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeEnrollTypeParameterBuilder class.
		/// </summary>
		public EdCodeEnrollTypeParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCodeEnrollTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCodeEnrollTypeParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCodeEnrollTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCodeEnrollTypeParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCodeEnrollTypeParameterBuilder
	
	#region EdCodeEnrollTypeSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdCodeEnrollTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeEnrollType"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdCodeEnrollTypeSortBuilder : SqlSortBuilder<EdCodeEnrollTypeColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeEnrollTypeSqlSortBuilder class.
		/// </summary>
		public EdCodeEnrollTypeSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdCodeEnrollTypeSortBuilder
	
} // end namespace
