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
	/// This class is the base class for any <see cref="AccomStudFeedReqDtlProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AccomStudFeedReqDtlProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AccomStudFeedReqDtl, UMIS_VER2.BusinessLyer.AccomStudFeedReqDtlKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomStudFeedReqDtlKey key)
		{
			return Delete(transactionManager, key.AccomStudFeedReqDtlId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_accomStudFeedReqDtlId">ايام  ووجبات الطلب. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _accomStudFeedReqDtlId)
		{
			return Delete(null, _accomStudFeedReqDtlId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomStudFeedReqDtlId">ايام  ووجبات الطلب. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _accomStudFeedReqDtlId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_FEED_REQ_DTL_ACCOM_STUD_FEED_REQ key.
		///		FK_ACCOM_STUD_FEED_REQ_DTL_ACCOM_STUD_FEED_REQ Description: 
		/// </summary>
		/// <param name="_accomStudFeedReqId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudFeedReqDtl objects.</returns>
		public TList<AccomStudFeedReqDtl> GetByAccomStudFeedReqId(System.Decimal _accomStudFeedReqId)
		{
			int count = -1;
			return GetByAccomStudFeedReqId(_accomStudFeedReqId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_FEED_REQ_DTL_ACCOM_STUD_FEED_REQ key.
		///		FK_ACCOM_STUD_FEED_REQ_DTL_ACCOM_STUD_FEED_REQ Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomStudFeedReqId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudFeedReqDtl objects.</returns>
		/// <remarks></remarks>
		public TList<AccomStudFeedReqDtl> GetByAccomStudFeedReqId(TransactionManager transactionManager, System.Decimal _accomStudFeedReqId)
		{
			int count = -1;
			return GetByAccomStudFeedReqId(transactionManager, _accomStudFeedReqId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_FEED_REQ_DTL_ACCOM_STUD_FEED_REQ key.
		///		FK_ACCOM_STUD_FEED_REQ_DTL_ACCOM_STUD_FEED_REQ Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomStudFeedReqId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudFeedReqDtl objects.</returns>
		public TList<AccomStudFeedReqDtl> GetByAccomStudFeedReqId(TransactionManager transactionManager, System.Decimal _accomStudFeedReqId, int start, int pageLength)
		{
			int count = -1;
			return GetByAccomStudFeedReqId(transactionManager, _accomStudFeedReqId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_FEED_REQ_DTL_ACCOM_STUD_FEED_REQ key.
		///		fkAccomStudFeedReqDtlAccomStudFeedReq Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_accomStudFeedReqId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudFeedReqDtl objects.</returns>
		public TList<AccomStudFeedReqDtl> GetByAccomStudFeedReqId(System.Decimal _accomStudFeedReqId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAccomStudFeedReqId(null, _accomStudFeedReqId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_FEED_REQ_DTL_ACCOM_STUD_FEED_REQ key.
		///		fkAccomStudFeedReqDtlAccomStudFeedReq Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_accomStudFeedReqId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudFeedReqDtl objects.</returns>
		public TList<AccomStudFeedReqDtl> GetByAccomStudFeedReqId(System.Decimal _accomStudFeedReqId, int start, int pageLength,out int count)
		{
			return GetByAccomStudFeedReqId(null, _accomStudFeedReqId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_FEED_REQ_DTL_ACCOM_STUD_FEED_REQ key.
		///		FK_ACCOM_STUD_FEED_REQ_DTL_ACCOM_STUD_FEED_REQ Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomStudFeedReqId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudFeedReqDtl objects.</returns>
		public abstract TList<AccomStudFeedReqDtl> GetByAccomStudFeedReqId(TransactionManager transactionManager, System.Decimal _accomStudFeedReqId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_FEED_REQ_DTL_GS_CODE_WEEK_DAY key.
		///		FK_ACCOM_STUD_FEED_REQ_DTL_GS_CODE_WEEK_DAY Description: 
		/// </summary>
		/// <param name="_gsCodeWeekDayId">off days only</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudFeedReqDtl objects.</returns>
		public TList<AccomStudFeedReqDtl> GetByGsCodeWeekDayId(System.Decimal _gsCodeWeekDayId)
		{
			int count = -1;
			return GetByGsCodeWeekDayId(_gsCodeWeekDayId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_FEED_REQ_DTL_GS_CODE_WEEK_DAY key.
		///		FK_ACCOM_STUD_FEED_REQ_DTL_GS_CODE_WEEK_DAY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeWeekDayId">off days only</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudFeedReqDtl objects.</returns>
		/// <remarks></remarks>
		public TList<AccomStudFeedReqDtl> GetByGsCodeWeekDayId(TransactionManager transactionManager, System.Decimal _gsCodeWeekDayId)
		{
			int count = -1;
			return GetByGsCodeWeekDayId(transactionManager, _gsCodeWeekDayId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_FEED_REQ_DTL_GS_CODE_WEEK_DAY key.
		///		FK_ACCOM_STUD_FEED_REQ_DTL_GS_CODE_WEEK_DAY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeWeekDayId">off days only</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudFeedReqDtl objects.</returns>
		public TList<AccomStudFeedReqDtl> GetByGsCodeWeekDayId(TransactionManager transactionManager, System.Decimal _gsCodeWeekDayId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeWeekDayId(transactionManager, _gsCodeWeekDayId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_FEED_REQ_DTL_GS_CODE_WEEK_DAY key.
		///		fkAccomStudFeedReqDtlGsCodeWeekDay Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeWeekDayId">off days only</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudFeedReqDtl objects.</returns>
		public TList<AccomStudFeedReqDtl> GetByGsCodeWeekDayId(System.Decimal _gsCodeWeekDayId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodeWeekDayId(null, _gsCodeWeekDayId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_FEED_REQ_DTL_GS_CODE_WEEK_DAY key.
		///		fkAccomStudFeedReqDtlGsCodeWeekDay Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeWeekDayId">off days only</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudFeedReqDtl objects.</returns>
		public TList<AccomStudFeedReqDtl> GetByGsCodeWeekDayId(System.Decimal _gsCodeWeekDayId, int start, int pageLength,out int count)
		{
			return GetByGsCodeWeekDayId(null, _gsCodeWeekDayId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ACCOM_STUD_FEED_REQ_DTL_GS_CODE_WEEK_DAY key.
		///		FK_ACCOM_STUD_FEED_REQ_DTL_GS_CODE_WEEK_DAY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeWeekDayId">off days only</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AccomStudFeedReqDtl objects.</returns>
		public abstract TList<AccomStudFeedReqDtl> GetByGsCodeWeekDayId(TransactionManager transactionManager, System.Decimal _gsCodeWeekDayId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.AccomStudFeedReqDtl Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomStudFeedReqDtlKey key, int start, int pageLength)
		{
			return GetByAccomStudFeedReqDtlId(transactionManager, key.AccomStudFeedReqDtlId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ACCOM_STUD_FEED_REQ_DTL index.
		/// </summary>
		/// <param name="_accomStudFeedReqDtlId">ايام  ووجبات الطلب</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomStudFeedReqDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomStudFeedReqDtl GetByAccomStudFeedReqDtlId(System.Decimal _accomStudFeedReqDtlId)
		{
			int count = -1;
			return GetByAccomStudFeedReqDtlId(null,_accomStudFeedReqDtlId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_STUD_FEED_REQ_DTL index.
		/// </summary>
		/// <param name="_accomStudFeedReqDtlId">ايام  ووجبات الطلب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomStudFeedReqDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomStudFeedReqDtl GetByAccomStudFeedReqDtlId(System.Decimal _accomStudFeedReqDtlId, int start, int pageLength)
		{
			int count = -1;
			return GetByAccomStudFeedReqDtlId(null, _accomStudFeedReqDtlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_STUD_FEED_REQ_DTL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomStudFeedReqDtlId">ايام  ووجبات الطلب</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomStudFeedReqDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomStudFeedReqDtl GetByAccomStudFeedReqDtlId(TransactionManager transactionManager, System.Decimal _accomStudFeedReqDtlId)
		{
			int count = -1;
			return GetByAccomStudFeedReqDtlId(transactionManager, _accomStudFeedReqDtlId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_STUD_FEED_REQ_DTL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomStudFeedReqDtlId">ايام  ووجبات الطلب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomStudFeedReqDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomStudFeedReqDtl GetByAccomStudFeedReqDtlId(TransactionManager transactionManager, System.Decimal _accomStudFeedReqDtlId, int start, int pageLength)
		{
			int count = -1;
			return GetByAccomStudFeedReqDtlId(transactionManager, _accomStudFeedReqDtlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_STUD_FEED_REQ_DTL index.
		/// </summary>
		/// <param name="_accomStudFeedReqDtlId">ايام  ووجبات الطلب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomStudFeedReqDtl"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomStudFeedReqDtl GetByAccomStudFeedReqDtlId(System.Decimal _accomStudFeedReqDtlId, int start, int pageLength, out int count)
		{
			return GetByAccomStudFeedReqDtlId(null, _accomStudFeedReqDtlId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_STUD_FEED_REQ_DTL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomStudFeedReqDtlId">ايام  ووجبات الطلب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomStudFeedReqDtl"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AccomStudFeedReqDtl GetByAccomStudFeedReqDtlId(TransactionManager transactionManager, System.Decimal _accomStudFeedReqDtlId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AccomStudFeedReqDtl&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AccomStudFeedReqDtl&gt;"/></returns>
		public static TList<AccomStudFeedReqDtl> Fill(IDataReader reader, TList<AccomStudFeedReqDtl> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AccomStudFeedReqDtl c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AccomStudFeedReqDtl")
					.Append("|").Append((System.Decimal)reader["ACCOM_STUD_FEED_REQ_DTL_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AccomStudFeedReqDtl>(
					key.ToString(), // EntityTrackingKey
					"AccomStudFeedReqDtl",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AccomStudFeedReqDtl();
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
					c.AccomStudFeedReqDtlId = (System.Decimal)reader["ACCOM_STUD_FEED_REQ_DTL_ID"];
					c.OriginalAccomStudFeedReqDtlId = c.AccomStudFeedReqDtlId;
					c.AccomStudFeedReqId = (System.Decimal)reader["ACCOM_STUD_FEED_REQ_ID"];
					c.GsCodeWeekDayId = (System.Decimal)reader["GS_CODE_WEEK_DAY_ID"];
					c.FeedDate = Convert.IsDBNull(reader["FEED_DATE"]) ? null : (System.DateTime?)reader["FEED_DATE"];
					c.CtrCdeMealId = (System.Decimal)reader["CTR_CDE_MEAL_ID"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AccomStudFeedReqDtl"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AccomStudFeedReqDtl"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AccomStudFeedReqDtl entity)
		{
			if (!reader.Read()) return;
			
			entity.AccomStudFeedReqDtlId = (System.Decimal)reader[((int)AccomStudFeedReqDtlColumn.AccomStudFeedReqDtlId - 1)];
			entity.OriginalAccomStudFeedReqDtlId = (System.Decimal)reader["ACCOM_STUD_FEED_REQ_DTL_ID"];
			entity.AccomStudFeedReqId = (System.Decimal)reader[((int)AccomStudFeedReqDtlColumn.AccomStudFeedReqId - 1)];
			entity.GsCodeWeekDayId = (System.Decimal)reader[((int)AccomStudFeedReqDtlColumn.GsCodeWeekDayId - 1)];
			entity.FeedDate = (reader.IsDBNull(((int)AccomStudFeedReqDtlColumn.FeedDate - 1)))?null:(System.DateTime?)reader[((int)AccomStudFeedReqDtlColumn.FeedDate - 1)];
			entity.CtrCdeMealId = (System.Decimal)reader[((int)AccomStudFeedReqDtlColumn.CtrCdeMealId - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)AccomStudFeedReqDtlColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)AccomStudFeedReqDtlColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)AccomStudFeedReqDtlColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)AccomStudFeedReqDtlColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AccomStudFeedReqDtl"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AccomStudFeedReqDtl"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AccomStudFeedReqDtl entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AccomStudFeedReqDtlId = (System.Decimal)dataRow["ACCOM_STUD_FEED_REQ_DTL_ID"];
			entity.OriginalAccomStudFeedReqDtlId = (System.Decimal)dataRow["ACCOM_STUD_FEED_REQ_DTL_ID"];
			entity.AccomStudFeedReqId = (System.Decimal)dataRow["ACCOM_STUD_FEED_REQ_ID"];
			entity.GsCodeWeekDayId = (System.Decimal)dataRow["GS_CODE_WEEK_DAY_ID"];
			entity.FeedDate = Convert.IsDBNull(dataRow["FEED_DATE"]) ? null : (System.DateTime?)dataRow["FEED_DATE"];
			entity.CtrCdeMealId = (System.Decimal)dataRow["CTR_CDE_MEAL_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AccomStudFeedReqDtl"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AccomStudFeedReqDtl Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomStudFeedReqDtl entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AccomStudFeedReqIdSource	
			if (CanDeepLoad(entity, "AccomStudFeedReq|AccomStudFeedReqIdSource", deepLoadType, innerList) 
				&& entity.AccomStudFeedReqIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AccomStudFeedReqId;
				AccomStudFeedReq tmpEntity = EntityManager.LocateEntity<AccomStudFeedReq>(EntityLocator.ConstructKeyFromPkItems(typeof(AccomStudFeedReq), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AccomStudFeedReqIdSource = tmpEntity;
				else
					entity.AccomStudFeedReqIdSource = DataRepository.AccomStudFeedReqProvider.GetByAccomStudFeedReqId(transactionManager, entity.AccomStudFeedReqId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AccomStudFeedReqIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AccomStudFeedReqIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AccomStudFeedReqProvider.DeepLoad(transactionManager, entity.AccomStudFeedReqIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AccomStudFeedReqIdSource

			#region GsCodeWeekDayIdSource	
			if (CanDeepLoad(entity, "GsCodeWeekDay|GsCodeWeekDayIdSource", deepLoadType, innerList) 
				&& entity.GsCodeWeekDayIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.GsCodeWeekDayId;
				GsCodeWeekDay tmpEntity = EntityManager.LocateEntity<GsCodeWeekDay>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodeWeekDay), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodeWeekDayIdSource = tmpEntity;
				else
					entity.GsCodeWeekDayIdSource = DataRepository.GsCodeWeekDayProvider.GetByGsCodeWeekDayId(transactionManager, entity.GsCodeWeekDayId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodeWeekDayIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCodeWeekDayIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodeWeekDayProvider.DeepLoad(transactionManager, entity.GsCodeWeekDayIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCodeWeekDayIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AccomStudFeedReqDtl object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AccomStudFeedReqDtl instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AccomStudFeedReqDtl Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomStudFeedReqDtl entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AccomStudFeedReqIdSource
			if (CanDeepSave(entity, "AccomStudFeedReq|AccomStudFeedReqIdSource", deepSaveType, innerList) 
				&& entity.AccomStudFeedReqIdSource != null)
			{
				DataRepository.AccomStudFeedReqProvider.Save(transactionManager, entity.AccomStudFeedReqIdSource);
				entity.AccomStudFeedReqId = entity.AccomStudFeedReqIdSource.AccomStudFeedReqId;
			}
			#endregion 
			
			#region GsCodeWeekDayIdSource
			if (CanDeepSave(entity, "GsCodeWeekDay|GsCodeWeekDayIdSource", deepSaveType, innerList) 
				&& entity.GsCodeWeekDayIdSource != null)
			{
				DataRepository.GsCodeWeekDayProvider.Save(transactionManager, entity.GsCodeWeekDayIdSource);
				entity.GsCodeWeekDayId = entity.GsCodeWeekDayIdSource.GsCodeWeekDayId;
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
	
	#region AccomStudFeedReqDtlChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AccomStudFeedReqDtl</c>
	///</summary>
	public enum AccomStudFeedReqDtlChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AccomStudFeedReq</c> at AccomStudFeedReqIdSource
		///</summary>
		[ChildEntityType(typeof(AccomStudFeedReq))]
		AccomStudFeedReq,
		
		///<summary>
		/// Composite Property for <c>GsCodeWeekDay</c> at GsCodeWeekDayIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeWeekDay))]
		GsCodeWeekDay,
	}
	
	#endregion AccomStudFeedReqDtlChildEntityTypes
	
	#region AccomStudFeedReqDtlFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AccomStudFeedReqDtlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AccomStudFeedReqDtl"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AccomStudFeedReqDtlFilterBuilder : SqlFilterBuilder<AccomStudFeedReqDtlColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AccomStudFeedReqDtlFilterBuilder class.
		/// </summary>
		public AccomStudFeedReqDtlFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AccomStudFeedReqDtlFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AccomStudFeedReqDtlFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AccomStudFeedReqDtlFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AccomStudFeedReqDtlFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AccomStudFeedReqDtlFilterBuilder
	
	#region AccomStudFeedReqDtlParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AccomStudFeedReqDtlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AccomStudFeedReqDtl"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AccomStudFeedReqDtlParameterBuilder : ParameterizedSqlFilterBuilder<AccomStudFeedReqDtlColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AccomStudFeedReqDtlParameterBuilder class.
		/// </summary>
		public AccomStudFeedReqDtlParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AccomStudFeedReqDtlParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AccomStudFeedReqDtlParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AccomStudFeedReqDtlParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AccomStudFeedReqDtlParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AccomStudFeedReqDtlParameterBuilder
	
	#region AccomStudFeedReqDtlSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AccomStudFeedReqDtlColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AccomStudFeedReqDtl"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AccomStudFeedReqDtlSortBuilder : SqlSortBuilder<AccomStudFeedReqDtlColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AccomStudFeedReqDtlSqlSortBuilder class.
		/// </summary>
		public AccomStudFeedReqDtlSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AccomStudFeedReqDtlSortBuilder
	
} // end namespace
