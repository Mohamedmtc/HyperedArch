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
	/// This class is the base class for any <see cref="AdmIntTransferAcceptanceProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AdmIntTransferAcceptanceProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AdmIntTransferAcceptance, UMIS_VER2.BusinessLyer.AdmIntTransferAcceptanceKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmIntTransferAcceptanceKey key)
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
		/// 	Gets rows from the datasource based on the FK_ADM_INT_TRANSFER_ACCEPTANCE_ADM_TRANS_ACCEPTANCE_CATEGORY key.
		///		FK_ADM_INT_TRANSFER_ACCEPTANCE_ADM_TRANS_ACCEPTANCE_CATEGORY Description: 
		/// </summary>
		/// <param name="_admTransAcceptanceCategoryId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmIntTransferAcceptance objects.</returns>
		public TList<AdmIntTransferAcceptance> GetByAdmTransAcceptanceCategoryId(System.Decimal _admTransAcceptanceCategoryId)
		{
			int count = -1;
			return GetByAdmTransAcceptanceCategoryId(_admTransAcceptanceCategoryId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_INT_TRANSFER_ACCEPTANCE_ADM_TRANS_ACCEPTANCE_CATEGORY key.
		///		FK_ADM_INT_TRANSFER_ACCEPTANCE_ADM_TRANS_ACCEPTANCE_CATEGORY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admTransAcceptanceCategoryId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmIntTransferAcceptance objects.</returns>
		/// <remarks></remarks>
		public TList<AdmIntTransferAcceptance> GetByAdmTransAcceptanceCategoryId(TransactionManager transactionManager, System.Decimal _admTransAcceptanceCategoryId)
		{
			int count = -1;
			return GetByAdmTransAcceptanceCategoryId(transactionManager, _admTransAcceptanceCategoryId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_INT_TRANSFER_ACCEPTANCE_ADM_TRANS_ACCEPTANCE_CATEGORY key.
		///		FK_ADM_INT_TRANSFER_ACCEPTANCE_ADM_TRANS_ACCEPTANCE_CATEGORY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admTransAcceptanceCategoryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmIntTransferAcceptance objects.</returns>
		public TList<AdmIntTransferAcceptance> GetByAdmTransAcceptanceCategoryId(TransactionManager transactionManager, System.Decimal _admTransAcceptanceCategoryId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmTransAcceptanceCategoryId(transactionManager, _admTransAcceptanceCategoryId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_INT_TRANSFER_ACCEPTANCE_ADM_TRANS_ACCEPTANCE_CATEGORY key.
		///		fkAdmIntTransferAcceptanceAdmTransAcceptanceCategory Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admTransAcceptanceCategoryId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmIntTransferAcceptance objects.</returns>
		public TList<AdmIntTransferAcceptance> GetByAdmTransAcceptanceCategoryId(System.Decimal _admTransAcceptanceCategoryId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmTransAcceptanceCategoryId(null, _admTransAcceptanceCategoryId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_INT_TRANSFER_ACCEPTANCE_ADM_TRANS_ACCEPTANCE_CATEGORY key.
		///		fkAdmIntTransferAcceptanceAdmTransAcceptanceCategory Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admTransAcceptanceCategoryId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmIntTransferAcceptance objects.</returns>
		public TList<AdmIntTransferAcceptance> GetByAdmTransAcceptanceCategoryId(System.Decimal _admTransAcceptanceCategoryId, int start, int pageLength,out int count)
		{
			return GetByAdmTransAcceptanceCategoryId(null, _admTransAcceptanceCategoryId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_INT_TRANSFER_ACCEPTANCE_ADM_TRANS_ACCEPTANCE_CATEGORY key.
		///		FK_ADM_INT_TRANSFER_ACCEPTANCE_ADM_TRANS_ACCEPTANCE_CATEGORY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admTransAcceptanceCategoryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmIntTransferAcceptance objects.</returns>
		public abstract TList<AdmIntTransferAcceptance> GetByAdmTransAcceptanceCategoryId(TransactionManager transactionManager, System.Decimal _admTransAcceptanceCategoryId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_INT_TRANSFER_ACCEPTANCE_ED_STUD_INT_TRNS key.
		///		FK_ADM_INT_TRANSFER_ACCEPTANCE_ED_STUD_INT_TRNS Description: 
		/// </summary>
		/// <param name="_edStudIntTrnsId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmIntTransferAcceptance objects.</returns>
		public TList<AdmIntTransferAcceptance> GetByEdStudIntTrnsId(System.Decimal _edStudIntTrnsId)
		{
			int count = -1;
			return GetByEdStudIntTrnsId(_edStudIntTrnsId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_INT_TRANSFER_ACCEPTANCE_ED_STUD_INT_TRNS key.
		///		FK_ADM_INT_TRANSFER_ACCEPTANCE_ED_STUD_INT_TRNS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudIntTrnsId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmIntTransferAcceptance objects.</returns>
		/// <remarks></remarks>
		public TList<AdmIntTransferAcceptance> GetByEdStudIntTrnsId(TransactionManager transactionManager, System.Decimal _edStudIntTrnsId)
		{
			int count = -1;
			return GetByEdStudIntTrnsId(transactionManager, _edStudIntTrnsId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_INT_TRANSFER_ACCEPTANCE_ED_STUD_INT_TRNS key.
		///		FK_ADM_INT_TRANSFER_ACCEPTANCE_ED_STUD_INT_TRNS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudIntTrnsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmIntTransferAcceptance objects.</returns>
		public TList<AdmIntTransferAcceptance> GetByEdStudIntTrnsId(TransactionManager transactionManager, System.Decimal _edStudIntTrnsId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudIntTrnsId(transactionManager, _edStudIntTrnsId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_INT_TRANSFER_ACCEPTANCE_ED_STUD_INT_TRNS key.
		///		fkAdmIntTransferAcceptanceEdStudIntTrns Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudIntTrnsId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmIntTransferAcceptance objects.</returns>
		public TList<AdmIntTransferAcceptance> GetByEdStudIntTrnsId(System.Decimal _edStudIntTrnsId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdStudIntTrnsId(null, _edStudIntTrnsId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_INT_TRANSFER_ACCEPTANCE_ED_STUD_INT_TRNS key.
		///		fkAdmIntTransferAcceptanceEdStudIntTrns Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edStudIntTrnsId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmIntTransferAcceptance objects.</returns>
		public TList<AdmIntTransferAcceptance> GetByEdStudIntTrnsId(System.Decimal _edStudIntTrnsId, int start, int pageLength,out int count)
		{
			return GetByEdStudIntTrnsId(null, _edStudIntTrnsId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_INT_TRANSFER_ACCEPTANCE_ED_STUD_INT_TRNS key.
		///		FK_ADM_INT_TRANSFER_ACCEPTANCE_ED_STUD_INT_TRNS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudIntTrnsId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmIntTransferAcceptance objects.</returns>
		public abstract TList<AdmIntTransferAcceptance> GetByEdStudIntTrnsId(TransactionManager transactionManager, System.Decimal _edStudIntTrnsId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.AdmIntTransferAcceptance Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmIntTransferAcceptanceKey key, int start, int pageLength)
		{
			return GetByAdmTransferAcceptanceId(transactionManager, key.AdmTransferAcceptanceId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ADM_INT_TRANSFER_ACCEPTANCE index.
		/// </summary>
		/// <param name="_admTransferAcceptanceId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmIntTransferAcceptance"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmIntTransferAcceptance GetByAdmTransferAcceptanceId(System.Decimal _admTransferAcceptanceId)
		{
			int count = -1;
			return GetByAdmTransferAcceptanceId(null,_admTransferAcceptanceId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_INT_TRANSFER_ACCEPTANCE index.
		/// </summary>
		/// <param name="_admTransferAcceptanceId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmIntTransferAcceptance"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmIntTransferAcceptance GetByAdmTransferAcceptanceId(System.Decimal _admTransferAcceptanceId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmTransferAcceptanceId(null, _admTransferAcceptanceId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_INT_TRANSFER_ACCEPTANCE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admTransferAcceptanceId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmIntTransferAcceptance"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmIntTransferAcceptance GetByAdmTransferAcceptanceId(TransactionManager transactionManager, System.Decimal _admTransferAcceptanceId)
		{
			int count = -1;
			return GetByAdmTransferAcceptanceId(transactionManager, _admTransferAcceptanceId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_INT_TRANSFER_ACCEPTANCE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admTransferAcceptanceId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmIntTransferAcceptance"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmIntTransferAcceptance GetByAdmTransferAcceptanceId(TransactionManager transactionManager, System.Decimal _admTransferAcceptanceId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmTransferAcceptanceId(transactionManager, _admTransferAcceptanceId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_INT_TRANSFER_ACCEPTANCE index.
		/// </summary>
		/// <param name="_admTransferAcceptanceId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmIntTransferAcceptance"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmIntTransferAcceptance GetByAdmTransferAcceptanceId(System.Decimal _admTransferAcceptanceId, int start, int pageLength, out int count)
		{
			return GetByAdmTransferAcceptanceId(null, _admTransferAcceptanceId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_INT_TRANSFER_ACCEPTANCE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admTransferAcceptanceId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmIntTransferAcceptance"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmIntTransferAcceptance GetByAdmTransferAcceptanceId(TransactionManager transactionManager, System.Decimal _admTransferAcceptanceId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AdmIntTransferAcceptance&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AdmIntTransferAcceptance&gt;"/></returns>
		public static TList<AdmIntTransferAcceptance> Fill(IDataReader reader, TList<AdmIntTransferAcceptance> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AdmIntTransferAcceptance c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AdmIntTransferAcceptance")
					.Append("|").Append((System.Decimal)reader["ADM_TRANSFER_ACCEPTANCE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AdmIntTransferAcceptance>(
					key.ToString(), // EntityTrackingKey
					"AdmIntTransferAcceptance",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AdmIntTransferAcceptance();
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
					c.EdStudIntTrnsId = (System.Decimal)reader["ED_STUD_INT_TRNS_ID"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmIntTransferAcceptance"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmIntTransferAcceptance"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AdmIntTransferAcceptance entity)
		{
			if (!reader.Read()) return;
			
			entity.AdmTransferAcceptanceId = (System.Decimal)reader[((int)AdmIntTransferAcceptanceColumn.AdmTransferAcceptanceId - 1)];
			entity.OriginalAdmTransferAcceptanceId = (System.Decimal)reader["ADM_TRANSFER_ACCEPTANCE_ID"];
			entity.AcceptanceFlg = (System.Decimal)reader[((int)AdmIntTransferAcceptanceColumn.AcceptanceFlg - 1)];
			entity.EdStudIntTrnsId = (System.Decimal)reader[((int)AdmIntTransferAcceptanceColumn.EdStudIntTrnsId - 1)];
			entity.AdmTransAcceptanceCategoryId = (System.Decimal)reader[((int)AdmIntTransferAcceptanceColumn.AdmTransAcceptanceCategoryId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmIntTransferAcceptance"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmIntTransferAcceptance"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AdmIntTransferAcceptance entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AdmTransferAcceptanceId = (System.Decimal)dataRow["ADM_TRANSFER_ACCEPTANCE_ID"];
			entity.OriginalAdmTransferAcceptanceId = (System.Decimal)dataRow["ADM_TRANSFER_ACCEPTANCE_ID"];
			entity.AcceptanceFlg = (System.Decimal)dataRow["ACCEPTANCE_FLG"];
			entity.EdStudIntTrnsId = (System.Decimal)dataRow["ED_STUD_INT_TRNS_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmIntTransferAcceptance"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmIntTransferAcceptance Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmIntTransferAcceptance entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

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

			#region EdStudIntTrnsIdSource	
			if (CanDeepLoad(entity, "EdStudIntTrns|EdStudIntTrnsIdSource", deepLoadType, innerList) 
				&& entity.EdStudIntTrnsIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdStudIntTrnsId;
				EdStudIntTrns tmpEntity = EntityManager.LocateEntity<EdStudIntTrns>(EntityLocator.ConstructKeyFromPkItems(typeof(EdStudIntTrns), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdStudIntTrnsIdSource = tmpEntity;
				else
					entity.EdStudIntTrnsIdSource = DataRepository.EdStudIntTrnsProvider.GetByEdStudIntTrnsId(transactionManager, entity.EdStudIntTrnsId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudIntTrnsIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdStudIntTrnsIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdStudIntTrnsProvider.DeepLoad(transactionManager, entity.EdStudIntTrnsIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdStudIntTrnsIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AdmIntTransferAcceptance object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AdmIntTransferAcceptance instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmIntTransferAcceptance Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmIntTransferAcceptance entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AdmTransAcceptanceCategoryIdSource
			if (CanDeepSave(entity, "AdmTransAcceptanceCategory|AdmTransAcceptanceCategoryIdSource", deepSaveType, innerList) 
				&& entity.AdmTransAcceptanceCategoryIdSource != null)
			{
				DataRepository.AdmTransAcceptanceCategoryProvider.Save(transactionManager, entity.AdmTransAcceptanceCategoryIdSource);
				entity.AdmTransAcceptanceCategoryId = entity.AdmTransAcceptanceCategoryIdSource.AdmTransAcceptanceCategoryId;
			}
			#endregion 
			
			#region EdStudIntTrnsIdSource
			if (CanDeepSave(entity, "EdStudIntTrns|EdStudIntTrnsIdSource", deepSaveType, innerList) 
				&& entity.EdStudIntTrnsIdSource != null)
			{
				DataRepository.EdStudIntTrnsProvider.Save(transactionManager, entity.EdStudIntTrnsIdSource);
				entity.EdStudIntTrnsId = entity.EdStudIntTrnsIdSource.EdStudIntTrnsId;
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
	
	#region AdmIntTransferAcceptanceChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AdmIntTransferAcceptance</c>
	///</summary>
	public enum AdmIntTransferAcceptanceChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AdmTransAcceptanceCategory</c> at AdmTransAcceptanceCategoryIdSource
		///</summary>
		[ChildEntityType(typeof(AdmTransAcceptanceCategory))]
		AdmTransAcceptanceCategory,
		
		///<summary>
		/// Composite Property for <c>EdStudIntTrns</c> at EdStudIntTrnsIdSource
		///</summary>
		[ChildEntityType(typeof(EdStudIntTrns))]
		EdStudIntTrns,
	}
	
	#endregion AdmIntTransferAcceptanceChildEntityTypes
	
	#region AdmIntTransferAcceptanceFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AdmIntTransferAcceptanceColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmIntTransferAcceptance"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmIntTransferAcceptanceFilterBuilder : SqlFilterBuilder<AdmIntTransferAcceptanceColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmIntTransferAcceptanceFilterBuilder class.
		/// </summary>
		public AdmIntTransferAcceptanceFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmIntTransferAcceptanceFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmIntTransferAcceptanceFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmIntTransferAcceptanceFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmIntTransferAcceptanceFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmIntTransferAcceptanceFilterBuilder
	
	#region AdmIntTransferAcceptanceParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AdmIntTransferAcceptanceColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmIntTransferAcceptance"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmIntTransferAcceptanceParameterBuilder : ParameterizedSqlFilterBuilder<AdmIntTransferAcceptanceColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmIntTransferAcceptanceParameterBuilder class.
		/// </summary>
		public AdmIntTransferAcceptanceParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmIntTransferAcceptanceParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmIntTransferAcceptanceParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmIntTransferAcceptanceParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmIntTransferAcceptanceParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmIntTransferAcceptanceParameterBuilder
	
	#region AdmIntTransferAcceptanceSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AdmIntTransferAcceptanceColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmIntTransferAcceptance"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AdmIntTransferAcceptanceSortBuilder : SqlSortBuilder<AdmIntTransferAcceptanceColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmIntTransferAcceptanceSqlSortBuilder class.
		/// </summary>
		public AdmIntTransferAcceptanceSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AdmIntTransferAcceptanceSortBuilder
	
} // end namespace
