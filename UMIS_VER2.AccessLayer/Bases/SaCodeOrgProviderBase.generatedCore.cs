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
	/// This class is the base class for any <see cref="SaCodeOrgProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SaCodeOrgProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SaCodeOrg, UMIS_VER2.BusinessLyer.SaCodeOrgKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeOrgKey key)
		{
			return Delete(transactionManager, key.SaCodeOrgId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_saCodeOrgId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _saCodeOrgId)
		{
			return Delete(null, _saCodeOrgId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeOrgId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _saCodeOrgId);		
		
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
		public override UMIS_VER2.BusinessLyer.SaCodeOrg Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeOrgKey key, int start, int pageLength)
		{
			return GetBySaCodeOrgId(transactionManager, key.SaCodeOrgId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_GS_CONTACT_METHOD_H__1 index.
		/// </summary>
		/// <param name="_gsContactMethodHId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCodeOrg&gt;"/> class.</returns>
		public TList<SaCodeOrg> GetByGsContactMethodHId(System.Decimal _gsContactMethodHId)
		{
			int count = -1;
			return GetByGsContactMethodHId(null,_gsContactMethodHId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CONTACT_METHOD_H__1 index.
		/// </summary>
		/// <param name="_gsContactMethodHId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCodeOrg&gt;"/> class.</returns>
		public TList<SaCodeOrg> GetByGsContactMethodHId(System.Decimal _gsContactMethodHId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsContactMethodHId(null, _gsContactMethodHId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CONTACT_METHOD_H__1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsContactMethodHId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCodeOrg&gt;"/> class.</returns>
		public TList<SaCodeOrg> GetByGsContactMethodHId(TransactionManager transactionManager, System.Decimal _gsContactMethodHId)
		{
			int count = -1;
			return GetByGsContactMethodHId(transactionManager, _gsContactMethodHId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CONTACT_METHOD_H__1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsContactMethodHId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCodeOrg&gt;"/> class.</returns>
		public TList<SaCodeOrg> GetByGsContactMethodHId(TransactionManager transactionManager, System.Decimal _gsContactMethodHId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsContactMethodHId(transactionManager, _gsContactMethodHId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CONTACT_METHOD_H__1 index.
		/// </summary>
		/// <param name="_gsContactMethodHId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCodeOrg&gt;"/> class.</returns>
		public TList<SaCodeOrg> GetByGsContactMethodHId(System.Decimal _gsContactMethodHId, int start, int pageLength, out int count)
		{
			return GetByGsContactMethodHId(null, _gsContactMethodHId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CONTACT_METHOD_H__1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsContactMethodHId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCodeOrg&gt;"/> class.</returns>
		public abstract TList<SaCodeOrg> GetByGsContactMethodHId(TransactionManager transactionManager, System.Decimal _gsContactMethodHId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_GS_COUNTRY_NODE_ID_1 index.
		/// </summary>
		/// <param name="_gsCountryNodeId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCodeOrg&gt;"/> class.</returns>
		public TList<SaCodeOrg> GetByGsCountryNodeId(System.Decimal _gsCountryNodeId)
		{
			int count = -1;
			return GetByGsCountryNodeId(null,_gsCountryNodeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_COUNTRY_NODE_ID_1 index.
		/// </summary>
		/// <param name="_gsCountryNodeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCodeOrg&gt;"/> class.</returns>
		public TList<SaCodeOrg> GetByGsCountryNodeId(System.Decimal _gsCountryNodeId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCountryNodeId(null, _gsCountryNodeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_COUNTRY_NODE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryNodeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCodeOrg&gt;"/> class.</returns>
		public TList<SaCodeOrg> GetByGsCountryNodeId(TransactionManager transactionManager, System.Decimal _gsCountryNodeId)
		{
			int count = -1;
			return GetByGsCountryNodeId(transactionManager, _gsCountryNodeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_COUNTRY_NODE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryNodeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCodeOrg&gt;"/> class.</returns>
		public TList<SaCodeOrg> GetByGsCountryNodeId(TransactionManager transactionManager, System.Decimal _gsCountryNodeId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCountryNodeId(transactionManager, _gsCountryNodeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_COUNTRY_NODE_ID_1 index.
		/// </summary>
		/// <param name="_gsCountryNodeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCodeOrg&gt;"/> class.</returns>
		public TList<SaCodeOrg> GetByGsCountryNodeId(System.Decimal _gsCountryNodeId, int start, int pageLength, out int count)
		{
			return GetByGsCountryNodeId(null, _gsCountryNodeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_COUNTRY_NODE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryNodeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCodeOrg&gt;"/> class.</returns>
		public abstract TList<SaCodeOrg> GetByGsCountryNodeId(TransactionManager transactionManager, System.Decimal _gsCountryNodeId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SA_CODE_ORG index.
		/// </summary>
		/// <param name="_saCodeOrgId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeOrg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeOrg GetBySaCodeOrgId(System.Decimal _saCodeOrgId)
		{
			int count = -1;
			return GetBySaCodeOrgId(null,_saCodeOrgId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_ORG index.
		/// </summary>
		/// <param name="_saCodeOrgId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeOrg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeOrg GetBySaCodeOrgId(System.Decimal _saCodeOrgId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeOrgId(null, _saCodeOrgId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_ORG index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeOrgId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeOrg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeOrg GetBySaCodeOrgId(TransactionManager transactionManager, System.Decimal _saCodeOrgId)
		{
			int count = -1;
			return GetBySaCodeOrgId(transactionManager, _saCodeOrgId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_ORG index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeOrgId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeOrg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeOrg GetBySaCodeOrgId(TransactionManager transactionManager, System.Decimal _saCodeOrgId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeOrgId(transactionManager, _saCodeOrgId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_ORG index.
		/// </summary>
		/// <param name="_saCodeOrgId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeOrg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeOrg GetBySaCodeOrgId(System.Decimal _saCodeOrgId, int start, int pageLength, out int count)
		{
			return GetBySaCodeOrgId(null, _saCodeOrgId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_ORG index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeOrgId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeOrg"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SaCodeOrg GetBySaCodeOrgId(TransactionManager transactionManager, System.Decimal _saCodeOrgId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SaCodeOrg&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SaCodeOrg&gt;"/></returns>
		public static TList<SaCodeOrg> Fill(IDataReader reader, TList<SaCodeOrg> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SaCodeOrg c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SaCodeOrg")
					.Append("|").Append((System.Decimal)reader["SA_CODE_ORG_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SaCodeOrg>(
					key.ToString(), // EntityTrackingKey
					"SaCodeOrg",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SaCodeOrg();
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
					c.SaCodeOrgId = (System.Decimal)reader["SA_CODE_ORG_ID"];
					c.OriginalSaCodeOrgId = c.SaCodeOrgId;
					c.OrgCode = Convert.IsDBNull(reader["ORG_CODE"]) ? null : (System.String)reader["ORG_CODE"];
					c.OrgDescr = (System.String)reader["ORG_DESCR"];
					c.OrgAddress = Convert.IsDBNull(reader["ORG_ADDRESS"]) ? null : (System.String)reader["ORG_ADDRESS"];
					c.GsCountryNodeId = (System.Decimal)reader["GS_COUNTRY_NODE_ID"];
					c.GsContactMethodHId = (System.Decimal)reader["GS_CONTACT_METHOD_H_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaCodeOrg"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCodeOrg"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SaCodeOrg entity)
		{
			if (!reader.Read()) return;
			
			entity.SaCodeOrgId = (System.Decimal)reader[((int)SaCodeOrgColumn.SaCodeOrgId - 1)];
			entity.OriginalSaCodeOrgId = (System.Decimal)reader["SA_CODE_ORG_ID"];
			entity.OrgCode = (reader.IsDBNull(((int)SaCodeOrgColumn.OrgCode - 1)))?null:(System.String)reader[((int)SaCodeOrgColumn.OrgCode - 1)];
			entity.OrgDescr = (System.String)reader[((int)SaCodeOrgColumn.OrgDescr - 1)];
			entity.OrgAddress = (reader.IsDBNull(((int)SaCodeOrgColumn.OrgAddress - 1)))?null:(System.String)reader[((int)SaCodeOrgColumn.OrgAddress - 1)];
			entity.GsCountryNodeId = (System.Decimal)reader[((int)SaCodeOrgColumn.GsCountryNodeId - 1)];
			entity.GsContactMethodHId = (System.Decimal)reader[((int)SaCodeOrgColumn.GsContactMethodHId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaCodeOrg"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCodeOrg"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SaCodeOrg entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SaCodeOrgId = (System.Decimal)dataRow["SA_CODE_ORG_ID"];
			entity.OriginalSaCodeOrgId = (System.Decimal)dataRow["SA_CODE_ORG_ID"];
			entity.OrgCode = Convert.IsDBNull(dataRow["ORG_CODE"]) ? null : (System.String)dataRow["ORG_CODE"];
			entity.OrgDescr = (System.String)dataRow["ORG_DESCR"];
			entity.OrgAddress = Convert.IsDBNull(dataRow["ORG_ADDRESS"]) ? null : (System.String)dataRow["ORG_ADDRESS"];
			entity.GsCountryNodeId = (System.Decimal)dataRow["GS_COUNTRY_NODE_ID"];
			entity.GsContactMethodHId = (System.Decimal)dataRow["GS_CONTACT_METHOD_H_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCodeOrg"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaCodeOrg Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeOrg entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region GsContactMethodHIdSource	
			if (CanDeepLoad(entity, "GsContactMethodH|GsContactMethodHIdSource", deepLoadType, innerList) 
				&& entity.GsContactMethodHIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.GsContactMethodHId;
				GsContactMethodH tmpEntity = EntityManager.LocateEntity<GsContactMethodH>(EntityLocator.ConstructKeyFromPkItems(typeof(GsContactMethodH), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsContactMethodHIdSource = tmpEntity;
				else
					entity.GsContactMethodHIdSource = DataRepository.GsContactMethodHProvider.GetByGsContactMethodHId(transactionManager, entity.GsContactMethodHId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsContactMethodHIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsContactMethodHIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsContactMethodHProvider.DeepLoad(transactionManager, entity.GsContactMethodHIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsContactMethodHIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetBySaCodeOrgId methods when available
			
			#region SaTransferCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaTransfer>|SaTransferCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaTransferCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaTransferCollection = DataRepository.SaTransferProvider.GetBySaCodeOrgId(transactionManager, entity.SaCodeOrgId);

				if (deep && entity.SaTransferCollection.Count > 0)
				{
					deepHandles.Add("SaTransferCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaTransfer>) DataRepository.SaTransferProvider.DeepLoad,
						new object[] { transactionManager, entity.SaTransferCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaExtDelCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaExtDel>|SaExtDelCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaExtDelCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaExtDelCollection = DataRepository.SaExtDelProvider.GetBySaCodeOrgId(transactionManager, entity.SaCodeOrgId);

				if (deep && entity.SaExtDelCollection.Count > 0)
				{
					deepHandles.Add("SaExtDelCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaExtDel>) DataRepository.SaExtDelProvider.DeepLoad,
						new object[] { transactionManager, entity.SaExtDelCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region PgExtMemberCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgExtMember>|PgExtMemberCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgExtMemberCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgExtMemberCollection = DataRepository.PgExtMemberProvider.GetBySaCodeOrgId(transactionManager, entity.SaCodeOrgId);

				if (deep && entity.PgExtMemberCollection.Count > 0)
				{
					deepHandles.Add("PgExtMemberCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgExtMember>) DataRepository.PgExtMemberProvider.DeepLoad,
						new object[] { transactionManager, entity.PgExtMemberCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaExperienceCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaExperience>|SaExperienceCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaExperienceCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaExperienceCollection = DataRepository.SaExperienceProvider.GetBySaCodeOrgId(transactionManager, entity.SaCodeOrgId);

				if (deep && entity.SaExperienceCollection.Count > 0)
				{
					deepHandles.Add("SaExperienceCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaExperience>) DataRepository.SaExperienceProvider.DeepLoad,
						new object[] { transactionManager, entity.SaExperienceCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SaCodeOrg object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SaCodeOrg instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaCodeOrg Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeOrg entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region GsContactMethodHIdSource
			if (CanDeepSave(entity, "GsContactMethodH|GsContactMethodHIdSource", deepSaveType, innerList) 
				&& entity.GsContactMethodHIdSource != null)
			{
				DataRepository.GsContactMethodHProvider.Save(transactionManager, entity.GsContactMethodHIdSource);
				entity.GsContactMethodHId = entity.GsContactMethodHIdSource.GsContactMethodHId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<SaTransfer>
				if (CanDeepSave(entity.SaTransferCollection, "List<SaTransfer>|SaTransferCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaTransfer child in entity.SaTransferCollection)
					{
						if(child.SaCodeOrgIdSource != null)
						{
							child.SaCodeOrgId = child.SaCodeOrgIdSource.SaCodeOrgId;
						}
						else
						{
							child.SaCodeOrgId = entity.SaCodeOrgId;
						}

					}

					if (entity.SaTransferCollection.Count > 0 || entity.SaTransferCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaTransferProvider.Save(transactionManager, entity.SaTransferCollection);
						
						deepHandles.Add("SaTransferCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaTransfer >) DataRepository.SaTransferProvider.DeepSave,
							new object[] { transactionManager, entity.SaTransferCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaExtDel>
				if (CanDeepSave(entity.SaExtDelCollection, "List<SaExtDel>|SaExtDelCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaExtDel child in entity.SaExtDelCollection)
					{
						if(child.SaCodeOrgIdSource != null)
						{
							child.SaCodeOrgId = child.SaCodeOrgIdSource.SaCodeOrgId;
						}
						else
						{
							child.SaCodeOrgId = entity.SaCodeOrgId;
						}

					}

					if (entity.SaExtDelCollection.Count > 0 || entity.SaExtDelCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaExtDelProvider.Save(transactionManager, entity.SaExtDelCollection);
						
						deepHandles.Add("SaExtDelCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaExtDel >) DataRepository.SaExtDelProvider.DeepSave,
							new object[] { transactionManager, entity.SaExtDelCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<PgExtMember>
				if (CanDeepSave(entity.PgExtMemberCollection, "List<PgExtMember>|PgExtMemberCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgExtMember child in entity.PgExtMemberCollection)
					{
						if(child.SaCodeOrgIdSource != null)
						{
							child.SaCodeOrgId = child.SaCodeOrgIdSource.SaCodeOrgId;
						}
						else
						{
							child.SaCodeOrgId = entity.SaCodeOrgId;
						}

					}

					if (entity.PgExtMemberCollection.Count > 0 || entity.PgExtMemberCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgExtMemberProvider.Save(transactionManager, entity.PgExtMemberCollection);
						
						deepHandles.Add("PgExtMemberCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgExtMember >) DataRepository.PgExtMemberProvider.DeepSave,
							new object[] { transactionManager, entity.PgExtMemberCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaExperience>
				if (CanDeepSave(entity.SaExperienceCollection, "List<SaExperience>|SaExperienceCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaExperience child in entity.SaExperienceCollection)
					{
						if(child.SaCodeOrgIdSource != null)
						{
							child.SaCodeOrgId = child.SaCodeOrgIdSource.SaCodeOrgId;
						}
						else
						{
							child.SaCodeOrgId = entity.SaCodeOrgId;
						}

					}

					if (entity.SaExperienceCollection.Count > 0 || entity.SaExperienceCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaExperienceProvider.Save(transactionManager, entity.SaExperienceCollection);
						
						deepHandles.Add("SaExperienceCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaExperience >) DataRepository.SaExperienceProvider.DeepSave,
							new object[] { transactionManager, entity.SaExperienceCollection, deepSaveType, childTypes, innerList }
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
	
	#region SaCodeOrgChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SaCodeOrg</c>
	///</summary>
	public enum SaCodeOrgChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>GsContactMethodH</c> at GsContactMethodHIdSource
		///</summary>
		[ChildEntityType(typeof(GsContactMethodH))]
		GsContactMethodH,
		///<summary>
		/// Collection of <c>SaCodeOrg</c> as OneToMany for SaTransferCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaTransfer>))]
		SaTransferCollection,
		///<summary>
		/// Collection of <c>SaCodeOrg</c> as OneToMany for SaExtDelCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaExtDel>))]
		SaExtDelCollection,
		///<summary>
		/// Collection of <c>SaCodeOrg</c> as OneToMany for PgExtMemberCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgExtMember>))]
		PgExtMemberCollection,
		///<summary>
		/// Collection of <c>SaCodeOrg</c> as OneToMany for SaExperienceCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaExperience>))]
		SaExperienceCollection,
	}
	
	#endregion SaCodeOrgChildEntityTypes
	
	#region SaCodeOrgFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SaCodeOrgColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCodeOrg"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaCodeOrgFilterBuilder : SqlFilterBuilder<SaCodeOrgColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCodeOrgFilterBuilder class.
		/// </summary>
		public SaCodeOrgFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaCodeOrgFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaCodeOrgFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaCodeOrgFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaCodeOrgFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaCodeOrgFilterBuilder
	
	#region SaCodeOrgParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SaCodeOrgColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCodeOrg"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaCodeOrgParameterBuilder : ParameterizedSqlFilterBuilder<SaCodeOrgColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCodeOrgParameterBuilder class.
		/// </summary>
		public SaCodeOrgParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaCodeOrgParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaCodeOrgParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaCodeOrgParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaCodeOrgParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaCodeOrgParameterBuilder
	
	#region SaCodeOrgSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SaCodeOrgColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCodeOrg"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SaCodeOrgSortBuilder : SqlSortBuilder<SaCodeOrgColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCodeOrgSqlSortBuilder class.
		/// </summary>
		public SaCodeOrgSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SaCodeOrgSortBuilder
	
} // end namespace
