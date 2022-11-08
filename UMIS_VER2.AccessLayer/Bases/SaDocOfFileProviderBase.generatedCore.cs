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
	/// This class is the base class for any <see cref="SaDocOfFileProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SaDocOfFileProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SaDocOfFile, UMIS_VER2.BusinessLyer.SaDocOfFileKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaDocOfFileKey key)
		{
			return Delete(transactionManager, key.SaDocOfFileId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_saDocOfFileId">XXX UMIS1. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _saDocOfFileId)
		{
			return Delete(null, _saDocOfFileId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saDocOfFileId">XXX UMIS1. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _saDocOfFileId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0014 key.
		///		FK_AUTO_0014 Description: 
		/// </summary>
		/// <param name="_saStfMemberId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaDocOfFile objects.</returns>
		public TList<SaDocOfFile> GetBySaStfMemberId(System.Decimal _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(_saStfMemberId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0014 key.
		///		FK_AUTO_0014 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaDocOfFile objects.</returns>
		/// <remarks></remarks>
		public TList<SaDocOfFile> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0014 key.
		///		FK_AUTO_0014 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaDocOfFile objects.</returns>
		public TList<SaDocOfFile> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0014 key.
		///		fkAuto0014 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemberId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaDocOfFile objects.</returns>
		public TList<SaDocOfFile> GetBySaStfMemberId(System.Decimal _saStfMemberId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0014 key.
		///		fkAuto0014 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaDocOfFile objects.</returns>
		public TList<SaDocOfFile> GetBySaStfMemberId(System.Decimal _saStfMemberId, int start, int pageLength,out int count)
		{
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0014 key.
		///		FK_AUTO_0014 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaDocOfFile objects.</returns>
		public abstract TList<SaDocOfFile> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0051 key.
		///		FK_AUTO_0051 Description: 
		/// </summary>
		/// <param name="_saCodeDocId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaDocOfFile objects.</returns>
		public TList<SaDocOfFile> GetBySaCodeDocId(System.Decimal _saCodeDocId)
		{
			int count = -1;
			return GetBySaCodeDocId(_saCodeDocId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0051 key.
		///		FK_AUTO_0051 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeDocId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaDocOfFile objects.</returns>
		/// <remarks></remarks>
		public TList<SaDocOfFile> GetBySaCodeDocId(TransactionManager transactionManager, System.Decimal _saCodeDocId)
		{
			int count = -1;
			return GetBySaCodeDocId(transactionManager, _saCodeDocId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0051 key.
		///		FK_AUTO_0051 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeDocId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaDocOfFile objects.</returns>
		public TList<SaDocOfFile> GetBySaCodeDocId(TransactionManager transactionManager, System.Decimal _saCodeDocId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeDocId(transactionManager, _saCodeDocId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0051 key.
		///		fkAuto0051 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saCodeDocId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaDocOfFile objects.</returns>
		public TList<SaDocOfFile> GetBySaCodeDocId(System.Decimal _saCodeDocId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaCodeDocId(null, _saCodeDocId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0051 key.
		///		fkAuto0051 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saCodeDocId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaDocOfFile objects.</returns>
		public TList<SaDocOfFile> GetBySaCodeDocId(System.Decimal _saCodeDocId, int start, int pageLength,out int count)
		{
			return GetBySaCodeDocId(null, _saCodeDocId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0051 key.
		///		FK_AUTO_0051 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeDocId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaDocOfFile objects.</returns>
		public abstract TList<SaDocOfFile> GetBySaCodeDocId(TransactionManager transactionManager, System.Decimal _saCodeDocId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SaDocOfFile Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaDocOfFileKey key, int start, int pageLength)
		{
			return GetBySaDocOfFileId(transactionManager, key.SaDocOfFileId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaDocOfFile&gt;"/> class.</returns>
		public TList<SaDocOfFile> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;SaDocOfFile&gt;"/> class.</returns>
		public TList<SaDocOfFile> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;SaDocOfFile&gt;"/> class.</returns>
		public TList<SaDocOfFile> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;SaDocOfFile&gt;"/> class.</returns>
		public TList<SaDocOfFile> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;SaDocOfFile&gt;"/> class.</returns>
		public TList<SaDocOfFile> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength, out int count)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;SaDocOfFile&gt;"/> class.</returns>
		public abstract TList<SaDocOfFile> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SA_DOC_OF_FILE index.
		/// </summary>
		/// <param name="_saDocOfFileId">XXX UMIS1</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaDocOfFile"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaDocOfFile GetBySaDocOfFileId(System.Decimal _saDocOfFileId)
		{
			int count = -1;
			return GetBySaDocOfFileId(null,_saDocOfFileId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_DOC_OF_FILE index.
		/// </summary>
		/// <param name="_saDocOfFileId">XXX UMIS1</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaDocOfFile"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaDocOfFile GetBySaDocOfFileId(System.Decimal _saDocOfFileId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaDocOfFileId(null, _saDocOfFileId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_DOC_OF_FILE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saDocOfFileId">XXX UMIS1</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaDocOfFile"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaDocOfFile GetBySaDocOfFileId(TransactionManager transactionManager, System.Decimal _saDocOfFileId)
		{
			int count = -1;
			return GetBySaDocOfFileId(transactionManager, _saDocOfFileId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_DOC_OF_FILE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saDocOfFileId">XXX UMIS1</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaDocOfFile"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaDocOfFile GetBySaDocOfFileId(TransactionManager transactionManager, System.Decimal _saDocOfFileId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaDocOfFileId(transactionManager, _saDocOfFileId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_DOC_OF_FILE index.
		/// </summary>
		/// <param name="_saDocOfFileId">XXX UMIS1</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaDocOfFile"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaDocOfFile GetBySaDocOfFileId(System.Decimal _saDocOfFileId, int start, int pageLength, out int count)
		{
			return GetBySaDocOfFileId(null, _saDocOfFileId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_DOC_OF_FILE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saDocOfFileId">XXX UMIS1</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaDocOfFile"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SaDocOfFile GetBySaDocOfFileId(TransactionManager transactionManager, System.Decimal _saDocOfFileId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SaDocOfFile&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SaDocOfFile&gt;"/></returns>
		public static TList<SaDocOfFile> Fill(IDataReader reader, TList<SaDocOfFile> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SaDocOfFile c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SaDocOfFile")
					.Append("|").Append((System.Decimal)reader["SA_DOC_OF_FILE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SaDocOfFile>(
					key.ToString(), // EntityTrackingKey
					"SaDocOfFile",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SaDocOfFile();
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
					c.SaDocOfFileId = (System.Decimal)reader["SA_DOC_OF_FILE_ID"];
					c.OriginalSaDocOfFileId = c.SaDocOfFileId;
					c.DocIssueDate = (System.DateTime)reader["DOC_ISSUE_DATE"];
					c.DocSubmitDate = (System.DateTime)reader["DOC_SUBMIT_DATE"];
					c.DocEndDate = Convert.IsDBNull(reader["DOC_END_DATE"]) ? null : (System.DateTime?)reader["DOC_END_DATE"];
					c.SaStfMemberId = (System.Decimal)reader["SA_STF_MEMBER_ID"];
					c.SaCodeDocId = (System.Decimal)reader["SA_CODE_DOC_ID"];
					c.AsFacultyInfoId = (System.Decimal)reader["AS_FACULTY_INFO_ID"];
					c.DocBlob = Convert.IsDBNull(reader["DOC_BLOB"]) ? null : (System.String)reader["DOC_BLOB"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaDocOfFile"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaDocOfFile"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SaDocOfFile entity)
		{
			if (!reader.Read()) return;
			
			entity.SaDocOfFileId = (System.Decimal)reader[((int)SaDocOfFileColumn.SaDocOfFileId - 1)];
			entity.OriginalSaDocOfFileId = (System.Decimal)reader["SA_DOC_OF_FILE_ID"];
			entity.DocIssueDate = (System.DateTime)reader[((int)SaDocOfFileColumn.DocIssueDate - 1)];
			entity.DocSubmitDate = (System.DateTime)reader[((int)SaDocOfFileColumn.DocSubmitDate - 1)];
			entity.DocEndDate = (reader.IsDBNull(((int)SaDocOfFileColumn.DocEndDate - 1)))?null:(System.DateTime?)reader[((int)SaDocOfFileColumn.DocEndDate - 1)];
			entity.SaStfMemberId = (System.Decimal)reader[((int)SaDocOfFileColumn.SaStfMemberId - 1)];
			entity.SaCodeDocId = (System.Decimal)reader[((int)SaDocOfFileColumn.SaCodeDocId - 1)];
			entity.AsFacultyInfoId = (System.Decimal)reader[((int)SaDocOfFileColumn.AsFacultyInfoId - 1)];
			entity.DocBlob = (reader.IsDBNull(((int)SaDocOfFileColumn.DocBlob - 1)))?null:(System.String)reader[((int)SaDocOfFileColumn.DocBlob - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaDocOfFile"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaDocOfFile"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SaDocOfFile entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SaDocOfFileId = (System.Decimal)dataRow["SA_DOC_OF_FILE_ID"];
			entity.OriginalSaDocOfFileId = (System.Decimal)dataRow["SA_DOC_OF_FILE_ID"];
			entity.DocIssueDate = (System.DateTime)dataRow["DOC_ISSUE_DATE"];
			entity.DocSubmitDate = (System.DateTime)dataRow["DOC_SUBMIT_DATE"];
			entity.DocEndDate = Convert.IsDBNull(dataRow["DOC_END_DATE"]) ? null : (System.DateTime?)dataRow["DOC_END_DATE"];
			entity.SaStfMemberId = (System.Decimal)dataRow["SA_STF_MEMBER_ID"];
			entity.SaCodeDocId = (System.Decimal)dataRow["SA_CODE_DOC_ID"];
			entity.AsFacultyInfoId = (System.Decimal)dataRow["AS_FACULTY_INFO_ID"];
			entity.DocBlob = Convert.IsDBNull(dataRow["DOC_BLOB"]) ? null : (System.String)dataRow["DOC_BLOB"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaDocOfFile"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaDocOfFile Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaDocOfFile entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region SaStfMemberIdSource	
			if (CanDeepLoad(entity, "SaStfMember|SaStfMemberIdSource", deepLoadType, innerList) 
				&& entity.SaStfMemberIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SaStfMemberId;
				SaStfMember tmpEntity = EntityManager.LocateEntity<SaStfMember>(EntityLocator.ConstructKeyFromPkItems(typeof(SaStfMember), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaStfMemberIdSource = tmpEntity;
				else
					entity.SaStfMemberIdSource = DataRepository.SaStfMemberProvider.GetBySaStfMemberId(transactionManager, entity.SaStfMemberId);		
				
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

			#region SaCodeDocIdSource	
			if (CanDeepLoad(entity, "SaCodeDoc|SaCodeDocIdSource", deepLoadType, innerList) 
				&& entity.SaCodeDocIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SaCodeDocId;
				SaCodeDoc tmpEntity = EntityManager.LocateEntity<SaCodeDoc>(EntityLocator.ConstructKeyFromPkItems(typeof(SaCodeDoc), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaCodeDocIdSource = tmpEntity;
				else
					entity.SaCodeDocIdSource = DataRepository.SaCodeDocProvider.GetBySaCodeDocId(transactionManager, entity.SaCodeDocId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaCodeDocIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaCodeDocIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaCodeDocProvider.DeepLoad(transactionManager, entity.SaCodeDocIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaCodeDocIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SaDocOfFile object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SaDocOfFile instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaDocOfFile Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaDocOfFile entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region SaStfMemberIdSource
			if (CanDeepSave(entity, "SaStfMember|SaStfMemberIdSource", deepSaveType, innerList) 
				&& entity.SaStfMemberIdSource != null)
			{
				DataRepository.SaStfMemberProvider.Save(transactionManager, entity.SaStfMemberIdSource);
				entity.SaStfMemberId = entity.SaStfMemberIdSource.SaStfMemberId;
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
			
			#region SaCodeDocIdSource
			if (CanDeepSave(entity, "SaCodeDoc|SaCodeDocIdSource", deepSaveType, innerList) 
				&& entity.SaCodeDocIdSource != null)
			{
				DataRepository.SaCodeDocProvider.Save(transactionManager, entity.SaCodeDocIdSource);
				entity.SaCodeDocId = entity.SaCodeDocIdSource.SaCodeDocId;
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
	
	#region SaDocOfFileChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SaDocOfFile</c>
	///</summary>
	public enum SaDocOfFileChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>SaStfMember</c> at SaStfMemberIdSource
		///</summary>
		[ChildEntityType(typeof(SaStfMember))]
		SaStfMember,
		
		///<summary>
		/// Composite Property for <c>AsFacultyInfo</c> at AsFacultyInfoIdSource
		///</summary>
		[ChildEntityType(typeof(AsFacultyInfo))]
		AsFacultyInfo,
		
		///<summary>
		/// Composite Property for <c>SaCodeDoc</c> at SaCodeDocIdSource
		///</summary>
		[ChildEntityType(typeof(SaCodeDoc))]
		SaCodeDoc,
	}
	
	#endregion SaDocOfFileChildEntityTypes
	
	#region SaDocOfFileFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SaDocOfFileColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaDocOfFile"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaDocOfFileFilterBuilder : SqlFilterBuilder<SaDocOfFileColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaDocOfFileFilterBuilder class.
		/// </summary>
		public SaDocOfFileFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaDocOfFileFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaDocOfFileFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaDocOfFileFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaDocOfFileFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaDocOfFileFilterBuilder
	
	#region SaDocOfFileParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SaDocOfFileColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaDocOfFile"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaDocOfFileParameterBuilder : ParameterizedSqlFilterBuilder<SaDocOfFileColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaDocOfFileParameterBuilder class.
		/// </summary>
		public SaDocOfFileParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaDocOfFileParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaDocOfFileParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaDocOfFileParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaDocOfFileParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaDocOfFileParameterBuilder
	
	#region SaDocOfFileSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SaDocOfFileColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaDocOfFile"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SaDocOfFileSortBuilder : SqlSortBuilder<SaDocOfFileColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaDocOfFileSqlSortBuilder class.
		/// </summary>
		public SaDocOfFileSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SaDocOfFileSortBuilder
	
} // end namespace
