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
	/// This class is the base class for any <see cref="SaPersonIdProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SaPersonIdProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SaPersonId, UMIS_VER2.BusinessLyer.SaPersonIdKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaPersonIdKey key)
		{
			return Delete(transactionManager, key.SaPersonId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_saPersonId">XXX. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _saPersonId)
		{
			return Delete(null, _saPersonId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saPersonId">XXX. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _saPersonId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_001f key.
		///		FK_AUTO_001f Description: 
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPersonId objects.</returns>
		public TList<SaPersonId> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(_asFacultyInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_001f key.
		///		FK_AUTO_001f Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPersonId objects.</returns>
		/// <remarks></remarks>
		public TList<SaPersonId> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_001f key.
		///		FK_AUTO_001f Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPersonId objects.</returns>
		public TList<SaPersonId> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_001f key.
		///		fkAuto001f Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPersonId objects.</returns>
		public TList<SaPersonId> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_001f key.
		///		fkAuto001f Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPersonId objects.</returns>
		public TList<SaPersonId> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength,out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_001f key.
		///		FK_AUTO_001f Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPersonId objects.</returns>
		public abstract TList<SaPersonId> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0020 key.
		///		FK_AUTO_0020 Description: 
		/// </summary>
		/// <param name="_saStfMemberId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPersonId objects.</returns>
		public TList<SaPersonId> GetBySaStfMemberId(System.Decimal _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(_saStfMemberId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0020 key.
		///		FK_AUTO_0020 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPersonId objects.</returns>
		/// <remarks></remarks>
		public TList<SaPersonId> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0020 key.
		///		FK_AUTO_0020 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPersonId objects.</returns>
		public TList<SaPersonId> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0020 key.
		///		fkAuto0020 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemberId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPersonId objects.</returns>
		public TList<SaPersonId> GetBySaStfMemberId(System.Decimal _saStfMemberId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0020 key.
		///		fkAuto0020 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPersonId objects.</returns>
		public TList<SaPersonId> GetBySaStfMemberId(System.Decimal _saStfMemberId, int start, int pageLength,out int count)
		{
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0020 key.
		///		FK_AUTO_0020 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPersonId objects.</returns>
		public abstract TList<SaPersonId> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PERSON_ID_GS_CODE_IDENT_KIND key.
		///		FK_SA_PERSON_ID_GS_CODE_IDENT_KIND Description: 
		/// </summary>
		/// <param name="_gsCodeIdentKindId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPersonId objects.</returns>
		public TList<SaPersonId> GetByGsCodeIdentKindId(System.Decimal _gsCodeIdentKindId)
		{
			int count = -1;
			return GetByGsCodeIdentKindId(_gsCodeIdentKindId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PERSON_ID_GS_CODE_IDENT_KIND key.
		///		FK_SA_PERSON_ID_GS_CODE_IDENT_KIND Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeIdentKindId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPersonId objects.</returns>
		/// <remarks></remarks>
		public TList<SaPersonId> GetByGsCodeIdentKindId(TransactionManager transactionManager, System.Decimal _gsCodeIdentKindId)
		{
			int count = -1;
			return GetByGsCodeIdentKindId(transactionManager, _gsCodeIdentKindId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PERSON_ID_GS_CODE_IDENT_KIND key.
		///		FK_SA_PERSON_ID_GS_CODE_IDENT_KIND Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeIdentKindId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPersonId objects.</returns>
		public TList<SaPersonId> GetByGsCodeIdentKindId(TransactionManager transactionManager, System.Decimal _gsCodeIdentKindId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeIdentKindId(transactionManager, _gsCodeIdentKindId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PERSON_ID_GS_CODE_IDENT_KIND key.
		///		fkSaPersonIdGsCodeIdentKind Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeIdentKindId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPersonId objects.</returns>
		public TList<SaPersonId> GetByGsCodeIdentKindId(System.Decimal _gsCodeIdentKindId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodeIdentKindId(null, _gsCodeIdentKindId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PERSON_ID_GS_CODE_IDENT_KIND key.
		///		fkSaPersonIdGsCodeIdentKind Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeIdentKindId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPersonId objects.</returns>
		public TList<SaPersonId> GetByGsCodeIdentKindId(System.Decimal _gsCodeIdentKindId, int start, int pageLength,out int count)
		{
			return GetByGsCodeIdentKindId(null, _gsCodeIdentKindId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PERSON_ID_GS_CODE_IDENT_KIND key.
		///		FK_SA_PERSON_ID_GS_CODE_IDENT_KIND Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeIdentKindId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPersonId objects.</returns>
		public abstract TList<SaPersonId> GetByGsCodeIdentKindId(TransactionManager transactionManager, System.Decimal _gsCodeIdentKindId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SaPersonId Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaPersonIdKey key, int start, int pageLength)
		{
			return GetBySaPersonId(transactionManager, key.SaPersonId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SA_PERSON_ID index.
		/// </summary>
		/// <param name="_saPersonId">XXX</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaPersonId"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaPersonId GetBySaPersonId(System.Decimal _saPersonId)
		{
			int count = -1;
			return GetBySaPersonId(null,_saPersonId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_PERSON_ID index.
		/// </summary>
		/// <param name="_saPersonId">XXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaPersonId"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaPersonId GetBySaPersonId(System.Decimal _saPersonId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaPersonId(null, _saPersonId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_PERSON_ID index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saPersonId">XXX</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaPersonId"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaPersonId GetBySaPersonId(TransactionManager transactionManager, System.Decimal _saPersonId)
		{
			int count = -1;
			return GetBySaPersonId(transactionManager, _saPersonId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_PERSON_ID index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saPersonId">XXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaPersonId"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaPersonId GetBySaPersonId(TransactionManager transactionManager, System.Decimal _saPersonId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaPersonId(transactionManager, _saPersonId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_PERSON_ID index.
		/// </summary>
		/// <param name="_saPersonId">XXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaPersonId"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaPersonId GetBySaPersonId(System.Decimal _saPersonId, int start, int pageLength, out int count)
		{
			return GetBySaPersonId(null, _saPersonId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_PERSON_ID index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saPersonId">XXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaPersonId"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SaPersonId GetBySaPersonId(TransactionManager transactionManager, System.Decimal _saPersonId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SaPersonId&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SaPersonId&gt;"/></returns>
		public static TList<SaPersonId> Fill(IDataReader reader, TList<SaPersonId> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SaPersonId c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SaPersonId")
					.Append("|").Append((System.Decimal)reader["SA_PERSON_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SaPersonId>(
					key.ToString(), // EntityTrackingKey
					"SaPersonId",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SaPersonId();
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
					c.SaPersonId = (System.Decimal)reader["SA_PERSON_ID"];
					c.OriginalSaPersonId = c.SaPersonId;
					c.IdNum = (System.String)reader["ID_NUM"];
					c.IdIssueDate = (System.DateTime)reader["ID_ISSUE_DATE"];
					c.IdExpDate = Convert.IsDBNull(reader["ID_EXP_DATE"]) ? null : (System.DateTime?)reader["ID_EXP_DATE"];
					c.SaStfMemberId = (System.Decimal)reader["SA_STF_MEMBER_ID"];
					c.GsCodeIdentKindId = (System.Decimal)reader["GS_CODE_IDENT_KIND_ID"];
					c.GsCountryNodeId = (System.Decimal)reader["GS_COUNTRY_NODE_ID"];
					c.AsFacultyInfoId = (System.Decimal)reader["AS_FACULTY_INFO_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaPersonId"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaPersonId"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SaPersonId entity)
		{
			if (!reader.Read()) return;
			
			entity.SaPersonId = (System.Decimal)reader[((int)SaPersonIdColumn.SaPersonId - 1)];
			entity.OriginalSaPersonId = (System.Decimal)reader["SA_PERSON_ID"];
			entity.IdNum = (System.String)reader[((int)SaPersonIdColumn.IdNum - 1)];
			entity.IdIssueDate = (System.DateTime)reader[((int)SaPersonIdColumn.IdIssueDate - 1)];
			entity.IdExpDate = (reader.IsDBNull(((int)SaPersonIdColumn.IdExpDate - 1)))?null:(System.DateTime?)reader[((int)SaPersonIdColumn.IdExpDate - 1)];
			entity.SaStfMemberId = (System.Decimal)reader[((int)SaPersonIdColumn.SaStfMemberId - 1)];
			entity.GsCodeIdentKindId = (System.Decimal)reader[((int)SaPersonIdColumn.GsCodeIdentKindId - 1)];
			entity.GsCountryNodeId = (System.Decimal)reader[((int)SaPersonIdColumn.GsCountryNodeId - 1)];
			entity.AsFacultyInfoId = (System.Decimal)reader[((int)SaPersonIdColumn.AsFacultyInfoId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaPersonId"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaPersonId"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SaPersonId entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SaPersonId = (System.Decimal)dataRow["SA_PERSON_ID"];
			entity.OriginalSaPersonId = (System.Decimal)dataRow["SA_PERSON_ID"];
			entity.IdNum = (System.String)dataRow["ID_NUM"];
			entity.IdIssueDate = (System.DateTime)dataRow["ID_ISSUE_DATE"];
			entity.IdExpDate = Convert.IsDBNull(dataRow["ID_EXP_DATE"]) ? null : (System.DateTime?)dataRow["ID_EXP_DATE"];
			entity.SaStfMemberId = (System.Decimal)dataRow["SA_STF_MEMBER_ID"];
			entity.GsCodeIdentKindId = (System.Decimal)dataRow["GS_CODE_IDENT_KIND_ID"];
			entity.GsCountryNodeId = (System.Decimal)dataRow["GS_COUNTRY_NODE_ID"];
			entity.AsFacultyInfoId = (System.Decimal)dataRow["AS_FACULTY_INFO_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaPersonId"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaPersonId Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaPersonId entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

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

			#region GsCodeIdentKindIdSource	
			if (CanDeepLoad(entity, "GsCodeIdentKind|GsCodeIdentKindIdSource", deepLoadType, innerList) 
				&& entity.GsCodeIdentKindIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.GsCodeIdentKindId;
				GsCodeIdentKind tmpEntity = EntityManager.LocateEntity<GsCodeIdentKind>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodeIdentKind), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodeIdentKindIdSource = tmpEntity;
				else
					entity.GsCodeIdentKindIdSource = DataRepository.GsCodeIdentKindProvider.GetByGsCodeIdentKindId(transactionManager, entity.GsCodeIdentKindId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodeIdentKindIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCodeIdentKindIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodeIdentKindProvider.DeepLoad(transactionManager, entity.GsCodeIdentKindIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCodeIdentKindIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SaPersonId object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SaPersonId instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaPersonId Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaPersonId entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AsFacultyInfoIdSource
			if (CanDeepSave(entity, "AsFacultyInfo|AsFacultyInfoIdSource", deepSaveType, innerList) 
				&& entity.AsFacultyInfoIdSource != null)
			{
				DataRepository.AsFacultyInfoProvider.Save(transactionManager, entity.AsFacultyInfoIdSource);
				entity.AsFacultyInfoId = entity.AsFacultyInfoIdSource.AsFacultyInfoId;
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
			
			#region GsCodeIdentKindIdSource
			if (CanDeepSave(entity, "GsCodeIdentKind|GsCodeIdentKindIdSource", deepSaveType, innerList) 
				&& entity.GsCodeIdentKindIdSource != null)
			{
				DataRepository.GsCodeIdentKindProvider.Save(transactionManager, entity.GsCodeIdentKindIdSource);
				entity.GsCodeIdentKindId = entity.GsCodeIdentKindIdSource.GsCodeIdentKindId;
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
	
	#region SaPersonIdChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SaPersonId</c>
	///</summary>
	public enum SaPersonIdChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AsFacultyInfo</c> at AsFacultyInfoIdSource
		///</summary>
		[ChildEntityType(typeof(AsFacultyInfo))]
		AsFacultyInfo,
		
		///<summary>
		/// Composite Property for <c>SaStfMember</c> at SaStfMemberIdSource
		///</summary>
		[ChildEntityType(typeof(SaStfMember))]
		SaStfMember,
		
		///<summary>
		/// Composite Property for <c>GsCodeIdentKind</c> at GsCodeIdentKindIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeIdentKind))]
		GsCodeIdentKind,
	}
	
	#endregion SaPersonIdChildEntityTypes
	
	#region SaPersonIdFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SaPersonIdColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaPersonId"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaPersonIdFilterBuilder : SqlFilterBuilder<SaPersonIdColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaPersonIdFilterBuilder class.
		/// </summary>
		public SaPersonIdFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaPersonIdFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaPersonIdFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaPersonIdFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaPersonIdFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaPersonIdFilterBuilder
	
	#region SaPersonIdParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SaPersonIdColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaPersonId"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaPersonIdParameterBuilder : ParameterizedSqlFilterBuilder<SaPersonIdColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaPersonIdParameterBuilder class.
		/// </summary>
		public SaPersonIdParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaPersonIdParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaPersonIdParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaPersonIdParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaPersonIdParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaPersonIdParameterBuilder
	
	#region SaPersonIdSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SaPersonIdColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaPersonId"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SaPersonIdSortBuilder : SqlSortBuilder<SaPersonIdColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaPersonIdSqlSortBuilder class.
		/// </summary>
		public SaPersonIdSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SaPersonIdSortBuilder
	
} // end namespace
