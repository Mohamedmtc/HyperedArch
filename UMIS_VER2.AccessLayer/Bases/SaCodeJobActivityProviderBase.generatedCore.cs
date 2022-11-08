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
	/// This class is the base class for any <see cref="SaCodeJobActivityProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SaCodeJobActivityProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SaCodeJobActivity, UMIS_VER2.BusinessLyer.SaCodeJobActivityKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeJobActivityKey key)
		{
			return Delete(transactionManager, key.SaCodeJobActivityId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_saCodeJobActivityId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _saCodeJobActivityId)
		{
			return Delete(null, _saCodeJobActivityId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeJobActivityId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _saCodeJobActivityId);		
		
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
		public override UMIS_VER2.BusinessLyer.SaCodeJobActivity Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeJobActivityKey key, int start, int pageLength)
		{
			return GetBySaCodeJobActivityId(transactionManager, key.SaCodeJobActivityId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key COS_SA_CODE_JOB_ACTIVITY2 index.
		/// </summary>
		/// <param name="_jobActivityDescrAr"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeJobActivity"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeJobActivity GetByJobActivityDescrAr(System.String _jobActivityDescrAr)
		{
			int count = -1;
			return GetByJobActivityDescrAr(null,_jobActivityDescrAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SA_CODE_JOB_ACTIVITY2 index.
		/// </summary>
		/// <param name="_jobActivityDescrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeJobActivity"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeJobActivity GetByJobActivityDescrAr(System.String _jobActivityDescrAr, int start, int pageLength)
		{
			int count = -1;
			return GetByJobActivityDescrAr(null, _jobActivityDescrAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SA_CODE_JOB_ACTIVITY2 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_jobActivityDescrAr"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeJobActivity"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeJobActivity GetByJobActivityDescrAr(TransactionManager transactionManager, System.String _jobActivityDescrAr)
		{
			int count = -1;
			return GetByJobActivityDescrAr(transactionManager, _jobActivityDescrAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SA_CODE_JOB_ACTIVITY2 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_jobActivityDescrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeJobActivity"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeJobActivity GetByJobActivityDescrAr(TransactionManager transactionManager, System.String _jobActivityDescrAr, int start, int pageLength)
		{
			int count = -1;
			return GetByJobActivityDescrAr(transactionManager, _jobActivityDescrAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SA_CODE_JOB_ACTIVITY2 index.
		/// </summary>
		/// <param name="_jobActivityDescrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeJobActivity"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeJobActivity GetByJobActivityDescrAr(System.String _jobActivityDescrAr, int start, int pageLength, out int count)
		{
			return GetByJobActivityDescrAr(null, _jobActivityDescrAr, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SA_CODE_JOB_ACTIVITY2 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_jobActivityDescrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeJobActivity"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SaCodeJobActivity GetByJobActivityDescrAr(TransactionManager transactionManager, System.String _jobActivityDescrAr, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SA_CODE_JOB_ACTIVITY index.
		/// </summary>
		/// <param name="_saCodeJobActivityId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeJobActivity"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeJobActivity GetBySaCodeJobActivityId(System.Decimal _saCodeJobActivityId)
		{
			int count = -1;
			return GetBySaCodeJobActivityId(null,_saCodeJobActivityId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_JOB_ACTIVITY index.
		/// </summary>
		/// <param name="_saCodeJobActivityId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeJobActivity"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeJobActivity GetBySaCodeJobActivityId(System.Decimal _saCodeJobActivityId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeJobActivityId(null, _saCodeJobActivityId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_JOB_ACTIVITY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeJobActivityId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeJobActivity"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeJobActivity GetBySaCodeJobActivityId(TransactionManager transactionManager, System.Decimal _saCodeJobActivityId)
		{
			int count = -1;
			return GetBySaCodeJobActivityId(transactionManager, _saCodeJobActivityId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_JOB_ACTIVITY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeJobActivityId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeJobActivity"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeJobActivity GetBySaCodeJobActivityId(TransactionManager transactionManager, System.Decimal _saCodeJobActivityId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeJobActivityId(transactionManager, _saCodeJobActivityId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_JOB_ACTIVITY index.
		/// </summary>
		/// <param name="_saCodeJobActivityId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeJobActivity"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeJobActivity GetBySaCodeJobActivityId(System.Decimal _saCodeJobActivityId, int start, int pageLength, out int count)
		{
			return GetBySaCodeJobActivityId(null, _saCodeJobActivityId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_JOB_ACTIVITY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeJobActivityId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeJobActivity"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SaCodeJobActivity GetBySaCodeJobActivityId(TransactionManager transactionManager, System.Decimal _saCodeJobActivityId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SaCodeJobActivity&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SaCodeJobActivity&gt;"/></returns>
		public static TList<SaCodeJobActivity> Fill(IDataReader reader, TList<SaCodeJobActivity> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SaCodeJobActivity c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SaCodeJobActivity")
					.Append("|").Append((System.Decimal)reader["SA_CODE_JOB_ACTIVITY_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SaCodeJobActivity>(
					key.ToString(), // EntityTrackingKey
					"SaCodeJobActivity",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SaCodeJobActivity();
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
					c.SaCodeJobActivityId = (System.Decimal)reader["SA_CODE_JOB_ACTIVITY_ID"];
					c.OriginalSaCodeJobActivityId = c.SaCodeJobActivityId;
					c.JobAcitivtyCode = Convert.IsDBNull(reader["JOB_ACITIVTY_CODE"]) ? null : (System.String)reader["JOB_ACITIVTY_CODE"];
					c.JobActivityDescrAr = (System.String)reader["JOB_ACTIVITY_DESCR_AR"];
					c.JobActivityDescrEn = Convert.IsDBNull(reader["JOB_ACTIVITY_DESCR_EN"]) ? null : (System.String)reader["JOB_ACTIVITY_DESCR_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaCodeJobActivity"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCodeJobActivity"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SaCodeJobActivity entity)
		{
			if (!reader.Read()) return;
			
			entity.SaCodeJobActivityId = (System.Decimal)reader[((int)SaCodeJobActivityColumn.SaCodeJobActivityId - 1)];
			entity.OriginalSaCodeJobActivityId = (System.Decimal)reader["SA_CODE_JOB_ACTIVITY_ID"];
			entity.JobAcitivtyCode = (reader.IsDBNull(((int)SaCodeJobActivityColumn.JobAcitivtyCode - 1)))?null:(System.String)reader[((int)SaCodeJobActivityColumn.JobAcitivtyCode - 1)];
			entity.JobActivityDescrAr = (System.String)reader[((int)SaCodeJobActivityColumn.JobActivityDescrAr - 1)];
			entity.JobActivityDescrEn = (reader.IsDBNull(((int)SaCodeJobActivityColumn.JobActivityDescrEn - 1)))?null:(System.String)reader[((int)SaCodeJobActivityColumn.JobActivityDescrEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaCodeJobActivity"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCodeJobActivity"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SaCodeJobActivity entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SaCodeJobActivityId = (System.Decimal)dataRow["SA_CODE_JOB_ACTIVITY_ID"];
			entity.OriginalSaCodeJobActivityId = (System.Decimal)dataRow["SA_CODE_JOB_ACTIVITY_ID"];
			entity.JobAcitivtyCode = Convert.IsDBNull(dataRow["JOB_ACITIVTY_CODE"]) ? null : (System.String)dataRow["JOB_ACITIVTY_CODE"];
			entity.JobActivityDescrAr = (System.String)dataRow["JOB_ACTIVITY_DESCR_AR"];
			entity.JobActivityDescrEn = Convert.IsDBNull(dataRow["JOB_ACTIVITY_DESCR_EN"]) ? null : (System.String)dataRow["JOB_ACTIVITY_DESCR_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCodeJobActivity"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaCodeJobActivity Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeJobActivity entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetBySaCodeJobActivityId methods when available
			
			#region SaJobActivityCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaJobActivity>|SaJobActivityCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaJobActivityCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaJobActivityCollection = DataRepository.SaJobActivityProvider.GetBySaCodeJobActivityId(transactionManager, entity.SaCodeJobActivityId);

				if (deep && entity.SaJobActivityCollection.Count > 0)
				{
					deepHandles.Add("SaJobActivityCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaJobActivity>) DataRepository.SaJobActivityProvider.DeepLoad,
						new object[] { transactionManager, entity.SaJobActivityCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SaCodeJobActivity object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SaCodeJobActivity instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaCodeJobActivity Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeJobActivity entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<SaJobActivity>
				if (CanDeepSave(entity.SaJobActivityCollection, "List<SaJobActivity>|SaJobActivityCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaJobActivity child in entity.SaJobActivityCollection)
					{
						if(child.SaCodeJobActivityIdSource != null)
						{
							child.SaCodeJobActivityId = child.SaCodeJobActivityIdSource.SaCodeJobActivityId;
						}
						else
						{
							child.SaCodeJobActivityId = entity.SaCodeJobActivityId;
						}

					}

					if (entity.SaJobActivityCollection.Count > 0 || entity.SaJobActivityCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaJobActivityProvider.Save(transactionManager, entity.SaJobActivityCollection);
						
						deepHandles.Add("SaJobActivityCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaJobActivity >) DataRepository.SaJobActivityProvider.DeepSave,
							new object[] { transactionManager, entity.SaJobActivityCollection, deepSaveType, childTypes, innerList }
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
	
	#region SaCodeJobActivityChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SaCodeJobActivity</c>
	///</summary>
	public enum SaCodeJobActivityChildEntityTypes
	{
		///<summary>
		/// Collection of <c>SaCodeJobActivity</c> as OneToMany for SaJobActivityCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaJobActivity>))]
		SaJobActivityCollection,
	}
	
	#endregion SaCodeJobActivityChildEntityTypes
	
	#region SaCodeJobActivityFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SaCodeJobActivityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCodeJobActivity"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaCodeJobActivityFilterBuilder : SqlFilterBuilder<SaCodeJobActivityColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCodeJobActivityFilterBuilder class.
		/// </summary>
		public SaCodeJobActivityFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaCodeJobActivityFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaCodeJobActivityFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaCodeJobActivityFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaCodeJobActivityFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaCodeJobActivityFilterBuilder
	
	#region SaCodeJobActivityParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SaCodeJobActivityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCodeJobActivity"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaCodeJobActivityParameterBuilder : ParameterizedSqlFilterBuilder<SaCodeJobActivityColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCodeJobActivityParameterBuilder class.
		/// </summary>
		public SaCodeJobActivityParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaCodeJobActivityParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaCodeJobActivityParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaCodeJobActivityParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaCodeJobActivityParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaCodeJobActivityParameterBuilder
	
	#region SaCodeJobActivitySortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SaCodeJobActivityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCodeJobActivity"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SaCodeJobActivitySortBuilder : SqlSortBuilder<SaCodeJobActivityColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCodeJobActivitySqlSortBuilder class.
		/// </summary>
		public SaCodeJobActivitySortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SaCodeJobActivitySortBuilder
	
} // end namespace
