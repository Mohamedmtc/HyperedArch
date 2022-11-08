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
	/// This class is the base class for any <see cref="SaCodeJobBeforeStatusProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SaCodeJobBeforeStatusProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SaCodeJobBeforeStatus, UMIS_VER2.BusinessLyer.SaCodeJobBeforeStatusKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeJobBeforeStatusKey key)
		{
			return Delete(transactionManager, key.SaCodeJobBeforeStatusId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_saCodeJobBeforeStatusId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _saCodeJobBeforeStatusId)
		{
			return Delete(null, _saCodeJobBeforeStatusId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeJobBeforeStatusId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _saCodeJobBeforeStatusId);		
		
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
		public override UMIS_VER2.BusinessLyer.SaCodeJobBeforeStatus Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeJobBeforeStatusKey key, int start, int pageLength)
		{
			return GetBySaCodeJobBeforeStatusId(transactionManager, key.SaCodeJobBeforeStatusId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_SA_CODE_JOB_STATUS_I_1 index.
		/// </summary>
		/// <param name="_saCodeJobStatusId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCodeJobBeforeStatus&gt;"/> class.</returns>
		public TList<SaCodeJobBeforeStatus> GetBySaCodeJobStatusId(System.Decimal _saCodeJobStatusId)
		{
			int count = -1;
			return GetBySaCodeJobStatusId(null,_saCodeJobStatusId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_CODE_JOB_STATUS_I_1 index.
		/// </summary>
		/// <param name="_saCodeJobStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCodeJobBeforeStatus&gt;"/> class.</returns>
		public TList<SaCodeJobBeforeStatus> GetBySaCodeJobStatusId(System.Decimal _saCodeJobStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeJobStatusId(null, _saCodeJobStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_CODE_JOB_STATUS_I_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeJobStatusId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCodeJobBeforeStatus&gt;"/> class.</returns>
		public TList<SaCodeJobBeforeStatus> GetBySaCodeJobStatusId(TransactionManager transactionManager, System.Decimal _saCodeJobStatusId)
		{
			int count = -1;
			return GetBySaCodeJobStatusId(transactionManager, _saCodeJobStatusId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_CODE_JOB_STATUS_I_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeJobStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCodeJobBeforeStatus&gt;"/> class.</returns>
		public TList<SaCodeJobBeforeStatus> GetBySaCodeJobStatusId(TransactionManager transactionManager, System.Decimal _saCodeJobStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeJobStatusId(transactionManager, _saCodeJobStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_CODE_JOB_STATUS_I_1 index.
		/// </summary>
		/// <param name="_saCodeJobStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCodeJobBeforeStatus&gt;"/> class.</returns>
		public TList<SaCodeJobBeforeStatus> GetBySaCodeJobStatusId(System.Decimal _saCodeJobStatusId, int start, int pageLength, out int count)
		{
			return GetBySaCodeJobStatusId(null, _saCodeJobStatusId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_CODE_JOB_STATUS_I_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeJobStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCodeJobBeforeStatus&gt;"/> class.</returns>
		public abstract TList<SaCodeJobBeforeStatus> GetBySaCodeJobStatusId(TransactionManager transactionManager, System.Decimal _saCodeJobStatusId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_SA_CODE_SUMMERY_ID_1 index.
		/// </summary>
		/// <param name="_saCodeSummeryId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCodeJobBeforeStatus&gt;"/> class.</returns>
		public TList<SaCodeJobBeforeStatus> GetBySaCodeSummeryId(System.Decimal _saCodeSummeryId)
		{
			int count = -1;
			return GetBySaCodeSummeryId(null,_saCodeSummeryId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_CODE_SUMMERY_ID_1 index.
		/// </summary>
		/// <param name="_saCodeSummeryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCodeJobBeforeStatus&gt;"/> class.</returns>
		public TList<SaCodeJobBeforeStatus> GetBySaCodeSummeryId(System.Decimal _saCodeSummeryId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeSummeryId(null, _saCodeSummeryId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_CODE_SUMMERY_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeSummeryId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCodeJobBeforeStatus&gt;"/> class.</returns>
		public TList<SaCodeJobBeforeStatus> GetBySaCodeSummeryId(TransactionManager transactionManager, System.Decimal _saCodeSummeryId)
		{
			int count = -1;
			return GetBySaCodeSummeryId(transactionManager, _saCodeSummeryId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_CODE_SUMMERY_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeSummeryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCodeJobBeforeStatus&gt;"/> class.</returns>
		public TList<SaCodeJobBeforeStatus> GetBySaCodeSummeryId(TransactionManager transactionManager, System.Decimal _saCodeSummeryId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeSummeryId(transactionManager, _saCodeSummeryId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_CODE_SUMMERY_ID_1 index.
		/// </summary>
		/// <param name="_saCodeSummeryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCodeJobBeforeStatus&gt;"/> class.</returns>
		public TList<SaCodeJobBeforeStatus> GetBySaCodeSummeryId(System.Decimal _saCodeSummeryId, int start, int pageLength, out int count)
		{
			return GetBySaCodeSummeryId(null, _saCodeSummeryId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SA_CODE_SUMMERY_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeSummeryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCodeJobBeforeStatus&gt;"/> class.</returns>
		public abstract TList<SaCodeJobBeforeStatus> GetBySaCodeSummeryId(TransactionManager transactionManager, System.Decimal _saCodeSummeryId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SA_CODE_JOB_BEFORE_STATUS index.
		/// </summary>
		/// <param name="_saCodeJobBeforeStatusId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeJobBeforeStatus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeJobBeforeStatus GetBySaCodeJobBeforeStatusId(System.Decimal _saCodeJobBeforeStatusId)
		{
			int count = -1;
			return GetBySaCodeJobBeforeStatusId(null,_saCodeJobBeforeStatusId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_JOB_BEFORE_STATUS index.
		/// </summary>
		/// <param name="_saCodeJobBeforeStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeJobBeforeStatus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeJobBeforeStatus GetBySaCodeJobBeforeStatusId(System.Decimal _saCodeJobBeforeStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeJobBeforeStatusId(null, _saCodeJobBeforeStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_JOB_BEFORE_STATUS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeJobBeforeStatusId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeJobBeforeStatus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeJobBeforeStatus GetBySaCodeJobBeforeStatusId(TransactionManager transactionManager, System.Decimal _saCodeJobBeforeStatusId)
		{
			int count = -1;
			return GetBySaCodeJobBeforeStatusId(transactionManager, _saCodeJobBeforeStatusId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_JOB_BEFORE_STATUS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeJobBeforeStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeJobBeforeStatus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeJobBeforeStatus GetBySaCodeJobBeforeStatusId(TransactionManager transactionManager, System.Decimal _saCodeJobBeforeStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeJobBeforeStatusId(transactionManager, _saCodeJobBeforeStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_JOB_BEFORE_STATUS index.
		/// </summary>
		/// <param name="_saCodeJobBeforeStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeJobBeforeStatus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeJobBeforeStatus GetBySaCodeJobBeforeStatusId(System.Decimal _saCodeJobBeforeStatusId, int start, int pageLength, out int count)
		{
			return GetBySaCodeJobBeforeStatusId(null, _saCodeJobBeforeStatusId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_JOB_BEFORE_STATUS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeJobBeforeStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeJobBeforeStatus"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SaCodeJobBeforeStatus GetBySaCodeJobBeforeStatusId(TransactionManager transactionManager, System.Decimal _saCodeJobBeforeStatusId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SaCodeJobBeforeStatus&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SaCodeJobBeforeStatus&gt;"/></returns>
		public static TList<SaCodeJobBeforeStatus> Fill(IDataReader reader, TList<SaCodeJobBeforeStatus> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SaCodeJobBeforeStatus c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SaCodeJobBeforeStatus")
					.Append("|").Append((System.Decimal)reader["SA_CODE_JOB_BEFORE_STATUS_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SaCodeJobBeforeStatus>(
					key.ToString(), // EntityTrackingKey
					"SaCodeJobBeforeStatus",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SaCodeJobBeforeStatus();
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
					c.SaCodeJobBeforeStatusId = (System.Decimal)reader["SA_CODE_JOB_BEFORE_STATUS_ID"];
					c.OriginalSaCodeJobBeforeStatusId = c.SaCodeJobBeforeStatusId;
					c.SaCodeSummeryId = (System.Decimal)reader["SA_CODE_SUMMERY_ID"];
					c.SaCodeJobStatusId = (System.Decimal)reader["SA_CODE_JOB_STATUS_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaCodeJobBeforeStatus"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCodeJobBeforeStatus"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SaCodeJobBeforeStatus entity)
		{
			if (!reader.Read()) return;
			
			entity.SaCodeJobBeforeStatusId = (System.Decimal)reader[((int)SaCodeJobBeforeStatusColumn.SaCodeJobBeforeStatusId - 1)];
			entity.OriginalSaCodeJobBeforeStatusId = (System.Decimal)reader["SA_CODE_JOB_BEFORE_STATUS_ID"];
			entity.SaCodeSummeryId = (System.Decimal)reader[((int)SaCodeJobBeforeStatusColumn.SaCodeSummeryId - 1)];
			entity.SaCodeJobStatusId = (System.Decimal)reader[((int)SaCodeJobBeforeStatusColumn.SaCodeJobStatusId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaCodeJobBeforeStatus"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCodeJobBeforeStatus"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SaCodeJobBeforeStatus entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SaCodeJobBeforeStatusId = (System.Decimal)dataRow["SA_CODE_JOB_BEFORE_STATUS_ID"];
			entity.OriginalSaCodeJobBeforeStatusId = (System.Decimal)dataRow["SA_CODE_JOB_BEFORE_STATUS_ID"];
			entity.SaCodeSummeryId = (System.Decimal)dataRow["SA_CODE_SUMMERY_ID"];
			entity.SaCodeJobStatusId = (System.Decimal)dataRow["SA_CODE_JOB_STATUS_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCodeJobBeforeStatus"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaCodeJobBeforeStatus Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeJobBeforeStatus entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region SaCodeJobStatusIdSource	
			if (CanDeepLoad(entity, "SaCodeJobStatus|SaCodeJobStatusIdSource", deepLoadType, innerList) 
				&& entity.SaCodeJobStatusIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SaCodeJobStatusId;
				SaCodeJobStatus tmpEntity = EntityManager.LocateEntity<SaCodeJobStatus>(EntityLocator.ConstructKeyFromPkItems(typeof(SaCodeJobStatus), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SaCodeJobStatusIdSource = tmpEntity;
				else
					entity.SaCodeJobStatusIdSource = DataRepository.SaCodeJobStatusProvider.GetBySaCodeJobStatusId(transactionManager, entity.SaCodeJobStatusId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaCodeJobStatusIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SaCodeJobStatusIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SaCodeJobStatusProvider.DeepLoad(transactionManager, entity.SaCodeJobStatusIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SaCodeJobStatusIdSource

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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SaCodeJobBeforeStatus object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SaCodeJobBeforeStatus instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaCodeJobBeforeStatus Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeJobBeforeStatus entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region SaCodeJobStatusIdSource
			if (CanDeepSave(entity, "SaCodeJobStatus|SaCodeJobStatusIdSource", deepSaveType, innerList) 
				&& entity.SaCodeJobStatusIdSource != null)
			{
				DataRepository.SaCodeJobStatusProvider.Save(transactionManager, entity.SaCodeJobStatusIdSource);
				entity.SaCodeJobStatusId = entity.SaCodeJobStatusIdSource.SaCodeJobStatusId;
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
	
	#region SaCodeJobBeforeStatusChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SaCodeJobBeforeStatus</c>
	///</summary>
	public enum SaCodeJobBeforeStatusChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>SaCodeJobStatus</c> at SaCodeJobStatusIdSource
		///</summary>
		[ChildEntityType(typeof(SaCodeJobStatus))]
		SaCodeJobStatus,
		
		///<summary>
		/// Composite Property for <c>SaCodeSummery</c> at SaCodeSummeryIdSource
		///</summary>
		[ChildEntityType(typeof(SaCodeSummery))]
		SaCodeSummery,
	}
	
	#endregion SaCodeJobBeforeStatusChildEntityTypes
	
	#region SaCodeJobBeforeStatusFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SaCodeJobBeforeStatusColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCodeJobBeforeStatus"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaCodeJobBeforeStatusFilterBuilder : SqlFilterBuilder<SaCodeJobBeforeStatusColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCodeJobBeforeStatusFilterBuilder class.
		/// </summary>
		public SaCodeJobBeforeStatusFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaCodeJobBeforeStatusFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaCodeJobBeforeStatusFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaCodeJobBeforeStatusFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaCodeJobBeforeStatusFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaCodeJobBeforeStatusFilterBuilder
	
	#region SaCodeJobBeforeStatusParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SaCodeJobBeforeStatusColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCodeJobBeforeStatus"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaCodeJobBeforeStatusParameterBuilder : ParameterizedSqlFilterBuilder<SaCodeJobBeforeStatusColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCodeJobBeforeStatusParameterBuilder class.
		/// </summary>
		public SaCodeJobBeforeStatusParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaCodeJobBeforeStatusParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaCodeJobBeforeStatusParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaCodeJobBeforeStatusParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaCodeJobBeforeStatusParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaCodeJobBeforeStatusParameterBuilder
	
	#region SaCodeJobBeforeStatusSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SaCodeJobBeforeStatusColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCodeJobBeforeStatus"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SaCodeJobBeforeStatusSortBuilder : SqlSortBuilder<SaCodeJobBeforeStatusColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCodeJobBeforeStatusSqlSortBuilder class.
		/// </summary>
		public SaCodeJobBeforeStatusSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SaCodeJobBeforeStatusSortBuilder
	
} // end namespace
