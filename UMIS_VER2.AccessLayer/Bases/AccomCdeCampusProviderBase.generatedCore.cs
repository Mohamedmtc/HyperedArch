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
	/// This class is the base class for any <see cref="AccomCdeCampusProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AccomCdeCampusProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AccomCdeCampus, UMIS_VER2.BusinessLyer.AccomCdeCampusKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomCdeCampusKey key)
		{
			return Delete(transactionManager, key.AccomCdeCampusId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_accomCdeCampusId">تعريف المواقع. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _accomCdeCampusId)
		{
			return Delete(null, _accomCdeCampusId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomCdeCampusId">تعريف المواقع. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _accomCdeCampusId);		
		
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
		public override UMIS_VER2.BusinessLyer.AccomCdeCampus Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomCdeCampusKey key, int start, int pageLength)
		{
			return GetByAccomCdeCampusId(transactionManager, key.AccomCdeCampusId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ACCOM_CDE_CAMPUS index.
		/// </summary>
		/// <param name="_accomCdeCampusId">تعريف المواقع</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomCdeCampus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomCdeCampus GetByAccomCdeCampusId(System.Int32 _accomCdeCampusId)
		{
			int count = -1;
			return GetByAccomCdeCampusId(null,_accomCdeCampusId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_CDE_CAMPUS index.
		/// </summary>
		/// <param name="_accomCdeCampusId">تعريف المواقع</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomCdeCampus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomCdeCampus GetByAccomCdeCampusId(System.Int32 _accomCdeCampusId, int start, int pageLength)
		{
			int count = -1;
			return GetByAccomCdeCampusId(null, _accomCdeCampusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_CDE_CAMPUS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomCdeCampusId">تعريف المواقع</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomCdeCampus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomCdeCampus GetByAccomCdeCampusId(TransactionManager transactionManager, System.Int32 _accomCdeCampusId)
		{
			int count = -1;
			return GetByAccomCdeCampusId(transactionManager, _accomCdeCampusId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_CDE_CAMPUS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomCdeCampusId">تعريف المواقع</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomCdeCampus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomCdeCampus GetByAccomCdeCampusId(TransactionManager transactionManager, System.Int32 _accomCdeCampusId, int start, int pageLength)
		{
			int count = -1;
			return GetByAccomCdeCampusId(transactionManager, _accomCdeCampusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_CDE_CAMPUS index.
		/// </summary>
		/// <param name="_accomCdeCampusId">تعريف المواقع</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomCdeCampus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomCdeCampus GetByAccomCdeCampusId(System.Int32 _accomCdeCampusId, int start, int pageLength, out int count)
		{
			return GetByAccomCdeCampusId(null, _accomCdeCampusId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_CDE_CAMPUS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomCdeCampusId">تعريف المواقع</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomCdeCampus"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AccomCdeCampus GetByAccomCdeCampusId(TransactionManager transactionManager, System.Int32 _accomCdeCampusId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AccomCdeCampus&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AccomCdeCampus&gt;"/></returns>
		public static TList<AccomCdeCampus> Fill(IDataReader reader, TList<AccomCdeCampus> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AccomCdeCampus c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AccomCdeCampus")
					.Append("|").Append((System.Int32)reader["ACCOM_CDE_CAMPUS_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AccomCdeCampus>(
					key.ToString(), // EntityTrackingKey
					"AccomCdeCampus",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AccomCdeCampus();
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
					c.AccomCdeCampusId = (System.Int32)reader["ACCOM_CDE_CAMPUS_ID"];
					c.OriginalAccomCdeCampusId = c.AccomCdeCampusId;
					c.CampusAr = (System.String)reader["CAMPUS_AR"];
					c.CampusEn = (System.String)reader["CAMPUS_EN"];
					c.CampusCode = Convert.IsDBNull(reader["CAMPUS_CODE"]) ? null : (System.String)reader["CAMPUS_CODE"];
					c.IsActive = Convert.IsDBNull(reader["IS_ACTIVE"]) ? null : (System.Boolean?)reader["IS_ACTIVE"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AccomCdeCampus"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AccomCdeCampus"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AccomCdeCampus entity)
		{
			if (!reader.Read()) return;
			
			entity.AccomCdeCampusId = (System.Int32)reader[((int)AccomCdeCampusColumn.AccomCdeCampusId - 1)];
			entity.OriginalAccomCdeCampusId = (System.Int32)reader["ACCOM_CDE_CAMPUS_ID"];
			entity.CampusAr = (System.String)reader[((int)AccomCdeCampusColumn.CampusAr - 1)];
			entity.CampusEn = (System.String)reader[((int)AccomCdeCampusColumn.CampusEn - 1)];
			entity.CampusCode = (reader.IsDBNull(((int)AccomCdeCampusColumn.CampusCode - 1)))?null:(System.String)reader[((int)AccomCdeCampusColumn.CampusCode - 1)];
			entity.IsActive = (reader.IsDBNull(((int)AccomCdeCampusColumn.IsActive - 1)))?null:(System.Boolean?)reader[((int)AccomCdeCampusColumn.IsActive - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AccomCdeCampus"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AccomCdeCampus"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AccomCdeCampus entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AccomCdeCampusId = (System.Int32)dataRow["ACCOM_CDE_CAMPUS_ID"];
			entity.OriginalAccomCdeCampusId = (System.Int32)dataRow["ACCOM_CDE_CAMPUS_ID"];
			entity.CampusAr = (System.String)dataRow["CAMPUS_AR"];
			entity.CampusEn = (System.String)dataRow["CAMPUS_EN"];
			entity.CampusCode = Convert.IsDBNull(dataRow["CAMPUS_CODE"]) ? null : (System.String)dataRow["CAMPUS_CODE"];
			entity.IsActive = Convert.IsDBNull(dataRow["IS_ACTIVE"]) ? null : (System.Boolean?)dataRow["IS_ACTIVE"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AccomCdeCampus"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AccomCdeCampus Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomCdeCampus entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByAccomCdeCampusId methods when available
			
			#region AccomBuildingCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AccomBuilding>|AccomBuildingCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AccomBuildingCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AccomBuildingCollection = DataRepository.AccomBuildingProvider.GetByAccomCdeCampusId(transactionManager, entity.AccomCdeCampusId);

				if (deep && entity.AccomBuildingCollection.Count > 0)
				{
					deepHandles.Add("AccomBuildingCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AccomBuilding>) DataRepository.AccomBuildingProvider.DeepLoad,
						new object[] { transactionManager, entity.AccomBuildingCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AccomCdeCampus object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AccomCdeCampus instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AccomCdeCampus Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomCdeCampus entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<AccomBuilding>
				if (CanDeepSave(entity.AccomBuildingCollection, "List<AccomBuilding>|AccomBuildingCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AccomBuilding child in entity.AccomBuildingCollection)
					{
						if(child.AccomCdeCampusIdSource != null)
						{
							child.AccomCdeCampusId = child.AccomCdeCampusIdSource.AccomCdeCampusId;
						}
						else
						{
							child.AccomCdeCampusId = entity.AccomCdeCampusId;
						}

					}

					if (entity.AccomBuildingCollection.Count > 0 || entity.AccomBuildingCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AccomBuildingProvider.Save(transactionManager, entity.AccomBuildingCollection);
						
						deepHandles.Add("AccomBuildingCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AccomBuilding >) DataRepository.AccomBuildingProvider.DeepSave,
							new object[] { transactionManager, entity.AccomBuildingCollection, deepSaveType, childTypes, innerList }
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
	
	#region AccomCdeCampusChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AccomCdeCampus</c>
	///</summary>
	public enum AccomCdeCampusChildEntityTypes
	{
		///<summary>
		/// Collection of <c>AccomCdeCampus</c> as OneToMany for AccomBuildingCollection
		///</summary>
		[ChildEntityType(typeof(TList<AccomBuilding>))]
		AccomBuildingCollection,
	}
	
	#endregion AccomCdeCampusChildEntityTypes
	
	#region AccomCdeCampusFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AccomCdeCampusColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AccomCdeCampus"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AccomCdeCampusFilterBuilder : SqlFilterBuilder<AccomCdeCampusColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AccomCdeCampusFilterBuilder class.
		/// </summary>
		public AccomCdeCampusFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AccomCdeCampusFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AccomCdeCampusFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AccomCdeCampusFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AccomCdeCampusFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AccomCdeCampusFilterBuilder
	
	#region AccomCdeCampusParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AccomCdeCampusColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AccomCdeCampus"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AccomCdeCampusParameterBuilder : ParameterizedSqlFilterBuilder<AccomCdeCampusColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AccomCdeCampusParameterBuilder class.
		/// </summary>
		public AccomCdeCampusParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AccomCdeCampusParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AccomCdeCampusParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AccomCdeCampusParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AccomCdeCampusParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AccomCdeCampusParameterBuilder
	
	#region AccomCdeCampusSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AccomCdeCampusColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AccomCdeCampus"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AccomCdeCampusSortBuilder : SqlSortBuilder<AccomCdeCampusColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AccomCdeCampusSqlSortBuilder class.
		/// </summary>
		public AccomCdeCampusSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AccomCdeCampusSortBuilder
	
} // end namespace
