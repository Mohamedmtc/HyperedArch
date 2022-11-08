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
	/// This class is the base class for any <see cref="SvCdeTaskStatusProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SvCdeTaskStatusProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SvCdeTaskStatus, UMIS_VER2.BusinessLyer.SvCdeTaskStatusKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvCdeTaskStatusKey key)
		{
			return Delete(transactionManager, key.SvCdeTaskStatusId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_svCdeTaskStatusId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _svCdeTaskStatusId)
		{
			return Delete(null, _svCdeTaskStatusId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeTaskStatusId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _svCdeTaskStatusId);		
		
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
		public override UMIS_VER2.BusinessLyer.SvCdeTaskStatus Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvCdeTaskStatusKey key, int start, int pageLength)
		{
			return GetBySvCdeTaskStatusId(transactionManager, key.SvCdeTaskStatusId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SV_CDE_TASK_STATUS index.
		/// </summary>
		/// <param name="_svCdeTaskStatusId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeTaskStatus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCdeTaskStatus GetBySvCdeTaskStatusId(System.Int32 _svCdeTaskStatusId)
		{
			int count = -1;
			return GetBySvCdeTaskStatusId(null,_svCdeTaskStatusId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_CDE_TASK_STATUS index.
		/// </summary>
		/// <param name="_svCdeTaskStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeTaskStatus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCdeTaskStatus GetBySvCdeTaskStatusId(System.Int32 _svCdeTaskStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvCdeTaskStatusId(null, _svCdeTaskStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_CDE_TASK_STATUS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeTaskStatusId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeTaskStatus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCdeTaskStatus GetBySvCdeTaskStatusId(TransactionManager transactionManager, System.Int32 _svCdeTaskStatusId)
		{
			int count = -1;
			return GetBySvCdeTaskStatusId(transactionManager, _svCdeTaskStatusId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_CDE_TASK_STATUS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeTaskStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeTaskStatus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCdeTaskStatus GetBySvCdeTaskStatusId(TransactionManager transactionManager, System.Int32 _svCdeTaskStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetBySvCdeTaskStatusId(transactionManager, _svCdeTaskStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_CDE_TASK_STATUS index.
		/// </summary>
		/// <param name="_svCdeTaskStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeTaskStatus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SvCdeTaskStatus GetBySvCdeTaskStatusId(System.Int32 _svCdeTaskStatusId, int start, int pageLength, out int count)
		{
			return GetBySvCdeTaskStatusId(null, _svCdeTaskStatusId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SV_CDE_TASK_STATUS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_svCdeTaskStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SvCdeTaskStatus"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SvCdeTaskStatus GetBySvCdeTaskStatusId(TransactionManager transactionManager, System.Int32 _svCdeTaskStatusId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SvCdeTaskStatus&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SvCdeTaskStatus&gt;"/></returns>
		public static TList<SvCdeTaskStatus> Fill(IDataReader reader, TList<SvCdeTaskStatus> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SvCdeTaskStatus c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SvCdeTaskStatus")
					.Append("|").Append((System.Int32)reader["SV_CDE_TASK_STATUS_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SvCdeTaskStatus>(
					key.ToString(), // EntityTrackingKey
					"SvCdeTaskStatus",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SvCdeTaskStatus();
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
					c.SvCdeTaskStatusId = (System.Int32)reader["SV_CDE_TASK_STATUS_ID"];
					c.OriginalSvCdeTaskStatusId = c.SvCdeTaskStatusId;
					c.StatusAr = Convert.IsDBNull(reader["STATUS_AR"]) ? null : (System.String)reader["STATUS_AR"];
					c.StatusEn = Convert.IsDBNull(reader["STATUS_EN"]) ? null : (System.String)reader["STATUS_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SvCdeTaskStatus"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvCdeTaskStatus"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SvCdeTaskStatus entity)
		{
			if (!reader.Read()) return;
			
			entity.SvCdeTaskStatusId = (System.Int32)reader[((int)SvCdeTaskStatusColumn.SvCdeTaskStatusId - 1)];
			entity.OriginalSvCdeTaskStatusId = (System.Int32)reader["SV_CDE_TASK_STATUS_ID"];
			entity.StatusAr = (reader.IsDBNull(((int)SvCdeTaskStatusColumn.StatusAr - 1)))?null:(System.String)reader[((int)SvCdeTaskStatusColumn.StatusAr - 1)];
			entity.StatusEn = (reader.IsDBNull(((int)SvCdeTaskStatusColumn.StatusEn - 1)))?null:(System.String)reader[((int)SvCdeTaskStatusColumn.StatusEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SvCdeTaskStatus"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvCdeTaskStatus"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SvCdeTaskStatus entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SvCdeTaskStatusId = (System.Int32)dataRow["SV_CDE_TASK_STATUS_ID"];
			entity.OriginalSvCdeTaskStatusId = (System.Int32)dataRow["SV_CDE_TASK_STATUS_ID"];
			entity.StatusAr = Convert.IsDBNull(dataRow["STATUS_AR"]) ? null : (System.String)dataRow["STATUS_AR"];
			entity.StatusEn = Convert.IsDBNull(dataRow["STATUS_EN"]) ? null : (System.String)dataRow["STATUS_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SvCdeTaskStatus"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SvCdeTaskStatus Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvCdeTaskStatus entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetBySvCdeTaskStatusId methods when available
			
			#region SvUserTaskCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvUserTask>|SvUserTaskCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvUserTaskCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvUserTaskCollection = DataRepository.SvUserTaskProvider.GetBySvCdeTaskStatusId(transactionManager, entity.SvCdeTaskStatusId);

				if (deep && entity.SvUserTaskCollection.Count > 0)
				{
					deepHandles.Add("SvUserTaskCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvUserTask>) DataRepository.SvUserTaskProvider.DeepLoad,
						new object[] { transactionManager, entity.SvUserTaskCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SvCdeTaskStatus object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SvCdeTaskStatus instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SvCdeTaskStatus Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SvCdeTaskStatus entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<SvUserTask>
				if (CanDeepSave(entity.SvUserTaskCollection, "List<SvUserTask>|SvUserTaskCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvUserTask child in entity.SvUserTaskCollection)
					{
						if(child.SvCdeTaskStatusIdSource != null)
						{
							child.SvCdeTaskStatusId = child.SvCdeTaskStatusIdSource.SvCdeTaskStatusId;
						}
						else
						{
							child.SvCdeTaskStatusId = entity.SvCdeTaskStatusId;
						}

					}

					if (entity.SvUserTaskCollection.Count > 0 || entity.SvUserTaskCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvUserTaskProvider.Save(transactionManager, entity.SvUserTaskCollection);
						
						deepHandles.Add("SvUserTaskCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvUserTask >) DataRepository.SvUserTaskProvider.DeepSave,
							new object[] { transactionManager, entity.SvUserTaskCollection, deepSaveType, childTypes, innerList }
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
	
	#region SvCdeTaskStatusChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SvCdeTaskStatus</c>
	///</summary>
	public enum SvCdeTaskStatusChildEntityTypes
	{
		///<summary>
		/// Collection of <c>SvCdeTaskStatus</c> as OneToMany for SvUserTaskCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvUserTask>))]
		SvUserTaskCollection,
	}
	
	#endregion SvCdeTaskStatusChildEntityTypes
	
	#region SvCdeTaskStatusFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SvCdeTaskStatusColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvCdeTaskStatus"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SvCdeTaskStatusFilterBuilder : SqlFilterBuilder<SvCdeTaskStatusColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvCdeTaskStatusFilterBuilder class.
		/// </summary>
		public SvCdeTaskStatusFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SvCdeTaskStatusFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SvCdeTaskStatusFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SvCdeTaskStatusFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SvCdeTaskStatusFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SvCdeTaskStatusFilterBuilder
	
	#region SvCdeTaskStatusParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SvCdeTaskStatusColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvCdeTaskStatus"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SvCdeTaskStatusParameterBuilder : ParameterizedSqlFilterBuilder<SvCdeTaskStatusColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvCdeTaskStatusParameterBuilder class.
		/// </summary>
		public SvCdeTaskStatusParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SvCdeTaskStatusParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SvCdeTaskStatusParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SvCdeTaskStatusParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SvCdeTaskStatusParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SvCdeTaskStatusParameterBuilder
	
	#region SvCdeTaskStatusSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SvCdeTaskStatusColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SvCdeTaskStatus"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SvCdeTaskStatusSortBuilder : SqlSortBuilder<SvCdeTaskStatusColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SvCdeTaskStatusSqlSortBuilder class.
		/// </summary>
		public SvCdeTaskStatusSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SvCdeTaskStatusSortBuilder
	
} // end namespace
