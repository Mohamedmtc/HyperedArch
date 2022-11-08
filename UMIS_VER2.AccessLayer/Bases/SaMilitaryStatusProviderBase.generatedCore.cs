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
	/// This class is the base class for any <see cref="SaMilitaryStatusProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SaMilitaryStatusProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SaMilitaryStatus, UMIS_VER2.BusinessLyer.SaMilitaryStatusKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaMilitaryStatusKey key)
		{
			return Delete(transactionManager, key.SaMilitaryStatusId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_saMilitaryStatusId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _saMilitaryStatusId)
		{
			return Delete(null, _saMilitaryStatusId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saMilitaryStatusId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _saMilitaryStatusId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_001b key.
		///		FK_AUTO_001b Description: 
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaMilitaryStatus objects.</returns>
		public TList<SaMilitaryStatus> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(_asFacultyInfoId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_001b key.
		///		FK_AUTO_001b Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaMilitaryStatus objects.</returns>
		/// <remarks></remarks>
		public TList<SaMilitaryStatus> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_001b key.
		///		FK_AUTO_001b Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaMilitaryStatus objects.</returns>
		public TList<SaMilitaryStatus> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_001b key.
		///		fkAuto001b Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaMilitaryStatus objects.</returns>
		public TList<SaMilitaryStatus> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_001b key.
		///		fkAuto001b Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaMilitaryStatus objects.</returns>
		public TList<SaMilitaryStatus> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength,out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_001b key.
		///		FK_AUTO_001b Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaMilitaryStatus objects.</returns>
		public abstract TList<SaMilitaryStatus> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_001c key.
		///		FK_AUTO_001c Description: 
		/// </summary>
		/// <param name="_saStfMemberId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaMilitaryStatus objects.</returns>
		public TList<SaMilitaryStatus> GetBySaStfMemberId(System.Decimal _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(_saStfMemberId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_001c key.
		///		FK_AUTO_001c Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaMilitaryStatus objects.</returns>
		/// <remarks></remarks>
		public TList<SaMilitaryStatus> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_001c key.
		///		FK_AUTO_001c Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaMilitaryStatus objects.</returns>
		public TList<SaMilitaryStatus> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_001c key.
		///		fkAuto001c Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemberId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaMilitaryStatus objects.</returns>
		public TList<SaMilitaryStatus> GetBySaStfMemberId(System.Decimal _saStfMemberId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_001c key.
		///		fkAuto001c Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaMilitaryStatus objects.</returns>
		public TList<SaMilitaryStatus> GetBySaStfMemberId(System.Decimal _saStfMemberId, int start, int pageLength,out int count)
		{
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_AUTO_001c key.
		///		FK_AUTO_001c Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaMilitaryStatus objects.</returns>
		public abstract TList<SaMilitaryStatus> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SaMilitaryStatus Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaMilitaryStatusKey key, int start, int pageLength)
		{
			return GetBySaMilitaryStatusId(transactionManager, key.SaMilitaryStatusId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_GS_CODE_MILITARY_STA_1 index.
		/// </summary>
		/// <param name="_gsCodeMilitaryStateId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaMilitaryStatus&gt;"/> class.</returns>
		public TList<SaMilitaryStatus> GetByGsCodeMilitaryStateId(System.Decimal _gsCodeMilitaryStateId)
		{
			int count = -1;
			return GetByGsCodeMilitaryStateId(null,_gsCodeMilitaryStateId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_MILITARY_STA_1 index.
		/// </summary>
		/// <param name="_gsCodeMilitaryStateId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaMilitaryStatus&gt;"/> class.</returns>
		public TList<SaMilitaryStatus> GetByGsCodeMilitaryStateId(System.Decimal _gsCodeMilitaryStateId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeMilitaryStateId(null, _gsCodeMilitaryStateId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_MILITARY_STA_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeMilitaryStateId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaMilitaryStatus&gt;"/> class.</returns>
		public TList<SaMilitaryStatus> GetByGsCodeMilitaryStateId(TransactionManager transactionManager, System.Decimal _gsCodeMilitaryStateId)
		{
			int count = -1;
			return GetByGsCodeMilitaryStateId(transactionManager, _gsCodeMilitaryStateId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_MILITARY_STA_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeMilitaryStateId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaMilitaryStatus&gt;"/> class.</returns>
		public TList<SaMilitaryStatus> GetByGsCodeMilitaryStateId(TransactionManager transactionManager, System.Decimal _gsCodeMilitaryStateId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeMilitaryStateId(transactionManager, _gsCodeMilitaryStateId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_MILITARY_STA_1 index.
		/// </summary>
		/// <param name="_gsCodeMilitaryStateId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaMilitaryStatus&gt;"/> class.</returns>
		public TList<SaMilitaryStatus> GetByGsCodeMilitaryStateId(System.Decimal _gsCodeMilitaryStateId, int start, int pageLength, out int count)
		{
			return GetByGsCodeMilitaryStateId(null, _gsCodeMilitaryStateId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_MILITARY_STA_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeMilitaryStateId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaMilitaryStatus&gt;"/> class.</returns>
		public abstract TList<SaMilitaryStatus> GetByGsCodeMilitaryStateId(TransactionManager transactionManager, System.Decimal _gsCodeMilitaryStateId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SA_MILITARY_STATUS index.
		/// </summary>
		/// <param name="_saMilitaryStatusId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaMilitaryStatus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaMilitaryStatus GetBySaMilitaryStatusId(System.Decimal _saMilitaryStatusId)
		{
			int count = -1;
			return GetBySaMilitaryStatusId(null,_saMilitaryStatusId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_MILITARY_STATUS index.
		/// </summary>
		/// <param name="_saMilitaryStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaMilitaryStatus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaMilitaryStatus GetBySaMilitaryStatusId(System.Decimal _saMilitaryStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaMilitaryStatusId(null, _saMilitaryStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_MILITARY_STATUS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saMilitaryStatusId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaMilitaryStatus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaMilitaryStatus GetBySaMilitaryStatusId(TransactionManager transactionManager, System.Decimal _saMilitaryStatusId)
		{
			int count = -1;
			return GetBySaMilitaryStatusId(transactionManager, _saMilitaryStatusId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_MILITARY_STATUS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saMilitaryStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaMilitaryStatus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaMilitaryStatus GetBySaMilitaryStatusId(TransactionManager transactionManager, System.Decimal _saMilitaryStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaMilitaryStatusId(transactionManager, _saMilitaryStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_MILITARY_STATUS index.
		/// </summary>
		/// <param name="_saMilitaryStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaMilitaryStatus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaMilitaryStatus GetBySaMilitaryStatusId(System.Decimal _saMilitaryStatusId, int start, int pageLength, out int count)
		{
			return GetBySaMilitaryStatusId(null, _saMilitaryStatusId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_MILITARY_STATUS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saMilitaryStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaMilitaryStatus"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SaMilitaryStatus GetBySaMilitaryStatusId(TransactionManager transactionManager, System.Decimal _saMilitaryStatusId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SaMilitaryStatus&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SaMilitaryStatus&gt;"/></returns>
		public static TList<SaMilitaryStatus> Fill(IDataReader reader, TList<SaMilitaryStatus> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SaMilitaryStatus c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SaMilitaryStatus")
					.Append("|").Append((System.Decimal)reader["SA_MILITARY_STATUS_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SaMilitaryStatus>(
					key.ToString(), // EntityTrackingKey
					"SaMilitaryStatus",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SaMilitaryStatus();
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
					c.SaMilitaryStatusId = (System.Decimal)reader["SA_MILITARY_STATUS_ID"];
					c.OriginalSaMilitaryStatusId = c.SaMilitaryStatusId;
					c.SaStfMemberId = (System.Decimal)reader["SA_STF_MEMBER_ID"];
					c.GsCodeMilitaryStateId = (System.Decimal)reader["GS_CODE_MILITARY_STATE_ID"];
					c.StateDate = (System.DateTime)reader["STATE_DATE"];
					c.ExpireDate = Convert.IsDBNull(reader["EXPIRE_DATE"]) ? null : (System.DateTime?)reader["EXPIRE_DATE"];
					c.DecisionNum = Convert.IsDBNull(reader["DECISION_NUM"]) ? null : (System.String)reader["DECISION_NUM"];
					c.DecisionText = Convert.IsDBNull(reader["DECISION_TEXT"]) ? null : (System.String)reader["DECISION_TEXT"];
					c.DecisionComm = Convert.IsDBNull(reader["DECISION_COMM"]) ? null : (System.String)reader["DECISION_COMM"];
					c.LatestState = (System.Decimal)reader["LATEST_STATE"];
					c.ExmptedReason = Convert.IsDBNull(reader["EXMPTED_REASON"]) ? null : (System.String)reader["EXMPTED_REASON"];
					c.AsFacultyInfoId = (System.Decimal)reader["AS_FACULTY_INFO_ID"];
					c.DoseAffectStaffStat = Convert.IsDBNull(reader["DOSE_AFFECT_STAFF_STAT"]) ? null : (System.Decimal?)reader["DOSE_AFFECT_STAFF_STAT"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaMilitaryStatus"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaMilitaryStatus"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SaMilitaryStatus entity)
		{
			if (!reader.Read()) return;
			
			entity.SaMilitaryStatusId = (System.Decimal)reader[((int)SaMilitaryStatusColumn.SaMilitaryStatusId - 1)];
			entity.OriginalSaMilitaryStatusId = (System.Decimal)reader["SA_MILITARY_STATUS_ID"];
			entity.SaStfMemberId = (System.Decimal)reader[((int)SaMilitaryStatusColumn.SaStfMemberId - 1)];
			entity.GsCodeMilitaryStateId = (System.Decimal)reader[((int)SaMilitaryStatusColumn.GsCodeMilitaryStateId - 1)];
			entity.StateDate = (System.DateTime)reader[((int)SaMilitaryStatusColumn.StateDate - 1)];
			entity.ExpireDate = (reader.IsDBNull(((int)SaMilitaryStatusColumn.ExpireDate - 1)))?null:(System.DateTime?)reader[((int)SaMilitaryStatusColumn.ExpireDate - 1)];
			entity.DecisionNum = (reader.IsDBNull(((int)SaMilitaryStatusColumn.DecisionNum - 1)))?null:(System.String)reader[((int)SaMilitaryStatusColumn.DecisionNum - 1)];
			entity.DecisionText = (reader.IsDBNull(((int)SaMilitaryStatusColumn.DecisionText - 1)))?null:(System.String)reader[((int)SaMilitaryStatusColumn.DecisionText - 1)];
			entity.DecisionComm = (reader.IsDBNull(((int)SaMilitaryStatusColumn.DecisionComm - 1)))?null:(System.String)reader[((int)SaMilitaryStatusColumn.DecisionComm - 1)];
			entity.LatestState = (System.Decimal)reader[((int)SaMilitaryStatusColumn.LatestState - 1)];
			entity.ExmptedReason = (reader.IsDBNull(((int)SaMilitaryStatusColumn.ExmptedReason - 1)))?null:(System.String)reader[((int)SaMilitaryStatusColumn.ExmptedReason - 1)];
			entity.AsFacultyInfoId = (System.Decimal)reader[((int)SaMilitaryStatusColumn.AsFacultyInfoId - 1)];
			entity.DoseAffectStaffStat = (reader.IsDBNull(((int)SaMilitaryStatusColumn.DoseAffectStaffStat - 1)))?null:(System.Decimal?)reader[((int)SaMilitaryStatusColumn.DoseAffectStaffStat - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaMilitaryStatus"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaMilitaryStatus"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SaMilitaryStatus entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SaMilitaryStatusId = (System.Decimal)dataRow["SA_MILITARY_STATUS_ID"];
			entity.OriginalSaMilitaryStatusId = (System.Decimal)dataRow["SA_MILITARY_STATUS_ID"];
			entity.SaStfMemberId = (System.Decimal)dataRow["SA_STF_MEMBER_ID"];
			entity.GsCodeMilitaryStateId = (System.Decimal)dataRow["GS_CODE_MILITARY_STATE_ID"];
			entity.StateDate = (System.DateTime)dataRow["STATE_DATE"];
			entity.ExpireDate = Convert.IsDBNull(dataRow["EXPIRE_DATE"]) ? null : (System.DateTime?)dataRow["EXPIRE_DATE"];
			entity.DecisionNum = Convert.IsDBNull(dataRow["DECISION_NUM"]) ? null : (System.String)dataRow["DECISION_NUM"];
			entity.DecisionText = Convert.IsDBNull(dataRow["DECISION_TEXT"]) ? null : (System.String)dataRow["DECISION_TEXT"];
			entity.DecisionComm = Convert.IsDBNull(dataRow["DECISION_COMM"]) ? null : (System.String)dataRow["DECISION_COMM"];
			entity.LatestState = (System.Decimal)dataRow["LATEST_STATE"];
			entity.ExmptedReason = Convert.IsDBNull(dataRow["EXMPTED_REASON"]) ? null : (System.String)dataRow["EXMPTED_REASON"];
			entity.AsFacultyInfoId = (System.Decimal)dataRow["AS_FACULTY_INFO_ID"];
			entity.DoseAffectStaffStat = Convert.IsDBNull(dataRow["DOSE_AFFECT_STAFF_STAT"]) ? null : (System.Decimal?)dataRow["DOSE_AFFECT_STAFF_STAT"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaMilitaryStatus"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaMilitaryStatus Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaMilitaryStatus entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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

			#region GsCodeMilitaryStateIdSource	
			if (CanDeepLoad(entity, "GsCodeMilitaryState|GsCodeMilitaryStateIdSource", deepLoadType, innerList) 
				&& entity.GsCodeMilitaryStateIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.GsCodeMilitaryStateId;
				GsCodeMilitaryState tmpEntity = EntityManager.LocateEntity<GsCodeMilitaryState>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodeMilitaryState), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodeMilitaryStateIdSource = tmpEntity;
				else
					entity.GsCodeMilitaryStateIdSource = DataRepository.GsCodeMilitaryStateProvider.GetByGsCodeMilitaryStateId(transactionManager, entity.GsCodeMilitaryStateId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodeMilitaryStateIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCodeMilitaryStateIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodeMilitaryStateProvider.DeepLoad(transactionManager, entity.GsCodeMilitaryStateIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCodeMilitaryStateIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SaMilitaryStatus object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SaMilitaryStatus instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaMilitaryStatus Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaMilitaryStatus entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region GsCodeMilitaryStateIdSource
			if (CanDeepSave(entity, "GsCodeMilitaryState|GsCodeMilitaryStateIdSource", deepSaveType, innerList) 
				&& entity.GsCodeMilitaryStateIdSource != null)
			{
				DataRepository.GsCodeMilitaryStateProvider.Save(transactionManager, entity.GsCodeMilitaryStateIdSource);
				entity.GsCodeMilitaryStateId = entity.GsCodeMilitaryStateIdSource.GsCodeMilitaryStateId;
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
	
	#region SaMilitaryStatusChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SaMilitaryStatus</c>
	///</summary>
	public enum SaMilitaryStatusChildEntityTypes
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
		/// Composite Property for <c>GsCodeMilitaryState</c> at GsCodeMilitaryStateIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeMilitaryState))]
		GsCodeMilitaryState,
	}
	
	#endregion SaMilitaryStatusChildEntityTypes
	
	#region SaMilitaryStatusFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SaMilitaryStatusColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaMilitaryStatus"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaMilitaryStatusFilterBuilder : SqlFilterBuilder<SaMilitaryStatusColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaMilitaryStatusFilterBuilder class.
		/// </summary>
		public SaMilitaryStatusFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaMilitaryStatusFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaMilitaryStatusFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaMilitaryStatusFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaMilitaryStatusFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaMilitaryStatusFilterBuilder
	
	#region SaMilitaryStatusParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SaMilitaryStatusColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaMilitaryStatus"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaMilitaryStatusParameterBuilder : ParameterizedSqlFilterBuilder<SaMilitaryStatusColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaMilitaryStatusParameterBuilder class.
		/// </summary>
		public SaMilitaryStatusParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaMilitaryStatusParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaMilitaryStatusParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaMilitaryStatusParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaMilitaryStatusParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaMilitaryStatusParameterBuilder
	
	#region SaMilitaryStatusSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SaMilitaryStatusColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaMilitaryStatus"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SaMilitaryStatusSortBuilder : SqlSortBuilder<SaMilitaryStatusColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaMilitaryStatusSqlSortBuilder class.
		/// </summary>
		public SaMilitaryStatusSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SaMilitaryStatusSortBuilder
	
} // end namespace
