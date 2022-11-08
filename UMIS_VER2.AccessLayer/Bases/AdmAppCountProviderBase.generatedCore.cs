﻿#region Using directives

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
	/// This class is the base class for any <see cref="AdmAppCountProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AdmAppCountProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AdmAppCount, UMIS_VER2.BusinessLyer.AdmAppCountKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppCountKey key)
		{
			return Delete(transactionManager, key.AdmAppCountId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_admAppCountId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _admAppCountId)
		{
			return Delete(null, _admAppCountId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppCountId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _admAppCountId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_COUNT_AS_CODE_DEGREE_CLASS key.
		///		FK_ADM_APP_COUNT_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppCount objects.</returns>
		public TList<AdmAppCount> GetByAsCodeDegreeClassId(System.Decimal? _asCodeDegreeClassId)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(_asCodeDegreeClassId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_COUNT_AS_CODE_DEGREE_CLASS key.
		///		FK_ADM_APP_COUNT_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppCount objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAppCount> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeClassId)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(transactionManager, _asCodeDegreeClassId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_COUNT_AS_CODE_DEGREE_CLASS key.
		///		FK_ADM_APP_COUNT_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppCount objects.</returns>
		public TList<AdmAppCount> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeClassId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(transactionManager, _asCodeDegreeClassId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_COUNT_AS_CODE_DEGREE_CLASS key.
		///		fkAdmAppCountAsCodeDegreeClass Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppCount objects.</returns>
		public TList<AdmAppCount> GetByAsCodeDegreeClassId(System.Decimal? _asCodeDegreeClassId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAsCodeDegreeClassId(null, _asCodeDegreeClassId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_COUNT_AS_CODE_DEGREE_CLASS key.
		///		fkAdmAppCountAsCodeDegreeClass Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppCount objects.</returns>
		public TList<AdmAppCount> GetByAsCodeDegreeClassId(System.Decimal? _asCodeDegreeClassId, int start, int pageLength,out int count)
		{
			return GetByAsCodeDegreeClassId(null, _asCodeDegreeClassId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_COUNT_AS_CODE_DEGREE_CLASS key.
		///		FK_ADM_APP_COUNT_AS_CODE_DEGREE_CLASS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppCount objects.</returns>
		public abstract TList<AdmAppCount> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal? _asCodeDegreeClassId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_COUNT_ENTITY_MAIN key.
		///		FK_ADM_APP_COUNT_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="_entMainId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppCount objects.</returns>
		public TList<AdmAppCount> GetByEntMainId(System.Decimal _entMainId)
		{
			int count = -1;
			return GetByEntMainId(_entMainId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_COUNT_ENTITY_MAIN key.
		///		FK_ADM_APP_COUNT_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppCount objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAppCount> GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId)
		{
			int count = -1;
			return GetByEntMainId(transactionManager, _entMainId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_COUNT_ENTITY_MAIN key.
		///		FK_ADM_APP_COUNT_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppCount objects.</returns>
		public TList<AdmAppCount> GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntMainId(transactionManager, _entMainId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_COUNT_ENTITY_MAIN key.
		///		fkAdmAppCountEntityMain Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppCount objects.</returns>
		public TList<AdmAppCount> GetByEntMainId(System.Decimal _entMainId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEntMainId(null, _entMainId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_COUNT_ENTITY_MAIN key.
		///		fkAdmAppCountEntityMain Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_entMainId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppCount objects.</returns>
		public TList<AdmAppCount> GetByEntMainId(System.Decimal _entMainId, int start, int pageLength,out int count)
		{
			return GetByEntMainId(null, _entMainId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_COUNT_ENTITY_MAIN key.
		///		FK_ADM_APP_COUNT_ENTITY_MAIN Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entMainId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppCount objects.</returns>
		public abstract TList<AdmAppCount> GetByEntMainId(TransactionManager transactionManager, System.Decimal _entMainId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.AdmAppCount Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppCountKey key, int start, int pageLength)
		{
			return GetByAdmAppCountId(transactionManager, key.AdmAppCountId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ADM_APP_COUNT index.
		/// </summary>
		/// <param name="_admAppCountId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppCount"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppCount GetByAdmAppCountId(System.Decimal _admAppCountId)
		{
			int count = -1;
			return GetByAdmAppCountId(null,_admAppCountId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_COUNT index.
		/// </summary>
		/// <param name="_admAppCountId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppCount"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppCount GetByAdmAppCountId(System.Decimal _admAppCountId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppCountId(null, _admAppCountId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_COUNT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppCountId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppCount"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppCount GetByAdmAppCountId(TransactionManager transactionManager, System.Decimal _admAppCountId)
		{
			int count = -1;
			return GetByAdmAppCountId(transactionManager, _admAppCountId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_COUNT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppCountId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppCount"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppCount GetByAdmAppCountId(TransactionManager transactionManager, System.Decimal _admAppCountId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppCountId(transactionManager, _admAppCountId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_COUNT index.
		/// </summary>
		/// <param name="_admAppCountId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppCount"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppCount GetByAdmAppCountId(System.Decimal _admAppCountId, int start, int pageLength, out int count)
		{
			return GetByAdmAppCountId(null, _admAppCountId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_COUNT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppCountId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppCount"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmAppCount GetByAdmAppCountId(TransactionManager transactionManager, System.Decimal _admAppCountId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AdmAppCount&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AdmAppCount&gt;"/></returns>
		public static TList<AdmAppCount> Fill(IDataReader reader, TList<AdmAppCount> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AdmAppCount c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AdmAppCount")
					.Append("|").Append((System.Decimal)reader["ADM_APP_COUNT_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AdmAppCount>(
					key.ToString(), // EntityTrackingKey
					"AdmAppCount",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AdmAppCount();
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
					c.AdmAppCountId = (System.Decimal)reader["ADM_APP_COUNT_ID"];
					c.OriginalAdmAppCountId = c.AdmAppCountId;
					c.EntMainId = (System.Decimal)reader["ENT_MAIN_ID"];
					c.MaxCount = Convert.IsDBNull(reader["MAX_COUNT"]) ? null : (System.Decimal?)reader["MAX_COUNT"];
					c.AsCodeDegreeClassId = Convert.IsDBNull(reader["AS_CODE_DEGREE_CLASS_ID"]) ? null : (System.Decimal?)reader["AS_CODE_DEGREE_CLASS_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmAppCount"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAppCount"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AdmAppCount entity)
		{
			if (!reader.Read()) return;
			
			entity.AdmAppCountId = (System.Decimal)reader[((int)AdmAppCountColumn.AdmAppCountId - 1)];
			entity.OriginalAdmAppCountId = (System.Decimal)reader["ADM_APP_COUNT_ID"];
			entity.EntMainId = (System.Decimal)reader[((int)AdmAppCountColumn.EntMainId - 1)];
			entity.MaxCount = (reader.IsDBNull(((int)AdmAppCountColumn.MaxCount - 1)))?null:(System.Decimal?)reader[((int)AdmAppCountColumn.MaxCount - 1)];
			entity.AsCodeDegreeClassId = (reader.IsDBNull(((int)AdmAppCountColumn.AsCodeDegreeClassId - 1)))?null:(System.Decimal?)reader[((int)AdmAppCountColumn.AsCodeDegreeClassId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmAppCount"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAppCount"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AdmAppCount entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AdmAppCountId = (System.Decimal)dataRow["ADM_APP_COUNT_ID"];
			entity.OriginalAdmAppCountId = (System.Decimal)dataRow["ADM_APP_COUNT_ID"];
			entity.EntMainId = (System.Decimal)dataRow["ENT_MAIN_ID"];
			entity.MaxCount = Convert.IsDBNull(dataRow["MAX_COUNT"]) ? null : (System.Decimal?)dataRow["MAX_COUNT"];
			entity.AsCodeDegreeClassId = Convert.IsDBNull(dataRow["AS_CODE_DEGREE_CLASS_ID"]) ? null : (System.Decimal?)dataRow["AS_CODE_DEGREE_CLASS_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAppCount"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmAppCount Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppCount entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AsCodeDegreeClassIdSource	
			if (CanDeepLoad(entity, "AsCodeDegreeClass|AsCodeDegreeClassIdSource", deepLoadType, innerList) 
				&& entity.AsCodeDegreeClassIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AsCodeDegreeClassId ?? 0.0m);
				AsCodeDegreeClass tmpEntity = EntityManager.LocateEntity<AsCodeDegreeClass>(EntityLocator.ConstructKeyFromPkItems(typeof(AsCodeDegreeClass), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AsCodeDegreeClassIdSource = tmpEntity;
				else
					entity.AsCodeDegreeClassIdSource = DataRepository.AsCodeDegreeClassProvider.GetByAsCodeDegreeClassId(transactionManager, (entity.AsCodeDegreeClassId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AsCodeDegreeClassIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AsCodeDegreeClassIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AsCodeDegreeClassProvider.DeepLoad(transactionManager, entity.AsCodeDegreeClassIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AsCodeDegreeClassIdSource

			#region EntMainIdSource	
			if (CanDeepLoad(entity, "EntityMain|EntMainIdSource", deepLoadType, innerList) 
				&& entity.EntMainIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EntMainId;
				EntityMain tmpEntity = EntityManager.LocateEntity<EntityMain>(EntityLocator.ConstructKeyFromPkItems(typeof(EntityMain), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EntMainIdSource = tmpEntity;
				else
					entity.EntMainIdSource = DataRepository.EntityMainProvider.GetByEntMainId(transactionManager, entity.EntMainId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntMainIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EntMainIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EntityMainProvider.DeepLoad(transactionManager, entity.EntMainIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EntMainIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AdmAppCount object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AdmAppCount instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmAppCount Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppCount entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AsCodeDegreeClassIdSource
			if (CanDeepSave(entity, "AsCodeDegreeClass|AsCodeDegreeClassIdSource", deepSaveType, innerList) 
				&& entity.AsCodeDegreeClassIdSource != null)
			{
				DataRepository.AsCodeDegreeClassProvider.Save(transactionManager, entity.AsCodeDegreeClassIdSource);
				entity.AsCodeDegreeClassId = entity.AsCodeDegreeClassIdSource.AsCodeDegreeClassId;
			}
			#endregion 
			
			#region EntMainIdSource
			if (CanDeepSave(entity, "EntityMain|EntMainIdSource", deepSaveType, innerList) 
				&& entity.EntMainIdSource != null)
			{
				DataRepository.EntityMainProvider.Save(transactionManager, entity.EntMainIdSource);
				entity.EntMainId = entity.EntMainIdSource.EntMainId;
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
	
	#region AdmAppCountChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AdmAppCount</c>
	///</summary>
	public enum AdmAppCountChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AsCodeDegreeClass</c> at AsCodeDegreeClassIdSource
		///</summary>
		[ChildEntityType(typeof(AsCodeDegreeClass))]
		AsCodeDegreeClass,
		
		///<summary>
		/// Composite Property for <c>EntityMain</c> at EntMainIdSource
		///</summary>
		[ChildEntityType(typeof(EntityMain))]
		EntityMain,
	}
	
	#endregion AdmAppCountChildEntityTypes
	
	#region AdmAppCountFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AdmAppCountColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAppCount"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmAppCountFilterBuilder : SqlFilterBuilder<AdmAppCountColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAppCountFilterBuilder class.
		/// </summary>
		public AdmAppCountFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmAppCountFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmAppCountFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmAppCountFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmAppCountFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmAppCountFilterBuilder
	
	#region AdmAppCountParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AdmAppCountColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAppCount"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmAppCountParameterBuilder : ParameterizedSqlFilterBuilder<AdmAppCountColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAppCountParameterBuilder class.
		/// </summary>
		public AdmAppCountParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmAppCountParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmAppCountParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmAppCountParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmAppCountParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmAppCountParameterBuilder
	
	#region AdmAppCountSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AdmAppCountColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAppCount"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AdmAppCountSortBuilder : SqlSortBuilder<AdmAppCountColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAppCountSqlSortBuilder class.
		/// </summary>
		public AdmAppCountSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AdmAppCountSortBuilder
	
} // end namespace