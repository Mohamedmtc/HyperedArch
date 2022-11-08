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
	/// This class is the base class for any <see cref="SaPromotionRequestProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SaPromotionRequestProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SaPromotionRequest, UMIS_VER2.BusinessLyer.SaPromotionRequestKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaPromotionRequestKey key)
		{
			return Delete(transactionManager, key.SaPromotionRequestId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_saPromotionRequestId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _saPromotionRequestId)
		{
			return Delete(null, _saPromotionRequestId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saPromotionRequestId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _saPromotionRequestId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_048a key.
		///		FK_AUTO_048a Description: 
		/// </summary>
		/// <param name="_saCodeScDegId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPromotionRequest objects.</returns>
		public TList<SaPromotionRequest> GetBySaCodeScDegId(System.Decimal _saCodeScDegId)
		{
			int count = -1;
			return GetBySaCodeScDegId(_saCodeScDegId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_048a key.
		///		FK_AUTO_048a Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeScDegId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPromotionRequest objects.</returns>
		/// <remarks></remarks>
		public TList<SaPromotionRequest> GetBySaCodeScDegId(TransactionManager transactionManager, System.Decimal _saCodeScDegId)
		{
			int count = -1;
			return GetBySaCodeScDegId(transactionManager, _saCodeScDegId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_048a key.
		///		FK_AUTO_048a Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeScDegId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPromotionRequest objects.</returns>
		public TList<SaPromotionRequest> GetBySaCodeScDegId(TransactionManager transactionManager, System.Decimal _saCodeScDegId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeScDegId(transactionManager, _saCodeScDegId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_048a key.
		///		fkAuto048a Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saCodeScDegId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPromotionRequest objects.</returns>
		public TList<SaPromotionRequest> GetBySaCodeScDegId(System.Decimal _saCodeScDegId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaCodeScDegId(null, _saCodeScDegId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_048a key.
		///		fkAuto048a Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saCodeScDegId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPromotionRequest objects.</returns>
		public TList<SaPromotionRequest> GetBySaCodeScDegId(System.Decimal _saCodeScDegId, int start, int pageLength,out int count)
		{
			return GetBySaCodeScDegId(null, _saCodeScDegId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_048a key.
		///		FK_AUTO_048a Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeScDegId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPromotionRequest objects.</returns>
		public abstract TList<SaPromotionRequest> GetBySaCodeScDegId(TransactionManager transactionManager, System.Decimal _saCodeScDegId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PROMOTION_REQUEST_AS_FACULTY_INFO key.
		///		FK_SA_PROMOTION_REQUEST_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPromotionRequest objects.</returns>
		public TList<SaPromotionRequest> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(_asFacultyInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PROMOTION_REQUEST_AS_FACULTY_INFO key.
		///		FK_SA_PROMOTION_REQUEST_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPromotionRequest objects.</returns>
		/// <remarks></remarks>
		public TList<SaPromotionRequest> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PROMOTION_REQUEST_AS_FACULTY_INFO key.
		///		FK_SA_PROMOTION_REQUEST_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPromotionRequest objects.</returns>
		public TList<SaPromotionRequest> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PROMOTION_REQUEST_AS_FACULTY_INFO key.
		///		fkSaPromotionRequestAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPromotionRequest objects.</returns>
		public TList<SaPromotionRequest> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PROMOTION_REQUEST_AS_FACULTY_INFO key.
		///		fkSaPromotionRequestAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPromotionRequest objects.</returns>
		public TList<SaPromotionRequest> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength,out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PROMOTION_REQUEST_AS_FACULTY_INFO key.
		///		FK_SA_PROMOTION_REQUEST_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPromotionRequest objects.</returns>
		public abstract TList<SaPromotionRequest> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PROMOTION_REQUEST_SA_STF_MEMBER key.
		///		FK_SA_PROMOTION_REQUEST_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="_saStfMemberId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPromotionRequest objects.</returns>
		public TList<SaPromotionRequest> GetBySaStfMemberId(System.Decimal _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(_saStfMemberId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PROMOTION_REQUEST_SA_STF_MEMBER key.
		///		FK_SA_PROMOTION_REQUEST_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPromotionRequest objects.</returns>
		/// <remarks></remarks>
		public TList<SaPromotionRequest> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PROMOTION_REQUEST_SA_STF_MEMBER key.
		///		FK_SA_PROMOTION_REQUEST_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPromotionRequest objects.</returns>
		public TList<SaPromotionRequest> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PROMOTION_REQUEST_SA_STF_MEMBER key.
		///		fkSaPromotionRequestSaStfMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemberId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPromotionRequest objects.</returns>
		public TList<SaPromotionRequest> GetBySaStfMemberId(System.Decimal _saStfMemberId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PROMOTION_REQUEST_SA_STF_MEMBER key.
		///		fkSaPromotionRequestSaStfMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPromotionRequest objects.</returns>
		public TList<SaPromotionRequest> GetBySaStfMemberId(System.Decimal _saStfMemberId, int start, int pageLength,out int count)
		{
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PROMOTION_REQUEST_SA_STF_MEMBER key.
		///		FK_SA_PROMOTION_REQUEST_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPromotionRequest objects.</returns>
		public abstract TList<SaPromotionRequest> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SaPromotionRequest Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaPromotionRequestKey key, int start, int pageLength)
		{
			return GetBySaPromotionRequestId(transactionManager, key.SaPromotionRequestId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SA_PROMOTION_REQUEST index.
		/// </summary>
		/// <param name="_saPromotionRequestId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaPromotionRequest"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaPromotionRequest GetBySaPromotionRequestId(System.Decimal _saPromotionRequestId)
		{
			int count = -1;
			return GetBySaPromotionRequestId(null,_saPromotionRequestId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_PROMOTION_REQUEST index.
		/// </summary>
		/// <param name="_saPromotionRequestId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaPromotionRequest"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaPromotionRequest GetBySaPromotionRequestId(System.Decimal _saPromotionRequestId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaPromotionRequestId(null, _saPromotionRequestId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_PROMOTION_REQUEST index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saPromotionRequestId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaPromotionRequest"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaPromotionRequest GetBySaPromotionRequestId(TransactionManager transactionManager, System.Decimal _saPromotionRequestId)
		{
			int count = -1;
			return GetBySaPromotionRequestId(transactionManager, _saPromotionRequestId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_PROMOTION_REQUEST index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saPromotionRequestId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaPromotionRequest"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaPromotionRequest GetBySaPromotionRequestId(TransactionManager transactionManager, System.Decimal _saPromotionRequestId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaPromotionRequestId(transactionManager, _saPromotionRequestId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_PROMOTION_REQUEST index.
		/// </summary>
		/// <param name="_saPromotionRequestId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaPromotionRequest"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaPromotionRequest GetBySaPromotionRequestId(System.Decimal _saPromotionRequestId, int start, int pageLength, out int count)
		{
			return GetBySaPromotionRequestId(null, _saPromotionRequestId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_PROMOTION_REQUEST index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saPromotionRequestId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaPromotionRequest"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SaPromotionRequest GetBySaPromotionRequestId(TransactionManager transactionManager, System.Decimal _saPromotionRequestId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SaPromotionRequest&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SaPromotionRequest&gt;"/></returns>
		public static TList<SaPromotionRequest> Fill(IDataReader reader, TList<SaPromotionRequest> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SaPromotionRequest c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SaPromotionRequest")
					.Append("|").Append((System.Decimal)reader["SA_PROMOTION_REQUEST_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SaPromotionRequest>(
					key.ToString(), // EntityTrackingKey
					"SaPromotionRequest",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SaPromotionRequest();
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
					c.SaPromotionRequestId = (System.Decimal)reader["SA_PROMOTION_REQUEST_ID"];
					c.OriginalSaPromotionRequestId = c.SaPromotionRequestId;
					c.RequestDate = (System.DateTime)reader["REQUEST_DATE"];
					c.ResearchNum = Convert.IsDBNull(reader["RESEARCH_NUM"]) ? null : (System.Decimal?)reader["RESEARCH_NUM"];
					c.Comments = Convert.IsDBNull(reader["COMMENTS"]) ? null : (System.String)reader["COMMENTS"];
					c.SaCodeScDegId = (System.Decimal)reader["SA_CODE_SC_DEG_ID"];
					c.SaStfMemberId = (System.Decimal)reader["SA_STF_MEMBER_ID"];
					c.AsFacultyInfoId = (System.Decimal)reader["AS_FACULTY_INFO_ID"];
					c.RequestStatus = (System.Decimal)reader["REQUEST_STATUS"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaPromotionRequest"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaPromotionRequest"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SaPromotionRequest entity)
		{
			if (!reader.Read()) return;
			
			entity.SaPromotionRequestId = (System.Decimal)reader[((int)SaPromotionRequestColumn.SaPromotionRequestId - 1)];
			entity.OriginalSaPromotionRequestId = (System.Decimal)reader["SA_PROMOTION_REQUEST_ID"];
			entity.RequestDate = (System.DateTime)reader[((int)SaPromotionRequestColumn.RequestDate - 1)];
			entity.ResearchNum = (reader.IsDBNull(((int)SaPromotionRequestColumn.ResearchNum - 1)))?null:(System.Decimal?)reader[((int)SaPromotionRequestColumn.ResearchNum - 1)];
			entity.Comments = (reader.IsDBNull(((int)SaPromotionRequestColumn.Comments - 1)))?null:(System.String)reader[((int)SaPromotionRequestColumn.Comments - 1)];
			entity.SaCodeScDegId = (System.Decimal)reader[((int)SaPromotionRequestColumn.SaCodeScDegId - 1)];
			entity.SaStfMemberId = (System.Decimal)reader[((int)SaPromotionRequestColumn.SaStfMemberId - 1)];
			entity.AsFacultyInfoId = (System.Decimal)reader[((int)SaPromotionRequestColumn.AsFacultyInfoId - 1)];
			entity.RequestStatus = (System.Decimal)reader[((int)SaPromotionRequestColumn.RequestStatus - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaPromotionRequest"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaPromotionRequest"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SaPromotionRequest entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SaPromotionRequestId = (System.Decimal)dataRow["SA_PROMOTION_REQUEST_ID"];
			entity.OriginalSaPromotionRequestId = (System.Decimal)dataRow["SA_PROMOTION_REQUEST_ID"];
			entity.RequestDate = (System.DateTime)dataRow["REQUEST_DATE"];
			entity.ResearchNum = Convert.IsDBNull(dataRow["RESEARCH_NUM"]) ? null : (System.Decimal?)dataRow["RESEARCH_NUM"];
			entity.Comments = Convert.IsDBNull(dataRow["COMMENTS"]) ? null : (System.String)dataRow["COMMENTS"];
			entity.SaCodeScDegId = (System.Decimal)dataRow["SA_CODE_SC_DEG_ID"];
			entity.SaStfMemberId = (System.Decimal)dataRow["SA_STF_MEMBER_ID"];
			entity.AsFacultyInfoId = (System.Decimal)dataRow["AS_FACULTY_INFO_ID"];
			entity.RequestStatus = (System.Decimal)dataRow["REQUEST_STATUS"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaPromotionRequest"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaPromotionRequest Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaPromotionRequest entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region SaCodeScDegIdSource	
			if (CanDeepLoad(entity, "SaCodeScDeg|SaCodeScDegIdSource", deepLoadType, innerList) 
				&& entity.SaCodeScDegIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SaCodeScDegId;
				SaCodeScDeg tmpEntity = EntityManager.LocateEntity<SaCodeScDeg>(EntityLocator.ConstructKeyFromPkItems(typeof(SaCodeScDeg), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaCodeScDegIdSource = tmpEntity;
				else
					entity.SaCodeScDegIdSource = DataRepository.SaCodeScDegProvider.GetBySaCodeScDegId(transactionManager, entity.SaCodeScDegId);		
				
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
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetBySaPromotionRequestId methods when available
			
			#region SaScCommDecisionCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaScCommDecision>|SaScCommDecisionCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaScCommDecisionCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaScCommDecisionCollection = DataRepository.SaScCommDecisionProvider.GetBySaPromotionRequestId(transactionManager, entity.SaPromotionRequestId);

				if (deep && entity.SaScCommDecisionCollection.Count > 0)
				{
					deepHandles.Add("SaScCommDecisionCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaScCommDecision>) DataRepository.SaScCommDecisionProvider.DeepLoad,
						new object[] { transactionManager, entity.SaScCommDecisionCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaScResearchCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaScResearch>|SaScResearchCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaScResearchCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaScResearchCollection = DataRepository.SaScResearchProvider.GetBySaPromotionRequestId(transactionManager, entity.SaPromotionRequestId);

				if (deep && entity.SaScResearchCollection.Count > 0)
				{
					deepHandles.Add("SaScResearchCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaScResearch>) DataRepository.SaScResearchProvider.DeepLoad,
						new object[] { transactionManager, entity.SaScResearchCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaPromotionCondStsfCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaPromotionCondStsf>|SaPromotionCondStsfCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaPromotionCondStsfCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaPromotionCondStsfCollection = DataRepository.SaPromotionCondStsfProvider.GetBySaPromotionRequestId(transactionManager, entity.SaPromotionRequestId);

				if (deep && entity.SaPromotionCondStsfCollection.Count > 0)
				{
					deepHandles.Add("SaPromotionCondStsfCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaPromotionCondStsf>) DataRepository.SaPromotionCondStsfProvider.DeepLoad,
						new object[] { transactionManager, entity.SaPromotionCondStsfCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SaPromotionRequest object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SaPromotionRequest instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaPromotionRequest Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaPromotionRequest entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<SaScCommDecision>
				if (CanDeepSave(entity.SaScCommDecisionCollection, "List<SaScCommDecision>|SaScCommDecisionCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaScCommDecision child in entity.SaScCommDecisionCollection)
					{
						if(child.SaPromotionRequestIdSource != null)
						{
							child.SaPromotionRequestId = child.SaPromotionRequestIdSource.SaPromotionRequestId;
						}
						else
						{
							child.SaPromotionRequestId = entity.SaPromotionRequestId;
						}

					}

					if (entity.SaScCommDecisionCollection.Count > 0 || entity.SaScCommDecisionCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaScCommDecisionProvider.Save(transactionManager, entity.SaScCommDecisionCollection);
						
						deepHandles.Add("SaScCommDecisionCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaScCommDecision >) DataRepository.SaScCommDecisionProvider.DeepSave,
							new object[] { transactionManager, entity.SaScCommDecisionCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaScResearch>
				if (CanDeepSave(entity.SaScResearchCollection, "List<SaScResearch>|SaScResearchCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaScResearch child in entity.SaScResearchCollection)
					{
						if(child.SaPromotionRequestIdSource != null)
						{
							child.SaPromotionRequestId = child.SaPromotionRequestIdSource.SaPromotionRequestId;
						}
						else
						{
							child.SaPromotionRequestId = entity.SaPromotionRequestId;
						}

					}

					if (entity.SaScResearchCollection.Count > 0 || entity.SaScResearchCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaScResearchProvider.Save(transactionManager, entity.SaScResearchCollection);
						
						deepHandles.Add("SaScResearchCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaScResearch >) DataRepository.SaScResearchProvider.DeepSave,
							new object[] { transactionManager, entity.SaScResearchCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaPromotionCondStsf>
				if (CanDeepSave(entity.SaPromotionCondStsfCollection, "List<SaPromotionCondStsf>|SaPromotionCondStsfCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaPromotionCondStsf child in entity.SaPromotionCondStsfCollection)
					{
						if(child.SaPromotionRequestIdSource != null)
						{
							child.SaPromotionRequestId = child.SaPromotionRequestIdSource.SaPromotionRequestId;
						}
						else
						{
							child.SaPromotionRequestId = entity.SaPromotionRequestId;
						}

					}

					if (entity.SaPromotionCondStsfCollection.Count > 0 || entity.SaPromotionCondStsfCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaPromotionCondStsfProvider.Save(transactionManager, entity.SaPromotionCondStsfCollection);
						
						deepHandles.Add("SaPromotionCondStsfCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaPromotionCondStsf >) DataRepository.SaPromotionCondStsfProvider.DeepSave,
							new object[] { transactionManager, entity.SaPromotionCondStsfCollection, deepSaveType, childTypes, innerList }
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
	
	#region SaPromotionRequestChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SaPromotionRequest</c>
	///</summary>
	public enum SaPromotionRequestChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>SaCodeScDeg</c> at SaCodeScDegIdSource
		///</summary>
		[ChildEntityType(typeof(SaCodeScDeg))]
		SaCodeScDeg,
		
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
		/// Collection of <c>SaPromotionRequest</c> as OneToMany for SaScCommDecisionCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaScCommDecision>))]
		SaScCommDecisionCollection,
		///<summary>
		/// Collection of <c>SaPromotionRequest</c> as OneToMany for SaScResearchCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaScResearch>))]
		SaScResearchCollection,
		///<summary>
		/// Collection of <c>SaPromotionRequest</c> as OneToMany for SaPromotionCondStsfCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaPromotionCondStsf>))]
		SaPromotionCondStsfCollection,
	}
	
	#endregion SaPromotionRequestChildEntityTypes
	
	#region SaPromotionRequestFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SaPromotionRequestColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaPromotionRequest"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaPromotionRequestFilterBuilder : SqlFilterBuilder<SaPromotionRequestColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaPromotionRequestFilterBuilder class.
		/// </summary>
		public SaPromotionRequestFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaPromotionRequestFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaPromotionRequestFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaPromotionRequestFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaPromotionRequestFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaPromotionRequestFilterBuilder
	
	#region SaPromotionRequestParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SaPromotionRequestColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaPromotionRequest"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaPromotionRequestParameterBuilder : ParameterizedSqlFilterBuilder<SaPromotionRequestColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaPromotionRequestParameterBuilder class.
		/// </summary>
		public SaPromotionRequestParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaPromotionRequestParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaPromotionRequestParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaPromotionRequestParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaPromotionRequestParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaPromotionRequestParameterBuilder
	
	#region SaPromotionRequestSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SaPromotionRequestColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaPromotionRequest"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SaPromotionRequestSortBuilder : SqlSortBuilder<SaPromotionRequestColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaPromotionRequestSqlSortBuilder class.
		/// </summary>
		public SaPromotionRequestSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SaPromotionRequestSortBuilder
	
} // end namespace
