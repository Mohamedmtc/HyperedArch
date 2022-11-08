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
	/// This class is the base class for any <see cref="CtrMenuItemProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class CtrMenuItemProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.CtrMenuItem, UMIS_VER2.BusinessLyer.CtrMenuItemKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CtrMenuItemKey key)
		{
			return Delete(transactionManager, key.CtrMenuItemId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_ctrMenuItemId">محتويات قائمة طعام وجبة. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _ctrMenuItemId)
		{
			return Delete(null, _ctrMenuItemId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrMenuItemId">محتويات قائمة طعام وجبة. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _ctrMenuItemId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_MENU_ITEM_CTR_CDE_MEAL_ITEM key.
		///		FK_CTR_MENU_ITEM_CTR_CDE_MEAL_ITEM Description: 
		/// </summary>
		/// <param name="_ctrCdeMealItemId">من الخيارات عناصر الطعام</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrMenuItem objects.</returns>
		public TList<CtrMenuItem> GetByCtrCdeMealItemId(System.Decimal _ctrCdeMealItemId)
		{
			int count = -1;
			return GetByCtrCdeMealItemId(_ctrCdeMealItemId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_MENU_ITEM_CTR_CDE_MEAL_ITEM key.
		///		FK_CTR_MENU_ITEM_CTR_CDE_MEAL_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrCdeMealItemId">من الخيارات عناصر الطعام</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrMenuItem objects.</returns>
		/// <remarks></remarks>
		public TList<CtrMenuItem> GetByCtrCdeMealItemId(TransactionManager transactionManager, System.Decimal _ctrCdeMealItemId)
		{
			int count = -1;
			return GetByCtrCdeMealItemId(transactionManager, _ctrCdeMealItemId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_MENU_ITEM_CTR_CDE_MEAL_ITEM key.
		///		FK_CTR_MENU_ITEM_CTR_CDE_MEAL_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrCdeMealItemId">من الخيارات عناصر الطعام</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrMenuItem objects.</returns>
		public TList<CtrMenuItem> GetByCtrCdeMealItemId(TransactionManager transactionManager, System.Decimal _ctrCdeMealItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByCtrCdeMealItemId(transactionManager, _ctrCdeMealItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_MENU_ITEM_CTR_CDE_MEAL_ITEM key.
		///		fkCtrMenuItemCtrCdeMealItem Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_ctrCdeMealItemId">من الخيارات عناصر الطعام</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrMenuItem objects.</returns>
		public TList<CtrMenuItem> GetByCtrCdeMealItemId(System.Decimal _ctrCdeMealItemId, int start, int pageLength)
		{
			int count =  -1;
			return GetByCtrCdeMealItemId(null, _ctrCdeMealItemId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_MENU_ITEM_CTR_CDE_MEAL_ITEM key.
		///		fkCtrMenuItemCtrCdeMealItem Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_ctrCdeMealItemId">من الخيارات عناصر الطعام</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrMenuItem objects.</returns>
		public TList<CtrMenuItem> GetByCtrCdeMealItemId(System.Decimal _ctrCdeMealItemId, int start, int pageLength,out int count)
		{
			return GetByCtrCdeMealItemId(null, _ctrCdeMealItemId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_MENU_ITEM_CTR_CDE_MEAL_ITEM key.
		///		FK_CTR_MENU_ITEM_CTR_CDE_MEAL_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrCdeMealItemId">من الخيارات عناصر الطعام</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrMenuItem objects.</returns>
		public abstract TList<CtrMenuItem> GetByCtrCdeMealItemId(TransactionManager transactionManager, System.Decimal _ctrCdeMealItemId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_MENU_ITEM_CTR_MENU key.
		///		FK_CTR_MENU_ITEM_CTR_MENU Description: 
		/// </summary>
		/// <param name="_ctrMenuId">قائمة افطار 1 2 3</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrMenuItem objects.</returns>
		public TList<CtrMenuItem> GetByCtrMenuId(System.Decimal _ctrMenuId)
		{
			int count = -1;
			return GetByCtrMenuId(_ctrMenuId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_MENU_ITEM_CTR_MENU key.
		///		FK_CTR_MENU_ITEM_CTR_MENU Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrMenuId">قائمة افطار 1 2 3</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrMenuItem objects.</returns>
		/// <remarks></remarks>
		public TList<CtrMenuItem> GetByCtrMenuId(TransactionManager transactionManager, System.Decimal _ctrMenuId)
		{
			int count = -1;
			return GetByCtrMenuId(transactionManager, _ctrMenuId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_MENU_ITEM_CTR_MENU key.
		///		FK_CTR_MENU_ITEM_CTR_MENU Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrMenuId">قائمة افطار 1 2 3</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrMenuItem objects.</returns>
		public TList<CtrMenuItem> GetByCtrMenuId(TransactionManager transactionManager, System.Decimal _ctrMenuId, int start, int pageLength)
		{
			int count = -1;
			return GetByCtrMenuId(transactionManager, _ctrMenuId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_MENU_ITEM_CTR_MENU key.
		///		fkCtrMenuItemCtrMenu Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_ctrMenuId">قائمة افطار 1 2 3</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrMenuItem objects.</returns>
		public TList<CtrMenuItem> GetByCtrMenuId(System.Decimal _ctrMenuId, int start, int pageLength)
		{
			int count =  -1;
			return GetByCtrMenuId(null, _ctrMenuId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_MENU_ITEM_CTR_MENU key.
		///		fkCtrMenuItemCtrMenu Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_ctrMenuId">قائمة افطار 1 2 3</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrMenuItem objects.</returns>
		public TList<CtrMenuItem> GetByCtrMenuId(System.Decimal _ctrMenuId, int start, int pageLength,out int count)
		{
			return GetByCtrMenuId(null, _ctrMenuId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_MENU_ITEM_CTR_MENU key.
		///		FK_CTR_MENU_ITEM_CTR_MENU Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrMenuId">قائمة افطار 1 2 3</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrMenuItem objects.</returns>
		public abstract TList<CtrMenuItem> GetByCtrMenuId(TransactionManager transactionManager, System.Decimal _ctrMenuId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.CtrMenuItem Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CtrMenuItemKey key, int start, int pageLength)
		{
			return GetByCtrMenuItemId(transactionManager, key.CtrMenuItemId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_CTR_MENU_ITEM index.
		/// </summary>
		/// <param name="_ctrMenuItemId">محتويات قائمة طعام وجبة</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrMenuItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrMenuItem GetByCtrMenuItemId(System.Decimal _ctrMenuItemId)
		{
			int count = -1;
			return GetByCtrMenuItemId(null,_ctrMenuItemId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_MENU_ITEM index.
		/// </summary>
		/// <param name="_ctrMenuItemId">محتويات قائمة طعام وجبة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrMenuItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrMenuItem GetByCtrMenuItemId(System.Decimal _ctrMenuItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByCtrMenuItemId(null, _ctrMenuItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_MENU_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrMenuItemId">محتويات قائمة طعام وجبة</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrMenuItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrMenuItem GetByCtrMenuItemId(TransactionManager transactionManager, System.Decimal _ctrMenuItemId)
		{
			int count = -1;
			return GetByCtrMenuItemId(transactionManager, _ctrMenuItemId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_MENU_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrMenuItemId">محتويات قائمة طعام وجبة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrMenuItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrMenuItem GetByCtrMenuItemId(TransactionManager transactionManager, System.Decimal _ctrMenuItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByCtrMenuItemId(transactionManager, _ctrMenuItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_MENU_ITEM index.
		/// </summary>
		/// <param name="_ctrMenuItemId">محتويات قائمة طعام وجبة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrMenuItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrMenuItem GetByCtrMenuItemId(System.Decimal _ctrMenuItemId, int start, int pageLength, out int count)
		{
			return GetByCtrMenuItemId(null, _ctrMenuItemId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_MENU_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrMenuItemId">محتويات قائمة طعام وجبة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrMenuItem"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.CtrMenuItem GetByCtrMenuItemId(TransactionManager transactionManager, System.Decimal _ctrMenuItemId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;CtrMenuItem&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;CtrMenuItem&gt;"/></returns>
		public static TList<CtrMenuItem> Fill(IDataReader reader, TList<CtrMenuItem> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.CtrMenuItem c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("CtrMenuItem")
					.Append("|").Append((System.Decimal)reader["CTR_MENU_ITEM_ID"]).ToString();
					c = EntityManager.LocateOrCreate<CtrMenuItem>(
					key.ToString(), // EntityTrackingKey
					"CtrMenuItem",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.CtrMenuItem();
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
					c.CtrMenuItemId = (System.Decimal)reader["CTR_MENU_ITEM_ID"];
					c.OriginalCtrMenuItemId = c.CtrMenuItemId;
					c.CtrMenuId = (System.Decimal)reader["CTR_MENU_ID"];
					c.CtrCdeMealItemId = (System.Decimal)reader["CTR_CDE_MEAL_ITEM_ID"];
					c.UnitCount = Convert.IsDBNull(reader["UNIT_COUNT"]) ? null : (System.Decimal?)reader["UNIT_COUNT"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.CtrMenuItem"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CtrMenuItem"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.CtrMenuItem entity)
		{
			if (!reader.Read()) return;
			
			entity.CtrMenuItemId = (System.Decimal)reader[((int)CtrMenuItemColumn.CtrMenuItemId - 1)];
			entity.OriginalCtrMenuItemId = (System.Decimal)reader["CTR_MENU_ITEM_ID"];
			entity.CtrMenuId = (System.Decimal)reader[((int)CtrMenuItemColumn.CtrMenuId - 1)];
			entity.CtrCdeMealItemId = (System.Decimal)reader[((int)CtrMenuItemColumn.CtrCdeMealItemId - 1)];
			entity.UnitCount = (reader.IsDBNull(((int)CtrMenuItemColumn.UnitCount - 1)))?null:(System.Decimal?)reader[((int)CtrMenuItemColumn.UnitCount - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.CtrMenuItem"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CtrMenuItem"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.CtrMenuItem entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.CtrMenuItemId = (System.Decimal)dataRow["CTR_MENU_ITEM_ID"];
			entity.OriginalCtrMenuItemId = (System.Decimal)dataRow["CTR_MENU_ITEM_ID"];
			entity.CtrMenuId = (System.Decimal)dataRow["CTR_MENU_ID"];
			entity.CtrCdeMealItemId = (System.Decimal)dataRow["CTR_CDE_MEAL_ITEM_ID"];
			entity.UnitCount = Convert.IsDBNull(dataRow["UNIT_COUNT"]) ? null : (System.Decimal?)dataRow["UNIT_COUNT"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CtrMenuItem"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.CtrMenuItem Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CtrMenuItem entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region CtrCdeMealItemIdSource	
			if (CanDeepLoad(entity, "CtrCdeMealItem|CtrCdeMealItemIdSource", deepLoadType, innerList) 
				&& entity.CtrCdeMealItemIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.CtrCdeMealItemId;
				CtrCdeMealItem tmpEntity = EntityManager.LocateEntity<CtrCdeMealItem>(EntityLocator.ConstructKeyFromPkItems(typeof(CtrCdeMealItem), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.CtrCdeMealItemIdSource = tmpEntity;
				else
					entity.CtrCdeMealItemIdSource = DataRepository.CtrCdeMealItemProvider.GetByCtrCdeMealItemId(transactionManager, entity.CtrCdeMealItemId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CtrCdeMealItemIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.CtrCdeMealItemIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.CtrCdeMealItemProvider.DeepLoad(transactionManager, entity.CtrCdeMealItemIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion CtrCdeMealItemIdSource

			#region CtrMenuIdSource	
			if (CanDeepLoad(entity, "CtrMenu|CtrMenuIdSource", deepLoadType, innerList) 
				&& entity.CtrMenuIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.CtrMenuId;
				CtrMenu tmpEntity = EntityManager.LocateEntity<CtrMenu>(EntityLocator.ConstructKeyFromPkItems(typeof(CtrMenu), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.CtrMenuIdSource = tmpEntity;
				else
					entity.CtrMenuIdSource = DataRepository.CtrMenuProvider.GetByCtrMenuId(transactionManager, entity.CtrMenuId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CtrMenuIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.CtrMenuIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.CtrMenuProvider.DeepLoad(transactionManager, entity.CtrMenuIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion CtrMenuIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.CtrMenuItem object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.CtrMenuItem instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.CtrMenuItem Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CtrMenuItem entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region CtrCdeMealItemIdSource
			if (CanDeepSave(entity, "CtrCdeMealItem|CtrCdeMealItemIdSource", deepSaveType, innerList) 
				&& entity.CtrCdeMealItemIdSource != null)
			{
				DataRepository.CtrCdeMealItemProvider.Save(transactionManager, entity.CtrCdeMealItemIdSource);
				entity.CtrCdeMealItemId = entity.CtrCdeMealItemIdSource.CtrCdeMealItemId;
			}
			#endregion 
			
			#region CtrMenuIdSource
			if (CanDeepSave(entity, "CtrMenu|CtrMenuIdSource", deepSaveType, innerList) 
				&& entity.CtrMenuIdSource != null)
			{
				DataRepository.CtrMenuProvider.Save(transactionManager, entity.CtrMenuIdSource);
				entity.CtrMenuId = entity.CtrMenuIdSource.CtrMenuId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
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
	
	#region CtrMenuItemChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.CtrMenuItem</c>
	///</summary>
	public enum CtrMenuItemChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>CtrCdeMealItem</c> at CtrCdeMealItemIdSource
		///</summary>
		[ChildEntityType(typeof(CtrCdeMealItem))]
		CtrCdeMealItem,
		
		///<summary>
		/// Composite Property for <c>CtrMenu</c> at CtrMenuIdSource
		///</summary>
		[ChildEntityType(typeof(CtrMenu))]
		CtrMenu,
	}
	
	#endregion CtrMenuItemChildEntityTypes
	
	#region CtrMenuItemFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;CtrMenuItemColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CtrMenuItem"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CtrMenuItemFilterBuilder : SqlFilterBuilder<CtrMenuItemColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CtrMenuItemFilterBuilder class.
		/// </summary>
		public CtrMenuItemFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CtrMenuItemFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CtrMenuItemFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CtrMenuItemFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CtrMenuItemFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CtrMenuItemFilterBuilder
	
	#region CtrMenuItemParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;CtrMenuItemColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CtrMenuItem"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CtrMenuItemParameterBuilder : ParameterizedSqlFilterBuilder<CtrMenuItemColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CtrMenuItemParameterBuilder class.
		/// </summary>
		public CtrMenuItemParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CtrMenuItemParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CtrMenuItemParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CtrMenuItemParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CtrMenuItemParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CtrMenuItemParameterBuilder
	
	#region CtrMenuItemSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;CtrMenuItemColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CtrMenuItem"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class CtrMenuItemSortBuilder : SqlSortBuilder<CtrMenuItemColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CtrMenuItemSqlSortBuilder class.
		/// </summary>
		public CtrMenuItemSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion CtrMenuItemSortBuilder
	
} // end namespace
