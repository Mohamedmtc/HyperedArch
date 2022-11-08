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
	/// This class is the base class for any <see cref="GsCdeViolCatProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GsCdeViolCatProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.GsCdeViolCat, UMIS_VER2.BusinessLyer.GsCdeViolCatKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeViolCatKey key)
		{
			return Delete(transactionManager, key.GsCdeViolCatId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_gsCdeViolCatId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _gsCdeViolCatId)
		{
			return Delete(null, _gsCdeViolCatId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeViolCatId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _gsCdeViolCatId);		
		
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
		public override UMIS_VER2.BusinessLyer.GsCdeViolCat Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeViolCatKey key, int start, int pageLength)
		{
			return GetByGsCdeViolCatId(transactionManager, key.GsCdeViolCatId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_GS_CDE_VIOL_CAT index.
		/// </summary>
		/// <param name="_gsCdeViolCatId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeViolCat"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeViolCat GetByGsCdeViolCatId(System.Decimal _gsCdeViolCatId)
		{
			int count = -1;
			return GetByGsCdeViolCatId(null,_gsCdeViolCatId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_VIOL_CAT index.
		/// </summary>
		/// <param name="_gsCdeViolCatId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeViolCat"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeViolCat GetByGsCdeViolCatId(System.Decimal _gsCdeViolCatId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeViolCatId(null, _gsCdeViolCatId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_VIOL_CAT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeViolCatId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeViolCat"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeViolCat GetByGsCdeViolCatId(TransactionManager transactionManager, System.Decimal _gsCdeViolCatId)
		{
			int count = -1;
			return GetByGsCdeViolCatId(transactionManager, _gsCdeViolCatId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_VIOL_CAT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeViolCatId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeViolCat"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeViolCat GetByGsCdeViolCatId(TransactionManager transactionManager, System.Decimal _gsCdeViolCatId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeViolCatId(transactionManager, _gsCdeViolCatId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_VIOL_CAT index.
		/// </summary>
		/// <param name="_gsCdeViolCatId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeViolCat"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeViolCat GetByGsCdeViolCatId(System.Decimal _gsCdeViolCatId, int start, int pageLength, out int count)
		{
			return GetByGsCdeViolCatId(null, _gsCdeViolCatId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_VIOL_CAT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeViolCatId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeViolCat"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsCdeViolCat GetByGsCdeViolCatId(TransactionManager transactionManager, System.Decimal _gsCdeViolCatId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GsCdeViolCat&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GsCdeViolCat&gt;"/></returns>
		public static TList<GsCdeViolCat> Fill(IDataReader reader, TList<GsCdeViolCat> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.GsCdeViolCat c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GsCdeViolCat")
					.Append("|").Append((System.Decimal)reader["GS_CDE_VIOL_CAT_ID"]).ToString();
					c = EntityManager.LocateOrCreate<GsCdeViolCat>(
					key.ToString(), // EntityTrackingKey
					"GsCdeViolCat",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.GsCdeViolCat();
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
					c.GsCdeViolCatId = (System.Decimal)reader["GS_CDE_VIOL_CAT_ID"];
					c.OriginalGsCdeViolCatId = c.GsCdeViolCatId;
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCdeViolCat"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCdeViolCat"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.GsCdeViolCat entity)
		{
			if (!reader.Read()) return;
			
			entity.GsCdeViolCatId = (System.Decimal)reader[((int)GsCdeViolCatColumn.GsCdeViolCatId - 1)];
			entity.OriginalGsCdeViolCatId = (System.Decimal)reader["GS_CDE_VIOL_CAT_ID"];
			entity.DescrAr = (System.String)reader[((int)GsCdeViolCatColumn.DescrAr - 1)];
			entity.DescrEn = (System.String)reader[((int)GsCdeViolCatColumn.DescrEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCdeViolCat"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCdeViolCat"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.GsCdeViolCat entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.GsCdeViolCatId = (System.Decimal)dataRow["GS_CDE_VIOL_CAT_ID"];
			entity.OriginalGsCdeViolCatId = (System.Decimal)dataRow["GS_CDE_VIOL_CAT_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCdeViolCat"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCdeViolCat Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeViolCat entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByGsCdeViolCatId methods when available
			
			#region EdStudViolCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudViol>|EdStudViolCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudViolCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudViolCollection = DataRepository.EdStudViolProvider.GetByGsCdeViolCatId(transactionManager, entity.GsCdeViolCatId);

				if (deep && entity.EdStudViolCollection.Count > 0)
				{
					deepHandles.Add("EdStudViolCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudViol>) DataRepository.EdStudViolProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudViolCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region GsCdeViolCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GsCdeViol>|GsCdeViolCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCdeViolCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GsCdeViolCollection = DataRepository.GsCdeViolProvider.GetByGsCdeViolCatId(transactionManager, entity.GsCdeViolCatId);

				if (deep && entity.GsCdeViolCollection.Count > 0)
				{
					deepHandles.Add("GsCdeViolCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GsCdeViol>) DataRepository.GsCdeViolProvider.DeepLoad,
						new object[] { transactionManager, entity.GsCdeViolCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.GsCdeViolCat object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.GsCdeViolCat instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCdeViolCat Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeViolCat entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
						if(child.GsCdeViolCatIdSource != null)
						{
							child.GsCdeViolCatId = child.GsCdeViolCatIdSource.GsCdeViolCatId;
						}
						else
						{
							child.GsCdeViolCatId = entity.GsCdeViolCatId;
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
				
	
			#region List<GsCdeViol>
				if (CanDeepSave(entity.GsCdeViolCollection, "List<GsCdeViol>|GsCdeViolCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GsCdeViol child in entity.GsCdeViolCollection)
					{
						if(child.GsCdeViolCatIdSource != null)
						{
							child.GsCdeViolCatId = child.GsCdeViolCatIdSource.GsCdeViolCatId;
						}
						else
						{
							child.GsCdeViolCatId = entity.GsCdeViolCatId;
						}

					}

					if (entity.GsCdeViolCollection.Count > 0 || entity.GsCdeViolCollection.DeletedItems.Count > 0)
					{
						//DataRepository.GsCdeViolProvider.Save(transactionManager, entity.GsCdeViolCollection);
						
						deepHandles.Add("GsCdeViolCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< GsCdeViol >) DataRepository.GsCdeViolProvider.DeepSave,
							new object[] { transactionManager, entity.GsCdeViolCollection, deepSaveType, childTypes, innerList }
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
	
	#region GsCdeViolCatChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.GsCdeViolCat</c>
	///</summary>
	public enum GsCdeViolCatChildEntityTypes
	{
		///<summary>
		/// Collection of <c>GsCdeViolCat</c> as OneToMany for EdStudViolCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudViol>))]
		EdStudViolCollection,
		///<summary>
		/// Collection of <c>GsCdeViolCat</c> as OneToMany for GsCdeViolCollection
		///</summary>
		[ChildEntityType(typeof(TList<GsCdeViol>))]
		GsCdeViolCollection,
	}
	
	#endregion GsCdeViolCatChildEntityTypes
	
	#region GsCdeViolCatFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GsCdeViolCatColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCdeViolCat"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCdeViolCatFilterBuilder : SqlFilterBuilder<GsCdeViolCatColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCdeViolCatFilterBuilder class.
		/// </summary>
		public GsCdeViolCatFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCdeViolCatFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCdeViolCatFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCdeViolCatFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCdeViolCatFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCdeViolCatFilterBuilder
	
	#region GsCdeViolCatParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GsCdeViolCatColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCdeViolCat"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCdeViolCatParameterBuilder : ParameterizedSqlFilterBuilder<GsCdeViolCatColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCdeViolCatParameterBuilder class.
		/// </summary>
		public GsCdeViolCatParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCdeViolCatParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCdeViolCatParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCdeViolCatParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCdeViolCatParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCdeViolCatParameterBuilder
	
	#region GsCdeViolCatSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GsCdeViolCatColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCdeViolCat"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GsCdeViolCatSortBuilder : SqlSortBuilder<GsCdeViolCatColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCdeViolCatSqlSortBuilder class.
		/// </summary>
		public GsCdeViolCatSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GsCdeViolCatSortBuilder
	
} // end namespace
