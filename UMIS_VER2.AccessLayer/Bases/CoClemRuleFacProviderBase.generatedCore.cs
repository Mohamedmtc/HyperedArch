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
	/// This class is the base class for any <see cref="CoClemRuleFacProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class CoClemRuleFacProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.CoClemRuleFac, UMIS_VER2.BusinessLyer.CoClemRuleFacKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CoClemRuleFacKey key)
		{
			return Delete(transactionManager, key.CoClemRuleFacId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_coClemRuleFacId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _coClemRuleFacId)
		{
			return Delete(null, _coClemRuleFacId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coClemRuleFacId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _coClemRuleFacId);		
		
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
		public override UMIS_VER2.BusinessLyer.CoClemRuleFac Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CoClemRuleFacKey key, int start, int pageLength)
		{
			return GetByCoClemRuleFacId(transactionManager, key.CoClemRuleFacId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_CO_CLEM_RULE_FAC index.
		/// </summary>
		/// <param name="_coClemRuleFacId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoClemRuleFac"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoClemRuleFac GetByCoClemRuleFacId(System.Decimal _coClemRuleFacId)
		{
			int count = -1;
			return GetByCoClemRuleFacId(null,_coClemRuleFacId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_CLEM_RULE_FAC index.
		/// </summary>
		/// <param name="_coClemRuleFacId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoClemRuleFac"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoClemRuleFac GetByCoClemRuleFacId(System.Decimal _coClemRuleFacId, int start, int pageLength)
		{
			int count = -1;
			return GetByCoClemRuleFacId(null, _coClemRuleFacId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_CLEM_RULE_FAC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coClemRuleFacId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoClemRuleFac"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoClemRuleFac GetByCoClemRuleFacId(TransactionManager transactionManager, System.Decimal _coClemRuleFacId)
		{
			int count = -1;
			return GetByCoClemRuleFacId(transactionManager, _coClemRuleFacId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_CLEM_RULE_FAC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coClemRuleFacId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoClemRuleFac"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoClemRuleFac GetByCoClemRuleFacId(TransactionManager transactionManager, System.Decimal _coClemRuleFacId, int start, int pageLength)
		{
			int count = -1;
			return GetByCoClemRuleFacId(transactionManager, _coClemRuleFacId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_CLEM_RULE_FAC index.
		/// </summary>
		/// <param name="_coClemRuleFacId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoClemRuleFac"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoClemRuleFac GetByCoClemRuleFacId(System.Decimal _coClemRuleFacId, int start, int pageLength, out int count)
		{
			return GetByCoClemRuleFacId(null, _coClemRuleFacId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_CLEM_RULE_FAC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coClemRuleFacId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoClemRuleFac"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.CoClemRuleFac GetByCoClemRuleFacId(TransactionManager transactionManager, System.Decimal _coClemRuleFacId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;CoClemRuleFac&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;CoClemRuleFac&gt;"/></returns>
		public static TList<CoClemRuleFac> Fill(IDataReader reader, TList<CoClemRuleFac> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.CoClemRuleFac c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("CoClemRuleFac")
					.Append("|").Append((System.Decimal)reader["CO_CLEM_RULE_FAC_ID"]).ToString();
					c = EntityManager.LocateOrCreate<CoClemRuleFac>(
					key.ToString(), // EntityTrackingKey
					"CoClemRuleFac",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.CoClemRuleFac();
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
					c.CoClemRuleFacId = (System.Decimal)reader["CO_CLEM_RULE_FAC_ID"];
					c.OriginalCoClemRuleFacId = c.CoClemRuleFacId;
					c.ClemRule = (System.String)reader["CLEM_RULE"];
					c.ClemType = (System.String)reader["CLEM_TYPE"];
					c.ClemRatio = Convert.IsDBNull(reader["CLEM_RATIO"]) ? null : (System.Decimal?)reader["CLEM_RATIO"];
					c.FuncName = Convert.IsDBNull(reader["FUNC_NAME"]) ? null : (System.String)reader["FUNC_NAME"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.CoClemRuleFac"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CoClemRuleFac"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.CoClemRuleFac entity)
		{
			if (!reader.Read()) return;
			
			entity.CoClemRuleFacId = (System.Decimal)reader[((int)CoClemRuleFacColumn.CoClemRuleFacId - 1)];
			entity.OriginalCoClemRuleFacId = (System.Decimal)reader["CO_CLEM_RULE_FAC_ID"];
			entity.ClemRule = (System.String)reader[((int)CoClemRuleFacColumn.ClemRule - 1)];
			entity.ClemType = (System.String)reader[((int)CoClemRuleFacColumn.ClemType - 1)];
			entity.ClemRatio = (reader.IsDBNull(((int)CoClemRuleFacColumn.ClemRatio - 1)))?null:(System.Decimal?)reader[((int)CoClemRuleFacColumn.ClemRatio - 1)];
			entity.FuncName = (reader.IsDBNull(((int)CoClemRuleFacColumn.FuncName - 1)))?null:(System.String)reader[((int)CoClemRuleFacColumn.FuncName - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.CoClemRuleFac"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CoClemRuleFac"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.CoClemRuleFac entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.CoClemRuleFacId = (System.Decimal)dataRow["CO_CLEM_RULE_FAC_ID"];
			entity.OriginalCoClemRuleFacId = (System.Decimal)dataRow["CO_CLEM_RULE_FAC_ID"];
			entity.ClemRule = (System.String)dataRow["CLEM_RULE"];
			entity.ClemType = (System.String)dataRow["CLEM_TYPE"];
			entity.ClemRatio = Convert.IsDBNull(dataRow["CLEM_RATIO"]) ? null : (System.Decimal?)dataRow["CLEM_RATIO"];
			entity.FuncName = Convert.IsDBNull(dataRow["FUNC_NAME"]) ? null : (System.String)dataRow["FUNC_NAME"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CoClemRuleFac"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.CoClemRuleFac Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CoClemRuleFac entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.CoClemRuleFac object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.CoClemRuleFac instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.CoClemRuleFac Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CoClemRuleFac entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region CoClemRuleFacChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.CoClemRuleFac</c>
	///</summary>
	public enum CoClemRuleFacChildEntityTypes
	{
	}
	
	#endregion CoClemRuleFacChildEntityTypes
	
	#region CoClemRuleFacFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;CoClemRuleFacColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CoClemRuleFac"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CoClemRuleFacFilterBuilder : SqlFilterBuilder<CoClemRuleFacColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CoClemRuleFacFilterBuilder class.
		/// </summary>
		public CoClemRuleFacFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CoClemRuleFacFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CoClemRuleFacFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CoClemRuleFacFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CoClemRuleFacFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CoClemRuleFacFilterBuilder
	
	#region CoClemRuleFacParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;CoClemRuleFacColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CoClemRuleFac"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CoClemRuleFacParameterBuilder : ParameterizedSqlFilterBuilder<CoClemRuleFacColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CoClemRuleFacParameterBuilder class.
		/// </summary>
		public CoClemRuleFacParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CoClemRuleFacParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CoClemRuleFacParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CoClemRuleFacParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CoClemRuleFacParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CoClemRuleFacParameterBuilder
	
	#region CoClemRuleFacSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;CoClemRuleFacColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CoClemRuleFac"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class CoClemRuleFacSortBuilder : SqlSortBuilder<CoClemRuleFacColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CoClemRuleFacSqlSortBuilder class.
		/// </summary>
		public CoClemRuleFacSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion CoClemRuleFacSortBuilder
	
} // end namespace
