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
	/// This class is the base class for any <see cref="CtrMenuActItemProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class CtrMenuActItemProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.CtrMenuActItem, UMIS_VER2.BusinessLyer.CtrMenuActItemKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CtrMenuActItemKey key)
		{
			return Delete(transactionManager, key.CtrMenuActItemId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_ctrMenuActItemId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _ctrMenuActItemId)
		{
			return Delete(null, _ctrMenuActItemId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrMenuActItemId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _ctrMenuActItemId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_MENU_ACT_ITEM_CTR_CDE_MEAL_ITEM key.
		///		FK_CTR_MENU_ACT_ITEM_CTR_CDE_MEAL_ITEM Description: 
		/// </summary>
		/// <param name="_ctrCdeMealItemId">من الخيارات عناصر الطعام</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrMenuActItem objects.</returns>
		public TList<CtrMenuActItem> GetByCtrCdeMealItemId(System.Decimal _ctrCdeMealItemId)
		{
			int count = -1;
			return GetByCtrCdeMealItemId(_ctrCdeMealItemId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_MENU_ACT_ITEM_CTR_CDE_MEAL_ITEM key.
		///		FK_CTR_MENU_ACT_ITEM_CTR_CDE_MEAL_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrCdeMealItemId">من الخيارات عناصر الطعام</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrMenuActItem objects.</returns>
		/// <remarks></remarks>
		public TList<CtrMenuActItem> GetByCtrCdeMealItemId(TransactionManager transactionManager, System.Decimal _ctrCdeMealItemId)
		{
			int count = -1;
			return GetByCtrCdeMealItemId(transactionManager, _ctrCdeMealItemId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_MENU_ACT_ITEM_CTR_CDE_MEAL_ITEM key.
		///		FK_CTR_MENU_ACT_ITEM_CTR_CDE_MEAL_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrCdeMealItemId">من الخيارات عناصر الطعام</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrMenuActItem objects.</returns>
		public TList<CtrMenuActItem> GetByCtrCdeMealItemId(TransactionManager transactionManager, System.Decimal _ctrCdeMealItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByCtrCdeMealItemId(transactionManager, _ctrCdeMealItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_MENU_ACT_ITEM_CTR_CDE_MEAL_ITEM key.
		///		fkCtrMenuActItemCtrCdeMealItem Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_ctrCdeMealItemId">من الخيارات عناصر الطعام</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrMenuActItem objects.</returns>
		public TList<CtrMenuActItem> GetByCtrCdeMealItemId(System.Decimal _ctrCdeMealItemId, int start, int pageLength)
		{
			int count =  -1;
			return GetByCtrCdeMealItemId(null, _ctrCdeMealItemId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_MENU_ACT_ITEM_CTR_CDE_MEAL_ITEM key.
		///		fkCtrMenuActItemCtrCdeMealItem Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_ctrCdeMealItemId">من الخيارات عناصر الطعام</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrMenuActItem objects.</returns>
		public TList<CtrMenuActItem> GetByCtrCdeMealItemId(System.Decimal _ctrCdeMealItemId, int start, int pageLength,out int count)
		{
			return GetByCtrCdeMealItemId(null, _ctrCdeMealItemId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_MENU_ACT_ITEM_CTR_CDE_MEAL_ITEM key.
		///		FK_CTR_MENU_ACT_ITEM_CTR_CDE_MEAL_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrCdeMealItemId">من الخيارات عناصر الطعام</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrMenuActItem objects.</returns>
		public abstract TList<CtrMenuActItem> GetByCtrCdeMealItemId(TransactionManager transactionManager, System.Decimal _ctrCdeMealItemId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_MENU_ACT_ITEM_CTR_MENU_ACT key.
		///		FK_CTR_MENU_ACT_ITEM_CTR_MENU_ACT Description: 
		/// </summary>
		/// <param name="_ctrMenuActId">قائمة الطعام الفعلية</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrMenuActItem objects.</returns>
		public TList<CtrMenuActItem> GetByCtrMenuActId(System.Decimal _ctrMenuActId)
		{
			int count = -1;
			return GetByCtrMenuActId(_ctrMenuActId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_MENU_ACT_ITEM_CTR_MENU_ACT key.
		///		FK_CTR_MENU_ACT_ITEM_CTR_MENU_ACT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrMenuActId">قائمة الطعام الفعلية</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrMenuActItem objects.</returns>
		/// <remarks></remarks>
		public TList<CtrMenuActItem> GetByCtrMenuActId(TransactionManager transactionManager, System.Decimal _ctrMenuActId)
		{
			int count = -1;
			return GetByCtrMenuActId(transactionManager, _ctrMenuActId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_MENU_ACT_ITEM_CTR_MENU_ACT key.
		///		FK_CTR_MENU_ACT_ITEM_CTR_MENU_ACT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrMenuActId">قائمة الطعام الفعلية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrMenuActItem objects.</returns>
		public TList<CtrMenuActItem> GetByCtrMenuActId(TransactionManager transactionManager, System.Decimal _ctrMenuActId, int start, int pageLength)
		{
			int count = -1;
			return GetByCtrMenuActId(transactionManager, _ctrMenuActId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_MENU_ACT_ITEM_CTR_MENU_ACT key.
		///		fkCtrMenuActItemCtrMenuAct Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_ctrMenuActId">قائمة الطعام الفعلية</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrMenuActItem objects.</returns>
		public TList<CtrMenuActItem> GetByCtrMenuActId(System.Decimal _ctrMenuActId, int start, int pageLength)
		{
			int count =  -1;
			return GetByCtrMenuActId(null, _ctrMenuActId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_MENU_ACT_ITEM_CTR_MENU_ACT key.
		///		fkCtrMenuActItemCtrMenuAct Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_ctrMenuActId">قائمة الطعام الفعلية</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrMenuActItem objects.</returns>
		public TList<CtrMenuActItem> GetByCtrMenuActId(System.Decimal _ctrMenuActId, int start, int pageLength,out int count)
		{
			return GetByCtrMenuActId(null, _ctrMenuActId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_MENU_ACT_ITEM_CTR_MENU_ACT key.
		///		FK_CTR_MENU_ACT_ITEM_CTR_MENU_ACT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrMenuActId">قائمة الطعام الفعلية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrMenuActItem objects.</returns>
		public abstract TList<CtrMenuActItem> GetByCtrMenuActId(TransactionManager transactionManager, System.Decimal _ctrMenuActId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.CtrMenuActItem Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CtrMenuActItemKey key, int start, int pageLength)
		{
			return GetByCtrMenuActItemId(transactionManager, key.CtrMenuActItemId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_CTR_MENU_ACT_ITEM index.
		/// </summary>
		/// <param name="_ctrMenuActItemId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrMenuActItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrMenuActItem GetByCtrMenuActItemId(System.Decimal _ctrMenuActItemId)
		{
			int count = -1;
			return GetByCtrMenuActItemId(null,_ctrMenuActItemId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_MENU_ACT_ITEM index.
		/// </summary>
		/// <param name="_ctrMenuActItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrMenuActItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrMenuActItem GetByCtrMenuActItemId(System.Decimal _ctrMenuActItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByCtrMenuActItemId(null, _ctrMenuActItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_MENU_ACT_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrMenuActItemId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrMenuActItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrMenuActItem GetByCtrMenuActItemId(TransactionManager transactionManager, System.Decimal _ctrMenuActItemId)
		{
			int count = -1;
			return GetByCtrMenuActItemId(transactionManager, _ctrMenuActItemId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_MENU_ACT_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrMenuActItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrMenuActItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrMenuActItem GetByCtrMenuActItemId(TransactionManager transactionManager, System.Decimal _ctrMenuActItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByCtrMenuActItemId(transactionManager, _ctrMenuActItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_MENU_ACT_ITEM index.
		/// </summary>
		/// <param name="_ctrMenuActItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrMenuActItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrMenuActItem GetByCtrMenuActItemId(System.Decimal _ctrMenuActItemId, int start, int pageLength, out int count)
		{
			return GetByCtrMenuActItemId(null, _ctrMenuActItemId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_MENU_ACT_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrMenuActItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrMenuActItem"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.CtrMenuActItem GetByCtrMenuActItemId(TransactionManager transactionManager, System.Decimal _ctrMenuActItemId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;CtrMenuActItem&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;CtrMenuActItem&gt;"/></returns>
		public static TList<CtrMenuActItem> Fill(IDataReader reader, TList<CtrMenuActItem> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.CtrMenuActItem c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("CtrMenuActItem")
					.Append("|").Append((System.Decimal)reader["CTR_MENU_ACT_ITEM_ID"]).ToString();
					c = EntityManager.LocateOrCreate<CtrMenuActItem>(
					key.ToString(), // EntityTrackingKey
					"CtrMenuActItem",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.CtrMenuActItem();
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
					c.CtrMenuActItemId = (System.Decimal)reader["CTR_MENU_ACT_ITEM_ID"];
					c.OriginalCtrMenuActItemId = c.CtrMenuActItemId;
					c.CtrMenuActId = (System.Decimal)reader["CTR_MENU_ACT_ID"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.CtrMenuActItem"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CtrMenuActItem"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.CtrMenuActItem entity)
		{
			if (!reader.Read()) return;
			
			entity.CtrMenuActItemId = (System.Decimal)reader[((int)CtrMenuActItemColumn.CtrMenuActItemId - 1)];
			entity.OriginalCtrMenuActItemId = (System.Decimal)reader["CTR_MENU_ACT_ITEM_ID"];
			entity.CtrMenuActId = (System.Decimal)reader[((int)CtrMenuActItemColumn.CtrMenuActId - 1)];
			entity.CtrCdeMealItemId = (System.Decimal)reader[((int)CtrMenuActItemColumn.CtrCdeMealItemId - 1)];
			entity.UnitCount = (reader.IsDBNull(((int)CtrMenuActItemColumn.UnitCount - 1)))?null:(System.Decimal?)reader[((int)CtrMenuActItemColumn.UnitCount - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.CtrMenuActItem"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CtrMenuActItem"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.CtrMenuActItem entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.CtrMenuActItemId = (System.Decimal)dataRow["CTR_MENU_ACT_ITEM_ID"];
			entity.OriginalCtrMenuActItemId = (System.Decimal)dataRow["CTR_MENU_ACT_ITEM_ID"];
			entity.CtrMenuActId = (System.Decimal)dataRow["CTR_MENU_ACT_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CtrMenuActItem"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.CtrMenuActItem Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CtrMenuActItem entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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

			#region CtrMenuActIdSource	
			if (CanDeepLoad(entity, "CtrMenuAct|CtrMenuActIdSource", deepLoadType, innerList) 
				&& entity.CtrMenuActIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.CtrMenuActId;
				CtrMenuAct tmpEntity = EntityManager.LocateEntity<CtrMenuAct>(EntityLocator.ConstructKeyFromPkItems(typeof(CtrMenuAct), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.CtrMenuActIdSource = tmpEntity;
				else
					entity.CtrMenuActIdSource = DataRepository.CtrMenuActProvider.GetByCtrMenuActId(transactionManager, entity.CtrMenuActId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CtrMenuActIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.CtrMenuActIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.CtrMenuActProvider.DeepLoad(transactionManager, entity.CtrMenuActIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion CtrMenuActIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.CtrMenuActItem object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.CtrMenuActItem instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.CtrMenuActItem Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CtrMenuActItem entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region CtrMenuActIdSource
			if (CanDeepSave(entity, "CtrMenuAct|CtrMenuActIdSource", deepSaveType, innerList) 
				&& entity.CtrMenuActIdSource != null)
			{
				DataRepository.CtrMenuActProvider.Save(transactionManager, entity.CtrMenuActIdSource);
				entity.CtrMenuActId = entity.CtrMenuActIdSource.CtrMenuActId;
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
	
	#region CtrMenuActItemChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.CtrMenuActItem</c>
	///</summary>
	public enum CtrMenuActItemChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>CtrCdeMealItem</c> at CtrCdeMealItemIdSource
		///</summary>
		[ChildEntityType(typeof(CtrCdeMealItem))]
		CtrCdeMealItem,
		
		///<summary>
		/// Composite Property for <c>CtrMenuAct</c> at CtrMenuActIdSource
		///</summary>
		[ChildEntityType(typeof(CtrMenuAct))]
		CtrMenuAct,
	}
	
	#endregion CtrMenuActItemChildEntityTypes
	
	#region CtrMenuActItemFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;CtrMenuActItemColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CtrMenuActItem"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CtrMenuActItemFilterBuilder : SqlFilterBuilder<CtrMenuActItemColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CtrMenuActItemFilterBuilder class.
		/// </summary>
		public CtrMenuActItemFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CtrMenuActItemFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CtrMenuActItemFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CtrMenuActItemFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CtrMenuActItemFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CtrMenuActItemFilterBuilder
	
	#region CtrMenuActItemParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;CtrMenuActItemColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CtrMenuActItem"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CtrMenuActItemParameterBuilder : ParameterizedSqlFilterBuilder<CtrMenuActItemColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CtrMenuActItemParameterBuilder class.
		/// </summary>
		public CtrMenuActItemParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CtrMenuActItemParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CtrMenuActItemParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CtrMenuActItemParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CtrMenuActItemParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CtrMenuActItemParameterBuilder
	
	#region CtrMenuActItemSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;CtrMenuActItemColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CtrMenuActItem"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class CtrMenuActItemSortBuilder : SqlSortBuilder<CtrMenuActItemColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CtrMenuActItemSqlSortBuilder class.
		/// </summary>
		public CtrMenuActItemSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion CtrMenuActItemSortBuilder
	
} // end namespace
