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
	/// This class is the base class for any <see cref="FeeStudDiscCodeItemProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class FeeStudDiscCodeItemProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.FeeStudDiscCodeItem, UMIS_VER2.BusinessLyer.FeeStudDiscCodeItemKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeStudDiscCodeItemKey key)
		{
			return Delete(transactionManager, key.FeeStudDiscCodeItemId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_feeStudDiscCodeItemId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _feeStudDiscCodeItemId)
		{
			return Delete(null, _feeStudDiscCodeItemId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudDiscCodeItemId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _feeStudDiscCodeItemId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_DISC_CODE_ITEM_FEE_CODE_ITEM key.
		///		FK_FEE_STUD_DISC_CODE_ITEM_FEE_CODE_ITEM Description: 
		/// </summary>
		/// <param name="_feeCodeItemId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudDiscCodeItem objects.</returns>
		public TList<FeeStudDiscCodeItem> GetByFeeCodeItemId(System.Decimal? _feeCodeItemId)
		{
			int count = -1;
			return GetByFeeCodeItemId(_feeCodeItemId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_DISC_CODE_ITEM_FEE_CODE_ITEM key.
		///		FK_FEE_STUD_DISC_CODE_ITEM_FEE_CODE_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeItemId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudDiscCodeItem objects.</returns>
		/// <remarks></remarks>
		public TList<FeeStudDiscCodeItem> GetByFeeCodeItemId(TransactionManager transactionManager, System.Decimal? _feeCodeItemId)
		{
			int count = -1;
			return GetByFeeCodeItemId(transactionManager, _feeCodeItemId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_DISC_CODE_ITEM_FEE_CODE_ITEM key.
		///		FK_FEE_STUD_DISC_CODE_ITEM_FEE_CODE_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudDiscCodeItem objects.</returns>
		public TList<FeeStudDiscCodeItem> GetByFeeCodeItemId(TransactionManager transactionManager, System.Decimal? _feeCodeItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCodeItemId(transactionManager, _feeCodeItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_DISC_CODE_ITEM_FEE_CODE_ITEM key.
		///		fkFeeStudDiscCodeItemFeeCodeItem Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeCodeItemId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudDiscCodeItem objects.</returns>
		public TList<FeeStudDiscCodeItem> GetByFeeCodeItemId(System.Decimal? _feeCodeItemId, int start, int pageLength)
		{
			int count =  -1;
			return GetByFeeCodeItemId(null, _feeCodeItemId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_DISC_CODE_ITEM_FEE_CODE_ITEM key.
		///		fkFeeStudDiscCodeItemFeeCodeItem Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeCodeItemId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudDiscCodeItem objects.</returns>
		public TList<FeeStudDiscCodeItem> GetByFeeCodeItemId(System.Decimal? _feeCodeItemId, int start, int pageLength,out int count)
		{
			return GetByFeeCodeItemId(null, _feeCodeItemId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_DISC_CODE_ITEM_FEE_CODE_ITEM key.
		///		FK_FEE_STUD_DISC_CODE_ITEM_FEE_CODE_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudDiscCodeItem objects.</returns>
		public abstract TList<FeeStudDiscCodeItem> GetByFeeCodeItemId(TransactionManager transactionManager, System.Decimal? _feeCodeItemId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_DISC_CODE_ITEM_FEE_STUD_DISC key.
		///		FK_FEE_STUD_DISC_CODE_ITEM_FEE_STUD_DISC Description: 
		/// </summary>
		/// <param name="_feeStudDiscId">اكواد بنود المصروفات  تحت طلب التخفيض</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudDiscCodeItem objects.</returns>
		public TList<FeeStudDiscCodeItem> GetByFeeStudDiscId(System.Decimal _feeStudDiscId)
		{
			int count = -1;
			return GetByFeeStudDiscId(_feeStudDiscId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_DISC_CODE_ITEM_FEE_STUD_DISC key.
		///		FK_FEE_STUD_DISC_CODE_ITEM_FEE_STUD_DISC Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudDiscId">اكواد بنود المصروفات  تحت طلب التخفيض</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudDiscCodeItem objects.</returns>
		/// <remarks></remarks>
		public TList<FeeStudDiscCodeItem> GetByFeeStudDiscId(TransactionManager transactionManager, System.Decimal _feeStudDiscId)
		{
			int count = -1;
			return GetByFeeStudDiscId(transactionManager, _feeStudDiscId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_DISC_CODE_ITEM_FEE_STUD_DISC key.
		///		FK_FEE_STUD_DISC_CODE_ITEM_FEE_STUD_DISC Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudDiscId">اكواد بنود المصروفات  تحت طلب التخفيض</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudDiscCodeItem objects.</returns>
		public TList<FeeStudDiscCodeItem> GetByFeeStudDiscId(TransactionManager transactionManager, System.Decimal _feeStudDiscId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeStudDiscId(transactionManager, _feeStudDiscId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_DISC_CODE_ITEM_FEE_STUD_DISC key.
		///		fkFeeStudDiscCodeItemFeeStudDisc Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeStudDiscId">اكواد بنود المصروفات  تحت طلب التخفيض</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudDiscCodeItem objects.</returns>
		public TList<FeeStudDiscCodeItem> GetByFeeStudDiscId(System.Decimal _feeStudDiscId, int start, int pageLength)
		{
			int count =  -1;
			return GetByFeeStudDiscId(null, _feeStudDiscId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_DISC_CODE_ITEM_FEE_STUD_DISC key.
		///		fkFeeStudDiscCodeItemFeeStudDisc Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeStudDiscId">اكواد بنود المصروفات  تحت طلب التخفيض</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudDiscCodeItem objects.</returns>
		public TList<FeeStudDiscCodeItem> GetByFeeStudDiscId(System.Decimal _feeStudDiscId, int start, int pageLength,out int count)
		{
			return GetByFeeStudDiscId(null, _feeStudDiscId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_DISC_CODE_ITEM_FEE_STUD_DISC key.
		///		FK_FEE_STUD_DISC_CODE_ITEM_FEE_STUD_DISC Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudDiscId">اكواد بنود المصروفات  تحت طلب التخفيض</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudDiscCodeItem objects.</returns>
		public abstract TList<FeeStudDiscCodeItem> GetByFeeStudDiscId(TransactionManager transactionManager, System.Decimal _feeStudDiscId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.FeeStudDiscCodeItem Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeStudDiscCodeItemKey key, int start, int pageLength)
		{
			return GetByFeeStudDiscCodeItemId(transactionManager, key.FeeStudDiscCodeItemId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_FEE_STUD_DISC_CODE_ITEM index.
		/// </summary>
		/// <param name="_feeStudDiscCodeItemId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudDiscCodeItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudDiscCodeItem GetByFeeStudDiscCodeItemId(System.Decimal _feeStudDiscCodeItemId)
		{
			int count = -1;
			return GetByFeeStudDiscCodeItemId(null,_feeStudDiscCodeItemId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_STUD_DISC_CODE_ITEM index.
		/// </summary>
		/// <param name="_feeStudDiscCodeItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudDiscCodeItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudDiscCodeItem GetByFeeStudDiscCodeItemId(System.Decimal _feeStudDiscCodeItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeStudDiscCodeItemId(null, _feeStudDiscCodeItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_STUD_DISC_CODE_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudDiscCodeItemId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudDiscCodeItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudDiscCodeItem GetByFeeStudDiscCodeItemId(TransactionManager transactionManager, System.Decimal _feeStudDiscCodeItemId)
		{
			int count = -1;
			return GetByFeeStudDiscCodeItemId(transactionManager, _feeStudDiscCodeItemId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_STUD_DISC_CODE_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudDiscCodeItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudDiscCodeItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudDiscCodeItem GetByFeeStudDiscCodeItemId(TransactionManager transactionManager, System.Decimal _feeStudDiscCodeItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeStudDiscCodeItemId(transactionManager, _feeStudDiscCodeItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_STUD_DISC_CODE_ITEM index.
		/// </summary>
		/// <param name="_feeStudDiscCodeItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudDiscCodeItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudDiscCodeItem GetByFeeStudDiscCodeItemId(System.Decimal _feeStudDiscCodeItemId, int start, int pageLength, out int count)
		{
			return GetByFeeStudDiscCodeItemId(null, _feeStudDiscCodeItemId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_STUD_DISC_CODE_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudDiscCodeItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudDiscCodeItem"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.FeeStudDiscCodeItem GetByFeeStudDiscCodeItemId(TransactionManager transactionManager, System.Decimal _feeStudDiscCodeItemId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;FeeStudDiscCodeItem&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;FeeStudDiscCodeItem&gt;"/></returns>
		public static TList<FeeStudDiscCodeItem> Fill(IDataReader reader, TList<FeeStudDiscCodeItem> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.FeeStudDiscCodeItem c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("FeeStudDiscCodeItem")
					.Append("|").Append((System.Decimal)reader["FEE_STUD_DISC_CODE_ITEM_ID"]).ToString();
					c = EntityManager.LocateOrCreate<FeeStudDiscCodeItem>(
					key.ToString(), // EntityTrackingKey
					"FeeStudDiscCodeItem",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.FeeStudDiscCodeItem();
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
					c.FeeStudDiscCodeItemId = (System.Decimal)reader["FEE_STUD_DISC_CODE_ITEM_ID"];
					c.OriginalFeeStudDiscCodeItemId = c.FeeStudDiscCodeItemId;
					c.FeeStudDiscId = (System.Decimal)reader["FEE_STUD_DISC_ID"];
					c.FeeCodeItemId = Convert.IsDBNull(reader["FEE_CODE_ITEM_ID"]) ? null : (System.Decimal?)reader["FEE_CODE_ITEM_ID"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeStudDiscCodeItem"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeStudDiscCodeItem"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.FeeStudDiscCodeItem entity)
		{
			if (!reader.Read()) return;
			
			entity.FeeStudDiscCodeItemId = (System.Decimal)reader[((int)FeeStudDiscCodeItemColumn.FeeStudDiscCodeItemId - 1)];
			entity.OriginalFeeStudDiscCodeItemId = (System.Decimal)reader["FEE_STUD_DISC_CODE_ITEM_ID"];
			entity.FeeStudDiscId = (System.Decimal)reader[((int)FeeStudDiscCodeItemColumn.FeeStudDiscId - 1)];
			entity.FeeCodeItemId = (reader.IsDBNull(((int)FeeStudDiscCodeItemColumn.FeeCodeItemId - 1)))?null:(System.Decimal?)reader[((int)FeeStudDiscCodeItemColumn.FeeCodeItemId - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)FeeStudDiscCodeItemColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)FeeStudDiscCodeItemColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)FeeStudDiscCodeItemColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)FeeStudDiscCodeItemColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeStudDiscCodeItem"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeStudDiscCodeItem"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.FeeStudDiscCodeItem entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.FeeStudDiscCodeItemId = (System.Decimal)dataRow["FEE_STUD_DISC_CODE_ITEM_ID"];
			entity.OriginalFeeStudDiscCodeItemId = (System.Decimal)dataRow["FEE_STUD_DISC_CODE_ITEM_ID"];
			entity.FeeStudDiscId = (System.Decimal)dataRow["FEE_STUD_DISC_ID"];
			entity.FeeCodeItemId = Convert.IsDBNull(dataRow["FEE_CODE_ITEM_ID"]) ? null : (System.Decimal?)dataRow["FEE_CODE_ITEM_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeStudDiscCodeItem"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeStudDiscCodeItem Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeStudDiscCodeItem entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region FeeCodeItemIdSource	
			if (CanDeepLoad(entity, "FeeCodeItem|FeeCodeItemIdSource", deepLoadType, innerList) 
				&& entity.FeeCodeItemIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.FeeCodeItemId ?? 0.0m);
				FeeCodeItem tmpEntity = EntityManager.LocateEntity<FeeCodeItem>(EntityLocator.ConstructKeyFromPkItems(typeof(FeeCodeItem), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.FeeCodeItemIdSource = tmpEntity;
				else
					entity.FeeCodeItemIdSource = DataRepository.FeeCodeItemProvider.GetByFeeCodeItemId(transactionManager, (entity.FeeCodeItemId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeCodeItemIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.FeeCodeItemIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.FeeCodeItemProvider.DeepLoad(transactionManager, entity.FeeCodeItemIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion FeeCodeItemIdSource

			#region FeeStudDiscIdSource	
			if (CanDeepLoad(entity, "FeeStudDisc|FeeStudDiscIdSource", deepLoadType, innerList) 
				&& entity.FeeStudDiscIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.FeeStudDiscId;
				FeeStudDisc tmpEntity = EntityManager.LocateEntity<FeeStudDisc>(EntityLocator.ConstructKeyFromPkItems(typeof(FeeStudDisc), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.FeeStudDiscIdSource = tmpEntity;
				else
					entity.FeeStudDiscIdSource = DataRepository.FeeStudDiscProvider.GetByFeeStudDiscId(transactionManager, entity.FeeStudDiscId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudDiscIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.FeeStudDiscIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.FeeStudDiscProvider.DeepLoad(transactionManager, entity.FeeStudDiscIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion FeeStudDiscIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.FeeStudDiscCodeItem object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.FeeStudDiscCodeItem instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeStudDiscCodeItem Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeStudDiscCodeItem entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region FeeCodeItemIdSource
			if (CanDeepSave(entity, "FeeCodeItem|FeeCodeItemIdSource", deepSaveType, innerList) 
				&& entity.FeeCodeItemIdSource != null)
			{
				DataRepository.FeeCodeItemProvider.Save(transactionManager, entity.FeeCodeItemIdSource);
				entity.FeeCodeItemId = entity.FeeCodeItemIdSource.FeeCodeItemId;
			}
			#endregion 
			
			#region FeeStudDiscIdSource
			if (CanDeepSave(entity, "FeeStudDisc|FeeStudDiscIdSource", deepSaveType, innerList) 
				&& entity.FeeStudDiscIdSource != null)
			{
				DataRepository.FeeStudDiscProvider.Save(transactionManager, entity.FeeStudDiscIdSource);
				entity.FeeStudDiscId = entity.FeeStudDiscIdSource.FeeStudDiscId;
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
	
	#region FeeStudDiscCodeItemChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.FeeStudDiscCodeItem</c>
	///</summary>
	public enum FeeStudDiscCodeItemChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>FeeCodeItem</c> at FeeCodeItemIdSource
		///</summary>
		[ChildEntityType(typeof(FeeCodeItem))]
		FeeCodeItem,
		
		///<summary>
		/// Composite Property for <c>FeeStudDisc</c> at FeeStudDiscIdSource
		///</summary>
		[ChildEntityType(typeof(FeeStudDisc))]
		FeeStudDisc,
	}
	
	#endregion FeeStudDiscCodeItemChildEntityTypes
	
	#region FeeStudDiscCodeItemFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;FeeStudDiscCodeItemColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeStudDiscCodeItem"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeStudDiscCodeItemFilterBuilder : SqlFilterBuilder<FeeStudDiscCodeItemColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeStudDiscCodeItemFilterBuilder class.
		/// </summary>
		public FeeStudDiscCodeItemFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeStudDiscCodeItemFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeStudDiscCodeItemFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeStudDiscCodeItemFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeStudDiscCodeItemFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeStudDiscCodeItemFilterBuilder
	
	#region FeeStudDiscCodeItemParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;FeeStudDiscCodeItemColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeStudDiscCodeItem"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeStudDiscCodeItemParameterBuilder : ParameterizedSqlFilterBuilder<FeeStudDiscCodeItemColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeStudDiscCodeItemParameterBuilder class.
		/// </summary>
		public FeeStudDiscCodeItemParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeStudDiscCodeItemParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeStudDiscCodeItemParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeStudDiscCodeItemParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeStudDiscCodeItemParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeStudDiscCodeItemParameterBuilder
	
	#region FeeStudDiscCodeItemSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;FeeStudDiscCodeItemColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeStudDiscCodeItem"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class FeeStudDiscCodeItemSortBuilder : SqlSortBuilder<FeeStudDiscCodeItemColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeStudDiscCodeItemSqlSortBuilder class.
		/// </summary>
		public FeeStudDiscCodeItemSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion FeeStudDiscCodeItemSortBuilder
	
} // end namespace
