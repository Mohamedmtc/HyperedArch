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
	/// This class is the base class for any <see cref="AdmExamGrdngPkgProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AdmExamGrdngPkgProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AdmExamGrdngPkg, UMIS_VER2.BusinessLyer.AdmExamGrdngPkgKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmExamGrdngPkgKey key)
		{
			return Delete(transactionManager, key.AdmExamGrdngPkgId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_admExamGrdngPkgId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _admExamGrdngPkgId)
		{
			return Delete(null, _admExamGrdngPkgId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admExamGrdngPkgId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _admExamGrdngPkgId);		
		
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
		public override UMIS_VER2.BusinessLyer.AdmExamGrdngPkg Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmExamGrdngPkgKey key, int start, int pageLength)
		{
			return GetByAdmExamGrdngPkgId(transactionManager, key.AdmExamGrdngPkgId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ADM_EXAM_GRDNG_PKG index.
		/// </summary>
		/// <param name="_admExamGrdngPkgId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmExamGrdngPkg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmExamGrdngPkg GetByAdmExamGrdngPkgId(System.Decimal _admExamGrdngPkgId)
		{
			int count = -1;
			return GetByAdmExamGrdngPkgId(null,_admExamGrdngPkgId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_EXAM_GRDNG_PKG index.
		/// </summary>
		/// <param name="_admExamGrdngPkgId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmExamGrdngPkg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmExamGrdngPkg GetByAdmExamGrdngPkgId(System.Decimal _admExamGrdngPkgId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmExamGrdngPkgId(null, _admExamGrdngPkgId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_EXAM_GRDNG_PKG index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admExamGrdngPkgId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmExamGrdngPkg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmExamGrdngPkg GetByAdmExamGrdngPkgId(TransactionManager transactionManager, System.Decimal _admExamGrdngPkgId)
		{
			int count = -1;
			return GetByAdmExamGrdngPkgId(transactionManager, _admExamGrdngPkgId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_EXAM_GRDNG_PKG index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admExamGrdngPkgId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmExamGrdngPkg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmExamGrdngPkg GetByAdmExamGrdngPkgId(TransactionManager transactionManager, System.Decimal _admExamGrdngPkgId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmExamGrdngPkgId(transactionManager, _admExamGrdngPkgId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_EXAM_GRDNG_PKG index.
		/// </summary>
		/// <param name="_admExamGrdngPkgId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmExamGrdngPkg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmExamGrdngPkg GetByAdmExamGrdngPkgId(System.Decimal _admExamGrdngPkgId, int start, int pageLength, out int count)
		{
			return GetByAdmExamGrdngPkgId(null, _admExamGrdngPkgId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_EXAM_GRDNG_PKG index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admExamGrdngPkgId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmExamGrdngPkg"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmExamGrdngPkg GetByAdmExamGrdngPkgId(TransactionManager transactionManager, System.Decimal _admExamGrdngPkgId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ADM_EXAM_GRDNG_PKG index.
		/// </summary>
		/// <param name="_pkgGrdngAr"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmExamGrdngPkg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmExamGrdngPkg GetByPkgGrdngAr(System.String _pkgGrdngAr)
		{
			int count = -1;
			return GetByPkgGrdngAr(null,_pkgGrdngAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_EXAM_GRDNG_PKG index.
		/// </summary>
		/// <param name="_pkgGrdngAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmExamGrdngPkg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmExamGrdngPkg GetByPkgGrdngAr(System.String _pkgGrdngAr, int start, int pageLength)
		{
			int count = -1;
			return GetByPkgGrdngAr(null, _pkgGrdngAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_EXAM_GRDNG_PKG index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pkgGrdngAr"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmExamGrdngPkg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmExamGrdngPkg GetByPkgGrdngAr(TransactionManager transactionManager, System.String _pkgGrdngAr)
		{
			int count = -1;
			return GetByPkgGrdngAr(transactionManager, _pkgGrdngAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_EXAM_GRDNG_PKG index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pkgGrdngAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmExamGrdngPkg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmExamGrdngPkg GetByPkgGrdngAr(TransactionManager transactionManager, System.String _pkgGrdngAr, int start, int pageLength)
		{
			int count = -1;
			return GetByPkgGrdngAr(transactionManager, _pkgGrdngAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_EXAM_GRDNG_PKG index.
		/// </summary>
		/// <param name="_pkgGrdngAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmExamGrdngPkg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmExamGrdngPkg GetByPkgGrdngAr(System.String _pkgGrdngAr, int start, int pageLength, out int count)
		{
			return GetByPkgGrdngAr(null, _pkgGrdngAr, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_EXAM_GRDNG_PKG index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_pkgGrdngAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmExamGrdngPkg"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmExamGrdngPkg GetByPkgGrdngAr(TransactionManager transactionManager, System.String _pkgGrdngAr, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AdmExamGrdngPkg&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AdmExamGrdngPkg&gt;"/></returns>
		public static TList<AdmExamGrdngPkg> Fill(IDataReader reader, TList<AdmExamGrdngPkg> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AdmExamGrdngPkg c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AdmExamGrdngPkg")
					.Append("|").Append((System.Decimal)reader["ADM_EXAM_GRDNG_PKG_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AdmExamGrdngPkg>(
					key.ToString(), // EntityTrackingKey
					"AdmExamGrdngPkg",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AdmExamGrdngPkg();
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
					c.AdmExamGrdngPkgId = (System.Decimal)reader["ADM_EXAM_GRDNG_PKG_ID"];
					c.OriginalAdmExamGrdngPkgId = c.AdmExamGrdngPkgId;
					c.PkgGrdngAr = (System.String)reader["PKG_GRDNG_AR"];
					c.PkgGrdngEn = (System.String)reader["PKG_GRDNG_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmExamGrdngPkg"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmExamGrdngPkg"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AdmExamGrdngPkg entity)
		{
			if (!reader.Read()) return;
			
			entity.AdmExamGrdngPkgId = (System.Decimal)reader[((int)AdmExamGrdngPkgColumn.AdmExamGrdngPkgId - 1)];
			entity.OriginalAdmExamGrdngPkgId = (System.Decimal)reader["ADM_EXAM_GRDNG_PKG_ID"];
			entity.PkgGrdngAr = (System.String)reader[((int)AdmExamGrdngPkgColumn.PkgGrdngAr - 1)];
			entity.PkgGrdngEn = (System.String)reader[((int)AdmExamGrdngPkgColumn.PkgGrdngEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmExamGrdngPkg"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmExamGrdngPkg"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AdmExamGrdngPkg entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AdmExamGrdngPkgId = (System.Decimal)dataRow["ADM_EXAM_GRDNG_PKG_ID"];
			entity.OriginalAdmExamGrdngPkgId = (System.Decimal)dataRow["ADM_EXAM_GRDNG_PKG_ID"];
			entity.PkgGrdngAr = (System.String)dataRow["PKG_GRDNG_AR"];
			entity.PkgGrdngEn = (System.String)dataRow["PKG_GRDNG_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmExamGrdngPkg"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmExamGrdngPkg Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmExamGrdngPkg entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByAdmExamGrdngPkgId methods when available
			
			#region AdmExamGrdngPkgDtlCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<AdmExamGrdngPkgDtl>|AdmExamGrdngPkgDtlCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmExamGrdngPkgDtlCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.AdmExamGrdngPkgDtlCollection = DataRepository.AdmExamGrdngPkgDtlProvider.GetByAdmExamGrdngPkgId(transactionManager, entity.AdmExamGrdngPkgId);

				if (deep && entity.AdmExamGrdngPkgDtlCollection.Count > 0)
				{
					deepHandles.Add("AdmExamGrdngPkgDtlCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmExamGrdngPkgDtl>) DataRepository.AdmExamGrdngPkgDtlProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmExamGrdngPkgDtlCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.EdCodeQualGroupCollection = DataRepository.EdCodeQualGroupProvider.GetByAdmExamGrdngPkgId(transactionManager, entity.AdmExamGrdngPkgId);

				if (deep && entity.EdCodeQualGroupCollection.Count > 0)
				{
					deepHandles.Add("EdCodeQualGroupCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdCodeQualGroup>) DataRepository.EdCodeQualGroupProvider.DeepLoad,
						new object[] { transactionManager, entity.EdCodeQualGroupCollection, deep, deepLoadType, childTypes, innerList }
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

				entity.AdmCdePlacementExamCollection = DataRepository.AdmCdePlacementExamProvider.GetByAdmExamGrdngPkgId(transactionManager, entity.AdmExamGrdngPkgId);

				if (deep && entity.AdmCdePlacementExamCollection.Count > 0)
				{
					deepHandles.Add("AdmCdePlacementExamCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<AdmCdePlacementExam>) DataRepository.AdmCdePlacementExamProvider.DeepLoad,
						new object[] { transactionManager, entity.AdmCdePlacementExamCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AdmExamGrdngPkg object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AdmExamGrdngPkg instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmExamGrdngPkg Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmExamGrdngPkg entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<AdmExamGrdngPkgDtl>
				if (CanDeepSave(entity.AdmExamGrdngPkgDtlCollection, "List<AdmExamGrdngPkgDtl>|AdmExamGrdngPkgDtlCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmExamGrdngPkgDtl child in entity.AdmExamGrdngPkgDtlCollection)
					{
						if(child.AdmExamGrdngPkgIdSource != null)
						{
							child.AdmExamGrdngPkgId = child.AdmExamGrdngPkgIdSource.AdmExamGrdngPkgId;
						}
						else
						{
							child.AdmExamGrdngPkgId = entity.AdmExamGrdngPkgId;
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
				
	
			#region List<EdCodeQualGroup>
				if (CanDeepSave(entity.EdCodeQualGroupCollection, "List<EdCodeQualGroup>|EdCodeQualGroupCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdCodeQualGroup child in entity.EdCodeQualGroupCollection)
					{
						if(child.AdmExamGrdngPkgIdSource != null)
						{
							child.AdmExamGrdngPkgId = child.AdmExamGrdngPkgIdSource.AdmExamGrdngPkgId;
						}
						else
						{
							child.AdmExamGrdngPkgId = entity.AdmExamGrdngPkgId;
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
				
	
			#region List<AdmCdePlacementExam>
				if (CanDeepSave(entity.AdmCdePlacementExamCollection, "List<AdmCdePlacementExam>|AdmCdePlacementExamCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(AdmCdePlacementExam child in entity.AdmCdePlacementExamCollection)
					{
						if(child.AdmExamGrdngPkgIdSource != null)
						{
							child.AdmExamGrdngPkgId = child.AdmExamGrdngPkgIdSource.AdmExamGrdngPkgId;
						}
						else
						{
							child.AdmExamGrdngPkgId = entity.AdmExamGrdngPkgId;
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
	
	#region AdmExamGrdngPkgChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AdmExamGrdngPkg</c>
	///</summary>
	public enum AdmExamGrdngPkgChildEntityTypes
	{
		///<summary>
		/// Collection of <c>AdmExamGrdngPkg</c> as OneToMany for AdmExamGrdngPkgDtlCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmExamGrdngPkgDtl>))]
		AdmExamGrdngPkgDtlCollection,
		///<summary>
		/// Collection of <c>AdmExamGrdngPkg</c> as OneToMany for EdCodeQualGroupCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdCodeQualGroup>))]
		EdCodeQualGroupCollection,
		///<summary>
		/// Collection of <c>AdmExamGrdngPkg</c> as OneToMany for AdmCdePlacementExamCollection
		///</summary>
		[ChildEntityType(typeof(TList<AdmCdePlacementExam>))]
		AdmCdePlacementExamCollection,
	}
	
	#endregion AdmExamGrdngPkgChildEntityTypes
	
	#region AdmExamGrdngPkgFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AdmExamGrdngPkgColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmExamGrdngPkg"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmExamGrdngPkgFilterBuilder : SqlFilterBuilder<AdmExamGrdngPkgColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmExamGrdngPkgFilterBuilder class.
		/// </summary>
		public AdmExamGrdngPkgFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmExamGrdngPkgFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmExamGrdngPkgFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmExamGrdngPkgFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmExamGrdngPkgFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmExamGrdngPkgFilterBuilder
	
	#region AdmExamGrdngPkgParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AdmExamGrdngPkgColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmExamGrdngPkg"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmExamGrdngPkgParameterBuilder : ParameterizedSqlFilterBuilder<AdmExamGrdngPkgColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmExamGrdngPkgParameterBuilder class.
		/// </summary>
		public AdmExamGrdngPkgParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmExamGrdngPkgParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmExamGrdngPkgParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmExamGrdngPkgParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmExamGrdngPkgParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmExamGrdngPkgParameterBuilder
	
	#region AdmExamGrdngPkgSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AdmExamGrdngPkgColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmExamGrdngPkg"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AdmExamGrdngPkgSortBuilder : SqlSortBuilder<AdmExamGrdngPkgColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmExamGrdngPkgSqlSortBuilder class.
		/// </summary>
		public AdmExamGrdngPkgSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AdmExamGrdngPkgSortBuilder
	
} // end namespace
