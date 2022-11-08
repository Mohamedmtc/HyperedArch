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
	/// This class is the base class for any <see cref="EdStaffDayPrefProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdStaffDayPrefProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdStaffDayPref, UMIS_VER2.BusinessLyer.EdStaffDayPrefKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStaffDayPrefKey key)
		{
			return Delete(transactionManager, key.EdStaffDayPrefId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edStaffDayPrefId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.String _edStaffDayPrefId)
		{
			return Delete(null, _edStaffDayPrefId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStaffDayPrefId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.String _edStaffDayPrefId);		
		
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
		public override UMIS_VER2.BusinessLyer.EdStaffDayPref Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStaffDayPrefKey key, int start, int pageLength)
		{
			return GetByEdStaffDayPrefId(transactionManager, key.EdStaffDayPrefId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_STAFF_DAY_PREF index.
		/// </summary>
		/// <param name="_edStaffDayPrefId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStaffDayPref"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStaffDayPref GetByEdStaffDayPrefId(System.String _edStaffDayPrefId)
		{
			int count = -1;
			return GetByEdStaffDayPrefId(null,_edStaffDayPrefId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STAFF_DAY_PREF index.
		/// </summary>
		/// <param name="_edStaffDayPrefId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStaffDayPref"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStaffDayPref GetByEdStaffDayPrefId(System.String _edStaffDayPrefId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStaffDayPrefId(null, _edStaffDayPrefId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STAFF_DAY_PREF index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStaffDayPrefId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStaffDayPref"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStaffDayPref GetByEdStaffDayPrefId(TransactionManager transactionManager, System.String _edStaffDayPrefId)
		{
			int count = -1;
			return GetByEdStaffDayPrefId(transactionManager, _edStaffDayPrefId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STAFF_DAY_PREF index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStaffDayPrefId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStaffDayPref"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStaffDayPref GetByEdStaffDayPrefId(TransactionManager transactionManager, System.String _edStaffDayPrefId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStaffDayPrefId(transactionManager, _edStaffDayPrefId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STAFF_DAY_PREF index.
		/// </summary>
		/// <param name="_edStaffDayPrefId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStaffDayPref"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdStaffDayPref GetByEdStaffDayPrefId(System.String _edStaffDayPrefId, int start, int pageLength, out int count)
		{
			return GetByEdStaffDayPrefId(null, _edStaffDayPrefId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_STAFF_DAY_PREF index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStaffDayPrefId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdStaffDayPref"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdStaffDayPref GetByEdStaffDayPrefId(TransactionManager transactionManager, System.String _edStaffDayPrefId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdStaffDayPref&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdStaffDayPref&gt;"/></returns>
		public static TList<EdStaffDayPref> Fill(IDataReader reader, TList<EdStaffDayPref> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdStaffDayPref c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdStaffDayPref")
					.Append("|").Append((System.String)reader["ED_STAFF_DAY_PREF_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdStaffDayPref>(
					key.ToString(), // EntityTrackingKey
					"EdStaffDayPref",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdStaffDayPref();
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
					c.EdStaffDayPrefId = (System.String)reader["ED_STAFF_DAY_PREF_ID"];
					c.OriginalEdStaffDayPrefId = c.EdStaffDayPrefId;
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStaffDayPref"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStaffDayPref"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdStaffDayPref entity)
		{
			if (!reader.Read()) return;
			
			entity.EdStaffDayPrefId = (System.String)reader[((int)EdStaffDayPrefColumn.EdStaffDayPrefId - 1)];
			entity.OriginalEdStaffDayPrefId = (System.String)reader["ED_STAFF_DAY_PREF_ID"];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdStaffDayPref"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStaffDayPref"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdStaffDayPref entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdStaffDayPrefId = (System.String)dataRow["ED_STAFF_DAY_PREF_ID"];
			entity.OriginalEdStaffDayPrefId = (System.String)dataRow["ED_STAFF_DAY_PREF_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdStaffDayPref"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStaffDayPref Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStaffDayPref entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdStaffDayPref object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdStaffDayPref instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdStaffDayPref Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStaffDayPref entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region EdStaffDayPrefChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdStaffDayPref</c>
	///</summary>
	public enum EdStaffDayPrefChildEntityTypes
	{
	}
	
	#endregion EdStaffDayPrefChildEntityTypes
	
	#region EdStaffDayPrefFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdStaffDayPrefColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStaffDayPref"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStaffDayPrefFilterBuilder : SqlFilterBuilder<EdStaffDayPrefColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStaffDayPrefFilterBuilder class.
		/// </summary>
		public EdStaffDayPrefFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStaffDayPrefFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStaffDayPrefFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStaffDayPrefFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStaffDayPrefFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStaffDayPrefFilterBuilder
	
	#region EdStaffDayPrefParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdStaffDayPrefColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStaffDayPref"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdStaffDayPrefParameterBuilder : ParameterizedSqlFilterBuilder<EdStaffDayPrefColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStaffDayPrefParameterBuilder class.
		/// </summary>
		public EdStaffDayPrefParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdStaffDayPrefParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdStaffDayPrefParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdStaffDayPrefParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdStaffDayPrefParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdStaffDayPrefParameterBuilder
	
	#region EdStaffDayPrefSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdStaffDayPrefColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdStaffDayPref"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdStaffDayPrefSortBuilder : SqlSortBuilder<EdStaffDayPrefColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdStaffDayPrefSqlSortBuilder class.
		/// </summary>
		public EdStaffDayPrefSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdStaffDayPrefSortBuilder
	
} // end namespace
