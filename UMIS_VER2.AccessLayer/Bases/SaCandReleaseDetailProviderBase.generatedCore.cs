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
	/// This class is the base class for any <see cref="SaCandReleaseDetailProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SaCandReleaseDetailProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SaCandReleaseDetail, UMIS_VER2.BusinessLyer.SaCandReleaseDetailKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCandReleaseDetailKey key)
		{
			return Delete(transactionManager, key.SaCandReleaseDetailId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_saCandReleaseDetailId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _saCandReleaseDetailId)
		{
			return Delete(null, _saCandReleaseDetailId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCandReleaseDetailId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _saCandReleaseDetailId);		
		
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
		public override UMIS_VER2.BusinessLyer.SaCandReleaseDetail Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCandReleaseDetailKey key, int start, int pageLength)
		{
			return GetBySaCandReleaseDetailId(transactionManager, key.SaCandReleaseDetailId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCandReleaseDetail&gt;"/> class.</returns>
		public TList<SaCandReleaseDetail> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(null,_asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCandReleaseDetail&gt;"/> class.</returns>
		public TList<SaCandReleaseDetail> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCandReleaseDetail&gt;"/> class.</returns>
		public TList<SaCandReleaseDetail> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCandReleaseDetail&gt;"/> class.</returns>
		public TList<SaCandReleaseDetail> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCandReleaseDetail&gt;"/> class.</returns>
		public TList<SaCandReleaseDetail> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength, out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCandReleaseDetail&gt;"/> class.</returns>
		public abstract TList<SaCandReleaseDetail> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_CODE_DISCHARGE_D__1 index.
		/// </summary>
		/// <param name="_edCodeDischargeDId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCandReleaseDetail&gt;"/> class.</returns>
		public TList<SaCandReleaseDetail> GetByEdCodeDischargeDId(System.Decimal _edCodeDischargeDId)
		{
			int count = -1;
			return GetByEdCodeDischargeDId(null,_edCodeDischargeDId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_DISCHARGE_D__1 index.
		/// </summary>
		/// <param name="_edCodeDischargeDId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCandReleaseDetail&gt;"/> class.</returns>
		public TList<SaCandReleaseDetail> GetByEdCodeDischargeDId(System.Decimal _edCodeDischargeDId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeDischargeDId(null, _edCodeDischargeDId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_DISCHARGE_D__1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeDischargeDId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCandReleaseDetail&gt;"/> class.</returns>
		public TList<SaCandReleaseDetail> GetByEdCodeDischargeDId(TransactionManager transactionManager, System.Decimal _edCodeDischargeDId)
		{
			int count = -1;
			return GetByEdCodeDischargeDId(transactionManager, _edCodeDischargeDId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_DISCHARGE_D__1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeDischargeDId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCandReleaseDetail&gt;"/> class.</returns>
		public TList<SaCandReleaseDetail> GetByEdCodeDischargeDId(TransactionManager transactionManager, System.Decimal _edCodeDischargeDId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeDischargeDId(transactionManager, _edCodeDischargeDId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_DISCHARGE_D__1 index.
		/// </summary>
		/// <param name="_edCodeDischargeDId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCandReleaseDetail&gt;"/> class.</returns>
		public TList<SaCandReleaseDetail> GetByEdCodeDischargeDId(System.Decimal _edCodeDischargeDId, int start, int pageLength, out int count)
		{
			return GetByEdCodeDischargeDId(null, _edCodeDischargeDId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_DISCHARGE_D__1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeDischargeDId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCandReleaseDetail&gt;"/> class.</returns>
		public abstract TList<SaCandReleaseDetail> GetByEdCodeDischargeDId(TransactionManager transactionManager, System.Decimal _edCodeDischargeDId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_SA_CAND_RELEASE_ID_1 index.
		/// </summary>
		/// <param name="_saCandReleaseId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCandReleaseDetail&gt;"/> class.</returns>
		public TList<SaCandReleaseDetail> GetBySaCandReleaseId(System.Decimal _saCandReleaseId)
		{
			int count = -1;
			return GetBySaCandReleaseId(null,_saCandReleaseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_CAND_RELEASE_ID_1 index.
		/// </summary>
		/// <param name="_saCandReleaseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCandReleaseDetail&gt;"/> class.</returns>
		public TList<SaCandReleaseDetail> GetBySaCandReleaseId(System.Decimal _saCandReleaseId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCandReleaseId(null, _saCandReleaseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_CAND_RELEASE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCandReleaseId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCandReleaseDetail&gt;"/> class.</returns>
		public TList<SaCandReleaseDetail> GetBySaCandReleaseId(TransactionManager transactionManager, System.Decimal _saCandReleaseId)
		{
			int count = -1;
			return GetBySaCandReleaseId(transactionManager, _saCandReleaseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_CAND_RELEASE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCandReleaseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCandReleaseDetail&gt;"/> class.</returns>
		public TList<SaCandReleaseDetail> GetBySaCandReleaseId(TransactionManager transactionManager, System.Decimal _saCandReleaseId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCandReleaseId(transactionManager, _saCandReleaseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_CAND_RELEASE_ID_1 index.
		/// </summary>
		/// <param name="_saCandReleaseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCandReleaseDetail&gt;"/> class.</returns>
		public TList<SaCandReleaseDetail> GetBySaCandReleaseId(System.Decimal _saCandReleaseId, int start, int pageLength, out int count)
		{
			return GetBySaCandReleaseId(null, _saCandReleaseId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_CAND_RELEASE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCandReleaseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCandReleaseDetail&gt;"/> class.</returns>
		public abstract TList<SaCandReleaseDetail> GetBySaCandReleaseId(TransactionManager transactionManager, System.Decimal _saCandReleaseId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SA_CAND_RELEASE_DETAIL index.
		/// </summary>
		/// <param name="_saCandReleaseDetailId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCandReleaseDetail"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCandReleaseDetail GetBySaCandReleaseDetailId(System.Decimal _saCandReleaseDetailId)
		{
			int count = -1;
			return GetBySaCandReleaseDetailId(null,_saCandReleaseDetailId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CAND_RELEASE_DETAIL index.
		/// </summary>
		/// <param name="_saCandReleaseDetailId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCandReleaseDetail"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCandReleaseDetail GetBySaCandReleaseDetailId(System.Decimal _saCandReleaseDetailId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCandReleaseDetailId(null, _saCandReleaseDetailId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CAND_RELEASE_DETAIL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCandReleaseDetailId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCandReleaseDetail"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCandReleaseDetail GetBySaCandReleaseDetailId(TransactionManager transactionManager, System.Decimal _saCandReleaseDetailId)
		{
			int count = -1;
			return GetBySaCandReleaseDetailId(transactionManager, _saCandReleaseDetailId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CAND_RELEASE_DETAIL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCandReleaseDetailId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCandReleaseDetail"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCandReleaseDetail GetBySaCandReleaseDetailId(TransactionManager transactionManager, System.Decimal _saCandReleaseDetailId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCandReleaseDetailId(transactionManager, _saCandReleaseDetailId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CAND_RELEASE_DETAIL index.
		/// </summary>
		/// <param name="_saCandReleaseDetailId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCandReleaseDetail"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCandReleaseDetail GetBySaCandReleaseDetailId(System.Decimal _saCandReleaseDetailId, int start, int pageLength, out int count)
		{
			return GetBySaCandReleaseDetailId(null, _saCandReleaseDetailId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CAND_RELEASE_DETAIL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCandReleaseDetailId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCandReleaseDetail"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SaCandReleaseDetail GetBySaCandReleaseDetailId(TransactionManager transactionManager, System.Decimal _saCandReleaseDetailId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SaCandReleaseDetail&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SaCandReleaseDetail&gt;"/></returns>
		public static TList<SaCandReleaseDetail> Fill(IDataReader reader, TList<SaCandReleaseDetail> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SaCandReleaseDetail c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SaCandReleaseDetail")
					.Append("|").Append((System.Decimal)reader["SA_CAND_RELEASE_DETAIL_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SaCandReleaseDetail>(
					key.ToString(), // EntityTrackingKey
					"SaCandReleaseDetail",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SaCandReleaseDetail();
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
					c.SaCandReleaseDetailId = (System.Decimal)reader["SA_CAND_RELEASE_DETAIL_ID"];
					c.OriginalSaCandReleaseDetailId = c.SaCandReleaseDetailId;
					c.DiscahrgeDate = (System.DateTime)reader["DISCAHRGE_DATE"];
					c.EdCodeDischargeDId = (System.Decimal)reader["ED_CODE_DISCHARGE_D_ID"];
					c.SaCandReleaseId = (System.Decimal)reader["SA_CAND_RELEASE_ID"];
					c.AsFacultyInfoId = (System.Decimal)reader["AS_FACULTY_INFO_ID"];
					c.RespName = Convert.IsDBNull(reader["RESP_NAME"]) ? null : (System.String)reader["RESP_NAME"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaCandReleaseDetail"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCandReleaseDetail"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SaCandReleaseDetail entity)
		{
			if (!reader.Read()) return;
			
			entity.SaCandReleaseDetailId = (System.Decimal)reader[((int)SaCandReleaseDetailColumn.SaCandReleaseDetailId - 1)];
			entity.OriginalSaCandReleaseDetailId = (System.Decimal)reader["SA_CAND_RELEASE_DETAIL_ID"];
			entity.DiscahrgeDate = (System.DateTime)reader[((int)SaCandReleaseDetailColumn.DiscahrgeDate - 1)];
			entity.EdCodeDischargeDId = (System.Decimal)reader[((int)SaCandReleaseDetailColumn.EdCodeDischargeDId - 1)];
			entity.SaCandReleaseId = (System.Decimal)reader[((int)SaCandReleaseDetailColumn.SaCandReleaseId - 1)];
			entity.AsFacultyInfoId = (System.Decimal)reader[((int)SaCandReleaseDetailColumn.AsFacultyInfoId - 1)];
			entity.RespName = (reader.IsDBNull(((int)SaCandReleaseDetailColumn.RespName - 1)))?null:(System.String)reader[((int)SaCandReleaseDetailColumn.RespName - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaCandReleaseDetail"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCandReleaseDetail"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SaCandReleaseDetail entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SaCandReleaseDetailId = (System.Decimal)dataRow["SA_CAND_RELEASE_DETAIL_ID"];
			entity.OriginalSaCandReleaseDetailId = (System.Decimal)dataRow["SA_CAND_RELEASE_DETAIL_ID"];
			entity.DiscahrgeDate = (System.DateTime)dataRow["DISCAHRGE_DATE"];
			entity.EdCodeDischargeDId = (System.Decimal)dataRow["ED_CODE_DISCHARGE_D_ID"];
			entity.SaCandReleaseId = (System.Decimal)dataRow["SA_CAND_RELEASE_ID"];
			entity.AsFacultyInfoId = (System.Decimal)dataRow["AS_FACULTY_INFO_ID"];
			entity.RespName = Convert.IsDBNull(dataRow["RESP_NAME"]) ? null : (System.String)dataRow["RESP_NAME"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCandReleaseDetail"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaCandReleaseDetail Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCandReleaseDetail entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region SaCandReleaseIdSource	
			if (CanDeepLoad(entity, "SaCandRelease|SaCandReleaseIdSource", deepLoadType, innerList) 
				&& entity.SaCandReleaseIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SaCandReleaseId;
				SaCandRelease tmpEntity = EntityManager.LocateEntity<SaCandRelease>(EntityLocator.ConstructKeyFromPkItems(typeof(SaCandRelease), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaCandReleaseIdSource = tmpEntity;
				else
					entity.SaCandReleaseIdSource = DataRepository.SaCandReleaseProvider.GetBySaCandReleaseId(transactionManager, entity.SaCandReleaseId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaCandReleaseIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaCandReleaseIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaCandReleaseProvider.DeepLoad(transactionManager, entity.SaCandReleaseIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaCandReleaseIdSource

			#region AsFacultyInfoIdSource	
			if (CanDeepLoad(entity, "AsFacultyInfo|AsFacultyInfoIdSource", deepLoadType, innerList) 
				&& entity.AsFacultyInfoIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AsFacultyInfoId;
				AsFacultyInfo tmpEntity = EntityManager.LocateEntity<AsFacultyInfo>(EntityLocator.ConstructKeyFromPkItems(typeof(AsFacultyInfo), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AsFacultyInfoIdSource = tmpEntity;
				else
					entity.AsFacultyInfoIdSource = DataRepository.AsFacultyInfoProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AsFacultyInfoIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AsFacultyInfoIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AsFacultyInfoProvider.DeepLoad(transactionManager, entity.AsFacultyInfoIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AsFacultyInfoIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SaCandReleaseDetail object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SaCandReleaseDetail instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaCandReleaseDetail Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCandReleaseDetail entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region SaCandReleaseIdSource
			if (CanDeepSave(entity, "SaCandRelease|SaCandReleaseIdSource", deepSaveType, innerList) 
				&& entity.SaCandReleaseIdSource != null)
			{
				DataRepository.SaCandReleaseProvider.Save(transactionManager, entity.SaCandReleaseIdSource);
				entity.SaCandReleaseId = entity.SaCandReleaseIdSource.SaCandReleaseId;
			}
			#endregion 
			
			#region AsFacultyInfoIdSource
			if (CanDeepSave(entity, "AsFacultyInfo|AsFacultyInfoIdSource", deepSaveType, innerList) 
				&& entity.AsFacultyInfoIdSource != null)
			{
				DataRepository.AsFacultyInfoProvider.Save(transactionManager, entity.AsFacultyInfoIdSource);
				entity.AsFacultyInfoId = entity.AsFacultyInfoIdSource.AsFacultyInfoId;
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
	
	#region SaCandReleaseDetailChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SaCandReleaseDetail</c>
	///</summary>
	public enum SaCandReleaseDetailChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>SaCandRelease</c> at SaCandReleaseIdSource
		///</summary>
		[ChildEntityType(typeof(SaCandRelease))]
		SaCandRelease,
		
		///<summary>
		/// Composite Property for <c>AsFacultyInfo</c> at AsFacultyInfoIdSource
		///</summary>
		[ChildEntityType(typeof(AsFacultyInfo))]
		AsFacultyInfo,
	}
	
	#endregion SaCandReleaseDetailChildEntityTypes
	
	#region SaCandReleaseDetailFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SaCandReleaseDetailColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCandReleaseDetail"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaCandReleaseDetailFilterBuilder : SqlFilterBuilder<SaCandReleaseDetailColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCandReleaseDetailFilterBuilder class.
		/// </summary>
		public SaCandReleaseDetailFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaCandReleaseDetailFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaCandReleaseDetailFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaCandReleaseDetailFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaCandReleaseDetailFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaCandReleaseDetailFilterBuilder
	
	#region SaCandReleaseDetailParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SaCandReleaseDetailColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCandReleaseDetail"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaCandReleaseDetailParameterBuilder : ParameterizedSqlFilterBuilder<SaCandReleaseDetailColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCandReleaseDetailParameterBuilder class.
		/// </summary>
		public SaCandReleaseDetailParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaCandReleaseDetailParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaCandReleaseDetailParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaCandReleaseDetailParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaCandReleaseDetailParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaCandReleaseDetailParameterBuilder
	
	#region SaCandReleaseDetailSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SaCandReleaseDetailColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCandReleaseDetail"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SaCandReleaseDetailSortBuilder : SqlSortBuilder<SaCandReleaseDetailColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCandReleaseDetailSqlSortBuilder class.
		/// </summary>
		public SaCandReleaseDetailSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SaCandReleaseDetailSortBuilder
	
} // end namespace
