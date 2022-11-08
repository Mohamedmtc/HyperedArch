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
	/// This class is the base class for any <see cref="AdmCdeStatusProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AdmCdeStatusProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AdmCdeStatus, UMIS_VER2.BusinessLyer.AdmCdeStatusKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmCdeStatusKey key)
		{
			return Delete(transactionManager, key.AdmCdeStatusId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_admCdeStatusId">حالة الطلب. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _admCdeStatusId)
		{
			return Delete(null, _admCdeStatusId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeStatusId">حالة الطلب. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _admCdeStatusId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_STATUS_SV_AUTO_MSG_TMPLT key.
		///		FK_ADM_CDE_STATUS_SV_AUTO_MSG_TMPLT Description: 
		/// </summary>
		/// <param name="_svAutoMsgTmpltId">notification message</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdeStatus objects.</returns>
		public TList<AdmCdeStatus> GetBySvAutoMsgTmpltId(System.Decimal? _svAutoMsgTmpltId)
		{
			int count = -1;
			return GetBySvAutoMsgTmpltId(_svAutoMsgTmpltId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_STATUS_SV_AUTO_MSG_TMPLT key.
		///		FK_ADM_CDE_STATUS_SV_AUTO_MSG_TMPLT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svAutoMsgTmpltId">notification message</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdeStatus objects.</returns>
		/// <remarks></remarks>
		public TList<AdmCdeStatus> GetBySvAutoMsgTmpltId(TransactionManager transactionManager, System.Decimal? _svAutoMsgTmpltId)
		{
			int count = -1;
			return GetBySvAutoMsgTmpltId(transactionManager, _svAutoMsgTmpltId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_STATUS_SV_AUTO_MSG_TMPLT key.
		///		FK_ADM_CDE_STATUS_SV_AUTO_MSG_TMPLT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svAutoMsgTmpltId">notification message</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdeStatus objects.</returns>
		public TList<AdmCdeStatus> GetBySvAutoMsgTmpltId(TransactionManager transactionManager, System.Decimal? _svAutoMsgTmpltId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvAutoMsgTmpltId(transactionManager, _svAutoMsgTmpltId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_STATUS_SV_AUTO_MSG_TMPLT key.
		///		fkAdmCdeStatusSvAutoMsgTmplt Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_svAutoMsgTmpltId">notification message</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdeStatus objects.</returns>
		public TList<AdmCdeStatus> GetBySvAutoMsgTmpltId(System.Decimal? _svAutoMsgTmpltId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySvAutoMsgTmpltId(null, _svAutoMsgTmpltId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_STATUS_SV_AUTO_MSG_TMPLT key.
		///		fkAdmCdeStatusSvAutoMsgTmplt Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_svAutoMsgTmpltId">notification message</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdeStatus objects.</returns>
		public TList<AdmCdeStatus> GetBySvAutoMsgTmpltId(System.Decimal? _svAutoMsgTmpltId, int start, int pageLength,out int count)
		{
			return GetBySvAutoMsgTmpltId(null, _svAutoMsgTmpltId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_CDE_STATUS_SV_AUTO_MSG_TMPLT key.
		///		FK_ADM_CDE_STATUS_SV_AUTO_MSG_TMPLT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svAutoMsgTmpltId">notification message</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmCdeStatus objects.</returns>
		public abstract TList<AdmCdeStatus> GetBySvAutoMsgTmpltId(TransactionManager transactionManager, System.Decimal? _svAutoMsgTmpltId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.AdmCdeStatus Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmCdeStatusKey key, int start, int pageLength)
		{
			return GetByAdmCdeStatusId(transactionManager, key.AdmCdeStatusId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ADM_CDE_STATUS index.
		/// </summary>
		/// <param name="_admCdeStatusId">حالة الطلب</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdeStatus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCdeStatus GetByAdmCdeStatusId(System.Decimal _admCdeStatusId)
		{
			int count = -1;
			return GetByAdmCdeStatusId(null,_admCdeStatusId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_CDE_STATUS index.
		/// </summary>
		/// <param name="_admCdeStatusId">حالة الطلب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdeStatus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCdeStatus GetByAdmCdeStatusId(System.Decimal _admCdeStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCdeStatusId(null, _admCdeStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_CDE_STATUS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeStatusId">حالة الطلب</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdeStatus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCdeStatus GetByAdmCdeStatusId(TransactionManager transactionManager, System.Decimal _admCdeStatusId)
		{
			int count = -1;
			return GetByAdmCdeStatusId(transactionManager, _admCdeStatusId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_CDE_STATUS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeStatusId">حالة الطلب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdeStatus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCdeStatus GetByAdmCdeStatusId(TransactionManager transactionManager, System.Decimal _admCdeStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCdeStatusId(transactionManager, _admCdeStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_CDE_STATUS index.
		/// </summary>
		/// <param name="_admCdeStatusId">حالة الطلب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdeStatus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCdeStatus GetByAdmCdeStatusId(System.Decimal _admCdeStatusId, int start, int pageLength, out int count)
		{
			return GetByAdmCdeStatusId(null, _admCdeStatusId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_CDE_STATUS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeStatusId">حالة الطلب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdeStatus"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmCdeStatus GetByAdmCdeStatusId(TransactionManager transactionManager, System.Decimal _admCdeStatusId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AdmCdeStatus&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AdmCdeStatus&gt;"/></returns>
		public static TList<AdmCdeStatus> Fill(IDataReader reader, TList<AdmCdeStatus> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AdmCdeStatus c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AdmCdeStatus")
					.Append("|").Append((System.Decimal)reader["ADM_CDE_STATUS_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AdmCdeStatus>(
					key.ToString(), // EntityTrackingKey
					"AdmCdeStatus",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AdmCdeStatus();
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
					c.AdmCdeStatusId = (System.Decimal)reader["ADM_CDE_STATUS_ID"];
					c.OriginalAdmCdeStatusId = c.AdmCdeStatusId;
					c.DescrAr = Convert.IsDBNull(reader["DESCR_AR"]) ? null : (System.String)reader["DESCR_AR"];
					c.DescrEn = Convert.IsDBNull(reader["DESCR_EN"]) ? null : (System.String)reader["DESCR_EN"];
					c.SvAutoMsgTmpltId = Convert.IsDBNull(reader["SV_AUTO_MSG_TMPLT_ID"]) ? null : (System.Decimal?)reader["SV_AUTO_MSG_TMPLT_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmCdeStatus"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmCdeStatus"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AdmCdeStatus entity)
		{
			if (!reader.Read()) return;
			
			entity.AdmCdeStatusId = (System.Decimal)reader[((int)AdmCdeStatusColumn.AdmCdeStatusId - 1)];
			entity.OriginalAdmCdeStatusId = (System.Decimal)reader["ADM_CDE_STATUS_ID"];
			entity.DescrAr = (reader.IsDBNull(((int)AdmCdeStatusColumn.DescrAr - 1)))?null:(System.String)reader[((int)AdmCdeStatusColumn.DescrAr - 1)];
			entity.DescrEn = (reader.IsDBNull(((int)AdmCdeStatusColumn.DescrEn - 1)))?null:(System.String)reader[((int)AdmCdeStatusColumn.DescrEn - 1)];
			entity.SvAutoMsgTmpltId = (reader.IsDBNull(((int)AdmCdeStatusColumn.SvAutoMsgTmpltId - 1)))?null:(System.Decimal?)reader[((int)AdmCdeStatusColumn.SvAutoMsgTmpltId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmCdeStatus"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmCdeStatus"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AdmCdeStatus entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AdmCdeStatusId = (System.Decimal)dataRow["ADM_CDE_STATUS_ID"];
			entity.OriginalAdmCdeStatusId = (System.Decimal)dataRow["ADM_CDE_STATUS_ID"];
			entity.DescrAr = Convert.IsDBNull(dataRow["DESCR_AR"]) ? null : (System.String)dataRow["DESCR_AR"];
			entity.DescrEn = Convert.IsDBNull(dataRow["DESCR_EN"]) ? null : (System.String)dataRow["DESCR_EN"];
			entity.SvAutoMsgTmpltId = Convert.IsDBNull(dataRow["SV_AUTO_MSG_TMPLT_ID"]) ? null : (System.Decimal?)dataRow["SV_AUTO_MSG_TMPLT_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmCdeStatus"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmCdeStatus Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmCdeStatus entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region SvAutoMsgTmpltIdSource	
			if (CanDeepLoad(entity, "SvAutoMsgTmplt|SvAutoMsgTmpltIdSource", deepLoadType, innerList) 
				&& entity.SvAutoMsgTmpltIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SvAutoMsgTmpltId ?? 0.0m);
				SvAutoMsgTmplt tmpEntity = EntityManager.LocateEntity<SvAutoMsgTmplt>(EntityLocator.ConstructKeyFromPkItems(typeof(SvAutoMsgTmplt), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SvAutoMsgTmpltIdSource = tmpEntity;
				else
					entity.SvAutoMsgTmpltIdSource = DataRepository.SvAutoMsgTmpltProvider.GetBySvAutoMsgTmpltId(transactionManager, (entity.SvAutoMsgTmpltId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvAutoMsgTmpltIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SvAutoMsgTmpltIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SvAutoMsgTmpltProvider.DeepLoad(transactionManager, entity.SvAutoMsgTmpltIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SvAutoMsgTmpltIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByAdmCdeStatusId methods when available
			
			#region AdmAppRegHistoryCollectionGetByAdmCdeStatusOldId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppRegHistory>|AdmAppRegHistoryCollectionGetByAdmCdeStatusOldId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppRegHistoryCollectionGetByAdmCdeStatusOldId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppRegHistoryCollectionGetByAdmCdeStatusOldId = DataRepository.AdmAppRegHistoryProvider.GetByAdmCdeStatusOldId(transactionManager, entity.AdmCdeStatusId);

				if (deep && entity.AdmAppRegHistoryCollectionGetByAdmCdeStatusOldId.Count > 0)
				{
					deepHandles.Add("AdmAppRegHistoryCollectionGetByAdmCdeStatusOldId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppRegHistory>) DataRepository.AdmAppRegHistoryProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppRegHistoryCollectionGetByAdmCdeStatusOldId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmCdeAppStatusCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmCdeAppStatus>|AdmCdeAppStatusCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmCdeAppStatusCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmCdeAppStatusCollection = DataRepository.AdmCdeAppStatusProvider.GetByAdmCdeStatusPrereqId(transactionManager, entity.AdmCdeStatusId);

				if (deep && entity.AdmCdeAppStatusCollection.Count > 0)
				{
					deepHandles.Add("AdmCdeAppStatusCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmCdeAppStatus>) DataRepository.AdmCdeAppStatusProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmCdeAppStatusCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmAppRegHistoryCollectionGetByAdmCdeStatusId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppRegHistory>|AdmAppRegHistoryCollectionGetByAdmCdeStatusId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppRegHistoryCollectionGetByAdmCdeStatusId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppRegHistoryCollectionGetByAdmCdeStatusId = DataRepository.AdmAppRegHistoryProvider.GetByAdmCdeStatusId(transactionManager, entity.AdmCdeStatusId);

				if (deep && entity.AdmAppRegHistoryCollectionGetByAdmCdeStatusId.Count > 0)
				{
					deepHandles.Add("AdmAppRegHistoryCollectionGetByAdmCdeStatusId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppRegHistory>) DataRepository.AdmAppRegHistoryProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppRegHistoryCollectionGetByAdmCdeStatusId, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AdmCdeStatus object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AdmCdeStatus instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmCdeStatus Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmCdeStatus entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region SvAutoMsgTmpltIdSource
			if (CanDeepSave(entity, "SvAutoMsgTmplt|SvAutoMsgTmpltIdSource", deepSaveType, innerList) 
				&& entity.SvAutoMsgTmpltIdSource != null)
			{
				DataRepository.SvAutoMsgTmpltProvider.Save(transactionManager, entity.SvAutoMsgTmpltIdSource);
				entity.SvAutoMsgTmpltId = entity.SvAutoMsgTmpltIdSource.SvAutoMsgTmpltId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<AdmAppRegHistory>
				if (CanDeepSave(entity.AdmAppRegHistoryCollectionGetByAdmCdeStatusOldId, "List<AdmAppRegHistory>|AdmAppRegHistoryCollectionGetByAdmCdeStatusOldId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppRegHistory child in entity.AdmAppRegHistoryCollectionGetByAdmCdeStatusOldId)
					{
						if(child.AdmCdeStatusOldIdSource != null)
						{
							child.AdmCdeStatusOldId = child.AdmCdeStatusOldIdSource.AdmCdeStatusId;
						}
						else
						{
							child.AdmCdeStatusOldId = entity.AdmCdeStatusId;
						}

					}

					if (entity.AdmAppRegHistoryCollectionGetByAdmCdeStatusOldId.Count > 0 || entity.AdmAppRegHistoryCollectionGetByAdmCdeStatusOldId.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppRegHistoryProvider.Save(transactionManager, entity.AdmAppRegHistoryCollectionGetByAdmCdeStatusOldId);
						
						deepHandles.Add("AdmAppRegHistoryCollectionGetByAdmCdeStatusOldId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppRegHistory >) DataRepository.AdmAppRegHistoryProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppRegHistoryCollectionGetByAdmCdeStatusOldId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmCdeAppStatus>
				if (CanDeepSave(entity.AdmCdeAppStatusCollection, "List<AdmCdeAppStatus>|AdmCdeAppStatusCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmCdeAppStatus child in entity.AdmCdeAppStatusCollection)
					{
						if(child.AdmCdeStatusPrereqIdSource != null)
						{
							child.AdmCdeStatusPrereqId = child.AdmCdeStatusPrereqIdSource.AdmCdeStatusId;
						}
						else
						{
							child.AdmCdeStatusPrereqId = entity.AdmCdeStatusId;
						}

					}

					if (entity.AdmCdeAppStatusCollection.Count > 0 || entity.AdmCdeAppStatusCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmCdeAppStatusProvider.Save(transactionManager, entity.AdmCdeAppStatusCollection);
						
						deepHandles.Add("AdmCdeAppStatusCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmCdeAppStatus >) DataRepository.AdmCdeAppStatusProvider.DeepSave,
							new object[] { transactionManager, entity.AdmCdeAppStatusCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmAppRegHistory>
				if (CanDeepSave(entity.AdmAppRegHistoryCollectionGetByAdmCdeStatusId, "List<AdmAppRegHistory>|AdmAppRegHistoryCollectionGetByAdmCdeStatusId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppRegHistory child in entity.AdmAppRegHistoryCollectionGetByAdmCdeStatusId)
					{
						if(child.AdmCdeStatusIdSource != null)
						{
							child.AdmCdeStatusId = child.AdmCdeStatusIdSource.AdmCdeStatusId;
						}
						else
						{
							child.AdmCdeStatusId = entity.AdmCdeStatusId;
						}

					}

					if (entity.AdmAppRegHistoryCollectionGetByAdmCdeStatusId.Count > 0 || entity.AdmAppRegHistoryCollectionGetByAdmCdeStatusId.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppRegHistoryProvider.Save(transactionManager, entity.AdmAppRegHistoryCollectionGetByAdmCdeStatusId);
						
						deepHandles.Add("AdmAppRegHistoryCollectionGetByAdmCdeStatusId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppRegHistory >) DataRepository.AdmAppRegHistoryProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppRegHistoryCollectionGetByAdmCdeStatusId, deepSaveType, childTypes, innerList }
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
	
	#region AdmCdeStatusChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AdmCdeStatus</c>
	///</summary>
	public enum AdmCdeStatusChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>SvAutoMsgTmplt</c> at SvAutoMsgTmpltIdSource
		///</summary>
		[ChildEntityType(typeof(SvAutoMsgTmplt))]
		SvAutoMsgTmplt,
		///<summary>
		/// Collection of <c>AdmCdeStatus</c> as OneToMany for AdmAppRegHistoryCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppRegHistory>))]
		AdmAppRegHistoryCollectionGetByAdmCdeStatusOldId,
		///<summary>
		/// Collection of <c>AdmCdeStatus</c> as OneToMany for AdmCdeAppStatusCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmCdeAppStatus>))]
		AdmCdeAppStatusCollection,
		///<summary>
		/// Collection of <c>AdmCdeStatus</c> as OneToMany for AdmAppRegHistoryCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppRegHistory>))]
		AdmAppRegHistoryCollectionGetByAdmCdeStatusId,
	}
	
	#endregion AdmCdeStatusChildEntityTypes
	
	#region AdmCdeStatusFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AdmCdeStatusColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmCdeStatus"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmCdeStatusFilterBuilder : SqlFilterBuilder<AdmCdeStatusColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmCdeStatusFilterBuilder class.
		/// </summary>
		public AdmCdeStatusFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmCdeStatusFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmCdeStatusFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmCdeStatusFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmCdeStatusFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmCdeStatusFilterBuilder
	
	#region AdmCdeStatusParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AdmCdeStatusColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmCdeStatus"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmCdeStatusParameterBuilder : ParameterizedSqlFilterBuilder<AdmCdeStatusColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmCdeStatusParameterBuilder class.
		/// </summary>
		public AdmCdeStatusParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmCdeStatusParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmCdeStatusParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmCdeStatusParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmCdeStatusParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmCdeStatusParameterBuilder
	
	#region AdmCdeStatusSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AdmCdeStatusColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmCdeStatus"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AdmCdeStatusSortBuilder : SqlSortBuilder<AdmCdeStatusColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmCdeStatusSqlSortBuilder class.
		/// </summary>
		public AdmCdeStatusSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AdmCdeStatusSortBuilder
	
} // end namespace
