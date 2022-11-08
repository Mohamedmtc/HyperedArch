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
	/// This class is the base class for any <see cref="GsCdeHonorProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GsCdeHonorProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.GsCdeHonor, UMIS_VER2.BusinessLyer.GsCdeHonorKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeHonorKey key)
		{
			return Delete(transactionManager, key.GsCdeHonorId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_gsCdeHonorId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _gsCdeHonorId)
		{
			return Delete(null, _gsCdeHonorId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeHonorId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _gsCdeHonorId);		
		
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
		public override UMIS_VER2.BusinessLyer.GsCdeHonor Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeHonorKey key, int start, int pageLength)
		{
			return GetByGsCdeHonorId(transactionManager, key.GsCdeHonorId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_GS_CDE_HONOR index.
		/// </summary>
		/// <param name="_gsCdeHonorId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeHonor"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeHonor GetByGsCdeHonorId(System.Decimal _gsCdeHonorId)
		{
			int count = -1;
			return GetByGsCdeHonorId(null,_gsCdeHonorId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_HONOR index.
		/// </summary>
		/// <param name="_gsCdeHonorId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeHonor"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeHonor GetByGsCdeHonorId(System.Decimal _gsCdeHonorId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeHonorId(null, _gsCdeHonorId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_HONOR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeHonorId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeHonor"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeHonor GetByGsCdeHonorId(TransactionManager transactionManager, System.Decimal _gsCdeHonorId)
		{
			int count = -1;
			return GetByGsCdeHonorId(transactionManager, _gsCdeHonorId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_HONOR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeHonorId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeHonor"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeHonor GetByGsCdeHonorId(TransactionManager transactionManager, System.Decimal _gsCdeHonorId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeHonorId(transactionManager, _gsCdeHonorId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_HONOR index.
		/// </summary>
		/// <param name="_gsCdeHonorId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeHonor"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeHonor GetByGsCdeHonorId(System.Decimal _gsCdeHonorId, int start, int pageLength, out int count)
		{
			return GetByGsCdeHonorId(null, _gsCdeHonorId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_HONOR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeHonorId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeHonor"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsCdeHonor GetByGsCdeHonorId(TransactionManager transactionManager, System.Decimal _gsCdeHonorId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GsCdeHonor&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GsCdeHonor&gt;"/></returns>
		public static TList<GsCdeHonor> Fill(IDataReader reader, TList<GsCdeHonor> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.GsCdeHonor c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GsCdeHonor")
					.Append("|").Append((System.Decimal)reader["GS_CDE_HONOR_ID"]).ToString();
					c = EntityManager.LocateOrCreate<GsCdeHonor>(
					key.ToString(), // EntityTrackingKey
					"GsCdeHonor",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.GsCdeHonor();
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
					c.GsCdeHonorId = (System.Decimal)reader["GS_CDE_HONOR_ID"];
					c.OriginalGsCdeHonorId = c.GsCdeHonorId;
					c.HonorCode = Convert.IsDBNull(reader["HONOR_CODE"]) ? null : (System.String)reader["HONOR_CODE"];
					c.HonorAr = Convert.IsDBNull(reader["HONOR_AR"]) ? null : (System.String)reader["HONOR_AR"];
					c.HonorEn = Convert.IsDBNull(reader["HONOR_EN"]) ? null : (System.String)reader["HONOR_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCdeHonor"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCdeHonor"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.GsCdeHonor entity)
		{
			if (!reader.Read()) return;
			
			entity.GsCdeHonorId = (System.Decimal)reader[((int)GsCdeHonorColumn.GsCdeHonorId - 1)];
			entity.OriginalGsCdeHonorId = (System.Decimal)reader["GS_CDE_HONOR_ID"];
			entity.HonorCode = (reader.IsDBNull(((int)GsCdeHonorColumn.HonorCode - 1)))?null:(System.String)reader[((int)GsCdeHonorColumn.HonorCode - 1)];
			entity.HonorAr = (reader.IsDBNull(((int)GsCdeHonorColumn.HonorAr - 1)))?null:(System.String)reader[((int)GsCdeHonorColumn.HonorAr - 1)];
			entity.HonorEn = (reader.IsDBNull(((int)GsCdeHonorColumn.HonorEn - 1)))?null:(System.String)reader[((int)GsCdeHonorColumn.HonorEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCdeHonor"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCdeHonor"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.GsCdeHonor entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.GsCdeHonorId = (System.Decimal)dataRow["GS_CDE_HONOR_ID"];
			entity.OriginalGsCdeHonorId = (System.Decimal)dataRow["GS_CDE_HONOR_ID"];
			entity.HonorCode = Convert.IsDBNull(dataRow["HONOR_CODE"]) ? null : (System.String)dataRow["HONOR_CODE"];
			entity.HonorAr = Convert.IsDBNull(dataRow["HONOR_AR"]) ? null : (System.String)dataRow["HONOR_AR"];
			entity.HonorEn = Convert.IsDBNull(dataRow["HONOR_EN"]) ? null : (System.String)dataRow["HONOR_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCdeHonor"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCdeHonor Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeHonor entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByGsCdeHonorId methods when available
			
			#region PgThesisGrantStudCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgThesisGrantStud>|PgThesisGrantStudCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisGrantStudCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgThesisGrantStudCollection = DataRepository.PgThesisGrantStudProvider.GetByGsCdeHonorId(transactionManager, entity.GsCdeHonorId);

				if (deep && entity.PgThesisGrantStudCollection.Count > 0)
				{
					deepHandles.Add("PgThesisGrantStudCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgThesisGrantStud>) DataRepository.PgThesisGrantStudProvider.DeepLoad,
						new object[] { transactionManager, entity.PgThesisGrantStudCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntPolicySemHonorCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntPolicySemHonor>|EntPolicySemHonorCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPolicySemHonorCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntPolicySemHonorCollection = DataRepository.EntPolicySemHonorProvider.GetByGsCdeHonorId(transactionManager, entity.GsCdeHonorId);

				if (deep && entity.EntPolicySemHonorCollection.Count > 0)
				{
					deepHandles.Add("EntPolicySemHonorCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntPolicySemHonor>) DataRepository.EntPolicySemHonorProvider.DeepLoad,
						new object[] { transactionManager, entity.EntPolicySemHonorCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntPolicyAccumHonorCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntPolicyAccumHonor>|EntPolicyAccumHonorCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPolicyAccumHonorCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntPolicyAccumHonorCollection = DataRepository.EntPolicyAccumHonorProvider.GetByGsCdeHonorId(transactionManager, entity.GsCdeHonorId);

				if (deep && entity.EntPolicyAccumHonorCollection.Count > 0)
				{
					deepHandles.Add("EntPolicyAccumHonorCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntPolicyAccumHonor>) DataRepository.EntPolicyAccumHonorProvider.DeepLoad,
						new object[] { transactionManager, entity.EntPolicyAccumHonorCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudFacultyCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudFaculty>|EdStudFacultyCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudFacultyCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudFacultyCollection = DataRepository.EdStudFacultyProvider.GetByGsCdeHonorId(transactionManager, entity.GsCdeHonorId);

				if (deep && entity.EdStudFacultyCollection.Count > 0)
				{
					deepHandles.Add("EdStudFacultyCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudFaculty>) DataRepository.EdStudFacultyProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudFacultyCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.EdStudSemesterCollection = DataRepository.EdStudSemesterProvider.GetByGsCdeHonorId(transactionManager, entity.GsCdeHonorId);

				if (deep && entity.EdStudSemesterCollection.Count > 0)
				{
					deepHandles.Add("EdStudSemesterCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudSemester>) DataRepository.EdStudSemesterProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudSemesterCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region PgThesisStudCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgThesisStud>|PgThesisStudCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisStudCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgThesisStudCollection = DataRepository.PgThesisStudProvider.GetByGsCdeHonorId(transactionManager, entity.GsCdeHonorId);

				if (deep && entity.PgThesisStudCollection.Count > 0)
				{
					deepHandles.Add("PgThesisStudCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgThesisStud>) DataRepository.PgThesisStudProvider.DeepLoad,
						new object[] { transactionManager, entity.PgThesisStudCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.GsCdeHonor object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.GsCdeHonor instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCdeHonor Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeHonor entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<PgThesisGrantStud>
				if (CanDeepSave(entity.PgThesisGrantStudCollection, "List<PgThesisGrantStud>|PgThesisGrantStudCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgThesisGrantStud child in entity.PgThesisGrantStudCollection)
					{
						if(child.GsCdeHonorIdSource != null)
						{
							child.GsCdeHonorId = child.GsCdeHonorIdSource.GsCdeHonorId;
						}
						else
						{
							child.GsCdeHonorId = entity.GsCdeHonorId;
						}

					}

					if (entity.PgThesisGrantStudCollection.Count > 0 || entity.PgThesisGrantStudCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgThesisGrantStudProvider.Save(transactionManager, entity.PgThesisGrantStudCollection);
						
						deepHandles.Add("PgThesisGrantStudCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgThesisGrantStud >) DataRepository.PgThesisGrantStudProvider.DeepSave,
							new object[] { transactionManager, entity.PgThesisGrantStudCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntPolicySemHonor>
				if (CanDeepSave(entity.EntPolicySemHonorCollection, "List<EntPolicySemHonor>|EntPolicySemHonorCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntPolicySemHonor child in entity.EntPolicySemHonorCollection)
					{
						if(child.GsCdeHonorIdSource != null)
						{
							child.GsCdeHonorId = child.GsCdeHonorIdSource.GsCdeHonorId;
						}
						else
						{
							child.GsCdeHonorId = entity.GsCdeHonorId;
						}

					}

					if (entity.EntPolicySemHonorCollection.Count > 0 || entity.EntPolicySemHonorCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntPolicySemHonorProvider.Save(transactionManager, entity.EntPolicySemHonorCollection);
						
						deepHandles.Add("EntPolicySemHonorCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntPolicySemHonor >) DataRepository.EntPolicySemHonorProvider.DeepSave,
							new object[] { transactionManager, entity.EntPolicySemHonorCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntPolicyAccumHonor>
				if (CanDeepSave(entity.EntPolicyAccumHonorCollection, "List<EntPolicyAccumHonor>|EntPolicyAccumHonorCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntPolicyAccumHonor child in entity.EntPolicyAccumHonorCollection)
					{
						if(child.GsCdeHonorIdSource != null)
						{
							child.GsCdeHonorId = child.GsCdeHonorIdSource.GsCdeHonorId;
						}
						else
						{
							child.GsCdeHonorId = entity.GsCdeHonorId;
						}

					}

					if (entity.EntPolicyAccumHonorCollection.Count > 0 || entity.EntPolicyAccumHonorCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntPolicyAccumHonorProvider.Save(transactionManager, entity.EntPolicyAccumHonorCollection);
						
						deepHandles.Add("EntPolicyAccumHonorCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntPolicyAccumHonor >) DataRepository.EntPolicyAccumHonorProvider.DeepSave,
							new object[] { transactionManager, entity.EntPolicyAccumHonorCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudFaculty>
				if (CanDeepSave(entity.EdStudFacultyCollection, "List<EdStudFaculty>|EdStudFacultyCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudFaculty child in entity.EdStudFacultyCollection)
					{
						if(child.GsCdeHonorIdSource != null)
						{
							child.GsCdeHonorId = child.GsCdeHonorIdSource.GsCdeHonorId;
						}
						else
						{
							child.GsCdeHonorId = entity.GsCdeHonorId;
						}

					}

					if (entity.EdStudFacultyCollection.Count > 0 || entity.EdStudFacultyCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudFacultyProvider.Save(transactionManager, entity.EdStudFacultyCollection);
						
						deepHandles.Add("EdStudFacultyCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudFaculty >) DataRepository.EdStudFacultyProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudFacultyCollection, deepSaveType, childTypes, innerList }
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
						if(child.GsCdeHonorIdSource != null)
						{
							child.GsCdeHonorId = child.GsCdeHonorIdSource.GsCdeHonorId;
						}
						else
						{
							child.GsCdeHonorId = entity.GsCdeHonorId;
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
				
	
			#region List<PgThesisStud>
				if (CanDeepSave(entity.PgThesisStudCollection, "List<PgThesisStud>|PgThesisStudCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgThesisStud child in entity.PgThesisStudCollection)
					{
						if(child.GsCdeHonorIdSource != null)
						{
							child.GsCdeHonorId = child.GsCdeHonorIdSource.GsCdeHonorId;
						}
						else
						{
							child.GsCdeHonorId = entity.GsCdeHonorId;
						}

					}

					if (entity.PgThesisStudCollection.Count > 0 || entity.PgThesisStudCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgThesisStudProvider.Save(transactionManager, entity.PgThesisStudCollection);
						
						deepHandles.Add("PgThesisStudCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgThesisStud >) DataRepository.PgThesisStudProvider.DeepSave,
							new object[] { transactionManager, entity.PgThesisStudCollection, deepSaveType, childTypes, innerList }
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
	
	#region GsCdeHonorChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.GsCdeHonor</c>
	///</summary>
	public enum GsCdeHonorChildEntityTypes
	{
		///<summary>
		/// Collection of <c>GsCdeHonor</c> as OneToMany for PgThesisGrantStudCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgThesisGrantStud>))]
		PgThesisGrantStudCollection,
		///<summary>
		/// Collection of <c>GsCdeHonor</c> as OneToMany for EntPolicySemHonorCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntPolicySemHonor>))]
		EntPolicySemHonorCollection,
		///<summary>
		/// Collection of <c>GsCdeHonor</c> as OneToMany for EntPolicyAccumHonorCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntPolicyAccumHonor>))]
		EntPolicyAccumHonorCollection,
		///<summary>
		/// Collection of <c>GsCdeHonor</c> as OneToMany for EdStudFacultyCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudFaculty>))]
		EdStudFacultyCollection,
		///<summary>
		/// Collection of <c>GsCdeHonor</c> as OneToMany for EdStudSemesterCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudSemester>))]
		EdStudSemesterCollection,
		///<summary>
		/// Collection of <c>GsCdeHonor</c> as OneToMany for PgThesisStudCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgThesisStud>))]
		PgThesisStudCollection,
	}
	
	#endregion GsCdeHonorChildEntityTypes
	
	#region GsCdeHonorFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GsCdeHonorColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCdeHonor"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCdeHonorFilterBuilder : SqlFilterBuilder<GsCdeHonorColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCdeHonorFilterBuilder class.
		/// </summary>
		public GsCdeHonorFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCdeHonorFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCdeHonorFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCdeHonorFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCdeHonorFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCdeHonorFilterBuilder
	
	#region GsCdeHonorParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GsCdeHonorColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCdeHonor"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCdeHonorParameterBuilder : ParameterizedSqlFilterBuilder<GsCdeHonorColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCdeHonorParameterBuilder class.
		/// </summary>
		public GsCdeHonorParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCdeHonorParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCdeHonorParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCdeHonorParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCdeHonorParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCdeHonorParameterBuilder
	
	#region GsCdeHonorSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GsCdeHonorColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCdeHonor"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GsCdeHonorSortBuilder : SqlSortBuilder<GsCdeHonorColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCdeHonorSqlSortBuilder class.
		/// </summary>
		public GsCdeHonorSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GsCdeHonorSortBuilder
	
} // end namespace
