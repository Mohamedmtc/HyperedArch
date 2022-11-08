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
	/// This class is the base class for any <see cref="SeApplicationAuditProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SeApplicationAuditProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SeApplicationAudit, UMIS_VER2.BusinessLyer.SeApplicationAuditKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeApplicationAuditKey key)
		{
			return Delete(transactionManager, key.SeApplicationAuditId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_seApplicationAuditId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int64 _seApplicationAuditId)
		{
			return Delete(null, _seApplicationAuditId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seApplicationAuditId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int64 _seApplicationAuditId);		
		
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
		public override UMIS_VER2.BusinessLyer.SeApplicationAudit Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeApplicationAuditKey key, int start, int pageLength)
		{
			return GetBySeApplicationAuditId(transactionManager, key.SeApplicationAuditId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK__SE_APPLI__788105F35E735BCE index.
		/// </summary>
		/// <param name="_seApplicationAuditId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeApplicationAudit"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeApplicationAudit GetBySeApplicationAuditId(System.Int64 _seApplicationAuditId)
		{
			int count = -1;
			return GetBySeApplicationAuditId(null,_seApplicationAuditId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__SE_APPLI__788105F35E735BCE index.
		/// </summary>
		/// <param name="_seApplicationAuditId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeApplicationAudit"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeApplicationAudit GetBySeApplicationAuditId(System.Int64 _seApplicationAuditId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeApplicationAuditId(null, _seApplicationAuditId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__SE_APPLI__788105F35E735BCE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seApplicationAuditId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeApplicationAudit"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeApplicationAudit GetBySeApplicationAuditId(TransactionManager transactionManager, System.Int64 _seApplicationAuditId)
		{
			int count = -1;
			return GetBySeApplicationAuditId(transactionManager, _seApplicationAuditId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__SE_APPLI__788105F35E735BCE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seApplicationAuditId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeApplicationAudit"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeApplicationAudit GetBySeApplicationAuditId(TransactionManager transactionManager, System.Int64 _seApplicationAuditId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeApplicationAuditId(transactionManager, _seApplicationAuditId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__SE_APPLI__788105F35E735BCE index.
		/// </summary>
		/// <param name="_seApplicationAuditId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeApplicationAudit"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SeApplicationAudit GetBySeApplicationAuditId(System.Int64 _seApplicationAuditId, int start, int pageLength, out int count)
		{
			return GetBySeApplicationAuditId(null, _seApplicationAuditId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK__SE_APPLI__788105F35E735BCE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seApplicationAuditId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SeApplicationAudit"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SeApplicationAudit GetBySeApplicationAuditId(TransactionManager transactionManager, System.Int64 _seApplicationAuditId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SeApplicationAudit&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SeApplicationAudit&gt;"/></returns>
		public static TList<SeApplicationAudit> Fill(IDataReader reader, TList<SeApplicationAudit> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SeApplicationAudit c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SeApplicationAudit")
					.Append("|").Append((System.Int64)reader["SE_APPLICATION_AUDIT_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SeApplicationAudit>(
					key.ToString(), // EntityTrackingKey
					"SeApplicationAudit",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SeApplicationAudit();
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
					c.SeApplicationAuditId = (System.Int64)reader["SE_APPLICATION_AUDIT_ID"];
					c.AuditDate = (System.DateTime)reader["AUDIT_DATE"];
					c.SysUser = (System.String)reader["SYS_USER"];
					c.Application = (System.String)reader["APPLICATION"];
					c.AuditTableName = (System.String)reader["AUDIT_TABLE_NAME"];
					c.Operation = (System.String)reader["OPERATION"];
					c.PrimaryKey = (System.Int32)reader["PRIMARY_KEY"];
					c.RowDescription = Convert.IsDBNull(reader["ROW_DESCRIPTION"]) ? null : (System.String)reader["ROW_DESCRIPTION"];
					c.SecondaryRow = Convert.IsDBNull(reader["SECONDARY_ROW"]) ? null : (System.String)reader["SECONDARY_ROW"];
					c.AuditColumnName = Convert.IsDBNull(reader["AUDIT_COLUMN_NAME"]) ? null : (System.String)reader["AUDIT_COLUMN_NAME"];
					c.OldValue = Convert.IsDBNull(reader["OLD_VALUE"]) ? null : (System.String)reader["OLD_VALUE"];
					c.NewValue = Convert.IsDBNull(reader["NEW_VALUE"]) ? null : (System.String)reader["NEW_VALUE"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SeApplicationAudit"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SeApplicationAudit"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SeApplicationAudit entity)
		{
			if (!reader.Read()) return;
			
			entity.SeApplicationAuditId = (System.Int64)reader[((int)SeApplicationAuditColumn.SeApplicationAuditId - 1)];
			entity.AuditDate = (System.DateTime)reader[((int)SeApplicationAuditColumn.AuditDate - 1)];
			entity.SysUser = (System.String)reader[((int)SeApplicationAuditColumn.SysUser - 1)];
			entity.Application = (System.String)reader[((int)SeApplicationAuditColumn.Application - 1)];
			entity.AuditTableName = (System.String)reader[((int)SeApplicationAuditColumn.AuditTableName - 1)];
			entity.Operation = (System.String)reader[((int)SeApplicationAuditColumn.Operation - 1)];
			entity.PrimaryKey = (System.Int32)reader[((int)SeApplicationAuditColumn.PrimaryKey - 1)];
			entity.RowDescription = (reader.IsDBNull(((int)SeApplicationAuditColumn.RowDescription - 1)))?null:(System.String)reader[((int)SeApplicationAuditColumn.RowDescription - 1)];
			entity.SecondaryRow = (reader.IsDBNull(((int)SeApplicationAuditColumn.SecondaryRow - 1)))?null:(System.String)reader[((int)SeApplicationAuditColumn.SecondaryRow - 1)];
			entity.AuditColumnName = (reader.IsDBNull(((int)SeApplicationAuditColumn.AuditColumnName - 1)))?null:(System.String)reader[((int)SeApplicationAuditColumn.AuditColumnName - 1)];
			entity.OldValue = (reader.IsDBNull(((int)SeApplicationAuditColumn.OldValue - 1)))?null:(System.String)reader[((int)SeApplicationAuditColumn.OldValue - 1)];
			entity.NewValue = (reader.IsDBNull(((int)SeApplicationAuditColumn.NewValue - 1)))?null:(System.String)reader[((int)SeApplicationAuditColumn.NewValue - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SeApplicationAudit"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SeApplicationAudit"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SeApplicationAudit entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SeApplicationAuditId = (System.Int64)dataRow["SE_APPLICATION_AUDIT_ID"];
			entity.AuditDate = (System.DateTime)dataRow["AUDIT_DATE"];
			entity.SysUser = (System.String)dataRow["SYS_USER"];
			entity.Application = (System.String)dataRow["APPLICATION"];
			entity.AuditTableName = (System.String)dataRow["AUDIT_TABLE_NAME"];
			entity.Operation = (System.String)dataRow["OPERATION"];
			entity.PrimaryKey = (System.Int32)dataRow["PRIMARY_KEY"];
			entity.RowDescription = Convert.IsDBNull(dataRow["ROW_DESCRIPTION"]) ? null : (System.String)dataRow["ROW_DESCRIPTION"];
			entity.SecondaryRow = Convert.IsDBNull(dataRow["SECONDARY_ROW"]) ? null : (System.String)dataRow["SECONDARY_ROW"];
			entity.AuditColumnName = Convert.IsDBNull(dataRow["AUDIT_COLUMN_NAME"]) ? null : (System.String)dataRow["AUDIT_COLUMN_NAME"];
			entity.OldValue = Convert.IsDBNull(dataRow["OLD_VALUE"]) ? null : (System.String)dataRow["OLD_VALUE"];
			entity.NewValue = Convert.IsDBNull(dataRow["NEW_VALUE"]) ? null : (System.String)dataRow["NEW_VALUE"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SeApplicationAudit"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SeApplicationAudit Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeApplicationAudit entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SeApplicationAudit object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SeApplicationAudit instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SeApplicationAudit Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeApplicationAudit entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region SeApplicationAuditChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SeApplicationAudit</c>
	///</summary>
	public enum SeApplicationAuditChildEntityTypes
	{
	}
	
	#endregion SeApplicationAuditChildEntityTypes
	
	#region SeApplicationAuditFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SeApplicationAuditColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SeApplicationAudit"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SeApplicationAuditFilterBuilder : SqlFilterBuilder<SeApplicationAuditColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SeApplicationAuditFilterBuilder class.
		/// </summary>
		public SeApplicationAuditFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SeApplicationAuditFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SeApplicationAuditFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SeApplicationAuditFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SeApplicationAuditFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SeApplicationAuditFilterBuilder
	
	#region SeApplicationAuditParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SeApplicationAuditColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SeApplicationAudit"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SeApplicationAuditParameterBuilder : ParameterizedSqlFilterBuilder<SeApplicationAuditColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SeApplicationAuditParameterBuilder class.
		/// </summary>
		public SeApplicationAuditParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SeApplicationAuditParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SeApplicationAuditParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SeApplicationAuditParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SeApplicationAuditParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SeApplicationAuditParameterBuilder
	
	#region SeApplicationAuditSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SeApplicationAuditColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SeApplicationAudit"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SeApplicationAuditSortBuilder : SqlSortBuilder<SeApplicationAuditColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SeApplicationAuditSqlSortBuilder class.
		/// </summary>
		public SeApplicationAuditSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SeApplicationAuditSortBuilder
	
} // end namespace
