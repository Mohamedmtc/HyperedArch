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
	/// This class is the base class for any <see cref="GsCdeClrncItemFacProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GsCdeClrncItemFacProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.GsCdeClrncItemFac, UMIS_VER2.BusinessLyer.GsCdeClrncItemFacKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeClrncItemFacKey key)
		{
			return Delete(transactionManager, key.GsCdeClrncItemFacId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_gsCdeClrncItemFacId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _gsCdeClrncItemFacId)
		{
			return Delete(null, _gsCdeClrncItemFacId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeClrncItemFacId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _gsCdeClrncItemFacId);		
		
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
		public override UMIS_VER2.BusinessLyer.GsCdeClrncItemFac Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeClrncItemFacKey key, int start, int pageLength)
		{
			return GetByGsCdeClrncItemFacId(transactionManager, key.GsCdeClrncItemFacId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;GsCdeClrncItemFac&gt;"/> class.</returns>
		public TList<GsCdeClrncItemFac> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(null,_asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;GsCdeClrncItemFac&gt;"/> class.</returns>
		public TList<GsCdeClrncItemFac> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;GsCdeClrncItemFac&gt;"/> class.</returns>
		public TList<GsCdeClrncItemFac> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;GsCdeClrncItemFac&gt;"/> class.</returns>
		public TList<GsCdeClrncItemFac> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoId(transactionManager, _asFacultyInfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;GsCdeClrncItemFac&gt;"/> class.</returns>
		public TList<GsCdeClrncItemFac> GetByAsFacultyInfoId(System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count)
		{
			return GetByAsFacultyInfoId(null, _asFacultyInfoId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;GsCdeClrncItemFac&gt;"/> class.</returns>
		public abstract TList<GsCdeClrncItemFac> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_GS_CDE_CLRNC_ITEM_ID_1 index.
		/// </summary>
		/// <param name="_gsCdeClrncItemId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;GsCdeClrncItemFac&gt;"/> class.</returns>
		public TList<GsCdeClrncItemFac> GetByGsCdeClrncItemId(System.Decimal _gsCdeClrncItemId)
		{
			int count = -1;
			return GetByGsCdeClrncItemId(null,_gsCdeClrncItemId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CDE_CLRNC_ITEM_ID_1 index.
		/// </summary>
		/// <param name="_gsCdeClrncItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;GsCdeClrncItemFac&gt;"/> class.</returns>
		public TList<GsCdeClrncItemFac> GetByGsCdeClrncItemId(System.Decimal _gsCdeClrncItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeClrncItemId(null, _gsCdeClrncItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CDE_CLRNC_ITEM_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeClrncItemId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;GsCdeClrncItemFac&gt;"/> class.</returns>
		public TList<GsCdeClrncItemFac> GetByGsCdeClrncItemId(TransactionManager transactionManager, System.Decimal _gsCdeClrncItemId)
		{
			int count = -1;
			return GetByGsCdeClrncItemId(transactionManager, _gsCdeClrncItemId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CDE_CLRNC_ITEM_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeClrncItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;GsCdeClrncItemFac&gt;"/> class.</returns>
		public TList<GsCdeClrncItemFac> GetByGsCdeClrncItemId(TransactionManager transactionManager, System.Decimal _gsCdeClrncItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeClrncItemId(transactionManager, _gsCdeClrncItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CDE_CLRNC_ITEM_ID_1 index.
		/// </summary>
		/// <param name="_gsCdeClrncItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;GsCdeClrncItemFac&gt;"/> class.</returns>
		public TList<GsCdeClrncItemFac> GetByGsCdeClrncItemId(System.Decimal _gsCdeClrncItemId, int start, int pageLength, out int count)
		{
			return GetByGsCdeClrncItemId(null, _gsCdeClrncItemId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_GS_CDE_CLRNC_ITEM_ID_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeClrncItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;GsCdeClrncItemFac&gt;"/> class.</returns>
		public abstract TList<GsCdeClrncItemFac> GetByGsCdeClrncItemId(TransactionManager transactionManager, System.Decimal _gsCdeClrncItemId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_GS_CDE_CLRNC_ITEM_FAC index.
		/// </summary>
		/// <param name="_gsCdeClrncItemFacId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeClrncItemFac"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeClrncItemFac GetByGsCdeClrncItemFacId(System.Decimal _gsCdeClrncItemFacId)
		{
			int count = -1;
			return GetByGsCdeClrncItemFacId(null,_gsCdeClrncItemFacId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_CLRNC_ITEM_FAC index.
		/// </summary>
		/// <param name="_gsCdeClrncItemFacId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeClrncItemFac"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeClrncItemFac GetByGsCdeClrncItemFacId(System.Decimal _gsCdeClrncItemFacId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeClrncItemFacId(null, _gsCdeClrncItemFacId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_CLRNC_ITEM_FAC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeClrncItemFacId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeClrncItemFac"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeClrncItemFac GetByGsCdeClrncItemFacId(TransactionManager transactionManager, System.Decimal _gsCdeClrncItemFacId)
		{
			int count = -1;
			return GetByGsCdeClrncItemFacId(transactionManager, _gsCdeClrncItemFacId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_CLRNC_ITEM_FAC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeClrncItemFacId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeClrncItemFac"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeClrncItemFac GetByGsCdeClrncItemFacId(TransactionManager transactionManager, System.Decimal _gsCdeClrncItemFacId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeClrncItemFacId(transactionManager, _gsCdeClrncItemFacId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_CLRNC_ITEM_FAC index.
		/// </summary>
		/// <param name="_gsCdeClrncItemFacId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeClrncItemFac"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeClrncItemFac GetByGsCdeClrncItemFacId(System.Decimal _gsCdeClrncItemFacId, int start, int pageLength, out int count)
		{
			return GetByGsCdeClrncItemFacId(null, _gsCdeClrncItemFacId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_GS_CDE_CLRNC_ITEM_FAC index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeClrncItemFacId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeClrncItemFac"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsCdeClrncItemFac GetByGsCdeClrncItemFacId(TransactionManager transactionManager, System.Decimal _gsCdeClrncItemFacId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GsCdeClrncItemFac&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GsCdeClrncItemFac&gt;"/></returns>
		public static TList<GsCdeClrncItemFac> Fill(IDataReader reader, TList<GsCdeClrncItemFac> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.GsCdeClrncItemFac c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GsCdeClrncItemFac")
					.Append("|").Append((System.Decimal)reader["GS_CDE_CLRNC_ITEM_FAC_ID"]).ToString();
					c = EntityManager.LocateOrCreate<GsCdeClrncItemFac>(
					key.ToString(), // EntityTrackingKey
					"GsCdeClrncItemFac",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.GsCdeClrncItemFac();
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
					c.GsCdeClrncItemFacId = (System.Decimal)reader["GS_CDE_CLRNC_ITEM_FAC_ID"];
					c.OriginalGsCdeClrncItemFacId = c.GsCdeClrncItemFacId;
					c.GsCdeClrncItemId = (System.Decimal)reader["GS_CDE_CLRNC_ITEM_ID"];
					c.AsFacultyInfoId = Convert.IsDBNull(reader["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)reader["AS_FACULTY_INFO_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCdeClrncItemFac"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCdeClrncItemFac"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.GsCdeClrncItemFac entity)
		{
			if (!reader.Read()) return;
			
			entity.GsCdeClrncItemFacId = (System.Decimal)reader[((int)GsCdeClrncItemFacColumn.GsCdeClrncItemFacId - 1)];
			entity.OriginalGsCdeClrncItemFacId = (System.Decimal)reader["GS_CDE_CLRNC_ITEM_FAC_ID"];
			entity.GsCdeClrncItemId = (System.Decimal)reader[((int)GsCdeClrncItemFacColumn.GsCdeClrncItemId - 1)];
			entity.AsFacultyInfoId = (reader.IsDBNull(((int)GsCdeClrncItemFacColumn.AsFacultyInfoId - 1)))?null:(System.Decimal?)reader[((int)GsCdeClrncItemFacColumn.AsFacultyInfoId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCdeClrncItemFac"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCdeClrncItemFac"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.GsCdeClrncItemFac entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.GsCdeClrncItemFacId = (System.Decimal)dataRow["GS_CDE_CLRNC_ITEM_FAC_ID"];
			entity.OriginalGsCdeClrncItemFacId = (System.Decimal)dataRow["GS_CDE_CLRNC_ITEM_FAC_ID"];
			entity.GsCdeClrncItemId = (System.Decimal)dataRow["GS_CDE_CLRNC_ITEM_ID"];
			entity.AsFacultyInfoId = Convert.IsDBNull(dataRow["AS_FACULTY_INFO_ID"]) ? null : (System.Decimal?)dataRow["AS_FACULTY_INFO_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCdeClrncItemFac"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCdeClrncItemFac Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeClrncItemFac entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AsFacultyInfoIdSource	
			if (CanDeepLoad(entity, "AsFacultyInfo|AsFacultyInfoIdSource", deepLoadType, innerList) 
				&& entity.AsFacultyInfoIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AsFacultyInfoId ?? 0.0m);
				AsFacultyInfo tmpEntity = EntityManager.LocateEntity<AsFacultyInfo>(EntityLocator.ConstructKeyFromPkItems(typeof(AsFacultyInfo), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AsFacultyInfoIdSource = tmpEntity;
				else
					entity.AsFacultyInfoIdSource = DataRepository.AsFacultyInfoProvider.GetByAsFacultyInfoId(transactionManager, (entity.AsFacultyInfoId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AsFacultyInfoIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AsFacultyInfoIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AsFacultyInfoProvider.DeepLoad(transactionManager, entity.AsFacultyInfoIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AsFacultyInfoIdSource

			#region GsCdeClrncItemIdSource	
			if (CanDeepLoad(entity, "GsCdeClrncItem|GsCdeClrncItemIdSource", deepLoadType, innerList) 
				&& entity.GsCdeClrncItemIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.GsCdeClrncItemId;
				GsCdeClrncItem tmpEntity = EntityManager.LocateEntity<GsCdeClrncItem>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCdeClrncItem), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCdeClrncItemIdSource = tmpEntity;
				else
					entity.GsCdeClrncItemIdSource = DataRepository.GsCdeClrncItemProvider.GetByGsCdeClrncItemId(transactionManager, entity.GsCdeClrncItemId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCdeClrncItemIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCdeClrncItemIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCdeClrncItemProvider.DeepLoad(transactionManager, entity.GsCdeClrncItemIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCdeClrncItemIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.GsCdeClrncItemFac object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.GsCdeClrncItemFac instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCdeClrncItemFac Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeClrncItemFac entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AsFacultyInfoIdSource
			if (CanDeepSave(entity, "AsFacultyInfo|AsFacultyInfoIdSource", deepSaveType, innerList) 
				&& entity.AsFacultyInfoIdSource != null)
			{
				DataRepository.AsFacultyInfoProvider.Save(transactionManager, entity.AsFacultyInfoIdSource);
				entity.AsFacultyInfoId = entity.AsFacultyInfoIdSource.AsFacultyInfoId;
			}
			#endregion 
			
			#region GsCdeClrncItemIdSource
			if (CanDeepSave(entity, "GsCdeClrncItem|GsCdeClrncItemIdSource", deepSaveType, innerList) 
				&& entity.GsCdeClrncItemIdSource != null)
			{
				DataRepository.GsCdeClrncItemProvider.Save(transactionManager, entity.GsCdeClrncItemIdSource);
				entity.GsCdeClrncItemId = entity.GsCdeClrncItemIdSource.GsCdeClrncItemId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
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
	
	#region GsCdeClrncItemFacChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.GsCdeClrncItemFac</c>
	///</summary>
	public enum GsCdeClrncItemFacChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AsFacultyInfo</c> at AsFacultyInfoIdSource
		///</summary>
		[ChildEntityType(typeof(AsFacultyInfo))]
		AsFacultyInfo,
		
		///<summary>
		/// Composite Property for <c>GsCdeClrncItem</c> at GsCdeClrncItemIdSource
		///</summary>
		[ChildEntityType(typeof(GsCdeClrncItem))]
		GsCdeClrncItem,
	}
	
	#endregion GsCdeClrncItemFacChildEntityTypes
	
	#region GsCdeClrncItemFacFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GsCdeClrncItemFacColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCdeClrncItemFac"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCdeClrncItemFacFilterBuilder : SqlFilterBuilder<GsCdeClrncItemFacColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCdeClrncItemFacFilterBuilder class.
		/// </summary>
		public GsCdeClrncItemFacFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCdeClrncItemFacFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCdeClrncItemFacFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCdeClrncItemFacFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCdeClrncItemFacFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCdeClrncItemFacFilterBuilder
	
	#region GsCdeClrncItemFacParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GsCdeClrncItemFacColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCdeClrncItemFac"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCdeClrncItemFacParameterBuilder : ParameterizedSqlFilterBuilder<GsCdeClrncItemFacColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCdeClrncItemFacParameterBuilder class.
		/// </summary>
		public GsCdeClrncItemFacParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCdeClrncItemFacParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCdeClrncItemFacParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCdeClrncItemFacParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCdeClrncItemFacParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCdeClrncItemFacParameterBuilder
	
	#region GsCdeClrncItemFacSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GsCdeClrncItemFacColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCdeClrncItemFac"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GsCdeClrncItemFacSortBuilder : SqlSortBuilder<GsCdeClrncItemFacColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCdeClrncItemFacSqlSortBuilder class.
		/// </summary>
		public GsCdeClrncItemFacSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GsCdeClrncItemFacSortBuilder
	
} // end namespace
