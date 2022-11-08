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
	/// This class is the base class for any <see cref="EdCodeCourseStatusProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdCodeCourseStatusProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdCodeCourseStatus, UMIS_VER2.BusinessLyer.EdCodeCourseStatusKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeCourseStatusKey key)
		{
			return Delete(transactionManager, key.EdCodeCourseStatusId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edCodeCourseStatusId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edCodeCourseStatusId)
		{
			return Delete(null, _edCodeCourseStatusId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseStatusId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edCodeCourseStatusId);		
		
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
		public override UMIS_VER2.BusinessLyer.EdCodeCourseStatus Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeCourseStatusKey key, int start, int pageLength)
		{
			return GetByEdCodeCourseStatusId(transactionManager, key.EdCodeCourseStatusId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_CODE_COURSE_STATUS index.
		/// </summary>
		/// <param name="_edCodeCourseStatusId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeCourseStatus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeCourseStatus GetByEdCodeCourseStatusId(System.Decimal _edCodeCourseStatusId)
		{
			int count = -1;
			return GetByEdCodeCourseStatusId(null,_edCodeCourseStatusId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_COURSE_STATUS index.
		/// </summary>
		/// <param name="_edCodeCourseStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeCourseStatus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeCourseStatus GetByEdCodeCourseStatusId(System.Decimal _edCodeCourseStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeCourseStatusId(null, _edCodeCourseStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_COURSE_STATUS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseStatusId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeCourseStatus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeCourseStatus GetByEdCodeCourseStatusId(TransactionManager transactionManager, System.Decimal _edCodeCourseStatusId)
		{
			int count = -1;
			return GetByEdCodeCourseStatusId(transactionManager, _edCodeCourseStatusId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_COURSE_STATUS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeCourseStatus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeCourseStatus GetByEdCodeCourseStatusId(TransactionManager transactionManager, System.Decimal _edCodeCourseStatusId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeCourseStatusId(transactionManager, _edCodeCourseStatusId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_COURSE_STATUS index.
		/// </summary>
		/// <param name="_edCodeCourseStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeCourseStatus"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeCourseStatus GetByEdCodeCourseStatusId(System.Decimal _edCodeCourseStatusId, int start, int pageLength, out int count)
		{
			return GetByEdCodeCourseStatusId(null, _edCodeCourseStatusId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_COURSE_STATUS index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeCourseStatusId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeCourseStatus"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdCodeCourseStatus GetByEdCodeCourseStatusId(TransactionManager transactionManager, System.Decimal _edCodeCourseStatusId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdCodeCourseStatus&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdCodeCourseStatus&gt;"/></returns>
		public static TList<EdCodeCourseStatus> Fill(IDataReader reader, TList<EdCodeCourseStatus> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdCodeCourseStatus c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdCodeCourseStatus")
					.Append("|").Append((System.Decimal)reader["ED_CODE_COURSE_STATUS_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdCodeCourseStatus>(
					key.ToString(), // EntityTrackingKey
					"EdCodeCourseStatus",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdCodeCourseStatus();
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
					c.EdCodeCourseStatusId = (System.Decimal)reader["ED_CODE_COURSE_STATUS_ID"];
					c.OriginalEdCodeCourseStatusId = c.EdCodeCourseStatusId;
					c.DescrAr = (System.String)reader["DESCR_AR"];
					c.DescrEn = (System.String)reader["DESCR_EN"];
					c.Symbol = Convert.IsDBNull(reader["SYMBOL"]) ? null : (System.String)reader["SYMBOL"];
					c.ShowFlg = (System.Decimal)reader["SHOW_FLG"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCodeCourseStatus"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeCourseStatus"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdCodeCourseStatus entity)
		{
			if (!reader.Read()) return;
			
			entity.EdCodeCourseStatusId = (System.Decimal)reader[((int)EdCodeCourseStatusColumn.EdCodeCourseStatusId - 1)];
			entity.OriginalEdCodeCourseStatusId = (System.Decimal)reader["ED_CODE_COURSE_STATUS_ID"];
			entity.DescrAr = (System.String)reader[((int)EdCodeCourseStatusColumn.DescrAr - 1)];
			entity.DescrEn = (System.String)reader[((int)EdCodeCourseStatusColumn.DescrEn - 1)];
			entity.Symbol = (reader.IsDBNull(((int)EdCodeCourseStatusColumn.Symbol - 1)))?null:(System.String)reader[((int)EdCodeCourseStatusColumn.Symbol - 1)];
			entity.ShowFlg = (System.Decimal)reader[((int)EdCodeCourseStatusColumn.ShowFlg - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCodeCourseStatus"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeCourseStatus"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdCodeCourseStatus entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdCodeCourseStatusId = (System.Decimal)dataRow["ED_CODE_COURSE_STATUS_ID"];
			entity.OriginalEdCodeCourseStatusId = (System.Decimal)dataRow["ED_CODE_COURSE_STATUS_ID"];
			entity.DescrAr = (System.String)dataRow["DESCR_AR"];
			entity.DescrEn = (System.String)dataRow["DESCR_EN"];
			entity.Symbol = Convert.IsDBNull(dataRow["SYMBOL"]) ? null : (System.String)dataRow["SYMBOL"];
			entity.ShowFlg = (System.Decimal)dataRow["SHOW_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeCourseStatus"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCodeCourseStatus Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeCourseStatus entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEdCodeCourseStatusId methods when available
			
			#region EdStudIntTrnsCourseFromCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudIntTrnsCourseFrom>|EdStudIntTrnsCourseFromCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudIntTrnsCourseFromCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudIntTrnsCourseFromCollection = DataRepository.EdStudIntTrnsCourseFromProvider.GetByEdCodeCourseStatusId(transactionManager, entity.EdCodeCourseStatusId);

				if (deep && entity.EdStudIntTrnsCourseFromCollection.Count > 0)
				{
					deepHandles.Add("EdStudIntTrnsCourseFromCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudIntTrnsCourseFrom>) DataRepository.EdStudIntTrnsCourseFromProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudIntTrnsCourseFromCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudCourseGrdChngCollectionGetByEdCodeCourseStsNewId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudCourseGrdChng>|EdStudCourseGrdChngCollectionGetByEdCodeCourseStsNewId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCourseGrdChngCollectionGetByEdCodeCourseStsNewId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCourseGrdChngCollectionGetByEdCodeCourseStsNewId = DataRepository.EdStudCourseGrdChngProvider.GetByEdCodeCourseStsNewId(transactionManager, entity.EdCodeCourseStatusId);

				if (deep && entity.EdStudCourseGrdChngCollectionGetByEdCodeCourseStsNewId.Count > 0)
				{
					deepHandles.Add("EdStudCourseGrdChngCollectionGetByEdCodeCourseStsNewId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCourseGrdChng>) DataRepository.EdStudCourseGrdChngProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCourseGrdChngCollectionGetByEdCodeCourseStsNewId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudCourseRegCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudCourseReg>|EdStudCourseRegCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCourseRegCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCourseRegCollection = DataRepository.EdStudCourseRegProvider.GetByEdCodeCourseStatusId(transactionManager, entity.EdCodeCourseStatusId);

				if (deep && entity.EdStudCourseRegCollection.Count > 0)
				{
					deepHandles.Add("EdStudCourseRegCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCourseReg>) DataRepository.EdStudCourseRegProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCourseRegCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudCourseRegAssessCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudCourseRegAssess>|EdStudCourseRegAssessCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCourseRegAssessCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCourseRegAssessCollection = DataRepository.EdStudCourseRegAssessProvider.GetByEdCodeCourseStatusId(transactionManager, entity.EdCodeCourseStatusId);

				if (deep && entity.EdStudCourseRegAssessCollection.Count > 0)
				{
					deepHandles.Add("EdStudCourseRegAssessCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCourseRegAssess>) DataRepository.EdStudCourseRegAssessProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCourseRegAssessCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStdCrsExamCollectionGetByEdCodeCourseStatusNewId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStdCrsExam>|EdStdCrsExamCollectionGetByEdCodeCourseStatusNewId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStdCrsExamCollectionGetByEdCodeCourseStatusNewId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStdCrsExamCollectionGetByEdCodeCourseStatusNewId = DataRepository.EdStdCrsExamProvider.GetByEdCodeCourseStatusNewId(transactionManager, entity.EdCodeCourseStatusId);

				if (deep && entity.EdStdCrsExamCollectionGetByEdCodeCourseStatusNewId.Count > 0)
				{
					deepHandles.Add("EdStdCrsExamCollectionGetByEdCodeCourseStatusNewId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStdCrsExam>) DataRepository.EdStdCrsExamProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStdCrsExamCollectionGetByEdCodeCourseStatusNewId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudCourseGrdChngCollectionGetByEdCodeCourseStsOldId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudCourseGrdChng>|EdStudCourseGrdChngCollectionGetByEdCodeCourseStsOldId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCourseGrdChngCollectionGetByEdCodeCourseStsOldId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCourseGrdChngCollectionGetByEdCodeCourseStsOldId = DataRepository.EdStudCourseGrdChngProvider.GetByEdCodeCourseStsOldId(transactionManager, entity.EdCodeCourseStatusId);

				if (deep && entity.EdStudCourseGrdChngCollectionGetByEdCodeCourseStsOldId.Count > 0)
				{
					deepHandles.Add("EdStudCourseGrdChngCollectionGetByEdCodeCourseStsOldId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCourseGrdChng>) DataRepository.EdStudCourseGrdChngProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCourseGrdChngCollectionGetByEdCodeCourseStsOldId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStdCrsExamCollectionGetByEdCodeCourseStatusOldId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStdCrsExam>|EdStdCrsExamCollectionGetByEdCodeCourseStatusOldId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStdCrsExamCollectionGetByEdCodeCourseStatusOldId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStdCrsExamCollectionGetByEdCodeCourseStatusOldId = DataRepository.EdStdCrsExamProvider.GetByEdCodeCourseStatusOldId(transactionManager, entity.EdCodeCourseStatusId);

				if (deep && entity.EdStdCrsExamCollectionGetByEdCodeCourseStatusOldId.Count > 0)
				{
					deepHandles.Add("EdStdCrsExamCollectionGetByEdCodeCourseStatusOldId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStdCrsExam>) DataRepository.EdStdCrsExamProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStdCrsExamCollectionGetByEdCodeCourseStatusOldId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudCourseRegTempCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudCourseRegTemp>|EdStudCourseRegTempCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCourseRegTempCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCourseRegTempCollection = DataRepository.EdStudCourseRegTempProvider.GetByEdCodeCourseStatusId(transactionManager, entity.EdCodeCourseStatusId);

				if (deep && entity.EdStudCourseRegTempCollection.Count > 0)
				{
					deepHandles.Add("EdStudCourseRegTempCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCourseRegTemp>) DataRepository.EdStudCourseRegTempProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCourseRegTempCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudIntTrnsCourseToCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudIntTrnsCourseTo>|EdStudIntTrnsCourseToCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudIntTrnsCourseToCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudIntTrnsCourseToCollection = DataRepository.EdStudIntTrnsCourseToProvider.GetByEdCodeCourseStatusId(transactionManager, entity.EdCodeCourseStatusId);

				if (deep && entity.EdStudIntTrnsCourseToCollection.Count > 0)
				{
					deepHandles.Add("EdStudIntTrnsCourseToCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudIntTrnsCourseTo>) DataRepository.EdStudIntTrnsCourseToProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudIntTrnsCourseToCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntPolcyGrdngHdrCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntPolcyGrdngHdr>|EntPolcyGrdngHdrCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPolcyGrdngHdrCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntPolcyGrdngHdrCollection = DataRepository.EntPolcyGrdngHdrProvider.GetByEdCodeCourseStatusNewId(transactionManager, entity.EdCodeCourseStatusId);

				if (deep && entity.EntPolcyGrdngHdrCollection.Count > 0)
				{
					deepHandles.Add("EntPolcyGrdngHdrCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntPolcyGrdngHdr>) DataRepository.EntPolcyGrdngHdrProvider.DeepLoad,
						new object[] { transactionManager, entity.EntPolcyGrdngHdrCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdCodeCourseStatus object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdCodeCourseStatus instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCodeCourseStatus Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeCourseStatus entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<EdStudIntTrnsCourseFrom>
				if (CanDeepSave(entity.EdStudIntTrnsCourseFromCollection, "List<EdStudIntTrnsCourseFrom>|EdStudIntTrnsCourseFromCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudIntTrnsCourseFrom child in entity.EdStudIntTrnsCourseFromCollection)
					{
						if(child.EdCodeCourseStatusIdSource != null)
						{
							child.EdCodeCourseStatusId = child.EdCodeCourseStatusIdSource.EdCodeCourseStatusId;
						}
						else
						{
							child.EdCodeCourseStatusId = entity.EdCodeCourseStatusId;
						}

					}

					if (entity.EdStudIntTrnsCourseFromCollection.Count > 0 || entity.EdStudIntTrnsCourseFromCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudIntTrnsCourseFromProvider.Save(transactionManager, entity.EdStudIntTrnsCourseFromCollection);
						
						deepHandles.Add("EdStudIntTrnsCourseFromCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudIntTrnsCourseFrom >) DataRepository.EdStudIntTrnsCourseFromProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudIntTrnsCourseFromCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudCourseGrdChng>
				if (CanDeepSave(entity.EdStudCourseGrdChngCollectionGetByEdCodeCourseStsNewId, "List<EdStudCourseGrdChng>|EdStudCourseGrdChngCollectionGetByEdCodeCourseStsNewId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudCourseGrdChng child in entity.EdStudCourseGrdChngCollectionGetByEdCodeCourseStsNewId)
					{
						if(child.EdCodeCourseStsNewIdSource != null)
						{
							child.EdCodeCourseStsNewId = child.EdCodeCourseStsNewIdSource.EdCodeCourseStatusId;
						}
						else
						{
							child.EdCodeCourseStsNewId = entity.EdCodeCourseStatusId;
						}

					}

					if (entity.EdStudCourseGrdChngCollectionGetByEdCodeCourseStsNewId.Count > 0 || entity.EdStudCourseGrdChngCollectionGetByEdCodeCourseStsNewId.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudCourseGrdChngProvider.Save(transactionManager, entity.EdStudCourseGrdChngCollectionGetByEdCodeCourseStsNewId);
						
						deepHandles.Add("EdStudCourseGrdChngCollectionGetByEdCodeCourseStsNewId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudCourseGrdChng >) DataRepository.EdStudCourseGrdChngProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCourseGrdChngCollectionGetByEdCodeCourseStsNewId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudCourseReg>
				if (CanDeepSave(entity.EdStudCourseRegCollection, "List<EdStudCourseReg>|EdStudCourseRegCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudCourseReg child in entity.EdStudCourseRegCollection)
					{
						if(child.EdCodeCourseStatusIdSource != null)
						{
							child.EdCodeCourseStatusId = child.EdCodeCourseStatusIdSource.EdCodeCourseStatusId;
						}
						else
						{
							child.EdCodeCourseStatusId = entity.EdCodeCourseStatusId;
						}

					}

					if (entity.EdStudCourseRegCollection.Count > 0 || entity.EdStudCourseRegCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudCourseRegProvider.Save(transactionManager, entity.EdStudCourseRegCollection);
						
						deepHandles.Add("EdStudCourseRegCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudCourseReg >) DataRepository.EdStudCourseRegProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCourseRegCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudCourseRegAssess>
				if (CanDeepSave(entity.EdStudCourseRegAssessCollection, "List<EdStudCourseRegAssess>|EdStudCourseRegAssessCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudCourseRegAssess child in entity.EdStudCourseRegAssessCollection)
					{
						if(child.EdCodeCourseStatusIdSource != null)
						{
							child.EdCodeCourseStatusId = child.EdCodeCourseStatusIdSource.EdCodeCourseStatusId;
						}
						else
						{
							child.EdCodeCourseStatusId = entity.EdCodeCourseStatusId;
						}

					}

					if (entity.EdStudCourseRegAssessCollection.Count > 0 || entity.EdStudCourseRegAssessCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudCourseRegAssessProvider.Save(transactionManager, entity.EdStudCourseRegAssessCollection);
						
						deepHandles.Add("EdStudCourseRegAssessCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudCourseRegAssess >) DataRepository.EdStudCourseRegAssessProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCourseRegAssessCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStdCrsExam>
				if (CanDeepSave(entity.EdStdCrsExamCollectionGetByEdCodeCourseStatusNewId, "List<EdStdCrsExam>|EdStdCrsExamCollectionGetByEdCodeCourseStatusNewId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStdCrsExam child in entity.EdStdCrsExamCollectionGetByEdCodeCourseStatusNewId)
					{
						if(child.EdCodeCourseStatusNewIdSource != null)
						{
							child.EdCodeCourseStatusNewId = child.EdCodeCourseStatusNewIdSource.EdCodeCourseStatusId;
						}
						else
						{
							child.EdCodeCourseStatusNewId = entity.EdCodeCourseStatusId;
						}

					}

					if (entity.EdStdCrsExamCollectionGetByEdCodeCourseStatusNewId.Count > 0 || entity.EdStdCrsExamCollectionGetByEdCodeCourseStatusNewId.DeletedItems.Count > 0)
					{
						//DataRepository.EdStdCrsExamProvider.Save(transactionManager, entity.EdStdCrsExamCollectionGetByEdCodeCourseStatusNewId);
						
						deepHandles.Add("EdStdCrsExamCollectionGetByEdCodeCourseStatusNewId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStdCrsExam >) DataRepository.EdStdCrsExamProvider.DeepSave,
							new object[] { transactionManager, entity.EdStdCrsExamCollectionGetByEdCodeCourseStatusNewId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudCourseGrdChng>
				if (CanDeepSave(entity.EdStudCourseGrdChngCollectionGetByEdCodeCourseStsOldId, "List<EdStudCourseGrdChng>|EdStudCourseGrdChngCollectionGetByEdCodeCourseStsOldId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudCourseGrdChng child in entity.EdStudCourseGrdChngCollectionGetByEdCodeCourseStsOldId)
					{
						if(child.EdCodeCourseStsOldIdSource != null)
						{
							child.EdCodeCourseStsOldId = child.EdCodeCourseStsOldIdSource.EdCodeCourseStatusId;
						}
						else
						{
							child.EdCodeCourseStsOldId = entity.EdCodeCourseStatusId;
						}

					}

					if (entity.EdStudCourseGrdChngCollectionGetByEdCodeCourseStsOldId.Count > 0 || entity.EdStudCourseGrdChngCollectionGetByEdCodeCourseStsOldId.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudCourseGrdChngProvider.Save(transactionManager, entity.EdStudCourseGrdChngCollectionGetByEdCodeCourseStsOldId);
						
						deepHandles.Add("EdStudCourseGrdChngCollectionGetByEdCodeCourseStsOldId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudCourseGrdChng >) DataRepository.EdStudCourseGrdChngProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCourseGrdChngCollectionGetByEdCodeCourseStsOldId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStdCrsExam>
				if (CanDeepSave(entity.EdStdCrsExamCollectionGetByEdCodeCourseStatusOldId, "List<EdStdCrsExam>|EdStdCrsExamCollectionGetByEdCodeCourseStatusOldId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStdCrsExam child in entity.EdStdCrsExamCollectionGetByEdCodeCourseStatusOldId)
					{
						if(child.EdCodeCourseStatusOldIdSource != null)
						{
							child.EdCodeCourseStatusOldId = child.EdCodeCourseStatusOldIdSource.EdCodeCourseStatusId;
						}
						else
						{
							child.EdCodeCourseStatusOldId = entity.EdCodeCourseStatusId;
						}

					}

					if (entity.EdStdCrsExamCollectionGetByEdCodeCourseStatusOldId.Count > 0 || entity.EdStdCrsExamCollectionGetByEdCodeCourseStatusOldId.DeletedItems.Count > 0)
					{
						//DataRepository.EdStdCrsExamProvider.Save(transactionManager, entity.EdStdCrsExamCollectionGetByEdCodeCourseStatusOldId);
						
						deepHandles.Add("EdStdCrsExamCollectionGetByEdCodeCourseStatusOldId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStdCrsExam >) DataRepository.EdStdCrsExamProvider.DeepSave,
							new object[] { transactionManager, entity.EdStdCrsExamCollectionGetByEdCodeCourseStatusOldId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudCourseRegTemp>
				if (CanDeepSave(entity.EdStudCourseRegTempCollection, "List<EdStudCourseRegTemp>|EdStudCourseRegTempCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudCourseRegTemp child in entity.EdStudCourseRegTempCollection)
					{
						if(child.EdCodeCourseStatusIdSource != null)
						{
							child.EdCodeCourseStatusId = child.EdCodeCourseStatusIdSource.EdCodeCourseStatusId;
						}
						else
						{
							child.EdCodeCourseStatusId = entity.EdCodeCourseStatusId;
						}

					}

					if (entity.EdStudCourseRegTempCollection.Count > 0 || entity.EdStudCourseRegTempCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudCourseRegTempProvider.Save(transactionManager, entity.EdStudCourseRegTempCollection);
						
						deepHandles.Add("EdStudCourseRegTempCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudCourseRegTemp >) DataRepository.EdStudCourseRegTempProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCourseRegTempCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudIntTrnsCourseTo>
				if (CanDeepSave(entity.EdStudIntTrnsCourseToCollection, "List<EdStudIntTrnsCourseTo>|EdStudIntTrnsCourseToCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudIntTrnsCourseTo child in entity.EdStudIntTrnsCourseToCollection)
					{
						if(child.EdCodeCourseStatusIdSource != null)
						{
							child.EdCodeCourseStatusId = child.EdCodeCourseStatusIdSource.EdCodeCourseStatusId;
						}
						else
						{
							child.EdCodeCourseStatusId = entity.EdCodeCourseStatusId;
						}

					}

					if (entity.EdStudIntTrnsCourseToCollection.Count > 0 || entity.EdStudIntTrnsCourseToCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudIntTrnsCourseToProvider.Save(transactionManager, entity.EdStudIntTrnsCourseToCollection);
						
						deepHandles.Add("EdStudIntTrnsCourseToCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudIntTrnsCourseTo >) DataRepository.EdStudIntTrnsCourseToProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudIntTrnsCourseToCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntPolcyGrdngHdr>
				if (CanDeepSave(entity.EntPolcyGrdngHdrCollection, "List<EntPolcyGrdngHdr>|EntPolcyGrdngHdrCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntPolcyGrdngHdr child in entity.EntPolcyGrdngHdrCollection)
					{
						if(child.EdCodeCourseStatusNewIdSource != null)
						{
							child.EdCodeCourseStatusNewId = child.EdCodeCourseStatusNewIdSource.EdCodeCourseStatusId;
						}
						else
						{
							child.EdCodeCourseStatusNewId = entity.EdCodeCourseStatusId;
						}

					}

					if (entity.EntPolcyGrdngHdrCollection.Count > 0 || entity.EntPolcyGrdngHdrCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntPolcyGrdngHdrProvider.Save(transactionManager, entity.EntPolcyGrdngHdrCollection);
						
						deepHandles.Add("EntPolcyGrdngHdrCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntPolcyGrdngHdr >) DataRepository.EntPolcyGrdngHdrProvider.DeepSave,
							new object[] { transactionManager, entity.EntPolcyGrdngHdrCollection, deepSaveType, childTypes, innerList }
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
	
	#region EdCodeCourseStatusChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdCodeCourseStatus</c>
	///</summary>
	public enum EdCodeCourseStatusChildEntityTypes
	{
		///<summary>
		/// Collection of <c>EdCodeCourseStatus</c> as OneToMany for EdStudIntTrnsCourseFromCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudIntTrnsCourseFrom>))]
		EdStudIntTrnsCourseFromCollection,
		///<summary>
		/// Collection of <c>EdCodeCourseStatus</c> as OneToMany for EdStudCourseGrdChngCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCourseGrdChng>))]
		EdStudCourseGrdChngCollectionGetByEdCodeCourseStsNewId,
		///<summary>
		/// Collection of <c>EdCodeCourseStatus</c> as OneToMany for EdStudCourseRegCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCourseReg>))]
		EdStudCourseRegCollection,
		///<summary>
		/// Collection of <c>EdCodeCourseStatus</c> as OneToMany for EdStudCourseRegAssessCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCourseRegAssess>))]
		EdStudCourseRegAssessCollection,
		///<summary>
		/// Collection of <c>EdCodeCourseStatus</c> as OneToMany for EdStdCrsExamCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStdCrsExam>))]
		EdStdCrsExamCollectionGetByEdCodeCourseStatusNewId,
		///<summary>
		/// Collection of <c>EdCodeCourseStatus</c> as OneToMany for EdStudCourseGrdChngCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCourseGrdChng>))]
		EdStudCourseGrdChngCollectionGetByEdCodeCourseStsOldId,
		///<summary>
		/// Collection of <c>EdCodeCourseStatus</c> as OneToMany for EdStdCrsExamCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStdCrsExam>))]
		EdStdCrsExamCollectionGetByEdCodeCourseStatusOldId,
		///<summary>
		/// Collection of <c>EdCodeCourseStatus</c> as OneToMany for EdStudCourseRegTempCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCourseRegTemp>))]
		EdStudCourseRegTempCollection,
		///<summary>
		/// Collection of <c>EdCodeCourseStatus</c> as OneToMany for EdStudIntTrnsCourseToCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudIntTrnsCourseTo>))]
		EdStudIntTrnsCourseToCollection,
		///<summary>
		/// Collection of <c>EdCodeCourseStatus</c> as OneToMany for EntPolcyGrdngHdrCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntPolcyGrdngHdr>))]
		EntPolcyGrdngHdrCollection,
	}
	
	#endregion EdCodeCourseStatusChildEntityTypes
	
	#region EdCodeCourseStatusFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdCodeCourseStatusColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeCourseStatus"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCodeCourseStatusFilterBuilder : SqlFilterBuilder<EdCodeCourseStatusColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeCourseStatusFilterBuilder class.
		/// </summary>
		public EdCodeCourseStatusFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCodeCourseStatusFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCodeCourseStatusFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCodeCourseStatusFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCodeCourseStatusFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCodeCourseStatusFilterBuilder
	
	#region EdCodeCourseStatusParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdCodeCourseStatusColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeCourseStatus"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCodeCourseStatusParameterBuilder : ParameterizedSqlFilterBuilder<EdCodeCourseStatusColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeCourseStatusParameterBuilder class.
		/// </summary>
		public EdCodeCourseStatusParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCodeCourseStatusParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCodeCourseStatusParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCodeCourseStatusParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCodeCourseStatusParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCodeCourseStatusParameterBuilder
	
	#region EdCodeCourseStatusSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdCodeCourseStatusColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeCourseStatus"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdCodeCourseStatusSortBuilder : SqlSortBuilder<EdCodeCourseStatusColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeCourseStatusSqlSortBuilder class.
		/// </summary>
		public EdCodeCourseStatusSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdCodeCourseStatusSortBuilder
	
} // end namespace
