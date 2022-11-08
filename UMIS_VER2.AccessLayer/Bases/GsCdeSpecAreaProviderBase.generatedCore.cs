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
	/// This class is the base class for any <see cref="GsCdeSpecAreaProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GsCdeSpecAreaProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.GsCdeSpecArea, UMIS_VER2.BusinessLyer.GsCdeSpecAreaKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeSpecAreaKey key)
		{
			return Delete(transactionManager, key.GsCdeSpecAreaId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_gsCdeSpecAreaId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _gsCdeSpecAreaId)
		{
			return Delete(null, _gsCdeSpecAreaId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeSpecAreaId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _gsCdeSpecAreaId);		
		
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
		public override UMIS_VER2.BusinessLyer.GsCdeSpecArea Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeSpecAreaKey key, int start, int pageLength)
		{
			return GetByGsCdeSpecAreaId(transactionManager, key.GsCdeSpecAreaId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_GS_CDE_SPEC_AREA index.
		/// </summary>
		/// <param name="_gsCdeSpecAreaId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeSpecArea"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeSpecArea GetByGsCdeSpecAreaId(System.Decimal _gsCdeSpecAreaId)
		{
			int count = -1;
			return GetByGsCdeSpecAreaId(null,_gsCdeSpecAreaId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_SPEC_AREA index.
		/// </summary>
		/// <param name="_gsCdeSpecAreaId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeSpecArea"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeSpecArea GetByGsCdeSpecAreaId(System.Decimal _gsCdeSpecAreaId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeSpecAreaId(null, _gsCdeSpecAreaId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_SPEC_AREA index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeSpecAreaId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeSpecArea"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeSpecArea GetByGsCdeSpecAreaId(TransactionManager transactionManager, System.Decimal _gsCdeSpecAreaId)
		{
			int count = -1;
			return GetByGsCdeSpecAreaId(transactionManager, _gsCdeSpecAreaId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_SPEC_AREA index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeSpecAreaId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeSpecArea"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeSpecArea GetByGsCdeSpecAreaId(TransactionManager transactionManager, System.Decimal _gsCdeSpecAreaId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeSpecAreaId(transactionManager, _gsCdeSpecAreaId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_SPEC_AREA index.
		/// </summary>
		/// <param name="_gsCdeSpecAreaId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeSpecArea"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeSpecArea GetByGsCdeSpecAreaId(System.Decimal _gsCdeSpecAreaId, int start, int pageLength, out int count)
		{
			return GetByGsCdeSpecAreaId(null, _gsCdeSpecAreaId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_SPEC_AREA index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeSpecAreaId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeSpecArea"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsCdeSpecArea GetByGsCdeSpecAreaId(TransactionManager transactionManager, System.Decimal _gsCdeSpecAreaId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GsCdeSpecArea&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GsCdeSpecArea&gt;"/></returns>
		public static TList<GsCdeSpecArea> Fill(IDataReader reader, TList<GsCdeSpecArea> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.GsCdeSpecArea c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GsCdeSpecArea")
					.Append("|").Append((System.Decimal)reader["GS_CDE_SPEC_AREA_ID"]).ToString();
					c = EntityManager.LocateOrCreate<GsCdeSpecArea>(
					key.ToString(), // EntityTrackingKey
					"GsCdeSpecArea",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.GsCdeSpecArea();
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
					c.GsCdeSpecAreaId = (System.Decimal)reader["GS_CDE_SPEC_AREA_ID"];
					c.OriginalGsCdeSpecAreaId = c.GsCdeSpecAreaId;
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCdeSpecArea"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCdeSpecArea"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.GsCdeSpecArea entity)
		{
			if (!reader.Read()) return;
			
			entity.GsCdeSpecAreaId = (System.Decimal)reader[((int)GsCdeSpecAreaColumn.GsCdeSpecAreaId - 1)];
			entity.OriginalGsCdeSpecAreaId = (System.Decimal)reader["GS_CDE_SPEC_AREA_ID"];
			entity.DescrAr = (System.String)reader[((int)GsCdeSpecAreaColumn.DescrAr - 1)];
			entity.DescrEn = (System.String)reader[((int)GsCdeSpecAreaColumn.DescrEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCdeSpecArea"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCdeSpecArea"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.GsCdeSpecArea entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.GsCdeSpecAreaId = (System.Decimal)dataRow["GS_CDE_SPEC_AREA_ID"];
			entity.OriginalGsCdeSpecAreaId = (System.Decimal)dataRow["GS_CDE_SPEC_AREA_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCdeSpecArea"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCdeSpecArea Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeSpecArea entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByGsCdeSpecAreaId methods when available
			
			#region EntityMainCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntityMain>|EntityMainCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntityMainCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntityMainCollection = DataRepository.EntityMainProvider.GetByGsCdeSpecAreaId(transactionManager, entity.GsCdeSpecAreaId);

				if (deep && entity.EntityMainCollection.Count > 0)
				{
					deepHandles.Add("EntityMainCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntityMain>) DataRepository.EntityMainProvider.DeepLoad,
						new object[] { transactionManager, entity.EntityMainCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.GsCdeSpecArea object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.GsCdeSpecArea instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCdeSpecArea Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeSpecArea entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<EntityMain>
				if (CanDeepSave(entity.EntityMainCollection, "List<EntityMain>|EntityMainCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntityMain child in entity.EntityMainCollection)
					{
						if(child.GsCdeSpecAreaIdSource != null)
						{
							child.GsCdeSpecAreaId = child.GsCdeSpecAreaIdSource.GsCdeSpecAreaId;
						}
						else
						{
							child.GsCdeSpecAreaId = entity.GsCdeSpecAreaId;
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
	
	#region GsCdeSpecAreaChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.GsCdeSpecArea</c>
	///</summary>
	public enum GsCdeSpecAreaChildEntityTypes
	{
		///<summary>
		/// Collection of <c>GsCdeSpecArea</c> as OneToMany for EntityMainCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntityMain>))]
		EntityMainCollection,
	}
	
	#endregion GsCdeSpecAreaChildEntityTypes
	
	#region GsCdeSpecAreaFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GsCdeSpecAreaColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCdeSpecArea"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCdeSpecAreaFilterBuilder : SqlFilterBuilder<GsCdeSpecAreaColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCdeSpecAreaFilterBuilder class.
		/// </summary>
		public GsCdeSpecAreaFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCdeSpecAreaFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCdeSpecAreaFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCdeSpecAreaFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCdeSpecAreaFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCdeSpecAreaFilterBuilder
	
	#region GsCdeSpecAreaParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GsCdeSpecAreaColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCdeSpecArea"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCdeSpecAreaParameterBuilder : ParameterizedSqlFilterBuilder<GsCdeSpecAreaColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCdeSpecAreaParameterBuilder class.
		/// </summary>
		public GsCdeSpecAreaParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCdeSpecAreaParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCdeSpecAreaParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCdeSpecAreaParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCdeSpecAreaParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCdeSpecAreaParameterBuilder
	
	#region GsCdeSpecAreaSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GsCdeSpecAreaColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCdeSpecArea"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GsCdeSpecAreaSortBuilder : SqlSortBuilder<GsCdeSpecAreaColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCdeSpecAreaSqlSortBuilder class.
		/// </summary>
		public GsCdeSpecAreaSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GsCdeSpecAreaSortBuilder
	
} // end namespace
