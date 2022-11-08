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
	/// This class is the base class for any <see cref="CtrMenuPlanProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class CtrMenuPlanProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.CtrMenuPlan, UMIS_VER2.BusinessLyer.CtrMenuPlanKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CtrMenuPlanKey key)
		{
			return Delete(transactionManager, key.CtrMenuPlanId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_ctrMenuPlanId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _ctrMenuPlanId)
		{
			return Delete(null, _ctrMenuPlanId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrMenuPlanId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _ctrMenuPlanId);		
		
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
		public override UMIS_VER2.BusinessLyer.CtrMenuPlan Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CtrMenuPlanKey key, int start, int pageLength)
		{
			return GetByCtrMenuPlanId(transactionManager, key.CtrMenuPlanId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_CTR_MENU_PLAN index.
		/// </summary>
		/// <param name="_ctrMenuPlanId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrMenuPlan"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrMenuPlan GetByCtrMenuPlanId(System.Decimal _ctrMenuPlanId)
		{
			int count = -1;
			return GetByCtrMenuPlanId(null,_ctrMenuPlanId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_MENU_PLAN index.
		/// </summary>
		/// <param name="_ctrMenuPlanId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrMenuPlan"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrMenuPlan GetByCtrMenuPlanId(System.Decimal _ctrMenuPlanId, int start, int pageLength)
		{
			int count = -1;
			return GetByCtrMenuPlanId(null, _ctrMenuPlanId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_MENU_PLAN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrMenuPlanId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrMenuPlan"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrMenuPlan GetByCtrMenuPlanId(TransactionManager transactionManager, System.Decimal _ctrMenuPlanId)
		{
			int count = -1;
			return GetByCtrMenuPlanId(transactionManager, _ctrMenuPlanId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_MENU_PLAN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrMenuPlanId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrMenuPlan"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrMenuPlan GetByCtrMenuPlanId(TransactionManager transactionManager, System.Decimal _ctrMenuPlanId, int start, int pageLength)
		{
			int count = -1;
			return GetByCtrMenuPlanId(transactionManager, _ctrMenuPlanId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_MENU_PLAN index.
		/// </summary>
		/// <param name="_ctrMenuPlanId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrMenuPlan"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrMenuPlan GetByCtrMenuPlanId(System.Decimal _ctrMenuPlanId, int start, int pageLength, out int count)
		{
			return GetByCtrMenuPlanId(null, _ctrMenuPlanId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_MENU_PLAN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrMenuPlanId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrMenuPlan"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.CtrMenuPlan GetByCtrMenuPlanId(TransactionManager transactionManager, System.Decimal _ctrMenuPlanId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;CtrMenuPlan&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;CtrMenuPlan&gt;"/></returns>
		public static TList<CtrMenuPlan> Fill(IDataReader reader, TList<CtrMenuPlan> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.CtrMenuPlan c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("CtrMenuPlan")
					.Append("|").Append((System.Decimal)reader["CTR_MENU_PLAN_ID"]).ToString();
					c = EntityManager.LocateOrCreate<CtrMenuPlan>(
					key.ToString(), // EntityTrackingKey
					"CtrMenuPlan",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.CtrMenuPlan();
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
					c.CtrMenuPlanId = (System.Decimal)reader["CTR_MENU_PLAN_ID"];
					c.OriginalCtrMenuPlanId = c.CtrMenuPlanId;
					c.PlanDt = (System.DateTime)reader["PLAN_DT"];
					c.ExtralMealCount = (System.Decimal)reader["EXTRAL_MEAL_COUNT"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.CtrMenuPlan"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CtrMenuPlan"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.CtrMenuPlan entity)
		{
			if (!reader.Read()) return;
			
			entity.CtrMenuPlanId = (System.Decimal)reader[((int)CtrMenuPlanColumn.CtrMenuPlanId - 1)];
			entity.OriginalCtrMenuPlanId = (System.Decimal)reader["CTR_MENU_PLAN_ID"];
			entity.PlanDt = (System.DateTime)reader[((int)CtrMenuPlanColumn.PlanDt - 1)];
			entity.ExtralMealCount = (System.Decimal)reader[((int)CtrMenuPlanColumn.ExtralMealCount - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.CtrMenuPlan"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CtrMenuPlan"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.CtrMenuPlan entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.CtrMenuPlanId = (System.Decimal)dataRow["CTR_MENU_PLAN_ID"];
			entity.OriginalCtrMenuPlanId = (System.Decimal)dataRow["CTR_MENU_PLAN_ID"];
			entity.PlanDt = (System.DateTime)dataRow["PLAN_DT"];
			entity.ExtralMealCount = (System.Decimal)dataRow["EXTRAL_MEAL_COUNT"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CtrMenuPlan"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.CtrMenuPlan Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CtrMenuPlan entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.CtrMenuPlan object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.CtrMenuPlan instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.CtrMenuPlan Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CtrMenuPlan entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region CtrMenuPlanChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.CtrMenuPlan</c>
	///</summary>
	public enum CtrMenuPlanChildEntityTypes
	{
	}
	
	#endregion CtrMenuPlanChildEntityTypes
	
	#region CtrMenuPlanFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;CtrMenuPlanColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CtrMenuPlan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CtrMenuPlanFilterBuilder : SqlFilterBuilder<CtrMenuPlanColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CtrMenuPlanFilterBuilder class.
		/// </summary>
		public CtrMenuPlanFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CtrMenuPlanFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CtrMenuPlanFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CtrMenuPlanFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CtrMenuPlanFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CtrMenuPlanFilterBuilder
	
	#region CtrMenuPlanParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;CtrMenuPlanColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CtrMenuPlan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CtrMenuPlanParameterBuilder : ParameterizedSqlFilterBuilder<CtrMenuPlanColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CtrMenuPlanParameterBuilder class.
		/// </summary>
		public CtrMenuPlanParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CtrMenuPlanParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CtrMenuPlanParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CtrMenuPlanParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CtrMenuPlanParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CtrMenuPlanParameterBuilder
	
	#region CtrMenuPlanSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;CtrMenuPlanColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CtrMenuPlan"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class CtrMenuPlanSortBuilder : SqlSortBuilder<CtrMenuPlanColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CtrMenuPlanSqlSortBuilder class.
		/// </summary>
		public CtrMenuPlanSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion CtrMenuPlanSortBuilder
	
} // end namespace
