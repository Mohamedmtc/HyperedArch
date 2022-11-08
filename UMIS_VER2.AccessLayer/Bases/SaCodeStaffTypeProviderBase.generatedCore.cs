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
	/// This class is the base class for any <see cref="SaCodeStaffTypeProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SaCodeStaffTypeProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SaCodeStaffType, UMIS_VER2.BusinessLyer.SaCodeStaffTypeKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeStaffTypeKey key)
		{
			return Delete(transactionManager, key.StaffFlag);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_staffFlag">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _staffFlag)
		{
			return Delete(null, _staffFlag);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_staffFlag">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _staffFlag);		
		
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
		public override UMIS_VER2.BusinessLyer.SaCodeStaffType Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeStaffTypeKey key, int start, int pageLength)
		{
			return GetByStaffFlag(transactionManager, key.StaffFlag, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SA_CODE_STAFF_TYPE index.
		/// </summary>
		/// <param name="_staffFlag"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeStaffType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeStaffType GetByStaffFlag(System.Decimal _staffFlag)
		{
			int count = -1;
			return GetByStaffFlag(null,_staffFlag, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_STAFF_TYPE index.
		/// </summary>
		/// <param name="_staffFlag"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeStaffType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeStaffType GetByStaffFlag(System.Decimal _staffFlag, int start, int pageLength)
		{
			int count = -1;
			return GetByStaffFlag(null, _staffFlag, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_STAFF_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_staffFlag"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeStaffType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeStaffType GetByStaffFlag(TransactionManager transactionManager, System.Decimal _staffFlag)
		{
			int count = -1;
			return GetByStaffFlag(transactionManager, _staffFlag, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_STAFF_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_staffFlag"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeStaffType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeStaffType GetByStaffFlag(TransactionManager transactionManager, System.Decimal _staffFlag, int start, int pageLength)
		{
			int count = -1;
			return GetByStaffFlag(transactionManager, _staffFlag, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_STAFF_TYPE index.
		/// </summary>
		/// <param name="_staffFlag"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeStaffType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeStaffType GetByStaffFlag(System.Decimal _staffFlag, int start, int pageLength, out int count)
		{
			return GetByStaffFlag(null, _staffFlag, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_STAFF_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_staffFlag"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeStaffType"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SaCodeStaffType GetByStaffFlag(TransactionManager transactionManager, System.Decimal _staffFlag, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SaCodeStaffType&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SaCodeStaffType&gt;"/></returns>
		public static TList<SaCodeStaffType> Fill(IDataReader reader, TList<SaCodeStaffType> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SaCodeStaffType c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SaCodeStaffType")
					.Append("|").Append((System.Decimal)reader["STAFF_FLAG"]).ToString();
					c = EntityManager.LocateOrCreate<SaCodeStaffType>(
					key.ToString(), // EntityTrackingKey
					"SaCodeStaffType",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SaCodeStaffType();
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
					c.StaffFlag = (System.Decimal)reader["STAFF_FLAG"];
					c.OriginalStaffFlag = c.StaffFlag;
					c.StaffType = Convert.IsDBNull(reader["STAFF_TYPE"]) ? null : (System.String)reader["STAFF_TYPE"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaCodeStaffType"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCodeStaffType"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SaCodeStaffType entity)
		{
			if (!reader.Read()) return;
			
			entity.StaffFlag = (System.Decimal)reader[((int)SaCodeStaffTypeColumn.StaffFlag - 1)];
			entity.OriginalStaffFlag = (System.Decimal)reader["STAFF_FLAG"];
			entity.StaffType = (reader.IsDBNull(((int)SaCodeStaffTypeColumn.StaffType - 1)))?null:(System.String)reader[((int)SaCodeStaffTypeColumn.StaffType - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaCodeStaffType"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCodeStaffType"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SaCodeStaffType entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.StaffFlag = (System.Decimal)dataRow["STAFF_FLAG"];
			entity.OriginalStaffFlag = (System.Decimal)dataRow["STAFF_FLAG"];
			entity.StaffType = Convert.IsDBNull(dataRow["STAFF_TYPE"]) ? null : (System.String)dataRow["STAFF_TYPE"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCodeStaffType"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaCodeStaffType Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeStaffType entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByStaffFlag methods when available
			
			#region SaPunishmentBylawsCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaPunishmentBylaws>|SaPunishmentBylawsCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaPunishmentBylawsCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaPunishmentBylawsCollection = DataRepository.SaPunishmentBylawsProvider.GetByStaffFlag(transactionManager, entity.StaffFlag);

				if (deep && entity.SaPunishmentBylawsCollection.Count > 0)
				{
					deepHandles.Add("SaPunishmentBylawsCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaPunishmentBylaws>) DataRepository.SaPunishmentBylawsProvider.DeepLoad,
						new object[] { transactionManager, entity.SaPunishmentBylawsCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SaCodeStaffType object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SaCodeStaffType instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaCodeStaffType Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeStaffType entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<SaPunishmentBylaws>
				if (CanDeepSave(entity.SaPunishmentBylawsCollection, "List<SaPunishmentBylaws>|SaPunishmentBylawsCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaPunishmentBylaws child in entity.SaPunishmentBylawsCollection)
					{
						if(child.StaffFlagSource != null)
						{
							child.StaffFlag = child.StaffFlagSource.StaffFlag;
						}
						else
						{
							child.StaffFlag = entity.StaffFlag;
						}

					}

					if (entity.SaPunishmentBylawsCollection.Count > 0 || entity.SaPunishmentBylawsCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaPunishmentBylawsProvider.Save(transactionManager, entity.SaPunishmentBylawsCollection);
						
						deepHandles.Add("SaPunishmentBylawsCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaPunishmentBylaws >) DataRepository.SaPunishmentBylawsProvider.DeepSave,
							new object[] { transactionManager, entity.SaPunishmentBylawsCollection, deepSaveType, childTypes, innerList }
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
	
	#region SaCodeStaffTypeChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SaCodeStaffType</c>
	///</summary>
	public enum SaCodeStaffTypeChildEntityTypes
	{
		///<summary>
		/// Collection of <c>SaCodeStaffType</c> as OneToMany for SaPunishmentBylawsCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaPunishmentBylaws>))]
		SaPunishmentBylawsCollection,
	}
	
	#endregion SaCodeStaffTypeChildEntityTypes
	
	#region SaCodeStaffTypeFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SaCodeStaffTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCodeStaffType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaCodeStaffTypeFilterBuilder : SqlFilterBuilder<SaCodeStaffTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCodeStaffTypeFilterBuilder class.
		/// </summary>
		public SaCodeStaffTypeFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaCodeStaffTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaCodeStaffTypeFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaCodeStaffTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaCodeStaffTypeFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaCodeStaffTypeFilterBuilder
	
	#region SaCodeStaffTypeParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SaCodeStaffTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCodeStaffType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaCodeStaffTypeParameterBuilder : ParameterizedSqlFilterBuilder<SaCodeStaffTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCodeStaffTypeParameterBuilder class.
		/// </summary>
		public SaCodeStaffTypeParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaCodeStaffTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaCodeStaffTypeParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaCodeStaffTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaCodeStaffTypeParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaCodeStaffTypeParameterBuilder
	
	#region SaCodeStaffTypeSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SaCodeStaffTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCodeStaffType"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SaCodeStaffTypeSortBuilder : SqlSortBuilder<SaCodeStaffTypeColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCodeStaffTypeSqlSortBuilder class.
		/// </summary>
		public SaCodeStaffTypeSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SaCodeStaffTypeSortBuilder
	
} // end namespace
