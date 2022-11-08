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
	/// This class is the base class for any <see cref="CoExaminerCorectorProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class CoExaminerCorectorProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.CoExaminerCorector, UMIS_VER2.BusinessLyer.CoExaminerCorectorKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CoExaminerCorectorKey key)
		{
			return Delete(transactionManager, key.CoExaminerCorectorId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_coExaminerCorectorId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _coExaminerCorectorId)
		{
			return Delete(null, _coExaminerCorectorId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coExaminerCorectorId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _coExaminerCorectorId);		
		
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
		public override UMIS_VER2.BusinessLyer.CoExaminerCorector Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CoExaminerCorectorKey key, int start, int pageLength)
		{
			return GetByCoExaminerCorectorId(transactionManager, key.CoExaminerCorectorId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_EXAM_SCHDL_ID_1 index.
		/// </summary>
		/// <param name="_edExamSchdlId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoExaminerCorector&gt;"/> class.</returns>
		public TList<CoExaminerCorector> GetByEdExamSchdlId(System.Decimal _edExamSchdlId)
		{
			int count = -1;
			return GetByEdExamSchdlId(null,_edExamSchdlId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_EXAM_SCHDL_ID_1 index.
		/// </summary>
		/// <param name="_edExamSchdlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoExaminerCorector&gt;"/> class.</returns>
		public TList<CoExaminerCorector> GetByEdExamSchdlId(System.Decimal _edExamSchdlId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdExamSchdlId(null, _edExamSchdlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_EXAM_SCHDL_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edExamSchdlId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoExaminerCorector&gt;"/> class.</returns>
		public TList<CoExaminerCorector> GetByEdExamSchdlId(TransactionManager transactionManager, System.Decimal _edExamSchdlId)
		{
			int count = -1;
			return GetByEdExamSchdlId(transactionManager, _edExamSchdlId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_EXAM_SCHDL_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edExamSchdlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoExaminerCorector&gt;"/> class.</returns>
		public TList<CoExaminerCorector> GetByEdExamSchdlId(TransactionManager transactionManager, System.Decimal _edExamSchdlId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdExamSchdlId(transactionManager, _edExamSchdlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_EXAM_SCHDL_ID_1 index.
		/// </summary>
		/// <param name="_edExamSchdlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoExaminerCorector&gt;"/> class.</returns>
		public TList<CoExaminerCorector> GetByEdExamSchdlId(System.Decimal _edExamSchdlId, int start, int pageLength, out int count)
		{
			return GetByEdExamSchdlId(null, _edExamSchdlId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_EXAM_SCHDL_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edExamSchdlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoExaminerCorector&gt;"/> class.</returns>
		public abstract TList<CoExaminerCorector> GetByEdExamSchdlId(TransactionManager transactionManager, System.Decimal _edExamSchdlId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_SA_CODE_SC_DEG_ID_1 index.
		/// </summary>
		/// <param name="_saCodeScDegId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoExaminerCorector&gt;"/> class.</returns>
		public TList<CoExaminerCorector> GetBySaCodeScDegId(System.Decimal? _saCodeScDegId)
		{
			int count = -1;
			return GetBySaCodeScDegId(null,_saCodeScDegId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_CODE_SC_DEG_ID_1 index.
		/// </summary>
		/// <param name="_saCodeScDegId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoExaminerCorector&gt;"/> class.</returns>
		public TList<CoExaminerCorector> GetBySaCodeScDegId(System.Decimal? _saCodeScDegId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeScDegId(null, _saCodeScDegId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_CODE_SC_DEG_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeScDegId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoExaminerCorector&gt;"/> class.</returns>
		public TList<CoExaminerCorector> GetBySaCodeScDegId(TransactionManager transactionManager, System.Decimal? _saCodeScDegId)
		{
			int count = -1;
			return GetBySaCodeScDegId(transactionManager, _saCodeScDegId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_CODE_SC_DEG_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeScDegId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoExaminerCorector&gt;"/> class.</returns>
		public TList<CoExaminerCorector> GetBySaCodeScDegId(TransactionManager transactionManager, System.Decimal? _saCodeScDegId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeScDegId(transactionManager, _saCodeScDegId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_CODE_SC_DEG_ID_1 index.
		/// </summary>
		/// <param name="_saCodeScDegId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoExaminerCorector&gt;"/> class.</returns>
		public TList<CoExaminerCorector> GetBySaCodeScDegId(System.Decimal? _saCodeScDegId, int start, int pageLength, out int count)
		{
			return GetBySaCodeScDegId(null, _saCodeScDegId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_CODE_SC_DEG_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeScDegId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoExaminerCorector&gt;"/> class.</returns>
		public abstract TList<CoExaminerCorector> GetBySaCodeScDegId(TransactionManager transactionManager, System.Decimal? _saCodeScDegId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_SA_STF_MEMBER_ID_1 index.
		/// </summary>
		/// <param name="_saStfMemberId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoExaminerCorector&gt;"/> class.</returns>
		public TList<CoExaminerCorector> GetBySaStfMemberId(System.Decimal? _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(null,_saStfMemberId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_STF_MEMBER_ID_1 index.
		/// </summary>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoExaminerCorector&gt;"/> class.</returns>
		public TList<CoExaminerCorector> GetBySaStfMemberId(System.Decimal? _saStfMemberId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_STF_MEMBER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoExaminerCorector&gt;"/> class.</returns>
		public TList<CoExaminerCorector> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal? _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_STF_MEMBER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoExaminerCorector&gt;"/> class.</returns>
		public TList<CoExaminerCorector> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal? _saStfMemberId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_STF_MEMBER_ID_1 index.
		/// </summary>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoExaminerCorector&gt;"/> class.</returns>
		public TList<CoExaminerCorector> GetBySaStfMemberId(System.Decimal? _saStfMemberId, int start, int pageLength, out int count)
		{
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_STF_MEMBER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoExaminerCorector&gt;"/> class.</returns>
		public abstract TList<CoExaminerCorector> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal? _saStfMemberId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_CO_EXAMINER_CORECTOR index.
		/// </summary>
		/// <param name="_coExaminerCorectorId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoExaminerCorector"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoExaminerCorector GetByCoExaminerCorectorId(System.Decimal _coExaminerCorectorId)
		{
			int count = -1;
			return GetByCoExaminerCorectorId(null,_coExaminerCorectorId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_EXAMINER_CORECTOR index.
		/// </summary>
		/// <param name="_coExaminerCorectorId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoExaminerCorector"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoExaminerCorector GetByCoExaminerCorectorId(System.Decimal _coExaminerCorectorId, int start, int pageLength)
		{
			int count = -1;
			return GetByCoExaminerCorectorId(null, _coExaminerCorectorId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_EXAMINER_CORECTOR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coExaminerCorectorId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoExaminerCorector"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoExaminerCorector GetByCoExaminerCorectorId(TransactionManager transactionManager, System.Decimal _coExaminerCorectorId)
		{
			int count = -1;
			return GetByCoExaminerCorectorId(transactionManager, _coExaminerCorectorId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_EXAMINER_CORECTOR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coExaminerCorectorId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoExaminerCorector"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoExaminerCorector GetByCoExaminerCorectorId(TransactionManager transactionManager, System.Decimal _coExaminerCorectorId, int start, int pageLength)
		{
			int count = -1;
			return GetByCoExaminerCorectorId(transactionManager, _coExaminerCorectorId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_EXAMINER_CORECTOR index.
		/// </summary>
		/// <param name="_coExaminerCorectorId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoExaminerCorector"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoExaminerCorector GetByCoExaminerCorectorId(System.Decimal _coExaminerCorectorId, int start, int pageLength, out int count)
		{
			return GetByCoExaminerCorectorId(null, _coExaminerCorectorId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_EXAMINER_CORECTOR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coExaminerCorectorId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoExaminerCorector"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.CoExaminerCorector GetByCoExaminerCorectorId(TransactionManager transactionManager, System.Decimal _coExaminerCorectorId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;CoExaminerCorector&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;CoExaminerCorector&gt;"/></returns>
		public static TList<CoExaminerCorector> Fill(IDataReader reader, TList<CoExaminerCorector> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.CoExaminerCorector c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("CoExaminerCorector")
					.Append("|").Append((System.Decimal)reader["CO_EXAMINER_CORECTOR_ID"]).ToString();
					c = EntityManager.LocateOrCreate<CoExaminerCorector>(
					key.ToString(), // EntityTrackingKey
					"CoExaminerCorector",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.CoExaminerCorector();
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
					c.CoExaminerCorectorId = (System.Decimal)reader["CO_EXAMINER_CORECTOR_ID"];
					c.OriginalCoExaminerCorectorId = c.CoExaminerCorectorId;
					c.EdExamSchdlId = (System.Decimal)reader["ED_EXAM_SCHDL_ID"];
					c.SaStfMemberId = Convert.IsDBNull(reader["SA_STF_MEMBER_ID"]) ? null : (System.Decimal?)reader["SA_STF_MEMBER_ID"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
					c.CorrectorFlg = (System.Decimal)reader["CORRECTOR_FLG"];
					c.ExaminerFlg = (System.Decimal)reader["EXAMINER_FLG"];
					c.SaCodeScDegId = Convert.IsDBNull(reader["SA_CODE_SC_DEG_ID"]) ? null : (System.Decimal?)reader["SA_CODE_SC_DEG_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.CoExaminerCorector"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CoExaminerCorector"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.CoExaminerCorector entity)
		{
			if (!reader.Read()) return;
			
			entity.CoExaminerCorectorId = (System.Decimal)reader[((int)CoExaminerCorectorColumn.CoExaminerCorectorId - 1)];
			entity.OriginalCoExaminerCorectorId = (System.Decimal)reader["CO_EXAMINER_CORECTOR_ID"];
			entity.EdExamSchdlId = (System.Decimal)reader[((int)CoExaminerCorectorColumn.EdExamSchdlId - 1)];
			entity.SaStfMemberId = (reader.IsDBNull(((int)CoExaminerCorectorColumn.SaStfMemberId - 1)))?null:(System.Decimal?)reader[((int)CoExaminerCorectorColumn.SaStfMemberId - 1)];
			entity.Notes = (reader.IsDBNull(((int)CoExaminerCorectorColumn.Notes - 1)))?null:(System.String)reader[((int)CoExaminerCorectorColumn.Notes - 1)];
			entity.CorrectorFlg = (System.Decimal)reader[((int)CoExaminerCorectorColumn.CorrectorFlg - 1)];
			entity.ExaminerFlg = (System.Decimal)reader[((int)CoExaminerCorectorColumn.ExaminerFlg - 1)];
			entity.SaCodeScDegId = (reader.IsDBNull(((int)CoExaminerCorectorColumn.SaCodeScDegId - 1)))?null:(System.Decimal?)reader[((int)CoExaminerCorectorColumn.SaCodeScDegId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.CoExaminerCorector"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CoExaminerCorector"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.CoExaminerCorector entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.CoExaminerCorectorId = (System.Decimal)dataRow["CO_EXAMINER_CORECTOR_ID"];
			entity.OriginalCoExaminerCorectorId = (System.Decimal)dataRow["CO_EXAMINER_CORECTOR_ID"];
			entity.EdExamSchdlId = (System.Decimal)dataRow["ED_EXAM_SCHDL_ID"];
			entity.SaStfMemberId = Convert.IsDBNull(dataRow["SA_STF_MEMBER_ID"]) ? null : (System.Decimal?)dataRow["SA_STF_MEMBER_ID"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
			entity.CorrectorFlg = (System.Decimal)dataRow["CORRECTOR_FLG"];
			entity.ExaminerFlg = (System.Decimal)dataRow["EXAMINER_FLG"];
			entity.SaCodeScDegId = Convert.IsDBNull(dataRow["SA_CODE_SC_DEG_ID"]) ? null : (System.Decimal?)dataRow["SA_CODE_SC_DEG_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CoExaminerCorector"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.CoExaminerCorector Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CoExaminerCorector entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region SaCodeScDegIdSource	
			if (CanDeepLoad(entity, "SaCodeScDeg|SaCodeScDegIdSource", deepLoadType, innerList) 
				&& entity.SaCodeScDegIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SaCodeScDegId ?? 0.0m);
				SaCodeScDeg tmpEntity = EntityManager.LocateEntity<SaCodeScDeg>(EntityLocator.ConstructKeyFromPkItems(typeof(SaCodeScDeg), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaCodeScDegIdSource = tmpEntity;
				else
					entity.SaCodeScDegIdSource = DataRepository.SaCodeScDegProvider.GetBySaCodeScDegId(transactionManager, (entity.SaCodeScDegId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaCodeScDegIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaCodeScDegIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaCodeScDegProvider.DeepLoad(transactionManager, entity.SaCodeScDegIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaCodeScDegIdSource

			#region EdExamSchdlIdSource	
			if (CanDeepLoad(entity, "EdExamSchdl|EdExamSchdlIdSource", deepLoadType, innerList) 
				&& entity.EdExamSchdlIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdExamSchdlId;
				EdExamSchdl tmpEntity = EntityManager.LocateEntity<EdExamSchdl>(EntityLocator.ConstructKeyFromPkItems(typeof(EdExamSchdl), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdExamSchdlIdSource = tmpEntity;
				else
					entity.EdExamSchdlIdSource = DataRepository.EdExamSchdlProvider.GetByEdExamSchdlId(transactionManager, entity.EdExamSchdlId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdExamSchdlIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdExamSchdlIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdExamSchdlProvider.DeepLoad(transactionManager, entity.EdExamSchdlIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdExamSchdlIdSource

			#region SaStfMemberIdSource	
			if (CanDeepLoad(entity, "SaStfMember|SaStfMemberIdSource", deepLoadType, innerList) 
				&& entity.SaStfMemberIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SaStfMemberId ?? 0.0m);
				SaStfMember tmpEntity = EntityManager.LocateEntity<SaStfMember>(EntityLocator.ConstructKeyFromPkItems(typeof(SaStfMember), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaStfMemberIdSource = tmpEntity;
				else
					entity.SaStfMemberIdSource = DataRepository.SaStfMemberProvider.GetBySaStfMemberId(transactionManager, (entity.SaStfMemberId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaStfMemberIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaStfMemberIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaStfMemberProvider.DeepLoad(transactionManager, entity.SaStfMemberIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaStfMemberIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.CoExaminerCorector object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.CoExaminerCorector instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.CoExaminerCorector Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CoExaminerCorector entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region SaCodeScDegIdSource
			if (CanDeepSave(entity, "SaCodeScDeg|SaCodeScDegIdSource", deepSaveType, innerList) 
				&& entity.SaCodeScDegIdSource != null)
			{
				DataRepository.SaCodeScDegProvider.Save(transactionManager, entity.SaCodeScDegIdSource);
				entity.SaCodeScDegId = entity.SaCodeScDegIdSource.SaCodeScDegId;
			}
			#endregion 
			
			#region EdExamSchdlIdSource
			if (CanDeepSave(entity, "EdExamSchdl|EdExamSchdlIdSource", deepSaveType, innerList) 
				&& entity.EdExamSchdlIdSource != null)
			{
				DataRepository.EdExamSchdlProvider.Save(transactionManager, entity.EdExamSchdlIdSource);
				entity.EdExamSchdlId = entity.EdExamSchdlIdSource.EdExamSchdlId;
			}
			#endregion 
			
			#region SaStfMemberIdSource
			if (CanDeepSave(entity, "SaStfMember|SaStfMemberIdSource", deepSaveType, innerList) 
				&& entity.SaStfMemberIdSource != null)
			{
				DataRepository.SaStfMemberProvider.Save(transactionManager, entity.SaStfMemberIdSource);
				entity.SaStfMemberId = entity.SaStfMemberIdSource.SaStfMemberId;
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
	
	#region CoExaminerCorectorChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.CoExaminerCorector</c>
	///</summary>
	public enum CoExaminerCorectorChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>SaCodeScDeg</c> at SaCodeScDegIdSource
		///</summary>
		[ChildEntityType(typeof(SaCodeScDeg))]
		SaCodeScDeg,
		
		///<summary>
		/// Composite Property for <c>EdExamSchdl</c> at EdExamSchdlIdSource
		///</summary>
		[ChildEntityType(typeof(EdExamSchdl))]
		EdExamSchdl,
		
		///<summary>
		/// Composite Property for <c>SaStfMember</c> at SaStfMemberIdSource
		///</summary>
		[ChildEntityType(typeof(SaStfMember))]
		SaStfMember,
	}
	
	#endregion CoExaminerCorectorChildEntityTypes
	
	#region CoExaminerCorectorFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;CoExaminerCorectorColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CoExaminerCorector"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CoExaminerCorectorFilterBuilder : SqlFilterBuilder<CoExaminerCorectorColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CoExaminerCorectorFilterBuilder class.
		/// </summary>
		public CoExaminerCorectorFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CoExaminerCorectorFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CoExaminerCorectorFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CoExaminerCorectorFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CoExaminerCorectorFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CoExaminerCorectorFilterBuilder
	
	#region CoExaminerCorectorParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;CoExaminerCorectorColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CoExaminerCorector"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CoExaminerCorectorParameterBuilder : ParameterizedSqlFilterBuilder<CoExaminerCorectorColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CoExaminerCorectorParameterBuilder class.
		/// </summary>
		public CoExaminerCorectorParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CoExaminerCorectorParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CoExaminerCorectorParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CoExaminerCorectorParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CoExaminerCorectorParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CoExaminerCorectorParameterBuilder
	
	#region CoExaminerCorectorSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;CoExaminerCorectorColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CoExaminerCorector"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class CoExaminerCorectorSortBuilder : SqlSortBuilder<CoExaminerCorectorColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CoExaminerCorectorSqlSortBuilder class.
		/// </summary>
		public CoExaminerCorectorSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion CoExaminerCorectorSortBuilder
	
} // end namespace
