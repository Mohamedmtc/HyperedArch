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
	/// This class is the base class for any <see cref="IntegMoodleUnenrolProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class IntegMoodleUnenrolProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.IntegMoodleUnenrol, UMIS_VER2.BusinessLyer.IntegMoodleUnenrolKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.IntegMoodleUnenrolKey key)
		{
			return Delete(transactionManager, key.IntegMoodleUnenrolId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_integMoodleUnenrolId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _integMoodleUnenrolId)
		{
			return Delete(null, _integMoodleUnenrolId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_integMoodleUnenrolId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _integMoodleUnenrolId);		
		
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
		public override UMIS_VER2.BusinessLyer.IntegMoodleUnenrol Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.IntegMoodleUnenrolKey key, int start, int pageLength)
		{
			return GetByIntegMoodleUnenrolId(transactionManager, key.IntegMoodleUnenrolId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_INTEG_MOODLE_UNENROL index.
		/// </summary>
		/// <param name="_integMoodleUnenrolId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.IntegMoodleUnenrol"/> class.</returns>
		public UMIS_VER2.BusinessLyer.IntegMoodleUnenrol GetByIntegMoodleUnenrolId(System.Decimal _integMoodleUnenrolId)
		{
			int count = -1;
			return GetByIntegMoodleUnenrolId(null,_integMoodleUnenrolId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_INTEG_MOODLE_UNENROL index.
		/// </summary>
		/// <param name="_integMoodleUnenrolId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.IntegMoodleUnenrol"/> class.</returns>
		public UMIS_VER2.BusinessLyer.IntegMoodleUnenrol GetByIntegMoodleUnenrolId(System.Decimal _integMoodleUnenrolId, int start, int pageLength)
		{
			int count = -1;
			return GetByIntegMoodleUnenrolId(null, _integMoodleUnenrolId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_INTEG_MOODLE_UNENROL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_integMoodleUnenrolId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.IntegMoodleUnenrol"/> class.</returns>
		public UMIS_VER2.BusinessLyer.IntegMoodleUnenrol GetByIntegMoodleUnenrolId(TransactionManager transactionManager, System.Decimal _integMoodleUnenrolId)
		{
			int count = -1;
			return GetByIntegMoodleUnenrolId(transactionManager, _integMoodleUnenrolId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_INTEG_MOODLE_UNENROL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_integMoodleUnenrolId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.IntegMoodleUnenrol"/> class.</returns>
		public UMIS_VER2.BusinessLyer.IntegMoodleUnenrol GetByIntegMoodleUnenrolId(TransactionManager transactionManager, System.Decimal _integMoodleUnenrolId, int start, int pageLength)
		{
			int count = -1;
			return GetByIntegMoodleUnenrolId(transactionManager, _integMoodleUnenrolId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_INTEG_MOODLE_UNENROL index.
		/// </summary>
		/// <param name="_integMoodleUnenrolId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.IntegMoodleUnenrol"/> class.</returns>
		public UMIS_VER2.BusinessLyer.IntegMoodleUnenrol GetByIntegMoodleUnenrolId(System.Decimal _integMoodleUnenrolId, int start, int pageLength, out int count)
		{
			return GetByIntegMoodleUnenrolId(null, _integMoodleUnenrolId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_INTEG_MOODLE_UNENROL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_integMoodleUnenrolId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.IntegMoodleUnenrol"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.IntegMoodleUnenrol GetByIntegMoodleUnenrolId(TransactionManager transactionManager, System.Decimal _integMoodleUnenrolId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;IntegMoodleUnenrol&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;IntegMoodleUnenrol&gt;"/></returns>
		public static TList<IntegMoodleUnenrol> Fill(IDataReader reader, TList<IntegMoodleUnenrol> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.IntegMoodleUnenrol c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("IntegMoodleUnenrol")
					.Append("|").Append((System.Decimal)reader["INTEG_MOODLE_UNENROL_ID"]).ToString();
					c = EntityManager.LocateOrCreate<IntegMoodleUnenrol>(
					key.ToString(), // EntityTrackingKey
					"IntegMoodleUnenrol",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.IntegMoodleUnenrol();
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
					c.IntegMoodleUnenrolId = (System.Decimal)reader["INTEG_MOODLE_UNENROL_ID"];
					c.CourseCode = (System.String)reader["COURSE_CODE"];
					c.Code = (System.String)reader["CODE"];
					c.UserType = (System.Int32)reader["USER_TYPE"];
					c.SemId = (System.Int32)reader["SEM_ID"];
					c.YearId = (System.Int32)reader["YEAR_ID"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.IntegMoodleUnenrol"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.IntegMoodleUnenrol"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.IntegMoodleUnenrol entity)
		{
			if (!reader.Read()) return;
			
			entity.IntegMoodleUnenrolId = (System.Decimal)reader[((int)IntegMoodleUnenrolColumn.IntegMoodleUnenrolId - 1)];
			entity.CourseCode = (System.String)reader[((int)IntegMoodleUnenrolColumn.CourseCode - 1)];
			entity.Code = (System.String)reader[((int)IntegMoodleUnenrolColumn.Code - 1)];
			entity.UserType = (System.Int32)reader[((int)IntegMoodleUnenrolColumn.UserType - 1)];
			entity.SemId = (System.Int32)reader[((int)IntegMoodleUnenrolColumn.SemId - 1)];
			entity.YearId = (System.Int32)reader[((int)IntegMoodleUnenrolColumn.YearId - 1)];
			entity.IsIntegrated = (System.Int32)reader[((int)IntegMoodleUnenrolColumn.IsIntegrated - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.IntegMoodleUnenrol"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.IntegMoodleUnenrol"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.IntegMoodleUnenrol entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.IntegMoodleUnenrolId = (System.Decimal)dataRow["INTEG_MOODLE_UNENROL_ID"];
			entity.CourseCode = (System.String)dataRow["COURSE_CODE"];
			entity.Code = (System.String)dataRow["CODE"];
			entity.UserType = (System.Int32)dataRow["USER_TYPE"];
			entity.SemId = (System.Int32)dataRow["SEM_ID"];
			entity.YearId = (System.Int32)dataRow["YEAR_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.IntegMoodleUnenrol"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.IntegMoodleUnenrol Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.IntegMoodleUnenrol entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.IntegMoodleUnenrol object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.IntegMoodleUnenrol instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.IntegMoodleUnenrol Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.IntegMoodleUnenrol entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region IntegMoodleUnenrolChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.IntegMoodleUnenrol</c>
	///</summary>
	public enum IntegMoodleUnenrolChildEntityTypes
	{
	}
	
	#endregion IntegMoodleUnenrolChildEntityTypes
	
	#region IntegMoodleUnenrolFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;IntegMoodleUnenrolColumn&gt;"/> class
	/// that is used exclusively with a <see cref="IntegMoodleUnenrol"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class IntegMoodleUnenrolFilterBuilder : SqlFilterBuilder<IntegMoodleUnenrolColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the IntegMoodleUnenrolFilterBuilder class.
		/// </summary>
		public IntegMoodleUnenrolFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the IntegMoodleUnenrolFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public IntegMoodleUnenrolFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the IntegMoodleUnenrolFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public IntegMoodleUnenrolFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion IntegMoodleUnenrolFilterBuilder
	
	#region IntegMoodleUnenrolParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;IntegMoodleUnenrolColumn&gt;"/> class
	/// that is used exclusively with a <see cref="IntegMoodleUnenrol"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class IntegMoodleUnenrolParameterBuilder : ParameterizedSqlFilterBuilder<IntegMoodleUnenrolColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the IntegMoodleUnenrolParameterBuilder class.
		/// </summary>
		public IntegMoodleUnenrolParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the IntegMoodleUnenrolParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public IntegMoodleUnenrolParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the IntegMoodleUnenrolParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public IntegMoodleUnenrolParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion IntegMoodleUnenrolParameterBuilder
	
	#region IntegMoodleUnenrolSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;IntegMoodleUnenrolColumn&gt;"/> class
	/// that is used exclusively with a <see cref="IntegMoodleUnenrol"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class IntegMoodleUnenrolSortBuilder : SqlSortBuilder<IntegMoodleUnenrolColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the IntegMoodleUnenrolSqlSortBuilder class.
		/// </summary>
		public IntegMoodleUnenrolSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion IntegMoodleUnenrolSortBuilder
	
} // end namespace
