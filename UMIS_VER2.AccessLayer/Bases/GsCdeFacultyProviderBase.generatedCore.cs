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
	/// This class is the base class for any <see cref="GsCdeFacultyProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GsCdeFacultyProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.GsCdeFaculty, UMIS_VER2.BusinessLyer.GsCdeFacultyKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeFacultyKey key)
		{
			return Delete(transactionManager, key.GsCdeFacultyId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_gsCdeFacultyId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _gsCdeFacultyId)
		{
			return Delete(null, _gsCdeFacultyId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeFacultyId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _gsCdeFacultyId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CDE_FACULTY_GS_CDE_UNIVERSITIES key.
		///		FK_GS_CDE_FACULTY_GS_CDE_UNIVERSITIES Description: 
		/// </summary>
		/// <param name="_gsCdeUniversitiesId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCdeFaculty objects.</returns>
		public TList<GsCdeFaculty> GetByGsCdeUniversitiesId(System.Decimal? _gsCdeUniversitiesId)
		{
			int count = -1;
			return GetByGsCdeUniversitiesId(_gsCdeUniversitiesId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CDE_FACULTY_GS_CDE_UNIVERSITIES key.
		///		FK_GS_CDE_FACULTY_GS_CDE_UNIVERSITIES Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeUniversitiesId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCdeFaculty objects.</returns>
		/// <remarks></remarks>
		public TList<GsCdeFaculty> GetByGsCdeUniversitiesId(TransactionManager transactionManager, System.Decimal? _gsCdeUniversitiesId)
		{
			int count = -1;
			return GetByGsCdeUniversitiesId(transactionManager, _gsCdeUniversitiesId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CDE_FACULTY_GS_CDE_UNIVERSITIES key.
		///		FK_GS_CDE_FACULTY_GS_CDE_UNIVERSITIES Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeUniversitiesId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCdeFaculty objects.</returns>
		public TList<GsCdeFaculty> GetByGsCdeUniversitiesId(TransactionManager transactionManager, System.Decimal? _gsCdeUniversitiesId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeUniversitiesId(transactionManager, _gsCdeUniversitiesId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CDE_FACULTY_GS_CDE_UNIVERSITIES key.
		///		fkGsCdeFacultyGsCdeUniversities Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCdeUniversitiesId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCdeFaculty objects.</returns>
		public TList<GsCdeFaculty> GetByGsCdeUniversitiesId(System.Decimal? _gsCdeUniversitiesId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCdeUniversitiesId(null, _gsCdeUniversitiesId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CDE_FACULTY_GS_CDE_UNIVERSITIES key.
		///		fkGsCdeFacultyGsCdeUniversities Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCdeUniversitiesId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCdeFaculty objects.</returns>
		public TList<GsCdeFaculty> GetByGsCdeUniversitiesId(System.Decimal? _gsCdeUniversitiesId, int start, int pageLength,out int count)
		{
			return GetByGsCdeUniversitiesId(null, _gsCdeUniversitiesId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CDE_FACULTY_GS_CDE_UNIVERSITIES key.
		///		FK_GS_CDE_FACULTY_GS_CDE_UNIVERSITIES Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeUniversitiesId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCdeFaculty objects.</returns>
		public abstract TList<GsCdeFaculty> GetByGsCdeUniversitiesId(TransactionManager transactionManager, System.Decimal? _gsCdeUniversitiesId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.GsCdeFaculty Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeFacultyKey key, int start, int pageLength)
		{
			return GetByGsCdeFacultyId(transactionManager, key.GsCdeFacultyId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_GS_CDE_FACULTY index.
		/// </summary>
		/// <param name="_gsCdeFacultyId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeFaculty"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeFaculty GetByGsCdeFacultyId(System.Decimal _gsCdeFacultyId)
		{
			int count = -1;
			return GetByGsCdeFacultyId(null,_gsCdeFacultyId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_FACULTY index.
		/// </summary>
		/// <param name="_gsCdeFacultyId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeFaculty"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeFaculty GetByGsCdeFacultyId(System.Decimal _gsCdeFacultyId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeFacultyId(null, _gsCdeFacultyId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_FACULTY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeFacultyId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeFaculty"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeFaculty GetByGsCdeFacultyId(TransactionManager transactionManager, System.Decimal _gsCdeFacultyId)
		{
			int count = -1;
			return GetByGsCdeFacultyId(transactionManager, _gsCdeFacultyId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_FACULTY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeFacultyId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeFaculty"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeFaculty GetByGsCdeFacultyId(TransactionManager transactionManager, System.Decimal _gsCdeFacultyId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeFacultyId(transactionManager, _gsCdeFacultyId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_FACULTY index.
		/// </summary>
		/// <param name="_gsCdeFacultyId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeFaculty"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeFaculty GetByGsCdeFacultyId(System.Decimal _gsCdeFacultyId, int start, int pageLength, out int count)
		{
			return GetByGsCdeFacultyId(null, _gsCdeFacultyId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_FACULTY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeFacultyId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeFaculty"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsCdeFaculty GetByGsCdeFacultyId(TransactionManager transactionManager, System.Decimal _gsCdeFacultyId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GsCdeFaculty&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GsCdeFaculty&gt;"/></returns>
		public static TList<GsCdeFaculty> Fill(IDataReader reader, TList<GsCdeFaculty> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.GsCdeFaculty c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GsCdeFaculty")
					.Append("|").Append((System.Decimal)reader["GS_CDE_FACULTY_ID"]).ToString();
					c = EntityManager.LocateOrCreate<GsCdeFaculty>(
					key.ToString(), // EntityTrackingKey
					"GsCdeFaculty",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.GsCdeFaculty();
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
					c.GsCdeFacultyId = (System.Decimal)reader["GS_CDE_FACULTY_ID"];
					c.OriginalGsCdeFacultyId = c.GsCdeFacultyId;
					c.GsCdeUniversitiesId = Convert.IsDBNull(reader["GS_CDE_UNIVERSITIES_ID"]) ? null : (System.Decimal?)reader["GS_CDE_UNIVERSITIES_ID"];
					c.FacDescrAr = (System.String)reader["FAC_DESCR_AR"];
					c.FacDescrEn = (System.String)reader["FAC_DESCR_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCdeFaculty"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCdeFaculty"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.GsCdeFaculty entity)
		{
			if (!reader.Read()) return;
			
			entity.GsCdeFacultyId = (System.Decimal)reader[((int)GsCdeFacultyColumn.GsCdeFacultyId - 1)];
			entity.OriginalGsCdeFacultyId = (System.Decimal)reader["GS_CDE_FACULTY_ID"];
			entity.GsCdeUniversitiesId = (reader.IsDBNull(((int)GsCdeFacultyColumn.GsCdeUniversitiesId - 1)))?null:(System.Decimal?)reader[((int)GsCdeFacultyColumn.GsCdeUniversitiesId - 1)];
			entity.FacDescrAr = (System.String)reader[((int)GsCdeFacultyColumn.FacDescrAr - 1)];
			entity.FacDescrEn = (System.String)reader[((int)GsCdeFacultyColumn.FacDescrEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCdeFaculty"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCdeFaculty"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.GsCdeFaculty entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.GsCdeFacultyId = (System.Decimal)dataRow["GS_CDE_FACULTY_ID"];
			entity.OriginalGsCdeFacultyId = (System.Decimal)dataRow["GS_CDE_FACULTY_ID"];
			entity.GsCdeUniversitiesId = Convert.IsDBNull(dataRow["GS_CDE_UNIVERSITIES_ID"]) ? null : (System.Decimal?)dataRow["GS_CDE_UNIVERSITIES_ID"];
			entity.FacDescrAr = (System.String)dataRow["FAC_DESCR_AR"];
			entity.FacDescrEn = (System.String)dataRow["FAC_DESCR_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCdeFaculty"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCdeFaculty Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeFaculty entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region GsCdeUniversitiesIdSource	
			if (CanDeepLoad(entity, "GsCdeUniversities|GsCdeUniversitiesIdSource", deepLoadType, innerList) 
				&& entity.GsCdeUniversitiesIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCdeUniversitiesId ?? 0.0m);
				GsCdeUniversities tmpEntity = EntityManager.LocateEntity<GsCdeUniversities>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCdeUniversities), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCdeUniversitiesIdSource = tmpEntity;
				else
					entity.GsCdeUniversitiesIdSource = DataRepository.GsCdeUniversitiesProvider.GetByGsCdeUniversitiesId(transactionManager, (entity.GsCdeUniversitiesId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCdeUniversitiesIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCdeUniversitiesIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCdeUniversitiesProvider.DeepLoad(transactionManager, entity.GsCdeUniversitiesIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCdeUniversitiesIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByGsCdeFacultyId methods when available
			
			#region EdStudQualCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudQual>|EdStudQualCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudQualCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudQualCollection = DataRepository.EdStudQualProvider.GetByGsCdeFacultyId(transactionManager, entity.GsCdeFacultyId);

				if (deep && entity.EdStudQualCollection.Count > 0)
				{
					deepHandles.Add("EdStudQualCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudQual>) DataRepository.EdStudQualProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudQualCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.GsCdeFaculty object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.GsCdeFaculty instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCdeFaculty Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeFaculty entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region GsCdeUniversitiesIdSource
			if (CanDeepSave(entity, "GsCdeUniversities|GsCdeUniversitiesIdSource", deepSaveType, innerList) 
				&& entity.GsCdeUniversitiesIdSource != null)
			{
				DataRepository.GsCdeUniversitiesProvider.Save(transactionManager, entity.GsCdeUniversitiesIdSource);
				entity.GsCdeUniversitiesId = entity.GsCdeUniversitiesIdSource.GsCdeUniversitiesId;
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
						if(child.GsCdeFacultyIdSource != null)
						{
							child.GsCdeFacultyId = child.GsCdeFacultyIdSource.GsCdeFacultyId;
						}
						else
						{
							child.GsCdeFacultyId = entity.GsCdeFacultyId;
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
	
	#region GsCdeFacultyChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.GsCdeFaculty</c>
	///</summary>
	public enum GsCdeFacultyChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>GsCdeUniversities</c> at GsCdeUniversitiesIdSource
		///</summary>
		[ChildEntityType(typeof(GsCdeUniversities))]
		GsCdeUniversities,
		///<summary>
		/// Collection of <c>GsCdeFaculty</c> as OneToMany for EdStudQualCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudQual>))]
		EdStudQualCollection,
	}
	
	#endregion GsCdeFacultyChildEntityTypes
	
	#region GsCdeFacultyFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GsCdeFacultyColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCdeFaculty"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCdeFacultyFilterBuilder : SqlFilterBuilder<GsCdeFacultyColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCdeFacultyFilterBuilder class.
		/// </summary>
		public GsCdeFacultyFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCdeFacultyFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCdeFacultyFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCdeFacultyFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCdeFacultyFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCdeFacultyFilterBuilder
	
	#region GsCdeFacultyParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GsCdeFacultyColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCdeFaculty"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCdeFacultyParameterBuilder : ParameterizedSqlFilterBuilder<GsCdeFacultyColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCdeFacultyParameterBuilder class.
		/// </summary>
		public GsCdeFacultyParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCdeFacultyParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCdeFacultyParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCdeFacultyParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCdeFacultyParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCdeFacultyParameterBuilder
	
	#region GsCdeFacultySortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GsCdeFacultyColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCdeFaculty"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GsCdeFacultySortBuilder : SqlSortBuilder<GsCdeFacultyColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCdeFacultySqlSortBuilder class.
		/// </summary>
		public GsCdeFacultySortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GsCdeFacultySortBuilder
	
} // end namespace
