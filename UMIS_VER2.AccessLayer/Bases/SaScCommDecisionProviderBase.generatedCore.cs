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
	/// This class is the base class for any <see cref="SaScCommDecisionProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SaScCommDecisionProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SaScCommDecision, UMIS_VER2.BusinessLyer.SaScCommDecisionKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaScCommDecisionKey key)
		{
			return Delete(transactionManager, key.SaScCommDecisionId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_saScCommDecisionId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _saScCommDecisionId)
		{
			return Delete(null, _saScCommDecisionId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saScCommDecisionId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _saScCommDecisionId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0350 key.
		///		FK_AUTO_0350 Description: 
		/// </summary>
		/// <param name="_saPromotionRequestId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScCommDecision objects.</returns>
		public TList<SaScCommDecision> GetBySaPromotionRequestId(System.Decimal? _saPromotionRequestId)
		{
			int count = -1;
			return GetBySaPromotionRequestId(_saPromotionRequestId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0350 key.
		///		FK_AUTO_0350 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saPromotionRequestId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScCommDecision objects.</returns>
		/// <remarks></remarks>
		public TList<SaScCommDecision> GetBySaPromotionRequestId(TransactionManager transactionManager, System.Decimal? _saPromotionRequestId)
		{
			int count = -1;
			return GetBySaPromotionRequestId(transactionManager, _saPromotionRequestId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0350 key.
		///		FK_AUTO_0350 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saPromotionRequestId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScCommDecision objects.</returns>
		public TList<SaScCommDecision> GetBySaPromotionRequestId(TransactionManager transactionManager, System.Decimal? _saPromotionRequestId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaPromotionRequestId(transactionManager, _saPromotionRequestId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0350 key.
		///		fkAuto0350 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saPromotionRequestId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScCommDecision objects.</returns>
		public TList<SaScCommDecision> GetBySaPromotionRequestId(System.Decimal? _saPromotionRequestId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaPromotionRequestId(null, _saPromotionRequestId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0350 key.
		///		fkAuto0350 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saPromotionRequestId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScCommDecision objects.</returns>
		public TList<SaScCommDecision> GetBySaPromotionRequestId(System.Decimal? _saPromotionRequestId, int start, int pageLength,out int count)
		{
			return GetBySaPromotionRequestId(null, _saPromotionRequestId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_0350 key.
		///		FK_AUTO_0350 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saPromotionRequestId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScCommDecision objects.</returns>
		public abstract TList<SaScCommDecision> GetBySaPromotionRequestId(TransactionManager transactionManager, System.Decimal? _saPromotionRequestId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_04e4 key.
		///		FK_AUTO_04e4 Description: 
		/// </summary>
		/// <param name="_saScCommId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScCommDecision objects.</returns>
		public TList<SaScCommDecision> GetBySaScCommId(System.Decimal _saScCommId)
		{
			int count = -1;
			return GetBySaScCommId(_saScCommId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_04e4 key.
		///		FK_AUTO_04e4 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saScCommId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScCommDecision objects.</returns>
		/// <remarks></remarks>
		public TList<SaScCommDecision> GetBySaScCommId(TransactionManager transactionManager, System.Decimal _saScCommId)
		{
			int count = -1;
			return GetBySaScCommId(transactionManager, _saScCommId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_04e4 key.
		///		FK_AUTO_04e4 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saScCommId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScCommDecision objects.</returns>
		public TList<SaScCommDecision> GetBySaScCommId(TransactionManager transactionManager, System.Decimal _saScCommId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaScCommId(transactionManager, _saScCommId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_04e4 key.
		///		fkAuto04e4 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saScCommId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScCommDecision objects.</returns>
		public TList<SaScCommDecision> GetBySaScCommId(System.Decimal _saScCommId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaScCommId(null, _saScCommId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_04e4 key.
		///		fkAuto04e4 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saScCommId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScCommDecision objects.</returns>
		public TList<SaScCommDecision> GetBySaScCommId(System.Decimal _saScCommId, int start, int pageLength,out int count)
		{
			return GetBySaScCommId(null, _saScCommId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_04e4 key.
		///		FK_AUTO_04e4 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saScCommId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScCommDecision objects.</returns>
		public abstract TList<SaScCommDecision> GetBySaScCommId(TransactionManager transactionManager, System.Decimal _saScCommId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SC_COMM_DECISION_AS_FACULTY_INFO key.
		///		FK_SA_SC_COMM_DECISION_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScCommDecision objects.</returns>
		public TList<SaScCommDecision> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(_asFacultyInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SC_COMM_DECISION_AS_FACULTY_INFO key.
		///		FK_SA_SC_COMM_DECISION_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScCommDecision objects.</returns>
		/// <remarks></remarks>
		public TList<SaScCommDecision> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SC_COMM_DECISION_AS_FACULTY_INFO key.
		///		FK_SA_SC_COMM_DECISION_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScCommDecision objects.</returns>
		public TList<SaScCommDecision> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SC_COMM_DECISION_AS_FACULTY_INFO key.
		///		fkSaScCommDecisionAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScCommDecision objects.</returns>
		public TList<SaScCommDecision> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SC_COMM_DECISION_AS_FACULTY_INFO key.
		///		fkSaScCommDecisionAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScCommDecision objects.</returns>
		public TList<SaScCommDecision> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength,out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_SC_COMM_DECISION_AS_FACULTY_INFO key.
		///		FK_SA_SC_COMM_DECISION_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaScCommDecision objects.</returns>
		public abstract TList<SaScCommDecision> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SaScCommDecision Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaScCommDecisionKey key, int start, int pageLength)
		{
			return GetBySaScCommDecisionId(transactionManager, key.SaScCommDecisionId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SA_SC_COMM_DECISION index.
		/// </summary>
		/// <param name="_saScCommDecisionId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaScCommDecision"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaScCommDecision GetBySaScCommDecisionId(System.Decimal _saScCommDecisionId)
		{
			int count = -1;
			return GetBySaScCommDecisionId(null,_saScCommDecisionId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_SC_COMM_DECISION index.
		/// </summary>
		/// <param name="_saScCommDecisionId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaScCommDecision"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaScCommDecision GetBySaScCommDecisionId(System.Decimal _saScCommDecisionId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaScCommDecisionId(null, _saScCommDecisionId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_SC_COMM_DECISION index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saScCommDecisionId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaScCommDecision"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaScCommDecision GetBySaScCommDecisionId(TransactionManager transactionManager, System.Decimal _saScCommDecisionId)
		{
			int count = -1;
			return GetBySaScCommDecisionId(transactionManager, _saScCommDecisionId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_SC_COMM_DECISION index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saScCommDecisionId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaScCommDecision"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaScCommDecision GetBySaScCommDecisionId(TransactionManager transactionManager, System.Decimal _saScCommDecisionId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaScCommDecisionId(transactionManager, _saScCommDecisionId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_SC_COMM_DECISION index.
		/// </summary>
		/// <param name="_saScCommDecisionId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaScCommDecision"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaScCommDecision GetBySaScCommDecisionId(System.Decimal _saScCommDecisionId, int start, int pageLength, out int count)
		{
			return GetBySaScCommDecisionId(null, _saScCommDecisionId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_SC_COMM_DECISION index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saScCommDecisionId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaScCommDecision"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SaScCommDecision GetBySaScCommDecisionId(TransactionManager transactionManager, System.Decimal _saScCommDecisionId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SaScCommDecision&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SaScCommDecision&gt;"/></returns>
		public static TList<SaScCommDecision> Fill(IDataReader reader, TList<SaScCommDecision> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SaScCommDecision c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SaScCommDecision")
					.Append("|").Append((System.Decimal)reader["SA_SC_COMM_DECISION_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SaScCommDecision>(
					key.ToString(), // EntityTrackingKey
					"SaScCommDecision",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SaScCommDecision();
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
					c.SaScCommDecisionId = (System.Decimal)reader["SA_SC_COMM_DECISION_ID"];
					c.OriginalSaScCommDecisionId = c.SaScCommDecisionId;
					c.DecisionNum = (System.String)reader["DECISION_NUM"];
					c.DecisionDate = (System.DateTime)reader["DECISION_DATE"];
					c.Recommendation = (System.Decimal)reader["RECOMMENDATION"];
					c.Comments = Convert.IsDBNull(reader["COMMENTS"]) ? null : (System.String)reader["COMMENTS"];
					c.SaScCommId = (System.Decimal)reader["SA_SC_COMM_ID"];
					c.AsFacultyInfoId = (System.Decimal)reader["AS_FACULTY_INFO_ID"];
					c.CommitteeDate = Convert.IsDBNull(reader["COMMITTEE_DATE"]) ? null : (System.DateTime?)reader["COMMITTEE_DATE"];
					c.SaPromotionRequestId = Convert.IsDBNull(reader["SA_PROMOTION_REQUEST_ID"]) ? null : (System.Decimal?)reader["SA_PROMOTION_REQUEST_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaScCommDecision"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaScCommDecision"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SaScCommDecision entity)
		{
			if (!reader.Read()) return;
			
			entity.SaScCommDecisionId = (System.Decimal)reader[((int)SaScCommDecisionColumn.SaScCommDecisionId - 1)];
			entity.OriginalSaScCommDecisionId = (System.Decimal)reader["SA_SC_COMM_DECISION_ID"];
			entity.DecisionNum = (System.String)reader[((int)SaScCommDecisionColumn.DecisionNum - 1)];
			entity.DecisionDate = (System.DateTime)reader[((int)SaScCommDecisionColumn.DecisionDate - 1)];
			entity.Recommendation = (System.Decimal)reader[((int)SaScCommDecisionColumn.Recommendation - 1)];
			entity.Comments = (reader.IsDBNull(((int)SaScCommDecisionColumn.Comments - 1)))?null:(System.String)reader[((int)SaScCommDecisionColumn.Comments - 1)];
			entity.SaScCommId = (System.Decimal)reader[((int)SaScCommDecisionColumn.SaScCommId - 1)];
			entity.AsFacultyInfoId = (System.Decimal)reader[((int)SaScCommDecisionColumn.AsFacultyInfoId - 1)];
			entity.CommitteeDate = (reader.IsDBNull(((int)SaScCommDecisionColumn.CommitteeDate - 1)))?null:(System.DateTime?)reader[((int)SaScCommDecisionColumn.CommitteeDate - 1)];
			entity.SaPromotionRequestId = (reader.IsDBNull(((int)SaScCommDecisionColumn.SaPromotionRequestId - 1)))?null:(System.Decimal?)reader[((int)SaScCommDecisionColumn.SaPromotionRequestId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaScCommDecision"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaScCommDecision"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SaScCommDecision entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SaScCommDecisionId = (System.Decimal)dataRow["SA_SC_COMM_DECISION_ID"];
			entity.OriginalSaScCommDecisionId = (System.Decimal)dataRow["SA_SC_COMM_DECISION_ID"];
			entity.DecisionNum = (System.String)dataRow["DECISION_NUM"];
			entity.DecisionDate = (System.DateTime)dataRow["DECISION_DATE"];
			entity.Recommendation = (System.Decimal)dataRow["RECOMMENDATION"];
			entity.Comments = Convert.IsDBNull(dataRow["COMMENTS"]) ? null : (System.String)dataRow["COMMENTS"];
			entity.SaScCommId = (System.Decimal)dataRow["SA_SC_COMM_ID"];
			entity.AsFacultyInfoId = (System.Decimal)dataRow["AS_FACULTY_INFO_ID"];
			entity.CommitteeDate = Convert.IsDBNull(dataRow["COMMITTEE_DATE"]) ? null : (System.DateTime?)dataRow["COMMITTEE_DATE"];
			entity.SaPromotionRequestId = Convert.IsDBNull(dataRow["SA_PROMOTION_REQUEST_ID"]) ? null : (System.Decimal?)dataRow["SA_PROMOTION_REQUEST_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaScCommDecision"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaScCommDecision Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaScCommDecision entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region SaPromotionRequestIdSource	
			if (CanDeepLoad(entity, "SaPromotionRequest|SaPromotionRequestIdSource", deepLoadType, innerList) 
				&& entity.SaPromotionRequestIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SaPromotionRequestId ?? 0.0m);
				SaPromotionRequest tmpEntity = EntityManager.LocateEntity<SaPromotionRequest>(EntityLocator.ConstructKeyFromPkItems(typeof(SaPromotionRequest), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaPromotionRequestIdSource = tmpEntity;
				else
					entity.SaPromotionRequestIdSource = DataRepository.SaPromotionRequestProvider.GetBySaPromotionRequestId(transactionManager, (entity.SaPromotionRequestId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaPromotionRequestIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaPromotionRequestIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaPromotionRequestProvider.DeepLoad(transactionManager, entity.SaPromotionRequestIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaPromotionRequestIdSource

			#region SaScCommIdSource	
			if (CanDeepLoad(entity, "SaScComm|SaScCommIdSource", deepLoadType, innerList) 
				&& entity.SaScCommIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SaScCommId;
				SaScComm tmpEntity = EntityManager.LocateEntity<SaScComm>(EntityLocator.ConstructKeyFromPkItems(typeof(SaScComm), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaScCommIdSource = tmpEntity;
				else
					entity.SaScCommIdSource = DataRepository.SaScCommProvider.GetBySaScCommId(transactionManager, entity.SaScCommId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaScCommIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaScCommIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaScCommProvider.DeepLoad(transactionManager, entity.SaScCommIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaScCommIdSource

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
			// Deep load child collections  - Call GetBySaScCommDecisionId methods when available
			
			#region SaPromotionCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaPromotion>|SaPromotionCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaPromotionCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaPromotionCollection = DataRepository.SaPromotionProvider.GetBySaScCommDecisionId(transactionManager, entity.SaScCommDecisionId);

				if (deep && entity.SaPromotionCollection.Count > 0)
				{
					deepHandles.Add("SaPromotionCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaPromotion>) DataRepository.SaPromotionProvider.DeepLoad,
						new object[] { transactionManager, entity.SaPromotionCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SaScCommDecision object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SaScCommDecision instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaScCommDecision Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaScCommDecision entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region SaPromotionRequestIdSource
			if (CanDeepSave(entity, "SaPromotionRequest|SaPromotionRequestIdSource", deepSaveType, innerList) 
				&& entity.SaPromotionRequestIdSource != null)
			{
				DataRepository.SaPromotionRequestProvider.Save(transactionManager, entity.SaPromotionRequestIdSource);
				entity.SaPromotionRequestId = entity.SaPromotionRequestIdSource.SaPromotionRequestId;
			}
			#endregion 
			
			#region SaScCommIdSource
			if (CanDeepSave(entity, "SaScComm|SaScCommIdSource", deepSaveType, innerList) 
				&& entity.SaScCommIdSource != null)
			{
				DataRepository.SaScCommProvider.Save(transactionManager, entity.SaScCommIdSource);
				entity.SaScCommId = entity.SaScCommIdSource.SaScCommId;
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
	
			#region List<SaPromotion>
				if (CanDeepSave(entity.SaPromotionCollection, "List<SaPromotion>|SaPromotionCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaPromotion child in entity.SaPromotionCollection)
					{
						if(child.SaScCommDecisionIdSource != null)
						{
							child.SaScCommDecisionId = child.SaScCommDecisionIdSource.SaScCommDecisionId;
						}
						else
						{
							child.SaScCommDecisionId = entity.SaScCommDecisionId;
						}

					}

					if (entity.SaPromotionCollection.Count > 0 || entity.SaPromotionCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaPromotionProvider.Save(transactionManager, entity.SaPromotionCollection);
						
						deepHandles.Add("SaPromotionCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaPromotion >) DataRepository.SaPromotionProvider.DeepSave,
							new object[] { transactionManager, entity.SaPromotionCollection, deepSaveType, childTypes, innerList }
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
	
	#region SaScCommDecisionChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SaScCommDecision</c>
	///</summary>
	public enum SaScCommDecisionChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>SaPromotionRequest</c> at SaPromotionRequestIdSource
		///</summary>
		[ChildEntityType(typeof(SaPromotionRequest))]
		SaPromotionRequest,
		
		///<summary>
		/// Composite Property for <c>SaScComm</c> at SaScCommIdSource
		///</summary>
		[ChildEntityType(typeof(SaScComm))]
		SaScComm,
		
		///<summary>
		/// Composite Property for <c>AsFacultyInfo</c> at AsFacultyInfoIdSource
		///</summary>
		[ChildEntityType(typeof(AsFacultyInfo))]
		AsFacultyInfo,
		///<summary>
		/// Collection of <c>SaScCommDecision</c> as OneToMany for SaPromotionCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaPromotion>))]
		SaPromotionCollection,
	}
	
	#endregion SaScCommDecisionChildEntityTypes
	
	#region SaScCommDecisionFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SaScCommDecisionColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaScCommDecision"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaScCommDecisionFilterBuilder : SqlFilterBuilder<SaScCommDecisionColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaScCommDecisionFilterBuilder class.
		/// </summary>
		public SaScCommDecisionFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaScCommDecisionFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaScCommDecisionFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaScCommDecisionFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaScCommDecisionFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaScCommDecisionFilterBuilder
	
	#region SaScCommDecisionParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SaScCommDecisionColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaScCommDecision"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaScCommDecisionParameterBuilder : ParameterizedSqlFilterBuilder<SaScCommDecisionColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaScCommDecisionParameterBuilder class.
		/// </summary>
		public SaScCommDecisionParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaScCommDecisionParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaScCommDecisionParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaScCommDecisionParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaScCommDecisionParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaScCommDecisionParameterBuilder
	
	#region SaScCommDecisionSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SaScCommDecisionColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaScCommDecision"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SaScCommDecisionSortBuilder : SqlSortBuilder<SaScCommDecisionColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaScCommDecisionSqlSortBuilder class.
		/// </summary>
		public SaScCommDecisionSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SaScCommDecisionSortBuilder
	
} // end namespace
