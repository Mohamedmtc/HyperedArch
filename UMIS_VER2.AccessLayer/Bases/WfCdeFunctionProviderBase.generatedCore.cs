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
	/// This class is the base class for any <see cref="WfCdeFunctionProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class WfCdeFunctionProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.WfCdeFunction, UMIS_VER2.BusinessLyer.WfCdeFunctionKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.WfCdeFunctionKey key)
		{
			return Delete(transactionManager, key.WfCdeFunctionId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_wfCdeFunctionId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _wfCdeFunctionId)
		{
			return Delete(null, _wfCdeFunctionId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_wfCdeFunctionId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _wfCdeFunctionId);		
		
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
		public override UMIS_VER2.BusinessLyer.WfCdeFunction Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.WfCdeFunctionKey key, int start, int pageLength)
		{
			return GetByWfCdeFunctionId(transactionManager, key.WfCdeFunctionId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_WF_CDE_FUNCTION index.
		/// </summary>
		/// <param name="_wfCdeFunctionId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.WfCdeFunction"/> class.</returns>
		public UMIS_VER2.BusinessLyer.WfCdeFunction GetByWfCdeFunctionId(System.Int32 _wfCdeFunctionId)
		{
			int count = -1;
			return GetByWfCdeFunctionId(null,_wfCdeFunctionId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_WF_CDE_FUNCTION index.
		/// </summary>
		/// <param name="_wfCdeFunctionId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.WfCdeFunction"/> class.</returns>
		public UMIS_VER2.BusinessLyer.WfCdeFunction GetByWfCdeFunctionId(System.Int32 _wfCdeFunctionId, int start, int pageLength)
		{
			int count = -1;
			return GetByWfCdeFunctionId(null, _wfCdeFunctionId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_WF_CDE_FUNCTION index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_wfCdeFunctionId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.WfCdeFunction"/> class.</returns>
		public UMIS_VER2.BusinessLyer.WfCdeFunction GetByWfCdeFunctionId(TransactionManager transactionManager, System.Int32 _wfCdeFunctionId)
		{
			int count = -1;
			return GetByWfCdeFunctionId(transactionManager, _wfCdeFunctionId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_WF_CDE_FUNCTION index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_wfCdeFunctionId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.WfCdeFunction"/> class.</returns>
		public UMIS_VER2.BusinessLyer.WfCdeFunction GetByWfCdeFunctionId(TransactionManager transactionManager, System.Int32 _wfCdeFunctionId, int start, int pageLength)
		{
			int count = -1;
			return GetByWfCdeFunctionId(transactionManager, _wfCdeFunctionId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_WF_CDE_FUNCTION index.
		/// </summary>
		/// <param name="_wfCdeFunctionId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.WfCdeFunction"/> class.</returns>
		public UMIS_VER2.BusinessLyer.WfCdeFunction GetByWfCdeFunctionId(System.Int32 _wfCdeFunctionId, int start, int pageLength, out int count)
		{
			return GetByWfCdeFunctionId(null, _wfCdeFunctionId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_WF_CDE_FUNCTION index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_wfCdeFunctionId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.WfCdeFunction"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.WfCdeFunction GetByWfCdeFunctionId(TransactionManager transactionManager, System.Int32 _wfCdeFunctionId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;WfCdeFunction&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;WfCdeFunction&gt;"/></returns>
		public static TList<WfCdeFunction> Fill(IDataReader reader, TList<WfCdeFunction> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.WfCdeFunction c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("WfCdeFunction")
					.Append("|").Append((System.Int32)reader["WF_CDE_FUNCTION_ID"]).ToString();
					c = EntityManager.LocateOrCreate<WfCdeFunction>(
					key.ToString(), // EntityTrackingKey
					"WfCdeFunction",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.WfCdeFunction();
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
					c.WfCdeFunctionId = (System.Int32)reader["WF_CDE_FUNCTION_ID"];
					c.OriginalWfCdeFunctionId = c.WfCdeFunctionId;
					c.FunctionNameAr = Convert.IsDBNull(reader["FUNCTION_NAME_AR"]) ? null : (System.String)reader["FUNCTION_NAME_AR"];
					c.FunctionNameEn = Convert.IsDBNull(reader["FUNCTION_NAME_EN"]) ? null : (System.String)reader["FUNCTION_NAME_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.WfCdeFunction"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.WfCdeFunction"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.WfCdeFunction entity)
		{
			if (!reader.Read()) return;
			
			entity.WfCdeFunctionId = (System.Int32)reader[((int)WfCdeFunctionColumn.WfCdeFunctionId - 1)];
			entity.OriginalWfCdeFunctionId = (System.Int32)reader["WF_CDE_FUNCTION_ID"];
			entity.FunctionNameAr = (reader.IsDBNull(((int)WfCdeFunctionColumn.FunctionNameAr - 1)))?null:(System.String)reader[((int)WfCdeFunctionColumn.FunctionNameAr - 1)];
			entity.FunctionNameEn = (reader.IsDBNull(((int)WfCdeFunctionColumn.FunctionNameEn - 1)))?null:(System.String)reader[((int)WfCdeFunctionColumn.FunctionNameEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.WfCdeFunction"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.WfCdeFunction"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.WfCdeFunction entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.WfCdeFunctionId = (System.Int32)dataRow["WF_CDE_FUNCTION_ID"];
			entity.OriginalWfCdeFunctionId = (System.Int32)dataRow["WF_CDE_FUNCTION_ID"];
			entity.FunctionNameAr = Convert.IsDBNull(dataRow["FUNCTION_NAME_AR"]) ? null : (System.String)dataRow["FUNCTION_NAME_AR"];
			entity.FunctionNameEn = Convert.IsDBNull(dataRow["FUNCTION_NAME_EN"]) ? null : (System.String)dataRow["FUNCTION_NAME_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.WfCdeFunction"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.WfCdeFunction Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.WfCdeFunction entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByWfCdeFunctionId methods when available
			
			#region WfCrsRsltApproveCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<WfCrsRsltApprove>|WfCrsRsltApproveCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'WfCrsRsltApproveCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.WfCrsRsltApproveCollection = DataRepository.WfCrsRsltApproveProvider.GetByWfCdeFunctionId(transactionManager, entity.WfCdeFunctionId);

				if (deep && entity.WfCrsRsltApproveCollection.Count > 0)
				{
					deepHandles.Add("WfCrsRsltApproveCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<WfCrsRsltApprove>) DataRepository.WfCrsRsltApproveProvider.DeepLoad,
						new object[] { transactionManager, entity.WfCrsRsltApproveCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.WfCdeFunction object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.WfCdeFunction instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.WfCdeFunction Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.WfCdeFunction entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<WfCrsRsltApprove>
				if (CanDeepSave(entity.WfCrsRsltApproveCollection, "List<WfCrsRsltApprove>|WfCrsRsltApproveCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(WfCrsRsltApprove child in entity.WfCrsRsltApproveCollection)
					{
						if(child.WfCdeFunctionIdSource != null)
						{
							child.WfCdeFunctionId = child.WfCdeFunctionIdSource.WfCdeFunctionId;
						}
						else
						{
							child.WfCdeFunctionId = entity.WfCdeFunctionId;
						}

					}

					if (entity.WfCrsRsltApproveCollection.Count > 0 || entity.WfCrsRsltApproveCollection.DeletedItems.Count > 0)
					{
						//DataRepository.WfCrsRsltApproveProvider.Save(transactionManager, entity.WfCrsRsltApproveCollection);
						
						deepHandles.Add("WfCrsRsltApproveCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< WfCrsRsltApprove >) DataRepository.WfCrsRsltApproveProvider.DeepSave,
							new object[] { transactionManager, entity.WfCrsRsltApproveCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
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
	
	#region WfCdeFunctionChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.WfCdeFunction</c>
	///</summary>
	public enum WfCdeFunctionChildEntityTypes
	{
		///<summary>
		/// Collection of <c>WfCdeFunction</c> as OneToMany for WfCrsRsltApproveCollection
		///</summary>
		[ChildEntityType(typeof(TList<WfCrsRsltApprove>))]
		WfCrsRsltApproveCollection,
	}
	
	#endregion WfCdeFunctionChildEntityTypes
	
	#region WfCdeFunctionFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;WfCdeFunctionColumn&gt;"/> class
	/// that is used exclusively with a <see cref="WfCdeFunction"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class WfCdeFunctionFilterBuilder : SqlFilterBuilder<WfCdeFunctionColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the WfCdeFunctionFilterBuilder class.
		/// </summary>
		public WfCdeFunctionFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the WfCdeFunctionFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public WfCdeFunctionFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the WfCdeFunctionFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public WfCdeFunctionFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion WfCdeFunctionFilterBuilder
	
	#region WfCdeFunctionParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;WfCdeFunctionColumn&gt;"/> class
	/// that is used exclusively with a <see cref="WfCdeFunction"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class WfCdeFunctionParameterBuilder : ParameterizedSqlFilterBuilder<WfCdeFunctionColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the WfCdeFunctionParameterBuilder class.
		/// </summary>
		public WfCdeFunctionParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the WfCdeFunctionParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public WfCdeFunctionParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the WfCdeFunctionParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public WfCdeFunctionParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion WfCdeFunctionParameterBuilder
	
	#region WfCdeFunctionSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;WfCdeFunctionColumn&gt;"/> class
	/// that is used exclusively with a <see cref="WfCdeFunction"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class WfCdeFunctionSortBuilder : SqlSortBuilder<WfCdeFunctionColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the WfCdeFunctionSqlSortBuilder class.
		/// </summary>
		public WfCdeFunctionSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion WfCdeFunctionSortBuilder
	
} // end namespace
