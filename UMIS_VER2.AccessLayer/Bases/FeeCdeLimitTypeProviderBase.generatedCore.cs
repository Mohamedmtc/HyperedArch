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
	/// This class is the base class for any <see cref="FeeCdeLimitTypeProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class FeeCdeLimitTypeProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.FeeCdeLimitType, UMIS_VER2.BusinessLyer.FeeCdeLimitTypeKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeCdeLimitTypeKey key)
		{
			return Delete(transactionManager, key.FeeCdeLimitTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_feeCdeLimitTypeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _feeCdeLimitTypeId)
		{
			return Delete(null, _feeCdeLimitTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeLimitTypeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _feeCdeLimitTypeId);		
		
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
		public override UMIS_VER2.BusinessLyer.FeeCdeLimitType Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeCdeLimitTypeKey key, int start, int pageLength)
		{
			return GetByFeeCdeLimitTypeId(transactionManager, key.FeeCdeLimitTypeId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_FEE_CDE_LIMIT_TYPE index.
		/// </summary>
		/// <param name="_feeCdeLimitTypeId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCdeLimitType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCdeLimitType GetByFeeCdeLimitTypeId(System.Int32 _feeCdeLimitTypeId)
		{
			int count = -1;
			return GetByFeeCdeLimitTypeId(null,_feeCdeLimitTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_CDE_LIMIT_TYPE index.
		/// </summary>
		/// <param name="_feeCdeLimitTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCdeLimitType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCdeLimitType GetByFeeCdeLimitTypeId(System.Int32 _feeCdeLimitTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCdeLimitTypeId(null, _feeCdeLimitTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_CDE_LIMIT_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeLimitTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCdeLimitType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCdeLimitType GetByFeeCdeLimitTypeId(TransactionManager transactionManager, System.Int32 _feeCdeLimitTypeId)
		{
			int count = -1;
			return GetByFeeCdeLimitTypeId(transactionManager, _feeCdeLimitTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_CDE_LIMIT_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeLimitTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCdeLimitType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCdeLimitType GetByFeeCdeLimitTypeId(TransactionManager transactionManager, System.Int32 _feeCdeLimitTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCdeLimitTypeId(transactionManager, _feeCdeLimitTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_CDE_LIMIT_TYPE index.
		/// </summary>
		/// <param name="_feeCdeLimitTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCdeLimitType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCdeLimitType GetByFeeCdeLimitTypeId(System.Int32 _feeCdeLimitTypeId, int start, int pageLength, out int count)
		{
			return GetByFeeCdeLimitTypeId(null, _feeCdeLimitTypeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_CDE_LIMIT_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeLimitTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCdeLimitType"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.FeeCdeLimitType GetByFeeCdeLimitTypeId(TransactionManager transactionManager, System.Int32 _feeCdeLimitTypeId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;FeeCdeLimitType&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;FeeCdeLimitType&gt;"/></returns>
		public static TList<FeeCdeLimitType> Fill(IDataReader reader, TList<FeeCdeLimitType> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.FeeCdeLimitType c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("FeeCdeLimitType")
					.Append("|").Append((System.Int32)reader["FEE_CDE_LIMIT_TYPE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<FeeCdeLimitType>(
					key.ToString(), // EntityTrackingKey
					"FeeCdeLimitType",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.FeeCdeLimitType();
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
					c.FeeCdeLimitTypeId = (System.Int32)reader["FEE_CDE_LIMIT_TYPE_ID"];
					c.OriginalFeeCdeLimitTypeId = c.FeeCdeLimitTypeId;
					c.LimitAr = (System.String)reader["LIMIT_AR"];
					c.LimitEn = (System.String)reader["LIMIT_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeCdeLimitType"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeCdeLimitType"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.FeeCdeLimitType entity)
		{
			if (!reader.Read()) return;
			
			entity.FeeCdeLimitTypeId = (System.Int32)reader[((int)FeeCdeLimitTypeColumn.FeeCdeLimitTypeId - 1)];
			entity.OriginalFeeCdeLimitTypeId = (System.Int32)reader["FEE_CDE_LIMIT_TYPE_ID"];
			entity.LimitAr = (System.String)reader[((int)FeeCdeLimitTypeColumn.LimitAr - 1)];
			entity.LimitEn = (System.String)reader[((int)FeeCdeLimitTypeColumn.LimitEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeCdeLimitType"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeCdeLimitType"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.FeeCdeLimitType entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.FeeCdeLimitTypeId = (System.Int32)dataRow["FEE_CDE_LIMIT_TYPE_ID"];
			entity.OriginalFeeCdeLimitTypeId = (System.Int32)dataRow["FEE_CDE_LIMIT_TYPE_ID"];
			entity.LimitAr = (System.String)dataRow["LIMIT_AR"];
			entity.LimitEn = (System.String)dataRow["LIMIT_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeCdeLimitType"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeCdeLimitType Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeCdeLimitType entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByFeeCdeLimitTypeId methods when available
			
			#region FeeLimitRuleCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeLimitRule>|FeeLimitRuleCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeLimitRuleCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeLimitRuleCollection = DataRepository.FeeLimitRuleProvider.GetByFeeCdeLimitTypeId(transactionManager, entity.FeeCdeLimitTypeId);

				if (deep && entity.FeeLimitRuleCollection.Count > 0)
				{
					deepHandles.Add("FeeLimitRuleCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeLimitRule>) DataRepository.FeeLimitRuleProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeLimitRuleCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.FeeCdeLimitType object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.FeeCdeLimitType instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeCdeLimitType Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeCdeLimitType entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<FeeLimitRule>
				if (CanDeepSave(entity.FeeLimitRuleCollection, "List<FeeLimitRule>|FeeLimitRuleCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeLimitRule child in entity.FeeLimitRuleCollection)
					{
						if(child.FeeCdeLimitTypeIdSource != null)
						{
							child.FeeCdeLimitTypeId = child.FeeCdeLimitTypeIdSource.FeeCdeLimitTypeId;
						}
						else
						{
							child.FeeCdeLimitTypeId = entity.FeeCdeLimitTypeId;
						}

					}

					if (entity.FeeLimitRuleCollection.Count > 0 || entity.FeeLimitRuleCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeLimitRuleProvider.Save(transactionManager, entity.FeeLimitRuleCollection);
						
						deepHandles.Add("FeeLimitRuleCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeLimitRule >) DataRepository.FeeLimitRuleProvider.DeepSave,
							new object[] { transactionManager, entity.FeeLimitRuleCollection, deepSaveType, childTypes, innerList }
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
	
	#region FeeCdeLimitTypeChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.FeeCdeLimitType</c>
	///</summary>
	public enum FeeCdeLimitTypeChildEntityTypes
	{
		///<summary>
		/// Collection of <c>FeeCdeLimitType</c> as OneToMany for FeeLimitRuleCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeLimitRule>))]
		FeeLimitRuleCollection,
	}
	
	#endregion FeeCdeLimitTypeChildEntityTypes
	
	#region FeeCdeLimitTypeFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;FeeCdeLimitTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeCdeLimitType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeCdeLimitTypeFilterBuilder : SqlFilterBuilder<FeeCdeLimitTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeCdeLimitTypeFilterBuilder class.
		/// </summary>
		public FeeCdeLimitTypeFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeCdeLimitTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeCdeLimitTypeFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeCdeLimitTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeCdeLimitTypeFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeCdeLimitTypeFilterBuilder
	
	#region FeeCdeLimitTypeParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;FeeCdeLimitTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeCdeLimitType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeCdeLimitTypeParameterBuilder : ParameterizedSqlFilterBuilder<FeeCdeLimitTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeCdeLimitTypeParameterBuilder class.
		/// </summary>
		public FeeCdeLimitTypeParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeCdeLimitTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeCdeLimitTypeParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeCdeLimitTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeCdeLimitTypeParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeCdeLimitTypeParameterBuilder
	
	#region FeeCdeLimitTypeSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;FeeCdeLimitTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeCdeLimitType"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class FeeCdeLimitTypeSortBuilder : SqlSortBuilder<FeeCdeLimitTypeColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeCdeLimitTypeSqlSortBuilder class.
		/// </summary>
		public FeeCdeLimitTypeSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion FeeCdeLimitTypeSortBuilder
	
} // end namespace
