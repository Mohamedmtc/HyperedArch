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
	/// This class is the base class for any <see cref="SaJobStartStatmentProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SaJobStartStatmentProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SaJobStartStatment, UMIS_VER2.BusinessLyer.SaJobStartStatmentKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaJobStartStatmentKey key)
		{
			return Delete(transactionManager, key.SaJobStartStatmentId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_saJobStartStatmentId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _saJobStartStatmentId)
		{
			return Delete(null, _saJobStartStatmentId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saJobStartStatmentId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _saJobStartStatmentId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0019 key.
		///		FK_AUTO_0019 Description: 
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaJobStartStatment objects.</returns>
		public TList<SaJobStartStatment> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(_asFacultyInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0019 key.
		///		FK_AUTO_0019 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaJobStartStatment objects.</returns>
		/// <remarks></remarks>
		public TList<SaJobStartStatment> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0019 key.
		///		FK_AUTO_0019 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaJobStartStatment objects.</returns>
		public TList<SaJobStartStatment> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0019 key.
		///		fkAuto0019 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaJobStartStatment objects.</returns>
		public TList<SaJobStartStatment> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0019 key.
		///		fkAuto0019 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaJobStartStatment objects.</returns>
		public TList<SaJobStartStatment> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength,out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0019 key.
		///		FK_AUTO_0019 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaJobStartStatment objects.</returns>
		public abstract TList<SaJobStartStatment> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_001a key.
		///		FK_AUTO_001a Description: 
		/// </summary>
		/// <param name="_saStfMemberId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaJobStartStatment objects.</returns>
		public TList<SaJobStartStatment> GetBySaStfMemberId(System.Decimal _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(_saStfMemberId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_001a key.
		///		FK_AUTO_001a Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaJobStartStatment objects.</returns>
		/// <remarks></remarks>
		public TList<SaJobStartStatment> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_001a key.
		///		FK_AUTO_001a Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaJobStartStatment objects.</returns>
		public TList<SaJobStartStatment> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_001a key.
		///		fkAuto001a Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemberId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaJobStartStatment objects.</returns>
		public TList<SaJobStartStatment> GetBySaStfMemberId(System.Decimal _saStfMemberId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_001a key.
		///		fkAuto001a Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaJobStartStatment objects.</returns>
		public TList<SaJobStartStatment> GetBySaStfMemberId(System.Decimal _saStfMemberId, int start, int pageLength,out int count)
		{
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_001a key.
		///		FK_AUTO_001a Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaJobStartStatment objects.</returns>
		public abstract TList<SaJobStartStatment> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_JOB_START_STATMENT_SA_CODE_SUMMERY key.
		///		FK_SA_JOB_START_STATMENT_SA_CODE_SUMMERY Description: 
		/// </summary>
		/// <param name="_saCodeSummeryId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaJobStartStatment objects.</returns>
		public TList<SaJobStartStatment> GetBySaCodeSummeryId(System.Decimal _saCodeSummeryId)
		{
			int count = -1;
			return GetBySaCodeSummeryId(_saCodeSummeryId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_JOB_START_STATMENT_SA_CODE_SUMMERY key.
		///		FK_SA_JOB_START_STATMENT_SA_CODE_SUMMERY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeSummeryId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaJobStartStatment objects.</returns>
		/// <remarks></remarks>
		public TList<SaJobStartStatment> GetBySaCodeSummeryId(TransactionManager transactionManager, System.Decimal _saCodeSummeryId)
		{
			int count = -1;
			return GetBySaCodeSummeryId(transactionManager, _saCodeSummeryId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_JOB_START_STATMENT_SA_CODE_SUMMERY key.
		///		FK_SA_JOB_START_STATMENT_SA_CODE_SUMMERY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeSummeryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaJobStartStatment objects.</returns>
		public TList<SaJobStartStatment> GetBySaCodeSummeryId(TransactionManager transactionManager, System.Decimal _saCodeSummeryId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeSummeryId(transactionManager, _saCodeSummeryId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_JOB_START_STATMENT_SA_CODE_SUMMERY key.
		///		fkSaJobStartStatmentSaCodeSummery Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saCodeSummeryId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaJobStartStatment objects.</returns>
		public TList<SaJobStartStatment> GetBySaCodeSummeryId(System.Decimal _saCodeSummeryId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaCodeSummeryId(null, _saCodeSummeryId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_JOB_START_STATMENT_SA_CODE_SUMMERY key.
		///		fkSaJobStartStatmentSaCodeSummery Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saCodeSummeryId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaJobStartStatment objects.</returns>
		public TList<SaJobStartStatment> GetBySaCodeSummeryId(System.Decimal _saCodeSummeryId, int start, int pageLength,out int count)
		{
			return GetBySaCodeSummeryId(null, _saCodeSummeryId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_JOB_START_STATMENT_SA_CODE_SUMMERY key.
		///		FK_SA_JOB_START_STATMENT_SA_CODE_SUMMERY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeSummeryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaJobStartStatment objects.</returns>
		public abstract TList<SaJobStartStatment> GetBySaCodeSummeryId(TransactionManager transactionManager, System.Decimal _saCodeSummeryId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SaJobStartStatment Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaJobStartStatmentKey key, int start, int pageLength)
		{
			return GetBySaJobStartStatmentId(transactionManager, key.SaJobStartStatmentId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SA_JOB_START_STATMENT index.
		/// </summary>
		/// <param name="_saJobStartStatmentId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaJobStartStatment"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaJobStartStatment GetBySaJobStartStatmentId(System.Decimal _saJobStartStatmentId)
		{
			int count = -1;
			return GetBySaJobStartStatmentId(null,_saJobStartStatmentId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_JOB_START_STATMENT index.
		/// </summary>
		/// <param name="_saJobStartStatmentId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaJobStartStatment"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaJobStartStatment GetBySaJobStartStatmentId(System.Decimal _saJobStartStatmentId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaJobStartStatmentId(null, _saJobStartStatmentId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_JOB_START_STATMENT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saJobStartStatmentId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaJobStartStatment"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaJobStartStatment GetBySaJobStartStatmentId(TransactionManager transactionManager, System.Decimal _saJobStartStatmentId)
		{
			int count = -1;
			return GetBySaJobStartStatmentId(transactionManager, _saJobStartStatmentId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_JOB_START_STATMENT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saJobStartStatmentId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaJobStartStatment"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaJobStartStatment GetBySaJobStartStatmentId(TransactionManager transactionManager, System.Decimal _saJobStartStatmentId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaJobStartStatmentId(transactionManager, _saJobStartStatmentId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_JOB_START_STATMENT index.
		/// </summary>
		/// <param name="_saJobStartStatmentId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaJobStartStatment"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaJobStartStatment GetBySaJobStartStatmentId(System.Decimal _saJobStartStatmentId, int start, int pageLength, out int count)
		{
			return GetBySaJobStartStatmentId(null, _saJobStartStatmentId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_JOB_START_STATMENT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saJobStartStatmentId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaJobStartStatment"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SaJobStartStatment GetBySaJobStartStatmentId(TransactionManager transactionManager, System.Decimal _saJobStartStatmentId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SaJobStartStatment&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SaJobStartStatment&gt;"/></returns>
		public static TList<SaJobStartStatment> Fill(IDataReader reader, TList<SaJobStartStatment> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SaJobStartStatment c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SaJobStartStatment")
					.Append("|").Append((System.Decimal)reader["SA_JOB_START_STATMENT_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SaJobStartStatment>(
					key.ToString(), // EntityTrackingKey
					"SaJobStartStatment",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SaJobStartStatment();
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
					c.SaJobStartStatmentId = (System.Decimal)reader["SA_JOB_START_STATMENT_ID"];
					c.OriginalSaJobStartStatmentId = c.SaJobStartStatmentId;
					c.JobStartDecisionNum = (System.String)reader["JOB_START_DECISION_NUM"];
					c.JobStartDecisionDate = (System.DateTime)reader["JOB_START_DECISION_DATE"];
					c.JobStartFrom = (System.DateTime)reader["JOB_START_FROM"];
					c.JobReturnReason = Convert.IsDBNull(reader["JOB_RETURN_REASON"]) ? null : (System.String)reader["JOB_RETURN_REASON"];
					c.Comments = Convert.IsDBNull(reader["COMMENTS"]) ? null : (System.String)reader["COMMENTS"];
					c.AffectsStaffState = (System.Decimal)reader["AFFECTS_STAFF_STATE"];
					c.SaCodeSummeryId = (System.Decimal)reader["SA_CODE_SUMMERY_ID"];
					c.SaStfMemberId = (System.Decimal)reader["SA_STF_MEMBER_ID"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaJobStartStatment"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaJobStartStatment"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SaJobStartStatment entity)
		{
			if (!reader.Read()) return;
			
			entity.SaJobStartStatmentId = (System.Decimal)reader[((int)SaJobStartStatmentColumn.SaJobStartStatmentId - 1)];
			entity.OriginalSaJobStartStatmentId = (System.Decimal)reader["SA_JOB_START_STATMENT_ID"];
			entity.JobStartDecisionNum = (System.String)reader[((int)SaJobStartStatmentColumn.JobStartDecisionNum - 1)];
			entity.JobStartDecisionDate = (System.DateTime)reader[((int)SaJobStartStatmentColumn.JobStartDecisionDate - 1)];
			entity.JobStartFrom = (System.DateTime)reader[((int)SaJobStartStatmentColumn.JobStartFrom - 1)];
			entity.JobReturnReason = (reader.IsDBNull(((int)SaJobStartStatmentColumn.JobReturnReason - 1)))?null:(System.String)reader[((int)SaJobStartStatmentColumn.JobReturnReason - 1)];
			entity.Comments = (reader.IsDBNull(((int)SaJobStartStatmentColumn.Comments - 1)))?null:(System.String)reader[((int)SaJobStartStatmentColumn.Comments - 1)];
			entity.AffectsStaffState = (System.Decimal)reader[((int)SaJobStartStatmentColumn.AffectsStaffState - 1)];
			entity.SaCodeSummeryId = (System.Decimal)reader[((int)SaJobStartStatmentColumn.SaCodeSummeryId - 1)];
			entity.SaStfMemberId = (System.Decimal)reader[((int)SaJobStartStatmentColumn.SaStfMemberId - 1)];
			entity.AsFacultyInfoId = (System.Decimal)reader[((int)SaJobStartStatmentColumn.AsFacultyInfoId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaJobStartStatment"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaJobStartStatment"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SaJobStartStatment entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SaJobStartStatmentId = (System.Decimal)dataRow["SA_JOB_START_STATMENT_ID"];
			entity.OriginalSaJobStartStatmentId = (System.Decimal)dataRow["SA_JOB_START_STATMENT_ID"];
			entity.JobStartDecisionNum = (System.String)dataRow["JOB_START_DECISION_NUM"];
			entity.JobStartDecisionDate = (System.DateTime)dataRow["JOB_START_DECISION_DATE"];
			entity.JobStartFrom = (System.DateTime)dataRow["JOB_START_FROM"];
			entity.JobReturnReason = Convert.IsDBNull(dataRow["JOB_RETURN_REASON"]) ? null : (System.String)dataRow["JOB_RETURN_REASON"];
			entity.Comments = Convert.IsDBNull(dataRow["COMMENTS"]) ? null : (System.String)dataRow["COMMENTS"];
			entity.AffectsStaffState = (System.Decimal)dataRow["AFFECTS_STAFF_STATE"];
			entity.SaCodeSummeryId = (System.Decimal)dataRow["SA_CODE_SUMMERY_ID"];
			entity.SaStfMemberId = (System.Decimal)dataRow["SA_STF_MEMBER_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaJobStartStatment"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaJobStartStatment Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaJobStartStatment entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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

			#region SaCodeSummeryIdSource	
			if (CanDeepLoad(entity, "SaCodeSummery|SaCodeSummeryIdSource", deepLoadType, innerList) 
				&& entity.SaCodeSummeryIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SaCodeSummeryId;
				SaCodeSummery tmpEntity = EntityManager.LocateEntity<SaCodeSummery>(EntityLocator.ConstructKeyFromPkItems(typeof(SaCodeSummery), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaCodeSummeryIdSource = tmpEntity;
				else
					entity.SaCodeSummeryIdSource = DataRepository.SaCodeSummeryProvider.GetBySaCodeSummeryId(transactionManager, entity.SaCodeSummeryId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaCodeSummeryIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaCodeSummeryIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaCodeSummeryProvider.DeepLoad(transactionManager, entity.SaCodeSummeryIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaCodeSummeryIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetBySaJobStartStatmentId methods when available
			
			#region SaJobStoppageCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaJobStoppage>|SaJobStoppageCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaJobStoppageCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaJobStoppageCollection = DataRepository.SaJobStoppageProvider.GetBySaJobStartStatmentId(transactionManager, entity.SaJobStartStatmentId);

				if (deep && entity.SaJobStoppageCollection.Count > 0)
				{
					deepHandles.Add("SaJobStoppageCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaJobStoppage>) DataRepository.SaJobStoppageProvider.DeepLoad,
						new object[] { transactionManager, entity.SaJobStoppageCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaVacationCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaVacation>|SaVacationCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaVacationCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaVacationCollection = DataRepository.SaVacationProvider.GetBySaJobStartStatmentId(transactionManager, entity.SaJobStartStatmentId);

				if (deep && entity.SaVacationCollection.Count > 0)
				{
					deepHandles.Add("SaVacationCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaVacation>) DataRepository.SaVacationProvider.DeepLoad,
						new object[] { transactionManager, entity.SaVacationCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaEmploymentCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaEmployment>|SaEmploymentCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaEmploymentCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaEmploymentCollection = DataRepository.SaEmploymentProvider.GetBySaJobStartStatmentId(transactionManager, entity.SaJobStartStatmentId);

				if (deep && entity.SaEmploymentCollection.Count > 0)
				{
					deepHandles.Add("SaEmploymentCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaEmployment>) DataRepository.SaEmploymentProvider.DeepLoad,
						new object[] { transactionManager, entity.SaEmploymentCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SaJobStartStatment object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SaJobStartStatment instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaJobStartStatment Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaJobStartStatment entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region SaCodeSummeryIdSource
			if (CanDeepSave(entity, "SaCodeSummery|SaCodeSummeryIdSource", deepSaveType, innerList) 
				&& entity.SaCodeSummeryIdSource != null)
			{
				DataRepository.SaCodeSummeryProvider.Save(transactionManager, entity.SaCodeSummeryIdSource);
				entity.SaCodeSummeryId = entity.SaCodeSummeryIdSource.SaCodeSummeryId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<SaJobStoppage>
				if (CanDeepSave(entity.SaJobStoppageCollection, "List<SaJobStoppage>|SaJobStoppageCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaJobStoppage child in entity.SaJobStoppageCollection)
					{
						if(child.SaJobStartStatmentIdSource != null)
						{
							child.SaJobStartStatmentId = child.SaJobStartStatmentIdSource.SaJobStartStatmentId;
						}
						else
						{
							child.SaJobStartStatmentId = entity.SaJobStartStatmentId;
						}

					}

					if (entity.SaJobStoppageCollection.Count > 0 || entity.SaJobStoppageCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaJobStoppageProvider.Save(transactionManager, entity.SaJobStoppageCollection);
						
						deepHandles.Add("SaJobStoppageCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaJobStoppage >) DataRepository.SaJobStoppageProvider.DeepSave,
							new object[] { transactionManager, entity.SaJobStoppageCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaVacation>
				if (CanDeepSave(entity.SaVacationCollection, "List<SaVacation>|SaVacationCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaVacation child in entity.SaVacationCollection)
					{
						if(child.SaJobStartStatmentIdSource != null)
						{
							child.SaJobStartStatmentId = child.SaJobStartStatmentIdSource.SaJobStartStatmentId;
						}
						else
						{
							child.SaJobStartStatmentId = entity.SaJobStartStatmentId;
						}

					}

					if (entity.SaVacationCollection.Count > 0 || entity.SaVacationCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaVacationProvider.Save(transactionManager, entity.SaVacationCollection);
						
						deepHandles.Add("SaVacationCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaVacation >) DataRepository.SaVacationProvider.DeepSave,
							new object[] { transactionManager, entity.SaVacationCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaEmployment>
				if (CanDeepSave(entity.SaEmploymentCollection, "List<SaEmployment>|SaEmploymentCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaEmployment child in entity.SaEmploymentCollection)
					{
						if(child.SaJobStartStatmentIdSource != null)
						{
							child.SaJobStartStatmentId = child.SaJobStartStatmentIdSource.SaJobStartStatmentId;
						}
						else
						{
							child.SaJobStartStatmentId = entity.SaJobStartStatmentId;
						}

					}

					if (entity.SaEmploymentCollection.Count > 0 || entity.SaEmploymentCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaEmploymentProvider.Save(transactionManager, entity.SaEmploymentCollection);
						
						deepHandles.Add("SaEmploymentCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaEmployment >) DataRepository.SaEmploymentProvider.DeepSave,
							new object[] { transactionManager, entity.SaEmploymentCollection, deepSaveType, childTypes, innerList }
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
	
	#region SaJobStartStatmentChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SaJobStartStatment</c>
	///</summary>
	public enum SaJobStartStatmentChildEntityTypes
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
		/// Composite Property for <c>SaCodeSummery</c> at SaCodeSummeryIdSource
		///</summary>
		[ChildEntityType(typeof(SaCodeSummery))]
		SaCodeSummery,
		///<summary>
		/// Collection of <c>SaJobStartStatment</c> as OneToMany for SaJobStoppageCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaJobStoppage>))]
		SaJobStoppageCollection,
		///<summary>
		/// Collection of <c>SaJobStartStatment</c> as OneToMany for SaVacationCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaVacation>))]
		SaVacationCollection,
		///<summary>
		/// Collection of <c>SaJobStartStatment</c> as OneToMany for SaEmploymentCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaEmployment>))]
		SaEmploymentCollection,
	}
	
	#endregion SaJobStartStatmentChildEntityTypes
	
	#region SaJobStartStatmentFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SaJobStartStatmentColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaJobStartStatment"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaJobStartStatmentFilterBuilder : SqlFilterBuilder<SaJobStartStatmentColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaJobStartStatmentFilterBuilder class.
		/// </summary>
		public SaJobStartStatmentFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaJobStartStatmentFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaJobStartStatmentFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaJobStartStatmentFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaJobStartStatmentFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaJobStartStatmentFilterBuilder
	
	#region SaJobStartStatmentParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SaJobStartStatmentColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaJobStartStatment"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaJobStartStatmentParameterBuilder : ParameterizedSqlFilterBuilder<SaJobStartStatmentColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaJobStartStatmentParameterBuilder class.
		/// </summary>
		public SaJobStartStatmentParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaJobStartStatmentParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaJobStartStatmentParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaJobStartStatmentParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaJobStartStatmentParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaJobStartStatmentParameterBuilder
	
	#region SaJobStartStatmentSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SaJobStartStatmentColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaJobStartStatment"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SaJobStartStatmentSortBuilder : SqlSortBuilder<SaJobStartStatmentColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaJobStartStatmentSqlSortBuilder class.
		/// </summary>
		public SaJobStartStatmentSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SaJobStartStatmentSortBuilder
	
} // end namespace
