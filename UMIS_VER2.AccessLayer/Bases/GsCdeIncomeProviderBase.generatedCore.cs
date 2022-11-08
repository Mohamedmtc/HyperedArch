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
	/// This class is the base class for any <see cref="GsCdeIncomeProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GsCdeIncomeProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.GsCdeIncome, UMIS_VER2.BusinessLyer.GsCdeIncomeKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeIncomeKey key)
		{
			return Delete(transactionManager, key.GsCdeIncomeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_gsCdeIncomeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _gsCdeIncomeId)
		{
			return Delete(null, _gsCdeIncomeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeIncomeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _gsCdeIncomeId);		
		
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
		public override UMIS_VER2.BusinessLyer.GsCdeIncome Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeIncomeKey key, int start, int pageLength)
		{
			return GetByGsCdeIncomeId(transactionManager, key.GsCdeIncomeId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_GS_CDE_INCOME index.
		/// </summary>
		/// <param name="_gsCdeIncomeId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeIncome"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeIncome GetByGsCdeIncomeId(System.Decimal _gsCdeIncomeId)
		{
			int count = -1;
			return GetByGsCdeIncomeId(null,_gsCdeIncomeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_INCOME index.
		/// </summary>
		/// <param name="_gsCdeIncomeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeIncome"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeIncome GetByGsCdeIncomeId(System.Decimal _gsCdeIncomeId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeIncomeId(null, _gsCdeIncomeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_INCOME index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeIncomeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeIncome"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeIncome GetByGsCdeIncomeId(TransactionManager transactionManager, System.Decimal _gsCdeIncomeId)
		{
			int count = -1;
			return GetByGsCdeIncomeId(transactionManager, _gsCdeIncomeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_INCOME index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeIncomeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeIncome"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeIncome GetByGsCdeIncomeId(TransactionManager transactionManager, System.Decimal _gsCdeIncomeId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeIncomeId(transactionManager, _gsCdeIncomeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_INCOME index.
		/// </summary>
		/// <param name="_gsCdeIncomeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeIncome"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeIncome GetByGsCdeIncomeId(System.Decimal _gsCdeIncomeId, int start, int pageLength, out int count)
		{
			return GetByGsCdeIncomeId(null, _gsCdeIncomeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_INCOME index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeIncomeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeIncome"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsCdeIncome GetByGsCdeIncomeId(TransactionManager transactionManager, System.Decimal _gsCdeIncomeId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GsCdeIncome&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GsCdeIncome&gt;"/></returns>
		public static TList<GsCdeIncome> Fill(IDataReader reader, TList<GsCdeIncome> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.GsCdeIncome c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GsCdeIncome")
					.Append("|").Append((System.Decimal)reader["GS_CDE_INCOME_ID"]).ToString();
					c = EntityManager.LocateOrCreate<GsCdeIncome>(
					key.ToString(), // EntityTrackingKey
					"GsCdeIncome",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.GsCdeIncome();
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
					c.GsCdeIncomeId = (System.Decimal)reader["GS_CDE_INCOME_ID"];
					c.OriginalGsCdeIncomeId = c.GsCdeIncomeId;
					c.IncomeDescrAr = (System.String)reader["INCOME_DESCR_AR"];
					c.IncomeDescrEn = (System.String)reader["INCOME_DESCR_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCdeIncome"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCdeIncome"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.GsCdeIncome entity)
		{
			if (!reader.Read()) return;
			
			entity.GsCdeIncomeId = (System.Decimal)reader[((int)GsCdeIncomeColumn.GsCdeIncomeId - 1)];
			entity.OriginalGsCdeIncomeId = (System.Decimal)reader["GS_CDE_INCOME_ID"];
			entity.IncomeDescrAr = (System.String)reader[((int)GsCdeIncomeColumn.IncomeDescrAr - 1)];
			entity.IncomeDescrEn = (System.String)reader[((int)GsCdeIncomeColumn.IncomeDescrEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCdeIncome"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCdeIncome"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.GsCdeIncome entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.GsCdeIncomeId = (System.Decimal)dataRow["GS_CDE_INCOME_ID"];
			entity.OriginalGsCdeIncomeId = (System.Decimal)dataRow["GS_CDE_INCOME_ID"];
			entity.IncomeDescrAr = (System.String)dataRow["INCOME_DESCR_AR"];
			entity.IncomeDescrEn = (System.String)dataRow["INCOME_DESCR_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCdeIncome"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCdeIncome Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeIncome entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.GsCdeIncome object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.GsCdeIncome instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCdeIncome Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeIncome entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region GsCdeIncomeChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.GsCdeIncome</c>
	///</summary>
	public enum GsCdeIncomeChildEntityTypes
	{
	}
	
	#endregion GsCdeIncomeChildEntityTypes
	
	#region GsCdeIncomeFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GsCdeIncomeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCdeIncome"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCdeIncomeFilterBuilder : SqlFilterBuilder<GsCdeIncomeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCdeIncomeFilterBuilder class.
		/// </summary>
		public GsCdeIncomeFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCdeIncomeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCdeIncomeFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCdeIncomeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCdeIncomeFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCdeIncomeFilterBuilder
	
	#region GsCdeIncomeParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GsCdeIncomeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCdeIncome"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCdeIncomeParameterBuilder : ParameterizedSqlFilterBuilder<GsCdeIncomeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCdeIncomeParameterBuilder class.
		/// </summary>
		public GsCdeIncomeParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCdeIncomeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCdeIncomeParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCdeIncomeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCdeIncomeParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCdeIncomeParameterBuilder
	
	#region GsCdeIncomeSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GsCdeIncomeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCdeIncome"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GsCdeIncomeSortBuilder : SqlSortBuilder<GsCdeIncomeColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCdeIncomeSqlSortBuilder class.
		/// </summary>
		public GsCdeIncomeSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GsCdeIncomeSortBuilder
	
} // end namespace
