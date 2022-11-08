﻿#region Using directives

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
	/// This class is the base class for any <see cref="ScScheduleHdrDefaultProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class ScScheduleHdrDefaultProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.ScScheduleHdrDefault, UMIS_VER2.BusinessLyer.ScScheduleHdrDefaultKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScScheduleHdrDefaultKey key)
		{
			return Delete(transactionManager, key.Id);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_id">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _id)
		{
			return Delete(null, _id);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _id);		
		
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
		public override UMIS_VER2.BusinessLyer.ScScheduleHdrDefault Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScScheduleHdrDefaultKey key, int start, int pageLength)
		{
			return GetById(transactionManager, key.Id, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SC_SCHEDULE_HDR_DEFAULT index.
		/// </summary>
		/// <param name="_id"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleHdrDefault"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScScheduleHdrDefault GetById(System.Decimal _id)
		{
			int count = -1;
			return GetById(null,_id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_SCHEDULE_HDR_DEFAULT index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleHdrDefault"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScScheduleHdrDefault GetById(System.Decimal _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(null, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_SCHEDULE_HDR_DEFAULT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleHdrDefault"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScScheduleHdrDefault GetById(TransactionManager transactionManager, System.Decimal _id)
		{
			int count = -1;
			return GetById(transactionManager, _id, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_SCHEDULE_HDR_DEFAULT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleHdrDefault"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScScheduleHdrDefault GetById(TransactionManager transactionManager, System.Decimal _id, int start, int pageLength)
		{
			int count = -1;
			return GetById(transactionManager, _id, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_SCHEDULE_HDR_DEFAULT index.
		/// </summary>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleHdrDefault"/> class.</returns>
		public UMIS_VER2.BusinessLyer.ScScheduleHdrDefault GetById(System.Decimal _id, int start, int pageLength, out int count)
		{
			return GetById(null, _id, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SC_SCHEDULE_HDR_DEFAULT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_id"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.ScScheduleHdrDefault"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.ScScheduleHdrDefault GetById(TransactionManager transactionManager, System.Decimal _id, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;ScScheduleHdrDefault&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;ScScheduleHdrDefault&gt;"/></returns>
		public static TList<ScScheduleHdrDefault> Fill(IDataReader reader, TList<ScScheduleHdrDefault> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.ScScheduleHdrDefault c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("ScScheduleHdrDefault")
					.Append("|").Append((System.Decimal)reader["ID"]).ToString();
					c = EntityManager.LocateOrCreate<ScScheduleHdrDefault>(
					key.ToString(), // EntityTrackingKey
					"ScScheduleHdrDefault",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.ScScheduleHdrDefault();
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
					c.Id = (System.Decimal)reader["ID"];
					c.OriginalId = c.Id;
					c.NoSlots = (System.Decimal)reader["NO_SLOTS"];
					c.NoGroups = (System.Decimal)reader["NO_GROUPS"];
					c.NoStudents = (System.Decimal)reader["NO_STUDENTS"];
					c.SlotFrequency = Convert.IsDBNull(reader["SLOT_FREQUENCY"]) ? null : (System.String)reader["SLOT_FREQUENCY"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.ScScheduleHdrDefault"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScScheduleHdrDefault"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.ScScheduleHdrDefault entity)
		{
			if (!reader.Read()) return;
			
			entity.Id = (System.Decimal)reader[((int)ScScheduleHdrDefaultColumn.Id - 1)];
			entity.OriginalId = (System.Decimal)reader["ID"];
			entity.NoSlots = (System.Decimal)reader[((int)ScScheduleHdrDefaultColumn.NoSlots - 1)];
			entity.NoGroups = (System.Decimal)reader[((int)ScScheduleHdrDefaultColumn.NoGroups - 1)];
			entity.NoStudents = (System.Decimal)reader[((int)ScScheduleHdrDefaultColumn.NoStudents - 1)];
			entity.SlotFrequency = (reader.IsDBNull(((int)ScScheduleHdrDefaultColumn.SlotFrequency - 1)))?null:(System.String)reader[((int)ScScheduleHdrDefaultColumn.SlotFrequency - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.ScScheduleHdrDefault"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScScheduleHdrDefault"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.ScScheduleHdrDefault entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.Id = (System.Decimal)dataRow["ID"];
			entity.OriginalId = (System.Decimal)dataRow["ID"];
			entity.NoSlots = (System.Decimal)dataRow["NO_SLOTS"];
			entity.NoGroups = (System.Decimal)dataRow["NO_GROUPS"];
			entity.NoStudents = (System.Decimal)dataRow["NO_STUDENTS"];
			entity.SlotFrequency = Convert.IsDBNull(dataRow["SLOT_FREQUENCY"]) ? null : (System.String)dataRow["SLOT_FREQUENCY"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.ScScheduleHdrDefault"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.ScScheduleHdrDefault Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScScheduleHdrDefault entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.ScScheduleHdrDefault object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.ScScheduleHdrDefault instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.ScScheduleHdrDefault Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.ScScheduleHdrDefault entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region ScScheduleHdrDefaultChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.ScScheduleHdrDefault</c>
	///</summary>
	public enum ScScheduleHdrDefaultChildEntityTypes
	{
	}
	
	#endregion ScScheduleHdrDefaultChildEntityTypes
	
	#region ScScheduleHdrDefaultFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;ScScheduleHdrDefaultColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScScheduleHdrDefault"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ScScheduleHdrDefaultFilterBuilder : SqlFilterBuilder<ScScheduleHdrDefaultColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScScheduleHdrDefaultFilterBuilder class.
		/// </summary>
		public ScScheduleHdrDefaultFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ScScheduleHdrDefaultFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ScScheduleHdrDefaultFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ScScheduleHdrDefaultFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ScScheduleHdrDefaultFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ScScheduleHdrDefaultFilterBuilder
	
	#region ScScheduleHdrDefaultParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;ScScheduleHdrDefaultColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScScheduleHdrDefault"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ScScheduleHdrDefaultParameterBuilder : ParameterizedSqlFilterBuilder<ScScheduleHdrDefaultColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScScheduleHdrDefaultParameterBuilder class.
		/// </summary>
		public ScScheduleHdrDefaultParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ScScheduleHdrDefaultParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ScScheduleHdrDefaultParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ScScheduleHdrDefaultParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ScScheduleHdrDefaultParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ScScheduleHdrDefaultParameterBuilder
	
	#region ScScheduleHdrDefaultSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;ScScheduleHdrDefaultColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ScScheduleHdrDefault"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ScScheduleHdrDefaultSortBuilder : SqlSortBuilder<ScScheduleHdrDefaultColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ScScheduleHdrDefaultSqlSortBuilder class.
		/// </summary>
		public ScScheduleHdrDefaultSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ScScheduleHdrDefaultSortBuilder
	
} // end namespace
