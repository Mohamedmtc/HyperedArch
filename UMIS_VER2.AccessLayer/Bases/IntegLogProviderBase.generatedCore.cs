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
	/// This class is the base class for any <see cref="IntegLogProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class IntegLogProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.IntegLog, UMIS_VER2.BusinessLyer.IntegLogKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.IntegLogKey key)
		{
			return Delete(transactionManager, key.IntegLogId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_integLogId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _integLogId)
		{
			return Delete(null, _integLogId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_integLogId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _integLogId);		
		
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
		public override UMIS_VER2.BusinessLyer.IntegLog Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.IntegLogKey key, int start, int pageLength)
		{
			return GetByIntegLogId(transactionManager, key.IntegLogId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_INTEG_LOG index.
		/// </summary>
		/// <param name="_integLogId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.IntegLog"/> class.</returns>
		public UMIS_VER2.BusinessLyer.IntegLog GetByIntegLogId(System.Decimal _integLogId)
		{
			int count = -1;
			return GetByIntegLogId(null,_integLogId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_INTEG_LOG index.
		/// </summary>
		/// <param name="_integLogId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.IntegLog"/> class.</returns>
		public UMIS_VER2.BusinessLyer.IntegLog GetByIntegLogId(System.Decimal _integLogId, int start, int pageLength)
		{
			int count = -1;
			return GetByIntegLogId(null, _integLogId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_INTEG_LOG index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_integLogId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.IntegLog"/> class.</returns>
		public UMIS_VER2.BusinessLyer.IntegLog GetByIntegLogId(TransactionManager transactionManager, System.Decimal _integLogId)
		{
			int count = -1;
			return GetByIntegLogId(transactionManager, _integLogId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_INTEG_LOG index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_integLogId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.IntegLog"/> class.</returns>
		public UMIS_VER2.BusinessLyer.IntegLog GetByIntegLogId(TransactionManager transactionManager, System.Decimal _integLogId, int start, int pageLength)
		{
			int count = -1;
			return GetByIntegLogId(transactionManager, _integLogId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_INTEG_LOG index.
		/// </summary>
		/// <param name="_integLogId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.IntegLog"/> class.</returns>
		public UMIS_VER2.BusinessLyer.IntegLog GetByIntegLogId(System.Decimal _integLogId, int start, int pageLength, out int count)
		{
			return GetByIntegLogId(null, _integLogId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_INTEG_LOG index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_integLogId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.IntegLog"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.IntegLog GetByIntegLogId(TransactionManager transactionManager, System.Decimal _integLogId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;IntegLog&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;IntegLog&gt;"/></returns>
		public static TList<IntegLog> Fill(IDataReader reader, TList<IntegLog> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.IntegLog c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("IntegLog")
					.Append("|").Append((System.Decimal)reader["INTEG_LOG_ID"]).ToString();
					c = EntityManager.LocateOrCreate<IntegLog>(
					key.ToString(), // EntityTrackingKey
					"IntegLog",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.IntegLog();
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
					c.IntegLogId = (System.Decimal)reader["INTEG_LOG_ID"];
					c.IntegType = (System.String)reader["INTEG_TYPE"];
					c.IntegDescription = Convert.IsDBNull(reader["INTEG_DESCRIPTION"]) ? null : (System.String)reader["INTEG_DESCRIPTION"];
					c.IntegDate = Convert.IsDBNull(reader["INTEG_DATE"]) ? null : (System.DateTime?)reader["INTEG_DATE"];
					c.IntegReason = Convert.IsDBNull(reader["INTEG_REASON"]) ? null : (System.String)reader["INTEG_REASON"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.IntegLog"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.IntegLog"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.IntegLog entity)
		{
			if (!reader.Read()) return;
			
			entity.IntegLogId = (System.Decimal)reader[((int)IntegLogColumn.IntegLogId - 1)];
			entity.IntegType = (System.String)reader[((int)IntegLogColumn.IntegType - 1)];
			entity.IntegDescription = (reader.IsDBNull(((int)IntegLogColumn.IntegDescription - 1)))?null:(System.String)reader[((int)IntegLogColumn.IntegDescription - 1)];
			entity.IntegDate = (reader.IsDBNull(((int)IntegLogColumn.IntegDate - 1)))?null:(System.DateTime?)reader[((int)IntegLogColumn.IntegDate - 1)];
			entity.IntegReason = (reader.IsDBNull(((int)IntegLogColumn.IntegReason - 1)))?null:(System.String)reader[((int)IntegLogColumn.IntegReason - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.IntegLog"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.IntegLog"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.IntegLog entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.IntegLogId = (System.Decimal)dataRow["INTEG_LOG_ID"];
			entity.IntegType = (System.String)dataRow["INTEG_TYPE"];
			entity.IntegDescription = Convert.IsDBNull(dataRow["INTEG_DESCRIPTION"]) ? null : (System.String)dataRow["INTEG_DESCRIPTION"];
			entity.IntegDate = Convert.IsDBNull(dataRow["INTEG_DATE"]) ? null : (System.DateTime?)dataRow["INTEG_DATE"];
			entity.IntegReason = Convert.IsDBNull(dataRow["INTEG_REASON"]) ? null : (System.String)dataRow["INTEG_REASON"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.IntegLog"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.IntegLog Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.IntegLog entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.IntegLog object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.IntegLog instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.IntegLog Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.IntegLog entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region IntegLogChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.IntegLog</c>
	///</summary>
	public enum IntegLogChildEntityTypes
	{
	}
	
	#endregion IntegLogChildEntityTypes
	
	#region IntegLogFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;IntegLogColumn&gt;"/> class
	/// that is used exclusively with a <see cref="IntegLog"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class IntegLogFilterBuilder : SqlFilterBuilder<IntegLogColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the IntegLogFilterBuilder class.
		/// </summary>
		public IntegLogFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the IntegLogFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public IntegLogFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the IntegLogFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public IntegLogFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion IntegLogFilterBuilder
	
	#region IntegLogParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;IntegLogColumn&gt;"/> class
	/// that is used exclusively with a <see cref="IntegLog"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class IntegLogParameterBuilder : ParameterizedSqlFilterBuilder<IntegLogColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the IntegLogParameterBuilder class.
		/// </summary>
		public IntegLogParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the IntegLogParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public IntegLogParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the IntegLogParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public IntegLogParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion IntegLogParameterBuilder
	
	#region IntegLogSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;IntegLogColumn&gt;"/> class
	/// that is used exclusively with a <see cref="IntegLog"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class IntegLogSortBuilder : SqlSortBuilder<IntegLogColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the IntegLogSqlSortBuilder class.
		/// </summary>
		public IntegLogSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion IntegLogSortBuilder
	
} // end namespace
