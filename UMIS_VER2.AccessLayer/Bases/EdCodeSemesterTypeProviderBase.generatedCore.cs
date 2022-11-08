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
	/// This class is the base class for any <see cref="EdCodeSemesterTypeProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdCodeSemesterTypeProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdCodeSemesterType, UMIS_VER2.BusinessLyer.EdCodeSemesterTypeKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeSemesterTypeKey key)
		{
			return Delete(transactionManager, key.EdCodeSemesterTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edCodeSemesterTypeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edCodeSemesterTypeId)
		{
			return Delete(null, _edCodeSemesterTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterTypeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edCodeSemesterTypeId);		
		
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
		public override UMIS_VER2.BusinessLyer.EdCodeSemesterType Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeSemesterTypeKey key, int start, int pageLength)
		{
			return GetByEdCodeSemesterTypeId(transactionManager, key.EdCodeSemesterTypeId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_CODE_SEMESTER_TYPE index.
		/// </summary>
		/// <param name="_edCodeSemesterTypeId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeSemesterType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeSemesterType GetByEdCodeSemesterTypeId(System.Decimal _edCodeSemesterTypeId)
		{
			int count = -1;
			return GetByEdCodeSemesterTypeId(null,_edCodeSemesterTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_SEMESTER_TYPE index.
		/// </summary>
		/// <param name="_edCodeSemesterTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeSemesterType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeSemesterType GetByEdCodeSemesterTypeId(System.Decimal _edCodeSemesterTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterTypeId(null, _edCodeSemesterTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_SEMESTER_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeSemesterType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeSemesterType GetByEdCodeSemesterTypeId(TransactionManager transactionManager, System.Decimal _edCodeSemesterTypeId)
		{
			int count = -1;
			return GetByEdCodeSemesterTypeId(transactionManager, _edCodeSemesterTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_SEMESTER_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeSemesterType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeSemesterType GetByEdCodeSemesterTypeId(TransactionManager transactionManager, System.Decimal _edCodeSemesterTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterTypeId(transactionManager, _edCodeSemesterTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_SEMESTER_TYPE index.
		/// </summary>
		/// <param name="_edCodeSemesterTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeSemesterType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeSemesterType GetByEdCodeSemesterTypeId(System.Decimal _edCodeSemesterTypeId, int start, int pageLength, out int count)
		{
			return GetByEdCodeSemesterTypeId(null, _edCodeSemesterTypeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_SEMESTER_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeSemesterType"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdCodeSemesterType GetByEdCodeSemesterTypeId(TransactionManager transactionManager, System.Decimal _edCodeSemesterTypeId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdCodeSemesterType&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdCodeSemesterType&gt;"/></returns>
		public static TList<EdCodeSemesterType> Fill(IDataReader reader, TList<EdCodeSemesterType> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdCodeSemesterType c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdCodeSemesterType")
					.Append("|").Append((System.Decimal)reader["ED_CODE_SEMESTER_TYPE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdCodeSemesterType>(
					key.ToString(), // EntityTrackingKey
					"EdCodeSemesterType",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdCodeSemesterType();
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
					c.EdCodeSemesterTypeId = (System.Decimal)reader["ED_CODE_SEMESTER_TYPE_ID"];
					c.OriginalEdCodeSemesterTypeId = c.EdCodeSemesterTypeId;
					c.DescrAr = Convert.IsDBNull(reader["DESCR_AR"]) ? null : (System.String)reader["DESCR_AR"];
					c.DescrEn = Convert.IsDBNull(reader["DESCR_EN"]) ? null : (System.String)reader["DESCR_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCodeSemesterType"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeSemesterType"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdCodeSemesterType entity)
		{
			if (!reader.Read()) return;
			
			entity.EdCodeSemesterTypeId = (System.Decimal)reader[((int)EdCodeSemesterTypeColumn.EdCodeSemesterTypeId - 1)];
			entity.OriginalEdCodeSemesterTypeId = (System.Decimal)reader["ED_CODE_SEMESTER_TYPE_ID"];
			entity.DescrAr = (reader.IsDBNull(((int)EdCodeSemesterTypeColumn.DescrAr - 1)))?null:(System.String)reader[((int)EdCodeSemesterTypeColumn.DescrAr - 1)];
			entity.DescrEn = (reader.IsDBNull(((int)EdCodeSemesterTypeColumn.DescrEn - 1)))?null:(System.String)reader[((int)EdCodeSemesterTypeColumn.DescrEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCodeSemesterType"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeSemesterType"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdCodeSemesterType entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdCodeSemesterTypeId = (System.Decimal)dataRow["ED_CODE_SEMESTER_TYPE_ID"];
			entity.OriginalEdCodeSemesterTypeId = (System.Decimal)dataRow["ED_CODE_SEMESTER_TYPE_ID"];
			entity.DescrAr = Convert.IsDBNull(dataRow["DESCR_AR"]) ? null : (System.String)dataRow["DESCR_AR"];
			entity.DescrEn = Convert.IsDBNull(dataRow["DESCR_EN"]) ? null : (System.String)dataRow["DESCR_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeSemesterType"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCodeSemesterType Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeSemesterType entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEdCodeSemesterTypeId methods when available
			
			#region EntPolicyLoadCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntPolicyLoad>|EntPolicyLoadCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPolicyLoadCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntPolicyLoadCollection = DataRepository.EntPolicyLoadProvider.GetByEdCodeSemesterTypeId(transactionManager, entity.EdCodeSemesterTypeId);

				if (deep && entity.EntPolicyLoadCollection.Count > 0)
				{
					deepHandles.Add("EntPolicyLoadCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntPolicyLoad>) DataRepository.EntPolicyLoadProvider.DeepLoad,
						new object[] { transactionManager, entity.EntPolicyLoadCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.FeeFacultyRuleCollection = DataRepository.FeeFacultyRuleProvider.GetByEdCodeSemesterTypeId(transactionManager, entity.EdCodeSemesterTypeId);

				if (deep && entity.FeeFacultyRuleCollection.Count > 0)
				{
					deepHandles.Add("FeeFacultyRuleCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeFacultyRule>) DataRepository.FeeFacultyRuleProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeFacultyRuleCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntPolicyCourseRepeatCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntPolicyCourseRepeat>|EntPolicyCourseRepeatCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPolicyCourseRepeatCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntPolicyCourseRepeatCollection = DataRepository.EntPolicyCourseRepeatProvider.GetByEdCodeSemesterTypeId(transactionManager, entity.EdCodeSemesterTypeId);

				if (deep && entity.EntPolicyCourseRepeatCollection.Count > 0)
				{
					deepHandles.Add("EntPolicyCourseRepeatCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntPolicyCourseRepeat>) DataRepository.EntPolicyCourseRepeatProvider.DeepLoad,
						new object[] { transactionManager, entity.EntPolicyCourseRepeatCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.EdSemesterOpenCollection = DataRepository.EdSemesterOpenProvider.GetByEdCodeSemesterTypeId(transactionManager, entity.EdCodeSemesterTypeId);

				if (deep && entity.EdSemesterOpenCollection.Count > 0)
				{
					deepHandles.Add("EdSemesterOpenCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdSemesterOpen>) DataRepository.EdSemesterOpenProvider.DeepLoad,
						new object[] { transactionManager, entity.EdSemesterOpenCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdCodeSemesterCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdCodeSemester>|EdCodeSemesterCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeSemesterCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdCodeSemesterCollection = DataRepository.EdCodeSemesterProvider.GetByEdCodeSemesterTypeId(transactionManager, entity.EdCodeSemesterTypeId);

				if (deep && entity.EdCodeSemesterCollection.Count > 0)
				{
					deepHandles.Add("EdCodeSemesterCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdCodeSemester>) DataRepository.EdCodeSemesterProvider.DeepLoad,
						new object[] { transactionManager, entity.EdCodeSemesterCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdCodeSemesterType object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdCodeSemesterType instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCodeSemesterType Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeSemesterType entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<EntPolicyLoad>
				if (CanDeepSave(entity.EntPolicyLoadCollection, "List<EntPolicyLoad>|EntPolicyLoadCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntPolicyLoad child in entity.EntPolicyLoadCollection)
					{
						if(child.EdCodeSemesterTypeIdSource != null)
						{
							child.EdCodeSemesterTypeId = child.EdCodeSemesterTypeIdSource.EdCodeSemesterTypeId;
						}
						else
						{
							child.EdCodeSemesterTypeId = entity.EdCodeSemesterTypeId;
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
				
	
			#region List<FeeFacultyRule>
				if (CanDeepSave(entity.FeeFacultyRuleCollection, "List<FeeFacultyRule>|FeeFacultyRuleCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeFacultyRule child in entity.FeeFacultyRuleCollection)
					{
						if(child.EdCodeSemesterTypeIdSource != null)
						{
							child.EdCodeSemesterTypeId = child.EdCodeSemesterTypeIdSource.EdCodeSemesterTypeId;
						}
						else
						{
							child.EdCodeSemesterTypeId = entity.EdCodeSemesterTypeId;
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
				
	
			#region List<EntPolicyCourseRepeat>
				if (CanDeepSave(entity.EntPolicyCourseRepeatCollection, "List<EntPolicyCourseRepeat>|EntPolicyCourseRepeatCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntPolicyCourseRepeat child in entity.EntPolicyCourseRepeatCollection)
					{
						if(child.EdCodeSemesterTypeIdSource != null)
						{
							child.EdCodeSemesterTypeId = child.EdCodeSemesterTypeIdSource.EdCodeSemesterTypeId;
						}
						else
						{
							child.EdCodeSemesterTypeId = entity.EdCodeSemesterTypeId;
						}

					}

					if (entity.EntPolicyCourseRepeatCollection.Count > 0 || entity.EntPolicyCourseRepeatCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntPolicyCourseRepeatProvider.Save(transactionManager, entity.EntPolicyCourseRepeatCollection);
						
						deepHandles.Add("EntPolicyCourseRepeatCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntPolicyCourseRepeat >) DataRepository.EntPolicyCourseRepeatProvider.DeepSave,
							new object[] { transactionManager, entity.EntPolicyCourseRepeatCollection, deepSaveType, childTypes, innerList }
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
						if(child.EdCodeSemesterTypeIdSource != null)
						{
							child.EdCodeSemesterTypeId = child.EdCodeSemesterTypeIdSource.EdCodeSemesterTypeId;
						}
						else
						{
							child.EdCodeSemesterTypeId = entity.EdCodeSemesterTypeId;
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
				
	
			#region List<EdCodeSemester>
				if (CanDeepSave(entity.EdCodeSemesterCollection, "List<EdCodeSemester>|EdCodeSemesterCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdCodeSemester child in entity.EdCodeSemesterCollection)
					{
						if(child.EdCodeSemesterTypeIdSource != null)
						{
							child.EdCodeSemesterTypeId = child.EdCodeSemesterTypeIdSource.EdCodeSemesterTypeId;
						}
						else
						{
							child.EdCodeSemesterTypeId = entity.EdCodeSemesterTypeId;
						}

					}

					if (entity.EdCodeSemesterCollection.Count > 0 || entity.EdCodeSemesterCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdCodeSemesterProvider.Save(transactionManager, entity.EdCodeSemesterCollection);
						
						deepHandles.Add("EdCodeSemesterCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdCodeSemester >) DataRepository.EdCodeSemesterProvider.DeepSave,
							new object[] { transactionManager, entity.EdCodeSemesterCollection, deepSaveType, childTypes, innerList }
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
	
	#region EdCodeSemesterTypeChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdCodeSemesterType</c>
	///</summary>
	public enum EdCodeSemesterTypeChildEntityTypes
	{
		///<summary>
		/// Collection of <c>EdCodeSemesterType</c> as OneToMany for EntPolicyLoadCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntPolicyLoad>))]
		EntPolicyLoadCollection,
		///<summary>
		/// Collection of <c>EdCodeSemesterType</c> as OneToMany for FeeFacultyRuleCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeFacultyRule>))]
		FeeFacultyRuleCollection,
		///<summary>
		/// Collection of <c>EdCodeSemesterType</c> as OneToMany for EntPolicyCourseRepeatCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntPolicyCourseRepeat>))]
		EntPolicyCourseRepeatCollection,
		///<summary>
		/// Collection of <c>EdCodeSemesterType</c> as OneToMany for EdSemesterOpenCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdSemesterOpen>))]
		EdSemesterOpenCollection,
		///<summary>
		/// Collection of <c>EdCodeSemesterType</c> as OneToMany for EdCodeSemesterCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdCodeSemester>))]
		EdCodeSemesterCollection,
	}
	
	#endregion EdCodeSemesterTypeChildEntityTypes
	
	#region EdCodeSemesterTypeFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdCodeSemesterTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeSemesterType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCodeSemesterTypeFilterBuilder : SqlFilterBuilder<EdCodeSemesterTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeSemesterTypeFilterBuilder class.
		/// </summary>
		public EdCodeSemesterTypeFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCodeSemesterTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCodeSemesterTypeFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCodeSemesterTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCodeSemesterTypeFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCodeSemesterTypeFilterBuilder
	
	#region EdCodeSemesterTypeParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdCodeSemesterTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeSemesterType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCodeSemesterTypeParameterBuilder : ParameterizedSqlFilterBuilder<EdCodeSemesterTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeSemesterTypeParameterBuilder class.
		/// </summary>
		public EdCodeSemesterTypeParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCodeSemesterTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCodeSemesterTypeParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCodeSemesterTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCodeSemesterTypeParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCodeSemesterTypeParameterBuilder
	
	#region EdCodeSemesterTypeSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdCodeSemesterTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeSemesterType"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdCodeSemesterTypeSortBuilder : SqlSortBuilder<EdCodeSemesterTypeColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeSemesterTypeSqlSortBuilder class.
		/// </summary>
		public EdCodeSemesterTypeSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdCodeSemesterTypeSortBuilder
	
} // end namespace
