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
	/// This class is the base class for any <see cref="AccomStudFeedReqProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AccomStudFeedReqProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AccomStudFeedReq, UMIS_VER2.BusinessLyer.AccomStudFeedReqKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomStudFeedReqKey key)
		{
			return Delete(transactionManager, key.AccomStudFeedReqId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_accomStudFeedReqId">طلب تغذيه. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _accomStudFeedReqId)
		{
			return Delete(null, _accomStudFeedReqId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomStudFeedReqId">طلب تغذيه. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _accomStudFeedReqId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_FEED_REQ_ACCOM_STUD_BOOK key.
		///		FK_ACCOM_STUD_FEED_REQ_ACCOM_STUD_BOOK Description: 
		/// </summary>
		/// <param name="_accomStudBookId">توزيع الطلاب علي الغرف</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudFeedReq objects.</returns>
		public TList<AccomStudFeedReq> GetByAccomStudBookId(System.Decimal _accomStudBookId)
		{
			int count = -1;
			return GetByAccomStudBookId(_accomStudBookId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_FEED_REQ_ACCOM_STUD_BOOK key.
		///		FK_ACCOM_STUD_FEED_REQ_ACCOM_STUD_BOOK Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomStudBookId">توزيع الطلاب علي الغرف</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudFeedReq objects.</returns>
		/// <remarks></remarks>
		public TList<AccomStudFeedReq> GetByAccomStudBookId(TransactionManager transactionManager, System.Decimal _accomStudBookId)
		{
			int count = -1;
			return GetByAccomStudBookId(transactionManager, _accomStudBookId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_FEED_REQ_ACCOM_STUD_BOOK key.
		///		FK_ACCOM_STUD_FEED_REQ_ACCOM_STUD_BOOK Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomStudBookId">توزيع الطلاب علي الغرف</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudFeedReq objects.</returns>
		public TList<AccomStudFeedReq> GetByAccomStudBookId(TransactionManager transactionManager, System.Decimal _accomStudBookId, int start, int pageLength)
		{
			int count = -1;
			return GetByAccomStudBookId(transactionManager, _accomStudBookId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_FEED_REQ_ACCOM_STUD_BOOK key.
		///		fkAccomStudFeedReqAccomStudBook Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_accomStudBookId">توزيع الطلاب علي الغرف</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudFeedReq objects.</returns>
		public TList<AccomStudFeedReq> GetByAccomStudBookId(System.Decimal _accomStudBookId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAccomStudBookId(null, _accomStudBookId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_FEED_REQ_ACCOM_STUD_BOOK key.
		///		fkAccomStudFeedReqAccomStudBook Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_accomStudBookId">توزيع الطلاب علي الغرف</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudFeedReq objects.</returns>
		public TList<AccomStudFeedReq> GetByAccomStudBookId(System.Decimal _accomStudBookId, int start, int pageLength,out int count)
		{
			return GetByAccomStudBookId(null, _accomStudBookId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_FEED_REQ_ACCOM_STUD_BOOK key.
		///		FK_ACCOM_STUD_FEED_REQ_ACCOM_STUD_BOOK Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomStudBookId">توزيع الطلاب علي الغرف</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudFeedReq objects.</returns>
		public abstract TList<AccomStudFeedReq> GetByAccomStudBookId(TransactionManager transactionManager, System.Decimal _accomStudBookId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_FEED_REQ_GS_CODE_REQ_STATUS key.
		///		FK_ACCOM_STUD_FEED_REQ_GS_CODE_REQ_STATUS Description: 
		/// </summary>
		/// <param name="_gsCodeReqStatusId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudFeedReq objects.</returns>
		public TList<AccomStudFeedReq> GetByGsCodeReqStatusId(System.Decimal _gsCodeReqStatusId)
		{
			int count = -1;
			return GetByGsCodeReqStatusId(_gsCodeReqStatusId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_FEED_REQ_GS_CODE_REQ_STATUS key.
		///		FK_ACCOM_STUD_FEED_REQ_GS_CODE_REQ_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeReqStatusId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudFeedReq objects.</returns>
		/// <remarks></remarks>
		public TList<AccomStudFeedReq> GetByGsCodeReqStatusId(TransactionManager transactionManager, System.Decimal _gsCodeReqStatusId)
		{
			int count = -1;
			return GetByGsCodeReqStatusId(transactionManager, _gsCodeReqStatusId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_FEED_REQ_GS_CODE_REQ_STATUS key.
		///		FK_ACCOM_STUD_FEED_REQ_GS_CODE_REQ_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeReqStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudFeedReq objects.</returns>
		public TList<AccomStudFeedReq> GetByGsCodeReqStatusId(TransactionManager transactionManager, System.Decimal _gsCodeReqStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeReqStatusId(transactionManager, _gsCodeReqStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_FEED_REQ_GS_CODE_REQ_STATUS key.
		///		fkAccomStudFeedReqGsCodeReqStatus Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeReqStatusId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudFeedReq objects.</returns>
		public TList<AccomStudFeedReq> GetByGsCodeReqStatusId(System.Decimal _gsCodeReqStatusId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodeReqStatusId(null, _gsCodeReqStatusId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_FEED_REQ_GS_CODE_REQ_STATUS key.
		///		fkAccomStudFeedReqGsCodeReqStatus Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeReqStatusId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudFeedReq objects.</returns>
		public TList<AccomStudFeedReq> GetByGsCodeReqStatusId(System.Decimal _gsCodeReqStatusId, int start, int pageLength,out int count)
		{
			return GetByGsCodeReqStatusId(null, _gsCodeReqStatusId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_FEED_REQ_GS_CODE_REQ_STATUS key.
		///		FK_ACCOM_STUD_FEED_REQ_GS_CODE_REQ_STATUS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeReqStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudFeedReq objects.</returns>
		public abstract TList<AccomStudFeedReq> GetByGsCodeReqStatusId(TransactionManager transactionManager, System.Decimal _gsCodeReqStatusId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.AccomStudFeedReq Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomStudFeedReqKey key, int start, int pageLength)
		{
			return GetByAccomStudFeedReqId(transactionManager, key.AccomStudFeedReqId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ACCOM_STUD_FEED_REQ index.
		/// </summary>
		/// <param name="_accomStudFeedReqId">طلب تغذيه</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomStudFeedReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomStudFeedReq GetByAccomStudFeedReqId(System.Decimal _accomStudFeedReqId)
		{
			int count = -1;
			return GetByAccomStudFeedReqId(null,_accomStudFeedReqId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_STUD_FEED_REQ index.
		/// </summary>
		/// <param name="_accomStudFeedReqId">طلب تغذيه</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomStudFeedReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomStudFeedReq GetByAccomStudFeedReqId(System.Decimal _accomStudFeedReqId, int start, int pageLength)
		{
			int count = -1;
			return GetByAccomStudFeedReqId(null, _accomStudFeedReqId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_STUD_FEED_REQ index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomStudFeedReqId">طلب تغذيه</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomStudFeedReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomStudFeedReq GetByAccomStudFeedReqId(TransactionManager transactionManager, System.Decimal _accomStudFeedReqId)
		{
			int count = -1;
			return GetByAccomStudFeedReqId(transactionManager, _accomStudFeedReqId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_STUD_FEED_REQ index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomStudFeedReqId">طلب تغذيه</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomStudFeedReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomStudFeedReq GetByAccomStudFeedReqId(TransactionManager transactionManager, System.Decimal _accomStudFeedReqId, int start, int pageLength)
		{
			int count = -1;
			return GetByAccomStudFeedReqId(transactionManager, _accomStudFeedReqId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_STUD_FEED_REQ index.
		/// </summary>
		/// <param name="_accomStudFeedReqId">طلب تغذيه</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomStudFeedReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomStudFeedReq GetByAccomStudFeedReqId(System.Decimal _accomStudFeedReqId, int start, int pageLength, out int count)
		{
			return GetByAccomStudFeedReqId(null, _accomStudFeedReqId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_STUD_FEED_REQ index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomStudFeedReqId">طلب تغذيه</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomStudFeedReq"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AccomStudFeedReq GetByAccomStudFeedReqId(TransactionManager transactionManager, System.Decimal _accomStudFeedReqId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AccomStudFeedReq&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AccomStudFeedReq&gt;"/></returns>
		public static TList<AccomStudFeedReq> Fill(IDataReader reader, TList<AccomStudFeedReq> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AccomStudFeedReq c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AccomStudFeedReq")
					.Append("|").Append((System.Decimal)reader["ACCOM_STUD_FEED_REQ_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AccomStudFeedReq>(
					key.ToString(), // EntityTrackingKey
					"AccomStudFeedReq",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AccomStudFeedReq();
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
					c.AccomStudFeedReqId = (System.Decimal)reader["ACCOM_STUD_FEED_REQ_ID"];
					c.OriginalAccomStudFeedReqId = c.AccomStudFeedReqId;
					c.AccomStudBookId = (System.Decimal)reader["ACCOM_STUD_BOOK_ID"];
					c.ReqDate = Convert.IsDBNull(reader["REQ_DATE"]) ? null : (System.DateTime?)reader["REQ_DATE"];
					c.GsCodeReqStatusId = (System.Decimal)reader["GS_CODE_REQ_STATUS_ID"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AccomStudFeedReq"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AccomStudFeedReq"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AccomStudFeedReq entity)
		{
			if (!reader.Read()) return;
			
			entity.AccomStudFeedReqId = (System.Decimal)reader[((int)AccomStudFeedReqColumn.AccomStudFeedReqId - 1)];
			entity.OriginalAccomStudFeedReqId = (System.Decimal)reader["ACCOM_STUD_FEED_REQ_ID"];
			entity.AccomStudBookId = (System.Decimal)reader[((int)AccomStudFeedReqColumn.AccomStudBookId - 1)];
			entity.ReqDate = (reader.IsDBNull(((int)AccomStudFeedReqColumn.ReqDate - 1)))?null:(System.DateTime?)reader[((int)AccomStudFeedReqColumn.ReqDate - 1)];
			entity.GsCodeReqStatusId = (System.Decimal)reader[((int)AccomStudFeedReqColumn.GsCodeReqStatusId - 1)];
			entity.Notes = (reader.IsDBNull(((int)AccomStudFeedReqColumn.Notes - 1)))?null:(System.String)reader[((int)AccomStudFeedReqColumn.Notes - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)AccomStudFeedReqColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)AccomStudFeedReqColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)AccomStudFeedReqColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)AccomStudFeedReqColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AccomStudFeedReq"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AccomStudFeedReq"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AccomStudFeedReq entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AccomStudFeedReqId = (System.Decimal)dataRow["ACCOM_STUD_FEED_REQ_ID"];
			entity.OriginalAccomStudFeedReqId = (System.Decimal)dataRow["ACCOM_STUD_FEED_REQ_ID"];
			entity.AccomStudBookId = (System.Decimal)dataRow["ACCOM_STUD_BOOK_ID"];
			entity.ReqDate = Convert.IsDBNull(dataRow["REQ_DATE"]) ? null : (System.DateTime?)dataRow["REQ_DATE"];
			entity.GsCodeReqStatusId = (System.Decimal)dataRow["GS_CODE_REQ_STATUS_ID"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AccomStudFeedReq"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AccomStudFeedReq Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomStudFeedReq entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

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

			#region GsCodeReqStatusIdSource	
			if (CanDeepLoad(entity, "GsCodeReqStatus|GsCodeReqStatusIdSource", deepLoadType, innerList) 
				&& entity.GsCodeReqStatusIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.GsCodeReqStatusId;
				GsCodeReqStatus tmpEntity = EntityManager.LocateEntity<GsCodeReqStatus>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodeReqStatus), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodeReqStatusIdSource = tmpEntity;
				else
					entity.GsCodeReqStatusIdSource = DataRepository.GsCodeReqStatusProvider.GetByGsCodeReqStatusId(transactionManager, entity.GsCodeReqStatusId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodeReqStatusIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCodeReqStatusIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodeReqStatusProvider.DeepLoad(transactionManager, entity.GsCodeReqStatusIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCodeReqStatusIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByAccomStudFeedReqId methods when available
			
			#region AccomStudFeedReqDtlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AccomStudFeedReqDtl>|AccomStudFeedReqDtlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AccomStudFeedReqDtlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AccomStudFeedReqDtlCollection = DataRepository.AccomStudFeedReqDtlProvider.GetByAccomStudFeedReqId(transactionManager, entity.AccomStudFeedReqId);

				if (deep && entity.AccomStudFeedReqDtlCollection.Count > 0)
				{
					deepHandles.Add("AccomStudFeedReqDtlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AccomStudFeedReqDtl>) DataRepository.AccomStudFeedReqDtlProvider.DeepLoad,
						new object[] { transactionManager, entity.AccomStudFeedReqDtlCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AccomStudFeedReq object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AccomStudFeedReq instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AccomStudFeedReq Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomStudFeedReq entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AccomStudBookIdSource
			if (CanDeepSave(entity, "AccomStudBook|AccomStudBookIdSource", deepSaveType, innerList) 
				&& entity.AccomStudBookIdSource != null)
			{
				DataRepository.AccomStudBookProvider.Save(transactionManager, entity.AccomStudBookIdSource);
				entity.AccomStudBookId = entity.AccomStudBookIdSource.AccomStudBookId;
			}
			#endregion 
			
			#region GsCodeReqStatusIdSource
			if (CanDeepSave(entity, "GsCodeReqStatus|GsCodeReqStatusIdSource", deepSaveType, innerList) 
				&& entity.GsCodeReqStatusIdSource != null)
			{
				DataRepository.GsCodeReqStatusProvider.Save(transactionManager, entity.GsCodeReqStatusIdSource);
				entity.GsCodeReqStatusId = entity.GsCodeReqStatusIdSource.GsCodeReqStatusId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<AccomStudFeedReqDtl>
				if (CanDeepSave(entity.AccomStudFeedReqDtlCollection, "List<AccomStudFeedReqDtl>|AccomStudFeedReqDtlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AccomStudFeedReqDtl child in entity.AccomStudFeedReqDtlCollection)
					{
						if(child.AccomStudFeedReqIdSource != null)
						{
							child.AccomStudFeedReqId = child.AccomStudFeedReqIdSource.AccomStudFeedReqId;
						}
						else
						{
							child.AccomStudFeedReqId = entity.AccomStudFeedReqId;
						}

					}

					if (entity.AccomStudFeedReqDtlCollection.Count > 0 || entity.AccomStudFeedReqDtlCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AccomStudFeedReqDtlProvider.Save(transactionManager, entity.AccomStudFeedReqDtlCollection);
						
						deepHandles.Add("AccomStudFeedReqDtlCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AccomStudFeedReqDtl >) DataRepository.AccomStudFeedReqDtlProvider.DeepSave,
							new object[] { transactionManager, entity.AccomStudFeedReqDtlCollection, deepSaveType, childTypes, innerList }
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
	
	#region AccomStudFeedReqChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AccomStudFeedReq</c>
	///</summary>
	public enum AccomStudFeedReqChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AccomStudBook</c> at AccomStudBookIdSource
		///</summary>
		[ChildEntityType(typeof(AccomStudBook))]
		AccomStudBook,
		
		///<summary>
		/// Composite Property for <c>GsCodeReqStatus</c> at GsCodeReqStatusIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeReqStatus))]
		GsCodeReqStatus,
		///<summary>
		/// Collection of <c>AccomStudFeedReq</c> as OneToMany for AccomStudFeedReqDtlCollection
		///</summary>
		[ChildEntityType(typeof(TList<AccomStudFeedReqDtl>))]
		AccomStudFeedReqDtlCollection,
	}
	
	#endregion AccomStudFeedReqChildEntityTypes
	
	#region AccomStudFeedReqFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AccomStudFeedReqColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AccomStudFeedReq"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AccomStudFeedReqFilterBuilder : SqlFilterBuilder<AccomStudFeedReqColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AccomStudFeedReqFilterBuilder class.
		/// </summary>
		public AccomStudFeedReqFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AccomStudFeedReqFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AccomStudFeedReqFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AccomStudFeedReqFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AccomStudFeedReqFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AccomStudFeedReqFilterBuilder
	
	#region AccomStudFeedReqParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AccomStudFeedReqColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AccomStudFeedReq"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AccomStudFeedReqParameterBuilder : ParameterizedSqlFilterBuilder<AccomStudFeedReqColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AccomStudFeedReqParameterBuilder class.
		/// </summary>
		public AccomStudFeedReqParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AccomStudFeedReqParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AccomStudFeedReqParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AccomStudFeedReqParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AccomStudFeedReqParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AccomStudFeedReqParameterBuilder
	
	#region AccomStudFeedReqSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AccomStudFeedReqColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AccomStudFeedReq"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AccomStudFeedReqSortBuilder : SqlSortBuilder<AccomStudFeedReqColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AccomStudFeedReqSqlSortBuilder class.
		/// </summary>
		public AccomStudFeedReqSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AccomStudFeedReqSortBuilder
	
} // end namespace
