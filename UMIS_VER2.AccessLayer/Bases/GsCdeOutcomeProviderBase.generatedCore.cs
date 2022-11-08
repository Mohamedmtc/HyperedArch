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
	/// This class is the base class for any <see cref="GsCdeOutcomeProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GsCdeOutcomeProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.GsCdeOutcome, UMIS_VER2.BusinessLyer.GsCdeOutcomeKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeOutcomeKey key)
		{
			return Delete(transactionManager, key.GsCdeOutcomeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_gsCdeOutcomeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _gsCdeOutcomeId)
		{
			return Delete(null, _gsCdeOutcomeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeOutcomeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _gsCdeOutcomeId);		
		
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
		public override UMIS_VER2.BusinessLyer.GsCdeOutcome Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeOutcomeKey key, int start, int pageLength)
		{
			return GetByGsCdeOutcomeId(transactionManager, key.GsCdeOutcomeId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_GS_CDE_OUTCOME index.
		/// </summary>
		/// <param name="_gsCdeOutcomeId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeOutcome"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeOutcome GetByGsCdeOutcomeId(System.Decimal _gsCdeOutcomeId)
		{
			int count = -1;
			return GetByGsCdeOutcomeId(null,_gsCdeOutcomeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_OUTCOME index.
		/// </summary>
		/// <param name="_gsCdeOutcomeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeOutcome"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeOutcome GetByGsCdeOutcomeId(System.Decimal _gsCdeOutcomeId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeOutcomeId(null, _gsCdeOutcomeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_OUTCOME index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeOutcomeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeOutcome"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeOutcome GetByGsCdeOutcomeId(TransactionManager transactionManager, System.Decimal _gsCdeOutcomeId)
		{
			int count = -1;
			return GetByGsCdeOutcomeId(transactionManager, _gsCdeOutcomeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_OUTCOME index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeOutcomeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeOutcome"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeOutcome GetByGsCdeOutcomeId(TransactionManager transactionManager, System.Decimal _gsCdeOutcomeId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeOutcomeId(transactionManager, _gsCdeOutcomeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_OUTCOME index.
		/// </summary>
		/// <param name="_gsCdeOutcomeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeOutcome"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeOutcome GetByGsCdeOutcomeId(System.Decimal _gsCdeOutcomeId, int start, int pageLength, out int count)
		{
			return GetByGsCdeOutcomeId(null, _gsCdeOutcomeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_OUTCOME index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeOutcomeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeOutcome"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsCdeOutcome GetByGsCdeOutcomeId(TransactionManager transactionManager, System.Decimal _gsCdeOutcomeId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GsCdeOutcome&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GsCdeOutcome&gt;"/></returns>
		public static TList<GsCdeOutcome> Fill(IDataReader reader, TList<GsCdeOutcome> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.GsCdeOutcome c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GsCdeOutcome")
					.Append("|").Append((System.Decimal)reader["GS_CDE_OUTCOME_ID"]).ToString();
					c = EntityManager.LocateOrCreate<GsCdeOutcome>(
					key.ToString(), // EntityTrackingKey
					"GsCdeOutcome",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.GsCdeOutcome();
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
					c.GsCdeOutcomeId = (System.Decimal)reader["GS_CDE_OUTCOME_ID"];
					c.OriginalGsCdeOutcomeId = c.GsCdeOutcomeId;
					c.OutcomeDescrAr = (System.String)reader["OUTCOME_DESCR_AR"];
					c.OutcomeDescrEn = (System.String)reader["OUTCOME_DESCR_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCdeOutcome"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCdeOutcome"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.GsCdeOutcome entity)
		{
			if (!reader.Read()) return;
			
			entity.GsCdeOutcomeId = (System.Decimal)reader[((int)GsCdeOutcomeColumn.GsCdeOutcomeId - 1)];
			entity.OriginalGsCdeOutcomeId = (System.Decimal)reader["GS_CDE_OUTCOME_ID"];
			entity.OutcomeDescrAr = (System.String)reader[((int)GsCdeOutcomeColumn.OutcomeDescrAr - 1)];
			entity.OutcomeDescrEn = (System.String)reader[((int)GsCdeOutcomeColumn.OutcomeDescrEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCdeOutcome"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCdeOutcome"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.GsCdeOutcome entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.GsCdeOutcomeId = (System.Decimal)dataRow["GS_CDE_OUTCOME_ID"];
			entity.OriginalGsCdeOutcomeId = (System.Decimal)dataRow["GS_CDE_OUTCOME_ID"];
			entity.OutcomeDescrAr = (System.String)dataRow["OUTCOME_DESCR_AR"];
			entity.OutcomeDescrEn = (System.String)dataRow["OUTCOME_DESCR_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCdeOutcome"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCdeOutcome Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeOutcome entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.GsCdeOutcome object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.GsCdeOutcome instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCdeOutcome Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeOutcome entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region GsCdeOutcomeChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.GsCdeOutcome</c>
	///</summary>
	public enum GsCdeOutcomeChildEntityTypes
	{
	}
	
	#endregion GsCdeOutcomeChildEntityTypes
	
	#region GsCdeOutcomeFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GsCdeOutcomeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCdeOutcome"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCdeOutcomeFilterBuilder : SqlFilterBuilder<GsCdeOutcomeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCdeOutcomeFilterBuilder class.
		/// </summary>
		public GsCdeOutcomeFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCdeOutcomeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCdeOutcomeFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCdeOutcomeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCdeOutcomeFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCdeOutcomeFilterBuilder
	
	#region GsCdeOutcomeParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GsCdeOutcomeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCdeOutcome"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCdeOutcomeParameterBuilder : ParameterizedSqlFilterBuilder<GsCdeOutcomeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCdeOutcomeParameterBuilder class.
		/// </summary>
		public GsCdeOutcomeParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCdeOutcomeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCdeOutcomeParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCdeOutcomeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCdeOutcomeParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCdeOutcomeParameterBuilder
	
	#region GsCdeOutcomeSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GsCdeOutcomeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCdeOutcome"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GsCdeOutcomeSortBuilder : SqlSortBuilder<GsCdeOutcomeColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCdeOutcomeSqlSortBuilder class.
		/// </summary>
		public GsCdeOutcomeSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GsCdeOutcomeSortBuilder
	
} // end namespace
