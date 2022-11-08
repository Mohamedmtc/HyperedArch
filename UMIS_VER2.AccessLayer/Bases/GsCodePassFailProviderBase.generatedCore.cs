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
	/// This class is the base class for any <see cref="GsCodePassFailProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GsCodePassFailProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.GsCodePassFail, UMIS_VER2.BusinessLyer.GsCodePassFailKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodePassFailKey key)
		{
			return Delete(transactionManager, key.GsCodePassFailId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_gsCodePassFailId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _gsCodePassFailId)
		{
			return Delete(null, _gsCodePassFailId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodePassFailId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _gsCodePassFailId);		
		
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
		public override UMIS_VER2.BusinessLyer.GsCodePassFail Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodePassFailKey key, int start, int pageLength)
		{
			return GetByGsCodePassFailId(transactionManager, key.GsCodePassFailId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_GS_CODE_PASS_FAIL index.
		/// </summary>
		/// <param name="_gsCodePassFailId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodePassFail"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodePassFail GetByGsCodePassFailId(System.Decimal _gsCodePassFailId)
		{
			int count = -1;
			return GetByGsCodePassFailId(null,_gsCodePassFailId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_PASS_FAIL index.
		/// </summary>
		/// <param name="_gsCodePassFailId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodePassFail"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodePassFail GetByGsCodePassFailId(System.Decimal _gsCodePassFailId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodePassFailId(null, _gsCodePassFailId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_PASS_FAIL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodePassFailId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodePassFail"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodePassFail GetByGsCodePassFailId(TransactionManager transactionManager, System.Decimal _gsCodePassFailId)
		{
			int count = -1;
			return GetByGsCodePassFailId(transactionManager, _gsCodePassFailId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_PASS_FAIL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodePassFailId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodePassFail"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodePassFail GetByGsCodePassFailId(TransactionManager transactionManager, System.Decimal _gsCodePassFailId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodePassFailId(transactionManager, _gsCodePassFailId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_PASS_FAIL index.
		/// </summary>
		/// <param name="_gsCodePassFailId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodePassFail"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodePassFail GetByGsCodePassFailId(System.Decimal _gsCodePassFailId, int start, int pageLength, out int count)
		{
			return GetByGsCodePassFailId(null, _gsCodePassFailId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_PASS_FAIL index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodePassFailId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodePassFail"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsCodePassFail GetByGsCodePassFailId(TransactionManager transactionManager, System.Decimal _gsCodePassFailId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GsCodePassFail&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GsCodePassFail&gt;"/></returns>
		public static TList<GsCodePassFail> Fill(IDataReader reader, TList<GsCodePassFail> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.GsCodePassFail c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GsCodePassFail")
					.Append("|").Append((System.Decimal)reader["GS_CODE_PASS_FAIL_ID"]).ToString();
					c = EntityManager.LocateOrCreate<GsCodePassFail>(
					key.ToString(), // EntityTrackingKey
					"GsCodePassFail",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.GsCodePassFail();
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
					c.GsCodePassFailId = (System.Decimal)reader["GS_CODE_PASS_FAIL_ID"];
					c.OriginalGsCodePassFailId = c.GsCodePassFailId;
					c.PfCode = Convert.IsDBNull(reader["PF_CODE"]) ? null : (System.String)reader["PF_CODE"];
					c.DescrAr = Convert.IsDBNull(reader["DESCR_AR"]) ? null : (System.String)reader["DESCR_AR"];
					c.DescrEn = Convert.IsDBNull(reader["DESCR_EN"]) ? null : (System.String)reader["DESCR_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCodePassFail"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCodePassFail"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.GsCodePassFail entity)
		{
			if (!reader.Read()) return;
			
			entity.GsCodePassFailId = (System.Decimal)reader[((int)GsCodePassFailColumn.GsCodePassFailId - 1)];
			entity.OriginalGsCodePassFailId = (System.Decimal)reader["GS_CODE_PASS_FAIL_ID"];
			entity.PfCode = (reader.IsDBNull(((int)GsCodePassFailColumn.PfCode - 1)))?null:(System.String)reader[((int)GsCodePassFailColumn.PfCode - 1)];
			entity.DescrAr = (reader.IsDBNull(((int)GsCodePassFailColumn.DescrAr - 1)))?null:(System.String)reader[((int)GsCodePassFailColumn.DescrAr - 1)];
			entity.DescrEn = (reader.IsDBNull(((int)GsCodePassFailColumn.DescrEn - 1)))?null:(System.String)reader[((int)GsCodePassFailColumn.DescrEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCodePassFail"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCodePassFail"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.GsCodePassFail entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.GsCodePassFailId = (System.Decimal)dataRow["GS_CODE_PASS_FAIL_ID"];
			entity.OriginalGsCodePassFailId = (System.Decimal)dataRow["GS_CODE_PASS_FAIL_ID"];
			entity.PfCode = Convert.IsDBNull(dataRow["PF_CODE"]) ? null : (System.String)dataRow["PF_CODE"];
			entity.DescrAr = Convert.IsDBNull(dataRow["DESCR_AR"]) ? null : (System.String)dataRow["DESCR_AR"];
			entity.DescrEn = Convert.IsDBNull(dataRow["DESCR_EN"]) ? null : (System.String)dataRow["DESCR_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCodePassFail"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCodePassFail Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodePassFail entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByGsCodePassFailId methods when available
			
			#region EdStudCourseRegAddCollectionGetByActualGsCodePassFailId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudCourseRegAdd>|EdStudCourseRegAddCollectionGetByActualGsCodePassFailId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCourseRegAddCollectionGetByActualGsCodePassFailId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCourseRegAddCollectionGetByActualGsCodePassFailId = DataRepository.EdStudCourseRegAddProvider.GetByActualGsCodePassFailId(transactionManager, entity.GsCodePassFailId);

				if (deep && entity.EdStudCourseRegAddCollectionGetByActualGsCodePassFailId.Count > 0)
				{
					deepHandles.Add("EdStudCourseRegAddCollectionGetByActualGsCodePassFailId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCourseRegAdd>) DataRepository.EdStudCourseRegAddProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCourseRegAddCollectionGetByActualGsCodePassFailId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmAppTransToCourseCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppTransToCourse>|AdmAppTransToCourseCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppTransToCourseCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppTransToCourseCollection = DataRepository.AdmAppTransToCourseProvider.GetByGsCodePassFailId(transactionManager, entity.GsCodePassFailId);

				if (deep && entity.AdmAppTransToCourseCollection.Count > 0)
				{
					deepHandles.Add("AdmAppTransToCourseCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppTransToCourse>) DataRepository.AdmAppTransToCourseProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppTransToCourseCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmExamGrdngPkgDtlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmExamGrdngPkgDtl>|AdmExamGrdngPkgDtlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmExamGrdngPkgDtlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmExamGrdngPkgDtlCollection = DataRepository.AdmExamGrdngPkgDtlProvider.GetByGsCodePassFailId(transactionManager, entity.GsCodePassFailId);

				if (deep && entity.AdmExamGrdngPkgDtlCollection.Count > 0)
				{
					deepHandles.Add("AdmExamGrdngPkgDtlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmExamGrdngPkgDtl>) DataRepository.AdmExamGrdngPkgDtlProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmExamGrdngPkgDtlCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudCourseRegAddCollectionGetByFinalGsCodePassFailId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudCourseRegAdd>|EdStudCourseRegAddCollectionGetByFinalGsCodePassFailId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCourseRegAddCollectionGetByFinalGsCodePassFailId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCourseRegAddCollectionGetByFinalGsCodePassFailId = DataRepository.EdStudCourseRegAddProvider.GetByFinalGsCodePassFailId(transactionManager, entity.GsCodePassFailId);

				if (deep && entity.EdStudCourseRegAddCollectionGetByFinalGsCodePassFailId.Count > 0)
				{
					deepHandles.Add("EdStudCourseRegAddCollectionGetByFinalGsCodePassFailId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCourseRegAdd>) DataRepository.EdStudCourseRegAddProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCourseRegAddCollectionGetByFinalGsCodePassFailId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStdCrsExamCollectionGetByGsCodePassFailOldId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStdCrsExam>|EdStdCrsExamCollectionGetByGsCodePassFailOldId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStdCrsExamCollectionGetByGsCodePassFailOldId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStdCrsExamCollectionGetByGsCodePassFailOldId = DataRepository.EdStdCrsExamProvider.GetByGsCodePassFailOldId(transactionManager, entity.GsCodePassFailId);

				if (deep && entity.EdStdCrsExamCollectionGetByGsCodePassFailOldId.Count > 0)
				{
					deepHandles.Add("EdStdCrsExamCollectionGetByGsCodePassFailOldId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStdCrsExam>) DataRepository.EdStdCrsExamProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStdCrsExamCollectionGetByGsCodePassFailOldId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmPlaceExamCourseCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmPlaceExamCourse>|AdmPlaceExamCourseCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmPlaceExamCourseCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmPlaceExamCourseCollection = DataRepository.AdmPlaceExamCourseProvider.GetByGsCodePassFailId(transactionManager, entity.GsCodePassFailId);

				if (deep && entity.AdmPlaceExamCourseCollection.Count > 0)
				{
					deepHandles.Add("AdmPlaceExamCourseCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmPlaceExamCourse>) DataRepository.AdmPlaceExamCourseProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmPlaceExamCourseCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region MltStudBhvrAttndcCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<MltStudBhvrAttndc>|MltStudBhvrAttndcCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MltStudBhvrAttndcCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.MltStudBhvrAttndcCollection = DataRepository.MltStudBhvrAttndcProvider.GetByGsCodePassFailId(transactionManager, entity.GsCodePassFailId);

				if (deep && entity.MltStudBhvrAttndcCollection.Count > 0)
				{
					deepHandles.Add("MltStudBhvrAttndcCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<MltStudBhvrAttndc>) DataRepository.MltStudBhvrAttndcProvider.DeepLoad,
						new object[] { transactionManager, entity.MltStudBhvrAttndcCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.EdStudCourseRegCollection = DataRepository.EdStudCourseRegProvider.GetByGsCodePassFailId(transactionManager, entity.GsCodePassFailId);

				if (deep && entity.EdStudCourseRegCollection.Count > 0)
				{
					deepHandles.Add("EdStudCourseRegCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCourseReg>) DataRepository.EdStudCourseRegProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCourseRegCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmAppTransFromCourseCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppTransFromCourse>|AdmAppTransFromCourseCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppTransFromCourseCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppTransFromCourseCollection = DataRepository.AdmAppTransFromCourseProvider.GetByGsCodePassFailId(transactionManager, entity.GsCodePassFailId);

				if (deep && entity.AdmAppTransFromCourseCollection.Count > 0)
				{
					deepHandles.Add("AdmAppTransFromCourseCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppTransFromCourse>) DataRepository.AdmAppTransFromCourseProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppTransFromCourseCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.EdStudIntTrnsCourseToCollection = DataRepository.EdStudIntTrnsCourseToProvider.GetByGsCodePassFailId(transactionManager, entity.GsCodePassFailId);

				if (deep && entity.EdStudIntTrnsCourseToCollection.Count > 0)
				{
					deepHandles.Add("EdStudIntTrnsCourseToCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudIntTrnsCourseTo>) DataRepository.EdStudIntTrnsCourseToProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudIntTrnsCourseToCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntPolicyGradingDtlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntPolicyGradingDtl>|EntPolicyGradingDtlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPolicyGradingDtlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntPolicyGradingDtlCollection = DataRepository.EntPolicyGradingDtlProvider.GetByGsCodePassFailId(transactionManager, entity.GsCodePassFailId);

				if (deep && entity.EntPolicyGradingDtlCollection.Count > 0)
				{
					deepHandles.Add("EntPolicyGradingDtlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntPolicyGradingDtl>) DataRepository.EntPolicyGradingDtlProvider.DeepLoad,
						new object[] { transactionManager, entity.EntPolicyGradingDtlCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStdCrsExamCollectionGetByGsCodePassFailNewId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStdCrsExam>|EdStdCrsExamCollectionGetByGsCodePassFailNewId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStdCrsExamCollectionGetByGsCodePassFailNewId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStdCrsExamCollectionGetByGsCodePassFailNewId = DataRepository.EdStdCrsExamProvider.GetByGsCodePassFailNewId(transactionManager, entity.GsCodePassFailId);

				if (deep && entity.EdStdCrsExamCollectionGetByGsCodePassFailNewId.Count > 0)
				{
					deepHandles.Add("EdStdCrsExamCollectionGetByGsCodePassFailNewId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStdCrsExam>) DataRepository.EdStdCrsExamProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStdCrsExamCollectionGetByGsCodePassFailNewId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdResidencyStudCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdResidencyStud>|EdResidencyStudCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdResidencyStudCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdResidencyStudCollection = DataRepository.EdResidencyStudProvider.GetByGsCodePassFailId(transactionManager, entity.GsCodePassFailId);

				if (deep && entity.EdResidencyStudCollection.Count > 0)
				{
					deepHandles.Add("EdResidencyStudCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdResidencyStud>) DataRepository.EdResidencyStudProvider.DeepLoad,
						new object[] { transactionManager, entity.EdResidencyStudCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudIntTrnsCourseFromCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudIntTrnsCourseFrom>|EdStudIntTrnsCourseFromCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudIntTrnsCourseFromCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudIntTrnsCourseFromCollection = DataRepository.EdStudIntTrnsCourseFromProvider.GetByGsCodePassFailId(transactionManager, entity.GsCodePassFailId);

				if (deep && entity.EdStudIntTrnsCourseFromCollection.Count > 0)
				{
					deepHandles.Add("EdStudIntTrnsCourseFromCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudIntTrnsCourseFrom>) DataRepository.EdStudIntTrnsCourseFromProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudIntTrnsCourseFromCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.EdStudCourseRegTempCollection = DataRepository.EdStudCourseRegTempProvider.GetByGsCodePassFailId(transactionManager, entity.GsCodePassFailId);

				if (deep && entity.EdStudCourseRegTempCollection.Count > 0)
				{
					deepHandles.Add("EdStudCourseRegTempCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCourseRegTemp>) DataRepository.EdStudCourseRegTempProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCourseRegTempCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.GsCodePassFail object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.GsCodePassFail instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCodePassFail Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodePassFail entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<EdStudCourseRegAdd>
				if (CanDeepSave(entity.EdStudCourseRegAddCollectionGetByActualGsCodePassFailId, "List<EdStudCourseRegAdd>|EdStudCourseRegAddCollectionGetByActualGsCodePassFailId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudCourseRegAdd child in entity.EdStudCourseRegAddCollectionGetByActualGsCodePassFailId)
					{
						if(child.ActualGsCodePassFailIdSource != null)
						{
							child.ActualGsCodePassFailId = child.ActualGsCodePassFailIdSource.GsCodePassFailId;
						}
						else
						{
							child.ActualGsCodePassFailId = entity.GsCodePassFailId;
						}

					}

					if (entity.EdStudCourseRegAddCollectionGetByActualGsCodePassFailId.Count > 0 || entity.EdStudCourseRegAddCollectionGetByActualGsCodePassFailId.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudCourseRegAddProvider.Save(transactionManager, entity.EdStudCourseRegAddCollectionGetByActualGsCodePassFailId);
						
						deepHandles.Add("EdStudCourseRegAddCollectionGetByActualGsCodePassFailId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudCourseRegAdd >) DataRepository.EdStudCourseRegAddProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCourseRegAddCollectionGetByActualGsCodePassFailId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmAppTransToCourse>
				if (CanDeepSave(entity.AdmAppTransToCourseCollection, "List<AdmAppTransToCourse>|AdmAppTransToCourseCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppTransToCourse child in entity.AdmAppTransToCourseCollection)
					{
						if(child.GsCodePassFailIdSource != null)
						{
							child.GsCodePassFailId = child.GsCodePassFailIdSource.GsCodePassFailId;
						}
						else
						{
							child.GsCodePassFailId = entity.GsCodePassFailId;
						}

					}

					if (entity.AdmAppTransToCourseCollection.Count > 0 || entity.AdmAppTransToCourseCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppTransToCourseProvider.Save(transactionManager, entity.AdmAppTransToCourseCollection);
						
						deepHandles.Add("AdmAppTransToCourseCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppTransToCourse >) DataRepository.AdmAppTransToCourseProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppTransToCourseCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmExamGrdngPkgDtl>
				if (CanDeepSave(entity.AdmExamGrdngPkgDtlCollection, "List<AdmExamGrdngPkgDtl>|AdmExamGrdngPkgDtlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmExamGrdngPkgDtl child in entity.AdmExamGrdngPkgDtlCollection)
					{
						if(child.GsCodePassFailIdSource != null)
						{
							child.GsCodePassFailId = child.GsCodePassFailIdSource.GsCodePassFailId;
						}
						else
						{
							child.GsCodePassFailId = entity.GsCodePassFailId;
						}

					}

					if (entity.AdmExamGrdngPkgDtlCollection.Count > 0 || entity.AdmExamGrdngPkgDtlCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmExamGrdngPkgDtlProvider.Save(transactionManager, entity.AdmExamGrdngPkgDtlCollection);
						
						deepHandles.Add("AdmExamGrdngPkgDtlCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmExamGrdngPkgDtl >) DataRepository.AdmExamGrdngPkgDtlProvider.DeepSave,
							new object[] { transactionManager, entity.AdmExamGrdngPkgDtlCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudCourseRegAdd>
				if (CanDeepSave(entity.EdStudCourseRegAddCollectionGetByFinalGsCodePassFailId, "List<EdStudCourseRegAdd>|EdStudCourseRegAddCollectionGetByFinalGsCodePassFailId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudCourseRegAdd child in entity.EdStudCourseRegAddCollectionGetByFinalGsCodePassFailId)
					{
						if(child.FinalGsCodePassFailIdSource != null)
						{
							child.FinalGsCodePassFailId = child.FinalGsCodePassFailIdSource.GsCodePassFailId;
						}
						else
						{
							child.FinalGsCodePassFailId = entity.GsCodePassFailId;
						}

					}

					if (entity.EdStudCourseRegAddCollectionGetByFinalGsCodePassFailId.Count > 0 || entity.EdStudCourseRegAddCollectionGetByFinalGsCodePassFailId.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudCourseRegAddProvider.Save(transactionManager, entity.EdStudCourseRegAddCollectionGetByFinalGsCodePassFailId);
						
						deepHandles.Add("EdStudCourseRegAddCollectionGetByFinalGsCodePassFailId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudCourseRegAdd >) DataRepository.EdStudCourseRegAddProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCourseRegAddCollectionGetByFinalGsCodePassFailId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStdCrsExam>
				if (CanDeepSave(entity.EdStdCrsExamCollectionGetByGsCodePassFailOldId, "List<EdStdCrsExam>|EdStdCrsExamCollectionGetByGsCodePassFailOldId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStdCrsExam child in entity.EdStdCrsExamCollectionGetByGsCodePassFailOldId)
					{
						if(child.GsCodePassFailOldIdSource != null)
						{
							child.GsCodePassFailOldId = child.GsCodePassFailOldIdSource.GsCodePassFailId;
						}
						else
						{
							child.GsCodePassFailOldId = entity.GsCodePassFailId;
						}

					}

					if (entity.EdStdCrsExamCollectionGetByGsCodePassFailOldId.Count > 0 || entity.EdStdCrsExamCollectionGetByGsCodePassFailOldId.DeletedItems.Count > 0)
					{
						//DataRepository.EdStdCrsExamProvider.Save(transactionManager, entity.EdStdCrsExamCollectionGetByGsCodePassFailOldId);
						
						deepHandles.Add("EdStdCrsExamCollectionGetByGsCodePassFailOldId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStdCrsExam >) DataRepository.EdStdCrsExamProvider.DeepSave,
							new object[] { transactionManager, entity.EdStdCrsExamCollectionGetByGsCodePassFailOldId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmPlaceExamCourse>
				if (CanDeepSave(entity.AdmPlaceExamCourseCollection, "List<AdmPlaceExamCourse>|AdmPlaceExamCourseCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmPlaceExamCourse child in entity.AdmPlaceExamCourseCollection)
					{
						if(child.GsCodePassFailIdSource != null)
						{
							child.GsCodePassFailId = child.GsCodePassFailIdSource.GsCodePassFailId;
						}
						else
						{
							child.GsCodePassFailId = entity.GsCodePassFailId;
						}

					}

					if (entity.AdmPlaceExamCourseCollection.Count > 0 || entity.AdmPlaceExamCourseCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmPlaceExamCourseProvider.Save(transactionManager, entity.AdmPlaceExamCourseCollection);
						
						deepHandles.Add("AdmPlaceExamCourseCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmPlaceExamCourse >) DataRepository.AdmPlaceExamCourseProvider.DeepSave,
							new object[] { transactionManager, entity.AdmPlaceExamCourseCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<MltStudBhvrAttndc>
				if (CanDeepSave(entity.MltStudBhvrAttndcCollection, "List<MltStudBhvrAttndc>|MltStudBhvrAttndcCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(MltStudBhvrAttndc child in entity.MltStudBhvrAttndcCollection)
					{
						if(child.GsCodePassFailIdSource != null)
						{
							child.GsCodePassFailId = child.GsCodePassFailIdSource.GsCodePassFailId;
						}
						else
						{
							child.GsCodePassFailId = entity.GsCodePassFailId;
						}

					}

					if (entity.MltStudBhvrAttndcCollection.Count > 0 || entity.MltStudBhvrAttndcCollection.DeletedItems.Count > 0)
					{
						//DataRepository.MltStudBhvrAttndcProvider.Save(transactionManager, entity.MltStudBhvrAttndcCollection);
						
						deepHandles.Add("MltStudBhvrAttndcCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< MltStudBhvrAttndc >) DataRepository.MltStudBhvrAttndcProvider.DeepSave,
							new object[] { transactionManager, entity.MltStudBhvrAttndcCollection, deepSaveType, childTypes, innerList }
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
						if(child.GsCodePassFailIdSource != null)
						{
							child.GsCodePassFailId = child.GsCodePassFailIdSource.GsCodePassFailId;
						}
						else
						{
							child.GsCodePassFailId = entity.GsCodePassFailId;
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
				
	
			#region List<AdmAppTransFromCourse>
				if (CanDeepSave(entity.AdmAppTransFromCourseCollection, "List<AdmAppTransFromCourse>|AdmAppTransFromCourseCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppTransFromCourse child in entity.AdmAppTransFromCourseCollection)
					{
						if(child.GsCodePassFailIdSource != null)
						{
							child.GsCodePassFailId = child.GsCodePassFailIdSource.GsCodePassFailId;
						}
						else
						{
							child.GsCodePassFailId = entity.GsCodePassFailId;
						}

					}

					if (entity.AdmAppTransFromCourseCollection.Count > 0 || entity.AdmAppTransFromCourseCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAppTransFromCourseProvider.Save(transactionManager, entity.AdmAppTransFromCourseCollection);
						
						deepHandles.Add("AdmAppTransFromCourseCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAppTransFromCourse >) DataRepository.AdmAppTransFromCourseProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAppTransFromCourseCollection, deepSaveType, childTypes, innerList }
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
						if(child.GsCodePassFailIdSource != null)
						{
							child.GsCodePassFailId = child.GsCodePassFailIdSource.GsCodePassFailId;
						}
						else
						{
							child.GsCodePassFailId = entity.GsCodePassFailId;
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
				
	
			#region List<EntPolicyGradingDtl>
				if (CanDeepSave(entity.EntPolicyGradingDtlCollection, "List<EntPolicyGradingDtl>|EntPolicyGradingDtlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntPolicyGradingDtl child in entity.EntPolicyGradingDtlCollection)
					{
						if(child.GsCodePassFailIdSource != null)
						{
							child.GsCodePassFailId = child.GsCodePassFailIdSource.GsCodePassFailId;
						}
						else
						{
							child.GsCodePassFailId = entity.GsCodePassFailId;
						}

					}

					if (entity.EntPolicyGradingDtlCollection.Count > 0 || entity.EntPolicyGradingDtlCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntPolicyGradingDtlProvider.Save(transactionManager, entity.EntPolicyGradingDtlCollection);
						
						deepHandles.Add("EntPolicyGradingDtlCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntPolicyGradingDtl >) DataRepository.EntPolicyGradingDtlProvider.DeepSave,
							new object[] { transactionManager, entity.EntPolicyGradingDtlCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStdCrsExam>
				if (CanDeepSave(entity.EdStdCrsExamCollectionGetByGsCodePassFailNewId, "List<EdStdCrsExam>|EdStdCrsExamCollectionGetByGsCodePassFailNewId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStdCrsExam child in entity.EdStdCrsExamCollectionGetByGsCodePassFailNewId)
					{
						if(child.GsCodePassFailNewIdSource != null)
						{
							child.GsCodePassFailNewId = child.GsCodePassFailNewIdSource.GsCodePassFailId;
						}
						else
						{
							child.GsCodePassFailNewId = entity.GsCodePassFailId;
						}

					}

					if (entity.EdStdCrsExamCollectionGetByGsCodePassFailNewId.Count > 0 || entity.EdStdCrsExamCollectionGetByGsCodePassFailNewId.DeletedItems.Count > 0)
					{
						//DataRepository.EdStdCrsExamProvider.Save(transactionManager, entity.EdStdCrsExamCollectionGetByGsCodePassFailNewId);
						
						deepHandles.Add("EdStdCrsExamCollectionGetByGsCodePassFailNewId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStdCrsExam >) DataRepository.EdStdCrsExamProvider.DeepSave,
							new object[] { transactionManager, entity.EdStdCrsExamCollectionGetByGsCodePassFailNewId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdResidencyStud>
				if (CanDeepSave(entity.EdResidencyStudCollection, "List<EdResidencyStud>|EdResidencyStudCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdResidencyStud child in entity.EdResidencyStudCollection)
					{
						if(child.GsCodePassFailIdSource != null)
						{
							child.GsCodePassFailId = child.GsCodePassFailIdSource.GsCodePassFailId;
						}
						else
						{
							child.GsCodePassFailId = entity.GsCodePassFailId;
						}

					}

					if (entity.EdResidencyStudCollection.Count > 0 || entity.EdResidencyStudCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdResidencyStudProvider.Save(transactionManager, entity.EdResidencyStudCollection);
						
						deepHandles.Add("EdResidencyStudCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdResidencyStud >) DataRepository.EdResidencyStudProvider.DeepSave,
							new object[] { transactionManager, entity.EdResidencyStudCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudIntTrnsCourseFrom>
				if (CanDeepSave(entity.EdStudIntTrnsCourseFromCollection, "List<EdStudIntTrnsCourseFrom>|EdStudIntTrnsCourseFromCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudIntTrnsCourseFrom child in entity.EdStudIntTrnsCourseFromCollection)
					{
						if(child.GsCodePassFailIdSource != null)
						{
							child.GsCodePassFailId = child.GsCodePassFailIdSource.GsCodePassFailId;
						}
						else
						{
							child.GsCodePassFailId = entity.GsCodePassFailId;
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
				
	
			#region List<EdStudCourseRegTemp>
				if (CanDeepSave(entity.EdStudCourseRegTempCollection, "List<EdStudCourseRegTemp>|EdStudCourseRegTempCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudCourseRegTemp child in entity.EdStudCourseRegTempCollection)
					{
						if(child.GsCodePassFailIdSource != null)
						{
							child.GsCodePassFailId = child.GsCodePassFailIdSource.GsCodePassFailId;
						}
						else
						{
							child.GsCodePassFailId = entity.GsCodePassFailId;
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
	
	#region GsCodePassFailChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.GsCodePassFail</c>
	///</summary>
	public enum GsCodePassFailChildEntityTypes
	{
		///<summary>
		/// Collection of <c>GsCodePassFail</c> as OneToMany for EdStudCourseRegAddCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCourseRegAdd>))]
		EdStudCourseRegAddCollectionGetByActualGsCodePassFailId,
		///<summary>
		/// Collection of <c>GsCodePassFail</c> as OneToMany for AdmAppTransToCourseCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppTransToCourse>))]
		AdmAppTransToCourseCollection,
		///<summary>
		/// Collection of <c>GsCodePassFail</c> as OneToMany for AdmExamGrdngPkgDtlCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmExamGrdngPkgDtl>))]
		AdmExamGrdngPkgDtlCollection,
		///<summary>
		/// Collection of <c>GsCodePassFail</c> as OneToMany for EdStudCourseRegAddCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCourseRegAdd>))]
		EdStudCourseRegAddCollectionGetByFinalGsCodePassFailId,
		///<summary>
		/// Collection of <c>GsCodePassFail</c> as OneToMany for EdStdCrsExamCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStdCrsExam>))]
		EdStdCrsExamCollectionGetByGsCodePassFailOldId,
		///<summary>
		/// Collection of <c>GsCodePassFail</c> as OneToMany for AdmPlaceExamCourseCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmPlaceExamCourse>))]
		AdmPlaceExamCourseCollection,
		///<summary>
		/// Collection of <c>GsCodePassFail</c> as OneToMany for MltStudBhvrAttndcCollection
		///</summary>
		[ChildEntityType(typeof(TList<MltStudBhvrAttndc>))]
		MltStudBhvrAttndcCollection,
		///<summary>
		/// Collection of <c>GsCodePassFail</c> as OneToMany for EdStudCourseRegCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCourseReg>))]
		EdStudCourseRegCollection,
		///<summary>
		/// Collection of <c>GsCodePassFail</c> as OneToMany for AdmAppTransFromCourseCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppTransFromCourse>))]
		AdmAppTransFromCourseCollection,
		///<summary>
		/// Collection of <c>GsCodePassFail</c> as OneToMany for EdStudIntTrnsCourseToCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudIntTrnsCourseTo>))]
		EdStudIntTrnsCourseToCollection,
		///<summary>
		/// Collection of <c>GsCodePassFail</c> as OneToMany for EntPolicyGradingDtlCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntPolicyGradingDtl>))]
		EntPolicyGradingDtlCollection,
		///<summary>
		/// Collection of <c>GsCodePassFail</c> as OneToMany for EdStdCrsExamCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStdCrsExam>))]
		EdStdCrsExamCollectionGetByGsCodePassFailNewId,
		///<summary>
		/// Collection of <c>GsCodePassFail</c> as OneToMany for EdResidencyStudCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdResidencyStud>))]
		EdResidencyStudCollection,
		///<summary>
		/// Collection of <c>GsCodePassFail</c> as OneToMany for EdStudIntTrnsCourseFromCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudIntTrnsCourseFrom>))]
		EdStudIntTrnsCourseFromCollection,
		///<summary>
		/// Collection of <c>GsCodePassFail</c> as OneToMany for EdStudCourseRegTempCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCourseRegTemp>))]
		EdStudCourseRegTempCollection,
	}
	
	#endregion GsCodePassFailChildEntityTypes
	
	#region GsCodePassFailFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GsCodePassFailColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCodePassFail"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCodePassFailFilterBuilder : SqlFilterBuilder<GsCodePassFailColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCodePassFailFilterBuilder class.
		/// </summary>
		public GsCodePassFailFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCodePassFailFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCodePassFailFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCodePassFailFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCodePassFailFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCodePassFailFilterBuilder
	
	#region GsCodePassFailParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GsCodePassFailColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCodePassFail"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCodePassFailParameterBuilder : ParameterizedSqlFilterBuilder<GsCodePassFailColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCodePassFailParameterBuilder class.
		/// </summary>
		public GsCodePassFailParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCodePassFailParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCodePassFailParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCodePassFailParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCodePassFailParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCodePassFailParameterBuilder
	
	#region GsCodePassFailSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GsCodePassFailColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCodePassFail"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GsCodePassFailSortBuilder : SqlSortBuilder<GsCodePassFailColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCodePassFailSqlSortBuilder class.
		/// </summary>
		public GsCodePassFailSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GsCodePassFailSortBuilder
	
} // end namespace
