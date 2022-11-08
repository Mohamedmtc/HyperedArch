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
	/// This class is the base class for any <see cref="GsCdeSchoolTypeProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GsCdeSchoolTypeProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.GsCdeSchoolType, UMIS_VER2.BusinessLyer.GsCdeSchoolTypeKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeSchoolTypeKey key)
		{
			return Delete(transactionManager, key.GsCdeSchoolTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_gsCdeSchoolTypeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _gsCdeSchoolTypeId)
		{
			return Delete(null, _gsCdeSchoolTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeSchoolTypeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _gsCdeSchoolTypeId);		
		
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
		public override UMIS_VER2.BusinessLyer.GsCdeSchoolType Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeSchoolTypeKey key, int start, int pageLength)
		{
			return GetByGsCdeSchoolTypeId(transactionManager, key.GsCdeSchoolTypeId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_GS_CDE_SCHOOL_TYPE index.
		/// </summary>
		/// <param name="_gsCdeSchoolTypeId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeSchoolType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeSchoolType GetByGsCdeSchoolTypeId(System.Int32 _gsCdeSchoolTypeId)
		{
			int count = -1;
			return GetByGsCdeSchoolTypeId(null,_gsCdeSchoolTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_SCHOOL_TYPE index.
		/// </summary>
		/// <param name="_gsCdeSchoolTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeSchoolType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeSchoolType GetByGsCdeSchoolTypeId(System.Int32 _gsCdeSchoolTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeSchoolTypeId(null, _gsCdeSchoolTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_SCHOOL_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeSchoolTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeSchoolType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeSchoolType GetByGsCdeSchoolTypeId(TransactionManager transactionManager, System.Int32 _gsCdeSchoolTypeId)
		{
			int count = -1;
			return GetByGsCdeSchoolTypeId(transactionManager, _gsCdeSchoolTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_SCHOOL_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeSchoolTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeSchoolType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeSchoolType GetByGsCdeSchoolTypeId(TransactionManager transactionManager, System.Int32 _gsCdeSchoolTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeSchoolTypeId(transactionManager, _gsCdeSchoolTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_SCHOOL_TYPE index.
		/// </summary>
		/// <param name="_gsCdeSchoolTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeSchoolType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeSchoolType GetByGsCdeSchoolTypeId(System.Int32 _gsCdeSchoolTypeId, int start, int pageLength, out int count)
		{
			return GetByGsCdeSchoolTypeId(null, _gsCdeSchoolTypeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_SCHOOL_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeSchoolTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeSchoolType"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsCdeSchoolType GetByGsCdeSchoolTypeId(TransactionManager transactionManager, System.Int32 _gsCdeSchoolTypeId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GsCdeSchoolType&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GsCdeSchoolType&gt;"/></returns>
		public static TList<GsCdeSchoolType> Fill(IDataReader reader, TList<GsCdeSchoolType> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.GsCdeSchoolType c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GsCdeSchoolType")
					.Append("|").Append((System.Int32)reader["GS_CDE_SCHOOL_TYPE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<GsCdeSchoolType>(
					key.ToString(), // EntityTrackingKey
					"GsCdeSchoolType",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.GsCdeSchoolType();
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
					c.GsCdeSchoolTypeId = (System.Int32)reader["GS_CDE_SCHOOL_TYPE_ID"];
					c.OriginalGsCdeSchoolTypeId = c.GsCdeSchoolTypeId;
					c.SchoolTypeAr = Convert.IsDBNull(reader["SCHOOL_TYPE_AR"]) ? null : (System.String)reader["SCHOOL_TYPE_AR"];
					c.SchoolTypeEn = Convert.IsDBNull(reader["SCHOOL_TYPE_EN"]) ? null : (System.String)reader["SCHOOL_TYPE_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCdeSchoolType"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCdeSchoolType"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.GsCdeSchoolType entity)
		{
			if (!reader.Read()) return;
			
			entity.GsCdeSchoolTypeId = (System.Int32)reader[((int)GsCdeSchoolTypeColumn.GsCdeSchoolTypeId - 1)];
			entity.OriginalGsCdeSchoolTypeId = (System.Int32)reader["GS_CDE_SCHOOL_TYPE_ID"];
			entity.SchoolTypeAr = (reader.IsDBNull(((int)GsCdeSchoolTypeColumn.SchoolTypeAr - 1)))?null:(System.String)reader[((int)GsCdeSchoolTypeColumn.SchoolTypeAr - 1)];
			entity.SchoolTypeEn = (reader.IsDBNull(((int)GsCdeSchoolTypeColumn.SchoolTypeEn - 1)))?null:(System.String)reader[((int)GsCdeSchoolTypeColumn.SchoolTypeEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCdeSchoolType"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCdeSchoolType"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.GsCdeSchoolType entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.GsCdeSchoolTypeId = (System.Int32)dataRow["GS_CDE_SCHOOL_TYPE_ID"];
			entity.OriginalGsCdeSchoolTypeId = (System.Int32)dataRow["GS_CDE_SCHOOL_TYPE_ID"];
			entity.SchoolTypeAr = Convert.IsDBNull(dataRow["SCHOOL_TYPE_AR"]) ? null : (System.String)dataRow["SCHOOL_TYPE_AR"];
			entity.SchoolTypeEn = Convert.IsDBNull(dataRow["SCHOOL_TYPE_EN"]) ? null : (System.String)dataRow["SCHOOL_TYPE_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCdeSchoolType"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCdeSchoolType Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeSchoolType entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByGsCdeSchoolTypeId methods when available
			
			#region EdStudQualCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudQual>|EdStudQualCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudQualCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudQualCollection = DataRepository.EdStudQualProvider.GetByGsCdeSchoolTypeId(transactionManager, entity.GsCdeSchoolTypeId);

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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.GsCdeSchoolType object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.GsCdeSchoolType instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCdeSchoolType Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeSchoolType entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<EdStudQual>
				if (CanDeepSave(entity.EdStudQualCollection, "List<EdStudQual>|EdStudQualCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudQual child in entity.EdStudQualCollection)
					{
						if(child.GsCdeSchoolTypeIdSource != null)
						{
							child.GsCdeSchoolTypeId = child.GsCdeSchoolTypeIdSource.GsCdeSchoolTypeId;
						}
						else
						{
							child.GsCdeSchoolTypeId = entity.GsCdeSchoolTypeId;
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
	
	#region GsCdeSchoolTypeChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.GsCdeSchoolType</c>
	///</summary>
	public enum GsCdeSchoolTypeChildEntityTypes
	{
		///<summary>
		/// Collection of <c>GsCdeSchoolType</c> as OneToMany for EdStudQualCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudQual>))]
		EdStudQualCollection,
	}
	
	#endregion GsCdeSchoolTypeChildEntityTypes
	
	#region GsCdeSchoolTypeFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GsCdeSchoolTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCdeSchoolType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCdeSchoolTypeFilterBuilder : SqlFilterBuilder<GsCdeSchoolTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCdeSchoolTypeFilterBuilder class.
		/// </summary>
		public GsCdeSchoolTypeFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCdeSchoolTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCdeSchoolTypeFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCdeSchoolTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCdeSchoolTypeFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCdeSchoolTypeFilterBuilder
	
	#region GsCdeSchoolTypeParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GsCdeSchoolTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCdeSchoolType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCdeSchoolTypeParameterBuilder : ParameterizedSqlFilterBuilder<GsCdeSchoolTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCdeSchoolTypeParameterBuilder class.
		/// </summary>
		public GsCdeSchoolTypeParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCdeSchoolTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCdeSchoolTypeParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCdeSchoolTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCdeSchoolTypeParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCdeSchoolTypeParameterBuilder
	
	#region GsCdeSchoolTypeSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GsCdeSchoolTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCdeSchoolType"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GsCdeSchoolTypeSortBuilder : SqlSortBuilder<GsCdeSchoolTypeColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCdeSchoolTypeSqlSortBuilder class.
		/// </summary>
		public GsCdeSchoolTypeSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GsCdeSchoolTypeSortBuilder
	
} // end namespace
