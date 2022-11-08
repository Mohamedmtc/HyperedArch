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
	/// This class is the base class for any <see cref="GsCodeMilitaryStateProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GsCodeMilitaryStateProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.GsCodeMilitaryState, UMIS_VER2.BusinessLyer.GsCodeMilitaryStateKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeMilitaryStateKey key)
		{
			return Delete(transactionManager, key.GsCodeMilitaryStateId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_gsCodeMilitaryStateId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _gsCodeMilitaryStateId)
		{
			return Delete(null, _gsCodeMilitaryStateId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeMilitaryStateId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _gsCodeMilitaryStateId);		
		
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
		public override UMIS_VER2.BusinessLyer.GsCodeMilitaryState Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeMilitaryStateKey key, int start, int pageLength)
		{
			return GetByGsCodeMilitaryStateId(transactionManager, key.GsCodeMilitaryStateId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_GS_CODE_MILITARY_STATE index.
		/// </summary>
		/// <param name="_gsCodeMilitaryStateId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeMilitaryState"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeMilitaryState GetByGsCodeMilitaryStateId(System.Decimal _gsCodeMilitaryStateId)
		{
			int count = -1;
			return GetByGsCodeMilitaryStateId(null,_gsCodeMilitaryStateId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_MILITARY_STATE index.
		/// </summary>
		/// <param name="_gsCodeMilitaryStateId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeMilitaryState"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeMilitaryState GetByGsCodeMilitaryStateId(System.Decimal _gsCodeMilitaryStateId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeMilitaryStateId(null, _gsCodeMilitaryStateId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_MILITARY_STATE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeMilitaryStateId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeMilitaryState"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeMilitaryState GetByGsCodeMilitaryStateId(TransactionManager transactionManager, System.Decimal _gsCodeMilitaryStateId)
		{
			int count = -1;
			return GetByGsCodeMilitaryStateId(transactionManager, _gsCodeMilitaryStateId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_MILITARY_STATE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeMilitaryStateId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeMilitaryState"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeMilitaryState GetByGsCodeMilitaryStateId(TransactionManager transactionManager, System.Decimal _gsCodeMilitaryStateId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeMilitaryStateId(transactionManager, _gsCodeMilitaryStateId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_MILITARY_STATE index.
		/// </summary>
		/// <param name="_gsCodeMilitaryStateId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeMilitaryState"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeMilitaryState GetByGsCodeMilitaryStateId(System.Decimal _gsCodeMilitaryStateId, int start, int pageLength, out int count)
		{
			return GetByGsCodeMilitaryStateId(null, _gsCodeMilitaryStateId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_MILITARY_STATE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeMilitaryStateId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeMilitaryState"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsCodeMilitaryState GetByGsCodeMilitaryStateId(TransactionManager transactionManager, System.Decimal _gsCodeMilitaryStateId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GsCodeMilitaryState&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GsCodeMilitaryState&gt;"/></returns>
		public static TList<GsCodeMilitaryState> Fill(IDataReader reader, TList<GsCodeMilitaryState> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.GsCodeMilitaryState c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GsCodeMilitaryState")
					.Append("|").Append((System.Decimal)reader["GS_CODE_MILITARY_STATE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<GsCodeMilitaryState>(
					key.ToString(), // EntityTrackingKey
					"GsCodeMilitaryState",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.GsCodeMilitaryState();
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
					c.GsCodeMilitaryStateId = (System.Decimal)reader["GS_CODE_MILITARY_STATE_ID"];
					c.OriginalGsCodeMilitaryStateId = c.GsCodeMilitaryStateId;
					c.StateDescrAr = (System.String)reader["STATE_DESCR_AR"];
					c.StateDescrEn = Convert.IsDBNull(reader["STATE_DESCR_EN"]) ? null : (System.String)reader["STATE_DESCR_EN"];
					c.StateCode = Convert.IsDBNull(reader["STATE_CODE"]) ? null : (System.String)reader["STATE_CODE"];
					c.HasExpireDate = (System.Decimal)reader["HAS_EXPIRE_DATE"];
					c.HasResolution = (System.Decimal)reader["HAS_RESOLUTION"];
					c.MinAge = (System.Decimal)reader["MIN_AGE"];
					c.Constant = (System.Decimal)reader["CONSTANT"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCodeMilitaryState"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCodeMilitaryState"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.GsCodeMilitaryState entity)
		{
			if (!reader.Read()) return;
			
			entity.GsCodeMilitaryStateId = (System.Decimal)reader[((int)GsCodeMilitaryStateColumn.GsCodeMilitaryStateId - 1)];
			entity.OriginalGsCodeMilitaryStateId = (System.Decimal)reader["GS_CODE_MILITARY_STATE_ID"];
			entity.StateDescrAr = (System.String)reader[((int)GsCodeMilitaryStateColumn.StateDescrAr - 1)];
			entity.StateDescrEn = (reader.IsDBNull(((int)GsCodeMilitaryStateColumn.StateDescrEn - 1)))?null:(System.String)reader[((int)GsCodeMilitaryStateColumn.StateDescrEn - 1)];
			entity.StateCode = (reader.IsDBNull(((int)GsCodeMilitaryStateColumn.StateCode - 1)))?null:(System.String)reader[((int)GsCodeMilitaryStateColumn.StateCode - 1)];
			entity.HasExpireDate = (System.Decimal)reader[((int)GsCodeMilitaryStateColumn.HasExpireDate - 1)];
			entity.HasResolution = (System.Decimal)reader[((int)GsCodeMilitaryStateColumn.HasResolution - 1)];
			entity.MinAge = (System.Decimal)reader[((int)GsCodeMilitaryStateColumn.MinAge - 1)];
			entity.Constant = (System.Decimal)reader[((int)GsCodeMilitaryStateColumn.Constant - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCodeMilitaryState"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCodeMilitaryState"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.GsCodeMilitaryState entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.GsCodeMilitaryStateId = (System.Decimal)dataRow["GS_CODE_MILITARY_STATE_ID"];
			entity.OriginalGsCodeMilitaryStateId = (System.Decimal)dataRow["GS_CODE_MILITARY_STATE_ID"];
			entity.StateDescrAr = (System.String)dataRow["STATE_DESCR_AR"];
			entity.StateDescrEn = Convert.IsDBNull(dataRow["STATE_DESCR_EN"]) ? null : (System.String)dataRow["STATE_DESCR_EN"];
			entity.StateCode = Convert.IsDBNull(dataRow["STATE_CODE"]) ? null : (System.String)dataRow["STATE_CODE"];
			entity.HasExpireDate = (System.Decimal)dataRow["HAS_EXPIRE_DATE"];
			entity.HasResolution = (System.Decimal)dataRow["HAS_RESOLUTION"];
			entity.MinAge = (System.Decimal)dataRow["MIN_AGE"];
			entity.Constant = (System.Decimal)dataRow["CONSTANT"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCodeMilitaryState"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCodeMilitaryState Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeMilitaryState entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByGsCodeMilitaryStateId methods when available
			
			#region EdStudMilitaryStateCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudMilitaryState>|EdStudMilitaryStateCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudMilitaryStateCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudMilitaryStateCollection = DataRepository.EdStudMilitaryStateProvider.GetByGsCodeMilitaryStateId(transactionManager, entity.GsCodeMilitaryStateId);

				if (deep && entity.EdStudMilitaryStateCollection.Count > 0)
				{
					deepHandles.Add("EdStudMilitaryStateCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudMilitaryState>) DataRepository.EdStudMilitaryStateProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudMilitaryStateCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaMilitaryStatusCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaMilitaryStatus>|SaMilitaryStatusCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaMilitaryStatusCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaMilitaryStatusCollection = DataRepository.SaMilitaryStatusProvider.GetByGsCodeMilitaryStateId(transactionManager, entity.GsCodeMilitaryStateId);

				if (deep && entity.SaMilitaryStatusCollection.Count > 0)
				{
					deepHandles.Add("SaMilitaryStatusCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaMilitaryStatus>) DataRepository.SaMilitaryStatusProvider.DeepLoad,
						new object[] { transactionManager, entity.SaMilitaryStatusCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.GsCodeMilitaryState object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.GsCodeMilitaryState instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCodeMilitaryState Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeMilitaryState entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<EdStudMilitaryState>
				if (CanDeepSave(entity.EdStudMilitaryStateCollection, "List<EdStudMilitaryState>|EdStudMilitaryStateCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudMilitaryState child in entity.EdStudMilitaryStateCollection)
					{
						if(child.GsCodeMilitaryStateIdSource != null)
						{
							child.GsCodeMilitaryStateId = child.GsCodeMilitaryStateIdSource.GsCodeMilitaryStateId;
						}
						else
						{
							child.GsCodeMilitaryStateId = entity.GsCodeMilitaryStateId;
						}

					}

					if (entity.EdStudMilitaryStateCollection.Count > 0 || entity.EdStudMilitaryStateCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudMilitaryStateProvider.Save(transactionManager, entity.EdStudMilitaryStateCollection);
						
						deepHandles.Add("EdStudMilitaryStateCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudMilitaryState >) DataRepository.EdStudMilitaryStateProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudMilitaryStateCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaMilitaryStatus>
				if (CanDeepSave(entity.SaMilitaryStatusCollection, "List<SaMilitaryStatus>|SaMilitaryStatusCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaMilitaryStatus child in entity.SaMilitaryStatusCollection)
					{
						if(child.GsCodeMilitaryStateIdSource != null)
						{
							child.GsCodeMilitaryStateId = child.GsCodeMilitaryStateIdSource.GsCodeMilitaryStateId;
						}
						else
						{
							child.GsCodeMilitaryStateId = entity.GsCodeMilitaryStateId;
						}

					}

					if (entity.SaMilitaryStatusCollection.Count > 0 || entity.SaMilitaryStatusCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaMilitaryStatusProvider.Save(transactionManager, entity.SaMilitaryStatusCollection);
						
						deepHandles.Add("SaMilitaryStatusCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaMilitaryStatus >) DataRepository.SaMilitaryStatusProvider.DeepSave,
							new object[] { transactionManager, entity.SaMilitaryStatusCollection, deepSaveType, childTypes, innerList }
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
	
	#region GsCodeMilitaryStateChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.GsCodeMilitaryState</c>
	///</summary>
	public enum GsCodeMilitaryStateChildEntityTypes
	{
		///<summary>
		/// Collection of <c>GsCodeMilitaryState</c> as OneToMany for EdStudMilitaryStateCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudMilitaryState>))]
		EdStudMilitaryStateCollection,
		///<summary>
		/// Collection of <c>GsCodeMilitaryState</c> as OneToMany for SaMilitaryStatusCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaMilitaryStatus>))]
		SaMilitaryStatusCollection,
	}
	
	#endregion GsCodeMilitaryStateChildEntityTypes
	
	#region GsCodeMilitaryStateFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GsCodeMilitaryStateColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCodeMilitaryState"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCodeMilitaryStateFilterBuilder : SqlFilterBuilder<GsCodeMilitaryStateColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCodeMilitaryStateFilterBuilder class.
		/// </summary>
		public GsCodeMilitaryStateFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCodeMilitaryStateFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCodeMilitaryStateFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCodeMilitaryStateFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCodeMilitaryStateFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCodeMilitaryStateFilterBuilder
	
	#region GsCodeMilitaryStateParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GsCodeMilitaryStateColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCodeMilitaryState"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCodeMilitaryStateParameterBuilder : ParameterizedSqlFilterBuilder<GsCodeMilitaryStateColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCodeMilitaryStateParameterBuilder class.
		/// </summary>
		public GsCodeMilitaryStateParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCodeMilitaryStateParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCodeMilitaryStateParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCodeMilitaryStateParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCodeMilitaryStateParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCodeMilitaryStateParameterBuilder
	
	#region GsCodeMilitaryStateSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GsCodeMilitaryStateColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCodeMilitaryState"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GsCodeMilitaryStateSortBuilder : SqlSortBuilder<GsCodeMilitaryStateColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCodeMilitaryStateSqlSortBuilder class.
		/// </summary>
		public GsCodeMilitaryStateSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GsCodeMilitaryStateSortBuilder
	
} // end namespace
