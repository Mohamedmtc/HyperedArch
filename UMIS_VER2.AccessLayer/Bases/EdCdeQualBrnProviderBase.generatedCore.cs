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
	/// This class is the base class for any <see cref="EdCdeQualBrnProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdCdeQualBrnProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdCdeQualBrn, UMIS_VER2.BusinessLyer.EdCdeQualBrnKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCdeQualBrnKey key)
		{
			return Delete(transactionManager, key.EdCdeQualBrnId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edCdeQualBrnId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edCdeQualBrnId)
		{
			return Delete(null, _edCdeQualBrnId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeQualBrnId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edCdeQualBrnId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CDE_QUAL_BRN_ED_CODE_QUAL key.
		///		FK_ED_CDE_QUAL_BRN_ED_CODE_QUAL Description: 
		/// </summary>
		/// <param name="_edCodeQualId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCdeQualBrn objects.</returns>
		public TList<EdCdeQualBrn> GetByEdCodeQualId(System.Decimal _edCodeQualId)
		{
			int count = -1;
			return GetByEdCodeQualId(_edCodeQualId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CDE_QUAL_BRN_ED_CODE_QUAL key.
		///		FK_ED_CDE_QUAL_BRN_ED_CODE_QUAL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeQualId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCdeQualBrn objects.</returns>
		/// <remarks></remarks>
		public TList<EdCdeQualBrn> GetByEdCodeQualId(TransactionManager transactionManager, System.Decimal _edCodeQualId)
		{
			int count = -1;
			return GetByEdCodeQualId(transactionManager, _edCodeQualId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CDE_QUAL_BRN_ED_CODE_QUAL key.
		///		FK_ED_CDE_QUAL_BRN_ED_CODE_QUAL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeQualId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCdeQualBrn objects.</returns>
		public TList<EdCdeQualBrn> GetByEdCodeQualId(TransactionManager transactionManager, System.Decimal _edCodeQualId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeQualId(transactionManager, _edCodeQualId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CDE_QUAL_BRN_ED_CODE_QUAL key.
		///		fkEdCdeQualBrnEdCodeQual Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeQualId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCdeQualBrn objects.</returns>
		public TList<EdCdeQualBrn> GetByEdCodeQualId(System.Decimal _edCodeQualId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCodeQualId(null, _edCodeQualId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CDE_QUAL_BRN_ED_CODE_QUAL key.
		///		fkEdCdeQualBrnEdCodeQual Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCodeQualId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCdeQualBrn objects.</returns>
		public TList<EdCdeQualBrn> GetByEdCodeQualId(System.Decimal _edCodeQualId, int start, int pageLength,out int count)
		{
			return GetByEdCodeQualId(null, _edCodeQualId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ED_CDE_QUAL_BRN_ED_CODE_QUAL key.
		///		FK_ED_CDE_QUAL_BRN_ED_CODE_QUAL Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeQualId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCdeQualBrn objects.</returns>
		public abstract TList<EdCdeQualBrn> GetByEdCodeQualId(TransactionManager transactionManager, System.Decimal _edCodeQualId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.EdCdeQualBrn Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCdeQualBrnKey key, int start, int pageLength)
		{
			return GetByEdCdeQualBrnId(transactionManager, key.EdCdeQualBrnId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_CDE_QUAL_BRN index.
		/// </summary>
		/// <param name="_edCdeQualBrnId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeQualBrn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeQualBrn GetByEdCdeQualBrnId(System.Decimal _edCdeQualBrnId)
		{
			int count = -1;
			return GetByEdCdeQualBrnId(null,_edCdeQualBrnId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_QUAL_BRN index.
		/// </summary>
		/// <param name="_edCdeQualBrnId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeQualBrn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeQualBrn GetByEdCdeQualBrnId(System.Decimal _edCdeQualBrnId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCdeQualBrnId(null, _edCdeQualBrnId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_QUAL_BRN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeQualBrnId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeQualBrn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeQualBrn GetByEdCdeQualBrnId(TransactionManager transactionManager, System.Decimal _edCdeQualBrnId)
		{
			int count = -1;
			return GetByEdCdeQualBrnId(transactionManager, _edCdeQualBrnId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_QUAL_BRN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeQualBrnId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeQualBrn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeQualBrn GetByEdCdeQualBrnId(TransactionManager transactionManager, System.Decimal _edCdeQualBrnId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCdeQualBrnId(transactionManager, _edCdeQualBrnId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_QUAL_BRN index.
		/// </summary>
		/// <param name="_edCdeQualBrnId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeQualBrn"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCdeQualBrn GetByEdCdeQualBrnId(System.Decimal _edCdeQualBrnId, int start, int pageLength, out int count)
		{
			return GetByEdCdeQualBrnId(null, _edCdeQualBrnId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CDE_QUAL_BRN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeQualBrnId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCdeQualBrn"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdCdeQualBrn GetByEdCdeQualBrnId(TransactionManager transactionManager, System.Decimal _edCdeQualBrnId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdCdeQualBrn&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdCdeQualBrn&gt;"/></returns>
		public static TList<EdCdeQualBrn> Fill(IDataReader reader, TList<EdCdeQualBrn> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdCdeQualBrn c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdCdeQualBrn")
					.Append("|").Append((System.Decimal)reader["ED_CDE_QUAL_BRN_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdCdeQualBrn>(
					key.ToString(), // EntityTrackingKey
					"EdCdeQualBrn",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdCdeQualBrn();
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
					c.EdCdeQualBrnId = (System.Decimal)reader["ED_CDE_QUAL_BRN_ID"];
					c.OriginalEdCdeQualBrnId = c.EdCdeQualBrnId;
					c.EdCodeQualId = (System.Decimal)reader["ED_CODE_QUAL_ID"];
					c.BrnDescrAr = (System.String)reader["BRN_DESCR_AR"];
					c.BrnDescrEn = (System.String)reader["BRN_DESCR_EN"];
					c.TotalMark = Convert.IsDBNull(reader["TOTAL_MARK"]) ? null : (System.Decimal?)reader["TOTAL_MARK"];
					c.MaxCrsCount = Convert.IsDBNull(reader["MAX_CRS_COUNT"]) ? null : (System.Int32?)reader["MAX_CRS_COUNT"];
					c.QualEquation = Convert.IsDBNull(reader["QUAL_EQUATION"]) ? null : (System.String)reader["QUAL_EQUATION"];
					c.QualBrnCode = Convert.IsDBNull(reader["QUAL_BRN_CODE"]) ? null : (System.String)reader["QUAL_BRN_CODE"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCdeQualBrn"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCdeQualBrn"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdCdeQualBrn entity)
		{
			if (!reader.Read()) return;
			
			entity.EdCdeQualBrnId = (System.Decimal)reader[((int)EdCdeQualBrnColumn.EdCdeQualBrnId - 1)];
			entity.OriginalEdCdeQualBrnId = (System.Decimal)reader["ED_CDE_QUAL_BRN_ID"];
			entity.EdCodeQualId = (System.Decimal)reader[((int)EdCdeQualBrnColumn.EdCodeQualId - 1)];
			entity.BrnDescrAr = (System.String)reader[((int)EdCdeQualBrnColumn.BrnDescrAr - 1)];
			entity.BrnDescrEn = (System.String)reader[((int)EdCdeQualBrnColumn.BrnDescrEn - 1)];
			entity.TotalMark = (reader.IsDBNull(((int)EdCdeQualBrnColumn.TotalMark - 1)))?null:(System.Decimal?)reader[((int)EdCdeQualBrnColumn.TotalMark - 1)];
			entity.MaxCrsCount = (reader.IsDBNull(((int)EdCdeQualBrnColumn.MaxCrsCount - 1)))?null:(System.Int32?)reader[((int)EdCdeQualBrnColumn.MaxCrsCount - 1)];
			entity.QualEquation = (reader.IsDBNull(((int)EdCdeQualBrnColumn.QualEquation - 1)))?null:(System.String)reader[((int)EdCdeQualBrnColumn.QualEquation - 1)];
			entity.QualBrnCode = (reader.IsDBNull(((int)EdCdeQualBrnColumn.QualBrnCode - 1)))?null:(System.String)reader[((int)EdCdeQualBrnColumn.QualBrnCode - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCdeQualBrn"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCdeQualBrn"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdCdeQualBrn entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdCdeQualBrnId = (System.Decimal)dataRow["ED_CDE_QUAL_BRN_ID"];
			entity.OriginalEdCdeQualBrnId = (System.Decimal)dataRow["ED_CDE_QUAL_BRN_ID"];
			entity.EdCodeQualId = (System.Decimal)dataRow["ED_CODE_QUAL_ID"];
			entity.BrnDescrAr = (System.String)dataRow["BRN_DESCR_AR"];
			entity.BrnDescrEn = (System.String)dataRow["BRN_DESCR_EN"];
			entity.TotalMark = Convert.IsDBNull(dataRow["TOTAL_MARK"]) ? null : (System.Decimal?)dataRow["TOTAL_MARK"];
			entity.MaxCrsCount = Convert.IsDBNull(dataRow["MAX_CRS_COUNT"]) ? null : (System.Int32?)dataRow["MAX_CRS_COUNT"];
			entity.QualEquation = Convert.IsDBNull(dataRow["QUAL_EQUATION"]) ? null : (System.String)dataRow["QUAL_EQUATION"];
			entity.QualBrnCode = Convert.IsDBNull(dataRow["QUAL_BRN_CODE"]) ? null : (System.String)dataRow["QUAL_BRN_CODE"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCdeQualBrn"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCdeQualBrn Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCdeQualBrn entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdCodeQualIdSource	
			if (CanDeepLoad(entity, "EdCodeQual|EdCodeQualIdSource", deepLoadType, innerList) 
				&& entity.EdCodeQualIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdCodeQualId;
				EdCodeQual tmpEntity = EntityManager.LocateEntity<EdCodeQual>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCodeQual), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCodeQualIdSource = tmpEntity;
				else
					entity.EdCodeQualIdSource = DataRepository.EdCodeQualProvider.GetByEdCodeQualId(transactionManager, entity.EdCodeQualId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeQualIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCodeQualIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCodeQualProvider.DeepLoad(transactionManager, entity.EdCodeQualIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCodeQualIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByEdCdeQualBrnId methods when available
			
			#region AdmPrecondQualCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmPrecondQual>|AdmPrecondQualCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmPrecondQualCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmPrecondQualCollection = DataRepository.AdmPrecondQualProvider.GetByEdCdeQualBrnId(transactionManager, entity.EdCdeQualBrnId);

				if (deep && entity.AdmPrecondQualCollection.Count > 0)
				{
					deepHandles.Add("AdmPrecondQualCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmPrecondQual>) DataRepository.AdmPrecondQualProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmPrecondQualCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdCodeQualGroupCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdCodeQualGroup>|EdCodeQualGroupCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeQualGroupCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdCodeQualGroupCollection = DataRepository.EdCodeQualGroupProvider.GetByEdCodeQualBranId(transactionManager, entity.EdCdeQualBrnId);

				if (deep && entity.EdCodeQualGroupCollection.Count > 0)
				{
					deepHandles.Add("EdCodeQualGroupCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdCodeQualGroup>) DataRepository.EdCodeQualGroupProvider.DeepLoad,
						new object[] { transactionManager, entity.EdCodeQualGroupCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdCodeQualSubjectCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdCodeQualSubject>|EdCodeQualSubjectCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCodeQualSubjectCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdCodeQualSubjectCollection = DataRepository.EdCodeQualSubjectProvider.GetByEdCodeQualBranId(transactionManager, entity.EdCdeQualBrnId);

				if (deep && entity.EdCodeQualSubjectCollection.Count > 0)
				{
					deepHandles.Add("EdCodeQualSubjectCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdCodeQualSubject>) DataRepository.EdCodeQualSubjectProvider.DeepLoad,
						new object[] { transactionManager, entity.EdCodeQualSubjectCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudQualCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudQual>|EdStudQualCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudQualCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudQualCollection = DataRepository.EdStudQualProvider.GetByEdCdeQualBrnId(transactionManager, entity.EdCdeQualBrnId);

				if (deep && entity.EdStudQualCollection.Count > 0)
				{
					deepHandles.Add("EdStudQualCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudQual>) DataRepository.EdStudQualProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudQualCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdCdeQualBrn object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdCdeQualBrn instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCdeQualBrn Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCdeQualBrn entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdCodeQualIdSource
			if (CanDeepSave(entity, "EdCodeQual|EdCodeQualIdSource", deepSaveType, innerList) 
				&& entity.EdCodeQualIdSource != null)
			{
				DataRepository.EdCodeQualProvider.Save(transactionManager, entity.EdCodeQualIdSource);
				entity.EdCodeQualId = entity.EdCodeQualIdSource.EdCodeQualId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<AdmPrecondQual>
				if (CanDeepSave(entity.AdmPrecondQualCollection, "List<AdmPrecondQual>|AdmPrecondQualCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmPrecondQual child in entity.AdmPrecondQualCollection)
					{
						if(child.EdCdeQualBrnIdSource != null)
						{
							child.EdCdeQualBrnId = child.EdCdeQualBrnIdSource.EdCdeQualBrnId;
						}
						else
						{
							child.EdCdeQualBrnId = entity.EdCdeQualBrnId;
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
				
	
			#region List<EdCodeQualGroup>
				if (CanDeepSave(entity.EdCodeQualGroupCollection, "List<EdCodeQualGroup>|EdCodeQualGroupCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdCodeQualGroup child in entity.EdCodeQualGroupCollection)
					{
						if(child.EdCodeQualBranIdSource != null)
						{
							child.EdCodeQualBranId = child.EdCodeQualBranIdSource.EdCdeQualBrnId;
						}
						else
						{
							child.EdCodeQualBranId = entity.EdCdeQualBrnId;
						}

					}

					if (entity.EdCodeQualGroupCollection.Count > 0 || entity.EdCodeQualGroupCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdCodeQualGroupProvider.Save(transactionManager, entity.EdCodeQualGroupCollection);
						
						deepHandles.Add("EdCodeQualGroupCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdCodeQualGroup >) DataRepository.EdCodeQualGroupProvider.DeepSave,
							new object[] { transactionManager, entity.EdCodeQualGroupCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdCodeQualSubject>
				if (CanDeepSave(entity.EdCodeQualSubjectCollection, "List<EdCodeQualSubject>|EdCodeQualSubjectCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdCodeQualSubject child in entity.EdCodeQualSubjectCollection)
					{
						if(child.EdCodeQualBranIdSource != null)
						{
							child.EdCodeQualBranId = child.EdCodeQualBranIdSource.EdCdeQualBrnId;
						}
						else
						{
							child.EdCodeQualBranId = entity.EdCdeQualBrnId;
						}

					}

					if (entity.EdCodeQualSubjectCollection.Count > 0 || entity.EdCodeQualSubjectCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdCodeQualSubjectProvider.Save(transactionManager, entity.EdCodeQualSubjectCollection);
						
						deepHandles.Add("EdCodeQualSubjectCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdCodeQualSubject >) DataRepository.EdCodeQualSubjectProvider.DeepSave,
							new object[] { transactionManager, entity.EdCodeQualSubjectCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudQual>
				if (CanDeepSave(entity.EdStudQualCollection, "List<EdStudQual>|EdStudQualCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudQual child in entity.EdStudQualCollection)
					{
						if(child.EdCdeQualBrnIdSource != null)
						{
							child.EdCdeQualBrnId = child.EdCdeQualBrnIdSource.EdCdeQualBrnId;
						}
						else
						{
							child.EdCdeQualBrnId = entity.EdCdeQualBrnId;
						}

					}

					if (entity.EdStudQualCollection.Count > 0 || entity.EdStudQualCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudQualProvider.Save(transactionManager, entity.EdStudQualCollection);
						
						deepHandles.Add("EdStudQualCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudQual >) DataRepository.EdStudQualProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudQualCollection, deepSaveType, childTypes, innerList }
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
	
	#region EdCdeQualBrnChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdCdeQualBrn</c>
	///</summary>
	public enum EdCdeQualBrnChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdCodeQual</c> at EdCodeQualIdSource
		///</summary>
		[ChildEntityType(typeof(EdCodeQual))]
		EdCodeQual,
		///<summary>
		/// Collection of <c>EdCdeQualBrn</c> as OneToMany for AdmPrecondQualCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmPrecondQual>))]
		AdmPrecondQualCollection,
		///<summary>
		/// Collection of <c>EdCdeQualBrn</c> as OneToMany for EdCodeQualGroupCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdCodeQualGroup>))]
		EdCodeQualGroupCollection,
		///<summary>
		/// Collection of <c>EdCdeQualBrn</c> as OneToMany for EdCodeQualSubjectCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdCodeQualSubject>))]
		EdCodeQualSubjectCollection,
		///<summary>
		/// Collection of <c>EdCdeQualBrn</c> as OneToMany for EdStudQualCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudQual>))]
		EdStudQualCollection,
	}
	
	#endregion EdCdeQualBrnChildEntityTypes
	
	#region EdCdeQualBrnFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdCdeQualBrnColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCdeQualBrn"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCdeQualBrnFilterBuilder : SqlFilterBuilder<EdCdeQualBrnColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCdeQualBrnFilterBuilder class.
		/// </summary>
		public EdCdeQualBrnFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCdeQualBrnFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCdeQualBrnFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCdeQualBrnFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCdeQualBrnFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCdeQualBrnFilterBuilder
	
	#region EdCdeQualBrnParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdCdeQualBrnColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCdeQualBrn"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCdeQualBrnParameterBuilder : ParameterizedSqlFilterBuilder<EdCdeQualBrnColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCdeQualBrnParameterBuilder class.
		/// </summary>
		public EdCdeQualBrnParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCdeQualBrnParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCdeQualBrnParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCdeQualBrnParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCdeQualBrnParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCdeQualBrnParameterBuilder
	
	#region EdCdeQualBrnSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdCdeQualBrnColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCdeQualBrn"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdCdeQualBrnSortBuilder : SqlSortBuilder<EdCdeQualBrnColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCdeQualBrnSqlSortBuilder class.
		/// </summary>
		public EdCdeQualBrnSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdCdeQualBrnSortBuilder
	
} // end namespace
