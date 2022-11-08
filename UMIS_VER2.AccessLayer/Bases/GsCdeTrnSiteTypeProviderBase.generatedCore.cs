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
	/// This class is the base class for any <see cref="GsCdeTrnSiteTypeProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GsCdeTrnSiteTypeProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.GsCdeTrnSiteType, UMIS_VER2.BusinessLyer.GsCdeTrnSiteTypeKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeTrnSiteTypeKey key)
		{
			return Delete(transactionManager, key.GsCdeTrnSiteTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_gsCdeTrnSiteTypeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _gsCdeTrnSiteTypeId)
		{
			return Delete(null, _gsCdeTrnSiteTypeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeTrnSiteTypeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _gsCdeTrnSiteTypeId);		
		
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
		public override UMIS_VER2.BusinessLyer.GsCdeTrnSiteType Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeTrnSiteTypeKey key, int start, int pageLength)
		{
			return GetByGsCdeTrnSiteTypeId(transactionManager, key.GsCdeTrnSiteTypeId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_GS_CDE_TRN_SITE_TYPE index.
		/// </summary>
		/// <param name="_gsCdeTrnSiteTypeId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeTrnSiteType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeTrnSiteType GetByGsCdeTrnSiteTypeId(System.Decimal _gsCdeTrnSiteTypeId)
		{
			int count = -1;
			return GetByGsCdeTrnSiteTypeId(null,_gsCdeTrnSiteTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_TRN_SITE_TYPE index.
		/// </summary>
		/// <param name="_gsCdeTrnSiteTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeTrnSiteType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeTrnSiteType GetByGsCdeTrnSiteTypeId(System.Decimal _gsCdeTrnSiteTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeTrnSiteTypeId(null, _gsCdeTrnSiteTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_TRN_SITE_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeTrnSiteTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeTrnSiteType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeTrnSiteType GetByGsCdeTrnSiteTypeId(TransactionManager transactionManager, System.Decimal _gsCdeTrnSiteTypeId)
		{
			int count = -1;
			return GetByGsCdeTrnSiteTypeId(transactionManager, _gsCdeTrnSiteTypeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_TRN_SITE_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeTrnSiteTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeTrnSiteType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeTrnSiteType GetByGsCdeTrnSiteTypeId(TransactionManager transactionManager, System.Decimal _gsCdeTrnSiteTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeTrnSiteTypeId(transactionManager, _gsCdeTrnSiteTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_TRN_SITE_TYPE index.
		/// </summary>
		/// <param name="_gsCdeTrnSiteTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeTrnSiteType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeTrnSiteType GetByGsCdeTrnSiteTypeId(System.Decimal _gsCdeTrnSiteTypeId, int start, int pageLength, out int count)
		{
			return GetByGsCdeTrnSiteTypeId(null, _gsCdeTrnSiteTypeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_TRN_SITE_TYPE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeTrnSiteTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeTrnSiteType"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsCdeTrnSiteType GetByGsCdeTrnSiteTypeId(TransactionManager transactionManager, System.Decimal _gsCdeTrnSiteTypeId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_GS_CDE_TRN_SITE_TYPE_AR index.
		/// </summary>
		/// <param name="_descrAr"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeTrnSiteType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeTrnSiteType GetByDescrAr(System.String _descrAr)
		{
			int count = -1;
			return GetByDescrAr(null,_descrAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_CDE_TRN_SITE_TYPE_AR index.
		/// </summary>
		/// <param name="_descrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeTrnSiteType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeTrnSiteType GetByDescrAr(System.String _descrAr, int start, int pageLength)
		{
			int count = -1;
			return GetByDescrAr(null, _descrAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_CDE_TRN_SITE_TYPE_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_descrAr"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeTrnSiteType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeTrnSiteType GetByDescrAr(TransactionManager transactionManager, System.String _descrAr)
		{
			int count = -1;
			return GetByDescrAr(transactionManager, _descrAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_CDE_TRN_SITE_TYPE_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_descrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeTrnSiteType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeTrnSiteType GetByDescrAr(TransactionManager transactionManager, System.String _descrAr, int start, int pageLength)
		{
			int count = -1;
			return GetByDescrAr(transactionManager, _descrAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_CDE_TRN_SITE_TYPE_AR index.
		/// </summary>
		/// <param name="_descrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeTrnSiteType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeTrnSiteType GetByDescrAr(System.String _descrAr, int start, int pageLength, out int count)
		{
			return GetByDescrAr(null, _descrAr, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_CDE_TRN_SITE_TYPE_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_descrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeTrnSiteType"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsCdeTrnSiteType GetByDescrAr(TransactionManager transactionManager, System.String _descrAr, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_GS_CDE_TRN_SITE_TYPE_EN index.
		/// </summary>
		/// <param name="_descrEn"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeTrnSiteType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeTrnSiteType GetByDescrEn(System.String _descrEn)
		{
			int count = -1;
			return GetByDescrEn(null,_descrEn, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_CDE_TRN_SITE_TYPE_EN index.
		/// </summary>
		/// <param name="_descrEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeTrnSiteType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeTrnSiteType GetByDescrEn(System.String _descrEn, int start, int pageLength)
		{
			int count = -1;
			return GetByDescrEn(null, _descrEn, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_CDE_TRN_SITE_TYPE_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_descrEn"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeTrnSiteType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeTrnSiteType GetByDescrEn(TransactionManager transactionManager, System.String _descrEn)
		{
			int count = -1;
			return GetByDescrEn(transactionManager, _descrEn, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_CDE_TRN_SITE_TYPE_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_descrEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeTrnSiteType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeTrnSiteType GetByDescrEn(TransactionManager transactionManager, System.String _descrEn, int start, int pageLength)
		{
			int count = -1;
			return GetByDescrEn(transactionManager, _descrEn, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_CDE_TRN_SITE_TYPE_EN index.
		/// </summary>
		/// <param name="_descrEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeTrnSiteType"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeTrnSiteType GetByDescrEn(System.String _descrEn, int start, int pageLength, out int count)
		{
			return GetByDescrEn(null, _descrEn, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_CDE_TRN_SITE_TYPE_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_descrEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeTrnSiteType"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsCdeTrnSiteType GetByDescrEn(TransactionManager transactionManager, System.String _descrEn, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GsCdeTrnSiteType&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GsCdeTrnSiteType&gt;"/></returns>
		public static TList<GsCdeTrnSiteType> Fill(IDataReader reader, TList<GsCdeTrnSiteType> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.GsCdeTrnSiteType c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GsCdeTrnSiteType")
					.Append("|").Append((System.Decimal)reader["GS_CDE_TRN_SITE_TYPE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<GsCdeTrnSiteType>(
					key.ToString(), // EntityTrackingKey
					"GsCdeTrnSiteType",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.GsCdeTrnSiteType();
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
					c.GsCdeTrnSiteTypeId = (System.Decimal)reader["GS_CDE_TRN_SITE_TYPE_ID"];
					c.OriginalGsCdeTrnSiteTypeId = c.GsCdeTrnSiteTypeId;
					c.DescrAr = (System.String)reader["DESCR_AR"];
					c.DescrEn = (System.String)reader["DESCR_EN"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCdeTrnSiteType"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCdeTrnSiteType"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.GsCdeTrnSiteType entity)
		{
			if (!reader.Read()) return;
			
			entity.GsCdeTrnSiteTypeId = (System.Decimal)reader[((int)GsCdeTrnSiteTypeColumn.GsCdeTrnSiteTypeId - 1)];
			entity.OriginalGsCdeTrnSiteTypeId = (System.Decimal)reader["GS_CDE_TRN_SITE_TYPE_ID"];
			entity.DescrAr = (System.String)reader[((int)GsCdeTrnSiteTypeColumn.DescrAr - 1)];
			entity.DescrEn = (System.String)reader[((int)GsCdeTrnSiteTypeColumn.DescrEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCdeTrnSiteType"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCdeTrnSiteType"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.GsCdeTrnSiteType entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.GsCdeTrnSiteTypeId = (System.Decimal)dataRow["GS_CDE_TRN_SITE_TYPE_ID"];
			entity.OriginalGsCdeTrnSiteTypeId = (System.Decimal)dataRow["GS_CDE_TRN_SITE_TYPE_ID"];
			entity.DescrAr = (System.String)dataRow["DESCR_AR"];
			entity.DescrEn = (System.String)dataRow["DESCR_EN"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCdeTrnSiteType"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCdeTrnSiteType Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeTrnSiteType entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByGsCdeTrnSiteTypeId methods when available
			
			#region GsCdeTrainSiteCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GsCdeTrainSite>|GsCdeTrainSiteCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCdeTrainSiteCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GsCdeTrainSiteCollection = DataRepository.GsCdeTrainSiteProvider.GetByGsCdeTrnSiteTypeId(transactionManager, entity.GsCdeTrnSiteTypeId);

				if (deep && entity.GsCdeTrainSiteCollection.Count > 0)
				{
					deepHandles.Add("GsCdeTrainSiteCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GsCdeTrainSite>) DataRepository.GsCdeTrainSiteProvider.DeepLoad,
						new object[] { transactionManager, entity.GsCdeTrainSiteCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.GsCdeTrnSiteType object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.GsCdeTrnSiteType instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCdeTrnSiteType Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeTrnSiteType entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
			#region List<GsCdeTrainSite>
				if (CanDeepSave(entity.GsCdeTrainSiteCollection, "List<GsCdeTrainSite>|GsCdeTrainSiteCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GsCdeTrainSite child in entity.GsCdeTrainSiteCollection)
					{
						if(child.GsCdeTrnSiteTypeIdSource != null)
						{
							child.GsCdeTrnSiteTypeId = child.GsCdeTrnSiteTypeIdSource.GsCdeTrnSiteTypeId;
						}
						else
						{
							child.GsCdeTrnSiteTypeId = entity.GsCdeTrnSiteTypeId;
						}

					}

					if (entity.GsCdeTrainSiteCollection.Count > 0 || entity.GsCdeTrainSiteCollection.DeletedItems.Count > 0)
					{
						//DataRepository.GsCdeTrainSiteProvider.Save(transactionManager, entity.GsCdeTrainSiteCollection);
						
						deepHandles.Add("GsCdeTrainSiteCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< GsCdeTrainSite >) DataRepository.GsCdeTrainSiteProvider.DeepSave,
							new object[] { transactionManager, entity.GsCdeTrainSiteCollection, deepSaveType, childTypes, innerList }
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
	
	#region GsCdeTrnSiteTypeChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.GsCdeTrnSiteType</c>
	///</summary>
	public enum GsCdeTrnSiteTypeChildEntityTypes
	{
		///<summary>
		/// Collection of <c>GsCdeTrnSiteType</c> as OneToMany for GsCdeTrainSiteCollection
		///</summary>
		[ChildEntityType(typeof(TList<GsCdeTrainSite>))]
		GsCdeTrainSiteCollection,
	}
	
	#endregion GsCdeTrnSiteTypeChildEntityTypes
	
	#region GsCdeTrnSiteTypeFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GsCdeTrnSiteTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCdeTrnSiteType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCdeTrnSiteTypeFilterBuilder : SqlFilterBuilder<GsCdeTrnSiteTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCdeTrnSiteTypeFilterBuilder class.
		/// </summary>
		public GsCdeTrnSiteTypeFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCdeTrnSiteTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCdeTrnSiteTypeFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCdeTrnSiteTypeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCdeTrnSiteTypeFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCdeTrnSiteTypeFilterBuilder
	
	#region GsCdeTrnSiteTypeParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GsCdeTrnSiteTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCdeTrnSiteType"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCdeTrnSiteTypeParameterBuilder : ParameterizedSqlFilterBuilder<GsCdeTrnSiteTypeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCdeTrnSiteTypeParameterBuilder class.
		/// </summary>
		public GsCdeTrnSiteTypeParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCdeTrnSiteTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCdeTrnSiteTypeParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCdeTrnSiteTypeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCdeTrnSiteTypeParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCdeTrnSiteTypeParameterBuilder
	
	#region GsCdeTrnSiteTypeSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GsCdeTrnSiteTypeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCdeTrnSiteType"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GsCdeTrnSiteTypeSortBuilder : SqlSortBuilder<GsCdeTrnSiteTypeColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCdeTrnSiteTypeSqlSortBuilder class.
		/// </summary>
		public GsCdeTrnSiteTypeSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GsCdeTrnSiteTypeSortBuilder
	
} // end namespace
