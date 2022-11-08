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
	/// This class is the base class for any <see cref="CtrCdeItemTypeProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class CtrCdeItemTypeProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.CtrCdeItemType, UMIS_VER2.BusinessLyer.CtrCdeItemTypeKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CtrCdeItemTypeKey key)
		{
			return Delete(transactionManager, key.CtrCdeItemTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_ctrCdeItemTypeId">نوع عناصر الطعام. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _ctrCdeItemTypeId)
		{
			return Delete(null, _ctrCdeItemTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrCdeItemTypeId">نوع عناصر الطعام. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _ctrCdeItemTypeId);		
		
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
		public override UMIS_VER2.BusinessLyer.CtrCdeItemType Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CtrCdeItemTypeKey key, int start, int pageLength)
		{
			return GetByCtrCdeItemTypeId(transactionManager, key.CtrCdeItemTypeId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_CTR_CDE_ITEM_TYPE index.
		/// </summary>
		/// <param name="_ctrCdeItemTypeId">نوع عناصر الطعام</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeItemType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeItemType GetByCtrCdeItemTypeId(System.Decimal _ctrCdeItemTypeId)
		{
			int count = -1;
			return GetByCtrCdeItemTypeId(null,_ctrCdeItemTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_CDE_ITEM_TYPE index.
		/// </summary>
		/// <param name="_ctrCdeItemTypeId">نوع عناصر الطعام</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeItemType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeItemType GetByCtrCdeItemTypeId(System.Decimal _ctrCdeItemTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByCtrCdeItemTypeId(null, _ctrCdeItemTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_CDE_ITEM_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrCdeItemTypeId">نوع عناصر الطعام</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeItemType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeItemType GetByCtrCdeItemTypeId(TransactionManager transactionManager, System.Decimal _ctrCdeItemTypeId)
		{
			int count = -1;
			return GetByCtrCdeItemTypeId(transactionManager, _ctrCdeItemTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_CDE_ITEM_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrCdeItemTypeId">نوع عناصر الطعام</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeItemType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeItemType GetByCtrCdeItemTypeId(TransactionManager transactionManager, System.Decimal _ctrCdeItemTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByCtrCdeItemTypeId(transactionManager, _ctrCdeItemTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_CDE_ITEM_TYPE index.
		/// </summary>
		/// <param name="_ctrCdeItemTypeId">نوع عناصر الطعام</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeItemType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeItemType GetByCtrCdeItemTypeId(System.Decimal _ctrCdeItemTypeId, int start, int pageLength, out int count)
		{
			return GetByCtrCdeItemTypeId(null, _ctrCdeItemTypeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_CDE_ITEM_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrCdeItemTypeId">نوع عناصر الطعام</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeItemType"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.CtrCdeItemType GetByCtrCdeItemTypeId(TransactionManager transactionManager, System.Decimal _ctrCdeItemTypeId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_CTR_CDE_ITEM_TYPE_AR index.
		/// </summary>
		/// <param name="_itemTypeAr">بروتين-خضار-فواكه-نشويات</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeItemType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeItemType GetByItemTypeAr(System.String _itemTypeAr)
		{
			int count = -1;
			return GetByItemTypeAr(null,_itemTypeAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_CTR_CDE_ITEM_TYPE_AR index.
		/// </summary>
		/// <param name="_itemTypeAr">بروتين-خضار-فواكه-نشويات</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeItemType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeItemType GetByItemTypeAr(System.String _itemTypeAr, int start, int pageLength)
		{
			int count = -1;
			return GetByItemTypeAr(null, _itemTypeAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_CTR_CDE_ITEM_TYPE_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_itemTypeAr">بروتين-خضار-فواكه-نشويات</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeItemType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeItemType GetByItemTypeAr(TransactionManager transactionManager, System.String _itemTypeAr)
		{
			int count = -1;
			return GetByItemTypeAr(transactionManager, _itemTypeAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_CTR_CDE_ITEM_TYPE_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_itemTypeAr">بروتين-خضار-فواكه-نشويات</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeItemType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeItemType GetByItemTypeAr(TransactionManager transactionManager, System.String _itemTypeAr, int start, int pageLength)
		{
			int count = -1;
			return GetByItemTypeAr(transactionManager, _itemTypeAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_CTR_CDE_ITEM_TYPE_AR index.
		/// </summary>
		/// <param name="_itemTypeAr">بروتين-خضار-فواكه-نشويات</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeItemType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeItemType GetByItemTypeAr(System.String _itemTypeAr, int start, int pageLength, out int count)
		{
			return GetByItemTypeAr(null, _itemTypeAr, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_CTR_CDE_ITEM_TYPE_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_itemTypeAr">بروتين-خضار-فواكه-نشويات</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeItemType"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.CtrCdeItemType GetByItemTypeAr(TransactionManager transactionManager, System.String _itemTypeAr, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_CTR_CDE_ITEM_TYPE_EN index.
		/// </summary>
		/// <param name="_itemTypeEn"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeItemType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeItemType GetByItemTypeEn(System.String _itemTypeEn)
		{
			int count = -1;
			return GetByItemTypeEn(null,_itemTypeEn, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_CTR_CDE_ITEM_TYPE_EN index.
		/// </summary>
		/// <param name="_itemTypeEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeItemType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeItemType GetByItemTypeEn(System.String _itemTypeEn, int start, int pageLength)
		{
			int count = -1;
			return GetByItemTypeEn(null, _itemTypeEn, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_CTR_CDE_ITEM_TYPE_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_itemTypeEn"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeItemType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeItemType GetByItemTypeEn(TransactionManager transactionManager, System.String _itemTypeEn)
		{
			int count = -1;
			return GetByItemTypeEn(transactionManager, _itemTypeEn, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_CTR_CDE_ITEM_TYPE_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_itemTypeEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeItemType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeItemType GetByItemTypeEn(TransactionManager transactionManager, System.String _itemTypeEn, int start, int pageLength)
		{
			int count = -1;
			return GetByItemTypeEn(transactionManager, _itemTypeEn, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_CTR_CDE_ITEM_TYPE_EN index.
		/// </summary>
		/// <param name="_itemTypeEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeItemType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeItemType GetByItemTypeEn(System.String _itemTypeEn, int start, int pageLength, out int count)
		{
			return GetByItemTypeEn(null, _itemTypeEn, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_CTR_CDE_ITEM_TYPE_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_itemTypeEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeItemType"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.CtrCdeItemType GetByItemTypeEn(TransactionManager transactionManager, System.String _itemTypeEn, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;CtrCdeItemType&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;CtrCdeItemType&gt;"/></returns>
		public static TList<CtrCdeItemType> Fill(IDataReader reader, TList<CtrCdeItemType> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.CtrCdeItemType c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("CtrCdeItemType")
					.Append("|").Append((System.Decimal)reader["CTR_CDE_ITEM_TYPE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<CtrCdeItemType>(
					key.ToString(), // EntityTrackingKey
					"CtrCdeItemType",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.CtrCdeItemType();
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
					c.CtrCdeItemTypeId = (System.Decimal)reader["CTR_CDE_ITEM_TYPE_ID"];
					c.OriginalCtrCdeItemTypeId = c.CtrCdeItemTypeId;
					c.ItemTypeAr = (System.String)reader["ITEM_TYPE_AR"];
					c.ItemTypeEn = (System.String)reader["ITEM_TYPE_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.CtrCdeItemType"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CtrCdeItemType"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.CtrCdeItemType entity)
		{
			if (!reader.Read()) return;
			
			entity.CtrCdeItemTypeId = (System.Decimal)reader[((int)CtrCdeItemTypeColumn.CtrCdeItemTypeId - 1)];
			entity.OriginalCtrCdeItemTypeId = (System.Decimal)reader["CTR_CDE_ITEM_TYPE_ID"];
			entity.ItemTypeAr = (System.String)reader[((int)CtrCdeItemTypeColumn.ItemTypeAr - 1)];
			entity.ItemTypeEn = (System.String)reader[((int)CtrCdeItemTypeColumn.ItemTypeEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.CtrCdeItemType"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CtrCdeItemType"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.CtrCdeItemType entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.CtrCdeItemTypeId = (System.Decimal)dataRow["CTR_CDE_ITEM_TYPE_ID"];
			entity.OriginalCtrCdeItemTypeId = (System.Decimal)dataRow["CTR_CDE_ITEM_TYPE_ID"];
			entity.ItemTypeAr = (System.String)dataRow["ITEM_TYPE_AR"];
			entity.ItemTypeEn = (System.String)dataRow["ITEM_TYPE_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CtrCdeItemType"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.CtrCdeItemType Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CtrCdeItemType entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByCtrCdeItemTypeId methods when available
			
			#region CtrCdeMealItemCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<CtrCdeMealItem>|CtrCdeMealItemCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CtrCdeMealItemCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.CtrCdeMealItemCollection = DataRepository.CtrCdeMealItemProvider.GetByCtrCdeItemTypeId(transactionManager, entity.CtrCdeItemTypeId);

				if (deep && entity.CtrCdeMealItemCollection.Count > 0)
				{
					deepHandles.Add("CtrCdeMealItemCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CtrCdeMealItem>) DataRepository.CtrCdeMealItemProvider.DeepLoad,
						new object[] { transactionManager, entity.CtrCdeMealItemCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.CtrCdeItemType object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.CtrCdeItemType instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.CtrCdeItemType Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CtrCdeItemType entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<CtrCdeMealItem>
				if (CanDeepSave(entity.CtrCdeMealItemCollection, "List<CtrCdeMealItem>|CtrCdeMealItemCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CtrCdeMealItem child in entity.CtrCdeMealItemCollection)
					{
						if(child.CtrCdeItemTypeIdSource != null)
						{
							child.CtrCdeItemTypeId = child.CtrCdeItemTypeIdSource.CtrCdeItemTypeId;
						}
						else
						{
							child.CtrCdeItemTypeId = entity.CtrCdeItemTypeId;
						}

					}

					if (entity.CtrCdeMealItemCollection.Count > 0 || entity.CtrCdeMealItemCollection.DeletedItems.Count > 0)
					{
						//DataRepository.CtrCdeMealItemProvider.Save(transactionManager, entity.CtrCdeMealItemCollection);
						
						deepHandles.Add("CtrCdeMealItemCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< CtrCdeMealItem >) DataRepository.CtrCdeMealItemProvider.DeepSave,
							new object[] { transactionManager, entity.CtrCdeMealItemCollection, deepSaveType, childTypes, innerList }
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
	
	#region CtrCdeItemTypeChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.CtrCdeItemType</c>
	///</summary>
	public enum CtrCdeItemTypeChildEntityTypes
	{
		///<summary>
		/// Collection of <c>CtrCdeItemType</c> as OneToMany for CtrCdeMealItemCollection
		///</summary>
		[ChildEntityType(typeof(TList<CtrCdeMealItem>))]
		CtrCdeMealItemCollection,
	}
	
	#endregion CtrCdeItemTypeChildEntityTypes
	
	#region CtrCdeItemTypeFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;CtrCdeItemTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CtrCdeItemType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CtrCdeItemTypeFilterBuilder : SqlFilterBuilder<CtrCdeItemTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CtrCdeItemTypeFilterBuilder class.
		/// </summary>
		public CtrCdeItemTypeFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CtrCdeItemTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CtrCdeItemTypeFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CtrCdeItemTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CtrCdeItemTypeFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CtrCdeItemTypeFilterBuilder
	
	#region CtrCdeItemTypeParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;CtrCdeItemTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CtrCdeItemType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CtrCdeItemTypeParameterBuilder : ParameterizedSqlFilterBuilder<CtrCdeItemTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CtrCdeItemTypeParameterBuilder class.
		/// </summary>
		public CtrCdeItemTypeParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CtrCdeItemTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CtrCdeItemTypeParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CtrCdeItemTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CtrCdeItemTypeParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CtrCdeItemTypeParameterBuilder
	
	#region CtrCdeItemTypeSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;CtrCdeItemTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CtrCdeItemType"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class CtrCdeItemTypeSortBuilder : SqlSortBuilder<CtrCdeItemTypeColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CtrCdeItemTypeSqlSortBuilder class.
		/// </summary>
		public CtrCdeItemTypeSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion CtrCdeItemTypeSortBuilder
	
} // end namespace
