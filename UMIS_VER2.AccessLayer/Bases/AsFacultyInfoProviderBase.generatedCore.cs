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
	/// This class is the base class for any <see cref="AsFacultyInfoProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AsFacultyInfoProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AsFacultyInfo, UMIS_VER2.BusinessLyer.AsFacultyInfoKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AsFacultyInfoKey key)
		{
			return Delete(transactionManager, key.AsFacultyInfoId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_asFacultyInfoId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _asFacultyInfoId)
		{
			return Delete(null, _asFacultyInfoId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _asFacultyInfoId);		
		
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
		public override UMIS_VER2.BusinessLyer.AsFacultyInfo Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AsFacultyInfoKey key, int start, int pageLength)
		{
			return GetByAsFacultyInfoId(transactionManager, key.AsFacultyInfoId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_GS_COUNTRY_NODE_ID_1 index.
		/// </summary>
		/// <param name="_gsCountryNodeId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AsFacultyInfo&gt;"/> class.</returns>
		public TList<AsFacultyInfo> GetByGsCountryNodeId(System.Decimal? _gsCountryNodeId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;AsFacultyInfo&gt;"/> class.</returns>
		public TList<AsFacultyInfo> GetByGsCountryNodeId(System.Decimal? _gsCountryNodeId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;AsFacultyInfo&gt;"/> class.</returns>
		public TList<AsFacultyInfo> GetByGsCountryNodeId(TransactionManager transactionManager, System.Decimal? _gsCountryNodeId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;AsFacultyInfo&gt;"/> class.</returns>
		public TList<AsFacultyInfo> GetByGsCountryNodeId(TransactionManager transactionManager, System.Decimal? _gsCountryNodeId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;AsFacultyInfo&gt;"/> class.</returns>
		public TList<AsFacultyInfo> GetByGsCountryNodeId(System.Decimal? _gsCountryNodeId, int start, int pageLength, out int count)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;AsFacultyInfo&gt;"/> class.</returns>
		public abstract TList<AsFacultyInfo> GetByGsCountryNodeId(TransactionManager transactionManager, System.Decimal? _gsCountryNodeId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_AS_FACULTY_INFO index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AsFacultyInfo"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AsFacultyInfo GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(null,_asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_AS_FACULTY_INFO index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AsFacultyInfo"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AsFacultyInfo GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_AS_FACULTY_INFO index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AsFacultyInfo"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AsFacultyInfo GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_AS_FACULTY_INFO index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AsFacultyInfo"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AsFacultyInfo GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_AS_FACULTY_INFO index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AsFacultyInfo"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AsFacultyInfo GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength, out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_AS_FACULTY_INFO index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AsFacultyInfo"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AsFacultyInfo GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AsFacultyInfo&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AsFacultyInfo&gt;"/></returns>
		public static TList<AsFacultyInfo> Fill(IDataReader reader, TList<AsFacultyInfo> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AsFacultyInfo c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AsFacultyInfo")
					.Append("|").Append((System.Decimal)reader["AS_FACULTY_INFO_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AsFacultyInfo>(
					key.ToString(), // EntityTrackingKey
					"AsFacultyInfo",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AsFacultyInfo();
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
					c.AsFacultyInfoId = (System.Decimal)reader["AS_FACULTY_INFO_ID"];
					c.OriginalAsFacultyInfoId = c.AsFacultyInfoId;
					c.GsCountryNodeId = Convert.IsDBNull(reader["GS_COUNTRY_NODE_ID"]) ? null : (System.Decimal?)reader["GS_COUNTRY_NODE_ID"];
					c.FacultyAddress = Convert.IsDBNull(reader["FACULTY_ADDRESS"]) ? null : (System.String)reader["FACULTY_ADDRESS"];
					c.FacultyDescrAr = Convert.IsDBNull(reader["FACULTY_DESCR_AR"]) ? null : (System.String)reader["FACULTY_DESCR_AR"];
					c.FacultyDescrEn = Convert.IsDBNull(reader["FACULTY_DESCR_EN"]) ? null : (System.String)reader["FACULTY_DESCR_EN"];
					c.ConDate = Convert.IsDBNull(reader["CON_DATE"]) ? null : (System.DateTime?)reader["CON_DATE"];
					c.FacultyLogo = Convert.IsDBNull(reader["FACULTY_LOGO"]) ? null : (System.String)reader["FACULTY_LOGO"];
					c.Notation = Convert.IsDBNull(reader["NOTATION"]) ? null : (System.Int32?)reader["NOTATION"];
					c.FacultyCode = Convert.IsDBNull(reader["FACULTY_CODE"]) ? null : (System.String)reader["FACULTY_CODE"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AsFacultyInfo"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AsFacultyInfo"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AsFacultyInfo entity)
		{
			if (!reader.Read()) return;
			
			entity.AsFacultyInfoId = (System.Decimal)reader[((int)AsFacultyInfoColumn.AsFacultyInfoId - 1)];
			entity.OriginalAsFacultyInfoId = (System.Decimal)reader["AS_FACULTY_INFO_ID"];
			entity.GsCountryNodeId = (reader.IsDBNull(((int)AsFacultyInfoColumn.GsCountryNodeId - 1)))?null:(System.Decimal?)reader[((int)AsFacultyInfoColumn.GsCountryNodeId - 1)];
			entity.FacultyAddress = (reader.IsDBNull(((int)AsFacultyInfoColumn.FacultyAddress - 1)))?null:(System.String)reader[((int)AsFacultyInfoColumn.FacultyAddress - 1)];
			entity.FacultyDescrAr = (reader.IsDBNull(((int)AsFacultyInfoColumn.FacultyDescrAr - 1)))?null:(System.String)reader[((int)AsFacultyInfoColumn.FacultyDescrAr - 1)];
			entity.FacultyDescrEn = (reader.IsDBNull(((int)AsFacultyInfoColumn.FacultyDescrEn - 1)))?null:(System.String)reader[((int)AsFacultyInfoColumn.FacultyDescrEn - 1)];
			entity.ConDate = (reader.IsDBNull(((int)AsFacultyInfoColumn.ConDate - 1)))?null:(System.DateTime?)reader[((int)AsFacultyInfoColumn.ConDate - 1)];
			entity.FacultyLogo = (reader.IsDBNull(((int)AsFacultyInfoColumn.FacultyLogo - 1)))?null:(System.String)reader[((int)AsFacultyInfoColumn.FacultyLogo - 1)];
			entity.Notation = (reader.IsDBNull(((int)AsFacultyInfoColumn.Notation - 1)))?null:(System.Int32?)reader[((int)AsFacultyInfoColumn.Notation - 1)];
			entity.FacultyCode = (reader.IsDBNull(((int)AsFacultyInfoColumn.FacultyCode - 1)))?null:(System.String)reader[((int)AsFacultyInfoColumn.FacultyCode - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AsFacultyInfo"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AsFacultyInfo"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AsFacultyInfo entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AsFacultyInfoId = (System.Decimal)dataRow["AS_FACULTY_INFO_ID"];
			entity.OriginalAsFacultyInfoId = (System.Decimal)dataRow["AS_FACULTY_INFO_ID"];
			entity.GsCountryNodeId = Convert.IsDBNull(dataRow["GS_COUNTRY_NODE_ID"]) ? null : (System.Decimal?)dataRow["GS_COUNTRY_NODE_ID"];
			entity.FacultyAddress = Convert.IsDBNull(dataRow["FACULTY_ADDRESS"]) ? null : (System.String)dataRow["FACULTY_ADDRESS"];
			entity.FacultyDescrAr = Convert.IsDBNull(dataRow["FACULTY_DESCR_AR"]) ? null : (System.String)dataRow["FACULTY_DESCR_AR"];
			entity.FacultyDescrEn = Convert.IsDBNull(dataRow["FACULTY_DESCR_EN"]) ? null : (System.String)dataRow["FACULTY_DESCR_EN"];
			entity.ConDate = Convert.IsDBNull(dataRow["CON_DATE"]) ? null : (System.DateTime?)dataRow["CON_DATE"];
			entity.FacultyLogo = Convert.IsDBNull(dataRow["FACULTY_LOGO"]) ? null : (System.String)dataRow["FACULTY_LOGO"];
			entity.Notation = Convert.IsDBNull(dataRow["NOTATION"]) ? null : (System.Int32?)dataRow["NOTATION"];
			entity.FacultyCode = Convert.IsDBNull(dataRow["FACULTY_CODE"]) ? null : (System.String)dataRow["FACULTY_CODE"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AsFacultyInfo"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AsFacultyInfo Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AsFacultyInfo entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region GsCountryNodeIdSource	
			if (CanDeepLoad(entity, "GsCountryNode|GsCountryNodeIdSource", deepLoadType, innerList) 
				&& entity.GsCountryNodeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCountryNodeId ?? 0.0m);
				GsCountryNode tmpEntity = EntityManager.LocateEntity<GsCountryNode>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCountryNode), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCountryNodeIdSource = tmpEntity;
				else
					entity.GsCountryNodeIdSource = DataRepository.GsCountryNodeProvider.GetByGsCountryNodeId(transactionManager, (entity.GsCountryNodeId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCountryNodeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCountryNodeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCountryNodeProvider.DeepLoad(transactionManager, entity.GsCountryNodeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCountryNodeIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByAsFacultyInfoId methods when available
			
			#region EdBranchRuleCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdBranchRule>|EdBranchRuleCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdBranchRuleCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdBranchRuleCollection = DataRepository.EdBranchRuleProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.EdBranchRuleCollection.Count > 0)
				{
					deepHandles.Add("EdBranchRuleCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdBranchRule>) DataRepository.EdBranchRuleProvider.DeepLoad,
						new object[] { transactionManager, entity.EdBranchRuleCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaMilitaryStatusCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaMilitaryStatus>|SaMilitaryStatusCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaMilitaryStatusCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaMilitaryStatusCollection = DataRepository.SaMilitaryStatusProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.SaMilitaryStatusCollection.Count > 0)
				{
					deepHandles.Add("SaMilitaryStatusCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaMilitaryStatus>) DataRepository.SaMilitaryStatusProvider.DeepLoad,
						new object[] { transactionManager, entity.SaMilitaryStatusCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region ScStudGroupCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ScStudGroup>|ScStudGroupCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScStudGroupCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ScStudGroupCollection = DataRepository.ScStudGroupProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.ScStudGroupCollection.Count > 0)
				{
					deepHandles.Add("ScStudGroupCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScStudGroup>) DataRepository.ScStudGroupProvider.DeepLoad,
						new object[] { transactionManager, entity.ScStudGroupCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaRelativeCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaRelative>|SaRelativeCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaRelativeCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaRelativeCollection = DataRepository.SaRelativeProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.SaRelativeCollection.Count > 0)
				{
					deepHandles.Add("SaRelativeCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaRelative>) DataRepository.SaRelativeProvider.DeepLoad,
						new object[] { transactionManager, entity.SaRelativeCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SeBlockTransCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SeBlockTrans>|SeBlockTransCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeBlockTransCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SeBlockTransCollection = DataRepository.SeBlockTransProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.SeBlockTransCollection.Count > 0)
				{
					deepHandles.Add("SeBlockTransCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SeBlockTrans>) DataRepository.SeBlockTransProvider.DeepLoad,
						new object[] { transactionManager, entity.SeBlockTransCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SpoSponsorStudCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SpoSponsorStud>|SpoSponsorStudCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SpoSponsorStudCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SpoSponsorStudCollection = DataRepository.SpoSponsorStudProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.SpoSponsorStudCollection.Count > 0)
				{
					deepHandles.Add("SpoSponsorStudCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SpoSponsorStud>) DataRepository.SpoSponsorStudProvider.DeepLoad,
						new object[] { transactionManager, entity.SpoSponsorStudCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdCodeCourseAssessCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdCodeCourseAssess>|EdCodeCourseAssessCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeCourseAssessCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdCodeCourseAssessCollection = DataRepository.EdCodeCourseAssessProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.EdCodeCourseAssessCollection.Count > 0)
				{
					deepHandles.Add("EdCodeCourseAssessCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdCodeCourseAssess>) DataRepository.EdCodeCourseAssessProvider.DeepLoad,
						new object[] { transactionManager, entity.EdCodeCourseAssessCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdCodeDischargeHCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdCodeDischargeH>|EdCodeDischargeHCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeDischargeHCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdCodeDischargeHCollection = DataRepository.EdCodeDischargeHProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.EdCodeDischargeHCollection.Count > 0)
				{
					deepHandles.Add("EdCodeDischargeHCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdCodeDischargeH>) DataRepository.EdCodeDischargeHProvider.DeepLoad,
						new object[] { transactionManager, entity.EdCodeDischargeHCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaCdeAcadLoadCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaCdeAcadLoad>|SaCdeAcadLoadCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaCdeAcadLoadCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaCdeAcadLoadCollection = DataRepository.SaCdeAcadLoadProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.SaCdeAcadLoadCollection.Count > 0)
				{
					deepHandles.Add("SaCdeAcadLoadCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaCdeAcadLoad>) DataRepository.SaCdeAcadLoadProvider.DeepLoad,
						new object[] { transactionManager, entity.SaCdeAcadLoadCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaEmpHierarchyCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaEmpHierarchy>|SaEmpHierarchyCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaEmpHierarchyCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaEmpHierarchyCollection = DataRepository.SaEmpHierarchyProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.SaEmpHierarchyCollection.Count > 0)
				{
					deepHandles.Add("SaEmpHierarchyCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaEmpHierarchy>) DataRepository.SaEmpHierarchyProvider.DeepLoad,
						new object[] { transactionManager, entity.SaEmpHierarchyCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdCodeCourseTeachingCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdCodeCourseTeaching>|EdCodeCourseTeachingCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeCourseTeachingCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdCodeCourseTeachingCollection = DataRepository.EdCodeCourseTeachingProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.EdCodeCourseTeachingCollection.Count > 0)
				{
					deepHandles.Add("EdCodeCourseTeachingCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdCodeCourseTeaching>) DataRepository.EdCodeCourseTeachingProvider.DeepLoad,
						new object[] { transactionManager, entity.EdCodeCourseTeachingCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudCourseRegPreCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudCourseRegPre>|EdStudCourseRegPreCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCourseRegPreCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCourseRegPreCollection = DataRepository.EdStudCourseRegPreProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.EdStudCourseRegPreCollection.Count > 0)
				{
					deepHandles.Add("EdStudCourseRegPreCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCourseRegPre>) DataRepository.EdStudCourseRegPreProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCourseRegPreCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.EdStudExcuseCollection = DataRepository.EdStudExcuseProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.EdStudExcuseCollection.Count > 0)
				{
					deepHandles.Add("EdStudExcuseCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudExcuse>) DataRepository.EdStudExcuseProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudExcuseCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region GsCommCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GsComm>|GsCommCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCommCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GsCommCollection = DataRepository.GsCommProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.GsCommCollection.Count > 0)
				{
					deepHandles.Add("GsCommCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GsComm>) DataRepository.GsCommProvider.DeepLoad,
						new object[] { transactionManager, entity.GsCommCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.SaJobStartStatmentCollection = DataRepository.SaJobStartStatmentProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.SaJobStartStatmentCollection.Count > 0)
				{
					deepHandles.Add("SaJobStartStatmentCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaJobStartStatment>) DataRepository.SaJobStartStatmentProvider.DeepLoad,
						new object[] { transactionManager, entity.SaJobStartStatmentCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudAcadWarnCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudAcadWarn>|EdStudAcadWarnCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudAcadWarnCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudAcadWarnCollection = DataRepository.EdStudAcadWarnProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.EdStudAcadWarnCollection.Count > 0)
				{
					deepHandles.Add("EdStudAcadWarnCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudAcadWarn>) DataRepository.EdStudAcadWarnProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudAcadWarnCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region PgThesisGrantDegreeCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgThesisGrantDegree>|PgThesisGrantDegreeCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisGrantDegreeCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgThesisGrantDegreeCollection = DataRepository.PgThesisGrantDegreeProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.PgThesisGrantDegreeCollection.Count > 0)
				{
					deepHandles.Add("PgThesisGrantDegreeCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgThesisGrantDegree>) DataRepository.PgThesisGrantDegreeProvider.DeepLoad,
						new object[] { transactionManager, entity.PgThesisGrantDegreeCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdCourseTopicCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdCourseTopic>|EdCourseTopicCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCourseTopicCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdCourseTopicCollection = DataRepository.EdCourseTopicProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.EdCourseTopicCollection.Count > 0)
				{
					deepHandles.Add("EdCourseTopicCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdCourseTopic>) DataRepository.EdCourseTopicProvider.DeepLoad,
						new object[] { transactionManager, entity.EdCourseTopicCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeFineCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeFine>|FeeFineCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeFineCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeFineCollection = DataRepository.FeeFineProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.FeeFineCollection.Count > 0)
				{
					deepHandles.Add("FeeFineCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeFine>) DataRepository.FeeFineProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeFineCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudQualSubjectCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudQualSubject>|EdStudQualSubjectCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudQualSubjectCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudQualSubjectCollection = DataRepository.EdStudQualSubjectProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.EdStudQualSubjectCollection.Count > 0)
				{
					deepHandles.Add("EdStudQualSubjectCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudQualSubject>) DataRepository.EdStudQualSubjectProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudQualSubjectCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudIntTrnsCourseToCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudIntTrnsCourseTo>|EdStudIntTrnsCourseToCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudIntTrnsCourseToCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudIntTrnsCourseToCollection = DataRepository.EdStudIntTrnsCourseToProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.EdStudIntTrnsCourseToCollection.Count > 0)
				{
					deepHandles.Add("EdStudIntTrnsCourseToCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudIntTrnsCourseTo>) DataRepository.EdStudIntTrnsCourseToProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudIntTrnsCourseToCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeStudNatSimilarityRequestCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeStudNatSimilarityRequest>|FeeStudNatSimilarityRequestCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudNatSimilarityRequestCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeStudNatSimilarityRequestCollection = DataRepository.FeeStudNatSimilarityRequestProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.FeeStudNatSimilarityRequestCollection.Count > 0)
				{
					deepHandles.Add("FeeStudNatSimilarityRequestCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudNatSimilarityRequest>) DataRepository.FeeStudNatSimilarityRequestProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudNatSimilarityRequestCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaJobStoppageCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaJobStoppage>|SaJobStoppageCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaJobStoppageCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaJobStoppageCollection = DataRepository.SaJobStoppageProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.SaJobStoppageCollection.Count > 0)
				{
					deepHandles.Add("SaJobStoppageCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaJobStoppage>) DataRepository.SaJobStoppageProvider.DeepLoad,
						new object[] { transactionManager, entity.SaJobStoppageCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaPromotionRequestCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaPromotionRequest>|SaPromotionRequestCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaPromotionRequestCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaPromotionRequestCollection = DataRepository.SaPromotionRequestProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.SaPromotionRequestCollection.Count > 0)
				{
					deepHandles.Add("SaPromotionRequestCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaPromotionRequest>) DataRepository.SaPromotionRequestProvider.DeepLoad,
						new object[] { transactionManager, entity.SaPromotionRequestCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region CoScheduleDetailCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<CoScheduleDetail>|CoScheduleDetailCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CoScheduleDetailCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.CoScheduleDetailCollection = DataRepository.CoScheduleDetailProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.CoScheduleDetailCollection.Count > 0)
				{
					deepHandles.Add("CoScheduleDetailCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CoScheduleDetail>) DataRepository.CoScheduleDetailProvider.DeepLoad,
						new object[] { transactionManager, entity.CoScheduleDetailCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaVacationBalanceHCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaVacationBalanceH>|SaVacationBalanceHCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaVacationBalanceHCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaVacationBalanceHCollection = DataRepository.SaVacationBalanceHProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.SaVacationBalanceHCollection.Count > 0)
				{
					deepHandles.Add("SaVacationBalanceHCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaVacationBalanceH>) DataRepository.SaVacationBalanceHProvider.DeepLoad,
						new object[] { transactionManager, entity.SaVacationBalanceHCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaPublicationCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaPublication>|SaPublicationCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaPublicationCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaPublicationCollection = DataRepository.SaPublicationProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.SaPublicationCollection.Count > 0)
				{
					deepHandles.Add("SaPublicationCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaPublication>) DataRepository.SaPublicationProvider.DeepLoad,
						new object[] { transactionManager, entity.SaPublicationCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeFacultyRuleCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeFacultyRule>|FeeFacultyRuleCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeFacultyRuleCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeFacultyRuleCollection = DataRepository.FeeFacultyRuleProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.FeeFacultyRuleCollection.Count > 0)
				{
					deepHandles.Add("FeeFacultyRuleCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeFacultyRule>) DataRepository.FeeFacultyRuleProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeFacultyRuleCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SvPollHdrCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvPollHdr>|SvPollHdrCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvPollHdrCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvPollHdrCollection = DataRepository.SvPollHdrProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.SvPollHdrCollection.Count > 0)
				{
					deepHandles.Add("SvPollHdrCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvPollHdr>) DataRepository.SvPollHdrProvider.DeepLoad,
						new object[] { transactionManager, entity.SvPollHdrCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeStudVoucherCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeStudVoucher>|FeeStudVoucherCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudVoucherCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeStudVoucherCollection = DataRepository.FeeStudVoucherProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.FeeStudVoucherCollection.Count > 0)
				{
					deepHandles.Add("FeeStudVoucherCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudVoucher>) DataRepository.FeeStudVoucherProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudVoucherCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdAcadYearFacultyCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdAcadYearFaculty>|EdAcadYearFacultyCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdAcadYearFacultyCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdAcadYearFacultyCollection = DataRepository.EdAcadYearFacultyProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.EdAcadYearFacultyCollection.Count > 0)
				{
					deepHandles.Add("EdAcadYearFacultyCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdAcadYearFaculty>) DataRepository.EdAcadYearFacultyProvider.DeepLoad,
						new object[] { transactionManager, entity.EdAcadYearFacultyCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.RsrchStudPostponeReqCollection = DataRepository.RsrchStudPostponeReqProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.RsrchStudPostponeReqCollection.Count > 0)
				{
					deepHandles.Add("RsrchStudPostponeReqCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<RsrchStudPostponeReq>) DataRepository.RsrchStudPostponeReqProvider.DeepLoad,
						new object[] { transactionManager, entity.RsrchStudPostponeReqCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SeUserCrsAssessCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SeUserCrsAssess>|SeUserCrsAssessCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeUserCrsAssessCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SeUserCrsAssessCollection = DataRepository.SeUserCrsAssessProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.SeUserCrsAssessCollection.Count > 0)
				{
					deepHandles.Add("SeUserCrsAssessCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SeUserCrsAssess>) DataRepository.SeUserCrsAssessProvider.DeepLoad,
						new object[] { transactionManager, entity.SeUserCrsAssessCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.EdStudTransFromReqCollection = DataRepository.EdStudTransFromReqProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.EdStudTransFromReqCollection.Count > 0)
				{
					deepHandles.Add("EdStudTransFromReqCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudTransFromReq>) DataRepository.EdStudTransFromReqProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudTransFromReqCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region GsCdeClrncItemFacCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GsCdeClrncItemFac>|GsCdeClrncItemFacCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCdeClrncItemFacCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GsCdeClrncItemFacCollection = DataRepository.GsCdeClrncItemFacProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.GsCdeClrncItemFacCollection.Count > 0)
				{
					deepHandles.Add("GsCdeClrncItemFacCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GsCdeClrncItemFac>) DataRepository.GsCdeClrncItemFacProvider.DeepLoad,
						new object[] { transactionManager, entity.GsCdeClrncItemFacCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaRaiseCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaRaise>|SaRaiseCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaRaiseCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaRaiseCollection = DataRepository.SaRaiseProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.SaRaiseCollection.Count > 0)
				{
					deepHandles.Add("SaRaiseCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaRaise>) DataRepository.SaRaiseProvider.DeepLoad,
						new object[] { transactionManager, entity.SaRaiseCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudIntTrnsStateToCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudIntTrnsStateTo>|EdStudIntTrnsStateToCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudIntTrnsStateToCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudIntTrnsStateToCollection = DataRepository.EdStudIntTrnsStateToProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.EdStudIntTrnsStateToCollection.Count > 0)
				{
					deepHandles.Add("EdStudIntTrnsStateToCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudIntTrnsStateTo>) DataRepository.EdStudIntTrnsStateToProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudIntTrnsStateToCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmPrecondQualCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmPrecondQual>|AdmPrecondQualCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmPrecondQualCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmPrecondQualCollection = DataRepository.AdmPrecondQualProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.AdmPrecondQualCollection.Count > 0)
				{
					deepHandles.Add("AdmPrecondQualCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmPrecondQual>) DataRepository.AdmPrecondQualProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmPrecondQualCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmRatingParametersMajorsCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmRatingParametersMajors>|AdmRatingParametersMajorsCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmRatingParametersMajorsCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmRatingParametersMajorsCollection = DataRepository.AdmRatingParametersMajorsProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.AdmRatingParametersMajorsCollection.Count > 0)
				{
					deepHandles.Add("AdmRatingParametersMajorsCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmRatingParametersMajors>) DataRepository.AdmRatingParametersMajorsProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmRatingParametersMajorsCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region ScSchdlPeriodCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ScSchdlPeriod>|ScSchdlPeriodCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScSchdlPeriodCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ScSchdlPeriodCollection = DataRepository.ScSchdlPeriodProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.ScSchdlPeriodCollection.Count > 0)
				{
					deepHandles.Add("ScSchdlPeriodCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScSchdlPeriod>) DataRepository.ScSchdlPeriodProvider.DeepLoad,
						new object[] { transactionManager, entity.ScSchdlPeriodCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeStudRetrieveRequestCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeStudRetrieveRequest>|FeeStudRetrieveRequestCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudRetrieveRequestCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeStudRetrieveRequestCollection = DataRepository.FeeStudRetrieveRequestProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.FeeStudRetrieveRequestCollection.Count > 0)
				{
					deepHandles.Add("FeeStudRetrieveRequestCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudRetrieveRequest>) DataRepository.FeeStudRetrieveRequestProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudRetrieveRequestCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.SaExtDelCollection = DataRepository.SaExtDelProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.SaExtDelCollection.Count > 0)
				{
					deepHandles.Add("SaExtDelCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaExtDel>) DataRepository.SaExtDelProvider.DeepLoad,
						new object[] { transactionManager, entity.SaExtDelCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region ScHallRsrvCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ScHallRsrv>|ScHallRsrvCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScHallRsrvCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ScHallRsrvCollection = DataRepository.ScHallRsrvProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.ScHallRsrvCollection.Count > 0)
				{
					deepHandles.Add("ScHallRsrvCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScHallRsrv>) DataRepository.ScHallRsrvProvider.DeepLoad,
						new object[] { transactionManager, entity.ScHallRsrvCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdResidencyStudCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdResidencyStud>|EdResidencyStudCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdResidencyStudCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdResidencyStudCollection = DataRepository.EdResidencyStudProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.EdResidencyStudCollection.Count > 0)
				{
					deepHandles.Add("EdResidencyStudCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdResidencyStud>) DataRepository.EdResidencyStudProvider.DeepLoad,
						new object[] { transactionManager, entity.EdResidencyStudCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.EdStudCourseChngCollection = DataRepository.EdStudCourseChngProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.EdStudCourseChngCollection.Count > 0)
				{
					deepHandles.Add("EdStudCourseChngCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCourseChng>) DataRepository.EdStudCourseChngProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCourseChngCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdCourseCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdCourse>|EdCourseCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCourseCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdCourseCollection = DataRepository.EdCourseProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.EdCourseCollection.Count > 0)
				{
					deepHandles.Add("EdCourseCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdCourse>) DataRepository.EdCourseProvider.DeepLoad,
						new object[] { transactionManager, entity.EdCourseCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SvAutoMsgTmpltCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvAutoMsgTmplt>|SvAutoMsgTmpltCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvAutoMsgTmpltCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvAutoMsgTmpltCollection = DataRepository.SvAutoMsgTmpltProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.SvAutoMsgTmpltCollection.Count > 0)
				{
					deepHandles.Add("SvAutoMsgTmpltCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvAutoMsgTmplt>) DataRepository.SvAutoMsgTmpltProvider.DeepLoad,
						new object[] { transactionManager, entity.SvAutoMsgTmpltCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region ScScheduleRsrvCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ScScheduleRsrv>|ScScheduleRsrvCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScScheduleRsrvCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ScScheduleRsrvCollection = DataRepository.ScScheduleRsrvProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.ScScheduleRsrvCollection.Count > 0)
				{
					deepHandles.Add("ScScheduleRsrvCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScScheduleRsrv>) DataRepository.ScScheduleRsrvProvider.DeepLoad,
						new object[] { transactionManager, entity.ScScheduleRsrvCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaScCommDecisionCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaScCommDecision>|SaScCommDecisionCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaScCommDecisionCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaScCommDecisionCollection = DataRepository.SaScCommDecisionProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.SaScCommDecisionCollection.Count > 0)
				{
					deepHandles.Add("SaScCommDecisionCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaScCommDecision>) DataRepository.SaScCommDecisionProvider.DeepLoad,
						new object[] { transactionManager, entity.SaScCommDecisionCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudIntTransPrefCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudIntTransPref>|EdStudIntTransPrefCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudIntTransPrefCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudIntTransPrefCollection = DataRepository.EdStudIntTransPrefProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.EdStudIntTransPrefCollection.Count > 0)
				{
					deepHandles.Add("EdStudIntTransPrefCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudIntTransPref>) DataRepository.EdStudIntTransPrefProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudIntTransPrefCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaTrainingCourseCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaTrainingCourse>|SaTrainingCourseCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaTrainingCourseCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaTrainingCourseCollection = DataRepository.SaTrainingCourseProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.SaTrainingCourseCollection.Count > 0)
				{
					deepHandles.Add("SaTrainingCourseCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaTrainingCourse>) DataRepository.SaTrainingCourseProvider.DeepLoad,
						new object[] { transactionManager, entity.SaTrainingCourseCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaMiltaryCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaMiltary>|SaMiltaryCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaMiltaryCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaMiltaryCollection = DataRepository.SaMiltaryProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.SaMiltaryCollection.Count > 0)
				{
					deepHandles.Add("SaMiltaryCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaMiltary>) DataRepository.SaMiltaryProvider.DeepLoad,
						new object[] { transactionManager, entity.SaMiltaryCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeInstlmntRuleCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeInstlmntRule>|FeeInstlmntRuleCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeInstlmntRuleCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeInstlmntRuleCollection = DataRepository.FeeInstlmntRuleProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.FeeInstlmntRuleCollection.Count > 0)
				{
					deepHandles.Add("FeeInstlmntRuleCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeInstlmntRule>) DataRepository.FeeInstlmntRuleProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeInstlmntRuleCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmCompetitiveAvgCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmCompetitiveAvg>|AdmCompetitiveAvgCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmCompetitiveAvgCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmCompetitiveAvgCollection = DataRepository.AdmCompetitiveAvgProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.AdmCompetitiveAvgCollection.Count > 0)
				{
					deepHandles.Add("AdmCompetitiveAvgCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmCompetitiveAvg>) DataRepository.AdmCompetitiveAvgProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmCompetitiveAvgCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region RsrchStudRegisterCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<RsrchStudRegister>|RsrchStudRegisterCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'RsrchStudRegisterCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.RsrchStudRegisterCollection = DataRepository.RsrchStudRegisterProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.RsrchStudRegisterCollection.Count > 0)
				{
					deepHandles.Add("RsrchStudRegisterCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<RsrchStudRegister>) DataRepository.RsrchStudRegisterProvider.DeepLoad,
						new object[] { transactionManager, entity.RsrchStudRegisterCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SeFormCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SeForm>|SeFormCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeFormCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SeFormCollection = DataRepository.SeFormProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.SeFormCollection.Count > 0)
				{
					deepHandles.Add("SeFormCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SeForm>) DataRepository.SeFormProvider.DeepLoad,
						new object[] { transactionManager, entity.SeFormCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdOfferingCourseCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdOfferingCourse>|EdOfferingCourseCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdOfferingCourseCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdOfferingCourseCollection = DataRepository.EdOfferingCourseProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.EdOfferingCourseCollection.Count > 0)
				{
					deepHandles.Add("EdOfferingCourseCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdOfferingCourse>) DataRepository.EdOfferingCourseProvider.DeepLoad,
						new object[] { transactionManager, entity.EdOfferingCourseCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeLimitRuleCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeLimitRule>|FeeLimitRuleCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeLimitRuleCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeLimitRuleCollection = DataRepository.FeeLimitRuleProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.FeeLimitRuleCollection.Count > 0)
				{
					deepHandles.Add("FeeLimitRuleCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeLimitRule>) DataRepository.FeeLimitRuleProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeLimitRuleCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.SaExperienceCollection = DataRepository.SaExperienceProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.SaExperienceCollection.Count > 0)
				{
					deepHandles.Add("SaExperienceCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaExperience>) DataRepository.SaExperienceProvider.DeepLoad,
						new object[] { transactionManager, entity.SaExperienceCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.SaServTerminCollection = DataRepository.SaServTerminProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.SaServTerminCollection.Count > 0)
				{
					deepHandles.Add("SaServTerminCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaServTermin>) DataRepository.SaServTerminProvider.DeepLoad,
						new object[] { transactionManager, entity.SaServTerminCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdOfferingCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdOffering>|EdOfferingCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdOfferingCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdOfferingCollection = DataRepository.EdOfferingProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.EdOfferingCollection.Count > 0)
				{
					deepHandles.Add("EdOfferingCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdOffering>) DataRepository.EdOfferingProvider.DeepLoad,
						new object[] { transactionManager, entity.EdOfferingCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmAppPrefCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppPref>|AdmAppPrefCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppPrefCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppPrefCollection = DataRepository.AdmAppPrefProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.AdmAppPrefCollection.Count > 0)
				{
					deepHandles.Add("AdmAppPrefCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppPref>) DataRepository.AdmAppPrefProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppPrefCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudAbsenceCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudAbsence>|EdStudAbsenceCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudAbsenceCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudAbsenceCollection = DataRepository.EdStudAbsenceProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.EdStudAbsenceCollection.Count > 0)
				{
					deepHandles.Add("EdStudAbsenceCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudAbsence>) DataRepository.EdStudAbsenceProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudAbsenceCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaWarningCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaWarning>|SaWarningCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaWarningCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaWarningCollection = DataRepository.SaWarningProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.SaWarningCollection.Count > 0)
				{
					deepHandles.Add("SaWarningCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaWarning>) DataRepository.SaWarningProvider.DeepLoad,
						new object[] { transactionManager, entity.SaWarningCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudStateTempCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudStateTemp>|EdStudStateTempCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudStateTempCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudStateTempCollection = DataRepository.EdStudStateTempProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.EdStudStateTempCollection.Count > 0)
				{
					deepHandles.Add("EdStudStateTempCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudStateTemp>) DataRepository.EdStudStateTempProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudStateTempCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaPromotionCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaPromotion>|SaPromotionCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaPromotionCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaPromotionCollection = DataRepository.SaPromotionProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.SaPromotionCollection.Count > 0)
				{
					deepHandles.Add("SaPromotionCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaPromotion>) DataRepository.SaPromotionProvider.DeepLoad,
						new object[] { transactionManager, entity.SaPromotionCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SvStaffEvlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvStaffEvl>|SvStaffEvlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvStaffEvlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvStaffEvlCollection = DataRepository.SvStaffEvlProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.SvStaffEvlCollection.Count > 0)
				{
					deepHandles.Add("SvStaffEvlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvStaffEvl>) DataRepository.SvStaffEvlProvider.DeepLoad,
						new object[] { transactionManager, entity.SvStaffEvlCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SpoSponsorOfferCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SpoSponsorOffer>|SpoSponsorOfferCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SpoSponsorOfferCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SpoSponsorOfferCollection = DataRepository.SpoSponsorOfferProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.SpoSponsorOfferCollection.Count > 0)
				{
					deepHandles.Add("SpoSponsorOfferCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SpoSponsorOffer>) DataRepository.SpoSponsorOfferProvider.DeepLoad,
						new object[] { transactionManager, entity.SpoSponsorOfferCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SvStudAskAdvCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvStudAskAdv>|SvStudAskAdvCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvStudAskAdvCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvStudAskAdvCollection = DataRepository.SvStudAskAdvProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.SvStudAskAdvCollection.Count > 0)
				{
					deepHandles.Add("SvStudAskAdvCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvStudAskAdv>) DataRepository.SvStudAskAdvProvider.DeepLoad,
						new object[] { transactionManager, entity.SvStudAskAdvCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaVacationCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaVacation>|SaVacationCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaVacationCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaVacationCollection = DataRepository.SaVacationProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.SaVacationCollection.Count > 0)
				{
					deepHandles.Add("SaVacationCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaVacation>) DataRepository.SaVacationProvider.DeepLoad,
						new object[] { transactionManager, entity.SaVacationCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaEmploymentCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaEmployment>|SaEmploymentCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaEmploymentCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaEmploymentCollection = DataRepository.SaEmploymentProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.SaEmploymentCollection.Count > 0)
				{
					deepHandles.Add("SaEmploymentCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaEmployment>) DataRepository.SaEmploymentProvider.DeepLoad,
						new object[] { transactionManager, entity.SaEmploymentCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaFinStatmentCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaFinStatment>|SaFinStatmentCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaFinStatmentCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaFinStatmentCollection = DataRepository.SaFinStatmentProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.SaFinStatmentCollection.Count > 0)
				{
					deepHandles.Add("SaFinStatmentCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaFinStatment>) DataRepository.SaFinStatmentProvider.DeepLoad,
						new object[] { transactionManager, entity.SaFinStatmentCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdCourseOutcomesTopicsCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdCourseOutcomesTopics>|EdCourseOutcomesTopicsCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCourseOutcomesTopicsCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdCourseOutcomesTopicsCollection = DataRepository.EdCourseOutcomesTopicsProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.EdCourseOutcomesTopicsCollection.Count > 0)
				{
					deepHandles.Add("EdCourseOutcomesTopicsCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdCourseOutcomesTopics>) DataRepository.EdCourseOutcomesTopicsProvider.DeepLoad,
						new object[] { transactionManager, entity.EdCourseOutcomesTopicsCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdPrintReqCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdPrintReq>|EdPrintReqCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdPrintReqCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdPrintReqCollection = DataRepository.EdPrintReqProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.EdPrintReqCollection.Count > 0)
				{
					deepHandles.Add("EdPrintReqCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdPrintReq>) DataRepository.EdPrintReqProvider.DeepLoad,
						new object[] { transactionManager, entity.EdPrintReqCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeStudFeeItemCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeStudFeeItem>|FeeStudFeeItemCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudFeeItemCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeStudFeeItemCollection = DataRepository.FeeStudFeeItemProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.FeeStudFeeItemCollection.Count > 0)
				{
					deepHandles.Add("FeeStudFeeItemCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudFeeItem>) DataRepository.FeeStudFeeItemProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudFeeItemCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdCodeLevelCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdCodeLevel>|EdCodeLevelCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeLevelCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdCodeLevelCollection = DataRepository.EdCodeLevelProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.EdCodeLevelCollection.Count > 0)
				{
					deepHandles.Add("EdCodeLevelCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdCodeLevel>) DataRepository.EdCodeLevelProvider.DeepLoad,
						new object[] { transactionManager, entity.EdCodeLevelCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region ScGroupInfoCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ScGroupInfo>|ScGroupInfoCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScGroupInfoCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ScGroupInfoCollection = DataRepository.ScGroupInfoProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.ScGroupInfoCollection.Count > 0)
				{
					deepHandles.Add("ScGroupInfoCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScGroupInfo>) DataRepository.ScGroupInfoProvider.DeepLoad,
						new object[] { transactionManager, entity.ScGroupInfoCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaPersonIdCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaPersonId>|SaPersonIdCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaPersonIdCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaPersonIdCollection = DataRepository.SaPersonIdProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.SaPersonIdCollection.Count > 0)
				{
					deepHandles.Add("SaPersonIdCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaPersonId>) DataRepository.SaPersonIdProvider.DeepLoad,
						new object[] { transactionManager, entity.SaPersonIdCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.SaStfMemberCollection = DataRepository.SaStfMemberProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.SaStfMemberCollection.Count > 0)
				{
					deepHandles.Add("SaStfMemberCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaStfMember>) DataRepository.SaStfMemberProvider.DeepLoad,
						new object[] { transactionManager, entity.SaStfMemberCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmCodeEngTestCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmCodeEngTest>|AdmCodeEngTestCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmCodeEngTestCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmCodeEngTestCollection = DataRepository.AdmCodeEngTestProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.AdmCodeEngTestCollection.Count > 0)
				{
					deepHandles.Add("AdmCodeEngTestCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmCodeEngTest>) DataRepository.AdmCodeEngTestProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmCodeEngTestCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.FeeRefndStdReqCollection = DataRepository.FeeRefndStdReqProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.FeeRefndStdReqCollection.Count > 0)
				{
					deepHandles.Add("FeeRefndStdReqCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeRefndStdReq>) DataRepository.FeeRefndStdReqProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeRefndStdReqCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudIntTrnsCourseFromCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudIntTrnsCourseFrom>|EdStudIntTrnsCourseFromCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudIntTrnsCourseFromCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudIntTrnsCourseFromCollection = DataRepository.EdStudIntTrnsCourseFromProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.EdStudIntTrnsCourseFromCollection.Count > 0)
				{
					deepHandles.Add("EdStudIntTrnsCourseFromCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudIntTrnsCourseFrom>) DataRepository.EdStudIntTrnsCourseFromProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudIntTrnsCourseFromCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region CoControlRoomCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<CoControlRoom>|CoControlRoomCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CoControlRoomCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.CoControlRoomCollection = DataRepository.CoControlRoomProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.CoControlRoomCollection.Count > 0)
				{
					deepHandles.Add("CoControlRoomCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CoControlRoom>) DataRepository.CoControlRoomProvider.DeepLoad,
						new object[] { transactionManager, entity.CoControlRoomCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudBranchPrefCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudBranchPref>|EdStudBranchPrefCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudBranchPrefCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudBranchPrefCollection = DataRepository.EdStudBranchPrefProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.EdStudBranchPrefCollection.Count > 0)
				{
					deepHandles.Add("EdStudBranchPrefCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudBranchPref>) DataRepository.EdStudBranchPrefProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudBranchPrefCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeStudDiscContinueCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeStudDiscContinue>|FeeStudDiscContinueCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudDiscContinueCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeStudDiscContinueCollection = DataRepository.FeeStudDiscContinueProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.FeeStudDiscContinueCollection.Count > 0)
				{
					deepHandles.Add("FeeStudDiscContinueCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudDiscContinue>) DataRepository.FeeStudDiscContinueProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudDiscContinueCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeStudInstallmentCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeStudInstallment>|FeeStudInstallmentCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudInstallmentCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeStudInstallmentCollection = DataRepository.FeeStudInstallmentProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.FeeStudInstallmentCollection.Count > 0)
				{
					deepHandles.Add("FeeStudInstallmentCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudInstallment>) DataRepository.FeeStudInstallmentProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudInstallmentCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudGroupCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudGroup>|EdStudGroupCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudGroupCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudGroupCollection = DataRepository.EdStudGroupProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.EdStudGroupCollection.Count > 0)
				{
					deepHandles.Add("EdStudGroupCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudGroup>) DataRepository.EdStudGroupProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudGroupCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudCourseRegCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudCourseReg>|EdStudCourseRegCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCourseRegCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCourseRegCollection = DataRepository.EdStudCourseRegProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.EdStudCourseRegCollection.Count > 0)
				{
					deepHandles.Add("EdStudCourseRegCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCourseReg>) DataRepository.EdStudCourseRegProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCourseRegCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaScQualCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaScQual>|SaScQualCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaScQualCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaScQualCollection = DataRepository.SaScQualProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.SaScQualCollection.Count > 0)
				{
					deepHandles.Add("SaScQualCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaScQual>) DataRepository.SaScQualProvider.DeepLoad,
						new object[] { transactionManager, entity.SaScQualCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region MltOrgTreeCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<MltOrgTree>|MltOrgTreeCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MltOrgTreeCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.MltOrgTreeCollection = DataRepository.MltOrgTreeProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.MltOrgTreeCollection.Count > 0)
				{
					deepHandles.Add("MltOrgTreeCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<MltOrgTree>) DataRepository.MltOrgTreeProvider.DeepLoad,
						new object[] { transactionManager, entity.MltOrgTreeCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaSupervisingJobsCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaSupervisingJobs>|SaSupervisingJobsCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaSupervisingJobsCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaSupervisingJobsCollection = DataRepository.SaSupervisingJobsProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.SaSupervisingJobsCollection.Count > 0)
				{
					deepHandles.Add("SaSupervisingJobsCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaSupervisingJobs>) DataRepository.SaSupervisingJobsProvider.DeepLoad,
						new object[] { transactionManager, entity.SaSupervisingJobsCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdExamSchdlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdExamSchdl>|EdExamSchdlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdExamSchdlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdExamSchdlCollection = DataRepository.EdExamSchdlProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.EdExamSchdlCollection.Count > 0)
				{
					deepHandles.Add("EdExamSchdlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdExamSchdl>) DataRepository.EdExamSchdlProvider.DeepLoad,
						new object[] { transactionManager, entity.EdExamSchdlCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region GsCodeApprovalFacultyCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GsCodeApprovalFaculty>|GsCodeApprovalFacultyCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodeApprovalFacultyCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GsCodeApprovalFacultyCollection = DataRepository.GsCodeApprovalFacultyProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.GsCodeApprovalFacultyCollection.Count > 0)
				{
					deepHandles.Add("GsCodeApprovalFacultyCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GsCodeApprovalFaculty>) DataRepository.GsCodeApprovalFacultyProvider.DeepLoad,
						new object[] { transactionManager, entity.GsCodeApprovalFacultyCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudAcadmicAdvCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudAcadmicAdv>|EdStudAcadmicAdvCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudAcadmicAdvCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudAcadmicAdvCollection = DataRepository.EdStudAcadmicAdvProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.EdStudAcadmicAdvCollection.Count > 0)
				{
					deepHandles.Add("EdStudAcadmicAdvCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudAcadmicAdv>) DataRepository.EdStudAcadmicAdvProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudAcadmicAdvCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaJobActivityCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaJobActivity>|SaJobActivityCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaJobActivityCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaJobActivityCollection = DataRepository.SaJobActivityProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.SaJobActivityCollection.Count > 0)
				{
					deepHandles.Add("SaJobActivityCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaJobActivity>) DataRepository.SaJobActivityProvider.DeepLoad,
						new object[] { transactionManager, entity.SaJobActivityCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudSemesterTempCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudSemesterTemp>|EdStudSemesterTempCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudSemesterTempCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudSemesterTempCollection = DataRepository.EdStudSemesterTempProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.EdStudSemesterTempCollection.Count > 0)
				{
					deepHandles.Add("EdStudSemesterTempCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudSemesterTemp>) DataRepository.EdStudSemesterTempProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudSemesterTempCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region GsCodeApprovalCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GsCodeApproval>|GsCodeApprovalCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodeApprovalCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GsCodeApprovalCollection = DataRepository.GsCodeApprovalProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.GsCodeApprovalCollection.Count > 0)
				{
					deepHandles.Add("GsCodeApprovalCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GsCodeApproval>) DataRepository.GsCodeApprovalProvider.DeepLoad,
						new object[] { transactionManager, entity.GsCodeApprovalCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntityMainCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntityMain>|EntityMainCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntityMainCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntityMainCollection = DataRepository.EntityMainProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.EntityMainCollection.Count > 0)
				{
					deepHandles.Add("EntityMainCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntityMain>) DataRepository.EntityMainProvider.DeepLoad,
						new object[] { transactionManager, entity.EntityMainCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.FeeStudInstallmentRequestCollection = DataRepository.FeeStudInstallmentRequestProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.FeeStudInstallmentRequestCollection.Count > 0)
				{
					deepHandles.Add("FeeStudInstallmentRequestCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudInstallmentRequest>) DataRepository.FeeStudInstallmentRequestProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudInstallmentRequestCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudCourseRegAssessCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudCourseRegAssess>|EdStudCourseRegAssessCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCourseRegAssessCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCourseRegAssessCollection = DataRepository.EdStudCourseRegAssessProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.EdStudCourseRegAssessCollection.Count > 0)
				{
					deepHandles.Add("EdStudCourseRegAssessCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCourseRegAssess>) DataRepository.EdStudCourseRegAssessProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCourseRegAssessCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaCandReleaseCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaCandRelease>|SaCandReleaseCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaCandReleaseCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaCandReleaseCollection = DataRepository.SaCandReleaseProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.SaCandReleaseCollection.Count > 0)
				{
					deepHandles.Add("SaCandReleaseCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaCandRelease>) DataRepository.SaCandReleaseProvider.DeepLoad,
						new object[] { transactionManager, entity.SaCandReleaseCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntPolcyGrdngHdrCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntPolcyGrdngHdr>|EntPolcyGrdngHdrCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPolcyGrdngHdrCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntPolcyGrdngHdrCollection = DataRepository.EntPolcyGrdngHdrProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.EntPolcyGrdngHdrCollection.Count > 0)
				{
					deepHandles.Add("EntPolcyGrdngHdrCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntPolcyGrdngHdr>) DataRepository.EntPolcyGrdngHdrProvider.DeepLoad,
						new object[] { transactionManager, entity.EntPolcyGrdngHdrCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudSemesterCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudSemester>|EdStudSemesterCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudSemesterCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudSemesterCollection = DataRepository.EdStudSemesterProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.EdStudSemesterCollection.Count > 0)
				{
					deepHandles.Add("EdStudSemesterCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudSemester>) DataRepository.EdStudSemesterProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudSemesterCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaScResearchCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaScResearch>|SaScResearchCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaScResearchCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaScResearchCollection = DataRepository.SaScResearchProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.SaScResearchCollection.Count > 0)
				{
					deepHandles.Add("SaScResearchCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaScResearch>) DataRepository.SaScResearchProvider.DeepLoad,
						new object[] { transactionManager, entity.SaScResearchCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdResultApproveCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdResultApprove>|EdResultApproveCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdResultApproveCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdResultApproveCollection = DataRepository.EdResultApproveProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.EdResultApproveCollection.Count > 0)
				{
					deepHandles.Add("EdResultApproveCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdResultApprove>) DataRepository.EdResultApproveProvider.DeepLoad,
						new object[] { transactionManager, entity.EdResultApproveCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SpoSponsorStudSemesterCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SpoSponsorStudSemester>|SpoSponsorStudSemesterCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SpoSponsorStudSemesterCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SpoSponsorStudSemesterCollection = DataRepository.SpoSponsorStudSemesterProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.SpoSponsorStudSemesterCollection.Count > 0)
				{
					deepHandles.Add("SpoSponsorStudSemesterCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SpoSponsorStudSemester>) DataRepository.SpoSponsorStudSemesterProvider.DeepLoad,
						new object[] { transactionManager, entity.SpoSponsorStudSemesterCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdProjectCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdProject>|EdProjectCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdProjectCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdProjectCollection = DataRepository.EdProjectProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.EdProjectCollection.Count > 0)
				{
					deepHandles.Add("EdProjectCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdProject>) DataRepository.EdProjectProvider.DeepLoad,
						new object[] { transactionManager, entity.EdProjectCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region CoCrsRsltRaiseCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<CoCrsRsltRaise>|CoCrsRsltRaiseCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CoCrsRsltRaiseCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.CoCrsRsltRaiseCollection = DataRepository.CoCrsRsltRaiseProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.CoCrsRsltRaiseCollection.Count > 0)
				{
					deepHandles.Add("CoCrsRsltRaiseCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CoCrsRsltRaise>) DataRepository.CoCrsRsltRaiseProvider.DeepLoad,
						new object[] { transactionManager, entity.CoCrsRsltRaiseCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region ScScheduleDtlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ScScheduleDtl>|ScScheduleDtlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScScheduleDtlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ScScheduleDtlCollection = DataRepository.ScScheduleDtlProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.ScScheduleDtlCollection.Count > 0)
				{
					deepHandles.Add("ScScheduleDtlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScScheduleDtl>) DataRepository.ScScheduleDtlProvider.DeepLoad,
						new object[] { transactionManager, entity.ScScheduleDtlCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudFacultyCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudFaculty>|EdStudFacultyCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudFacultyCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudFacultyCollection = DataRepository.EdStudFacultyProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.EdStudFacultyCollection.Count > 0)
				{
					deepHandles.Add("EdStudFacultyCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudFaculty>) DataRepository.EdStudFacultyProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudFacultyCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region ScSectionGroupHdrCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ScSectionGroupHdr>|ScSectionGroupHdrCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScSectionGroupHdrCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ScSectionGroupHdrCollection = DataRepository.ScSectionGroupHdrProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.ScSectionGroupHdrCollection.Count > 0)
				{
					deepHandles.Add("ScSectionGroupHdrCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScSectionGroupHdr>) DataRepository.ScSectionGroupHdrProvider.DeepLoad,
						new object[] { transactionManager, entity.ScSectionGroupHdrCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudIntTrnsStateFromCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudIntTrnsStateFrom>|EdStudIntTrnsStateFromCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudIntTrnsStateFromCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudIntTrnsStateFromCollection = DataRepository.EdStudIntTrnsStateFromProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.EdStudIntTrnsStateFromCollection.Count > 0)
				{
					deepHandles.Add("EdStudIntTrnsStateFromCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudIntTrnsStateFrom>) DataRepository.EdStudIntTrnsStateFromProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudIntTrnsStateFromCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeCdeDiscTypeCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeCdeDiscType>|FeeCdeDiscTypeCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeCdeDiscTypeCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeCdeDiscTypeCollection = DataRepository.FeeCdeDiscTypeProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.FeeCdeDiscTypeCollection.Count > 0)
				{
					deepHandles.Add("FeeCdeDiscTypeCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeCdeDiscType>) DataRepository.FeeCdeDiscTypeProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeCdeDiscTypeCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdGraduationAwardCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdGraduationAward>|EdGraduationAwardCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdGraduationAwardCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdGraduationAwardCollection = DataRepository.EdGraduationAwardProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.EdGraduationAwardCollection.Count > 0)
				{
					deepHandles.Add("EdGraduationAwardCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdGraduationAward>) DataRepository.EdGraduationAwardProvider.DeepLoad,
						new object[] { transactionManager, entity.EdGraduationAwardCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region ScBuildingCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ScBuilding>|ScBuildingCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScBuildingCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ScBuildingCollection = DataRepository.ScBuildingProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.ScBuildingCollection.Count > 0)
				{
					deepHandles.Add("ScBuildingCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScBuilding>) DataRepository.ScBuildingProvider.DeepLoad,
						new object[] { transactionManager, entity.ScBuildingCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudGrantTempCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudGrantTemp>|EdStudGrantTempCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudGrantTempCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudGrantTempCollection = DataRepository.EdStudGrantTempProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.EdStudGrantTempCollection.Count > 0)
				{
					deepHandles.Add("EdStudGrantTempCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudGrantTemp>) DataRepository.EdStudGrantTempProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudGrantTempCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdInttransRuleCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdInttransRule>|EdInttransRuleCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdInttransRuleCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdInttransRuleCollection = DataRepository.EdInttransRuleProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.EdInttransRuleCollection.Count > 0)
				{
					deepHandles.Add("EdInttransRuleCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdInttransRule>) DataRepository.EdInttransRuleProvider.DeepLoad,
						new object[] { transactionManager, entity.EdInttransRuleCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region PgOfferingCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgOffering>|PgOfferingCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgOfferingCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgOfferingCollection = DataRepository.PgOfferingProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.PgOfferingCollection.Count > 0)
				{
					deepHandles.Add("PgOfferingCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgOffering>) DataRepository.PgOfferingProvider.DeepLoad,
						new object[] { transactionManager, entity.PgOfferingCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudStateCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudState>|EdStudStateCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudStateCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudStateCollection = DataRepository.EdStudStateProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.EdStudStateCollection.Count > 0)
				{
					deepHandles.Add("EdStudStateCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudState>) DataRepository.EdStudStateProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudStateCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaPunishmentCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaPunishment>|SaPunishmentCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaPunishmentCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaPunishmentCollection = DataRepository.SaPunishmentProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.SaPunishmentCollection.Count > 0)
				{
					deepHandles.Add("SaPunishmentCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaPunishment>) DataRepository.SaPunishmentProvider.DeepLoad,
						new object[] { transactionManager, entity.SaPunishmentCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaVacationRenewCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaVacationRenew>|SaVacationRenewCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaVacationRenewCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaVacationRenewCollection = DataRepository.SaVacationRenewProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.SaVacationRenewCollection.Count > 0)
				{
					deepHandles.Add("SaVacationRenewCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaVacationRenew>) DataRepository.SaVacationRenewProvider.DeepLoad,
						new object[] { transactionManager, entity.SaVacationRenewCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdBylawCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdBylaw>|EdBylawCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdBylawCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdBylawCollection = DataRepository.EdBylawProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.EdBylawCollection.Count > 0)
				{
					deepHandles.Add("EdBylawCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdBylaw>) DataRepository.EdBylawProvider.DeepLoad,
						new object[] { transactionManager, entity.EdBylawCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaPromotionCondStsfCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaPromotionCondStsf>|SaPromotionCondStsfCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaPromotionCondStsfCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaPromotionCondStsfCollection = DataRepository.SaPromotionCondStsfProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.SaPromotionCondStsfCollection.Count > 0)
				{
					deepHandles.Add("SaPromotionCondStsfCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaPromotionCondStsf>) DataRepository.SaPromotionCondStsfProvider.DeepLoad,
						new object[] { transactionManager, entity.SaPromotionCondStsfCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaCandReleaseDetailCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaCandReleaseDetail>|SaCandReleaseDetailCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaCandReleaseDetailCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaCandReleaseDetailCollection = DataRepository.SaCandReleaseDetailProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.SaCandReleaseDetailCollection.Count > 0)
				{
					deepHandles.Add("SaCandReleaseDetailCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaCandReleaseDetail>) DataRepository.SaCandReleaseDetailProvider.DeepLoad,
						new object[] { transactionManager, entity.SaCandReleaseDetailCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region GsApprovalHCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GsApprovalH>|GsApprovalHCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsApprovalHCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GsApprovalHCollection = DataRepository.GsApprovalHProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.GsApprovalHCollection.Count > 0)
				{
					deepHandles.Add("GsApprovalHCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GsApprovalH>) DataRepository.GsApprovalHProvider.DeepLoad,
						new object[] { transactionManager, entity.GsApprovalHCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudAbsFwCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudAbsFw>|EdStudAbsFwCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudAbsFwCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudAbsFwCollection = DataRepository.EdStudAbsFwProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.EdStudAbsFwCollection.Count > 0)
				{
					deepHandles.Add("EdStudAbsFwCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudAbsFw>) DataRepository.EdStudAbsFwProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudAbsFwCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaTransferCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaTransfer>|SaTransferCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaTransferCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaTransferCollection = DataRepository.SaTransferProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.SaTransferCollection.Count > 0)
				{
					deepHandles.Add("SaTransferCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaTransfer>) DataRepository.SaTransferProvider.DeepLoad,
						new object[] { transactionManager, entity.SaTransferCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.EdStudIntTrnsCollection = DataRepository.EdStudIntTrnsProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.EdStudIntTrnsCollection.Count > 0)
				{
					deepHandles.Add("EdStudIntTrnsCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudIntTrns>) DataRepository.EdStudIntTrnsProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudIntTrnsCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaCodeSuperviseJobCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaCodeSuperviseJob>|SaCodeSuperviseJobCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaCodeSuperviseJobCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaCodeSuperviseJobCollection = DataRepository.SaCodeSuperviseJobProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.SaCodeSuperviseJobCollection.Count > 0)
				{
					deepHandles.Add("SaCodeSuperviseJobCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaCodeSuperviseJob>) DataRepository.SaCodeSuperviseJobProvider.DeepLoad,
						new object[] { transactionManager, entity.SaCodeSuperviseJobCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.FeeStudDiscCollection = DataRepository.FeeStudDiscProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.FeeStudDiscCollection.Count > 0)
				{
					deepHandles.Add("FeeStudDiscCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudDisc>) DataRepository.FeeStudDiscProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudDiscCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudCourseCompCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudCourseComp>|EdStudCourseCompCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCourseCompCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCourseCompCollection = DataRepository.EdStudCourseCompProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.EdStudCourseCompCollection.Count > 0)
				{
					deepHandles.Add("EdStudCourseCompCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCourseComp>) DataRepository.EdStudCourseCompProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCourseCompCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudNoteCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudNote>|EdStudNoteCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudNoteCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudNoteCollection = DataRepository.EdStudNoteProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.EdStudNoteCollection.Count > 0)
				{
					deepHandles.Add("EdStudNoteCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudNote>) DataRepository.EdStudNoteProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudNoteCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaDocOfFileCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaDocOfFile>|SaDocOfFileCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaDocOfFileCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaDocOfFileCollection = DataRepository.SaDocOfFileProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.SaDocOfFileCollection.Count > 0)
				{
					deepHandles.Add("SaDocOfFileCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaDocOfFile>) DataRepository.SaDocOfFileProvider.DeepLoad,
						new object[] { transactionManager, entity.SaDocOfFileCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SvStudAskAdvReCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvStudAskAdvRe>|SvStudAskAdvReCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvStudAskAdvReCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvStudAskAdvReCollection = DataRepository.SvStudAskAdvReProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.SvStudAskAdvReCollection.Count > 0)
				{
					deepHandles.Add("SvStudAskAdvReCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvStudAskAdvRe>) DataRepository.SvStudAskAdvReProvider.DeepLoad,
						new object[] { transactionManager, entity.SvStudAskAdvReCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmAcceptanceCategoryCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAcceptanceCategory>|AdmAcceptanceCategoryCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAcceptanceCategoryCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAcceptanceCategoryCollection = DataRepository.AdmAcceptanceCategoryProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.AdmAcceptanceCategoryCollection.Count > 0)
				{
					deepHandles.Add("AdmAcceptanceCategoryCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAcceptanceCategory>) DataRepository.AdmAcceptanceCategoryProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAcceptanceCategoryCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaVacationBalanceCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaVacationBalance>|SaVacationBalanceCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaVacationBalanceCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaVacationBalanceCollection = DataRepository.SaVacationBalanceProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.SaVacationBalanceCollection.Count > 0)
				{
					deepHandles.Add("SaVacationBalanceCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaVacationBalance>) DataRepository.SaVacationBalanceProvider.DeepLoad,
						new object[] { transactionManager, entity.SaVacationBalanceCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeStudItemCnclCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeStudItemCncl>|FeeStudItemCnclCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudItemCnclCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeStudItemCnclCollection = DataRepository.FeeStudItemCnclProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.FeeStudItemCnclCollection.Count > 0)
				{
					deepHandles.Add("FeeStudItemCnclCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudItemCncl>) DataRepository.FeeStudItemCnclProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudItemCnclCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region PgThesisStudCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgThesisStud>|PgThesisStudCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisStudCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgThesisStudCollection = DataRepository.PgThesisStudProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.PgThesisStudCollection.Count > 0)
				{
					deepHandles.Add("PgThesisStudCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgThesisStud>) DataRepository.PgThesisStudProvider.DeepLoad,
						new object[] { transactionManager, entity.PgThesisStudCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region GsApprovalDCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GsApprovalD>|GsApprovalDCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsApprovalDCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GsApprovalDCollection = DataRepository.GsApprovalDProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.GsApprovalDCollection.Count > 0)
				{
					deepHandles.Add("GsApprovalDCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GsApprovalD>) DataRepository.GsApprovalDProvider.DeepLoad,
						new object[] { transactionManager, entity.GsApprovalDCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudLatenessCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudLateness>|EdStudLatenessCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudLatenessCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudLatenessCollection = DataRepository.EdStudLatenessProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.EdStudLatenessCollection.Count > 0)
				{
					deepHandles.Add("EdStudLatenessCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudLateness>) DataRepository.EdStudLatenessProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudLatenessCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region GsCodeRptSignatureCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GsCodeRptSignature>|GsCodeRptSignatureCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodeRptSignatureCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GsCodeRptSignatureCollection = DataRepository.GsCodeRptSignatureProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.GsCodeRptSignatureCollection.Count > 0)
				{
					deepHandles.Add("GsCodeRptSignatureCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GsCodeRptSignature>) DataRepository.GsCodeRptSignatureProvider.DeepLoad,
						new object[] { transactionManager, entity.GsCodeRptSignatureCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaResearchTeamCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaResearchTeam>|SaResearchTeamCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaResearchTeamCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaResearchTeamCollection = DataRepository.SaResearchTeamProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.SaResearchTeamCollection.Count > 0)
				{
					deepHandles.Add("SaResearchTeamCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaResearchTeam>) DataRepository.SaResearchTeamProvider.DeepLoad,
						new object[] { transactionManager, entity.SaResearchTeamCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.AdmAppTransReqCollection = DataRepository.AdmAppTransReqProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.AdmAppTransReqCollection.Count > 0)
				{
					deepHandles.Add("AdmAppTransReqCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppTransReq>) DataRepository.AdmAppTransReqProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppTransReqCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdSemAgendaDtlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdSemAgendaDtl>|EdSemAgendaDtlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdSemAgendaDtlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdSemAgendaDtlCollection = DataRepository.EdSemAgendaDtlProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.EdSemAgendaDtlCollection.Count > 0)
				{
					deepHandles.Add("EdSemAgendaDtlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdSemAgendaDtl>) DataRepository.EdSemAgendaDtlProvider.DeepLoad,
						new object[] { transactionManager, entity.EdSemAgendaDtlCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdCrsFreeRstrctdCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdCrsFreeRstrctd>|EdCrsFreeRstrctdCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCrsFreeRstrctdCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdCrsFreeRstrctdCollection = DataRepository.EdCrsFreeRstrctdProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.EdCrsFreeRstrctdCollection.Count > 0)
				{
					deepHandles.Add("EdCrsFreeRstrctdCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdCrsFreeRstrctd>) DataRepository.EdCrsFreeRstrctdProvider.DeepLoad,
						new object[] { transactionManager, entity.EdCrsFreeRstrctdCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudGrantDegreeCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudGrantDegree>|EdStudGrantDegreeCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudGrantDegreeCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudGrantDegreeCollection = DataRepository.EdStudGrantDegreeProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.EdStudGrantDegreeCollection.Count > 0)
				{
					deepHandles.Add("EdStudGrantDegreeCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudGrantDegree>) DataRepository.EdStudGrantDegreeProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudGrantDegreeCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudGroupPreCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudGroupPre>|EdStudGroupPreCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudGroupPreCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudGroupPreCollection = DataRepository.EdStudGroupPreProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);

				if (deep && entity.EdStudGroupPreCollection.Count > 0)
				{
					deepHandles.Add("EdStudGroupPreCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudGroupPre>) DataRepository.EdStudGroupPreProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudGroupPreCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AsFacultyInfo object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AsFacultyInfo instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AsFacultyInfo Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AsFacultyInfo entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region GsCountryNodeIdSource
			if (CanDeepSave(entity, "GsCountryNode|GsCountryNodeIdSource", deepSaveType, innerList) 
				&& entity.GsCountryNodeIdSource != null)
			{
				DataRepository.GsCountryNodeProvider.Save(transactionManager, entity.GsCountryNodeIdSource);
				entity.GsCountryNodeId = entity.GsCountryNodeIdSource.GsCountryNodeId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<EdBranchRule>
				if (CanDeepSave(entity.EdBranchRuleCollection, "List<EdBranchRule>|EdBranchRuleCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdBranchRule child in entity.EdBranchRuleCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.EdBranchRuleCollection.Count > 0 || entity.EdBranchRuleCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdBranchRuleProvider.Save(transactionManager, entity.EdBranchRuleCollection);
						
						deepHandles.Add("EdBranchRuleCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdBranchRule >) DataRepository.EdBranchRuleProvider.DeepSave,
							new object[] { transactionManager, entity.EdBranchRuleCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaMilitaryStatus>
				if (CanDeepSave(entity.SaMilitaryStatusCollection, "List<SaMilitaryStatus>|SaMilitaryStatusCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaMilitaryStatus child in entity.SaMilitaryStatusCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.SaMilitaryStatusCollection.Count > 0 || entity.SaMilitaryStatusCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaMilitaryStatusProvider.Save(transactionManager, entity.SaMilitaryStatusCollection);
						
						deepHandles.Add("SaMilitaryStatusCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaMilitaryStatus >) DataRepository.SaMilitaryStatusProvider.DeepSave,
							new object[] { transactionManager, entity.SaMilitaryStatusCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<ScStudGroup>
				if (CanDeepSave(entity.ScStudGroupCollection, "List<ScStudGroup>|ScStudGroupCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScStudGroup child in entity.ScStudGroupCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.ScStudGroupCollection.Count > 0 || entity.ScStudGroupCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ScStudGroupProvider.Save(transactionManager, entity.ScStudGroupCollection);
						
						deepHandles.Add("ScStudGroupCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ScStudGroup >) DataRepository.ScStudGroupProvider.DeepSave,
							new object[] { transactionManager, entity.ScStudGroupCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaRelative>
				if (CanDeepSave(entity.SaRelativeCollection, "List<SaRelative>|SaRelativeCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaRelative child in entity.SaRelativeCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.SaRelativeCollection.Count > 0 || entity.SaRelativeCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaRelativeProvider.Save(transactionManager, entity.SaRelativeCollection);
						
						deepHandles.Add("SaRelativeCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaRelative >) DataRepository.SaRelativeProvider.DeepSave,
							new object[] { transactionManager, entity.SaRelativeCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SeBlockTrans>
				if (CanDeepSave(entity.SeBlockTransCollection, "List<SeBlockTrans>|SeBlockTransCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SeBlockTrans child in entity.SeBlockTransCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.SeBlockTransCollection.Count > 0 || entity.SeBlockTransCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SeBlockTransProvider.Save(transactionManager, entity.SeBlockTransCollection);
						
						deepHandles.Add("SeBlockTransCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SeBlockTrans >) DataRepository.SeBlockTransProvider.DeepSave,
							new object[] { transactionManager, entity.SeBlockTransCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SpoSponsorStud>
				if (CanDeepSave(entity.SpoSponsorStudCollection, "List<SpoSponsorStud>|SpoSponsorStudCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SpoSponsorStud child in entity.SpoSponsorStudCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.SpoSponsorStudCollection.Count > 0 || entity.SpoSponsorStudCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SpoSponsorStudProvider.Save(transactionManager, entity.SpoSponsorStudCollection);
						
						deepHandles.Add("SpoSponsorStudCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SpoSponsorStud >) DataRepository.SpoSponsorStudProvider.DeepSave,
							new object[] { transactionManager, entity.SpoSponsorStudCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdCodeCourseAssess>
				if (CanDeepSave(entity.EdCodeCourseAssessCollection, "List<EdCodeCourseAssess>|EdCodeCourseAssessCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdCodeCourseAssess child in entity.EdCodeCourseAssessCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.EdCodeCourseAssessCollection.Count > 0 || entity.EdCodeCourseAssessCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdCodeCourseAssessProvider.Save(transactionManager, entity.EdCodeCourseAssessCollection);
						
						deepHandles.Add("EdCodeCourseAssessCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdCodeCourseAssess >) DataRepository.EdCodeCourseAssessProvider.DeepSave,
							new object[] { transactionManager, entity.EdCodeCourseAssessCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdCodeDischargeH>
				if (CanDeepSave(entity.EdCodeDischargeHCollection, "List<EdCodeDischargeH>|EdCodeDischargeHCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdCodeDischargeH child in entity.EdCodeDischargeHCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.EdCodeDischargeHCollection.Count > 0 || entity.EdCodeDischargeHCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdCodeDischargeHProvider.Save(transactionManager, entity.EdCodeDischargeHCollection);
						
						deepHandles.Add("EdCodeDischargeHCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdCodeDischargeH >) DataRepository.EdCodeDischargeHProvider.DeepSave,
							new object[] { transactionManager, entity.EdCodeDischargeHCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaCdeAcadLoad>
				if (CanDeepSave(entity.SaCdeAcadLoadCollection, "List<SaCdeAcadLoad>|SaCdeAcadLoadCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaCdeAcadLoad child in entity.SaCdeAcadLoadCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.SaCdeAcadLoadCollection.Count > 0 || entity.SaCdeAcadLoadCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaCdeAcadLoadProvider.Save(transactionManager, entity.SaCdeAcadLoadCollection);
						
						deepHandles.Add("SaCdeAcadLoadCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaCdeAcadLoad >) DataRepository.SaCdeAcadLoadProvider.DeepSave,
							new object[] { transactionManager, entity.SaCdeAcadLoadCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaEmpHierarchy>
				if (CanDeepSave(entity.SaEmpHierarchyCollection, "List<SaEmpHierarchy>|SaEmpHierarchyCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaEmpHierarchy child in entity.SaEmpHierarchyCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.SaEmpHierarchyCollection.Count > 0 || entity.SaEmpHierarchyCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaEmpHierarchyProvider.Save(transactionManager, entity.SaEmpHierarchyCollection);
						
						deepHandles.Add("SaEmpHierarchyCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaEmpHierarchy >) DataRepository.SaEmpHierarchyProvider.DeepSave,
							new object[] { transactionManager, entity.SaEmpHierarchyCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdCodeCourseTeaching>
				if (CanDeepSave(entity.EdCodeCourseTeachingCollection, "List<EdCodeCourseTeaching>|EdCodeCourseTeachingCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdCodeCourseTeaching child in entity.EdCodeCourseTeachingCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.EdCodeCourseTeachingCollection.Count > 0 || entity.EdCodeCourseTeachingCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdCodeCourseTeachingProvider.Save(transactionManager, entity.EdCodeCourseTeachingCollection);
						
						deepHandles.Add("EdCodeCourseTeachingCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdCodeCourseTeaching >) DataRepository.EdCodeCourseTeachingProvider.DeepSave,
							new object[] { transactionManager, entity.EdCodeCourseTeachingCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudCourseRegPre>
				if (CanDeepSave(entity.EdStudCourseRegPreCollection, "List<EdStudCourseRegPre>|EdStudCourseRegPreCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudCourseRegPre child in entity.EdStudCourseRegPreCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.EdStudCourseRegPreCollection.Count > 0 || entity.EdStudCourseRegPreCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudCourseRegPreProvider.Save(transactionManager, entity.EdStudCourseRegPreCollection);
						
						deepHandles.Add("EdStudCourseRegPreCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudCourseRegPre >) DataRepository.EdStudCourseRegPreProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCourseRegPreCollection, deepSaveType, childTypes, innerList }
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
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
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
				
	
			#region List<GsComm>
				if (CanDeepSave(entity.GsCommCollection, "List<GsComm>|GsCommCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GsComm child in entity.GsCommCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.GsCommCollection.Count > 0 || entity.GsCommCollection.DeletedItems.Count > 0)
					{
						//DataRepository.GsCommProvider.Save(transactionManager, entity.GsCommCollection);
						
						deepHandles.Add("GsCommCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< GsComm >) DataRepository.GsCommProvider.DeepSave,
							new object[] { transactionManager, entity.GsCommCollection, deepSaveType, childTypes, innerList }
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
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
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
				
	
			#region List<EdStudAcadWarn>
				if (CanDeepSave(entity.EdStudAcadWarnCollection, "List<EdStudAcadWarn>|EdStudAcadWarnCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudAcadWarn child in entity.EdStudAcadWarnCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.EdStudAcadWarnCollection.Count > 0 || entity.EdStudAcadWarnCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudAcadWarnProvider.Save(transactionManager, entity.EdStudAcadWarnCollection);
						
						deepHandles.Add("EdStudAcadWarnCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudAcadWarn >) DataRepository.EdStudAcadWarnProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudAcadWarnCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<PgThesisGrantDegree>
				if (CanDeepSave(entity.PgThesisGrantDegreeCollection, "List<PgThesisGrantDegree>|PgThesisGrantDegreeCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgThesisGrantDegree child in entity.PgThesisGrantDegreeCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.PgThesisGrantDegreeCollection.Count > 0 || entity.PgThesisGrantDegreeCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgThesisGrantDegreeProvider.Save(transactionManager, entity.PgThesisGrantDegreeCollection);
						
						deepHandles.Add("PgThesisGrantDegreeCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgThesisGrantDegree >) DataRepository.PgThesisGrantDegreeProvider.DeepSave,
							new object[] { transactionManager, entity.PgThesisGrantDegreeCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdCourseTopic>
				if (CanDeepSave(entity.EdCourseTopicCollection, "List<EdCourseTopic>|EdCourseTopicCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdCourseTopic child in entity.EdCourseTopicCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.EdCourseTopicCollection.Count > 0 || entity.EdCourseTopicCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdCourseTopicProvider.Save(transactionManager, entity.EdCourseTopicCollection);
						
						deepHandles.Add("EdCourseTopicCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdCourseTopic >) DataRepository.EdCourseTopicProvider.DeepSave,
							new object[] { transactionManager, entity.EdCourseTopicCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeFine>
				if (CanDeepSave(entity.FeeFineCollection, "List<FeeFine>|FeeFineCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeFine child in entity.FeeFineCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.FeeFineCollection.Count > 0 || entity.FeeFineCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeFineProvider.Save(transactionManager, entity.FeeFineCollection);
						
						deepHandles.Add("FeeFineCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeFine >) DataRepository.FeeFineProvider.DeepSave,
							new object[] { transactionManager, entity.FeeFineCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudQualSubject>
				if (CanDeepSave(entity.EdStudQualSubjectCollection, "List<EdStudQualSubject>|EdStudQualSubjectCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudQualSubject child in entity.EdStudQualSubjectCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.EdStudQualSubjectCollection.Count > 0 || entity.EdStudQualSubjectCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudQualSubjectProvider.Save(transactionManager, entity.EdStudQualSubjectCollection);
						
						deepHandles.Add("EdStudQualSubjectCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudQualSubject >) DataRepository.EdStudQualSubjectProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudQualSubjectCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudIntTrnsCourseTo>
				if (CanDeepSave(entity.EdStudIntTrnsCourseToCollection, "List<EdStudIntTrnsCourseTo>|EdStudIntTrnsCourseToCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudIntTrnsCourseTo child in entity.EdStudIntTrnsCourseToCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.EdStudIntTrnsCourseToCollection.Count > 0 || entity.EdStudIntTrnsCourseToCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudIntTrnsCourseToProvider.Save(transactionManager, entity.EdStudIntTrnsCourseToCollection);
						
						deepHandles.Add("EdStudIntTrnsCourseToCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudIntTrnsCourseTo >) DataRepository.EdStudIntTrnsCourseToProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudIntTrnsCourseToCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeStudNatSimilarityRequest>
				if (CanDeepSave(entity.FeeStudNatSimilarityRequestCollection, "List<FeeStudNatSimilarityRequest>|FeeStudNatSimilarityRequestCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeStudNatSimilarityRequest child in entity.FeeStudNatSimilarityRequestCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.FeeStudNatSimilarityRequestCollection.Count > 0 || entity.FeeStudNatSimilarityRequestCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeStudNatSimilarityRequestProvider.Save(transactionManager, entity.FeeStudNatSimilarityRequestCollection);
						
						deepHandles.Add("FeeStudNatSimilarityRequestCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeStudNatSimilarityRequest >) DataRepository.FeeStudNatSimilarityRequestProvider.DeepSave,
							new object[] { transactionManager, entity.FeeStudNatSimilarityRequestCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaJobStoppage>
				if (CanDeepSave(entity.SaJobStoppageCollection, "List<SaJobStoppage>|SaJobStoppageCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaJobStoppage child in entity.SaJobStoppageCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.SaJobStoppageCollection.Count > 0 || entity.SaJobStoppageCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaJobStoppageProvider.Save(transactionManager, entity.SaJobStoppageCollection);
						
						deepHandles.Add("SaJobStoppageCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaJobStoppage >) DataRepository.SaJobStoppageProvider.DeepSave,
							new object[] { transactionManager, entity.SaJobStoppageCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaPromotionRequest>
				if (CanDeepSave(entity.SaPromotionRequestCollection, "List<SaPromotionRequest>|SaPromotionRequestCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaPromotionRequest child in entity.SaPromotionRequestCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.SaPromotionRequestCollection.Count > 0 || entity.SaPromotionRequestCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaPromotionRequestProvider.Save(transactionManager, entity.SaPromotionRequestCollection);
						
						deepHandles.Add("SaPromotionRequestCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaPromotionRequest >) DataRepository.SaPromotionRequestProvider.DeepSave,
							new object[] { transactionManager, entity.SaPromotionRequestCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<CoScheduleDetail>
				if (CanDeepSave(entity.CoScheduleDetailCollection, "List<CoScheduleDetail>|CoScheduleDetailCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CoScheduleDetail child in entity.CoScheduleDetailCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.CoScheduleDetailCollection.Count > 0 || entity.CoScheduleDetailCollection.DeletedItems.Count > 0)
					{
						//DataRepository.CoScheduleDetailProvider.Save(transactionManager, entity.CoScheduleDetailCollection);
						
						deepHandles.Add("CoScheduleDetailCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< CoScheduleDetail >) DataRepository.CoScheduleDetailProvider.DeepSave,
							new object[] { transactionManager, entity.CoScheduleDetailCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaVacationBalanceH>
				if (CanDeepSave(entity.SaVacationBalanceHCollection, "List<SaVacationBalanceH>|SaVacationBalanceHCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaVacationBalanceH child in entity.SaVacationBalanceHCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.SaVacationBalanceHCollection.Count > 0 || entity.SaVacationBalanceHCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaVacationBalanceHProvider.Save(transactionManager, entity.SaVacationBalanceHCollection);
						
						deepHandles.Add("SaVacationBalanceHCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaVacationBalanceH >) DataRepository.SaVacationBalanceHProvider.DeepSave,
							new object[] { transactionManager, entity.SaVacationBalanceHCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaPublication>
				if (CanDeepSave(entity.SaPublicationCollection, "List<SaPublication>|SaPublicationCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaPublication child in entity.SaPublicationCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.SaPublicationCollection.Count > 0 || entity.SaPublicationCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaPublicationProvider.Save(transactionManager, entity.SaPublicationCollection);
						
						deepHandles.Add("SaPublicationCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaPublication >) DataRepository.SaPublicationProvider.DeepSave,
							new object[] { transactionManager, entity.SaPublicationCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeFacultyRule>
				if (CanDeepSave(entity.FeeFacultyRuleCollection, "List<FeeFacultyRule>|FeeFacultyRuleCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeFacultyRule child in entity.FeeFacultyRuleCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.FeeFacultyRuleCollection.Count > 0 || entity.FeeFacultyRuleCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeFacultyRuleProvider.Save(transactionManager, entity.FeeFacultyRuleCollection);
						
						deepHandles.Add("FeeFacultyRuleCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeFacultyRule >) DataRepository.FeeFacultyRuleProvider.DeepSave,
							new object[] { transactionManager, entity.FeeFacultyRuleCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SvPollHdr>
				if (CanDeepSave(entity.SvPollHdrCollection, "List<SvPollHdr>|SvPollHdrCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvPollHdr child in entity.SvPollHdrCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.SvPollHdrCollection.Count > 0 || entity.SvPollHdrCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvPollHdrProvider.Save(transactionManager, entity.SvPollHdrCollection);
						
						deepHandles.Add("SvPollHdrCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvPollHdr >) DataRepository.SvPollHdrProvider.DeepSave,
							new object[] { transactionManager, entity.SvPollHdrCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeStudVoucher>
				if (CanDeepSave(entity.FeeStudVoucherCollection, "List<FeeStudVoucher>|FeeStudVoucherCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeStudVoucher child in entity.FeeStudVoucherCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.FeeStudVoucherCollection.Count > 0 || entity.FeeStudVoucherCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeStudVoucherProvider.Save(transactionManager, entity.FeeStudVoucherCollection);
						
						deepHandles.Add("FeeStudVoucherCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeStudVoucher >) DataRepository.FeeStudVoucherProvider.DeepSave,
							new object[] { transactionManager, entity.FeeStudVoucherCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdAcadYearFaculty>
				if (CanDeepSave(entity.EdAcadYearFacultyCollection, "List<EdAcadYearFaculty>|EdAcadYearFacultyCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdAcadYearFaculty child in entity.EdAcadYearFacultyCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.EdAcadYearFacultyCollection.Count > 0 || entity.EdAcadYearFacultyCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdAcadYearFacultyProvider.Save(transactionManager, entity.EdAcadYearFacultyCollection);
						
						deepHandles.Add("EdAcadYearFacultyCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdAcadYearFaculty >) DataRepository.EdAcadYearFacultyProvider.DeepSave,
							new object[] { transactionManager, entity.EdAcadYearFacultyCollection, deepSaveType, childTypes, innerList }
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
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
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
				
	
			#region List<SeUserCrsAssess>
				if (CanDeepSave(entity.SeUserCrsAssessCollection, "List<SeUserCrsAssess>|SeUserCrsAssessCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SeUserCrsAssess child in entity.SeUserCrsAssessCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.SeUserCrsAssessCollection.Count > 0 || entity.SeUserCrsAssessCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SeUserCrsAssessProvider.Save(transactionManager, entity.SeUserCrsAssessCollection);
						
						deepHandles.Add("SeUserCrsAssessCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SeUserCrsAssess >) DataRepository.SeUserCrsAssessProvider.DeepSave,
							new object[] { transactionManager, entity.SeUserCrsAssessCollection, deepSaveType, childTypes, innerList }
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
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
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
				
	
			#region List<GsCdeClrncItemFac>
				if (CanDeepSave(entity.GsCdeClrncItemFacCollection, "List<GsCdeClrncItemFac>|GsCdeClrncItemFacCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GsCdeClrncItemFac child in entity.GsCdeClrncItemFacCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.GsCdeClrncItemFacCollection.Count > 0 || entity.GsCdeClrncItemFacCollection.DeletedItems.Count > 0)
					{
						//DataRepository.GsCdeClrncItemFacProvider.Save(transactionManager, entity.GsCdeClrncItemFacCollection);
						
						deepHandles.Add("GsCdeClrncItemFacCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< GsCdeClrncItemFac >) DataRepository.GsCdeClrncItemFacProvider.DeepSave,
							new object[] { transactionManager, entity.GsCdeClrncItemFacCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaRaise>
				if (CanDeepSave(entity.SaRaiseCollection, "List<SaRaise>|SaRaiseCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaRaise child in entity.SaRaiseCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.SaRaiseCollection.Count > 0 || entity.SaRaiseCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaRaiseProvider.Save(transactionManager, entity.SaRaiseCollection);
						
						deepHandles.Add("SaRaiseCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaRaise >) DataRepository.SaRaiseProvider.DeepSave,
							new object[] { transactionManager, entity.SaRaiseCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudIntTrnsStateTo>
				if (CanDeepSave(entity.EdStudIntTrnsStateToCollection, "List<EdStudIntTrnsStateTo>|EdStudIntTrnsStateToCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudIntTrnsStateTo child in entity.EdStudIntTrnsStateToCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.EdStudIntTrnsStateToCollection.Count > 0 || entity.EdStudIntTrnsStateToCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudIntTrnsStateToProvider.Save(transactionManager, entity.EdStudIntTrnsStateToCollection);
						
						deepHandles.Add("EdStudIntTrnsStateToCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudIntTrnsStateTo >) DataRepository.EdStudIntTrnsStateToProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudIntTrnsStateToCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmPrecondQual>
				if (CanDeepSave(entity.AdmPrecondQualCollection, "List<AdmPrecondQual>|AdmPrecondQualCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmPrecondQual child in entity.AdmPrecondQualCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.AdmPrecondQualCollection.Count > 0 || entity.AdmPrecondQualCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmPrecondQualProvider.Save(transactionManager, entity.AdmPrecondQualCollection);
						
						deepHandles.Add("AdmPrecondQualCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmPrecondQual >) DataRepository.AdmPrecondQualProvider.DeepSave,
							new object[] { transactionManager, entity.AdmPrecondQualCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmRatingParametersMajors>
				if (CanDeepSave(entity.AdmRatingParametersMajorsCollection, "List<AdmRatingParametersMajors>|AdmRatingParametersMajorsCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmRatingParametersMajors child in entity.AdmRatingParametersMajorsCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.AdmRatingParametersMajorsCollection.Count > 0 || entity.AdmRatingParametersMajorsCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmRatingParametersMajorsProvider.Save(transactionManager, entity.AdmRatingParametersMajorsCollection);
						
						deepHandles.Add("AdmRatingParametersMajorsCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmRatingParametersMajors >) DataRepository.AdmRatingParametersMajorsProvider.DeepSave,
							new object[] { transactionManager, entity.AdmRatingParametersMajorsCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<ScSchdlPeriod>
				if (CanDeepSave(entity.ScSchdlPeriodCollection, "List<ScSchdlPeriod>|ScSchdlPeriodCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScSchdlPeriod child in entity.ScSchdlPeriodCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.ScSchdlPeriodCollection.Count > 0 || entity.ScSchdlPeriodCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ScSchdlPeriodProvider.Save(transactionManager, entity.ScSchdlPeriodCollection);
						
						deepHandles.Add("ScSchdlPeriodCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ScSchdlPeriod >) DataRepository.ScSchdlPeriodProvider.DeepSave,
							new object[] { transactionManager, entity.ScSchdlPeriodCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeStudRetrieveRequest>
				if (CanDeepSave(entity.FeeStudRetrieveRequestCollection, "List<FeeStudRetrieveRequest>|FeeStudRetrieveRequestCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeStudRetrieveRequest child in entity.FeeStudRetrieveRequestCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.FeeStudRetrieveRequestCollection.Count > 0 || entity.FeeStudRetrieveRequestCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeStudRetrieveRequestProvider.Save(transactionManager, entity.FeeStudRetrieveRequestCollection);
						
						deepHandles.Add("FeeStudRetrieveRequestCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeStudRetrieveRequest >) DataRepository.FeeStudRetrieveRequestProvider.DeepSave,
							new object[] { transactionManager, entity.FeeStudRetrieveRequestCollection, deepSaveType, childTypes, innerList }
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
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
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
				
	
			#region List<ScHallRsrv>
				if (CanDeepSave(entity.ScHallRsrvCollection, "List<ScHallRsrv>|ScHallRsrvCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScHallRsrv child in entity.ScHallRsrvCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.ScHallRsrvCollection.Count > 0 || entity.ScHallRsrvCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ScHallRsrvProvider.Save(transactionManager, entity.ScHallRsrvCollection);
						
						deepHandles.Add("ScHallRsrvCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ScHallRsrv >) DataRepository.ScHallRsrvProvider.DeepSave,
							new object[] { transactionManager, entity.ScHallRsrvCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdResidencyStud>
				if (CanDeepSave(entity.EdResidencyStudCollection, "List<EdResidencyStud>|EdResidencyStudCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdResidencyStud child in entity.EdResidencyStudCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.EdResidencyStudCollection.Count > 0 || entity.EdResidencyStudCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdResidencyStudProvider.Save(transactionManager, entity.EdResidencyStudCollection);
						
						deepHandles.Add("EdResidencyStudCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdResidencyStud >) DataRepository.EdResidencyStudProvider.DeepSave,
							new object[] { transactionManager, entity.EdResidencyStudCollection, deepSaveType, childTypes, innerList }
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
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
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
				
	
			#region List<EdCourse>
				if (CanDeepSave(entity.EdCourseCollection, "List<EdCourse>|EdCourseCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdCourse child in entity.EdCourseCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.EdCourseCollection.Count > 0 || entity.EdCourseCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdCourseProvider.Save(transactionManager, entity.EdCourseCollection);
						
						deepHandles.Add("EdCourseCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdCourse >) DataRepository.EdCourseProvider.DeepSave,
							new object[] { transactionManager, entity.EdCourseCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SvAutoMsgTmplt>
				if (CanDeepSave(entity.SvAutoMsgTmpltCollection, "List<SvAutoMsgTmplt>|SvAutoMsgTmpltCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvAutoMsgTmplt child in entity.SvAutoMsgTmpltCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.SvAutoMsgTmpltCollection.Count > 0 || entity.SvAutoMsgTmpltCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvAutoMsgTmpltProvider.Save(transactionManager, entity.SvAutoMsgTmpltCollection);
						
						deepHandles.Add("SvAutoMsgTmpltCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvAutoMsgTmplt >) DataRepository.SvAutoMsgTmpltProvider.DeepSave,
							new object[] { transactionManager, entity.SvAutoMsgTmpltCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<ScScheduleRsrv>
				if (CanDeepSave(entity.ScScheduleRsrvCollection, "List<ScScheduleRsrv>|ScScheduleRsrvCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScScheduleRsrv child in entity.ScScheduleRsrvCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.ScScheduleRsrvCollection.Count > 0 || entity.ScScheduleRsrvCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ScScheduleRsrvProvider.Save(transactionManager, entity.ScScheduleRsrvCollection);
						
						deepHandles.Add("ScScheduleRsrvCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ScScheduleRsrv >) DataRepository.ScScheduleRsrvProvider.DeepSave,
							new object[] { transactionManager, entity.ScScheduleRsrvCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaScCommDecision>
				if (CanDeepSave(entity.SaScCommDecisionCollection, "List<SaScCommDecision>|SaScCommDecisionCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaScCommDecision child in entity.SaScCommDecisionCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.SaScCommDecisionCollection.Count > 0 || entity.SaScCommDecisionCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaScCommDecisionProvider.Save(transactionManager, entity.SaScCommDecisionCollection);
						
						deepHandles.Add("SaScCommDecisionCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaScCommDecision >) DataRepository.SaScCommDecisionProvider.DeepSave,
							new object[] { transactionManager, entity.SaScCommDecisionCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudIntTransPref>
				if (CanDeepSave(entity.EdStudIntTransPrefCollection, "List<EdStudIntTransPref>|EdStudIntTransPrefCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudIntTransPref child in entity.EdStudIntTransPrefCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.EdStudIntTransPrefCollection.Count > 0 || entity.EdStudIntTransPrefCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudIntTransPrefProvider.Save(transactionManager, entity.EdStudIntTransPrefCollection);
						
						deepHandles.Add("EdStudIntTransPrefCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudIntTransPref >) DataRepository.EdStudIntTransPrefProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudIntTransPrefCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaTrainingCourse>
				if (CanDeepSave(entity.SaTrainingCourseCollection, "List<SaTrainingCourse>|SaTrainingCourseCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaTrainingCourse child in entity.SaTrainingCourseCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
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
				
	
			#region List<SaMiltary>
				if (CanDeepSave(entity.SaMiltaryCollection, "List<SaMiltary>|SaMiltaryCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaMiltary child in entity.SaMiltaryCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.SaMiltaryCollection.Count > 0 || entity.SaMiltaryCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaMiltaryProvider.Save(transactionManager, entity.SaMiltaryCollection);
						
						deepHandles.Add("SaMiltaryCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaMiltary >) DataRepository.SaMiltaryProvider.DeepSave,
							new object[] { transactionManager, entity.SaMiltaryCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeInstlmntRule>
				if (CanDeepSave(entity.FeeInstlmntRuleCollection, "List<FeeInstlmntRule>|FeeInstlmntRuleCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeInstlmntRule child in entity.FeeInstlmntRuleCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.FeeInstlmntRuleCollection.Count > 0 || entity.FeeInstlmntRuleCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeInstlmntRuleProvider.Save(transactionManager, entity.FeeInstlmntRuleCollection);
						
						deepHandles.Add("FeeInstlmntRuleCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeInstlmntRule >) DataRepository.FeeInstlmntRuleProvider.DeepSave,
							new object[] { transactionManager, entity.FeeInstlmntRuleCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmCompetitiveAvg>
				if (CanDeepSave(entity.AdmCompetitiveAvgCollection, "List<AdmCompetitiveAvg>|AdmCompetitiveAvgCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmCompetitiveAvg child in entity.AdmCompetitiveAvgCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.AdmCompetitiveAvgCollection.Count > 0 || entity.AdmCompetitiveAvgCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmCompetitiveAvgProvider.Save(transactionManager, entity.AdmCompetitiveAvgCollection);
						
						deepHandles.Add("AdmCompetitiveAvgCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmCompetitiveAvg >) DataRepository.AdmCompetitiveAvgProvider.DeepSave,
							new object[] { transactionManager, entity.AdmCompetitiveAvgCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<RsrchStudRegister>
				if (CanDeepSave(entity.RsrchStudRegisterCollection, "List<RsrchStudRegister>|RsrchStudRegisterCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(RsrchStudRegister child in entity.RsrchStudRegisterCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.RsrchStudRegisterCollection.Count > 0 || entity.RsrchStudRegisterCollection.DeletedItems.Count > 0)
					{
						//DataRepository.RsrchStudRegisterProvider.Save(transactionManager, entity.RsrchStudRegisterCollection);
						
						deepHandles.Add("RsrchStudRegisterCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< RsrchStudRegister >) DataRepository.RsrchStudRegisterProvider.DeepSave,
							new object[] { transactionManager, entity.RsrchStudRegisterCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SeForm>
				if (CanDeepSave(entity.SeFormCollection, "List<SeForm>|SeFormCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SeForm child in entity.SeFormCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.SeFormCollection.Count > 0 || entity.SeFormCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SeFormProvider.Save(transactionManager, entity.SeFormCollection);
						
						deepHandles.Add("SeFormCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SeForm >) DataRepository.SeFormProvider.DeepSave,
							new object[] { transactionManager, entity.SeFormCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdOfferingCourse>
				if (CanDeepSave(entity.EdOfferingCourseCollection, "List<EdOfferingCourse>|EdOfferingCourseCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdOfferingCourse child in entity.EdOfferingCourseCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.EdOfferingCourseCollection.Count > 0 || entity.EdOfferingCourseCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdOfferingCourseProvider.Save(transactionManager, entity.EdOfferingCourseCollection);
						
						deepHandles.Add("EdOfferingCourseCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdOfferingCourse >) DataRepository.EdOfferingCourseProvider.DeepSave,
							new object[] { transactionManager, entity.EdOfferingCourseCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeLimitRule>
				if (CanDeepSave(entity.FeeLimitRuleCollection, "List<FeeLimitRule>|FeeLimitRuleCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeLimitRule child in entity.FeeLimitRuleCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.FeeLimitRuleCollection.Count > 0 || entity.FeeLimitRuleCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeLimitRuleProvider.Save(transactionManager, entity.FeeLimitRuleCollection);
						
						deepHandles.Add("FeeLimitRuleCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeLimitRule >) DataRepository.FeeLimitRuleProvider.DeepSave,
							new object[] { transactionManager, entity.FeeLimitRuleCollection, deepSaveType, childTypes, innerList }
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
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
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
				
	
			#region List<SaServTermin>
				if (CanDeepSave(entity.SaServTerminCollection, "List<SaServTermin>|SaServTerminCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaServTermin child in entity.SaServTerminCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
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
				
	
			#region List<EdOffering>
				if (CanDeepSave(entity.EdOfferingCollection, "List<EdOffering>|EdOfferingCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdOffering child in entity.EdOfferingCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.EdOfferingCollection.Count > 0 || entity.EdOfferingCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdOfferingProvider.Save(transactionManager, entity.EdOfferingCollection);
						
						deepHandles.Add("EdOfferingCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdOffering >) DataRepository.EdOfferingProvider.DeepSave,
							new object[] { transactionManager, entity.EdOfferingCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmAppPref>
				if (CanDeepSave(entity.AdmAppPrefCollection, "List<AdmAppPref>|AdmAppPrefCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppPref child in entity.AdmAppPrefCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.AdmAppPrefCollection.Count > 0 || entity.AdmAppPrefCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppPrefProvider.Save(transactionManager, entity.AdmAppPrefCollection);
						
						deepHandles.Add("AdmAppPrefCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppPref >) DataRepository.AdmAppPrefProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppPrefCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudAbsence>
				if (CanDeepSave(entity.EdStudAbsenceCollection, "List<EdStudAbsence>|EdStudAbsenceCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudAbsence child in entity.EdStudAbsenceCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.EdStudAbsenceCollection.Count > 0 || entity.EdStudAbsenceCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudAbsenceProvider.Save(transactionManager, entity.EdStudAbsenceCollection);
						
						deepHandles.Add("EdStudAbsenceCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudAbsence >) DataRepository.EdStudAbsenceProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudAbsenceCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaWarning>
				if (CanDeepSave(entity.SaWarningCollection, "List<SaWarning>|SaWarningCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaWarning child in entity.SaWarningCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.SaWarningCollection.Count > 0 || entity.SaWarningCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaWarningProvider.Save(transactionManager, entity.SaWarningCollection);
						
						deepHandles.Add("SaWarningCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaWarning >) DataRepository.SaWarningProvider.DeepSave,
							new object[] { transactionManager, entity.SaWarningCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudStateTemp>
				if (CanDeepSave(entity.EdStudStateTempCollection, "List<EdStudStateTemp>|EdStudStateTempCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudStateTemp child in entity.EdStudStateTempCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.EdStudStateTempCollection.Count > 0 || entity.EdStudStateTempCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudStateTempProvider.Save(transactionManager, entity.EdStudStateTempCollection);
						
						deepHandles.Add("EdStudStateTempCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudStateTemp >) DataRepository.EdStudStateTempProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudStateTempCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaPromotion>
				if (CanDeepSave(entity.SaPromotionCollection, "List<SaPromotion>|SaPromotionCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaPromotion child in entity.SaPromotionCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.SaPromotionCollection.Count > 0 || entity.SaPromotionCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaPromotionProvider.Save(transactionManager, entity.SaPromotionCollection);
						
						deepHandles.Add("SaPromotionCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaPromotion >) DataRepository.SaPromotionProvider.DeepSave,
							new object[] { transactionManager, entity.SaPromotionCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SvStaffEvl>
				if (CanDeepSave(entity.SvStaffEvlCollection, "List<SvStaffEvl>|SvStaffEvlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvStaffEvl child in entity.SvStaffEvlCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.SvStaffEvlCollection.Count > 0 || entity.SvStaffEvlCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvStaffEvlProvider.Save(transactionManager, entity.SvStaffEvlCollection);
						
						deepHandles.Add("SvStaffEvlCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvStaffEvl >) DataRepository.SvStaffEvlProvider.DeepSave,
							new object[] { transactionManager, entity.SvStaffEvlCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SpoSponsorOffer>
				if (CanDeepSave(entity.SpoSponsorOfferCollection, "List<SpoSponsorOffer>|SpoSponsorOfferCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SpoSponsorOffer child in entity.SpoSponsorOfferCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.SpoSponsorOfferCollection.Count > 0 || entity.SpoSponsorOfferCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SpoSponsorOfferProvider.Save(transactionManager, entity.SpoSponsorOfferCollection);
						
						deepHandles.Add("SpoSponsorOfferCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SpoSponsorOffer >) DataRepository.SpoSponsorOfferProvider.DeepSave,
							new object[] { transactionManager, entity.SpoSponsorOfferCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SvStudAskAdv>
				if (CanDeepSave(entity.SvStudAskAdvCollection, "List<SvStudAskAdv>|SvStudAskAdvCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvStudAskAdv child in entity.SvStudAskAdvCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.SvStudAskAdvCollection.Count > 0 || entity.SvStudAskAdvCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvStudAskAdvProvider.Save(transactionManager, entity.SvStudAskAdvCollection);
						
						deepHandles.Add("SvStudAskAdvCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvStudAskAdv >) DataRepository.SvStudAskAdvProvider.DeepSave,
							new object[] { transactionManager, entity.SvStudAskAdvCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaVacation>
				if (CanDeepSave(entity.SaVacationCollection, "List<SaVacation>|SaVacationCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaVacation child in entity.SaVacationCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.SaVacationCollection.Count > 0 || entity.SaVacationCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaVacationProvider.Save(transactionManager, entity.SaVacationCollection);
						
						deepHandles.Add("SaVacationCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaVacation >) DataRepository.SaVacationProvider.DeepSave,
							new object[] { transactionManager, entity.SaVacationCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaEmployment>
				if (CanDeepSave(entity.SaEmploymentCollection, "List<SaEmployment>|SaEmploymentCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaEmployment child in entity.SaEmploymentCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.SaEmploymentCollection.Count > 0 || entity.SaEmploymentCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaEmploymentProvider.Save(transactionManager, entity.SaEmploymentCollection);
						
						deepHandles.Add("SaEmploymentCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaEmployment >) DataRepository.SaEmploymentProvider.DeepSave,
							new object[] { transactionManager, entity.SaEmploymentCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaFinStatment>
				if (CanDeepSave(entity.SaFinStatmentCollection, "List<SaFinStatment>|SaFinStatmentCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaFinStatment child in entity.SaFinStatmentCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.SaFinStatmentCollection.Count > 0 || entity.SaFinStatmentCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaFinStatmentProvider.Save(transactionManager, entity.SaFinStatmentCollection);
						
						deepHandles.Add("SaFinStatmentCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaFinStatment >) DataRepository.SaFinStatmentProvider.DeepSave,
							new object[] { transactionManager, entity.SaFinStatmentCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdCourseOutcomesTopics>
				if (CanDeepSave(entity.EdCourseOutcomesTopicsCollection, "List<EdCourseOutcomesTopics>|EdCourseOutcomesTopicsCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdCourseOutcomesTopics child in entity.EdCourseOutcomesTopicsCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.EdCourseOutcomesTopicsCollection.Count > 0 || entity.EdCourseOutcomesTopicsCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdCourseOutcomesTopicsProvider.Save(transactionManager, entity.EdCourseOutcomesTopicsCollection);
						
						deepHandles.Add("EdCourseOutcomesTopicsCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdCourseOutcomesTopics >) DataRepository.EdCourseOutcomesTopicsProvider.DeepSave,
							new object[] { transactionManager, entity.EdCourseOutcomesTopicsCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdPrintReq>
				if (CanDeepSave(entity.EdPrintReqCollection, "List<EdPrintReq>|EdPrintReqCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdPrintReq child in entity.EdPrintReqCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.EdPrintReqCollection.Count > 0 || entity.EdPrintReqCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdPrintReqProvider.Save(transactionManager, entity.EdPrintReqCollection);
						
						deepHandles.Add("EdPrintReqCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdPrintReq >) DataRepository.EdPrintReqProvider.DeepSave,
							new object[] { transactionManager, entity.EdPrintReqCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeStudFeeItem>
				if (CanDeepSave(entity.FeeStudFeeItemCollection, "List<FeeStudFeeItem>|FeeStudFeeItemCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeStudFeeItem child in entity.FeeStudFeeItemCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.FeeStudFeeItemCollection.Count > 0 || entity.FeeStudFeeItemCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeStudFeeItemProvider.Save(transactionManager, entity.FeeStudFeeItemCollection);
						
						deepHandles.Add("FeeStudFeeItemCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeStudFeeItem >) DataRepository.FeeStudFeeItemProvider.DeepSave,
							new object[] { transactionManager, entity.FeeStudFeeItemCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdCodeLevel>
				if (CanDeepSave(entity.EdCodeLevelCollection, "List<EdCodeLevel>|EdCodeLevelCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdCodeLevel child in entity.EdCodeLevelCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.EdCodeLevelCollection.Count > 0 || entity.EdCodeLevelCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdCodeLevelProvider.Save(transactionManager, entity.EdCodeLevelCollection);
						
						deepHandles.Add("EdCodeLevelCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdCodeLevel >) DataRepository.EdCodeLevelProvider.DeepSave,
							new object[] { transactionManager, entity.EdCodeLevelCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<ScGroupInfo>
				if (CanDeepSave(entity.ScGroupInfoCollection, "List<ScGroupInfo>|ScGroupInfoCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScGroupInfo child in entity.ScGroupInfoCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.ScGroupInfoCollection.Count > 0 || entity.ScGroupInfoCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ScGroupInfoProvider.Save(transactionManager, entity.ScGroupInfoCollection);
						
						deepHandles.Add("ScGroupInfoCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ScGroupInfo >) DataRepository.ScGroupInfoProvider.DeepSave,
							new object[] { transactionManager, entity.ScGroupInfoCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaPersonId>
				if (CanDeepSave(entity.SaPersonIdCollection, "List<SaPersonId>|SaPersonIdCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaPersonId child in entity.SaPersonIdCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.SaPersonIdCollection.Count > 0 || entity.SaPersonIdCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaPersonIdProvider.Save(transactionManager, entity.SaPersonIdCollection);
						
						deepHandles.Add("SaPersonIdCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaPersonId >) DataRepository.SaPersonIdProvider.DeepSave,
							new object[] { transactionManager, entity.SaPersonIdCollection, deepSaveType, childTypes, innerList }
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
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
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
				
	
			#region List<AdmCodeEngTest>
				if (CanDeepSave(entity.AdmCodeEngTestCollection, "List<AdmCodeEngTest>|AdmCodeEngTestCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmCodeEngTest child in entity.AdmCodeEngTestCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.AdmCodeEngTestCollection.Count > 0 || entity.AdmCodeEngTestCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmCodeEngTestProvider.Save(transactionManager, entity.AdmCodeEngTestCollection);
						
						deepHandles.Add("AdmCodeEngTestCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmCodeEngTest >) DataRepository.AdmCodeEngTestProvider.DeepSave,
							new object[] { transactionManager, entity.AdmCodeEngTestCollection, deepSaveType, childTypes, innerList }
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
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
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
				
	
			#region List<EdStudIntTrnsCourseFrom>
				if (CanDeepSave(entity.EdStudIntTrnsCourseFromCollection, "List<EdStudIntTrnsCourseFrom>|EdStudIntTrnsCourseFromCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudIntTrnsCourseFrom child in entity.EdStudIntTrnsCourseFromCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.EdStudIntTrnsCourseFromCollection.Count > 0 || entity.EdStudIntTrnsCourseFromCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudIntTrnsCourseFromProvider.Save(transactionManager, entity.EdStudIntTrnsCourseFromCollection);
						
						deepHandles.Add("EdStudIntTrnsCourseFromCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudIntTrnsCourseFrom >) DataRepository.EdStudIntTrnsCourseFromProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudIntTrnsCourseFromCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<CoControlRoom>
				if (CanDeepSave(entity.CoControlRoomCollection, "List<CoControlRoom>|CoControlRoomCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CoControlRoom child in entity.CoControlRoomCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.CoControlRoomCollection.Count > 0 || entity.CoControlRoomCollection.DeletedItems.Count > 0)
					{
						//DataRepository.CoControlRoomProvider.Save(transactionManager, entity.CoControlRoomCollection);
						
						deepHandles.Add("CoControlRoomCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< CoControlRoom >) DataRepository.CoControlRoomProvider.DeepSave,
							new object[] { transactionManager, entity.CoControlRoomCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudBranchPref>
				if (CanDeepSave(entity.EdStudBranchPrefCollection, "List<EdStudBranchPref>|EdStudBranchPrefCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudBranchPref child in entity.EdStudBranchPrefCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.EdStudBranchPrefCollection.Count > 0 || entity.EdStudBranchPrefCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudBranchPrefProvider.Save(transactionManager, entity.EdStudBranchPrefCollection);
						
						deepHandles.Add("EdStudBranchPrefCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudBranchPref >) DataRepository.EdStudBranchPrefProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudBranchPrefCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeStudDiscContinue>
				if (CanDeepSave(entity.FeeStudDiscContinueCollection, "List<FeeStudDiscContinue>|FeeStudDiscContinueCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeStudDiscContinue child in entity.FeeStudDiscContinueCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.FeeStudDiscContinueCollection.Count > 0 || entity.FeeStudDiscContinueCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeStudDiscContinueProvider.Save(transactionManager, entity.FeeStudDiscContinueCollection);
						
						deepHandles.Add("FeeStudDiscContinueCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeStudDiscContinue >) DataRepository.FeeStudDiscContinueProvider.DeepSave,
							new object[] { transactionManager, entity.FeeStudDiscContinueCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeStudInstallment>
				if (CanDeepSave(entity.FeeStudInstallmentCollection, "List<FeeStudInstallment>|FeeStudInstallmentCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeStudInstallment child in entity.FeeStudInstallmentCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.FeeStudInstallmentCollection.Count > 0 || entity.FeeStudInstallmentCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeStudInstallmentProvider.Save(transactionManager, entity.FeeStudInstallmentCollection);
						
						deepHandles.Add("FeeStudInstallmentCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeStudInstallment >) DataRepository.FeeStudInstallmentProvider.DeepSave,
							new object[] { transactionManager, entity.FeeStudInstallmentCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudGroup>
				if (CanDeepSave(entity.EdStudGroupCollection, "List<EdStudGroup>|EdStudGroupCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudGroup child in entity.EdStudGroupCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.EdStudGroupCollection.Count > 0 || entity.EdStudGroupCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudGroupProvider.Save(transactionManager, entity.EdStudGroupCollection);
						
						deepHandles.Add("EdStudGroupCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudGroup >) DataRepository.EdStudGroupProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudGroupCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudCourseReg>
				if (CanDeepSave(entity.EdStudCourseRegCollection, "List<EdStudCourseReg>|EdStudCourseRegCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudCourseReg child in entity.EdStudCourseRegCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.EdStudCourseRegCollection.Count > 0 || entity.EdStudCourseRegCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudCourseRegProvider.Save(transactionManager, entity.EdStudCourseRegCollection);
						
						deepHandles.Add("EdStudCourseRegCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudCourseReg >) DataRepository.EdStudCourseRegProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCourseRegCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaScQual>
				if (CanDeepSave(entity.SaScQualCollection, "List<SaScQual>|SaScQualCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaScQual child in entity.SaScQualCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.SaScQualCollection.Count > 0 || entity.SaScQualCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaScQualProvider.Save(transactionManager, entity.SaScQualCollection);
						
						deepHandles.Add("SaScQualCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaScQual >) DataRepository.SaScQualProvider.DeepSave,
							new object[] { transactionManager, entity.SaScQualCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<MltOrgTree>
				if (CanDeepSave(entity.MltOrgTreeCollection, "List<MltOrgTree>|MltOrgTreeCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(MltOrgTree child in entity.MltOrgTreeCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.MltOrgTreeCollection.Count > 0 || entity.MltOrgTreeCollection.DeletedItems.Count > 0)
					{
						//DataRepository.MltOrgTreeProvider.Save(transactionManager, entity.MltOrgTreeCollection);
						
						deepHandles.Add("MltOrgTreeCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< MltOrgTree >) DataRepository.MltOrgTreeProvider.DeepSave,
							new object[] { transactionManager, entity.MltOrgTreeCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaSupervisingJobs>
				if (CanDeepSave(entity.SaSupervisingJobsCollection, "List<SaSupervisingJobs>|SaSupervisingJobsCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaSupervisingJobs child in entity.SaSupervisingJobsCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.SaSupervisingJobsCollection.Count > 0 || entity.SaSupervisingJobsCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaSupervisingJobsProvider.Save(transactionManager, entity.SaSupervisingJobsCollection);
						
						deepHandles.Add("SaSupervisingJobsCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaSupervisingJobs >) DataRepository.SaSupervisingJobsProvider.DeepSave,
							new object[] { transactionManager, entity.SaSupervisingJobsCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdExamSchdl>
				if (CanDeepSave(entity.EdExamSchdlCollection, "List<EdExamSchdl>|EdExamSchdlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdExamSchdl child in entity.EdExamSchdlCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.EdExamSchdlCollection.Count > 0 || entity.EdExamSchdlCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdExamSchdlProvider.Save(transactionManager, entity.EdExamSchdlCollection);
						
						deepHandles.Add("EdExamSchdlCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdExamSchdl >) DataRepository.EdExamSchdlProvider.DeepSave,
							new object[] { transactionManager, entity.EdExamSchdlCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<GsCodeApprovalFaculty>
				if (CanDeepSave(entity.GsCodeApprovalFacultyCollection, "List<GsCodeApprovalFaculty>|GsCodeApprovalFacultyCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GsCodeApprovalFaculty child in entity.GsCodeApprovalFacultyCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.GsCodeApprovalFacultyCollection.Count > 0 || entity.GsCodeApprovalFacultyCollection.DeletedItems.Count > 0)
					{
						//DataRepository.GsCodeApprovalFacultyProvider.Save(transactionManager, entity.GsCodeApprovalFacultyCollection);
						
						deepHandles.Add("GsCodeApprovalFacultyCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< GsCodeApprovalFaculty >) DataRepository.GsCodeApprovalFacultyProvider.DeepSave,
							new object[] { transactionManager, entity.GsCodeApprovalFacultyCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudAcadmicAdv>
				if (CanDeepSave(entity.EdStudAcadmicAdvCollection, "List<EdStudAcadmicAdv>|EdStudAcadmicAdvCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudAcadmicAdv child in entity.EdStudAcadmicAdvCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.EdStudAcadmicAdvCollection.Count > 0 || entity.EdStudAcadmicAdvCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudAcadmicAdvProvider.Save(transactionManager, entity.EdStudAcadmicAdvCollection);
						
						deepHandles.Add("EdStudAcadmicAdvCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudAcadmicAdv >) DataRepository.EdStudAcadmicAdvProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudAcadmicAdvCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaJobActivity>
				if (CanDeepSave(entity.SaJobActivityCollection, "List<SaJobActivity>|SaJobActivityCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaJobActivity child in entity.SaJobActivityCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.SaJobActivityCollection.Count > 0 || entity.SaJobActivityCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaJobActivityProvider.Save(transactionManager, entity.SaJobActivityCollection);
						
						deepHandles.Add("SaJobActivityCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaJobActivity >) DataRepository.SaJobActivityProvider.DeepSave,
							new object[] { transactionManager, entity.SaJobActivityCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudSemesterTemp>
				if (CanDeepSave(entity.EdStudSemesterTempCollection, "List<EdStudSemesterTemp>|EdStudSemesterTempCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudSemesterTemp child in entity.EdStudSemesterTempCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.EdStudSemesterTempCollection.Count > 0 || entity.EdStudSemesterTempCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudSemesterTempProvider.Save(transactionManager, entity.EdStudSemesterTempCollection);
						
						deepHandles.Add("EdStudSemesterTempCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudSemesterTemp >) DataRepository.EdStudSemesterTempProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudSemesterTempCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<GsCodeApproval>
				if (CanDeepSave(entity.GsCodeApprovalCollection, "List<GsCodeApproval>|GsCodeApprovalCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GsCodeApproval child in entity.GsCodeApprovalCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.GsCodeApprovalCollection.Count > 0 || entity.GsCodeApprovalCollection.DeletedItems.Count > 0)
					{
						//DataRepository.GsCodeApprovalProvider.Save(transactionManager, entity.GsCodeApprovalCollection);
						
						deepHandles.Add("GsCodeApprovalCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< GsCodeApproval >) DataRepository.GsCodeApprovalProvider.DeepSave,
							new object[] { transactionManager, entity.GsCodeApprovalCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntityMain>
				if (CanDeepSave(entity.EntityMainCollection, "List<EntityMain>|EntityMainCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntityMain child in entity.EntityMainCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.EntityMainCollection.Count > 0 || entity.EntityMainCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntityMainProvider.Save(transactionManager, entity.EntityMainCollection);
						
						deepHandles.Add("EntityMainCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntityMain >) DataRepository.EntityMainProvider.DeepSave,
							new object[] { transactionManager, entity.EntityMainCollection, deepSaveType, childTypes, innerList }
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
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
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
				
	
			#region List<EdStudCourseRegAssess>
				if (CanDeepSave(entity.EdStudCourseRegAssessCollection, "List<EdStudCourseRegAssess>|EdStudCourseRegAssessCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudCourseRegAssess child in entity.EdStudCourseRegAssessCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.EdStudCourseRegAssessCollection.Count > 0 || entity.EdStudCourseRegAssessCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudCourseRegAssessProvider.Save(transactionManager, entity.EdStudCourseRegAssessCollection);
						
						deepHandles.Add("EdStudCourseRegAssessCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudCourseRegAssess >) DataRepository.EdStudCourseRegAssessProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCourseRegAssessCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaCandRelease>
				if (CanDeepSave(entity.SaCandReleaseCollection, "List<SaCandRelease>|SaCandReleaseCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaCandRelease child in entity.SaCandReleaseCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.SaCandReleaseCollection.Count > 0 || entity.SaCandReleaseCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaCandReleaseProvider.Save(transactionManager, entity.SaCandReleaseCollection);
						
						deepHandles.Add("SaCandReleaseCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaCandRelease >) DataRepository.SaCandReleaseProvider.DeepSave,
							new object[] { transactionManager, entity.SaCandReleaseCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntPolcyGrdngHdr>
				if (CanDeepSave(entity.EntPolcyGrdngHdrCollection, "List<EntPolcyGrdngHdr>|EntPolcyGrdngHdrCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntPolcyGrdngHdr child in entity.EntPolcyGrdngHdrCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.EntPolcyGrdngHdrCollection.Count > 0 || entity.EntPolcyGrdngHdrCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntPolcyGrdngHdrProvider.Save(transactionManager, entity.EntPolcyGrdngHdrCollection);
						
						deepHandles.Add("EntPolcyGrdngHdrCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntPolcyGrdngHdr >) DataRepository.EntPolcyGrdngHdrProvider.DeepSave,
							new object[] { transactionManager, entity.EntPolcyGrdngHdrCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudSemester>
				if (CanDeepSave(entity.EdStudSemesterCollection, "List<EdStudSemester>|EdStudSemesterCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudSemester child in entity.EdStudSemesterCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.EdStudSemesterCollection.Count > 0 || entity.EdStudSemesterCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudSemesterProvider.Save(transactionManager, entity.EdStudSemesterCollection);
						
						deepHandles.Add("EdStudSemesterCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudSemester >) DataRepository.EdStudSemesterProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudSemesterCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaScResearch>
				if (CanDeepSave(entity.SaScResearchCollection, "List<SaScResearch>|SaScResearchCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaScResearch child in entity.SaScResearchCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.SaScResearchCollection.Count > 0 || entity.SaScResearchCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaScResearchProvider.Save(transactionManager, entity.SaScResearchCollection);
						
						deepHandles.Add("SaScResearchCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaScResearch >) DataRepository.SaScResearchProvider.DeepSave,
							new object[] { transactionManager, entity.SaScResearchCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdResultApprove>
				if (CanDeepSave(entity.EdResultApproveCollection, "List<EdResultApprove>|EdResultApproveCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdResultApprove child in entity.EdResultApproveCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.EdResultApproveCollection.Count > 0 || entity.EdResultApproveCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdResultApproveProvider.Save(transactionManager, entity.EdResultApproveCollection);
						
						deepHandles.Add("EdResultApproveCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdResultApprove >) DataRepository.EdResultApproveProvider.DeepSave,
							new object[] { transactionManager, entity.EdResultApproveCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SpoSponsorStudSemester>
				if (CanDeepSave(entity.SpoSponsorStudSemesterCollection, "List<SpoSponsorStudSemester>|SpoSponsorStudSemesterCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SpoSponsorStudSemester child in entity.SpoSponsorStudSemesterCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.SpoSponsorStudSemesterCollection.Count > 0 || entity.SpoSponsorStudSemesterCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SpoSponsorStudSemesterProvider.Save(transactionManager, entity.SpoSponsorStudSemesterCollection);
						
						deepHandles.Add("SpoSponsorStudSemesterCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SpoSponsorStudSemester >) DataRepository.SpoSponsorStudSemesterProvider.DeepSave,
							new object[] { transactionManager, entity.SpoSponsorStudSemesterCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdProject>
				if (CanDeepSave(entity.EdProjectCollection, "List<EdProject>|EdProjectCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdProject child in entity.EdProjectCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.EdProjectCollection.Count > 0 || entity.EdProjectCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdProjectProvider.Save(transactionManager, entity.EdProjectCollection);
						
						deepHandles.Add("EdProjectCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdProject >) DataRepository.EdProjectProvider.DeepSave,
							new object[] { transactionManager, entity.EdProjectCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<CoCrsRsltRaise>
				if (CanDeepSave(entity.CoCrsRsltRaiseCollection, "List<CoCrsRsltRaise>|CoCrsRsltRaiseCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CoCrsRsltRaise child in entity.CoCrsRsltRaiseCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.CoCrsRsltRaiseCollection.Count > 0 || entity.CoCrsRsltRaiseCollection.DeletedItems.Count > 0)
					{
						//DataRepository.CoCrsRsltRaiseProvider.Save(transactionManager, entity.CoCrsRsltRaiseCollection);
						
						deepHandles.Add("CoCrsRsltRaiseCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< CoCrsRsltRaise >) DataRepository.CoCrsRsltRaiseProvider.DeepSave,
							new object[] { transactionManager, entity.CoCrsRsltRaiseCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<ScScheduleDtl>
				if (CanDeepSave(entity.ScScheduleDtlCollection, "List<ScScheduleDtl>|ScScheduleDtlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScScheduleDtl child in entity.ScScheduleDtlCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.ScScheduleDtlCollection.Count > 0 || entity.ScScheduleDtlCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ScScheduleDtlProvider.Save(transactionManager, entity.ScScheduleDtlCollection);
						
						deepHandles.Add("ScScheduleDtlCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ScScheduleDtl >) DataRepository.ScScheduleDtlProvider.DeepSave,
							new object[] { transactionManager, entity.ScScheduleDtlCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudFaculty>
				if (CanDeepSave(entity.EdStudFacultyCollection, "List<EdStudFaculty>|EdStudFacultyCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudFaculty child in entity.EdStudFacultyCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.EdStudFacultyCollection.Count > 0 || entity.EdStudFacultyCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudFacultyProvider.Save(transactionManager, entity.EdStudFacultyCollection);
						
						deepHandles.Add("EdStudFacultyCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudFaculty >) DataRepository.EdStudFacultyProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudFacultyCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<ScSectionGroupHdr>
				if (CanDeepSave(entity.ScSectionGroupHdrCollection, "List<ScSectionGroupHdr>|ScSectionGroupHdrCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScSectionGroupHdr child in entity.ScSectionGroupHdrCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.ScSectionGroupHdrCollection.Count > 0 || entity.ScSectionGroupHdrCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ScSectionGroupHdrProvider.Save(transactionManager, entity.ScSectionGroupHdrCollection);
						
						deepHandles.Add("ScSectionGroupHdrCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ScSectionGroupHdr >) DataRepository.ScSectionGroupHdrProvider.DeepSave,
							new object[] { transactionManager, entity.ScSectionGroupHdrCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudIntTrnsStateFrom>
				if (CanDeepSave(entity.EdStudIntTrnsStateFromCollection, "List<EdStudIntTrnsStateFrom>|EdStudIntTrnsStateFromCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudIntTrnsStateFrom child in entity.EdStudIntTrnsStateFromCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.EdStudIntTrnsStateFromCollection.Count > 0 || entity.EdStudIntTrnsStateFromCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudIntTrnsStateFromProvider.Save(transactionManager, entity.EdStudIntTrnsStateFromCollection);
						
						deepHandles.Add("EdStudIntTrnsStateFromCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudIntTrnsStateFrom >) DataRepository.EdStudIntTrnsStateFromProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudIntTrnsStateFromCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeCdeDiscType>
				if (CanDeepSave(entity.FeeCdeDiscTypeCollection, "List<FeeCdeDiscType>|FeeCdeDiscTypeCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeCdeDiscType child in entity.FeeCdeDiscTypeCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.FeeCdeDiscTypeCollection.Count > 0 || entity.FeeCdeDiscTypeCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeCdeDiscTypeProvider.Save(transactionManager, entity.FeeCdeDiscTypeCollection);
						
						deepHandles.Add("FeeCdeDiscTypeCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeCdeDiscType >) DataRepository.FeeCdeDiscTypeProvider.DeepSave,
							new object[] { transactionManager, entity.FeeCdeDiscTypeCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdGraduationAward>
				if (CanDeepSave(entity.EdGraduationAwardCollection, "List<EdGraduationAward>|EdGraduationAwardCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdGraduationAward child in entity.EdGraduationAwardCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.EdGraduationAwardCollection.Count > 0 || entity.EdGraduationAwardCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdGraduationAwardProvider.Save(transactionManager, entity.EdGraduationAwardCollection);
						
						deepHandles.Add("EdGraduationAwardCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdGraduationAward >) DataRepository.EdGraduationAwardProvider.DeepSave,
							new object[] { transactionManager, entity.EdGraduationAwardCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<ScBuilding>
				if (CanDeepSave(entity.ScBuildingCollection, "List<ScBuilding>|ScBuildingCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScBuilding child in entity.ScBuildingCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.ScBuildingCollection.Count > 0 || entity.ScBuildingCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ScBuildingProvider.Save(transactionManager, entity.ScBuildingCollection);
						
						deepHandles.Add("ScBuildingCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ScBuilding >) DataRepository.ScBuildingProvider.DeepSave,
							new object[] { transactionManager, entity.ScBuildingCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudGrantTemp>
				if (CanDeepSave(entity.EdStudGrantTempCollection, "List<EdStudGrantTemp>|EdStudGrantTempCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudGrantTemp child in entity.EdStudGrantTempCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.EdStudGrantTempCollection.Count > 0 || entity.EdStudGrantTempCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudGrantTempProvider.Save(transactionManager, entity.EdStudGrantTempCollection);
						
						deepHandles.Add("EdStudGrantTempCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudGrantTemp >) DataRepository.EdStudGrantTempProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudGrantTempCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdInttransRule>
				if (CanDeepSave(entity.EdInttransRuleCollection, "List<EdInttransRule>|EdInttransRuleCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdInttransRule child in entity.EdInttransRuleCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.EdInttransRuleCollection.Count > 0 || entity.EdInttransRuleCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdInttransRuleProvider.Save(transactionManager, entity.EdInttransRuleCollection);
						
						deepHandles.Add("EdInttransRuleCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdInttransRule >) DataRepository.EdInttransRuleProvider.DeepSave,
							new object[] { transactionManager, entity.EdInttransRuleCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<PgOffering>
				if (CanDeepSave(entity.PgOfferingCollection, "List<PgOffering>|PgOfferingCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgOffering child in entity.PgOfferingCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.PgOfferingCollection.Count > 0 || entity.PgOfferingCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgOfferingProvider.Save(transactionManager, entity.PgOfferingCollection);
						
						deepHandles.Add("PgOfferingCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgOffering >) DataRepository.PgOfferingProvider.DeepSave,
							new object[] { transactionManager, entity.PgOfferingCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudState>
				if (CanDeepSave(entity.EdStudStateCollection, "List<EdStudState>|EdStudStateCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudState child in entity.EdStudStateCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.EdStudStateCollection.Count > 0 || entity.EdStudStateCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudStateProvider.Save(transactionManager, entity.EdStudStateCollection);
						
						deepHandles.Add("EdStudStateCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudState >) DataRepository.EdStudStateProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudStateCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaPunishment>
				if (CanDeepSave(entity.SaPunishmentCollection, "List<SaPunishment>|SaPunishmentCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaPunishment child in entity.SaPunishmentCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
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
				
	
			#region List<SaVacationRenew>
				if (CanDeepSave(entity.SaVacationRenewCollection, "List<SaVacationRenew>|SaVacationRenewCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaVacationRenew child in entity.SaVacationRenewCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.SaVacationRenewCollection.Count > 0 || entity.SaVacationRenewCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaVacationRenewProvider.Save(transactionManager, entity.SaVacationRenewCollection);
						
						deepHandles.Add("SaVacationRenewCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaVacationRenew >) DataRepository.SaVacationRenewProvider.DeepSave,
							new object[] { transactionManager, entity.SaVacationRenewCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdBylaw>
				if (CanDeepSave(entity.EdBylawCollection, "List<EdBylaw>|EdBylawCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdBylaw child in entity.EdBylawCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.EdBylawCollection.Count > 0 || entity.EdBylawCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdBylawProvider.Save(transactionManager, entity.EdBylawCollection);
						
						deepHandles.Add("EdBylawCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdBylaw >) DataRepository.EdBylawProvider.DeepSave,
							new object[] { transactionManager, entity.EdBylawCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaPromotionCondStsf>
				if (CanDeepSave(entity.SaPromotionCondStsfCollection, "List<SaPromotionCondStsf>|SaPromotionCondStsfCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaPromotionCondStsf child in entity.SaPromotionCondStsfCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.SaPromotionCondStsfCollection.Count > 0 || entity.SaPromotionCondStsfCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaPromotionCondStsfProvider.Save(transactionManager, entity.SaPromotionCondStsfCollection);
						
						deepHandles.Add("SaPromotionCondStsfCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaPromotionCondStsf >) DataRepository.SaPromotionCondStsfProvider.DeepSave,
							new object[] { transactionManager, entity.SaPromotionCondStsfCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaCandReleaseDetail>
				if (CanDeepSave(entity.SaCandReleaseDetailCollection, "List<SaCandReleaseDetail>|SaCandReleaseDetailCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaCandReleaseDetail child in entity.SaCandReleaseDetailCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.SaCandReleaseDetailCollection.Count > 0 || entity.SaCandReleaseDetailCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaCandReleaseDetailProvider.Save(transactionManager, entity.SaCandReleaseDetailCollection);
						
						deepHandles.Add("SaCandReleaseDetailCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaCandReleaseDetail >) DataRepository.SaCandReleaseDetailProvider.DeepSave,
							new object[] { transactionManager, entity.SaCandReleaseDetailCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<GsApprovalH>
				if (CanDeepSave(entity.GsApprovalHCollection, "List<GsApprovalH>|GsApprovalHCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GsApprovalH child in entity.GsApprovalHCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.GsApprovalHCollection.Count > 0 || entity.GsApprovalHCollection.DeletedItems.Count > 0)
					{
						//DataRepository.GsApprovalHProvider.Save(transactionManager, entity.GsApprovalHCollection);
						
						deepHandles.Add("GsApprovalHCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< GsApprovalH >) DataRepository.GsApprovalHProvider.DeepSave,
							new object[] { transactionManager, entity.GsApprovalHCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudAbsFw>
				if (CanDeepSave(entity.EdStudAbsFwCollection, "List<EdStudAbsFw>|EdStudAbsFwCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudAbsFw child in entity.EdStudAbsFwCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.EdStudAbsFwCollection.Count > 0 || entity.EdStudAbsFwCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudAbsFwProvider.Save(transactionManager, entity.EdStudAbsFwCollection);
						
						deepHandles.Add("EdStudAbsFwCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudAbsFw >) DataRepository.EdStudAbsFwProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudAbsFwCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaTransfer>
				if (CanDeepSave(entity.SaTransferCollection, "List<SaTransfer>|SaTransferCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaTransfer child in entity.SaTransferCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
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
				
	
			#region List<EdStudIntTrns>
				if (CanDeepSave(entity.EdStudIntTrnsCollection, "List<EdStudIntTrns>|EdStudIntTrnsCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudIntTrns child in entity.EdStudIntTrnsCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
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
				
	
			#region List<SaCodeSuperviseJob>
				if (CanDeepSave(entity.SaCodeSuperviseJobCollection, "List<SaCodeSuperviseJob>|SaCodeSuperviseJobCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaCodeSuperviseJob child in entity.SaCodeSuperviseJobCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.SaCodeSuperviseJobCollection.Count > 0 || entity.SaCodeSuperviseJobCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaCodeSuperviseJobProvider.Save(transactionManager, entity.SaCodeSuperviseJobCollection);
						
						deepHandles.Add("SaCodeSuperviseJobCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaCodeSuperviseJob >) DataRepository.SaCodeSuperviseJobProvider.DeepSave,
							new object[] { transactionManager, entity.SaCodeSuperviseJobCollection, deepSaveType, childTypes, innerList }
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
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
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
				
	
			#region List<EdStudCourseComp>
				if (CanDeepSave(entity.EdStudCourseCompCollection, "List<EdStudCourseComp>|EdStudCourseCompCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudCourseComp child in entity.EdStudCourseCompCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.EdStudCourseCompCollection.Count > 0 || entity.EdStudCourseCompCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudCourseCompProvider.Save(transactionManager, entity.EdStudCourseCompCollection);
						
						deepHandles.Add("EdStudCourseCompCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudCourseComp >) DataRepository.EdStudCourseCompProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCourseCompCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudNote>
				if (CanDeepSave(entity.EdStudNoteCollection, "List<EdStudNote>|EdStudNoteCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudNote child in entity.EdStudNoteCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.EdStudNoteCollection.Count > 0 || entity.EdStudNoteCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudNoteProvider.Save(transactionManager, entity.EdStudNoteCollection);
						
						deepHandles.Add("EdStudNoteCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudNote >) DataRepository.EdStudNoteProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudNoteCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaDocOfFile>
				if (CanDeepSave(entity.SaDocOfFileCollection, "List<SaDocOfFile>|SaDocOfFileCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaDocOfFile child in entity.SaDocOfFileCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.SaDocOfFileCollection.Count > 0 || entity.SaDocOfFileCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaDocOfFileProvider.Save(transactionManager, entity.SaDocOfFileCollection);
						
						deepHandles.Add("SaDocOfFileCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaDocOfFile >) DataRepository.SaDocOfFileProvider.DeepSave,
							new object[] { transactionManager, entity.SaDocOfFileCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SvStudAskAdvRe>
				if (CanDeepSave(entity.SvStudAskAdvReCollection, "List<SvStudAskAdvRe>|SvStudAskAdvReCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvStudAskAdvRe child in entity.SvStudAskAdvReCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.SvStudAskAdvReCollection.Count > 0 || entity.SvStudAskAdvReCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvStudAskAdvReProvider.Save(transactionManager, entity.SvStudAskAdvReCollection);
						
						deepHandles.Add("SvStudAskAdvReCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvStudAskAdvRe >) DataRepository.SvStudAskAdvReProvider.DeepSave,
							new object[] { transactionManager, entity.SvStudAskAdvReCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmAcceptanceCategory>
				if (CanDeepSave(entity.AdmAcceptanceCategoryCollection, "List<AdmAcceptanceCategory>|AdmAcceptanceCategoryCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAcceptanceCategory child in entity.AdmAcceptanceCategoryCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.AdmAcceptanceCategoryCollection.Count > 0 || entity.AdmAcceptanceCategoryCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAcceptanceCategoryProvider.Save(transactionManager, entity.AdmAcceptanceCategoryCollection);
						
						deepHandles.Add("AdmAcceptanceCategoryCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAcceptanceCategory >) DataRepository.AdmAcceptanceCategoryProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAcceptanceCategoryCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaVacationBalance>
				if (CanDeepSave(entity.SaVacationBalanceCollection, "List<SaVacationBalance>|SaVacationBalanceCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaVacationBalance child in entity.SaVacationBalanceCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.SaVacationBalanceCollection.Count > 0 || entity.SaVacationBalanceCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaVacationBalanceProvider.Save(transactionManager, entity.SaVacationBalanceCollection);
						
						deepHandles.Add("SaVacationBalanceCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaVacationBalance >) DataRepository.SaVacationBalanceProvider.DeepSave,
							new object[] { transactionManager, entity.SaVacationBalanceCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeStudItemCncl>
				if (CanDeepSave(entity.FeeStudItemCnclCollection, "List<FeeStudItemCncl>|FeeStudItemCnclCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeStudItemCncl child in entity.FeeStudItemCnclCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.FeeStudItemCnclCollection.Count > 0 || entity.FeeStudItemCnclCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeStudItemCnclProvider.Save(transactionManager, entity.FeeStudItemCnclCollection);
						
						deepHandles.Add("FeeStudItemCnclCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeStudItemCncl >) DataRepository.FeeStudItemCnclProvider.DeepSave,
							new object[] { transactionManager, entity.FeeStudItemCnclCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<PgThesisStud>
				if (CanDeepSave(entity.PgThesisStudCollection, "List<PgThesisStud>|PgThesisStudCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgThesisStud child in entity.PgThesisStudCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.PgThesisStudCollection.Count > 0 || entity.PgThesisStudCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgThesisStudProvider.Save(transactionManager, entity.PgThesisStudCollection);
						
						deepHandles.Add("PgThesisStudCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgThesisStud >) DataRepository.PgThesisStudProvider.DeepSave,
							new object[] { transactionManager, entity.PgThesisStudCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<GsApprovalD>
				if (CanDeepSave(entity.GsApprovalDCollection, "List<GsApprovalD>|GsApprovalDCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GsApprovalD child in entity.GsApprovalDCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.GsApprovalDCollection.Count > 0 || entity.GsApprovalDCollection.DeletedItems.Count > 0)
					{
						//DataRepository.GsApprovalDProvider.Save(transactionManager, entity.GsApprovalDCollection);
						
						deepHandles.Add("GsApprovalDCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< GsApprovalD >) DataRepository.GsApprovalDProvider.DeepSave,
							new object[] { transactionManager, entity.GsApprovalDCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudLateness>
				if (CanDeepSave(entity.EdStudLatenessCollection, "List<EdStudLateness>|EdStudLatenessCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudLateness child in entity.EdStudLatenessCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.EdStudLatenessCollection.Count > 0 || entity.EdStudLatenessCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudLatenessProvider.Save(transactionManager, entity.EdStudLatenessCollection);
						
						deepHandles.Add("EdStudLatenessCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudLateness >) DataRepository.EdStudLatenessProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudLatenessCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<GsCodeRptSignature>
				if (CanDeepSave(entity.GsCodeRptSignatureCollection, "List<GsCodeRptSignature>|GsCodeRptSignatureCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GsCodeRptSignature child in entity.GsCodeRptSignatureCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.GsCodeRptSignatureCollection.Count > 0 || entity.GsCodeRptSignatureCollection.DeletedItems.Count > 0)
					{
						//DataRepository.GsCodeRptSignatureProvider.Save(transactionManager, entity.GsCodeRptSignatureCollection);
						
						deepHandles.Add("GsCodeRptSignatureCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< GsCodeRptSignature >) DataRepository.GsCodeRptSignatureProvider.DeepSave,
							new object[] { transactionManager, entity.GsCodeRptSignatureCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaResearchTeam>
				if (CanDeepSave(entity.SaResearchTeamCollection, "List<SaResearchTeam>|SaResearchTeamCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaResearchTeam child in entity.SaResearchTeamCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.SaResearchTeamCollection.Count > 0 || entity.SaResearchTeamCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaResearchTeamProvider.Save(transactionManager, entity.SaResearchTeamCollection);
						
						deepHandles.Add("SaResearchTeamCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaResearchTeam >) DataRepository.SaResearchTeamProvider.DeepSave,
							new object[] { transactionManager, entity.SaResearchTeamCollection, deepSaveType, childTypes, innerList }
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
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
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
				
	
			#region List<EdSemAgendaDtl>
				if (CanDeepSave(entity.EdSemAgendaDtlCollection, "List<EdSemAgendaDtl>|EdSemAgendaDtlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdSemAgendaDtl child in entity.EdSemAgendaDtlCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.EdSemAgendaDtlCollection.Count > 0 || entity.EdSemAgendaDtlCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdSemAgendaDtlProvider.Save(transactionManager, entity.EdSemAgendaDtlCollection);
						
						deepHandles.Add("EdSemAgendaDtlCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdSemAgendaDtl >) DataRepository.EdSemAgendaDtlProvider.DeepSave,
							new object[] { transactionManager, entity.EdSemAgendaDtlCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdCrsFreeRstrctd>
				if (CanDeepSave(entity.EdCrsFreeRstrctdCollection, "List<EdCrsFreeRstrctd>|EdCrsFreeRstrctdCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdCrsFreeRstrctd child in entity.EdCrsFreeRstrctdCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.EdCrsFreeRstrctdCollection.Count > 0 || entity.EdCrsFreeRstrctdCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdCrsFreeRstrctdProvider.Save(transactionManager, entity.EdCrsFreeRstrctdCollection);
						
						deepHandles.Add("EdCrsFreeRstrctdCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdCrsFreeRstrctd >) DataRepository.EdCrsFreeRstrctdProvider.DeepSave,
							new object[] { transactionManager, entity.EdCrsFreeRstrctdCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudGrantDegree>
				if (CanDeepSave(entity.EdStudGrantDegreeCollection, "List<EdStudGrantDegree>|EdStudGrantDegreeCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudGrantDegree child in entity.EdStudGrantDegreeCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.EdStudGrantDegreeCollection.Count > 0 || entity.EdStudGrantDegreeCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudGrantDegreeProvider.Save(transactionManager, entity.EdStudGrantDegreeCollection);
						
						deepHandles.Add("EdStudGrantDegreeCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudGrantDegree >) DataRepository.EdStudGrantDegreeProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudGrantDegreeCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudGroupPre>
				if (CanDeepSave(entity.EdStudGroupPreCollection, "List<EdStudGroupPre>|EdStudGroupPreCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudGroupPre child in entity.EdStudGroupPreCollection)
					{
						if(child.AsFacultyInfoIdSource != null)
						{
							child.AsFacultyInfoId = child.AsFacultyInfoIdSource.AsFacultyInfoId;
						}
						else
						{
							child.AsFacultyInfoId = entity.AsFacultyInfoId;
						}

					}

					if (entity.EdStudGroupPreCollection.Count > 0 || entity.EdStudGroupPreCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudGroupPreProvider.Save(transactionManager, entity.EdStudGroupPreCollection);
						
						deepHandles.Add("EdStudGroupPreCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudGroupPre >) DataRepository.EdStudGroupPreProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudGroupPreCollection, deepSaveType, childTypes, innerList }
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
	
	#region AsFacultyInfoChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AsFacultyInfo</c>
	///</summary>
	public enum AsFacultyInfoChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>GsCountryNode</c> at GsCountryNodeIdSource
		///</summary>
		[ChildEntityType(typeof(GsCountryNode))]
		GsCountryNode,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for EdBranchRuleCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdBranchRule>))]
		EdBranchRuleCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for SaMilitaryStatusCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaMilitaryStatus>))]
		SaMilitaryStatusCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for ScStudGroupCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScStudGroup>))]
		ScStudGroupCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for SaRelativeCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaRelative>))]
		SaRelativeCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for SeBlockTransCollection
		///</summary>
		[ChildEntityType(typeof(TList<SeBlockTrans>))]
		SeBlockTransCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for SpoSponsorStudCollection
		///</summary>
		[ChildEntityType(typeof(TList<SpoSponsorStud>))]
		SpoSponsorStudCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for EdCodeCourseAssessCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdCodeCourseAssess>))]
		EdCodeCourseAssessCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for EdCodeDischargeHCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdCodeDischargeH>))]
		EdCodeDischargeHCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for SaCdeAcadLoadCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaCdeAcadLoad>))]
		SaCdeAcadLoadCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for SaEmpHierarchyCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaEmpHierarchy>))]
		SaEmpHierarchyCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for EdCodeCourseTeachingCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdCodeCourseTeaching>))]
		EdCodeCourseTeachingCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for EdStudCourseRegPreCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCourseRegPre>))]
		EdStudCourseRegPreCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for EdStudExcuseCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudExcuse>))]
		EdStudExcuseCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for GsCommCollection
		///</summary>
		[ChildEntityType(typeof(TList<GsComm>))]
		GsCommCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for SaJobStartStatmentCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaJobStartStatment>))]
		SaJobStartStatmentCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for EdStudAcadWarnCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudAcadWarn>))]
		EdStudAcadWarnCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for PgThesisGrantDegreeCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgThesisGrantDegree>))]
		PgThesisGrantDegreeCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for EdCourseTopicCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdCourseTopic>))]
		EdCourseTopicCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for FeeFineCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeFine>))]
		FeeFineCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for EdStudQualSubjectCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudQualSubject>))]
		EdStudQualSubjectCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for EdStudIntTrnsCourseToCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudIntTrnsCourseTo>))]
		EdStudIntTrnsCourseToCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for FeeStudNatSimilarityRequestCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudNatSimilarityRequest>))]
		FeeStudNatSimilarityRequestCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for SaJobStoppageCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaJobStoppage>))]
		SaJobStoppageCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for SaPromotionRequestCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaPromotionRequest>))]
		SaPromotionRequestCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for CoScheduleDetailCollection
		///</summary>
		[ChildEntityType(typeof(TList<CoScheduleDetail>))]
		CoScheduleDetailCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for SaVacationBalanceHCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaVacationBalanceH>))]
		SaVacationBalanceHCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for SaPublicationCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaPublication>))]
		SaPublicationCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for FeeFacultyRuleCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeFacultyRule>))]
		FeeFacultyRuleCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for SvPollHdrCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvPollHdr>))]
		SvPollHdrCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for FeeStudVoucherCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudVoucher>))]
		FeeStudVoucherCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for EdAcadYearFacultyCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdAcadYearFaculty>))]
		EdAcadYearFacultyCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for RsrchStudPostponeReqCollection
		///</summary>
		[ChildEntityType(typeof(TList<RsrchStudPostponeReq>))]
		RsrchStudPostponeReqCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for SeUserCrsAssessCollection
		///</summary>
		[ChildEntityType(typeof(TList<SeUserCrsAssess>))]
		SeUserCrsAssessCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for EdStudTransFromReqCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudTransFromReq>))]
		EdStudTransFromReqCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for GsCdeClrncItemFacCollection
		///</summary>
		[ChildEntityType(typeof(TList<GsCdeClrncItemFac>))]
		GsCdeClrncItemFacCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for SaRaiseCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaRaise>))]
		SaRaiseCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for EdStudIntTrnsStateToCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudIntTrnsStateTo>))]
		EdStudIntTrnsStateToCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for AdmPrecondQualCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmPrecondQual>))]
		AdmPrecondQualCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for AdmRatingParametersMajorsCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmRatingParametersMajors>))]
		AdmRatingParametersMajorsCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for ScSchdlPeriodCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScSchdlPeriod>))]
		ScSchdlPeriodCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for FeeStudRetrieveRequestCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudRetrieveRequest>))]
		FeeStudRetrieveRequestCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for SaExtDelCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaExtDel>))]
		SaExtDelCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for ScHallRsrvCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScHallRsrv>))]
		ScHallRsrvCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for EdResidencyStudCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdResidencyStud>))]
		EdResidencyStudCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for EdStudCourseChngCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCourseChng>))]
		EdStudCourseChngCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for EdCourseCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdCourse>))]
		EdCourseCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for SvAutoMsgTmpltCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvAutoMsgTmplt>))]
		SvAutoMsgTmpltCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for ScScheduleRsrvCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScScheduleRsrv>))]
		ScScheduleRsrvCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for SaScCommDecisionCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaScCommDecision>))]
		SaScCommDecisionCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for EdStudIntTransPrefCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudIntTransPref>))]
		EdStudIntTransPrefCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for SaTrainingCourseCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaTrainingCourse>))]
		SaTrainingCourseCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for SaMiltaryCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaMiltary>))]
		SaMiltaryCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for FeeInstlmntRuleCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeInstlmntRule>))]
		FeeInstlmntRuleCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for AdmCompetitiveAvgCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmCompetitiveAvg>))]
		AdmCompetitiveAvgCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for RsrchStudRegisterCollection
		///</summary>
		[ChildEntityType(typeof(TList<RsrchStudRegister>))]
		RsrchStudRegisterCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for SeFormCollection
		///</summary>
		[ChildEntityType(typeof(TList<SeForm>))]
		SeFormCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for EdOfferingCourseCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdOfferingCourse>))]
		EdOfferingCourseCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for FeeLimitRuleCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeLimitRule>))]
		FeeLimitRuleCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for SaExperienceCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaExperience>))]
		SaExperienceCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for SaServTerminCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaServTermin>))]
		SaServTerminCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for EdOfferingCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdOffering>))]
		EdOfferingCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for AdmAppPrefCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppPref>))]
		AdmAppPrefCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for EdStudAbsenceCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudAbsence>))]
		EdStudAbsenceCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for SaWarningCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaWarning>))]
		SaWarningCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for EdStudStateTempCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudStateTemp>))]
		EdStudStateTempCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for SaPromotionCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaPromotion>))]
		SaPromotionCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for SvStaffEvlCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvStaffEvl>))]
		SvStaffEvlCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for SpoSponsorOfferCollection
		///</summary>
		[ChildEntityType(typeof(TList<SpoSponsorOffer>))]
		SpoSponsorOfferCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for SvStudAskAdvCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvStudAskAdv>))]
		SvStudAskAdvCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for SaVacationCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaVacation>))]
		SaVacationCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for SaEmploymentCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaEmployment>))]
		SaEmploymentCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for SaFinStatmentCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaFinStatment>))]
		SaFinStatmentCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for EdCourseOutcomesTopicsCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdCourseOutcomesTopics>))]
		EdCourseOutcomesTopicsCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for EdPrintReqCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdPrintReq>))]
		EdPrintReqCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for FeeStudFeeItemCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudFeeItem>))]
		FeeStudFeeItemCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for EdCodeLevelCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdCodeLevel>))]
		EdCodeLevelCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for ScGroupInfoCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScGroupInfo>))]
		ScGroupInfoCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for SaPersonIdCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaPersonId>))]
		SaPersonIdCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for SaStfMemberCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaStfMember>))]
		SaStfMemberCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for AdmCodeEngTestCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmCodeEngTest>))]
		AdmCodeEngTestCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for FeeRefndStdReqCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeRefndStdReq>))]
		FeeRefndStdReqCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for EdStudIntTrnsCourseFromCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudIntTrnsCourseFrom>))]
		EdStudIntTrnsCourseFromCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for CoControlRoomCollection
		///</summary>
		[ChildEntityType(typeof(TList<CoControlRoom>))]
		CoControlRoomCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for EdStudBranchPrefCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudBranchPref>))]
		EdStudBranchPrefCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for FeeStudDiscContinueCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudDiscContinue>))]
		FeeStudDiscContinueCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for FeeStudInstallmentCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudInstallment>))]
		FeeStudInstallmentCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for EdStudGroupCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudGroup>))]
		EdStudGroupCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for EdStudCourseRegCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCourseReg>))]
		EdStudCourseRegCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for SaScQualCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaScQual>))]
		SaScQualCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for MltOrgTreeCollection
		///</summary>
		[ChildEntityType(typeof(TList<MltOrgTree>))]
		MltOrgTreeCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for SaSupervisingJobsCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaSupervisingJobs>))]
		SaSupervisingJobsCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for EdExamSchdlCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdExamSchdl>))]
		EdExamSchdlCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for GsCodeApprovalFacultyCollection
		///</summary>
		[ChildEntityType(typeof(TList<GsCodeApprovalFaculty>))]
		GsCodeApprovalFacultyCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for EdStudAcadmicAdvCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudAcadmicAdv>))]
		EdStudAcadmicAdvCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for SaJobActivityCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaJobActivity>))]
		SaJobActivityCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for EdStudSemesterTempCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudSemesterTemp>))]
		EdStudSemesterTempCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for GsCodeApprovalCollection
		///</summary>
		[ChildEntityType(typeof(TList<GsCodeApproval>))]
		GsCodeApprovalCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for EntityMainCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntityMain>))]
		EntityMainCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for FeeStudInstallmentRequestCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudInstallmentRequest>))]
		FeeStudInstallmentRequestCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for EdStudCourseRegAssessCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCourseRegAssess>))]
		EdStudCourseRegAssessCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for SaCandReleaseCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaCandRelease>))]
		SaCandReleaseCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for EntPolcyGrdngHdrCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntPolcyGrdngHdr>))]
		EntPolcyGrdngHdrCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for EdStudSemesterCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudSemester>))]
		EdStudSemesterCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for SaScResearchCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaScResearch>))]
		SaScResearchCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for EdResultApproveCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdResultApprove>))]
		EdResultApproveCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for SpoSponsorStudSemesterCollection
		///</summary>
		[ChildEntityType(typeof(TList<SpoSponsorStudSemester>))]
		SpoSponsorStudSemesterCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for EdProjectCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdProject>))]
		EdProjectCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for CoCrsRsltRaiseCollection
		///</summary>
		[ChildEntityType(typeof(TList<CoCrsRsltRaise>))]
		CoCrsRsltRaiseCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for ScScheduleDtlCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScScheduleDtl>))]
		ScScheduleDtlCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for EdStudFacultyCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudFaculty>))]
		EdStudFacultyCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for ScSectionGroupHdrCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScSectionGroupHdr>))]
		ScSectionGroupHdrCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for EdStudIntTrnsStateFromCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudIntTrnsStateFrom>))]
		EdStudIntTrnsStateFromCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for FeeCdeDiscTypeCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeCdeDiscType>))]
		FeeCdeDiscTypeCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for EdGraduationAwardCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdGraduationAward>))]
		EdGraduationAwardCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for ScBuildingCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScBuilding>))]
		ScBuildingCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for EdStudGrantTempCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudGrantTemp>))]
		EdStudGrantTempCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for EdInttransRuleCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdInttransRule>))]
		EdInttransRuleCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for PgOfferingCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgOffering>))]
		PgOfferingCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for EdStudStateCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudState>))]
		EdStudStateCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for SaPunishmentCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaPunishment>))]
		SaPunishmentCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for SaVacationRenewCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaVacationRenew>))]
		SaVacationRenewCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for EdBylawCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdBylaw>))]
		EdBylawCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for SaPromotionCondStsfCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaPromotionCondStsf>))]
		SaPromotionCondStsfCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for SaCandReleaseDetailCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaCandReleaseDetail>))]
		SaCandReleaseDetailCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for GsApprovalHCollection
		///</summary>
		[ChildEntityType(typeof(TList<GsApprovalH>))]
		GsApprovalHCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for EdStudAbsFwCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudAbsFw>))]
		EdStudAbsFwCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for SaTransferCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaTransfer>))]
		SaTransferCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for EdStudIntTrnsCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudIntTrns>))]
		EdStudIntTrnsCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for SaCodeSuperviseJobCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaCodeSuperviseJob>))]
		SaCodeSuperviseJobCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for FeeStudDiscCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudDisc>))]
		FeeStudDiscCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for EdStudCourseCompCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCourseComp>))]
		EdStudCourseCompCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for EdStudNoteCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudNote>))]
		EdStudNoteCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for SaDocOfFileCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaDocOfFile>))]
		SaDocOfFileCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for SvStudAskAdvReCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvStudAskAdvRe>))]
		SvStudAskAdvReCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for AdmAcceptanceCategoryCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAcceptanceCategory>))]
		AdmAcceptanceCategoryCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for SaVacationBalanceCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaVacationBalance>))]
		SaVacationBalanceCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for FeeStudItemCnclCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudItemCncl>))]
		FeeStudItemCnclCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for PgThesisStudCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgThesisStud>))]
		PgThesisStudCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for GsApprovalDCollection
		///</summary>
		[ChildEntityType(typeof(TList<GsApprovalD>))]
		GsApprovalDCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for EdStudLatenessCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudLateness>))]
		EdStudLatenessCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for GsCodeRptSignatureCollection
		///</summary>
		[ChildEntityType(typeof(TList<GsCodeRptSignature>))]
		GsCodeRptSignatureCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for SaResearchTeamCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaResearchTeam>))]
		SaResearchTeamCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for AdmAppTransReqCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppTransReq>))]
		AdmAppTransReqCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for EdSemAgendaDtlCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdSemAgendaDtl>))]
		EdSemAgendaDtlCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for EdCrsFreeRstrctdCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdCrsFreeRstrctd>))]
		EdCrsFreeRstrctdCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for EdStudGrantDegreeCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudGrantDegree>))]
		EdStudGrantDegreeCollection,
		///<summary>
		/// Collection of <c>AsFacultyInfo</c> as OneToMany for EdStudGroupPreCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudGroupPre>))]
		EdStudGroupPreCollection,
	}
	
	#endregion AsFacultyInfoChildEntityTypes
	
	#region AsFacultyInfoFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AsFacultyInfoColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AsFacultyInfo"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AsFacultyInfoFilterBuilder : SqlFilterBuilder<AsFacultyInfoColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AsFacultyInfoFilterBuilder class.
		/// </summary>
		public AsFacultyInfoFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AsFacultyInfoFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AsFacultyInfoFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AsFacultyInfoFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AsFacultyInfoFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AsFacultyInfoFilterBuilder
	
	#region AsFacultyInfoParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AsFacultyInfoColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AsFacultyInfo"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AsFacultyInfoParameterBuilder : ParameterizedSqlFilterBuilder<AsFacultyInfoColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AsFacultyInfoParameterBuilder class.
		/// </summary>
		public AsFacultyInfoParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AsFacultyInfoParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AsFacultyInfoParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AsFacultyInfoParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AsFacultyInfoParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AsFacultyInfoParameterBuilder
	
	#region AsFacultyInfoSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AsFacultyInfoColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AsFacultyInfo"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AsFacultyInfoSortBuilder : SqlSortBuilder<AsFacultyInfoColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AsFacultyInfoSqlSortBuilder class.
		/// </summary>
		public AsFacultyInfoSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AsFacultyInfoSortBuilder
	
} // end namespace
