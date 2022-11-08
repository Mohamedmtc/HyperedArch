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
	/// This class is the base class for any <see cref="HrDepartmentProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class HrDepartmentProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.HrDepartment, UMIS_VER2.BusinessLyer.HrDepartmentKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.HrDepartmentKey key)
		{
			return Delete(transactionManager, key.HrDepartmentId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_hrDepartmentId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _hrDepartmentId)
		{
			return Delete(null, _hrDepartmentId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_hrDepartmentId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _hrDepartmentId);		
		
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
		public override UMIS_VER2.BusinessLyer.HrDepartment Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.HrDepartmentKey key, int start, int pageLength)
		{
			return GetByHrDepartmentId(transactionManager, key.HrDepartmentId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key HR_DEPARTMENTS_KEY index.
		/// </summary>
		/// <param name="_hrDepartmentId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.HrDepartment"/> class.</returns>
		public UMIS_VER2.BusinessLyer.HrDepartment GetByHrDepartmentId(System.Decimal _hrDepartmentId)
		{
			int count = -1;
			return GetByHrDepartmentId(null,_hrDepartmentId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the HR_DEPARTMENTS_KEY index.
		/// </summary>
		/// <param name="_hrDepartmentId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.HrDepartment"/> class.</returns>
		public UMIS_VER2.BusinessLyer.HrDepartment GetByHrDepartmentId(System.Decimal _hrDepartmentId, int start, int pageLength)
		{
			int count = -1;
			return GetByHrDepartmentId(null, _hrDepartmentId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the HR_DEPARTMENTS_KEY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_hrDepartmentId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.HrDepartment"/> class.</returns>
		public UMIS_VER2.BusinessLyer.HrDepartment GetByHrDepartmentId(TransactionManager transactionManager, System.Decimal _hrDepartmentId)
		{
			int count = -1;
			return GetByHrDepartmentId(transactionManager, _hrDepartmentId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the HR_DEPARTMENTS_KEY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_hrDepartmentId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.HrDepartment"/> class.</returns>
		public UMIS_VER2.BusinessLyer.HrDepartment GetByHrDepartmentId(TransactionManager transactionManager, System.Decimal _hrDepartmentId, int start, int pageLength)
		{
			int count = -1;
			return GetByHrDepartmentId(transactionManager, _hrDepartmentId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the HR_DEPARTMENTS_KEY index.
		/// </summary>
		/// <param name="_hrDepartmentId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.HrDepartment"/> class.</returns>
		public UMIS_VER2.BusinessLyer.HrDepartment GetByHrDepartmentId(System.Decimal _hrDepartmentId, int start, int pageLength, out int count)
		{
			return GetByHrDepartmentId(null, _hrDepartmentId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the HR_DEPARTMENTS_KEY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_hrDepartmentId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.HrDepartment"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.HrDepartment GetByHrDepartmentId(TransactionManager transactionManager, System.Decimal _hrDepartmentId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;HrDepartment&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;HrDepartment&gt;"/></returns>
		public static TList<HrDepartment> Fill(IDataReader reader, TList<HrDepartment> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.HrDepartment c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("HrDepartment")
					.Append("|").Append((System.Decimal)reader["HR_DEPARTMENT_ID"]).ToString();
					c = EntityManager.LocateOrCreate<HrDepartment>(
					key.ToString(), // EntityTrackingKey
					"HrDepartment",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.HrDepartment();
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
					c.HrDepartmentId = (System.Decimal)reader["HR_DEPARTMENT_ID"];
					c.OriginalHrDepartmentId = c.HrDepartmentId;
					c.Name = (System.String)reader["NAME"];
					c.Value = (System.String)reader["VALUE"];
					c.Issummary = (System.String)reader["ISSUMMARY"];
					c.Description = Convert.IsDBNull(reader["DESCRIPTION"]) ? null : (System.String)reader["DESCRIPTION"];
					c.DeptType = Convert.IsDBNull(reader["DEPT_TYPE"]) ? null : (System.String)reader["DEPT_TYPE"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.HrDepartment"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.HrDepartment"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.HrDepartment entity)
		{
			if (!reader.Read()) return;
			
			entity.HrDepartmentId = (System.Decimal)reader[((int)HrDepartmentColumn.HrDepartmentId - 1)];
			entity.OriginalHrDepartmentId = (System.Decimal)reader["HR_DEPARTMENT_ID"];
			entity.Name = (System.String)reader[((int)HrDepartmentColumn.Name - 1)];
			entity.Value = (System.String)reader[((int)HrDepartmentColumn.Value - 1)];
			entity.Issummary = (System.String)reader[((int)HrDepartmentColumn.Issummary - 1)];
			entity.Description = (reader.IsDBNull(((int)HrDepartmentColumn.Description - 1)))?null:(System.String)reader[((int)HrDepartmentColumn.Description - 1)];
			entity.DeptType = (reader.IsDBNull(((int)HrDepartmentColumn.DeptType - 1)))?null:(System.String)reader[((int)HrDepartmentColumn.DeptType - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.HrDepartment"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.HrDepartment"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.HrDepartment entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.HrDepartmentId = (System.Decimal)dataRow["HR_DEPARTMENT_ID"];
			entity.OriginalHrDepartmentId = (System.Decimal)dataRow["HR_DEPARTMENT_ID"];
			entity.Name = (System.String)dataRow["NAME"];
			entity.Value = (System.String)dataRow["VALUE"];
			entity.Issummary = (System.String)dataRow["ISSUMMARY"];
			entity.Description = Convert.IsDBNull(dataRow["DESCRIPTION"]) ? null : (System.String)dataRow["DESCRIPTION"];
			entity.DeptType = Convert.IsDBNull(dataRow["DEPT_TYPE"]) ? null : (System.String)dataRow["DEPT_TYPE"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.HrDepartment"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.HrDepartment Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.HrDepartment entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.HrDepartment object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.HrDepartment instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.HrDepartment Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.HrDepartment entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region HrDepartmentChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.HrDepartment</c>
	///</summary>
	public enum HrDepartmentChildEntityTypes
	{
	}
	
	#endregion HrDepartmentChildEntityTypes
	
	#region HrDepartmentFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;HrDepartmentColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HrDepartment"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HrDepartmentFilterBuilder : SqlFilterBuilder<HrDepartmentColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HrDepartmentFilterBuilder class.
		/// </summary>
		public HrDepartmentFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the HrDepartmentFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public HrDepartmentFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the HrDepartmentFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public HrDepartmentFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion HrDepartmentFilterBuilder
	
	#region HrDepartmentParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;HrDepartmentColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HrDepartment"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HrDepartmentParameterBuilder : ParameterizedSqlFilterBuilder<HrDepartmentColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HrDepartmentParameterBuilder class.
		/// </summary>
		public HrDepartmentParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the HrDepartmentParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public HrDepartmentParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the HrDepartmentParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public HrDepartmentParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion HrDepartmentParameterBuilder
	
	#region HrDepartmentSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;HrDepartmentColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HrDepartment"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class HrDepartmentSortBuilder : SqlSortBuilder<HrDepartmentColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HrDepartmentSqlSortBuilder class.
		/// </summary>
		public HrDepartmentSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion HrDepartmentSortBuilder
	
} // end namespace
