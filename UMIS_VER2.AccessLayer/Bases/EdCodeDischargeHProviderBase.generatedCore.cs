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
	/// This class is the base class for any <see cref="EdCodeDischargeHProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EdCodeDischargeHProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.EdCodeDischargeH, UMIS_VER2.BusinessLyer.EdCodeDischargeHKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeDischargeHKey key)
		{
			return Delete(transactionManager, key.EdCodeDischargeHId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_edCodeDischargeHId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _edCodeDischargeHId)
		{
			return Delete(null, _edCodeDischargeHId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeDischargeHId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _edCodeDischargeHId);		
		
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
		public override UMIS_VER2.BusinessLyer.EdCodeDischargeH Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeDischargeHKey key, int start, int pageLength)
		{
			return GetByEdCodeDischargeHId(transactionManager, key.EdCodeDischargeHId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key COS_ITEM_DESCR_AR index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_itemDescrAr"></param>
		/// <param name="_gsSysNodeId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeDischargeH"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeDischargeH GetByAsFacultyInfoIdItemDescrArGsSysNodeId(System.Decimal _asFacultyInfoId, System.String _itemDescrAr, System.Decimal _gsSysNodeId)
		{
			int count = -1;
			return GetByAsFacultyInfoIdItemDescrArGsSysNodeId(null,_asFacultyInfoId, _itemDescrAr, _gsSysNodeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_ITEM_DESCR_AR index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_itemDescrAr"></param>
		/// <param name="_gsSysNodeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeDischargeH"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeDischargeH GetByAsFacultyInfoIdItemDescrArGsSysNodeId(System.Decimal _asFacultyInfoId, System.String _itemDescrAr, System.Decimal _gsSysNodeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoIdItemDescrArGsSysNodeId(null, _asFacultyInfoId, _itemDescrAr, _gsSysNodeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_ITEM_DESCR_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_itemDescrAr"></param>
		/// <param name="_gsSysNodeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeDischargeH"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeDischargeH GetByAsFacultyInfoIdItemDescrArGsSysNodeId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, System.String _itemDescrAr, System.Decimal _gsSysNodeId)
		{
			int count = -1;
			return GetByAsFacultyInfoIdItemDescrArGsSysNodeId(transactionManager, _asFacultyInfoId, _itemDescrAr, _gsSysNodeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_ITEM_DESCR_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_itemDescrAr"></param>
		/// <param name="_gsSysNodeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeDischargeH"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeDischargeH GetByAsFacultyInfoIdItemDescrArGsSysNodeId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, System.String _itemDescrAr, System.Decimal _gsSysNodeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAsFacultyInfoIdItemDescrArGsSysNodeId(transactionManager, _asFacultyInfoId, _itemDescrAr, _gsSysNodeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_ITEM_DESCR_AR index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_itemDescrAr"></param>
		/// <param name="_gsSysNodeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeDischargeH"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeDischargeH GetByAsFacultyInfoIdItemDescrArGsSysNodeId(System.Decimal _asFacultyInfoId, System.String _itemDescrAr, System.Decimal _gsSysNodeId, int start, int pageLength, out int count)
		{
			return GetByAsFacultyInfoIdItemDescrArGsSysNodeId(null, _asFacultyInfoId, _itemDescrAr, _gsSysNodeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_ITEM_DESCR_AR index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_asFacultyInfoId"></param>
		/// <param name="_itemDescrAr"></param>
		/// <param name="_gsSysNodeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeDischargeH"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdCodeDischargeH GetByAsFacultyInfoIdItemDescrArGsSysNodeId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, System.String _itemDescrAr, System.Decimal _gsSysNodeId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_AS_FACULTY_INFO_ID_1 index.
		/// </summary>
		/// <param name="_asFacultyInfoId"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;EdCodeDischargeH&gt;"/> class.</returns>
		public TList<EdCodeDischargeH> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdCodeDischargeH&gt;"/> class.</returns>
		public TList<EdCodeDischargeH> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdCodeDischargeH&gt;"/> class.</returns>
		public TList<EdCodeDischargeH> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdCodeDischargeH&gt;"/> class.</returns>
		public TList<EdCodeDischargeH> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdCodeDischargeH&gt;"/> class.</returns>
		public TList<EdCodeDischargeH> GetByAsFacultyInfoId(System.Decimal _asFacultyInfoId, int start, int pageLength, out int count)
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
		/// <returns>Returns an instance of the <see cref="TList&lt;EdCodeDischargeH&gt;"/> class.</returns>
		public abstract TList<EdCodeDischargeH> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ED_CODE_DISCHARGE_H index.
		/// </summary>
		/// <param name="_edCodeDischargeHId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeDischargeH"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeDischargeH GetByEdCodeDischargeHId(System.Decimal _edCodeDischargeHId)
		{
			int count = -1;
			return GetByEdCodeDischargeHId(null,_edCodeDischargeHId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_DISCHARGE_H index.
		/// </summary>
		/// <param name="_edCodeDischargeHId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeDischargeH"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeDischargeH GetByEdCodeDischargeHId(System.Decimal _edCodeDischargeHId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeDischargeHId(null, _edCodeDischargeHId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_DISCHARGE_H index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeDischargeHId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeDischargeH"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeDischargeH GetByEdCodeDischargeHId(TransactionManager transactionManager, System.Decimal _edCodeDischargeHId)
		{
			int count = -1;
			return GetByEdCodeDischargeHId(transactionManager, _edCodeDischargeHId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_DISCHARGE_H index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeDischargeHId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeDischargeH"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeDischargeH GetByEdCodeDischargeHId(TransactionManager transactionManager, System.Decimal _edCodeDischargeHId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCodeDischargeHId(transactionManager, _edCodeDischargeHId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_DISCHARGE_H index.
		/// </summary>
		/// <param name="_edCodeDischargeHId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeDischargeH"/> class.</returns>
		public UMIS_VER2.BusinessLyer.EdCodeDischargeH GetByEdCodeDischargeHId(System.Decimal _edCodeDischargeHId, int start, int pageLength, out int count)
		{
			return GetByEdCodeDischargeHId(null, _edCodeDischargeHId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ED_CODE_DISCHARGE_H index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCodeDischargeHId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.EdCodeDischargeH"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.EdCodeDischargeH GetByEdCodeDischargeHId(TransactionManager transactionManager, System.Decimal _edCodeDischargeHId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;EdCodeDischargeH&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;EdCodeDischargeH&gt;"/></returns>
		public static TList<EdCodeDischargeH> Fill(IDataReader reader, TList<EdCodeDischargeH> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.EdCodeDischargeH c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("EdCodeDischargeH")
					.Append("|").Append((System.Decimal)reader["ED_CODE_DISCHARGE_H_ID"]).ToString();
					c = EntityManager.LocateOrCreate<EdCodeDischargeH>(
					key.ToString(), // EntityTrackingKey
					"EdCodeDischargeH",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.EdCodeDischargeH();
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
					c.EdCodeDischargeHId = (System.Decimal)reader["ED_CODE_DISCHARGE_H_ID"];
					c.OriginalEdCodeDischargeHId = c.EdCodeDischargeHId;
					c.ItemDescrAr = (System.String)reader["ITEM_DESCR_AR"];
					c.ItemDescrEn = Convert.IsDBNull(reader["ITEM_DESCR_EN"]) ? null : (System.String)reader["ITEM_DESCR_EN"];
					c.ItemCode = Convert.IsDBNull(reader["ITEM_CODE"]) ? null : (System.String)reader["ITEM_CODE"];
					c.AsFacultyInfoId = (System.Decimal)reader["AS_FACULTY_INFO_ID"];
					c.GsSysNodeId = (System.Decimal)reader["GS_SYS_NODE_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCodeDischargeH"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeDischargeH"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.EdCodeDischargeH entity)
		{
			if (!reader.Read()) return;
			
			entity.EdCodeDischargeHId = (System.Decimal)reader[((int)EdCodeDischargeHColumn.EdCodeDischargeHId - 1)];
			entity.OriginalEdCodeDischargeHId = (System.Decimal)reader["ED_CODE_DISCHARGE_H_ID"];
			entity.ItemDescrAr = (System.String)reader[((int)EdCodeDischargeHColumn.ItemDescrAr - 1)];
			entity.ItemDescrEn = (reader.IsDBNull(((int)EdCodeDischargeHColumn.ItemDescrEn - 1)))?null:(System.String)reader[((int)EdCodeDischargeHColumn.ItemDescrEn - 1)];
			entity.ItemCode = (reader.IsDBNull(((int)EdCodeDischargeHColumn.ItemCode - 1)))?null:(System.String)reader[((int)EdCodeDischargeHColumn.ItemCode - 1)];
			entity.AsFacultyInfoId = (System.Decimal)reader[((int)EdCodeDischargeHColumn.AsFacultyInfoId - 1)];
			entity.GsSysNodeId = (System.Decimal)reader[((int)EdCodeDischargeHColumn.GsSysNodeId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.EdCodeDischargeH"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeDischargeH"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.EdCodeDischargeH entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdCodeDischargeHId = (System.Decimal)dataRow["ED_CODE_DISCHARGE_H_ID"];
			entity.OriginalEdCodeDischargeHId = (System.Decimal)dataRow["ED_CODE_DISCHARGE_H_ID"];
			entity.ItemDescrAr = (System.String)dataRow["ITEM_DESCR_AR"];
			entity.ItemDescrEn = Convert.IsDBNull(dataRow["ITEM_DESCR_EN"]) ? null : (System.String)dataRow["ITEM_DESCR_EN"];
			entity.ItemCode = Convert.IsDBNull(dataRow["ITEM_CODE"]) ? null : (System.String)dataRow["ITEM_CODE"];
			entity.AsFacultyInfoId = (System.Decimal)dataRow["AS_FACULTY_INFO_ID"];
			entity.GsSysNodeId = (System.Decimal)dataRow["GS_SYS_NODE_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.EdCodeDischargeH"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCodeDischargeH Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeDischargeH entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AsFacultyInfoIdSource	
			if (CanDeepLoad(entity, "AsFacultyInfo|AsFacultyInfoIdSource", deepLoadType, innerList) 
				&& entity.AsFacultyInfoIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AsFacultyInfoId;
				AsFacultyInfo tmpEntity = EntityManager.LocateEntity<AsFacultyInfo>(EntityLocator.ConstructKeyFromPkItems(typeof(AsFacultyInfo), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AsFacultyInfoIdSource = tmpEntity;
				else
					entity.AsFacultyInfoIdSource = DataRepository.AsFacultyInfoProvider.GetByAsFacultyInfoId(transactionManager, entity.AsFacultyInfoId);		
				
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.EdCodeDischargeH object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.EdCodeDischargeH instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.EdCodeDischargeH Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeDischargeH entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
	
	#region EdCodeDischargeHChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.EdCodeDischargeH</c>
	///</summary>
	public enum EdCodeDischargeHChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AsFacultyInfo</c> at AsFacultyInfoIdSource
		///</summary>
		[ChildEntityType(typeof(AsFacultyInfo))]
		AsFacultyInfo,
	}
	
	#endregion EdCodeDischargeHChildEntityTypes
	
	#region EdCodeDischargeHFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EdCodeDischargeHColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeDischargeH"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCodeDischargeHFilterBuilder : SqlFilterBuilder<EdCodeDischargeHColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeDischargeHFilterBuilder class.
		/// </summary>
		public EdCodeDischargeHFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCodeDischargeHFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCodeDischargeHFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCodeDischargeHFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCodeDischargeHFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCodeDischargeHFilterBuilder
	
	#region EdCodeDischargeHParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EdCodeDischargeHColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeDischargeH"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class EdCodeDischargeHParameterBuilder : ParameterizedSqlFilterBuilder<EdCodeDischargeHColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeDischargeHParameterBuilder class.
		/// </summary>
		public EdCodeDischargeHParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the EdCodeDischargeHParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public EdCodeDischargeHParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the EdCodeDischargeHParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public EdCodeDischargeHParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion EdCodeDischargeHParameterBuilder
	
	#region EdCodeDischargeHSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EdCodeDischargeHColumn&gt;"/> class
	/// that is used exclusively with a <see cref="EdCodeDischargeH"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class EdCodeDischargeHSortBuilder : SqlSortBuilder<EdCodeDischargeHColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EdCodeDischargeHSqlSortBuilder class.
		/// </summary>
		public EdCodeDischargeHSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion EdCodeDischargeHSortBuilder
	
} // end namespace
