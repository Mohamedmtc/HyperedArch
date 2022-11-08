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
	/// This class is the base class for any <see cref="GsCdeCampusProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GsCdeCampusProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.GsCdeCampus, UMIS_VER2.BusinessLyer.GsCdeCampusKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeCampusKey key)
		{
			return Delete(transactionManager, key.GsCdeCampusId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_gsCdeCampusId">Campus حرم الجامعة. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _gsCdeCampusId)
		{
			return Delete(null, _gsCdeCampusId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeCampusId">Campus حرم الجامعة. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _gsCdeCampusId);		
		
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
		public override UMIS_VER2.BusinessLyer.GsCdeCampus Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeCampusKey key, int start, int pageLength)
		{
			return GetByGsCdeCampusId(transactionManager, key.GsCdeCampusId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SC_CDE_SITE index.
		/// </summary>
		/// <param name="_gsCdeCampusId">Campus حرم الجامعة</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeCampus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeCampus GetByGsCdeCampusId(System.Decimal _gsCdeCampusId)
		{
			int count = -1;
			return GetByGsCdeCampusId(null,_gsCdeCampusId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_CDE_SITE index.
		/// </summary>
		/// <param name="_gsCdeCampusId">Campus حرم الجامعة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeCampus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeCampus GetByGsCdeCampusId(System.Decimal _gsCdeCampusId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeCampusId(null, _gsCdeCampusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_CDE_SITE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeCampusId">Campus حرم الجامعة</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeCampus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeCampus GetByGsCdeCampusId(TransactionManager transactionManager, System.Decimal _gsCdeCampusId)
		{
			int count = -1;
			return GetByGsCdeCampusId(transactionManager, _gsCdeCampusId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_CDE_SITE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeCampusId">Campus حرم الجامعة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeCampus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeCampus GetByGsCdeCampusId(TransactionManager transactionManager, System.Decimal _gsCdeCampusId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeCampusId(transactionManager, _gsCdeCampusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_CDE_SITE index.
		/// </summary>
		/// <param name="_gsCdeCampusId">Campus حرم الجامعة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeCampus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeCampus GetByGsCdeCampusId(System.Decimal _gsCdeCampusId, int start, int pageLength, out int count)
		{
			return GetByGsCdeCampusId(null, _gsCdeCampusId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_CDE_SITE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeCampusId">Campus حرم الجامعة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeCampus"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsCdeCampus GetByGsCdeCampusId(TransactionManager transactionManager, System.Decimal _gsCdeCampusId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GsCdeCampus&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GsCdeCampus&gt;"/></returns>
		public static TList<GsCdeCampus> Fill(IDataReader reader, TList<GsCdeCampus> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.GsCdeCampus c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GsCdeCampus")
					.Append("|").Append((System.Decimal)reader["GS_CDE_CAMPUS_ID"]).ToString();
					c = EntityManager.LocateOrCreate<GsCdeCampus>(
					key.ToString(), // EntityTrackingKey
					"GsCdeCampus",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.GsCdeCampus();
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
					c.GsCdeCampusId = (System.Decimal)reader["GS_CDE_CAMPUS_ID"];
					c.OriginalGsCdeCampusId = c.GsCdeCampusId;
					c.DescrAr = (System.String)reader["DESCR_AR"];
					c.DescrEn = (System.String)reader["DESCR_EN"];
					c.CampCode = Convert.IsDBNull(reader["CAMP_CODE"]) ? null : (System.String)reader["CAMP_CODE"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCdeCampus"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCdeCampus"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.GsCdeCampus entity)
		{
			if (!reader.Read()) return;
			
			entity.GsCdeCampusId = (System.Decimal)reader[((int)GsCdeCampusColumn.GsCdeCampusId - 1)];
			entity.OriginalGsCdeCampusId = (System.Decimal)reader["GS_CDE_CAMPUS_ID"];
			entity.DescrAr = (System.String)reader[((int)GsCdeCampusColumn.DescrAr - 1)];
			entity.DescrEn = (System.String)reader[((int)GsCdeCampusColumn.DescrEn - 1)];
			entity.CampCode = (reader.IsDBNull(((int)GsCdeCampusColumn.CampCode - 1)))?null:(System.String)reader[((int)GsCdeCampusColumn.CampCode - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCdeCampus"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCdeCampus"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.GsCdeCampus entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.GsCdeCampusId = (System.Decimal)dataRow["GS_CDE_CAMPUS_ID"];
			entity.OriginalGsCdeCampusId = (System.Decimal)dataRow["GS_CDE_CAMPUS_ID"];
			entity.DescrAr = (System.String)dataRow["DESCR_AR"];
			entity.DescrEn = (System.String)dataRow["DESCR_EN"];
			entity.CampCode = Convert.IsDBNull(dataRow["CAMP_CODE"]) ? null : (System.String)dataRow["CAMP_CODE"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCdeCampus"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCdeCampus Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeCampus entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByGsCdeCampusId methods when available
			
			#region EdStudViolCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudViol>|EdStudViolCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudViolCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudViolCollection = DataRepository.EdStudViolProvider.GetByGsCdeCampusId(transactionManager, entity.GsCdeCampusId);

				if (deep && entity.EdStudViolCollection.Count > 0)
				{
					deepHandles.Add("EdStudViolCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudViol>) DataRepository.EdStudViolProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudViolCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region TrnsLineCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<TrnsLine>|TrnsLineCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'TrnsLineCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.TrnsLineCollection = DataRepository.TrnsLineProvider.GetByGsCdeCampusId(transactionManager, entity.GsCdeCampusId);

				if (deep && entity.TrnsLineCollection.Count > 0)
				{
					deepHandles.Add("TrnsLineCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<TrnsLine>) DataRepository.TrnsLineProvider.DeepLoad,
						new object[] { transactionManager, entity.TrnsLineCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.TrnsStudReqCollection = DataRepository.TrnsStudReqProvider.GetByGsCdeCampusId(transactionManager, entity.GsCdeCampusId);

				if (deep && entity.TrnsStudReqCollection.Count > 0)
				{
					deepHandles.Add("TrnsStudReqCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<TrnsStudReq>) DataRepository.TrnsStudReqProvider.DeepLoad,
						new object[] { transactionManager, entity.TrnsStudReqCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.ScBuildingCollection = DataRepository.ScBuildingProvider.GetByGsCdeCampusId(transactionManager, entity.GsCdeCampusId);

				if (deep && entity.ScBuildingCollection.Count > 0)
				{
					deepHandles.Add("ScBuildingCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScBuilding>) DataRepository.ScBuildingProvider.DeepLoad,
						new object[] { transactionManager, entity.ScBuildingCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.GsCdeCampus object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.GsCdeCampus instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCdeCampus Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeCampus entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<EdStudViol>
				if (CanDeepSave(entity.EdStudViolCollection, "List<EdStudViol>|EdStudViolCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudViol child in entity.EdStudViolCollection)
					{
						if(child.GsCdeCampusIdSource != null)
						{
							child.GsCdeCampusId = child.GsCdeCampusIdSource.GsCdeCampusId;
						}
						else
						{
							child.GsCdeCampusId = entity.GsCdeCampusId;
						}

					}

					if (entity.EdStudViolCollection.Count > 0 || entity.EdStudViolCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudViolProvider.Save(transactionManager, entity.EdStudViolCollection);
						
						deepHandles.Add("EdStudViolCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudViol >) DataRepository.EdStudViolProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudViolCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<TrnsLine>
				if (CanDeepSave(entity.TrnsLineCollection, "List<TrnsLine>|TrnsLineCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(TrnsLine child in entity.TrnsLineCollection)
					{
						if(child.GsCdeCampusIdSource != null)
						{
							child.GsCdeCampusId = child.GsCdeCampusIdSource.GsCdeCampusId;
						}
						else
						{
							child.GsCdeCampusId = entity.GsCdeCampusId;
						}

					}

					if (entity.TrnsLineCollection.Count > 0 || entity.TrnsLineCollection.DeletedItems.Count > 0)
					{
						//DataRepository.TrnsLineProvider.Save(transactionManager, entity.TrnsLineCollection);
						
						deepHandles.Add("TrnsLineCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< TrnsLine >) DataRepository.TrnsLineProvider.DeepSave,
							new object[] { transactionManager, entity.TrnsLineCollection, deepSaveType, childTypes, innerList }
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
						if(child.GsCdeCampusIdSource != null)
						{
							child.GsCdeCampusId = child.GsCdeCampusIdSource.GsCdeCampusId;
						}
						else
						{
							child.GsCdeCampusId = entity.GsCdeCampusId;
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
				
	
			#region List<ScBuilding>
				if (CanDeepSave(entity.ScBuildingCollection, "List<ScBuilding>|ScBuildingCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScBuilding child in entity.ScBuildingCollection)
					{
						if(child.GsCdeCampusIdSource != null)
						{
							child.GsCdeCampusId = child.GsCdeCampusIdSource.GsCdeCampusId;
						}
						else
						{
							child.GsCdeCampusId = entity.GsCdeCampusId;
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
	
	#region GsCdeCampusChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.GsCdeCampus</c>
	///</summary>
	public enum GsCdeCampusChildEntityTypes
	{
		///<summary>
		/// Collection of <c>GsCdeCampus</c> as OneToMany for EdStudViolCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudViol>))]
		EdStudViolCollection,
		///<summary>
		/// Collection of <c>GsCdeCampus</c> as OneToMany for TrnsLineCollection
		///</summary>
		[ChildEntityType(typeof(TList<TrnsLine>))]
		TrnsLineCollection,
		///<summary>
		/// Collection of <c>GsCdeCampus</c> as OneToMany for TrnsStudReqCollection
		///</summary>
		[ChildEntityType(typeof(TList<TrnsStudReq>))]
		TrnsStudReqCollection,
		///<summary>
		/// Collection of <c>GsCdeCampus</c> as OneToMany for ScBuildingCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScBuilding>))]
		ScBuildingCollection,
	}
	
	#endregion GsCdeCampusChildEntityTypes
	
	#region GsCdeCampusFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GsCdeCampusColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCdeCampus"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCdeCampusFilterBuilder : SqlFilterBuilder<GsCdeCampusColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCdeCampusFilterBuilder class.
		/// </summary>
		public GsCdeCampusFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCdeCampusFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCdeCampusFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCdeCampusFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCdeCampusFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCdeCampusFilterBuilder
	
	#region GsCdeCampusParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GsCdeCampusColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCdeCampus"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCdeCampusParameterBuilder : ParameterizedSqlFilterBuilder<GsCdeCampusColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCdeCampusParameterBuilder class.
		/// </summary>
		public GsCdeCampusParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCdeCampusParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCdeCampusParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCdeCampusParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCdeCampusParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCdeCampusParameterBuilder
	
	#region GsCdeCampusSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GsCdeCampusColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCdeCampus"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GsCdeCampusSortBuilder : SqlSortBuilder<GsCdeCampusColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCdeCampusSqlSortBuilder class.
		/// </summary>
		public GsCdeCampusSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GsCdeCampusSortBuilder
	
} // end namespace
