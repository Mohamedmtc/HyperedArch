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
	/// This class is the base class for any <see cref="SvStaffPollProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SvStaffPollProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SvStaffPoll, UMIS_VER2.BusinessLyer.SvStaffPollKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvStaffPollKey key)
		{
			return Delete(transactionManager, key.SvStaffPollId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_svStaffPollId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _svStaffPollId)
		{
			return Delete(null, _svStaffPollId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svStaffPollId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _svStaffPollId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STAFF_POLL_SA_STF_MEMBER key.
		///		FK_SV_STAFF_POLL_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="_saStfMemberId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffPoll objects.</returns>
		public TList<SvStaffPoll> GetBySaStfMemberId(System.Decimal _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(_saStfMemberId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STAFF_POLL_SA_STF_MEMBER key.
		///		FK_SV_STAFF_POLL_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffPoll objects.</returns>
		/// <remarks></remarks>
		public TList<SvStaffPoll> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STAFF_POLL_SA_STF_MEMBER key.
		///		FK_SV_STAFF_POLL_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffPoll objects.</returns>
		public TList<SvStaffPoll> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaStfMemberId(transactionManager, _saStfMemberId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STAFF_POLL_SA_STF_MEMBER key.
		///		fkSvStaffPollSaStfMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemberId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffPoll objects.</returns>
		public TList<SvStaffPoll> GetBySaStfMemberId(System.Decimal _saStfMemberId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STAFF_POLL_SA_STF_MEMBER key.
		///		fkSvStaffPollSaStfMember Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffPoll objects.</returns>
		public TList<SvStaffPoll> GetBySaStfMemberId(System.Decimal _saStfMemberId, int start, int pageLength,out int count)
		{
			return GetBySaStfMemberId(null, _saStfMemberId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STAFF_POLL_SA_STF_MEMBER key.
		///		FK_SV_STAFF_POLL_SA_STF_MEMBER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saStfMemberId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffPoll objects.</returns>
		public abstract TList<SvStaffPoll> GetBySaStfMemberId(TransactionManager transactionManager, System.Decimal _saStfMemberId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STAFF_POLL_SV_POLL_DTL key.
		///		FK_SV_STAFF_POLL_SV_POLL_DTL Description: 
		/// </summary>
		/// <param name="_svPollDtlId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffPoll objects.</returns>
		public TList<SvStaffPoll> GetBySvPollDtlId(System.Decimal _svPollDtlId)
		{
			int count = -1;
			return GetBySvPollDtlId(_svPollDtlId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STAFF_POLL_SV_POLL_DTL key.
		///		FK_SV_STAFF_POLL_SV_POLL_DTL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svPollDtlId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffPoll objects.</returns>
		/// <remarks></remarks>
		public TList<SvStaffPoll> GetBySvPollDtlId(TransactionManager transactionManager, System.Decimal _svPollDtlId)
		{
			int count = -1;
			return GetBySvPollDtlId(transactionManager, _svPollDtlId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STAFF_POLL_SV_POLL_DTL key.
		///		FK_SV_STAFF_POLL_SV_POLL_DTL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svPollDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffPoll objects.</returns>
		public TList<SvStaffPoll> GetBySvPollDtlId(TransactionManager transactionManager, System.Decimal _svPollDtlId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvPollDtlId(transactionManager, _svPollDtlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STAFF_POLL_SV_POLL_DTL key.
		///		fkSvStaffPollSvPollDtl Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_svPollDtlId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffPoll objects.</returns>
		public TList<SvStaffPoll> GetBySvPollDtlId(System.Decimal _svPollDtlId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySvPollDtlId(null, _svPollDtlId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STAFF_POLL_SV_POLL_DTL key.
		///		fkSvStaffPollSvPollDtl Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_svPollDtlId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffPoll objects.</returns>
		public TList<SvStaffPoll> GetBySvPollDtlId(System.Decimal _svPollDtlId, int start, int pageLength,out int count)
		{
			return GetBySvPollDtlId(null, _svPollDtlId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SV_STAFF_POLL_SV_POLL_DTL key.
		///		FK_SV_STAFF_POLL_SV_POLL_DTL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svPollDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SvStaffPoll objects.</returns>
		public abstract TList<SvStaffPoll> GetBySvPollDtlId(TransactionManager transactionManager, System.Decimal _svPollDtlId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SvStaffPoll Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvStaffPollKey key, int start, int pageLength)
		{
			return GetBySvStaffPollId(transactionManager, key.SvStaffPollId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SV_STAFF_POLL index.
		/// </summary>
		/// <param name="_svStaffPollId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvStaffPoll"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvStaffPoll GetBySvStaffPollId(System.Decimal _svStaffPollId)
		{
			int count = -1;
			return GetBySvStaffPollId(null,_svStaffPollId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_STAFF_POLL index.
		/// </summary>
		/// <param name="_svStaffPollId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvStaffPoll"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvStaffPoll GetBySvStaffPollId(System.Decimal _svStaffPollId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvStaffPollId(null, _svStaffPollId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_STAFF_POLL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svStaffPollId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvStaffPoll"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvStaffPoll GetBySvStaffPollId(TransactionManager transactionManager, System.Decimal _svStaffPollId)
		{
			int count = -1;
			return GetBySvStaffPollId(transactionManager, _svStaffPollId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_STAFF_POLL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svStaffPollId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvStaffPoll"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvStaffPoll GetBySvStaffPollId(TransactionManager transactionManager, System.Decimal _svStaffPollId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvStaffPollId(transactionManager, _svStaffPollId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_STAFF_POLL index.
		/// </summary>
		/// <param name="_svStaffPollId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvStaffPoll"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvStaffPoll GetBySvStaffPollId(System.Decimal _svStaffPollId, int start, int pageLength, out int count)
		{
			return GetBySvStaffPollId(null, _svStaffPollId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_STAFF_POLL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svStaffPollId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvStaffPoll"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SvStaffPoll GetBySvStaffPollId(TransactionManager transactionManager, System.Decimal _svStaffPollId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SvStaffPoll&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SvStaffPoll&gt;"/></returns>
		public static TList<SvStaffPoll> Fill(IDataReader reader, TList<SvStaffPoll> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SvStaffPoll c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SvStaffPoll")
					.Append("|").Append((System.Decimal)reader["SV_STAFF_POLL_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SvStaffPoll>(
					key.ToString(), // EntityTrackingKey
					"SvStaffPoll",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SvStaffPoll();
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
					c.SvStaffPollId = (System.Decimal)reader["SV_STAFF_POLL_ID"];
					c.OriginalSvStaffPollId = c.SvStaffPollId;
					c.SaStfMemberId = (System.Decimal)reader["SA_STF_MEMBER_ID"];
					c.SvPollDtlId = (System.Decimal)reader["SV_POLL_DTL_ID"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SvStaffPoll"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvStaffPoll"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SvStaffPoll entity)
		{
			if (!reader.Read()) return;
			
			entity.SvStaffPollId = (System.Decimal)reader[((int)SvStaffPollColumn.SvStaffPollId - 1)];
			entity.OriginalSvStaffPollId = (System.Decimal)reader["SV_STAFF_POLL_ID"];
			entity.SaStfMemberId = (System.Decimal)reader[((int)SvStaffPollColumn.SaStfMemberId - 1)];
			entity.SvPollDtlId = (System.Decimal)reader[((int)SvStaffPollColumn.SvPollDtlId - 1)];
			entity.Notes = (reader.IsDBNull(((int)SvStaffPollColumn.Notes - 1)))?null:(System.String)reader[((int)SvStaffPollColumn.Notes - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SvStaffPoll"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvStaffPoll"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SvStaffPoll entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SvStaffPollId = (System.Decimal)dataRow["SV_STAFF_POLL_ID"];
			entity.OriginalSvStaffPollId = (System.Decimal)dataRow["SV_STAFF_POLL_ID"];
			entity.SaStfMemberId = (System.Decimal)dataRow["SA_STF_MEMBER_ID"];
			entity.SvPollDtlId = (System.Decimal)dataRow["SV_POLL_DTL_ID"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvStaffPoll"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SvStaffPoll Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvStaffPoll entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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

			#region SvPollDtlIdSource	
			if (CanDeepLoad(entity, "SvPollDtl|SvPollDtlIdSource", deepLoadType, innerList) 
				&& entity.SvPollDtlIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SvPollDtlId;
				SvPollDtl tmpEntity = EntityManager.LocateEntity<SvPollDtl>(EntityLocator.ConstructKeyFromPkItems(typeof(SvPollDtl), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SvPollDtlIdSource = tmpEntity;
				else
					entity.SvPollDtlIdSource = DataRepository.SvPollDtlProvider.GetBySvPollDtlId(transactionManager, entity.SvPollDtlId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvPollDtlIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SvPollDtlIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SvPollDtlProvider.DeepLoad(transactionManager, entity.SvPollDtlIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SvPollDtlIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SvStaffPoll object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SvStaffPoll instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SvStaffPoll Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvStaffPoll entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region SvPollDtlIdSource
			if (CanDeepSave(entity, "SvPollDtl|SvPollDtlIdSource", deepSaveType, innerList) 
				&& entity.SvPollDtlIdSource != null)
			{
				DataRepository.SvPollDtlProvider.Save(transactionManager, entity.SvPollDtlIdSource);
				entity.SvPollDtlId = entity.SvPollDtlIdSource.SvPollDtlId;
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
	
	#region SvStaffPollChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SvStaffPoll</c>
	///</summary>
	public enum SvStaffPollChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>SaStfMember</c> at SaStfMemberIdSource
		///</summary>
		[ChildEntityType(typeof(SaStfMember))]
		SaStfMember,
		
		///<summary>
		/// Composite Property for <c>SvPollDtl</c> at SvPollDtlIdSource
		///</summary>
		[ChildEntityType(typeof(SvPollDtl))]
		SvPollDtl,
	}
	
	#endregion SvStaffPollChildEntityTypes
	
	#region SvStaffPollFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SvStaffPollColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvStaffPoll"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SvStaffPollFilterBuilder : SqlFilterBuilder<SvStaffPollColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvStaffPollFilterBuilder class.
		/// </summary>
		public SvStaffPollFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SvStaffPollFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SvStaffPollFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SvStaffPollFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SvStaffPollFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SvStaffPollFilterBuilder
	
	#region SvStaffPollParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SvStaffPollColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvStaffPoll"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SvStaffPollParameterBuilder : ParameterizedSqlFilterBuilder<SvStaffPollColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvStaffPollParameterBuilder class.
		/// </summary>
		public SvStaffPollParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SvStaffPollParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SvStaffPollParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SvStaffPollParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SvStaffPollParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SvStaffPollParameterBuilder
	
	#region SvStaffPollSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SvStaffPollColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvStaffPoll"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SvStaffPollSortBuilder : SqlSortBuilder<SvStaffPollColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvStaffPollSqlSortBuilder class.
		/// </summary>
		public SvStaffPollSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SvStaffPollSortBuilder
	
} // end namespace
