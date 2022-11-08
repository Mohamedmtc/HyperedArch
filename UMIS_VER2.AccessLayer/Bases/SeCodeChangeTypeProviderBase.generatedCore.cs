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
	/// This class is the base class for any <see cref="SeCodeChangeTypeProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SeCodeChangeTypeProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SeCodeChangeType, UMIS_VER2.BusinessLyer.SeCodeChangeTypeKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeCodeChangeTypeKey key)
		{
			return Delete(transactionManager, key.SeCodeChangeTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_seCodeChangeTypeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _seCodeChangeTypeId)
		{
			return Delete(null, _seCodeChangeTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seCodeChangeTypeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _seCodeChangeTypeId);		
		
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
		public override UMIS_VER2.BusinessLyer.SeCodeChangeType Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeCodeChangeTypeKey key, int start, int pageLength)
		{
			return GetBySeCodeChangeTypeId(transactionManager, key.SeCodeChangeTypeId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SE_CODE_CHANGE_TYPE index.
		/// </summary>
		/// <param name="_seCodeChangeTypeId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeCodeChangeType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeCodeChangeType GetBySeCodeChangeTypeId(System.Decimal _seCodeChangeTypeId)
		{
			int count = -1;
			return GetBySeCodeChangeTypeId(null,_seCodeChangeTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_CODE_CHANGE_TYPE index.
		/// </summary>
		/// <param name="_seCodeChangeTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeCodeChangeType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeCodeChangeType GetBySeCodeChangeTypeId(System.Decimal _seCodeChangeTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeCodeChangeTypeId(null, _seCodeChangeTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_CODE_CHANGE_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seCodeChangeTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeCodeChangeType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeCodeChangeType GetBySeCodeChangeTypeId(TransactionManager transactionManager, System.Decimal _seCodeChangeTypeId)
		{
			int count = -1;
			return GetBySeCodeChangeTypeId(transactionManager, _seCodeChangeTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_CODE_CHANGE_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seCodeChangeTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeCodeChangeType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeCodeChangeType GetBySeCodeChangeTypeId(TransactionManager transactionManager, System.Decimal _seCodeChangeTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeCodeChangeTypeId(transactionManager, _seCodeChangeTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_CODE_CHANGE_TYPE index.
		/// </summary>
		/// <param name="_seCodeChangeTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeCodeChangeType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeCodeChangeType GetBySeCodeChangeTypeId(System.Decimal _seCodeChangeTypeId, int start, int pageLength, out int count)
		{
			return GetBySeCodeChangeTypeId(null, _seCodeChangeTypeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SE_CODE_CHANGE_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seCodeChangeTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeCodeChangeType"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SeCodeChangeType GetBySeCodeChangeTypeId(TransactionManager transactionManager, System.Decimal _seCodeChangeTypeId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SeCodeChangeType&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SeCodeChangeType&gt;"/></returns>
		public static TList<SeCodeChangeType> Fill(IDataReader reader, TList<SeCodeChangeType> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SeCodeChangeType c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SeCodeChangeType")
					.Append("|").Append((System.Decimal)reader["SE_CODE_CHANGE_TYPE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SeCodeChangeType>(
					key.ToString(), // EntityTrackingKey
					"SeCodeChangeType",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SeCodeChangeType();
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
					c.SeCodeChangeTypeId = (System.Decimal)reader["SE_CODE_CHANGE_TYPE_ID"];
					c.OriginalSeCodeChangeTypeId = c.SeCodeChangeTypeId;
					c.ChangeName = (System.String)reader["CHANGE_NAME"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SeCodeChangeType"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SeCodeChangeType"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SeCodeChangeType entity)
		{
			if (!reader.Read()) return;
			
			entity.SeCodeChangeTypeId = (System.Decimal)reader[((int)SeCodeChangeTypeColumn.SeCodeChangeTypeId - 1)];
			entity.OriginalSeCodeChangeTypeId = (System.Decimal)reader["SE_CODE_CHANGE_TYPE_ID"];
			entity.ChangeName = (System.String)reader[((int)SeCodeChangeTypeColumn.ChangeName - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SeCodeChangeType"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SeCodeChangeType"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SeCodeChangeType entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SeCodeChangeTypeId = (System.Decimal)dataRow["SE_CODE_CHANGE_TYPE_ID"];
			entity.OriginalSeCodeChangeTypeId = (System.Decimal)dataRow["SE_CODE_CHANGE_TYPE_ID"];
			entity.ChangeName = (System.String)dataRow["CHANGE_NAME"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SeCodeChangeType"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SeCodeChangeType Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeCodeChangeType entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetBySeCodeChangeTypeId methods when available
			
			#region SeVersionCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SeVersion>|SeVersionCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeVersionCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SeVersionCollection = DataRepository.SeVersionProvider.GetBySeCodeChangeTypeId(transactionManager, entity.SeCodeChangeTypeId);

				if (deep && entity.SeVersionCollection.Count > 0)
				{
					deepHandles.Add("SeVersionCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SeVersion>) DataRepository.SeVersionProvider.DeepLoad,
						new object[] { transactionManager, entity.SeVersionCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SeCodeChangeType object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SeCodeChangeType instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SeCodeChangeType Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeCodeChangeType entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<SeVersion>
				if (CanDeepSave(entity.SeVersionCollection, "List<SeVersion>|SeVersionCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SeVersion child in entity.SeVersionCollection)
					{
						if(child.SeCodeChangeTypeIdSource != null)
						{
							child.SeCodeChangeTypeId = child.SeCodeChangeTypeIdSource.SeCodeChangeTypeId;
						}
						else
						{
							child.SeCodeChangeTypeId = entity.SeCodeChangeTypeId;
						}

					}

					if (entity.SeVersionCollection.Count > 0 || entity.SeVersionCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SeVersionProvider.Save(transactionManager, entity.SeVersionCollection);
						
						deepHandles.Add("SeVersionCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SeVersion >) DataRepository.SeVersionProvider.DeepSave,
							new object[] { transactionManager, entity.SeVersionCollection, deepSaveType, childTypes, innerList }
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
	
	#region SeCodeChangeTypeChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SeCodeChangeType</c>
	///</summary>
	public enum SeCodeChangeTypeChildEntityTypes
	{
		///<summary>
		/// Collection of <c>SeCodeChangeType</c> as OneToMany for SeVersionCollection
		///</summary>
		[ChildEntityType(typeof(TList<SeVersion>))]
		SeVersionCollection,
	}
	
	#endregion SeCodeChangeTypeChildEntityTypes
	
	#region SeCodeChangeTypeFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SeCodeChangeTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SeCodeChangeType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SeCodeChangeTypeFilterBuilder : SqlFilterBuilder<SeCodeChangeTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SeCodeChangeTypeFilterBuilder class.
		/// </summary>
		public SeCodeChangeTypeFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SeCodeChangeTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SeCodeChangeTypeFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SeCodeChangeTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SeCodeChangeTypeFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SeCodeChangeTypeFilterBuilder
	
	#region SeCodeChangeTypeParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SeCodeChangeTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SeCodeChangeType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SeCodeChangeTypeParameterBuilder : ParameterizedSqlFilterBuilder<SeCodeChangeTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SeCodeChangeTypeParameterBuilder class.
		/// </summary>
		public SeCodeChangeTypeParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SeCodeChangeTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SeCodeChangeTypeParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SeCodeChangeTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SeCodeChangeTypeParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SeCodeChangeTypeParameterBuilder
	
	#region SeCodeChangeTypeSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SeCodeChangeTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SeCodeChangeType"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SeCodeChangeTypeSortBuilder : SqlSortBuilder<SeCodeChangeTypeColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SeCodeChangeTypeSqlSortBuilder class.
		/// </summary>
		public SeCodeChangeTypeSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SeCodeChangeTypeSortBuilder
	
} // end namespace
