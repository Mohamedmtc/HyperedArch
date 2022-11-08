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
	/// This class is the base class for any <see cref="FeeTreasuryItemProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class FeeTreasuryItemProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.FeeTreasuryItem, UMIS_VER2.BusinessLyer.FeeTreasuryItemKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeTreasuryItemKey key)
		{
			return Delete(transactionManager, key.FeeTreasuryItemId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_feeTreasuryItemId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _feeTreasuryItemId)
		{
			return Delete(null, _feeTreasuryItemId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeTreasuryItemId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _feeTreasuryItemId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_TREASURY_ITEM_FEE_CDE_BOND_ITEM key.
		///		FK_FEE_TREASURY_ITEM_FEE_CDE_BOND_ITEM Description: 
		/// </summary>
		/// <param name="_feeCdeBondItemId">تعريف بنود السندات</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeTreasuryItem objects.</returns>
		public TList<FeeTreasuryItem> GetByFeeCdeBondItemId(System.Int32 _feeCdeBondItemId)
		{
			int count = -1;
			return GetByFeeCdeBondItemId(_feeCdeBondItemId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_TREASURY_ITEM_FEE_CDE_BOND_ITEM key.
		///		FK_FEE_TREASURY_ITEM_FEE_CDE_BOND_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeBondItemId">تعريف بنود السندات</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeTreasuryItem objects.</returns>
		/// <remarks></remarks>
		public TList<FeeTreasuryItem> GetByFeeCdeBondItemId(TransactionManager transactionManager, System.Int32 _feeCdeBondItemId)
		{
			int count = -1;
			return GetByFeeCdeBondItemId(transactionManager, _feeCdeBondItemId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_TREASURY_ITEM_FEE_CDE_BOND_ITEM key.
		///		FK_FEE_TREASURY_ITEM_FEE_CDE_BOND_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeBondItemId">تعريف بنود السندات</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeTreasuryItem objects.</returns>
		public TList<FeeTreasuryItem> GetByFeeCdeBondItemId(TransactionManager transactionManager, System.Int32 _feeCdeBondItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCdeBondItemId(transactionManager, _feeCdeBondItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_TREASURY_ITEM_FEE_CDE_BOND_ITEM key.
		///		fkFeeTreasuryItemFeeCdeBondItem Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeCdeBondItemId">تعريف بنود السندات</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeTreasuryItem objects.</returns>
		public TList<FeeTreasuryItem> GetByFeeCdeBondItemId(System.Int32 _feeCdeBondItemId, int start, int pageLength)
		{
			int count =  -1;
			return GetByFeeCdeBondItemId(null, _feeCdeBondItemId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_TREASURY_ITEM_FEE_CDE_BOND_ITEM key.
		///		fkFeeTreasuryItemFeeCdeBondItem Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeCdeBondItemId">تعريف بنود السندات</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeTreasuryItem objects.</returns>
		public TList<FeeTreasuryItem> GetByFeeCdeBondItemId(System.Int32 _feeCdeBondItemId, int start, int pageLength,out int count)
		{
			return GetByFeeCdeBondItemId(null, _feeCdeBondItemId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_TREASURY_ITEM_FEE_CDE_BOND_ITEM key.
		///		FK_FEE_TREASURY_ITEM_FEE_CDE_BOND_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeBondItemId">تعريف بنود السندات</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeTreasuryItem objects.</returns>
		public abstract TList<FeeTreasuryItem> GetByFeeCdeBondItemId(TransactionManager transactionManager, System.Int32 _feeCdeBondItemId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_TREASURY_ITEM_FEE_TREASURY_REQ key.
		///		FK_FEE_TREASURY_ITEM_FEE_TREASURY_REQ Description: 
		/// </summary>
		/// <param name="_feeTreasuryReqId">طلبات الاستعاضه  للخزنة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeTreasuryItem objects.</returns>
		public TList<FeeTreasuryItem> GetByFeeTreasuryReqId(System.Decimal _feeTreasuryReqId)
		{
			int count = -1;
			return GetByFeeTreasuryReqId(_feeTreasuryReqId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_TREASURY_ITEM_FEE_TREASURY_REQ key.
		///		FK_FEE_TREASURY_ITEM_FEE_TREASURY_REQ Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeTreasuryReqId">طلبات الاستعاضه  للخزنة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeTreasuryItem objects.</returns>
		/// <remarks></remarks>
		public TList<FeeTreasuryItem> GetByFeeTreasuryReqId(TransactionManager transactionManager, System.Decimal _feeTreasuryReqId)
		{
			int count = -1;
			return GetByFeeTreasuryReqId(transactionManager, _feeTreasuryReqId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_TREASURY_ITEM_FEE_TREASURY_REQ key.
		///		FK_FEE_TREASURY_ITEM_FEE_TREASURY_REQ Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeTreasuryReqId">طلبات الاستعاضه  للخزنة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeTreasuryItem objects.</returns>
		public TList<FeeTreasuryItem> GetByFeeTreasuryReqId(TransactionManager transactionManager, System.Decimal _feeTreasuryReqId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeTreasuryReqId(transactionManager, _feeTreasuryReqId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_TREASURY_ITEM_FEE_TREASURY_REQ key.
		///		fkFeeTreasuryItemFeeTreasuryReq Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeTreasuryReqId">طلبات الاستعاضه  للخزنة</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeTreasuryItem objects.</returns>
		public TList<FeeTreasuryItem> GetByFeeTreasuryReqId(System.Decimal _feeTreasuryReqId, int start, int pageLength)
		{
			int count =  -1;
			return GetByFeeTreasuryReqId(null, _feeTreasuryReqId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_TREASURY_ITEM_FEE_TREASURY_REQ key.
		///		fkFeeTreasuryItemFeeTreasuryReq Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeTreasuryReqId">طلبات الاستعاضه  للخزنة</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeTreasuryItem objects.</returns>
		public TList<FeeTreasuryItem> GetByFeeTreasuryReqId(System.Decimal _feeTreasuryReqId, int start, int pageLength,out int count)
		{
			return GetByFeeTreasuryReqId(null, _feeTreasuryReqId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_TREASURY_ITEM_FEE_TREASURY_REQ key.
		///		FK_FEE_TREASURY_ITEM_FEE_TREASURY_REQ Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeTreasuryReqId">طلبات الاستعاضه  للخزنة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeTreasuryItem objects.</returns>
		public abstract TList<FeeTreasuryItem> GetByFeeTreasuryReqId(TransactionManager transactionManager, System.Decimal _feeTreasuryReqId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.FeeTreasuryItem Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeTreasuryItemKey key, int start, int pageLength)
		{
			return GetByFeeTreasuryItemId(transactionManager, key.FeeTreasuryItemId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_FEE_TREASURY_ITEM index.
		/// </summary>
		/// <param name="_feeTreasuryItemId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeTreasuryItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeTreasuryItem GetByFeeTreasuryItemId(System.Decimal _feeTreasuryItemId)
		{
			int count = -1;
			return GetByFeeTreasuryItemId(null,_feeTreasuryItemId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_TREASURY_ITEM index.
		/// </summary>
		/// <param name="_feeTreasuryItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeTreasuryItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeTreasuryItem GetByFeeTreasuryItemId(System.Decimal _feeTreasuryItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeTreasuryItemId(null, _feeTreasuryItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_TREASURY_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeTreasuryItemId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeTreasuryItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeTreasuryItem GetByFeeTreasuryItemId(TransactionManager transactionManager, System.Decimal _feeTreasuryItemId)
		{
			int count = -1;
			return GetByFeeTreasuryItemId(transactionManager, _feeTreasuryItemId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_TREASURY_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeTreasuryItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeTreasuryItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeTreasuryItem GetByFeeTreasuryItemId(TransactionManager transactionManager, System.Decimal _feeTreasuryItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeTreasuryItemId(transactionManager, _feeTreasuryItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_TREASURY_ITEM index.
		/// </summary>
		/// <param name="_feeTreasuryItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeTreasuryItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeTreasuryItem GetByFeeTreasuryItemId(System.Decimal _feeTreasuryItemId, int start, int pageLength, out int count)
		{
			return GetByFeeTreasuryItemId(null, _feeTreasuryItemId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_TREASURY_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeTreasuryItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeTreasuryItem"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.FeeTreasuryItem GetByFeeTreasuryItemId(TransactionManager transactionManager, System.Decimal _feeTreasuryItemId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;FeeTreasuryItem&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;FeeTreasuryItem&gt;"/></returns>
		public static TList<FeeTreasuryItem> Fill(IDataReader reader, TList<FeeTreasuryItem> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.FeeTreasuryItem c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("FeeTreasuryItem")
					.Append("|").Append((System.Decimal)reader["FEE_TREASURY_ITEM_ID"]).ToString();
					c = EntityManager.LocateOrCreate<FeeTreasuryItem>(
					key.ToString(), // EntityTrackingKey
					"FeeTreasuryItem",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.FeeTreasuryItem();
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
					c.FeeTreasuryItemId = (System.Decimal)reader["FEE_TREASURY_ITEM_ID"];
					c.OriginalFeeTreasuryItemId = c.FeeTreasuryItemId;
					c.FeeTreasuryReqId = (System.Decimal)reader["FEE_TREASURY_REQ_ID"];
					c.FeeCdeBondItemId = (System.Int32)reader["FEE_CDE_BOND_ITEM_ID"];
					c.BondItemAmount = (System.Decimal)reader["BOND_ITEM_AMOUNT"];
					c.SeUserId = Convert.IsDBNull(reader["SE_USER_ID"]) ? null : (System.Decimal?)reader["SE_USER_ID"];
					c.LastDate = Convert.IsDBNull(reader["LAST_DATE"]) ? null : (System.DateTime?)reader["LAST_DATE"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeTreasuryItem"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeTreasuryItem"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.FeeTreasuryItem entity)
		{
			if (!reader.Read()) return;
			
			entity.FeeTreasuryItemId = (System.Decimal)reader[((int)FeeTreasuryItemColumn.FeeTreasuryItemId - 1)];
			entity.OriginalFeeTreasuryItemId = (System.Decimal)reader["FEE_TREASURY_ITEM_ID"];
			entity.FeeTreasuryReqId = (System.Decimal)reader[((int)FeeTreasuryItemColumn.FeeTreasuryReqId - 1)];
			entity.FeeCdeBondItemId = (System.Int32)reader[((int)FeeTreasuryItemColumn.FeeCdeBondItemId - 1)];
			entity.BondItemAmount = (System.Decimal)reader[((int)FeeTreasuryItemColumn.BondItemAmount - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)FeeTreasuryItemColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)FeeTreasuryItemColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)FeeTreasuryItemColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)FeeTreasuryItemColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeTreasuryItem"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeTreasuryItem"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.FeeTreasuryItem entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.FeeTreasuryItemId = (System.Decimal)dataRow["FEE_TREASURY_ITEM_ID"];
			entity.OriginalFeeTreasuryItemId = (System.Decimal)dataRow["FEE_TREASURY_ITEM_ID"];
			entity.FeeTreasuryReqId = (System.Decimal)dataRow["FEE_TREASURY_REQ_ID"];
			entity.FeeCdeBondItemId = (System.Int32)dataRow["FEE_CDE_BOND_ITEM_ID"];
			entity.BondItemAmount = (System.Decimal)dataRow["BOND_ITEM_AMOUNT"];
			entity.SeUserId = Convert.IsDBNull(dataRow["SE_USER_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_ID"];
			entity.LastDate = Convert.IsDBNull(dataRow["LAST_DATE"]) ? null : (System.DateTime?)dataRow["LAST_DATE"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeTreasuryItem"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeTreasuryItem Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeTreasuryItem entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region FeeCdeBondItemIdSource	
			if (CanDeepLoad(entity, "FeeCdeBondItem|FeeCdeBondItemIdSource", deepLoadType, innerList) 
				&& entity.FeeCdeBondItemIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.FeeCdeBondItemId;
				FeeCdeBondItem tmpEntity = EntityManager.LocateEntity<FeeCdeBondItem>(EntityLocator.ConstructKeyFromPkItems(typeof(FeeCdeBondItem), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.FeeCdeBondItemIdSource = tmpEntity;
				else
					entity.FeeCdeBondItemIdSource = DataRepository.FeeCdeBondItemProvider.GetByFeeCdeBondItemId(transactionManager, entity.FeeCdeBondItemId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeCdeBondItemIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.FeeCdeBondItemIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.FeeCdeBondItemProvider.DeepLoad(transactionManager, entity.FeeCdeBondItemIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion FeeCdeBondItemIdSource

			#region FeeTreasuryReqIdSource	
			if (CanDeepLoad(entity, "FeeTreasuryReq|FeeTreasuryReqIdSource", deepLoadType, innerList) 
				&& entity.FeeTreasuryReqIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.FeeTreasuryReqId;
				FeeTreasuryReq tmpEntity = EntityManager.LocateEntity<FeeTreasuryReq>(EntityLocator.ConstructKeyFromPkItems(typeof(FeeTreasuryReq), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.FeeTreasuryReqIdSource = tmpEntity;
				else
					entity.FeeTreasuryReqIdSource = DataRepository.FeeTreasuryReqProvider.GetByFeeTreasuryReqId(transactionManager, entity.FeeTreasuryReqId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeTreasuryReqIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.FeeTreasuryReqIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.FeeTreasuryReqProvider.DeepLoad(transactionManager, entity.FeeTreasuryReqIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion FeeTreasuryReqIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.FeeTreasuryItem object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.FeeTreasuryItem instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeTreasuryItem Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeTreasuryItem entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region FeeCdeBondItemIdSource
			if (CanDeepSave(entity, "FeeCdeBondItem|FeeCdeBondItemIdSource", deepSaveType, innerList) 
				&& entity.FeeCdeBondItemIdSource != null)
			{
				DataRepository.FeeCdeBondItemProvider.Save(transactionManager, entity.FeeCdeBondItemIdSource);
				entity.FeeCdeBondItemId = entity.FeeCdeBondItemIdSource.FeeCdeBondItemId;
			}
			#endregion 
			
			#region FeeTreasuryReqIdSource
			if (CanDeepSave(entity, "FeeTreasuryReq|FeeTreasuryReqIdSource", deepSaveType, innerList) 
				&& entity.FeeTreasuryReqIdSource != null)
			{
				DataRepository.FeeTreasuryReqProvider.Save(transactionManager, entity.FeeTreasuryReqIdSource);
				entity.FeeTreasuryReqId = entity.FeeTreasuryReqIdSource.FeeTreasuryReqId;
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
	
	#region FeeTreasuryItemChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.FeeTreasuryItem</c>
	///</summary>
	public enum FeeTreasuryItemChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>FeeCdeBondItem</c> at FeeCdeBondItemIdSource
		///</summary>
		[ChildEntityType(typeof(FeeCdeBondItem))]
		FeeCdeBondItem,
		
		///<summary>
		/// Composite Property for <c>FeeTreasuryReq</c> at FeeTreasuryReqIdSource
		///</summary>
		[ChildEntityType(typeof(FeeTreasuryReq))]
		FeeTreasuryReq,
	}
	
	#endregion FeeTreasuryItemChildEntityTypes
	
	#region FeeTreasuryItemFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;FeeTreasuryItemColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeTreasuryItem"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeTreasuryItemFilterBuilder : SqlFilterBuilder<FeeTreasuryItemColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeTreasuryItemFilterBuilder class.
		/// </summary>
		public FeeTreasuryItemFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeTreasuryItemFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeTreasuryItemFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeTreasuryItemFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeTreasuryItemFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeTreasuryItemFilterBuilder
	
	#region FeeTreasuryItemParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;FeeTreasuryItemColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeTreasuryItem"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeTreasuryItemParameterBuilder : ParameterizedSqlFilterBuilder<FeeTreasuryItemColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeTreasuryItemParameterBuilder class.
		/// </summary>
		public FeeTreasuryItemParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeTreasuryItemParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeTreasuryItemParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeTreasuryItemParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeTreasuryItemParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeTreasuryItemParameterBuilder
	
	#region FeeTreasuryItemSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;FeeTreasuryItemColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeTreasuryItem"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class FeeTreasuryItemSortBuilder : SqlSortBuilder<FeeTreasuryItemColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeTreasuryItemSqlSortBuilder class.
		/// </summary>
		public FeeTreasuryItemSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion FeeTreasuryItemSortBuilder
	
} // end namespace
