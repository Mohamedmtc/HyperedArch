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
	/// This class is the base class for any <see cref="SaPunishBylawAuthProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SaPunishBylawAuthProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SaPunishBylawAuth, UMIS_VER2.BusinessLyer.SaPunishBylawAuthKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaPunishBylawAuthKey key)
		{
			return Delete(transactionManager, key.SaPunishBylawAuthId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_saPunishBylawAuthId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _saPunishBylawAuthId)
		{
			return Delete(null, _saPunishBylawAuthId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saPunishBylawAuthId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _saPunishBylawAuthId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PUNISH_BYLAW_AUTH_SA_CODE_PUNISHING_AUTHORITY key.
		///		FK_SA_PUNISH_BYLAW_AUTH_SA_CODE_PUNISHING_AUTHORITY Description: 
		/// </summary>
		/// <param name="_saCodePunishingAuthorityId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPunishBylawAuth objects.</returns>
		public TList<SaPunishBylawAuth> GetBySaCodePunishingAuthorityId(System.Decimal _saCodePunishingAuthorityId)
		{
			int count = -1;
			return GetBySaCodePunishingAuthorityId(_saCodePunishingAuthorityId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PUNISH_BYLAW_AUTH_SA_CODE_PUNISHING_AUTHORITY key.
		///		FK_SA_PUNISH_BYLAW_AUTH_SA_CODE_PUNISHING_AUTHORITY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodePunishingAuthorityId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPunishBylawAuth objects.</returns>
		/// <remarks></remarks>
		public TList<SaPunishBylawAuth> GetBySaCodePunishingAuthorityId(TransactionManager transactionManager, System.Decimal _saCodePunishingAuthorityId)
		{
			int count = -1;
			return GetBySaCodePunishingAuthorityId(transactionManager, _saCodePunishingAuthorityId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PUNISH_BYLAW_AUTH_SA_CODE_PUNISHING_AUTHORITY key.
		///		FK_SA_PUNISH_BYLAW_AUTH_SA_CODE_PUNISHING_AUTHORITY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodePunishingAuthorityId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPunishBylawAuth objects.</returns>
		public TList<SaPunishBylawAuth> GetBySaCodePunishingAuthorityId(TransactionManager transactionManager, System.Decimal _saCodePunishingAuthorityId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodePunishingAuthorityId(transactionManager, _saCodePunishingAuthorityId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PUNISH_BYLAW_AUTH_SA_CODE_PUNISHING_AUTHORITY key.
		///		fkSaPunishBylawAuthSaCodePunishingAuthority Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saCodePunishingAuthorityId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPunishBylawAuth objects.</returns>
		public TList<SaPunishBylawAuth> GetBySaCodePunishingAuthorityId(System.Decimal _saCodePunishingAuthorityId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaCodePunishingAuthorityId(null, _saCodePunishingAuthorityId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PUNISH_BYLAW_AUTH_SA_CODE_PUNISHING_AUTHORITY key.
		///		fkSaPunishBylawAuthSaCodePunishingAuthority Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saCodePunishingAuthorityId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPunishBylawAuth objects.</returns>
		public TList<SaPunishBylawAuth> GetBySaCodePunishingAuthorityId(System.Decimal _saCodePunishingAuthorityId, int start, int pageLength,out int count)
		{
			return GetBySaCodePunishingAuthorityId(null, _saCodePunishingAuthorityId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PUNISH_BYLAW_AUTH_SA_CODE_PUNISHING_AUTHORITY key.
		///		FK_SA_PUNISH_BYLAW_AUTH_SA_CODE_PUNISHING_AUTHORITY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodePunishingAuthorityId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPunishBylawAuth objects.</returns>
		public abstract TList<SaPunishBylawAuth> GetBySaCodePunishingAuthorityId(TransactionManager transactionManager, System.Decimal _saCodePunishingAuthorityId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PUNISH_BYLAW_AUTH_SA_PUNISHMENT_BYLAWS key.
		///		FK_SA_PUNISH_BYLAW_AUTH_SA_PUNISHMENT_BYLAWS Description: 
		/// </summary>
		/// <param name="_saPunishmentBylawsId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPunishBylawAuth objects.</returns>
		public TList<SaPunishBylawAuth> GetBySaPunishmentBylawsId(System.Decimal _saPunishmentBylawsId)
		{
			int count = -1;
			return GetBySaPunishmentBylawsId(_saPunishmentBylawsId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PUNISH_BYLAW_AUTH_SA_PUNISHMENT_BYLAWS key.
		///		FK_SA_PUNISH_BYLAW_AUTH_SA_PUNISHMENT_BYLAWS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saPunishmentBylawsId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPunishBylawAuth objects.</returns>
		/// <remarks></remarks>
		public TList<SaPunishBylawAuth> GetBySaPunishmentBylawsId(TransactionManager transactionManager, System.Decimal _saPunishmentBylawsId)
		{
			int count = -1;
			return GetBySaPunishmentBylawsId(transactionManager, _saPunishmentBylawsId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PUNISH_BYLAW_AUTH_SA_PUNISHMENT_BYLAWS key.
		///		FK_SA_PUNISH_BYLAW_AUTH_SA_PUNISHMENT_BYLAWS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saPunishmentBylawsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPunishBylawAuth objects.</returns>
		public TList<SaPunishBylawAuth> GetBySaPunishmentBylawsId(TransactionManager transactionManager, System.Decimal _saPunishmentBylawsId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaPunishmentBylawsId(transactionManager, _saPunishmentBylawsId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PUNISH_BYLAW_AUTH_SA_PUNISHMENT_BYLAWS key.
		///		fkSaPunishBylawAuthSaPunishmentBylaws Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saPunishmentBylawsId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPunishBylawAuth objects.</returns>
		public TList<SaPunishBylawAuth> GetBySaPunishmentBylawsId(System.Decimal _saPunishmentBylawsId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySaPunishmentBylawsId(null, _saPunishmentBylawsId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PUNISH_BYLAW_AUTH_SA_PUNISHMENT_BYLAWS key.
		///		fkSaPunishBylawAuthSaPunishmentBylaws Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_saPunishmentBylawsId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPunishBylawAuth objects.</returns>
		public TList<SaPunishBylawAuth> GetBySaPunishmentBylawsId(System.Decimal _saPunishmentBylawsId, int start, int pageLength,out int count)
		{
			return GetBySaPunishmentBylawsId(null, _saPunishmentBylawsId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SA_PUNISH_BYLAW_AUTH_SA_PUNISHMENT_BYLAWS key.
		///		FK_SA_PUNISH_BYLAW_AUTH_SA_PUNISHMENT_BYLAWS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saPunishmentBylawsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SaPunishBylawAuth objects.</returns>
		public abstract TList<SaPunishBylawAuth> GetBySaPunishmentBylawsId(TransactionManager transactionManager, System.Decimal _saPunishmentBylawsId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SaPunishBylawAuth Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaPunishBylawAuthKey key, int start, int pageLength)
		{
			return GetBySaPunishBylawAuthId(transactionManager, key.SaPunishBylawAuthId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SA_PUNISH_BYLAW_AUTH index.
		/// </summary>
		/// <param name="_saPunishBylawAuthId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaPunishBylawAuth"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaPunishBylawAuth GetBySaPunishBylawAuthId(System.Decimal _saPunishBylawAuthId)
		{
			int count = -1;
			return GetBySaPunishBylawAuthId(null,_saPunishBylawAuthId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_PUNISH_BYLAW_AUTH index.
		/// </summary>
		/// <param name="_saPunishBylawAuthId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaPunishBylawAuth"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaPunishBylawAuth GetBySaPunishBylawAuthId(System.Decimal _saPunishBylawAuthId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaPunishBylawAuthId(null, _saPunishBylawAuthId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_PUNISH_BYLAW_AUTH index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saPunishBylawAuthId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaPunishBylawAuth"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaPunishBylawAuth GetBySaPunishBylawAuthId(TransactionManager transactionManager, System.Decimal _saPunishBylawAuthId)
		{
			int count = -1;
			return GetBySaPunishBylawAuthId(transactionManager, _saPunishBylawAuthId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_PUNISH_BYLAW_AUTH index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saPunishBylawAuthId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaPunishBylawAuth"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaPunishBylawAuth GetBySaPunishBylawAuthId(TransactionManager transactionManager, System.Decimal _saPunishBylawAuthId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaPunishBylawAuthId(transactionManager, _saPunishBylawAuthId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_PUNISH_BYLAW_AUTH index.
		/// </summary>
		/// <param name="_saPunishBylawAuthId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaPunishBylawAuth"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaPunishBylawAuth GetBySaPunishBylawAuthId(System.Decimal _saPunishBylawAuthId, int start, int pageLength, out int count)
		{
			return GetBySaPunishBylawAuthId(null, _saPunishBylawAuthId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_PUNISH_BYLAW_AUTH index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saPunishBylawAuthId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaPunishBylawAuth"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SaPunishBylawAuth GetBySaPunishBylawAuthId(TransactionManager transactionManager, System.Decimal _saPunishBylawAuthId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SaPunishBylawAuth&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SaPunishBylawAuth&gt;"/></returns>
		public static TList<SaPunishBylawAuth> Fill(IDataReader reader, TList<SaPunishBylawAuth> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SaPunishBylawAuth c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SaPunishBylawAuth")
					.Append("|").Append((System.Decimal)reader["SA_PUNISH_BYLAW_AUTH_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SaPunishBylawAuth>(
					key.ToString(), // EntityTrackingKey
					"SaPunishBylawAuth",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SaPunishBylawAuth();
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
					c.SaPunishBylawAuthId = (System.Decimal)reader["SA_PUNISH_BYLAW_AUTH_ID"];
					c.OriginalSaPunishBylawAuthId = c.SaPunishBylawAuthId;
					c.SaPunishmentBylawsId = (System.Decimal)reader["SA_PUNISHMENT_BYLAWS_ID"];
					c.SaCodePunishingAuthorityId = (System.Decimal)reader["SA_CODE_PUNISHING_AUTHORITY_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaPunishBylawAuth"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaPunishBylawAuth"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SaPunishBylawAuth entity)
		{
			if (!reader.Read()) return;
			
			entity.SaPunishBylawAuthId = (System.Decimal)reader[((int)SaPunishBylawAuthColumn.SaPunishBylawAuthId - 1)];
			entity.OriginalSaPunishBylawAuthId = (System.Decimal)reader["SA_PUNISH_BYLAW_AUTH_ID"];
			entity.SaPunishmentBylawsId = (System.Decimal)reader[((int)SaPunishBylawAuthColumn.SaPunishmentBylawsId - 1)];
			entity.SaCodePunishingAuthorityId = (System.Decimal)reader[((int)SaPunishBylawAuthColumn.SaCodePunishingAuthorityId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaPunishBylawAuth"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaPunishBylawAuth"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SaPunishBylawAuth entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SaPunishBylawAuthId = (System.Decimal)dataRow["SA_PUNISH_BYLAW_AUTH_ID"];
			entity.OriginalSaPunishBylawAuthId = (System.Decimal)dataRow["SA_PUNISH_BYLAW_AUTH_ID"];
			entity.SaPunishmentBylawsId = (System.Decimal)dataRow["SA_PUNISHMENT_BYLAWS_ID"];
			entity.SaCodePunishingAuthorityId = (System.Decimal)dataRow["SA_CODE_PUNISHING_AUTHORITY_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaPunishBylawAuth"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaPunishBylawAuth Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaPunishBylawAuth entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region SaCodePunishingAuthorityIdSource	
			if (CanDeepLoad(entity, "SaCodePunishingAuthority|SaCodePunishingAuthorityIdSource", deepLoadType, innerList) 
				&& entity.SaCodePunishingAuthorityIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SaCodePunishingAuthorityId;
				SaCodePunishingAuthority tmpEntity = EntityManager.LocateEntity<SaCodePunishingAuthority>(EntityLocator.ConstructKeyFromPkItems(typeof(SaCodePunishingAuthority), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaCodePunishingAuthorityIdSource = tmpEntity;
				else
					entity.SaCodePunishingAuthorityIdSource = DataRepository.SaCodePunishingAuthorityProvider.GetBySaCodePunishingAuthorityId(transactionManager, entity.SaCodePunishingAuthorityId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaCodePunishingAuthorityIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaCodePunishingAuthorityIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaCodePunishingAuthorityProvider.DeepLoad(transactionManager, entity.SaCodePunishingAuthorityIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaCodePunishingAuthorityIdSource

			#region SaPunishmentBylawsIdSource	
			if (CanDeepLoad(entity, "SaPunishmentBylaws|SaPunishmentBylawsIdSource", deepLoadType, innerList) 
				&& entity.SaPunishmentBylawsIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SaPunishmentBylawsId;
				SaPunishmentBylaws tmpEntity = EntityManager.LocateEntity<SaPunishmentBylaws>(EntityLocator.ConstructKeyFromPkItems(typeof(SaPunishmentBylaws), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaPunishmentBylawsIdSource = tmpEntity;
				else
					entity.SaPunishmentBylawsIdSource = DataRepository.SaPunishmentBylawsProvider.GetBySaPunishmentBylawsId(transactionManager, entity.SaPunishmentBylawsId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaPunishmentBylawsIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaPunishmentBylawsIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaPunishmentBylawsProvider.DeepLoad(transactionManager, entity.SaPunishmentBylawsIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaPunishmentBylawsIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetBySaPunishBylawAuthId methods when available
			
			#region SaPunishmentCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaPunishment>|SaPunishmentCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaPunishmentCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaPunishmentCollection = DataRepository.SaPunishmentProvider.GetBySaPunishBylawAuthId(transactionManager, entity.SaPunishBylawAuthId);

				if (deep && entity.SaPunishmentCollection.Count > 0)
				{
					deepHandles.Add("SaPunishmentCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaPunishment>) DataRepository.SaPunishmentProvider.DeepLoad,
						new object[] { transactionManager, entity.SaPunishmentCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SaPunishBylawAuth object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SaPunishBylawAuth instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaPunishBylawAuth Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaPunishBylawAuth entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region SaCodePunishingAuthorityIdSource
			if (CanDeepSave(entity, "SaCodePunishingAuthority|SaCodePunishingAuthorityIdSource", deepSaveType, innerList) 
				&& entity.SaCodePunishingAuthorityIdSource != null)
			{
				DataRepository.SaCodePunishingAuthorityProvider.Save(transactionManager, entity.SaCodePunishingAuthorityIdSource);
				entity.SaCodePunishingAuthorityId = entity.SaCodePunishingAuthorityIdSource.SaCodePunishingAuthorityId;
			}
			#endregion 
			
			#region SaPunishmentBylawsIdSource
			if (CanDeepSave(entity, "SaPunishmentBylaws|SaPunishmentBylawsIdSource", deepSaveType, innerList) 
				&& entity.SaPunishmentBylawsIdSource != null)
			{
				DataRepository.SaPunishmentBylawsProvider.Save(transactionManager, entity.SaPunishmentBylawsIdSource);
				entity.SaPunishmentBylawsId = entity.SaPunishmentBylawsIdSource.SaPunishmentBylawsId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<SaPunishment>
				if (CanDeepSave(entity.SaPunishmentCollection, "List<SaPunishment>|SaPunishmentCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaPunishment child in entity.SaPunishmentCollection)
					{
						if(child.SaPunishBylawAuthIdSource != null)
						{
							child.SaPunishBylawAuthId = child.SaPunishBylawAuthIdSource.SaPunishBylawAuthId;
						}
						else
						{
							child.SaPunishBylawAuthId = entity.SaPunishBylawAuthId;
						}

					}

					if (entity.SaPunishmentCollection.Count > 0 || entity.SaPunishmentCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaPunishmentProvider.Save(transactionManager, entity.SaPunishmentCollection);
						
						deepHandles.Add("SaPunishmentCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaPunishment >) DataRepository.SaPunishmentProvider.DeepSave,
							new object[] { transactionManager, entity.SaPunishmentCollection, deepSaveType, childTypes, innerList }
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
	
	#region SaPunishBylawAuthChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SaPunishBylawAuth</c>
	///</summary>
	public enum SaPunishBylawAuthChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>SaCodePunishingAuthority</c> at SaCodePunishingAuthorityIdSource
		///</summary>
		[ChildEntityType(typeof(SaCodePunishingAuthority))]
		SaCodePunishingAuthority,
		
		///<summary>
		/// Composite Property for <c>SaPunishmentBylaws</c> at SaPunishmentBylawsIdSource
		///</summary>
		[ChildEntityType(typeof(SaPunishmentBylaws))]
		SaPunishmentBylaws,
		///<summary>
		/// Collection of <c>SaPunishBylawAuth</c> as OneToMany for SaPunishmentCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaPunishment>))]
		SaPunishmentCollection,
	}
	
	#endregion SaPunishBylawAuthChildEntityTypes
	
	#region SaPunishBylawAuthFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SaPunishBylawAuthColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaPunishBylawAuth"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaPunishBylawAuthFilterBuilder : SqlFilterBuilder<SaPunishBylawAuthColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaPunishBylawAuthFilterBuilder class.
		/// </summary>
		public SaPunishBylawAuthFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaPunishBylawAuthFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaPunishBylawAuthFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaPunishBylawAuthFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaPunishBylawAuthFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaPunishBylawAuthFilterBuilder
	
	#region SaPunishBylawAuthParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SaPunishBylawAuthColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaPunishBylawAuth"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaPunishBylawAuthParameterBuilder : ParameterizedSqlFilterBuilder<SaPunishBylawAuthColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaPunishBylawAuthParameterBuilder class.
		/// </summary>
		public SaPunishBylawAuthParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaPunishBylawAuthParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaPunishBylawAuthParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaPunishBylawAuthParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaPunishBylawAuthParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaPunishBylawAuthParameterBuilder
	
	#region SaPunishBylawAuthSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SaPunishBylawAuthColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaPunishBylawAuth"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SaPunishBylawAuthSortBuilder : SqlSortBuilder<SaPunishBylawAuthColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaPunishBylawAuthSqlSortBuilder class.
		/// </summary>
		public SaPunishBylawAuthSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SaPunishBylawAuthSortBuilder
	
} // end namespace
