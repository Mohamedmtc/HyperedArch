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
	/// This class is the base class for any <see cref="GsMilitaryRegionProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GsMilitaryRegionProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.GsMilitaryRegion, UMIS_VER2.BusinessLyer.GsMilitaryRegionKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsMilitaryRegionKey key)
		{
			return Delete(transactionManager, key.GsMilitaryRegionId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_gsMilitaryRegionId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _gsMilitaryRegionId)
		{
			return Delete(null, _gsMilitaryRegionId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsMilitaryRegionId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _gsMilitaryRegionId);		
		
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
		public override UMIS_VER2.BusinessLyer.GsMilitaryRegion Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsMilitaryRegionKey key, int start, int pageLength)
		{
			return GetByGsMilitaryRegionId(transactionManager, key.GsMilitaryRegionId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_GS_MILITARY_REGION index.
		/// </summary>
		/// <param name="_gsMilitaryRegionId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsMilitaryRegion"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsMilitaryRegion GetByGsMilitaryRegionId(System.Decimal _gsMilitaryRegionId)
		{
			int count = -1;
			return GetByGsMilitaryRegionId(null,_gsMilitaryRegionId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_MILITARY_REGION index.
		/// </summary>
		/// <param name="_gsMilitaryRegionId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsMilitaryRegion"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsMilitaryRegion GetByGsMilitaryRegionId(System.Decimal _gsMilitaryRegionId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsMilitaryRegionId(null, _gsMilitaryRegionId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_MILITARY_REGION index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsMilitaryRegionId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsMilitaryRegion"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsMilitaryRegion GetByGsMilitaryRegionId(TransactionManager transactionManager, System.Decimal _gsMilitaryRegionId)
		{
			int count = -1;
			return GetByGsMilitaryRegionId(transactionManager, _gsMilitaryRegionId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_MILITARY_REGION index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsMilitaryRegionId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsMilitaryRegion"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsMilitaryRegion GetByGsMilitaryRegionId(TransactionManager transactionManager, System.Decimal _gsMilitaryRegionId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsMilitaryRegionId(transactionManager, _gsMilitaryRegionId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_MILITARY_REGION index.
		/// </summary>
		/// <param name="_gsMilitaryRegionId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsMilitaryRegion"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsMilitaryRegion GetByGsMilitaryRegionId(System.Decimal _gsMilitaryRegionId, int start, int pageLength, out int count)
		{
			return GetByGsMilitaryRegionId(null, _gsMilitaryRegionId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_MILITARY_REGION index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsMilitaryRegionId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsMilitaryRegion"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsMilitaryRegion GetByGsMilitaryRegionId(TransactionManager transactionManager, System.Decimal _gsMilitaryRegionId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_GS_MILITARY_REGION_AR index.
		/// </summary>
		/// <param name="_regionDescrAr"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsMilitaryRegion"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsMilitaryRegion GetByRegionDescrAr(System.String _regionDescrAr)
		{
			int count = -1;
			return GetByRegionDescrAr(null,_regionDescrAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_MILITARY_REGION_AR index.
		/// </summary>
		/// <param name="_regionDescrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsMilitaryRegion"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsMilitaryRegion GetByRegionDescrAr(System.String _regionDescrAr, int start, int pageLength)
		{
			int count = -1;
			return GetByRegionDescrAr(null, _regionDescrAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_MILITARY_REGION_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_regionDescrAr"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsMilitaryRegion"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsMilitaryRegion GetByRegionDescrAr(TransactionManager transactionManager, System.String _regionDescrAr)
		{
			int count = -1;
			return GetByRegionDescrAr(transactionManager, _regionDescrAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_MILITARY_REGION_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_regionDescrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsMilitaryRegion"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsMilitaryRegion GetByRegionDescrAr(TransactionManager transactionManager, System.String _regionDescrAr, int start, int pageLength)
		{
			int count = -1;
			return GetByRegionDescrAr(transactionManager, _regionDescrAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_MILITARY_REGION_AR index.
		/// </summary>
		/// <param name="_regionDescrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsMilitaryRegion"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsMilitaryRegion GetByRegionDescrAr(System.String _regionDescrAr, int start, int pageLength, out int count)
		{
			return GetByRegionDescrAr(null, _regionDescrAr, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_MILITARY_REGION_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_regionDescrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsMilitaryRegion"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsMilitaryRegion GetByRegionDescrAr(TransactionManager transactionManager, System.String _regionDescrAr, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_GS_MILITARY_REGION_EN index.
		/// </summary>
		/// <param name="_regionDescrEn"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsMilitaryRegion"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsMilitaryRegion GetByRegionDescrEn(System.String _regionDescrEn)
		{
			int count = -1;
			return GetByRegionDescrEn(null,_regionDescrEn, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_MILITARY_REGION_EN index.
		/// </summary>
		/// <param name="_regionDescrEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsMilitaryRegion"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsMilitaryRegion GetByRegionDescrEn(System.String _regionDescrEn, int start, int pageLength)
		{
			int count = -1;
			return GetByRegionDescrEn(null, _regionDescrEn, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_MILITARY_REGION_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_regionDescrEn"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsMilitaryRegion"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsMilitaryRegion GetByRegionDescrEn(TransactionManager transactionManager, System.String _regionDescrEn)
		{
			int count = -1;
			return GetByRegionDescrEn(transactionManager, _regionDescrEn, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_MILITARY_REGION_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_regionDescrEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsMilitaryRegion"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsMilitaryRegion GetByRegionDescrEn(TransactionManager transactionManager, System.String _regionDescrEn, int start, int pageLength)
		{
			int count = -1;
			return GetByRegionDescrEn(transactionManager, _regionDescrEn, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_MILITARY_REGION_EN index.
		/// </summary>
		/// <param name="_regionDescrEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsMilitaryRegion"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsMilitaryRegion GetByRegionDescrEn(System.String _regionDescrEn, int start, int pageLength, out int count)
		{
			return GetByRegionDescrEn(null, _regionDescrEn, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_MILITARY_REGION_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_regionDescrEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsMilitaryRegion"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsMilitaryRegion GetByRegionDescrEn(TransactionManager transactionManager, System.String _regionDescrEn, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GsMilitaryRegion&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GsMilitaryRegion&gt;"/></returns>
		public static TList<GsMilitaryRegion> Fill(IDataReader reader, TList<GsMilitaryRegion> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.GsMilitaryRegion c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GsMilitaryRegion")
					.Append("|").Append((System.Decimal)reader["GS_MILITARY_REGION_ID"]).ToString();
					c = EntityManager.LocateOrCreate<GsMilitaryRegion>(
					key.ToString(), // EntityTrackingKey
					"GsMilitaryRegion",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.GsMilitaryRegion();
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
					c.GsMilitaryRegionId = (System.Decimal)reader["GS_MILITARY_REGION_ID"];
					c.OriginalGsMilitaryRegionId = c.GsMilitaryRegionId;
					c.RegionDescrAr = (System.String)reader["REGION_DESCR_AR"];
					c.RegionDescrEn = Convert.IsDBNull(reader["REGION_DESCR_EN"]) ? null : (System.String)reader["REGION_DESCR_EN"];
					c.RegionCode = Convert.IsDBNull(reader["REGION_CODE"]) ? null : (System.String)reader["REGION_CODE"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsMilitaryRegion"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsMilitaryRegion"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.GsMilitaryRegion entity)
		{
			if (!reader.Read()) return;
			
			entity.GsMilitaryRegionId = (System.Decimal)reader[((int)GsMilitaryRegionColumn.GsMilitaryRegionId - 1)];
			entity.OriginalGsMilitaryRegionId = (System.Decimal)reader["GS_MILITARY_REGION_ID"];
			entity.RegionDescrAr = (System.String)reader[((int)GsMilitaryRegionColumn.RegionDescrAr - 1)];
			entity.RegionDescrEn = (reader.IsDBNull(((int)GsMilitaryRegionColumn.RegionDescrEn - 1)))?null:(System.String)reader[((int)GsMilitaryRegionColumn.RegionDescrEn - 1)];
			entity.RegionCode = (reader.IsDBNull(((int)GsMilitaryRegionColumn.RegionCode - 1)))?null:(System.String)reader[((int)GsMilitaryRegionColumn.RegionCode - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsMilitaryRegion"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsMilitaryRegion"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.GsMilitaryRegion entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.GsMilitaryRegionId = (System.Decimal)dataRow["GS_MILITARY_REGION_ID"];
			entity.OriginalGsMilitaryRegionId = (System.Decimal)dataRow["GS_MILITARY_REGION_ID"];
			entity.RegionDescrAr = (System.String)dataRow["REGION_DESCR_AR"];
			entity.RegionDescrEn = Convert.IsDBNull(dataRow["REGION_DESCR_EN"]) ? null : (System.String)dataRow["REGION_DESCR_EN"];
			entity.RegionCode = Convert.IsDBNull(dataRow["REGION_CODE"]) ? null : (System.String)dataRow["REGION_CODE"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsMilitaryRegion"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsMilitaryRegion Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsMilitaryRegion entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByGsMilitaryRegionId methods when available
			
			#region EdStudMilitaryInfoCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudMilitaryInfo>|EdStudMilitaryInfoCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudMilitaryInfoCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudMilitaryInfoCollection = DataRepository.EdStudMilitaryInfoProvider.GetByGsMilitaryRegionId(transactionManager, entity.GsMilitaryRegionId);

				if (deep && entity.EdStudMilitaryInfoCollection.Count > 0)
				{
					deepHandles.Add("EdStudMilitaryInfoCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudMilitaryInfo>) DataRepository.EdStudMilitaryInfoProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudMilitaryInfoCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region GsMilitaryOfficeCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GsMilitaryOffice>|GsMilitaryOfficeCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsMilitaryOfficeCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GsMilitaryOfficeCollection = DataRepository.GsMilitaryOfficeProvider.GetByGsMilitaryRegionId(transactionManager, entity.GsMilitaryRegionId);

				if (deep && entity.GsMilitaryOfficeCollection.Count > 0)
				{
					deepHandles.Add("GsMilitaryOfficeCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GsMilitaryOffice>) DataRepository.GsMilitaryOfficeProvider.DeepLoad,
						new object[] { transactionManager, entity.GsMilitaryOfficeCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.SaMiltaryCollection = DataRepository.SaMiltaryProvider.GetByGsMilitaryRegionId(transactionManager, entity.GsMilitaryRegionId);

				if (deep && entity.SaMiltaryCollection.Count > 0)
				{
					deepHandles.Add("SaMiltaryCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaMiltary>) DataRepository.SaMiltaryProvider.DeepLoad,
						new object[] { transactionManager, entity.SaMiltaryCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.GsMilitaryRegion object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.GsMilitaryRegion instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsMilitaryRegion Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsMilitaryRegion entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<EdStudMilitaryInfo>
				if (CanDeepSave(entity.EdStudMilitaryInfoCollection, "List<EdStudMilitaryInfo>|EdStudMilitaryInfoCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudMilitaryInfo child in entity.EdStudMilitaryInfoCollection)
					{
						if(child.GsMilitaryRegionIdSource != null)
						{
							child.GsMilitaryRegionId = child.GsMilitaryRegionIdSource.GsMilitaryRegionId;
						}
						else
						{
							child.GsMilitaryRegionId = entity.GsMilitaryRegionId;
						}

					}

					if (entity.EdStudMilitaryInfoCollection.Count > 0 || entity.EdStudMilitaryInfoCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudMilitaryInfoProvider.Save(transactionManager, entity.EdStudMilitaryInfoCollection);
						
						deepHandles.Add("EdStudMilitaryInfoCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudMilitaryInfo >) DataRepository.EdStudMilitaryInfoProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudMilitaryInfoCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<GsMilitaryOffice>
				if (CanDeepSave(entity.GsMilitaryOfficeCollection, "List<GsMilitaryOffice>|GsMilitaryOfficeCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GsMilitaryOffice child in entity.GsMilitaryOfficeCollection)
					{
						if(child.GsMilitaryRegionIdSource != null)
						{
							child.GsMilitaryRegionId = child.GsMilitaryRegionIdSource.GsMilitaryRegionId;
						}
						else
						{
							child.GsMilitaryRegionId = entity.GsMilitaryRegionId;
						}

					}

					if (entity.GsMilitaryOfficeCollection.Count > 0 || entity.GsMilitaryOfficeCollection.DeletedItems.Count > 0)
					{
						//DataRepository.GsMilitaryOfficeProvider.Save(transactionManager, entity.GsMilitaryOfficeCollection);
						
						deepHandles.Add("GsMilitaryOfficeCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< GsMilitaryOffice >) DataRepository.GsMilitaryOfficeProvider.DeepSave,
							new object[] { transactionManager, entity.GsMilitaryOfficeCollection, deepSaveType, childTypes, innerList }
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
						if(child.GsMilitaryRegionIdSource != null)
						{
							child.GsMilitaryRegionId = child.GsMilitaryRegionIdSource.GsMilitaryRegionId;
						}
						else
						{
							child.GsMilitaryRegionId = entity.GsMilitaryRegionId;
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
	
	#region GsMilitaryRegionChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.GsMilitaryRegion</c>
	///</summary>
	public enum GsMilitaryRegionChildEntityTypes
	{
		///<summary>
		/// Collection of <c>GsMilitaryRegion</c> as OneToMany for EdStudMilitaryInfoCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudMilitaryInfo>))]
		EdStudMilitaryInfoCollection,
		///<summary>
		/// Collection of <c>GsMilitaryRegion</c> as OneToMany for GsMilitaryOfficeCollection
		///</summary>
		[ChildEntityType(typeof(TList<GsMilitaryOffice>))]
		GsMilitaryOfficeCollection,
		///<summary>
		/// Collection of <c>GsMilitaryRegion</c> as OneToMany for SaMiltaryCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaMiltary>))]
		SaMiltaryCollection,
	}
	
	#endregion GsMilitaryRegionChildEntityTypes
	
	#region GsMilitaryRegionFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GsMilitaryRegionColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsMilitaryRegion"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsMilitaryRegionFilterBuilder : SqlFilterBuilder<GsMilitaryRegionColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsMilitaryRegionFilterBuilder class.
		/// </summary>
		public GsMilitaryRegionFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsMilitaryRegionFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsMilitaryRegionFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsMilitaryRegionFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsMilitaryRegionFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsMilitaryRegionFilterBuilder
	
	#region GsMilitaryRegionParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GsMilitaryRegionColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsMilitaryRegion"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsMilitaryRegionParameterBuilder : ParameterizedSqlFilterBuilder<GsMilitaryRegionColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsMilitaryRegionParameterBuilder class.
		/// </summary>
		public GsMilitaryRegionParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsMilitaryRegionParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsMilitaryRegionParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsMilitaryRegionParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsMilitaryRegionParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsMilitaryRegionParameterBuilder
	
	#region GsMilitaryRegionSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GsMilitaryRegionColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsMilitaryRegion"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GsMilitaryRegionSortBuilder : SqlSortBuilder<GsMilitaryRegionColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsMilitaryRegionSqlSortBuilder class.
		/// </summary>
		public GsMilitaryRegionSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GsMilitaryRegionSortBuilder
	
} // end namespace
