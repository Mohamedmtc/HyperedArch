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
	/// This class is the base class for any <see cref="WfCdeActionProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class WfCdeActionProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.WfCdeAction, UMIS_VER2.BusinessLyer.WfCdeActionKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.WfCdeActionKey key)
		{
			return Delete(transactionManager, key.WfCdeActionId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_wfCdeActionId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _wfCdeActionId)
		{
			return Delete(null, _wfCdeActionId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_wfCdeActionId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _wfCdeActionId);		
		
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
		public override UMIS_VER2.BusinessLyer.WfCdeAction Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.WfCdeActionKey key, int start, int pageLength)
		{
			return GetByWfCdeActionId(transactionManager, key.WfCdeActionId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_WF_CDE_ACTION index.
		/// </summary>
		/// <param name="_wfCdeActionId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.WfCdeAction"/> class.</returns>
		public UMIS_VER2.BusinessLyer.WfCdeAction GetByWfCdeActionId(System.Int32 _wfCdeActionId)
		{
			int count = -1;
			return GetByWfCdeActionId(null,_wfCdeActionId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_WF_CDE_ACTION index.
		/// </summary>
		/// <param name="_wfCdeActionId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.WfCdeAction"/> class.</returns>
		public UMIS_VER2.BusinessLyer.WfCdeAction GetByWfCdeActionId(System.Int32 _wfCdeActionId, int start, int pageLength)
		{
			int count = -1;
			return GetByWfCdeActionId(null, _wfCdeActionId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_WF_CDE_ACTION index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_wfCdeActionId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.WfCdeAction"/> class.</returns>
		public UMIS_VER2.BusinessLyer.WfCdeAction GetByWfCdeActionId(TransactionManager transactionManager, System.Int32 _wfCdeActionId)
		{
			int count = -1;
			return GetByWfCdeActionId(transactionManager, _wfCdeActionId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_WF_CDE_ACTION index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_wfCdeActionId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.WfCdeAction"/> class.</returns>
		public UMIS_VER2.BusinessLyer.WfCdeAction GetByWfCdeActionId(TransactionManager transactionManager, System.Int32 _wfCdeActionId, int start, int pageLength)
		{
			int count = -1;
			return GetByWfCdeActionId(transactionManager, _wfCdeActionId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_WF_CDE_ACTION index.
		/// </summary>
		/// <param name="_wfCdeActionId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.WfCdeAction"/> class.</returns>
		public UMIS_VER2.BusinessLyer.WfCdeAction GetByWfCdeActionId(System.Int32 _wfCdeActionId, int start, int pageLength, out int count)
		{
			return GetByWfCdeActionId(null, _wfCdeActionId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_WF_CDE_ACTION index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_wfCdeActionId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.WfCdeAction"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.WfCdeAction GetByWfCdeActionId(TransactionManager transactionManager, System.Int32 _wfCdeActionId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;WfCdeAction&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;WfCdeAction&gt;"/></returns>
		public static TList<WfCdeAction> Fill(IDataReader reader, TList<WfCdeAction> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.WfCdeAction c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("WfCdeAction")
					.Append("|").Append((System.Int32)reader["WF_CDE_ACTION_ID"]).ToString();
					c = EntityManager.LocateOrCreate<WfCdeAction>(
					key.ToString(), // EntityTrackingKey
					"WfCdeAction",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.WfCdeAction();
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
					c.WfCdeActionId = (System.Int32)reader["WF_CDE_ACTION_ID"];
					c.OriginalWfCdeActionId = c.WfCdeActionId;
					c.ActionAr = Convert.IsDBNull(reader["ACTION_AR"]) ? null : (System.String)reader["ACTION_AR"];
					c.ActionEn = Convert.IsDBNull(reader["ACTION_EN"]) ? null : (System.String)reader["ACTION_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.WfCdeAction"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.WfCdeAction"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.WfCdeAction entity)
		{
			if (!reader.Read()) return;
			
			entity.WfCdeActionId = (System.Int32)reader[((int)WfCdeActionColumn.WfCdeActionId - 1)];
			entity.OriginalWfCdeActionId = (System.Int32)reader["WF_CDE_ACTION_ID"];
			entity.ActionAr = (reader.IsDBNull(((int)WfCdeActionColumn.ActionAr - 1)))?null:(System.String)reader[((int)WfCdeActionColumn.ActionAr - 1)];
			entity.ActionEn = (reader.IsDBNull(((int)WfCdeActionColumn.ActionEn - 1)))?null:(System.String)reader[((int)WfCdeActionColumn.ActionEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.WfCdeAction"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.WfCdeAction"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.WfCdeAction entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.WfCdeActionId = (System.Int32)dataRow["WF_CDE_ACTION_ID"];
			entity.OriginalWfCdeActionId = (System.Int32)dataRow["WF_CDE_ACTION_ID"];
			entity.ActionAr = Convert.IsDBNull(dataRow["ACTION_AR"]) ? null : (System.String)dataRow["ACTION_AR"];
			entity.ActionEn = Convert.IsDBNull(dataRow["ACTION_EN"]) ? null : (System.String)dataRow["ACTION_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.WfCdeAction"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.WfCdeAction Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.WfCdeAction entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByWfCdeActionId methods when available
			
			#region WfCrsRsltApproveCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<WfCrsRsltApprove>|WfCrsRsltApproveCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'WfCrsRsltApproveCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.WfCrsRsltApproveCollection = DataRepository.WfCrsRsltApproveProvider.GetByWfCdeActionId(transactionManager, entity.WfCdeActionId);

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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.WfCdeAction object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.WfCdeAction instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.WfCdeAction Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.WfCdeAction entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
						if(child.WfCdeActionIdSource != null)
						{
							child.WfCdeActionId = child.WfCdeActionIdSource.WfCdeActionId;
						}
						else
						{
							child.WfCdeActionId = entity.WfCdeActionId;
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
	
	#region WfCdeActionChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.WfCdeAction</c>
	///</summary>
	public enum WfCdeActionChildEntityTypes
	{
		///<summary>
		/// Collection of <c>WfCdeAction</c> as OneToMany for WfCrsRsltApproveCollection
		///</summary>
		[ChildEntityType(typeof(TList<WfCrsRsltApprove>))]
		WfCrsRsltApproveCollection,
	}
	
	#endregion WfCdeActionChildEntityTypes
	
	#region WfCdeActionFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;WfCdeActionColumn&gt;"/> class
	/// that is used exclusively with a <see cref="WfCdeAction"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class WfCdeActionFilterBuilder : SqlFilterBuilder<WfCdeActionColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the WfCdeActionFilterBuilder class.
		/// </summary>
		public WfCdeActionFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the WfCdeActionFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public WfCdeActionFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the WfCdeActionFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public WfCdeActionFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion WfCdeActionFilterBuilder
	
	#region WfCdeActionParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;WfCdeActionColumn&gt;"/> class
	/// that is used exclusively with a <see cref="WfCdeAction"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class WfCdeActionParameterBuilder : ParameterizedSqlFilterBuilder<WfCdeActionColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the WfCdeActionParameterBuilder class.
		/// </summary>
		public WfCdeActionParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the WfCdeActionParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public WfCdeActionParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the WfCdeActionParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public WfCdeActionParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion WfCdeActionParameterBuilder
	
	#region WfCdeActionSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;WfCdeActionColumn&gt;"/> class
	/// that is used exclusively with a <see cref="WfCdeAction"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class WfCdeActionSortBuilder : SqlSortBuilder<WfCdeActionColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the WfCdeActionSqlSortBuilder class.
		/// </summary>
		public WfCdeActionSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion WfCdeActionSortBuilder
	
} // end namespace
