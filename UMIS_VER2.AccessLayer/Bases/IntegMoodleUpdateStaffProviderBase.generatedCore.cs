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
	/// This class is the base class for any <see cref="IntegMoodleUpdateStaffProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class IntegMoodleUpdateStaffProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.IntegMoodleUpdateStaff, UMIS_VER2.BusinessLyer.IntegMoodleUpdateStaffKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.IntegMoodleUpdateStaffKey key)
		{
			return Delete(transactionManager, key.IntegMoodleUpdateStaffId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_integMoodleUpdateStaffId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _integMoodleUpdateStaffId)
		{
			return Delete(null, _integMoodleUpdateStaffId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_integMoodleUpdateStaffId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _integMoodleUpdateStaffId);		
		
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
		public override UMIS_VER2.BusinessLyer.IntegMoodleUpdateStaff Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.IntegMoodleUpdateStaffKey key, int start, int pageLength)
		{
			return GetByIntegMoodleUpdateStaffId(transactionManager, key.IntegMoodleUpdateStaffId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_INTEG_MOODLE_UpdateStaff index.
		/// </summary>
		/// <param name="_integMoodleUpdateStaffId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.IntegMoodleUpdateStaff"/> class.</returns>
		public UMIS_VER2.BusinessLyer.IntegMoodleUpdateStaff GetByIntegMoodleUpdateStaffId(System.Decimal _integMoodleUpdateStaffId)
		{
			int count = -1;
			return GetByIntegMoodleUpdateStaffId(null,_integMoodleUpdateStaffId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_INTEG_MOODLE_UpdateStaff index.
		/// </summary>
		/// <param name="_integMoodleUpdateStaffId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.IntegMoodleUpdateStaff"/> class.</returns>
		public UMIS_VER2.BusinessLyer.IntegMoodleUpdateStaff GetByIntegMoodleUpdateStaffId(System.Decimal _integMoodleUpdateStaffId, int start, int pageLength)
		{
			int count = -1;
			return GetByIntegMoodleUpdateStaffId(null, _integMoodleUpdateStaffId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_INTEG_MOODLE_UpdateStaff index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_integMoodleUpdateStaffId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.IntegMoodleUpdateStaff"/> class.</returns>
		public UMIS_VER2.BusinessLyer.IntegMoodleUpdateStaff GetByIntegMoodleUpdateStaffId(TransactionManager transactionManager, System.Decimal _integMoodleUpdateStaffId)
		{
			int count = -1;
			return GetByIntegMoodleUpdateStaffId(transactionManager, _integMoodleUpdateStaffId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_INTEG_MOODLE_UpdateStaff index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_integMoodleUpdateStaffId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.IntegMoodleUpdateStaff"/> class.</returns>
		public UMIS_VER2.BusinessLyer.IntegMoodleUpdateStaff GetByIntegMoodleUpdateStaffId(TransactionManager transactionManager, System.Decimal _integMoodleUpdateStaffId, int start, int pageLength)
		{
			int count = -1;
			return GetByIntegMoodleUpdateStaffId(transactionManager, _integMoodleUpdateStaffId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_INTEG_MOODLE_UpdateStaff index.
		/// </summary>
		/// <param name="_integMoodleUpdateStaffId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.IntegMoodleUpdateStaff"/> class.</returns>
		public UMIS_VER2.BusinessLyer.IntegMoodleUpdateStaff GetByIntegMoodleUpdateStaffId(System.Decimal _integMoodleUpdateStaffId, int start, int pageLength, out int count)
		{
			return GetByIntegMoodleUpdateStaffId(null, _integMoodleUpdateStaffId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_INTEG_MOODLE_UpdateStaff index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_integMoodleUpdateStaffId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.IntegMoodleUpdateStaff"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.IntegMoodleUpdateStaff GetByIntegMoodleUpdateStaffId(TransactionManager transactionManager, System.Decimal _integMoodleUpdateStaffId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;IntegMoodleUpdateStaff&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;IntegMoodleUpdateStaff&gt;"/></returns>
		public static TList<IntegMoodleUpdateStaff> Fill(IDataReader reader, TList<IntegMoodleUpdateStaff> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.IntegMoodleUpdateStaff c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("IntegMoodleUpdateStaff")
					.Append("|").Append((System.Decimal)reader["INTEG_MOODLE_UpdateStaff_ID"]).ToString();
					c = EntityManager.LocateOrCreate<IntegMoodleUpdateStaff>(
					key.ToString(), // EntityTrackingKey
					"IntegMoodleUpdateStaff",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.IntegMoodleUpdateStaff();
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
					c.IntegMoodleUpdateStaffId = (System.Decimal)reader["INTEG_MOODLE_UpdateStaff_ID"];
					c.StaffCode = (System.String)reader["STAFF_CODE"];
					c.Username = (System.String)reader["USERNAME"];
					c.FirstName = (System.String)reader["FIRST_NAME"];
					c.LastName = (System.String)reader["LAST_NAME"];
					c.Email = (System.String)reader["EMAIL"];
					c.IsIntegrated = (System.Int32)reader["IS_INTEGRATED"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.IntegMoodleUpdateStaff"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.IntegMoodleUpdateStaff"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.IntegMoodleUpdateStaff entity)
		{
			if (!reader.Read()) return;
			
			entity.IntegMoodleUpdateStaffId = (System.Decimal)reader[((int)IntegMoodleUpdateStaffColumn.IntegMoodleUpdateStaffId - 1)];
			entity.StaffCode = (System.String)reader[((int)IntegMoodleUpdateStaffColumn.StaffCode - 1)];
			entity.Username = (System.String)reader[((int)IntegMoodleUpdateStaffColumn.Username - 1)];
			entity.FirstName = (System.String)reader[((int)IntegMoodleUpdateStaffColumn.FirstName - 1)];
			entity.LastName = (System.String)reader[((int)IntegMoodleUpdateStaffColumn.LastName - 1)];
			entity.Email = (System.String)reader[((int)IntegMoodleUpdateStaffColumn.Email - 1)];
			entity.IsIntegrated = (System.Int32)reader[((int)IntegMoodleUpdateStaffColumn.IsIntegrated - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.IntegMoodleUpdateStaff"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.IntegMoodleUpdateStaff"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.IntegMoodleUpdateStaff entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.IntegMoodleUpdateStaffId = (System.Decimal)dataRow["INTEG_MOODLE_UpdateStaff_ID"];
			entity.StaffCode = (System.String)dataRow["STAFF_CODE"];
			entity.Username = (System.String)dataRow["USERNAME"];
			entity.FirstName = (System.String)dataRow["FIRST_NAME"];
			entity.LastName = (System.String)dataRow["LAST_NAME"];
			entity.Email = (System.String)dataRow["EMAIL"];
			entity.IsIntegrated = (System.Int32)dataRow["IS_INTEGRATED"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.IntegMoodleUpdateStaff"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.IntegMoodleUpdateStaff Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.IntegMoodleUpdateStaff entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.IntegMoodleUpdateStaff object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.IntegMoodleUpdateStaff instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.IntegMoodleUpdateStaff Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.IntegMoodleUpdateStaff entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region IntegMoodleUpdateStaffChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.IntegMoodleUpdateStaff</c>
	///</summary>
	public enum IntegMoodleUpdateStaffChildEntityTypes
	{
	}
	
	#endregion IntegMoodleUpdateStaffChildEntityTypes
	
	#region IntegMoodleUpdateStaffFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;IntegMoodleUpdateStaffColumn&gt;"/> class
	/// that is used exclusively with a <see cref="IntegMoodleUpdateStaff"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class IntegMoodleUpdateStaffFilterBuilder : SqlFilterBuilder<IntegMoodleUpdateStaffColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the IntegMoodleUpdateStaffFilterBuilder class.
		/// </summary>
		public IntegMoodleUpdateStaffFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the IntegMoodleUpdateStaffFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public IntegMoodleUpdateStaffFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the IntegMoodleUpdateStaffFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public IntegMoodleUpdateStaffFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion IntegMoodleUpdateStaffFilterBuilder
	
	#region IntegMoodleUpdateStaffParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;IntegMoodleUpdateStaffColumn&gt;"/> class
	/// that is used exclusively with a <see cref="IntegMoodleUpdateStaff"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class IntegMoodleUpdateStaffParameterBuilder : ParameterizedSqlFilterBuilder<IntegMoodleUpdateStaffColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the IntegMoodleUpdateStaffParameterBuilder class.
		/// </summary>
		public IntegMoodleUpdateStaffParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the IntegMoodleUpdateStaffParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public IntegMoodleUpdateStaffParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the IntegMoodleUpdateStaffParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public IntegMoodleUpdateStaffParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion IntegMoodleUpdateStaffParameterBuilder
	
	#region IntegMoodleUpdateStaffSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;IntegMoodleUpdateStaffColumn&gt;"/> class
	/// that is used exclusively with a <see cref="IntegMoodleUpdateStaff"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class IntegMoodleUpdateStaffSortBuilder : SqlSortBuilder<IntegMoodleUpdateStaffColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the IntegMoodleUpdateStaffSqlSortBuilder class.
		/// </summary>
		public IntegMoodleUpdateStaffSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion IntegMoodleUpdateStaffSortBuilder
	
} // end namespace
