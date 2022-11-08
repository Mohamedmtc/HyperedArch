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
	/// This class is the base class for any <see cref="PgCdeStfRoleProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class PgCdeStfRoleProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.PgCdeStfRole, UMIS_VER2.BusinessLyer.PgCdeStfRoleKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgCdeStfRoleKey key)
		{
			return Delete(transactionManager, key.PgCdeStfRoleId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_pgCdeStfRoleId">دور العضو فى لجنه الاشراف على الرسالة. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _pgCdeStfRoleId)
		{
			return Delete(null, _pgCdeStfRoleId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgCdeStfRoleId">دور العضو فى لجنه الاشراف على الرسالة. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _pgCdeStfRoleId);		
		
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
		public override UMIS_VER2.BusinessLyer.PgCdeStfRole Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgCdeStfRoleKey key, int start, int pageLength)
		{
			return GetByPgCdeStfRoleId(transactionManager, key.PgCdeStfRoleId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_PG_CDE_STF_ROLE index.
		/// </summary>
		/// <param name="_pgCdeStfRoleId">دور العضو فى لجنه الاشراف على الرسالة</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgCdeStfRole"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgCdeStfRole GetByPgCdeStfRoleId(System.Int32 _pgCdeStfRoleId)
		{
			int count = -1;
			return GetByPgCdeStfRoleId(null,_pgCdeStfRoleId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_CDE_STF_ROLE index.
		/// </summary>
		/// <param name="_pgCdeStfRoleId">دور العضو فى لجنه الاشراف على الرسالة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgCdeStfRole"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgCdeStfRole GetByPgCdeStfRoleId(System.Int32 _pgCdeStfRoleId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgCdeStfRoleId(null, _pgCdeStfRoleId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_CDE_STF_ROLE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgCdeStfRoleId">دور العضو فى لجنه الاشراف على الرسالة</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgCdeStfRole"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgCdeStfRole GetByPgCdeStfRoleId(TransactionManager transactionManager, System.Int32 _pgCdeStfRoleId)
		{
			int count = -1;
			return GetByPgCdeStfRoleId(transactionManager, _pgCdeStfRoleId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_CDE_STF_ROLE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgCdeStfRoleId">دور العضو فى لجنه الاشراف على الرسالة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgCdeStfRole"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgCdeStfRole GetByPgCdeStfRoleId(TransactionManager transactionManager, System.Int32 _pgCdeStfRoleId, int start, int pageLength)
		{
			int count = -1;
			return GetByPgCdeStfRoleId(transactionManager, _pgCdeStfRoleId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_CDE_STF_ROLE index.
		/// </summary>
		/// <param name="_pgCdeStfRoleId">دور العضو فى لجنه الاشراف على الرسالة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgCdeStfRole"/> class.</returns>
		public UMIS_VER2.BusinessLyer.PgCdeStfRole GetByPgCdeStfRoleId(System.Int32 _pgCdeStfRoleId, int start, int pageLength, out int count)
		{
			return GetByPgCdeStfRoleId(null, _pgCdeStfRoleId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_PG_CDE_STF_ROLE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pgCdeStfRoleId">دور العضو فى لجنه الاشراف على الرسالة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.PgCdeStfRole"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.PgCdeStfRole GetByPgCdeStfRoleId(TransactionManager transactionManager, System.Int32 _pgCdeStfRoleId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;PgCdeStfRole&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;PgCdeStfRole&gt;"/></returns>
		public static TList<PgCdeStfRole> Fill(IDataReader reader, TList<PgCdeStfRole> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.PgCdeStfRole c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("PgCdeStfRole")
					.Append("|").Append((System.Int32)reader["PG_CDE_STF_ROLE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<PgCdeStfRole>(
					key.ToString(), // EntityTrackingKey
					"PgCdeStfRole",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.PgCdeStfRole();
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
					c.PgCdeStfRoleId = (System.Int32)reader["PG_CDE_STF_ROLE_ID"];
					c.OriginalPgCdeStfRoleId = c.PgCdeStfRoleId;
					c.StfRoleAr = Convert.IsDBNull(reader["STF_ROLE_AR"]) ? null : (System.String)reader["STF_ROLE_AR"];
					c.StfRoleEn = Convert.IsDBNull(reader["STF_ROLE_EN"]) ? null : (System.String)reader["STF_ROLE_EN"];
					c.MaxStudCount = Convert.IsDBNull(reader["MAX_STUD_COUNT"]) ? null : (System.Int32?)reader["MAX_STUD_COUNT"];
					c.ExternalFlg = Convert.IsDBNull(reader["EXTERNAL_FLG"]) ? null : (System.Boolean?)reader["EXTERNAL_FLG"];
					c.RoleTypeFlg = Convert.IsDBNull(reader["ROLE_TYPE_FLG"]) ? null : (System.Int16?)reader["ROLE_TYPE_FLG"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.PgCdeStfRole"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgCdeStfRole"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.PgCdeStfRole entity)
		{
			if (!reader.Read()) return;
			
			entity.PgCdeStfRoleId = (System.Int32)reader[((int)PgCdeStfRoleColumn.PgCdeStfRoleId - 1)];
			entity.OriginalPgCdeStfRoleId = (System.Int32)reader["PG_CDE_STF_ROLE_ID"];
			entity.StfRoleAr = (reader.IsDBNull(((int)PgCdeStfRoleColumn.StfRoleAr - 1)))?null:(System.String)reader[((int)PgCdeStfRoleColumn.StfRoleAr - 1)];
			entity.StfRoleEn = (reader.IsDBNull(((int)PgCdeStfRoleColumn.StfRoleEn - 1)))?null:(System.String)reader[((int)PgCdeStfRoleColumn.StfRoleEn - 1)];
			entity.MaxStudCount = (reader.IsDBNull(((int)PgCdeStfRoleColumn.MaxStudCount - 1)))?null:(System.Int32?)reader[((int)PgCdeStfRoleColumn.MaxStudCount - 1)];
			entity.ExternalFlg = (reader.IsDBNull(((int)PgCdeStfRoleColumn.ExternalFlg - 1)))?null:(System.Boolean?)reader[((int)PgCdeStfRoleColumn.ExternalFlg - 1)];
			entity.RoleTypeFlg = (reader.IsDBNull(((int)PgCdeStfRoleColumn.RoleTypeFlg - 1)))?null:(System.Int16?)reader[((int)PgCdeStfRoleColumn.RoleTypeFlg - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.PgCdeStfRole"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgCdeStfRole"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.PgCdeStfRole entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.PgCdeStfRoleId = (System.Int32)dataRow["PG_CDE_STF_ROLE_ID"];
			entity.OriginalPgCdeStfRoleId = (System.Int32)dataRow["PG_CDE_STF_ROLE_ID"];
			entity.StfRoleAr = Convert.IsDBNull(dataRow["STF_ROLE_AR"]) ? null : (System.String)dataRow["STF_ROLE_AR"];
			entity.StfRoleEn = Convert.IsDBNull(dataRow["STF_ROLE_EN"]) ? null : (System.String)dataRow["STF_ROLE_EN"];
			entity.MaxStudCount = Convert.IsDBNull(dataRow["MAX_STUD_COUNT"]) ? null : (System.Int32?)dataRow["MAX_STUD_COUNT"];
			entity.ExternalFlg = Convert.IsDBNull(dataRow["EXTERNAL_FLG"]) ? null : (System.Boolean?)dataRow["EXTERNAL_FLG"];
			entity.RoleTypeFlg = Convert.IsDBNull(dataRow["ROLE_TYPE_FLG"]) ? null : (System.Int16?)dataRow["ROLE_TYPE_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.PgCdeStfRole"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.PgCdeStfRole Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgCdeStfRole entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByPgCdeStfRoleId methods when available
			
			#region PgStfRoleDegCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgStfRoleDeg>|PgStfRoleDegCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgStfRoleDegCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgStfRoleDegCollection = DataRepository.PgStfRoleDegProvider.GetByPgCdeStfRoleId(transactionManager, entity.PgCdeStfRoleId);

				if (deep && entity.PgStfRoleDegCollection.Count > 0)
				{
					deepHandles.Add("PgStfRoleDegCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgStfRoleDeg>) DataRepository.PgStfRoleDegProvider.DeepLoad,
						new object[] { transactionManager, entity.PgStfRoleDegCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region PgThesisStaffCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgThesisStaff>|PgThesisStaffCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisStaffCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgThesisStaffCollection = DataRepository.PgThesisStaffProvider.GetByPgCdeStfRoleId(transactionManager, entity.PgCdeStfRoleId);

				if (deep && entity.PgThesisStaffCollection.Count > 0)
				{
					deepHandles.Add("PgThesisStaffCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgThesisStaff>) DataRepository.PgThesisStaffProvider.DeepLoad,
						new object[] { transactionManager, entity.PgThesisStaffCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region PgThesisCommMemberCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgThesisCommMember>|PgThesisCommMemberCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisCommMemberCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgThesisCommMemberCollection = DataRepository.PgThesisCommMemberProvider.GetByPgCdeStfRoleId(transactionManager, entity.PgCdeStfRoleId);

				if (deep && entity.PgThesisCommMemberCollection.Count > 0)
				{
					deepHandles.Add("PgThesisCommMemberCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgThesisCommMember>) DataRepository.PgThesisCommMemberProvider.DeepLoad,
						new object[] { transactionManager, entity.PgThesisCommMemberCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.PgCdeStfRole object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.PgCdeStfRole instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.PgCdeStfRole Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.PgCdeStfRole entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<PgStfRoleDeg>
				if (CanDeepSave(entity.PgStfRoleDegCollection, "List<PgStfRoleDeg>|PgStfRoleDegCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgStfRoleDeg child in entity.PgStfRoleDegCollection)
					{
						if(child.PgCdeStfRoleIdSource != null)
						{
							child.PgCdeStfRoleId = child.PgCdeStfRoleIdSource.PgCdeStfRoleId;
						}
						else
						{
							child.PgCdeStfRoleId = entity.PgCdeStfRoleId;
						}

					}

					if (entity.PgStfRoleDegCollection.Count > 0 || entity.PgStfRoleDegCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgStfRoleDegProvider.Save(transactionManager, entity.PgStfRoleDegCollection);
						
						deepHandles.Add("PgStfRoleDegCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgStfRoleDeg >) DataRepository.PgStfRoleDegProvider.DeepSave,
							new object[] { transactionManager, entity.PgStfRoleDegCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<PgThesisStaff>
				if (CanDeepSave(entity.PgThesisStaffCollection, "List<PgThesisStaff>|PgThesisStaffCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgThesisStaff child in entity.PgThesisStaffCollection)
					{
						if(child.PgCdeStfRoleIdSource != null)
						{
							child.PgCdeStfRoleId = child.PgCdeStfRoleIdSource.PgCdeStfRoleId;
						}
						else
						{
							child.PgCdeStfRoleId = entity.PgCdeStfRoleId;
						}

					}

					if (entity.PgThesisStaffCollection.Count > 0 || entity.PgThesisStaffCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgThesisStaffProvider.Save(transactionManager, entity.PgThesisStaffCollection);
						
						deepHandles.Add("PgThesisStaffCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgThesisStaff >) DataRepository.PgThesisStaffProvider.DeepSave,
							new object[] { transactionManager, entity.PgThesisStaffCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<PgThesisCommMember>
				if (CanDeepSave(entity.PgThesisCommMemberCollection, "List<PgThesisCommMember>|PgThesisCommMemberCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgThesisCommMember child in entity.PgThesisCommMemberCollection)
					{
						if(child.PgCdeStfRoleIdSource != null)
						{
							child.PgCdeStfRoleId = child.PgCdeStfRoleIdSource.PgCdeStfRoleId;
						}
						else
						{
							child.PgCdeStfRoleId = entity.PgCdeStfRoleId;
						}

					}

					if (entity.PgThesisCommMemberCollection.Count > 0 || entity.PgThesisCommMemberCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgThesisCommMemberProvider.Save(transactionManager, entity.PgThesisCommMemberCollection);
						
						deepHandles.Add("PgThesisCommMemberCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgThesisCommMember >) DataRepository.PgThesisCommMemberProvider.DeepSave,
							new object[] { transactionManager, entity.PgThesisCommMemberCollection, deepSaveType, childTypes, innerList }
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
	
	#region PgCdeStfRoleChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.PgCdeStfRole</c>
	///</summary>
	public enum PgCdeStfRoleChildEntityTypes
	{
		///<summary>
		/// Collection of <c>PgCdeStfRole</c> as OneToMany for PgStfRoleDegCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgStfRoleDeg>))]
		PgStfRoleDegCollection,
		///<summary>
		/// Collection of <c>PgCdeStfRole</c> as OneToMany for PgThesisStaffCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgThesisStaff>))]
		PgThesisStaffCollection,
		///<summary>
		/// Collection of <c>PgCdeStfRole</c> as OneToMany for PgThesisCommMemberCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgThesisCommMember>))]
		PgThesisCommMemberCollection,
	}
	
	#endregion PgCdeStfRoleChildEntityTypes
	
	#region PgCdeStfRoleFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;PgCdeStfRoleColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgCdeStfRole"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PgCdeStfRoleFilterBuilder : SqlFilterBuilder<PgCdeStfRoleColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgCdeStfRoleFilterBuilder class.
		/// </summary>
		public PgCdeStfRoleFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PgCdeStfRoleFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PgCdeStfRoleFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PgCdeStfRoleFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PgCdeStfRoleFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PgCdeStfRoleFilterBuilder
	
	#region PgCdeStfRoleParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;PgCdeStfRoleColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgCdeStfRole"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PgCdeStfRoleParameterBuilder : ParameterizedSqlFilterBuilder<PgCdeStfRoleColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgCdeStfRoleParameterBuilder class.
		/// </summary>
		public PgCdeStfRoleParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the PgCdeStfRoleParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public PgCdeStfRoleParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the PgCdeStfRoleParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public PgCdeStfRoleParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion PgCdeStfRoleParameterBuilder
	
	#region PgCdeStfRoleSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;PgCdeStfRoleColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PgCdeStfRole"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class PgCdeStfRoleSortBuilder : SqlSortBuilder<PgCdeStfRoleColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PgCdeStfRoleSqlSortBuilder class.
		/// </summary>
		public PgCdeStfRoleSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion PgCdeStfRoleSortBuilder
	
} // end namespace
