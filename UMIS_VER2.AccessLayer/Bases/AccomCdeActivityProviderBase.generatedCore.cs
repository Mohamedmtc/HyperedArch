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
	/// This class is the base class for any <see cref="AccomCdeActivityProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AccomCdeActivityProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AccomCdeActivity, UMIS_VER2.BusinessLyer.AccomCdeActivityKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomCdeActivityKey key)
		{
			return Delete(transactionManager, key.AccomCdeActivityId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_accomCdeActivityId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _accomCdeActivityId)
		{
			return Delete(null, _accomCdeActivityId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomCdeActivityId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _accomCdeActivityId);		
		
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
		public override UMIS_VER2.BusinessLyer.AccomCdeActivity Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomCdeActivityKey key, int start, int pageLength)
		{
			return GetByAccomCdeActivityId(transactionManager, key.AccomCdeActivityId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ACCOM_CDE_ACTIVITY index.
		/// </summary>
		/// <param name="_accomCdeActivityId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomCdeActivity"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomCdeActivity GetByAccomCdeActivityId(System.Int32 _accomCdeActivityId)
		{
			int count = -1;
			return GetByAccomCdeActivityId(null,_accomCdeActivityId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_CDE_ACTIVITY index.
		/// </summary>
		/// <param name="_accomCdeActivityId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomCdeActivity"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomCdeActivity GetByAccomCdeActivityId(System.Int32 _accomCdeActivityId, int start, int pageLength)
		{
			int count = -1;
			return GetByAccomCdeActivityId(null, _accomCdeActivityId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_CDE_ACTIVITY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomCdeActivityId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomCdeActivity"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomCdeActivity GetByAccomCdeActivityId(TransactionManager transactionManager, System.Int32 _accomCdeActivityId)
		{
			int count = -1;
			return GetByAccomCdeActivityId(transactionManager, _accomCdeActivityId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_CDE_ACTIVITY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomCdeActivityId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomCdeActivity"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomCdeActivity GetByAccomCdeActivityId(TransactionManager transactionManager, System.Int32 _accomCdeActivityId, int start, int pageLength)
		{
			int count = -1;
			return GetByAccomCdeActivityId(transactionManager, _accomCdeActivityId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_CDE_ACTIVITY index.
		/// </summary>
		/// <param name="_accomCdeActivityId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomCdeActivity"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AccomCdeActivity GetByAccomCdeActivityId(System.Int32 _accomCdeActivityId, int start, int pageLength, out int count)
		{
			return GetByAccomCdeActivityId(null, _accomCdeActivityId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ACCOM_CDE_ACTIVITY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accomCdeActivityId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AccomCdeActivity"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AccomCdeActivity GetByAccomCdeActivityId(TransactionManager transactionManager, System.Int32 _accomCdeActivityId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AccomCdeActivity&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AccomCdeActivity&gt;"/></returns>
		public static TList<AccomCdeActivity> Fill(IDataReader reader, TList<AccomCdeActivity> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AccomCdeActivity c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AccomCdeActivity")
					.Append("|").Append((System.Int32)reader["ACCOM_CDE_ACTIVITY_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AccomCdeActivity>(
					key.ToString(), // EntityTrackingKey
					"AccomCdeActivity",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AccomCdeActivity();
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
					c.AccomCdeActivityId = (System.Int32)reader["ACCOM_CDE_ACTIVITY_ID"];
					c.OriginalAccomCdeActivityId = c.AccomCdeActivityId;
					c.ActvtyDscrAr = (System.String)reader["ACTVTY_DSCR_AR"];
					c.ActvtyDscrEn = Convert.IsDBNull(reader["ACTVTY_DSCR_EN"]) ? null : (System.String)reader["ACTVTY_DSCR_EN"];
					c.MonthId = Convert.IsDBNull(reader["MONTH_ID"]) ? null : (System.Int32?)reader["MONTH_ID"];
					c.ActvtyOrder = Convert.IsDBNull(reader["ACTVTY_ORDER"]) ? null : (System.Int32?)reader["ACTVTY_ORDER"];
					c.IsActive = (System.Boolean)reader["IS_ACTIVE"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AccomCdeActivity"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AccomCdeActivity"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AccomCdeActivity entity)
		{
			if (!reader.Read()) return;
			
			entity.AccomCdeActivityId = (System.Int32)reader[((int)AccomCdeActivityColumn.AccomCdeActivityId - 1)];
			entity.OriginalAccomCdeActivityId = (System.Int32)reader["ACCOM_CDE_ACTIVITY_ID"];
			entity.ActvtyDscrAr = (System.String)reader[((int)AccomCdeActivityColumn.ActvtyDscrAr - 1)];
			entity.ActvtyDscrEn = (reader.IsDBNull(((int)AccomCdeActivityColumn.ActvtyDscrEn - 1)))?null:(System.String)reader[((int)AccomCdeActivityColumn.ActvtyDscrEn - 1)];
			entity.MonthId = (reader.IsDBNull(((int)AccomCdeActivityColumn.MonthId - 1)))?null:(System.Int32?)reader[((int)AccomCdeActivityColumn.MonthId - 1)];
			entity.ActvtyOrder = (reader.IsDBNull(((int)AccomCdeActivityColumn.ActvtyOrder - 1)))?null:(System.Int32?)reader[((int)AccomCdeActivityColumn.ActvtyOrder - 1)];
			entity.IsActive = (System.Boolean)reader[((int)AccomCdeActivityColumn.IsActive - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AccomCdeActivity"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AccomCdeActivity"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AccomCdeActivity entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AccomCdeActivityId = (System.Int32)dataRow["ACCOM_CDE_ACTIVITY_ID"];
			entity.OriginalAccomCdeActivityId = (System.Int32)dataRow["ACCOM_CDE_ACTIVITY_ID"];
			entity.ActvtyDscrAr = (System.String)dataRow["ACTVTY_DSCR_AR"];
			entity.ActvtyDscrEn = Convert.IsDBNull(dataRow["ACTVTY_DSCR_EN"]) ? null : (System.String)dataRow["ACTVTY_DSCR_EN"];
			entity.MonthId = Convert.IsDBNull(dataRow["MONTH_ID"]) ? null : (System.Int32?)dataRow["MONTH_ID"];
			entity.ActvtyOrder = Convert.IsDBNull(dataRow["ACTVTY_ORDER"]) ? null : (System.Int32?)dataRow["ACTVTY_ORDER"];
			entity.IsActive = (System.Boolean)dataRow["IS_ACTIVE"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AccomCdeActivity"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AccomCdeActivity Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomCdeActivity entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByAccomCdeActivityId methods when available
			
			#region AccomAgendaCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AccomAgenda>|AccomAgendaCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AccomAgendaCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AccomAgendaCollection = DataRepository.AccomAgendaProvider.GetByAccomCdeActivityId(transactionManager, entity.AccomCdeActivityId);

				if (deep && entity.AccomAgendaCollection.Count > 0)
				{
					deepHandles.Add("AccomAgendaCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AccomAgenda>) DataRepository.AccomAgendaProvider.DeepLoad,
						new object[] { transactionManager, entity.AccomAgendaCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AccomCdeActivity object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AccomCdeActivity instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AccomCdeActivity Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AccomCdeActivity entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<AccomAgenda>
				if (CanDeepSave(entity.AccomAgendaCollection, "List<AccomAgenda>|AccomAgendaCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AccomAgenda child in entity.AccomAgendaCollection)
					{
						if(child.AccomCdeActivityIdSource != null)
						{
							child.AccomCdeActivityId = child.AccomCdeActivityIdSource.AccomCdeActivityId;
						}
						else
						{
							child.AccomCdeActivityId = entity.AccomCdeActivityId;
						}

					}

					if (entity.AccomAgendaCollection.Count > 0 || entity.AccomAgendaCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AccomAgendaProvider.Save(transactionManager, entity.AccomAgendaCollection);
						
						deepHandles.Add("AccomAgendaCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AccomAgenda >) DataRepository.AccomAgendaProvider.DeepSave,
							new object[] { transactionManager, entity.AccomAgendaCollection, deepSaveType, childTypes, innerList }
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
	
	#region AccomCdeActivityChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AccomCdeActivity</c>
	///</summary>
	public enum AccomCdeActivityChildEntityTypes
	{
		///<summary>
		/// Collection of <c>AccomCdeActivity</c> as OneToMany for AccomAgendaCollection
		///</summary>
		[ChildEntityType(typeof(TList<AccomAgenda>))]
		AccomAgendaCollection,
	}
	
	#endregion AccomCdeActivityChildEntityTypes
	
	#region AccomCdeActivityFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AccomCdeActivityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AccomCdeActivity"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AccomCdeActivityFilterBuilder : SqlFilterBuilder<AccomCdeActivityColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AccomCdeActivityFilterBuilder class.
		/// </summary>
		public AccomCdeActivityFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AccomCdeActivityFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AccomCdeActivityFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AccomCdeActivityFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AccomCdeActivityFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AccomCdeActivityFilterBuilder
	
	#region AccomCdeActivityParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AccomCdeActivityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AccomCdeActivity"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AccomCdeActivityParameterBuilder : ParameterizedSqlFilterBuilder<AccomCdeActivityColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AccomCdeActivityParameterBuilder class.
		/// </summary>
		public AccomCdeActivityParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AccomCdeActivityParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AccomCdeActivityParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AccomCdeActivityParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AccomCdeActivityParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AccomCdeActivityParameterBuilder
	
	#region AccomCdeActivitySortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AccomCdeActivityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AccomCdeActivity"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AccomCdeActivitySortBuilder : SqlSortBuilder<AccomCdeActivityColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AccomCdeActivitySqlSortBuilder class.
		/// </summary>
		public AccomCdeActivitySortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AccomCdeActivitySortBuilder
	
} // end namespace
