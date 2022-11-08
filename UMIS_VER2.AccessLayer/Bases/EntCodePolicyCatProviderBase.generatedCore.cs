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
	/// This class is the base class for any <see cref="EntCodePolicyCatProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EntCodePolicyCatProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EntCodePolicyCat, UMIS_VER2.BusinessLyer.EntCodePolicyCatKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntCodePolicyCatKey key)
		{
			return Delete(transactionManager, key.EntCodePolicyCatId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_entCodePolicyCatId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _entCodePolicyCatId)
		{
			return Delete(null, _entCodePolicyCatId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodePolicyCatId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _entCodePolicyCatId);		
		
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
		public override UMIS_VER2.BusinessLyer.EntCodePolicyCat Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntCodePolicyCatKey key, int start, int pageLength)
		{
			return GetByEntCodePolicyCatId(transactionManager, key.EntCodePolicyCatId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ENT_CODE_POLICY_CAT index.
		/// </summary>
		/// <param name="_entCodePolicyCatId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntCodePolicyCat"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntCodePolicyCat GetByEntCodePolicyCatId(System.Decimal _entCodePolicyCatId)
		{
			int count = -1;
			return GetByEntCodePolicyCatId(null,_entCodePolicyCatId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_CODE_POLICY_CAT index.
		/// </summary>
		/// <param name="_entCodePolicyCatId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntCodePolicyCat"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntCodePolicyCat GetByEntCodePolicyCatId(System.Decimal _entCodePolicyCatId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntCodePolicyCatId(null, _entCodePolicyCatId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_CODE_POLICY_CAT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodePolicyCatId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntCodePolicyCat"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntCodePolicyCat GetByEntCodePolicyCatId(TransactionManager transactionManager, System.Decimal _entCodePolicyCatId)
		{
			int count = -1;
			return GetByEntCodePolicyCatId(transactionManager, _entCodePolicyCatId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_CODE_POLICY_CAT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodePolicyCatId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntCodePolicyCat"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntCodePolicyCat GetByEntCodePolicyCatId(TransactionManager transactionManager, System.Decimal _entCodePolicyCatId, int start, int pageLength)
		{
			int count = -1;
			return GetByEntCodePolicyCatId(transactionManager, _entCodePolicyCatId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_CODE_POLICY_CAT index.
		/// </summary>
		/// <param name="_entCodePolicyCatId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntCodePolicyCat"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EntCodePolicyCat GetByEntCodePolicyCatId(System.Decimal _entCodePolicyCatId, int start, int pageLength, out int count)
		{
			return GetByEntCodePolicyCatId(null, _entCodePolicyCatId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ENT_CODE_POLICY_CAT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_entCodePolicyCatId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EntCodePolicyCat"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EntCodePolicyCat GetByEntCodePolicyCatId(TransactionManager transactionManager, System.Decimal _entCodePolicyCatId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EntCodePolicyCat&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EntCodePolicyCat&gt;"/></returns>
		public static TList<EntCodePolicyCat> Fill(IDataReader reader, TList<EntCodePolicyCat> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EntCodePolicyCat c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EntCodePolicyCat")
					.Append("|").Append((System.Decimal)reader["ENT_CODE_POLICY_CAT_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EntCodePolicyCat>(
					key.ToString(), // EntityTrackingKey
					"EntCodePolicyCat",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EntCodePolicyCat();
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
					c.EntCodePolicyCatId = (System.Decimal)reader["ENT_CODE_POLICY_CAT_ID"];
					c.OriginalEntCodePolicyCatId = c.EntCodePolicyCatId;
					c.DescrEn = Convert.IsDBNull(reader["DESCR_EN"]) ? null : (System.String)reader["DESCR_EN"];
					c.DescrAr = (System.String)reader["DESCR_AR"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntCodePolicyCat"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntCodePolicyCat"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EntCodePolicyCat entity)
		{
			if (!reader.Read()) return;
			
			entity.EntCodePolicyCatId = (System.Decimal)reader[((int)EntCodePolicyCatColumn.EntCodePolicyCatId - 1)];
			entity.OriginalEntCodePolicyCatId = (System.Decimal)reader["ENT_CODE_POLICY_CAT_ID"];
			entity.DescrEn = (reader.IsDBNull(((int)EntCodePolicyCatColumn.DescrEn - 1)))?null:(System.String)reader[((int)EntCodePolicyCatColumn.DescrEn - 1)];
			entity.DescrAr = (System.String)reader[((int)EntCodePolicyCatColumn.DescrAr - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EntCodePolicyCat"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntCodePolicyCat"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EntCodePolicyCat entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EntCodePolicyCatId = (System.Decimal)dataRow["ENT_CODE_POLICY_CAT_ID"];
			entity.OriginalEntCodePolicyCatId = (System.Decimal)dataRow["ENT_CODE_POLICY_CAT_ID"];
			entity.DescrEn = Convert.IsDBNull(dataRow["DESCR_EN"]) ? null : (System.String)dataRow["DESCR_EN"];
			entity.DescrAr = (System.String)dataRow["DESCR_AR"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EntCodePolicyCat"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntCodePolicyCat Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntCodePolicyCat entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEntCodePolicyCatId methods when available
			
			#region EntCodePolicyMetadataCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntCodePolicyMetadata>|EntCodePolicyMetadataCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntCodePolicyMetadataCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntCodePolicyMetadataCollection = DataRepository.EntCodePolicyMetadataProvider.GetByEntCodePolicyCatId(transactionManager, entity.EntCodePolicyCatId);

				if (deep && entity.EntCodePolicyMetadataCollection.Count > 0)
				{
					deepHandles.Add("EntCodePolicyMetadataCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntCodePolicyMetadata>) DataRepository.EntCodePolicyMetadataProvider.DeepLoad,
						new object[] { transactionManager, entity.EntCodePolicyMetadataCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EntCodePolicyCat object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EntCodePolicyCat instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EntCodePolicyCat Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EntCodePolicyCat entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<EntCodePolicyMetadata>
				if (CanDeepSave(entity.EntCodePolicyMetadataCollection, "List<EntCodePolicyMetadata>|EntCodePolicyMetadataCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntCodePolicyMetadata child in entity.EntCodePolicyMetadataCollection)
					{
						if(child.EntCodePolicyCatIdSource != null)
						{
							child.EntCodePolicyCatId = child.EntCodePolicyCatIdSource.EntCodePolicyCatId;
						}
						else
						{
							child.EntCodePolicyCatId = entity.EntCodePolicyCatId;
						}

					}

					if (entity.EntCodePolicyMetadataCollection.Count > 0 || entity.EntCodePolicyMetadataCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntCodePolicyMetadataProvider.Save(transactionManager, entity.EntCodePolicyMetadataCollection);
						
						deepHandles.Add("EntCodePolicyMetadataCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntCodePolicyMetadata >) DataRepository.EntCodePolicyMetadataProvider.DeepSave,
							new object[] { transactionManager, entity.EntCodePolicyMetadataCollection, deepSaveType, childTypes, innerList }
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
	
	#region EntCodePolicyCatChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EntCodePolicyCat</c>
	///</summary>
	public enum EntCodePolicyCatChildEntityTypes
	{
		///<summary>
		/// Collection of <c>EntCodePolicyCat</c> as OneToMany for EntCodePolicyMetadataCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntCodePolicyMetadata>))]
		EntCodePolicyMetadataCollection,
	}
	
	#endregion EntCodePolicyCatChildEntityTypes
	
	#region EntCodePolicyCatFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntCodePolicyCatColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntCodePolicyCat"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntCodePolicyCatFilterBuilder : SqlFilterBuilder<EntCodePolicyCatColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntCodePolicyCatFilterBuilder class.
		/// </summary>
		public EntCodePolicyCatFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntCodePolicyCatFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntCodePolicyCatFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntCodePolicyCatFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntCodePolicyCatFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntCodePolicyCatFilterBuilder
	
	#region EntCodePolicyCatParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntCodePolicyCatColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntCodePolicyCat"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EntCodePolicyCatParameterBuilder : ParameterizedSqlFilterBuilder<EntCodePolicyCatColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntCodePolicyCatParameterBuilder class.
		/// </summary>
		public EntCodePolicyCatParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EntCodePolicyCatParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EntCodePolicyCatParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EntCodePolicyCatParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EntCodePolicyCatParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EntCodePolicyCatParameterBuilder
	
	#region EntCodePolicyCatSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntCodePolicyCatColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EntCodePolicyCat"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EntCodePolicyCatSortBuilder : SqlSortBuilder<EntCodePolicyCatColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EntCodePolicyCatSqlSortBuilder class.
		/// </summary>
		public EntCodePolicyCatSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EntCodePolicyCatSortBuilder
	
} // end namespace
