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
	/// This class is the base class for any <see cref="AsCodeDegreeProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AsCodeDegreeProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AsCodeDegree, UMIS_VER2.BusinessLyer.AsCodeDegreeKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AsCodeDegreeKey key)
		{
			return Delete(transactionManager, key.AsCodeDegreeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_asCodeDegreeId">مسلسل الدرجة العلمية. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _asCodeDegreeId)
		{
			return Delete(null, _asCodeDegreeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId">مسلسل الدرجة العلمية. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _asCodeDegreeId);		
		
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
		public override UMIS_VER2.BusinessLyer.AsCodeDegree Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AsCodeDegreeKey key, int start, int pageLength)
		{
			return GetByAsCodeDegreeId(transactionManager, key.AsCodeDegreeId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_AS_CODE_DEGREE_CLASS_1 index.
		/// </summary>
		/// <param name="_asCodeDegreeClassId">مسلسل نوع الدرجة العلمية</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AsCodeDegree&gt;"/> class.</returns>
		public TList<AsCodeDegree> GetByAsCodeDegreeClassId(System.Decimal _asCodeDegreeClassId)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(null,_asCodeDegreeClassId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_CODE_DEGREE_CLASS_1 index.
		/// </summary>
		/// <param name="_asCodeDegreeClassId">مسلسل نوع الدرجة العلمية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AsCodeDegree&gt;"/> class.</returns>
		public TList<AsCodeDegree> GetByAsCodeDegreeClassId(System.Decimal _asCodeDegreeClassId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(null, _asCodeDegreeClassId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_CODE_DEGREE_CLASS_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId">مسلسل نوع الدرجة العلمية</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AsCodeDegree&gt;"/> class.</returns>
		public TList<AsCodeDegree> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal _asCodeDegreeClassId)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(transactionManager, _asCodeDegreeClassId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_CODE_DEGREE_CLASS_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId">مسلسل نوع الدرجة العلمية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AsCodeDegree&gt;"/> class.</returns>
		public TList<AsCodeDegree> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal _asCodeDegreeClassId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsCodeDegreeClassId(transactionManager, _asCodeDegreeClassId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_CODE_DEGREE_CLASS_1 index.
		/// </summary>
		/// <param name="_asCodeDegreeClassId">مسلسل نوع الدرجة العلمية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;AsCodeDegree&gt;"/> class.</returns>
		public TList<AsCodeDegree> GetByAsCodeDegreeClassId(System.Decimal _asCodeDegreeClassId, int start, int pageLength, out int count)
		{
			return GetByAsCodeDegreeClassId(null, _asCodeDegreeClassId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_CODE_DEGREE_CLASS_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeClassId">مسلسل نوع الدرجة العلمية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;AsCodeDegree&gt;"/> class.</returns>
		public abstract TList<AsCodeDegree> GetByAsCodeDegreeClassId(TransactionManager transactionManager, System.Decimal _asCodeDegreeClassId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_AS_CODE_DEGREE index.
		/// </summary>
		/// <param name="_asCodeDegreeId">مسلسل الدرجة العلمية</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AsCodeDegree"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AsCodeDegree GetByAsCodeDegreeId(System.Decimal _asCodeDegreeId)
		{
			int count = -1;
			return GetByAsCodeDegreeId(null,_asCodeDegreeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_AS_CODE_DEGREE index.
		/// </summary>
		/// <param name="_asCodeDegreeId">مسلسل الدرجة العلمية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AsCodeDegree"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AsCodeDegree GetByAsCodeDegreeId(System.Decimal _asCodeDegreeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsCodeDegreeId(null, _asCodeDegreeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_AS_CODE_DEGREE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId">مسلسل الدرجة العلمية</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AsCodeDegree"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AsCodeDegree GetByAsCodeDegreeId(TransactionManager transactionManager, System.Decimal _asCodeDegreeId)
		{
			int count = -1;
			return GetByAsCodeDegreeId(transactionManager, _asCodeDegreeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_AS_CODE_DEGREE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId">مسلسل الدرجة العلمية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AsCodeDegree"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AsCodeDegree GetByAsCodeDegreeId(TransactionManager transactionManager, System.Decimal _asCodeDegreeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsCodeDegreeId(transactionManager, _asCodeDegreeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_AS_CODE_DEGREE index.
		/// </summary>
		/// <param name="_asCodeDegreeId">مسلسل الدرجة العلمية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AsCodeDegree"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AsCodeDegree GetByAsCodeDegreeId(System.Decimal _asCodeDegreeId, int start, int pageLength, out int count)
		{
			return GetByAsCodeDegreeId(null, _asCodeDegreeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_AS_CODE_DEGREE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asCodeDegreeId">مسلسل الدرجة العلمية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AsCodeDegree"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AsCodeDegree GetByAsCodeDegreeId(TransactionManager transactionManager, System.Decimal _asCodeDegreeId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AsCodeDegree&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AsCodeDegree&gt;"/></returns>
		public static TList<AsCodeDegree> Fill(IDataReader reader, TList<AsCodeDegree> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AsCodeDegree c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AsCodeDegree")
					.Append("|").Append((System.Decimal)reader["AS_CODE_DEGREE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AsCodeDegree>(
					key.ToString(), // EntityTrackingKey
					"AsCodeDegree",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AsCodeDegree();
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
					c.AsCodeDegreeId = (System.Decimal)reader["AS_CODE_DEGREE_ID"];
					c.OriginalAsCodeDegreeId = c.AsCodeDegreeId;
					c.AsCodeDegreeClassId = (System.Decimal)reader["AS_CODE_DEGREE_CLASS_ID"];
					c.DegreeDescrAr = (System.String)reader["DEGREE_DESCR_AR"];
					c.DegreeDescrEn = Convert.IsDBNull(reader["DEGREE_DESCR_EN"]) ? null : (System.String)reader["DEGREE_DESCR_EN"];
					c.DegreeCode = Convert.IsDBNull(reader["DEGREE_CODE"]) ? null : (System.String)reader["DEGREE_CODE"];
					c.LinkDegreeId = Convert.IsDBNull(reader["LINK_DEGREE_ID"]) ? null : (System.Int32?)reader["LINK_DEGREE_ID"];
					c.Notation = Convert.IsDBNull(reader["NOTATION"]) ? null : (System.Int32?)reader["NOTATION"];
					c.AdmHint = Convert.IsDBNull(reader["ADM_HINT"]) ? null : (System.String)reader["ADM_HINT"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AsCodeDegree"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AsCodeDegree"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AsCodeDegree entity)
		{
			if (!reader.Read()) return;
			
			entity.AsCodeDegreeId = (System.Decimal)reader[((int)AsCodeDegreeColumn.AsCodeDegreeId - 1)];
			entity.OriginalAsCodeDegreeId = (System.Decimal)reader["AS_CODE_DEGREE_ID"];
			entity.AsCodeDegreeClassId = (System.Decimal)reader[((int)AsCodeDegreeColumn.AsCodeDegreeClassId - 1)];
			entity.DegreeDescrAr = (System.String)reader[((int)AsCodeDegreeColumn.DegreeDescrAr - 1)];
			entity.DegreeDescrEn = (reader.IsDBNull(((int)AsCodeDegreeColumn.DegreeDescrEn - 1)))?null:(System.String)reader[((int)AsCodeDegreeColumn.DegreeDescrEn - 1)];
			entity.DegreeCode = (reader.IsDBNull(((int)AsCodeDegreeColumn.DegreeCode - 1)))?null:(System.String)reader[((int)AsCodeDegreeColumn.DegreeCode - 1)];
			entity.LinkDegreeId = (reader.IsDBNull(((int)AsCodeDegreeColumn.LinkDegreeId - 1)))?null:(System.Int32?)reader[((int)AsCodeDegreeColumn.LinkDegreeId - 1)];
			entity.Notation = (reader.IsDBNull(((int)AsCodeDegreeColumn.Notation - 1)))?null:(System.Int32?)reader[((int)AsCodeDegreeColumn.Notation - 1)];
			entity.AdmHint = (reader.IsDBNull(((int)AsCodeDegreeColumn.AdmHint - 1)))?null:(System.String)reader[((int)AsCodeDegreeColumn.AdmHint - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AsCodeDegree"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AsCodeDegree"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AsCodeDegree entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AsCodeDegreeId = (System.Decimal)dataRow["AS_CODE_DEGREE_ID"];
			entity.OriginalAsCodeDegreeId = (System.Decimal)dataRow["AS_CODE_DEGREE_ID"];
			entity.AsCodeDegreeClassId = (System.Decimal)dataRow["AS_CODE_DEGREE_CLASS_ID"];
			entity.DegreeDescrAr = (System.String)dataRow["DEGREE_DESCR_AR"];
			entity.DegreeDescrEn = Convert.IsDBNull(dataRow["DEGREE_DESCR_EN"]) ? null : (System.String)dataRow["DEGREE_DESCR_EN"];
			entity.DegreeCode = Convert.IsDBNull(dataRow["DEGREE_CODE"]) ? null : (System.String)dataRow["DEGREE_CODE"];
			entity.LinkDegreeId = Convert.IsDBNull(dataRow["LINK_DEGREE_ID"]) ? null : (System.Int32?)dataRow["LINK_DEGREE_ID"];
			entity.Notation = Convert.IsDBNull(dataRow["NOTATION"]) ? null : (System.Int32?)dataRow["NOTATION"];
			entity.AdmHint = Convert.IsDBNull(dataRow["ADM_HINT"]) ? null : (System.String)dataRow["ADM_HINT"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AsCodeDegree"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AsCodeDegree Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AsCodeDegree entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AsCodeDegreeClassIdSource	
			if (CanDeepLoad(entity, "AsCodeDegreeClass|AsCodeDegreeClassIdSource", deepLoadType, innerList) 
				&& entity.AsCodeDegreeClassIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AsCodeDegreeClassId;
				AsCodeDegreeClass tmpEntity = EntityManager.LocateEntity<AsCodeDegreeClass>(EntityLocator.ConstructKeyFromPkItems(typeof(AsCodeDegreeClass), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AsCodeDegreeClassIdSource = tmpEntity;
				else
					entity.AsCodeDegreeClassIdSource = DataRepository.AsCodeDegreeClassProvider.GetByAsCodeDegreeClassId(transactionManager, entity.AsCodeDegreeClassId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AsCodeDegreeClassIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AsCodeDegreeClassIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AsCodeDegreeClassProvider.DeepLoad(transactionManager, entity.AsCodeDegreeClassIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AsCodeDegreeClassIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByAsCodeDegreeId methods when available
			
			#region AdmAppRegHistoryCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppRegHistory>|AdmAppRegHistoryCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppRegHistoryCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppRegHistoryCollection = DataRepository.AdmAppRegHistoryProvider.GetByAsCodeDegreeId(transactionManager, entity.AsCodeDegreeId);

				if (deep && entity.AdmAppRegHistoryCollection.Count > 0)
				{
					deepHandles.Add("AdmAppRegHistoryCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppRegHistory>) DataRepository.AdmAppRegHistoryProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppRegHistoryCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmReqDocCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmReqDoc>|AdmReqDocCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmReqDocCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmReqDocCollection = DataRepository.AdmReqDocProvider.GetByAsCodeDegreeId(transactionManager, entity.AsCodeDegreeId);

				if (deep && entity.AdmReqDocCollection.Count > 0)
				{
					deepHandles.Add("AdmReqDocCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmReqDoc>) DataRepository.AdmReqDocProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmReqDocCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudSemesterCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudSemester>|EdStudSemesterCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudSemesterCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudSemesterCollection = DataRepository.EdStudSemesterProvider.GetByAsCodeDegreeId(transactionManager, entity.AsCodeDegreeId);

				if (deep && entity.EdStudSemesterCollection.Count > 0)
				{
					deepHandles.Add("EdStudSemesterCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudSemester>) DataRepository.EdStudSemesterProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudSemesterCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeFundRuleCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeFundRule>|FeeFundRuleCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeFundRuleCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeFundRuleCollection = DataRepository.FeeFundRuleProvider.GetByAsCodeDegreeId(transactionManager, entity.AsCodeDegreeId);

				if (deep && entity.FeeFundRuleCollection.Count > 0)
				{
					deepHandles.Add("FeeFundRuleCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeFundRule>) DataRepository.FeeFundRuleProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeFundRuleCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaScQualCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaScQual>|SaScQualCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaScQualCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaScQualCollection = DataRepository.SaScQualProvider.GetByAsCodeDegreeId(transactionManager, entity.AsCodeDegreeId);

				if (deep && entity.SaScQualCollection.Count > 0)
				{
					deepHandles.Add("SaScQualCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaScQual>) DataRepository.SaScQualProvider.DeepLoad,
						new object[] { transactionManager, entity.SaScQualCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region PgThesisGrantDegreeCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgThesisGrantDegree>|PgThesisGrantDegreeCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisGrantDegreeCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgThesisGrantDegreeCollection = DataRepository.PgThesisGrantDegreeProvider.GetByAsCodeDegreeId(transactionManager, entity.AsCodeDegreeId);

				if (deep && entity.PgThesisGrantDegreeCollection.Count > 0)
				{
					deepHandles.Add("PgThesisGrantDegreeCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgThesisGrantDegree>) DataRepository.PgThesisGrantDegreeProvider.DeepLoad,
						new object[] { transactionManager, entity.PgThesisGrantDegreeCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SeUserAccntDegCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SeUserAccntDeg>|SeUserAccntDegCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeUserAccntDegCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SeUserAccntDegCollection = DataRepository.SeUserAccntDegProvider.GetByAsCodeDegreeId(transactionManager, entity.AsCodeDegreeId);

				if (deep && entity.SeUserAccntDegCollection.Count > 0)
				{
					deepHandles.Add("SeUserAccntDegCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SeUserAccntDeg>) DataRepository.SeUserAccntDegProvider.DeepLoad,
						new object[] { transactionManager, entity.SeUserAccntDegCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeInstlmntRuleCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeInstlmntRule>|FeeInstlmntRuleCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeInstlmntRuleCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeInstlmntRuleCollection = DataRepository.FeeInstlmntRuleProvider.GetByAsCodeDegreeId(transactionManager, entity.AsCodeDegreeId);

				if (deep && entity.FeeInstlmntRuleCollection.Count > 0)
				{
					deepHandles.Add("FeeInstlmntRuleCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeInstlmntRule>) DataRepository.FeeInstlmntRuleProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeInstlmntRuleCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudFacultyCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudFaculty>|EdStudFacultyCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudFacultyCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudFacultyCollection = DataRepository.EdStudFacultyProvider.GetByAsCodeDegreeId(transactionManager, entity.AsCodeDegreeId);

				if (deep && entity.EdStudFacultyCollection.Count > 0)
				{
					deepHandles.Add("EdStudFacultyCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudFaculty>) DataRepository.EdStudFacultyProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudFacultyCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntityMainCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntityMain>|EntityMainCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntityMainCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntityMainCollection = DataRepository.EntityMainProvider.GetByAsCodeDegreeId(transactionManager, entity.AsCodeDegreeId);

				if (deep && entity.EntityMainCollection.Count > 0)
				{
					deepHandles.Add("EntityMainCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntityMain>) DataRepository.EntityMainProvider.DeepLoad,
						new object[] { transactionManager, entity.EntityMainCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntPlcyAcadWarnDtlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntPlcyAcadWarnDtl>|EntPlcyAcadWarnDtlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPlcyAcadWarnDtlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntPlcyAcadWarnDtlCollection = DataRepository.EntPlcyAcadWarnDtlProvider.GetByAsCodeDegreeId(transactionManager, entity.AsCodeDegreeId);

				if (deep && entity.EntPlcyAcadWarnDtlCollection.Count > 0)
				{
					deepHandles.Add("EntPlcyAcadWarnDtlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntPlcyAcadWarnDtl>) DataRepository.EntPlcyAcadWarnDtlProvider.DeepLoad,
						new object[] { transactionManager, entity.EntPlcyAcadWarnDtlCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeAllowanceRuleCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeAllowanceRule>|FeeAllowanceRuleCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeAllowanceRuleCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeAllowanceRuleCollection = DataRepository.FeeAllowanceRuleProvider.GetByAsCodeDegreeId(transactionManager, entity.AsCodeDegreeId);

				if (deep && entity.FeeAllowanceRuleCollection.Count > 0)
				{
					deepHandles.Add("FeeAllowanceRuleCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeAllowanceRule>) DataRepository.FeeAllowanceRuleProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeAllowanceRuleCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdBylawCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdBylaw>|EdBylawCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdBylawCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdBylawCollection = DataRepository.EdBylawProvider.GetByAsCodeDegreeId(transactionManager, entity.AsCodeDegreeId);

				if (deep && entity.EdBylawCollection.Count > 0)
				{
					deepHandles.Add("EdBylawCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdBylaw>) DataRepository.EdBylawProvider.DeepLoad,
						new object[] { transactionManager, entity.EdBylawCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeFacultyInstallmentCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeFacultyInstallment>|FeeFacultyInstallmentCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeFacultyInstallmentCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeFacultyInstallmentCollection = DataRepository.FeeFacultyInstallmentProvider.GetByAsCodeDegreeId(transactionManager, entity.AsCodeDegreeId);

				if (deep && entity.FeeFacultyInstallmentCollection.Count > 0)
				{
					deepHandles.Add("FeeFacultyInstallmentCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeFacultyInstallment>) DataRepository.FeeFacultyInstallmentProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeFacultyInstallmentCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmPrecondQualCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmPrecondQual>|AdmPrecondQualCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmPrecondQualCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmPrecondQualCollection = DataRepository.AdmPrecondQualProvider.GetByAsCodeDegreeId(transactionManager, entity.AsCodeDegreeId);

				if (deep && entity.AdmPrecondQualCollection.Count > 0)
				{
					deepHandles.Add("AdmPrecondQualCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmPrecondQual>) DataRepository.AdmPrecondQualProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmPrecondQualCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdCdeQualCatCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdCdeQualCat>|EdCdeQualCatCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCdeQualCatCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdCdeQualCatCollection = DataRepository.EdCdeQualCatProvider.GetByAsCodeDegreeId(transactionManager, entity.AsCodeDegreeId);

				if (deep && entity.EdCdeQualCatCollection.Count > 0)
				{
					deepHandles.Add("EdCdeQualCatCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdCdeQualCat>) DataRepository.EdCdeQualCatProvider.DeepLoad,
						new object[] { transactionManager, entity.EdCdeQualCatCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmRatingParametersMajorsCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmRatingParametersMajors>|AdmRatingParametersMajorsCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmRatingParametersMajorsCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmRatingParametersMajorsCollection = DataRepository.AdmRatingParametersMajorsProvider.GetByAsCodeDegreeId(transactionManager, entity.AsCodeDegreeId);

				if (deep && entity.AdmRatingParametersMajorsCollection.Count > 0)
				{
					deepHandles.Add("AdmRatingParametersMajorsCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmRatingParametersMajors>) DataRepository.AdmRatingParametersMajorsProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmRatingParametersMajorsCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region ScScheduleRsrvCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ScScheduleRsrv>|ScScheduleRsrvCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScScheduleRsrvCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ScScheduleRsrvCollection = DataRepository.ScScheduleRsrvProvider.GetByAsCodeDegreeId(transactionManager, entity.AsCodeDegreeId);

				if (deep && entity.ScScheduleRsrvCollection.Count > 0)
				{
					deepHandles.Add("ScScheduleRsrvCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScScheduleRsrv>) DataRepository.ScScheduleRsrvProvider.DeepLoad,
						new object[] { transactionManager, entity.ScScheduleRsrvCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmAcceptanceCategoryCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAcceptanceCategory>|AdmAcceptanceCategoryCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAcceptanceCategoryCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAcceptanceCategoryCollection = DataRepository.AdmAcceptanceCategoryProvider.GetByAsCodeDegreeId(transactionManager, entity.AsCodeDegreeId);

				if (deep && entity.AdmAcceptanceCategoryCollection.Count > 0)
				{
					deepHandles.Add("AdmAcceptanceCategoryCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAcceptanceCategory>) DataRepository.AdmAcceptanceCategoryProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAcceptanceCategoryCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmTransAcceptanceCategoryCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmTransAcceptanceCategory>|AdmTransAcceptanceCategoryCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmTransAcceptanceCategoryCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmTransAcceptanceCategoryCollection = DataRepository.AdmTransAcceptanceCategoryProvider.GetByAsCodeDegreeId(transactionManager, entity.AsCodeDegreeId);

				if (deep && entity.AdmTransAcceptanceCategoryCollection.Count > 0)
				{
					deepHandles.Add("AdmTransAcceptanceCategoryCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmTransAcceptanceCategory>) DataRepository.AdmTransAcceptanceCategoryProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmTransAcceptanceCategoryCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdResultApproveCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdResultApprove>|EdResultApproveCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdResultApproveCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdResultApproveCollection = DataRepository.EdResultApproveProvider.GetByAsCodeDegreeId(transactionManager, entity.AsCodeDegreeId);

				if (deep && entity.EdResultApproveCollection.Count > 0)
				{
					deepHandles.Add("EdResultApproveCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdResultApprove>) DataRepository.EdResultApproveProvider.DeepLoad,
						new object[] { transactionManager, entity.EdResultApproveCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmCdePlacementExamCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmCdePlacementExam>|AdmCdePlacementExamCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmCdePlacementExamCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmCdePlacementExamCollection = DataRepository.AdmCdePlacementExamProvider.GetByAsCodeDegreeId(transactionManager, entity.AsCodeDegreeId);

				if (deep && entity.AdmCdePlacementExamCollection.Count > 0)
				{
					deepHandles.Add("AdmCdePlacementExamCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmCdePlacementExam>) DataRepository.AdmCdePlacementExamProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmCdePlacementExamCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeLimitRuleCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeLimitRule>|FeeLimitRuleCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeLimitRuleCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeLimitRuleCollection = DataRepository.FeeLimitRuleProvider.GetByAsCodeDegreeId(transactionManager, entity.AsCodeDegreeId);

				if (deep && entity.FeeLimitRuleCollection.Count > 0)
				{
					deepHandles.Add("FeeLimitRuleCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeLimitRule>) DataRepository.FeeLimitRuleProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeLimitRuleCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdSemesterAgendaCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdSemesterAgenda>|EdSemesterAgendaCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdSemesterAgendaCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdSemesterAgendaCollection = DataRepository.EdSemesterAgendaProvider.GetByAsCodeDegreeId(transactionManager, entity.AsCodeDegreeId);

				if (deep && entity.EdSemesterAgendaCollection.Count > 0)
				{
					deepHandles.Add("EdSemesterAgendaCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdSemesterAgenda>) DataRepository.EdSemesterAgendaProvider.DeepLoad,
						new object[] { transactionManager, entity.EdSemesterAgendaCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeCodeItemCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeCodeItem>|FeeCodeItemCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeCodeItemCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeCodeItemCollection = DataRepository.FeeCodeItemProvider.GetByAsCodeDegreeId(transactionManager, entity.AsCodeDegreeId);

				if (deep && entity.FeeCodeItemCollection.Count > 0)
				{
					deepHandles.Add("FeeCodeItemCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeCodeItem>) DataRepository.FeeCodeItemProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeCodeItemCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmCompetitiveAvgCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmCompetitiveAvg>|AdmCompetitiveAvgCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmCompetitiveAvgCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmCompetitiveAvgCollection = DataRepository.AdmCompetitiveAvgProvider.GetByAsCodeDegreeId(transactionManager, entity.AsCodeDegreeId);

				if (deep && entity.AdmCompetitiveAvgCollection.Count > 0)
				{
					deepHandles.Add("AdmCompetitiveAvgCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmCompetitiveAvg>) DataRepository.AdmCompetitiveAvgProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmCompetitiveAvgCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmTansikCodesCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmTansikCodes>|AdmTansikCodesCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmTansikCodesCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmTansikCodesCollection = DataRepository.AdmTansikCodesProvider.GetByAsCodeDegreeId(transactionManager, entity.AsCodeDegreeId);

				if (deep && entity.AdmTansikCodesCollection.Count > 0)
				{
					deepHandles.Add("AdmTansikCodesCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmTansikCodes>) DataRepository.AdmTansikCodesProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmTansikCodesCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeFacultyRuleCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeFacultyRule>|FeeFacultyRuleCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeFacultyRuleCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeFacultyRuleCollection = DataRepository.FeeFacultyRuleProvider.GetByAsCodeDegreeId(transactionManager, entity.AsCodeDegreeId);

				if (deep && entity.FeeFacultyRuleCollection.Count > 0)
				{
					deepHandles.Add("FeeFacultyRuleCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeFacultyRule>) DataRepository.FeeFacultyRuleProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeFacultyRuleCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmCodeEngTestCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmCodeEngTest>|AdmCodeEngTestCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmCodeEngTestCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmCodeEngTestCollection = DataRepository.AdmCodeEngTestProvider.GetByAsCodeDegreeId(transactionManager, entity.AsCodeDegreeId);

				if (deep && entity.AdmCodeEngTestCollection.Count > 0)
				{
					deepHandles.Add("AdmCodeEngTestCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmCodeEngTest>) DataRepository.AdmCodeEngTestProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmCodeEngTestCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdGraduationAwardCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdGraduationAward>|EdGraduationAwardCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdGraduationAwardCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdGraduationAwardCollection = DataRepository.EdGraduationAwardProvider.GetByAsCodeDegreeId(transactionManager, entity.AsCodeDegreeId);

				if (deep && entity.EdGraduationAwardCollection.Count > 0)
				{
					deepHandles.Add("EdGraduationAwardCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdGraduationAward>) DataRepository.EdGraduationAwardProvider.DeepLoad,
						new object[] { transactionManager, entity.EdGraduationAwardCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmCdeFeeCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmCdeFee>|AdmCdeFeeCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmCdeFeeCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmCdeFeeCollection = DataRepository.AdmCdeFeeProvider.GetByAsCodeDegreeId(transactionManager, entity.AsCodeDegreeId);

				if (deep && entity.AdmCdeFeeCollection.Count > 0)
				{
					deepHandles.Add("AdmCdeFeeCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmCdeFee>) DataRepository.AdmCdeFeeProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmCdeFeeCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AsCodeDegree object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AsCodeDegree instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AsCodeDegree Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AsCodeDegree entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AsCodeDegreeClassIdSource
			if (CanDeepSave(entity, "AsCodeDegreeClass|AsCodeDegreeClassIdSource", deepSaveType, innerList) 
				&& entity.AsCodeDegreeClassIdSource != null)
			{
				DataRepository.AsCodeDegreeClassProvider.Save(transactionManager, entity.AsCodeDegreeClassIdSource);
				entity.AsCodeDegreeClassId = entity.AsCodeDegreeClassIdSource.AsCodeDegreeClassId;
			}
			#endregion 
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
						if(child.AsCodeDegreeIdSource != null)
						{
							child.AsCodeDegreeId = child.AsCodeDegreeIdSource.AsCodeDegreeId;
						}
						else
						{
							child.AsCodeDegreeId = entity.AsCodeDegreeId;
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
				
	
			#region List<AdmReqDoc>
				if (CanDeepSave(entity.AdmReqDocCollection, "List<AdmReqDoc>|AdmReqDocCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmReqDoc child in entity.AdmReqDocCollection)
					{
						if(child.AsCodeDegreeIdSource != null)
						{
							child.AsCodeDegreeId = child.AsCodeDegreeIdSource.AsCodeDegreeId;
						}
						else
						{
							child.AsCodeDegreeId = entity.AsCodeDegreeId;
						}

					}

					if (entity.AdmReqDocCollection.Count > 0 || entity.AdmReqDocCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmReqDocProvider.Save(transactionManager, entity.AdmReqDocCollection);
						
						deepHandles.Add("AdmReqDocCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmReqDoc >) DataRepository.AdmReqDocProvider.DeepSave,
							new object[] { transactionManager, entity.AdmReqDocCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudSemester>
				if (CanDeepSave(entity.EdStudSemesterCollection, "List<EdStudSemester>|EdStudSemesterCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudSemester child in entity.EdStudSemesterCollection)
					{
						if(child.AsCodeDegreeIdSource != null)
						{
							child.AsCodeDegreeId = child.AsCodeDegreeIdSource.AsCodeDegreeId;
						}
						else
						{
							child.AsCodeDegreeId = entity.AsCodeDegreeId;
						}

					}

					if (entity.EdStudSemesterCollection.Count > 0 || entity.EdStudSemesterCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudSemesterProvider.Save(transactionManager, entity.EdStudSemesterCollection);
						
						deepHandles.Add("EdStudSemesterCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudSemester >) DataRepository.EdStudSemesterProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudSemesterCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeFundRule>
				if (CanDeepSave(entity.FeeFundRuleCollection, "List<FeeFundRule>|FeeFundRuleCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeFundRule child in entity.FeeFundRuleCollection)
					{
						if(child.AsCodeDegreeIdSource != null)
						{
							child.AsCodeDegreeId = child.AsCodeDegreeIdSource.AsCodeDegreeId;
						}
						else
						{
							child.AsCodeDegreeId = entity.AsCodeDegreeId;
						}

					}

					if (entity.FeeFundRuleCollection.Count > 0 || entity.FeeFundRuleCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeFundRuleProvider.Save(transactionManager, entity.FeeFundRuleCollection);
						
						deepHandles.Add("FeeFundRuleCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeFundRule >) DataRepository.FeeFundRuleProvider.DeepSave,
							new object[] { transactionManager, entity.FeeFundRuleCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaScQual>
				if (CanDeepSave(entity.SaScQualCollection, "List<SaScQual>|SaScQualCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaScQual child in entity.SaScQualCollection)
					{
						if(child.AsCodeDegreeIdSource != null)
						{
							child.AsCodeDegreeId = child.AsCodeDegreeIdSource.AsCodeDegreeId;
						}
						else
						{
							child.AsCodeDegreeId = entity.AsCodeDegreeId;
						}

					}

					if (entity.SaScQualCollection.Count > 0 || entity.SaScQualCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaScQualProvider.Save(transactionManager, entity.SaScQualCollection);
						
						deepHandles.Add("SaScQualCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaScQual >) DataRepository.SaScQualProvider.DeepSave,
							new object[] { transactionManager, entity.SaScQualCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<PgThesisGrantDegree>
				if (CanDeepSave(entity.PgThesisGrantDegreeCollection, "List<PgThesisGrantDegree>|PgThesisGrantDegreeCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgThesisGrantDegree child in entity.PgThesisGrantDegreeCollection)
					{
						if(child.AsCodeDegreeIdSource != null)
						{
							child.AsCodeDegreeId = child.AsCodeDegreeIdSource.AsCodeDegreeId;
						}
						else
						{
							child.AsCodeDegreeId = entity.AsCodeDegreeId;
						}

					}

					if (entity.PgThesisGrantDegreeCollection.Count > 0 || entity.PgThesisGrantDegreeCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgThesisGrantDegreeProvider.Save(transactionManager, entity.PgThesisGrantDegreeCollection);
						
						deepHandles.Add("PgThesisGrantDegreeCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgThesisGrantDegree >) DataRepository.PgThesisGrantDegreeProvider.DeepSave,
							new object[] { transactionManager, entity.PgThesisGrantDegreeCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SeUserAccntDeg>
				if (CanDeepSave(entity.SeUserAccntDegCollection, "List<SeUserAccntDeg>|SeUserAccntDegCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SeUserAccntDeg child in entity.SeUserAccntDegCollection)
					{
						if(child.AsCodeDegreeIdSource != null)
						{
							child.AsCodeDegreeId = child.AsCodeDegreeIdSource.AsCodeDegreeId;
						}
						else
						{
							child.AsCodeDegreeId = entity.AsCodeDegreeId;
						}

					}

					if (entity.SeUserAccntDegCollection.Count > 0 || entity.SeUserAccntDegCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SeUserAccntDegProvider.Save(transactionManager, entity.SeUserAccntDegCollection);
						
						deepHandles.Add("SeUserAccntDegCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SeUserAccntDeg >) DataRepository.SeUserAccntDegProvider.DeepSave,
							new object[] { transactionManager, entity.SeUserAccntDegCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeInstlmntRule>
				if (CanDeepSave(entity.FeeInstlmntRuleCollection, "List<FeeInstlmntRule>|FeeInstlmntRuleCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeInstlmntRule child in entity.FeeInstlmntRuleCollection)
					{
						if(child.AsCodeDegreeIdSource != null)
						{
							child.AsCodeDegreeId = child.AsCodeDegreeIdSource.AsCodeDegreeId;
						}
						else
						{
							child.AsCodeDegreeId = entity.AsCodeDegreeId;
						}

					}

					if (entity.FeeInstlmntRuleCollection.Count > 0 || entity.FeeInstlmntRuleCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeInstlmntRuleProvider.Save(transactionManager, entity.FeeInstlmntRuleCollection);
						
						deepHandles.Add("FeeInstlmntRuleCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeInstlmntRule >) DataRepository.FeeInstlmntRuleProvider.DeepSave,
							new object[] { transactionManager, entity.FeeInstlmntRuleCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudFaculty>
				if (CanDeepSave(entity.EdStudFacultyCollection, "List<EdStudFaculty>|EdStudFacultyCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudFaculty child in entity.EdStudFacultyCollection)
					{
						if(child.AsCodeDegreeIdSource != null)
						{
							child.AsCodeDegreeId = child.AsCodeDegreeIdSource.AsCodeDegreeId;
						}
						else
						{
							child.AsCodeDegreeId = entity.AsCodeDegreeId;
						}

					}

					if (entity.EdStudFacultyCollection.Count > 0 || entity.EdStudFacultyCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudFacultyProvider.Save(transactionManager, entity.EdStudFacultyCollection);
						
						deepHandles.Add("EdStudFacultyCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudFaculty >) DataRepository.EdStudFacultyProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudFacultyCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntityMain>
				if (CanDeepSave(entity.EntityMainCollection, "List<EntityMain>|EntityMainCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntityMain child in entity.EntityMainCollection)
					{
						if(child.AsCodeDegreeIdSource != null)
						{
							child.AsCodeDegreeId = child.AsCodeDegreeIdSource.AsCodeDegreeId;
						}
						else
						{
							child.AsCodeDegreeId = entity.AsCodeDegreeId;
						}

					}

					if (entity.EntityMainCollection.Count > 0 || entity.EntityMainCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntityMainProvider.Save(transactionManager, entity.EntityMainCollection);
						
						deepHandles.Add("EntityMainCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntityMain >) DataRepository.EntityMainProvider.DeepSave,
							new object[] { transactionManager, entity.EntityMainCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntPlcyAcadWarnDtl>
				if (CanDeepSave(entity.EntPlcyAcadWarnDtlCollection, "List<EntPlcyAcadWarnDtl>|EntPlcyAcadWarnDtlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntPlcyAcadWarnDtl child in entity.EntPlcyAcadWarnDtlCollection)
					{
						if(child.AsCodeDegreeIdSource != null)
						{
							child.AsCodeDegreeId = child.AsCodeDegreeIdSource.AsCodeDegreeId;
						}
						else
						{
							child.AsCodeDegreeId = entity.AsCodeDegreeId;
						}

					}

					if (entity.EntPlcyAcadWarnDtlCollection.Count > 0 || entity.EntPlcyAcadWarnDtlCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntPlcyAcadWarnDtlProvider.Save(transactionManager, entity.EntPlcyAcadWarnDtlCollection);
						
						deepHandles.Add("EntPlcyAcadWarnDtlCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntPlcyAcadWarnDtl >) DataRepository.EntPlcyAcadWarnDtlProvider.DeepSave,
							new object[] { transactionManager, entity.EntPlcyAcadWarnDtlCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeAllowanceRule>
				if (CanDeepSave(entity.FeeAllowanceRuleCollection, "List<FeeAllowanceRule>|FeeAllowanceRuleCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeAllowanceRule child in entity.FeeAllowanceRuleCollection)
					{
						if(child.AsCodeDegreeIdSource != null)
						{
							child.AsCodeDegreeId = child.AsCodeDegreeIdSource.AsCodeDegreeId;
						}
						else
						{
							child.AsCodeDegreeId = entity.AsCodeDegreeId;
						}

					}

					if (entity.FeeAllowanceRuleCollection.Count > 0 || entity.FeeAllowanceRuleCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeAllowanceRuleProvider.Save(transactionManager, entity.FeeAllowanceRuleCollection);
						
						deepHandles.Add("FeeAllowanceRuleCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeAllowanceRule >) DataRepository.FeeAllowanceRuleProvider.DeepSave,
							new object[] { transactionManager, entity.FeeAllowanceRuleCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdBylaw>
				if (CanDeepSave(entity.EdBylawCollection, "List<EdBylaw>|EdBylawCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdBylaw child in entity.EdBylawCollection)
					{
						if(child.AsCodeDegreeIdSource != null)
						{
							child.AsCodeDegreeId = child.AsCodeDegreeIdSource.AsCodeDegreeId;
						}
						else
						{
							child.AsCodeDegreeId = entity.AsCodeDegreeId;
						}

					}

					if (entity.EdBylawCollection.Count > 0 || entity.EdBylawCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdBylawProvider.Save(transactionManager, entity.EdBylawCollection);
						
						deepHandles.Add("EdBylawCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdBylaw >) DataRepository.EdBylawProvider.DeepSave,
							new object[] { transactionManager, entity.EdBylawCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeFacultyInstallment>
				if (CanDeepSave(entity.FeeFacultyInstallmentCollection, "List<FeeFacultyInstallment>|FeeFacultyInstallmentCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeFacultyInstallment child in entity.FeeFacultyInstallmentCollection)
					{
						if(child.AsCodeDegreeIdSource != null)
						{
							child.AsCodeDegreeId = child.AsCodeDegreeIdSource.AsCodeDegreeId;
						}
						else
						{
							child.AsCodeDegreeId = entity.AsCodeDegreeId;
						}

					}

					if (entity.FeeFacultyInstallmentCollection.Count > 0 || entity.FeeFacultyInstallmentCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeFacultyInstallmentProvider.Save(transactionManager, entity.FeeFacultyInstallmentCollection);
						
						deepHandles.Add("FeeFacultyInstallmentCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeFacultyInstallment >) DataRepository.FeeFacultyInstallmentProvider.DeepSave,
							new object[] { transactionManager, entity.FeeFacultyInstallmentCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmPrecondQual>
				if (CanDeepSave(entity.AdmPrecondQualCollection, "List<AdmPrecondQual>|AdmPrecondQualCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmPrecondQual child in entity.AdmPrecondQualCollection)
					{
						if(child.AsCodeDegreeIdSource != null)
						{
							child.AsCodeDegreeId = child.AsCodeDegreeIdSource.AsCodeDegreeId;
						}
						else
						{
							child.AsCodeDegreeId = entity.AsCodeDegreeId;
						}

					}

					if (entity.AdmPrecondQualCollection.Count > 0 || entity.AdmPrecondQualCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmPrecondQualProvider.Save(transactionManager, entity.AdmPrecondQualCollection);
						
						deepHandles.Add("AdmPrecondQualCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmPrecondQual >) DataRepository.AdmPrecondQualProvider.DeepSave,
							new object[] { transactionManager, entity.AdmPrecondQualCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdCdeQualCat>
				if (CanDeepSave(entity.EdCdeQualCatCollection, "List<EdCdeQualCat>|EdCdeQualCatCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdCdeQualCat child in entity.EdCdeQualCatCollection)
					{
						if(child.AsCodeDegreeIdSource != null)
						{
							child.AsCodeDegreeId = child.AsCodeDegreeIdSource.AsCodeDegreeId;
						}
						else
						{
							child.AsCodeDegreeId = entity.AsCodeDegreeId;
						}

					}

					if (entity.EdCdeQualCatCollection.Count > 0 || entity.EdCdeQualCatCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdCdeQualCatProvider.Save(transactionManager, entity.EdCdeQualCatCollection);
						
						deepHandles.Add("EdCdeQualCatCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdCdeQualCat >) DataRepository.EdCdeQualCatProvider.DeepSave,
							new object[] { transactionManager, entity.EdCdeQualCatCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmRatingParametersMajors>
				if (CanDeepSave(entity.AdmRatingParametersMajorsCollection, "List<AdmRatingParametersMajors>|AdmRatingParametersMajorsCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmRatingParametersMajors child in entity.AdmRatingParametersMajorsCollection)
					{
						if(child.AsCodeDegreeIdSource != null)
						{
							child.AsCodeDegreeId = child.AsCodeDegreeIdSource.AsCodeDegreeId;
						}
						else
						{
							child.AsCodeDegreeId = entity.AsCodeDegreeId;
						}

					}

					if (entity.AdmRatingParametersMajorsCollection.Count > 0 || entity.AdmRatingParametersMajorsCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmRatingParametersMajorsProvider.Save(transactionManager, entity.AdmRatingParametersMajorsCollection);
						
						deepHandles.Add("AdmRatingParametersMajorsCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmRatingParametersMajors >) DataRepository.AdmRatingParametersMajorsProvider.DeepSave,
							new object[] { transactionManager, entity.AdmRatingParametersMajorsCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<ScScheduleRsrv>
				if (CanDeepSave(entity.ScScheduleRsrvCollection, "List<ScScheduleRsrv>|ScScheduleRsrvCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScScheduleRsrv child in entity.ScScheduleRsrvCollection)
					{
						if(child.AsCodeDegreeIdSource != null)
						{
							child.AsCodeDegreeId = child.AsCodeDegreeIdSource.AsCodeDegreeId;
						}
						else
						{
							child.AsCodeDegreeId = entity.AsCodeDegreeId;
						}

					}

					if (entity.ScScheduleRsrvCollection.Count > 0 || entity.ScScheduleRsrvCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ScScheduleRsrvProvider.Save(transactionManager, entity.ScScheduleRsrvCollection);
						
						deepHandles.Add("ScScheduleRsrvCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ScScheduleRsrv >) DataRepository.ScScheduleRsrvProvider.DeepSave,
							new object[] { transactionManager, entity.ScScheduleRsrvCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmAcceptanceCategory>
				if (CanDeepSave(entity.AdmAcceptanceCategoryCollection, "List<AdmAcceptanceCategory>|AdmAcceptanceCategoryCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAcceptanceCategory child in entity.AdmAcceptanceCategoryCollection)
					{
						if(child.AsCodeDegreeIdSource != null)
						{
							child.AsCodeDegreeId = child.AsCodeDegreeIdSource.AsCodeDegreeId;
						}
						else
						{
							child.AsCodeDegreeId = entity.AsCodeDegreeId;
						}

					}

					if (entity.AdmAcceptanceCategoryCollection.Count > 0 || entity.AdmAcceptanceCategoryCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmAcceptanceCategoryProvider.Save(transactionManager, entity.AdmAcceptanceCategoryCollection);
						
						deepHandles.Add("AdmAcceptanceCategoryCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmAcceptanceCategory >) DataRepository.AdmAcceptanceCategoryProvider.DeepSave,
							new object[] { transactionManager, entity.AdmAcceptanceCategoryCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmTransAcceptanceCategory>
				if (CanDeepSave(entity.AdmTransAcceptanceCategoryCollection, "List<AdmTransAcceptanceCategory>|AdmTransAcceptanceCategoryCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmTransAcceptanceCategory child in entity.AdmTransAcceptanceCategoryCollection)
					{
						if(child.AsCodeDegreeIdSource != null)
						{
							child.AsCodeDegreeId = child.AsCodeDegreeIdSource.AsCodeDegreeId;
						}
						else
						{
							child.AsCodeDegreeId = entity.AsCodeDegreeId;
						}

					}

					if (entity.AdmTransAcceptanceCategoryCollection.Count > 0 || entity.AdmTransAcceptanceCategoryCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmTransAcceptanceCategoryProvider.Save(transactionManager, entity.AdmTransAcceptanceCategoryCollection);
						
						deepHandles.Add("AdmTransAcceptanceCategoryCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmTransAcceptanceCategory >) DataRepository.AdmTransAcceptanceCategoryProvider.DeepSave,
							new object[] { transactionManager, entity.AdmTransAcceptanceCategoryCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdResultApprove>
				if (CanDeepSave(entity.EdResultApproveCollection, "List<EdResultApprove>|EdResultApproveCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdResultApprove child in entity.EdResultApproveCollection)
					{
						if(child.AsCodeDegreeIdSource != null)
						{
							child.AsCodeDegreeId = child.AsCodeDegreeIdSource.AsCodeDegreeId;
						}
						else
						{
							child.AsCodeDegreeId = entity.AsCodeDegreeId;
						}

					}

					if (entity.EdResultApproveCollection.Count > 0 || entity.EdResultApproveCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdResultApproveProvider.Save(transactionManager, entity.EdResultApproveCollection);
						
						deepHandles.Add("EdResultApproveCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdResultApprove >) DataRepository.EdResultApproveProvider.DeepSave,
							new object[] { transactionManager, entity.EdResultApproveCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmCdePlacementExam>
				if (CanDeepSave(entity.AdmCdePlacementExamCollection, "List<AdmCdePlacementExam>|AdmCdePlacementExamCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmCdePlacementExam child in entity.AdmCdePlacementExamCollection)
					{
						if(child.AsCodeDegreeIdSource != null)
						{
							child.AsCodeDegreeId = child.AsCodeDegreeIdSource.AsCodeDegreeId;
						}
						else
						{
							child.AsCodeDegreeId = entity.AsCodeDegreeId;
						}

					}

					if (entity.AdmCdePlacementExamCollection.Count > 0 || entity.AdmCdePlacementExamCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmCdePlacementExamProvider.Save(transactionManager, entity.AdmCdePlacementExamCollection);
						
						deepHandles.Add("AdmCdePlacementExamCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmCdePlacementExam >) DataRepository.AdmCdePlacementExamProvider.DeepSave,
							new object[] { transactionManager, entity.AdmCdePlacementExamCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeLimitRule>
				if (CanDeepSave(entity.FeeLimitRuleCollection, "List<FeeLimitRule>|FeeLimitRuleCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeLimitRule child in entity.FeeLimitRuleCollection)
					{
						if(child.AsCodeDegreeIdSource != null)
						{
							child.AsCodeDegreeId = child.AsCodeDegreeIdSource.AsCodeDegreeId;
						}
						else
						{
							child.AsCodeDegreeId = entity.AsCodeDegreeId;
						}

					}

					if (entity.FeeLimitRuleCollection.Count > 0 || entity.FeeLimitRuleCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeLimitRuleProvider.Save(transactionManager, entity.FeeLimitRuleCollection);
						
						deepHandles.Add("FeeLimitRuleCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeLimitRule >) DataRepository.FeeLimitRuleProvider.DeepSave,
							new object[] { transactionManager, entity.FeeLimitRuleCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdSemesterAgenda>
				if (CanDeepSave(entity.EdSemesterAgendaCollection, "List<EdSemesterAgenda>|EdSemesterAgendaCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdSemesterAgenda child in entity.EdSemesterAgendaCollection)
					{
						if(child.AsCodeDegreeIdSource != null)
						{
							child.AsCodeDegreeId = child.AsCodeDegreeIdSource.AsCodeDegreeId;
						}
						else
						{
							child.AsCodeDegreeId = entity.AsCodeDegreeId;
						}

					}

					if (entity.EdSemesterAgendaCollection.Count > 0 || entity.EdSemesterAgendaCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdSemesterAgendaProvider.Save(transactionManager, entity.EdSemesterAgendaCollection);
						
						deepHandles.Add("EdSemesterAgendaCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdSemesterAgenda >) DataRepository.EdSemesterAgendaProvider.DeepSave,
							new object[] { transactionManager, entity.EdSemesterAgendaCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeCodeItem>
				if (CanDeepSave(entity.FeeCodeItemCollection, "List<FeeCodeItem>|FeeCodeItemCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeCodeItem child in entity.FeeCodeItemCollection)
					{
						if(child.AsCodeDegreeIdSource != null)
						{
							child.AsCodeDegreeId = child.AsCodeDegreeIdSource.AsCodeDegreeId;
						}
						else
						{
							child.AsCodeDegreeId = entity.AsCodeDegreeId;
						}

					}

					if (entity.FeeCodeItemCollection.Count > 0 || entity.FeeCodeItemCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeCodeItemProvider.Save(transactionManager, entity.FeeCodeItemCollection);
						
						deepHandles.Add("FeeCodeItemCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeCodeItem >) DataRepository.FeeCodeItemProvider.DeepSave,
							new object[] { transactionManager, entity.FeeCodeItemCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmCompetitiveAvg>
				if (CanDeepSave(entity.AdmCompetitiveAvgCollection, "List<AdmCompetitiveAvg>|AdmCompetitiveAvgCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmCompetitiveAvg child in entity.AdmCompetitiveAvgCollection)
					{
						if(child.AsCodeDegreeIdSource != null)
						{
							child.AsCodeDegreeId = child.AsCodeDegreeIdSource.AsCodeDegreeId;
						}
						else
						{
							child.AsCodeDegreeId = entity.AsCodeDegreeId;
						}

					}

					if (entity.AdmCompetitiveAvgCollection.Count > 0 || entity.AdmCompetitiveAvgCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmCompetitiveAvgProvider.Save(transactionManager, entity.AdmCompetitiveAvgCollection);
						
						deepHandles.Add("AdmCompetitiveAvgCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmCompetitiveAvg >) DataRepository.AdmCompetitiveAvgProvider.DeepSave,
							new object[] { transactionManager, entity.AdmCompetitiveAvgCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmTansikCodes>
				if (CanDeepSave(entity.AdmTansikCodesCollection, "List<AdmTansikCodes>|AdmTansikCodesCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmTansikCodes child in entity.AdmTansikCodesCollection)
					{
						if(child.AsCodeDegreeIdSource != null)
						{
							child.AsCodeDegreeId = child.AsCodeDegreeIdSource.AsCodeDegreeId;
						}
						else
						{
							child.AsCodeDegreeId = entity.AsCodeDegreeId;
						}

					}

					if (entity.AdmTansikCodesCollection.Count > 0 || entity.AdmTansikCodesCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmTansikCodesProvider.Save(transactionManager, entity.AdmTansikCodesCollection);
						
						deepHandles.Add("AdmTansikCodesCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmTansikCodes >) DataRepository.AdmTansikCodesProvider.DeepSave,
							new object[] { transactionManager, entity.AdmTansikCodesCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeFacultyRule>
				if (CanDeepSave(entity.FeeFacultyRuleCollection, "List<FeeFacultyRule>|FeeFacultyRuleCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeFacultyRule child in entity.FeeFacultyRuleCollection)
					{
						if(child.AsCodeDegreeIdSource != null)
						{
							child.AsCodeDegreeId = child.AsCodeDegreeIdSource.AsCodeDegreeId;
						}
						else
						{
							child.AsCodeDegreeId = entity.AsCodeDegreeId;
						}

					}

					if (entity.FeeFacultyRuleCollection.Count > 0 || entity.FeeFacultyRuleCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeFacultyRuleProvider.Save(transactionManager, entity.FeeFacultyRuleCollection);
						
						deepHandles.Add("FeeFacultyRuleCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeFacultyRule >) DataRepository.FeeFacultyRuleProvider.DeepSave,
							new object[] { transactionManager, entity.FeeFacultyRuleCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmCodeEngTest>
				if (CanDeepSave(entity.AdmCodeEngTestCollection, "List<AdmCodeEngTest>|AdmCodeEngTestCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmCodeEngTest child in entity.AdmCodeEngTestCollection)
					{
						if(child.AsCodeDegreeIdSource != null)
						{
							child.AsCodeDegreeId = child.AsCodeDegreeIdSource.AsCodeDegreeId;
						}
						else
						{
							child.AsCodeDegreeId = entity.AsCodeDegreeId;
						}

					}

					if (entity.AdmCodeEngTestCollection.Count > 0 || entity.AdmCodeEngTestCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmCodeEngTestProvider.Save(transactionManager, entity.AdmCodeEngTestCollection);
						
						deepHandles.Add("AdmCodeEngTestCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmCodeEngTest >) DataRepository.AdmCodeEngTestProvider.DeepSave,
							new object[] { transactionManager, entity.AdmCodeEngTestCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdGraduationAward>
				if (CanDeepSave(entity.EdGraduationAwardCollection, "List<EdGraduationAward>|EdGraduationAwardCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdGraduationAward child in entity.EdGraduationAwardCollection)
					{
						if(child.AsCodeDegreeIdSource != null)
						{
							child.AsCodeDegreeId = child.AsCodeDegreeIdSource.AsCodeDegreeId;
						}
						else
						{
							child.AsCodeDegreeId = entity.AsCodeDegreeId;
						}

					}

					if (entity.EdGraduationAwardCollection.Count > 0 || entity.EdGraduationAwardCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdGraduationAwardProvider.Save(transactionManager, entity.EdGraduationAwardCollection);
						
						deepHandles.Add("EdGraduationAwardCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdGraduationAward >) DataRepository.EdGraduationAwardProvider.DeepSave,
							new object[] { transactionManager, entity.EdGraduationAwardCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmCdeFee>
				if (CanDeepSave(entity.AdmCdeFeeCollection, "List<AdmCdeFee>|AdmCdeFeeCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmCdeFee child in entity.AdmCdeFeeCollection)
					{
						if(child.AsCodeDegreeIdSource != null)
						{
							child.AsCodeDegreeId = child.AsCodeDegreeIdSource.AsCodeDegreeId;
						}
						else
						{
							child.AsCodeDegreeId = entity.AsCodeDegreeId;
						}

					}

					if (entity.AdmCdeFeeCollection.Count > 0 || entity.AdmCdeFeeCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmCdeFeeProvider.Save(transactionManager, entity.AdmCdeFeeCollection);
						
						deepHandles.Add("AdmCdeFeeCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmCdeFee >) DataRepository.AdmCdeFeeProvider.DeepSave,
							new object[] { transactionManager, entity.AdmCdeFeeCollection, deepSaveType, childTypes, innerList }
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
	
	#region AsCodeDegreeChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AsCodeDegree</c>
	///</summary>
	public enum AsCodeDegreeChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AsCodeDegreeClass</c> at AsCodeDegreeClassIdSource
		///</summary>
		[ChildEntityType(typeof(AsCodeDegreeClass))]
		AsCodeDegreeClass,
		///<summary>
		/// Collection of <c>AsCodeDegree</c> as OneToMany for AdmAppRegHistoryCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppRegHistory>))]
		AdmAppRegHistoryCollection,
		///<summary>
		/// Collection of <c>AsCodeDegree</c> as OneToMany for AdmReqDocCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmReqDoc>))]
		AdmReqDocCollection,
		///<summary>
		/// Collection of <c>AsCodeDegree</c> as OneToMany for EdStudSemesterCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudSemester>))]
		EdStudSemesterCollection,
		///<summary>
		/// Collection of <c>AsCodeDegree</c> as OneToMany for FeeFundRuleCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeFundRule>))]
		FeeFundRuleCollection,
		///<summary>
		/// Collection of <c>AsCodeDegree</c> as OneToMany for SaScQualCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaScQual>))]
		SaScQualCollection,
		///<summary>
		/// Collection of <c>AsCodeDegree</c> as OneToMany for PgThesisGrantDegreeCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgThesisGrantDegree>))]
		PgThesisGrantDegreeCollection,
		///<summary>
		/// Collection of <c>AsCodeDegree</c> as OneToMany for SeUserAccntDegCollection
		///</summary>
		[ChildEntityType(typeof(TList<SeUserAccntDeg>))]
		SeUserAccntDegCollection,
		///<summary>
		/// Collection of <c>AsCodeDegree</c> as OneToMany for FeeInstlmntRuleCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeInstlmntRule>))]
		FeeInstlmntRuleCollection,
		///<summary>
		/// Collection of <c>AsCodeDegree</c> as OneToMany for EdStudFacultyCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudFaculty>))]
		EdStudFacultyCollection,
		///<summary>
		/// Collection of <c>AsCodeDegree</c> as OneToMany for EntityMainCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntityMain>))]
		EntityMainCollection,
		///<summary>
		/// Collection of <c>AsCodeDegree</c> as OneToMany for EntPlcyAcadWarnDtlCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntPlcyAcadWarnDtl>))]
		EntPlcyAcadWarnDtlCollection,
		///<summary>
		/// Collection of <c>AsCodeDegree</c> as OneToMany for FeeAllowanceRuleCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeAllowanceRule>))]
		FeeAllowanceRuleCollection,
		///<summary>
		/// Collection of <c>AsCodeDegree</c> as OneToMany for EdBylawCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdBylaw>))]
		EdBylawCollection,
		///<summary>
		/// Collection of <c>AsCodeDegree</c> as OneToMany for FeeFacultyInstallmentCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeFacultyInstallment>))]
		FeeFacultyInstallmentCollection,
		///<summary>
		/// Collection of <c>AsCodeDegree</c> as OneToMany for AdmPrecondQualCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmPrecondQual>))]
		AdmPrecondQualCollection,
		///<summary>
		/// Collection of <c>AsCodeDegree</c> as OneToMany for EdCdeQualCatCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdCdeQualCat>))]
		EdCdeQualCatCollection,
		///<summary>
		/// Collection of <c>AsCodeDegree</c> as OneToMany for AdmRatingParametersMajorsCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmRatingParametersMajors>))]
		AdmRatingParametersMajorsCollection,
		///<summary>
		/// Collection of <c>AsCodeDegree</c> as OneToMany for ScScheduleRsrvCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScScheduleRsrv>))]
		ScScheduleRsrvCollection,
		///<summary>
		/// Collection of <c>AsCodeDegree</c> as OneToMany for AdmAcceptanceCategoryCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAcceptanceCategory>))]
		AdmAcceptanceCategoryCollection,
		///<summary>
		/// Collection of <c>AsCodeDegree</c> as OneToMany for AdmTransAcceptanceCategoryCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmTransAcceptanceCategory>))]
		AdmTransAcceptanceCategoryCollection,
		///<summary>
		/// Collection of <c>AsCodeDegree</c> as OneToMany for EdResultApproveCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdResultApprove>))]
		EdResultApproveCollection,
		///<summary>
		/// Collection of <c>AsCodeDegree</c> as OneToMany for AdmCdePlacementExamCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmCdePlacementExam>))]
		AdmCdePlacementExamCollection,
		///<summary>
		/// Collection of <c>AsCodeDegree</c> as OneToMany for FeeLimitRuleCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeLimitRule>))]
		FeeLimitRuleCollection,
		///<summary>
		/// Collection of <c>AsCodeDegree</c> as OneToMany for EdSemesterAgendaCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdSemesterAgenda>))]
		EdSemesterAgendaCollection,
		///<summary>
		/// Collection of <c>AsCodeDegree</c> as OneToMany for FeeCodeItemCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeCodeItem>))]
		FeeCodeItemCollection,
		///<summary>
		/// Collection of <c>AsCodeDegree</c> as OneToMany for AdmCompetitiveAvgCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmCompetitiveAvg>))]
		AdmCompetitiveAvgCollection,
		///<summary>
		/// Collection of <c>AsCodeDegree</c> as OneToMany for AdmTansikCodesCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmTansikCodes>))]
		AdmTansikCodesCollection,
		///<summary>
		/// Collection of <c>AsCodeDegree</c> as OneToMany for FeeFacultyRuleCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeFacultyRule>))]
		FeeFacultyRuleCollection,
		///<summary>
		/// Collection of <c>AsCodeDegree</c> as OneToMany for AdmCodeEngTestCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmCodeEngTest>))]
		AdmCodeEngTestCollection,
		///<summary>
		/// Collection of <c>AsCodeDegree</c> as OneToMany for EdGraduationAwardCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdGraduationAward>))]
		EdGraduationAwardCollection,
		///<summary>
		/// Collection of <c>AsCodeDegree</c> as OneToMany for AdmCdeFeeCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmCdeFee>))]
		AdmCdeFeeCollection,
	}
	
	#endregion AsCodeDegreeChildEntityTypes
	
	#region AsCodeDegreeFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AsCodeDegreeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AsCodeDegree"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AsCodeDegreeFilterBuilder : SqlFilterBuilder<AsCodeDegreeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AsCodeDegreeFilterBuilder class.
		/// </summary>
		public AsCodeDegreeFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AsCodeDegreeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AsCodeDegreeFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AsCodeDegreeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AsCodeDegreeFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AsCodeDegreeFilterBuilder
	
	#region AsCodeDegreeParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AsCodeDegreeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AsCodeDegree"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AsCodeDegreeParameterBuilder : ParameterizedSqlFilterBuilder<AsCodeDegreeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AsCodeDegreeParameterBuilder class.
		/// </summary>
		public AsCodeDegreeParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AsCodeDegreeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AsCodeDegreeParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AsCodeDegreeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AsCodeDegreeParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AsCodeDegreeParameterBuilder
	
	#region AsCodeDegreeSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AsCodeDegreeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AsCodeDegree"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AsCodeDegreeSortBuilder : SqlSortBuilder<AsCodeDegreeColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AsCodeDegreeSqlSortBuilder class.
		/// </summary>
		public AsCodeDegreeSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AsCodeDegreeSortBuilder
	
} // end namespace
