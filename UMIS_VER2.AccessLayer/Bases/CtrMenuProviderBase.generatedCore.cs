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
	/// This class is the base class for any <see cref="CtrMenuProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class CtrMenuProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.CtrMenu, UMIS_VER2.BusinessLyer.CtrMenuKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CtrMenuKey key)
		{
			return Delete(transactionManager, key.CtrMenuId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_ctrMenuId">قائمة افطار 1 2 3. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _ctrMenuId)
		{
			return Delete(null, _ctrMenuId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrMenuId">قائمة افطار 1 2 3. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _ctrMenuId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_MENU_CTR_CDE_MEAL key.
		///		FK_CTR_MENU_CTR_CDE_MEAL Description: 
		/// </summary>
		/// <param name="_ctrCdeMealId">نوع الوجبة:فطار-غدا-عشا</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrMenu objects.</returns>
		public TList<CtrMenu> GetByCtrCdeMealId(System.Decimal _ctrCdeMealId)
		{
			int count = -1;
			return GetByCtrCdeMealId(_ctrCdeMealId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_MENU_CTR_CDE_MEAL key.
		///		FK_CTR_MENU_CTR_CDE_MEAL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrCdeMealId">نوع الوجبة:فطار-غدا-عشا</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrMenu objects.</returns>
		/// <remarks></remarks>
		public TList<CtrMenu> GetByCtrCdeMealId(TransactionManager transactionManager, System.Decimal _ctrCdeMealId)
		{
			int count = -1;
			return GetByCtrCdeMealId(transactionManager, _ctrCdeMealId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_MENU_CTR_CDE_MEAL key.
		///		FK_CTR_MENU_CTR_CDE_MEAL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrCdeMealId">نوع الوجبة:فطار-غدا-عشا</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrMenu objects.</returns>
		public TList<CtrMenu> GetByCtrCdeMealId(TransactionManager transactionManager, System.Decimal _ctrCdeMealId, int start, int pageLength)
		{
			int count = -1;
			return GetByCtrCdeMealId(transactionManager, _ctrCdeMealId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_MENU_CTR_CDE_MEAL key.
		///		fkCtrMenuCtrCdeMeal Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_ctrCdeMealId">نوع الوجبة:فطار-غدا-عشا</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrMenu objects.</returns>
		public TList<CtrMenu> GetByCtrCdeMealId(System.Decimal _ctrCdeMealId, int start, int pageLength)
		{
			int count =  -1;
			return GetByCtrCdeMealId(null, _ctrCdeMealId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_MENU_CTR_CDE_MEAL key.
		///		fkCtrMenuCtrCdeMeal Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_ctrCdeMealId">نوع الوجبة:فطار-غدا-عشا</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrMenu objects.</returns>
		public TList<CtrMenu> GetByCtrCdeMealId(System.Decimal _ctrCdeMealId, int start, int pageLength,out int count)
		{
			return GetByCtrCdeMealId(null, _ctrCdeMealId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_MENU_CTR_CDE_MEAL key.
		///		FK_CTR_MENU_CTR_CDE_MEAL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrCdeMealId">نوع الوجبة:فطار-غدا-عشا</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrMenu objects.</returns>
		public abstract TList<CtrMenu> GetByCtrCdeMealId(TransactionManager transactionManager, System.Decimal _ctrCdeMealId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.CtrMenu Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CtrMenuKey key, int start, int pageLength)
		{
			return GetByCtrMenuId(transactionManager, key.CtrMenuId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_CTR_MENU index.
		/// </summary>
		/// <param name="_ctrMenuId">قائمة افطار 1 2 3</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrMenu"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrMenu GetByCtrMenuId(System.Decimal _ctrMenuId)
		{
			int count = -1;
			return GetByCtrMenuId(null,_ctrMenuId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_MENU index.
		/// </summary>
		/// <param name="_ctrMenuId">قائمة افطار 1 2 3</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrMenu"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrMenu GetByCtrMenuId(System.Decimal _ctrMenuId, int start, int pageLength)
		{
			int count = -1;
			return GetByCtrMenuId(null, _ctrMenuId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_MENU index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrMenuId">قائمة افطار 1 2 3</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrMenu"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrMenu GetByCtrMenuId(TransactionManager transactionManager, System.Decimal _ctrMenuId)
		{
			int count = -1;
			return GetByCtrMenuId(transactionManager, _ctrMenuId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_MENU index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrMenuId">قائمة افطار 1 2 3</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrMenu"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrMenu GetByCtrMenuId(TransactionManager transactionManager, System.Decimal _ctrMenuId, int start, int pageLength)
		{
			int count = -1;
			return GetByCtrMenuId(transactionManager, _ctrMenuId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_MENU index.
		/// </summary>
		/// <param name="_ctrMenuId">قائمة افطار 1 2 3</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrMenu"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrMenu GetByCtrMenuId(System.Decimal _ctrMenuId, int start, int pageLength, out int count)
		{
			return GetByCtrMenuId(null, _ctrMenuId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_MENU index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrMenuId">قائمة افطار 1 2 3</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrMenu"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.CtrMenu GetByCtrMenuId(TransactionManager transactionManager, System.Decimal _ctrMenuId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;CtrMenu&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;CtrMenu&gt;"/></returns>
		public static TList<CtrMenu> Fill(IDataReader reader, TList<CtrMenu> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.CtrMenu c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("CtrMenu")
					.Append("|").Append((System.Decimal)reader["CTR_MENU_ID"]).ToString();
					c = EntityManager.LocateOrCreate<CtrMenu>(
					key.ToString(), // EntityTrackingKey
					"CtrMenu",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.CtrMenu();
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
					c.CtrMenuId = (System.Decimal)reader["CTR_MENU_ID"];
					c.OriginalCtrMenuId = c.CtrMenuId;
					c.CtrCdeMealId = (System.Decimal)reader["CTR_CDE_MEAL_ID"];
					c.MenuAr = (System.String)reader["MENU_AR"];
					c.MenuEn = (System.String)reader["MENU_EN"];
					c.ActiveFlg = Convert.IsDBNull(reader["ACTIVE_FLG"]) ? null : (System.Decimal?)reader["ACTIVE_FLG"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.CtrMenu"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CtrMenu"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.CtrMenu entity)
		{
			if (!reader.Read()) return;
			
			entity.CtrMenuId = (System.Decimal)reader[((int)CtrMenuColumn.CtrMenuId - 1)];
			entity.OriginalCtrMenuId = (System.Decimal)reader["CTR_MENU_ID"];
			entity.CtrCdeMealId = (System.Decimal)reader[((int)CtrMenuColumn.CtrCdeMealId - 1)];
			entity.MenuAr = (System.String)reader[((int)CtrMenuColumn.MenuAr - 1)];
			entity.MenuEn = (System.String)reader[((int)CtrMenuColumn.MenuEn - 1)];
			entity.ActiveFlg = (reader.IsDBNull(((int)CtrMenuColumn.ActiveFlg - 1)))?null:(System.Decimal?)reader[((int)CtrMenuColumn.ActiveFlg - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.CtrMenu"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CtrMenu"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.CtrMenu entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.CtrMenuId = (System.Decimal)dataRow["CTR_MENU_ID"];
			entity.OriginalCtrMenuId = (System.Decimal)dataRow["CTR_MENU_ID"];
			entity.CtrCdeMealId = (System.Decimal)dataRow["CTR_CDE_MEAL_ID"];
			entity.MenuAr = (System.String)dataRow["MENU_AR"];
			entity.MenuEn = (System.String)dataRow["MENU_EN"];
			entity.ActiveFlg = Convert.IsDBNull(dataRow["ACTIVE_FLG"]) ? null : (System.Decimal?)dataRow["ACTIVE_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CtrMenu"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.CtrMenu Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CtrMenu entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region CtrCdeMealIdSource	
			if (CanDeepLoad(entity, "CtrCdeMeal|CtrCdeMealIdSource", deepLoadType, innerList) 
				&& entity.CtrCdeMealIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.CtrCdeMealId;
				CtrCdeMeal tmpEntity = EntityManager.LocateEntity<CtrCdeMeal>(EntityLocator.ConstructKeyFromPkItems(typeof(CtrCdeMeal), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.CtrCdeMealIdSource = tmpEntity;
				else
					entity.CtrCdeMealIdSource = DataRepository.CtrCdeMealProvider.GetByCtrCdeMealId(transactionManager, entity.CtrCdeMealId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CtrCdeMealIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.CtrCdeMealIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.CtrCdeMealProvider.DeepLoad(transactionManager, entity.CtrCdeMealIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion CtrCdeMealIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByCtrMenuId methods when available
			
			#region CtrMenuItemCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<CtrMenuItem>|CtrMenuItemCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CtrMenuItemCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.CtrMenuItemCollection = DataRepository.CtrMenuItemProvider.GetByCtrMenuId(transactionManager, entity.CtrMenuId);

				if (deep && entity.CtrMenuItemCollection.Count > 0)
				{
					deepHandles.Add("CtrMenuItemCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CtrMenuItem>) DataRepository.CtrMenuItemProvider.DeepLoad,
						new object[] { transactionManager, entity.CtrMenuItemCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region CtrMenuActCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<CtrMenuAct>|CtrMenuActCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CtrMenuActCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.CtrMenuActCollection = DataRepository.CtrMenuActProvider.GetByCtrMenuId(transactionManager, entity.CtrMenuId);

				if (deep && entity.CtrMenuActCollection.Count > 0)
				{
					deepHandles.Add("CtrMenuActCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CtrMenuAct>) DataRepository.CtrMenuActProvider.DeepLoad,
						new object[] { transactionManager, entity.CtrMenuActCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.CtrMenu object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.CtrMenu instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.CtrMenu Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CtrMenu entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region CtrCdeMealIdSource
			if (CanDeepSave(entity, "CtrCdeMeal|CtrCdeMealIdSource", deepSaveType, innerList) 
				&& entity.CtrCdeMealIdSource != null)
			{
				DataRepository.CtrCdeMealProvider.Save(transactionManager, entity.CtrCdeMealIdSource);
				entity.CtrCdeMealId = entity.CtrCdeMealIdSource.CtrCdeMealId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<CtrMenuItem>
				if (CanDeepSave(entity.CtrMenuItemCollection, "List<CtrMenuItem>|CtrMenuItemCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CtrMenuItem child in entity.CtrMenuItemCollection)
					{
						if(child.CtrMenuIdSource != null)
						{
							child.CtrMenuId = child.CtrMenuIdSource.CtrMenuId;
						}
						else
						{
							child.CtrMenuId = entity.CtrMenuId;
						}

					}

					if (entity.CtrMenuItemCollection.Count > 0 || entity.CtrMenuItemCollection.DeletedItems.Count > 0)
					{
						//DataRepository.CtrMenuItemProvider.Save(transactionManager, entity.CtrMenuItemCollection);
						
						deepHandles.Add("CtrMenuItemCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< CtrMenuItem >) DataRepository.CtrMenuItemProvider.DeepSave,
							new object[] { transactionManager, entity.CtrMenuItemCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<CtrMenuAct>
				if (CanDeepSave(entity.CtrMenuActCollection, "List<CtrMenuAct>|CtrMenuActCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CtrMenuAct child in entity.CtrMenuActCollection)
					{
						if(child.CtrMenuIdSource != null)
						{
							child.CtrMenuId = child.CtrMenuIdSource.CtrMenuId;
						}
						else
						{
							child.CtrMenuId = entity.CtrMenuId;
						}

					}

					if (entity.CtrMenuActCollection.Count > 0 || entity.CtrMenuActCollection.DeletedItems.Count > 0)
					{
						//DataRepository.CtrMenuActProvider.Save(transactionManager, entity.CtrMenuActCollection);
						
						deepHandles.Add("CtrMenuActCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< CtrMenuAct >) DataRepository.CtrMenuActProvider.DeepSave,
							new object[] { transactionManager, entity.CtrMenuActCollection, deepSaveType, childTypes, innerList }
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
	
	#region CtrMenuChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.CtrMenu</c>
	///</summary>
	public enum CtrMenuChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>CtrCdeMeal</c> at CtrCdeMealIdSource
		///</summary>
		[ChildEntityType(typeof(CtrCdeMeal))]
		CtrCdeMeal,
		///<summary>
		/// Collection of <c>CtrMenu</c> as OneToMany for CtrMenuItemCollection
		///</summary>
		[ChildEntityType(typeof(TList<CtrMenuItem>))]
		CtrMenuItemCollection,
		///<summary>
		/// Collection of <c>CtrMenu</c> as OneToMany for CtrMenuActCollection
		///</summary>
		[ChildEntityType(typeof(TList<CtrMenuAct>))]
		CtrMenuActCollection,
	}
	
	#endregion CtrMenuChildEntityTypes
	
	#region CtrMenuFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;CtrMenuColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CtrMenu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CtrMenuFilterBuilder : SqlFilterBuilder<CtrMenuColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CtrMenuFilterBuilder class.
		/// </summary>
		public CtrMenuFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CtrMenuFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CtrMenuFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CtrMenuFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CtrMenuFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CtrMenuFilterBuilder
	
	#region CtrMenuParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;CtrMenuColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CtrMenu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CtrMenuParameterBuilder : ParameterizedSqlFilterBuilder<CtrMenuColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CtrMenuParameterBuilder class.
		/// </summary>
		public CtrMenuParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CtrMenuParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CtrMenuParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CtrMenuParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CtrMenuParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CtrMenuParameterBuilder
	
	#region CtrMenuSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;CtrMenuColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CtrMenu"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class CtrMenuSortBuilder : SqlSortBuilder<CtrMenuColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CtrMenuSqlSortBuilder class.
		/// </summary>
		public CtrMenuSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion CtrMenuSortBuilder
	
} // end namespace
