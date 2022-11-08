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
	/// This class is the base class for any <see cref="FeeInvoiceItemProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class FeeInvoiceItemProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.FeeInvoiceItem, UMIS_VER2.BusinessLyer.FeeInvoiceItemKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeInvoiceItemKey key)
		{
			return Delete(transactionManager, key.FeeInvoiceItemId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_feeInvoiceItemId">بنود الفاتورة. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _feeInvoiceItemId)
		{
			return Delete(null, _feeInvoiceItemId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeInvoiceItemId">بنود الفاتورة. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _feeInvoiceItemId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_INVOICE_ITEM_FEE_INVOICE key.
		///		FK_FEE_INVOICE_ITEM_FEE_INVOICE Description: 
		/// </summary>
		/// <param name="_feeInvoiceId">الفاتورة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeInvoiceItem objects.</returns>
		public TList<FeeInvoiceItem> GetByFeeInvoiceId(System.Decimal _feeInvoiceId)
		{
			int count = -1;
			return GetByFeeInvoiceId(_feeInvoiceId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_INVOICE_ITEM_FEE_INVOICE key.
		///		FK_FEE_INVOICE_ITEM_FEE_INVOICE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeInvoiceId">الفاتورة</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeInvoiceItem objects.</returns>
		/// <remarks></remarks>
		public TList<FeeInvoiceItem> GetByFeeInvoiceId(TransactionManager transactionManager, System.Decimal _feeInvoiceId)
		{
			int count = -1;
			return GetByFeeInvoiceId(transactionManager, _feeInvoiceId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_INVOICE_ITEM_FEE_INVOICE key.
		///		FK_FEE_INVOICE_ITEM_FEE_INVOICE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeInvoiceId">الفاتورة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeInvoiceItem objects.</returns>
		public TList<FeeInvoiceItem> GetByFeeInvoiceId(TransactionManager transactionManager, System.Decimal _feeInvoiceId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeInvoiceId(transactionManager, _feeInvoiceId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_INVOICE_ITEM_FEE_INVOICE key.
		///		fkFeeInvoiceItemFeeInvoice Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeInvoiceId">الفاتورة</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeInvoiceItem objects.</returns>
		public TList<FeeInvoiceItem> GetByFeeInvoiceId(System.Decimal _feeInvoiceId, int start, int pageLength)
		{
			int count =  -1;
			return GetByFeeInvoiceId(null, _feeInvoiceId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_INVOICE_ITEM_FEE_INVOICE key.
		///		fkFeeInvoiceItemFeeInvoice Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeInvoiceId">الفاتورة</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeInvoiceItem objects.</returns>
		public TList<FeeInvoiceItem> GetByFeeInvoiceId(System.Decimal _feeInvoiceId, int start, int pageLength,out int count)
		{
			return GetByFeeInvoiceId(null, _feeInvoiceId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_INVOICE_ITEM_FEE_INVOICE key.
		///		FK_FEE_INVOICE_ITEM_FEE_INVOICE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeInvoiceId">الفاتورة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeInvoiceItem objects.</returns>
		public abstract TList<FeeInvoiceItem> GetByFeeInvoiceId(TransactionManager transactionManager, System.Decimal _feeInvoiceId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_INVOICE_ITEM_FEE_STUD_FEE_ITEM key.
		///		FK_FEE_INVOICE_ITEM_FEE_STUD_FEE_ITEM Description: 
		/// </summary>
		/// <param name="_feeStudFeeItemId">بنود المصروفات على  طالب</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeInvoiceItem objects.</returns>
		public TList<FeeInvoiceItem> GetByFeeStudFeeItemId(System.Decimal _feeStudFeeItemId)
		{
			int count = -1;
			return GetByFeeStudFeeItemId(_feeStudFeeItemId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_INVOICE_ITEM_FEE_STUD_FEE_ITEM key.
		///		FK_FEE_INVOICE_ITEM_FEE_STUD_FEE_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudFeeItemId">بنود المصروفات على  طالب</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeInvoiceItem objects.</returns>
		/// <remarks></remarks>
		public TList<FeeInvoiceItem> GetByFeeStudFeeItemId(TransactionManager transactionManager, System.Decimal _feeStudFeeItemId)
		{
			int count = -1;
			return GetByFeeStudFeeItemId(transactionManager, _feeStudFeeItemId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_INVOICE_ITEM_FEE_STUD_FEE_ITEM key.
		///		FK_FEE_INVOICE_ITEM_FEE_STUD_FEE_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudFeeItemId">بنود المصروفات على  طالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeInvoiceItem objects.</returns>
		public TList<FeeInvoiceItem> GetByFeeStudFeeItemId(TransactionManager transactionManager, System.Decimal _feeStudFeeItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeStudFeeItemId(transactionManager, _feeStudFeeItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_INVOICE_ITEM_FEE_STUD_FEE_ITEM key.
		///		fkFeeInvoiceItemFeeStudFeeItem Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeStudFeeItemId">بنود المصروفات على  طالب</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeInvoiceItem objects.</returns>
		public TList<FeeInvoiceItem> GetByFeeStudFeeItemId(System.Decimal _feeStudFeeItemId, int start, int pageLength)
		{
			int count =  -1;
			return GetByFeeStudFeeItemId(null, _feeStudFeeItemId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_INVOICE_ITEM_FEE_STUD_FEE_ITEM key.
		///		fkFeeInvoiceItemFeeStudFeeItem Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeStudFeeItemId">بنود المصروفات على  طالب</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeInvoiceItem objects.</returns>
		public TList<FeeInvoiceItem> GetByFeeStudFeeItemId(System.Decimal _feeStudFeeItemId, int start, int pageLength,out int count)
		{
			return GetByFeeStudFeeItemId(null, _feeStudFeeItemId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_INVOICE_ITEM_FEE_STUD_FEE_ITEM key.
		///		FK_FEE_INVOICE_ITEM_FEE_STUD_FEE_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudFeeItemId">بنود المصروفات على  طالب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeInvoiceItem objects.</returns>
		public abstract TList<FeeInvoiceItem> GetByFeeStudFeeItemId(TransactionManager transactionManager, System.Decimal _feeStudFeeItemId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.FeeInvoiceItem Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeInvoiceItemKey key, int start, int pageLength)
		{
			return GetByFeeInvoiceItemId(transactionManager, key.FeeInvoiceItemId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_FEE_INVOICE_ITEM index.
		/// </summary>
		/// <param name="_feeInvoiceItemId">بنود الفاتورة</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeInvoiceItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeInvoiceItem GetByFeeInvoiceItemId(System.Decimal _feeInvoiceItemId)
		{
			int count = -1;
			return GetByFeeInvoiceItemId(null,_feeInvoiceItemId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_INVOICE_ITEM index.
		/// </summary>
		/// <param name="_feeInvoiceItemId">بنود الفاتورة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeInvoiceItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeInvoiceItem GetByFeeInvoiceItemId(System.Decimal _feeInvoiceItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeInvoiceItemId(null, _feeInvoiceItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_INVOICE_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeInvoiceItemId">بنود الفاتورة</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeInvoiceItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeInvoiceItem GetByFeeInvoiceItemId(TransactionManager transactionManager, System.Decimal _feeInvoiceItemId)
		{
			int count = -1;
			return GetByFeeInvoiceItemId(transactionManager, _feeInvoiceItemId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_INVOICE_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeInvoiceItemId">بنود الفاتورة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeInvoiceItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeInvoiceItem GetByFeeInvoiceItemId(TransactionManager transactionManager, System.Decimal _feeInvoiceItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeInvoiceItemId(transactionManager, _feeInvoiceItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_INVOICE_ITEM index.
		/// </summary>
		/// <param name="_feeInvoiceItemId">بنود الفاتورة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeInvoiceItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeInvoiceItem GetByFeeInvoiceItemId(System.Decimal _feeInvoiceItemId, int start, int pageLength, out int count)
		{
			return GetByFeeInvoiceItemId(null, _feeInvoiceItemId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_INVOICE_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeInvoiceItemId">بنود الفاتورة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeInvoiceItem"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.FeeInvoiceItem GetByFeeInvoiceItemId(TransactionManager transactionManager, System.Decimal _feeInvoiceItemId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;FeeInvoiceItem&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;FeeInvoiceItem&gt;"/></returns>
		public static TList<FeeInvoiceItem> Fill(IDataReader reader, TList<FeeInvoiceItem> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.FeeInvoiceItem c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("FeeInvoiceItem")
					.Append("|").Append((System.Decimal)reader["FEE_INVOICE_ITEM_ID"]).ToString();
					c = EntityManager.LocateOrCreate<FeeInvoiceItem>(
					key.ToString(), // EntityTrackingKey
					"FeeInvoiceItem",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.FeeInvoiceItem();
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
					c.FeeInvoiceItemId = (System.Decimal)reader["FEE_INVOICE_ITEM_ID"];
					c.OriginalFeeInvoiceItemId = c.FeeInvoiceItemId;
					c.FeeInvoiceId = (System.Decimal)reader["FEE_INVOICE_ID"];
					c.FeeStudFeeItemId = (System.Decimal)reader["FEE_STUD_FEE_ITEM_ID"];
					c.PayAmount = (System.Decimal)reader["PAY_AMOUNT"];
					c.DiscAmount = Convert.IsDBNull(reader["DISC_AMOUNT"]) ? null : (System.Decimal?)reader["DISC_AMOUNT"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeInvoiceItem"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeInvoiceItem"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.FeeInvoiceItem entity)
		{
			if (!reader.Read()) return;
			
			entity.FeeInvoiceItemId = (System.Decimal)reader[((int)FeeInvoiceItemColumn.FeeInvoiceItemId - 1)];
			entity.OriginalFeeInvoiceItemId = (System.Decimal)reader["FEE_INVOICE_ITEM_ID"];
			entity.FeeInvoiceId = (System.Decimal)reader[((int)FeeInvoiceItemColumn.FeeInvoiceId - 1)];
			entity.FeeStudFeeItemId = (System.Decimal)reader[((int)FeeInvoiceItemColumn.FeeStudFeeItemId - 1)];
			entity.PayAmount = (System.Decimal)reader[((int)FeeInvoiceItemColumn.PayAmount - 1)];
			entity.DiscAmount = (reader.IsDBNull(((int)FeeInvoiceItemColumn.DiscAmount - 1)))?null:(System.Decimal?)reader[((int)FeeInvoiceItemColumn.DiscAmount - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)FeeInvoiceItemColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)FeeInvoiceItemColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)FeeInvoiceItemColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)FeeInvoiceItemColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeInvoiceItem"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeInvoiceItem"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.FeeInvoiceItem entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.FeeInvoiceItemId = (System.Decimal)dataRow["FEE_INVOICE_ITEM_ID"];
			entity.OriginalFeeInvoiceItemId = (System.Decimal)dataRow["FEE_INVOICE_ITEM_ID"];
			entity.FeeInvoiceId = (System.Decimal)dataRow["FEE_INVOICE_ID"];
			entity.FeeStudFeeItemId = (System.Decimal)dataRow["FEE_STUD_FEE_ITEM_ID"];
			entity.PayAmount = (System.Decimal)dataRow["PAY_AMOUNT"];
			entity.DiscAmount = Convert.IsDBNull(dataRow["DISC_AMOUNT"]) ? null : (System.Decimal?)dataRow["DISC_AMOUNT"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeInvoiceItem"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeInvoiceItem Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeInvoiceItem entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region FeeInvoiceIdSource	
			if (CanDeepLoad(entity, "FeeInvoice|FeeInvoiceIdSource", deepLoadType, innerList) 
				&& entity.FeeInvoiceIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.FeeInvoiceId;
				FeeInvoice tmpEntity = EntityManager.LocateEntity<FeeInvoice>(EntityLocator.ConstructKeyFromPkItems(typeof(FeeInvoice), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.FeeInvoiceIdSource = tmpEntity;
				else
					entity.FeeInvoiceIdSource = DataRepository.FeeInvoiceProvider.GetByFeeInvoiceId(transactionManager, entity.FeeInvoiceId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeInvoiceIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.FeeInvoiceIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.FeeInvoiceProvider.DeepLoad(transactionManager, entity.FeeInvoiceIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion FeeInvoiceIdSource

			#region FeeStudFeeItemIdSource	
			if (CanDeepLoad(entity, "FeeStudFeeItem|FeeStudFeeItemIdSource", deepLoadType, innerList) 
				&& entity.FeeStudFeeItemIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.FeeStudFeeItemId;
				FeeStudFeeItem tmpEntity = EntityManager.LocateEntity<FeeStudFeeItem>(EntityLocator.ConstructKeyFromPkItems(typeof(FeeStudFeeItem), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.FeeStudFeeItemIdSource = tmpEntity;
				else
					entity.FeeStudFeeItemIdSource = DataRepository.FeeStudFeeItemProvider.GetByFeeStudFeeItemId(transactionManager, entity.FeeStudFeeItemId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudFeeItemIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.FeeStudFeeItemIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.FeeStudFeeItemProvider.DeepLoad(transactionManager, entity.FeeStudFeeItemIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion FeeStudFeeItemIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByFeeInvoiceItemId methods when available
			
			#region FeeStudVoucherCrsItemCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeStudVoucherCrsItem>|FeeStudVoucherCrsItemCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudVoucherCrsItemCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeStudVoucherCrsItemCollection = DataRepository.FeeStudVoucherCrsItemProvider.GetByFeeInvoiceItemId(transactionManager, entity.FeeInvoiceItemId);

				if (deep && entity.FeeStudVoucherCrsItemCollection.Count > 0)
				{
					deepHandles.Add("FeeStudVoucherCrsItemCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudVoucherCrsItem>) DataRepository.FeeStudVoucherCrsItemProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudVoucherCrsItemCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.FeeInvoiceItem object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.FeeInvoiceItem instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeInvoiceItem Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeInvoiceItem entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region FeeInvoiceIdSource
			if (CanDeepSave(entity, "FeeInvoice|FeeInvoiceIdSource", deepSaveType, innerList) 
				&& entity.FeeInvoiceIdSource != null)
			{
				DataRepository.FeeInvoiceProvider.Save(transactionManager, entity.FeeInvoiceIdSource);
				entity.FeeInvoiceId = entity.FeeInvoiceIdSource.FeeInvoiceId;
			}
			#endregion 
			
			#region FeeStudFeeItemIdSource
			if (CanDeepSave(entity, "FeeStudFeeItem|FeeStudFeeItemIdSource", deepSaveType, innerList) 
				&& entity.FeeStudFeeItemIdSource != null)
			{
				DataRepository.FeeStudFeeItemProvider.Save(transactionManager, entity.FeeStudFeeItemIdSource);
				entity.FeeStudFeeItemId = entity.FeeStudFeeItemIdSource.FeeStudFeeItemId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<FeeStudVoucherCrsItem>
				if (CanDeepSave(entity.FeeStudVoucherCrsItemCollection, "List<FeeStudVoucherCrsItem>|FeeStudVoucherCrsItemCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeStudVoucherCrsItem child in entity.FeeStudVoucherCrsItemCollection)
					{
						if(child.FeeInvoiceItemIdSource != null)
						{
							child.FeeInvoiceItemId = child.FeeInvoiceItemIdSource.FeeInvoiceItemId;
						}
						else
						{
							child.FeeInvoiceItemId = entity.FeeInvoiceItemId;
						}

					}

					if (entity.FeeStudVoucherCrsItemCollection.Count > 0 || entity.FeeStudVoucherCrsItemCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeStudVoucherCrsItemProvider.Save(transactionManager, entity.FeeStudVoucherCrsItemCollection);
						
						deepHandles.Add("FeeStudVoucherCrsItemCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeStudVoucherCrsItem >) DataRepository.FeeStudVoucherCrsItemProvider.DeepSave,
							new object[] { transactionManager, entity.FeeStudVoucherCrsItemCollection, deepSaveType, childTypes, innerList }
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
	
	#region FeeInvoiceItemChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.FeeInvoiceItem</c>
	///</summary>
	public enum FeeInvoiceItemChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>FeeInvoice</c> at FeeInvoiceIdSource
		///</summary>
		[ChildEntityType(typeof(FeeInvoice))]
		FeeInvoice,
		
		///<summary>
		/// Composite Property for <c>FeeStudFeeItem</c> at FeeStudFeeItemIdSource
		///</summary>
		[ChildEntityType(typeof(FeeStudFeeItem))]
		FeeStudFeeItem,
		///<summary>
		/// Collection of <c>FeeInvoiceItem</c> as OneToMany for FeeStudVoucherCrsItemCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudVoucherCrsItem>))]
		FeeStudVoucherCrsItemCollection,
	}
	
	#endregion FeeInvoiceItemChildEntityTypes
	
	#region FeeInvoiceItemFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;FeeInvoiceItemColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeInvoiceItem"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeInvoiceItemFilterBuilder : SqlFilterBuilder<FeeInvoiceItemColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeInvoiceItemFilterBuilder class.
		/// </summary>
		public FeeInvoiceItemFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeInvoiceItemFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeInvoiceItemFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeInvoiceItemFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeInvoiceItemFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeInvoiceItemFilterBuilder
	
	#region FeeInvoiceItemParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;FeeInvoiceItemColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeInvoiceItem"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeInvoiceItemParameterBuilder : ParameterizedSqlFilterBuilder<FeeInvoiceItemColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeInvoiceItemParameterBuilder class.
		/// </summary>
		public FeeInvoiceItemParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeInvoiceItemParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeInvoiceItemParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeInvoiceItemParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeInvoiceItemParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeInvoiceItemParameterBuilder
	
	#region FeeInvoiceItemSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;FeeInvoiceItemColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeInvoiceItem"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class FeeInvoiceItemSortBuilder : SqlSortBuilder<FeeInvoiceItemColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeInvoiceItemSqlSortBuilder class.
		/// </summary>
		public FeeInvoiceItemSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion FeeInvoiceItemSortBuilder
	
} // end namespace
