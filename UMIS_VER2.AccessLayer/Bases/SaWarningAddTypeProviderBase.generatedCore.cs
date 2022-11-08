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
	/// This class is the base class for any <see cref="SaWarningAddTypeProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SaWarningAddTypeProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SaWarningAddType, UMIS_VER2.BusinessLyer.SaWarningAddTypeKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaWarningAddTypeKey key)
		{
			return Delete(transactionManager, key.SaWarningAddTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_saWarningAddTypeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _saWarningAddTypeId)
		{
			return Delete(null, _saWarningAddTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saWarningAddTypeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _saWarningAddTypeId);		
		
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
		public override UMIS_VER2.BusinessLyer.SaWarningAddType Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaWarningAddTypeKey key, int start, int pageLength)
		{
			return GetBySaWarningAddTypeId(transactionManager, key.SaWarningAddTypeId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_WARNING_ADD_TYPE index.
		/// </summary>
		/// <param name="_saWarningAddTypeId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaWarningAddType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaWarningAddType GetBySaWarningAddTypeId(System.Decimal _saWarningAddTypeId)
		{
			int count = -1;
			return GetBySaWarningAddTypeId(null,_saWarningAddTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_WARNING_ADD_TYPE index.
		/// </summary>
		/// <param name="_saWarningAddTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaWarningAddType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaWarningAddType GetBySaWarningAddTypeId(System.Decimal _saWarningAddTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaWarningAddTypeId(null, _saWarningAddTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_WARNING_ADD_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saWarningAddTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaWarningAddType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaWarningAddType GetBySaWarningAddTypeId(TransactionManager transactionManager, System.Decimal _saWarningAddTypeId)
		{
			int count = -1;
			return GetBySaWarningAddTypeId(transactionManager, _saWarningAddTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_WARNING_ADD_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saWarningAddTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaWarningAddType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaWarningAddType GetBySaWarningAddTypeId(TransactionManager transactionManager, System.Decimal _saWarningAddTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaWarningAddTypeId(transactionManager, _saWarningAddTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_WARNING_ADD_TYPE index.
		/// </summary>
		/// <param name="_saWarningAddTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaWarningAddType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaWarningAddType GetBySaWarningAddTypeId(System.Decimal _saWarningAddTypeId, int start, int pageLength, out int count)
		{
			return GetBySaWarningAddTypeId(null, _saWarningAddTypeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_WARNING_ADD_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saWarningAddTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaWarningAddType"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SaWarningAddType GetBySaWarningAddTypeId(TransactionManager transactionManager, System.Decimal _saWarningAddTypeId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SaWarningAddType&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SaWarningAddType&gt;"/></returns>
		public static TList<SaWarningAddType> Fill(IDataReader reader, TList<SaWarningAddType> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SaWarningAddType c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SaWarningAddType")
					.Append("|").Append((System.Decimal)reader["SA_WARNING_ADD_TYPE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SaWarningAddType>(
					key.ToString(), // EntityTrackingKey
					"SaWarningAddType",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SaWarningAddType();
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
					c.SaWarningAddTypeId = (System.Decimal)reader["SA_WARNING_ADD_TYPE_ID"];
					c.OriginalSaWarningAddTypeId = c.SaWarningAddTypeId;
					c.WarningAddTypeDescr = (System.String)reader["WARNING_ADD_TYPE_DESCR"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaWarningAddType"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaWarningAddType"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SaWarningAddType entity)
		{
			if (!reader.Read()) return;
			
			entity.SaWarningAddTypeId = (System.Decimal)reader[((int)SaWarningAddTypeColumn.SaWarningAddTypeId - 1)];
			entity.OriginalSaWarningAddTypeId = (System.Decimal)reader["SA_WARNING_ADD_TYPE_ID"];
			entity.WarningAddTypeDescr = (System.String)reader[((int)SaWarningAddTypeColumn.WarningAddTypeDescr - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaWarningAddType"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaWarningAddType"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SaWarningAddType entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SaWarningAddTypeId = (System.Decimal)dataRow["SA_WARNING_ADD_TYPE_ID"];
			entity.OriginalSaWarningAddTypeId = (System.Decimal)dataRow["SA_WARNING_ADD_TYPE_ID"];
			entity.WarningAddTypeDescr = (System.String)dataRow["WARNING_ADD_TYPE_DESCR"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaWarningAddType"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaWarningAddType Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaWarningAddType entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetBySaWarningAddTypeId methods when available
			
			#region SaWarningCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaWarning>|SaWarningCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaWarningCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaWarningCollection = DataRepository.SaWarningProvider.GetByWarningAddTypeId(transactionManager, entity.SaWarningAddTypeId);

				if (deep && entity.SaWarningCollection.Count > 0)
				{
					deepHandles.Add("SaWarningCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaWarning>) DataRepository.SaWarningProvider.DeepLoad,
						new object[] { transactionManager, entity.SaWarningCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SaWarningAddType object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SaWarningAddType instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaWarningAddType Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaWarningAddType entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<SaWarning>
				if (CanDeepSave(entity.SaWarningCollection, "List<SaWarning>|SaWarningCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaWarning child in entity.SaWarningCollection)
					{
						if(child.WarningAddTypeIdSource != null)
						{
							child.WarningAddTypeId = child.WarningAddTypeIdSource.SaWarningAddTypeId;
						}
						else
						{
							child.WarningAddTypeId = entity.SaWarningAddTypeId;
						}

					}

					if (entity.SaWarningCollection.Count > 0 || entity.SaWarningCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaWarningProvider.Save(transactionManager, entity.SaWarningCollection);
						
						deepHandles.Add("SaWarningCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaWarning >) DataRepository.SaWarningProvider.DeepSave,
							new object[] { transactionManager, entity.SaWarningCollection, deepSaveType, childTypes, innerList }
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
	
	#region SaWarningAddTypeChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SaWarningAddType</c>
	///</summary>
	public enum SaWarningAddTypeChildEntityTypes
	{
		///<summary>
		/// Collection of <c>SaWarningAddType</c> as OneToMany for SaWarningCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaWarning>))]
		SaWarningCollection,
	}
	
	#endregion SaWarningAddTypeChildEntityTypes
	
	#region SaWarningAddTypeFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SaWarningAddTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaWarningAddType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaWarningAddTypeFilterBuilder : SqlFilterBuilder<SaWarningAddTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaWarningAddTypeFilterBuilder class.
		/// </summary>
		public SaWarningAddTypeFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaWarningAddTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaWarningAddTypeFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaWarningAddTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaWarningAddTypeFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaWarningAddTypeFilterBuilder
	
	#region SaWarningAddTypeParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SaWarningAddTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaWarningAddType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaWarningAddTypeParameterBuilder : ParameterizedSqlFilterBuilder<SaWarningAddTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaWarningAddTypeParameterBuilder class.
		/// </summary>
		public SaWarningAddTypeParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaWarningAddTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaWarningAddTypeParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaWarningAddTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaWarningAddTypeParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaWarningAddTypeParameterBuilder
	
	#region SaWarningAddTypeSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SaWarningAddTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaWarningAddType"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SaWarningAddTypeSortBuilder : SqlSortBuilder<SaWarningAddTypeColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaWarningAddTypeSqlSortBuilder class.
		/// </summary>
		public SaWarningAddTypeSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SaWarningAddTypeSortBuilder
	
} // end namespace
