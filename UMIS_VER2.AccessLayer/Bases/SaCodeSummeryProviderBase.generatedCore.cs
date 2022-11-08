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
	/// This class is the base class for any <see cref="SaCodeSummeryProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SaCodeSummeryProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SaCodeSummery, UMIS_VER2.BusinessLyer.SaCodeSummeryKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeSummeryKey key)
		{
			return Delete(transactionManager, key.SaCodeSummeryId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_saCodeSummeryId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _saCodeSummeryId)
		{
			return Delete(null, _saCodeSummeryId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeSummeryId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _saCodeSummeryId);		
		
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
		public override UMIS_VER2.BusinessLyer.SaCodeSummery Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeSummeryKey key, int start, int pageLength)
		{
			return GetBySaCodeSummeryId(transactionManager, key.SaCodeSummeryId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_SA_CODE_JOB_STATUS_I_1 index.
		/// </summary>
		/// <param name="_saCodeJobStatusId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCodeSummery&gt;"/> class.</returns>
		public TList<SaCodeSummery> GetBySaCodeJobStatusId(System.Decimal _saCodeJobStatusId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCodeSummery&gt;"/> class.</returns>
		public TList<SaCodeSummery> GetBySaCodeJobStatusId(System.Decimal _saCodeJobStatusId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCodeSummery&gt;"/> class.</returns>
		public TList<SaCodeSummery> GetBySaCodeJobStatusId(TransactionManager transactionManager, System.Decimal _saCodeJobStatusId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCodeSummery&gt;"/> class.</returns>
		public TList<SaCodeSummery> GetBySaCodeJobStatusId(TransactionManager transactionManager, System.Decimal _saCodeJobStatusId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCodeSummery&gt;"/> class.</returns>
		public TList<SaCodeSummery> GetBySaCodeJobStatusId(System.Decimal _saCodeJobStatusId, int start, int pageLength, out int count)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCodeSummery&gt;"/> class.</returns>
		public abstract TList<SaCodeSummery> GetBySaCodeJobStatusId(TransactionManager transactionManager, System.Decimal _saCodeJobStatusId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SA_CODE_SUMMERY index.
		/// </summary>
		/// <param name="_saCodeSummeryId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeSummery"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeSummery GetBySaCodeSummeryId(System.Decimal _saCodeSummeryId)
		{
			int count = -1;
			return GetBySaCodeSummeryId(null,_saCodeSummeryId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_SUMMERY index.
		/// </summary>
		/// <param name="_saCodeSummeryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeSummery"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeSummery GetBySaCodeSummeryId(System.Decimal _saCodeSummeryId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeSummeryId(null, _saCodeSummeryId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_SUMMERY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeSummeryId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeSummery"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeSummery GetBySaCodeSummeryId(TransactionManager transactionManager, System.Decimal _saCodeSummeryId)
		{
			int count = -1;
			return GetBySaCodeSummeryId(transactionManager, _saCodeSummeryId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_SUMMERY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeSummeryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeSummery"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeSummery GetBySaCodeSummeryId(TransactionManager transactionManager, System.Decimal _saCodeSummeryId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeSummeryId(transactionManager, _saCodeSummeryId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_SUMMERY index.
		/// </summary>
		/// <param name="_saCodeSummeryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeSummery"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeSummery GetBySaCodeSummeryId(System.Decimal _saCodeSummeryId, int start, int pageLength, out int count)
		{
			return GetBySaCodeSummeryId(null, _saCodeSummeryId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_SUMMERY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeSummeryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeSummery"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SaCodeSummery GetBySaCodeSummeryId(TransactionManager transactionManager, System.Decimal _saCodeSummeryId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SaCodeSummery&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SaCodeSummery&gt;"/></returns>
		public static TList<SaCodeSummery> Fill(IDataReader reader, TList<SaCodeSummery> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SaCodeSummery c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SaCodeSummery")
					.Append("|").Append((System.Decimal)reader["SA_CODE_SUMMERY_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SaCodeSummery>(
					key.ToString(), // EntityTrackingKey
					"SaCodeSummery",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SaCodeSummery();
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
					c.SaCodeSummeryId = (System.Decimal)reader["SA_CODE_SUMMERY_ID"];
					c.OriginalSaCodeSummeryId = c.SaCodeSummeryId;
					c.TransDesc = (System.String)reader["TRANS_DESC"];
					c.SaCodeJobStatusId = (System.Decimal)reader["SA_CODE_JOB_STATUS_ID"];
					c.JobValidationFlag = (System.Decimal)reader["JOB_VALIDATION_FLAG"];
					c.JobStartStatementFlag = (System.Decimal)reader["JOB_START_STATEMENT_FLAG"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaCodeSummery"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCodeSummery"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SaCodeSummery entity)
		{
			if (!reader.Read()) return;
			
			entity.SaCodeSummeryId = (System.Decimal)reader[((int)SaCodeSummeryColumn.SaCodeSummeryId - 1)];
			entity.OriginalSaCodeSummeryId = (System.Decimal)reader["SA_CODE_SUMMERY_ID"];
			entity.TransDesc = (System.String)reader[((int)SaCodeSummeryColumn.TransDesc - 1)];
			entity.SaCodeJobStatusId = (System.Decimal)reader[((int)SaCodeSummeryColumn.SaCodeJobStatusId - 1)];
			entity.JobValidationFlag = (System.Decimal)reader[((int)SaCodeSummeryColumn.JobValidationFlag - 1)];
			entity.JobStartStatementFlag = (System.Decimal)reader[((int)SaCodeSummeryColumn.JobStartStatementFlag - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaCodeSummery"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCodeSummery"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SaCodeSummery entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SaCodeSummeryId = (System.Decimal)dataRow["SA_CODE_SUMMERY_ID"];
			entity.OriginalSaCodeSummeryId = (System.Decimal)dataRow["SA_CODE_SUMMERY_ID"];
			entity.TransDesc = (System.String)dataRow["TRANS_DESC"];
			entity.SaCodeJobStatusId = (System.Decimal)dataRow["SA_CODE_JOB_STATUS_ID"];
			entity.JobValidationFlag = (System.Decimal)dataRow["JOB_VALIDATION_FLAG"];
			entity.JobStartStatementFlag = (System.Decimal)dataRow["JOB_START_STATEMENT_FLAG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCodeSummery"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaCodeSummery Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeSummery entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetBySaCodeSummeryId methods when available
			
			#region SaStfSummeryTransCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaStfSummeryTrans>|SaStfSummeryTransCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaStfSummeryTransCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaStfSummeryTransCollection = DataRepository.SaStfSummeryTransProvider.GetBySaCodeSummeryId(transactionManager, entity.SaCodeSummeryId);

				if (deep && entity.SaStfSummeryTransCollection.Count > 0)
				{
					deepHandles.Add("SaStfSummeryTransCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaStfSummeryTrans>) DataRepository.SaStfSummeryTransProvider.DeepLoad,
						new object[] { transactionManager, entity.SaStfSummeryTransCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaJobStartStatmentCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaJobStartStatment>|SaJobStartStatmentCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaJobStartStatmentCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaJobStartStatmentCollection = DataRepository.SaJobStartStatmentProvider.GetBySaCodeSummeryId(transactionManager, entity.SaCodeSummeryId);

				if (deep && entity.SaJobStartStatmentCollection.Count > 0)
				{
					deepHandles.Add("SaJobStartStatmentCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaJobStartStatment>) DataRepository.SaJobStartStatmentProvider.DeepLoad,
						new object[] { transactionManager, entity.SaJobStartStatmentCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaCodeJobBeforeStatusCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaCodeJobBeforeStatus>|SaCodeJobBeforeStatusCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaCodeJobBeforeStatusCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaCodeJobBeforeStatusCollection = DataRepository.SaCodeJobBeforeStatusProvider.GetBySaCodeSummeryId(transactionManager, entity.SaCodeSummeryId);

				if (deep && entity.SaCodeJobBeforeStatusCollection.Count > 0)
				{
					deepHandles.Add("SaCodeJobBeforeStatusCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaCodeJobBeforeStatus>) DataRepository.SaCodeJobBeforeStatusProvider.DeepLoad,
						new object[] { transactionManager, entity.SaCodeJobBeforeStatusCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SaCodeSummery object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SaCodeSummery instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaCodeSummery Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeSummery entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<SaStfSummeryTrans>
				if (CanDeepSave(entity.SaStfSummeryTransCollection, "List<SaStfSummeryTrans>|SaStfSummeryTransCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaStfSummeryTrans child in entity.SaStfSummeryTransCollection)
					{
						if(child.SaCodeSummeryIdSource != null)
						{
							child.SaCodeSummeryId = child.SaCodeSummeryIdSource.SaCodeSummeryId;
						}
						else
						{
							child.SaCodeSummeryId = entity.SaCodeSummeryId;
						}

					}

					if (entity.SaStfSummeryTransCollection.Count > 0 || entity.SaStfSummeryTransCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaStfSummeryTransProvider.Save(transactionManager, entity.SaStfSummeryTransCollection);
						
						deepHandles.Add("SaStfSummeryTransCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaStfSummeryTrans >) DataRepository.SaStfSummeryTransProvider.DeepSave,
							new object[] { transactionManager, entity.SaStfSummeryTransCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaJobStartStatment>
				if (CanDeepSave(entity.SaJobStartStatmentCollection, "List<SaJobStartStatment>|SaJobStartStatmentCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaJobStartStatment child in entity.SaJobStartStatmentCollection)
					{
						if(child.SaCodeSummeryIdSource != null)
						{
							child.SaCodeSummeryId = child.SaCodeSummeryIdSource.SaCodeSummeryId;
						}
						else
						{
							child.SaCodeSummeryId = entity.SaCodeSummeryId;
						}

					}

					if (entity.SaJobStartStatmentCollection.Count > 0 || entity.SaJobStartStatmentCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaJobStartStatmentProvider.Save(transactionManager, entity.SaJobStartStatmentCollection);
						
						deepHandles.Add("SaJobStartStatmentCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaJobStartStatment >) DataRepository.SaJobStartStatmentProvider.DeepSave,
							new object[] { transactionManager, entity.SaJobStartStatmentCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaCodeJobBeforeStatus>
				if (CanDeepSave(entity.SaCodeJobBeforeStatusCollection, "List<SaCodeJobBeforeStatus>|SaCodeJobBeforeStatusCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaCodeJobBeforeStatus child in entity.SaCodeJobBeforeStatusCollection)
					{
						if(child.SaCodeSummeryIdSource != null)
						{
							child.SaCodeSummeryId = child.SaCodeSummeryIdSource.SaCodeSummeryId;
						}
						else
						{
							child.SaCodeSummeryId = entity.SaCodeSummeryId;
						}

					}

					if (entity.SaCodeJobBeforeStatusCollection.Count > 0 || entity.SaCodeJobBeforeStatusCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaCodeJobBeforeStatusProvider.Save(transactionManager, entity.SaCodeJobBeforeStatusCollection);
						
						deepHandles.Add("SaCodeJobBeforeStatusCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaCodeJobBeforeStatus >) DataRepository.SaCodeJobBeforeStatusProvider.DeepSave,
							new object[] { transactionManager, entity.SaCodeJobBeforeStatusCollection, deepSaveType, childTypes, innerList }
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
	
	#region SaCodeSummeryChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SaCodeSummery</c>
	///</summary>
	public enum SaCodeSummeryChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>SaCodeJobStatus</c> at SaCodeJobStatusIdSource
		///</summary>
		[ChildEntityType(typeof(SaCodeJobStatus))]
		SaCodeJobStatus,
		///<summary>
		/// Collection of <c>SaCodeSummery</c> as OneToMany for SaStfSummeryTransCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaStfSummeryTrans>))]
		SaStfSummeryTransCollection,
		///<summary>
		/// Collection of <c>SaCodeSummery</c> as OneToMany for SaJobStartStatmentCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaJobStartStatment>))]
		SaJobStartStatmentCollection,
		///<summary>
		/// Collection of <c>SaCodeSummery</c> as OneToMany for SaCodeJobBeforeStatusCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaCodeJobBeforeStatus>))]
		SaCodeJobBeforeStatusCollection,
	}
	
	#endregion SaCodeSummeryChildEntityTypes
	
	#region SaCodeSummeryFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SaCodeSummeryColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCodeSummery"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaCodeSummeryFilterBuilder : SqlFilterBuilder<SaCodeSummeryColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCodeSummeryFilterBuilder class.
		/// </summary>
		public SaCodeSummeryFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaCodeSummeryFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaCodeSummeryFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaCodeSummeryFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaCodeSummeryFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaCodeSummeryFilterBuilder
	
	#region SaCodeSummeryParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SaCodeSummeryColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCodeSummery"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaCodeSummeryParameterBuilder : ParameterizedSqlFilterBuilder<SaCodeSummeryColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCodeSummeryParameterBuilder class.
		/// </summary>
		public SaCodeSummeryParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaCodeSummeryParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaCodeSummeryParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaCodeSummeryParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaCodeSummeryParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaCodeSummeryParameterBuilder
	
	#region SaCodeSummerySortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SaCodeSummeryColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCodeSummery"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SaCodeSummerySortBuilder : SqlSortBuilder<SaCodeSummeryColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCodeSummerySqlSortBuilder class.
		/// </summary>
		public SaCodeSummerySortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SaCodeSummerySortBuilder
	
} // end namespace
