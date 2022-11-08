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
	/// This class is the base class for any <see cref="AccomStudDismissProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AccomStudDismissProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AccomStudDismiss, UMIS_VER2.BusinessLyer.AccomStudDismissKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomStudDismissKey key)
		{
			return Delete(transactionManager, key.AccomStudDismissId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_accomStudDismissId">فصل/اخراج الطلاب من السكن الداخلي. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _accomStudDismissId)
		{
			return Delete(null, _accomStudDismissId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomStudDismissId">فصل/اخراج الطلاب من السكن الداخلي. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _accomStudDismissId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_DISMISS_ACCOM_CDE_BOOK_STATUS key.
		///		FK_ACCOM_STUD_DISMISS_ACCOM_CDE_BOOK_STATUS Description: 
		/// </summary>
		/// <param name="_accomCdeBookStatusId">2 or 3 only</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudDismiss objects.</returns>
		public TList<AccomStudDismiss> GetByAccomCdeBookStatusId(System.Int32 _accomCdeBookStatusId)
		{
			int count = -1;
			return GetByAccomCdeBookStatusId(_accomCdeBookStatusId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_DISMISS_ACCOM_CDE_BOOK_STATUS key.
		///		FK_ACCOM_STUD_DISMISS_ACCOM_CDE_BOOK_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomCdeBookStatusId">2 or 3 only</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudDismiss objects.</returns>
		/// <remarks></remarks>
		public TList<AccomStudDismiss> GetByAccomCdeBookStatusId(TransactionManager transactionManager, System.Int32 _accomCdeBookStatusId)
		{
			int count = -1;
			return GetByAccomCdeBookStatusId(transactionManager, _accomCdeBookStatusId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_DISMISS_ACCOM_CDE_BOOK_STATUS key.
		///		FK_ACCOM_STUD_DISMISS_ACCOM_CDE_BOOK_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomCdeBookStatusId">2 or 3 only</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudDismiss objects.</returns>
		public TList<AccomStudDismiss> GetByAccomCdeBookStatusId(TransactionManager transactionManager, System.Int32 _accomCdeBookStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetByAccomCdeBookStatusId(transactionManager, _accomCdeBookStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_DISMISS_ACCOM_CDE_BOOK_STATUS key.
		///		fkAccomStudDismissAccomCdeBookStatus Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_accomCdeBookStatusId">2 or 3 only</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudDismiss objects.</returns>
		public TList<AccomStudDismiss> GetByAccomCdeBookStatusId(System.Int32 _accomCdeBookStatusId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAccomCdeBookStatusId(null, _accomCdeBookStatusId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_DISMISS_ACCOM_CDE_BOOK_STATUS key.
		///		fkAccomStudDismissAccomCdeBookStatus Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_accomCdeBookStatusId">2 or 3 only</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudDismiss objects.</returns>
		public TList<AccomStudDismiss> GetByAccomCdeBookStatusId(System.Int32 _accomCdeBookStatusId, int start, int pageLength,out int count)
		{
			return GetByAccomCdeBookStatusId(null, _accomCdeBookStatusId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_DISMISS_ACCOM_CDE_BOOK_STATUS key.
		///		FK_ACCOM_STUD_DISMISS_ACCOM_CDE_BOOK_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomCdeBookStatusId">2 or 3 only</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudDismiss objects.</returns>
		public abstract TList<AccomStudDismiss> GetByAccomCdeBookStatusId(TransactionManager transactionManager, System.Int32 _accomCdeBookStatusId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_DISMISS_ACCOM_STUD_BOOK key.
		///		FK_ACCOM_STUD_DISMISS_ACCOM_STUD_BOOK Description: 
		/// </summary>
		/// <param name="_accomStudBookId">توزيع الطلاب علي الغرف</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudDismiss objects.</returns>
		public TList<AccomStudDismiss> GetByAccomStudBookId(System.Decimal _accomStudBookId)
		{
			int count = -1;
			return GetByAccomStudBookId(_accomStudBookId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_DISMISS_ACCOM_STUD_BOOK key.
		///		FK_ACCOM_STUD_DISMISS_ACCOM_STUD_BOOK Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomStudBookId">توزيع الطلاب علي الغرف</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudDismiss objects.</returns>
		/// <remarks></remarks>
		public TList<AccomStudDismiss> GetByAccomStudBookId(TransactionManager transactionManager, System.Decimal _accomStudBookId)
		{
			int count = -1;
			return GetByAccomStudBookId(transactionManager, _accomStudBookId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_DISMISS_ACCOM_STUD_BOOK key.
		///		FK_ACCOM_STUD_DISMISS_ACCOM_STUD_BOOK Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomStudBookId">توزيع الطلاب علي الغرف</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudDismiss objects.</returns>
		public TList<AccomStudDismiss> GetByAccomStudBookId(TransactionManager transactionManager, System.Decimal _accomStudBookId, int start, int pageLength)
		{
			int count = -1;
			return GetByAccomStudBookId(transactionManager, _accomStudBookId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_DISMISS_ACCOM_STUD_BOOK key.
		///		fkAccomStudDismissAccomStudBook Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_accomStudBookId">توزيع الطلاب علي الغرف</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudDismiss objects.</returns>
		public TList<AccomStudDismiss> GetByAccomStudBookId(System.Decimal _accomStudBookId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAccomStudBookId(null, _accomStudBookId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_DISMISS_ACCOM_STUD_BOOK key.
		///		fkAccomStudDismissAccomStudBook Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_accomStudBookId">توزيع الطلاب علي الغرف</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudDismiss objects.</returns>
		public TList<AccomStudDismiss> GetByAccomStudBookId(System.Decimal _accomStudBookId, int start, int pageLength,out int count)
		{
			return GetByAccomStudBookId(null, _accomStudBookId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_DISMISS_ACCOM_STUD_BOOK key.
		///		FK_ACCOM_STUD_DISMISS_ACCOM_STUD_BOOK Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomStudBookId">توزيع الطلاب علي الغرف</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudDismiss objects.</returns>
		public abstract TList<AccomStudDismiss> GetByAccomStudBookId(TransactionManager transactionManager, System.Decimal _accomStudBookId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.AccomStudDismiss Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomStudDismissKey key, int start, int pageLength)
		{
			return GetByAccomStudDismissId(transactionManager, key.AccomStudDismissId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ACCOM_STUD_DISMISS index.
		/// </summary>
		/// <param name="_accomStudDismissId">فصل/اخراج الطلاب من السكن الداخلي</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomStudDismiss"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomStudDismiss GetByAccomStudDismissId(System.Decimal _accomStudDismissId)
		{
			int count = -1;
			return GetByAccomStudDismissId(null,_accomStudDismissId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_STUD_DISMISS index.
		/// </summary>
		/// <param name="_accomStudDismissId">فصل/اخراج الطلاب من السكن الداخلي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomStudDismiss"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomStudDismiss GetByAccomStudDismissId(System.Decimal _accomStudDismissId, int start, int pageLength)
		{
			int count = -1;
			return GetByAccomStudDismissId(null, _accomStudDismissId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_STUD_DISMISS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomStudDismissId">فصل/اخراج الطلاب من السكن الداخلي</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomStudDismiss"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomStudDismiss GetByAccomStudDismissId(TransactionManager transactionManager, System.Decimal _accomStudDismissId)
		{
			int count = -1;
			return GetByAccomStudDismissId(transactionManager, _accomStudDismissId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_STUD_DISMISS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomStudDismissId">فصل/اخراج الطلاب من السكن الداخلي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomStudDismiss"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomStudDismiss GetByAccomStudDismissId(TransactionManager transactionManager, System.Decimal _accomStudDismissId, int start, int pageLength)
		{
			int count = -1;
			return GetByAccomStudDismissId(transactionManager, _accomStudDismissId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_STUD_DISMISS index.
		/// </summary>
		/// <param name="_accomStudDismissId">فصل/اخراج الطلاب من السكن الداخلي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomStudDismiss"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomStudDismiss GetByAccomStudDismissId(System.Decimal _accomStudDismissId, int start, int pageLength, out int count)
		{
			return GetByAccomStudDismissId(null, _accomStudDismissId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_STUD_DISMISS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomStudDismissId">فصل/اخراج الطلاب من السكن الداخلي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomStudDismiss"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AccomStudDismiss GetByAccomStudDismissId(TransactionManager transactionManager, System.Decimal _accomStudDismissId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AccomStudDismiss&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AccomStudDismiss&gt;"/></returns>
		public static TList<AccomStudDismiss> Fill(IDataReader reader, TList<AccomStudDismiss> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AccomStudDismiss c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AccomStudDismiss")
					.Append("|").Append((System.Decimal)reader["ACCOM_STUD_DISMISS_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AccomStudDismiss>(
					key.ToString(), // EntityTrackingKey
					"AccomStudDismiss",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AccomStudDismiss();
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
					c.AccomStudDismissId = (System.Decimal)reader["ACCOM_STUD_DISMISS_ID"];
					c.OriginalAccomStudDismissId = c.AccomStudDismissId;
					c.AccomStudBookId = (System.Decimal)reader["ACCOM_STUD_BOOK_ID"];
					c.AccomCdeBookStatusId = (System.Int32)reader["ACCOM_CDE_BOOK_STATUS_ID"];
					c.FromDate = Convert.IsDBNull(reader["FROM_DATE"]) ? null : (System.DateTime?)reader["FROM_DATE"];
					c.ToDate = Convert.IsDBNull(reader["TO_DATE"]) ? null : (System.DateTime?)reader["TO_DATE"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
					c.ApproveFlg = (System.Int32)reader["APPROVE_FLG"];
					c.ApproveDate = Convert.IsDBNull(reader["APPROVE_DATE"]) ? null : (System.DateTime?)reader["APPROVE_DATE"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AccomStudDismiss"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AccomStudDismiss"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AccomStudDismiss entity)
		{
			if (!reader.Read()) return;
			
			entity.AccomStudDismissId = (System.Decimal)reader[((int)AccomStudDismissColumn.AccomStudDismissId - 1)];
			entity.OriginalAccomStudDismissId = (System.Decimal)reader["ACCOM_STUD_DISMISS_ID"];
			entity.AccomStudBookId = (System.Decimal)reader[((int)AccomStudDismissColumn.AccomStudBookId - 1)];
			entity.AccomCdeBookStatusId = (System.Int32)reader[((int)AccomStudDismissColumn.AccomCdeBookStatusId - 1)];
			entity.FromDate = (reader.IsDBNull(((int)AccomStudDismissColumn.FromDate - 1)))?null:(System.DateTime?)reader[((int)AccomStudDismissColumn.FromDate - 1)];
			entity.ToDate = (reader.IsDBNull(((int)AccomStudDismissColumn.ToDate - 1)))?null:(System.DateTime?)reader[((int)AccomStudDismissColumn.ToDate - 1)];
			entity.Notes = (reader.IsDBNull(((int)AccomStudDismissColumn.Notes - 1)))?null:(System.String)reader[((int)AccomStudDismissColumn.Notes - 1)];
			entity.ApproveFlg = (System.Int32)reader[((int)AccomStudDismissColumn.ApproveFlg - 1)];
			entity.ApproveDate = (reader.IsDBNull(((int)AccomStudDismissColumn.ApproveDate - 1)))?null:(System.DateTime?)reader[((int)AccomStudDismissColumn.ApproveDate - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)AccomStudDismissColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)AccomStudDismissColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)AccomStudDismissColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)AccomStudDismissColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AccomStudDismiss"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AccomStudDismiss"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AccomStudDismiss entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AccomStudDismissId = (System.Decimal)dataRow["ACCOM_STUD_DISMISS_ID"];
			entity.OriginalAccomStudDismissId = (System.Decimal)dataRow["ACCOM_STUD_DISMISS_ID"];
			entity.AccomStudBookId = (System.Decimal)dataRow["ACCOM_STUD_BOOK_ID"];
			entity.AccomCdeBookStatusId = (System.Int32)dataRow["ACCOM_CDE_BOOK_STATUS_ID"];
			entity.FromDate = Convert.IsDBNull(dataRow["FROM_DATE"]) ? null : (System.DateTime?)dataRow["FROM_DATE"];
			entity.ToDate = Convert.IsDBNull(dataRow["TO_DATE"]) ? null : (System.DateTime?)dataRow["TO_DATE"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
			entity.ApproveFlg = (System.Int32)dataRow["APPROVE_FLG"];
			entity.ApproveDate = Convert.IsDBNull(dataRow["APPROVE_DATE"]) ? null : (System.DateTime?)dataRow["APPROVE_DATE"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AccomStudDismiss"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AccomStudDismiss Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomStudDismiss entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AccomCdeBookStatusIdSource	
			if (CanDeepLoad(entity, "AccomCdeBookStatus|AccomCdeBookStatusIdSource", deepLoadType, innerList) 
				&& entity.AccomCdeBookStatusIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AccomCdeBookStatusId;
				AccomCdeBookStatus tmpEntity = EntityManager.LocateEntity<AccomCdeBookStatus>(EntityLocator.ConstructKeyFromPkItems(typeof(AccomCdeBookStatus), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AccomCdeBookStatusIdSource = tmpEntity;
				else
					entity.AccomCdeBookStatusIdSource = DataRepository.AccomCdeBookStatusProvider.GetByAccomCdeBookStatusId(transactionManager, entity.AccomCdeBookStatusId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AccomCdeBookStatusIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AccomCdeBookStatusIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AccomCdeBookStatusProvider.DeepLoad(transactionManager, entity.AccomCdeBookStatusIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AccomCdeBookStatusIdSource

			#region AccomStudBookIdSource	
			if (CanDeepLoad(entity, "AccomStudBook|AccomStudBookIdSource", deepLoadType, innerList) 
				&& entity.AccomStudBookIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AccomStudBookId;
				AccomStudBook tmpEntity = EntityManager.LocateEntity<AccomStudBook>(EntityLocator.ConstructKeyFromPkItems(typeof(AccomStudBook), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AccomStudBookIdSource = tmpEntity;
				else
					entity.AccomStudBookIdSource = DataRepository.AccomStudBookProvider.GetByAccomStudBookId(transactionManager, entity.AccomStudBookId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AccomStudBookIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AccomStudBookIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AccomStudBookProvider.DeepLoad(transactionManager, entity.AccomStudBookIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AccomStudBookIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AccomStudDismiss object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AccomStudDismiss instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AccomStudDismiss Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomStudDismiss entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AccomCdeBookStatusIdSource
			if (CanDeepSave(entity, "AccomCdeBookStatus|AccomCdeBookStatusIdSource", deepSaveType, innerList) 
				&& entity.AccomCdeBookStatusIdSource != null)
			{
				DataRepository.AccomCdeBookStatusProvider.Save(transactionManager, entity.AccomCdeBookStatusIdSource);
				entity.AccomCdeBookStatusId = entity.AccomCdeBookStatusIdSource.AccomCdeBookStatusId;
			}
			#endregion 
			
			#region AccomStudBookIdSource
			if (CanDeepSave(entity, "AccomStudBook|AccomStudBookIdSource", deepSaveType, innerList) 
				&& entity.AccomStudBookIdSource != null)
			{
				DataRepository.AccomStudBookProvider.Save(transactionManager, entity.AccomStudBookIdSource);
				entity.AccomStudBookId = entity.AccomStudBookIdSource.AccomStudBookId;
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
	
	#region AccomStudDismissChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AccomStudDismiss</c>
	///</summary>
	public enum AccomStudDismissChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AccomCdeBookStatus</c> at AccomCdeBookStatusIdSource
		///</summary>
		[ChildEntityType(typeof(AccomCdeBookStatus))]
		AccomCdeBookStatus,
		
		///<summary>
		/// Composite Property for <c>AccomStudBook</c> at AccomStudBookIdSource
		///</summary>
		[ChildEntityType(typeof(AccomStudBook))]
		AccomStudBook,
	}
	
	#endregion AccomStudDismissChildEntityTypes
	
	#region AccomStudDismissFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AccomStudDismissColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AccomStudDismiss"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AccomStudDismissFilterBuilder : SqlFilterBuilder<AccomStudDismissColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AccomStudDismissFilterBuilder class.
		/// </summary>
		public AccomStudDismissFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AccomStudDismissFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AccomStudDismissFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AccomStudDismissFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AccomStudDismissFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AccomStudDismissFilterBuilder
	
	#region AccomStudDismissParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AccomStudDismissColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AccomStudDismiss"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AccomStudDismissParameterBuilder : ParameterizedSqlFilterBuilder<AccomStudDismissColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AccomStudDismissParameterBuilder class.
		/// </summary>
		public AccomStudDismissParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AccomStudDismissParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AccomStudDismissParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AccomStudDismissParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AccomStudDismissParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AccomStudDismissParameterBuilder
	
	#region AccomStudDismissSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AccomStudDismissColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AccomStudDismiss"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AccomStudDismissSortBuilder : SqlSortBuilder<AccomStudDismissColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AccomStudDismissSqlSortBuilder class.
		/// </summary>
		public AccomStudDismissSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AccomStudDismissSortBuilder
	
} // end namespace
