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
	/// This class is the base class for any <see cref="GsCdeUniversitiesProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GsCdeUniversitiesProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.GsCdeUniversities, UMIS_VER2.BusinessLyer.GsCdeUniversitiesKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeUniversitiesKey key)
		{
			return Delete(transactionManager, key.GsCdeUniversitiesId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_gsCdeUniversitiesId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _gsCdeUniversitiesId)
		{
			return Delete(null, _gsCdeUniversitiesId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeUniversitiesId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _gsCdeUniversitiesId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CDE_UNIVERSITIES_GS_COUNTRY_NODE key.
		///		FK_GS_CDE_UNIVERSITIES_GS_COUNTRY_NODE Description: 
		/// </summary>
		/// <param name="_gsCountryNodeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCdeUniversities objects.</returns>
		public TList<GsCdeUniversities> GetByGsCountryNodeId(System.Decimal? _gsCountryNodeId)
		{
			int count = -1;
			return GetByGsCountryNodeId(_gsCountryNodeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CDE_UNIVERSITIES_GS_COUNTRY_NODE key.
		///		FK_GS_CDE_UNIVERSITIES_GS_COUNTRY_NODE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryNodeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCdeUniversities objects.</returns>
		/// <remarks></remarks>
		public TList<GsCdeUniversities> GetByGsCountryNodeId(TransactionManager transactionManager, System.Decimal? _gsCountryNodeId)
		{
			int count = -1;
			return GetByGsCountryNodeId(transactionManager, _gsCountryNodeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CDE_UNIVERSITIES_GS_COUNTRY_NODE key.
		///		FK_GS_CDE_UNIVERSITIES_GS_COUNTRY_NODE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryNodeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCdeUniversities objects.</returns>
		public TList<GsCdeUniversities> GetByGsCountryNodeId(TransactionManager transactionManager, System.Decimal? _gsCountryNodeId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCountryNodeId(transactionManager, _gsCountryNodeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CDE_UNIVERSITIES_GS_COUNTRY_NODE key.
		///		fkGsCdeUniversitiesGsCountryNode Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCountryNodeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCdeUniversities objects.</returns>
		public TList<GsCdeUniversities> GetByGsCountryNodeId(System.Decimal? _gsCountryNodeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCountryNodeId(null, _gsCountryNodeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CDE_UNIVERSITIES_GS_COUNTRY_NODE key.
		///		fkGsCdeUniversitiesGsCountryNode Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCountryNodeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCdeUniversities objects.</returns>
		public TList<GsCdeUniversities> GetByGsCountryNodeId(System.Decimal? _gsCountryNodeId, int start, int pageLength,out int count)
		{
			return GetByGsCountryNodeId(null, _gsCountryNodeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CDE_UNIVERSITIES_GS_COUNTRY_NODE key.
		///		FK_GS_CDE_UNIVERSITIES_GS_COUNTRY_NODE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCountryNodeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCdeUniversities objects.</returns>
		public abstract TList<GsCdeUniversities> GetByGsCountryNodeId(TransactionManager transactionManager, System.Decimal? _gsCountryNodeId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.GsCdeUniversities Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeUniversitiesKey key, int start, int pageLength)
		{
			return GetByGsCdeUniversitiesId(transactionManager, key.GsCdeUniversitiesId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_GS_CDE_UNIVERSITIES index.
		/// </summary>
		/// <param name="_gsCdeUniversitiesId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeUniversities"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeUniversities GetByGsCdeUniversitiesId(System.Decimal _gsCdeUniversitiesId)
		{
			int count = -1;
			return GetByGsCdeUniversitiesId(null,_gsCdeUniversitiesId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_UNIVERSITIES index.
		/// </summary>
		/// <param name="_gsCdeUniversitiesId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeUniversities"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeUniversities GetByGsCdeUniversitiesId(System.Decimal _gsCdeUniversitiesId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeUniversitiesId(null, _gsCdeUniversitiesId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_UNIVERSITIES index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeUniversitiesId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeUniversities"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeUniversities GetByGsCdeUniversitiesId(TransactionManager transactionManager, System.Decimal _gsCdeUniversitiesId)
		{
			int count = -1;
			return GetByGsCdeUniversitiesId(transactionManager, _gsCdeUniversitiesId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_UNIVERSITIES index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeUniversitiesId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeUniversities"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeUniversities GetByGsCdeUniversitiesId(TransactionManager transactionManager, System.Decimal _gsCdeUniversitiesId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeUniversitiesId(transactionManager, _gsCdeUniversitiesId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_UNIVERSITIES index.
		/// </summary>
		/// <param name="_gsCdeUniversitiesId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeUniversities"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeUniversities GetByGsCdeUniversitiesId(System.Decimal _gsCdeUniversitiesId, int start, int pageLength, out int count)
		{
			return GetByGsCdeUniversitiesId(null, _gsCdeUniversitiesId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_UNIVERSITIES index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeUniversitiesId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeUniversities"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsCdeUniversities GetByGsCdeUniversitiesId(TransactionManager transactionManager, System.Decimal _gsCdeUniversitiesId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GsCdeUniversities&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GsCdeUniversities&gt;"/></returns>
		public static TList<GsCdeUniversities> Fill(IDataReader reader, TList<GsCdeUniversities> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.GsCdeUniversities c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GsCdeUniversities")
					.Append("|").Append((System.Decimal)reader["GS_CDE_UNIVERSITIES_ID"]).ToString();
					c = EntityManager.LocateOrCreate<GsCdeUniversities>(
					key.ToString(), // EntityTrackingKey
					"GsCdeUniversities",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.GsCdeUniversities();
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
					c.GsCdeUniversitiesId = (System.Decimal)reader["GS_CDE_UNIVERSITIES_ID"];
					c.OriginalGsCdeUniversitiesId = c.GsCdeUniversitiesId;
					c.DescrAr = (System.String)reader["DESCR_AR"];
					c.DescrEn = (System.String)reader["DESCR_EN"];
					c.GsCountryNodeId = Convert.IsDBNull(reader["GS_COUNTRY_NODE_ID"]) ? null : (System.Decimal?)reader["GS_COUNTRY_NODE_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCdeUniversities"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCdeUniversities"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.GsCdeUniversities entity)
		{
			if (!reader.Read()) return;
			
			entity.GsCdeUniversitiesId = (System.Decimal)reader[((int)GsCdeUniversitiesColumn.GsCdeUniversitiesId - 1)];
			entity.OriginalGsCdeUniversitiesId = (System.Decimal)reader["GS_CDE_UNIVERSITIES_ID"];
			entity.DescrAr = (System.String)reader[((int)GsCdeUniversitiesColumn.DescrAr - 1)];
			entity.DescrEn = (System.String)reader[((int)GsCdeUniversitiesColumn.DescrEn - 1)];
			entity.GsCountryNodeId = (reader.IsDBNull(((int)GsCdeUniversitiesColumn.GsCountryNodeId - 1)))?null:(System.Decimal?)reader[((int)GsCdeUniversitiesColumn.GsCountryNodeId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCdeUniversities"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCdeUniversities"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.GsCdeUniversities entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.GsCdeUniversitiesId = (System.Decimal)dataRow["GS_CDE_UNIVERSITIES_ID"];
			entity.OriginalGsCdeUniversitiesId = (System.Decimal)dataRow["GS_CDE_UNIVERSITIES_ID"];
			entity.DescrAr = (System.String)dataRow["DESCR_AR"];
			entity.DescrEn = (System.String)dataRow["DESCR_EN"];
			entity.GsCountryNodeId = Convert.IsDBNull(dataRow["GS_COUNTRY_NODE_ID"]) ? null : (System.Decimal?)dataRow["GS_COUNTRY_NODE_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCdeUniversities"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCdeUniversities Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeUniversities entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
			// Deep load child collections  - Call GetByGsCdeUniversitiesId methods when available
			
			#region EdStudQualCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudQual>|EdStudQualCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudQualCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudQualCollection = DataRepository.EdStudQualProvider.GetByGsCdeUniversitiesId(transactionManager, entity.GsCdeUniversitiesId);

				if (deep && entity.EdStudQualCollection.Count > 0)
				{
					deepHandles.Add("EdStudQualCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudQual>) DataRepository.EdStudQualProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudQualCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.PgExtMemberCollection = DataRepository.PgExtMemberProvider.GetByGsCdeUniversitiesId(transactionManager, entity.GsCdeUniversitiesId);

				if (deep && entity.PgExtMemberCollection.Count > 0)
				{
					deepHandles.Add("PgExtMemberCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgExtMember>) DataRepository.PgExtMemberProvider.DeepLoad,
						new object[] { transactionManager, entity.PgExtMemberCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmAppWorkExperCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppWorkExper>|AdmAppWorkExperCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppWorkExperCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppWorkExperCollection = DataRepository.AdmAppWorkExperProvider.GetByGsCdeUniversitiesId(transactionManager, entity.GsCdeUniversitiesId);

				if (deep && entity.AdmAppWorkExperCollection.Count > 0)
				{
					deepHandles.Add("AdmAppWorkExperCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppWorkExper>) DataRepository.AdmAppWorkExperProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppWorkExperCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region GsCdeFacultyCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GsCdeFaculty>|GsCdeFacultyCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCdeFacultyCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GsCdeFacultyCollection = DataRepository.GsCdeFacultyProvider.GetByGsCdeUniversitiesId(transactionManager, entity.GsCdeUniversitiesId);

				if (deep && entity.GsCdeFacultyCollection.Count > 0)
				{
					deepHandles.Add("GsCdeFacultyCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GsCdeFaculty>) DataRepository.GsCdeFacultyProvider.DeepLoad,
						new object[] { transactionManager, entity.GsCdeFacultyCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.GsCdeUniversities object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.GsCdeUniversities instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCdeUniversities Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeUniversities entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<EdStudQual>
				if (CanDeepSave(entity.EdStudQualCollection, "List<EdStudQual>|EdStudQualCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudQual child in entity.EdStudQualCollection)
					{
						if(child.GsCdeUniversitiesIdSource != null)
						{
							child.GsCdeUniversitiesId = child.GsCdeUniversitiesIdSource.GsCdeUniversitiesId;
						}
						else
						{
							child.GsCdeUniversitiesId = entity.GsCdeUniversitiesId;
						}

					}

					if (entity.EdStudQualCollection.Count > 0 || entity.EdStudQualCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudQualProvider.Save(transactionManager, entity.EdStudQualCollection);
						
						deepHandles.Add("EdStudQualCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudQual >) DataRepository.EdStudQualProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudQualCollection, deepSaveType, childTypes, innerList }
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
						if(child.GsCdeUniversitiesIdSource != null)
						{
							child.GsCdeUniversitiesId = child.GsCdeUniversitiesIdSource.GsCdeUniversitiesId;
						}
						else
						{
							child.GsCdeUniversitiesId = entity.GsCdeUniversitiesId;
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
				
	
			#region List<AdmAppWorkExper>
				if (CanDeepSave(entity.AdmAppWorkExperCollection, "List<AdmAppWorkExper>|AdmAppWorkExperCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppWorkExper child in entity.AdmAppWorkExperCollection)
					{
						if(child.GsCdeUniversitiesIdSource != null)
						{
							child.GsCdeUniversitiesId = child.GsCdeUniversitiesIdSource.GsCdeUniversitiesId;
						}
						else
						{
							child.GsCdeUniversitiesId = entity.GsCdeUniversitiesId;
						}

					}

					if (entity.AdmAppWorkExperCollection.Count > 0 || entity.AdmAppWorkExperCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppWorkExperProvider.Save(transactionManager, entity.AdmAppWorkExperCollection);
						
						deepHandles.Add("AdmAppWorkExperCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppWorkExper >) DataRepository.AdmAppWorkExperProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppWorkExperCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<GsCdeFaculty>
				if (CanDeepSave(entity.GsCdeFacultyCollection, "List<GsCdeFaculty>|GsCdeFacultyCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GsCdeFaculty child in entity.GsCdeFacultyCollection)
					{
						if(child.GsCdeUniversitiesIdSource != null)
						{
							child.GsCdeUniversitiesId = child.GsCdeUniversitiesIdSource.GsCdeUniversitiesId;
						}
						else
						{
							child.GsCdeUniversitiesId = entity.GsCdeUniversitiesId;
						}

					}

					if (entity.GsCdeFacultyCollection.Count > 0 || entity.GsCdeFacultyCollection.DeletedItems.Count > 0)
					{
						//DataRepository.GsCdeFacultyProvider.Save(transactionManager, entity.GsCdeFacultyCollection);
						
						deepHandles.Add("GsCdeFacultyCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< GsCdeFaculty >) DataRepository.GsCdeFacultyProvider.DeepSave,
							new object[] { transactionManager, entity.GsCdeFacultyCollection, deepSaveType, childTypes, innerList }
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
	
	#region GsCdeUniversitiesChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.GsCdeUniversities</c>
	///</summary>
	public enum GsCdeUniversitiesChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>GsCountryNode</c> at GsCountryNodeIdSource
		///</summary>
		[ChildEntityType(typeof(GsCountryNode))]
		GsCountryNode,
		///<summary>
		/// Collection of <c>GsCdeUniversities</c> as OneToMany for EdStudQualCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudQual>))]
		EdStudQualCollection,
		///<summary>
		/// Collection of <c>GsCdeUniversities</c> as OneToMany for PgExtMemberCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgExtMember>))]
		PgExtMemberCollection,
		///<summary>
		/// Collection of <c>GsCdeUniversities</c> as OneToMany for AdmAppWorkExperCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppWorkExper>))]
		AdmAppWorkExperCollection,
		///<summary>
		/// Collection of <c>GsCdeUniversities</c> as OneToMany for GsCdeFacultyCollection
		///</summary>
		[ChildEntityType(typeof(TList<GsCdeFaculty>))]
		GsCdeFacultyCollection,
	}
	
	#endregion GsCdeUniversitiesChildEntityTypes
	
	#region GsCdeUniversitiesFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GsCdeUniversitiesColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCdeUniversities"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCdeUniversitiesFilterBuilder : SqlFilterBuilder<GsCdeUniversitiesColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCdeUniversitiesFilterBuilder class.
		/// </summary>
		public GsCdeUniversitiesFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCdeUniversitiesFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCdeUniversitiesFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCdeUniversitiesFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCdeUniversitiesFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCdeUniversitiesFilterBuilder
	
	#region GsCdeUniversitiesParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GsCdeUniversitiesColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCdeUniversities"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCdeUniversitiesParameterBuilder : ParameterizedSqlFilterBuilder<GsCdeUniversitiesColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCdeUniversitiesParameterBuilder class.
		/// </summary>
		public GsCdeUniversitiesParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCdeUniversitiesParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCdeUniversitiesParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCdeUniversitiesParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCdeUniversitiesParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCdeUniversitiesParameterBuilder
	
	#region GsCdeUniversitiesSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GsCdeUniversitiesColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCdeUniversities"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GsCdeUniversitiesSortBuilder : SqlSortBuilder<GsCdeUniversitiesColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCdeUniversitiesSqlSortBuilder class.
		/// </summary>
		public GsCdeUniversitiesSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GsCdeUniversitiesSortBuilder
	
} // end namespace
