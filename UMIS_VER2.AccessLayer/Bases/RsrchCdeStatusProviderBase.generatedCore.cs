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
	/// This class is the base class for any <see cref="RsrchCdeStatusProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class RsrchCdeStatusProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.RsrchCdeStatus, UMIS_VER2.BusinessLyer.RsrchCdeStatusKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.RsrchCdeStatusKey key)
		{
			return Delete(transactionManager, key.RsrchCdeStatusId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_rsrchCdeStatusId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _rsrchCdeStatusId)
		{
			return Delete(null, _rsrchCdeStatusId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_rsrchCdeStatusId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _rsrchCdeStatusId);		
		
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
		public override UMIS_VER2.BusinessLyer.RsrchCdeStatus Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.RsrchCdeStatusKey key, int start, int pageLength)
		{
			return GetByRsrchCdeStatusId(transactionManager, key.RsrchCdeStatusId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_RSRCH_CDE_STATUS index.
		/// </summary>
		/// <param name="_rsrchCdeStatusId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.RsrchCdeStatus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.RsrchCdeStatus GetByRsrchCdeStatusId(System.Int32 _rsrchCdeStatusId)
		{
			int count = -1;
			return GetByRsrchCdeStatusId(null,_rsrchCdeStatusId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_RSRCH_CDE_STATUS index.
		/// </summary>
		/// <param name="_rsrchCdeStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.RsrchCdeStatus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.RsrchCdeStatus GetByRsrchCdeStatusId(System.Int32 _rsrchCdeStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetByRsrchCdeStatusId(null, _rsrchCdeStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_RSRCH_CDE_STATUS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_rsrchCdeStatusId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.RsrchCdeStatus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.RsrchCdeStatus GetByRsrchCdeStatusId(TransactionManager transactionManager, System.Int32 _rsrchCdeStatusId)
		{
			int count = -1;
			return GetByRsrchCdeStatusId(transactionManager, _rsrchCdeStatusId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_RSRCH_CDE_STATUS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_rsrchCdeStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.RsrchCdeStatus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.RsrchCdeStatus GetByRsrchCdeStatusId(TransactionManager transactionManager, System.Int32 _rsrchCdeStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetByRsrchCdeStatusId(transactionManager, _rsrchCdeStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_RSRCH_CDE_STATUS index.
		/// </summary>
		/// <param name="_rsrchCdeStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.RsrchCdeStatus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.RsrchCdeStatus GetByRsrchCdeStatusId(System.Int32 _rsrchCdeStatusId, int start, int pageLength, out int count)
		{
			return GetByRsrchCdeStatusId(null, _rsrchCdeStatusId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_RSRCH_CDE_STATUS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_rsrchCdeStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.RsrchCdeStatus"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.RsrchCdeStatus GetByRsrchCdeStatusId(TransactionManager transactionManager, System.Int32 _rsrchCdeStatusId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;RsrchCdeStatus&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;RsrchCdeStatus&gt;"/></returns>
		public static TList<RsrchCdeStatus> Fill(IDataReader reader, TList<RsrchCdeStatus> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.RsrchCdeStatus c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("RsrchCdeStatus")
					.Append("|").Append((System.Int32)reader["RSRCH_CDE_STATUS_ID"]).ToString();
					c = EntityManager.LocateOrCreate<RsrchCdeStatus>(
					key.ToString(), // EntityTrackingKey
					"RsrchCdeStatus",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.RsrchCdeStatus();
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
					c.RsrchCdeStatusId = (System.Int32)reader["RSRCH_CDE_STATUS_ID"];
					c.OriginalRsrchCdeStatusId = c.RsrchCdeStatusId;
					c.RsrchStatusAr = (System.String)reader["RSRCH_STATUS_AR"];
					c.RsrchStatusEn = (System.String)reader["RSRCH_STATUS_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.RsrchCdeStatus"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.RsrchCdeStatus"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.RsrchCdeStatus entity)
		{
			if (!reader.Read()) return;
			
			entity.RsrchCdeStatusId = (System.Int32)reader[((int)RsrchCdeStatusColumn.RsrchCdeStatusId - 1)];
			entity.OriginalRsrchCdeStatusId = (System.Int32)reader["RSRCH_CDE_STATUS_ID"];
			entity.RsrchStatusAr = (System.String)reader[((int)RsrchCdeStatusColumn.RsrchStatusAr - 1)];
			entity.RsrchStatusEn = (System.String)reader[((int)RsrchCdeStatusColumn.RsrchStatusEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.RsrchCdeStatus"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.RsrchCdeStatus"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.RsrchCdeStatus entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.RsrchCdeStatusId = (System.Int32)dataRow["RSRCH_CDE_STATUS_ID"];
			entity.OriginalRsrchCdeStatusId = (System.Int32)dataRow["RSRCH_CDE_STATUS_ID"];
			entity.RsrchStatusAr = (System.String)dataRow["RSRCH_STATUS_AR"];
			entity.RsrchStatusEn = (System.String)dataRow["RSRCH_STATUS_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.RsrchCdeStatus"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.RsrchCdeStatus Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.RsrchCdeStatus entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByRsrchCdeStatusId methods when available
			
			#region RsrchStudRegisterDtlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<RsrchStudRegisterDtl>|RsrchStudRegisterDtlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'RsrchStudRegisterDtlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.RsrchStudRegisterDtlCollection = DataRepository.RsrchStudRegisterDtlProvider.GetByRsrchCdeStatusId(transactionManager, entity.RsrchCdeStatusId);

				if (deep && entity.RsrchStudRegisterDtlCollection.Count > 0)
				{
					deepHandles.Add("RsrchStudRegisterDtlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<RsrchStudRegisterDtl>) DataRepository.RsrchStudRegisterDtlProvider.DeepLoad,
						new object[] { transactionManager, entity.RsrchStudRegisterDtlCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.RsrchCdeStatus object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.RsrchCdeStatus instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.RsrchCdeStatus Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.RsrchCdeStatus entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<RsrchStudRegisterDtl>
				if (CanDeepSave(entity.RsrchStudRegisterDtlCollection, "List<RsrchStudRegisterDtl>|RsrchStudRegisterDtlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(RsrchStudRegisterDtl child in entity.RsrchStudRegisterDtlCollection)
					{
						if(child.RsrchCdeStatusIdSource != null)
						{
							child.RsrchCdeStatusId = child.RsrchCdeStatusIdSource.RsrchCdeStatusId;
						}
						else
						{
							child.RsrchCdeStatusId = entity.RsrchCdeStatusId;
						}

					}

					if (entity.RsrchStudRegisterDtlCollection.Count > 0 || entity.RsrchStudRegisterDtlCollection.DeletedItems.Count > 0)
					{
						//DataRepository.RsrchStudRegisterDtlProvider.Save(transactionManager, entity.RsrchStudRegisterDtlCollection);
						
						deepHandles.Add("RsrchStudRegisterDtlCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< RsrchStudRegisterDtl >) DataRepository.RsrchStudRegisterDtlProvider.DeepSave,
							new object[] { transactionManager, entity.RsrchStudRegisterDtlCollection, deepSaveType, childTypes, innerList }
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
	
	#region RsrchCdeStatusChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.RsrchCdeStatus</c>
	///</summary>
	public enum RsrchCdeStatusChildEntityTypes
	{
		///<summary>
		/// Collection of <c>RsrchCdeStatus</c> as OneToMany for RsrchStudRegisterDtlCollection
		///</summary>
		[ChildEntityType(typeof(TList<RsrchStudRegisterDtl>))]
		RsrchStudRegisterDtlCollection,
	}
	
	#endregion RsrchCdeStatusChildEntityTypes
	
	#region RsrchCdeStatusFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;RsrchCdeStatusColumn&gt;"/> class
	/// that is used exclusively with a <see cref="RsrchCdeStatus"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class RsrchCdeStatusFilterBuilder : SqlFilterBuilder<RsrchCdeStatusColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the RsrchCdeStatusFilterBuilder class.
		/// </summary>
		public RsrchCdeStatusFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the RsrchCdeStatusFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public RsrchCdeStatusFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the RsrchCdeStatusFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public RsrchCdeStatusFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion RsrchCdeStatusFilterBuilder
	
	#region RsrchCdeStatusParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;RsrchCdeStatusColumn&gt;"/> class
	/// that is used exclusively with a <see cref="RsrchCdeStatus"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class RsrchCdeStatusParameterBuilder : ParameterizedSqlFilterBuilder<RsrchCdeStatusColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the RsrchCdeStatusParameterBuilder class.
		/// </summary>
		public RsrchCdeStatusParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the RsrchCdeStatusParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public RsrchCdeStatusParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the RsrchCdeStatusParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public RsrchCdeStatusParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion RsrchCdeStatusParameterBuilder
	
	#region RsrchCdeStatusSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;RsrchCdeStatusColumn&gt;"/> class
	/// that is used exclusively with a <see cref="RsrchCdeStatus"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class RsrchCdeStatusSortBuilder : SqlSortBuilder<RsrchCdeStatusColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the RsrchCdeStatusSqlSortBuilder class.
		/// </summary>
		public RsrchCdeStatusSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion RsrchCdeStatusSortBuilder
	
} // end namespace
