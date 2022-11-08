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
	/// This class is the base class for any <see cref="CtrMealItemProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class CtrMealItemProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.CtrMealItem, UMIS_VER2.BusinessLyer.CtrMealItemKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CtrMealItemKey key)
		{
			return Delete(transactionManager, key.CtrMealItemId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_ctrMealItemId">قائمة خيارات التعيين لكل وجبة. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _ctrMealItemId)
		{
			return Delete(null, _ctrMealItemId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrMealItemId">قائمة خيارات التعيين لكل وجبة. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _ctrMealItemId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_MEAL_ITEM_CTR_CDE_MEAL key.
		///		FK_CTR_MEAL_ITEM_CTR_CDE_MEAL Description: 
		/// </summary>
		/// <param name="_ctrCdeMealId">فطار-غدا عشا-وجبة خفيفة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrMealItem objects.</returns>
		public TList<CtrMealItem> GetByCtrCdeMealId(System.Decimal _ctrCdeMealId)
		{
			int count = -1;
			return GetByCtrCdeMealId(_ctrCdeMealId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_MEAL_ITEM_CTR_CDE_MEAL key.
		///		FK_CTR_MEAL_ITEM_CTR_CDE_MEAL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrCdeMealId">فطار-غدا عشا-وجبة خفيفة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrMealItem objects.</returns>
		/// <remarks></remarks>
		public TList<CtrMealItem> GetByCtrCdeMealId(TransactionManager transactionManager, System.Decimal _ctrCdeMealId)
		{
			int count = -1;
			return GetByCtrCdeMealId(transactionManager, _ctrCdeMealId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_MEAL_ITEM_CTR_CDE_MEAL key.
		///		FK_CTR_MEAL_ITEM_CTR_CDE_MEAL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrCdeMealId">فطار-غدا عشا-وجبة خفيفة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrMealItem objects.</returns>
		public TList<CtrMealItem> GetByCtrCdeMealId(TransactionManager transactionManager, System.Decimal _ctrCdeMealId, int start, int pageLength)
		{
			int count = -1;
			return GetByCtrCdeMealId(transactionManager, _ctrCdeMealId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_MEAL_ITEM_CTR_CDE_MEAL key.
		///		fkCtrMealItemCtrCdeMeal Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_ctrCdeMealId">فطار-غدا عشا-وجبة خفيفة</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrMealItem objects.</returns>
		public TList<CtrMealItem> GetByCtrCdeMealId(System.Decimal _ctrCdeMealId, int start, int pageLength)
		{
			int count =  -1;
			return GetByCtrCdeMealId(null, _ctrCdeMealId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_MEAL_ITEM_CTR_CDE_MEAL key.
		///		fkCtrMealItemCtrCdeMeal Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_ctrCdeMealId">فطار-غدا عشا-وجبة خفيفة</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrMealItem objects.</returns>
		public TList<CtrMealItem> GetByCtrCdeMealId(System.Decimal _ctrCdeMealId, int start, int pageLength,out int count)
		{
			return GetByCtrCdeMealId(null, _ctrCdeMealId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_MEAL_ITEM_CTR_CDE_MEAL key.
		///		FK_CTR_MEAL_ITEM_CTR_CDE_MEAL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrCdeMealId">فطار-غدا عشا-وجبة خفيفة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrMealItem objects.</returns>
		public abstract TList<CtrMealItem> GetByCtrCdeMealId(TransactionManager transactionManager, System.Decimal _ctrCdeMealId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_MEAL_ITEM_CTR_CDE_MEAL_ITEM key.
		///		FK_CTR_MEAL_ITEM_CTR_CDE_MEAL_ITEM Description: 
		/// </summary>
		/// <param name="_ctrCdeMealItemId">عناصر الطعام</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrMealItem objects.</returns>
		public TList<CtrMealItem> GetByCtrCdeMealItemId(System.Decimal _ctrCdeMealItemId)
		{
			int count = -1;
			return GetByCtrCdeMealItemId(_ctrCdeMealItemId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_MEAL_ITEM_CTR_CDE_MEAL_ITEM key.
		///		FK_CTR_MEAL_ITEM_CTR_CDE_MEAL_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrCdeMealItemId">عناصر الطعام</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrMealItem objects.</returns>
		/// <remarks></remarks>
		public TList<CtrMealItem> GetByCtrCdeMealItemId(TransactionManager transactionManager, System.Decimal _ctrCdeMealItemId)
		{
			int count = -1;
			return GetByCtrCdeMealItemId(transactionManager, _ctrCdeMealItemId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_MEAL_ITEM_CTR_CDE_MEAL_ITEM key.
		///		FK_CTR_MEAL_ITEM_CTR_CDE_MEAL_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrCdeMealItemId">عناصر الطعام</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrMealItem objects.</returns>
		public TList<CtrMealItem> GetByCtrCdeMealItemId(TransactionManager transactionManager, System.Decimal _ctrCdeMealItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByCtrCdeMealItemId(transactionManager, _ctrCdeMealItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_MEAL_ITEM_CTR_CDE_MEAL_ITEM key.
		///		fkCtrMealItemCtrCdeMealItem Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_ctrCdeMealItemId">عناصر الطعام</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrMealItem objects.</returns>
		public TList<CtrMealItem> GetByCtrCdeMealItemId(System.Decimal _ctrCdeMealItemId, int start, int pageLength)
		{
			int count =  -1;
			return GetByCtrCdeMealItemId(null, _ctrCdeMealItemId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_MEAL_ITEM_CTR_CDE_MEAL_ITEM key.
		///		fkCtrMealItemCtrCdeMealItem Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_ctrCdeMealItemId">عناصر الطعام</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrMealItem objects.</returns>
		public TList<CtrMealItem> GetByCtrCdeMealItemId(System.Decimal _ctrCdeMealItemId, int start, int pageLength,out int count)
		{
			return GetByCtrCdeMealItemId(null, _ctrCdeMealItemId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_MEAL_ITEM_CTR_CDE_MEAL_ITEM key.
		///		FK_CTR_MEAL_ITEM_CTR_CDE_MEAL_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrCdeMealItemId">عناصر الطعام</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrMealItem objects.</returns>
		public abstract TList<CtrMealItem> GetByCtrCdeMealItemId(TransactionManager transactionManager, System.Decimal _ctrCdeMealItemId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.CtrMealItem Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CtrMealItemKey key, int start, int pageLength)
		{
			return GetByCtrMealItemId(transactionManager, key.CtrMealItemId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_CTR_MEAL_ITEM index.
		/// </summary>
		/// <param name="_ctrMealItemId">قائمة خيارات التعيين لكل وجبة</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrMealItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrMealItem GetByCtrMealItemId(System.Decimal _ctrMealItemId)
		{
			int count = -1;
			return GetByCtrMealItemId(null,_ctrMealItemId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_MEAL_ITEM index.
		/// </summary>
		/// <param name="_ctrMealItemId">قائمة خيارات التعيين لكل وجبة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrMealItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrMealItem GetByCtrMealItemId(System.Decimal _ctrMealItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByCtrMealItemId(null, _ctrMealItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_MEAL_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrMealItemId">قائمة خيارات التعيين لكل وجبة</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrMealItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrMealItem GetByCtrMealItemId(TransactionManager transactionManager, System.Decimal _ctrMealItemId)
		{
			int count = -1;
			return GetByCtrMealItemId(transactionManager, _ctrMealItemId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_MEAL_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrMealItemId">قائمة خيارات التعيين لكل وجبة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrMealItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrMealItem GetByCtrMealItemId(TransactionManager transactionManager, System.Decimal _ctrMealItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByCtrMealItemId(transactionManager, _ctrMealItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_MEAL_ITEM index.
		/// </summary>
		/// <param name="_ctrMealItemId">قائمة خيارات التعيين لكل وجبة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrMealItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrMealItem GetByCtrMealItemId(System.Decimal _ctrMealItemId, int start, int pageLength, out int count)
		{
			return GetByCtrMealItemId(null, _ctrMealItemId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_MEAL_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrMealItemId">قائمة خيارات التعيين لكل وجبة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrMealItem"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.CtrMealItem GetByCtrMealItemId(TransactionManager transactionManager, System.Decimal _ctrMealItemId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;CtrMealItem&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;CtrMealItem&gt;"/></returns>
		public static TList<CtrMealItem> Fill(IDataReader reader, TList<CtrMealItem> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.CtrMealItem c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("CtrMealItem")
					.Append("|").Append((System.Decimal)reader["CTR_MEAL_ITEM_ID"]).ToString();
					c = EntityManager.LocateOrCreate<CtrMealItem>(
					key.ToString(), // EntityTrackingKey
					"CtrMealItem",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.CtrMealItem();
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
					c.CtrMealItemId = (System.Decimal)reader["CTR_MEAL_ITEM_ID"];
					c.OriginalCtrMealItemId = c.CtrMealItemId;
					c.CtrCdeMealId = (System.Decimal)reader["CTR_CDE_MEAL_ID"];
					c.CtrCdeMealItemId = (System.Decimal)reader["CTR_CDE_MEAL_ITEM_ID"];
					c.UnitCount = Convert.IsDBNull(reader["UNIT_COUNT"]) ? null : (System.Decimal?)reader["UNIT_COUNT"];
					c.AvgDlvrRate = Convert.IsDBNull(reader["AVG_DLVR_RATE"]) ? null : (System.Decimal?)reader["AVG_DLVR_RATE"];
					c.DlvrFlg = Convert.IsDBNull(reader["DLVR_FLG"]) ? null : (System.Decimal?)reader["DLVR_FLG"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.CtrMealItem"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CtrMealItem"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.CtrMealItem entity)
		{
			if (!reader.Read()) return;
			
			entity.CtrMealItemId = (System.Decimal)reader[((int)CtrMealItemColumn.CtrMealItemId - 1)];
			entity.OriginalCtrMealItemId = (System.Decimal)reader["CTR_MEAL_ITEM_ID"];
			entity.CtrCdeMealId = (System.Decimal)reader[((int)CtrMealItemColumn.CtrCdeMealId - 1)];
			entity.CtrCdeMealItemId = (System.Decimal)reader[((int)CtrMealItemColumn.CtrCdeMealItemId - 1)];
			entity.UnitCount = (reader.IsDBNull(((int)CtrMealItemColumn.UnitCount - 1)))?null:(System.Decimal?)reader[((int)CtrMealItemColumn.UnitCount - 1)];
			entity.AvgDlvrRate = (reader.IsDBNull(((int)CtrMealItemColumn.AvgDlvrRate - 1)))?null:(System.Decimal?)reader[((int)CtrMealItemColumn.AvgDlvrRate - 1)];
			entity.DlvrFlg = (reader.IsDBNull(((int)CtrMealItemColumn.DlvrFlg - 1)))?null:(System.Decimal?)reader[((int)CtrMealItemColumn.DlvrFlg - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.CtrMealItem"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CtrMealItem"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.CtrMealItem entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.CtrMealItemId = (System.Decimal)dataRow["CTR_MEAL_ITEM_ID"];
			entity.OriginalCtrMealItemId = (System.Decimal)dataRow["CTR_MEAL_ITEM_ID"];
			entity.CtrCdeMealId = (System.Decimal)dataRow["CTR_CDE_MEAL_ID"];
			entity.CtrCdeMealItemId = (System.Decimal)dataRow["CTR_CDE_MEAL_ITEM_ID"];
			entity.UnitCount = Convert.IsDBNull(dataRow["UNIT_COUNT"]) ? null : (System.Decimal?)dataRow["UNIT_COUNT"];
			entity.AvgDlvrRate = Convert.IsDBNull(dataRow["AVG_DLVR_RATE"]) ? null : (System.Decimal?)dataRow["AVG_DLVR_RATE"];
			entity.DlvrFlg = Convert.IsDBNull(dataRow["DLVR_FLG"]) ? null : (System.Decimal?)dataRow["DLVR_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CtrMealItem"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.CtrMealItem Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CtrMealItem entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.CtrMealItem object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.CtrMealItem instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.CtrMealItem Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CtrMealItem entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region CtrCdeMealItemIdSource
			if (CanDeepSave(entity, "CtrCdeMealItem|CtrCdeMealItemIdSource", deepSaveType, innerList) 
				&& entity.CtrCdeMealItemIdSource != null)
			{
				DataRepository.CtrCdeMealItemProvider.Save(transactionManager, entity.CtrCdeMealItemIdSource);
				entity.CtrCdeMealItemId = entity.CtrCdeMealItemIdSource.CtrCdeMealItemId;
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
	
	#region CtrMealItemChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.CtrMealItem</c>
	///</summary>
	public enum CtrMealItemChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>CtrCdeMeal</c> at CtrCdeMealIdSource
		///</summary>
		[ChildEntityType(typeof(CtrCdeMeal))]
		CtrCdeMeal,
		
		///<summary>
		/// Composite Property for <c>CtrCdeMealItem</c> at CtrCdeMealItemIdSource
		///</summary>
		[ChildEntityType(typeof(CtrCdeMealItem))]
		CtrCdeMealItem,
	}
	
	#endregion CtrMealItemChildEntityTypes
	
	#region CtrMealItemFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;CtrMealItemColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CtrMealItem"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CtrMealItemFilterBuilder : SqlFilterBuilder<CtrMealItemColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CtrMealItemFilterBuilder class.
		/// </summary>
		public CtrMealItemFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CtrMealItemFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CtrMealItemFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CtrMealItemFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CtrMealItemFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CtrMealItemFilterBuilder
	
	#region CtrMealItemParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;CtrMealItemColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CtrMealItem"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CtrMealItemParameterBuilder : ParameterizedSqlFilterBuilder<CtrMealItemColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CtrMealItemParameterBuilder class.
		/// </summary>
		public CtrMealItemParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CtrMealItemParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CtrMealItemParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CtrMealItemParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CtrMealItemParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CtrMealItemParameterBuilder
	
	#region CtrMealItemSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;CtrMealItemColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CtrMealItem"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class CtrMealItemSortBuilder : SqlSortBuilder<CtrMealItemColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CtrMealItemSqlSortBuilder class.
		/// </summary>
		public CtrMealItemSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion CtrMealItemSortBuilder
	
} // end namespace
