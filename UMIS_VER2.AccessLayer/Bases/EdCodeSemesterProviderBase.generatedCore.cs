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
	/// This class is the base class for any <see cref="EdCodeSemesterProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdCodeSemesterProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdCodeSemester, UMIS_VER2.BusinessLyer.EdCodeSemesterKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeSemesterKey key)
		{
			return Delete(transactionManager, key.EdCodeSemesterId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edCodeSemesterId)
		{
			return Delete(null, _edCodeSemesterId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edCodeSemesterId);		
		
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
		public override UMIS_VER2.BusinessLyer.EdCodeSemester Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeSemesterKey key, int start, int pageLength)
		{
			return GetByEdCodeSemesterId(transactionManager, key.EdCodeSemesterId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_ED_CODE_SEMESTER_TYP_1 index.
		/// </summary>
		/// <param name="_edCodeSemesterTypeId">نوع الفصل</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdCodeSemester&gt;"/> class.</returns>
		public TList<EdCodeSemester> GetByEdCodeSemesterTypeId(System.Decimal? _edCodeSemesterTypeId)
		{
			int count = -1;
			return GetByEdCodeSemesterTypeId(null,_edCodeSemesterTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_SEMESTER_TYP_1 index.
		/// </summary>
		/// <param name="_edCodeSemesterTypeId">نوع الفصل</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdCodeSemester&gt;"/> class.</returns>
		public TList<EdCodeSemester> GetByEdCodeSemesterTypeId(System.Decimal? _edCodeSemesterTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterTypeId(null, _edCodeSemesterTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_SEMESTER_TYP_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterTypeId">نوع الفصل</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdCodeSemester&gt;"/> class.</returns>
		public TList<EdCodeSemester> GetByEdCodeSemesterTypeId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterTypeId)
		{
			int count = -1;
			return GetByEdCodeSemesterTypeId(transactionManager, _edCodeSemesterTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_SEMESTER_TYP_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterTypeId">نوع الفصل</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdCodeSemester&gt;"/> class.</returns>
		public TList<EdCodeSemester> GetByEdCodeSemesterTypeId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterTypeId(transactionManager, _edCodeSemesterTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_SEMESTER_TYP_1 index.
		/// </summary>
		/// <param name="_edCodeSemesterTypeId">نوع الفصل</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdCodeSemester&gt;"/> class.</returns>
		public TList<EdCodeSemester> GetByEdCodeSemesterTypeId(System.Decimal? _edCodeSemesterTypeId, int start, int pageLength, out int count)
		{
			return GetByEdCodeSemesterTypeId(null, _edCodeSemesterTypeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_ED_CODE_SEMESTER_TYP_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterTypeId">نوع الفصل</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdCodeSemester&gt;"/> class.</returns>
		public abstract TList<EdCodeSemester> GetByEdCodeSemesterTypeId(TransactionManager transactionManager, System.Decimal? _edCodeSemesterTypeId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_CODE_SEMESTER index.
		/// </summary>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeSemester"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeSemester GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(null,_edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_SEMESTER index.
		/// </summary>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeSemester"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeSemester GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_SEMESTER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeSemester"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeSemester GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_SEMESTER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeSemester"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeSemester GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeSemesterId(transactionManager, _edCodeSemesterId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_SEMESTER index.
		/// </summary>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeSemester"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeSemester GetByEdCodeSemesterId(System.Decimal _edCodeSemesterId, int start, int pageLength, out int count)
		{
			return GetByEdCodeSemesterId(null, _edCodeSemesterId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_SEMESTER index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeSemesterId">مسلسل الفصل الدراسي</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeSemester"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdCodeSemester GetByEdCodeSemesterId(TransactionManager transactionManager, System.Decimal _edCodeSemesterId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdCodeSemester&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdCodeSemester&gt;"/></returns>
		public static TList<EdCodeSemester> Fill(IDataReader reader, TList<EdCodeSemester> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdCodeSemester c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdCodeSemester")
					.Append("|").Append((System.Decimal)reader["ED_CODE_SEMESTER_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdCodeSemester>(
					key.ToString(), // EntityTrackingKey
					"EdCodeSemester",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdCodeSemester();
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
					c.EdCodeSemesterId = (System.Decimal)reader["ED_CODE_SEMESTER_ID"];
					c.OriginalEdCodeSemesterId = c.EdCodeSemesterId;
					c.DescrAr = (System.String)reader["DESCR_AR"];
					c.DescrEn = Convert.IsDBNull(reader["DESCR_EN"]) ? null : (System.String)reader["DESCR_EN"];
					c.SemesterOrder = (System.Decimal)reader["SEMESTER_ORDER"];
					c.EdCodeSemesterTypeId = Convert.IsDBNull(reader["ED_CODE_SEMESTER_TYPE_ID"]) ? null : (System.Decimal?)reader["ED_CODE_SEMESTER_TYPE_ID"];
					c.PeriodWeek = Convert.IsDBNull(reader["PERIOD_WEEK"]) ? null : (System.Decimal?)reader["PERIOD_WEEK"];
					c.HideFlg = Convert.IsDBNull(reader["HIDE_FLG"]) ? null : (System.Decimal?)reader["HIDE_FLG"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCodeSemester"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeSemester"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdCodeSemester entity)
		{
			if (!reader.Read()) return;
			
			entity.EdCodeSemesterId = (System.Decimal)reader[((int)EdCodeSemesterColumn.EdCodeSemesterId - 1)];
			entity.OriginalEdCodeSemesterId = (System.Decimal)reader["ED_CODE_SEMESTER_ID"];
			entity.DescrAr = (System.String)reader[((int)EdCodeSemesterColumn.DescrAr - 1)];
			entity.DescrEn = (reader.IsDBNull(((int)EdCodeSemesterColumn.DescrEn - 1)))?null:(System.String)reader[((int)EdCodeSemesterColumn.DescrEn - 1)];
			entity.SemesterOrder = (System.Decimal)reader[((int)EdCodeSemesterColumn.SemesterOrder - 1)];
			entity.EdCodeSemesterTypeId = (reader.IsDBNull(((int)EdCodeSemesterColumn.EdCodeSemesterTypeId - 1)))?null:(System.Decimal?)reader[((int)EdCodeSemesterColumn.EdCodeSemesterTypeId - 1)];
			entity.PeriodWeek = (reader.IsDBNull(((int)EdCodeSemesterColumn.PeriodWeek - 1)))?null:(System.Decimal?)reader[((int)EdCodeSemesterColumn.PeriodWeek - 1)];
			entity.HideFlg = (reader.IsDBNull(((int)EdCodeSemesterColumn.HideFlg - 1)))?null:(System.Decimal?)reader[((int)EdCodeSemesterColumn.HideFlg - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCodeSemester"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeSemester"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdCodeSemester entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdCodeSemesterId = (System.Decimal)dataRow["ED_CODE_SEMESTER_ID"];
			entity.OriginalEdCodeSemesterId = (System.Decimal)dataRow["ED_CODE_SEMESTER_ID"];
			entity.DescrAr = (System.String)dataRow["DESCR_AR"];
			entity.DescrEn = Convert.IsDBNull(dataRow["DESCR_EN"]) ? null : (System.String)dataRow["DESCR_EN"];
			entity.SemesterOrder = (System.Decimal)dataRow["SEMESTER_ORDER"];
			entity.EdCodeSemesterTypeId = Convert.IsDBNull(dataRow["ED_CODE_SEMESTER_TYPE_ID"]) ? null : (System.Decimal?)dataRow["ED_CODE_SEMESTER_TYPE_ID"];
			entity.PeriodWeek = Convert.IsDBNull(dataRow["PERIOD_WEEK"]) ? null : (System.Decimal?)dataRow["PERIOD_WEEK"];
			entity.HideFlg = Convert.IsDBNull(dataRow["HIDE_FLG"]) ? null : (System.Decimal?)dataRow["HIDE_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeSemester"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCodeSemester Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeSemester entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdCodeSemesterTypeIdSource	
			if (CanDeepLoad(entity, "EdCodeSemesterType|EdCodeSemesterTypeIdSource", deepLoadType, innerList) 
				&& entity.EdCodeSemesterTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdCodeSemesterTypeId ?? 0.0m);
				EdCodeSemesterType tmpEntity = EntityManager.LocateEntity<EdCodeSemesterType>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeSemesterType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeSemesterTypeIdSource = tmpEntity;
				else
					entity.EdCodeSemesterTypeIdSource = DataRepository.EdCodeSemesterTypeProvider.GetByEdCodeSemesterTypeId(transactionManager, (entity.EdCodeSemesterTypeId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeSemesterTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeSemesterTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeSemesterTypeProvider.DeepLoad(transactionManager, entity.EdCodeSemesterTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeSemesterTypeIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEdCodeSemesterId methods when available
			
			#region EdStudFacultyCollectionGetByEdCodeSemesterJoinId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudFaculty>|EdStudFacultyCollectionGetByEdCodeSemesterJoinId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudFacultyCollectionGetByEdCodeSemesterJoinId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudFacultyCollectionGetByEdCodeSemesterJoinId = DataRepository.EdStudFacultyProvider.GetByEdCodeSemesterJoinId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.EdStudFacultyCollectionGetByEdCodeSemesterJoinId.Count > 0)
				{
					deepHandles.Add("EdStudFacultyCollectionGetByEdCodeSemesterJoinId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudFaculty>) DataRepository.EdStudFacultyProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudFacultyCollectionGetByEdCodeSemesterJoinId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region TrnsLineCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<TrnsLine>|TrnsLineCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'TrnsLineCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.TrnsLineCollection = DataRepository.TrnsLineProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.TrnsLineCollection.Count > 0)
				{
					deepHandles.Add("TrnsLineCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<TrnsLine>) DataRepository.TrnsLineProvider.DeepLoad,
						new object[] { transactionManager, entity.TrnsLineCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudTransCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudTrans>|EdStudTransCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudTransCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudTransCollection = DataRepository.EdStudTransProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.EdStudTransCollection.Count > 0)
				{
					deepHandles.Add("EdStudTransCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudTrans>) DataRepository.EdStudTransProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudTransCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region WfCrsRsltApproveCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<WfCrsRsltApprove>|WfCrsRsltApproveCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'WfCrsRsltApproveCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.WfCrsRsltApproveCollection = DataRepository.WfCrsRsltApproveProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.WfCrsRsltApproveCollection.Count > 0)
				{
					deepHandles.Add("WfCrsRsltApproveCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<WfCrsRsltApprove>) DataRepository.WfCrsRsltApproveProvider.DeepLoad,
						new object[] { transactionManager, entity.WfCrsRsltApproveCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SpoSponsorOfferCollectionGetByEdCodeSemesterToId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SpoSponsorOffer>|SpoSponsorOfferCollectionGetByEdCodeSemesterToId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SpoSponsorOfferCollectionGetByEdCodeSemesterToId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SpoSponsorOfferCollectionGetByEdCodeSemesterToId = DataRepository.SpoSponsorOfferProvider.GetByEdCodeSemesterToId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.SpoSponsorOfferCollectionGetByEdCodeSemesterToId.Count > 0)
				{
					deepHandles.Add("SpoSponsorOfferCollectionGetByEdCodeSemesterToId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SpoSponsorOffer>) DataRepository.SpoSponsorOfferProvider.DeepLoad,
						new object[] { transactionManager, entity.SpoSponsorOfferCollectionGetByEdCodeSemesterToId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudCourseRegPreCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudCourseRegPre>|EdStudCourseRegPreCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudCourseRegPreCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudCourseRegPreCollection = DataRepository.EdStudCourseRegPreProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.EdStudCourseRegPreCollection.Count > 0)
				{
					deepHandles.Add("EdStudCourseRegPreCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudCourseRegPre>) DataRepository.EdStudCourseRegPreProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudCourseRegPreCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeStudNatSimilarityRequestCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeStudNatSimilarityRequest>|FeeStudNatSimilarityRequestCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudNatSimilarityRequestCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeStudNatSimilarityRequestCollection = DataRepository.FeeStudNatSimilarityRequestProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.FeeStudNatSimilarityRequestCollection.Count > 0)
				{
					deepHandles.Add("FeeStudNatSimilarityRequestCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudNatSimilarityRequest>) DataRepository.FeeStudNatSimilarityRequestProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudNatSimilarityRequestCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmOpenAcadSemesterCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmOpenAcadSemester>|AdmOpenAcadSemesterCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmOpenAcadSemesterCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmOpenAcadSemesterCollection = DataRepository.AdmOpenAcadSemesterProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.AdmOpenAcadSemesterCollection.Count > 0)
				{
					deepHandles.Add("AdmOpenAcadSemesterCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmOpenAcadSemester>) DataRepository.AdmOpenAcadSemesterProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmOpenAcadSemesterCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.EdGraduationAwardCollection = DataRepository.EdGraduationAwardProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.EdGraduationAwardCollection.Count > 0)
				{
					deepHandles.Add("EdGraduationAwardCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdGraduationAward>) DataRepository.EdGraduationAwardProvider.DeepLoad,
						new object[] { transactionManager, entity.EdGraduationAwardCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AccomWfRequestApproveCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AccomWfRequestApprove>|AccomWfRequestApproveCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AccomWfRequestApproveCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AccomWfRequestApproveCollection = DataRepository.AccomWfRequestApproveProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.AccomWfRequestApproveCollection.Count > 0)
				{
					deepHandles.Add("AccomWfRequestApproveCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AccomWfRequestApprove>) DataRepository.AccomWfRequestApproveProvider.DeepLoad,
						new object[] { transactionManager, entity.AccomWfRequestApproveCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region ScStudGroupCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ScStudGroup>|ScStudGroupCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScStudGroupCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ScStudGroupCollection = DataRepository.ScStudGroupProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.ScStudGroupCollection.Count > 0)
				{
					deepHandles.Add("ScStudGroupCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScStudGroup>) DataRepository.ScStudGroupProvider.DeepLoad,
						new object[] { transactionManager, entity.ScStudGroupCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdProjectCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdProject>|EdProjectCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdProjectCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdProjectCollection = DataRepository.EdProjectProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.EdProjectCollection.Count > 0)
				{
					deepHandles.Add("EdProjectCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdProject>) DataRepository.EdProjectProvider.DeepLoad,
						new object[] { transactionManager, entity.EdProjectCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region RsrchStudRegisterCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<RsrchStudRegister>|RsrchStudRegisterCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'RsrchStudRegisterCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.RsrchStudRegisterCollection = DataRepository.RsrchStudRegisterProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.RsrchStudRegisterCollection.Count > 0)
				{
					deepHandles.Add("RsrchStudRegisterCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<RsrchStudRegister>) DataRepository.RsrchStudRegisterProvider.DeepLoad,
						new object[] { transactionManager, entity.RsrchStudRegisterCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdCourseOutcomesTopicsCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdCourseOutcomesTopics>|EdCourseOutcomesTopicsCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCourseOutcomesTopicsCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdCourseOutcomesTopicsCollection = DataRepository.EdCourseOutcomesTopicsProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.EdCourseOutcomesTopicsCollection.Count > 0)
				{
					deepHandles.Add("EdCourseOutcomesTopicsCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdCourseOutcomesTopics>) DataRepository.EdCourseOutcomesTopicsProvider.DeepLoad,
						new object[] { transactionManager, entity.EdCourseOutcomesTopicsCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SvStudAskAdvCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvStudAskAdv>|SvStudAskAdvCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvStudAskAdvCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvStudAskAdvCollection = DataRepository.SvStudAskAdvProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.SvStudAskAdvCollection.Count > 0)
				{
					deepHandles.Add("SvStudAskAdvCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvStudAskAdv>) DataRepository.SvStudAskAdvProvider.DeepLoad,
						new object[] { transactionManager, entity.SvStudAskAdvCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdCourseTchngCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdCourseTchng>|EdCourseTchngCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCourseTchngCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdCourseTchngCollection = DataRepository.EdCourseTchngProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.EdCourseTchngCollection.Count > 0)
				{
					deepHandles.Add("EdCourseTchngCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdCourseTchng>) DataRepository.EdCourseTchngProvider.DeepLoad,
						new object[] { transactionManager, entity.EdCourseTchngCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntMajorPhaseCollectionGetByEdCodeSemesterFromId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntMajorPhase>|EntMajorPhaseCollectionGetByEdCodeSemesterFromId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntMajorPhaseCollectionGetByEdCodeSemesterFromId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntMajorPhaseCollectionGetByEdCodeSemesterFromId = DataRepository.EntMajorPhaseProvider.GetByEdCodeSemesterFromId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.EntMajorPhaseCollectionGetByEdCodeSemesterFromId.Count > 0)
				{
					deepHandles.Add("EntMajorPhaseCollectionGetByEdCodeSemesterFromId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntMajorPhase>) DataRepository.EntMajorPhaseProvider.DeepLoad,
						new object[] { transactionManager, entity.EntMajorPhaseCollectionGetByEdCodeSemesterFromId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdExamSchdlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdExamSchdl>|EdExamSchdlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdExamSchdlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdExamSchdlCollection = DataRepository.EdExamSchdlProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.EdExamSchdlCollection.Count > 0)
				{
					deepHandles.Add("EdExamSchdlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdExamSchdl>) DataRepository.EdExamSchdlProvider.DeepLoad,
						new object[] { transactionManager, entity.EdExamSchdlCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region CoControlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<CoControl>|CoControlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CoControlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.CoControlCollection = DataRepository.CoControlProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.CoControlCollection.Count > 0)
				{
					deepHandles.Add("CoControlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CoControl>) DataRepository.CoControlProvider.DeepLoad,
						new object[] { transactionManager, entity.CoControlCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudAcadWarnCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudAcadWarn>|EdStudAcadWarnCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudAcadWarnCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudAcadWarnCollection = DataRepository.EdStudAcadWarnProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.EdStudAcadWarnCollection.Count > 0)
				{
					deepHandles.Add("EdStudAcadWarnCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudAcadWarn>) DataRepository.EdStudAcadWarnProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudAcadWarnCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SpoSponsorStudCollectionGetByEdCodeSemesterToId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SpoSponsorStud>|SpoSponsorStudCollectionGetByEdCodeSemesterToId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SpoSponsorStudCollectionGetByEdCodeSemesterToId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SpoSponsorStudCollectionGetByEdCodeSemesterToId = DataRepository.SpoSponsorStudProvider.GetByEdCodeSemesterToId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.SpoSponsorStudCollectionGetByEdCodeSemesterToId.Count > 0)
				{
					deepHandles.Add("SpoSponsorStudCollectionGetByEdCodeSemesterToId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SpoSponsorStud>) DataRepository.SpoSponsorStudProvider.DeepLoad,
						new object[] { transactionManager, entity.SpoSponsorStudCollectionGetByEdCodeSemesterToId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region CoCrsRsltRaiseCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<CoCrsRsltRaise>|CoCrsRsltRaiseCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CoCrsRsltRaiseCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.CoCrsRsltRaiseCollection = DataRepository.CoCrsRsltRaiseProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.CoCrsRsltRaiseCollection.Count > 0)
				{
					deepHandles.Add("CoCrsRsltRaiseCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CoCrsRsltRaise>) DataRepository.CoCrsRsltRaiseProvider.DeepLoad,
						new object[] { transactionManager, entity.CoCrsRsltRaiseCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudIntTrnsStateFromCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudIntTrnsStateFrom>|EdStudIntTrnsStateFromCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudIntTrnsStateFromCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudIntTrnsStateFromCollection = DataRepository.EdStudIntTrnsStateFromProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.EdStudIntTrnsStateFromCollection.Count > 0)
				{
					deepHandles.Add("EdStudIntTrnsStateFromCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudIntTrnsStateFrom>) DataRepository.EdStudIntTrnsStateFromProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudIntTrnsStateFromCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region MdiStudRecordCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<MdiStudRecord>|MdiStudRecordCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MdiStudRecordCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.MdiStudRecordCollection = DataRepository.MdiStudRecordProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.MdiStudRecordCollection.Count > 0)
				{
					deepHandles.Add("MdiStudRecordCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<MdiStudRecord>) DataRepository.MdiStudRecordProvider.DeepLoad,
						new object[] { transactionManager, entity.MdiStudRecordCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudLatenessCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudLateness>|EdStudLatenessCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudLatenessCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudLatenessCollection = DataRepository.EdStudLatenessProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.EdStudLatenessCollection.Count > 0)
				{
					deepHandles.Add("EdStudLatenessCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudLateness>) DataRepository.EdStudLatenessProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudLatenessCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeStudItemCnclCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeStudItemCncl>|FeeStudItemCnclCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudItemCnclCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeStudItemCnclCollection = DataRepository.FeeStudItemCnclProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.FeeStudItemCnclCollection.Count > 0)
				{
					deepHandles.Add("FeeStudItemCnclCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudItemCncl>) DataRepository.FeeStudItemCnclProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudItemCnclCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudBranchPrefCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudBranchPref>|EdStudBranchPrefCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudBranchPrefCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudBranchPrefCollection = DataRepository.EdStudBranchPrefProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.EdStudBranchPrefCollection.Count > 0)
				{
					deepHandles.Add("EdStudBranchPrefCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudBranchPref>) DataRepository.EdStudBranchPrefProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudBranchPrefCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdAcdadvRmkCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdAcdadvRmk>|EdAcdadvRmkCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdAcdadvRmkCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdAcdadvRmkCollection = DataRepository.EdAcdadvRmkProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.EdAcdadvRmkCollection.Count > 0)
				{
					deepHandles.Add("EdAcdadvRmkCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdAcdadvRmk>) DataRepository.EdAcdadvRmkProvider.DeepLoad,
						new object[] { transactionManager, entity.EdAcdadvRmkCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdCourseInfoCollectionGetByEdCodeSemesterToId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdCourseInfo>|EdCourseInfoCollectionGetByEdCodeSemesterToId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCourseInfoCollectionGetByEdCodeSemesterToId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdCourseInfoCollectionGetByEdCodeSemesterToId = DataRepository.EdCourseInfoProvider.GetByEdCodeSemesterToId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.EdCourseInfoCollectionGetByEdCodeSemesterToId.Count > 0)
				{
					deepHandles.Add("EdCourseInfoCollectionGetByEdCodeSemesterToId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdCourseInfo>) DataRepository.EdCourseInfoProvider.DeepLoad,
						new object[] { transactionManager, entity.EdCourseInfoCollectionGetByEdCodeSemesterToId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeStudPayPostponeCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeStudPayPostpone>|FeeStudPayPostponeCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudPayPostponeCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeStudPayPostponeCollection = DataRepository.FeeStudPayPostponeProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.FeeStudPayPostponeCollection.Count > 0)
				{
					deepHandles.Add("FeeStudPayPostponeCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudPayPostpone>) DataRepository.FeeStudPayPostponeProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudPayPostponeCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SpoSponsorStudCollectionGetByEdCodeSemesterId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SpoSponsorStud>|SpoSponsorStudCollectionGetByEdCodeSemesterId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SpoSponsorStudCollectionGetByEdCodeSemesterId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SpoSponsorStudCollectionGetByEdCodeSemesterId = DataRepository.SpoSponsorStudProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.SpoSponsorStudCollectionGetByEdCodeSemesterId.Count > 0)
				{
					deepHandles.Add("SpoSponsorStudCollectionGetByEdCodeSemesterId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SpoSponsorStud>) DataRepository.SpoSponsorStudProvider.DeepLoad,
						new object[] { transactionManager, entity.SpoSponsorStudCollectionGetByEdCodeSemesterId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SvSrvyHdrCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvSrvyHdr>|SvSrvyHdrCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvSrvyHdrCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvSrvyHdrCollection = DataRepository.SvSrvyHdrProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.SvSrvyHdrCollection.Count > 0)
				{
					deepHandles.Add("SvSrvyHdrCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvSrvyHdr>) DataRepository.SvSrvyHdrProvider.DeepLoad,
						new object[] { transactionManager, entity.SvSrvyHdrCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.FeeLimitRuleCollection = DataRepository.FeeLimitRuleProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.FeeLimitRuleCollection.Count > 0)
				{
					deepHandles.Add("FeeLimitRuleCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeLimitRule>) DataRepository.FeeLimitRuleProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeLimitRuleCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region MltStudInfoCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<MltStudInfo>|MltStudInfoCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MltStudInfoCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.MltStudInfoCollection = DataRepository.MltStudInfoProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.MltStudInfoCollection.Count > 0)
				{
					deepHandles.Add("MltStudInfoCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<MltStudInfo>) DataRepository.MltStudInfoProvider.DeepLoad,
						new object[] { transactionManager, entity.MltStudInfoCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.FeeInstlmntRuleCollection = DataRepository.FeeInstlmntRuleProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.FeeInstlmntRuleCollection.Count > 0)
				{
					deepHandles.Add("FeeInstlmntRuleCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeInstlmntRule>) DataRepository.FeeInstlmntRuleProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeInstlmntRuleCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudEnrollChangeCollectionGetByEdCodeSemesterToId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudEnrollChange>|EdStudEnrollChangeCollectionGetByEdCodeSemesterToId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudEnrollChangeCollectionGetByEdCodeSemesterToId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudEnrollChangeCollectionGetByEdCodeSemesterToId = DataRepository.EdStudEnrollChangeProvider.GetByEdCodeSemesterToId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.EdStudEnrollChangeCollectionGetByEdCodeSemesterToId.Count > 0)
				{
					deepHandles.Add("EdStudEnrollChangeCollectionGetByEdCodeSemesterToId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudEnrollChange>) DataRepository.EdStudEnrollChangeProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudEnrollChangeCollectionGetByEdCodeSemesterToId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudAcadmicAdvCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudAcadmicAdv>|EdStudAcadmicAdvCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudAcadmicAdvCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudAcadmicAdvCollection = DataRepository.EdStudAcadmicAdvProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.EdStudAcadmicAdvCollection.Count > 0)
				{
					deepHandles.Add("EdStudAcadmicAdvCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudAcadmicAdv>) DataRepository.EdStudAcadmicAdvProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudAcadmicAdvCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdInttransRuleCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdInttransRule>|EdInttransRuleCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdInttransRuleCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdInttransRuleCollection = DataRepository.EdInttransRuleProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.EdInttransRuleCollection.Count > 0)
				{
					deepHandles.Add("EdInttransRuleCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdInttransRule>) DataRepository.EdInttransRuleProvider.DeepLoad,
						new object[] { transactionManager, entity.EdInttransRuleCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SpoOfferStudExceptionCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SpoOfferStudException>|SpoOfferStudExceptionCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SpoOfferStudExceptionCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SpoOfferStudExceptionCollection = DataRepository.SpoOfferStudExceptionProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.SpoOfferStudExceptionCollection.Count > 0)
				{
					deepHandles.Add("SpoOfferStudExceptionCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SpoOfferStudException>) DataRepository.SpoOfferStudExceptionProvider.DeepLoad,
						new object[] { transactionManager, entity.SpoOfferStudExceptionCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeRefundCodeCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeRefundCode>|FeeRefundCodeCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeRefundCodeCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeRefundCodeCollection = DataRepository.FeeRefundCodeProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.FeeRefundCodeCollection.Count > 0)
				{
					deepHandles.Add("FeeRefundCodeCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeRefundCode>) DataRepository.FeeRefundCodeProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeRefundCodeCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeStudVoucherCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeStudVoucher>|FeeStudVoucherCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudVoucherCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeStudVoucherCollection = DataRepository.FeeStudVoucherProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.FeeStudVoucherCollection.Count > 0)
				{
					deepHandles.Add("FeeStudVoucherCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudVoucher>) DataRepository.FeeStudVoucherProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudVoucherCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SpoSponsorStudSemesterCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SpoSponsorStudSemester>|SpoSponsorStudSemesterCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SpoSponsorStudSemesterCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SpoSponsorStudSemesterCollection = DataRepository.SpoSponsorStudSemesterProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.SpoSponsorStudSemesterCollection.Count > 0)
				{
					deepHandles.Add("SpoSponsorStudSemesterCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SpoSponsorStudSemester>) DataRepository.SpoSponsorStudSemesterProvider.DeepLoad,
						new object[] { transactionManager, entity.SpoSponsorStudSemesterCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeStudFundCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeStudFund>|FeeStudFundCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudFundCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeStudFundCollection = DataRepository.FeeStudFundProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.FeeStudFundCollection.Count > 0)
				{
					deepHandles.Add("FeeStudFundCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudFund>) DataRepository.FeeStudFundProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudFundCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeStudDiscCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeStudDisc>|FeeStudDiscCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudDiscCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeStudDiscCollection = DataRepository.FeeStudDiscProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.FeeStudDiscCollection.Count > 0)
				{
					deepHandles.Add("FeeStudDiscCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudDisc>) DataRepository.FeeStudDiscProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudDiscCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeStudCoursesItemCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeStudCoursesItem>|FeeStudCoursesItemCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudCoursesItemCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeStudCoursesItemCollection = DataRepository.FeeStudCoursesItemProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.FeeStudCoursesItemCollection.Count > 0)
				{
					deepHandles.Add("FeeStudCoursesItemCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudCoursesItem>) DataRepository.FeeStudCoursesItemProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudCoursesItemCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdSemesterOpenCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdSemesterOpen>|EdSemesterOpenCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdSemesterOpenCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdSemesterOpenCollection = DataRepository.EdSemesterOpenProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.EdSemesterOpenCollection.Count > 0)
				{
					deepHandles.Add("EdSemesterOpenCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdSemesterOpen>) DataRepository.EdSemesterOpenProvider.DeepLoad,
						new object[] { transactionManager, entity.EdSemesterOpenCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaOfficeHourCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaOfficeHour>|SaOfficeHourCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaOfficeHourCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaOfficeHourCollection = DataRepository.SaOfficeHourProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.SaOfficeHourCollection.Count > 0)
				{
					deepHandles.Add("SaOfficeHourCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaOfficeHour>) DataRepository.SaOfficeHourProvider.DeepLoad,
						new object[] { transactionManager, entity.SaOfficeHourCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region CtrStudExpCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<CtrStudExp>|CtrStudExpCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CtrStudExpCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.CtrStudExpCollection = DataRepository.CtrStudExpProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.CtrStudExpCollection.Count > 0)
				{
					deepHandles.Add("CtrStudExpCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CtrStudExp>) DataRepository.CtrStudExpProvider.DeepLoad,
						new object[] { transactionManager, entity.CtrStudExpCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region MdiStudClnqCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<MdiStudClnq>|MdiStudClnqCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MdiStudClnqCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.MdiStudClnqCollection = DataRepository.MdiStudClnqProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.MdiStudClnqCollection.Count > 0)
				{
					deepHandles.Add("MdiStudClnqCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<MdiStudClnq>) DataRepository.MdiStudClnqProvider.DeepLoad,
						new object[] { transactionManager, entity.MdiStudClnqCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.PgThesisStudCollection = DataRepository.PgThesisStudProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.PgThesisStudCollection.Count > 0)
				{
					deepHandles.Add("PgThesisStudCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgThesisStud>) DataRepository.PgThesisStudProvider.DeepLoad,
						new object[] { transactionManager, entity.PgThesisStudCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region GsAgendaHolidayCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GsAgendaHoliday>|GsAgendaHolidayCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsAgendaHolidayCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GsAgendaHolidayCollection = DataRepository.GsAgendaHolidayProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.GsAgendaHolidayCollection.Count > 0)
				{
					deepHandles.Add("GsAgendaHolidayCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GsAgendaHoliday>) DataRepository.GsAgendaHolidayProvider.DeepLoad,
						new object[] { transactionManager, entity.GsAgendaHolidayCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudViolCollectionGetByEdCodeSemesterId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudViol>|EdStudViolCollectionGetByEdCodeSemesterId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudViolCollectionGetByEdCodeSemesterId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudViolCollectionGetByEdCodeSemesterId = DataRepository.EdStudViolProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.EdStudViolCollectionGetByEdCodeSemesterId.Count > 0)
				{
					deepHandles.Add("EdStudViolCollectionGetByEdCodeSemesterId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudViol>) DataRepository.EdStudViolProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudViolCollectionGetByEdCodeSemesterId, deep, deepLoadType, childTypes, innerList }
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

				entity.EdStudIntTrnsCourseFromCollection = DataRepository.EdStudIntTrnsCourseFromProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.EdStudIntTrnsCourseFromCollection.Count > 0)
				{
					deepHandles.Add("EdStudIntTrnsCourseFromCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudIntTrnsCourseFrom>) DataRepository.EdStudIntTrnsCourseFromProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudIntTrnsCourseFromCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AccomStudAbsenceCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AccomStudAbsence>|AccomStudAbsenceCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AccomStudAbsenceCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AccomStudAbsenceCollection = DataRepository.AccomStudAbsenceProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.AccomStudAbsenceCollection.Count > 0)
				{
					deepHandles.Add("AccomStudAbsenceCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AccomStudAbsence>) DataRepository.AccomStudAbsenceProvider.DeepLoad,
						new object[] { transactionManager, entity.AccomStudAbsenceCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region PgOfferingCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgOffering>|PgOfferingCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgOfferingCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgOfferingCollection = DataRepository.PgOfferingProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.PgOfferingCollection.Count > 0)
				{
					deepHandles.Add("PgOfferingCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgOffering>) DataRepository.PgOfferingProvider.DeepLoad,
						new object[] { transactionManager, entity.PgOfferingCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeItemTrnsBlncCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeItemTrnsBlnc>|FeeItemTrnsBlncCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeItemTrnsBlncCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeItemTrnsBlncCollection = DataRepository.FeeItemTrnsBlncProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.FeeItemTrnsBlncCollection.Count > 0)
				{
					deepHandles.Add("FeeItemTrnsBlncCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeItemTrnsBlnc>) DataRepository.FeeItemTrnsBlncProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeItemTrnsBlncCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EntMajorPhaseCollectionGetByEdCodeSemesterToId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EntMajorPhase>|EntMajorPhaseCollectionGetByEdCodeSemesterToId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EntMajorPhaseCollectionGetByEdCodeSemesterToId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EntMajorPhaseCollectionGetByEdCodeSemesterToId = DataRepository.EntMajorPhaseProvider.GetByEdCodeSemesterToId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.EntMajorPhaseCollectionGetByEdCodeSemesterToId.Count > 0)
				{
					deepHandles.Add("EntMajorPhaseCollectionGetByEdCodeSemesterToId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntMajorPhase>) DataRepository.EntMajorPhaseProvider.DeepLoad,
						new object[] { transactionManager, entity.EntMajorPhaseCollectionGetByEdCodeSemesterToId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdCourseInfoCollectionGetByEdCodeSemesterFromId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdCourseInfo>|EdCourseInfoCollectionGetByEdCodeSemesterFromId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCourseInfoCollectionGetByEdCodeSemesterFromId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdCourseInfoCollectionGetByEdCodeSemesterFromId = DataRepository.EdCourseInfoProvider.GetByEdCodeSemesterFromId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.EdCourseInfoCollectionGetByEdCodeSemesterFromId.Count > 0)
				{
					deepHandles.Add("EdCourseInfoCollectionGetByEdCodeSemesterFromId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdCourseInfo>) DataRepository.EdCourseInfoProvider.DeepLoad,
						new object[] { transactionManager, entity.EdCourseInfoCollectionGetByEdCodeSemesterFromId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeStudInstallmentCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeStudInstallment>|FeeStudInstallmentCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudInstallmentCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeStudInstallmentCollection = DataRepository.FeeStudInstallmentProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.FeeStudInstallmentCollection.Count > 0)
				{
					deepHandles.Add("FeeStudInstallmentCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudInstallment>) DataRepository.FeeStudInstallmentProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudInstallmentCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmFeePromocodeCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmFeePromocode>|AdmFeePromocodeCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmFeePromocodeCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmFeePromocodeCollection = DataRepository.AdmFeePromocodeProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.AdmFeePromocodeCollection.Count > 0)
				{
					deepHandles.Add("AdmFeePromocodeCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmFeePromocode>) DataRepository.AdmFeePromocodeProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmFeePromocodeCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudViolCollectionGetByEdCodeSemesterStopFromId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudViol>|EdStudViolCollectionGetByEdCodeSemesterStopFromId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudViolCollectionGetByEdCodeSemesterStopFromId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudViolCollectionGetByEdCodeSemesterStopFromId = DataRepository.EdStudViolProvider.GetByEdCodeSemesterStopFromId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.EdStudViolCollectionGetByEdCodeSemesterStopFromId.Count > 0)
				{
					deepHandles.Add("EdStudViolCollectionGetByEdCodeSemesterStopFromId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudViol>) DataRepository.EdStudViolProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudViolCollectionGetByEdCodeSemesterStopFromId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdBranchRuleCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdBranchRule>|EdBranchRuleCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdBranchRuleCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdBranchRuleCollection = DataRepository.EdBranchRuleProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.EdBranchRuleCollection.Count > 0)
				{
					deepHandles.Add("EdBranchRuleCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdBranchRule>) DataRepository.EdBranchRuleProvider.DeepLoad,
						new object[] { transactionManager, entity.EdBranchRuleCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.FeeFacultyRuleCollection = DataRepository.FeeFacultyRuleProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.FeeFacultyRuleCollection.Count > 0)
				{
					deepHandles.Add("FeeFacultyRuleCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeFacultyRule>) DataRepository.FeeFacultyRuleProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeFacultyRuleCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudProblemCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudProblem>|EdStudProblemCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudProblemCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudProblemCollection = DataRepository.EdStudProblemProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.EdStudProblemCollection.Count > 0)
				{
					deepHandles.Add("EdStudProblemCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudProblem>) DataRepository.EdStudProblemProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudProblemCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SpoSponsorOfferCollectionGetByEdCodeSemesterFromId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SpoSponsorOffer>|SpoSponsorOfferCollectionGetByEdCodeSemesterFromId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SpoSponsorOfferCollectionGetByEdCodeSemesterFromId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SpoSponsorOfferCollectionGetByEdCodeSemesterFromId = DataRepository.SpoSponsorOfferProvider.GetByEdCodeSemesterFromId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.SpoSponsorOfferCollectionGetByEdCodeSemesterFromId.Count > 0)
				{
					deepHandles.Add("SpoSponsorOfferCollectionGetByEdCodeSemesterFromId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SpoSponsorOffer>) DataRepository.SpoSponsorOfferProvider.DeepLoad,
						new object[] { transactionManager, entity.SpoSponsorOfferCollectionGetByEdCodeSemesterFromId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeItemSemesterCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeItemSemester>|FeeItemSemesterCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeItemSemesterCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeItemSemesterCollection = DataRepository.FeeItemSemesterProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.FeeItemSemesterCollection.Count > 0)
				{
					deepHandles.Add("FeeItemSemesterCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeItemSemester>) DataRepository.FeeItemSemesterProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeItemSemesterCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region ScSectionGroupHdrCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ScSectionGroupHdr>|ScSectionGroupHdrCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScSectionGroupHdrCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ScSectionGroupHdrCollection = DataRepository.ScSectionGroupHdrProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.ScSectionGroupHdrCollection.Count > 0)
				{
					deepHandles.Add("ScSectionGroupHdrCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScSectionGroupHdr>) DataRepository.ScSectionGroupHdrProvider.DeepLoad,
						new object[] { transactionManager, entity.ScSectionGroupHdrCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region CtrStudOutCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<CtrStudOut>|CtrStudOutCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CtrStudOutCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.CtrStudOutCollection = DataRepository.CtrStudOutProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.CtrStudOutCollection.Count > 0)
				{
					deepHandles.Add("CtrStudOutCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CtrStudOut>) DataRepository.CtrStudOutProvider.DeepLoad,
						new object[] { transactionManager, entity.CtrStudOutCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region TrnsStudReqCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<TrnsStudReq>|TrnsStudReqCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'TrnsStudReqCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.TrnsStudReqCollection = DataRepository.TrnsStudReqProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.TrnsStudReqCollection.Count > 0)
				{
					deepHandles.Add("TrnsStudReqCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<TrnsStudReq>) DataRepository.TrnsStudReqProvider.DeepLoad,
						new object[] { transactionManager, entity.TrnsStudReqCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudExmptReqCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudExmptReq>|EdStudExmptReqCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudExmptReqCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudExmptReqCollection = DataRepository.EdStudExmptReqProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.EdStudExmptReqCollection.Count > 0)
				{
					deepHandles.Add("EdStudExmptReqCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudExmptReq>) DataRepository.EdStudExmptReqProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudExmptReqCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeStudRetrieveRequestCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeStudRetrieveRequest>|FeeStudRetrieveRequestCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudRetrieveRequestCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeStudRetrieveRequestCollection = DataRepository.FeeStudRetrieveRequestProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.FeeStudRetrieveRequestCollection.Count > 0)
				{
					deepHandles.Add("FeeStudRetrieveRequestCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudRetrieveRequest>) DataRepository.FeeStudRetrieveRequestProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudRetrieveRequestCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SvCourseEvalCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvCourseEval>|SvCourseEvalCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvCourseEvalCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvCourseEvalCollection = DataRepository.SvCourseEvalProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.SvCourseEvalCollection.Count > 0)
				{
					deepHandles.Add("SvCourseEvalCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvCourseEval>) DataRepository.SvCourseEvalProvider.DeepLoad,
						new object[] { transactionManager, entity.SvCourseEvalCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region RsrchStudPostponeReqCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<RsrchStudPostponeReq>|RsrchStudPostponeReqCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'RsrchStudPostponeReqCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.RsrchStudPostponeReqCollection = DataRepository.RsrchStudPostponeReqProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.RsrchStudPostponeReqCollection.Count > 0)
				{
					deepHandles.Add("RsrchStudPostponeReqCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<RsrchStudPostponeReq>) DataRepository.RsrchStudPostponeReqProvider.DeepLoad,
						new object[] { transactionManager, entity.RsrchStudPostponeReqCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AdmAppRegHistoryCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmAppRegHistory>|AdmAppRegHistoryCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppRegHistoryCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmAppRegHistoryCollection = DataRepository.AdmAppRegHistoryProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.AdmAppRegHistoryCollection.Count > 0)
				{
					deepHandles.Add("AdmAppRegHistoryCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmAppRegHistory>) DataRepository.AdmAppRegHistoryProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmAppRegHistoryCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.EdStudSemesterCollection = DataRepository.EdStudSemesterProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.EdStudSemesterCollection.Count > 0)
				{
					deepHandles.Add("EdStudSemesterCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudSemester>) DataRepository.EdStudSemesterProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudSemesterCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.PgThesisGrantDegreeCollection = DataRepository.PgThesisGrantDegreeProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.PgThesisGrantDegreeCollection.Count > 0)
				{
					deepHandles.Add("PgThesisGrantDegreeCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgThesisGrantDegree>) DataRepository.PgThesisGrantDegreeProvider.DeepLoad,
						new object[] { transactionManager, entity.PgThesisGrantDegreeCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudExecuseReqCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudExecuseReq>|EdStudExecuseReqCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudExecuseReqCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudExecuseReqCollection = DataRepository.EdStudExecuseReqProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.EdStudExecuseReqCollection.Count > 0)
				{
					deepHandles.Add("EdStudExecuseReqCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudExecuseReq>) DataRepository.EdStudExecuseReqProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudExecuseReqCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeRefndStdReqCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeRefndStdReq>|FeeRefndStdReqCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeRefndStdReqCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeRefndStdReqCollection = DataRepository.FeeRefndStdReqProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.FeeRefndStdReqCollection.Count > 0)
				{
					deepHandles.Add("FeeRefndStdReqCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeRefndStdReq>) DataRepository.FeeRefndStdReqProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeRefndStdReqCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdOfferingCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdOffering>|EdOfferingCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdOfferingCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdOfferingCollection = DataRepository.EdOfferingProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.EdOfferingCollection.Count > 0)
				{
					deepHandles.Add("EdOfferingCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdOffering>) DataRepository.EdOfferingProvider.DeepLoad,
						new object[] { transactionManager, entity.EdOfferingCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SvLecNoteCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvLecNote>|SvLecNoteCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvLecNoteCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvLecNoteCollection = DataRepository.SvLecNoteProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.SvLecNoteCollection.Count > 0)
				{
					deepHandles.Add("SvLecNoteCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvLecNote>) DataRepository.SvLecNoteProvider.DeepLoad,
						new object[] { transactionManager, entity.SvLecNoteCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudAbsenceCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudAbsence>|EdStudAbsenceCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudAbsenceCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudAbsenceCollection = DataRepository.EdStudAbsenceProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.EdStudAbsenceCollection.Count > 0)
				{
					deepHandles.Add("EdStudAbsenceCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudAbsence>) DataRepository.EdStudAbsenceProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudAbsenceCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudAbsFwCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudAbsFw>|EdStudAbsFwCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudAbsFwCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudAbsFwCollection = DataRepository.EdStudAbsFwProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.EdStudAbsFwCollection.Count > 0)
				{
					deepHandles.Add("EdStudAbsFwCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudAbsFw>) DataRepository.EdStudAbsFwProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudAbsFwCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeStudInstallmentRequestCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeStudInstallmentRequest>|FeeStudInstallmentRequestCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudInstallmentRequestCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeStudInstallmentRequestCollection = DataRepository.FeeStudInstallmentRequestProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.FeeStudInstallmentRequestCollection.Count > 0)
				{
					deepHandles.Add("FeeStudInstallmentRequestCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudInstallmentRequest>) DataRepository.FeeStudInstallmentRequestProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudInstallmentRequestCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region MltRptDayStudStsCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<MltRptDayStudSts>|MltRptDayStudStsCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MltRptDayStudStsCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.MltRptDayStudStsCollection = DataRepository.MltRptDayStudStsProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.MltRptDayStudStsCollection.Count > 0)
				{
					deepHandles.Add("MltRptDayStudStsCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<MltRptDayStudSts>) DataRepository.MltRptDayStudStsProvider.DeepLoad,
						new object[] { transactionManager, entity.MltRptDayStudStsCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SvUserTaskCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvUserTask>|SvUserTaskCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvUserTaskCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvUserTaskCollection = DataRepository.SvUserTaskProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.SvUserTaskCollection.Count > 0)
				{
					deepHandles.Add("SvUserTaskCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvUserTask>) DataRepository.SvUserTaskProvider.DeepLoad,
						new object[] { transactionManager, entity.SvUserTaskCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudEnrollChangeCollectionGetByEdCodeSemesterFromId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudEnrollChange>|EdStudEnrollChangeCollectionGetByEdCodeSemesterFromId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudEnrollChangeCollectionGetByEdCodeSemesterFromId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudEnrollChangeCollectionGetByEdCodeSemesterFromId = DataRepository.EdStudEnrollChangeProvider.GetByEdCodeSemesterFromId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.EdStudEnrollChangeCollectionGetByEdCodeSemesterFromId.Count > 0)
				{
					deepHandles.Add("EdStudEnrollChangeCollectionGetByEdCodeSemesterFromId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudEnrollChange>) DataRepository.EdStudEnrollChangeProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudEnrollChangeCollectionGetByEdCodeSemesterFromId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudViolCollectionGetByEdCodeSemesterStopToId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudViol>|EdStudViolCollectionGetByEdCodeSemesterStopToId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudViolCollectionGetByEdCodeSemesterStopToId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudViolCollectionGetByEdCodeSemesterStopToId = DataRepository.EdStudViolProvider.GetByEdCodeSemesterStopToId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.EdStudViolCollectionGetByEdCodeSemesterStopToId.Count > 0)
				{
					deepHandles.Add("EdStudViolCollectionGetByEdCodeSemesterStopToId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudViol>) DataRepository.EdStudViolProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudViolCollectionGetByEdCodeSemesterStopToId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AccomStudReqCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AccomStudReq>|AccomStudReqCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AccomStudReqCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AccomStudReqCollection = DataRepository.AccomStudReqProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.AccomStudReqCollection.Count > 0)
				{
					deepHandles.Add("AccomStudReqCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AccomStudReq>) DataRepository.AccomStudReqProvider.DeepLoad,
						new object[] { transactionManager, entity.AccomStudReqCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdAcadPlanHdrCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdAcadPlanHdr>|EdAcadPlanHdrCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdAcadPlanHdrCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdAcadPlanHdrCollection = DataRepository.EdAcadPlanHdrProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.EdAcadPlanHdrCollection.Count > 0)
				{
					deepHandles.Add("EdAcadPlanHdrCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdAcadPlanHdr>) DataRepository.EdAcadPlanHdrProvider.DeepLoad,
						new object[] { transactionManager, entity.EdAcadPlanHdrCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SvStaffEvlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvStaffEvl>|SvStaffEvlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvStaffEvlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvStaffEvlCollection = DataRepository.SvStaffEvlProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.SvStaffEvlCollection.Count > 0)
				{
					deepHandles.Add("SvStaffEvlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvStaffEvl>) DataRepository.SvStaffEvlProvider.DeepLoad,
						new object[] { transactionManager, entity.SvStaffEvlCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SeUserCrsAssessCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SeUserCrsAssess>|SeUserCrsAssessCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeUserCrsAssessCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SeUserCrsAssessCollection = DataRepository.SeUserCrsAssessProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.SeUserCrsAssessCollection.Count > 0)
				{
					deepHandles.Add("SeUserCrsAssessCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SeUserCrsAssess>) DataRepository.SeUserCrsAssessProvider.DeepLoad,
						new object[] { transactionManager, entity.SeUserCrsAssessCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.EdStudIntTrnsCourseToCollection = DataRepository.EdStudIntTrnsCourseToProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.EdStudIntTrnsCourseToCollection.Count > 0)
				{
					deepHandles.Add("EdStudIntTrnsCourseToCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudIntTrnsCourseTo>) DataRepository.EdStudIntTrnsCourseToProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudIntTrnsCourseToCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudFacultyCollectionGetByEdCodeSemesterId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudFaculty>|EdStudFacultyCollectionGetByEdCodeSemesterId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudFacultyCollectionGetByEdCodeSemesterId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudFacultyCollectionGetByEdCodeSemesterId = DataRepository.EdStudFacultyProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.EdStudFacultyCollectionGetByEdCodeSemesterId.Count > 0)
				{
					deepHandles.Add("EdStudFacultyCollectionGetByEdCodeSemesterId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudFaculty>) DataRepository.EdStudFacultyProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudFacultyCollectionGetByEdCodeSemesterId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudIntTrnsStateToCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudIntTrnsStateTo>|EdStudIntTrnsStateToCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudIntTrnsStateToCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudIntTrnsStateToCollection = DataRepository.EdStudIntTrnsStateToProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.EdStudIntTrnsStateToCollection.Count > 0)
				{
					deepHandles.Add("EdStudIntTrnsStateToCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudIntTrnsStateTo>) DataRepository.EdStudIntTrnsStateToProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudIntTrnsStateToCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region FeeStudFeeItemCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeStudFeeItem>|FeeStudFeeItemCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudFeeItemCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeStudFeeItemCollection = DataRepository.FeeStudFeeItemProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.FeeStudFeeItemCollection.Count > 0)
				{
					deepHandles.Add("FeeStudFeeItemCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeStudFeeItem>) DataRepository.FeeStudFeeItemProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeStudFeeItemCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdPrintReqCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdPrintReq>|EdPrintReqCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdPrintReqCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdPrintReqCollection = DataRepository.EdPrintReqProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.EdPrintReqCollection.Count > 0)
				{
					deepHandles.Add("EdPrintReqCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdPrintReq>) DataRepository.EdPrintReqProvider.DeepLoad,
						new object[] { transactionManager, entity.EdPrintReqCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudTransFromReqCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudTransFromReq>|EdStudTransFromReqCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudTransFromReqCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudTransFromReqCollection = DataRepository.EdStudTransFromReqProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.EdStudTransFromReqCollection.Count > 0)
				{
					deepHandles.Add("EdStudTransFromReqCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudTransFromReq>) DataRepository.EdStudTransFromReqProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudTransFromReqCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AccomStudBookCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AccomStudBook>|AccomStudBookCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AccomStudBookCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AccomStudBookCollection = DataRepository.AccomStudBookProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.AccomStudBookCollection.Count > 0)
				{
					deepHandles.Add("AccomStudBookCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AccomStudBook>) DataRepository.AccomStudBookProvider.DeepLoad,
						new object[] { transactionManager, entity.AccomStudBookCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudSemesterTempCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudSemesterTemp>|EdStudSemesterTempCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudSemesterTempCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudSemesterTempCollection = DataRepository.EdStudSemesterTempProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.EdStudSemesterTempCollection.Count > 0)
				{
					deepHandles.Add("EdStudSemesterTempCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudSemesterTemp>) DataRepository.EdStudSemesterTempProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudSemesterTempCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudIntTrnsCollectionGetByEdCodeSemesterId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudIntTrns>|EdStudIntTrnsCollectionGetByEdCodeSemesterId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudIntTrnsCollectionGetByEdCodeSemesterId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudIntTrnsCollectionGetByEdCodeSemesterId = DataRepository.EdStudIntTrnsProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.EdStudIntTrnsCollectionGetByEdCodeSemesterId.Count > 0)
				{
					deepHandles.Add("EdStudIntTrnsCollectionGetByEdCodeSemesterId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudIntTrns>) DataRepository.EdStudIntTrnsProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudIntTrnsCollectionGetByEdCodeSemesterId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SvStudCompCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvStudComp>|SvStudCompCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvStudCompCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvStudCompCollection = DataRepository.SvStudCompProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.SvStudCompCollection.Count > 0)
				{
					deepHandles.Add("SvStudCompCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvStudComp>) DataRepository.SvStudCompProvider.DeepLoad,
						new object[] { transactionManager, entity.SvStudCompCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudExcuseCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudExcuse>|EdStudExcuseCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudExcuseCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudExcuseCollection = DataRepository.EdStudExcuseProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.EdStudExcuseCollection.Count > 0)
				{
					deepHandles.Add("EdStudExcuseCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudExcuse>) DataRepository.EdStudExcuseProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudExcuseCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region MdiStudHosptlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<MdiStudHosptl>|MdiStudHosptlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MdiStudHosptlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.MdiStudHosptlCollection = DataRepository.MdiStudHosptlProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.MdiStudHosptlCollection.Count > 0)
				{
					deepHandles.Add("MdiStudHosptlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<MdiStudHosptl>) DataRepository.MdiStudHosptlProvider.DeepLoad,
						new object[] { transactionManager, entity.MdiStudHosptlCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SvMessageCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SvMessage>|SvMessageCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SvMessageCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SvMessageCollection = DataRepository.SvMessageProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.SvMessageCollection.Count > 0)
				{
					deepHandles.Add("SvMessageCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SvMessage>) DataRepository.SvMessageProvider.DeepLoad,
						new object[] { transactionManager, entity.SvMessageCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudIntTrnsCollectionGetByEdCodeSemesterReqId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudIntTrns>|EdStudIntTrnsCollectionGetByEdCodeSemesterReqId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudIntTrnsCollectionGetByEdCodeSemesterReqId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudIntTrnsCollectionGetByEdCodeSemesterReqId = DataRepository.EdStudIntTrnsProvider.GetByEdCodeSemesterReqId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.EdStudIntTrnsCollectionGetByEdCodeSemesterReqId.Count > 0)
				{
					deepHandles.Add("EdStudIntTrnsCollectionGetByEdCodeSemesterReqId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudIntTrns>) DataRepository.EdStudIntTrnsProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudIntTrnsCollectionGetByEdCodeSemesterReqId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region MltLvlBhvrAttndcCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<MltLvlBhvrAttndc>|MltLvlBhvrAttndcCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MltLvlBhvrAttndcCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.MltLvlBhvrAttndcCollection = DataRepository.MltLvlBhvrAttndcProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.MltLvlBhvrAttndcCollection.Count > 0)
				{
					deepHandles.Add("MltLvlBhvrAttndcCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<MltLvlBhvrAttndc>) DataRepository.MltLvlBhvrAttndcProvider.DeepLoad,
						new object[] { transactionManager, entity.MltLvlBhvrAttndcCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.FeeCodeItemCollection = DataRepository.FeeCodeItemProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.FeeCodeItemCollection.Count > 0)
				{
					deepHandles.Add("FeeCodeItemCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeCodeItem>) DataRepository.FeeCodeItemProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeCodeItemCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdTrainingCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdTraining>|EdTrainingCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdTrainingCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdTrainingCollection = DataRepository.EdTrainingProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.EdTrainingCollection.Count > 0)
				{
					deepHandles.Add("EdTrainingCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdTraining>) DataRepository.EdTrainingProvider.DeepLoad,
						new object[] { transactionManager, entity.EdTrainingCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region ScSchdlPeriodCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ScSchdlPeriod>|ScSchdlPeriodCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScSchdlPeriodCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ScSchdlPeriodCollection = DataRepository.ScSchdlPeriodProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.ScSchdlPeriodCollection.Count > 0)
				{
					deepHandles.Add("ScSchdlPeriodCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScSchdlPeriod>) DataRepository.ScSchdlPeriodProvider.DeepLoad,
						new object[] { transactionManager, entity.ScSchdlPeriodCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SeBlockTransCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SeBlockTrans>|SeBlockTransCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeBlockTransCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SeBlockTransCollection = DataRepository.SeBlockTransProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.SeBlockTransCollection.Count > 0)
				{
					deepHandles.Add("SeBlockTransCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SeBlockTrans>) DataRepository.SeBlockTransProvider.DeepLoad,
						new object[] { transactionManager, entity.SeBlockTransCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region ScGroupInfoCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<ScGroupInfo>|ScGroupInfoCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'ScGroupInfoCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.ScGroupInfoCollection = DataRepository.ScGroupInfoProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.ScGroupInfoCollection.Count > 0)
				{
					deepHandles.Add("ScGroupInfoCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<ScGroupInfo>) DataRepository.ScGroupInfoProvider.DeepLoad,
						new object[] { transactionManager, entity.ScGroupInfoCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.EntPolcyGrdngHdrCollection = DataRepository.EntPolcyGrdngHdrProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.EntPolcyGrdngHdrCollection.Count > 0)
				{
					deepHandles.Add("EntPolcyGrdngHdrCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EntPolcyGrdngHdr>) DataRepository.EntPolcyGrdngHdrProvider.DeepLoad,
						new object[] { transactionManager, entity.EntPolcyGrdngHdrCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStaffCoursePrefCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStaffCoursePref>|EdStaffCoursePrefCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStaffCoursePrefCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStaffCoursePrefCollection = DataRepository.EdStaffCoursePrefProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.EdStaffCoursePrefCollection.Count > 0)
				{
					deepHandles.Add("EdStaffCoursePrefCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStaffCoursePref>) DataRepository.EdStaffCoursePrefProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStaffCoursePrefCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region AccomStudAbsenceWarnCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AccomStudAbsenceWarn>|AccomStudAbsenceWarnCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AccomStudAbsenceWarnCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AccomStudAbsenceWarnCollection = DataRepository.AccomStudAbsenceWarnProvider.GetByEdCodeSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.AccomStudAbsenceWarnCollection.Count > 0)
				{
					deepHandles.Add("AccomStudAbsenceWarnCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AccomStudAbsenceWarn>) DataRepository.AccomStudAbsenceWarnProvider.DeepLoad,
						new object[] { transactionManager, entity.AccomStudAbsenceWarnCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region GsCommCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GsComm>|GsCommCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCommCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GsCommCollection = DataRepository.GsCommProvider.GetByEdSemesterId(transactionManager, entity.EdCodeSemesterId);

				if (deep && entity.GsCommCollection.Count > 0)
				{
					deepHandles.Add("GsCommCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GsComm>) DataRepository.GsCommProvider.DeepLoad,
						new object[] { transactionManager, entity.GsCommCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdCodeSemester object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdCodeSemester instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCodeSemester Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeSemester entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdCodeSemesterTypeIdSource
			if (CanDeepSave(entity, "EdCodeSemesterType|EdCodeSemesterTypeIdSource", deepSaveType, innerList) 
				&& entity.EdCodeSemesterTypeIdSource != null)
			{
				DataRepository.EdCodeSemesterTypeProvider.Save(transactionManager, entity.EdCodeSemesterTypeIdSource);
				entity.EdCodeSemesterTypeId = entity.EdCodeSemesterTypeIdSource.EdCodeSemesterTypeId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<EdStudFaculty>
				if (CanDeepSave(entity.EdStudFacultyCollectionGetByEdCodeSemesterJoinId, "List<EdStudFaculty>|EdStudFacultyCollectionGetByEdCodeSemesterJoinId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudFaculty child in entity.EdStudFacultyCollectionGetByEdCodeSemesterJoinId)
					{
						if(child.EdCodeSemesterJoinIdSource != null)
						{
							child.EdCodeSemesterJoinId = child.EdCodeSemesterJoinIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterJoinId = entity.EdCodeSemesterId;
						}

					}

					if (entity.EdStudFacultyCollectionGetByEdCodeSemesterJoinId.Count > 0 || entity.EdStudFacultyCollectionGetByEdCodeSemesterJoinId.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudFacultyProvider.Save(transactionManager, entity.EdStudFacultyCollectionGetByEdCodeSemesterJoinId);
						
						deepHandles.Add("EdStudFacultyCollectionGetByEdCodeSemesterJoinId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudFaculty >) DataRepository.EdStudFacultyProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudFacultyCollectionGetByEdCodeSemesterJoinId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<TrnsLine>
				if (CanDeepSave(entity.TrnsLineCollection, "List<TrnsLine>|TrnsLineCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(TrnsLine child in entity.TrnsLineCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.TrnsLineCollection.Count > 0 || entity.TrnsLineCollection.DeletedItems.Count > 0)
					{
						//DataRepository.TrnsLineProvider.Save(transactionManager, entity.TrnsLineCollection);
						
						deepHandles.Add("TrnsLineCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< TrnsLine >) DataRepository.TrnsLineProvider.DeepSave,
							new object[] { transactionManager, entity.TrnsLineCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudTrans>
				if (CanDeepSave(entity.EdStudTransCollection, "List<EdStudTrans>|EdStudTransCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudTrans child in entity.EdStudTransCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.EdStudTransCollection.Count > 0 || entity.EdStudTransCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudTransProvider.Save(transactionManager, entity.EdStudTransCollection);
						
						deepHandles.Add("EdStudTransCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudTrans >) DataRepository.EdStudTransProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudTransCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<WfCrsRsltApprove>
				if (CanDeepSave(entity.WfCrsRsltApproveCollection, "List<WfCrsRsltApprove>|WfCrsRsltApproveCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(WfCrsRsltApprove child in entity.WfCrsRsltApproveCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.WfCrsRsltApproveCollection.Count > 0 || entity.WfCrsRsltApproveCollection.DeletedItems.Count > 0)
					{
						//DataRepository.WfCrsRsltApproveProvider.Save(transactionManager, entity.WfCrsRsltApproveCollection);
						
						deepHandles.Add("WfCrsRsltApproveCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< WfCrsRsltApprove >) DataRepository.WfCrsRsltApproveProvider.DeepSave,
							new object[] { transactionManager, entity.WfCrsRsltApproveCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SpoSponsorOffer>
				if (CanDeepSave(entity.SpoSponsorOfferCollectionGetByEdCodeSemesterToId, "List<SpoSponsorOffer>|SpoSponsorOfferCollectionGetByEdCodeSemesterToId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SpoSponsorOffer child in entity.SpoSponsorOfferCollectionGetByEdCodeSemesterToId)
					{
						if(child.EdCodeSemesterToIdSource != null)
						{
							child.EdCodeSemesterToId = child.EdCodeSemesterToIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterToId = entity.EdCodeSemesterId;
						}

					}

					if (entity.SpoSponsorOfferCollectionGetByEdCodeSemesterToId.Count > 0 || entity.SpoSponsorOfferCollectionGetByEdCodeSemesterToId.DeletedItems.Count > 0)
					{
						//DataRepository.SpoSponsorOfferProvider.Save(transactionManager, entity.SpoSponsorOfferCollectionGetByEdCodeSemesterToId);
						
						deepHandles.Add("SpoSponsorOfferCollectionGetByEdCodeSemesterToId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SpoSponsorOffer >) DataRepository.SpoSponsorOfferProvider.DeepSave,
							new object[] { transactionManager, entity.SpoSponsorOfferCollectionGetByEdCodeSemesterToId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudCourseRegPre>
				if (CanDeepSave(entity.EdStudCourseRegPreCollection, "List<EdStudCourseRegPre>|EdStudCourseRegPreCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudCourseRegPre child in entity.EdStudCourseRegPreCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.EdStudCourseRegPreCollection.Count > 0 || entity.EdStudCourseRegPreCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudCourseRegPreProvider.Save(transactionManager, entity.EdStudCourseRegPreCollection);
						
						deepHandles.Add("EdStudCourseRegPreCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudCourseRegPre >) DataRepository.EdStudCourseRegPreProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudCourseRegPreCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeStudNatSimilarityRequest>
				if (CanDeepSave(entity.FeeStudNatSimilarityRequestCollection, "List<FeeStudNatSimilarityRequest>|FeeStudNatSimilarityRequestCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeStudNatSimilarityRequest child in entity.FeeStudNatSimilarityRequestCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.FeeStudNatSimilarityRequestCollection.Count > 0 || entity.FeeStudNatSimilarityRequestCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeStudNatSimilarityRequestProvider.Save(transactionManager, entity.FeeStudNatSimilarityRequestCollection);
						
						deepHandles.Add("FeeStudNatSimilarityRequestCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeStudNatSimilarityRequest >) DataRepository.FeeStudNatSimilarityRequestProvider.DeepSave,
							new object[] { transactionManager, entity.FeeStudNatSimilarityRequestCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmOpenAcadSemester>
				if (CanDeepSave(entity.AdmOpenAcadSemesterCollection, "List<AdmOpenAcadSemester>|AdmOpenAcadSemesterCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmOpenAcadSemester child in entity.AdmOpenAcadSemesterCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.AdmOpenAcadSemesterCollection.Count > 0 || entity.AdmOpenAcadSemesterCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmOpenAcadSemesterProvider.Save(transactionManager, entity.AdmOpenAcadSemesterCollection);
						
						deepHandles.Add("AdmOpenAcadSemesterCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmOpenAcadSemester >) DataRepository.AdmOpenAcadSemesterProvider.DeepSave,
							new object[] { transactionManager, entity.AdmOpenAcadSemesterCollection, deepSaveType, childTypes, innerList }
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
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
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
				
	
			#region List<AccomWfRequestApprove>
				if (CanDeepSave(entity.AccomWfRequestApproveCollection, "List<AccomWfRequestApprove>|AccomWfRequestApproveCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AccomWfRequestApprove child in entity.AccomWfRequestApproveCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.AccomWfRequestApproveCollection.Count > 0 || entity.AccomWfRequestApproveCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AccomWfRequestApproveProvider.Save(transactionManager, entity.AccomWfRequestApproveCollection);
						
						deepHandles.Add("AccomWfRequestApproveCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AccomWfRequestApprove >) DataRepository.AccomWfRequestApproveProvider.DeepSave,
							new object[] { transactionManager, entity.AccomWfRequestApproveCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<ScStudGroup>
				if (CanDeepSave(entity.ScStudGroupCollection, "List<ScStudGroup>|ScStudGroupCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScStudGroup child in entity.ScStudGroupCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.ScStudGroupCollection.Count > 0 || entity.ScStudGroupCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ScStudGroupProvider.Save(transactionManager, entity.ScStudGroupCollection);
						
						deepHandles.Add("ScStudGroupCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ScStudGroup >) DataRepository.ScStudGroupProvider.DeepSave,
							new object[] { transactionManager, entity.ScStudGroupCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdProject>
				if (CanDeepSave(entity.EdProjectCollection, "List<EdProject>|EdProjectCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdProject child in entity.EdProjectCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.EdProjectCollection.Count > 0 || entity.EdProjectCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdProjectProvider.Save(transactionManager, entity.EdProjectCollection);
						
						deepHandles.Add("EdProjectCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdProject >) DataRepository.EdProjectProvider.DeepSave,
							new object[] { transactionManager, entity.EdProjectCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<RsrchStudRegister>
				if (CanDeepSave(entity.RsrchStudRegisterCollection, "List<RsrchStudRegister>|RsrchStudRegisterCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(RsrchStudRegister child in entity.RsrchStudRegisterCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.RsrchStudRegisterCollection.Count > 0 || entity.RsrchStudRegisterCollection.DeletedItems.Count > 0)
					{
						//DataRepository.RsrchStudRegisterProvider.Save(transactionManager, entity.RsrchStudRegisterCollection);
						
						deepHandles.Add("RsrchStudRegisterCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< RsrchStudRegister >) DataRepository.RsrchStudRegisterProvider.DeepSave,
							new object[] { transactionManager, entity.RsrchStudRegisterCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdCourseOutcomesTopics>
				if (CanDeepSave(entity.EdCourseOutcomesTopicsCollection, "List<EdCourseOutcomesTopics>|EdCourseOutcomesTopicsCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdCourseOutcomesTopics child in entity.EdCourseOutcomesTopicsCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.EdCourseOutcomesTopicsCollection.Count > 0 || entity.EdCourseOutcomesTopicsCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdCourseOutcomesTopicsProvider.Save(transactionManager, entity.EdCourseOutcomesTopicsCollection);
						
						deepHandles.Add("EdCourseOutcomesTopicsCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdCourseOutcomesTopics >) DataRepository.EdCourseOutcomesTopicsProvider.DeepSave,
							new object[] { transactionManager, entity.EdCourseOutcomesTopicsCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SvStudAskAdv>
				if (CanDeepSave(entity.SvStudAskAdvCollection, "List<SvStudAskAdv>|SvStudAskAdvCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvStudAskAdv child in entity.SvStudAskAdvCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.SvStudAskAdvCollection.Count > 0 || entity.SvStudAskAdvCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvStudAskAdvProvider.Save(transactionManager, entity.SvStudAskAdvCollection);
						
						deepHandles.Add("SvStudAskAdvCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvStudAskAdv >) DataRepository.SvStudAskAdvProvider.DeepSave,
							new object[] { transactionManager, entity.SvStudAskAdvCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdCourseTchng>
				if (CanDeepSave(entity.EdCourseTchngCollection, "List<EdCourseTchng>|EdCourseTchngCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdCourseTchng child in entity.EdCourseTchngCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.EdCourseTchngCollection.Count > 0 || entity.EdCourseTchngCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdCourseTchngProvider.Save(transactionManager, entity.EdCourseTchngCollection);
						
						deepHandles.Add("EdCourseTchngCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdCourseTchng >) DataRepository.EdCourseTchngProvider.DeepSave,
							new object[] { transactionManager, entity.EdCourseTchngCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntMajorPhase>
				if (CanDeepSave(entity.EntMajorPhaseCollectionGetByEdCodeSemesterFromId, "List<EntMajorPhase>|EntMajorPhaseCollectionGetByEdCodeSemesterFromId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntMajorPhase child in entity.EntMajorPhaseCollectionGetByEdCodeSemesterFromId)
					{
						if(child.EdCodeSemesterFromIdSource != null)
						{
							child.EdCodeSemesterFromId = child.EdCodeSemesterFromIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterFromId = entity.EdCodeSemesterId;
						}

					}

					if (entity.EntMajorPhaseCollectionGetByEdCodeSemesterFromId.Count > 0 || entity.EntMajorPhaseCollectionGetByEdCodeSemesterFromId.DeletedItems.Count > 0)
					{
						//DataRepository.EntMajorPhaseProvider.Save(transactionManager, entity.EntMajorPhaseCollectionGetByEdCodeSemesterFromId);
						
						deepHandles.Add("EntMajorPhaseCollectionGetByEdCodeSemesterFromId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntMajorPhase >) DataRepository.EntMajorPhaseProvider.DeepSave,
							new object[] { transactionManager, entity.EntMajorPhaseCollectionGetByEdCodeSemesterFromId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdExamSchdl>
				if (CanDeepSave(entity.EdExamSchdlCollection, "List<EdExamSchdl>|EdExamSchdlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdExamSchdl child in entity.EdExamSchdlCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.EdExamSchdlCollection.Count > 0 || entity.EdExamSchdlCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdExamSchdlProvider.Save(transactionManager, entity.EdExamSchdlCollection);
						
						deepHandles.Add("EdExamSchdlCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdExamSchdl >) DataRepository.EdExamSchdlProvider.DeepSave,
							new object[] { transactionManager, entity.EdExamSchdlCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<CoControl>
				if (CanDeepSave(entity.CoControlCollection, "List<CoControl>|CoControlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CoControl child in entity.CoControlCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.CoControlCollection.Count > 0 || entity.CoControlCollection.DeletedItems.Count > 0)
					{
						//DataRepository.CoControlProvider.Save(transactionManager, entity.CoControlCollection);
						
						deepHandles.Add("CoControlCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< CoControl >) DataRepository.CoControlProvider.DeepSave,
							new object[] { transactionManager, entity.CoControlCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudAcadWarn>
				if (CanDeepSave(entity.EdStudAcadWarnCollection, "List<EdStudAcadWarn>|EdStudAcadWarnCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudAcadWarn child in entity.EdStudAcadWarnCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.EdStudAcadWarnCollection.Count > 0 || entity.EdStudAcadWarnCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudAcadWarnProvider.Save(transactionManager, entity.EdStudAcadWarnCollection);
						
						deepHandles.Add("EdStudAcadWarnCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudAcadWarn >) DataRepository.EdStudAcadWarnProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudAcadWarnCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SpoSponsorStud>
				if (CanDeepSave(entity.SpoSponsorStudCollectionGetByEdCodeSemesterToId, "List<SpoSponsorStud>|SpoSponsorStudCollectionGetByEdCodeSemesterToId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SpoSponsorStud child in entity.SpoSponsorStudCollectionGetByEdCodeSemesterToId)
					{
						if(child.EdCodeSemesterToIdSource != null)
						{
							child.EdCodeSemesterToId = child.EdCodeSemesterToIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterToId = entity.EdCodeSemesterId;
						}

					}

					if (entity.SpoSponsorStudCollectionGetByEdCodeSemesterToId.Count > 0 || entity.SpoSponsorStudCollectionGetByEdCodeSemesterToId.DeletedItems.Count > 0)
					{
						//DataRepository.SpoSponsorStudProvider.Save(transactionManager, entity.SpoSponsorStudCollectionGetByEdCodeSemesterToId);
						
						deepHandles.Add("SpoSponsorStudCollectionGetByEdCodeSemesterToId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SpoSponsorStud >) DataRepository.SpoSponsorStudProvider.DeepSave,
							new object[] { transactionManager, entity.SpoSponsorStudCollectionGetByEdCodeSemesterToId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<CoCrsRsltRaise>
				if (CanDeepSave(entity.CoCrsRsltRaiseCollection, "List<CoCrsRsltRaise>|CoCrsRsltRaiseCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CoCrsRsltRaise child in entity.CoCrsRsltRaiseCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.CoCrsRsltRaiseCollection.Count > 0 || entity.CoCrsRsltRaiseCollection.DeletedItems.Count > 0)
					{
						//DataRepository.CoCrsRsltRaiseProvider.Save(transactionManager, entity.CoCrsRsltRaiseCollection);
						
						deepHandles.Add("CoCrsRsltRaiseCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< CoCrsRsltRaise >) DataRepository.CoCrsRsltRaiseProvider.DeepSave,
							new object[] { transactionManager, entity.CoCrsRsltRaiseCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudIntTrnsStateFrom>
				if (CanDeepSave(entity.EdStudIntTrnsStateFromCollection, "List<EdStudIntTrnsStateFrom>|EdStudIntTrnsStateFromCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudIntTrnsStateFrom child in entity.EdStudIntTrnsStateFromCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.EdStudIntTrnsStateFromCollection.Count > 0 || entity.EdStudIntTrnsStateFromCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudIntTrnsStateFromProvider.Save(transactionManager, entity.EdStudIntTrnsStateFromCollection);
						
						deepHandles.Add("EdStudIntTrnsStateFromCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudIntTrnsStateFrom >) DataRepository.EdStudIntTrnsStateFromProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudIntTrnsStateFromCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<MdiStudRecord>
				if (CanDeepSave(entity.MdiStudRecordCollection, "List<MdiStudRecord>|MdiStudRecordCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(MdiStudRecord child in entity.MdiStudRecordCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.MdiStudRecordCollection.Count > 0 || entity.MdiStudRecordCollection.DeletedItems.Count > 0)
					{
						//DataRepository.MdiStudRecordProvider.Save(transactionManager, entity.MdiStudRecordCollection);
						
						deepHandles.Add("MdiStudRecordCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< MdiStudRecord >) DataRepository.MdiStudRecordProvider.DeepSave,
							new object[] { transactionManager, entity.MdiStudRecordCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudLateness>
				if (CanDeepSave(entity.EdStudLatenessCollection, "List<EdStudLateness>|EdStudLatenessCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudLateness child in entity.EdStudLatenessCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.EdStudLatenessCollection.Count > 0 || entity.EdStudLatenessCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudLatenessProvider.Save(transactionManager, entity.EdStudLatenessCollection);
						
						deepHandles.Add("EdStudLatenessCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudLateness >) DataRepository.EdStudLatenessProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudLatenessCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeStudItemCncl>
				if (CanDeepSave(entity.FeeStudItemCnclCollection, "List<FeeStudItemCncl>|FeeStudItemCnclCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeStudItemCncl child in entity.FeeStudItemCnclCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.FeeStudItemCnclCollection.Count > 0 || entity.FeeStudItemCnclCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeStudItemCnclProvider.Save(transactionManager, entity.FeeStudItemCnclCollection);
						
						deepHandles.Add("FeeStudItemCnclCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeStudItemCncl >) DataRepository.FeeStudItemCnclProvider.DeepSave,
							new object[] { transactionManager, entity.FeeStudItemCnclCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudBranchPref>
				if (CanDeepSave(entity.EdStudBranchPrefCollection, "List<EdStudBranchPref>|EdStudBranchPrefCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudBranchPref child in entity.EdStudBranchPrefCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.EdStudBranchPrefCollection.Count > 0 || entity.EdStudBranchPrefCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudBranchPrefProvider.Save(transactionManager, entity.EdStudBranchPrefCollection);
						
						deepHandles.Add("EdStudBranchPrefCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudBranchPref >) DataRepository.EdStudBranchPrefProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudBranchPrefCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdAcdadvRmk>
				if (CanDeepSave(entity.EdAcdadvRmkCollection, "List<EdAcdadvRmk>|EdAcdadvRmkCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdAcdadvRmk child in entity.EdAcdadvRmkCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.EdAcdadvRmkCollection.Count > 0 || entity.EdAcdadvRmkCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdAcdadvRmkProvider.Save(transactionManager, entity.EdAcdadvRmkCollection);
						
						deepHandles.Add("EdAcdadvRmkCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdAcdadvRmk >) DataRepository.EdAcdadvRmkProvider.DeepSave,
							new object[] { transactionManager, entity.EdAcdadvRmkCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdCourseInfo>
				if (CanDeepSave(entity.EdCourseInfoCollectionGetByEdCodeSemesterToId, "List<EdCourseInfo>|EdCourseInfoCollectionGetByEdCodeSemesterToId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdCourseInfo child in entity.EdCourseInfoCollectionGetByEdCodeSemesterToId)
					{
						if(child.EdCodeSemesterToIdSource != null)
						{
							child.EdCodeSemesterToId = child.EdCodeSemesterToIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterToId = entity.EdCodeSemesterId;
						}

					}

					if (entity.EdCourseInfoCollectionGetByEdCodeSemesterToId.Count > 0 || entity.EdCourseInfoCollectionGetByEdCodeSemesterToId.DeletedItems.Count > 0)
					{
						//DataRepository.EdCourseInfoProvider.Save(transactionManager, entity.EdCourseInfoCollectionGetByEdCodeSemesterToId);
						
						deepHandles.Add("EdCourseInfoCollectionGetByEdCodeSemesterToId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdCourseInfo >) DataRepository.EdCourseInfoProvider.DeepSave,
							new object[] { transactionManager, entity.EdCourseInfoCollectionGetByEdCodeSemesterToId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeStudPayPostpone>
				if (CanDeepSave(entity.FeeStudPayPostponeCollection, "List<FeeStudPayPostpone>|FeeStudPayPostponeCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeStudPayPostpone child in entity.FeeStudPayPostponeCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.FeeStudPayPostponeCollection.Count > 0 || entity.FeeStudPayPostponeCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeStudPayPostponeProvider.Save(transactionManager, entity.FeeStudPayPostponeCollection);
						
						deepHandles.Add("FeeStudPayPostponeCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeStudPayPostpone >) DataRepository.FeeStudPayPostponeProvider.DeepSave,
							new object[] { transactionManager, entity.FeeStudPayPostponeCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SpoSponsorStud>
				if (CanDeepSave(entity.SpoSponsorStudCollectionGetByEdCodeSemesterId, "List<SpoSponsorStud>|SpoSponsorStudCollectionGetByEdCodeSemesterId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SpoSponsorStud child in entity.SpoSponsorStudCollectionGetByEdCodeSemesterId)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.SpoSponsorStudCollectionGetByEdCodeSemesterId.Count > 0 || entity.SpoSponsorStudCollectionGetByEdCodeSemesterId.DeletedItems.Count > 0)
					{
						//DataRepository.SpoSponsorStudProvider.Save(transactionManager, entity.SpoSponsorStudCollectionGetByEdCodeSemesterId);
						
						deepHandles.Add("SpoSponsorStudCollectionGetByEdCodeSemesterId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SpoSponsorStud >) DataRepository.SpoSponsorStudProvider.DeepSave,
							new object[] { transactionManager, entity.SpoSponsorStudCollectionGetByEdCodeSemesterId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SvSrvyHdr>
				if (CanDeepSave(entity.SvSrvyHdrCollection, "List<SvSrvyHdr>|SvSrvyHdrCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvSrvyHdr child in entity.SvSrvyHdrCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.SvSrvyHdrCollection.Count > 0 || entity.SvSrvyHdrCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvSrvyHdrProvider.Save(transactionManager, entity.SvSrvyHdrCollection);
						
						deepHandles.Add("SvSrvyHdrCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvSrvyHdr >) DataRepository.SvSrvyHdrProvider.DeepSave,
							new object[] { transactionManager, entity.SvSrvyHdrCollection, deepSaveType, childTypes, innerList }
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
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
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
				
	
			#region List<MltStudInfo>
				if (CanDeepSave(entity.MltStudInfoCollection, "List<MltStudInfo>|MltStudInfoCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(MltStudInfo child in entity.MltStudInfoCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.MltStudInfoCollection.Count > 0 || entity.MltStudInfoCollection.DeletedItems.Count > 0)
					{
						//DataRepository.MltStudInfoProvider.Save(transactionManager, entity.MltStudInfoCollection);
						
						deepHandles.Add("MltStudInfoCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< MltStudInfo >) DataRepository.MltStudInfoProvider.DeepSave,
							new object[] { transactionManager, entity.MltStudInfoCollection, deepSaveType, childTypes, innerList }
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
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
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
				
	
			#region List<EdStudEnrollChange>
				if (CanDeepSave(entity.EdStudEnrollChangeCollectionGetByEdCodeSemesterToId, "List<EdStudEnrollChange>|EdStudEnrollChangeCollectionGetByEdCodeSemesterToId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudEnrollChange child in entity.EdStudEnrollChangeCollectionGetByEdCodeSemesterToId)
					{
						if(child.EdCodeSemesterToIdSource != null)
						{
							child.EdCodeSemesterToId = child.EdCodeSemesterToIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterToId = entity.EdCodeSemesterId;
						}

					}

					if (entity.EdStudEnrollChangeCollectionGetByEdCodeSemesterToId.Count > 0 || entity.EdStudEnrollChangeCollectionGetByEdCodeSemesterToId.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudEnrollChangeProvider.Save(transactionManager, entity.EdStudEnrollChangeCollectionGetByEdCodeSemesterToId);
						
						deepHandles.Add("EdStudEnrollChangeCollectionGetByEdCodeSemesterToId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudEnrollChange >) DataRepository.EdStudEnrollChangeProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudEnrollChangeCollectionGetByEdCodeSemesterToId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudAcadmicAdv>
				if (CanDeepSave(entity.EdStudAcadmicAdvCollection, "List<EdStudAcadmicAdv>|EdStudAcadmicAdvCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudAcadmicAdv child in entity.EdStudAcadmicAdvCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.EdStudAcadmicAdvCollection.Count > 0 || entity.EdStudAcadmicAdvCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudAcadmicAdvProvider.Save(transactionManager, entity.EdStudAcadmicAdvCollection);
						
						deepHandles.Add("EdStudAcadmicAdvCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudAcadmicAdv >) DataRepository.EdStudAcadmicAdvProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudAcadmicAdvCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdInttransRule>
				if (CanDeepSave(entity.EdInttransRuleCollection, "List<EdInttransRule>|EdInttransRuleCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdInttransRule child in entity.EdInttransRuleCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.EdInttransRuleCollection.Count > 0 || entity.EdInttransRuleCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdInttransRuleProvider.Save(transactionManager, entity.EdInttransRuleCollection);
						
						deepHandles.Add("EdInttransRuleCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdInttransRule >) DataRepository.EdInttransRuleProvider.DeepSave,
							new object[] { transactionManager, entity.EdInttransRuleCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SpoOfferStudException>
				if (CanDeepSave(entity.SpoOfferStudExceptionCollection, "List<SpoOfferStudException>|SpoOfferStudExceptionCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SpoOfferStudException child in entity.SpoOfferStudExceptionCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.SpoOfferStudExceptionCollection.Count > 0 || entity.SpoOfferStudExceptionCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SpoOfferStudExceptionProvider.Save(transactionManager, entity.SpoOfferStudExceptionCollection);
						
						deepHandles.Add("SpoOfferStudExceptionCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SpoOfferStudException >) DataRepository.SpoOfferStudExceptionProvider.DeepSave,
							new object[] { transactionManager, entity.SpoOfferStudExceptionCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeRefundCode>
				if (CanDeepSave(entity.FeeRefundCodeCollection, "List<FeeRefundCode>|FeeRefundCodeCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeRefundCode child in entity.FeeRefundCodeCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.FeeRefundCodeCollection.Count > 0 || entity.FeeRefundCodeCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeRefundCodeProvider.Save(transactionManager, entity.FeeRefundCodeCollection);
						
						deepHandles.Add("FeeRefundCodeCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeRefundCode >) DataRepository.FeeRefundCodeProvider.DeepSave,
							new object[] { transactionManager, entity.FeeRefundCodeCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeStudVoucher>
				if (CanDeepSave(entity.FeeStudVoucherCollection, "List<FeeStudVoucher>|FeeStudVoucherCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeStudVoucher child in entity.FeeStudVoucherCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.FeeStudVoucherCollection.Count > 0 || entity.FeeStudVoucherCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeStudVoucherProvider.Save(transactionManager, entity.FeeStudVoucherCollection);
						
						deepHandles.Add("FeeStudVoucherCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeStudVoucher >) DataRepository.FeeStudVoucherProvider.DeepSave,
							new object[] { transactionManager, entity.FeeStudVoucherCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SpoSponsorStudSemester>
				if (CanDeepSave(entity.SpoSponsorStudSemesterCollection, "List<SpoSponsorStudSemester>|SpoSponsorStudSemesterCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SpoSponsorStudSemester child in entity.SpoSponsorStudSemesterCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.SpoSponsorStudSemesterCollection.Count > 0 || entity.SpoSponsorStudSemesterCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SpoSponsorStudSemesterProvider.Save(transactionManager, entity.SpoSponsorStudSemesterCollection);
						
						deepHandles.Add("SpoSponsorStudSemesterCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SpoSponsorStudSemester >) DataRepository.SpoSponsorStudSemesterProvider.DeepSave,
							new object[] { transactionManager, entity.SpoSponsorStudSemesterCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeStudFund>
				if (CanDeepSave(entity.FeeStudFundCollection, "List<FeeStudFund>|FeeStudFundCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeStudFund child in entity.FeeStudFundCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.FeeStudFundCollection.Count > 0 || entity.FeeStudFundCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeStudFundProvider.Save(transactionManager, entity.FeeStudFundCollection);
						
						deepHandles.Add("FeeStudFundCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeStudFund >) DataRepository.FeeStudFundProvider.DeepSave,
							new object[] { transactionManager, entity.FeeStudFundCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeStudDisc>
				if (CanDeepSave(entity.FeeStudDiscCollection, "List<FeeStudDisc>|FeeStudDiscCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeStudDisc child in entity.FeeStudDiscCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.FeeStudDiscCollection.Count > 0 || entity.FeeStudDiscCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeStudDiscProvider.Save(transactionManager, entity.FeeStudDiscCollection);
						
						deepHandles.Add("FeeStudDiscCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeStudDisc >) DataRepository.FeeStudDiscProvider.DeepSave,
							new object[] { transactionManager, entity.FeeStudDiscCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeStudCoursesItem>
				if (CanDeepSave(entity.FeeStudCoursesItemCollection, "List<FeeStudCoursesItem>|FeeStudCoursesItemCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeStudCoursesItem child in entity.FeeStudCoursesItemCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.FeeStudCoursesItemCollection.Count > 0 || entity.FeeStudCoursesItemCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeStudCoursesItemProvider.Save(transactionManager, entity.FeeStudCoursesItemCollection);
						
						deepHandles.Add("FeeStudCoursesItemCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeStudCoursesItem >) DataRepository.FeeStudCoursesItemProvider.DeepSave,
							new object[] { transactionManager, entity.FeeStudCoursesItemCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdSemesterOpen>
				if (CanDeepSave(entity.EdSemesterOpenCollection, "List<EdSemesterOpen>|EdSemesterOpenCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdSemesterOpen child in entity.EdSemesterOpenCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.EdSemesterOpenCollection.Count > 0 || entity.EdSemesterOpenCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdSemesterOpenProvider.Save(transactionManager, entity.EdSemesterOpenCollection);
						
						deepHandles.Add("EdSemesterOpenCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdSemesterOpen >) DataRepository.EdSemesterOpenProvider.DeepSave,
							new object[] { transactionManager, entity.EdSemesterOpenCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaOfficeHour>
				if (CanDeepSave(entity.SaOfficeHourCollection, "List<SaOfficeHour>|SaOfficeHourCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaOfficeHour child in entity.SaOfficeHourCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.SaOfficeHourCollection.Count > 0 || entity.SaOfficeHourCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaOfficeHourProvider.Save(transactionManager, entity.SaOfficeHourCollection);
						
						deepHandles.Add("SaOfficeHourCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaOfficeHour >) DataRepository.SaOfficeHourProvider.DeepSave,
							new object[] { transactionManager, entity.SaOfficeHourCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<CtrStudExp>
				if (CanDeepSave(entity.CtrStudExpCollection, "List<CtrStudExp>|CtrStudExpCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CtrStudExp child in entity.CtrStudExpCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.CtrStudExpCollection.Count > 0 || entity.CtrStudExpCollection.DeletedItems.Count > 0)
					{
						//DataRepository.CtrStudExpProvider.Save(transactionManager, entity.CtrStudExpCollection);
						
						deepHandles.Add("CtrStudExpCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< CtrStudExp >) DataRepository.CtrStudExpProvider.DeepSave,
							new object[] { transactionManager, entity.CtrStudExpCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<MdiStudClnq>
				if (CanDeepSave(entity.MdiStudClnqCollection, "List<MdiStudClnq>|MdiStudClnqCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(MdiStudClnq child in entity.MdiStudClnqCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.MdiStudClnqCollection.Count > 0 || entity.MdiStudClnqCollection.DeletedItems.Count > 0)
					{
						//DataRepository.MdiStudClnqProvider.Save(transactionManager, entity.MdiStudClnqCollection);
						
						deepHandles.Add("MdiStudClnqCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< MdiStudClnq >) DataRepository.MdiStudClnqProvider.DeepSave,
							new object[] { transactionManager, entity.MdiStudClnqCollection, deepSaveType, childTypes, innerList }
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
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
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
				
	
			#region List<GsAgendaHoliday>
				if (CanDeepSave(entity.GsAgendaHolidayCollection, "List<GsAgendaHoliday>|GsAgendaHolidayCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GsAgendaHoliday child in entity.GsAgendaHolidayCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.GsAgendaHolidayCollection.Count > 0 || entity.GsAgendaHolidayCollection.DeletedItems.Count > 0)
					{
						//DataRepository.GsAgendaHolidayProvider.Save(transactionManager, entity.GsAgendaHolidayCollection);
						
						deepHandles.Add("GsAgendaHolidayCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< GsAgendaHoliday >) DataRepository.GsAgendaHolidayProvider.DeepSave,
							new object[] { transactionManager, entity.GsAgendaHolidayCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudViol>
				if (CanDeepSave(entity.EdStudViolCollectionGetByEdCodeSemesterId, "List<EdStudViol>|EdStudViolCollectionGetByEdCodeSemesterId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudViol child in entity.EdStudViolCollectionGetByEdCodeSemesterId)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.EdStudViolCollectionGetByEdCodeSemesterId.Count > 0 || entity.EdStudViolCollectionGetByEdCodeSemesterId.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudViolProvider.Save(transactionManager, entity.EdStudViolCollectionGetByEdCodeSemesterId);
						
						deepHandles.Add("EdStudViolCollectionGetByEdCodeSemesterId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudViol >) DataRepository.EdStudViolProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudViolCollectionGetByEdCodeSemesterId, deepSaveType, childTypes, innerList }
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
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
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
				
	
			#region List<AccomStudAbsence>
				if (CanDeepSave(entity.AccomStudAbsenceCollection, "List<AccomStudAbsence>|AccomStudAbsenceCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AccomStudAbsence child in entity.AccomStudAbsenceCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.AccomStudAbsenceCollection.Count > 0 || entity.AccomStudAbsenceCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AccomStudAbsenceProvider.Save(transactionManager, entity.AccomStudAbsenceCollection);
						
						deepHandles.Add("AccomStudAbsenceCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AccomStudAbsence >) DataRepository.AccomStudAbsenceProvider.DeepSave,
							new object[] { transactionManager, entity.AccomStudAbsenceCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<PgOffering>
				if (CanDeepSave(entity.PgOfferingCollection, "List<PgOffering>|PgOfferingCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgOffering child in entity.PgOfferingCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.PgOfferingCollection.Count > 0 || entity.PgOfferingCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgOfferingProvider.Save(transactionManager, entity.PgOfferingCollection);
						
						deepHandles.Add("PgOfferingCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgOffering >) DataRepository.PgOfferingProvider.DeepSave,
							new object[] { transactionManager, entity.PgOfferingCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeItemTrnsBlnc>
				if (CanDeepSave(entity.FeeItemTrnsBlncCollection, "List<FeeItemTrnsBlnc>|FeeItemTrnsBlncCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeItemTrnsBlnc child in entity.FeeItemTrnsBlncCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.FeeItemTrnsBlncCollection.Count > 0 || entity.FeeItemTrnsBlncCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeItemTrnsBlncProvider.Save(transactionManager, entity.FeeItemTrnsBlncCollection);
						
						deepHandles.Add("FeeItemTrnsBlncCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeItemTrnsBlnc >) DataRepository.FeeItemTrnsBlncProvider.DeepSave,
							new object[] { transactionManager, entity.FeeItemTrnsBlncCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EntMajorPhase>
				if (CanDeepSave(entity.EntMajorPhaseCollectionGetByEdCodeSemesterToId, "List<EntMajorPhase>|EntMajorPhaseCollectionGetByEdCodeSemesterToId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EntMajorPhase child in entity.EntMajorPhaseCollectionGetByEdCodeSemesterToId)
					{
						if(child.EdCodeSemesterToIdSource != null)
						{
							child.EdCodeSemesterToId = child.EdCodeSemesterToIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterToId = entity.EdCodeSemesterId;
						}

					}

					if (entity.EntMajorPhaseCollectionGetByEdCodeSemesterToId.Count > 0 || entity.EntMajorPhaseCollectionGetByEdCodeSemesterToId.DeletedItems.Count > 0)
					{
						//DataRepository.EntMajorPhaseProvider.Save(transactionManager, entity.EntMajorPhaseCollectionGetByEdCodeSemesterToId);
						
						deepHandles.Add("EntMajorPhaseCollectionGetByEdCodeSemesterToId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EntMajorPhase >) DataRepository.EntMajorPhaseProvider.DeepSave,
							new object[] { transactionManager, entity.EntMajorPhaseCollectionGetByEdCodeSemesterToId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdCourseInfo>
				if (CanDeepSave(entity.EdCourseInfoCollectionGetByEdCodeSemesterFromId, "List<EdCourseInfo>|EdCourseInfoCollectionGetByEdCodeSemesterFromId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdCourseInfo child in entity.EdCourseInfoCollectionGetByEdCodeSemesterFromId)
					{
						if(child.EdCodeSemesterFromIdSource != null)
						{
							child.EdCodeSemesterFromId = child.EdCodeSemesterFromIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterFromId = entity.EdCodeSemesterId;
						}

					}

					if (entity.EdCourseInfoCollectionGetByEdCodeSemesterFromId.Count > 0 || entity.EdCourseInfoCollectionGetByEdCodeSemesterFromId.DeletedItems.Count > 0)
					{
						//DataRepository.EdCourseInfoProvider.Save(transactionManager, entity.EdCourseInfoCollectionGetByEdCodeSemesterFromId);
						
						deepHandles.Add("EdCourseInfoCollectionGetByEdCodeSemesterFromId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdCourseInfo >) DataRepository.EdCourseInfoProvider.DeepSave,
							new object[] { transactionManager, entity.EdCourseInfoCollectionGetByEdCodeSemesterFromId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeStudInstallment>
				if (CanDeepSave(entity.FeeStudInstallmentCollection, "List<FeeStudInstallment>|FeeStudInstallmentCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeStudInstallment child in entity.FeeStudInstallmentCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.FeeStudInstallmentCollection.Count > 0 || entity.FeeStudInstallmentCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeStudInstallmentProvider.Save(transactionManager, entity.FeeStudInstallmentCollection);
						
						deepHandles.Add("FeeStudInstallmentCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeStudInstallment >) DataRepository.FeeStudInstallmentProvider.DeepSave,
							new object[] { transactionManager, entity.FeeStudInstallmentCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmFeePromocode>
				if (CanDeepSave(entity.AdmFeePromocodeCollection, "List<AdmFeePromocode>|AdmFeePromocodeCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmFeePromocode child in entity.AdmFeePromocodeCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.AdmFeePromocodeCollection.Count > 0 || entity.AdmFeePromocodeCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AdmFeePromocodeProvider.Save(transactionManager, entity.AdmFeePromocodeCollection);
						
						deepHandles.Add("AdmFeePromocodeCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AdmFeePromocode >) DataRepository.AdmFeePromocodeProvider.DeepSave,
							new object[] { transactionManager, entity.AdmFeePromocodeCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudViol>
				if (CanDeepSave(entity.EdStudViolCollectionGetByEdCodeSemesterStopFromId, "List<EdStudViol>|EdStudViolCollectionGetByEdCodeSemesterStopFromId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudViol child in entity.EdStudViolCollectionGetByEdCodeSemesterStopFromId)
					{
						if(child.EdCodeSemesterStopFromIdSource != null)
						{
							child.EdCodeSemesterStopFromId = child.EdCodeSemesterStopFromIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterStopFromId = entity.EdCodeSemesterId;
						}

					}

					if (entity.EdStudViolCollectionGetByEdCodeSemesterStopFromId.Count > 0 || entity.EdStudViolCollectionGetByEdCodeSemesterStopFromId.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudViolProvider.Save(transactionManager, entity.EdStudViolCollectionGetByEdCodeSemesterStopFromId);
						
						deepHandles.Add("EdStudViolCollectionGetByEdCodeSemesterStopFromId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudViol >) DataRepository.EdStudViolProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudViolCollectionGetByEdCodeSemesterStopFromId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdBranchRule>
				if (CanDeepSave(entity.EdBranchRuleCollection, "List<EdBranchRule>|EdBranchRuleCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdBranchRule child in entity.EdBranchRuleCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.EdBranchRuleCollection.Count > 0 || entity.EdBranchRuleCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdBranchRuleProvider.Save(transactionManager, entity.EdBranchRuleCollection);
						
						deepHandles.Add("EdBranchRuleCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdBranchRule >) DataRepository.EdBranchRuleProvider.DeepSave,
							new object[] { transactionManager, entity.EdBranchRuleCollection, deepSaveType, childTypes, innerList }
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
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
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
				
	
			#region List<EdStudProblem>
				if (CanDeepSave(entity.EdStudProblemCollection, "List<EdStudProblem>|EdStudProblemCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudProblem child in entity.EdStudProblemCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.EdStudProblemCollection.Count > 0 || entity.EdStudProblemCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudProblemProvider.Save(transactionManager, entity.EdStudProblemCollection);
						
						deepHandles.Add("EdStudProblemCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudProblem >) DataRepository.EdStudProblemProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudProblemCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SpoSponsorOffer>
				if (CanDeepSave(entity.SpoSponsorOfferCollectionGetByEdCodeSemesterFromId, "List<SpoSponsorOffer>|SpoSponsorOfferCollectionGetByEdCodeSemesterFromId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SpoSponsorOffer child in entity.SpoSponsorOfferCollectionGetByEdCodeSemesterFromId)
					{
						if(child.EdCodeSemesterFromIdSource != null)
						{
							child.EdCodeSemesterFromId = child.EdCodeSemesterFromIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterFromId = entity.EdCodeSemesterId;
						}

					}

					if (entity.SpoSponsorOfferCollectionGetByEdCodeSemesterFromId.Count > 0 || entity.SpoSponsorOfferCollectionGetByEdCodeSemesterFromId.DeletedItems.Count > 0)
					{
						//DataRepository.SpoSponsorOfferProvider.Save(transactionManager, entity.SpoSponsorOfferCollectionGetByEdCodeSemesterFromId);
						
						deepHandles.Add("SpoSponsorOfferCollectionGetByEdCodeSemesterFromId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SpoSponsorOffer >) DataRepository.SpoSponsorOfferProvider.DeepSave,
							new object[] { transactionManager, entity.SpoSponsorOfferCollectionGetByEdCodeSemesterFromId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeItemSemester>
				if (CanDeepSave(entity.FeeItemSemesterCollection, "List<FeeItemSemester>|FeeItemSemesterCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeItemSemester child in entity.FeeItemSemesterCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.FeeItemSemesterCollection.Count > 0 || entity.FeeItemSemesterCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeItemSemesterProvider.Save(transactionManager, entity.FeeItemSemesterCollection);
						
						deepHandles.Add("FeeItemSemesterCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeItemSemester >) DataRepository.FeeItemSemesterProvider.DeepSave,
							new object[] { transactionManager, entity.FeeItemSemesterCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<ScSectionGroupHdr>
				if (CanDeepSave(entity.ScSectionGroupHdrCollection, "List<ScSectionGroupHdr>|ScSectionGroupHdrCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScSectionGroupHdr child in entity.ScSectionGroupHdrCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.ScSectionGroupHdrCollection.Count > 0 || entity.ScSectionGroupHdrCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ScSectionGroupHdrProvider.Save(transactionManager, entity.ScSectionGroupHdrCollection);
						
						deepHandles.Add("ScSectionGroupHdrCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ScSectionGroupHdr >) DataRepository.ScSectionGroupHdrProvider.DeepSave,
							new object[] { transactionManager, entity.ScSectionGroupHdrCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<CtrStudOut>
				if (CanDeepSave(entity.CtrStudOutCollection, "List<CtrStudOut>|CtrStudOutCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CtrStudOut child in entity.CtrStudOutCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.CtrStudOutCollection.Count > 0 || entity.CtrStudOutCollection.DeletedItems.Count > 0)
					{
						//DataRepository.CtrStudOutProvider.Save(transactionManager, entity.CtrStudOutCollection);
						
						deepHandles.Add("CtrStudOutCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< CtrStudOut >) DataRepository.CtrStudOutProvider.DeepSave,
							new object[] { transactionManager, entity.CtrStudOutCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<TrnsStudReq>
				if (CanDeepSave(entity.TrnsStudReqCollection, "List<TrnsStudReq>|TrnsStudReqCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(TrnsStudReq child in entity.TrnsStudReqCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.TrnsStudReqCollection.Count > 0 || entity.TrnsStudReqCollection.DeletedItems.Count > 0)
					{
						//DataRepository.TrnsStudReqProvider.Save(transactionManager, entity.TrnsStudReqCollection);
						
						deepHandles.Add("TrnsStudReqCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< TrnsStudReq >) DataRepository.TrnsStudReqProvider.DeepSave,
							new object[] { transactionManager, entity.TrnsStudReqCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudExmptReq>
				if (CanDeepSave(entity.EdStudExmptReqCollection, "List<EdStudExmptReq>|EdStudExmptReqCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudExmptReq child in entity.EdStudExmptReqCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.EdStudExmptReqCollection.Count > 0 || entity.EdStudExmptReqCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudExmptReqProvider.Save(transactionManager, entity.EdStudExmptReqCollection);
						
						deepHandles.Add("EdStudExmptReqCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudExmptReq >) DataRepository.EdStudExmptReqProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudExmptReqCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeStudRetrieveRequest>
				if (CanDeepSave(entity.FeeStudRetrieveRequestCollection, "List<FeeStudRetrieveRequest>|FeeStudRetrieveRequestCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeStudRetrieveRequest child in entity.FeeStudRetrieveRequestCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.FeeStudRetrieveRequestCollection.Count > 0 || entity.FeeStudRetrieveRequestCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeStudRetrieveRequestProvider.Save(transactionManager, entity.FeeStudRetrieveRequestCollection);
						
						deepHandles.Add("FeeStudRetrieveRequestCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeStudRetrieveRequest >) DataRepository.FeeStudRetrieveRequestProvider.DeepSave,
							new object[] { transactionManager, entity.FeeStudRetrieveRequestCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SvCourseEval>
				if (CanDeepSave(entity.SvCourseEvalCollection, "List<SvCourseEval>|SvCourseEvalCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvCourseEval child in entity.SvCourseEvalCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.SvCourseEvalCollection.Count > 0 || entity.SvCourseEvalCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvCourseEvalProvider.Save(transactionManager, entity.SvCourseEvalCollection);
						
						deepHandles.Add("SvCourseEvalCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvCourseEval >) DataRepository.SvCourseEvalProvider.DeepSave,
							new object[] { transactionManager, entity.SvCourseEvalCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<RsrchStudPostponeReq>
				if (CanDeepSave(entity.RsrchStudPostponeReqCollection, "List<RsrchStudPostponeReq>|RsrchStudPostponeReqCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(RsrchStudPostponeReq child in entity.RsrchStudPostponeReqCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.RsrchStudPostponeReqCollection.Count > 0 || entity.RsrchStudPostponeReqCollection.DeletedItems.Count > 0)
					{
						//DataRepository.RsrchStudPostponeReqProvider.Save(transactionManager, entity.RsrchStudPostponeReqCollection);
						
						deepHandles.Add("RsrchStudPostponeReqCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< RsrchStudPostponeReq >) DataRepository.RsrchStudPostponeReqProvider.DeepSave,
							new object[] { transactionManager, entity.RsrchStudPostponeReqCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AdmAppRegHistory>
				if (CanDeepSave(entity.AdmAppRegHistoryCollection, "List<AdmAppRegHistory>|AdmAppRegHistoryCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmAppRegHistory child in entity.AdmAppRegHistoryCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
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
				
	
			#region List<EdStudSemester>
				if (CanDeepSave(entity.EdStudSemesterCollection, "List<EdStudSemester>|EdStudSemesterCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudSemester child in entity.EdStudSemesterCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
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
				
	
			#region List<PgThesisGrantDegree>
				if (CanDeepSave(entity.PgThesisGrantDegreeCollection, "List<PgThesisGrantDegree>|PgThesisGrantDegreeCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgThesisGrantDegree child in entity.PgThesisGrantDegreeCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
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
				
	
			#region List<EdStudExecuseReq>
				if (CanDeepSave(entity.EdStudExecuseReqCollection, "List<EdStudExecuseReq>|EdStudExecuseReqCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudExecuseReq child in entity.EdStudExecuseReqCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.EdStudExecuseReqCollection.Count > 0 || entity.EdStudExecuseReqCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudExecuseReqProvider.Save(transactionManager, entity.EdStudExecuseReqCollection);
						
						deepHandles.Add("EdStudExecuseReqCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudExecuseReq >) DataRepository.EdStudExecuseReqProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudExecuseReqCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeRefndStdReq>
				if (CanDeepSave(entity.FeeRefndStdReqCollection, "List<FeeRefndStdReq>|FeeRefndStdReqCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeRefndStdReq child in entity.FeeRefndStdReqCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.FeeRefndStdReqCollection.Count > 0 || entity.FeeRefndStdReqCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeRefndStdReqProvider.Save(transactionManager, entity.FeeRefndStdReqCollection);
						
						deepHandles.Add("FeeRefndStdReqCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeRefndStdReq >) DataRepository.FeeRefndStdReqProvider.DeepSave,
							new object[] { transactionManager, entity.FeeRefndStdReqCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdOffering>
				if (CanDeepSave(entity.EdOfferingCollection, "List<EdOffering>|EdOfferingCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdOffering child in entity.EdOfferingCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.EdOfferingCollection.Count > 0 || entity.EdOfferingCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdOfferingProvider.Save(transactionManager, entity.EdOfferingCollection);
						
						deepHandles.Add("EdOfferingCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdOffering >) DataRepository.EdOfferingProvider.DeepSave,
							new object[] { transactionManager, entity.EdOfferingCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SvLecNote>
				if (CanDeepSave(entity.SvLecNoteCollection, "List<SvLecNote>|SvLecNoteCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvLecNote child in entity.SvLecNoteCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.SvLecNoteCollection.Count > 0 || entity.SvLecNoteCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvLecNoteProvider.Save(transactionManager, entity.SvLecNoteCollection);
						
						deepHandles.Add("SvLecNoteCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvLecNote >) DataRepository.SvLecNoteProvider.DeepSave,
							new object[] { transactionManager, entity.SvLecNoteCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudAbsence>
				if (CanDeepSave(entity.EdStudAbsenceCollection, "List<EdStudAbsence>|EdStudAbsenceCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudAbsence child in entity.EdStudAbsenceCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.EdStudAbsenceCollection.Count > 0 || entity.EdStudAbsenceCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudAbsenceProvider.Save(transactionManager, entity.EdStudAbsenceCollection);
						
						deepHandles.Add("EdStudAbsenceCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudAbsence >) DataRepository.EdStudAbsenceProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudAbsenceCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudAbsFw>
				if (CanDeepSave(entity.EdStudAbsFwCollection, "List<EdStudAbsFw>|EdStudAbsFwCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudAbsFw child in entity.EdStudAbsFwCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.EdStudAbsFwCollection.Count > 0 || entity.EdStudAbsFwCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudAbsFwProvider.Save(transactionManager, entity.EdStudAbsFwCollection);
						
						deepHandles.Add("EdStudAbsFwCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudAbsFw >) DataRepository.EdStudAbsFwProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudAbsFwCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeStudInstallmentRequest>
				if (CanDeepSave(entity.FeeStudInstallmentRequestCollection, "List<FeeStudInstallmentRequest>|FeeStudInstallmentRequestCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeStudInstallmentRequest child in entity.FeeStudInstallmentRequestCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.FeeStudInstallmentRequestCollection.Count > 0 || entity.FeeStudInstallmentRequestCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeStudInstallmentRequestProvider.Save(transactionManager, entity.FeeStudInstallmentRequestCollection);
						
						deepHandles.Add("FeeStudInstallmentRequestCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeStudInstallmentRequest >) DataRepository.FeeStudInstallmentRequestProvider.DeepSave,
							new object[] { transactionManager, entity.FeeStudInstallmentRequestCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<MltRptDayStudSts>
				if (CanDeepSave(entity.MltRptDayStudStsCollection, "List<MltRptDayStudSts>|MltRptDayStudStsCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(MltRptDayStudSts child in entity.MltRptDayStudStsCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.MltRptDayStudStsCollection.Count > 0 || entity.MltRptDayStudStsCollection.DeletedItems.Count > 0)
					{
						//DataRepository.MltRptDayStudStsProvider.Save(transactionManager, entity.MltRptDayStudStsCollection);
						
						deepHandles.Add("MltRptDayStudStsCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< MltRptDayStudSts >) DataRepository.MltRptDayStudStsProvider.DeepSave,
							new object[] { transactionManager, entity.MltRptDayStudStsCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SvUserTask>
				if (CanDeepSave(entity.SvUserTaskCollection, "List<SvUserTask>|SvUserTaskCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvUserTask child in entity.SvUserTaskCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
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
				
	
			#region List<EdStudEnrollChange>
				if (CanDeepSave(entity.EdStudEnrollChangeCollectionGetByEdCodeSemesterFromId, "List<EdStudEnrollChange>|EdStudEnrollChangeCollectionGetByEdCodeSemesterFromId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudEnrollChange child in entity.EdStudEnrollChangeCollectionGetByEdCodeSemesterFromId)
					{
						if(child.EdCodeSemesterFromIdSource != null)
						{
							child.EdCodeSemesterFromId = child.EdCodeSemesterFromIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterFromId = entity.EdCodeSemesterId;
						}

					}

					if (entity.EdStudEnrollChangeCollectionGetByEdCodeSemesterFromId.Count > 0 || entity.EdStudEnrollChangeCollectionGetByEdCodeSemesterFromId.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudEnrollChangeProvider.Save(transactionManager, entity.EdStudEnrollChangeCollectionGetByEdCodeSemesterFromId);
						
						deepHandles.Add("EdStudEnrollChangeCollectionGetByEdCodeSemesterFromId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudEnrollChange >) DataRepository.EdStudEnrollChangeProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudEnrollChangeCollectionGetByEdCodeSemesterFromId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudViol>
				if (CanDeepSave(entity.EdStudViolCollectionGetByEdCodeSemesterStopToId, "List<EdStudViol>|EdStudViolCollectionGetByEdCodeSemesterStopToId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudViol child in entity.EdStudViolCollectionGetByEdCodeSemesterStopToId)
					{
						if(child.EdCodeSemesterStopToIdSource != null)
						{
							child.EdCodeSemesterStopToId = child.EdCodeSemesterStopToIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterStopToId = entity.EdCodeSemesterId;
						}

					}

					if (entity.EdStudViolCollectionGetByEdCodeSemesterStopToId.Count > 0 || entity.EdStudViolCollectionGetByEdCodeSemesterStopToId.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudViolProvider.Save(transactionManager, entity.EdStudViolCollectionGetByEdCodeSemesterStopToId);
						
						deepHandles.Add("EdStudViolCollectionGetByEdCodeSemesterStopToId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudViol >) DataRepository.EdStudViolProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudViolCollectionGetByEdCodeSemesterStopToId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AccomStudReq>
				if (CanDeepSave(entity.AccomStudReqCollection, "List<AccomStudReq>|AccomStudReqCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AccomStudReq child in entity.AccomStudReqCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.AccomStudReqCollection.Count > 0 || entity.AccomStudReqCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AccomStudReqProvider.Save(transactionManager, entity.AccomStudReqCollection);
						
						deepHandles.Add("AccomStudReqCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AccomStudReq >) DataRepository.AccomStudReqProvider.DeepSave,
							new object[] { transactionManager, entity.AccomStudReqCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdAcadPlanHdr>
				if (CanDeepSave(entity.EdAcadPlanHdrCollection, "List<EdAcadPlanHdr>|EdAcadPlanHdrCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdAcadPlanHdr child in entity.EdAcadPlanHdrCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.EdAcadPlanHdrCollection.Count > 0 || entity.EdAcadPlanHdrCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdAcadPlanHdrProvider.Save(transactionManager, entity.EdAcadPlanHdrCollection);
						
						deepHandles.Add("EdAcadPlanHdrCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdAcadPlanHdr >) DataRepository.EdAcadPlanHdrProvider.DeepSave,
							new object[] { transactionManager, entity.EdAcadPlanHdrCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SvStaffEvl>
				if (CanDeepSave(entity.SvStaffEvlCollection, "List<SvStaffEvl>|SvStaffEvlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvStaffEvl child in entity.SvStaffEvlCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.SvStaffEvlCollection.Count > 0 || entity.SvStaffEvlCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvStaffEvlProvider.Save(transactionManager, entity.SvStaffEvlCollection);
						
						deepHandles.Add("SvStaffEvlCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvStaffEvl >) DataRepository.SvStaffEvlProvider.DeepSave,
							new object[] { transactionManager, entity.SvStaffEvlCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SeUserCrsAssess>
				if (CanDeepSave(entity.SeUserCrsAssessCollection, "List<SeUserCrsAssess>|SeUserCrsAssessCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SeUserCrsAssess child in entity.SeUserCrsAssessCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.SeUserCrsAssessCollection.Count > 0 || entity.SeUserCrsAssessCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SeUserCrsAssessProvider.Save(transactionManager, entity.SeUserCrsAssessCollection);
						
						deepHandles.Add("SeUserCrsAssessCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SeUserCrsAssess >) DataRepository.SeUserCrsAssessProvider.DeepSave,
							new object[] { transactionManager, entity.SeUserCrsAssessCollection, deepSaveType, childTypes, innerList }
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
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
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
				if (CanDeepSave(entity.EdStudFacultyCollectionGetByEdCodeSemesterId, "List<EdStudFaculty>|EdStudFacultyCollectionGetByEdCodeSemesterId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudFaculty child in entity.EdStudFacultyCollectionGetByEdCodeSemesterId)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.EdStudFacultyCollectionGetByEdCodeSemesterId.Count > 0 || entity.EdStudFacultyCollectionGetByEdCodeSemesterId.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudFacultyProvider.Save(transactionManager, entity.EdStudFacultyCollectionGetByEdCodeSemesterId);
						
						deepHandles.Add("EdStudFacultyCollectionGetByEdCodeSemesterId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudFaculty >) DataRepository.EdStudFacultyProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudFacultyCollectionGetByEdCodeSemesterId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudIntTrnsStateTo>
				if (CanDeepSave(entity.EdStudIntTrnsStateToCollection, "List<EdStudIntTrnsStateTo>|EdStudIntTrnsStateToCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudIntTrnsStateTo child in entity.EdStudIntTrnsStateToCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.EdStudIntTrnsStateToCollection.Count > 0 || entity.EdStudIntTrnsStateToCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudIntTrnsStateToProvider.Save(transactionManager, entity.EdStudIntTrnsStateToCollection);
						
						deepHandles.Add("EdStudIntTrnsStateToCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudIntTrnsStateTo >) DataRepository.EdStudIntTrnsStateToProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudIntTrnsStateToCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<FeeStudFeeItem>
				if (CanDeepSave(entity.FeeStudFeeItemCollection, "List<FeeStudFeeItem>|FeeStudFeeItemCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeStudFeeItem child in entity.FeeStudFeeItemCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.FeeStudFeeItemCollection.Count > 0 || entity.FeeStudFeeItemCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeStudFeeItemProvider.Save(transactionManager, entity.FeeStudFeeItemCollection);
						
						deepHandles.Add("FeeStudFeeItemCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeStudFeeItem >) DataRepository.FeeStudFeeItemProvider.DeepSave,
							new object[] { transactionManager, entity.FeeStudFeeItemCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdPrintReq>
				if (CanDeepSave(entity.EdPrintReqCollection, "List<EdPrintReq>|EdPrintReqCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdPrintReq child in entity.EdPrintReqCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.EdPrintReqCollection.Count > 0 || entity.EdPrintReqCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdPrintReqProvider.Save(transactionManager, entity.EdPrintReqCollection);
						
						deepHandles.Add("EdPrintReqCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdPrintReq >) DataRepository.EdPrintReqProvider.DeepSave,
							new object[] { transactionManager, entity.EdPrintReqCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudTransFromReq>
				if (CanDeepSave(entity.EdStudTransFromReqCollection, "List<EdStudTransFromReq>|EdStudTransFromReqCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudTransFromReq child in entity.EdStudTransFromReqCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.EdStudTransFromReqCollection.Count > 0 || entity.EdStudTransFromReqCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudTransFromReqProvider.Save(transactionManager, entity.EdStudTransFromReqCollection);
						
						deepHandles.Add("EdStudTransFromReqCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudTransFromReq >) DataRepository.EdStudTransFromReqProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudTransFromReqCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AccomStudBook>
				if (CanDeepSave(entity.AccomStudBookCollection, "List<AccomStudBook>|AccomStudBookCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AccomStudBook child in entity.AccomStudBookCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.AccomStudBookCollection.Count > 0 || entity.AccomStudBookCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AccomStudBookProvider.Save(transactionManager, entity.AccomStudBookCollection);
						
						deepHandles.Add("AccomStudBookCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AccomStudBook >) DataRepository.AccomStudBookProvider.DeepSave,
							new object[] { transactionManager, entity.AccomStudBookCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudSemesterTemp>
				if (CanDeepSave(entity.EdStudSemesterTempCollection, "List<EdStudSemesterTemp>|EdStudSemesterTempCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudSemesterTemp child in entity.EdStudSemesterTempCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.EdStudSemesterTempCollection.Count > 0 || entity.EdStudSemesterTempCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudSemesterTempProvider.Save(transactionManager, entity.EdStudSemesterTempCollection);
						
						deepHandles.Add("EdStudSemesterTempCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudSemesterTemp >) DataRepository.EdStudSemesterTempProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudSemesterTempCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudIntTrns>
				if (CanDeepSave(entity.EdStudIntTrnsCollectionGetByEdCodeSemesterId, "List<EdStudIntTrns>|EdStudIntTrnsCollectionGetByEdCodeSemesterId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudIntTrns child in entity.EdStudIntTrnsCollectionGetByEdCodeSemesterId)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.EdStudIntTrnsCollectionGetByEdCodeSemesterId.Count > 0 || entity.EdStudIntTrnsCollectionGetByEdCodeSemesterId.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudIntTrnsProvider.Save(transactionManager, entity.EdStudIntTrnsCollectionGetByEdCodeSemesterId);
						
						deepHandles.Add("EdStudIntTrnsCollectionGetByEdCodeSemesterId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudIntTrns >) DataRepository.EdStudIntTrnsProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudIntTrnsCollectionGetByEdCodeSemesterId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SvStudComp>
				if (CanDeepSave(entity.SvStudCompCollection, "List<SvStudComp>|SvStudCompCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvStudComp child in entity.SvStudCompCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.SvStudCompCollection.Count > 0 || entity.SvStudCompCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvStudCompProvider.Save(transactionManager, entity.SvStudCompCollection);
						
						deepHandles.Add("SvStudCompCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvStudComp >) DataRepository.SvStudCompProvider.DeepSave,
							new object[] { transactionManager, entity.SvStudCompCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudExcuse>
				if (CanDeepSave(entity.EdStudExcuseCollection, "List<EdStudExcuse>|EdStudExcuseCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudExcuse child in entity.EdStudExcuseCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.EdStudExcuseCollection.Count > 0 || entity.EdStudExcuseCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudExcuseProvider.Save(transactionManager, entity.EdStudExcuseCollection);
						
						deepHandles.Add("EdStudExcuseCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudExcuse >) DataRepository.EdStudExcuseProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudExcuseCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<MdiStudHosptl>
				if (CanDeepSave(entity.MdiStudHosptlCollection, "List<MdiStudHosptl>|MdiStudHosptlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(MdiStudHosptl child in entity.MdiStudHosptlCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.MdiStudHosptlCollection.Count > 0 || entity.MdiStudHosptlCollection.DeletedItems.Count > 0)
					{
						//DataRepository.MdiStudHosptlProvider.Save(transactionManager, entity.MdiStudHosptlCollection);
						
						deepHandles.Add("MdiStudHosptlCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< MdiStudHosptl >) DataRepository.MdiStudHosptlProvider.DeepSave,
							new object[] { transactionManager, entity.MdiStudHosptlCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SvMessage>
				if (CanDeepSave(entity.SvMessageCollection, "List<SvMessage>|SvMessageCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SvMessage child in entity.SvMessageCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.SvMessageCollection.Count > 0 || entity.SvMessageCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SvMessageProvider.Save(transactionManager, entity.SvMessageCollection);
						
						deepHandles.Add("SvMessageCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SvMessage >) DataRepository.SvMessageProvider.DeepSave,
							new object[] { transactionManager, entity.SvMessageCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudIntTrns>
				if (CanDeepSave(entity.EdStudIntTrnsCollectionGetByEdCodeSemesterReqId, "List<EdStudIntTrns>|EdStudIntTrnsCollectionGetByEdCodeSemesterReqId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudIntTrns child in entity.EdStudIntTrnsCollectionGetByEdCodeSemesterReqId)
					{
						if(child.EdCodeSemesterReqIdSource != null)
						{
							child.EdCodeSemesterReqId = child.EdCodeSemesterReqIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterReqId = entity.EdCodeSemesterId;
						}

					}

					if (entity.EdStudIntTrnsCollectionGetByEdCodeSemesterReqId.Count > 0 || entity.EdStudIntTrnsCollectionGetByEdCodeSemesterReqId.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudIntTrnsProvider.Save(transactionManager, entity.EdStudIntTrnsCollectionGetByEdCodeSemesterReqId);
						
						deepHandles.Add("EdStudIntTrnsCollectionGetByEdCodeSemesterReqId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudIntTrns >) DataRepository.EdStudIntTrnsProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudIntTrnsCollectionGetByEdCodeSemesterReqId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<MltLvlBhvrAttndc>
				if (CanDeepSave(entity.MltLvlBhvrAttndcCollection, "List<MltLvlBhvrAttndc>|MltLvlBhvrAttndcCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(MltLvlBhvrAttndc child in entity.MltLvlBhvrAttndcCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.MltLvlBhvrAttndcCollection.Count > 0 || entity.MltLvlBhvrAttndcCollection.DeletedItems.Count > 0)
					{
						//DataRepository.MltLvlBhvrAttndcProvider.Save(transactionManager, entity.MltLvlBhvrAttndcCollection);
						
						deepHandles.Add("MltLvlBhvrAttndcCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< MltLvlBhvrAttndc >) DataRepository.MltLvlBhvrAttndcProvider.DeepSave,
							new object[] { transactionManager, entity.MltLvlBhvrAttndcCollection, deepSaveType, childTypes, innerList }
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
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
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
				
	
			#region List<EdTraining>
				if (CanDeepSave(entity.EdTrainingCollection, "List<EdTraining>|EdTrainingCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdTraining child in entity.EdTrainingCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.EdTrainingCollection.Count > 0 || entity.EdTrainingCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdTrainingProvider.Save(transactionManager, entity.EdTrainingCollection);
						
						deepHandles.Add("EdTrainingCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdTraining >) DataRepository.EdTrainingProvider.DeepSave,
							new object[] { transactionManager, entity.EdTrainingCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<ScSchdlPeriod>
				if (CanDeepSave(entity.ScSchdlPeriodCollection, "List<ScSchdlPeriod>|ScSchdlPeriodCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScSchdlPeriod child in entity.ScSchdlPeriodCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.ScSchdlPeriodCollection.Count > 0 || entity.ScSchdlPeriodCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ScSchdlPeriodProvider.Save(transactionManager, entity.ScSchdlPeriodCollection);
						
						deepHandles.Add("ScSchdlPeriodCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ScSchdlPeriod >) DataRepository.ScSchdlPeriodProvider.DeepSave,
							new object[] { transactionManager, entity.ScSchdlPeriodCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SeBlockTrans>
				if (CanDeepSave(entity.SeBlockTransCollection, "List<SeBlockTrans>|SeBlockTransCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SeBlockTrans child in entity.SeBlockTransCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.SeBlockTransCollection.Count > 0 || entity.SeBlockTransCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SeBlockTransProvider.Save(transactionManager, entity.SeBlockTransCollection);
						
						deepHandles.Add("SeBlockTransCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SeBlockTrans >) DataRepository.SeBlockTransProvider.DeepSave,
							new object[] { transactionManager, entity.SeBlockTransCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<ScGroupInfo>
				if (CanDeepSave(entity.ScGroupInfoCollection, "List<ScGroupInfo>|ScGroupInfoCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(ScGroupInfo child in entity.ScGroupInfoCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.ScGroupInfoCollection.Count > 0 || entity.ScGroupInfoCollection.DeletedItems.Count > 0)
					{
						//DataRepository.ScGroupInfoProvider.Save(transactionManager, entity.ScGroupInfoCollection);
						
						deepHandles.Add("ScGroupInfoCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< ScGroupInfo >) DataRepository.ScGroupInfoProvider.DeepSave,
							new object[] { transactionManager, entity.ScGroupInfoCollection, deepSaveType, childTypes, innerList }
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
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
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
				
	
			#region List<EdStaffCoursePref>
				if (CanDeepSave(entity.EdStaffCoursePrefCollection, "List<EdStaffCoursePref>|EdStaffCoursePrefCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStaffCoursePref child in entity.EdStaffCoursePrefCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.EdStaffCoursePrefCollection.Count > 0 || entity.EdStaffCoursePrefCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStaffCoursePrefProvider.Save(transactionManager, entity.EdStaffCoursePrefCollection);
						
						deepHandles.Add("EdStaffCoursePrefCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStaffCoursePref >) DataRepository.EdStaffCoursePrefProvider.DeepSave,
							new object[] { transactionManager, entity.EdStaffCoursePrefCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<AccomStudAbsenceWarn>
				if (CanDeepSave(entity.AccomStudAbsenceWarnCollection, "List<AccomStudAbsenceWarn>|AccomStudAbsenceWarnCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AccomStudAbsenceWarn child in entity.AccomStudAbsenceWarnCollection)
					{
						if(child.EdCodeSemesterIdSource != null)
						{
							child.EdCodeSemesterId = child.EdCodeSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdCodeSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.AccomStudAbsenceWarnCollection.Count > 0 || entity.AccomStudAbsenceWarnCollection.DeletedItems.Count > 0)
					{
						//DataRepository.AccomStudAbsenceWarnProvider.Save(transactionManager, entity.AccomStudAbsenceWarnCollection);
						
						deepHandles.Add("AccomStudAbsenceWarnCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< AccomStudAbsenceWarn >) DataRepository.AccomStudAbsenceWarnProvider.DeepSave,
							new object[] { transactionManager, entity.AccomStudAbsenceWarnCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<GsComm>
				if (CanDeepSave(entity.GsCommCollection, "List<GsComm>|GsCommCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GsComm child in entity.GsCommCollection)
					{
						if(child.EdSemesterIdSource != null)
						{
							child.EdSemesterId = child.EdSemesterIdSource.EdCodeSemesterId;
						}
						else
						{
							child.EdSemesterId = entity.EdCodeSemesterId;
						}

					}

					if (entity.GsCommCollection.Count > 0 || entity.GsCommCollection.DeletedItems.Count > 0)
					{
						//DataRepository.GsCommProvider.Save(transactionManager, entity.GsCommCollection);
						
						deepHandles.Add("GsCommCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< GsComm >) DataRepository.GsCommProvider.DeepSave,
							new object[] { transactionManager, entity.GsCommCollection, deepSaveType, childTypes, innerList }
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
	
	#region EdCodeSemesterChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdCodeSemester</c>
	///</summary>
	public enum EdCodeSemesterChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdCodeSemesterType</c> at EdCodeSemesterTypeIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeSemesterType))]
		EdCodeSemesterType,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for EdStudFacultyCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudFaculty>))]
		EdStudFacultyCollectionGetByEdCodeSemesterJoinId,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for TrnsLineCollection
		///</summary>
		[ChildEntityType(typeof(TList<TrnsLine>))]
		TrnsLineCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for EdStudTransCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudTrans>))]
		EdStudTransCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for WfCrsRsltApproveCollection
		///</summary>
		[ChildEntityType(typeof(TList<WfCrsRsltApprove>))]
		WfCrsRsltApproveCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for SpoSponsorOfferCollection
		///</summary>
		[ChildEntityType(typeof(TList<SpoSponsorOffer>))]
		SpoSponsorOfferCollectionGetByEdCodeSemesterToId,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for EdStudCourseRegPreCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudCourseRegPre>))]
		EdStudCourseRegPreCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for FeeStudNatSimilarityRequestCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudNatSimilarityRequest>))]
		FeeStudNatSimilarityRequestCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for AdmOpenAcadSemesterCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmOpenAcadSemester>))]
		AdmOpenAcadSemesterCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for EdGraduationAwardCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdGraduationAward>))]
		EdGraduationAwardCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for AccomWfRequestApproveCollection
		///</summary>
		[ChildEntityType(typeof(TList<AccomWfRequestApprove>))]
		AccomWfRequestApproveCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for ScStudGroupCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScStudGroup>))]
		ScStudGroupCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for EdProjectCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdProject>))]
		EdProjectCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for RsrchStudRegisterCollection
		///</summary>
		[ChildEntityType(typeof(TList<RsrchStudRegister>))]
		RsrchStudRegisterCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for EdCourseOutcomesTopicsCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdCourseOutcomesTopics>))]
		EdCourseOutcomesTopicsCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for SvStudAskAdvCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvStudAskAdv>))]
		SvStudAskAdvCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for EdCourseTchngCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdCourseTchng>))]
		EdCourseTchngCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for EntMajorPhaseCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntMajorPhase>))]
		EntMajorPhaseCollectionGetByEdCodeSemesterFromId,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for EdExamSchdlCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdExamSchdl>))]
		EdExamSchdlCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for CoControlCollection
		///</summary>
		[ChildEntityType(typeof(TList<CoControl>))]
		CoControlCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for EdStudAcadWarnCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudAcadWarn>))]
		EdStudAcadWarnCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for SpoSponsorStudCollection
		///</summary>
		[ChildEntityType(typeof(TList<SpoSponsorStud>))]
		SpoSponsorStudCollectionGetByEdCodeSemesterToId,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for CoCrsRsltRaiseCollection
		///</summary>
		[ChildEntityType(typeof(TList<CoCrsRsltRaise>))]
		CoCrsRsltRaiseCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for EdStudIntTrnsStateFromCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudIntTrnsStateFrom>))]
		EdStudIntTrnsStateFromCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for MdiStudRecordCollection
		///</summary>
		[ChildEntityType(typeof(TList<MdiStudRecord>))]
		MdiStudRecordCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for EdStudLatenessCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudLateness>))]
		EdStudLatenessCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for FeeStudItemCnclCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudItemCncl>))]
		FeeStudItemCnclCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for EdStudBranchPrefCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudBranchPref>))]
		EdStudBranchPrefCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for EdAcdadvRmkCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdAcdadvRmk>))]
		EdAcdadvRmkCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for EdCourseInfoCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdCourseInfo>))]
		EdCourseInfoCollectionGetByEdCodeSemesterToId,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for FeeStudPayPostponeCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudPayPostpone>))]
		FeeStudPayPostponeCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for SpoSponsorStudCollection
		///</summary>
		[ChildEntityType(typeof(TList<SpoSponsorStud>))]
		SpoSponsorStudCollectionGetByEdCodeSemesterId,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for SvSrvyHdrCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvSrvyHdr>))]
		SvSrvyHdrCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for FeeLimitRuleCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeLimitRule>))]
		FeeLimitRuleCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for MltStudInfoCollection
		///</summary>
		[ChildEntityType(typeof(TList<MltStudInfo>))]
		MltStudInfoCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for FeeInstlmntRuleCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeInstlmntRule>))]
		FeeInstlmntRuleCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for EdStudEnrollChangeCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudEnrollChange>))]
		EdStudEnrollChangeCollectionGetByEdCodeSemesterToId,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for EdStudAcadmicAdvCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudAcadmicAdv>))]
		EdStudAcadmicAdvCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for EdInttransRuleCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdInttransRule>))]
		EdInttransRuleCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for SpoOfferStudExceptionCollection
		///</summary>
		[ChildEntityType(typeof(TList<SpoOfferStudException>))]
		SpoOfferStudExceptionCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for FeeRefundCodeCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeRefundCode>))]
		FeeRefundCodeCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for FeeStudVoucherCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudVoucher>))]
		FeeStudVoucherCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for SpoSponsorStudSemesterCollection
		///</summary>
		[ChildEntityType(typeof(TList<SpoSponsorStudSemester>))]
		SpoSponsorStudSemesterCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for FeeStudFundCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudFund>))]
		FeeStudFundCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for FeeStudDiscCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudDisc>))]
		FeeStudDiscCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for FeeStudCoursesItemCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudCoursesItem>))]
		FeeStudCoursesItemCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for EdSemesterOpenCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdSemesterOpen>))]
		EdSemesterOpenCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for SaOfficeHourCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaOfficeHour>))]
		SaOfficeHourCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for CtrStudExpCollection
		///</summary>
		[ChildEntityType(typeof(TList<CtrStudExp>))]
		CtrStudExpCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for MdiStudClnqCollection
		///</summary>
		[ChildEntityType(typeof(TList<MdiStudClnq>))]
		MdiStudClnqCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for PgThesisStudCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgThesisStud>))]
		PgThesisStudCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for GsAgendaHolidayCollection
		///</summary>
		[ChildEntityType(typeof(TList<GsAgendaHoliday>))]
		GsAgendaHolidayCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for EdStudViolCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudViol>))]
		EdStudViolCollectionGetByEdCodeSemesterId,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for EdStudIntTrnsCourseFromCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudIntTrnsCourseFrom>))]
		EdStudIntTrnsCourseFromCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for AccomStudAbsenceCollection
		///</summary>
		[ChildEntityType(typeof(TList<AccomStudAbsence>))]
		AccomStudAbsenceCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for PgOfferingCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgOffering>))]
		PgOfferingCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for FeeItemTrnsBlncCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeItemTrnsBlnc>))]
		FeeItemTrnsBlncCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for EntMajorPhaseCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntMajorPhase>))]
		EntMajorPhaseCollectionGetByEdCodeSemesterToId,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for EdCourseInfoCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdCourseInfo>))]
		EdCourseInfoCollectionGetByEdCodeSemesterFromId,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for FeeStudInstallmentCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudInstallment>))]
		FeeStudInstallmentCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for AdmFeePromocodeCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmFeePromocode>))]
		AdmFeePromocodeCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for EdStudViolCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudViol>))]
		EdStudViolCollectionGetByEdCodeSemesterStopFromId,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for EdBranchRuleCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdBranchRule>))]
		EdBranchRuleCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for FeeFacultyRuleCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeFacultyRule>))]
		FeeFacultyRuleCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for EdStudProblemCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudProblem>))]
		EdStudProblemCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for SpoSponsorOfferCollection
		///</summary>
		[ChildEntityType(typeof(TList<SpoSponsorOffer>))]
		SpoSponsorOfferCollectionGetByEdCodeSemesterFromId,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for FeeItemSemesterCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeItemSemester>))]
		FeeItemSemesterCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for ScSectionGroupHdrCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScSectionGroupHdr>))]
		ScSectionGroupHdrCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for CtrStudOutCollection
		///</summary>
		[ChildEntityType(typeof(TList<CtrStudOut>))]
		CtrStudOutCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for TrnsStudReqCollection
		///</summary>
		[ChildEntityType(typeof(TList<TrnsStudReq>))]
		TrnsStudReqCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for EdStudExmptReqCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudExmptReq>))]
		EdStudExmptReqCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for FeeStudRetrieveRequestCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudRetrieveRequest>))]
		FeeStudRetrieveRequestCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for SvCourseEvalCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvCourseEval>))]
		SvCourseEvalCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for RsrchStudPostponeReqCollection
		///</summary>
		[ChildEntityType(typeof(TList<RsrchStudPostponeReq>))]
		RsrchStudPostponeReqCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for AdmAppRegHistoryCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmAppRegHistory>))]
		AdmAppRegHistoryCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for EdStudSemesterCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudSemester>))]
		EdStudSemesterCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for PgThesisGrantDegreeCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgThesisGrantDegree>))]
		PgThesisGrantDegreeCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for EdStudExecuseReqCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudExecuseReq>))]
		EdStudExecuseReqCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for FeeRefndStdReqCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeRefndStdReq>))]
		FeeRefndStdReqCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for EdOfferingCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdOffering>))]
		EdOfferingCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for SvLecNoteCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvLecNote>))]
		SvLecNoteCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for EdStudAbsenceCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudAbsence>))]
		EdStudAbsenceCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for EdStudAbsFwCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudAbsFw>))]
		EdStudAbsFwCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for FeeStudInstallmentRequestCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudInstallmentRequest>))]
		FeeStudInstallmentRequestCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for MltRptDayStudStsCollection
		///</summary>
		[ChildEntityType(typeof(TList<MltRptDayStudSts>))]
		MltRptDayStudStsCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for SvUserTaskCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvUserTask>))]
		SvUserTaskCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for EdStudEnrollChangeCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudEnrollChange>))]
		EdStudEnrollChangeCollectionGetByEdCodeSemesterFromId,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for EdStudViolCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudViol>))]
		EdStudViolCollectionGetByEdCodeSemesterStopToId,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for AccomStudReqCollection
		///</summary>
		[ChildEntityType(typeof(TList<AccomStudReq>))]
		AccomStudReqCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for EdAcadPlanHdrCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdAcadPlanHdr>))]
		EdAcadPlanHdrCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for SvStaffEvlCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvStaffEvl>))]
		SvStaffEvlCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for SeUserCrsAssessCollection
		///</summary>
		[ChildEntityType(typeof(TList<SeUserCrsAssess>))]
		SeUserCrsAssessCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for EdStudIntTrnsCourseToCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudIntTrnsCourseTo>))]
		EdStudIntTrnsCourseToCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for EdStudFacultyCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudFaculty>))]
		EdStudFacultyCollectionGetByEdCodeSemesterId,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for EdStudIntTrnsStateToCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudIntTrnsStateTo>))]
		EdStudIntTrnsStateToCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for FeeStudFeeItemCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeStudFeeItem>))]
		FeeStudFeeItemCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for EdPrintReqCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdPrintReq>))]
		EdPrintReqCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for EdStudTransFromReqCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudTransFromReq>))]
		EdStudTransFromReqCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for AccomStudBookCollection
		///</summary>
		[ChildEntityType(typeof(TList<AccomStudBook>))]
		AccomStudBookCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for EdStudSemesterTempCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudSemesterTemp>))]
		EdStudSemesterTempCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for EdStudIntTrnsCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudIntTrns>))]
		EdStudIntTrnsCollectionGetByEdCodeSemesterId,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for SvStudCompCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvStudComp>))]
		SvStudCompCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for EdStudExcuseCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudExcuse>))]
		EdStudExcuseCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for MdiStudHosptlCollection
		///</summary>
		[ChildEntityType(typeof(TList<MdiStudHosptl>))]
		MdiStudHosptlCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for SvMessageCollection
		///</summary>
		[ChildEntityType(typeof(TList<SvMessage>))]
		SvMessageCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for EdStudIntTrnsCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudIntTrns>))]
		EdStudIntTrnsCollectionGetByEdCodeSemesterReqId,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for MltLvlBhvrAttndcCollection
		///</summary>
		[ChildEntityType(typeof(TList<MltLvlBhvrAttndc>))]
		MltLvlBhvrAttndcCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for FeeCodeItemCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeCodeItem>))]
		FeeCodeItemCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for EdTrainingCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdTraining>))]
		EdTrainingCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for ScSchdlPeriodCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScSchdlPeriod>))]
		ScSchdlPeriodCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for SeBlockTransCollection
		///</summary>
		[ChildEntityType(typeof(TList<SeBlockTrans>))]
		SeBlockTransCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for ScGroupInfoCollection
		///</summary>
		[ChildEntityType(typeof(TList<ScGroupInfo>))]
		ScGroupInfoCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for EntPolcyGrdngHdrCollection
		///</summary>
		[ChildEntityType(typeof(TList<EntPolcyGrdngHdr>))]
		EntPolcyGrdngHdrCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for EdStaffCoursePrefCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStaffCoursePref>))]
		EdStaffCoursePrefCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for AccomStudAbsenceWarnCollection
		///</summary>
		[ChildEntityType(typeof(TList<AccomStudAbsenceWarn>))]
		AccomStudAbsenceWarnCollection,
		///<summary>
		/// Collection of <c>EdCodeSemester</c> as OneToMany for GsCommCollection
		///</summary>
		[ChildEntityType(typeof(TList<GsComm>))]
		GsCommCollection,
	}
	
	#endregion EdCodeSemesterChildEntityTypes
	
	#region EdCodeSemesterFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdCodeSemesterColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeSemester"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCodeSemesterFilterBuilder : SqlFilterBuilder<EdCodeSemesterColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeSemesterFilterBuilder class.
		/// </summary>
		public EdCodeSemesterFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCodeSemesterFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCodeSemesterFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCodeSemesterFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCodeSemesterFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCodeSemesterFilterBuilder
	
	#region EdCodeSemesterParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdCodeSemesterColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeSemester"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCodeSemesterParameterBuilder : ParameterizedSqlFilterBuilder<EdCodeSemesterColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeSemesterParameterBuilder class.
		/// </summary>
		public EdCodeSemesterParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCodeSemesterParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCodeSemesterParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCodeSemesterParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCodeSemesterParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCodeSemesterParameterBuilder
	
	#region EdCodeSemesterSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdCodeSemesterColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeSemester"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdCodeSemesterSortBuilder : SqlSortBuilder<EdCodeSemesterColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeSemesterSqlSortBuilder class.
		/// </summary>
		public EdCodeSemesterSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdCodeSemesterSortBuilder
	
} // end namespace
