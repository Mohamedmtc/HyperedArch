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
	/// This class is the base class for any <see cref="SaCodeJobStatusProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SaCodeJobStatusProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SaCodeJobStatus, UMIS_VER2.BusinessLyer.SaCodeJobStatusKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeJobStatusKey key)
		{
			return Delete(transactionManager, key.SaCodeJobStatusId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_saCodeJobStatusId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _saCodeJobStatusId)
		{
			return Delete(null, _saCodeJobStatusId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeJobStatusId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _saCodeJobStatusId);		
		
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
		public override UMIS_VER2.BusinessLyer.SaCodeJobStatus Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeJobStatusKey key, int start, int pageLength)
		{
			return GetBySaCodeJobStatusId(transactionManager, key.SaCodeJobStatusId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SA_CODE_JOB_STATUS index.
		/// </summary>
		/// <param name="_saCodeJobStatusId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeJobStatus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeJobStatus GetBySaCodeJobStatusId(System.Decimal _saCodeJobStatusId)
		{
			int count = -1;
			return GetBySaCodeJobStatusId(null,_saCodeJobStatusId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_JOB_STATUS index.
		/// </summary>
		/// <param name="_saCodeJobStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeJobStatus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeJobStatus GetBySaCodeJobStatusId(System.Decimal _saCodeJobStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeJobStatusId(null, _saCodeJobStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_JOB_STATUS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeJobStatusId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeJobStatus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeJobStatus GetBySaCodeJobStatusId(TransactionManager transactionManager, System.Decimal _saCodeJobStatusId)
		{
			int count = -1;
			return GetBySaCodeJobStatusId(transactionManager, _saCodeJobStatusId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_JOB_STATUS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeJobStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeJobStatus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeJobStatus GetBySaCodeJobStatusId(TransactionManager transactionManager, System.Decimal _saCodeJobStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeJobStatusId(transactionManager, _saCodeJobStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_JOB_STATUS index.
		/// </summary>
		/// <param name="_saCodeJobStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeJobStatus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeJobStatus GetBySaCodeJobStatusId(System.Decimal _saCodeJobStatusId, int start, int pageLength, out int count)
		{
			return GetBySaCodeJobStatusId(null, _saCodeJobStatusId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_JOB_STATUS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeJobStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeJobStatus"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SaCodeJobStatus GetBySaCodeJobStatusId(TransactionManager transactionManager, System.Decimal _saCodeJobStatusId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SaCodeJobStatus&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SaCodeJobStatus&gt;"/></returns>
		public static TList<SaCodeJobStatus> Fill(IDataReader reader, TList<SaCodeJobStatus> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SaCodeJobStatus c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SaCodeJobStatus")
					.Append("|").Append((System.Decimal)reader["SA_CODE_JOB_STATUS_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SaCodeJobStatus>(
					key.ToString(), // EntityTrackingKey
					"SaCodeJobStatus",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SaCodeJobStatus();
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
					c.SaCodeJobStatusId = (System.Decimal)reader["SA_CODE_JOB_STATUS_ID"];
					c.OriginalSaCodeJobStatusId = c.SaCodeJobStatusId;
					c.JobStatusCode = Convert.IsDBNull(reader["JOB_STATUS_CODE"]) ? null : (System.String)reader["JOB_STATUS_CODE"];
					c.JobStatusDescr = (System.String)reader["JOB_STATUS_DESCR"];
					c.JobStatusDescrEn = Convert.IsDBNull(reader["JOB_STATUS_DESCR_EN"]) ? null : (System.String)reader["JOB_STATUS_DESCR_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaCodeJobStatus"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCodeJobStatus"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SaCodeJobStatus entity)
		{
			if (!reader.Read()) return;
			
			entity.SaCodeJobStatusId = (System.Decimal)reader[((int)SaCodeJobStatusColumn.SaCodeJobStatusId - 1)];
			entity.OriginalSaCodeJobStatusId = (System.Decimal)reader["SA_CODE_JOB_STATUS_ID"];
			entity.JobStatusCode = (reader.IsDBNull(((int)SaCodeJobStatusColumn.JobStatusCode - 1)))?null:(System.String)reader[((int)SaCodeJobStatusColumn.JobStatusCode - 1)];
			entity.JobStatusDescr = (System.String)reader[((int)SaCodeJobStatusColumn.JobStatusDescr - 1)];
			entity.JobStatusDescrEn = (reader.IsDBNull(((int)SaCodeJobStatusColumn.JobStatusDescrEn - 1)))?null:(System.String)reader[((int)SaCodeJobStatusColumn.JobStatusDescrEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaCodeJobStatus"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCodeJobStatus"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SaCodeJobStatus entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SaCodeJobStatusId = (System.Decimal)dataRow["SA_CODE_JOB_STATUS_ID"];
			entity.OriginalSaCodeJobStatusId = (System.Decimal)dataRow["SA_CODE_JOB_STATUS_ID"];
			entity.JobStatusCode = Convert.IsDBNull(dataRow["JOB_STATUS_CODE"]) ? null : (System.String)dataRow["JOB_STATUS_CODE"];
			entity.JobStatusDescr = (System.String)dataRow["JOB_STATUS_DESCR"];
			entity.JobStatusDescrEn = Convert.IsDBNull(dataRow["JOB_STATUS_DESCR_EN"]) ? null : (System.String)dataRow["JOB_STATUS_DESCR_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCodeJobStatus"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaCodeJobStatus Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeJobStatus entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetBySaCodeJobStatusId methods when available
			
			#region SaCodeJobBeforeStatusCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaCodeJobBeforeStatus>|SaCodeJobBeforeStatusCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaCodeJobBeforeStatusCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaCodeJobBeforeStatusCollection = DataRepository.SaCodeJobBeforeStatusProvider.GetBySaCodeJobStatusId(transactionManager, entity.SaCodeJobStatusId);

				if (deep && entity.SaCodeJobBeforeStatusCollection.Count > 0)
				{
					deepHandles.Add("SaCodeJobBeforeStatusCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaCodeJobBeforeStatus>) DataRepository.SaCodeJobBeforeStatusProvider.DeepLoad,
						new object[] { transactionManager, entity.SaCodeJobBeforeStatusCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaStfMemberCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaStfMember>|SaStfMemberCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaStfMemberCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaStfMemberCollection = DataRepository.SaStfMemberProvider.GetBySaCodeJobStatusId(transactionManager, entity.SaCodeJobStatusId);

				if (deep && entity.SaStfMemberCollection.Count > 0)
				{
					deepHandles.Add("SaStfMemberCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaStfMember>) DataRepository.SaStfMemberProvider.DeepLoad,
						new object[] { transactionManager, entity.SaStfMemberCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaServTerminCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaServTermin>|SaServTerminCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaServTerminCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaServTerminCollection = DataRepository.SaServTerminProvider.GetBySaCodeJobStatusId(transactionManager, entity.SaCodeJobStatusId);

				if (deep && entity.SaServTerminCollection.Count > 0)
				{
					deepHandles.Add("SaServTerminCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaServTermin>) DataRepository.SaServTerminProvider.DeepLoad,
						new object[] { transactionManager, entity.SaServTerminCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaCodeSummeryCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaCodeSummery>|SaCodeSummeryCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaCodeSummeryCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaCodeSummeryCollection = DataRepository.SaCodeSummeryProvider.GetBySaCodeJobStatusId(transactionManager, entity.SaCodeJobStatusId);

				if (deep && entity.SaCodeSummeryCollection.Count > 0)
				{
					deepHandles.Add("SaCodeSummeryCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaCodeSummery>) DataRepository.SaCodeSummeryProvider.DeepLoad,
						new object[] { transactionManager, entity.SaCodeSummeryCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaStfSummeryTransCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaStfSummeryTrans>|SaStfSummeryTransCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaStfSummeryTransCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaStfSummeryTransCollection = DataRepository.SaStfSummeryTransProvider.GetBySaCodeJobStatusId(transactionManager, entity.SaCodeJobStatusId);

				if (deep && entity.SaStfSummeryTransCollection.Count > 0)
				{
					deepHandles.Add("SaStfSummeryTransCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaStfSummeryTrans>) DataRepository.SaStfSummeryTransProvider.DeepLoad,
						new object[] { transactionManager, entity.SaStfSummeryTransCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SaCodeJobStatus object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SaCodeJobStatus instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaCodeJobStatus Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeJobStatus entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<SaCodeJobBeforeStatus>
				if (CanDeepSave(entity.SaCodeJobBeforeStatusCollection, "List<SaCodeJobBeforeStatus>|SaCodeJobBeforeStatusCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaCodeJobBeforeStatus child in entity.SaCodeJobBeforeStatusCollection)
					{
						if(child.SaCodeJobStatusIdSource != null)
						{
							child.SaCodeJobStatusId = child.SaCodeJobStatusIdSource.SaCodeJobStatusId;
						}
						else
						{
							child.SaCodeJobStatusId = entity.SaCodeJobStatusId;
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
				
	
			#region List<SaStfMember>
				if (CanDeepSave(entity.SaStfMemberCollection, "List<SaStfMember>|SaStfMemberCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaStfMember child in entity.SaStfMemberCollection)
					{
						if(child.SaCodeJobStatusIdSource != null)
						{
							child.SaCodeJobStatusId = child.SaCodeJobStatusIdSource.SaCodeJobStatusId;
						}
						else
						{
							child.SaCodeJobStatusId = entity.SaCodeJobStatusId;
						}

					}

					if (entity.SaStfMemberCollection.Count > 0 || entity.SaStfMemberCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaStfMemberProvider.Save(transactionManager, entity.SaStfMemberCollection);
						
						deepHandles.Add("SaStfMemberCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaStfMember >) DataRepository.SaStfMemberProvider.DeepSave,
							new object[] { transactionManager, entity.SaStfMemberCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaServTermin>
				if (CanDeepSave(entity.SaServTerminCollection, "List<SaServTermin>|SaServTerminCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaServTermin child in entity.SaServTerminCollection)
					{
						if(child.SaCodeJobStatusIdSource != null)
						{
							child.SaCodeJobStatusId = child.SaCodeJobStatusIdSource.SaCodeJobStatusId;
						}
						else
						{
							child.SaCodeJobStatusId = entity.SaCodeJobStatusId;
						}

					}

					if (entity.SaServTerminCollection.Count > 0 || entity.SaServTerminCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaServTerminProvider.Save(transactionManager, entity.SaServTerminCollection);
						
						deepHandles.Add("SaServTerminCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaServTermin >) DataRepository.SaServTerminProvider.DeepSave,
							new object[] { transactionManager, entity.SaServTerminCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaCodeSummery>
				if (CanDeepSave(entity.SaCodeSummeryCollection, "List<SaCodeSummery>|SaCodeSummeryCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaCodeSummery child in entity.SaCodeSummeryCollection)
					{
						if(child.SaCodeJobStatusIdSource != null)
						{
							child.SaCodeJobStatusId = child.SaCodeJobStatusIdSource.SaCodeJobStatusId;
						}
						else
						{
							child.SaCodeJobStatusId = entity.SaCodeJobStatusId;
						}

					}

					if (entity.SaCodeSummeryCollection.Count > 0 || entity.SaCodeSummeryCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaCodeSummeryProvider.Save(transactionManager, entity.SaCodeSummeryCollection);
						
						deepHandles.Add("SaCodeSummeryCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaCodeSummery >) DataRepository.SaCodeSummeryProvider.DeepSave,
							new object[] { transactionManager, entity.SaCodeSummeryCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaStfSummeryTrans>
				if (CanDeepSave(entity.SaStfSummeryTransCollection, "List<SaStfSummeryTrans>|SaStfSummeryTransCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaStfSummeryTrans child in entity.SaStfSummeryTransCollection)
					{
						if(child.SaCodeJobStatusIdSource != null)
						{
							child.SaCodeJobStatusId = child.SaCodeJobStatusIdSource.SaCodeJobStatusId;
						}
						else
						{
							child.SaCodeJobStatusId = entity.SaCodeJobStatusId;
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
	
	#region SaCodeJobStatusChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SaCodeJobStatus</c>
	///</summary>
	public enum SaCodeJobStatusChildEntityTypes
	{
		///<summary>
		/// Collection of <c>SaCodeJobStatus</c> as OneToMany for SaCodeJobBeforeStatusCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaCodeJobBeforeStatus>))]
		SaCodeJobBeforeStatusCollection,
		///<summary>
		/// Collection of <c>SaCodeJobStatus</c> as OneToMany for SaStfMemberCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaStfMember>))]
		SaStfMemberCollection,
		///<summary>
		/// Collection of <c>SaCodeJobStatus</c> as OneToMany for SaServTerminCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaServTermin>))]
		SaServTerminCollection,
		///<summary>
		/// Collection of <c>SaCodeJobStatus</c> as OneToMany for SaCodeSummeryCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaCodeSummery>))]
		SaCodeSummeryCollection,
		///<summary>
		/// Collection of <c>SaCodeJobStatus</c> as OneToMany for SaStfSummeryTransCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaStfSummeryTrans>))]
		SaStfSummeryTransCollection,
	}
	
	#endregion SaCodeJobStatusChildEntityTypes
	
	#region SaCodeJobStatusFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SaCodeJobStatusColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCodeJobStatus"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaCodeJobStatusFilterBuilder : SqlFilterBuilder<SaCodeJobStatusColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCodeJobStatusFilterBuilder class.
		/// </summary>
		public SaCodeJobStatusFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaCodeJobStatusFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaCodeJobStatusFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaCodeJobStatusFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaCodeJobStatusFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaCodeJobStatusFilterBuilder
	
	#region SaCodeJobStatusParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SaCodeJobStatusColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCodeJobStatus"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaCodeJobStatusParameterBuilder : ParameterizedSqlFilterBuilder<SaCodeJobStatusColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCodeJobStatusParameterBuilder class.
		/// </summary>
		public SaCodeJobStatusParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaCodeJobStatusParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaCodeJobStatusParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaCodeJobStatusParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaCodeJobStatusParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaCodeJobStatusParameterBuilder
	
	#region SaCodeJobStatusSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SaCodeJobStatusColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCodeJobStatus"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SaCodeJobStatusSortBuilder : SqlSortBuilder<SaCodeJobStatusColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCodeJobStatusSqlSortBuilder class.
		/// </summary>
		public SaCodeJobStatusSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SaCodeJobStatusSortBuilder
	
} // end namespace
