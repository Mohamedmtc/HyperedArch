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
	/// This class is the base class for any <see cref="EdCodeGradingProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdCodeGradingProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdCodeGrading, UMIS_VER2.BusinessLyer.EdCodeGradingKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeGradingKey key)
		{
			return Delete(transactionManager, key.EdCodeGradingId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edCodeGradingId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edCodeGradingId)
		{
			return Delete(null, _edCodeGradingId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeGradingId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edCodeGradingId);		
		
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
		public override UMIS_VER2.BusinessLyer.EdCodeGrading Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeGradingKey key, int start, int pageLength)
		{
			return GetByEdCodeGradingId(transactionManager, key.EdCodeGradingId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_CODE_RATING index.
		/// </summary>
		/// <param name="_edCodeGradingId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeGrading"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeGrading GetByEdCodeGradingId(System.Decimal _edCodeGradingId)
		{
			int count = -1;
			return GetByEdCodeGradingId(null,_edCodeGradingId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_RATING index.
		/// </summary>
		/// <param name="_edCodeGradingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeGrading"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeGrading GetByEdCodeGradingId(System.Decimal _edCodeGradingId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeGradingId(null, _edCodeGradingId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_RATING index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeGradingId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeGrading"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeGrading GetByEdCodeGradingId(TransactionManager transactionManager, System.Decimal _edCodeGradingId)
		{
			int count = -1;
			return GetByEdCodeGradingId(transactionManager, _edCodeGradingId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_RATING index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeGradingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeGrading"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeGrading GetByEdCodeGradingId(TransactionManager transactionManager, System.Decimal _edCodeGradingId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeGradingId(transactionManager, _edCodeGradingId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_RATING index.
		/// </summary>
		/// <param name="_edCodeGradingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeGrading"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeGrading GetByEdCodeGradingId(System.Decimal _edCodeGradingId, int start, int pageLength, out int count)
		{
			return GetByEdCodeGradingId(null, _edCodeGradingId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_RATING index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeGradingId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeGrading"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdCodeGrading GetByEdCodeGradingId(TransactionManager transactionManager, System.Decimal _edCodeGradingId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdCodeGrading&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdCodeGrading&gt;"/></returns>
		public static TList<EdCodeGrading> Fill(IDataReader reader, TList<EdCodeGrading> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdCodeGrading c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdCodeGrading")
					.Append("|").Append((System.Decimal)reader["ED_CODE_GRADING_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdCodeGrading>(
					key.ToString(), // EntityTrackingKey
					"EdCodeGrading",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdCodeGrading();
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
					c.EdCodeGradingId = (System.Decimal)reader["ED_CODE_GRADING_ID"];
					c.OriginalEdCodeGradingId = c.EdCodeGradingId;
					c.DescrAr = (System.String)reader["DESCR_AR"];
					c.DescrEn = Convert.IsDBNull(reader["DESCR_EN"]) ? null : (System.String)reader["DESCR_EN"];
					c.SymbolAr = Convert.IsDBNull(reader["SYMBOL_AR"]) ? null : (System.String)reader["SYMBOL_AR"];
					c.SymbolEn = Convert.IsDBNull(reader["SYMBOL_EN"]) ? null : (System.String)reader["SYMBOL_EN"];
					c.GradOrder = Convert.IsDBNull(reader["GRAD_ORDER"]) ? null : (System.String)reader["GRAD_ORDER"];
					c.GradCode = Convert.IsDBNull(reader["GRAD_CODE"]) ? null : (System.String)reader["GRAD_CODE"];
					c.ShowFlg = Convert.IsDBNull(reader["SHOW_FLG"]) ? null : (System.Decimal?)reader["SHOW_FLG"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCodeGrading"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeGrading"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdCodeGrading entity)
		{
			if (!reader.Read()) return;
			
			entity.EdCodeGradingId = (System.Decimal)reader[((int)EdCodeGradingColumn.EdCodeGradingId - 1)];
			entity.OriginalEdCodeGradingId = (System.Decimal)reader["ED_CODE_GRADING_ID"];
			entity.DescrAr = (System.String)reader[((int)EdCodeGradingColumn.DescrAr - 1)];
			entity.DescrEn = (reader.IsDBNull(((int)EdCodeGradingColumn.DescrEn - 1)))?null:(System.String)reader[((int)EdCodeGradingColumn.DescrEn - 1)];
			entity.SymbolAr = (reader.IsDBNull(((int)EdCodeGradingColumn.SymbolAr - 1)))?null:(System.String)reader[((int)EdCodeGradingColumn.SymbolAr - 1)];
			entity.SymbolEn = (reader.IsDBNull(((int)EdCodeGradingColumn.SymbolEn - 1)))?null:(System.String)reader[((int)EdCodeGradingColumn.SymbolEn - 1)];
			entity.GradOrder = (reader.IsDBNull(((int)EdCodeGradingColumn.GradOrder - 1)))?null:(System.String)reader[((int)EdCodeGradingColumn.GradOrder - 1)];
			entity.GradCode = (reader.IsDBNull(((int)EdCodeGradingColumn.GradCode - 1)))?null:(System.String)reader[((int)EdCodeGradingColumn.GradCode - 1)];
			entity.ShowFlg = (reader.IsDBNull(((int)EdCodeGradingColumn.ShowFlg - 1)))?null:(System.Decimal?)reader[((int)EdCodeGradingColumn.ShowFlg - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCodeGrading"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeGrading"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdCodeGrading entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdCodeGradingId = (System.Decimal)dataRow["ED_CODE_GRADING_ID"];
			entity.OriginalEdCodeGradingId = (System.Decimal)dataRow["ED_CODE_GRADING_ID"];
			entity.DescrAr = (System.String)dataRow["DESCR_AR"];
			entity.DescrEn = Convert.IsDBNull(dataRow["DESCR_EN"]) ? null : (System.String)dataRow["DESCR_EN"];
			entity.SymbolAr = Convert.IsDBNull(dataRow["SYMBOL_AR"]) ? null : (System.String)dataRow["SYMBOL_AR"];
			entity.SymbolEn = Convert.IsDBNull(dataRow["SYMBOL_EN"]) ? null : (System.String)dataRow["SYMBOL_EN"];
			entity.GradOrder = Convert.IsDBNull(dataRow["GRAD_ORDER"]) ? null : (System.String)dataRow["GRAD_ORDER"];
			entity.GradCode = Convert.IsDBNull(dataRow["GRAD_CODE"]) ? null : (System.String)dataRow["GRAD_CODE"];
			entity.ShowFlg = Convert.IsDBNull(dataRow["SHOW_FLG"]) ? null : (System.Decimal?)dataRow["SHOW_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeGrading"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCodeGrading Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeGrading entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEdCodeGradingId methods when available
			
			#region EdStudIntTrnsCourseFromCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudIntTrnsCourseFrom>|EdStudIntTrnsCourseFromCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudIntTrnsCourseFromCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudIntTrnsCourseFromCollection = DataRepository.EdStudIntTrnsCourseFromProvider.GetByEdCodeGradingId(transactionManager, entity.EdCodeGradingId);

				if (deep && entity.EdStudIntTrnsCourseFromCollection.Count > 0)
				{
					deepHandles.Add("EdStudIntTrnsCourseFromCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudIntTrnsCourseFrom>) DataRepository.EdStudIntTrnsCourseFromProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudIntTrnsCourseFromCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.AdmAppTransToCourseCollection = DataRepository.AdmAppTransToCourseProvider.GetByEdCodeGradingId(transactionManager, entity.EdCodeGradingId);

				if (deep && entity.AdmAppTransToCourseCollection.Count > 0)
				{
					deepHandles.Add("AdmAppTransToCourseCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppTransToCourse>) DataRepository.AdmAppTransToCourseProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppTransToCourseCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntPolicyCourseRepeatCollectionGetByEdCodeMinGradId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntPolicyCourseRepeat>|EntPolicyCourseRepeatCollectionGetByEdCodeMinGradId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPolicyCourseRepeatCollectionGetByEdCodeMinGradId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntPolicyCourseRepeatCollectionGetByEdCodeMinGradId = DataRepository.EntPolicyCourseRepeatProvider.GetByEdCodeMinGradId(transactionManager, entity.EdCodeGradingId);

				if (deep && entity.EntPolicyCourseRepeatCollectionGetByEdCodeMinGradId.Count > 0)
				{
					deepHandles.Add("EntPolicyCourseRepeatCollectionGetByEdCodeMinGradId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntPolicyCourseRepeat>) DataRepository.EntPolicyCourseRepeatProvider.DeepLoad,
						new object[] { transactionManager, entity.EntPolicyCourseRepeatCollectionGetByEdCodeMinGradId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudCourseRegAddCollectionGetByActualEdCodeGradingId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudCourseRegAdd>|EdStudCourseRegAddCollectionGetByActualEdCodeGradingId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCourseRegAddCollectionGetByActualEdCodeGradingId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCourseRegAddCollectionGetByActualEdCodeGradingId = DataRepository.EdStudCourseRegAddProvider.GetByActualEdCodeGradingId(transactionManager, entity.EdCodeGradingId);

				if (deep && entity.EdStudCourseRegAddCollectionGetByActualEdCodeGradingId.Count > 0)
				{
					deepHandles.Add("EdStudCourseRegAddCollectionGetByActualEdCodeGradingId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCourseRegAdd>) DataRepository.EdStudCourseRegAddProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCourseRegAddCollectionGetByActualEdCodeGradingId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region PgThesisStudCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgThesisStud>|PgThesisStudCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisStudCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgThesisStudCollection = DataRepository.PgThesisStudProvider.GetByEdCodeGradingId(transactionManager, entity.EdCodeGradingId);

				if (deep && entity.PgThesisStudCollection.Count > 0)
				{
					deepHandles.Add("PgThesisStudCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgThesisStud>) DataRepository.PgThesisStudProvider.DeepLoad,
						new object[] { transactionManager, entity.PgThesisStudCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntPolicyAccumHonorCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntPolicyAccumHonor>|EntPolicyAccumHonorCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPolicyAccumHonorCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntPolicyAccumHonorCollection = DataRepository.EntPolicyAccumHonorProvider.GetByMinLvlGradeId(transactionManager, entity.EdCodeGradingId);

				if (deep && entity.EntPolicyAccumHonorCollection.Count > 0)
				{
					deepHandles.Add("EntPolicyAccumHonorCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntPolicyAccumHonor>) DataRepository.EntPolicyAccumHonorProvider.DeepLoad,
						new object[] { transactionManager, entity.EntPolicyAccumHonorCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudSemesterExtCollectionGetByEdCodeGradingId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudSemesterExt>|EdStudSemesterExtCollectionGetByEdCodeGradingId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudSemesterExtCollectionGetByEdCodeGradingId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudSemesterExtCollectionGetByEdCodeGradingId = DataRepository.EdStudSemesterExtProvider.GetByEdCodeGradingId(transactionManager, entity.EdCodeGradingId);

				if (deep && entity.EdStudSemesterExtCollectionGetByEdCodeGradingId.Count > 0)
				{
					deepHandles.Add("EdStudSemesterExtCollectionGetByEdCodeGradingId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudSemesterExt>) DataRepository.EdStudSemesterExtProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudSemesterExtCollectionGetByEdCodeGradingId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdCourseExpDtlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdCourseExpDtl>|EdCourseExpDtlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCourseExpDtlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdCourseExpDtlCollection = DataRepository.EdCourseExpDtlProvider.GetByEdCodeGradingId(transactionManager, entity.EdCodeGradingId);

				if (deep && entity.EdCourseExpDtlCollection.Count > 0)
				{
					deepHandles.Add("EdCourseExpDtlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdCourseExpDtl>) DataRepository.EdCourseExpDtlProvider.DeepLoad,
						new object[] { transactionManager, entity.EdCourseExpDtlCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.EntPolcyGrdngHdrCollection = DataRepository.EntPolcyGrdngHdrProvider.GetByEdCodeMaxGradId(transactionManager, entity.EdCodeGradingId);

				if (deep && entity.EntPolcyGrdngHdrCollection.Count > 0)
				{
					deepHandles.Add("EntPolcyGrdngHdrCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntPolcyGrdngHdr>) DataRepository.EntPolcyGrdngHdrProvider.DeepLoad,
						new object[] { transactionManager, entity.EntPolcyGrdngHdrCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStdCrsExamCollectionGetByEdCodeGradingOldId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStdCrsExam>|EdStdCrsExamCollectionGetByEdCodeGradingOldId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStdCrsExamCollectionGetByEdCodeGradingOldId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStdCrsExamCollectionGetByEdCodeGradingOldId = DataRepository.EdStdCrsExamProvider.GetByEdCodeGradingOldId(transactionManager, entity.EdCodeGradingId);

				if (deep && entity.EdStdCrsExamCollectionGetByEdCodeGradingOldId.Count > 0)
				{
					deepHandles.Add("EdStdCrsExamCollectionGetByEdCodeGradingOldId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStdCrsExam>) DataRepository.EdStdCrsExamProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStdCrsExamCollectionGetByEdCodeGradingOldId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudCourseGrdChngCollectionGetByEdCodeGradingNewId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudCourseGrdChng>|EdStudCourseGrdChngCollectionGetByEdCodeGradingNewId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCourseGrdChngCollectionGetByEdCodeGradingNewId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCourseGrdChngCollectionGetByEdCodeGradingNewId = DataRepository.EdStudCourseGrdChngProvider.GetByEdCodeGradingNewId(transactionManager, entity.EdCodeGradingId);

				if (deep && entity.EdStudCourseGrdChngCollectionGetByEdCodeGradingNewId.Count > 0)
				{
					deepHandles.Add("EdStudCourseGrdChngCollectionGetByEdCodeGradingNewId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCourseGrdChng>) DataRepository.EdStudCourseGrdChngProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCourseGrdChngCollectionGetByEdCodeGradingNewId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStdExamSemesterCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStdExamSemester>|EdStdExamSemesterCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStdExamSemesterCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStdExamSemesterCollection = DataRepository.EdStdExamSemesterProvider.GetByEdCodeGradingId(transactionManager, entity.EdCodeGradingId);

				if (deep && entity.EdStdExamSemesterCollection.Count > 0)
				{
					deepHandles.Add("EdStdExamSemesterCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStdExamSemester>) DataRepository.EdStdExamSemesterProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStdExamSemesterCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStdCrsExamCollectionGetByEdCodeGradingNewId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStdCrsExam>|EdStdCrsExamCollectionGetByEdCodeGradingNewId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStdCrsExamCollectionGetByEdCodeGradingNewId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStdCrsExamCollectionGetByEdCodeGradingNewId = DataRepository.EdStdCrsExamProvider.GetByEdCodeGradingNewId(transactionManager, entity.EdCodeGradingId);

				if (deep && entity.EdStdCrsExamCollectionGetByEdCodeGradingNewId.Count > 0)
				{
					deepHandles.Add("EdStdCrsExamCollectionGetByEdCodeGradingNewId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStdCrsExam>) DataRepository.EdStdCrsExamProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStdCrsExamCollectionGetByEdCodeGradingNewId, deep, deepLoadType, childTypes, innerList }
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

				entity.EdStudCourseRegCollection = DataRepository.EdStudCourseRegProvider.GetByEdCodeGradingId(transactionManager, entity.EdCodeGradingId);

				if (deep && entity.EdStudCourseRegCollection.Count > 0)
				{
					deepHandles.Add("EdStudCourseRegCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCourseReg>) DataRepository.EdStudCourseRegProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCourseRegCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntPolicyCourseRepeatCollectionGetByEdCodeGradingId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntPolicyCourseRepeat>|EntPolicyCourseRepeatCollectionGetByEdCodeGradingId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPolicyCourseRepeatCollectionGetByEdCodeGradingId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntPolicyCourseRepeatCollectionGetByEdCodeGradingId = DataRepository.EntPolicyCourseRepeatProvider.GetByEdCodeGradingId(transactionManager, entity.EdCodeGradingId);

				if (deep && entity.EntPolicyCourseRepeatCollectionGetByEdCodeGradingId.Count > 0)
				{
					deepHandles.Add("EntPolicyCourseRepeatCollectionGetByEdCodeGradingId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntPolicyCourseRepeat>) DataRepository.EntPolicyCourseRepeatProvider.DeepLoad,
						new object[] { transactionManager, entity.EntPolicyCourseRepeatCollectionGetByEdCodeGradingId, deep, deepLoadType, childTypes, innerList }
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

				entity.EdStudIntTrnsCourseToCollection = DataRepository.EdStudIntTrnsCourseToProvider.GetByEdCodeGradingId(transactionManager, entity.EdCodeGradingId);

				if (deep && entity.EdStudIntTrnsCourseToCollection.Count > 0)
				{
					deepHandles.Add("EdStudIntTrnsCourseToCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudIntTrnsCourseTo>) DataRepository.EdStudIntTrnsCourseToProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudIntTrnsCourseToCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.EdStudFacultyCollection = DataRepository.EdStudFacultyProvider.GetByEdCodeGradingId(transactionManager, entity.EdCodeGradingId);

				if (deep && entity.EdStudFacultyCollection.Count > 0)
				{
					deepHandles.Add("EdStudFacultyCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudFaculty>) DataRepository.EdStudFacultyProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudFacultyCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.EntPolicyGradingDtlCollection = DataRepository.EntPolicyGradingDtlProvider.GetByEdCodeGradingId(transactionManager, entity.EdCodeGradingId);

				if (deep && entity.EntPolicyGradingDtlCollection.Count > 0)
				{
					deepHandles.Add("EntPolicyGradingDtlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntPolicyGradingDtl>) DataRepository.EntPolicyGradingDtlProvider.DeepLoad,
						new object[] { transactionManager, entity.EntPolicyGradingDtlCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region PgThesisGrantStudCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgThesisGrantStud>|PgThesisGrantStudCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgThesisGrantStudCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgThesisGrantStudCollection = DataRepository.PgThesisGrantStudProvider.GetByEdCodeGradingId(transactionManager, entity.EdCodeGradingId);

				if (deep && entity.PgThesisGrantStudCollection.Count > 0)
				{
					deepHandles.Add("PgThesisGrantStudCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgThesisGrantStud>) DataRepository.PgThesisGrantStudProvider.DeepLoad,
						new object[] { transactionManager, entity.PgThesisGrantStudCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudCourseGrdChngCollectionGetByEdCodeGradingOldId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudCourseGrdChng>|EdStudCourseGrdChngCollectionGetByEdCodeGradingOldId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCourseGrdChngCollectionGetByEdCodeGradingOldId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCourseGrdChngCollectionGetByEdCodeGradingOldId = DataRepository.EdStudCourseGrdChngProvider.GetByEdCodeGradingOldId(transactionManager, entity.EdCodeGradingId);

				if (deep && entity.EdStudCourseGrdChngCollectionGetByEdCodeGradingOldId.Count > 0)
				{
					deepHandles.Add("EdStudCourseGrdChngCollectionGetByEdCodeGradingOldId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCourseGrdChng>) DataRepository.EdStudCourseGrdChngProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCourseGrdChngCollectionGetByEdCodeGradingOldId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudSemesterExtCollectionGetByEdCodeAccumGradingId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudSemesterExt>|EdStudSemesterExtCollectionGetByEdCodeAccumGradingId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudSemesterExtCollectionGetByEdCodeAccumGradingId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudSemesterExtCollectionGetByEdCodeAccumGradingId = DataRepository.EdStudSemesterExtProvider.GetByEdCodeAccumGradingId(transactionManager, entity.EdCodeGradingId);

				if (deep && entity.EdStudSemesterExtCollectionGetByEdCodeAccumGradingId.Count > 0)
				{
					deepHandles.Add("EdStudSemesterExtCollectionGetByEdCodeAccumGradingId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudSemesterExt>) DataRepository.EdStudSemesterExtProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudSemesterExtCollectionGetByEdCodeAccumGradingId, deep, deepLoadType, childTypes, innerList }
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

				entity.EdStudCourseRegTempCollection = DataRepository.EdStudCourseRegTempProvider.GetByEdCodeGradingId(transactionManager, entity.EdCodeGradingId);

				if (deep && entity.EdStudCourseRegTempCollection.Count > 0)
				{
					deepHandles.Add("EdStudCourseRegTempCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCourseRegTemp>) DataRepository.EdStudCourseRegTempProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCourseRegTempCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntPolicyCourseRepeatCollectionGetByGradingMoreThanOneId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntPolicyCourseRepeat>|EntPolicyCourseRepeatCollectionGetByGradingMoreThanOneId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntPolicyCourseRepeatCollectionGetByGradingMoreThanOneId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntPolicyCourseRepeatCollectionGetByGradingMoreThanOneId = DataRepository.EntPolicyCourseRepeatProvider.GetByGradingMoreThanOneId(transactionManager, entity.EdCodeGradingId);

				if (deep && entity.EntPolicyCourseRepeatCollectionGetByGradingMoreThanOneId.Count > 0)
				{
					deepHandles.Add("EntPolicyCourseRepeatCollectionGetByGradingMoreThanOneId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntPolicyCourseRepeat>) DataRepository.EntPolicyCourseRepeatProvider.DeepLoad,
						new object[] { transactionManager, entity.EntPolicyCourseRepeatCollectionGetByGradingMoreThanOneId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntCourseMdDataCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntCourseMdData>|EntCourseMdDataCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntCourseMdDataCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntCourseMdDataCollection = DataRepository.EntCourseMdDataProvider.GetByEdCodeGradingId(transactionManager, entity.EdCodeGradingId);

				if (deep && entity.EntCourseMdDataCollection.Count > 0)
				{
					deepHandles.Add("EntCourseMdDataCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntCourseMdData>) DataRepository.EntCourseMdDataProvider.DeepLoad,
						new object[] { transactionManager, entity.EntCourseMdDataCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudCourseRegAddCollectionGetByFinalEdCodeGradingId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudCourseRegAdd>|EdStudCourseRegAddCollectionGetByFinalEdCodeGradingId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCourseRegAddCollectionGetByFinalEdCodeGradingId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCourseRegAddCollectionGetByFinalEdCodeGradingId = DataRepository.EdStudCourseRegAddProvider.GetByFinalEdCodeGradingId(transactionManager, entity.EdCodeGradingId);

				if (deep && entity.EdStudCourseRegAddCollectionGetByFinalEdCodeGradingId.Count > 0)
				{
					deepHandles.Add("EdStudCourseRegAddCollectionGetByFinalEdCodeGradingId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCourseRegAdd>) DataRepository.EdStudCourseRegAddProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCourseRegAddCollectionGetByFinalEdCodeGradingId, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdCodeGrading object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdCodeGrading instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCodeGrading Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeGrading entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
						if(child.EdCodeGradingIdSource != null)
						{
							child.EdCodeGradingId = child.EdCodeGradingIdSource.EdCodeGradingId;
						}
						else
						{
							child.EdCodeGradingId = entity.EdCodeGradingId;
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
				
	
			#region List<AdmAppTransToCourse>
				if (CanDeepSave(entity.AdmAppTransToCourseCollection, "List<AdmAppTransToCourse>|AdmAppTransToCourseCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppTransToCourse child in entity.AdmAppTransToCourseCollection)
					{
						if(child.EdCodeGradingIdSource != null)
						{
							child.EdCodeGradingId = child.EdCodeGradingIdSource.EdCodeGradingId;
						}
						else
						{
							child.EdCodeGradingId = entity.EdCodeGradingId;
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
				
	
			#region List<EntPolicyCourseRepeat>
				if (CanDeepSave(entity.EntPolicyCourseRepeatCollectionGetByEdCodeMinGradId, "List<EntPolicyCourseRepeat>|EntPolicyCourseRepeatCollectionGetByEdCodeMinGradId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntPolicyCourseRepeat child in entity.EntPolicyCourseRepeatCollectionGetByEdCodeMinGradId)
					{
						if(child.EdCodeMinGradIdSource != null)
						{
							child.EdCodeMinGradId = child.EdCodeMinGradIdSource.EdCodeGradingId;
						}
						else
						{
							child.EdCodeMinGradId = entity.EdCodeGradingId;
						}

					}

					if (entity.EntPolicyCourseRepeatCollectionGetByEdCodeMinGradId.Count > 0 || entity.EntPolicyCourseRepeatCollectionGetByEdCodeMinGradId.DeletedItems.Count > 0)
					{
						//DataRepository.EntPolicyCourseRepeatProvider.Save(transactionManager, entity.EntPolicyCourseRepeatCollectionGetByEdCodeMinGradId);
						
						deepHandles.Add("EntPolicyCourseRepeatCollectionGetByEdCodeMinGradId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntPolicyCourseRepeat >) DataRepository.EntPolicyCourseRepeatProvider.DeepSave,
							new object[] { transactionManager, entity.EntPolicyCourseRepeatCollectionGetByEdCodeMinGradId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudCourseRegAdd>
				if (CanDeepSave(entity.EdStudCourseRegAddCollectionGetByActualEdCodeGradingId, "List<EdStudCourseRegAdd>|EdStudCourseRegAddCollectionGetByActualEdCodeGradingId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudCourseRegAdd child in entity.EdStudCourseRegAddCollectionGetByActualEdCodeGradingId)
					{
						if(child.ActualEdCodeGradingIdSource != null)
						{
							child.ActualEdCodeGradingId = child.ActualEdCodeGradingIdSource.EdCodeGradingId;
						}
						else
						{
							child.ActualEdCodeGradingId = entity.EdCodeGradingId;
						}

					}

					if (entity.EdStudCourseRegAddCollectionGetByActualEdCodeGradingId.Count > 0 || entity.EdStudCourseRegAddCollectionGetByActualEdCodeGradingId.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudCourseRegAddProvider.Save(transactionManager, entity.EdStudCourseRegAddCollectionGetByActualEdCodeGradingId);
						
						deepHandles.Add("EdStudCourseRegAddCollectionGetByActualEdCodeGradingId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudCourseRegAdd >) DataRepository.EdStudCourseRegAddProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCourseRegAddCollectionGetByActualEdCodeGradingId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<PgThesisStud>
				if (CanDeepSave(entity.PgThesisStudCollection, "List<PgThesisStud>|PgThesisStudCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgThesisStud child in entity.PgThesisStudCollection)
					{
						if(child.EdCodeGradingIdSource != null)
						{
							child.EdCodeGradingId = child.EdCodeGradingIdSource.EdCodeGradingId;
						}
						else
						{
							child.EdCodeGradingId = entity.EdCodeGradingId;
						}

					}

					if (entity.PgThesisStudCollection.Count > 0 || entity.PgThesisStudCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgThesisStudProvider.Save(transactionManager, entity.PgThesisStudCollection);
						
						deepHandles.Add("PgThesisStudCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgThesisStud >) DataRepository.PgThesisStudProvider.DeepSave,
							new object[] { transactionManager, entity.PgThesisStudCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntPolicyAccumHonor>
				if (CanDeepSave(entity.EntPolicyAccumHonorCollection, "List<EntPolicyAccumHonor>|EntPolicyAccumHonorCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntPolicyAccumHonor child in entity.EntPolicyAccumHonorCollection)
					{
						if(child.MinLvlGradeIdSource != null)
						{
							child.MinLvlGradeId = child.MinLvlGradeIdSource.EdCodeGradingId;
						}
						else
						{
							child.MinLvlGradeId = entity.EdCodeGradingId;
						}

					}

					if (entity.EntPolicyAccumHonorCollection.Count > 0 || entity.EntPolicyAccumHonorCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntPolicyAccumHonorProvider.Save(transactionManager, entity.EntPolicyAccumHonorCollection);
						
						deepHandles.Add("EntPolicyAccumHonorCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntPolicyAccumHonor >) DataRepository.EntPolicyAccumHonorProvider.DeepSave,
							new object[] { transactionManager, entity.EntPolicyAccumHonorCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudSemesterExt>
				if (CanDeepSave(entity.EdStudSemesterExtCollectionGetByEdCodeGradingId, "List<EdStudSemesterExt>|EdStudSemesterExtCollectionGetByEdCodeGradingId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudSemesterExt child in entity.EdStudSemesterExtCollectionGetByEdCodeGradingId)
					{
						if(child.EdCodeGradingIdSource != null)
						{
							child.EdCodeGradingId = child.EdCodeGradingIdSource.EdCodeGradingId;
						}
						else
						{
							child.EdCodeGradingId = entity.EdCodeGradingId;
						}

					}

					if (entity.EdStudSemesterExtCollectionGetByEdCodeGradingId.Count > 0 || entity.EdStudSemesterExtCollectionGetByEdCodeGradingId.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudSemesterExtProvider.Save(transactionManager, entity.EdStudSemesterExtCollectionGetByEdCodeGradingId);
						
						deepHandles.Add("EdStudSemesterExtCollectionGetByEdCodeGradingId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudSemesterExt >) DataRepository.EdStudSemesterExtProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudSemesterExtCollectionGetByEdCodeGradingId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdCourseExpDtl>
				if (CanDeepSave(entity.EdCourseExpDtlCollection, "List<EdCourseExpDtl>|EdCourseExpDtlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdCourseExpDtl child in entity.EdCourseExpDtlCollection)
					{
						if(child.EdCodeGradingIdSource != null)
						{
							child.EdCodeGradingId = child.EdCodeGradingIdSource.EdCodeGradingId;
						}
						else
						{
							child.EdCodeGradingId = entity.EdCodeGradingId;
						}

					}

					if (entity.EdCourseExpDtlCollection.Count > 0 || entity.EdCourseExpDtlCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdCourseExpDtlProvider.Save(transactionManager, entity.EdCourseExpDtlCollection);
						
						deepHandles.Add("EdCourseExpDtlCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdCourseExpDtl >) DataRepository.EdCourseExpDtlProvider.DeepSave,
							new object[] { transactionManager, entity.EdCourseExpDtlCollection, deepSaveType, childTypes, innerList }
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
						if(child.EdCodeMaxGradIdSource != null)
						{
							child.EdCodeMaxGradId = child.EdCodeMaxGradIdSource.EdCodeGradingId;
						}
						else
						{
							child.EdCodeMaxGradId = entity.EdCodeGradingId;
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
				
	
			#region List<EdStdCrsExam>
				if (CanDeepSave(entity.EdStdCrsExamCollectionGetByEdCodeGradingOldId, "List<EdStdCrsExam>|EdStdCrsExamCollectionGetByEdCodeGradingOldId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStdCrsExam child in entity.EdStdCrsExamCollectionGetByEdCodeGradingOldId)
					{
						if(child.EdCodeGradingOldIdSource != null)
						{
							child.EdCodeGradingOldId = child.EdCodeGradingOldIdSource.EdCodeGradingId;
						}
						else
						{
							child.EdCodeGradingOldId = entity.EdCodeGradingId;
						}

					}

					if (entity.EdStdCrsExamCollectionGetByEdCodeGradingOldId.Count > 0 || entity.EdStdCrsExamCollectionGetByEdCodeGradingOldId.DeletedItems.Count > 0)
					{
						//DataRepository.EdStdCrsExamProvider.Save(transactionManager, entity.EdStdCrsExamCollectionGetByEdCodeGradingOldId);
						
						deepHandles.Add("EdStdCrsExamCollectionGetByEdCodeGradingOldId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStdCrsExam >) DataRepository.EdStdCrsExamProvider.DeepSave,
							new object[] { transactionManager, entity.EdStdCrsExamCollectionGetByEdCodeGradingOldId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudCourseGrdChng>
				if (CanDeepSave(entity.EdStudCourseGrdChngCollectionGetByEdCodeGradingNewId, "List<EdStudCourseGrdChng>|EdStudCourseGrdChngCollectionGetByEdCodeGradingNewId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudCourseGrdChng child in entity.EdStudCourseGrdChngCollectionGetByEdCodeGradingNewId)
					{
						if(child.EdCodeGradingNewIdSource != null)
						{
							child.EdCodeGradingNewId = child.EdCodeGradingNewIdSource.EdCodeGradingId;
						}
						else
						{
							child.EdCodeGradingNewId = entity.EdCodeGradingId;
						}

					}

					if (entity.EdStudCourseGrdChngCollectionGetByEdCodeGradingNewId.Count > 0 || entity.EdStudCourseGrdChngCollectionGetByEdCodeGradingNewId.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudCourseGrdChngProvider.Save(transactionManager, entity.EdStudCourseGrdChngCollectionGetByEdCodeGradingNewId);
						
						deepHandles.Add("EdStudCourseGrdChngCollectionGetByEdCodeGradingNewId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudCourseGrdChng >) DataRepository.EdStudCourseGrdChngProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCourseGrdChngCollectionGetByEdCodeGradingNewId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStdExamSemester>
				if (CanDeepSave(entity.EdStdExamSemesterCollection, "List<EdStdExamSemester>|EdStdExamSemesterCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStdExamSemester child in entity.EdStdExamSemesterCollection)
					{
						if(child.EdCodeGradingIdSource != null)
						{
							child.EdCodeGradingId = child.EdCodeGradingIdSource.EdCodeGradingId;
						}
						else
						{
							child.EdCodeGradingId = entity.EdCodeGradingId;
						}

					}

					if (entity.EdStdExamSemesterCollection.Count > 0 || entity.EdStdExamSemesterCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStdExamSemesterProvider.Save(transactionManager, entity.EdStdExamSemesterCollection);
						
						deepHandles.Add("EdStdExamSemesterCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStdExamSemester >) DataRepository.EdStdExamSemesterProvider.DeepSave,
							new object[] { transactionManager, entity.EdStdExamSemesterCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStdCrsExam>
				if (CanDeepSave(entity.EdStdCrsExamCollectionGetByEdCodeGradingNewId, "List<EdStdCrsExam>|EdStdCrsExamCollectionGetByEdCodeGradingNewId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStdCrsExam child in entity.EdStdCrsExamCollectionGetByEdCodeGradingNewId)
					{
						if(child.EdCodeGradingNewIdSource != null)
						{
							child.EdCodeGradingNewId = child.EdCodeGradingNewIdSource.EdCodeGradingId;
						}
						else
						{
							child.EdCodeGradingNewId = entity.EdCodeGradingId;
						}

					}

					if (entity.EdStdCrsExamCollectionGetByEdCodeGradingNewId.Count > 0 || entity.EdStdCrsExamCollectionGetByEdCodeGradingNewId.DeletedItems.Count > 0)
					{
						//DataRepository.EdStdCrsExamProvider.Save(transactionManager, entity.EdStdCrsExamCollectionGetByEdCodeGradingNewId);
						
						deepHandles.Add("EdStdCrsExamCollectionGetByEdCodeGradingNewId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStdCrsExam >) DataRepository.EdStdCrsExamProvider.DeepSave,
							new object[] { transactionManager, entity.EdStdCrsExamCollectionGetByEdCodeGradingNewId, deepSaveType, childTypes, innerList }
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
						if(child.EdCodeGradingIdSource != null)
						{
							child.EdCodeGradingId = child.EdCodeGradingIdSource.EdCodeGradingId;
						}
						else
						{
							child.EdCodeGradingId = entity.EdCodeGradingId;
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
				
	
			#region List<EntPolicyCourseRepeat>
				if (CanDeepSave(entity.EntPolicyCourseRepeatCollectionGetByEdCodeGradingId, "List<EntPolicyCourseRepeat>|EntPolicyCourseRepeatCollectionGetByEdCodeGradingId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntPolicyCourseRepeat child in entity.EntPolicyCourseRepeatCollectionGetByEdCodeGradingId)
					{
						if(child.EdCodeGradingIdSource != null)
						{
							child.EdCodeGradingId = child.EdCodeGradingIdSource.EdCodeGradingId;
						}
						else
						{
							child.EdCodeGradingId = entity.EdCodeGradingId;
						}

					}

					if (entity.EntPolicyCourseRepeatCollectionGetByEdCodeGradingId.Count > 0 || entity.EntPolicyCourseRepeatCollectionGetByEdCodeGradingId.DeletedItems.Count > 0)
					{
						//DataRepository.EntPolicyCourseRepeatProvider.Save(transactionManager, entity.EntPolicyCourseRepeatCollectionGetByEdCodeGradingId);
						
						deepHandles.Add("EntPolicyCourseRepeatCollectionGetByEdCodeGradingId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntPolicyCourseRepeat >) DataRepository.EntPolicyCourseRepeatProvider.DeepSave,
							new object[] { transactionManager, entity.EntPolicyCourseRepeatCollectionGetByEdCodeGradingId, deepSaveType, childTypes, innerList }
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
						if(child.EdCodeGradingIdSource != null)
						{
							child.EdCodeGradingId = child.EdCodeGradingIdSource.EdCodeGradingId;
						}
						else
						{
							child.EdCodeGradingId = entity.EdCodeGradingId;
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
				
	
			#region List<EdStudFaculty>
				if (CanDeepSave(entity.EdStudFacultyCollection, "List<EdStudFaculty>|EdStudFacultyCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudFaculty child in entity.EdStudFacultyCollection)
					{
						if(child.EdCodeGradingIdSource != null)
						{
							child.EdCodeGradingId = child.EdCodeGradingIdSource.EdCodeGradingId;
						}
						else
						{
							child.EdCodeGradingId = entity.EdCodeGradingId;
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
				
	
			#region List<EntPolicyGradingDtl>
				if (CanDeepSave(entity.EntPolicyGradingDtlCollection, "List<EntPolicyGradingDtl>|EntPolicyGradingDtlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntPolicyGradingDtl child in entity.EntPolicyGradingDtlCollection)
					{
						if(child.EdCodeGradingIdSource != null)
						{
							child.EdCodeGradingId = child.EdCodeGradingIdSource.EdCodeGradingId;
						}
						else
						{
							child.EdCodeGradingId = entity.EdCodeGradingId;
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
				
	
			#region List<PgThesisGrantStud>
				if (CanDeepSave(entity.PgThesisGrantStudCollection, "List<PgThesisGrantStud>|PgThesisGrantStudCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgThesisGrantStud child in entity.PgThesisGrantStudCollection)
					{
						if(child.EdCodeGradingIdSource != null)
						{
							child.EdCodeGradingId = child.EdCodeGradingIdSource.EdCodeGradingId;
						}
						else
						{
							child.EdCodeGradingId = entity.EdCodeGradingId;
						}

					}

					if (entity.PgThesisGrantStudCollection.Count > 0 || entity.PgThesisGrantStudCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgThesisGrantStudProvider.Save(transactionManager, entity.PgThesisGrantStudCollection);
						
						deepHandles.Add("PgThesisGrantStudCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgThesisGrantStud >) DataRepository.PgThesisGrantStudProvider.DeepSave,
							new object[] { transactionManager, entity.PgThesisGrantStudCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudCourseGrdChng>
				if (CanDeepSave(entity.EdStudCourseGrdChngCollectionGetByEdCodeGradingOldId, "List<EdStudCourseGrdChng>|EdStudCourseGrdChngCollectionGetByEdCodeGradingOldId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudCourseGrdChng child in entity.EdStudCourseGrdChngCollectionGetByEdCodeGradingOldId)
					{
						if(child.EdCodeGradingOldIdSource != null)
						{
							child.EdCodeGradingOldId = child.EdCodeGradingOldIdSource.EdCodeGradingId;
						}
						else
						{
							child.EdCodeGradingOldId = entity.EdCodeGradingId;
						}

					}

					if (entity.EdStudCourseGrdChngCollectionGetByEdCodeGradingOldId.Count > 0 || entity.EdStudCourseGrdChngCollectionGetByEdCodeGradingOldId.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudCourseGrdChngProvider.Save(transactionManager, entity.EdStudCourseGrdChngCollectionGetByEdCodeGradingOldId);
						
						deepHandles.Add("EdStudCourseGrdChngCollectionGetByEdCodeGradingOldId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudCourseGrdChng >) DataRepository.EdStudCourseGrdChngProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCourseGrdChngCollectionGetByEdCodeGradingOldId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudSemesterExt>
				if (CanDeepSave(entity.EdStudSemesterExtCollectionGetByEdCodeAccumGradingId, "List<EdStudSemesterExt>|EdStudSemesterExtCollectionGetByEdCodeAccumGradingId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudSemesterExt child in entity.EdStudSemesterExtCollectionGetByEdCodeAccumGradingId)
					{
						if(child.EdCodeAccumGradingIdSource != null)
						{
							child.EdCodeAccumGradingId = child.EdCodeAccumGradingIdSource.EdCodeGradingId;
						}
						else
						{
							child.EdCodeAccumGradingId = entity.EdCodeGradingId;
						}

					}

					if (entity.EdStudSemesterExtCollectionGetByEdCodeAccumGradingId.Count > 0 || entity.EdStudSemesterExtCollectionGetByEdCodeAccumGradingId.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudSemesterExtProvider.Save(transactionManager, entity.EdStudSemesterExtCollectionGetByEdCodeAccumGradingId);
						
						deepHandles.Add("EdStudSemesterExtCollectionGetByEdCodeAccumGradingId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudSemesterExt >) DataRepository.EdStudSemesterExtProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudSemesterExtCollectionGetByEdCodeAccumGradingId, deepSaveType, childTypes, innerList }
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
						if(child.EdCodeGradingIdSource != null)
						{
							child.EdCodeGradingId = child.EdCodeGradingIdSource.EdCodeGradingId;
						}
						else
						{
							child.EdCodeGradingId = entity.EdCodeGradingId;
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
				
	
			#region List<EntPolicyCourseRepeat>
				if (CanDeepSave(entity.EntPolicyCourseRepeatCollectionGetByGradingMoreThanOneId, "List<EntPolicyCourseRepeat>|EntPolicyCourseRepeatCollectionGetByGradingMoreThanOneId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntPolicyCourseRepeat child in entity.EntPolicyCourseRepeatCollectionGetByGradingMoreThanOneId)
					{
						if(child.GradingMoreThanOneIdSource != null)
						{
							child.GradingMoreThanOneId = child.GradingMoreThanOneIdSource.EdCodeGradingId;
						}
						else
						{
							child.GradingMoreThanOneId = entity.EdCodeGradingId;
						}

					}

					if (entity.EntPolicyCourseRepeatCollectionGetByGradingMoreThanOneId.Count > 0 || entity.EntPolicyCourseRepeatCollectionGetByGradingMoreThanOneId.DeletedItems.Count > 0)
					{
						//DataRepository.EntPolicyCourseRepeatProvider.Save(transactionManager, entity.EntPolicyCourseRepeatCollectionGetByGradingMoreThanOneId);
						
						deepHandles.Add("EntPolicyCourseRepeatCollectionGetByGradingMoreThanOneId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntPolicyCourseRepeat >) DataRepository.EntPolicyCourseRepeatProvider.DeepSave,
							new object[] { transactionManager, entity.EntPolicyCourseRepeatCollectionGetByGradingMoreThanOneId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntCourseMdData>
				if (CanDeepSave(entity.EntCourseMdDataCollection, "List<EntCourseMdData>|EntCourseMdDataCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntCourseMdData child in entity.EntCourseMdDataCollection)
					{
						if(child.EdCodeGradingIdSource != null)
						{
							child.EdCodeGradingId = child.EdCodeGradingIdSource.EdCodeGradingId;
						}
						else
						{
							child.EdCodeGradingId = entity.EdCodeGradingId;
						}

					}

					if (entity.EntCourseMdDataCollection.Count > 0 || entity.EntCourseMdDataCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EntCourseMdDataProvider.Save(transactionManager, entity.EntCourseMdDataCollection);
						
						deepHandles.Add("EntCourseMdDataCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntCourseMdData >) DataRepository.EntCourseMdDataProvider.DeepSave,
							new object[] { transactionManager, entity.EntCourseMdDataCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudCourseRegAdd>
				if (CanDeepSave(entity.EdStudCourseRegAddCollectionGetByFinalEdCodeGradingId, "List<EdStudCourseRegAdd>|EdStudCourseRegAddCollectionGetByFinalEdCodeGradingId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudCourseRegAdd child in entity.EdStudCourseRegAddCollectionGetByFinalEdCodeGradingId)
					{
						if(child.FinalEdCodeGradingIdSource != null)
						{
							child.FinalEdCodeGradingId = child.FinalEdCodeGradingIdSource.EdCodeGradingId;
						}
						else
						{
							child.FinalEdCodeGradingId = entity.EdCodeGradingId;
						}

					}

					if (entity.EdStudCourseRegAddCollectionGetByFinalEdCodeGradingId.Count > 0 || entity.EdStudCourseRegAddCollectionGetByFinalEdCodeGradingId.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudCourseRegAddProvider.Save(transactionManager, entity.EdStudCourseRegAddCollectionGetByFinalEdCodeGradingId);
						
						deepHandles.Add("EdStudCourseRegAddCollectionGetByFinalEdCodeGradingId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudCourseRegAdd >) DataRepository.EdStudCourseRegAddProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCourseRegAddCollectionGetByFinalEdCodeGradingId, deepSaveType, childTypes, innerList }
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
	
	#region EdCodeGradingChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdCodeGrading</c>
	///</summary>
	public enum EdCodeGradingChildEntityTypes
	{
		///<summary>
		/// Collection of <c>EdCodeGrading</c> as OneToMany for EdStudIntTrnsCourseFromCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudIntTrnsCourseFrom>))]
		EdStudIntTrnsCourseFromCollection,
		///<summary>
		/// Collection of <c>EdCodeGrading</c> as OneToMany for AdmAppTransToCourseCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppTransToCourse>))]
		AdmAppTransToCourseCollection,
		///<summary>
		/// Collection of <c>EdCodeGrading</c> as OneToMany for EntPolicyCourseRepeatCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntPolicyCourseRepeat>))]
		EntPolicyCourseRepeatCollectionGetByEdCodeMinGradId,
		///<summary>
		/// Collection of <c>EdCodeGrading</c> as OneToMany for EdStudCourseRegAddCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCourseRegAdd>))]
		EdStudCourseRegAddCollectionGetByActualEdCodeGradingId,
		///<summary>
		/// Collection of <c>EdCodeGrading</c> as OneToMany for PgThesisStudCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgThesisStud>))]
		PgThesisStudCollection,
		///<summary>
		/// Collection of <c>EdCodeGrading</c> as OneToMany for EntPolicyAccumHonorCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntPolicyAccumHonor>))]
		EntPolicyAccumHonorCollection,
		///<summary>
		/// Collection of <c>EdCodeGrading</c> as OneToMany for EdStudSemesterExtCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudSemesterExt>))]
		EdStudSemesterExtCollectionGetByEdCodeGradingId,
		///<summary>
		/// Collection of <c>EdCodeGrading</c> as OneToMany for EdCourseExpDtlCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdCourseExpDtl>))]
		EdCourseExpDtlCollection,
		///<summary>
		/// Collection of <c>EdCodeGrading</c> as OneToMany for EntPolcyGrdngHdrCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntPolcyGrdngHdr>))]
		EntPolcyGrdngHdrCollection,
		///<summary>
		/// Collection of <c>EdCodeGrading</c> as OneToMany for EdStdCrsExamCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStdCrsExam>))]
		EdStdCrsExamCollectionGetByEdCodeGradingOldId,
		///<summary>
		/// Collection of <c>EdCodeGrading</c> as OneToMany for EdStudCourseGrdChngCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCourseGrdChng>))]
		EdStudCourseGrdChngCollectionGetByEdCodeGradingNewId,
		///<summary>
		/// Collection of <c>EdCodeGrading</c> as OneToMany for EdStdExamSemesterCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStdExamSemester>))]
		EdStdExamSemesterCollection,
		///<summary>
		/// Collection of <c>EdCodeGrading</c> as OneToMany for EdStdCrsExamCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStdCrsExam>))]
		EdStdCrsExamCollectionGetByEdCodeGradingNewId,
		///<summary>
		/// Collection of <c>EdCodeGrading</c> as OneToMany for EdStudCourseRegCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCourseReg>))]
		EdStudCourseRegCollection,
		///<summary>
		/// Collection of <c>EdCodeGrading</c> as OneToMany for EntPolicyCourseRepeatCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntPolicyCourseRepeat>))]
		EntPolicyCourseRepeatCollectionGetByEdCodeGradingId,
		///<summary>
		/// Collection of <c>EdCodeGrading</c> as OneToMany for EdStudIntTrnsCourseToCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudIntTrnsCourseTo>))]
		EdStudIntTrnsCourseToCollection,
		///<summary>
		/// Collection of <c>EdCodeGrading</c> as OneToMany for EdStudFacultyCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudFaculty>))]
		EdStudFacultyCollection,
		///<summary>
		/// Collection of <c>EdCodeGrading</c> as OneToMany for EntPolicyGradingDtlCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntPolicyGradingDtl>))]
		EntPolicyGradingDtlCollection,
		///<summary>
		/// Collection of <c>EdCodeGrading</c> as OneToMany for PgThesisGrantStudCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgThesisGrantStud>))]
		PgThesisGrantStudCollection,
		///<summary>
		/// Collection of <c>EdCodeGrading</c> as OneToMany for EdStudCourseGrdChngCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCourseGrdChng>))]
		EdStudCourseGrdChngCollectionGetByEdCodeGradingOldId,
		///<summary>
		/// Collection of <c>EdCodeGrading</c> as OneToMany for EdStudSemesterExtCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudSemesterExt>))]
		EdStudSemesterExtCollectionGetByEdCodeAccumGradingId,
		///<summary>
		/// Collection of <c>EdCodeGrading</c> as OneToMany for EdStudCourseRegTempCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCourseRegTemp>))]
		EdStudCourseRegTempCollection,
		///<summary>
		/// Collection of <c>EdCodeGrading</c> as OneToMany for EntPolicyCourseRepeatCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntPolicyCourseRepeat>))]
		EntPolicyCourseRepeatCollectionGetByGradingMoreThanOneId,
		///<summary>
		/// Collection of <c>EdCodeGrading</c> as OneToMany for EntCourseMdDataCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntCourseMdData>))]
		EntCourseMdDataCollection,
		///<summary>
		/// Collection of <c>EdCodeGrading</c> as OneToMany for EdStudCourseRegAddCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCourseRegAdd>))]
		EdStudCourseRegAddCollectionGetByFinalEdCodeGradingId,
	}
	
	#endregion EdCodeGradingChildEntityTypes
	
	#region EdCodeGradingFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdCodeGradingColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeGrading"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCodeGradingFilterBuilder : SqlFilterBuilder<EdCodeGradingColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeGradingFilterBuilder class.
		/// </summary>
		public EdCodeGradingFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCodeGradingFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCodeGradingFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCodeGradingFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCodeGradingFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCodeGradingFilterBuilder
	
	#region EdCodeGradingParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdCodeGradingColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeGrading"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCodeGradingParameterBuilder : ParameterizedSqlFilterBuilder<EdCodeGradingColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeGradingParameterBuilder class.
		/// </summary>
		public EdCodeGradingParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCodeGradingParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCodeGradingParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCodeGradingParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCodeGradingParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCodeGradingParameterBuilder
	
	#region EdCodeGradingSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdCodeGradingColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeGrading"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdCodeGradingSortBuilder : SqlSortBuilder<EdCodeGradingColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeGradingSqlSortBuilder class.
		/// </summary>
		public EdCodeGradingSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdCodeGradingSortBuilder
	
} // end namespace
