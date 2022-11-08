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
	/// This class is the base class for any <see cref="EdStudClrncReqProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdStudClrncReqProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdStudClrncReq, UMIS_VER2.BusinessLyer.EdStudClrncReqKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudClrncReqKey key)
		{
			return Delete(transactionManager, key.EdStudClrncReqId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edStudClrncReqId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edStudClrncReqId)
		{
			return Delete(null, _edStudClrncReqId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudClrncReqId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edStudClrncReqId);		
		
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
		public override UMIS_VER2.BusinessLyer.EdStudClrncReq Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudClrncReqKey key, int start, int pageLength)
		{
			return GetByEdStudClrncReqId(transactionManager, key.EdStudClrncReqId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_STUD_SEMESTER_ID_1 index.
		/// </summary>
		/// <param name="_edStudSemesterId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudClrncReq&gt;"/> class.</returns>
		public TList<EdStudClrncReq> GetByEdStudSemesterId(System.Decimal? _edStudSemesterId)
		{
			int count = -1;
			return GetByEdStudSemesterId(null,_edStudSemesterId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_SEMESTER_ID_1 index.
		/// </summary>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudClrncReq&gt;"/> class.</returns>
		public TList<EdStudClrncReq> GetByEdStudSemesterId(System.Decimal? _edStudSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudSemesterId(null, _edStudSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_SEMESTER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudClrncReq&gt;"/> class.</returns>
		public TList<EdStudClrncReq> GetByEdStudSemesterId(TransactionManager transactionManager, System.Decimal? _edStudSemesterId)
		{
			int count = -1;
			return GetByEdStudSemesterId(transactionManager, _edStudSemesterId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_SEMESTER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudClrncReq&gt;"/> class.</returns>
		public TList<EdStudClrncReq> GetByEdStudSemesterId(TransactionManager transactionManager, System.Decimal? _edStudSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudSemesterId(transactionManager, _edStudSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_SEMESTER_ID_1 index.
		/// </summary>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudClrncReq&gt;"/> class.</returns>
		public TList<EdStudClrncReq> GetByEdStudSemesterId(System.Decimal? _edStudSemesterId, int start, int pageLength, out int count)
		{
			return GetByEdStudSemesterId(null, _edStudSemesterId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_STUD_SEMESTER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudSemesterId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudClrncReq&gt;"/> class.</returns>
		public abstract TList<EdStudClrncReq> GetByEdStudSemesterId(TransactionManager transactionManager, System.Decimal? _edStudSemesterId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_GS_CDE_CLRNC_REASON__1 index.
		/// </summary>
		/// <param name="_gsCdeClrncReasonId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudClrncReq&gt;"/> class.</returns>
		public TList<EdStudClrncReq> GetByGsCdeClrncReasonId(System.Decimal _gsCdeClrncReasonId)
		{
			int count = -1;
			return GetByGsCdeClrncReasonId(null,_gsCdeClrncReasonId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CDE_CLRNC_REASON__1 index.
		/// </summary>
		/// <param name="_gsCdeClrncReasonId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudClrncReq&gt;"/> class.</returns>
		public TList<EdStudClrncReq> GetByGsCdeClrncReasonId(System.Decimal _gsCdeClrncReasonId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeClrncReasonId(null, _gsCdeClrncReasonId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CDE_CLRNC_REASON__1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeClrncReasonId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudClrncReq&gt;"/> class.</returns>
		public TList<EdStudClrncReq> GetByGsCdeClrncReasonId(TransactionManager transactionManager, System.Decimal _gsCdeClrncReasonId)
		{
			int count = -1;
			return GetByGsCdeClrncReasonId(transactionManager, _gsCdeClrncReasonId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CDE_CLRNC_REASON__1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeClrncReasonId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudClrncReq&gt;"/> class.</returns>
		public TList<EdStudClrncReq> GetByGsCdeClrncReasonId(TransactionManager transactionManager, System.Decimal _gsCdeClrncReasonId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeClrncReasonId(transactionManager, _gsCdeClrncReasonId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CDE_CLRNC_REASON__1 index.
		/// </summary>
		/// <param name="_gsCdeClrncReasonId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudClrncReq&gt;"/> class.</returns>
		public TList<EdStudClrncReq> GetByGsCdeClrncReasonId(System.Decimal _gsCdeClrncReasonId, int start, int pageLength, out int count)
		{
			return GetByGsCdeClrncReasonId(null, _gsCdeClrncReasonId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CDE_CLRNC_REASON__1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeClrncReasonId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudClrncReq&gt;"/> class.</returns>
		public abstract TList<EdStudClrncReq> GetByGsCdeClrncReasonId(TransactionManager transactionManager, System.Decimal _gsCdeClrncReasonId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_GS_CODE_REQ_STATUS_I_1 index.
		/// </summary>
		/// <param name="_gsCodeReqStatusId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudClrncReq&gt;"/> class.</returns>
		public TList<EdStudClrncReq> GetByGsCodeReqStatusId(System.Decimal _gsCodeReqStatusId)
		{
			int count = -1;
			return GetByGsCodeReqStatusId(null,_gsCodeReqStatusId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_REQ_STATUS_I_1 index.
		/// </summary>
		/// <param name="_gsCodeReqStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudClrncReq&gt;"/> class.</returns>
		public TList<EdStudClrncReq> GetByGsCodeReqStatusId(System.Decimal _gsCodeReqStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeReqStatusId(null, _gsCodeReqStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_REQ_STATUS_I_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeReqStatusId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudClrncReq&gt;"/> class.</returns>
		public TList<EdStudClrncReq> GetByGsCodeReqStatusId(TransactionManager transactionManager, System.Decimal _gsCodeReqStatusId)
		{
			int count = -1;
			return GetByGsCodeReqStatusId(transactionManager, _gsCodeReqStatusId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_REQ_STATUS_I_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeReqStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudClrncReq&gt;"/> class.</returns>
		public TList<EdStudClrncReq> GetByGsCodeReqStatusId(TransactionManager transactionManager, System.Decimal _gsCodeReqStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeReqStatusId(transactionManager, _gsCodeReqStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_REQ_STATUS_I_1 index.
		/// </summary>
		/// <param name="_gsCodeReqStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudClrncReq&gt;"/> class.</returns>
		public TList<EdStudClrncReq> GetByGsCodeReqStatusId(System.Decimal _gsCodeReqStatusId, int start, int pageLength, out int count)
		{
			return GetByGsCodeReqStatusId(null, _gsCodeReqStatusId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_REQ_STATUS_I_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeReqStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdStudClrncReq&gt;"/> class.</returns>
		public abstract TList<EdStudClrncReq> GetByGsCodeReqStatusId(TransactionManager transactionManager, System.Decimal _gsCodeReqStatusId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_STUD_CLRNC_REQ index.
		/// </summary>
		/// <param name="_edStudClrncReqId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudClrncReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudClrncReq GetByEdStudClrncReqId(System.Decimal _edStudClrncReqId)
		{
			int count = -1;
			return GetByEdStudClrncReqId(null,_edStudClrncReqId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_CLRNC_REQ index.
		/// </summary>
		/// <param name="_edStudClrncReqId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudClrncReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudClrncReq GetByEdStudClrncReqId(System.Decimal _edStudClrncReqId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudClrncReqId(null, _edStudClrncReqId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_CLRNC_REQ index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudClrncReqId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudClrncReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudClrncReq GetByEdStudClrncReqId(TransactionManager transactionManager, System.Decimal _edStudClrncReqId)
		{
			int count = -1;
			return GetByEdStudClrncReqId(transactionManager, _edStudClrncReqId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_CLRNC_REQ index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudClrncReqId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudClrncReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudClrncReq GetByEdStudClrncReqId(TransactionManager transactionManager, System.Decimal _edStudClrncReqId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudClrncReqId(transactionManager, _edStudClrncReqId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_CLRNC_REQ index.
		/// </summary>
		/// <param name="_edStudClrncReqId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudClrncReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStudClrncReq GetByEdStudClrncReqId(System.Decimal _edStudClrncReqId, int start, int pageLength, out int count)
		{
			return GetByEdStudClrncReqId(null, _edStudClrncReqId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STUD_CLRNC_REQ index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudClrncReqId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStudClrncReq"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdStudClrncReq GetByEdStudClrncReqId(TransactionManager transactionManager, System.Decimal _edStudClrncReqId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdStudClrncReq&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdStudClrncReq&gt;"/></returns>
		public static TList<EdStudClrncReq> Fill(IDataReader reader, TList<EdStudClrncReq> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdStudClrncReq c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdStudClrncReq")
					.Append("|").Append((System.Decimal)reader["ED_STUD_CLRNC_REQ_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdStudClrncReq>(
					key.ToString(), // EntityTrackingKey
					"EdStudClrncReq",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdStudClrncReq();
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
					c.EdStudClrncReqId = (System.Decimal)reader["ED_STUD_CLRNC_REQ_ID"];
					c.OriginalEdStudClrncReqId = c.EdStudClrncReqId;
					c.ReqDate = Convert.IsDBNull(reader["REQ_DATE"]) ? null : (System.DateTime?)reader["REQ_DATE"];
					c.ReqStatusDate = Convert.IsDBNull(reader["REQ_STATUS_DATE"]) ? null : (System.DateTime?)reader["REQ_STATUS_DATE"];
					c.EdStudSemesterId = Convert.IsDBNull(reader["ED_STUD_SEMESTER_ID"]) ? null : (System.Decimal?)reader["ED_STUD_SEMESTER_ID"];
					c.GsCdeClrncReasonId = (System.Decimal)reader["GS_CDE_CLRNC_REASON_ID"];
					c.GsCodeReqStatusId = (System.Decimal)reader["GS_CODE_REQ_STATUS_ID"];
					c.WithdrawDate = Convert.IsDBNull(reader["WITHDRAW_DATE"]) ? null : (System.DateTime?)reader["WITHDRAW_DATE"];
					c.WithdrawName = Convert.IsDBNull(reader["WITHDRAW_NAME"]) ? null : (System.String)reader["WITHDRAW_NAME"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudClrncReq"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudClrncReq"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdStudClrncReq entity)
		{
			if (!reader.Read()) return;
			
			entity.EdStudClrncReqId = (System.Decimal)reader[((int)EdStudClrncReqColumn.EdStudClrncReqId - 1)];
			entity.OriginalEdStudClrncReqId = (System.Decimal)reader["ED_STUD_CLRNC_REQ_ID"];
			entity.ReqDate = (reader.IsDBNull(((int)EdStudClrncReqColumn.ReqDate - 1)))?null:(System.DateTime?)reader[((int)EdStudClrncReqColumn.ReqDate - 1)];
			entity.ReqStatusDate = (reader.IsDBNull(((int)EdStudClrncReqColumn.ReqStatusDate - 1)))?null:(System.DateTime?)reader[((int)EdStudClrncReqColumn.ReqStatusDate - 1)];
			entity.EdStudSemesterId = (reader.IsDBNull(((int)EdStudClrncReqColumn.EdStudSemesterId - 1)))?null:(System.Decimal?)reader[((int)EdStudClrncReqColumn.EdStudSemesterId - 1)];
			entity.GsCdeClrncReasonId = (System.Decimal)reader[((int)EdStudClrncReqColumn.GsCdeClrncReasonId - 1)];
			entity.GsCodeReqStatusId = (System.Decimal)reader[((int)EdStudClrncReqColumn.GsCodeReqStatusId - 1)];
			entity.WithdrawDate = (reader.IsDBNull(((int)EdStudClrncReqColumn.WithdrawDate - 1)))?null:(System.DateTime?)reader[((int)EdStudClrncReqColumn.WithdrawDate - 1)];
			entity.WithdrawName = (reader.IsDBNull(((int)EdStudClrncReqColumn.WithdrawName - 1)))?null:(System.String)reader[((int)EdStudClrncReqColumn.WithdrawName - 1)];
			entity.Notes = (reader.IsDBNull(((int)EdStudClrncReqColumn.Notes - 1)))?null:(System.String)reader[((int)EdStudClrncReqColumn.Notes - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStudClrncReq"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudClrncReq"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdStudClrncReq entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdStudClrncReqId = (System.Decimal)dataRow["ED_STUD_CLRNC_REQ_ID"];
			entity.OriginalEdStudClrncReqId = (System.Decimal)dataRow["ED_STUD_CLRNC_REQ_ID"];
			entity.ReqDate = Convert.IsDBNull(dataRow["REQ_DATE"]) ? null : (System.DateTime?)dataRow["REQ_DATE"];
			entity.ReqStatusDate = Convert.IsDBNull(dataRow["REQ_STATUS_DATE"]) ? null : (System.DateTime?)dataRow["REQ_STATUS_DATE"];
			entity.EdStudSemesterId = Convert.IsDBNull(dataRow["ED_STUD_SEMESTER_ID"]) ? null : (System.Decimal?)dataRow["ED_STUD_SEMESTER_ID"];
			entity.GsCdeClrncReasonId = (System.Decimal)dataRow["GS_CDE_CLRNC_REASON_ID"];
			entity.GsCodeReqStatusId = (System.Decimal)dataRow["GS_CODE_REQ_STATUS_ID"];
			entity.WithdrawDate = Convert.IsDBNull(dataRow["WITHDRAW_DATE"]) ? null : (System.DateTime?)dataRow["WITHDRAW_DATE"];
			entity.WithdrawName = Convert.IsDBNull(dataRow["WITHDRAW_NAME"]) ? null : (System.String)dataRow["WITHDRAW_NAME"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStudClrncReq"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudClrncReq Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudClrncReq entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdStudSemesterIdSource	
			if (CanDeepLoad(entity, "EdStudSemester|EdStudSemesterIdSource", deepLoadType, innerList) 
				&& entity.EdStudSemesterIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdStudSemesterId ?? 0.0m);
				EdStudSemester tmpEntity = EntityManager.LocateEntity<EdStudSemester>(EntityLocator.ConstructKeyFromPkItems(typeof(EdStudSemester), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdStudSemesterIdSource = tmpEntity;
				else
					entity.EdStudSemesterIdSource = DataRepository.EdStudSemesterProvider.GetByEdStudSemesterId(transactionManager, (entity.EdStudSemesterId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudSemesterIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdStudSemesterIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdStudSemesterProvider.DeepLoad(transactionManager, entity.EdStudSemesterIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdStudSemesterIdSource

			#region GsCdeClrncReasonIdSource	
			if (CanDeepLoad(entity, "GsCdeClrncReason|GsCdeClrncReasonIdSource", deepLoadType, innerList) 
				&& entity.GsCdeClrncReasonIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.GsCdeClrncReasonId;
				GsCdeClrncReason tmpEntity = EntityManager.LocateEntity<GsCdeClrncReason>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCdeClrncReason), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCdeClrncReasonIdSource = tmpEntity;
				else
					entity.GsCdeClrncReasonIdSource = DataRepository.GsCdeClrncReasonProvider.GetByGsCdeClrncReasonId(transactionManager, entity.GsCdeClrncReasonId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCdeClrncReasonIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCdeClrncReasonIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCdeClrncReasonProvider.DeepLoad(transactionManager, entity.GsCdeClrncReasonIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCdeClrncReasonIdSource

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
			// Deep load child collections  - Call GetByEdStudClrncReqId methods when available
			
			#region GsAttchdDocCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GsAttchdDoc>|GsAttchdDocCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsAttchdDocCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GsAttchdDocCollection = DataRepository.GsAttchdDocProvider.GetByEdStudClrncReqId(transactionManager, entity.EdStudClrncReqId);

				if (deep && entity.GsAttchdDocCollection.Count > 0)
				{
					deepHandles.Add("GsAttchdDocCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GsAttchdDoc>) DataRepository.GsAttchdDocProvider.DeepLoad,
						new object[] { transactionManager, entity.GsAttchdDocCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudClrncItemCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudClrncItem>|EdStudClrncItemCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudClrncItemCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudClrncItemCollection = DataRepository.EdStudClrncItemProvider.GetByEdStudClrncReqId(transactionManager, entity.EdStudClrncReqId);

				if (deep && entity.EdStudClrncItemCollection.Count > 0)
				{
					deepHandles.Add("EdStudClrncItemCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudClrncItem>) DataRepository.EdStudClrncItemProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudClrncItemCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdStudClrncReq object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdStudClrncReq instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStudClrncReq Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudClrncReq entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdStudSemesterIdSource
			if (CanDeepSave(entity, "EdStudSemester|EdStudSemesterIdSource", deepSaveType, innerList) 
				&& entity.EdStudSemesterIdSource != null)
			{
				DataRepository.EdStudSemesterProvider.Save(transactionManager, entity.EdStudSemesterIdSource);
				entity.EdStudSemesterId = entity.EdStudSemesterIdSource.EdStudSemesterId;
			}
			#endregion 
			
			#region GsCdeClrncReasonIdSource
			if (CanDeepSave(entity, "GsCdeClrncReason|GsCdeClrncReasonIdSource", deepSaveType, innerList) 
				&& entity.GsCdeClrncReasonIdSource != null)
			{
				DataRepository.GsCdeClrncReasonProvider.Save(transactionManager, entity.GsCdeClrncReasonIdSource);
				entity.GsCdeClrncReasonId = entity.GsCdeClrncReasonIdSource.GsCdeClrncReasonId;
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
	
			#region List<GsAttchdDoc>
				if (CanDeepSave(entity.GsAttchdDocCollection, "List<GsAttchdDoc>|GsAttchdDocCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GsAttchdDoc child in entity.GsAttchdDocCollection)
					{
						if(child.EdStudClrncReqIdSource != null)
						{
							child.EdStudClrncReqId = child.EdStudClrncReqIdSource.EdStudClrncReqId;
						}
						else
						{
							child.EdStudClrncReqId = entity.EdStudClrncReqId;
						}

					}

					if (entity.GsAttchdDocCollection.Count > 0 || entity.GsAttchdDocCollection.DeletedItems.Count > 0)
					{
						//DataRepository.GsAttchdDocProvider.Save(transactionManager, entity.GsAttchdDocCollection);
						
						deepHandles.Add("GsAttchdDocCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< GsAttchdDoc >) DataRepository.GsAttchdDocProvider.DeepSave,
							new object[] { transactionManager, entity.GsAttchdDocCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudClrncItem>
				if (CanDeepSave(entity.EdStudClrncItemCollection, "List<EdStudClrncItem>|EdStudClrncItemCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudClrncItem child in entity.EdStudClrncItemCollection)
					{
						if(child.EdStudClrncReqIdSource != null)
						{
							child.EdStudClrncReqId = child.EdStudClrncReqIdSource.EdStudClrncReqId;
						}
						else
						{
							child.EdStudClrncReqId = entity.EdStudClrncReqId;
						}

					}

					if (entity.EdStudClrncItemCollection.Count > 0 || entity.EdStudClrncItemCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudClrncItemProvider.Save(transactionManager, entity.EdStudClrncItemCollection);
						
						deepHandles.Add("EdStudClrncItemCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudClrncItem >) DataRepository.EdStudClrncItemProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudClrncItemCollection, deepSaveType, childTypes, innerList }
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
	
	#region EdStudClrncReqChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdStudClrncReq</c>
	///</summary>
	public enum EdStudClrncReqChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdStudSemester</c> at EdStudSemesterIdSource
		///</summary>
		[ChildEntityType(typeof(EdStudSemester))]
		EdStudSemester,
		
		///<summary>
		/// Composite Property for <c>GsCdeClrncReason</c> at GsCdeClrncReasonIdSource
		///</summary>
		[ChildEntityType(typeof(GsCdeClrncReason))]
		GsCdeClrncReason,
		
		///<summary>
		/// Composite Property for <c>GsCodeReqStatus</c> at GsCodeReqStatusIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeReqStatus))]
		GsCodeReqStatus,
		///<summary>
		/// Collection of <c>EdStudClrncReq</c> as OneToMany for GsAttchdDocCollection
		///</summary>
		[ChildEntityType(typeof(TList<GsAttchdDoc>))]
		GsAttchdDocCollection,
		///<summary>
		/// Collection of <c>EdStudClrncReq</c> as OneToMany for EdStudClrncItemCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudClrncItem>))]
		EdStudClrncItemCollection,
	}
	
	#endregion EdStudClrncReqChildEntityTypes
	
	#region EdStudClrncReqFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdStudClrncReqColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudClrncReq"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudClrncReqFilterBuilder : SqlFilterBuilder<EdStudClrncReqColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudClrncReqFilterBuilder class.
		/// </summary>
		public EdStudClrncReqFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudClrncReqFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudClrncReqFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudClrncReqFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudClrncReqFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudClrncReqFilterBuilder
	
	#region EdStudClrncReqParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdStudClrncReqColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudClrncReq"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStudClrncReqParameterBuilder : ParameterizedSqlFilterBuilder<EdStudClrncReqColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudClrncReqParameterBuilder class.
		/// </summary>
		public EdStudClrncReqParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStudClrncReqParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStudClrncReqParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStudClrncReqParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStudClrncReqParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStudClrncReqParameterBuilder
	
	#region EdStudClrncReqSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdStudClrncReqColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStudClrncReq"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdStudClrncReqSortBuilder : SqlSortBuilder<EdStudClrncReqColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStudClrncReqSqlSortBuilder class.
		/// </summary>
		public EdStudClrncReqSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdStudClrncReqSortBuilder
	
} // end namespace
