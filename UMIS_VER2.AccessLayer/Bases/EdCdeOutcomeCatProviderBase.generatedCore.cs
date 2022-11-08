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
	/// This class is the base class for any <see cref="EdCdeOutcomeCatProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdCdeOutcomeCatProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdCdeOutcomeCat, UMIS_VER2.BusinessLyer.EdCdeOutcomeCatKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCdeOutcomeCatKey key)
		{
			return Delete(transactionManager, key.EdCdeOutcomeCatId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edCdeOutcomeCatId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _edCdeOutcomeCatId)
		{
			return Delete(null, _edCdeOutcomeCatId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeOutcomeCatId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _edCdeOutcomeCatId);		
		
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
		public override UMIS_VER2.BusinessLyer.EdCdeOutcomeCat Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCdeOutcomeCatKey key, int start, int pageLength)
		{
			return GetByEdCdeOutcomeCatId(transactionManager, key.EdCdeOutcomeCatId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_CDE_OUTCOME_CAT index.
		/// </summary>
		/// <param name="_edCdeOutcomeCatId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeOutcomeCat"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeOutcomeCat GetByEdCdeOutcomeCatId(System.Int32 _edCdeOutcomeCatId)
		{
			int count = -1;
			return GetByEdCdeOutcomeCatId(null,_edCdeOutcomeCatId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_OUTCOME_CAT index.
		/// </summary>
		/// <param name="_edCdeOutcomeCatId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeOutcomeCat"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeOutcomeCat GetByEdCdeOutcomeCatId(System.Int32 _edCdeOutcomeCatId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCdeOutcomeCatId(null, _edCdeOutcomeCatId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_OUTCOME_CAT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeOutcomeCatId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeOutcomeCat"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeOutcomeCat GetByEdCdeOutcomeCatId(TransactionManager transactionManager, System.Int32 _edCdeOutcomeCatId)
		{
			int count = -1;
			return GetByEdCdeOutcomeCatId(transactionManager, _edCdeOutcomeCatId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_OUTCOME_CAT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeOutcomeCatId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeOutcomeCat"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeOutcomeCat GetByEdCdeOutcomeCatId(TransactionManager transactionManager, System.Int32 _edCdeOutcomeCatId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCdeOutcomeCatId(transactionManager, _edCdeOutcomeCatId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_OUTCOME_CAT index.
		/// </summary>
		/// <param name="_edCdeOutcomeCatId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeOutcomeCat"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeOutcomeCat GetByEdCdeOutcomeCatId(System.Int32 _edCdeOutcomeCatId, int start, int pageLength, out int count)
		{
			return GetByEdCdeOutcomeCatId(null, _edCdeOutcomeCatId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_OUTCOME_CAT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeOutcomeCatId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeOutcomeCat"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdCdeOutcomeCat GetByEdCdeOutcomeCatId(TransactionManager transactionManager, System.Int32 _edCdeOutcomeCatId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdCdeOutcomeCat&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdCdeOutcomeCat&gt;"/></returns>
		public static TList<EdCdeOutcomeCat> Fill(IDataReader reader, TList<EdCdeOutcomeCat> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdCdeOutcomeCat c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdCdeOutcomeCat")
					.Append("|").Append((System.Int32)reader["ED_CDE_OUTCOME_CAT_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdCdeOutcomeCat>(
					key.ToString(), // EntityTrackingKey
					"EdCdeOutcomeCat",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdCdeOutcomeCat();
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
					c.EdCdeOutcomeCatId = (System.Int32)reader["ED_CDE_OUTCOME_CAT_ID"];
					c.OriginalEdCdeOutcomeCatId = c.EdCdeOutcomeCatId;
					c.OcCatAr = (System.String)reader["OC_CAT_AR"];
					c.OcCatEn = (System.String)reader["OC_CAT_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCdeOutcomeCat"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCdeOutcomeCat"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdCdeOutcomeCat entity)
		{
			if (!reader.Read()) return;
			
			entity.EdCdeOutcomeCatId = (System.Int32)reader[((int)EdCdeOutcomeCatColumn.EdCdeOutcomeCatId - 1)];
			entity.OriginalEdCdeOutcomeCatId = (System.Int32)reader["ED_CDE_OUTCOME_CAT_ID"];
			entity.OcCatAr = (System.String)reader[((int)EdCdeOutcomeCatColumn.OcCatAr - 1)];
			entity.OcCatEn = (System.String)reader[((int)EdCdeOutcomeCatColumn.OcCatEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCdeOutcomeCat"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCdeOutcomeCat"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdCdeOutcomeCat entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdCdeOutcomeCatId = (System.Int32)dataRow["ED_CDE_OUTCOME_CAT_ID"];
			entity.OriginalEdCdeOutcomeCatId = (System.Int32)dataRow["ED_CDE_OUTCOME_CAT_ID"];
			entity.OcCatAr = (System.String)dataRow["OC_CAT_AR"];
			entity.OcCatEn = (System.String)dataRow["OC_CAT_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCdeOutcomeCat"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCdeOutcomeCat Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCdeOutcomeCat entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEdCdeOutcomeCatId methods when available
			
			#region EdOutcomeCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdOutcome>|EdOutcomeCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdOutcomeCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdOutcomeCollection = DataRepository.EdOutcomeProvider.GetByEdCdeOutcomeCatId(transactionManager, entity.EdCdeOutcomeCatId);

				if (deep && entity.EdOutcomeCollection.Count > 0)
				{
					deepHandles.Add("EdOutcomeCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdOutcome>) DataRepository.EdOutcomeProvider.DeepLoad,
						new object[] { transactionManager, entity.EdOutcomeCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdCdeOutcomeCat object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdCdeOutcomeCat instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCdeOutcomeCat Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCdeOutcomeCat entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<EdOutcome>
				if (CanDeepSave(entity.EdOutcomeCollection, "List<EdOutcome>|EdOutcomeCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdOutcome child in entity.EdOutcomeCollection)
					{
						if(child.EdCdeOutcomeCatIdSource != null)
						{
							child.EdCdeOutcomeCatId = child.EdCdeOutcomeCatIdSource.EdCdeOutcomeCatId;
						}
						else
						{
							child.EdCdeOutcomeCatId = entity.EdCdeOutcomeCatId;
						}

					}

					if (entity.EdOutcomeCollection.Count > 0 || entity.EdOutcomeCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdOutcomeProvider.Save(transactionManager, entity.EdOutcomeCollection);
						
						deepHandles.Add("EdOutcomeCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdOutcome >) DataRepository.EdOutcomeProvider.DeepSave,
							new object[] { transactionManager, entity.EdOutcomeCollection, deepSaveType, childTypes, innerList }
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
	
	#region EdCdeOutcomeCatChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdCdeOutcomeCat</c>
	///</summary>
	public enum EdCdeOutcomeCatChildEntityTypes
	{
		///<summary>
		/// Collection of <c>EdCdeOutcomeCat</c> as OneToMany for EdOutcomeCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdOutcome>))]
		EdOutcomeCollection,
	}
	
	#endregion EdCdeOutcomeCatChildEntityTypes
	
	#region EdCdeOutcomeCatFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdCdeOutcomeCatColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCdeOutcomeCat"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCdeOutcomeCatFilterBuilder : SqlFilterBuilder<EdCdeOutcomeCatColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCdeOutcomeCatFilterBuilder class.
		/// </summary>
		public EdCdeOutcomeCatFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCdeOutcomeCatFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCdeOutcomeCatFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCdeOutcomeCatFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCdeOutcomeCatFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCdeOutcomeCatFilterBuilder
	
	#region EdCdeOutcomeCatParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdCdeOutcomeCatColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCdeOutcomeCat"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCdeOutcomeCatParameterBuilder : ParameterizedSqlFilterBuilder<EdCdeOutcomeCatColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCdeOutcomeCatParameterBuilder class.
		/// </summary>
		public EdCdeOutcomeCatParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCdeOutcomeCatParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCdeOutcomeCatParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCdeOutcomeCatParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCdeOutcomeCatParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCdeOutcomeCatParameterBuilder
	
	#region EdCdeOutcomeCatSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdCdeOutcomeCatColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCdeOutcomeCat"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdCdeOutcomeCatSortBuilder : SqlSortBuilder<EdCdeOutcomeCatColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCdeOutcomeCatSqlSortBuilder class.
		/// </summary>
		public EdCdeOutcomeCatSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdCdeOutcomeCatSortBuilder
	
} // end namespace
