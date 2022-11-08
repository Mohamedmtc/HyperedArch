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
	/// This class is the base class for any <see cref="EdCourseExpHdrProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdCourseExpHdrProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdCourseExpHdr, UMIS_VER2.BusinessLyer.EdCourseExpHdrKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCourseExpHdrKey key)
		{
			return Delete(transactionManager, key.EdCourseExpHdrId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edCourseExpHdrId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edCourseExpHdrId)
		{
			return Delete(null, _edCourseExpHdrId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseExpHdrId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edCourseExpHdrId);		
		
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
		public override UMIS_VER2.BusinessLyer.EdCourseExpHdr Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCourseExpHdrKey key, int start, int pageLength)
		{
			return GetByEdCourseExpHdrId(transactionManager, key.EdCourseExpHdrId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_COURSE_EXP_HDR index.
		/// </summary>
		/// <param name="_edCourseExpHdrId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourseExpHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCourseExpHdr GetByEdCourseExpHdrId(System.Decimal _edCourseExpHdrId)
		{
			int count = -1;
			return GetByEdCourseExpHdrId(null,_edCourseExpHdrId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_COURSE_EXP_HDR index.
		/// </summary>
		/// <param name="_edCourseExpHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourseExpHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCourseExpHdr GetByEdCourseExpHdrId(System.Decimal _edCourseExpHdrId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseExpHdrId(null, _edCourseExpHdrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_COURSE_EXP_HDR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseExpHdrId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourseExpHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCourseExpHdr GetByEdCourseExpHdrId(TransactionManager transactionManager, System.Decimal _edCourseExpHdrId)
		{
			int count = -1;
			return GetByEdCourseExpHdrId(transactionManager, _edCourseExpHdrId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_COURSE_EXP_HDR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseExpHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourseExpHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCourseExpHdr GetByEdCourseExpHdrId(TransactionManager transactionManager, System.Decimal _edCourseExpHdrId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseExpHdrId(transactionManager, _edCourseExpHdrId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_COURSE_EXP_HDR index.
		/// </summary>
		/// <param name="_edCourseExpHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourseExpHdr"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCourseExpHdr GetByEdCourseExpHdrId(System.Decimal _edCourseExpHdrId, int start, int pageLength, out int count)
		{
			return GetByEdCourseExpHdrId(null, _edCourseExpHdrId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_COURSE_EXP_HDR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseExpHdrId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourseExpHdr"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdCourseExpHdr GetByEdCourseExpHdrId(TransactionManager transactionManager, System.Decimal _edCourseExpHdrId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdCourseExpHdr&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdCourseExpHdr&gt;"/></returns>
		public static TList<EdCourseExpHdr> Fill(IDataReader reader, TList<EdCourseExpHdr> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdCourseExpHdr c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdCourseExpHdr")
					.Append("|").Append((System.Decimal)reader["ED_COURSE_EXP_HDR_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdCourseExpHdr>(
					key.ToString(), // EntityTrackingKey
					"EdCourseExpHdr",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdCourseExpHdr();
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
					c.EdCourseExpHdrId = (System.Decimal)reader["ED_COURSE_EXP_HDR_ID"];
					c.OriginalEdCourseExpHdrId = c.EdCourseExpHdrId;
					c.ExpNameAr = Convert.IsDBNull(reader["EXP_NAME_AR"]) ? null : (System.String)reader["EXP_NAME_AR"];
					c.ExpNameEn = Convert.IsDBNull(reader["EXP_NAME_EN"]) ? null : (System.String)reader["EXP_NAME_EN"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCourseExpHdr"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCourseExpHdr"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdCourseExpHdr entity)
		{
			if (!reader.Read()) return;
			
			entity.EdCourseExpHdrId = (System.Decimal)reader[((int)EdCourseExpHdrColumn.EdCourseExpHdrId - 1)];
			entity.OriginalEdCourseExpHdrId = (System.Decimal)reader["ED_COURSE_EXP_HDR_ID"];
			entity.ExpNameAr = (reader.IsDBNull(((int)EdCourseExpHdrColumn.ExpNameAr - 1)))?null:(System.String)reader[((int)EdCourseExpHdrColumn.ExpNameAr - 1)];
			entity.ExpNameEn = (reader.IsDBNull(((int)EdCourseExpHdrColumn.ExpNameEn - 1)))?null:(System.String)reader[((int)EdCourseExpHdrColumn.ExpNameEn - 1)];
			entity.Notes = (reader.IsDBNull(((int)EdCourseExpHdrColumn.Notes - 1)))?null:(System.String)reader[((int)EdCourseExpHdrColumn.Notes - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCourseExpHdr"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCourseExpHdr"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdCourseExpHdr entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdCourseExpHdrId = (System.Decimal)dataRow["ED_COURSE_EXP_HDR_ID"];
			entity.OriginalEdCourseExpHdrId = (System.Decimal)dataRow["ED_COURSE_EXP_HDR_ID"];
			entity.ExpNameAr = Convert.IsDBNull(dataRow["EXP_NAME_AR"]) ? null : (System.String)dataRow["EXP_NAME_AR"];
			entity.ExpNameEn = Convert.IsDBNull(dataRow["EXP_NAME_EN"]) ? null : (System.String)dataRow["EXP_NAME_EN"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCourseExpHdr"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCourseExpHdr Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCourseExpHdr entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEdCourseExpHdrId methods when available
			
			#region EntCoursePkgDtlCollectionGetByEdCourseExpPrereqHdrId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntCoursePkgDtl>|EntCoursePkgDtlCollectionGetByEdCourseExpPrereqHdrId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntCoursePkgDtlCollectionGetByEdCourseExpPrereqHdrId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntCoursePkgDtlCollectionGetByEdCourseExpPrereqHdrId = DataRepository.EntCoursePkgDtlProvider.GetByEdCourseExpPrereqHdrId(transactionManager, entity.EdCourseExpHdrId);

				if (deep && entity.EntCoursePkgDtlCollectionGetByEdCourseExpPrereqHdrId.Count > 0)
				{
					deepHandles.Add("EntCoursePkgDtlCollectionGetByEdCourseExpPrereqHdrId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntCoursePkgDtl>) DataRepository.EntCoursePkgDtlProvider.DeepLoad,
						new object[] { transactionManager, entity.EntCoursePkgDtlCollectionGetByEdCourseExpPrereqHdrId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntCoursePkgDtlCollectionGetByEdCourseExpHdrId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntCoursePkgDtl>|EntCoursePkgDtlCollectionGetByEdCourseExpHdrId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntCoursePkgDtlCollectionGetByEdCourseExpHdrId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntCoursePkgDtlCollectionGetByEdCourseExpHdrId = DataRepository.EntCoursePkgDtlProvider.GetByEdCourseExpHdrId(transactionManager, entity.EdCourseExpHdrId);

				if (deep && entity.EntCoursePkgDtlCollectionGetByEdCourseExpHdrId.Count > 0)
				{
					deepHandles.Add("EntCoursePkgDtlCollectionGetByEdCourseExpHdrId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntCoursePkgDtl>) DataRepository.EntCoursePkgDtlProvider.DeepLoad,
						new object[] { transactionManager, entity.EntCoursePkgDtlCollectionGetByEdCourseExpHdrId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdAcadPlanDtlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdAcadPlanDtl>|EdAcadPlanDtlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdAcadPlanDtlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdAcadPlanDtlCollection = DataRepository.EdAcadPlanDtlProvider.GetByEdCourseExpHdrId(transactionManager, entity.EdCourseExpHdrId);

				if (deep && entity.EdAcadPlanDtlCollection.Count > 0)
				{
					deepHandles.Add("EdAcadPlanDtlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdAcadPlanDtl>) DataRepository.EdAcadPlanDtlProvider.DeepLoad,
						new object[] { transactionManager, entity.EdAcadPlanDtlCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdCourseExpDtlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdCourseExpDtl>|EdCourseExpDtlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCourseExpDtlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdCourseExpDtlCollection = DataRepository.EdCourseExpDtlProvider.GetByEdCourseExpHdrId(transactionManager, entity.EdCourseExpHdrId);

				if (deep && entity.EdCourseExpDtlCollection.Count > 0)
				{
					deepHandles.Add("EdCourseExpDtlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdCourseExpDtl>) DataRepository.EdCourseExpDtlProvider.DeepLoad,
						new object[] { transactionManager, entity.EdCourseExpDtlCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdCourseCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdCourse>|EdCourseCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCourseCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdCourseCollection = DataRepository.EdCourseProvider.GetByEdCourseExpHdrId(transactionManager, entity.EdCourseExpHdrId);

				if (deep && entity.EdCourseCollection.Count > 0)
				{
					deepHandles.Add("EdCourseCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdCourse>) DataRepository.EdCourseProvider.DeepLoad,
						new object[] { transactionManager, entity.EdCourseCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdCourseExpHdr object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdCourseExpHdr instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCourseExpHdr Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCourseExpHdr entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<EntCoursePkgDtl>
				if (CanDeepSave(entity.EntCoursePkgDtlCollectionGetByEdCourseExpPrereqHdrId, "List<EntCoursePkgDtl>|EntCoursePkgDtlCollectionGetByEdCourseExpPrereqHdrId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntCoursePkgDtl child in entity.EntCoursePkgDtlCollectionGetByEdCourseExpPrereqHdrId)
					{
						if(child.EdCourseExpPrereqHdrIdSource != null)
						{
							child.EdCourseExpPrereqHdrId = child.EdCourseExpPrereqHdrIdSource.EdCourseExpHdrId;
						}
						else
						{
							child.EdCourseExpPrereqHdrId = entity.EdCourseExpHdrId;
						}

					}

					if (entity.EntCoursePkgDtlCollectionGetByEdCourseExpPrereqHdrId.Count > 0 || entity.EntCoursePkgDtlCollectionGetByEdCourseExpPrereqHdrId.DeletedItems.Count > 0)
					{
						//DataRepository.EntCoursePkgDtlProvider.Save(transactionManager, entity.EntCoursePkgDtlCollectionGetByEdCourseExpPrereqHdrId);
						
						deepHandles.Add("EntCoursePkgDtlCollectionGetByEdCourseExpPrereqHdrId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntCoursePkgDtl >) DataRepository.EntCoursePkgDtlProvider.DeepSave,
							new object[] { transactionManager, entity.EntCoursePkgDtlCollectionGetByEdCourseExpPrereqHdrId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntCoursePkgDtl>
				if (CanDeepSave(entity.EntCoursePkgDtlCollectionGetByEdCourseExpHdrId, "List<EntCoursePkgDtl>|EntCoursePkgDtlCollectionGetByEdCourseExpHdrId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntCoursePkgDtl child in entity.EntCoursePkgDtlCollectionGetByEdCourseExpHdrId)
					{
						if(child.EdCourseExpHdrIdSource != null)
						{
							child.EdCourseExpHdrId = child.EdCourseExpHdrIdSource.EdCourseExpHdrId;
						}
						else
						{
							child.EdCourseExpHdrId = entity.EdCourseExpHdrId;
						}

					}

					if (entity.EntCoursePkgDtlCollectionGetByEdCourseExpHdrId.Count > 0 || entity.EntCoursePkgDtlCollectionGetByEdCourseExpHdrId.DeletedItems.Count > 0)
					{
						//DataRepository.EntCoursePkgDtlProvider.Save(transactionManager, entity.EntCoursePkgDtlCollectionGetByEdCourseExpHdrId);
						
						deepHandles.Add("EntCoursePkgDtlCollectionGetByEdCourseExpHdrId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntCoursePkgDtl >) DataRepository.EntCoursePkgDtlProvider.DeepSave,
							new object[] { transactionManager, entity.EntCoursePkgDtlCollectionGetByEdCourseExpHdrId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdAcadPlanDtl>
				if (CanDeepSave(entity.EdAcadPlanDtlCollection, "List<EdAcadPlanDtl>|EdAcadPlanDtlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdAcadPlanDtl child in entity.EdAcadPlanDtlCollection)
					{
						if(child.EdCourseExpHdrIdSource != null)
						{
							child.EdCourseExpHdrId = child.EdCourseExpHdrIdSource.EdCourseExpHdrId;
						}
						else
						{
							child.EdCourseExpHdrId = entity.EdCourseExpHdrId;
						}

					}

					if (entity.EdAcadPlanDtlCollection.Count > 0 || entity.EdAcadPlanDtlCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdAcadPlanDtlProvider.Save(transactionManager, entity.EdAcadPlanDtlCollection);
						
						deepHandles.Add("EdAcadPlanDtlCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdAcadPlanDtl >) DataRepository.EdAcadPlanDtlProvider.DeepSave,
							new object[] { transactionManager, entity.EdAcadPlanDtlCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdCourseExpDtl>
				if (CanDeepSave(entity.EdCourseExpDtlCollection, "List<EdCourseExpDtl>|EdCourseExpDtlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdCourseExpDtl child in entity.EdCourseExpDtlCollection)
					{
						if(child.EdCourseExpHdrIdSource != null)
						{
							child.EdCourseExpHdrId = child.EdCourseExpHdrIdSource.EdCourseExpHdrId;
						}
						else
						{
							child.EdCourseExpHdrId = entity.EdCourseExpHdrId;
						}

					}

					if (entity.EdCourseExpDtlCollection.Count > 0 || entity.EdCourseExpDtlCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdCourseExpDtlProvider.Save(transactionManager, entity.EdCourseExpDtlCollection);
						
						deepHandles.Add("EdCourseExpDtlCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdCourseExpDtl >) DataRepository.EdCourseExpDtlProvider.DeepSave,
							new object[] { transactionManager, entity.EdCourseExpDtlCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdCourse>
				if (CanDeepSave(entity.EdCourseCollection, "List<EdCourse>|EdCourseCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdCourse child in entity.EdCourseCollection)
					{
						if(child.EdCourseExpHdrIdSource != null)
						{
							child.EdCourseExpHdrId = child.EdCourseExpHdrIdSource.EdCourseExpHdrId;
						}
						else
						{
							child.EdCourseExpHdrId = entity.EdCourseExpHdrId;
						}

					}

					if (entity.EdCourseCollection.Count > 0 || entity.EdCourseCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdCourseProvider.Save(transactionManager, entity.EdCourseCollection);
						
						deepHandles.Add("EdCourseCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdCourse >) DataRepository.EdCourseProvider.DeepSave,
							new object[] { transactionManager, entity.EdCourseCollection, deepSaveType, childTypes, innerList }
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
	
	#region EdCourseExpHdrChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdCourseExpHdr</c>
	///</summary>
	public enum EdCourseExpHdrChildEntityTypes
	{
		///<summary>
		/// Collection of <c>EdCourseExpHdr</c> as OneToMany for EntCoursePkgDtlCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntCoursePkgDtl>))]
		EntCoursePkgDtlCollectionGetByEdCourseExpPrereqHdrId,
		///<summary>
		/// Collection of <c>EdCourseExpHdr</c> as OneToMany for EntCoursePkgDtlCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntCoursePkgDtl>))]
		EntCoursePkgDtlCollectionGetByEdCourseExpHdrId,
		///<summary>
		/// Collection of <c>EdCourseExpHdr</c> as OneToMany for EdAcadPlanDtlCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdAcadPlanDtl>))]
		EdAcadPlanDtlCollection,
		///<summary>
		/// Collection of <c>EdCourseExpHdr</c> as OneToMany for EdCourseExpDtlCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdCourseExpDtl>))]
		EdCourseExpDtlCollection,
		///<summary>
		/// Collection of <c>EdCourseExpHdr</c> as OneToMany for EdCourseCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdCourse>))]
		EdCourseCollection,
	}
	
	#endregion EdCourseExpHdrChildEntityTypes
	
	#region EdCourseExpHdrFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdCourseExpHdrColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCourseExpHdr"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCourseExpHdrFilterBuilder : SqlFilterBuilder<EdCourseExpHdrColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCourseExpHdrFilterBuilder class.
		/// </summary>
		public EdCourseExpHdrFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCourseExpHdrFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCourseExpHdrFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCourseExpHdrFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCourseExpHdrFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCourseExpHdrFilterBuilder
	
	#region EdCourseExpHdrParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdCourseExpHdrColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCourseExpHdr"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCourseExpHdrParameterBuilder : ParameterizedSqlFilterBuilder<EdCourseExpHdrColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCourseExpHdrParameterBuilder class.
		/// </summary>
		public EdCourseExpHdrParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCourseExpHdrParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCourseExpHdrParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCourseExpHdrParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCourseExpHdrParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCourseExpHdrParameterBuilder
	
	#region EdCourseExpHdrSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdCourseExpHdrColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCourseExpHdr"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdCourseExpHdrSortBuilder : SqlSortBuilder<EdCourseExpHdrColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCourseExpHdrSqlSortBuilder class.
		/// </summary>
		public EdCourseExpHdrSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdCourseExpHdrSortBuilder
	
} // end namespace
