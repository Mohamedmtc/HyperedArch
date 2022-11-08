﻿#region Using directives

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
	/// This class is the base class for any <see cref="AdmCdeStatusRsnProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AdmCdeStatusRsnProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AdmCdeStatusRsn, UMIS_VER2.BusinessLyer.AdmCdeStatusRsnKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmCdeStatusRsnKey key)
		{
			return Delete(transactionManager, key.AdmCdeStatusRsnId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_admCdeStatusRsnId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _admCdeStatusRsnId)
		{
			return Delete(null, _admCdeStatusRsnId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeStatusRsnId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _admCdeStatusRsnId);		
		
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
		public override UMIS_VER2.BusinessLyer.AdmCdeStatusRsn Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmCdeStatusRsnKey key, int start, int pageLength)
		{
			return GetByAdmCdeStatusRsnId(transactionManager, key.AdmCdeStatusRsnId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ADM_CDE_STATUS_RSN index.
		/// </summary>
		/// <param name="_admCdeStatusRsnId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdeStatusRsn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCdeStatusRsn GetByAdmCdeStatusRsnId(System.Int32 _admCdeStatusRsnId)
		{
			int count = -1;
			return GetByAdmCdeStatusRsnId(null,_admCdeStatusRsnId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_CDE_STATUS_RSN index.
		/// </summary>
		/// <param name="_admCdeStatusRsnId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdeStatusRsn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCdeStatusRsn GetByAdmCdeStatusRsnId(System.Int32 _admCdeStatusRsnId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCdeStatusRsnId(null, _admCdeStatusRsnId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_CDE_STATUS_RSN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeStatusRsnId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdeStatusRsn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCdeStatusRsn GetByAdmCdeStatusRsnId(TransactionManager transactionManager, System.Int32 _admCdeStatusRsnId)
		{
			int count = -1;
			return GetByAdmCdeStatusRsnId(transactionManager, _admCdeStatusRsnId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_CDE_STATUS_RSN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeStatusRsnId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdeStatusRsn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCdeStatusRsn GetByAdmCdeStatusRsnId(TransactionManager transactionManager, System.Int32 _admCdeStatusRsnId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCdeStatusRsnId(transactionManager, _admCdeStatusRsnId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_CDE_STATUS_RSN index.
		/// </summary>
		/// <param name="_admCdeStatusRsnId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdeStatusRsn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmCdeStatusRsn GetByAdmCdeStatusRsnId(System.Int32 _admCdeStatusRsnId, int start, int pageLength, out int count)
		{
			return GetByAdmCdeStatusRsnId(null, _admCdeStatusRsnId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_CDE_STATUS_RSN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeStatusRsnId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmCdeStatusRsn"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmCdeStatusRsn GetByAdmCdeStatusRsnId(TransactionManager transactionManager, System.Int32 _admCdeStatusRsnId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AdmCdeStatusRsn&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AdmCdeStatusRsn&gt;"/></returns>
		public static TList<AdmCdeStatusRsn> Fill(IDataReader reader, TList<AdmCdeStatusRsn> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AdmCdeStatusRsn c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AdmCdeStatusRsn")
					.Append("|").Append((System.Int32)reader["ADM_CDE_STATUS_RSN_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AdmCdeStatusRsn>(
					key.ToString(), // EntityTrackingKey
					"AdmCdeStatusRsn",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AdmCdeStatusRsn();
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
					c.AdmCdeStatusRsnId = (System.Int32)reader["ADM_CDE_STATUS_RSN_ID"];
					c.OriginalAdmCdeStatusRsnId = c.AdmCdeStatusRsnId;
					c.StatusRsnAr = Convert.IsDBNull(reader["STATUS_RSN_AR"]) ? null : (System.String)reader["STATUS_RSN_AR"];
					c.StatusRsnEn = Convert.IsDBNull(reader["STATUS_RSN_EN"]) ? null : (System.String)reader["STATUS_RSN_EN"];
					c.StatusCode = Convert.IsDBNull(reader["STATUS_CODE"]) ? null : (System.String)reader["STATUS_CODE"];
					c.RsnCode = Convert.IsDBNull(reader["RSN_CODE"]) ? null : (System.String)reader["RSN_CODE"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmCdeStatusRsn"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmCdeStatusRsn"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AdmCdeStatusRsn entity)
		{
			if (!reader.Read()) return;
			
			entity.AdmCdeStatusRsnId = (System.Int32)reader[((int)AdmCdeStatusRsnColumn.AdmCdeStatusRsnId - 1)];
			entity.OriginalAdmCdeStatusRsnId = (System.Int32)reader["ADM_CDE_STATUS_RSN_ID"];
			entity.StatusRsnAr = (reader.IsDBNull(((int)AdmCdeStatusRsnColumn.StatusRsnAr - 1)))?null:(System.String)reader[((int)AdmCdeStatusRsnColumn.StatusRsnAr - 1)];
			entity.StatusRsnEn = (reader.IsDBNull(((int)AdmCdeStatusRsnColumn.StatusRsnEn - 1)))?null:(System.String)reader[((int)AdmCdeStatusRsnColumn.StatusRsnEn - 1)];
			entity.StatusCode = (reader.IsDBNull(((int)AdmCdeStatusRsnColumn.StatusCode - 1)))?null:(System.String)reader[((int)AdmCdeStatusRsnColumn.StatusCode - 1)];
			entity.RsnCode = (reader.IsDBNull(((int)AdmCdeStatusRsnColumn.RsnCode - 1)))?null:(System.String)reader[((int)AdmCdeStatusRsnColumn.RsnCode - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmCdeStatusRsn"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmCdeStatusRsn"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AdmCdeStatusRsn entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AdmCdeStatusRsnId = (System.Int32)dataRow["ADM_CDE_STATUS_RSN_ID"];
			entity.OriginalAdmCdeStatusRsnId = (System.Int32)dataRow["ADM_CDE_STATUS_RSN_ID"];
			entity.StatusRsnAr = Convert.IsDBNull(dataRow["STATUS_RSN_AR"]) ? null : (System.String)dataRow["STATUS_RSN_AR"];
			entity.StatusRsnEn = Convert.IsDBNull(dataRow["STATUS_RSN_EN"]) ? null : (System.String)dataRow["STATUS_RSN_EN"];
			entity.StatusCode = Convert.IsDBNull(dataRow["STATUS_CODE"]) ? null : (System.String)dataRow["STATUS_CODE"];
			entity.RsnCode = Convert.IsDBNull(dataRow["RSN_CODE"]) ? null : (System.String)dataRow["RSN_CODE"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmCdeStatusRsn"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmCdeStatusRsn Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmCdeStatusRsn entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByAdmCdeStatusRsnId methods when available
			
			#region AdmAppRegHistoryCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppRegHistory>|AdmAppRegHistoryCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppRegHistoryCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppRegHistoryCollection = DataRepository.AdmAppRegHistoryProvider.GetByAdmCdeStatusRsnId(transactionManager, entity.AdmCdeStatusRsnId);

				if (deep && entity.AdmAppRegHistoryCollection.Count > 0)
				{
					deepHandles.Add("AdmAppRegHistoryCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppRegHistory>) DataRepository.AdmAppRegHistoryProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppRegHistoryCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AdmCdeStatusRsn object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AdmCdeStatusRsn instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmCdeStatusRsn Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmCdeStatusRsn entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<AdmAppRegHistory>
				if (CanDeepSave(entity.AdmAppRegHistoryCollection, "List<AdmAppRegHistory>|AdmAppRegHistoryCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppRegHistory child in entity.AdmAppRegHistoryCollection)
					{
						if(child.AdmCdeStatusRsnIdSource != null)
						{
							child.AdmCdeStatusRsnId = child.AdmCdeStatusRsnIdSource.AdmCdeStatusRsnId;
						}
						else
						{
							child.AdmCdeStatusRsnId = entity.AdmCdeStatusRsnId;
						}

					}

					if (entity.AdmAppRegHistoryCollection.Count > 0 || entity.AdmAppRegHistoryCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppRegHistoryProvider.Save(transactionManager, entity.AdmAppRegHistoryCollection);
						
						deepHandles.Add("AdmAppRegHistoryCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppRegHistory >) DataRepository.AdmAppRegHistoryProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppRegHistoryCollection, deepSaveType, childTypes, innerList }
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
	
	#region AdmCdeStatusRsnChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AdmCdeStatusRsn</c>
	///</summary>
	public enum AdmCdeStatusRsnChildEntityTypes
	{
		///<summary>
		/// Collection of <c>AdmCdeStatusRsn</c> as OneToMany for AdmAppRegHistoryCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppRegHistory>))]
		AdmAppRegHistoryCollection,
	}
	
	#endregion AdmCdeStatusRsnChildEntityTypes
	
	#region AdmCdeStatusRsnFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AdmCdeStatusRsnColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmCdeStatusRsn"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmCdeStatusRsnFilterBuilder : SqlFilterBuilder<AdmCdeStatusRsnColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmCdeStatusRsnFilterBuilder class.
		/// </summary>
		public AdmCdeStatusRsnFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmCdeStatusRsnFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmCdeStatusRsnFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmCdeStatusRsnFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmCdeStatusRsnFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmCdeStatusRsnFilterBuilder
	
	#region AdmCdeStatusRsnParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AdmCdeStatusRsnColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmCdeStatusRsn"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmCdeStatusRsnParameterBuilder : ParameterizedSqlFilterBuilder<AdmCdeStatusRsnColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmCdeStatusRsnParameterBuilder class.
		/// </summary>
		public AdmCdeStatusRsnParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmCdeStatusRsnParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmCdeStatusRsnParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmCdeStatusRsnParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmCdeStatusRsnParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmCdeStatusRsnParameterBuilder
	
	#region AdmCdeStatusRsnSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AdmCdeStatusRsnColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmCdeStatusRsn"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AdmCdeStatusRsnSortBuilder : SqlSortBuilder<AdmCdeStatusRsnColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmCdeStatusRsnSqlSortBuilder class.
		/// </summary>
		public AdmCdeStatusRsnSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AdmCdeStatusRsnSortBuilder
	
} // end namespace
