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
	/// This class is the base class for any <see cref="EdStudClrncItemProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdStudClrncItemProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdStudClrncItem, UMIS_VER2.BusinessLyer.EdStudClrncItemKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudClrncItemKey key)
		{
			return Delete(transactionManager, key.EdStudClrncItemId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edStudClrncItemId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edStudClrncItemId)
		{
			return Delete(null, _edStudClrncItemId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudClrncItemId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edStudClrncItemId);		
		
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
		public override UMIS_VER2.BusinessLyer.EdStudClrncItem Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudClrncItemKey key, int start, int pageLength)
		{
			return GetByEdStudClrncItemId(transactionManager, key.EdStudClrncItemId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_STUD_CLRNC_REQ_ID_1 index.
		/// </summary>
		/// <param name="_edStudClrncReqId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudClrncItem&gt;"/> class.</returns>
		public TList<EdStudClrncItem> GetByEdStudClrncReqId(System.Decimal _edStudClrncReqId)
		{
			int count = -1;
			return GetByEdStudClrncReqId(null,_edStudClrncReqId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_CLRNC_REQ_ID_1 index.
		/// </summary>
		/// <param name="_edStudClrncReqId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudClrncItem&gt;"/> class.</returns>
		public TList<EdStudClrncItem> GetByEdStudClrncReqId(System.Decimal _edStudClrncReqId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudClrncReqId(null, _edStudClrncReqId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_CLRNC_REQ_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudClrncReqId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudClrncItem&gt;"/> class.</returns>
		public TList<EdStudClrncItem> GetByEdStudClrncReqId(TransactionManager transactionManager, System.Decimal _edStudClrncReqId)
		{
			int count = -1;
			return GetByEdStudClrncReqId(transactionManager, _edStudClrncReqId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_CLRNC_REQ_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudClrncReqId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudClrncItem&gt;"/> class.</returns>
		public TList<EdStudClrncItem> GetByEdStudClrncReqId(TransactionManager transactionManager, System.Decimal _edStudClrncReqId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudClrncReqId(transactionManager, _edStudClrncReqId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_CLRNC_REQ_ID_1 index.
		/// </summary>
		/// <param name="_edStudClrncReqId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudClrncItem&gt;"/> class.</returns>
		public TList<EdStudClrncItem> GetByEdStudClrncReqId(System.Decimal _edStudClrncReqId, int start, int pageLength, out int count)
		{
			return GetByEdStudClrncReqId(null, _edStudClrncReqId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_CLRNC_REQ_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudClrncReqId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudClrncItem&gt;"/> class.</returns>
		public abstract TList<EdStudClrncItem> GetByEdStudClrncReqId(TransactionManager transactionManager, System.Decimal _edStudClrncReqId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_GS_CDE_CLRNC_ITEM_ID_1 index.
		/// </summary>
		/// <param name="_gsCdeClrncItemId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudClrncItem&gt;"/> class.</returns>
		public TList<EdStudClrncItem> GetByGsCdeClrncItemId(System.Decimal _gsCdeClrncItemId)
		{
			int count = -1;
			return GetByGsCdeClrncItemId(null,_gsCdeClrncItemId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CDE_CLRNC_ITEM_ID_1 index.
		/// </summary>
		/// <param name="_gsCdeClrncItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudClrncItem&gt;"/> class.</returns>
		public TList<EdStudClrncItem> GetByGsCdeClrncItemId(System.Decimal _gsCdeClrncItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeClrncItemId(null, _gsCdeClrncItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CDE_CLRNC_ITEM_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeClrncItemId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudClrncItem&gt;"/> class.</returns>
		public TList<EdStudClrncItem> GetByGsCdeClrncItemId(TransactionManager transactionManager, System.Decimal _gsCdeClrncItemId)
		{
			int count = -1;
			return GetByGsCdeClrncItemId(transactionManager, _gsCdeClrncItemId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CDE_CLRNC_ITEM_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeClrncItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudClrncItem&gt;"/> class.</returns>
		public TList<EdStudClrncItem> GetByGsCdeClrncItemId(TransactionManager transactionManager, System.Decimal _gsCdeClrncItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeClrncItemId(transactionManager, _gsCdeClrncItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CDE_CLRNC_ITEM_ID_1 index.
		/// </summary>
		/// <param name="_gsCdeClrncItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudClrncItem&gt;"/> class.</returns>
		public TList<EdStudClrncItem> GetByGsCdeClrncItemId(System.Decimal _gsCdeClrncItemId, int start, int pageLength, out int count)
		{
			return GetByGsCdeClrncItemId(null, _gsCdeClrncItemId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CDE_CLRNC_ITEM_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeClrncItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudClrncItem&gt;"/> class.</returns>
		public abstract TList<EdStudClrncItem> GetByGsCdeClrncItemId(TransactionManager transactionManager, System.Decimal _gsCdeClrncItemId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_STUD_DISCHARGE_ITEM index.
		/// </summary>
		/// <param name="_edStudClrncItemId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudClrncItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudClrncItem GetByEdStudClrncItemId(System.Decimal _edStudClrncItemId)
		{
			int count = -1;
			return GetByEdStudClrncItemId(null,_edStudClrncItemId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_DISCHARGE_ITEM index.
		/// </summary>
		/// <param name="_edStudClrncItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudClrncItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudClrncItem GetByEdStudClrncItemId(System.Decimal _edStudClrncItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudClrncItemId(null, _edStudClrncItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_DISCHARGE_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudClrncItemId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudClrncItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudClrncItem GetByEdStudClrncItemId(TransactionManager transactionManager, System.Decimal _edStudClrncItemId)
		{
			int count = -1;
			return GetByEdStudClrncItemId(transactionManager, _edStudClrncItemId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_DISCHARGE_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudClrncItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudClrncItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudClrncItem GetByEdStudClrncItemId(TransactionManager transactionManager, System.Decimal _edStudClrncItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudClrncItemId(transactionManager, _edStudClrncItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_DISCHARGE_ITEM index.
		/// </summary>
		/// <param name="_edStudClrncItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudClrncItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudClrncItem GetByEdStudClrncItemId(System.Decimal _edStudClrncItemId, int start, int pageLength, out int count)
		{
			return GetByEdStudClrncItemId(null, _edStudClrncItemId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_DISCHARGE_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudClrncItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudClrncItem"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdStudClrncItem GetByEdStudClrncItemId(TransactionManager transactionManager, System.Decimal _edStudClrncItemId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdStudClrncItem&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdStudClrncItem&gt;"/></returns>
		public static TList<EdStudClrncItem> Fill(IDataReader reader, TList<EdStudClrncItem> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdStudClrncItem c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdStudClrncItem")
					.Append("|").Append((System.Decimal)reader["ED_STUD_CLRNC_ITEM_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdStudClrncItem>(
					key.ToString(), // EntityTrackingKey
					"EdStudClrncItem",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdStudClrncItem();
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
					c.EdStudClrncItemId = (System.Decimal)reader["ED_STUD_CLRNC_ITEM_ID"];
					c.OriginalEdStudClrncItemId = c.EdStudClrncItemId;
					c.EdStudClrncReqId = (System.Decimal)reader["ED_STUD_CLRNC_REQ_ID"];
					c.GsCdeClrncItemId = (System.Decimal)reader["GS_CDE_CLRNC_ITEM_ID"];
					c.OwnerName = Convert.IsDBNull(reader["OWNER_NAME"]) ? null : (System.String)reader["OWNER_NAME"];
					c.ConfirmDate = Convert.IsDBNull(reader["CONFIRM_DATE"]) ? null : (System.DateTime?)reader["CONFIRM_DATE"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudClrncItem"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudClrncItem"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdStudClrncItem entity)
		{
			if (!reader.Read()) return;
			
			entity.EdStudClrncItemId = (System.Decimal)reader[((int)EdStudClrncItemColumn.EdStudClrncItemId - 1)];
			entity.OriginalEdStudClrncItemId = (System.Decimal)reader["ED_STUD_CLRNC_ITEM_ID"];
			entity.EdStudClrncReqId = (System.Decimal)reader[((int)EdStudClrncItemColumn.EdStudClrncReqId - 1)];
			entity.GsCdeClrncItemId = (System.Decimal)reader[((int)EdStudClrncItemColumn.GsCdeClrncItemId - 1)];
			entity.OwnerName = (reader.IsDBNull(((int)EdStudClrncItemColumn.OwnerName - 1)))?null:(System.String)reader[((int)EdStudClrncItemColumn.OwnerName - 1)];
			entity.ConfirmDate = (reader.IsDBNull(((int)EdStudClrncItemColumn.ConfirmDate - 1)))?null:(System.DateTime?)reader[((int)EdStudClrncItemColumn.ConfirmDate - 1)];
			entity.Notes = (reader.IsDBNull(((int)EdStudClrncItemColumn.Notes - 1)))?null:(System.String)reader[((int)EdStudClrncItemColumn.Notes - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudClrncItem"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudClrncItem"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdStudClrncItem entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdStudClrncItemId = (System.Decimal)dataRow["ED_STUD_CLRNC_ITEM_ID"];
			entity.OriginalEdStudClrncItemId = (System.Decimal)dataRow["ED_STUD_CLRNC_ITEM_ID"];
			entity.EdStudClrncReqId = (System.Decimal)dataRow["ED_STUD_CLRNC_REQ_ID"];
			entity.GsCdeClrncItemId = (System.Decimal)dataRow["GS_CDE_CLRNC_ITEM_ID"];
			entity.OwnerName = Convert.IsDBNull(dataRow["OWNER_NAME"]) ? null : (System.String)dataRow["OWNER_NAME"];
			entity.ConfirmDate = Convert.IsDBNull(dataRow["CONFIRM_DATE"]) ? null : (System.DateTime?)dataRow["CONFIRM_DATE"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudClrncItem"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudClrncItem Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudClrncItem entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdStudClrncReqIdSource	
			if (CanDeepLoad(entity, "EdStudClrncReq|EdStudClrncReqIdSource", deepLoadType, innerList) 
				&& entity.EdStudClrncReqIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdStudClrncReqId;
				EdStudClrncReq tmpEntity = EntityManager.LocateEntity<EdStudClrncReq>(EntityLocator.ConstructKeyFromPkItems(typeof(EdStudClrncReq), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdStudClrncReqIdSource = tmpEntity;
				else
					entity.EdStudClrncReqIdSource = DataRepository.EdStudClrncReqProvider.GetByEdStudClrncReqId(transactionManager, entity.EdStudClrncReqId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudClrncReqIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdStudClrncReqIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdStudClrncReqProvider.DeepLoad(transactionManager, entity.EdStudClrncReqIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdStudClrncReqIdSource

			#region GsCdeClrncItemIdSource	
			if (CanDeepLoad(entity, "GsCdeClrncItem|GsCdeClrncItemIdSource", deepLoadType, innerList) 
				&& entity.GsCdeClrncItemIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.GsCdeClrncItemId;
				GsCdeClrncItem tmpEntity = EntityManager.LocateEntity<GsCdeClrncItem>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCdeClrncItem), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCdeClrncItemIdSource = tmpEntity;
				else
					entity.GsCdeClrncItemIdSource = DataRepository.GsCdeClrncItemProvider.GetByGsCdeClrncItemId(transactionManager, entity.GsCdeClrncItemId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCdeClrncItemIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCdeClrncItemIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCdeClrncItemProvider.DeepLoad(transactionManager, entity.GsCdeClrncItemIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCdeClrncItemIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdStudClrncItem object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdStudClrncItem instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudClrncItem Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudClrncItem entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdStudClrncReqIdSource
			if (CanDeepSave(entity, "EdStudClrncReq|EdStudClrncReqIdSource", deepSaveType, innerList) 
				&& entity.EdStudClrncReqIdSource != null)
			{
				DataRepository.EdStudClrncReqProvider.Save(transactionManager, entity.EdStudClrncReqIdSource);
				entity.EdStudClrncReqId = entity.EdStudClrncReqIdSource.EdStudClrncReqId;
			}
			#endregion 
			
			#region GsCdeClrncItemIdSource
			if (CanDeepSave(entity, "GsCdeClrncItem|GsCdeClrncItemIdSource", deepSaveType, innerList) 
				&& entity.GsCdeClrncItemIdSource != null)
			{
				DataRepository.GsCdeClrncItemProvider.Save(transactionManager, entity.GsCdeClrncItemIdSource);
				entity.GsCdeClrncItemId = entity.GsCdeClrncItemIdSource.GsCdeClrncItemId;
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
	
	#region EdStudClrncItemChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdStudClrncItem</c>
	///</summary>
	public enum EdStudClrncItemChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdStudClrncReq</c> at EdStudClrncReqIdSource
		///</summary>
		[ChildEntityType(typeof(EdStudClrncReq))]
		EdStudClrncReq,
		
		///<summary>
		/// Composite Property for <c>GsCdeClrncItem</c> at GsCdeClrncItemIdSource
		///</summary>
		[ChildEntityType(typeof(GsCdeClrncItem))]
		GsCdeClrncItem,
	}
	
	#endregion EdStudClrncItemChildEntityTypes
	
	#region EdStudClrncItemFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdStudClrncItemColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudClrncItem"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudClrncItemFilterBuilder : SqlFilterBuilder<EdStudClrncItemColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudClrncItemFilterBuilder class.
		/// </summary>
		public EdStudClrncItemFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudClrncItemFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudClrncItemFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudClrncItemFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudClrncItemFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudClrncItemFilterBuilder
	
	#region EdStudClrncItemParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdStudClrncItemColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudClrncItem"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudClrncItemParameterBuilder : ParameterizedSqlFilterBuilder<EdStudClrncItemColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudClrncItemParameterBuilder class.
		/// </summary>
		public EdStudClrncItemParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudClrncItemParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudClrncItemParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudClrncItemParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudClrncItemParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudClrncItemParameterBuilder
	
	#region EdStudClrncItemSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdStudClrncItemColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudClrncItem"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdStudClrncItemSortBuilder : SqlSortBuilder<EdStudClrncItemColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudClrncItemSqlSortBuilder class.
		/// </summary>
		public EdStudClrncItemSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdStudClrncItemSortBuilder
	
} // end namespace
