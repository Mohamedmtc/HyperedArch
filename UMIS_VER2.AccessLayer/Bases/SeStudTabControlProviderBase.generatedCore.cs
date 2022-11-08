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
	/// This class is the base class for any <see cref="SeStudTabControlProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SeStudTabControlProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SeStudTabControl, UMIS_VER2.BusinessLyer.SeStudTabControlKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeStudTabControlKey key)
		{
			return Delete(transactionManager, key.SeStudTabControlId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_seStudTabControlId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _seStudTabControlId)
		{
			return Delete(null, _seStudTabControlId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seStudTabControlId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _seStudTabControlId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_STUD_TAB_CONTROL_SE_STUD_TAB_CONTROL key.
		///		FK_SE_STUD_TAB_CONTROL_SE_STUD_TAB_CONTROL Description: 
		/// </summary>
		/// <param name="_seStudTabId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeStudTabControl objects.</returns>
		public TList<SeStudTabControl> GetBySeStudTabId(System.Decimal? _seStudTabId)
		{
			int count = -1;
			return GetBySeStudTabId(_seStudTabId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_STUD_TAB_CONTROL_SE_STUD_TAB_CONTROL key.
		///		FK_SE_STUD_TAB_CONTROL_SE_STUD_TAB_CONTROL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seStudTabId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeStudTabControl objects.</returns>
		/// <remarks></remarks>
		public TList<SeStudTabControl> GetBySeStudTabId(TransactionManager transactionManager, System.Decimal? _seStudTabId)
		{
			int count = -1;
			return GetBySeStudTabId(transactionManager, _seStudTabId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_STUD_TAB_CONTROL_SE_STUD_TAB_CONTROL key.
		///		FK_SE_STUD_TAB_CONTROL_SE_STUD_TAB_CONTROL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seStudTabId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeStudTabControl objects.</returns>
		public TList<SeStudTabControl> GetBySeStudTabId(TransactionManager transactionManager, System.Decimal? _seStudTabId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeStudTabId(transactionManager, _seStudTabId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_STUD_TAB_CONTROL_SE_STUD_TAB_CONTROL key.
		///		fkSeStudTabControlSeStudTabControl Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seStudTabId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeStudTabControl objects.</returns>
		public TList<SeStudTabControl> GetBySeStudTabId(System.Decimal? _seStudTabId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySeStudTabId(null, _seStudTabId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_STUD_TAB_CONTROL_SE_STUD_TAB_CONTROL key.
		///		fkSeStudTabControlSeStudTabControl Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seStudTabId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeStudTabControl objects.</returns>
		public TList<SeStudTabControl> GetBySeStudTabId(System.Decimal? _seStudTabId, int start, int pageLength,out int count)
		{
			return GetBySeStudTabId(null, _seStudTabId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SE_STUD_TAB_CONTROL_SE_STUD_TAB_CONTROL key.
		///		FK_SE_STUD_TAB_CONTROL_SE_STUD_TAB_CONTROL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seStudTabId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SeStudTabControl objects.</returns>
		public abstract TList<SeStudTabControl> GetBySeStudTabId(TransactionManager transactionManager, System.Decimal? _seStudTabId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SeStudTabControl Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeStudTabControlKey key, int start, int pageLength)
		{
			return GetBySeStudTabControlId(transactionManager, key.SeStudTabControlId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SE_STUD_TAB_CONTROL index.
		/// </summary>
		/// <param name="_seStudTabControlId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeStudTabControl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeStudTabControl GetBySeStudTabControlId(System.Decimal _seStudTabControlId)
		{
			int count = -1;
			return GetBySeStudTabControlId(null,_seStudTabControlId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_STUD_TAB_CONTROL index.
		/// </summary>
		/// <param name="_seStudTabControlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeStudTabControl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeStudTabControl GetBySeStudTabControlId(System.Decimal _seStudTabControlId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeStudTabControlId(null, _seStudTabControlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_STUD_TAB_CONTROL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seStudTabControlId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeStudTabControl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeStudTabControl GetBySeStudTabControlId(TransactionManager transactionManager, System.Decimal _seStudTabControlId)
		{
			int count = -1;
			return GetBySeStudTabControlId(transactionManager, _seStudTabControlId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_STUD_TAB_CONTROL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seStudTabControlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeStudTabControl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeStudTabControl GetBySeStudTabControlId(TransactionManager transactionManager, System.Decimal _seStudTabControlId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeStudTabControlId(transactionManager, _seStudTabControlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_STUD_TAB_CONTROL index.
		/// </summary>
		/// <param name="_seStudTabControlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeStudTabControl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeStudTabControl GetBySeStudTabControlId(System.Decimal _seStudTabControlId, int start, int pageLength, out int count)
		{
			return GetBySeStudTabControlId(null, _seStudTabControlId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_STUD_TAB_CONTROL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seStudTabControlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeStudTabControl"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SeStudTabControl GetBySeStudTabControlId(TransactionManager transactionManager, System.Decimal _seStudTabControlId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SeStudTabControl&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SeStudTabControl&gt;"/></returns>
		public static TList<SeStudTabControl> Fill(IDataReader reader, TList<SeStudTabControl> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SeStudTabControl c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SeStudTabControl")
					.Append("|").Append((System.Decimal)reader["SE_STUD_TAB_CONTROL_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SeStudTabControl>(
					key.ToString(), // EntityTrackingKey
					"SeStudTabControl",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SeStudTabControl();
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
					c.SeStudTabControlId = (System.Decimal)reader["SE_STUD_TAB_CONTROL_ID"];
					c.OriginalSeStudTabControlId = c.SeStudTabControlId;
					c.CodeName = (System.String)reader["CODE_NAME"];
					c.DescAr = (System.String)reader["DESC_AR"];
					c.DescEn = (System.String)reader["DESC_EN"];
					c.SeStudTabId = Convert.IsDBNull(reader["SE_STUD_TAB_ID"]) ? null : (System.Decimal?)reader["SE_STUD_TAB_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SeStudTabControl"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SeStudTabControl"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SeStudTabControl entity)
		{
			if (!reader.Read()) return;
			
			entity.SeStudTabControlId = (System.Decimal)reader[((int)SeStudTabControlColumn.SeStudTabControlId - 1)];
			entity.OriginalSeStudTabControlId = (System.Decimal)reader["SE_STUD_TAB_CONTROL_ID"];
			entity.CodeName = (System.String)reader[((int)SeStudTabControlColumn.CodeName - 1)];
			entity.DescAr = (System.String)reader[((int)SeStudTabControlColumn.DescAr - 1)];
			entity.DescEn = (System.String)reader[((int)SeStudTabControlColumn.DescEn - 1)];
			entity.SeStudTabId = (reader.IsDBNull(((int)SeStudTabControlColumn.SeStudTabId - 1)))?null:(System.Decimal?)reader[((int)SeStudTabControlColumn.SeStudTabId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SeStudTabControl"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SeStudTabControl"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SeStudTabControl entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SeStudTabControlId = (System.Decimal)dataRow["SE_STUD_TAB_CONTROL_ID"];
			entity.OriginalSeStudTabControlId = (System.Decimal)dataRow["SE_STUD_TAB_CONTROL_ID"];
			entity.CodeName = (System.String)dataRow["CODE_NAME"];
			entity.DescAr = (System.String)dataRow["DESC_AR"];
			entity.DescEn = (System.String)dataRow["DESC_EN"];
			entity.SeStudTabId = Convert.IsDBNull(dataRow["SE_STUD_TAB_ID"]) ? null : (System.Decimal?)dataRow["SE_STUD_TAB_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SeStudTabControl"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SeStudTabControl Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeStudTabControl entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region SeStudTabIdSource	
			if (CanDeepLoad(entity, "SeStudTabControl|SeStudTabIdSource", deepLoadType, innerList) 
				&& entity.SeStudTabIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SeStudTabId ?? 0.0m);
				SeStudTabControl tmpEntity = EntityManager.LocateEntity<SeStudTabControl>(EntityLocator.ConstructKeyFromPkItems(typeof(SeStudTabControl), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SeStudTabIdSource = tmpEntity;
				else
					entity.SeStudTabIdSource = DataRepository.SeStudTabControlProvider.GetBySeStudTabControlId(transactionManager, (entity.SeStudTabId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeStudTabIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SeStudTabIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SeStudTabControlProvider.DeepLoad(transactionManager, entity.SeStudTabIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SeStudTabIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetBySeStudTabControlId methods when available
			
			#region SeStudTabUserTypeControlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SeStudTabUserTypeControl>|SeStudTabUserTypeControlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeStudTabUserTypeControlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SeStudTabUserTypeControlCollection = DataRepository.SeStudTabUserTypeControlProvider.GetBySeStudTabControlId(transactionManager, entity.SeStudTabControlId);

				if (deep && entity.SeStudTabUserTypeControlCollection.Count > 0)
				{
					deepHandles.Add("SeStudTabUserTypeControlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SeStudTabUserTypeControl>) DataRepository.SeStudTabUserTypeControlProvider.DeepLoad,
						new object[] { transactionManager, entity.SeStudTabUserTypeControlCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SeStudTabControlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SeStudTabControl>|SeStudTabControlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeStudTabControlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SeStudTabControlCollection = DataRepository.SeStudTabControlProvider.GetBySeStudTabId(transactionManager, entity.SeStudTabControlId);

				if (deep && entity.SeStudTabControlCollection.Count > 0)
				{
					deepHandles.Add("SeStudTabControlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SeStudTabControl>) DataRepository.SeStudTabControlProvider.DeepLoad,
						new object[] { transactionManager, entity.SeStudTabControlCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SeStudTabControl object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SeStudTabControl instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SeStudTabControl Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeStudTabControl entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region SeStudTabIdSource
			if (CanDeepSave(entity, "SeStudTabControl|SeStudTabIdSource", deepSaveType, innerList) 
				&& entity.SeStudTabIdSource != null)
			{
				DataRepository.SeStudTabControlProvider.Save(transactionManager, entity.SeStudTabIdSource);
				entity.SeStudTabId = entity.SeStudTabIdSource.SeStudTabControlId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<SeStudTabUserTypeControl>
				if (CanDeepSave(entity.SeStudTabUserTypeControlCollection, "List<SeStudTabUserTypeControl>|SeStudTabUserTypeControlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SeStudTabUserTypeControl child in entity.SeStudTabUserTypeControlCollection)
					{
						if(child.SeStudTabControlIdSource != null)
						{
							child.SeStudTabControlId = child.SeStudTabControlIdSource.SeStudTabControlId;
						}
						else
						{
							child.SeStudTabControlId = entity.SeStudTabControlId;
						}

					}

					if (entity.SeStudTabUserTypeControlCollection.Count > 0 || entity.SeStudTabUserTypeControlCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SeStudTabUserTypeControlProvider.Save(transactionManager, entity.SeStudTabUserTypeControlCollection);
						
						deepHandles.Add("SeStudTabUserTypeControlCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SeStudTabUserTypeControl >) DataRepository.SeStudTabUserTypeControlProvider.DeepSave,
							new object[] { transactionManager, entity.SeStudTabUserTypeControlCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SeStudTabControl>
				if (CanDeepSave(entity.SeStudTabControlCollection, "List<SeStudTabControl>|SeStudTabControlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SeStudTabControl child in entity.SeStudTabControlCollection)
					{
						if(child.SeStudTabIdSource != null)
						{
							child.SeStudTabId = child.SeStudTabIdSource.SeStudTabControlId;
						}
						else
						{
							child.SeStudTabId = entity.SeStudTabControlId;
						}

					}

					if (entity.SeStudTabControlCollection.Count > 0 || entity.SeStudTabControlCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SeStudTabControlProvider.Save(transactionManager, entity.SeStudTabControlCollection);
						
						deepHandles.Add("SeStudTabControlCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SeStudTabControl >) DataRepository.SeStudTabControlProvider.DeepSave,
							new object[] { transactionManager, entity.SeStudTabControlCollection, deepSaveType, childTypes, innerList }
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
	
	#region SeStudTabControlChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SeStudTabControl</c>
	///</summary>
	public enum SeStudTabControlChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>SeStudTabControl</c> at SeStudTabIdSource
		///</summary>
		[ChildEntityType(typeof(SeStudTabControl))]
		SeStudTabControl,
		///<summary>
		/// Collection of <c>SeStudTabControl</c> as OneToMany for SeStudTabUserTypeControlCollection
		///</summary>
		[ChildEntityType(typeof(TList<SeStudTabUserTypeControl>))]
		SeStudTabUserTypeControlCollection,
		///<summary>
		/// Collection of <c>SeStudTabControl</c> as OneToMany for SeStudTabControlCollection
		///</summary>
		[ChildEntityType(typeof(TList<SeStudTabControl>))]
		SeStudTabControlCollection,
	}
	
	#endregion SeStudTabControlChildEntityTypes
	
	#region SeStudTabControlFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SeStudTabControlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SeStudTabControl"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SeStudTabControlFilterBuilder : SqlFilterBuilder<SeStudTabControlColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SeStudTabControlFilterBuilder class.
		/// </summary>
		public SeStudTabControlFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SeStudTabControlFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SeStudTabControlFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SeStudTabControlFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SeStudTabControlFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SeStudTabControlFilterBuilder
	
	#region SeStudTabControlParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SeStudTabControlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SeStudTabControl"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SeStudTabControlParameterBuilder : ParameterizedSqlFilterBuilder<SeStudTabControlColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SeStudTabControlParameterBuilder class.
		/// </summary>
		public SeStudTabControlParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SeStudTabControlParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SeStudTabControlParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SeStudTabControlParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SeStudTabControlParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SeStudTabControlParameterBuilder
	
	#region SeStudTabControlSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SeStudTabControlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SeStudTabControl"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SeStudTabControlSortBuilder : SqlSortBuilder<SeStudTabControlColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SeStudTabControlSqlSortBuilder class.
		/// </summary>
		public SeStudTabControlSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SeStudTabControlSortBuilder
	
} // end namespace
