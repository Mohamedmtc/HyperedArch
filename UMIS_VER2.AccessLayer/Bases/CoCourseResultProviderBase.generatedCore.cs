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
	/// This class is the base class for any <see cref="CoCourseResultProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class CoCourseResultProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.CoCourseResult, UMIS_VER2.BusinessLyer.CoCourseResultKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CoCourseResultKey key)
		{
			return Delete(transactionManager, key.CoSubjectResultId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_coSubjectResultId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _coSubjectResultId)
		{
			return Delete(null, _coSubjectResultId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coSubjectResultId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _coSubjectResultId);		
		
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
		public override UMIS_VER2.BusinessLyer.CoCourseResult Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CoCourseResultKey key, int start, int pageLength)
		{
			return GetByCoSubjectResultId(transactionManager, key.CoSubjectResultId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_CO_CONTROL_ROOM_ID_1 index.
		/// </summary>
		/// <param name="_coControlRoomId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoCourseResult&gt;"/> class.</returns>
		public TList<CoCourseResult> GetByCoControlRoomId(System.Decimal _coControlRoomId)
		{
			int count = -1;
			return GetByCoControlRoomId(null,_coControlRoomId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_CO_CONTROL_ROOM_ID_1 index.
		/// </summary>
		/// <param name="_coControlRoomId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoCourseResult&gt;"/> class.</returns>
		public TList<CoCourseResult> GetByCoControlRoomId(System.Decimal _coControlRoomId, int start, int pageLength)
		{
			int count = -1;
			return GetByCoControlRoomId(null, _coControlRoomId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_CO_CONTROL_ROOM_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coControlRoomId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoCourseResult&gt;"/> class.</returns>
		public TList<CoCourseResult> GetByCoControlRoomId(TransactionManager transactionManager, System.Decimal _coControlRoomId)
		{
			int count = -1;
			return GetByCoControlRoomId(transactionManager, _coControlRoomId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_CO_CONTROL_ROOM_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coControlRoomId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoCourseResult&gt;"/> class.</returns>
		public TList<CoCourseResult> GetByCoControlRoomId(TransactionManager transactionManager, System.Decimal _coControlRoomId, int start, int pageLength)
		{
			int count = -1;
			return GetByCoControlRoomId(transactionManager, _coControlRoomId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_CO_CONTROL_ROOM_ID_1 index.
		/// </summary>
		/// <param name="_coControlRoomId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoCourseResult&gt;"/> class.</returns>
		public TList<CoCourseResult> GetByCoControlRoomId(System.Decimal _coControlRoomId, int start, int pageLength, out int count)
		{
			return GetByCoControlRoomId(null, _coControlRoomId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_CO_CONTROL_ROOM_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coControlRoomId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoCourseResult&gt;"/> class.</returns>
		public abstract TList<CoCourseResult> GetByCoControlRoomId(TransactionManager transactionManager, System.Decimal _coControlRoomId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_COURSE_ID_1 index.
		/// </summary>
		/// <param name="_edCourseId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoCourseResult&gt;"/> class.</returns>
		public TList<CoCourseResult> GetByEdCourseId(System.Decimal _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(null,_edCourseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_COURSE_ID_1 index.
		/// </summary>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoCourseResult&gt;"/> class.</returns>
		public TList<CoCourseResult> GetByEdCourseId(System.Decimal _edCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseId(null, _edCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_COURSE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoCourseResult&gt;"/> class.</returns>
		public TList<CoCourseResult> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_COURSE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoCourseResult&gt;"/> class.</returns>
		public TList<CoCourseResult> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCourseId(transactionManager, _edCourseId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_COURSE_ID_1 index.
		/// </summary>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoCourseResult&gt;"/> class.</returns>
		public TList<CoCourseResult> GetByEdCourseId(System.Decimal _edCourseId, int start, int pageLength, out int count)
		{
			return GetByEdCourseId(null, _edCourseId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_COURSE_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCourseId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;CoCourseResult&gt;"/> class.</returns>
		public abstract TList<CoCourseResult> GetByEdCourseId(TransactionManager transactionManager, System.Decimal _edCourseId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_CO_SUBJECT_RESULT index.
		/// </summary>
		/// <param name="_coSubjectResultId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoCourseResult"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoCourseResult GetByCoSubjectResultId(System.Decimal _coSubjectResultId)
		{
			int count = -1;
			return GetByCoSubjectResultId(null,_coSubjectResultId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_SUBJECT_RESULT index.
		/// </summary>
		/// <param name="_coSubjectResultId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoCourseResult"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoCourseResult GetByCoSubjectResultId(System.Decimal _coSubjectResultId, int start, int pageLength)
		{
			int count = -1;
			return GetByCoSubjectResultId(null, _coSubjectResultId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_SUBJECT_RESULT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coSubjectResultId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoCourseResult"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoCourseResult GetByCoSubjectResultId(TransactionManager transactionManager, System.Decimal _coSubjectResultId)
		{
			int count = -1;
			return GetByCoSubjectResultId(transactionManager, _coSubjectResultId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_SUBJECT_RESULT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coSubjectResultId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoCourseResult"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoCourseResult GetByCoSubjectResultId(TransactionManager transactionManager, System.Decimal _coSubjectResultId, int start, int pageLength)
		{
			int count = -1;
			return GetByCoSubjectResultId(transactionManager, _coSubjectResultId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_SUBJECT_RESULT index.
		/// </summary>
		/// <param name="_coSubjectResultId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoCourseResult"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CoCourseResult GetByCoSubjectResultId(System.Decimal _coSubjectResultId, int start, int pageLength, out int count)
		{
			return GetByCoSubjectResultId(null, _coSubjectResultId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CO_SUBJECT_RESULT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_coSubjectResultId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CoCourseResult"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.CoCourseResult GetByCoSubjectResultId(TransactionManager transactionManager, System.Decimal _coSubjectResultId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;CoCourseResult&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;CoCourseResult&gt;"/></returns>
		public static TList<CoCourseResult> Fill(IDataReader reader, TList<CoCourseResult> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.CoCourseResult c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("CoCourseResult")
					.Append("|").Append((System.Decimal)reader["CO_SUBJECT_RESULT_ID"]).ToString();
					c = EntityManager.LocateOrCreate<CoCourseResult>(
					key.ToString(), // EntityTrackingKey
					"CoCourseResult",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.CoCourseResult();
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
					c.CoSubjectResultId = (System.Decimal)reader["CO_SUBJECT_RESULT_ID"];
					c.OriginalCoSubjectResultId = c.CoSubjectResultId;
					c.CoControlRoomId = (System.Decimal)reader["CO_CONTROL_ROOM_ID"];
					c.EdCourseId = (System.Decimal)reader["ED_COURSE_ID"];
					c.Note = Convert.IsDBNull(reader["NOTE"]) ? null : (System.String)reader["NOTE"];
					c.SumFlg = (System.Decimal)reader["SUM_FLG"];
					c.ApproveFlg = (System.Decimal)reader["APPROVE_FLG"];
					c.PublishFlg = Convert.IsDBNull(reader["PUBLISH_FLG"]) ? null : (System.Decimal?)reader["PUBLISH_FLG"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.CoCourseResult"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CoCourseResult"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.CoCourseResult entity)
		{
			if (!reader.Read()) return;
			
			entity.CoSubjectResultId = (System.Decimal)reader[((int)CoCourseResultColumn.CoSubjectResultId - 1)];
			entity.OriginalCoSubjectResultId = (System.Decimal)reader["CO_SUBJECT_RESULT_ID"];
			entity.CoControlRoomId = (System.Decimal)reader[((int)CoCourseResultColumn.CoControlRoomId - 1)];
			entity.EdCourseId = (System.Decimal)reader[((int)CoCourseResultColumn.EdCourseId - 1)];
			entity.Note = (reader.IsDBNull(((int)CoCourseResultColumn.Note - 1)))?null:(System.String)reader[((int)CoCourseResultColumn.Note - 1)];
			entity.SumFlg = (System.Decimal)reader[((int)CoCourseResultColumn.SumFlg - 1)];
			entity.ApproveFlg = (System.Decimal)reader[((int)CoCourseResultColumn.ApproveFlg - 1)];
			entity.PublishFlg = (reader.IsDBNull(((int)CoCourseResultColumn.PublishFlg - 1)))?null:(System.Decimal?)reader[((int)CoCourseResultColumn.PublishFlg - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.CoCourseResult"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CoCourseResult"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.CoCourseResult entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.CoSubjectResultId = (System.Decimal)dataRow["CO_SUBJECT_RESULT_ID"];
			entity.OriginalCoSubjectResultId = (System.Decimal)dataRow["CO_SUBJECT_RESULT_ID"];
			entity.CoControlRoomId = (System.Decimal)dataRow["CO_CONTROL_ROOM_ID"];
			entity.EdCourseId = (System.Decimal)dataRow["ED_COURSE_ID"];
			entity.Note = Convert.IsDBNull(dataRow["NOTE"]) ? null : (System.String)dataRow["NOTE"];
			entity.SumFlg = (System.Decimal)dataRow["SUM_FLG"];
			entity.ApproveFlg = (System.Decimal)dataRow["APPROVE_FLG"];
			entity.PublishFlg = Convert.IsDBNull(dataRow["PUBLISH_FLG"]) ? null : (System.Decimal?)dataRow["PUBLISH_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CoCourseResult"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.CoCourseResult Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CoCourseResult entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region CoControlRoomIdSource	
			if (CanDeepLoad(entity, "CoControlRoom|CoControlRoomIdSource", deepLoadType, innerList) 
				&& entity.CoControlRoomIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.CoControlRoomId;
				CoControlRoom tmpEntity = EntityManager.LocateEntity<CoControlRoom>(EntityLocator.ConstructKeyFromPkItems(typeof(CoControlRoom), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.CoControlRoomIdSource = tmpEntity;
				else
					entity.CoControlRoomIdSource = DataRepository.CoControlRoomProvider.GetByCoControlRoomId(transactionManager, entity.CoControlRoomId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CoControlRoomIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.CoControlRoomIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.CoControlRoomProvider.DeepLoad(transactionManager, entity.CoControlRoomIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion CoControlRoomIdSource

			#region EdCourseIdSource	
			if (CanDeepLoad(entity, "EdCourse|EdCourseIdSource", deepLoadType, innerList) 
				&& entity.EdCourseIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdCourseId;
				EdCourse tmpEntity = EntityManager.LocateEntity<EdCourse>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCourse), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCourseIdSource = tmpEntity;
				else
					entity.EdCourseIdSource = DataRepository.EdCourseProvider.GetByEdCourseId(transactionManager, entity.EdCourseId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCourseIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCourseIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCourseProvider.DeepLoad(transactionManager, entity.EdCourseIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCourseIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.CoCourseResult object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.CoCourseResult instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.CoCourseResult Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CoCourseResult entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region CoControlRoomIdSource
			if (CanDeepSave(entity, "CoControlRoom|CoControlRoomIdSource", deepSaveType, innerList) 
				&& entity.CoControlRoomIdSource != null)
			{
				DataRepository.CoControlRoomProvider.Save(transactionManager, entity.CoControlRoomIdSource);
				entity.CoControlRoomId = entity.CoControlRoomIdSource.CoControlRoomId;
			}
			#endregion 
			
			#region EdCourseIdSource
			if (CanDeepSave(entity, "EdCourse|EdCourseIdSource", deepSaveType, innerList) 
				&& entity.EdCourseIdSource != null)
			{
				DataRepository.EdCourseProvider.Save(transactionManager, entity.EdCourseIdSource);
				entity.EdCourseId = entity.EdCourseIdSource.EdCourseId;
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
	
	#region CoCourseResultChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.CoCourseResult</c>
	///</summary>
	public enum CoCourseResultChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>CoControlRoom</c> at CoControlRoomIdSource
		///</summary>
		[ChildEntityType(typeof(CoControlRoom))]
		CoControlRoom,
		
		///<summary>
		/// Composite Property for <c>EdCourse</c> at EdCourseIdSource
		///</summary>
		[ChildEntityType(typeof(EdCourse))]
		EdCourse,
	}
	
	#endregion CoCourseResultChildEntityTypes
	
	#region CoCourseResultFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;CoCourseResultColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CoCourseResult"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CoCourseResultFilterBuilder : SqlFilterBuilder<CoCourseResultColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CoCourseResultFilterBuilder class.
		/// </summary>
		public CoCourseResultFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CoCourseResultFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CoCourseResultFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CoCourseResultFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CoCourseResultFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CoCourseResultFilterBuilder
	
	#region CoCourseResultParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;CoCourseResultColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CoCourseResult"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CoCourseResultParameterBuilder : ParameterizedSqlFilterBuilder<CoCourseResultColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CoCourseResultParameterBuilder class.
		/// </summary>
		public CoCourseResultParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CoCourseResultParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CoCourseResultParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CoCourseResultParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CoCourseResultParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CoCourseResultParameterBuilder
	
	#region CoCourseResultSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;CoCourseResultColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CoCourseResult"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class CoCourseResultSortBuilder : SqlSortBuilder<CoCourseResultColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CoCourseResultSqlSortBuilder class.
		/// </summary>
		public CoCourseResultSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion CoCourseResultSortBuilder
	
} // end namespace
