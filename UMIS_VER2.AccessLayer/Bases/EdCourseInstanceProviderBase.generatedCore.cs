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
	/// This class is the base class for any <see cref="EdCourseInstanceProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdCourseInstanceProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdCourseInstance, UMIS_VER2.BusinessLyer.EdCourseInstanceKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCourseInstanceKey key)
		{
			return Delete(transactionManager, key.EdCourseInstanceId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edCourseInstanceId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edCourseInstanceId)
		{
			return Delete(null, _edCourseInstanceId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseInstanceId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edCourseInstanceId);		
		
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
		public override UMIS_VER2.BusinessLyer.EdCourseInstance Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCourseInstanceKey key, int start, int pageLength)
		{
			return GetByEdCourseInstanceId(transactionManager, key.EdCourseInstanceId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_OFFERING_COURSE_I_1 index.
		/// </summary>
		/// <param name="_edOfferingCourseId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdCourseInstance&gt;"/> class.</returns>
		public TList<EdCourseInstance> GetByEdOfferingCourseId(System.Decimal _edOfferingCourseId)
		{
			int count = -1;
			return GetByEdOfferingCourseId(null,_edOfferingCourseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_OFFERING_COURSE_I_1 index.
		/// </summary>
		/// <param name="_edOfferingCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdCourseInstance&gt;"/> class.</returns>
		public TList<EdCourseInstance> GetByEdOfferingCourseId(System.Decimal _edOfferingCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdOfferingCourseId(null, _edOfferingCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_OFFERING_COURSE_I_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edOfferingCourseId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdCourseInstance&gt;"/> class.</returns>
		public TList<EdCourseInstance> GetByEdOfferingCourseId(TransactionManager transactionManager, System.Decimal _edOfferingCourseId)
		{
			int count = -1;
			return GetByEdOfferingCourseId(transactionManager, _edOfferingCourseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_OFFERING_COURSE_I_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edOfferingCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdCourseInstance&gt;"/> class.</returns>
		public TList<EdCourseInstance> GetByEdOfferingCourseId(TransactionManager transactionManager, System.Decimal _edOfferingCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdOfferingCourseId(transactionManager, _edOfferingCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_OFFERING_COURSE_I_1 index.
		/// </summary>
		/// <param name="_edOfferingCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdCourseInstance&gt;"/> class.</returns>
		public TList<EdCourseInstance> GetByEdOfferingCourseId(System.Decimal _edOfferingCourseId, int start, int pageLength, out int count)
		{
			return GetByEdOfferingCourseId(null, _edOfferingCourseId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_OFFERING_COURSE_I_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edOfferingCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdCourseInstance&gt;"/> class.</returns>
		public abstract TList<EdCourseInstance> GetByEdOfferingCourseId(TransactionManager transactionManager, System.Decimal _edOfferingCourseId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_SC_SCHEDULE_DTL_ID_1 index.
		/// </summary>
		/// <param name="_scScheduleDtlId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdCourseInstance&gt;"/> class.</returns>
		public TList<EdCourseInstance> GetByScScheduleDtlId(System.Decimal? _scScheduleDtlId)
		{
			int count = -1;
			return GetByScScheduleDtlId(null,_scScheduleDtlId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SC_SCHEDULE_DTL_ID_1 index.
		/// </summary>
		/// <param name="_scScheduleDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdCourseInstance&gt;"/> class.</returns>
		public TList<EdCourseInstance> GetByScScheduleDtlId(System.Decimal? _scScheduleDtlId, int start, int pageLength)
		{
			int count = -1;
			return GetByScScheduleDtlId(null, _scScheduleDtlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SC_SCHEDULE_DTL_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleDtlId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdCourseInstance&gt;"/> class.</returns>
		public TList<EdCourseInstance> GetByScScheduleDtlId(TransactionManager transactionManager, System.Decimal? _scScheduleDtlId)
		{
			int count = -1;
			return GetByScScheduleDtlId(transactionManager, _scScheduleDtlId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SC_SCHEDULE_DTL_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdCourseInstance&gt;"/> class.</returns>
		public TList<EdCourseInstance> GetByScScheduleDtlId(TransactionManager transactionManager, System.Decimal? _scScheduleDtlId, int start, int pageLength)
		{
			int count = -1;
			return GetByScScheduleDtlId(transactionManager, _scScheduleDtlId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SC_SCHEDULE_DTL_ID_1 index.
		/// </summary>
		/// <param name="_scScheduleDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdCourseInstance&gt;"/> class.</returns>
		public TList<EdCourseInstance> GetByScScheduleDtlId(System.Decimal? _scScheduleDtlId, int start, int pageLength, out int count)
		{
			return GetByScScheduleDtlId(null, _scScheduleDtlId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_SC_SCHEDULE_DTL_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scScheduleDtlId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdCourseInstance&gt;"/> class.</returns>
		public abstract TList<EdCourseInstance> GetByScScheduleDtlId(TransactionManager transactionManager, System.Decimal? _scScheduleDtlId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_COURSE‌_INSTANCE index.
		/// </summary>
		/// <param name="_edCourseInstanceId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourseInstance"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCourseInstance GetByEdCourseInstanceId(System.Decimal _edCourseInstanceId)
		{
			int count = -1;
			return GetByEdCourseInstanceId(null,_edCourseInstanceId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_COURSE‌_INSTANCE index.
		/// </summary>
		/// <param name="_edCourseInstanceId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourseInstance"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCourseInstance GetByEdCourseInstanceId(System.Decimal _edCourseInstanceId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseInstanceId(null, _edCourseInstanceId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_COURSE‌_INSTANCE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseInstanceId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourseInstance"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCourseInstance GetByEdCourseInstanceId(TransactionManager transactionManager, System.Decimal _edCourseInstanceId)
		{
			int count = -1;
			return GetByEdCourseInstanceId(transactionManager, _edCourseInstanceId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_COURSE‌_INSTANCE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseInstanceId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourseInstance"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCourseInstance GetByEdCourseInstanceId(TransactionManager transactionManager, System.Decimal _edCourseInstanceId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseInstanceId(transactionManager, _edCourseInstanceId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_COURSE‌_INSTANCE index.
		/// </summary>
		/// <param name="_edCourseInstanceId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourseInstance"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCourseInstance GetByEdCourseInstanceId(System.Decimal _edCourseInstanceId, int start, int pageLength, out int count)
		{
			return GetByEdCourseInstanceId(null, _edCourseInstanceId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_COURSE‌_INSTANCE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseInstanceId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCourseInstance"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdCourseInstance GetByEdCourseInstanceId(TransactionManager transactionManager, System.Decimal _edCourseInstanceId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdCourseInstance&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdCourseInstance&gt;"/></returns>
		public static TList<EdCourseInstance> Fill(IDataReader reader, TList<EdCourseInstance> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdCourseInstance c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdCourseInstance")
					.Append("|").Append((System.Decimal)reader["ED_COURSE_INSTANCE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdCourseInstance>(
					key.ToString(), // EntityTrackingKey
					"EdCourseInstance",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdCourseInstance();
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
					c.EdCourseInstanceId = (System.Decimal)reader["ED_COURSE_INSTANCE_ID"];
					c.OriginalEdCourseInstanceId = c.EdCourseInstanceId;
					c.EdOfferingCourseId = (System.Decimal)reader["ED_OFFERING_COURSE_ID"];
					c.CourseName = Convert.IsDBNull(reader["COURSE_NAME"]) ? null : (System.String)reader["COURSE_NAME"];
					c.ScScheduleDtlId = Convert.IsDBNull(reader["SC_SCHEDULE_DTL_ID"]) ? null : (System.Decimal?)reader["SC_SCHEDULE_DTL_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCourseInstance"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCourseInstance"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdCourseInstance entity)
		{
			if (!reader.Read()) return;
			
			entity.EdCourseInstanceId = (System.Decimal)reader[((int)EdCourseInstanceColumn.EdCourseInstanceId - 1)];
			entity.OriginalEdCourseInstanceId = (System.Decimal)reader["ED_COURSE_INSTANCE_ID"];
			entity.EdOfferingCourseId = (System.Decimal)reader[((int)EdCourseInstanceColumn.EdOfferingCourseId - 1)];
			entity.CourseName = (reader.IsDBNull(((int)EdCourseInstanceColumn.CourseName - 1)))?null:(System.String)reader[((int)EdCourseInstanceColumn.CourseName - 1)];
			entity.ScScheduleDtlId = (reader.IsDBNull(((int)EdCourseInstanceColumn.ScScheduleDtlId - 1)))?null:(System.Decimal?)reader[((int)EdCourseInstanceColumn.ScScheduleDtlId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCourseInstance"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCourseInstance"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdCourseInstance entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdCourseInstanceId = (System.Decimal)dataRow["ED_COURSE_INSTANCE_ID"];
			entity.OriginalEdCourseInstanceId = (System.Decimal)dataRow["ED_COURSE_INSTANCE_ID"];
			entity.EdOfferingCourseId = (System.Decimal)dataRow["ED_OFFERING_COURSE_ID"];
			entity.CourseName = Convert.IsDBNull(dataRow["COURSE_NAME"]) ? null : (System.String)dataRow["COURSE_NAME"];
			entity.ScScheduleDtlId = Convert.IsDBNull(dataRow["SC_SCHEDULE_DTL_ID"]) ? null : (System.Decimal?)dataRow["SC_SCHEDULE_DTL_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCourseInstance"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCourseInstance Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCourseInstance entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdOfferingCourseIdSource	
			if (CanDeepLoad(entity, "EdOfferingCourse|EdOfferingCourseIdSource", deepLoadType, innerList) 
				&& entity.EdOfferingCourseIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdOfferingCourseId;
				EdOfferingCourse tmpEntity = EntityManager.LocateEntity<EdOfferingCourse>(EntityLocator.ConstructKeyFromPkItems(typeof(EdOfferingCourse), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdOfferingCourseIdSource = tmpEntity;
				else
					entity.EdOfferingCourseIdSource = DataRepository.EdOfferingCourseProvider.GetByEdOfferingCourseId(transactionManager, entity.EdOfferingCourseId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdOfferingCourseIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdOfferingCourseIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdOfferingCourseProvider.DeepLoad(transactionManager, entity.EdOfferingCourseIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdOfferingCourseIdSource

			#region ScScheduleDtlIdSource	
			if (CanDeepLoad(entity, "ScScheduleDtl|ScScheduleDtlIdSource", deepLoadType, innerList) 
				&& entity.ScScheduleDtlIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.ScScheduleDtlId ?? 0.0m);
				ScScheduleDtl tmpEntity = EntityManager.LocateEntity<ScScheduleDtl>(EntityLocator.ConstructKeyFromPkItems(typeof(ScScheduleDtl), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.ScScheduleDtlIdSource = tmpEntity;
				else
					entity.ScScheduleDtlIdSource = DataRepository.ScScheduleDtlProvider.GetByScScheduleDtlId(transactionManager, (entity.ScScheduleDtlId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScScheduleDtlIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.ScScheduleDtlIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.ScScheduleDtlProvider.DeepLoad(transactionManager, entity.ScScheduleDtlIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion ScScheduleDtlIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdCourseInstance object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdCourseInstance instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCourseInstance Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCourseInstance entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdOfferingCourseIdSource
			if (CanDeepSave(entity, "EdOfferingCourse|EdOfferingCourseIdSource", deepSaveType, innerList) 
				&& entity.EdOfferingCourseIdSource != null)
			{
				DataRepository.EdOfferingCourseProvider.Save(transactionManager, entity.EdOfferingCourseIdSource);
				entity.EdOfferingCourseId = entity.EdOfferingCourseIdSource.EdOfferingCourseId;
			}
			#endregion 
			
			#region ScScheduleDtlIdSource
			if (CanDeepSave(entity, "ScScheduleDtl|ScScheduleDtlIdSource", deepSaveType, innerList) 
				&& entity.ScScheduleDtlIdSource != null)
			{
				DataRepository.ScScheduleDtlProvider.Save(transactionManager, entity.ScScheduleDtlIdSource);
				entity.ScScheduleDtlId = entity.ScScheduleDtlIdSource.ScScheduleDtlId;
			}
			#endregion 
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
	
	#region EdCourseInstanceChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdCourseInstance</c>
	///</summary>
	public enum EdCourseInstanceChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdOfferingCourse</c> at EdOfferingCourseIdSource
		///</summary>
		[ChildEntityType(typeof(EdOfferingCourse))]
		EdOfferingCourse,
		
		///<summary>
		/// Composite Property for <c>ScScheduleDtl</c> at ScScheduleDtlIdSource
		///</summary>
		[ChildEntityType(typeof(ScScheduleDtl))]
		ScScheduleDtl,
	}
	
	#endregion EdCourseInstanceChildEntityTypes
	
	#region EdCourseInstanceFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdCourseInstanceColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCourseInstance"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCourseInstanceFilterBuilder : SqlFilterBuilder<EdCourseInstanceColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCourseInstanceFilterBuilder class.
		/// </summary>
		public EdCourseInstanceFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCourseInstanceFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCourseInstanceFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCourseInstanceFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCourseInstanceFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCourseInstanceFilterBuilder
	
	#region EdCourseInstanceParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdCourseInstanceColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCourseInstance"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCourseInstanceParameterBuilder : ParameterizedSqlFilterBuilder<EdCourseInstanceColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCourseInstanceParameterBuilder class.
		/// </summary>
		public EdCourseInstanceParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCourseInstanceParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCourseInstanceParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCourseInstanceParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCourseInstanceParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCourseInstanceParameterBuilder
	
	#region EdCourseInstanceSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdCourseInstanceColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCourseInstance"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdCourseInstanceSortBuilder : SqlSortBuilder<EdCourseInstanceColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCourseInstanceSqlSortBuilder class.
		/// </summary>
		public EdCourseInstanceSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdCourseInstanceSortBuilder
	
} // end namespace
