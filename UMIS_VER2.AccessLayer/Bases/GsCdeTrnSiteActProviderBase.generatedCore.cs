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
	/// This class is the base class for any <see cref="GsCdeTrnSiteActProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GsCdeTrnSiteActProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.GsCdeTrnSiteAct, UMIS_VER2.BusinessLyer.GsCdeTrnSiteActKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeTrnSiteActKey key)
		{
			return Delete(transactionManager, key.GsCdeTrnSiteActId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_gsCdeTrnSiteActId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _gsCdeTrnSiteActId)
		{
			return Delete(null, _gsCdeTrnSiteActId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeTrnSiteActId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _gsCdeTrnSiteActId);		
		
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
		public override UMIS_VER2.BusinessLyer.GsCdeTrnSiteAct Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeTrnSiteActKey key, int start, int pageLength)
		{
			return GetByGsCdeTrnSiteActId(transactionManager, key.GsCdeTrnSiteActId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_GS_CDE_TRN_SITE_ACT index.
		/// </summary>
		/// <param name="_gsCdeTrnSiteActId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeTrnSiteAct"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeTrnSiteAct GetByGsCdeTrnSiteActId(System.Decimal _gsCdeTrnSiteActId)
		{
			int count = -1;
			return GetByGsCdeTrnSiteActId(null,_gsCdeTrnSiteActId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_TRN_SITE_ACT index.
		/// </summary>
		/// <param name="_gsCdeTrnSiteActId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeTrnSiteAct"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeTrnSiteAct GetByGsCdeTrnSiteActId(System.Decimal _gsCdeTrnSiteActId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeTrnSiteActId(null, _gsCdeTrnSiteActId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_TRN_SITE_ACT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeTrnSiteActId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeTrnSiteAct"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeTrnSiteAct GetByGsCdeTrnSiteActId(TransactionManager transactionManager, System.Decimal _gsCdeTrnSiteActId)
		{
			int count = -1;
			return GetByGsCdeTrnSiteActId(transactionManager, _gsCdeTrnSiteActId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_TRN_SITE_ACT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeTrnSiteActId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeTrnSiteAct"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeTrnSiteAct GetByGsCdeTrnSiteActId(TransactionManager transactionManager, System.Decimal _gsCdeTrnSiteActId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeTrnSiteActId(transactionManager, _gsCdeTrnSiteActId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_TRN_SITE_ACT index.
		/// </summary>
		/// <param name="_gsCdeTrnSiteActId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeTrnSiteAct"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeTrnSiteAct GetByGsCdeTrnSiteActId(System.Decimal _gsCdeTrnSiteActId, int start, int pageLength, out int count)
		{
			return GetByGsCdeTrnSiteActId(null, _gsCdeTrnSiteActId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_TRN_SITE_ACT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeTrnSiteActId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeTrnSiteAct"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsCdeTrnSiteAct GetByGsCdeTrnSiteActId(TransactionManager transactionManager, System.Decimal _gsCdeTrnSiteActId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_GS_CDE_TRN_SITE_ACT_AR index.
		/// </summary>
		/// <param name="_descrAr"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeTrnSiteAct"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeTrnSiteAct GetByDescrAr(System.String _descrAr)
		{
			int count = -1;
			return GetByDescrAr(null,_descrAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_CDE_TRN_SITE_ACT_AR index.
		/// </summary>
		/// <param name="_descrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeTrnSiteAct"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeTrnSiteAct GetByDescrAr(System.String _descrAr, int start, int pageLength)
		{
			int count = -1;
			return GetByDescrAr(null, _descrAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_CDE_TRN_SITE_ACT_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_descrAr"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeTrnSiteAct"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeTrnSiteAct GetByDescrAr(TransactionManager transactionManager, System.String _descrAr)
		{
			int count = -1;
			return GetByDescrAr(transactionManager, _descrAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_CDE_TRN_SITE_ACT_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_descrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeTrnSiteAct"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeTrnSiteAct GetByDescrAr(TransactionManager transactionManager, System.String _descrAr, int start, int pageLength)
		{
			int count = -1;
			return GetByDescrAr(transactionManager, _descrAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_CDE_TRN_SITE_ACT_AR index.
		/// </summary>
		/// <param name="_descrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeTrnSiteAct"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeTrnSiteAct GetByDescrAr(System.String _descrAr, int start, int pageLength, out int count)
		{
			return GetByDescrAr(null, _descrAr, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_CDE_TRN_SITE_ACT_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_descrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeTrnSiteAct"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsCdeTrnSiteAct GetByDescrAr(TransactionManager transactionManager, System.String _descrAr, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_GS_CDE_TRN_SITE_ACT_EN index.
		/// </summary>
		/// <param name="_descrEn"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeTrnSiteAct"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeTrnSiteAct GetByDescrEn(System.String _descrEn)
		{
			int count = -1;
			return GetByDescrEn(null,_descrEn, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_CDE_TRN_SITE_ACT_EN index.
		/// </summary>
		/// <param name="_descrEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeTrnSiteAct"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeTrnSiteAct GetByDescrEn(System.String _descrEn, int start, int pageLength)
		{
			int count = -1;
			return GetByDescrEn(null, _descrEn, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_CDE_TRN_SITE_ACT_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_descrEn"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeTrnSiteAct"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeTrnSiteAct GetByDescrEn(TransactionManager transactionManager, System.String _descrEn)
		{
			int count = -1;
			return GetByDescrEn(transactionManager, _descrEn, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_CDE_TRN_SITE_ACT_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_descrEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeTrnSiteAct"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeTrnSiteAct GetByDescrEn(TransactionManager transactionManager, System.String _descrEn, int start, int pageLength)
		{
			int count = -1;
			return GetByDescrEn(transactionManager, _descrEn, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_CDE_TRN_SITE_ACT_EN index.
		/// </summary>
		/// <param name="_descrEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeTrnSiteAct"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeTrnSiteAct GetByDescrEn(System.String _descrEn, int start, int pageLength, out int count)
		{
			return GetByDescrEn(null, _descrEn, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_GS_CDE_TRN_SITE_ACT_EN index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_descrEn"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeTrnSiteAct"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsCdeTrnSiteAct GetByDescrEn(TransactionManager transactionManager, System.String _descrEn, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GsCdeTrnSiteAct&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GsCdeTrnSiteAct&gt;"/></returns>
		public static TList<GsCdeTrnSiteAct> Fill(IDataReader reader, TList<GsCdeTrnSiteAct> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.GsCdeTrnSiteAct c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GsCdeTrnSiteAct")
					.Append("|").Append((System.Decimal)reader["GS_CDE_TRN_SITE_ACT_ID"]).ToString();
					c = EntityManager.LocateOrCreate<GsCdeTrnSiteAct>(
					key.ToString(), // EntityTrackingKey
					"GsCdeTrnSiteAct",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.GsCdeTrnSiteAct();
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
					c.GsCdeTrnSiteActId = (System.Decimal)reader["GS_CDE_TRN_SITE_ACT_ID"];
					c.OriginalGsCdeTrnSiteActId = c.GsCdeTrnSiteActId;
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCdeTrnSiteAct"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCdeTrnSiteAct"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.GsCdeTrnSiteAct entity)
		{
			if (!reader.Read()) return;
			
			entity.GsCdeTrnSiteActId = (System.Decimal)reader[((int)GsCdeTrnSiteActColumn.GsCdeTrnSiteActId - 1)];
			entity.OriginalGsCdeTrnSiteActId = (System.Decimal)reader["GS_CDE_TRN_SITE_ACT_ID"];
			entity.DescrAr = (System.String)reader[((int)GsCdeTrnSiteActColumn.DescrAr - 1)];
			entity.DescrEn = (System.String)reader[((int)GsCdeTrnSiteActColumn.DescrEn - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCdeTrnSiteAct"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCdeTrnSiteAct"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.GsCdeTrnSiteAct entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.GsCdeTrnSiteActId = (System.Decimal)dataRow["GS_CDE_TRN_SITE_ACT_ID"];
			entity.OriginalGsCdeTrnSiteActId = (System.Decimal)dataRow["GS_CDE_TRN_SITE_ACT_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCdeTrnSiteAct"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCdeTrnSiteAct Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeTrnSiteAct entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByGsCdeTrnSiteActId methods when available
			
			#region GsCdeTrainSiteCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GsCdeTrainSite>|GsCdeTrainSiteCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCdeTrainSiteCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GsCdeTrainSiteCollection = DataRepository.GsCdeTrainSiteProvider.GetByGsCdeTrnSiteActId(transactionManager, entity.GsCdeTrnSiteActId);

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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.GsCdeTrnSiteAct object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.GsCdeTrnSiteAct instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCdeTrnSiteAct Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeTrnSiteAct entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
						if(child.GsCdeTrnSiteActIdSource != null)
						{
							child.GsCdeTrnSiteActId = child.GsCdeTrnSiteActIdSource.GsCdeTrnSiteActId;
						}
						else
						{
							child.GsCdeTrnSiteActId = entity.GsCdeTrnSiteActId;
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
	
	#region GsCdeTrnSiteActChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.GsCdeTrnSiteAct</c>
	///</summary>
	public enum GsCdeTrnSiteActChildEntityTypes
	{
		///<summary>
		/// Collection of <c>GsCdeTrnSiteAct</c> as OneToMany for GsCdeTrainSiteCollection
		///</summary>
		[ChildEntityType(typeof(TList<GsCdeTrainSite>))]
		GsCdeTrainSiteCollection,
	}
	
	#endregion GsCdeTrnSiteActChildEntityTypes
	
	#region GsCdeTrnSiteActFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GsCdeTrnSiteActColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCdeTrnSiteAct"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCdeTrnSiteActFilterBuilder : SqlFilterBuilder<GsCdeTrnSiteActColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCdeTrnSiteActFilterBuilder class.
		/// </summary>
		public GsCdeTrnSiteActFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCdeTrnSiteActFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCdeTrnSiteActFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCdeTrnSiteActFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCdeTrnSiteActFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCdeTrnSiteActFilterBuilder
	
	#region GsCdeTrnSiteActParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GsCdeTrnSiteActColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCdeTrnSiteAct"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCdeTrnSiteActParameterBuilder : ParameterizedSqlFilterBuilder<GsCdeTrnSiteActColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCdeTrnSiteActParameterBuilder class.
		/// </summary>
		public GsCdeTrnSiteActParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCdeTrnSiteActParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCdeTrnSiteActParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCdeTrnSiteActParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCdeTrnSiteActParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCdeTrnSiteActParameterBuilder
	
	#region GsCdeTrnSiteActSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GsCdeTrnSiteActColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCdeTrnSiteAct"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GsCdeTrnSiteActSortBuilder : SqlSortBuilder<GsCdeTrnSiteActColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCdeTrnSiteActSqlSortBuilder class.
		/// </summary>
		public GsCdeTrnSiteActSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GsCdeTrnSiteActSortBuilder
	
} // end namespace
