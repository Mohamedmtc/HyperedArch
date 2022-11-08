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
	/// This class is the base class for any <see cref="SaCodeTrainingOrgProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SaCodeTrainingOrgProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SaCodeTrainingOrg, UMIS_VER2.BusinessLyer.SaCodeTrainingOrgKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeTrainingOrgKey key)
		{
			return Delete(transactionManager, key.SaCodeTrainingOrgId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_saCodeTrainingOrgId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _saCodeTrainingOrgId)
		{
			return Delete(null, _saCodeTrainingOrgId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeTrainingOrgId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _saCodeTrainingOrgId);		
		
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
		public override UMIS_VER2.BusinessLyer.SaCodeTrainingOrg Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeTrainingOrgKey key, int start, int pageLength)
		{
			return GetBySaCodeTrainingOrgId(transactionManager, key.SaCodeTrainingOrgId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_GS_CONTACT_METHOD_H__1 index.
		/// </summary>
		/// <param name="_gsContactMethodHId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCodeTrainingOrg&gt;"/> class.</returns>
		public TList<SaCodeTrainingOrg> GetByGsContactMethodHId(System.Decimal _gsContactMethodHId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCodeTrainingOrg&gt;"/> class.</returns>
		public TList<SaCodeTrainingOrg> GetByGsContactMethodHId(System.Decimal _gsContactMethodHId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCodeTrainingOrg&gt;"/> class.</returns>
		public TList<SaCodeTrainingOrg> GetByGsContactMethodHId(TransactionManager transactionManager, System.Decimal _gsContactMethodHId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCodeTrainingOrg&gt;"/> class.</returns>
		public TList<SaCodeTrainingOrg> GetByGsContactMethodHId(TransactionManager transactionManager, System.Decimal _gsContactMethodHId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCodeTrainingOrg&gt;"/> class.</returns>
		public TList<SaCodeTrainingOrg> GetByGsContactMethodHId(System.Decimal _gsContactMethodHId, int start, int pageLength, out int count)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCodeTrainingOrg&gt;"/> class.</returns>
		public abstract TList<SaCodeTrainingOrg> GetByGsContactMethodHId(TransactionManager transactionManager, System.Decimal _gsContactMethodHId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_GS_COUNTRY_NODE_ID_1 index.
		/// </summary>
		/// <param name="_gsCountryNodeId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCodeTrainingOrg&gt;"/> class.</returns>
		public TList<SaCodeTrainingOrg> GetByGsCountryNodeId(System.Decimal _gsCountryNodeId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCodeTrainingOrg&gt;"/> class.</returns>
		public TList<SaCodeTrainingOrg> GetByGsCountryNodeId(System.Decimal _gsCountryNodeId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCodeTrainingOrg&gt;"/> class.</returns>
		public TList<SaCodeTrainingOrg> GetByGsCountryNodeId(TransactionManager transactionManager, System.Decimal _gsCountryNodeId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCodeTrainingOrg&gt;"/> class.</returns>
		public TList<SaCodeTrainingOrg> GetByGsCountryNodeId(TransactionManager transactionManager, System.Decimal _gsCountryNodeId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCodeTrainingOrg&gt;"/> class.</returns>
		public TList<SaCodeTrainingOrg> GetByGsCountryNodeId(System.Decimal _gsCountryNodeId, int start, int pageLength, out int count)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCodeTrainingOrg&gt;"/> class.</returns>
		public abstract TList<SaCodeTrainingOrg> GetByGsCountryNodeId(TransactionManager transactionManager, System.Decimal _gsCountryNodeId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key SA_CODE_TRAINING_ORG_pk index.
		/// </summary>
		/// <param name="_saCodeTrainingOrgId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeTrainingOrg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeTrainingOrg GetBySaCodeTrainingOrgId(System.Decimal _saCodeTrainingOrgId)
		{
			int count = -1;
			return GetBySaCodeTrainingOrgId(null,_saCodeTrainingOrgId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the SA_CODE_TRAINING_ORG_pk index.
		/// </summary>
		/// <param name="_saCodeTrainingOrgId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeTrainingOrg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeTrainingOrg GetBySaCodeTrainingOrgId(System.Decimal _saCodeTrainingOrgId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeTrainingOrgId(null, _saCodeTrainingOrgId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the SA_CODE_TRAINING_ORG_pk index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeTrainingOrgId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeTrainingOrg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeTrainingOrg GetBySaCodeTrainingOrgId(TransactionManager transactionManager, System.Decimal _saCodeTrainingOrgId)
		{
			int count = -1;
			return GetBySaCodeTrainingOrgId(transactionManager, _saCodeTrainingOrgId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the SA_CODE_TRAINING_ORG_pk index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeTrainingOrgId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeTrainingOrg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeTrainingOrg GetBySaCodeTrainingOrgId(TransactionManager transactionManager, System.Decimal _saCodeTrainingOrgId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeTrainingOrgId(transactionManager, _saCodeTrainingOrgId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the SA_CODE_TRAINING_ORG_pk index.
		/// </summary>
		/// <param name="_saCodeTrainingOrgId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeTrainingOrg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeTrainingOrg GetBySaCodeTrainingOrgId(System.Decimal _saCodeTrainingOrgId, int start, int pageLength, out int count)
		{
			return GetBySaCodeTrainingOrgId(null, _saCodeTrainingOrgId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the SA_CODE_TRAINING_ORG_pk index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeTrainingOrgId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeTrainingOrg"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SaCodeTrainingOrg GetBySaCodeTrainingOrgId(TransactionManager transactionManager, System.Decimal _saCodeTrainingOrgId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SaCodeTrainingOrg&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SaCodeTrainingOrg&gt;"/></returns>
		public static TList<SaCodeTrainingOrg> Fill(IDataReader reader, TList<SaCodeTrainingOrg> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SaCodeTrainingOrg c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SaCodeTrainingOrg")
					.Append("|").Append((System.Decimal)reader["SA_CODE_TRAINING_ORG_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SaCodeTrainingOrg>(
					key.ToString(), // EntityTrackingKey
					"SaCodeTrainingOrg",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SaCodeTrainingOrg();
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
					c.SaCodeTrainingOrgId = (System.Decimal)reader["SA_CODE_TRAINING_ORG_ID"];
					c.OriginalSaCodeTrainingOrgId = c.SaCodeTrainingOrgId;
					c.TraininrgCode = Convert.IsDBNull(reader["TRAININRG_CODE"]) ? null : (System.String)reader["TRAININRG_CODE"];
					c.TraininrgDescr = (System.String)reader["TRAININRG_DESCR"];
					c.TraininrgAddress = Convert.IsDBNull(reader["TRAININRG_ADDRESS"]) ? null : (System.String)reader["TRAININRG_ADDRESS"];
					c.TraininrgContactPerson = Convert.IsDBNull(reader["TRAININRG_CONTACT_PERSON"]) ? null : (System.String)reader["TRAININRG_CONTACT_PERSON"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaCodeTrainingOrg"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCodeTrainingOrg"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SaCodeTrainingOrg entity)
		{
			if (!reader.Read()) return;
			
			entity.SaCodeTrainingOrgId = (System.Decimal)reader[((int)SaCodeTrainingOrgColumn.SaCodeTrainingOrgId - 1)];
			entity.OriginalSaCodeTrainingOrgId = (System.Decimal)reader["SA_CODE_TRAINING_ORG_ID"];
			entity.TraininrgCode = (reader.IsDBNull(((int)SaCodeTrainingOrgColumn.TraininrgCode - 1)))?null:(System.String)reader[((int)SaCodeTrainingOrgColumn.TraininrgCode - 1)];
			entity.TraininrgDescr = (System.String)reader[((int)SaCodeTrainingOrgColumn.TraininrgDescr - 1)];
			entity.TraininrgAddress = (reader.IsDBNull(((int)SaCodeTrainingOrgColumn.TraininrgAddress - 1)))?null:(System.String)reader[((int)SaCodeTrainingOrgColumn.TraininrgAddress - 1)];
			entity.TraininrgContactPerson = (reader.IsDBNull(((int)SaCodeTrainingOrgColumn.TraininrgContactPerson - 1)))?null:(System.String)reader[((int)SaCodeTrainingOrgColumn.TraininrgContactPerson - 1)];
			entity.GsCountryNodeId = (System.Decimal)reader[((int)SaCodeTrainingOrgColumn.GsCountryNodeId - 1)];
			entity.GsContactMethodHId = (System.Decimal)reader[((int)SaCodeTrainingOrgColumn.GsContactMethodHId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaCodeTrainingOrg"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCodeTrainingOrg"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SaCodeTrainingOrg entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SaCodeTrainingOrgId = (System.Decimal)dataRow["SA_CODE_TRAINING_ORG_ID"];
			entity.OriginalSaCodeTrainingOrgId = (System.Decimal)dataRow["SA_CODE_TRAINING_ORG_ID"];
			entity.TraininrgCode = Convert.IsDBNull(dataRow["TRAININRG_CODE"]) ? null : (System.String)dataRow["TRAININRG_CODE"];
			entity.TraininrgDescr = (System.String)dataRow["TRAININRG_DESCR"];
			entity.TraininrgAddress = Convert.IsDBNull(dataRow["TRAININRG_ADDRESS"]) ? null : (System.String)dataRow["TRAININRG_ADDRESS"];
			entity.TraininrgContactPerson = Convert.IsDBNull(dataRow["TRAININRG_CONTACT_PERSON"]) ? null : (System.String)dataRow["TRAININRG_CONTACT_PERSON"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCodeTrainingOrg"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaCodeTrainingOrg Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeTrainingOrg entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
			// Deep load child collections  - Call GetBySaCodeTrainingOrgId methods when available
			
			#region SaTrainingCourseCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaTrainingCourse>|SaTrainingCourseCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaTrainingCourseCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaTrainingCourseCollection = DataRepository.SaTrainingCourseProvider.GetBySaCodeTrainingOrgId(transactionManager, entity.SaCodeTrainingOrgId);

				if (deep && entity.SaTrainingCourseCollection.Count > 0)
				{
					deepHandles.Add("SaTrainingCourseCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaTrainingCourse>) DataRepository.SaTrainingCourseProvider.DeepLoad,
						new object[] { transactionManager, entity.SaTrainingCourseCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SaCodeTrainingOrg object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SaCodeTrainingOrg instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaCodeTrainingOrg Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeTrainingOrg entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<SaTrainingCourse>
				if (CanDeepSave(entity.SaTrainingCourseCollection, "List<SaTrainingCourse>|SaTrainingCourseCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaTrainingCourse child in entity.SaTrainingCourseCollection)
					{
						if(child.SaCodeTrainingOrgIdSource != null)
						{
							child.SaCodeTrainingOrgId = child.SaCodeTrainingOrgIdSource.SaCodeTrainingOrgId;
						}
						else
						{
							child.SaCodeTrainingOrgId = entity.SaCodeTrainingOrgId;
						}

					}

					if (entity.SaTrainingCourseCollection.Count > 0 || entity.SaTrainingCourseCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaTrainingCourseProvider.Save(transactionManager, entity.SaTrainingCourseCollection);
						
						deepHandles.Add("SaTrainingCourseCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaTrainingCourse >) DataRepository.SaTrainingCourseProvider.DeepSave,
							new object[] { transactionManager, entity.SaTrainingCourseCollection, deepSaveType, childTypes, innerList }
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
	
	#region SaCodeTrainingOrgChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SaCodeTrainingOrg</c>
	///</summary>
	public enum SaCodeTrainingOrgChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>GsContactMethodH</c> at GsContactMethodHIdSource
		///</summary>
		[ChildEntityType(typeof(GsContactMethodH))]
		GsContactMethodH,
		///<summary>
		/// Collection of <c>SaCodeTrainingOrg</c> as OneToMany for SaTrainingCourseCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaTrainingCourse>))]
		SaTrainingCourseCollection,
	}
	
	#endregion SaCodeTrainingOrgChildEntityTypes
	
	#region SaCodeTrainingOrgFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SaCodeTrainingOrgColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCodeTrainingOrg"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaCodeTrainingOrgFilterBuilder : SqlFilterBuilder<SaCodeTrainingOrgColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCodeTrainingOrgFilterBuilder class.
		/// </summary>
		public SaCodeTrainingOrgFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaCodeTrainingOrgFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaCodeTrainingOrgFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaCodeTrainingOrgFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaCodeTrainingOrgFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaCodeTrainingOrgFilterBuilder
	
	#region SaCodeTrainingOrgParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SaCodeTrainingOrgColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCodeTrainingOrg"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaCodeTrainingOrgParameterBuilder : ParameterizedSqlFilterBuilder<SaCodeTrainingOrgColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCodeTrainingOrgParameterBuilder class.
		/// </summary>
		public SaCodeTrainingOrgParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaCodeTrainingOrgParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaCodeTrainingOrgParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaCodeTrainingOrgParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaCodeTrainingOrgParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaCodeTrainingOrgParameterBuilder
	
	#region SaCodeTrainingOrgSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SaCodeTrainingOrgColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCodeTrainingOrg"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SaCodeTrainingOrgSortBuilder : SqlSortBuilder<SaCodeTrainingOrgColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCodeTrainingOrgSqlSortBuilder class.
		/// </summary>
		public SaCodeTrainingOrgSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SaCodeTrainingOrgSortBuilder
	
} // end namespace
