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
	/// This class is the base class for any <see cref="AdmAppTransBalanceProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AdmAppTransBalanceProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AdmAppTransBalance, UMIS_VER2.BusinessLyer.AdmAppTransBalanceKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppTransBalanceKey key)
		{
			return Delete(transactionManager, key.AdmAppTransBalanceId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_admAppTransBalanceId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _admAppTransBalanceId)
		{
			return Delete(null, _admAppTransBalanceId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppTransBalanceId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _admAppTransBalanceId);		
		
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
		public override UMIS_VER2.BusinessLyer.AdmAppTransBalance Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppTransBalanceKey key, int start, int pageLength)
		{
			return GetByAdmAppTransBalanceId(transactionManager, key.AdmAppTransBalanceId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ADM_APP_TRANS_FROM_C_1 index.
		/// </summary>
		/// <param name="_admAppTransFromCourseId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppTransBalance&gt;"/> class.</returns>
		public TList<AdmAppTransBalance> GetByAdmAppTransFromCourseId(System.Decimal _admAppTransFromCourseId)
		{
			int count = -1;
			return GetByAdmAppTransFromCourseId(null,_admAppTransFromCourseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ADM_APP_TRANS_FROM_C_1 index.
		/// </summary>
		/// <param name="_admAppTransFromCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppTransBalance&gt;"/> class.</returns>
		public TList<AdmAppTransBalance> GetByAdmAppTransFromCourseId(System.Decimal _admAppTransFromCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppTransFromCourseId(null, _admAppTransFromCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ADM_APP_TRANS_FROM_C_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppTransFromCourseId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppTransBalance&gt;"/> class.</returns>
		public TList<AdmAppTransBalance> GetByAdmAppTransFromCourseId(TransactionManager transactionManager, System.Decimal _admAppTransFromCourseId)
		{
			int count = -1;
			return GetByAdmAppTransFromCourseId(transactionManager, _admAppTransFromCourseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ADM_APP_TRANS_FROM_C_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppTransFromCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppTransBalance&gt;"/> class.</returns>
		public TList<AdmAppTransBalance> GetByAdmAppTransFromCourseId(TransactionManager transactionManager, System.Decimal _admAppTransFromCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppTransFromCourseId(transactionManager, _admAppTransFromCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ADM_APP_TRANS_FROM_C_1 index.
		/// </summary>
		/// <param name="_admAppTransFromCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppTransBalance&gt;"/> class.</returns>
		public TList<AdmAppTransBalance> GetByAdmAppTransFromCourseId(System.Decimal _admAppTransFromCourseId, int start, int pageLength, out int count)
		{
			return GetByAdmAppTransFromCourseId(null, _admAppTransFromCourseId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ADM_APP_TRANS_FROM_C_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppTransFromCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppTransBalance&gt;"/> class.</returns>
		public abstract TList<AdmAppTransBalance> GetByAdmAppTransFromCourseId(TransactionManager transactionManager, System.Decimal _admAppTransFromCourseId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ADM_APP_TRANS_REQ_ID_1 index.
		/// </summary>
		/// <param name="_admAppTransReqId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppTransBalance&gt;"/> class.</returns>
		public TList<AdmAppTransBalance> GetByAdmAppTransReqId(System.Decimal _admAppTransReqId)
		{
			int count = -1;
			return GetByAdmAppTransReqId(null,_admAppTransReqId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ADM_APP_TRANS_REQ_ID_1 index.
		/// </summary>
		/// <param name="_admAppTransReqId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppTransBalance&gt;"/> class.</returns>
		public TList<AdmAppTransBalance> GetByAdmAppTransReqId(System.Decimal _admAppTransReqId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppTransReqId(null, _admAppTransReqId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ADM_APP_TRANS_REQ_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppTransReqId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppTransBalance&gt;"/> class.</returns>
		public TList<AdmAppTransBalance> GetByAdmAppTransReqId(TransactionManager transactionManager, System.Decimal _admAppTransReqId)
		{
			int count = -1;
			return GetByAdmAppTransReqId(transactionManager, _admAppTransReqId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ADM_APP_TRANS_REQ_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppTransReqId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppTransBalance&gt;"/> class.</returns>
		public TList<AdmAppTransBalance> GetByAdmAppTransReqId(TransactionManager transactionManager, System.Decimal _admAppTransReqId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppTransReqId(transactionManager, _admAppTransReqId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ADM_APP_TRANS_REQ_ID_1 index.
		/// </summary>
		/// <param name="_admAppTransReqId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppTransBalance&gt;"/> class.</returns>
		public TList<AdmAppTransBalance> GetByAdmAppTransReqId(System.Decimal _admAppTransReqId, int start, int pageLength, out int count)
		{
			return GetByAdmAppTransReqId(null, _admAppTransReqId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ADM_APP_TRANS_REQ_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppTransReqId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppTransBalance&gt;"/> class.</returns>
		public abstract TList<AdmAppTransBalance> GetByAdmAppTransReqId(TransactionManager transactionManager, System.Decimal _admAppTransReqId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ADM_APP_TRANS_TO_COU_1 index.
		/// </summary>
		/// <param name="_admAppTransToCourseId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppTransBalance&gt;"/> class.</returns>
		public TList<AdmAppTransBalance> GetByAdmAppTransToCourseId(System.Decimal _admAppTransToCourseId)
		{
			int count = -1;
			return GetByAdmAppTransToCourseId(null,_admAppTransToCourseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ADM_APP_TRANS_TO_COU_1 index.
		/// </summary>
		/// <param name="_admAppTransToCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppTransBalance&gt;"/> class.</returns>
		public TList<AdmAppTransBalance> GetByAdmAppTransToCourseId(System.Decimal _admAppTransToCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppTransToCourseId(null, _admAppTransToCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ADM_APP_TRANS_TO_COU_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppTransToCourseId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppTransBalance&gt;"/> class.</returns>
		public TList<AdmAppTransBalance> GetByAdmAppTransToCourseId(TransactionManager transactionManager, System.Decimal _admAppTransToCourseId)
		{
			int count = -1;
			return GetByAdmAppTransToCourseId(transactionManager, _admAppTransToCourseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ADM_APP_TRANS_TO_COU_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppTransToCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppTransBalance&gt;"/> class.</returns>
		public TList<AdmAppTransBalance> GetByAdmAppTransToCourseId(TransactionManager transactionManager, System.Decimal _admAppTransToCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppTransToCourseId(transactionManager, _admAppTransToCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ADM_APP_TRANS_TO_COU_1 index.
		/// </summary>
		/// <param name="_admAppTransToCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppTransBalance&gt;"/> class.</returns>
		public TList<AdmAppTransBalance> GetByAdmAppTransToCourseId(System.Decimal _admAppTransToCourseId, int start, int pageLength, out int count)
		{
			return GetByAdmAppTransToCourseId(null, _admAppTransToCourseId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ADM_APP_TRANS_TO_COU_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppTransToCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AdmAppTransBalance&gt;"/> class.</returns>
		public abstract TList<AdmAppTransBalance> GetByAdmAppTransToCourseId(TransactionManager transactionManager, System.Decimal _admAppTransToCourseId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ADM_APP_TRANS_BALANCEE index.
		/// </summary>
		/// <param name="_admAppTransBalanceId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppTransBalance"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppTransBalance GetByAdmAppTransBalanceId(System.Decimal _admAppTransBalanceId)
		{
			int count = -1;
			return GetByAdmAppTransBalanceId(null,_admAppTransBalanceId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_TRANS_BALANCEE index.
		/// </summary>
		/// <param name="_admAppTransBalanceId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppTransBalance"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppTransBalance GetByAdmAppTransBalanceId(System.Decimal _admAppTransBalanceId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppTransBalanceId(null, _admAppTransBalanceId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_TRANS_BALANCEE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppTransBalanceId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppTransBalance"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppTransBalance GetByAdmAppTransBalanceId(TransactionManager transactionManager, System.Decimal _admAppTransBalanceId)
		{
			int count = -1;
			return GetByAdmAppTransBalanceId(transactionManager, _admAppTransBalanceId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_TRANS_BALANCEE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppTransBalanceId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppTransBalance"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppTransBalance GetByAdmAppTransBalanceId(TransactionManager transactionManager, System.Decimal _admAppTransBalanceId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppTransBalanceId(transactionManager, _admAppTransBalanceId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_TRANS_BALANCEE index.
		/// </summary>
		/// <param name="_admAppTransBalanceId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppTransBalance"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppTransBalance GetByAdmAppTransBalanceId(System.Decimal _admAppTransBalanceId, int start, int pageLength, out int count)
		{
			return GetByAdmAppTransBalanceId(null, _admAppTransBalanceId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_TRANS_BALANCEE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppTransBalanceId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppTransBalance"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmAppTransBalance GetByAdmAppTransBalanceId(TransactionManager transactionManager, System.Decimal _admAppTransBalanceId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AdmAppTransBalance&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AdmAppTransBalance&gt;"/></returns>
		public static TList<AdmAppTransBalance> Fill(IDataReader reader, TList<AdmAppTransBalance> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AdmAppTransBalance c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AdmAppTransBalance")
					.Append("|").Append((System.Decimal)reader["ADM_APP_TRANS_BALANCE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AdmAppTransBalance>(
					key.ToString(), // EntityTrackingKey
					"AdmAppTransBalance",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AdmAppTransBalance();
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
					c.AdmAppTransBalanceId = (System.Decimal)reader["ADM_APP_TRANS_BALANCE_ID"];
					c.OriginalAdmAppTransBalanceId = c.AdmAppTransBalanceId;
					c.AdmAppTransReqId = (System.Decimal)reader["ADM_APP_TRANS_REQ_ID"];
					c.AdmAppTransFromCourseId = (System.Decimal)reader["ADM_APP_TRANS_FROM_COURSE_ID"];
					c.AdmAppTransToCourseId = (System.Decimal)reader["ADM_APP_TRANS_TO_COURSE_ID"];
					c.EquivPercent = (System.Decimal)reader["EQUIV_PERCENT"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmAppTransBalance"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAppTransBalance"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AdmAppTransBalance entity)
		{
			if (!reader.Read()) return;
			
			entity.AdmAppTransBalanceId = (System.Decimal)reader[((int)AdmAppTransBalanceColumn.AdmAppTransBalanceId - 1)];
			entity.OriginalAdmAppTransBalanceId = (System.Decimal)reader["ADM_APP_TRANS_BALANCE_ID"];
			entity.AdmAppTransReqId = (System.Decimal)reader[((int)AdmAppTransBalanceColumn.AdmAppTransReqId - 1)];
			entity.AdmAppTransFromCourseId = (System.Decimal)reader[((int)AdmAppTransBalanceColumn.AdmAppTransFromCourseId - 1)];
			entity.AdmAppTransToCourseId = (System.Decimal)reader[((int)AdmAppTransBalanceColumn.AdmAppTransToCourseId - 1)];
			entity.EquivPercent = (System.Decimal)reader[((int)AdmAppTransBalanceColumn.EquivPercent - 1)];
			entity.Notes = (reader.IsDBNull(((int)AdmAppTransBalanceColumn.Notes - 1)))?null:(System.String)reader[((int)AdmAppTransBalanceColumn.Notes - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmAppTransBalance"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAppTransBalance"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AdmAppTransBalance entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AdmAppTransBalanceId = (System.Decimal)dataRow["ADM_APP_TRANS_BALANCE_ID"];
			entity.OriginalAdmAppTransBalanceId = (System.Decimal)dataRow["ADM_APP_TRANS_BALANCE_ID"];
			entity.AdmAppTransReqId = (System.Decimal)dataRow["ADM_APP_TRANS_REQ_ID"];
			entity.AdmAppTransFromCourseId = (System.Decimal)dataRow["ADM_APP_TRANS_FROM_COURSE_ID"];
			entity.AdmAppTransToCourseId = (System.Decimal)dataRow["ADM_APP_TRANS_TO_COURSE_ID"];
			entity.EquivPercent = (System.Decimal)dataRow["EQUIV_PERCENT"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAppTransBalance"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmAppTransBalance Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppTransBalance entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AdmAppTransFromCourseIdSource	
			if (CanDeepLoad(entity, "AdmAppTransFromCourse|AdmAppTransFromCourseIdSource", deepLoadType, innerList) 
				&& entity.AdmAppTransFromCourseIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AdmAppTransFromCourseId;
				AdmAppTransFromCourse tmpEntity = EntityManager.LocateEntity<AdmAppTransFromCourse>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmAppTransFromCourse), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmAppTransFromCourseIdSource = tmpEntity;
				else
					entity.AdmAppTransFromCourseIdSource = DataRepository.AdmAppTransFromCourseProvider.GetByAdmAppTransFromCourseId(transactionManager, entity.AdmAppTransFromCourseId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppTransFromCourseIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmAppTransFromCourseIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmAppTransFromCourseProvider.DeepLoad(transactionManager, entity.AdmAppTransFromCourseIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmAppTransFromCourseIdSource

			#region AdmAppTransToCourseIdSource	
			if (CanDeepLoad(entity, "AdmAppTransToCourse|AdmAppTransToCourseIdSource", deepLoadType, innerList) 
				&& entity.AdmAppTransToCourseIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AdmAppTransToCourseId;
				AdmAppTransToCourse tmpEntity = EntityManager.LocateEntity<AdmAppTransToCourse>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmAppTransToCourse), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmAppTransToCourseIdSource = tmpEntity;
				else
					entity.AdmAppTransToCourseIdSource = DataRepository.AdmAppTransToCourseProvider.GetByAdmAppTransToCourseId(transactionManager, entity.AdmAppTransToCourseId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppTransToCourseIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmAppTransToCourseIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmAppTransToCourseProvider.DeepLoad(transactionManager, entity.AdmAppTransToCourseIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmAppTransToCourseIdSource

			#region AdmAppTransReqIdSource	
			if (CanDeepLoad(entity, "AdmAppTransReq|AdmAppTransReqIdSource", deepLoadType, innerList) 
				&& entity.AdmAppTransReqIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AdmAppTransReqId;
				AdmAppTransReq tmpEntity = EntityManager.LocateEntity<AdmAppTransReq>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmAppTransReq), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmAppTransReqIdSource = tmpEntity;
				else
					entity.AdmAppTransReqIdSource = DataRepository.AdmAppTransReqProvider.GetByAdmAppTransReqId(transactionManager, entity.AdmAppTransReqId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppTransReqIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmAppTransReqIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmAppTransReqProvider.DeepLoad(transactionManager, entity.AdmAppTransReqIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmAppTransReqIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AdmAppTransBalance object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AdmAppTransBalance instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmAppTransBalance Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppTransBalance entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AdmAppTransFromCourseIdSource
			if (CanDeepSave(entity, "AdmAppTransFromCourse|AdmAppTransFromCourseIdSource", deepSaveType, innerList) 
				&& entity.AdmAppTransFromCourseIdSource != null)
			{
				DataRepository.AdmAppTransFromCourseProvider.Save(transactionManager, entity.AdmAppTransFromCourseIdSource);
				entity.AdmAppTransFromCourseId = entity.AdmAppTransFromCourseIdSource.AdmAppTransFromCourseId;
			}
			#endregion 
			
			#region AdmAppTransToCourseIdSource
			if (CanDeepSave(entity, "AdmAppTransToCourse|AdmAppTransToCourseIdSource", deepSaveType, innerList) 
				&& entity.AdmAppTransToCourseIdSource != null)
			{
				DataRepository.AdmAppTransToCourseProvider.Save(transactionManager, entity.AdmAppTransToCourseIdSource);
				entity.AdmAppTransToCourseId = entity.AdmAppTransToCourseIdSource.AdmAppTransToCourseId;
			}
			#endregion 
			
			#region AdmAppTransReqIdSource
			if (CanDeepSave(entity, "AdmAppTransReq|AdmAppTransReqIdSource", deepSaveType, innerList) 
				&& entity.AdmAppTransReqIdSource != null)
			{
				DataRepository.AdmAppTransReqProvider.Save(transactionManager, entity.AdmAppTransReqIdSource);
				entity.AdmAppTransReqId = entity.AdmAppTransReqIdSource.AdmAppTransReqId;
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
	
	#region AdmAppTransBalanceChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AdmAppTransBalance</c>
	///</summary>
	public enum AdmAppTransBalanceChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AdmAppTransFromCourse</c> at AdmAppTransFromCourseIdSource
		///</summary>
		[ChildEntityType(typeof(AdmAppTransFromCourse))]
		AdmAppTransFromCourse,
		
		///<summary>
		/// Composite Property for <c>AdmAppTransToCourse</c> at AdmAppTransToCourseIdSource
		///</summary>
		[ChildEntityType(typeof(AdmAppTransToCourse))]
		AdmAppTransToCourse,
		
		///<summary>
		/// Composite Property for <c>AdmAppTransReq</c> at AdmAppTransReqIdSource
		///</summary>
		[ChildEntityType(typeof(AdmAppTransReq))]
		AdmAppTransReq,
	}
	
	#endregion AdmAppTransBalanceChildEntityTypes
	
	#region AdmAppTransBalanceFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AdmAppTransBalanceColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAppTransBalance"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmAppTransBalanceFilterBuilder : SqlFilterBuilder<AdmAppTransBalanceColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAppTransBalanceFilterBuilder class.
		/// </summary>
		public AdmAppTransBalanceFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmAppTransBalanceFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmAppTransBalanceFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmAppTransBalanceFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmAppTransBalanceFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmAppTransBalanceFilterBuilder
	
	#region AdmAppTransBalanceParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AdmAppTransBalanceColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAppTransBalance"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmAppTransBalanceParameterBuilder : ParameterizedSqlFilterBuilder<AdmAppTransBalanceColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAppTransBalanceParameterBuilder class.
		/// </summary>
		public AdmAppTransBalanceParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmAppTransBalanceParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmAppTransBalanceParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmAppTransBalanceParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmAppTransBalanceParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmAppTransBalanceParameterBuilder
	
	#region AdmAppTransBalanceSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AdmAppTransBalanceColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAppTransBalance"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AdmAppTransBalanceSortBuilder : SqlSortBuilder<AdmAppTransBalanceColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAppTransBalanceSqlSortBuilder class.
		/// </summary>
		public AdmAppTransBalanceSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AdmAppTransBalanceSortBuilder
	
} // end namespace
