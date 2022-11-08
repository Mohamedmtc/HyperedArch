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
	/// This class is the base class for any <see cref="FeeVoucherInvocProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class FeeVoucherInvocProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.FeeVoucherInvoc, UMIS_VER2.BusinessLyer.FeeVoucherInvocKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeVoucherInvocKey key)
		{
			return Delete(transactionManager, key.FeeVoucherInvocId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_feeVoucherInvocId">دفع الفواتير على اكتر منايصال - دفع ايصال به اكترمنفاتورة. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _feeVoucherInvocId)
		{
			return Delete(null, _feeVoucherInvocId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeVoucherInvocId">دفع الفواتير على اكتر منايصال - دفع ايصال به اكترمنفاتورة. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _feeVoucherInvocId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_VOUCHER_INVOC_FEE_INVOICE key.
		///		FK_FEE_VOUCHER_INVOC_FEE_INVOICE Description: 
		/// </summary>
		/// <param name="_feeInvoiceId">فاتورة كفيل- or credit memo</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeVoucherInvoc objects.</returns>
		public TList<FeeVoucherInvoc> GetByFeeInvoiceId(System.Decimal _feeInvoiceId)
		{
			int count = -1;
			return GetByFeeInvoiceId(_feeInvoiceId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_VOUCHER_INVOC_FEE_INVOICE key.
		///		FK_FEE_VOUCHER_INVOC_FEE_INVOICE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeInvoiceId">فاتورة كفيل- or credit memo</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeVoucherInvoc objects.</returns>
		/// <remarks></remarks>
		public TList<FeeVoucherInvoc> GetByFeeInvoiceId(TransactionManager transactionManager, System.Decimal _feeInvoiceId)
		{
			int count = -1;
			return GetByFeeInvoiceId(transactionManager, _feeInvoiceId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_VOUCHER_INVOC_FEE_INVOICE key.
		///		FK_FEE_VOUCHER_INVOC_FEE_INVOICE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeInvoiceId">فاتورة كفيل- or credit memo</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeVoucherInvoc objects.</returns>
		public TList<FeeVoucherInvoc> GetByFeeInvoiceId(TransactionManager transactionManager, System.Decimal _feeInvoiceId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeInvoiceId(transactionManager, _feeInvoiceId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_VOUCHER_INVOC_FEE_INVOICE key.
		///		fkFeeVoucherInvocFeeInvoice Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeInvoiceId">فاتورة كفيل- or credit memo</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeVoucherInvoc objects.</returns>
		public TList<FeeVoucherInvoc> GetByFeeInvoiceId(System.Decimal _feeInvoiceId, int start, int pageLength)
		{
			int count =  -1;
			return GetByFeeInvoiceId(null, _feeInvoiceId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_VOUCHER_INVOC_FEE_INVOICE key.
		///		fkFeeVoucherInvocFeeInvoice Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeInvoiceId">فاتورة كفيل- or credit memo</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeVoucherInvoc objects.</returns>
		public TList<FeeVoucherInvoc> GetByFeeInvoiceId(System.Decimal _feeInvoiceId, int start, int pageLength,out int count)
		{
			return GetByFeeInvoiceId(null, _feeInvoiceId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_VOUCHER_INVOC_FEE_INVOICE key.
		///		FK_FEE_VOUCHER_INVOC_FEE_INVOICE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeInvoiceId">فاتورة كفيل- or credit memo</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeVoucherInvoc objects.</returns>
		public abstract TList<FeeVoucherInvoc> GetByFeeInvoiceId(TransactionManager transactionManager, System.Decimal _feeInvoiceId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_VOUCHER_INVOC_FEE_STUD_VOUCHER key.
		///		FK_FEE_VOUCHER_INVOC_FEE_STUD_VOUCHER Description: 
		/// </summary>
		/// <param name="_feeStudVoucherId">اذن دفع/ايصال سداد</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeVoucherInvoc objects.</returns>
		public TList<FeeVoucherInvoc> GetByFeeStudVoucherId(System.Decimal _feeStudVoucherId)
		{
			int count = -1;
			return GetByFeeStudVoucherId(_feeStudVoucherId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_VOUCHER_INVOC_FEE_STUD_VOUCHER key.
		///		FK_FEE_VOUCHER_INVOC_FEE_STUD_VOUCHER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudVoucherId">اذن دفع/ايصال سداد</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeVoucherInvoc objects.</returns>
		/// <remarks></remarks>
		public TList<FeeVoucherInvoc> GetByFeeStudVoucherId(TransactionManager transactionManager, System.Decimal _feeStudVoucherId)
		{
			int count = -1;
			return GetByFeeStudVoucherId(transactionManager, _feeStudVoucherId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_VOUCHER_INVOC_FEE_STUD_VOUCHER key.
		///		FK_FEE_VOUCHER_INVOC_FEE_STUD_VOUCHER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudVoucherId">اذن دفع/ايصال سداد</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeVoucherInvoc objects.</returns>
		public TList<FeeVoucherInvoc> GetByFeeStudVoucherId(TransactionManager transactionManager, System.Decimal _feeStudVoucherId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeStudVoucherId(transactionManager, _feeStudVoucherId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_VOUCHER_INVOC_FEE_STUD_VOUCHER key.
		///		fkFeeVoucherInvocFeeStudVoucher Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeStudVoucherId">اذن دفع/ايصال سداد</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeVoucherInvoc objects.</returns>
		public TList<FeeVoucherInvoc> GetByFeeStudVoucherId(System.Decimal _feeStudVoucherId, int start, int pageLength)
		{
			int count =  -1;
			return GetByFeeStudVoucherId(null, _feeStudVoucherId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_VOUCHER_INVOC_FEE_STUD_VOUCHER key.
		///		fkFeeVoucherInvocFeeStudVoucher Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeStudVoucherId">اذن دفع/ايصال سداد</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeVoucherInvoc objects.</returns>
		public TList<FeeVoucherInvoc> GetByFeeStudVoucherId(System.Decimal _feeStudVoucherId, int start, int pageLength,out int count)
		{
			return GetByFeeStudVoucherId(null, _feeStudVoucherId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_VOUCHER_INVOC_FEE_STUD_VOUCHER key.
		///		FK_FEE_VOUCHER_INVOC_FEE_STUD_VOUCHER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudVoucherId">اذن دفع/ايصال سداد</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeVoucherInvoc objects.</returns>
		public abstract TList<FeeVoucherInvoc> GetByFeeStudVoucherId(TransactionManager transactionManager, System.Decimal _feeStudVoucherId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.FeeVoucherInvoc Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeVoucherInvocKey key, int start, int pageLength)
		{
			return GetByFeeVoucherInvocId(transactionManager, key.FeeVoucherInvocId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_FEE_VOUCHER_INVOC index.
		/// </summary>
		/// <param name="_feeVoucherInvocId">دفع الفواتير على اكتر منايصال - دفع ايصال به اكترمنفاتورة</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeVoucherInvoc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeVoucherInvoc GetByFeeVoucherInvocId(System.Decimal _feeVoucherInvocId)
		{
			int count = -1;
			return GetByFeeVoucherInvocId(null,_feeVoucherInvocId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_VOUCHER_INVOC index.
		/// </summary>
		/// <param name="_feeVoucherInvocId">دفع الفواتير على اكتر منايصال - دفع ايصال به اكترمنفاتورة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeVoucherInvoc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeVoucherInvoc GetByFeeVoucherInvocId(System.Decimal _feeVoucherInvocId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeVoucherInvocId(null, _feeVoucherInvocId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_VOUCHER_INVOC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeVoucherInvocId">دفع الفواتير على اكتر منايصال - دفع ايصال به اكترمنفاتورة</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeVoucherInvoc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeVoucherInvoc GetByFeeVoucherInvocId(TransactionManager transactionManager, System.Decimal _feeVoucherInvocId)
		{
			int count = -1;
			return GetByFeeVoucherInvocId(transactionManager, _feeVoucherInvocId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_VOUCHER_INVOC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeVoucherInvocId">دفع الفواتير على اكتر منايصال - دفع ايصال به اكترمنفاتورة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeVoucherInvoc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeVoucherInvoc GetByFeeVoucherInvocId(TransactionManager transactionManager, System.Decimal _feeVoucherInvocId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeVoucherInvocId(transactionManager, _feeVoucherInvocId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_VOUCHER_INVOC index.
		/// </summary>
		/// <param name="_feeVoucherInvocId">دفع الفواتير على اكتر منايصال - دفع ايصال به اكترمنفاتورة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeVoucherInvoc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeVoucherInvoc GetByFeeVoucherInvocId(System.Decimal _feeVoucherInvocId, int start, int pageLength, out int count)
		{
			return GetByFeeVoucherInvocId(null, _feeVoucherInvocId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_VOUCHER_INVOC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeVoucherInvocId">دفع الفواتير على اكتر منايصال - دفع ايصال به اكترمنفاتورة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeVoucherInvoc"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.FeeVoucherInvoc GetByFeeVoucherInvocId(TransactionManager transactionManager, System.Decimal _feeVoucherInvocId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;FeeVoucherInvoc&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;FeeVoucherInvoc&gt;"/></returns>
		public static TList<FeeVoucherInvoc> Fill(IDataReader reader, TList<FeeVoucherInvoc> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.FeeVoucherInvoc c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("FeeVoucherInvoc")
					.Append("|").Append((System.Decimal)reader["FEE_VOUCHER_INVOC_ID"]).ToString();
					c = EntityManager.LocateOrCreate<FeeVoucherInvoc>(
					key.ToString(), // EntityTrackingKey
					"FeeVoucherInvoc",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.FeeVoucherInvoc();
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
					c.FeeVoucherInvocId = (System.Decimal)reader["FEE_VOUCHER_INVOC_ID"];
					c.OriginalFeeVoucherInvocId = c.FeeVoucherInvocId;
					c.FeeStudVoucherId = (System.Decimal)reader["FEE_STUD_VOUCHER_ID"];
					c.FeeInvoiceId = (System.Decimal)reader["FEE_INVOICE_ID"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeVoucherInvoc"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeVoucherInvoc"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.FeeVoucherInvoc entity)
		{
			if (!reader.Read()) return;
			
			entity.FeeVoucherInvocId = (System.Decimal)reader[((int)FeeVoucherInvocColumn.FeeVoucherInvocId - 1)];
			entity.OriginalFeeVoucherInvocId = (System.Decimal)reader["FEE_VOUCHER_INVOC_ID"];
			entity.FeeStudVoucherId = (System.Decimal)reader[((int)FeeVoucherInvocColumn.FeeStudVoucherId - 1)];
			entity.FeeInvoiceId = (System.Decimal)reader[((int)FeeVoucherInvocColumn.FeeInvoiceId - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)FeeVoucherInvocColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)FeeVoucherInvocColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)FeeVoucherInvocColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)FeeVoucherInvocColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeVoucherInvoc"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeVoucherInvoc"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.FeeVoucherInvoc entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.FeeVoucherInvocId = (System.Decimal)dataRow["FEE_VOUCHER_INVOC_ID"];
			entity.OriginalFeeVoucherInvocId = (System.Decimal)dataRow["FEE_VOUCHER_INVOC_ID"];
			entity.FeeStudVoucherId = (System.Decimal)dataRow["FEE_STUD_VOUCHER_ID"];
			entity.FeeInvoiceId = (System.Decimal)dataRow["FEE_INVOICE_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeVoucherInvoc"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeVoucherInvoc Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeVoucherInvoc entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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

			#region FeeStudVoucherIdSource	
			if (CanDeepLoad(entity, "FeeStudVoucher|FeeStudVoucherIdSource", deepLoadType, innerList) 
				&& entity.FeeStudVoucherIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.FeeStudVoucherId;
				FeeStudVoucher tmpEntity = EntityManager.LocateEntity<FeeStudVoucher>(EntityLocator.ConstructKeyFromPkItems(typeof(FeeStudVoucher), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.FeeStudVoucherIdSource = tmpEntity;
				else
					entity.FeeStudVoucherIdSource = DataRepository.FeeStudVoucherProvider.GetByFeeStudVoucherId(transactionManager, entity.FeeStudVoucherId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudVoucherIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.FeeStudVoucherIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.FeeStudVoucherProvider.DeepLoad(transactionManager, entity.FeeStudVoucherIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion FeeStudVoucherIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.FeeVoucherInvoc object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.FeeVoucherInvoc instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeVoucherInvoc Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeVoucherInvoc entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region FeeStudVoucherIdSource
			if (CanDeepSave(entity, "FeeStudVoucher|FeeStudVoucherIdSource", deepSaveType, innerList) 
				&& entity.FeeStudVoucherIdSource != null)
			{
				DataRepository.FeeStudVoucherProvider.Save(transactionManager, entity.FeeStudVoucherIdSource);
				entity.FeeStudVoucherId = entity.FeeStudVoucherIdSource.FeeStudVoucherId;
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
	
	#region FeeVoucherInvocChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.FeeVoucherInvoc</c>
	///</summary>
	public enum FeeVoucherInvocChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>FeeInvoice</c> at FeeInvoiceIdSource
		///</summary>
		[ChildEntityType(typeof(FeeInvoice))]
		FeeInvoice,
		
		///<summary>
		/// Composite Property for <c>FeeStudVoucher</c> at FeeStudVoucherIdSource
		///</summary>
		[ChildEntityType(typeof(FeeStudVoucher))]
		FeeStudVoucher,
	}
	
	#endregion FeeVoucherInvocChildEntityTypes
	
	#region FeeVoucherInvocFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;FeeVoucherInvocColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeVoucherInvoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeVoucherInvocFilterBuilder : SqlFilterBuilder<FeeVoucherInvocColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeVoucherInvocFilterBuilder class.
		/// </summary>
		public FeeVoucherInvocFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeVoucherInvocFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeVoucherInvocFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeVoucherInvocFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeVoucherInvocFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeVoucherInvocFilterBuilder
	
	#region FeeVoucherInvocParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;FeeVoucherInvocColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeVoucherInvoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeVoucherInvocParameterBuilder : ParameterizedSqlFilterBuilder<FeeVoucherInvocColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeVoucherInvocParameterBuilder class.
		/// </summary>
		public FeeVoucherInvocParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeVoucherInvocParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeVoucherInvocParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeVoucherInvocParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeVoucherInvocParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeVoucherInvocParameterBuilder
	
	#region FeeVoucherInvocSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;FeeVoucherInvocColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeVoucherInvoc"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class FeeVoucherInvocSortBuilder : SqlSortBuilder<FeeVoucherInvocColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeVoucherInvocSqlSortBuilder class.
		/// </summary>
		public FeeVoucherInvocSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion FeeVoucherInvocSortBuilder
	
} // end namespace
