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
	/// This class is the base class for any <see cref="SaJobStoppageProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SaJobStoppageProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SaJobStoppage, UMIS_VER2.BusinessLyer.SaJobStoppageKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaJobStoppageKey key)
		{
			return Delete(transactionManager, key.SaJobStoppageId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_saJobStoppageId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _saJobStoppageId)
		{
			return Delete(null, _saJobStoppageId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saJobStoppageId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _saJobStoppageId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_JOB_STOPPAGE_AS_FACULTY_INFO key.
		///		FK_SA_JOB_STOPPAGE_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaJobStoppage objects.</returns>
		public TList<SaJobStoppage> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(_asFacultyInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_JOB_STOPPAGE_AS_FACULTY_INFO key.
		///		FK_SA_JOB_STOPPAGE_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaJobStoppage objects.</returns>
		/// <remarks></remarks>
		public TList<SaJobStoppage> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_JOB_STOPPAGE_AS_FACULTY_INFO key.
		///		FK_SA_JOB_STOPPAGE_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaJobStoppage objects.</returns>
		public TList<SaJobStoppage> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_JOB_STOPPAGE_AS_FACULTY_INFO key.
		///		fkSaJobStoppageAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaJobStoppage objects.</returns>
		public TList<SaJobStoppage> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_JOB_STOPPAGE_AS_FACULTY_INFO key.
		///		fkSaJobStoppageAsFacultyInfo Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaJobStoppage objects.</returns>
		public TList<SaJobStoppage> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength,out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_JOB_STOPPAGE_AS_FACULTY_INFO key.
		///		FK_SA_JOB_STOPPAGE_AS_FACULTY_INFO Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaJobStoppage objects.</returns>
		public abstract TList<SaJobStoppage> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_JOB_STOPPAGE_SA_JOB_START_STATMENT key.
		///		FK_SA_JOB_STOPPAGE_SA_JOB_START_STATMENT Description: 
		/// </summary>
		/// <param name="_saJobStartStatmentId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaJobStoppage objects.</returns>
		public TList<SaJobStoppage> GetBySaJobStartStatmentId(System.Decimal? _saJobStartStatmentId)
		{
			int count = -1;
			return GetBySaJobStartStatmentId(_saJobStartStatmentId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_JOB_STOPPAGE_SA_JOB_START_STATMENT key.
		///		FK_SA_JOB_STOPPAGE_SA_JOB_START_STATMENT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saJobStartStatmentId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaJobStoppage objects.</returns>
		/// <remarks></remarks>
		public TList<SaJobStoppage> GetBySaJobStartStatmentId(TransactionManager transactionManager, System.Decimal? _saJobStartStatmentId)
		{
			int count = -1;
			return GetBySaJobStartStatmentId(transactionManager, _saJobStartStatmentId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_JOB_STOPPAGE_SA_JOB_START_STATMENT key.
		///		FK_SA_JOB_STOPPAGE_SA_JOB_START_STATMENT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saJobStartStatmentId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaJobStoppage objects.</returns>
		public TList<SaJobStoppage> GetBySaJobStartStatmentId(TransactionManager transactionManager, System.Decimal? _saJobStartStatmentId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaJobStartStatmentId(transactionManager, _saJobStartStatmentId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_JOB_STOPPAGE_SA_JOB_START_STATMENT key.
		///		fkSaJobStoppageSaJobStartStatment Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saJobStartStatmentId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaJobStoppage objects.</returns>
		public TList<SaJobStoppage> GetBySaJobStartStatmentId(System.Decimal? _saJobStartStatmentId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaJobStartStatmentId(null, _saJobStartStatmentId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_JOB_STOPPAGE_SA_JOB_START_STATMENT key.
		///		fkSaJobStoppageSaJobStartStatment Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saJobStartStatmentId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaJobStoppage objects.</returns>
		public TList<SaJobStoppage> GetBySaJobStartStatmentId(System.Decimal? _saJobStartStatmentId, int start, int pageLength,out int count)
		{
			return GetBySaJobStartStatmentId(null, _saJobStartStatmentId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_JOB_STOPPAGE_SA_JOB_START_STATMENT key.
		///		FK_SA_JOB_STOPPAGE_SA_JOB_START_STATMENT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saJobStartStatmentId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaJobStoppage objects.</returns>
		public abstract TList<SaJobStoppage> GetBySaJobStartStatmentId(TransactionManager transactionManager, System.Decimal? _saJobStartStatmentId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SaJobStoppage Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaJobStoppageKey key, int start, int pageLength)
		{
			return GetBySaJobStoppageId(transactionManager, key.SaJobStoppageId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_SA_STF_MEMBER_ID_1 index.
		/// </summary>
		/// <param name="_saStfMemberId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaJobStoppage&gt;"/> class.</returns>
		public TList<SaJobStoppage> GetBySaStfMemberId(System.Decimal _saStfMemberId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;SaJobStoppage&gt;"/> class.</returns>
		public TList<SaJobStoppage> GetBySaStfMemberId(System.Decimal _saStfMemberId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;SaJobStoppage&gt;"/> class.</returns>
		public TList<SaJobStoppage> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;SaJobStoppage&gt;"/> class.</returns>
		public TList<SaJobStoppage> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;SaJobStoppage&gt;"/> class.</returns>
		public TList<SaJobStoppage> GetBySaStfMemberId(System.Decimal _saStfMemberId, int start, int pageLength, out int count)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;SaJobStoppage&gt;"/> class.</returns>
		public abstract TList<SaJobStoppage> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SA_JOB_STOPPAGE index.
		/// </summary>
		/// <param name="_saJobStoppageId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaJobStoppage"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaJobStoppage GetBySaJobStoppageId(System.Decimal _saJobStoppageId)
		{
			int count = -1;
			return GetBySaJobStoppageId(null,_saJobStoppageId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_JOB_STOPPAGE index.
		/// </summary>
		/// <param name="_saJobStoppageId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaJobStoppage"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaJobStoppage GetBySaJobStoppageId(System.Decimal _saJobStoppageId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaJobStoppageId(null, _saJobStoppageId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_JOB_STOPPAGE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saJobStoppageId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaJobStoppage"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaJobStoppage GetBySaJobStoppageId(TransactionManager transactionManager, System.Decimal _saJobStoppageId)
		{
			int count = -1;
			return GetBySaJobStoppageId(transactionManager, _saJobStoppageId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_JOB_STOPPAGE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saJobStoppageId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaJobStoppage"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaJobStoppage GetBySaJobStoppageId(TransactionManager transactionManager, System.Decimal _saJobStoppageId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaJobStoppageId(transactionManager, _saJobStoppageId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_JOB_STOPPAGE index.
		/// </summary>
		/// <param name="_saJobStoppageId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaJobStoppage"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaJobStoppage GetBySaJobStoppageId(System.Decimal _saJobStoppageId, int start, int pageLength, out int count)
		{
			return GetBySaJobStoppageId(null, _saJobStoppageId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_JOB_STOPPAGE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saJobStoppageId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaJobStoppage"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SaJobStoppage GetBySaJobStoppageId(TransactionManager transactionManager, System.Decimal _saJobStoppageId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SaJobStoppage&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SaJobStoppage&gt;"/></returns>
		public static TList<SaJobStoppage> Fill(IDataReader reader, TList<SaJobStoppage> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SaJobStoppage c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SaJobStoppage")
					.Append("|").Append((System.Decimal)reader["SA_JOB_STOPPAGE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SaJobStoppage>(
					key.ToString(), // EntityTrackingKey
					"SaJobStoppage",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SaJobStoppage();
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
					c.SaJobStoppageId = (System.Decimal)reader["SA_JOB_STOPPAGE_ID"];
					c.OriginalSaJobStoppageId = c.SaJobStoppageId;
					c.StoppingReason = (System.String)reader["STOPPING_REASON"];
					c.StoppingFrom = (System.DateTime)reader["STOPPING_FROM"];
					c.StoppingTo = Convert.IsDBNull(reader["STOPPING_TO"]) ? null : (System.DateTime?)reader["STOPPING_TO"];
					c.StoppingDecisionText = (System.String)reader["STOPPING_DECISION_TEXT"];
					c.StoppingRuleText = Convert.IsDBNull(reader["STOPPING_RULE_TEXT"]) ? null : (System.String)reader["STOPPING_RULE_TEXT"];
					c.IsExcuseAcceptedDept = (System.Decimal)reader["IS_EXCUSE_ACCEPTED_DEPT"];
					c.IsExcuseAcceptedFaculty = (System.Decimal)reader["IS_EXCUSE_ACCEPTED_FACULTY"];
					c.IsExcuseAcceptedUni = (System.Decimal)reader["IS_EXCUSE_ACCEPTED_UNI"];
					c.DoesAffectStaffState = (System.Decimal)reader["DOES_AFFECT_STAFF_STATE"];
					c.Comments = Convert.IsDBNull(reader["COMMENTS"]) ? null : (System.String)reader["COMMENTS"];
					c.SaStfMemberId = (System.Decimal)reader["SA_STF_MEMBER_ID"];
					c.AsFacultyInfoId = (System.Decimal)reader["AS_FACULTY_INFO_ID"];
					c.ReturnAffectsStatus = (System.Decimal)reader["RETURN_AFFECTS_STATUS"];
					c.SaJobStartStatmentId = Convert.IsDBNull(reader["SA_JOB_START_STATMENT_ID"]) ? null : (System.Decimal?)reader["SA_JOB_START_STATMENT_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaJobStoppage"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaJobStoppage"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SaJobStoppage entity)
		{
			if (!reader.Read()) return;
			
			entity.SaJobStoppageId = (System.Decimal)reader[((int)SaJobStoppageColumn.SaJobStoppageId - 1)];
			entity.OriginalSaJobStoppageId = (System.Decimal)reader["SA_JOB_STOPPAGE_ID"];
			entity.StoppingReason = (System.String)reader[((int)SaJobStoppageColumn.StoppingReason - 1)];
			entity.StoppingFrom = (System.DateTime)reader[((int)SaJobStoppageColumn.StoppingFrom - 1)];
			entity.StoppingTo = (reader.IsDBNull(((int)SaJobStoppageColumn.StoppingTo - 1)))?null:(System.DateTime?)reader[((int)SaJobStoppageColumn.StoppingTo - 1)];
			entity.StoppingDecisionText = (System.String)reader[((int)SaJobStoppageColumn.StoppingDecisionText - 1)];
			entity.StoppingRuleText = (reader.IsDBNull(((int)SaJobStoppageColumn.StoppingRuleText - 1)))?null:(System.String)reader[((int)SaJobStoppageColumn.StoppingRuleText - 1)];
			entity.IsExcuseAcceptedDept = (System.Decimal)reader[((int)SaJobStoppageColumn.IsExcuseAcceptedDept - 1)];
			entity.IsExcuseAcceptedFaculty = (System.Decimal)reader[((int)SaJobStoppageColumn.IsExcuseAcceptedFaculty - 1)];
			entity.IsExcuseAcceptedUni = (System.Decimal)reader[((int)SaJobStoppageColumn.IsExcuseAcceptedUni - 1)];
			entity.DoesAffectStaffState = (System.Decimal)reader[((int)SaJobStoppageColumn.DoesAffectStaffState - 1)];
			entity.Comments = (reader.IsDBNull(((int)SaJobStoppageColumn.Comments - 1)))?null:(System.String)reader[((int)SaJobStoppageColumn.Comments - 1)];
			entity.SaStfMemberId = (System.Decimal)reader[((int)SaJobStoppageColumn.SaStfMemberId - 1)];
			entity.AsFacultyInfoId = (System.Decimal)reader[((int)SaJobStoppageColumn.AsFacultyInfoId - 1)];
			entity.ReturnAffectsStatus = (System.Decimal)reader[((int)SaJobStoppageColumn.ReturnAffectsStatus - 1)];
			entity.SaJobStartStatmentId = (reader.IsDBNull(((int)SaJobStoppageColumn.SaJobStartStatmentId - 1)))?null:(System.Decimal?)reader[((int)SaJobStoppageColumn.SaJobStartStatmentId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaJobStoppage"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaJobStoppage"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SaJobStoppage entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SaJobStoppageId = (System.Decimal)dataRow["SA_JOB_STOPPAGE_ID"];
			entity.OriginalSaJobStoppageId = (System.Decimal)dataRow["SA_JOB_STOPPAGE_ID"];
			entity.StoppingReason = (System.String)dataRow["STOPPING_REASON"];
			entity.StoppingFrom = (System.DateTime)dataRow["STOPPING_FROM"];
			entity.StoppingTo = Convert.IsDBNull(dataRow["STOPPING_TO"]) ? null : (System.DateTime?)dataRow["STOPPING_TO"];
			entity.StoppingDecisionText = (System.String)dataRow["STOPPING_DECISION_TEXT"];
			entity.StoppingRuleText = Convert.IsDBNull(dataRow["STOPPING_RULE_TEXT"]) ? null : (System.String)dataRow["STOPPING_RULE_TEXT"];
			entity.IsExcuseAcceptedDept = (System.Decimal)dataRow["IS_EXCUSE_ACCEPTED_DEPT"];
			entity.IsExcuseAcceptedFaculty = (System.Decimal)dataRow["IS_EXCUSE_ACCEPTED_FACULTY"];
			entity.IsExcuseAcceptedUni = (System.Decimal)dataRow["IS_EXCUSE_ACCEPTED_UNI"];
			entity.DoesAffectStaffState = (System.Decimal)dataRow["DOES_AFFECT_STAFF_STATE"];
			entity.Comments = Convert.IsDBNull(dataRow["COMMENTS"]) ? null : (System.String)dataRow["COMMENTS"];
			entity.SaStfMemberId = (System.Decimal)dataRow["SA_STF_MEMBER_ID"];
			entity.AsFacultyInfoId = (System.Decimal)dataRow["AS_FACULTY_INFO_ID"];
			entity.ReturnAffectsStatus = (System.Decimal)dataRow["RETURN_AFFECTS_STATUS"];
			entity.SaJobStartStatmentId = Convert.IsDBNull(dataRow["SA_JOB_START_STATMENT_ID"]) ? null : (System.Decimal?)dataRow["SA_JOB_START_STATMENT_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaJobStoppage"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaJobStoppage Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaJobStoppage entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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

			#region SaJobStartStatmentIdSource	
			if (CanDeepLoad(entity, "SaJobStartStatment|SaJobStartStatmentIdSource", deepLoadType, innerList) 
				&& entity.SaJobStartStatmentIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SaJobStartStatmentId ?? 0.0m);
				SaJobStartStatment tmpEntity = EntityManager.LocateEntity<SaJobStartStatment>(EntityLocator.ConstructKeyFromPkItems(typeof(SaJobStartStatment), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaJobStartStatmentIdSource = tmpEntity;
				else
					entity.SaJobStartStatmentIdSource = DataRepository.SaJobStartStatmentProvider.GetBySaJobStartStatmentId(transactionManager, (entity.SaJobStartStatmentId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaJobStartStatmentIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaJobStartStatmentIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaJobStartStatmentProvider.DeepLoad(transactionManager, entity.SaJobStartStatmentIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaJobStartStatmentIdSource

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
			// Deep load child collections  - Call GetBySaJobStoppageId methods when available
			
			#region SaWarningCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaWarning>|SaWarningCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaWarningCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaWarningCollection = DataRepository.SaWarningProvider.GetBySaJobStoppageId(transactionManager, entity.SaJobStoppageId);

				if (deep && entity.SaWarningCollection.Count > 0)
				{
					deepHandles.Add("SaWarningCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaWarning>) DataRepository.SaWarningProvider.DeepLoad,
						new object[] { transactionManager, entity.SaWarningCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SaJobStoppage object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SaJobStoppage instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaJobStoppage Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaJobStoppage entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region SaJobStartStatmentIdSource
			if (CanDeepSave(entity, "SaJobStartStatment|SaJobStartStatmentIdSource", deepSaveType, innerList) 
				&& entity.SaJobStartStatmentIdSource != null)
			{
				DataRepository.SaJobStartStatmentProvider.Save(transactionManager, entity.SaJobStartStatmentIdSource);
				entity.SaJobStartStatmentId = entity.SaJobStartStatmentIdSource.SaJobStartStatmentId;
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
	
			#region List<SaWarning>
				if (CanDeepSave(entity.SaWarningCollection, "List<SaWarning>|SaWarningCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaWarning child in entity.SaWarningCollection)
					{
						if(child.SaJobStoppageIdSource != null)
						{
							child.SaJobStoppageId = child.SaJobStoppageIdSource.SaJobStoppageId;
						}
						else
						{
							child.SaJobStoppageId = entity.SaJobStoppageId;
						}

					}

					if (entity.SaWarningCollection.Count > 0 || entity.SaWarningCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaWarningProvider.Save(transactionManager, entity.SaWarningCollection);
						
						deepHandles.Add("SaWarningCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaWarning >) DataRepository.SaWarningProvider.DeepSave,
							new object[] { transactionManager, entity.SaWarningCollection, deepSaveType, childTypes, innerList }
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
	
	#region SaJobStoppageChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SaJobStoppage</c>
	///</summary>
	public enum SaJobStoppageChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AsFacultyInfo</c> at AsFacultyInfoIdSource
		///</summary>
		[ChildEntityType(typeof(AsFacultyInfo))]
		AsFacultyInfo,
		
		///<summary>
		/// Composite Property for <c>SaJobStartStatment</c> at SaJobStartStatmentIdSource
		///</summary>
		[ChildEntityType(typeof(SaJobStartStatment))]
		SaJobStartStatment,
		
		///<summary>
		/// Composite Property for <c>SaStfMember</c> at SaStfMemberIdSource
		///</summary>
		[ChildEntityType(typeof(SaStfMember))]
		SaStfMember,
		///<summary>
		/// Collection of <c>SaJobStoppage</c> as OneToMany for SaWarningCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaWarning>))]
		SaWarningCollection,
	}
	
	#endregion SaJobStoppageChildEntityTypes
	
	#region SaJobStoppageFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SaJobStoppageColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaJobStoppage"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaJobStoppageFilterBuilder : SqlFilterBuilder<SaJobStoppageColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaJobStoppageFilterBuilder class.
		/// </summary>
		public SaJobStoppageFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaJobStoppageFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaJobStoppageFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaJobStoppageFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaJobStoppageFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaJobStoppageFilterBuilder
	
	#region SaJobStoppageParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SaJobStoppageColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaJobStoppage"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaJobStoppageParameterBuilder : ParameterizedSqlFilterBuilder<SaJobStoppageColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaJobStoppageParameterBuilder class.
		/// </summary>
		public SaJobStoppageParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaJobStoppageParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaJobStoppageParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaJobStoppageParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaJobStoppageParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaJobStoppageParameterBuilder
	
	#region SaJobStoppageSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SaJobStoppageColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaJobStoppage"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SaJobStoppageSortBuilder : SqlSortBuilder<SaJobStoppageColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaJobStoppageSqlSortBuilder class.
		/// </summary>
		public SaJobStoppageSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SaJobStoppageSortBuilder
	
} // end namespace
