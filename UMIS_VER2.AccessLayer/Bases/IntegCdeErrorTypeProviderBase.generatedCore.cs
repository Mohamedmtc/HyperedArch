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
	/// This class is the base class for any <see cref="IntegCdeErrorTypeProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class IntegCdeErrorTypeProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.IntegCdeErrorType, UMIS_VER2.BusinessLyer.IntegCdeErrorTypeKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.IntegCdeErrorTypeKey key)
		{
			return Delete(transactionManager, key.IntegCdeErrorTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_integCdeErrorTypeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _integCdeErrorTypeId)
		{
			return Delete(null, _integCdeErrorTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_integCdeErrorTypeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _integCdeErrorTypeId);		
		
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
		public override UMIS_VER2.BusinessLyer.IntegCdeErrorType Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.IntegCdeErrorTypeKey key, int start, int pageLength)
		{
			return GetByIntegCdeErrorTypeId(transactionManager, key.IntegCdeErrorTypeId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_INTEG_CDE_ERROR_TYPE index.
		/// </summary>
		/// <param name="_integCdeErrorTypeId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.IntegCdeErrorType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.IntegCdeErrorType GetByIntegCdeErrorTypeId(System.Int32 _integCdeErrorTypeId)
		{
			int count = -1;
			return GetByIntegCdeErrorTypeId(null,_integCdeErrorTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_INTEG_CDE_ERROR_TYPE index.
		/// </summary>
		/// <param name="_integCdeErrorTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.IntegCdeErrorType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.IntegCdeErrorType GetByIntegCdeErrorTypeId(System.Int32 _integCdeErrorTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByIntegCdeErrorTypeId(null, _integCdeErrorTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_INTEG_CDE_ERROR_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_integCdeErrorTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.IntegCdeErrorType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.IntegCdeErrorType GetByIntegCdeErrorTypeId(TransactionManager transactionManager, System.Int32 _integCdeErrorTypeId)
		{
			int count = -1;
			return GetByIntegCdeErrorTypeId(transactionManager, _integCdeErrorTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_INTEG_CDE_ERROR_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_integCdeErrorTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.IntegCdeErrorType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.IntegCdeErrorType GetByIntegCdeErrorTypeId(TransactionManager transactionManager, System.Int32 _integCdeErrorTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByIntegCdeErrorTypeId(transactionManager, _integCdeErrorTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_INTEG_CDE_ERROR_TYPE index.
		/// </summary>
		/// <param name="_integCdeErrorTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.IntegCdeErrorType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.IntegCdeErrorType GetByIntegCdeErrorTypeId(System.Int32 _integCdeErrorTypeId, int start, int pageLength, out int count)
		{
			return GetByIntegCdeErrorTypeId(null, _integCdeErrorTypeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_INTEG_CDE_ERROR_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_integCdeErrorTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.IntegCdeErrorType"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.IntegCdeErrorType GetByIntegCdeErrorTypeId(TransactionManager transactionManager, System.Int32 _integCdeErrorTypeId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;IntegCdeErrorType&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;IntegCdeErrorType&gt;"/></returns>
		public static TList<IntegCdeErrorType> Fill(IDataReader reader, TList<IntegCdeErrorType> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.IntegCdeErrorType c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("IntegCdeErrorType")
					.Append("|").Append((System.Int32)reader["INTEG_CDE_ERROR_TYPE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<IntegCdeErrorType>(
					key.ToString(), // EntityTrackingKey
					"IntegCdeErrorType",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.IntegCdeErrorType();
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
					c.IntegCdeErrorTypeId = (System.Int32)reader["INTEG_CDE_ERROR_TYPE_ID"];
					c.OriginalIntegCdeErrorTypeId = c.IntegCdeErrorTypeId;
					c.ErrorTypeAr = Convert.IsDBNull(reader["ERROR_TYPE_AR"]) ? null : (System.String)reader["ERROR_TYPE_AR"];
					c.ErrorTypeEn = Convert.IsDBNull(reader["ERROR_TYPE_EN"]) ? null : (System.String)reader["ERROR_TYPE_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.IntegCdeErrorType"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.IntegCdeErrorType"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.IntegCdeErrorType entity)
		{
			if (!reader.Read()) return;
			
			entity.IntegCdeErrorTypeId = (System.Int32)reader[((int)IntegCdeErrorTypeColumn.IntegCdeErrorTypeId - 1)];
			entity.OriginalIntegCdeErrorTypeId = (System.Int32)reader["INTEG_CDE_ERROR_TYPE_ID"];
			entity.ErrorTypeAr = (reader.IsDBNull(((int)IntegCdeErrorTypeColumn.ErrorTypeAr - 1)))?null:(System.String)reader[((int)IntegCdeErrorTypeColumn.ErrorTypeAr - 1)];
			entity.ErrorTypeEn = (reader.IsDBNull(((int)IntegCdeErrorTypeColumn.ErrorTypeEn - 1)))?null:(System.String)reader[((int)IntegCdeErrorTypeColumn.ErrorTypeEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.IntegCdeErrorType"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.IntegCdeErrorType"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.IntegCdeErrorType entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.IntegCdeErrorTypeId = (System.Int32)dataRow["INTEG_CDE_ERROR_TYPE_ID"];
			entity.OriginalIntegCdeErrorTypeId = (System.Int32)dataRow["INTEG_CDE_ERROR_TYPE_ID"];
			entity.ErrorTypeAr = Convert.IsDBNull(dataRow["ERROR_TYPE_AR"]) ? null : (System.String)dataRow["ERROR_TYPE_AR"];
			entity.ErrorTypeEn = Convert.IsDBNull(dataRow["ERROR_TYPE_EN"]) ? null : (System.String)dataRow["ERROR_TYPE_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.IntegCdeErrorType"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.IntegCdeErrorType Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.IntegCdeErrorType entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByIntegCdeErrorTypeId methods when available
			
			#region IntegUserAdLogDtlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<IntegUserAdLogDtl>|IntegUserAdLogDtlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'IntegUserAdLogDtlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.IntegUserAdLogDtlCollection = DataRepository.IntegUserAdLogDtlProvider.GetByIntegCdeErrorTypeId(transactionManager, entity.IntegCdeErrorTypeId);

				if (deep && entity.IntegUserAdLogDtlCollection.Count > 0)
				{
					deepHandles.Add("IntegUserAdLogDtlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<IntegUserAdLogDtl>) DataRepository.IntegUserAdLogDtlProvider.DeepLoad,
						new object[] { transactionManager, entity.IntegUserAdLogDtlCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.IntegCdeErrorType object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.IntegCdeErrorType instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.IntegCdeErrorType Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.IntegCdeErrorType entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<IntegUserAdLogDtl>
				if (CanDeepSave(entity.IntegUserAdLogDtlCollection, "List<IntegUserAdLogDtl>|IntegUserAdLogDtlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(IntegUserAdLogDtl child in entity.IntegUserAdLogDtlCollection)
					{
						if(child.IntegCdeErrorTypeIdSource != null)
						{
							child.IntegCdeErrorTypeId = child.IntegCdeErrorTypeIdSource.IntegCdeErrorTypeId;
						}
						else
						{
							child.IntegCdeErrorTypeId = entity.IntegCdeErrorTypeId;
						}

					}

					if (entity.IntegUserAdLogDtlCollection.Count > 0 || entity.IntegUserAdLogDtlCollection.DeletedItems.Count > 0)
					{
						//DataRepository.IntegUserAdLogDtlProvider.Save(transactionManager, entity.IntegUserAdLogDtlCollection);
						
						deepHandles.Add("IntegUserAdLogDtlCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< IntegUserAdLogDtl >) DataRepository.IntegUserAdLogDtlProvider.DeepSave,
							new object[] { transactionManager, entity.IntegUserAdLogDtlCollection, deepSaveType, childTypes, innerList }
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
	
	#region IntegCdeErrorTypeChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.IntegCdeErrorType</c>
	///</summary>
	public enum IntegCdeErrorTypeChildEntityTypes
	{
		///<summary>
		/// Collection of <c>IntegCdeErrorType</c> as OneToMany for IntegUserAdLogDtlCollection
		///</summary>
		[ChildEntityType(typeof(TList<IntegUserAdLogDtl>))]
		IntegUserAdLogDtlCollection,
	}
	
	#endregion IntegCdeErrorTypeChildEntityTypes
	
	#region IntegCdeErrorTypeFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;IntegCdeErrorTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="IntegCdeErrorType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class IntegCdeErrorTypeFilterBuilder : SqlFilterBuilder<IntegCdeErrorTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the IntegCdeErrorTypeFilterBuilder class.
		/// </summary>
		public IntegCdeErrorTypeFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the IntegCdeErrorTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public IntegCdeErrorTypeFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the IntegCdeErrorTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public IntegCdeErrorTypeFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion IntegCdeErrorTypeFilterBuilder
	
	#region IntegCdeErrorTypeParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;IntegCdeErrorTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="IntegCdeErrorType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class IntegCdeErrorTypeParameterBuilder : ParameterizedSqlFilterBuilder<IntegCdeErrorTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the IntegCdeErrorTypeParameterBuilder class.
		/// </summary>
		public IntegCdeErrorTypeParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the IntegCdeErrorTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public IntegCdeErrorTypeParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the IntegCdeErrorTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public IntegCdeErrorTypeParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion IntegCdeErrorTypeParameterBuilder
	
	#region IntegCdeErrorTypeSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;IntegCdeErrorTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="IntegCdeErrorType"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class IntegCdeErrorTypeSortBuilder : SqlSortBuilder<IntegCdeErrorTypeColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the IntegCdeErrorTypeSqlSortBuilder class.
		/// </summary>
		public IntegCdeErrorTypeSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion IntegCdeErrorTypeSortBuilder
	
} // end namespace
