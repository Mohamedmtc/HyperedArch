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
	/// This class is the base class for any <see cref="FeeCdeTrnsProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class FeeCdeTrnsProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.FeeCdeTrns, UMIS_VER2.BusinessLyer.FeeCdeTrnsKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeCdeTrnsKey key)
		{
			return Delete(transactionManager, key.FeeCdeTrnsId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_feeCdeTrnsId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _feeCdeTrnsId)
		{
			return Delete(null, _feeCdeTrnsId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeTrnsId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _feeCdeTrnsId);		
		
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
		public override UMIS_VER2.BusinessLyer.FeeCdeTrns Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeCdeTrnsKey key, int start, int pageLength)
		{
			return GetByFeeCdeTrnsId(transactionManager, key.FeeCdeTrnsId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_FEE_CDE_TRNS index.
		/// </summary>
		/// <param name="_feeCdeTrnsId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCdeTrns"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCdeTrns GetByFeeCdeTrnsId(System.Int32 _feeCdeTrnsId)
		{
			int count = -1;
			return GetByFeeCdeTrnsId(null,_feeCdeTrnsId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_CDE_TRNS index.
		/// </summary>
		/// <param name="_feeCdeTrnsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCdeTrns"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCdeTrns GetByFeeCdeTrnsId(System.Int32 _feeCdeTrnsId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCdeTrnsId(null, _feeCdeTrnsId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_CDE_TRNS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeTrnsId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCdeTrns"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCdeTrns GetByFeeCdeTrnsId(TransactionManager transactionManager, System.Int32 _feeCdeTrnsId)
		{
			int count = -1;
			return GetByFeeCdeTrnsId(transactionManager, _feeCdeTrnsId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_CDE_TRNS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeTrnsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCdeTrns"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCdeTrns GetByFeeCdeTrnsId(TransactionManager transactionManager, System.Int32 _feeCdeTrnsId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCdeTrnsId(transactionManager, _feeCdeTrnsId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_CDE_TRNS index.
		/// </summary>
		/// <param name="_feeCdeTrnsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCdeTrns"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCdeTrns GetByFeeCdeTrnsId(System.Int32 _feeCdeTrnsId, int start, int pageLength, out int count)
		{
			return GetByFeeCdeTrnsId(null, _feeCdeTrnsId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_CDE_TRNS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeTrnsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCdeTrns"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.FeeCdeTrns GetByFeeCdeTrnsId(TransactionManager transactionManager, System.Int32 _feeCdeTrnsId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;FeeCdeTrns&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;FeeCdeTrns&gt;"/></returns>
		public static TList<FeeCdeTrns> Fill(IDataReader reader, TList<FeeCdeTrns> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.FeeCdeTrns c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("FeeCdeTrns")
					.Append("|").Append((System.Int32)reader["FEE_CDE_TRNS_ID"]).ToString();
					c = EntityManager.LocateOrCreate<FeeCdeTrns>(
					key.ToString(), // EntityTrackingKey
					"FeeCdeTrns",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.FeeCdeTrns();
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
					c.FeeCdeTrnsId = (System.Int32)reader["FEE_CDE_TRNS_ID"];
					c.OriginalFeeCdeTrnsId = c.FeeCdeTrnsId;
					c.TrnsAr = Convert.IsDBNull(reader["TRNS_AR"]) ? null : (System.String)reader["TRNS_AR"];
					c.TrnsEn = Convert.IsDBNull(reader["TRNS_EN"]) ? null : (System.String)reader["TRNS_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeCdeTrns"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeCdeTrns"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.FeeCdeTrns entity)
		{
			if (!reader.Read()) return;
			
			entity.FeeCdeTrnsId = (System.Int32)reader[((int)FeeCdeTrnsColumn.FeeCdeTrnsId - 1)];
			entity.OriginalFeeCdeTrnsId = (System.Int32)reader["FEE_CDE_TRNS_ID"];
			entity.TrnsAr = (reader.IsDBNull(((int)FeeCdeTrnsColumn.TrnsAr - 1)))?null:(System.String)reader[((int)FeeCdeTrnsColumn.TrnsAr - 1)];
			entity.TrnsEn = (reader.IsDBNull(((int)FeeCdeTrnsColumn.TrnsEn - 1)))?null:(System.String)reader[((int)FeeCdeTrnsColumn.TrnsEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeCdeTrns"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeCdeTrns"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.FeeCdeTrns entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.FeeCdeTrnsId = (System.Int32)dataRow["FEE_CDE_TRNS_ID"];
			entity.OriginalFeeCdeTrnsId = (System.Int32)dataRow["FEE_CDE_TRNS_ID"];
			entity.TrnsAr = Convert.IsDBNull(dataRow["TRNS_AR"]) ? null : (System.String)dataRow["TRNS_AR"];
			entity.TrnsEn = Convert.IsDBNull(dataRow["TRNS_EN"]) ? null : (System.String)dataRow["TRNS_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeCdeTrns"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeCdeTrns Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeCdeTrns entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.FeeCdeTrns object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.FeeCdeTrns instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeCdeTrns Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeCdeTrns entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region FeeCdeTrnsChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.FeeCdeTrns</c>
	///</summary>
	public enum FeeCdeTrnsChildEntityTypes
	{
	}
	
	#endregion FeeCdeTrnsChildEntityTypes
	
	#region FeeCdeTrnsFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;FeeCdeTrnsColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeCdeTrns"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeCdeTrnsFilterBuilder : SqlFilterBuilder<FeeCdeTrnsColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeCdeTrnsFilterBuilder class.
		/// </summary>
		public FeeCdeTrnsFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeCdeTrnsFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeCdeTrnsFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeCdeTrnsFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeCdeTrnsFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeCdeTrnsFilterBuilder
	
	#region FeeCdeTrnsParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;FeeCdeTrnsColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeCdeTrns"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeCdeTrnsParameterBuilder : ParameterizedSqlFilterBuilder<FeeCdeTrnsColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeCdeTrnsParameterBuilder class.
		/// </summary>
		public FeeCdeTrnsParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeCdeTrnsParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeCdeTrnsParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeCdeTrnsParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeCdeTrnsParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeCdeTrnsParameterBuilder
	
	#region FeeCdeTrnsSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;FeeCdeTrnsColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeCdeTrns"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class FeeCdeTrnsSortBuilder : SqlSortBuilder<FeeCdeTrnsColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeCdeTrnsSqlSortBuilder class.
		/// </summary>
		public FeeCdeTrnsSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion FeeCdeTrnsSortBuilder
	
} // end namespace
