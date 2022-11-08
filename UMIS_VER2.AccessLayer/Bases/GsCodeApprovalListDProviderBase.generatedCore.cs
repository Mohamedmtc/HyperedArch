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
	/// This class is the base class for any <see cref="GsCodeApprovalListDProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GsCodeApprovalListDProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.GsCodeApprovalListD, UMIS_VER2.BusinessLyer.GsCodeApprovalListDKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeApprovalListDKey key)
		{
			return Delete(transactionManager, key.GsCodeApprovalListDId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_gsCodeApprovalListDId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _gsCodeApprovalListDId)
		{
			return Delete(null, _gsCodeApprovalListDId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeApprovalListDId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _gsCodeApprovalListDId);		
		
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
		public override UMIS_VER2.BusinessLyer.GsCodeApprovalListD Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeApprovalListDKey key, int start, int pageLength)
		{
			return GetByGsCodeApprovalListDId(transactionManager, key.GsCodeApprovalListDId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_GS_CODE_APPROVAL_ID_1 index.
		/// </summary>
		/// <param name="_gsCodeApprovalId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;GsCodeApprovalListD&gt;"/> class.</returns>
		public TList<GsCodeApprovalListD> GetByGsCodeApprovalId(System.Decimal _gsCodeApprovalId)
		{
			int count = -1;
			return GetByGsCodeApprovalId(null,_gsCodeApprovalId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_APPROVAL_ID_1 index.
		/// </summary>
		/// <param name="_gsCodeApprovalId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;GsCodeApprovalListD&gt;"/> class.</returns>
		public TList<GsCodeApprovalListD> GetByGsCodeApprovalId(System.Decimal _gsCodeApprovalId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeApprovalId(null, _gsCodeApprovalId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_APPROVAL_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeApprovalId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;GsCodeApprovalListD&gt;"/> class.</returns>
		public TList<GsCodeApprovalListD> GetByGsCodeApprovalId(TransactionManager transactionManager, System.Decimal _gsCodeApprovalId)
		{
			int count = -1;
			return GetByGsCodeApprovalId(transactionManager, _gsCodeApprovalId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_APPROVAL_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeApprovalId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;GsCodeApprovalListD&gt;"/> class.</returns>
		public TList<GsCodeApprovalListD> GetByGsCodeApprovalId(TransactionManager transactionManager, System.Decimal _gsCodeApprovalId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeApprovalId(transactionManager, _gsCodeApprovalId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_APPROVAL_ID_1 index.
		/// </summary>
		/// <param name="_gsCodeApprovalId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;GsCodeApprovalListD&gt;"/> class.</returns>
		public TList<GsCodeApprovalListD> GetByGsCodeApprovalId(System.Decimal _gsCodeApprovalId, int start, int pageLength, out int count)
		{
			return GetByGsCodeApprovalId(null, _gsCodeApprovalId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_APPROVAL_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeApprovalId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;GsCodeApprovalListD&gt;"/> class.</returns>
		public abstract TList<GsCodeApprovalListD> GetByGsCodeApprovalId(TransactionManager transactionManager, System.Decimal _gsCodeApprovalId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_GS_CODE_APPROVAL_LIS_1 index.
		/// </summary>
		/// <param name="_gsCodeApprovalListHId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;GsCodeApprovalListD&gt;"/> class.</returns>
		public TList<GsCodeApprovalListD> GetByGsCodeApprovalListHId(System.Decimal _gsCodeApprovalListHId)
		{
			int count = -1;
			return GetByGsCodeApprovalListHId(null,_gsCodeApprovalListHId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_APPROVAL_LIS_1 index.
		/// </summary>
		/// <param name="_gsCodeApprovalListHId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;GsCodeApprovalListD&gt;"/> class.</returns>
		public TList<GsCodeApprovalListD> GetByGsCodeApprovalListHId(System.Decimal _gsCodeApprovalListHId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeApprovalListHId(null, _gsCodeApprovalListHId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_APPROVAL_LIS_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeApprovalListHId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;GsCodeApprovalListD&gt;"/> class.</returns>
		public TList<GsCodeApprovalListD> GetByGsCodeApprovalListHId(TransactionManager transactionManager, System.Decimal _gsCodeApprovalListHId)
		{
			int count = -1;
			return GetByGsCodeApprovalListHId(transactionManager, _gsCodeApprovalListHId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_APPROVAL_LIS_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeApprovalListHId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;GsCodeApprovalListD&gt;"/> class.</returns>
		public TList<GsCodeApprovalListD> GetByGsCodeApprovalListHId(TransactionManager transactionManager, System.Decimal _gsCodeApprovalListHId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeApprovalListHId(transactionManager, _gsCodeApprovalListHId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_APPROVAL_LIS_1 index.
		/// </summary>
		/// <param name="_gsCodeApprovalListHId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;GsCodeApprovalListD&gt;"/> class.</returns>
		public TList<GsCodeApprovalListD> GetByGsCodeApprovalListHId(System.Decimal _gsCodeApprovalListHId, int start, int pageLength, out int count)
		{
			return GetByGsCodeApprovalListHId(null, _gsCodeApprovalListHId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CODE_APPROVAL_LIS_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeApprovalListHId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;GsCodeApprovalListD&gt;"/> class.</returns>
		public abstract TList<GsCodeApprovalListD> GetByGsCodeApprovalListHId(TransactionManager transactionManager, System.Decimal _gsCodeApprovalListHId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_GS_CODE_APPROVAL_LIST_D index.
		/// </summary>
		/// <param name="_gsCodeApprovalListDId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeApprovalListD"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeApprovalListD GetByGsCodeApprovalListDId(System.Decimal _gsCodeApprovalListDId)
		{
			int count = -1;
			return GetByGsCodeApprovalListDId(null,_gsCodeApprovalListDId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_APPROVAL_LIST_D index.
		/// </summary>
		/// <param name="_gsCodeApprovalListDId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeApprovalListD"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeApprovalListD GetByGsCodeApprovalListDId(System.Decimal _gsCodeApprovalListDId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeApprovalListDId(null, _gsCodeApprovalListDId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_APPROVAL_LIST_D index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeApprovalListDId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeApprovalListD"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeApprovalListD GetByGsCodeApprovalListDId(TransactionManager transactionManager, System.Decimal _gsCodeApprovalListDId)
		{
			int count = -1;
			return GetByGsCodeApprovalListDId(transactionManager, _gsCodeApprovalListDId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_APPROVAL_LIST_D index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeApprovalListDId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeApprovalListD"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeApprovalListD GetByGsCodeApprovalListDId(TransactionManager transactionManager, System.Decimal _gsCodeApprovalListDId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeApprovalListDId(transactionManager, _gsCodeApprovalListDId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_APPROVAL_LIST_D index.
		/// </summary>
		/// <param name="_gsCodeApprovalListDId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeApprovalListD"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCodeApprovalListD GetByGsCodeApprovalListDId(System.Decimal _gsCodeApprovalListDId, int start, int pageLength, out int count)
		{
			return GetByGsCodeApprovalListDId(null, _gsCodeApprovalListDId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CODE_APPROVAL_LIST_D index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeApprovalListDId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCodeApprovalListD"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsCodeApprovalListD GetByGsCodeApprovalListDId(TransactionManager transactionManager, System.Decimal _gsCodeApprovalListDId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GsCodeApprovalListD&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GsCodeApprovalListD&gt;"/></returns>
		public static TList<GsCodeApprovalListD> Fill(IDataReader reader, TList<GsCodeApprovalListD> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.GsCodeApprovalListD c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GsCodeApprovalListD")
					.Append("|").Append((System.Decimal)reader["GS_CODE_APPROVAL_LIST_D_ID"]).ToString();
					c = EntityManager.LocateOrCreate<GsCodeApprovalListD>(
					key.ToString(), // EntityTrackingKey
					"GsCodeApprovalListD",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.GsCodeApprovalListD();
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
					c.GsCodeApprovalListDId = (System.Decimal)reader["GS_CODE_APPROVAL_LIST_D_ID"];
					c.OriginalGsCodeApprovalListDId = c.GsCodeApprovalListDId;
					c.GsCodeApprovalListHId = (System.Decimal)reader["GS_CODE_APPROVAL_LIST_H_ID"];
					c.GsCodeApprovalId = (System.Decimal)reader["GS_CODE_APPROVAL_ID"];
					c.GsDelCodeApprovalId = Convert.IsDBNull(reader["GS_DEL_CODE_APPROVAL_ID"]) ? null : (System.Decimal?)reader["GS_DEL_CODE_APPROVAL_ID"];
					c.HasResolution = (System.Decimal)reader["HAS_RESOLUTION"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCodeApprovalListD"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCodeApprovalListD"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.GsCodeApprovalListD entity)
		{
			if (!reader.Read()) return;
			
			entity.GsCodeApprovalListDId = (System.Decimal)reader[((int)GsCodeApprovalListDColumn.GsCodeApprovalListDId - 1)];
			entity.OriginalGsCodeApprovalListDId = (System.Decimal)reader["GS_CODE_APPROVAL_LIST_D_ID"];
			entity.GsCodeApprovalListHId = (System.Decimal)reader[((int)GsCodeApprovalListDColumn.GsCodeApprovalListHId - 1)];
			entity.GsCodeApprovalId = (System.Decimal)reader[((int)GsCodeApprovalListDColumn.GsCodeApprovalId - 1)];
			entity.GsDelCodeApprovalId = (reader.IsDBNull(((int)GsCodeApprovalListDColumn.GsDelCodeApprovalId - 1)))?null:(System.Decimal?)reader[((int)GsCodeApprovalListDColumn.GsDelCodeApprovalId - 1)];
			entity.HasResolution = (System.Decimal)reader[((int)GsCodeApprovalListDColumn.HasResolution - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCodeApprovalListD"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCodeApprovalListD"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.GsCodeApprovalListD entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.GsCodeApprovalListDId = (System.Decimal)dataRow["GS_CODE_APPROVAL_LIST_D_ID"];
			entity.OriginalGsCodeApprovalListDId = (System.Decimal)dataRow["GS_CODE_APPROVAL_LIST_D_ID"];
			entity.GsCodeApprovalListHId = (System.Decimal)dataRow["GS_CODE_APPROVAL_LIST_H_ID"];
			entity.GsCodeApprovalId = (System.Decimal)dataRow["GS_CODE_APPROVAL_ID"];
			entity.GsDelCodeApprovalId = Convert.IsDBNull(dataRow["GS_DEL_CODE_APPROVAL_ID"]) ? null : (System.Decimal?)dataRow["GS_DEL_CODE_APPROVAL_ID"];
			entity.HasResolution = (System.Decimal)dataRow["HAS_RESOLUTION"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCodeApprovalListD"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCodeApprovalListD Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeApprovalListD entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region GsCodeApprovalIdSource	
			if (CanDeepLoad(entity, "GsCodeApproval|GsCodeApprovalIdSource", deepLoadType, innerList) 
				&& entity.GsCodeApprovalIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.GsCodeApprovalId;
				GsCodeApproval tmpEntity = EntityManager.LocateEntity<GsCodeApproval>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodeApproval), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodeApprovalIdSource = tmpEntity;
				else
					entity.GsCodeApprovalIdSource = DataRepository.GsCodeApprovalProvider.GetByGsCodeApprovalId(transactionManager, entity.GsCodeApprovalId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodeApprovalIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCodeApprovalIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodeApprovalProvider.DeepLoad(transactionManager, entity.GsCodeApprovalIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCodeApprovalIdSource

			#region GsCodeApprovalListHIdSource	
			if (CanDeepLoad(entity, "GsCodeApprovalListH|GsCodeApprovalListHIdSource", deepLoadType, innerList) 
				&& entity.GsCodeApprovalListHIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.GsCodeApprovalListHId;
				GsCodeApprovalListH tmpEntity = EntityManager.LocateEntity<GsCodeApprovalListH>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodeApprovalListH), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodeApprovalListHIdSource = tmpEntity;
				else
					entity.GsCodeApprovalListHIdSource = DataRepository.GsCodeApprovalListHProvider.GetByGsCodeApprovalListHId(transactionManager, entity.GsCodeApprovalListHId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodeApprovalListHIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCodeApprovalListHIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodeApprovalListHProvider.DeepLoad(transactionManager, entity.GsCodeApprovalListHIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCodeApprovalListHIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByGsCodeApprovalListDId methods when available
			
			#region GsApprovalDCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GsApprovalD>|GsApprovalDCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsApprovalDCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GsApprovalDCollection = DataRepository.GsApprovalDProvider.GetByGsCodeApprovalListDId(transactionManager, entity.GsCodeApprovalListDId);

				if (deep && entity.GsApprovalDCollection.Count > 0)
				{
					deepHandles.Add("GsApprovalDCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GsApprovalD>) DataRepository.GsApprovalDProvider.DeepLoad,
						new object[] { transactionManager, entity.GsApprovalDCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.GsCodeApprovalListD object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.GsCodeApprovalListD instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCodeApprovalListD Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCodeApprovalListD entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region GsCodeApprovalIdSource
			if (CanDeepSave(entity, "GsCodeApproval|GsCodeApprovalIdSource", deepSaveType, innerList) 
				&& entity.GsCodeApprovalIdSource != null)
			{
				DataRepository.GsCodeApprovalProvider.Save(transactionManager, entity.GsCodeApprovalIdSource);
				entity.GsCodeApprovalId = entity.GsCodeApprovalIdSource.GsCodeApprovalId;
			}
			#endregion 
			
			#region GsCodeApprovalListHIdSource
			if (CanDeepSave(entity, "GsCodeApprovalListH|GsCodeApprovalListHIdSource", deepSaveType, innerList) 
				&& entity.GsCodeApprovalListHIdSource != null)
			{
				DataRepository.GsCodeApprovalListHProvider.Save(transactionManager, entity.GsCodeApprovalListHIdSource);
				entity.GsCodeApprovalListHId = entity.GsCodeApprovalListHIdSource.GsCodeApprovalListHId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<GsApprovalD>
				if (CanDeepSave(entity.GsApprovalDCollection, "List<GsApprovalD>|GsApprovalDCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GsApprovalD child in entity.GsApprovalDCollection)
					{
						if(child.GsCodeApprovalListDIdSource != null)
						{
							child.GsCodeApprovalListDId = child.GsCodeApprovalListDIdSource.GsCodeApprovalListDId;
						}
						else
						{
							child.GsCodeApprovalListDId = entity.GsCodeApprovalListDId;
						}

					}

					if (entity.GsApprovalDCollection.Count > 0 || entity.GsApprovalDCollection.DeletedItems.Count > 0)
					{
						//DataRepository.GsApprovalDProvider.Save(transactionManager, entity.GsApprovalDCollection);
						
						deepHandles.Add("GsApprovalDCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< GsApprovalD >) DataRepository.GsApprovalDProvider.DeepSave,
							new object[] { transactionManager, entity.GsApprovalDCollection, deepSaveType, childTypes, innerList }
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
	
	#region GsCodeApprovalListDChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.GsCodeApprovalListD</c>
	///</summary>
	public enum GsCodeApprovalListDChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>GsCodeApproval</c> at GsCodeApprovalIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeApproval))]
		GsCodeApproval,
		
		///<summary>
		/// Composite Property for <c>GsCodeApprovalListH</c> at GsCodeApprovalListHIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeApprovalListH))]
		GsCodeApprovalListH,
		///<summary>
		/// Collection of <c>GsCodeApprovalListD</c> as OneToMany for GsApprovalDCollection
		///</summary>
		[ChildEntityType(typeof(TList<GsApprovalD>))]
		GsApprovalDCollection,
	}
	
	#endregion GsCodeApprovalListDChildEntityTypes
	
	#region GsCodeApprovalListDFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GsCodeApprovalListDColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCodeApprovalListD"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCodeApprovalListDFilterBuilder : SqlFilterBuilder<GsCodeApprovalListDColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCodeApprovalListDFilterBuilder class.
		/// </summary>
		public GsCodeApprovalListDFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCodeApprovalListDFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCodeApprovalListDFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCodeApprovalListDFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCodeApprovalListDFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCodeApprovalListDFilterBuilder
	
	#region GsCodeApprovalListDParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GsCodeApprovalListDColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCodeApprovalListD"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCodeApprovalListDParameterBuilder : ParameterizedSqlFilterBuilder<GsCodeApprovalListDColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCodeApprovalListDParameterBuilder class.
		/// </summary>
		public GsCodeApprovalListDParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCodeApprovalListDParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCodeApprovalListDParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCodeApprovalListDParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCodeApprovalListDParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCodeApprovalListDParameterBuilder
	
	#region GsCodeApprovalListDSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GsCodeApprovalListDColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCodeApprovalListD"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GsCodeApprovalListDSortBuilder : SqlSortBuilder<GsCodeApprovalListDColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCodeApprovalListDSqlSortBuilder class.
		/// </summary>
		public GsCodeApprovalListDSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GsCodeApprovalListDSortBuilder
	
} // end namespace
