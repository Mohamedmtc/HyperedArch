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
	/// This class is the base class for any <see cref="GsCodeReqStatusProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GsCodeReqStatusProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.GsCodeReqStatus, UMIS_VER2.BusinessLyer.GsCodeReqStatusKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeReqStatusKey key)
		{
			return Delete(transactionManager, key.GsCodeReqStatusId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_gsCodeReqStatusId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _gsCodeReqStatusId)
		{
			return Delete(null, _gsCodeReqStatusId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeReqStatusId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _gsCodeReqStatusId);		
		
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
		public override UMIS_VER2.BusinessLyer.GsCodeReqStatus Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeReqStatusKey key, int start, int pageLength)
		{
			return GetByGsCodeReqStatusId(transactionManager, key.GsCodeReqStatusId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_GS_CODE_REQ_STATUS index.
		/// </summary>
		/// <param name="_gsCodeReqStatusId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeReqStatus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeReqStatus GetByGsCodeReqStatusId(System.Decimal _gsCodeReqStatusId)
		{
			int count = -1;
			return GetByGsCodeReqStatusId(null,_gsCodeReqStatusId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_REQ_STATUS index.
		/// </summary>
		/// <param name="_gsCodeReqStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeReqStatus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeReqStatus GetByGsCodeReqStatusId(System.Decimal _gsCodeReqStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeReqStatusId(null, _gsCodeReqStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_REQ_STATUS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeReqStatusId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeReqStatus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeReqStatus GetByGsCodeReqStatusId(TransactionManager transactionManager, System.Decimal _gsCodeReqStatusId)
		{
			int count = -1;
			return GetByGsCodeReqStatusId(transactionManager, _gsCodeReqStatusId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_REQ_STATUS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeReqStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeReqStatus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeReqStatus GetByGsCodeReqStatusId(TransactionManager transactionManager, System.Decimal _gsCodeReqStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeReqStatusId(transactionManager, _gsCodeReqStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_REQ_STATUS index.
		/// </summary>
		/// <param name="_gsCodeReqStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeReqStatus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeReqStatus GetByGsCodeReqStatusId(System.Decimal _gsCodeReqStatusId, int start, int pageLength, out int count)
		{
			return GetByGsCodeReqStatusId(null, _gsCodeReqStatusId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_REQ_STATUS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeReqStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeReqStatus"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsCodeReqStatus GetByGsCodeReqStatusId(TransactionManager transactionManager, System.Decimal _gsCodeReqStatusId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GsCodeReqStatus&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GsCodeReqStatus&gt;"/></returns>
		public static TList<GsCodeReqStatus> Fill(IDataReader reader, TList<GsCodeReqStatus> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.GsCodeReqStatus c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GsCodeReqStatus")
					.Append("|").Append((System.Decimal)reader["GS_CODE_REQ_STATUS_ID"]).ToString();
					c = EntityManager.LocateOrCreate<GsCodeReqStatus>(
					key.ToString(), // EntityTrackingKey
					"GsCodeReqStatus",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.GsCodeReqStatus();
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
					c.GsCodeReqStatusId = (System.Decimal)reader["GS_CODE_REQ_STATUS_ID"];
					c.OriginalGsCodeReqStatusId = c.GsCodeReqStatusId;
					c.DescrAr = (System.String)reader["DESCR_AR"];
					c.DescrEn = (System.String)reader["DESCR_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCodeReqStatus"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCodeReqStatus"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.GsCodeReqStatus entity)
		{
			if (!reader.Read()) return;
			
			entity.GsCodeReqStatusId = (System.Decimal)reader[((int)GsCodeReqStatusColumn.GsCodeReqStatusId - 1)];
			entity.OriginalGsCodeReqStatusId = (System.Decimal)reader["GS_CODE_REQ_STATUS_ID"];
			entity.DescrAr = (System.String)reader[((int)GsCodeReqStatusColumn.DescrAr - 1)];
			entity.DescrEn = (System.String)reader[((int)GsCodeReqStatusColumn.DescrEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCodeReqStatus"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCodeReqStatus"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.GsCodeReqStatus entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.GsCodeReqStatusId = (System.Decimal)dataRow["GS_CODE_REQ_STATUS_ID"];
			entity.OriginalGsCodeReqStatusId = (System.Decimal)dataRow["GS_CODE_REQ_STATUS_ID"];
			entity.DescrAr = (System.String)dataRow["DESCR_AR"];
			entity.DescrEn = (System.String)dataRow["DESCR_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCodeReqStatus"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCodeReqStatus Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeReqStatus entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByGsCodeReqStatusId methods when available
			
			#region EdStudExecuseReqCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudExecuseReq>|EdStudExecuseReqCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudExecuseReqCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudExecuseReqCollection = DataRepository.EdStudExecuseReqProvider.GetByGsCodeReqStatusId(transactionManager, entity.GsCodeReqStatusId);

				if (deep && entity.EdStudExecuseReqCollection.Count > 0)
				{
					deepHandles.Add("EdStudExecuseReqCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudExecuseReq>) DataRepository.EdStudExecuseReqProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudExecuseReqCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmAppTransReqCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppTransReq>|AdmAppTransReqCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppTransReqCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppTransReqCollection = DataRepository.AdmAppTransReqProvider.GetByGsCodeReqStatusId(transactionManager, entity.GsCodeReqStatusId);

				if (deep && entity.AdmAppTransReqCollection.Count > 0)
				{
					deepHandles.Add("AdmAppTransReqCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppTransReq>) DataRepository.AdmAppTransReqProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppTransReqCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeRefndStdReqCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeRefndStdReq>|FeeRefndStdReqCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeRefndStdReqCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeRefndStdReqCollection = DataRepository.FeeRefndStdReqProvider.GetByGsCodeReqStatusId(transactionManager, entity.GsCodeReqStatusId);

				if (deep && entity.FeeRefndStdReqCollection.Count > 0)
				{
					deepHandles.Add("FeeRefndStdReqCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeRefndStdReq>) DataRepository.FeeRefndStdReqProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeRefndStdReqCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SpoOfferStudExceptionCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SpoOfferStudException>|SpoOfferStudExceptionCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SpoOfferStudExceptionCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SpoOfferStudExceptionCollection = DataRepository.SpoOfferStudExceptionProvider.GetByGsCodeReqStatusId(transactionManager, entity.GsCodeReqStatusId);

				if (deep && entity.SpoOfferStudExceptionCollection.Count > 0)
				{
					deepHandles.Add("SpoOfferStudExceptionCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SpoOfferStudException>) DataRepository.SpoOfferStudExceptionProvider.DeepLoad,
						new object[] { transactionManager, entity.SpoOfferStudExceptionCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region RsrchStudPostponeReqCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<RsrchStudPostponeReq>|RsrchStudPostponeReqCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'RsrchStudPostponeReqCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.RsrchStudPostponeReqCollection = DataRepository.RsrchStudPostponeReqProvider.GetByGsCodeReqStatusId(transactionManager, entity.GsCodeReqStatusId);

				if (deep && entity.RsrchStudPostponeReqCollection.Count > 0)
				{
					deepHandles.Add("RsrchStudPostponeReqCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<RsrchStudPostponeReq>) DataRepository.RsrchStudPostponeReqProvider.DeepLoad,
						new object[] { transactionManager, entity.RsrchStudPostponeReqCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudIntTrnsCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudIntTrns>|EdStudIntTrnsCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudIntTrnsCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudIntTrnsCollection = DataRepository.EdStudIntTrnsProvider.GetByGsCodeReqStatusId(transactionManager, entity.GsCodeReqStatusId);

				if (deep && entity.EdStudIntTrnsCollection.Count > 0)
				{
					deepHandles.Add("EdStudIntTrnsCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudIntTrns>) DataRepository.EdStudIntTrnsProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudIntTrnsCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudCourseRplcCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudCourseRplc>|EdStudCourseRplcCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCourseRplcCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCourseRplcCollection = DataRepository.EdStudCourseRplcProvider.GetByGsCodeReqStatusId(transactionManager, entity.GsCodeReqStatusId);

				if (deep && entity.EdStudCourseRplcCollection.Count > 0)
				{
					deepHandles.Add("EdStudCourseRplcCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCourseRplc>) DataRepository.EdStudCourseRplcProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCourseRplcCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudTransFromReqCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudTransFromReq>|EdStudTransFromReqCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudTransFromReqCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudTransFromReqCollection = DataRepository.EdStudTransFromReqProvider.GetByGsCodeReqStatusId(transactionManager, entity.GsCodeReqStatusId);

				if (deep && entity.EdStudTransFromReqCollection.Count > 0)
				{
					deepHandles.Add("EdStudTransFromReqCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudTransFromReq>) DataRepository.EdStudTransFromReqProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudTransFromReqCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudExcuseCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudExcuse>|EdStudExcuseCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudExcuseCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudExcuseCollection = DataRepository.EdStudExcuseProvider.GetByGsCodeReqStatusId(transactionManager, entity.GsCodeReqStatusId);

				if (deep && entity.EdStudExcuseCollection.Count > 0)
				{
					deepHandles.Add("EdStudExcuseCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudExcuse>) DataRepository.EdStudExcuseProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudExcuseCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudClrncReqCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudClrncReq>|EdStudClrncReqCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudClrncReqCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudClrncReqCollection = DataRepository.EdStudClrncReqProvider.GetByGsCodeReqStatusId(transactionManager, entity.GsCodeReqStatusId);

				if (deep && entity.EdStudClrncReqCollection.Count > 0)
				{
					deepHandles.Add("EdStudClrncReqCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudClrncReq>) DataRepository.EdStudClrncReqProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudClrncReqCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AccomStudPermtReqCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AccomStudPermtReq>|AccomStudPermtReqCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AccomStudPermtReqCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AccomStudPermtReqCollection = DataRepository.AccomStudPermtReqProvider.GetByGsCodeReqStatusId(transactionManager, entity.GsCodeReqStatusId);

				if (deep && entity.AccomStudPermtReqCollection.Count > 0)
				{
					deepHandles.Add("AccomStudPermtReqCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AccomStudPermtReq>) DataRepository.AccomStudPermtReqProvider.DeepLoad,
						new object[] { transactionManager, entity.AccomStudPermtReqCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AccomStudLeaveReqCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AccomStudLeaveReq>|AccomStudLeaveReqCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AccomStudLeaveReqCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AccomStudLeaveReqCollection = DataRepository.AccomStudLeaveReqProvider.GetByGsCodeReqStatusId(transactionManager, entity.GsCodeReqStatusId);

				if (deep && entity.AccomStudLeaveReqCollection.Count > 0)
				{
					deepHandles.Add("AccomStudLeaveReqCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AccomStudLeaveReq>) DataRepository.AccomStudLeaveReqProvider.DeepLoad,
						new object[] { transactionManager, entity.AccomStudLeaveReqCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudExmptReqCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudExmptReq>|EdStudExmptReqCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudExmptReqCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudExmptReqCollection = DataRepository.EdStudExmptReqProvider.GetByGsCodeReqStatusId(transactionManager, entity.GsCodeReqStatusId);

				if (deep && entity.EdStudExmptReqCollection.Count > 0)
				{
					deepHandles.Add("EdStudExmptReqCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudExmptReq>) DataRepository.EdStudExmptReqProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudExmptReqCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region TrnsStudReqCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<TrnsStudReq>|TrnsStudReqCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'TrnsStudReqCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.TrnsStudReqCollection = DataRepository.TrnsStudReqProvider.GetByGsCodeReqStatusId(transactionManager, entity.GsCodeReqStatusId);

				if (deep && entity.TrnsStudReqCollection.Count > 0)
				{
					deepHandles.Add("TrnsStudReqCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<TrnsStudReq>) DataRepository.TrnsStudReqProvider.DeepLoad,
						new object[] { transactionManager, entity.TrnsStudReqCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AccomStudFeedReqCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AccomStudFeedReq>|AccomStudFeedReqCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AccomStudFeedReqCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AccomStudFeedReqCollection = DataRepository.AccomStudFeedReqProvider.GetByGsCodeReqStatusId(transactionManager, entity.GsCodeReqStatusId);

				if (deep && entity.AccomStudFeedReqCollection.Count > 0)
				{
					deepHandles.Add("AccomStudFeedReqCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AccomStudFeedReq>) DataRepository.AccomStudFeedReqProvider.DeepLoad,
						new object[] { transactionManager, entity.AccomStudFeedReqCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AccomStudReqCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AccomStudReq>|AccomStudReqCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AccomStudReqCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AccomStudReqCollection = DataRepository.AccomStudReqProvider.GetByGsCodeReqStatusId(transactionManager, entity.GsCodeReqStatusId);

				if (deep && entity.AccomStudReqCollection.Count > 0)
				{
					deepHandles.Add("AccomStudReqCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AccomStudReq>) DataRepository.AccomStudReqProvider.DeepLoad,
						new object[] { transactionManager, entity.AccomStudReqCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeStudInstallmentRequestCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeStudInstallmentRequest>|FeeStudInstallmentRequestCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudInstallmentRequestCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeStudInstallmentRequestCollection = DataRepository.FeeStudInstallmentRequestProvider.GetByGsCodeReqStatusId(transactionManager, entity.GsCodeReqStatusId);

				if (deep && entity.FeeStudInstallmentRequestCollection.Count > 0)
				{
					deepHandles.Add("FeeStudInstallmentRequestCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudInstallmentRequest>) DataRepository.FeeStudInstallmentRequestProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudInstallmentRequestCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AccomStudGuestReqCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AccomStudGuestReq>|AccomStudGuestReqCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AccomStudGuestReqCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AccomStudGuestReqCollection = DataRepository.AccomStudGuestReqProvider.GetByGsCodeReqStatusId(transactionManager, entity.GsCodeReqStatusId);

				if (deep && entity.AccomStudGuestReqCollection.Count > 0)
				{
					deepHandles.Add("AccomStudGuestReqCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AccomStudGuestReq>) DataRepository.AccomStudGuestReqProvider.DeepLoad,
						new object[] { transactionManager, entity.AccomStudGuestReqCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeStudDiscCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeStudDisc>|FeeStudDiscCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudDiscCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeStudDiscCollection = DataRepository.FeeStudDiscProvider.GetByGsCodeReqStatusId(transactionManager, entity.GsCodeReqStatusId);

				if (deep && entity.FeeStudDiscCollection.Count > 0)
				{
					deepHandles.Add("FeeStudDiscCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudDisc>) DataRepository.FeeStudDiscProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudDiscCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudCourseChngCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudCourseChng>|EdStudCourseChngCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCourseChngCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCourseChngCollection = DataRepository.EdStudCourseChngProvider.GetByGsCodeReqStatusId(transactionManager, entity.GsCodeReqStatusId);

				if (deep && entity.EdStudCourseChngCollection.Count > 0)
				{
					deepHandles.Add("EdStudCourseChngCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCourseChng>) DataRepository.EdStudCourseChngProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCourseChngCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.GsCodeReqStatus object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.GsCodeReqStatus instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCodeReqStatus Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeReqStatus entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<EdStudExecuseReq>
				if (CanDeepSave(entity.EdStudExecuseReqCollection, "List<EdStudExecuseReq>|EdStudExecuseReqCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudExecuseReq child in entity.EdStudExecuseReqCollection)
					{
						if(child.GsCodeReqStatusIdSource != null)
						{
							child.GsCodeReqStatusId = child.GsCodeReqStatusIdSource.GsCodeReqStatusId;
						}
						else
						{
							child.GsCodeReqStatusId = entity.GsCodeReqStatusId;
						}

					}

					if (entity.EdStudExecuseReqCollection.Count > 0 || entity.EdStudExecuseReqCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudExecuseReqProvider.Save(transactionManager, entity.EdStudExecuseReqCollection);
						
						deepHandles.Add("EdStudExecuseReqCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudExecuseReq >) DataRepository.EdStudExecuseReqProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudExecuseReqCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmAppTransReq>
				if (CanDeepSave(entity.AdmAppTransReqCollection, "List<AdmAppTransReq>|AdmAppTransReqCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppTransReq child in entity.AdmAppTransReqCollection)
					{
						if(child.GsCodeReqStatusIdSource != null)
						{
							child.GsCodeReqStatusId = child.GsCodeReqStatusIdSource.GsCodeReqStatusId;
						}
						else
						{
							child.GsCodeReqStatusId = entity.GsCodeReqStatusId;
						}

					}

					if (entity.AdmAppTransReqCollection.Count > 0 || entity.AdmAppTransReqCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppTransReqProvider.Save(transactionManager, entity.AdmAppTransReqCollection);
						
						deepHandles.Add("AdmAppTransReqCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppTransReq >) DataRepository.AdmAppTransReqProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppTransReqCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeRefndStdReq>
				if (CanDeepSave(entity.FeeRefndStdReqCollection, "List<FeeRefndStdReq>|FeeRefndStdReqCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeRefndStdReq child in entity.FeeRefndStdReqCollection)
					{
						if(child.GsCodeReqStatusIdSource != null)
						{
							child.GsCodeReqStatusId = child.GsCodeReqStatusIdSource.GsCodeReqStatusId;
						}
						else
						{
							child.GsCodeReqStatusId = entity.GsCodeReqStatusId;
						}

					}

					if (entity.FeeRefndStdReqCollection.Count > 0 || entity.FeeRefndStdReqCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeRefndStdReqProvider.Save(transactionManager, entity.FeeRefndStdReqCollection);
						
						deepHandles.Add("FeeRefndStdReqCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeRefndStdReq >) DataRepository.FeeRefndStdReqProvider.DeepSave,
							new object[] { transactionManager, entity.FeeRefndStdReqCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SpoOfferStudException>
				if (CanDeepSave(entity.SpoOfferStudExceptionCollection, "List<SpoOfferStudException>|SpoOfferStudExceptionCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SpoOfferStudException child in entity.SpoOfferStudExceptionCollection)
					{
						if(child.GsCodeReqStatusIdSource != null)
						{
							child.GsCodeReqStatusId = child.GsCodeReqStatusIdSource.GsCodeReqStatusId;
						}
						else
						{
							child.GsCodeReqStatusId = entity.GsCodeReqStatusId;
						}

					}

					if (entity.SpoOfferStudExceptionCollection.Count > 0 || entity.SpoOfferStudExceptionCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SpoOfferStudExceptionProvider.Save(transactionManager, entity.SpoOfferStudExceptionCollection);
						
						deepHandles.Add("SpoOfferStudExceptionCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SpoOfferStudException >) DataRepository.SpoOfferStudExceptionProvider.DeepSave,
							new object[] { transactionManager, entity.SpoOfferStudExceptionCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<RsrchStudPostponeReq>
				if (CanDeepSave(entity.RsrchStudPostponeReqCollection, "List<RsrchStudPostponeReq>|RsrchStudPostponeReqCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(RsrchStudPostponeReq child in entity.RsrchStudPostponeReqCollection)
					{
						if(child.GsCodeReqStatusIdSource != null)
						{
							child.GsCodeReqStatusId = child.GsCodeReqStatusIdSource.GsCodeReqStatusId;
						}
						else
						{
							child.GsCodeReqStatusId = entity.GsCodeReqStatusId;
						}

					}

					if (entity.RsrchStudPostponeReqCollection.Count > 0 || entity.RsrchStudPostponeReqCollection.DeletedItems.Count > 0)
					{
						//DataRepository.RsrchStudPostponeReqProvider.Save(transactionManager, entity.RsrchStudPostponeReqCollection);
						
						deepHandles.Add("RsrchStudPostponeReqCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< RsrchStudPostponeReq >) DataRepository.RsrchStudPostponeReqProvider.DeepSave,
							new object[] { transactionManager, entity.RsrchStudPostponeReqCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudIntTrns>
				if (CanDeepSave(entity.EdStudIntTrnsCollection, "List<EdStudIntTrns>|EdStudIntTrnsCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudIntTrns child in entity.EdStudIntTrnsCollection)
					{
						if(child.GsCodeReqStatusIdSource != null)
						{
							child.GsCodeReqStatusId = child.GsCodeReqStatusIdSource.GsCodeReqStatusId;
						}
						else
						{
							child.GsCodeReqStatusId = entity.GsCodeReqStatusId;
						}

					}

					if (entity.EdStudIntTrnsCollection.Count > 0 || entity.EdStudIntTrnsCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudIntTrnsProvider.Save(transactionManager, entity.EdStudIntTrnsCollection);
						
						deepHandles.Add("EdStudIntTrnsCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudIntTrns >) DataRepository.EdStudIntTrnsProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudIntTrnsCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudCourseRplc>
				if (CanDeepSave(entity.EdStudCourseRplcCollection, "List<EdStudCourseRplc>|EdStudCourseRplcCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudCourseRplc child in entity.EdStudCourseRplcCollection)
					{
						if(child.GsCodeReqStatusIdSource != null)
						{
							child.GsCodeReqStatusId = child.GsCodeReqStatusIdSource.GsCodeReqStatusId;
						}
						else
						{
							child.GsCodeReqStatusId = entity.GsCodeReqStatusId;
						}

					}

					if (entity.EdStudCourseRplcCollection.Count > 0 || entity.EdStudCourseRplcCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudCourseRplcProvider.Save(transactionManager, entity.EdStudCourseRplcCollection);
						
						deepHandles.Add("EdStudCourseRplcCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudCourseRplc >) DataRepository.EdStudCourseRplcProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCourseRplcCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudTransFromReq>
				if (CanDeepSave(entity.EdStudTransFromReqCollection, "List<EdStudTransFromReq>|EdStudTransFromReqCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudTransFromReq child in entity.EdStudTransFromReqCollection)
					{
						if(child.GsCodeReqStatusIdSource != null)
						{
							child.GsCodeReqStatusId = child.GsCodeReqStatusIdSource.GsCodeReqStatusId;
						}
						else
						{
							child.GsCodeReqStatusId = entity.GsCodeReqStatusId;
						}

					}

					if (entity.EdStudTransFromReqCollection.Count > 0 || entity.EdStudTransFromReqCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudTransFromReqProvider.Save(transactionManager, entity.EdStudTransFromReqCollection);
						
						deepHandles.Add("EdStudTransFromReqCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudTransFromReq >) DataRepository.EdStudTransFromReqProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudTransFromReqCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudExcuse>
				if (CanDeepSave(entity.EdStudExcuseCollection, "List<EdStudExcuse>|EdStudExcuseCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudExcuse child in entity.EdStudExcuseCollection)
					{
						if(child.GsCodeReqStatusIdSource != null)
						{
							child.GsCodeReqStatusId = child.GsCodeReqStatusIdSource.GsCodeReqStatusId;
						}
						else
						{
							child.GsCodeReqStatusId = entity.GsCodeReqStatusId;
						}

					}

					if (entity.EdStudExcuseCollection.Count > 0 || entity.EdStudExcuseCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudExcuseProvider.Save(transactionManager, entity.EdStudExcuseCollection);
						
						deepHandles.Add("EdStudExcuseCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudExcuse >) DataRepository.EdStudExcuseProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudExcuseCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudClrncReq>
				if (CanDeepSave(entity.EdStudClrncReqCollection, "List<EdStudClrncReq>|EdStudClrncReqCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudClrncReq child in entity.EdStudClrncReqCollection)
					{
						if(child.GsCodeReqStatusIdSource != null)
						{
							child.GsCodeReqStatusId = child.GsCodeReqStatusIdSource.GsCodeReqStatusId;
						}
						else
						{
							child.GsCodeReqStatusId = entity.GsCodeReqStatusId;
						}

					}

					if (entity.EdStudClrncReqCollection.Count > 0 || entity.EdStudClrncReqCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudClrncReqProvider.Save(transactionManager, entity.EdStudClrncReqCollection);
						
						deepHandles.Add("EdStudClrncReqCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudClrncReq >) DataRepository.EdStudClrncReqProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudClrncReqCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AccomStudPermtReq>
				if (CanDeepSave(entity.AccomStudPermtReqCollection, "List<AccomStudPermtReq>|AccomStudPermtReqCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AccomStudPermtReq child in entity.AccomStudPermtReqCollection)
					{
						if(child.GsCodeReqStatusIdSource != null)
						{
							child.GsCodeReqStatusId = child.GsCodeReqStatusIdSource.GsCodeReqStatusId;
						}
						else
						{
							child.GsCodeReqStatusId = entity.GsCodeReqStatusId;
						}

					}

					if (entity.AccomStudPermtReqCollection.Count > 0 || entity.AccomStudPermtReqCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AccomStudPermtReqProvider.Save(transactionManager, entity.AccomStudPermtReqCollection);
						
						deepHandles.Add("AccomStudPermtReqCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AccomStudPermtReq >) DataRepository.AccomStudPermtReqProvider.DeepSave,
							new object[] { transactionManager, entity.AccomStudPermtReqCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AccomStudLeaveReq>
				if (CanDeepSave(entity.AccomStudLeaveReqCollection, "List<AccomStudLeaveReq>|AccomStudLeaveReqCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AccomStudLeaveReq child in entity.AccomStudLeaveReqCollection)
					{
						if(child.GsCodeReqStatusIdSource != null)
						{
							child.GsCodeReqStatusId = child.GsCodeReqStatusIdSource.GsCodeReqStatusId;
						}
						else
						{
							child.GsCodeReqStatusId = entity.GsCodeReqStatusId;
						}

					}

					if (entity.AccomStudLeaveReqCollection.Count > 0 || entity.AccomStudLeaveReqCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AccomStudLeaveReqProvider.Save(transactionManager, entity.AccomStudLeaveReqCollection);
						
						deepHandles.Add("AccomStudLeaveReqCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AccomStudLeaveReq >) DataRepository.AccomStudLeaveReqProvider.DeepSave,
							new object[] { transactionManager, entity.AccomStudLeaveReqCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudExmptReq>
				if (CanDeepSave(entity.EdStudExmptReqCollection, "List<EdStudExmptReq>|EdStudExmptReqCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudExmptReq child in entity.EdStudExmptReqCollection)
					{
						if(child.GsCodeReqStatusIdSource != null)
						{
							child.GsCodeReqStatusId = child.GsCodeReqStatusIdSource.GsCodeReqStatusId;
						}
						else
						{
							child.GsCodeReqStatusId = entity.GsCodeReqStatusId;
						}

					}

					if (entity.EdStudExmptReqCollection.Count > 0 || entity.EdStudExmptReqCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudExmptReqProvider.Save(transactionManager, entity.EdStudExmptReqCollection);
						
						deepHandles.Add("EdStudExmptReqCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudExmptReq >) DataRepository.EdStudExmptReqProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudExmptReqCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<TrnsStudReq>
				if (CanDeepSave(entity.TrnsStudReqCollection, "List<TrnsStudReq>|TrnsStudReqCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(TrnsStudReq child in entity.TrnsStudReqCollection)
					{
						if(child.GsCodeReqStatusIdSource != null)
						{
							child.GsCodeReqStatusId = child.GsCodeReqStatusIdSource.GsCodeReqStatusId;
						}
						else
						{
							child.GsCodeReqStatusId = entity.GsCodeReqStatusId;
						}

					}

					if (entity.TrnsStudReqCollection.Count > 0 || entity.TrnsStudReqCollection.DeletedItems.Count > 0)
					{
						//DataRepository.TrnsStudReqProvider.Save(transactionManager, entity.TrnsStudReqCollection);
						
						deepHandles.Add("TrnsStudReqCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< TrnsStudReq >) DataRepository.TrnsStudReqProvider.DeepSave,
							new object[] { transactionManager, entity.TrnsStudReqCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AccomStudFeedReq>
				if (CanDeepSave(entity.AccomStudFeedReqCollection, "List<AccomStudFeedReq>|AccomStudFeedReqCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AccomStudFeedReq child in entity.AccomStudFeedReqCollection)
					{
						if(child.GsCodeReqStatusIdSource != null)
						{
							child.GsCodeReqStatusId = child.GsCodeReqStatusIdSource.GsCodeReqStatusId;
						}
						else
						{
							child.GsCodeReqStatusId = entity.GsCodeReqStatusId;
						}

					}

					if (entity.AccomStudFeedReqCollection.Count > 0 || entity.AccomStudFeedReqCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AccomStudFeedReqProvider.Save(transactionManager, entity.AccomStudFeedReqCollection);
						
						deepHandles.Add("AccomStudFeedReqCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AccomStudFeedReq >) DataRepository.AccomStudFeedReqProvider.DeepSave,
							new object[] { transactionManager, entity.AccomStudFeedReqCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AccomStudReq>
				if (CanDeepSave(entity.AccomStudReqCollection, "List<AccomStudReq>|AccomStudReqCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AccomStudReq child in entity.AccomStudReqCollection)
					{
						if(child.GsCodeReqStatusIdSource != null)
						{
							child.GsCodeReqStatusId = child.GsCodeReqStatusIdSource.GsCodeReqStatusId;
						}
						else
						{
							child.GsCodeReqStatusId = entity.GsCodeReqStatusId;
						}

					}

					if (entity.AccomStudReqCollection.Count > 0 || entity.AccomStudReqCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AccomStudReqProvider.Save(transactionManager, entity.AccomStudReqCollection);
						
						deepHandles.Add("AccomStudReqCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AccomStudReq >) DataRepository.AccomStudReqProvider.DeepSave,
							new object[] { transactionManager, entity.AccomStudReqCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeStudInstallmentRequest>
				if (CanDeepSave(entity.FeeStudInstallmentRequestCollection, "List<FeeStudInstallmentRequest>|FeeStudInstallmentRequestCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeStudInstallmentRequest child in entity.FeeStudInstallmentRequestCollection)
					{
						if(child.GsCodeReqStatusIdSource != null)
						{
							child.GsCodeReqStatusId = child.GsCodeReqStatusIdSource.GsCodeReqStatusId;
						}
						else
						{
							child.GsCodeReqStatusId = entity.GsCodeReqStatusId;
						}

					}

					if (entity.FeeStudInstallmentRequestCollection.Count > 0 || entity.FeeStudInstallmentRequestCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeStudInstallmentRequestProvider.Save(transactionManager, entity.FeeStudInstallmentRequestCollection);
						
						deepHandles.Add("FeeStudInstallmentRequestCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeStudInstallmentRequest >) DataRepository.FeeStudInstallmentRequestProvider.DeepSave,
							new object[] { transactionManager, entity.FeeStudInstallmentRequestCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AccomStudGuestReq>
				if (CanDeepSave(entity.AccomStudGuestReqCollection, "List<AccomStudGuestReq>|AccomStudGuestReqCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AccomStudGuestReq child in entity.AccomStudGuestReqCollection)
					{
						if(child.GsCodeReqStatusIdSource != null)
						{
							child.GsCodeReqStatusId = child.GsCodeReqStatusIdSource.GsCodeReqStatusId;
						}
						else
						{
							child.GsCodeReqStatusId = entity.GsCodeReqStatusId;
						}

					}

					if (entity.AccomStudGuestReqCollection.Count > 0 || entity.AccomStudGuestReqCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AccomStudGuestReqProvider.Save(transactionManager, entity.AccomStudGuestReqCollection);
						
						deepHandles.Add("AccomStudGuestReqCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AccomStudGuestReq >) DataRepository.AccomStudGuestReqProvider.DeepSave,
							new object[] { transactionManager, entity.AccomStudGuestReqCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeStudDisc>
				if (CanDeepSave(entity.FeeStudDiscCollection, "List<FeeStudDisc>|FeeStudDiscCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeStudDisc child in entity.FeeStudDiscCollection)
					{
						if(child.GsCodeReqStatusIdSource != null)
						{
							child.GsCodeReqStatusId = child.GsCodeReqStatusIdSource.GsCodeReqStatusId;
						}
						else
						{
							child.GsCodeReqStatusId = entity.GsCodeReqStatusId;
						}

					}

					if (entity.FeeStudDiscCollection.Count > 0 || entity.FeeStudDiscCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeStudDiscProvider.Save(transactionManager, entity.FeeStudDiscCollection);
						
						deepHandles.Add("FeeStudDiscCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeStudDisc >) DataRepository.FeeStudDiscProvider.DeepSave,
							new object[] { transactionManager, entity.FeeStudDiscCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudCourseChng>
				if (CanDeepSave(entity.EdStudCourseChngCollection, "List<EdStudCourseChng>|EdStudCourseChngCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudCourseChng child in entity.EdStudCourseChngCollection)
					{
						if(child.GsCodeReqStatusIdSource != null)
						{
							child.GsCodeReqStatusId = child.GsCodeReqStatusIdSource.GsCodeReqStatusId;
						}
						else
						{
							child.GsCodeReqStatusId = entity.GsCodeReqStatusId;
						}

					}

					if (entity.EdStudCourseChngCollection.Count > 0 || entity.EdStudCourseChngCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudCourseChngProvider.Save(transactionManager, entity.EdStudCourseChngCollection);
						
						deepHandles.Add("EdStudCourseChngCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudCourseChng >) DataRepository.EdStudCourseChngProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCourseChngCollection, deepSaveType, childTypes, innerList }
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
	
	#region GsCodeReqStatusChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.GsCodeReqStatus</c>
	///</summary>
	public enum GsCodeReqStatusChildEntityTypes
	{
		///<summary>
		/// Collection of <c>GsCodeReqStatus</c> as OneToMany for EdStudExecuseReqCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudExecuseReq>))]
		EdStudExecuseReqCollection,
		///<summary>
		/// Collection of <c>GsCodeReqStatus</c> as OneToMany for AdmAppTransReqCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppTransReq>))]
		AdmAppTransReqCollection,
		///<summary>
		/// Collection of <c>GsCodeReqStatus</c> as OneToMany for FeeRefndStdReqCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeRefndStdReq>))]
		FeeRefndStdReqCollection,
		///<summary>
		/// Collection of <c>GsCodeReqStatus</c> as OneToMany for SpoOfferStudExceptionCollection
		///</summary>
		[ChildEntityType(typeof(TList<SpoOfferStudException>))]
		SpoOfferStudExceptionCollection,
		///<summary>
		/// Collection of <c>GsCodeReqStatus</c> as OneToMany for RsrchStudPostponeReqCollection
		///</summary>
		[ChildEntityType(typeof(TList<RsrchStudPostponeReq>))]
		RsrchStudPostponeReqCollection,
		///<summary>
		/// Collection of <c>GsCodeReqStatus</c> as OneToMany for EdStudIntTrnsCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudIntTrns>))]
		EdStudIntTrnsCollection,
		///<summary>
		/// Collection of <c>GsCodeReqStatus</c> as OneToMany for EdStudCourseRplcCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCourseRplc>))]
		EdStudCourseRplcCollection,
		///<summary>
		/// Collection of <c>GsCodeReqStatus</c> as OneToMany for EdStudTransFromReqCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudTransFromReq>))]
		EdStudTransFromReqCollection,
		///<summary>
		/// Collection of <c>GsCodeReqStatus</c> as OneToMany for EdStudExcuseCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudExcuse>))]
		EdStudExcuseCollection,
		///<summary>
		/// Collection of <c>GsCodeReqStatus</c> as OneToMany for EdStudClrncReqCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudClrncReq>))]
		EdStudClrncReqCollection,
		///<summary>
		/// Collection of <c>GsCodeReqStatus</c> as OneToMany for AccomStudPermtReqCollection
		///</summary>
		[ChildEntityType(typeof(TList<AccomStudPermtReq>))]
		AccomStudPermtReqCollection,
		///<summary>
		/// Collection of <c>GsCodeReqStatus</c> as OneToMany for AccomStudLeaveReqCollection
		///</summary>
		[ChildEntityType(typeof(TList<AccomStudLeaveReq>))]
		AccomStudLeaveReqCollection,
		///<summary>
		/// Collection of <c>GsCodeReqStatus</c> as OneToMany for EdStudExmptReqCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudExmptReq>))]
		EdStudExmptReqCollection,
		///<summary>
		/// Collection of <c>GsCodeReqStatus</c> as OneToMany for TrnsStudReqCollection
		///</summary>
		[ChildEntityType(typeof(TList<TrnsStudReq>))]
		TrnsStudReqCollection,
		///<summary>
		/// Collection of <c>GsCodeReqStatus</c> as OneToMany for AccomStudFeedReqCollection
		///</summary>
		[ChildEntityType(typeof(TList<AccomStudFeedReq>))]
		AccomStudFeedReqCollection,
		///<summary>
		/// Collection of <c>GsCodeReqStatus</c> as OneToMany for AccomStudReqCollection
		///</summary>
		[ChildEntityType(typeof(TList<AccomStudReq>))]
		AccomStudReqCollection,
		///<summary>
		/// Collection of <c>GsCodeReqStatus</c> as OneToMany for FeeStudInstallmentRequestCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudInstallmentRequest>))]
		FeeStudInstallmentRequestCollection,
		///<summary>
		/// Collection of <c>GsCodeReqStatus</c> as OneToMany for AccomStudGuestReqCollection
		///</summary>
		[ChildEntityType(typeof(TList<AccomStudGuestReq>))]
		AccomStudGuestReqCollection,
		///<summary>
		/// Collection of <c>GsCodeReqStatus</c> as OneToMany for FeeStudDiscCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudDisc>))]
		FeeStudDiscCollection,
		///<summary>
		/// Collection of <c>GsCodeReqStatus</c> as OneToMany for EdStudCourseChngCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCourseChng>))]
		EdStudCourseChngCollection,
	}
	
	#endregion GsCodeReqStatusChildEntityTypes
	
	#region GsCodeReqStatusFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GsCodeReqStatusColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCodeReqStatus"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCodeReqStatusFilterBuilder : SqlFilterBuilder<GsCodeReqStatusColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCodeReqStatusFilterBuilder class.
		/// </summary>
		public GsCodeReqStatusFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCodeReqStatusFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCodeReqStatusFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCodeReqStatusFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCodeReqStatusFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCodeReqStatusFilterBuilder
	
	#region GsCodeReqStatusParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GsCodeReqStatusColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCodeReqStatus"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCodeReqStatusParameterBuilder : ParameterizedSqlFilterBuilder<GsCodeReqStatusColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCodeReqStatusParameterBuilder class.
		/// </summary>
		public GsCodeReqStatusParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCodeReqStatusParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCodeReqStatusParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCodeReqStatusParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCodeReqStatusParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCodeReqStatusParameterBuilder
	
	#region GsCodeReqStatusSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GsCodeReqStatusColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCodeReqStatus"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GsCodeReqStatusSortBuilder : SqlSortBuilder<GsCodeReqStatusColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCodeReqStatusSqlSortBuilder class.
		/// </summary>
		public GsCodeReqStatusSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GsCodeReqStatusSortBuilder
	
} // end namespace
