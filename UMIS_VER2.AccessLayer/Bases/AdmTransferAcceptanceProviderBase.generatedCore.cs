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
	/// This class is the base class for any <see cref="AdmTransferAcceptanceProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AdmTransferAcceptanceProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AdmTransferAcceptance, UMIS_VER2.BusinessLyer.AdmTransferAcceptanceKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmTransferAcceptanceKey key)
		{
			return Delete(transactionManager, key.AdmTransferAcceptanceId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_admTransferAcceptanceId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _admTransferAcceptanceId)
		{
			return Delete(null, _admTransferAcceptanceId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admTransferAcceptanceId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _admTransferAcceptanceId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_TRANSFER_ACCEPTANCE_ADM_APP_TRANS_REQ key.
		///		FK_ADM_TRANSFER_ACCEPTANCE_ADM_APP_TRANS_REQ Description: 
		/// </summary>
		/// <param name="_admAppTransReqId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTransferAcceptance objects.</returns>
		public TList<AdmTransferAcceptance> GetByAdmAppTransReqId(System.Decimal _admAppTransReqId)
		{
			int count = -1;
			return GetByAdmAppTransReqId(_admAppTransReqId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_TRANSFER_ACCEPTANCE_ADM_APP_TRANS_REQ key.
		///		FK_ADM_TRANSFER_ACCEPTANCE_ADM_APP_TRANS_REQ Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppTransReqId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTransferAcceptance objects.</returns>
		/// <remarks></remarks>
		public TList<AdmTransferAcceptance> GetByAdmAppTransReqId(TransactionManager transactionManager, System.Decimal _admAppTransReqId)
		{
			int count = -1;
			return GetByAdmAppTransReqId(transactionManager, _admAppTransReqId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_TRANSFER_ACCEPTANCE_ADM_APP_TRANS_REQ key.
		///		FK_ADM_TRANSFER_ACCEPTANCE_ADM_APP_TRANS_REQ Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppTransReqId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTransferAcceptance objects.</returns>
		public TList<AdmTransferAcceptance> GetByAdmAppTransReqId(TransactionManager transactionManager, System.Decimal _admAppTransReqId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppTransReqId(transactionManager, _admAppTransReqId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_TRANSFER_ACCEPTANCE_ADM_APP_TRANS_REQ key.
		///		fkAdmTransferAcceptanceAdmAppTransReq Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admAppTransReqId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTransferAcceptance objects.</returns>
		public TList<AdmTransferAcceptance> GetByAdmAppTransReqId(System.Decimal _admAppTransReqId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmAppTransReqId(null, _admAppTransReqId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_TRANSFER_ACCEPTANCE_ADM_APP_TRANS_REQ key.
		///		fkAdmTransferAcceptanceAdmAppTransReq Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admAppTransReqId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTransferAcceptance objects.</returns>
		public TList<AdmTransferAcceptance> GetByAdmAppTransReqId(System.Decimal _admAppTransReqId, int start, int pageLength,out int count)
		{
			return GetByAdmAppTransReqId(null, _admAppTransReqId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_TRANSFER_ACCEPTANCE_ADM_APP_TRANS_REQ key.
		///		FK_ADM_TRANSFER_ACCEPTANCE_ADM_APP_TRANS_REQ Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppTransReqId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTransferAcceptance objects.</returns>
		public abstract TList<AdmTransferAcceptance> GetByAdmAppTransReqId(TransactionManager transactionManager, System.Decimal _admAppTransReqId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_TRANSFER_ACCEPTANCE_ADM_TRANS_ACCEPTANCE_CATEGORY key.
		///		FK_ADM_TRANSFER_ACCEPTANCE_ADM_TRANS_ACCEPTANCE_CATEGORY Description: 
		/// </summary>
		/// <param name="_admTransAcceptanceCategoryId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTransferAcceptance objects.</returns>
		public TList<AdmTransferAcceptance> GetByAdmTransAcceptanceCategoryId(System.Decimal _admTransAcceptanceCategoryId)
		{
			int count = -1;
			return GetByAdmTransAcceptanceCategoryId(_admTransAcceptanceCategoryId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_TRANSFER_ACCEPTANCE_ADM_TRANS_ACCEPTANCE_CATEGORY key.
		///		FK_ADM_TRANSFER_ACCEPTANCE_ADM_TRANS_ACCEPTANCE_CATEGORY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admTransAcceptanceCategoryId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTransferAcceptance objects.</returns>
		/// <remarks></remarks>
		public TList<AdmTransferAcceptance> GetByAdmTransAcceptanceCategoryId(TransactionManager transactionManager, System.Decimal _admTransAcceptanceCategoryId)
		{
			int count = -1;
			return GetByAdmTransAcceptanceCategoryId(transactionManager, _admTransAcceptanceCategoryId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_TRANSFER_ACCEPTANCE_ADM_TRANS_ACCEPTANCE_CATEGORY key.
		///		FK_ADM_TRANSFER_ACCEPTANCE_ADM_TRANS_ACCEPTANCE_CATEGORY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admTransAcceptanceCategoryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTransferAcceptance objects.</returns>
		public TList<AdmTransferAcceptance> GetByAdmTransAcceptanceCategoryId(TransactionManager transactionManager, System.Decimal _admTransAcceptanceCategoryId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmTransAcceptanceCategoryId(transactionManager, _admTransAcceptanceCategoryId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_TRANSFER_ACCEPTANCE_ADM_TRANS_ACCEPTANCE_CATEGORY key.
		///		fkAdmTransferAcceptanceAdmTransAcceptanceCategory Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admTransAcceptanceCategoryId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTransferAcceptance objects.</returns>
		public TList<AdmTransferAcceptance> GetByAdmTransAcceptanceCategoryId(System.Decimal _admTransAcceptanceCategoryId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmTransAcceptanceCategoryId(null, _admTransAcceptanceCategoryId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_TRANSFER_ACCEPTANCE_ADM_TRANS_ACCEPTANCE_CATEGORY key.
		///		fkAdmTransferAcceptanceAdmTransAcceptanceCategory Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admTransAcceptanceCategoryId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTransferAcceptance objects.</returns>
		public TList<AdmTransferAcceptance> GetByAdmTransAcceptanceCategoryId(System.Decimal _admTransAcceptanceCategoryId, int start, int pageLength,out int count)
		{
			return GetByAdmTransAcceptanceCategoryId(null, _admTransAcceptanceCategoryId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_TRANSFER_ACCEPTANCE_ADM_TRANS_ACCEPTANCE_CATEGORY key.
		///		FK_ADM_TRANSFER_ACCEPTANCE_ADM_TRANS_ACCEPTANCE_CATEGORY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admTransAcceptanceCategoryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmTransferAcceptance objects.</returns>
		public abstract TList<AdmTransferAcceptance> GetByAdmTransAcceptanceCategoryId(TransactionManager transactionManager, System.Decimal _admTransAcceptanceCategoryId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.AdmTransferAcceptance Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmTransferAcceptanceKey key, int start, int pageLength)
		{
			return GetByAdmTransferAcceptanceId(transactionManager, key.AdmTransferAcceptanceId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ADM_TRANSFER_ACCEPTANCE index.
		/// </summary>
		/// <param name="_admTransferAcceptanceId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmTransferAcceptance"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmTransferAcceptance GetByAdmTransferAcceptanceId(System.Decimal _admTransferAcceptanceId)
		{
			int count = -1;
			return GetByAdmTransferAcceptanceId(null,_admTransferAcceptanceId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_TRANSFER_ACCEPTANCE index.
		/// </summary>
		/// <param name="_admTransferAcceptanceId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmTransferAcceptance"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmTransferAcceptance GetByAdmTransferAcceptanceId(System.Decimal _admTransferAcceptanceId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmTransferAcceptanceId(null, _admTransferAcceptanceId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_TRANSFER_ACCEPTANCE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admTransferAcceptanceId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmTransferAcceptance"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmTransferAcceptance GetByAdmTransferAcceptanceId(TransactionManager transactionManager, System.Decimal _admTransferAcceptanceId)
		{
			int count = -1;
			return GetByAdmTransferAcceptanceId(transactionManager, _admTransferAcceptanceId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_TRANSFER_ACCEPTANCE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admTransferAcceptanceId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmTransferAcceptance"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmTransferAcceptance GetByAdmTransferAcceptanceId(TransactionManager transactionManager, System.Decimal _admTransferAcceptanceId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmTransferAcceptanceId(transactionManager, _admTransferAcceptanceId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_TRANSFER_ACCEPTANCE index.
		/// </summary>
		/// <param name="_admTransferAcceptanceId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmTransferAcceptance"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmTransferAcceptance GetByAdmTransferAcceptanceId(System.Decimal _admTransferAcceptanceId, int start, int pageLength, out int count)
		{
			return GetByAdmTransferAcceptanceId(null, _admTransferAcceptanceId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_TRANSFER_ACCEPTANCE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admTransferAcceptanceId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmTransferAcceptance"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmTransferAcceptance GetByAdmTransferAcceptanceId(TransactionManager transactionManager, System.Decimal _admTransferAcceptanceId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AdmTransferAcceptance&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AdmTransferAcceptance&gt;"/></returns>
		public static TList<AdmTransferAcceptance> Fill(IDataReader reader, TList<AdmTransferAcceptance> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AdmTransferAcceptance c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AdmTransferAcceptance")
					.Append("|").Append((System.Decimal)reader["ADM_TRANSFER_ACCEPTANCE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AdmTransferAcceptance>(
					key.ToString(), // EntityTrackingKey
					"AdmTransferAcceptance",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AdmTransferAcceptance();
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
					c.AdmTransferAcceptanceId = (System.Decimal)reader["ADM_TRANSFER_ACCEPTANCE_ID"];
					c.OriginalAdmTransferAcceptanceId = c.AdmTransferAcceptanceId;
					c.AcceptanceFlg = (System.Decimal)reader["ACCEPTANCE_FLG"];
					c.AdmAppTransReqId = (System.Decimal)reader["ADM_APP_TRANS_REQ_ID"];
					c.AdmTransAcceptanceCategoryId = (System.Decimal)reader["ADM_TRANS_ACCEPTANCE_CATEGORY_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmTransferAcceptance"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmTransferAcceptance"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AdmTransferAcceptance entity)
		{
			if (!reader.Read()) return;
			
			entity.AdmTransferAcceptanceId = (System.Decimal)reader[((int)AdmTransferAcceptanceColumn.AdmTransferAcceptanceId - 1)];
			entity.OriginalAdmTransferAcceptanceId = (System.Decimal)reader["ADM_TRANSFER_ACCEPTANCE_ID"];
			entity.AcceptanceFlg = (System.Decimal)reader[((int)AdmTransferAcceptanceColumn.AcceptanceFlg - 1)];
			entity.AdmAppTransReqId = (System.Decimal)reader[((int)AdmTransferAcceptanceColumn.AdmAppTransReqId - 1)];
			entity.AdmTransAcceptanceCategoryId = (System.Decimal)reader[((int)AdmTransferAcceptanceColumn.AdmTransAcceptanceCategoryId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmTransferAcceptance"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmTransferAcceptance"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AdmTransferAcceptance entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AdmTransferAcceptanceId = (System.Decimal)dataRow["ADM_TRANSFER_ACCEPTANCE_ID"];
			entity.OriginalAdmTransferAcceptanceId = (System.Decimal)dataRow["ADM_TRANSFER_ACCEPTANCE_ID"];
			entity.AcceptanceFlg = (System.Decimal)dataRow["ACCEPTANCE_FLG"];
			entity.AdmAppTransReqId = (System.Decimal)dataRow["ADM_APP_TRANS_REQ_ID"];
			entity.AdmTransAcceptanceCategoryId = (System.Decimal)dataRow["ADM_TRANS_ACCEPTANCE_CATEGORY_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmTransferAcceptance"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmTransferAcceptance Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmTransferAcceptance entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AdmAppTransReqIdSource	
			if (CanDeepLoad(entity, "AdmAppTransReq|AdmAppTransReqIdSource", deepLoadType, innerList) 
				&& entity.AdmAppTransReqIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AdmAppTransReqId;
				AdmAppTransReq tmpEntity = EntityManager.LocateEntity<AdmAppTransReq>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmAppTransReq), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmAppTransReqIdSource = tmpEntity;
				else
					entity.AdmAppTransReqIdSource = DataRepository.AdmAppTransReqProvider.GetByAdmAppTransReqId(transactionManager, entity.AdmAppTransReqId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppTransReqIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmAppTransReqIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmAppTransReqProvider.DeepLoad(transactionManager, entity.AdmAppTransReqIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmAppTransReqIdSource

			#region AdmTransAcceptanceCategoryIdSource	
			if (CanDeepLoad(entity, "AdmTransAcceptanceCategory|AdmTransAcceptanceCategoryIdSource", deepLoadType, innerList) 
				&& entity.AdmTransAcceptanceCategoryIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AdmTransAcceptanceCategoryId;
				AdmTransAcceptanceCategory tmpEntity = EntityManager.LocateEntity<AdmTransAcceptanceCategory>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmTransAcceptanceCategory), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmTransAcceptanceCategoryIdSource = tmpEntity;
				else
					entity.AdmTransAcceptanceCategoryIdSource = DataRepository.AdmTransAcceptanceCategoryProvider.GetByAdmTransAcceptanceCategoryId(transactionManager, entity.AdmTransAcceptanceCategoryId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmTransAcceptanceCategoryIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmTransAcceptanceCategoryIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmTransAcceptanceCategoryProvider.DeepLoad(transactionManager, entity.AdmTransAcceptanceCategoryIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmTransAcceptanceCategoryIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AdmTransferAcceptance object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AdmTransferAcceptance instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmTransferAcceptance Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmTransferAcceptance entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AdmAppTransReqIdSource
			if (CanDeepSave(entity, "AdmAppTransReq|AdmAppTransReqIdSource", deepSaveType, innerList) 
				&& entity.AdmAppTransReqIdSource != null)
			{
				DataRepository.AdmAppTransReqProvider.Save(transactionManager, entity.AdmAppTransReqIdSource);
				entity.AdmAppTransReqId = entity.AdmAppTransReqIdSource.AdmAppTransReqId;
			}
			#endregion 
			
			#region AdmTransAcceptanceCategoryIdSource
			if (CanDeepSave(entity, "AdmTransAcceptanceCategory|AdmTransAcceptanceCategoryIdSource", deepSaveType, innerList) 
				&& entity.AdmTransAcceptanceCategoryIdSource != null)
			{
				DataRepository.AdmTransAcceptanceCategoryProvider.Save(transactionManager, entity.AdmTransAcceptanceCategoryIdSource);
				entity.AdmTransAcceptanceCategoryId = entity.AdmTransAcceptanceCategoryIdSource.AdmTransAcceptanceCategoryId;
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
	
	#region AdmTransferAcceptanceChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AdmTransferAcceptance</c>
	///</summary>
	public enum AdmTransferAcceptanceChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AdmAppTransReq</c> at AdmAppTransReqIdSource
		///</summary>
		[ChildEntityType(typeof(AdmAppTransReq))]
		AdmAppTransReq,
		
		///<summary>
		/// Composite Property for <c>AdmTransAcceptanceCategory</c> at AdmTransAcceptanceCategoryIdSource
		///</summary>
		[ChildEntityType(typeof(AdmTransAcceptanceCategory))]
		AdmTransAcceptanceCategory,
	}
	
	#endregion AdmTransferAcceptanceChildEntityTypes
	
	#region AdmTransferAcceptanceFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AdmTransferAcceptanceColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmTransferAcceptance"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmTransferAcceptanceFilterBuilder : SqlFilterBuilder<AdmTransferAcceptanceColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmTransferAcceptanceFilterBuilder class.
		/// </summary>
		public AdmTransferAcceptanceFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmTransferAcceptanceFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmTransferAcceptanceFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmTransferAcceptanceFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmTransferAcceptanceFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmTransferAcceptanceFilterBuilder
	
	#region AdmTransferAcceptanceParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AdmTransferAcceptanceColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmTransferAcceptance"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmTransferAcceptanceParameterBuilder : ParameterizedSqlFilterBuilder<AdmTransferAcceptanceColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmTransferAcceptanceParameterBuilder class.
		/// </summary>
		public AdmTransferAcceptanceParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmTransferAcceptanceParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmTransferAcceptanceParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmTransferAcceptanceParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmTransferAcceptanceParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmTransferAcceptanceParameterBuilder
	
	#region AdmTransferAcceptanceSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AdmTransferAcceptanceColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmTransferAcceptance"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AdmTransferAcceptanceSortBuilder : SqlSortBuilder<AdmTransferAcceptanceColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmTransferAcceptanceSqlSortBuilder class.
		/// </summary>
		public AdmTransferAcceptanceSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AdmTransferAcceptanceSortBuilder
	
} // end namespace
