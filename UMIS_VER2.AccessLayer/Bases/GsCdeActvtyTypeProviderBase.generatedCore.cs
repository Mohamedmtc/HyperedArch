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
	/// This class is the base class for any <see cref="GsCdeActvtyTypeProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GsCdeActvtyTypeProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.GsCdeActvtyType, UMIS_VER2.BusinessLyer.GsCdeActvtyTypeKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeActvtyTypeKey key)
		{
			return Delete(transactionManager, key.GsCdeActvtyTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_gsCdeActvtyTypeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _gsCdeActvtyTypeId)
		{
			return Delete(null, _gsCdeActvtyTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeActvtyTypeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _gsCdeActvtyTypeId);		
		
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
		public override UMIS_VER2.BusinessLyer.GsCdeActvtyType Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeActvtyTypeKey key, int start, int pageLength)
		{
			return GetByGsCdeActvtyTypeId(transactionManager, key.GsCdeActvtyTypeId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_GS_CDE_ACTVTY_TYPE index.
		/// </summary>
		/// <param name="_gsCdeActvtyTypeId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeActvtyType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeActvtyType GetByGsCdeActvtyTypeId(System.Int32 _gsCdeActvtyTypeId)
		{
			int count = -1;
			return GetByGsCdeActvtyTypeId(null,_gsCdeActvtyTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_ACTVTY_TYPE index.
		/// </summary>
		/// <param name="_gsCdeActvtyTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeActvtyType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeActvtyType GetByGsCdeActvtyTypeId(System.Int32 _gsCdeActvtyTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeActvtyTypeId(null, _gsCdeActvtyTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_ACTVTY_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeActvtyTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeActvtyType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeActvtyType GetByGsCdeActvtyTypeId(TransactionManager transactionManager, System.Int32 _gsCdeActvtyTypeId)
		{
			int count = -1;
			return GetByGsCdeActvtyTypeId(transactionManager, _gsCdeActvtyTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_ACTVTY_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeActvtyTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeActvtyType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeActvtyType GetByGsCdeActvtyTypeId(TransactionManager transactionManager, System.Int32 _gsCdeActvtyTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeActvtyTypeId(transactionManager, _gsCdeActvtyTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_ACTVTY_TYPE index.
		/// </summary>
		/// <param name="_gsCdeActvtyTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeActvtyType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeActvtyType GetByGsCdeActvtyTypeId(System.Int32 _gsCdeActvtyTypeId, int start, int pageLength, out int count)
		{
			return GetByGsCdeActvtyTypeId(null, _gsCdeActvtyTypeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_ACTVTY_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeActvtyTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeActvtyType"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsCdeActvtyType GetByGsCdeActvtyTypeId(TransactionManager transactionManager, System.Int32 _gsCdeActvtyTypeId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GsCdeActvtyType&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GsCdeActvtyType&gt;"/></returns>
		public static TList<GsCdeActvtyType> Fill(IDataReader reader, TList<GsCdeActvtyType> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.GsCdeActvtyType c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GsCdeActvtyType")
					.Append("|").Append((System.Int32)reader["GS_CDE_ACTVTY_TYPE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<GsCdeActvtyType>(
					key.ToString(), // EntityTrackingKey
					"GsCdeActvtyType",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.GsCdeActvtyType();
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
					c.GsCdeActvtyTypeId = (System.Int32)reader["GS_CDE_ACTVTY_TYPE_ID"];
					c.OriginalGsCdeActvtyTypeId = c.GsCdeActvtyTypeId;
					c.ActvtyTypeAr = (System.String)reader["ACTVTY_TYPE_AR"];
					c.ActvtyTypeEn = (System.String)reader["ACTVTY_TYPE_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCdeActvtyType"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCdeActvtyType"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.GsCdeActvtyType entity)
		{
			if (!reader.Read()) return;
			
			entity.GsCdeActvtyTypeId = (System.Int32)reader[((int)GsCdeActvtyTypeColumn.GsCdeActvtyTypeId - 1)];
			entity.OriginalGsCdeActvtyTypeId = (System.Int32)reader["GS_CDE_ACTVTY_TYPE_ID"];
			entity.ActvtyTypeAr = (System.String)reader[((int)GsCdeActvtyTypeColumn.ActvtyTypeAr - 1)];
			entity.ActvtyTypeEn = (System.String)reader[((int)GsCdeActvtyTypeColumn.ActvtyTypeEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCdeActvtyType"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCdeActvtyType"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.GsCdeActvtyType entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.GsCdeActvtyTypeId = (System.Int32)dataRow["GS_CDE_ACTVTY_TYPE_ID"];
			entity.OriginalGsCdeActvtyTypeId = (System.Int32)dataRow["GS_CDE_ACTVTY_TYPE_ID"];
			entity.ActvtyTypeAr = (System.String)dataRow["ACTVTY_TYPE_AR"];
			entity.ActvtyTypeEn = (System.String)dataRow["ACTVTY_TYPE_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCdeActvtyType"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCdeActvtyType Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeActvtyType entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByGsCdeActvtyTypeId methods when available
			
			#region GsCdeActvtyCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GsCdeActvty>|GsCdeActvtyCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCdeActvtyCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GsCdeActvtyCollection = DataRepository.GsCdeActvtyProvider.GetByGsCdeActvtyTypeId(transactionManager, entity.GsCdeActvtyTypeId);

				if (deep && entity.GsCdeActvtyCollection.Count > 0)
				{
					deepHandles.Add("GsCdeActvtyCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GsCdeActvty>) DataRepository.GsCdeActvtyProvider.DeepLoad,
						new object[] { transactionManager, entity.GsCdeActvtyCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudActivityCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudActivity>|EdStudActivityCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudActivityCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudActivityCollection = DataRepository.EdStudActivityProvider.GetByGsCdeActvtyTypeId(transactionManager, entity.GsCdeActvtyTypeId);

				if (deep && entity.EdStudActivityCollection.Count > 0)
				{
					deepHandles.Add("EdStudActivityCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudActivity>) DataRepository.EdStudActivityProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudActivityCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.GsCdeActvtyType object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.GsCdeActvtyType instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCdeActvtyType Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeActvtyType entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<GsCdeActvty>
				if (CanDeepSave(entity.GsCdeActvtyCollection, "List<GsCdeActvty>|GsCdeActvtyCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GsCdeActvty child in entity.GsCdeActvtyCollection)
					{
						if(child.GsCdeActvtyTypeIdSource != null)
						{
							child.GsCdeActvtyTypeId = child.GsCdeActvtyTypeIdSource.GsCdeActvtyTypeId;
						}
						else
						{
							child.GsCdeActvtyTypeId = entity.GsCdeActvtyTypeId;
						}

					}

					if (entity.GsCdeActvtyCollection.Count > 0 || entity.GsCdeActvtyCollection.DeletedItems.Count > 0)
					{
						//DataRepository.GsCdeActvtyProvider.Save(transactionManager, entity.GsCdeActvtyCollection);
						
						deepHandles.Add("GsCdeActvtyCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< GsCdeActvty >) DataRepository.GsCdeActvtyProvider.DeepSave,
							new object[] { transactionManager, entity.GsCdeActvtyCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudActivity>
				if (CanDeepSave(entity.EdStudActivityCollection, "List<EdStudActivity>|EdStudActivityCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudActivity child in entity.EdStudActivityCollection)
					{
						if(child.GsCdeActvtyTypeIdSource != null)
						{
							child.GsCdeActvtyTypeId = child.GsCdeActvtyTypeIdSource.GsCdeActvtyTypeId;
						}
						else
						{
							child.GsCdeActvtyTypeId = entity.GsCdeActvtyTypeId;
						}

					}

					if (entity.EdStudActivityCollection.Count > 0 || entity.EdStudActivityCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudActivityProvider.Save(transactionManager, entity.EdStudActivityCollection);
						
						deepHandles.Add("EdStudActivityCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudActivity >) DataRepository.EdStudActivityProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudActivityCollection, deepSaveType, childTypes, innerList }
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
	
	#region GsCdeActvtyTypeChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.GsCdeActvtyType</c>
	///</summary>
	public enum GsCdeActvtyTypeChildEntityTypes
	{
		///<summary>
		/// Collection of <c>GsCdeActvtyType</c> as OneToMany for GsCdeActvtyCollection
		///</summary>
		[ChildEntityType(typeof(TList<GsCdeActvty>))]
		GsCdeActvtyCollection,
		///<summary>
		/// Collection of <c>GsCdeActvtyType</c> as OneToMany for EdStudActivityCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudActivity>))]
		EdStudActivityCollection,
	}
	
	#endregion GsCdeActvtyTypeChildEntityTypes
	
	#region GsCdeActvtyTypeFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GsCdeActvtyTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCdeActvtyType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCdeActvtyTypeFilterBuilder : SqlFilterBuilder<GsCdeActvtyTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCdeActvtyTypeFilterBuilder class.
		/// </summary>
		public GsCdeActvtyTypeFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCdeActvtyTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCdeActvtyTypeFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCdeActvtyTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCdeActvtyTypeFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCdeActvtyTypeFilterBuilder
	
	#region GsCdeActvtyTypeParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GsCdeActvtyTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCdeActvtyType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCdeActvtyTypeParameterBuilder : ParameterizedSqlFilterBuilder<GsCdeActvtyTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCdeActvtyTypeParameterBuilder class.
		/// </summary>
		public GsCdeActvtyTypeParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCdeActvtyTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCdeActvtyTypeParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCdeActvtyTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCdeActvtyTypeParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCdeActvtyTypeParameterBuilder
	
	#region GsCdeActvtyTypeSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GsCdeActvtyTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCdeActvtyType"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GsCdeActvtyTypeSortBuilder : SqlSortBuilder<GsCdeActvtyTypeColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCdeActvtyTypeSqlSortBuilder class.
		/// </summary>
		public GsCdeActvtyTypeSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GsCdeActvtyTypeSortBuilder
	
} // end namespace
