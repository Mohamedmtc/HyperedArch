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
	/// This class is the base class for any <see cref="SaCodeDocProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SaCodeDocProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SaCodeDoc, UMIS_VER2.BusinessLyer.SaCodeDocKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeDocKey key)
		{
			return Delete(transactionManager, key.SaCodeDocId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_saCodeDocId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _saCodeDocId)
		{
			return Delete(null, _saCodeDocId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeDocId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _saCodeDocId);		
		
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
		public override UMIS_VER2.BusinessLyer.SaCodeDoc Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeDocKey key, int start, int pageLength)
		{
			return GetBySaCodeDocId(transactionManager, key.SaCodeDocId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key COS_SA_CODE_DOC2 index.
		/// </summary>
		/// <param name="_docNameAr"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeDoc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeDoc GetByDocNameAr(System.String _docNameAr)
		{
			int count = -1;
			return GetByDocNameAr(null,_docNameAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SA_CODE_DOC2 index.
		/// </summary>
		/// <param name="_docNameAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeDoc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeDoc GetByDocNameAr(System.String _docNameAr, int start, int pageLength)
		{
			int count = -1;
			return GetByDocNameAr(null, _docNameAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SA_CODE_DOC2 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_docNameAr"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeDoc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeDoc GetByDocNameAr(TransactionManager transactionManager, System.String _docNameAr)
		{
			int count = -1;
			return GetByDocNameAr(transactionManager, _docNameAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SA_CODE_DOC2 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_docNameAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeDoc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeDoc GetByDocNameAr(TransactionManager transactionManager, System.String _docNameAr, int start, int pageLength)
		{
			int count = -1;
			return GetByDocNameAr(transactionManager, _docNameAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SA_CODE_DOC2 index.
		/// </summary>
		/// <param name="_docNameAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeDoc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeDoc GetByDocNameAr(System.String _docNameAr, int start, int pageLength, out int count)
		{
			return GetByDocNameAr(null, _docNameAr, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SA_CODE_DOC2 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_docNameAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeDoc"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SaCodeDoc GetByDocNameAr(TransactionManager transactionManager, System.String _docNameAr, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_GS_CODE_GENDER_ID_1 index.
		/// </summary>
		/// <param name="_gsCodeGenderId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCodeDoc&gt;"/> class.</returns>
		public TList<SaCodeDoc> GetByGsCodeGenderId(System.Decimal? _gsCodeGenderId)
		{
			int count = -1;
			return GetByGsCodeGenderId(null,_gsCodeGenderId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_GENDER_ID_1 index.
		/// </summary>
		/// <param name="_gsCodeGenderId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCodeDoc&gt;"/> class.</returns>
		public TList<SaCodeDoc> GetByGsCodeGenderId(System.Decimal? _gsCodeGenderId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeGenderId(null, _gsCodeGenderId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_GENDER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeGenderId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCodeDoc&gt;"/> class.</returns>
		public TList<SaCodeDoc> GetByGsCodeGenderId(TransactionManager transactionManager, System.Decimal? _gsCodeGenderId)
		{
			int count = -1;
			return GetByGsCodeGenderId(transactionManager, _gsCodeGenderId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_GENDER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeGenderId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCodeDoc&gt;"/> class.</returns>
		public TList<SaCodeDoc> GetByGsCodeGenderId(TransactionManager transactionManager, System.Decimal? _gsCodeGenderId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeGenderId(transactionManager, _gsCodeGenderId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_GENDER_ID_1 index.
		/// </summary>
		/// <param name="_gsCodeGenderId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCodeDoc&gt;"/> class.</returns>
		public TList<SaCodeDoc> GetByGsCodeGenderId(System.Decimal? _gsCodeGenderId, int start, int pageLength, out int count)
		{
			return GetByGsCodeGenderId(null, _gsCodeGenderId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_GENDER_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeGenderId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCodeDoc&gt;"/> class.</returns>
		public abstract TList<SaCodeDoc> GetByGsCodeGenderId(TransactionManager transactionManager, System.Decimal? _gsCodeGenderId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_SA_CODE_FILE_TYPE_ID_3694 index.
		/// </summary>
		/// <param name="_saCodeDocTypeId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCodeDoc&gt;"/> class.</returns>
		public TList<SaCodeDoc> GetBySaCodeDocTypeId(System.Decimal _saCodeDocTypeId)
		{
			int count = -1;
			return GetBySaCodeDocTypeId(null,_saCodeDocTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_CODE_FILE_TYPE_ID_3694 index.
		/// </summary>
		/// <param name="_saCodeDocTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCodeDoc&gt;"/> class.</returns>
		public TList<SaCodeDoc> GetBySaCodeDocTypeId(System.Decimal _saCodeDocTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeDocTypeId(null, _saCodeDocTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_CODE_FILE_TYPE_ID_3694 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeDocTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCodeDoc&gt;"/> class.</returns>
		public TList<SaCodeDoc> GetBySaCodeDocTypeId(TransactionManager transactionManager, System.Decimal _saCodeDocTypeId)
		{
			int count = -1;
			return GetBySaCodeDocTypeId(transactionManager, _saCodeDocTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_CODE_FILE_TYPE_ID_3694 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeDocTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCodeDoc&gt;"/> class.</returns>
		public TList<SaCodeDoc> GetBySaCodeDocTypeId(TransactionManager transactionManager, System.Decimal _saCodeDocTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeDocTypeId(transactionManager, _saCodeDocTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_CODE_FILE_TYPE_ID_3694 index.
		/// </summary>
		/// <param name="_saCodeDocTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCodeDoc&gt;"/> class.</returns>
		public TList<SaCodeDoc> GetBySaCodeDocTypeId(System.Decimal _saCodeDocTypeId, int start, int pageLength, out int count)
		{
			return GetBySaCodeDocTypeId(null, _saCodeDocTypeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_CODE_FILE_TYPE_ID_3694 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeDocTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCodeDoc&gt;"/> class.</returns>
		public abstract TList<SaCodeDoc> GetBySaCodeDocTypeId(TransactionManager transactionManager, System.Decimal _saCodeDocTypeId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SA_CODE_DOC index.
		/// </summary>
		/// <param name="_saCodeDocId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeDoc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeDoc GetBySaCodeDocId(System.Decimal _saCodeDocId)
		{
			int count = -1;
			return GetBySaCodeDocId(null,_saCodeDocId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_DOC index.
		/// </summary>
		/// <param name="_saCodeDocId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeDoc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeDoc GetBySaCodeDocId(System.Decimal _saCodeDocId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeDocId(null, _saCodeDocId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_DOC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeDocId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeDoc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeDoc GetBySaCodeDocId(TransactionManager transactionManager, System.Decimal _saCodeDocId)
		{
			int count = -1;
			return GetBySaCodeDocId(transactionManager, _saCodeDocId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_DOC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeDocId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeDoc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeDoc GetBySaCodeDocId(TransactionManager transactionManager, System.Decimal _saCodeDocId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeDocId(transactionManager, _saCodeDocId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_DOC index.
		/// </summary>
		/// <param name="_saCodeDocId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeDoc"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeDoc GetBySaCodeDocId(System.Decimal _saCodeDocId, int start, int pageLength, out int count)
		{
			return GetBySaCodeDocId(null, _saCodeDocId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_DOC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeDocId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeDoc"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SaCodeDoc GetBySaCodeDocId(TransactionManager transactionManager, System.Decimal _saCodeDocId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SaCodeDoc&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SaCodeDoc&gt;"/></returns>
		public static TList<SaCodeDoc> Fill(IDataReader reader, TList<SaCodeDoc> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SaCodeDoc c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SaCodeDoc")
					.Append("|").Append((System.Decimal)reader["SA_CODE_DOC_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SaCodeDoc>(
					key.ToString(), // EntityTrackingKey
					"SaCodeDoc",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SaCodeDoc();
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
					c.SaCodeDocId = (System.Decimal)reader["SA_CODE_DOC_ID"];
					c.OriginalSaCodeDocId = c.SaCodeDocId;
					c.DocCode = Convert.IsDBNull(reader["DOC_CODE"]) ? null : (System.String)reader["DOC_CODE"];
					c.DocNameAr = (System.String)reader["DOC_NAME_AR"];
					c.DocNameEn = (System.String)reader["DOC_NAME_EN"];
					c.ExpireFlg = Convert.IsDBNull(reader["EXPIRE_FLG"]) ? null : (System.Decimal?)reader["EXPIRE_FLG"];
					c.SaCodeDocTypeId = (System.Decimal)reader["SA_CODE_DOC_TYPE_ID"];
					c.GsCodeGenderId = Convert.IsDBNull(reader["GS_CODE_GENDER_ID"]) ? null : (System.Decimal?)reader["GS_CODE_GENDER_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaCodeDoc"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCodeDoc"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SaCodeDoc entity)
		{
			if (!reader.Read()) return;
			
			entity.SaCodeDocId = (System.Decimal)reader[((int)SaCodeDocColumn.SaCodeDocId - 1)];
			entity.OriginalSaCodeDocId = (System.Decimal)reader["SA_CODE_DOC_ID"];
			entity.DocCode = (reader.IsDBNull(((int)SaCodeDocColumn.DocCode - 1)))?null:(System.String)reader[((int)SaCodeDocColumn.DocCode - 1)];
			entity.DocNameAr = (System.String)reader[((int)SaCodeDocColumn.DocNameAr - 1)];
			entity.DocNameEn = (System.String)reader[((int)SaCodeDocColumn.DocNameEn - 1)];
			entity.ExpireFlg = (reader.IsDBNull(((int)SaCodeDocColumn.ExpireFlg - 1)))?null:(System.Decimal?)reader[((int)SaCodeDocColumn.ExpireFlg - 1)];
			entity.SaCodeDocTypeId = (System.Decimal)reader[((int)SaCodeDocColumn.SaCodeDocTypeId - 1)];
			entity.GsCodeGenderId = (reader.IsDBNull(((int)SaCodeDocColumn.GsCodeGenderId - 1)))?null:(System.Decimal?)reader[((int)SaCodeDocColumn.GsCodeGenderId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaCodeDoc"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCodeDoc"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SaCodeDoc entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SaCodeDocId = (System.Decimal)dataRow["SA_CODE_DOC_ID"];
			entity.OriginalSaCodeDocId = (System.Decimal)dataRow["SA_CODE_DOC_ID"];
			entity.DocCode = Convert.IsDBNull(dataRow["DOC_CODE"]) ? null : (System.String)dataRow["DOC_CODE"];
			entity.DocNameAr = (System.String)dataRow["DOC_NAME_AR"];
			entity.DocNameEn = (System.String)dataRow["DOC_NAME_EN"];
			entity.ExpireFlg = Convert.IsDBNull(dataRow["EXPIRE_FLG"]) ? null : (System.Decimal?)dataRow["EXPIRE_FLG"];
			entity.SaCodeDocTypeId = (System.Decimal)dataRow["SA_CODE_DOC_TYPE_ID"];
			entity.GsCodeGenderId = Convert.IsDBNull(dataRow["GS_CODE_GENDER_ID"]) ? null : (System.Decimal?)dataRow["GS_CODE_GENDER_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCodeDoc"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaCodeDoc Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeDoc entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region GsCodeGenderIdSource	
			if (CanDeepLoad(entity, "GsCodeGender|GsCodeGenderIdSource", deepLoadType, innerList) 
				&& entity.GsCodeGenderIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCodeGenderId ?? 0.0m);
				GsCodeGender tmpEntity = EntityManager.LocateEntity<GsCodeGender>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodeGender), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodeGenderIdSource = tmpEntity;
				else
					entity.GsCodeGenderIdSource = DataRepository.GsCodeGenderProvider.GetByGsCodeGenderId(transactionManager, (entity.GsCodeGenderId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodeGenderIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCodeGenderIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodeGenderProvider.DeepLoad(transactionManager, entity.GsCodeGenderIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCodeGenderIdSource

			#region SaCodeDocTypeIdSource	
			if (CanDeepLoad(entity, "SaCodeDocType|SaCodeDocTypeIdSource", deepLoadType, innerList) 
				&& entity.SaCodeDocTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SaCodeDocTypeId;
				SaCodeDocType tmpEntity = EntityManager.LocateEntity<SaCodeDocType>(EntityLocator.ConstructKeyFromPkItems(typeof(SaCodeDocType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaCodeDocTypeIdSource = tmpEntity;
				else
					entity.SaCodeDocTypeIdSource = DataRepository.SaCodeDocTypeProvider.GetBySaCodeDocTypeId(transactionManager, entity.SaCodeDocTypeId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaCodeDocTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaCodeDocTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaCodeDocTypeProvider.DeepLoad(transactionManager, entity.SaCodeDocTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaCodeDocTypeIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetBySaCodeDocId methods when available
			
			#region SaStfDocCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaStfDoc>|SaStfDocCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaStfDocCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaStfDocCollection = DataRepository.SaStfDocProvider.GetBySaCodeDocId(transactionManager, entity.SaCodeDocId);

				if (deep && entity.SaStfDocCollection.Count > 0)
				{
					deepHandles.Add("SaStfDocCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaStfDoc>) DataRepository.SaStfDocProvider.DeepLoad,
						new object[] { transactionManager, entity.SaStfDocCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaDocOfFileCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaDocOfFile>|SaDocOfFileCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaDocOfFileCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaDocOfFileCollection = DataRepository.SaDocOfFileProvider.GetBySaCodeDocId(transactionManager, entity.SaCodeDocId);

				if (deep && entity.SaDocOfFileCollection.Count > 0)
				{
					deepHandles.Add("SaDocOfFileCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaDocOfFile>) DataRepository.SaDocOfFileProvider.DeepLoad,
						new object[] { transactionManager, entity.SaDocOfFileCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SaCodeDoc object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SaCodeDoc instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaCodeDoc Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeDoc entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region GsCodeGenderIdSource
			if (CanDeepSave(entity, "GsCodeGender|GsCodeGenderIdSource", deepSaveType, innerList) 
				&& entity.GsCodeGenderIdSource != null)
			{
				DataRepository.GsCodeGenderProvider.Save(transactionManager, entity.GsCodeGenderIdSource);
				entity.GsCodeGenderId = entity.GsCodeGenderIdSource.GsCodeGenderId;
			}
			#endregion 
			
			#region SaCodeDocTypeIdSource
			if (CanDeepSave(entity, "SaCodeDocType|SaCodeDocTypeIdSource", deepSaveType, innerList) 
				&& entity.SaCodeDocTypeIdSource != null)
			{
				DataRepository.SaCodeDocTypeProvider.Save(transactionManager, entity.SaCodeDocTypeIdSource);
				entity.SaCodeDocTypeId = entity.SaCodeDocTypeIdSource.SaCodeDocTypeId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<SaStfDoc>
				if (CanDeepSave(entity.SaStfDocCollection, "List<SaStfDoc>|SaStfDocCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaStfDoc child in entity.SaStfDocCollection)
					{
						if(child.SaCodeDocIdSource != null)
						{
							child.SaCodeDocId = child.SaCodeDocIdSource.SaCodeDocId;
						}
						else
						{
							child.SaCodeDocId = entity.SaCodeDocId;
						}

					}

					if (entity.SaStfDocCollection.Count > 0 || entity.SaStfDocCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaStfDocProvider.Save(transactionManager, entity.SaStfDocCollection);
						
						deepHandles.Add("SaStfDocCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaStfDoc >) DataRepository.SaStfDocProvider.DeepSave,
							new object[] { transactionManager, entity.SaStfDocCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaDocOfFile>
				if (CanDeepSave(entity.SaDocOfFileCollection, "List<SaDocOfFile>|SaDocOfFileCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaDocOfFile child in entity.SaDocOfFileCollection)
					{
						if(child.SaCodeDocIdSource != null)
						{
							child.SaCodeDocId = child.SaCodeDocIdSource.SaCodeDocId;
						}
						else
						{
							child.SaCodeDocId = entity.SaCodeDocId;
						}

					}

					if (entity.SaDocOfFileCollection.Count > 0 || entity.SaDocOfFileCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaDocOfFileProvider.Save(transactionManager, entity.SaDocOfFileCollection);
						
						deepHandles.Add("SaDocOfFileCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaDocOfFile >) DataRepository.SaDocOfFileProvider.DeepSave,
							new object[] { transactionManager, entity.SaDocOfFileCollection, deepSaveType, childTypes, innerList }
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
	
	#region SaCodeDocChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SaCodeDoc</c>
	///</summary>
	public enum SaCodeDocChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>GsCodeGender</c> at GsCodeGenderIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeGender))]
		GsCodeGender,
		
		///<summary>
		/// Composite Property for <c>SaCodeDocType</c> at SaCodeDocTypeIdSource
		///</summary>
		[ChildEntityType(typeof(SaCodeDocType))]
		SaCodeDocType,
		///<summary>
		/// Collection of <c>SaCodeDoc</c> as OneToMany for SaStfDocCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaStfDoc>))]
		SaStfDocCollection,
		///<summary>
		/// Collection of <c>SaCodeDoc</c> as OneToMany for SaDocOfFileCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaDocOfFile>))]
		SaDocOfFileCollection,
	}
	
	#endregion SaCodeDocChildEntityTypes
	
	#region SaCodeDocFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SaCodeDocColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCodeDoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaCodeDocFilterBuilder : SqlFilterBuilder<SaCodeDocColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCodeDocFilterBuilder class.
		/// </summary>
		public SaCodeDocFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaCodeDocFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaCodeDocFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaCodeDocFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaCodeDocFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaCodeDocFilterBuilder
	
	#region SaCodeDocParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SaCodeDocColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCodeDoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaCodeDocParameterBuilder : ParameterizedSqlFilterBuilder<SaCodeDocColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCodeDocParameterBuilder class.
		/// </summary>
		public SaCodeDocParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaCodeDocParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaCodeDocParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaCodeDocParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaCodeDocParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaCodeDocParameterBuilder
	
	#region SaCodeDocSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SaCodeDocColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCodeDoc"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SaCodeDocSortBuilder : SqlSortBuilder<SaCodeDocColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCodeDocSqlSortBuilder class.
		/// </summary>
		public SaCodeDocSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SaCodeDocSortBuilder
	
} // end namespace
