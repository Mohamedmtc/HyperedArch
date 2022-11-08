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
	/// This class is the base class for any <see cref="SpoSponsorFeeItemProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SpoSponsorFeeItemProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SpoSponsorFeeItem, UMIS_VER2.BusinessLyer.SpoSponsorFeeItemKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SpoSponsorFeeItemKey key)
		{
			return Delete(transactionManager, key.SpoSponsorFeeItemId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_spoSponsorFeeItemId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _spoSponsorFeeItemId)
		{
			return Delete(null, _spoSponsorFeeItemId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorFeeItemId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _spoSponsorFeeItemId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_FEE_ITEM_FEE_CODE_ITEM key.
		///		FK_SPO_SPONSOR_FEE_ITEM_FEE_CODE_ITEM Description: 
		/// </summary>
		/// <param name="_feeCodeItemId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorFeeItem objects.</returns>
		public TList<SpoSponsorFeeItem> GetByFeeCodeItemId(System.Decimal _feeCodeItemId)
		{
			int count = -1;
			return GetByFeeCodeItemId(_feeCodeItemId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_FEE_ITEM_FEE_CODE_ITEM key.
		///		FK_SPO_SPONSOR_FEE_ITEM_FEE_CODE_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeItemId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorFeeItem objects.</returns>
		/// <remarks></remarks>
		public TList<SpoSponsorFeeItem> GetByFeeCodeItemId(TransactionManager transactionManager, System.Decimal _feeCodeItemId)
		{
			int count = -1;
			return GetByFeeCodeItemId(transactionManager, _feeCodeItemId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_FEE_ITEM_FEE_CODE_ITEM key.
		///		FK_SPO_SPONSOR_FEE_ITEM_FEE_CODE_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorFeeItem objects.</returns>
		public TList<SpoSponsorFeeItem> GetByFeeCodeItemId(TransactionManager transactionManager, System.Decimal _feeCodeItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCodeItemId(transactionManager, _feeCodeItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_FEE_ITEM_FEE_CODE_ITEM key.
		///		fkSpoSponsorFeeItemFeeCodeItem Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeCodeItemId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorFeeItem objects.</returns>
		public TList<SpoSponsorFeeItem> GetByFeeCodeItemId(System.Decimal _feeCodeItemId, int start, int pageLength)
		{
			int count =  -1;
			return GetByFeeCodeItemId(null, _feeCodeItemId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_FEE_ITEM_FEE_CODE_ITEM key.
		///		fkSpoSponsorFeeItemFeeCodeItem Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeCodeItemId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorFeeItem objects.</returns>
		public TList<SpoSponsorFeeItem> GetByFeeCodeItemId(System.Decimal _feeCodeItemId, int start, int pageLength,out int count)
		{
			return GetByFeeCodeItemId(null, _feeCodeItemId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_FEE_ITEM_FEE_CODE_ITEM key.
		///		FK_SPO_SPONSOR_FEE_ITEM_FEE_CODE_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorFeeItem objects.</returns>
		public abstract TList<SpoSponsorFeeItem> GetByFeeCodeItemId(TransactionManager transactionManager, System.Decimal _feeCodeItemId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_FEE_ITEM_SPO_SPONSOR_OFFER key.
		///		FK_SPO_SPONSOR_FEE_ITEM_SPO_SPONSOR_OFFER Description: 
		/// </summary>
		/// <param name="_spoSponsorOfferId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorFeeItem objects.</returns>
		public TList<SpoSponsorFeeItem> GetBySpoSponsorOfferId(System.Decimal _spoSponsorOfferId)
		{
			int count = -1;
			return GetBySpoSponsorOfferId(_spoSponsorOfferId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_FEE_ITEM_SPO_SPONSOR_OFFER key.
		///		FK_SPO_SPONSOR_FEE_ITEM_SPO_SPONSOR_OFFER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorOfferId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorFeeItem objects.</returns>
		/// <remarks></remarks>
		public TList<SpoSponsorFeeItem> GetBySpoSponsorOfferId(TransactionManager transactionManager, System.Decimal _spoSponsorOfferId)
		{
			int count = -1;
			return GetBySpoSponsorOfferId(transactionManager, _spoSponsorOfferId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_FEE_ITEM_SPO_SPONSOR_OFFER key.
		///		FK_SPO_SPONSOR_FEE_ITEM_SPO_SPONSOR_OFFER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorOfferId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorFeeItem objects.</returns>
		public TList<SpoSponsorFeeItem> GetBySpoSponsorOfferId(TransactionManager transactionManager, System.Decimal _spoSponsorOfferId, int start, int pageLength)
		{
			int count = -1;
			return GetBySpoSponsorOfferId(transactionManager, _spoSponsorOfferId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_FEE_ITEM_SPO_SPONSOR_OFFER key.
		///		fkSpoSponsorFeeItemSpoSponsorOffer Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_spoSponsorOfferId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorFeeItem objects.</returns>
		public TList<SpoSponsorFeeItem> GetBySpoSponsorOfferId(System.Decimal _spoSponsorOfferId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySpoSponsorOfferId(null, _spoSponsorOfferId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_FEE_ITEM_SPO_SPONSOR_OFFER key.
		///		fkSpoSponsorFeeItemSpoSponsorOffer Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_spoSponsorOfferId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorFeeItem objects.</returns>
		public TList<SpoSponsorFeeItem> GetBySpoSponsorOfferId(System.Decimal _spoSponsorOfferId, int start, int pageLength,out int count)
		{
			return GetBySpoSponsorOfferId(null, _spoSponsorOfferId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_SPO_SPONSOR_FEE_ITEM_SPO_SPONSOR_OFFER key.
		///		FK_SPO_SPONSOR_FEE_ITEM_SPO_SPONSOR_OFFER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorOfferId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.SpoSponsorFeeItem objects.</returns>
		public abstract TList<SpoSponsorFeeItem> GetBySpoSponsorOfferId(TransactionManager transactionManager, System.Decimal _spoSponsorOfferId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.SpoSponsorFeeItem Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SpoSponsorFeeItemKey key, int start, int pageLength)
		{
			return GetBySpoSponsorFeeItemId(transactionManager, key.SpoSponsorFeeItemId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SPO_SPONSOR_FEE_ITEM index.
		/// </summary>
		/// <param name="_spoSponsorFeeItemId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoSponsorFeeItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoSponsorFeeItem GetBySpoSponsorFeeItemId(System.Decimal _spoSponsorFeeItemId)
		{
			int count = -1;
			return GetBySpoSponsorFeeItemId(null,_spoSponsorFeeItemId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SPO_SPONSOR_FEE_ITEM index.
		/// </summary>
		/// <param name="_spoSponsorFeeItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoSponsorFeeItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoSponsorFeeItem GetBySpoSponsorFeeItemId(System.Decimal _spoSponsorFeeItemId, int start, int pageLength)
		{
			int count = -1;
			return GetBySpoSponsorFeeItemId(null, _spoSponsorFeeItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SPO_SPONSOR_FEE_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorFeeItemId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoSponsorFeeItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoSponsorFeeItem GetBySpoSponsorFeeItemId(TransactionManager transactionManager, System.Decimal _spoSponsorFeeItemId)
		{
			int count = -1;
			return GetBySpoSponsorFeeItemId(transactionManager, _spoSponsorFeeItemId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SPO_SPONSOR_FEE_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorFeeItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoSponsorFeeItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoSponsorFeeItem GetBySpoSponsorFeeItemId(TransactionManager transactionManager, System.Decimal _spoSponsorFeeItemId, int start, int pageLength)
		{
			int count = -1;
			return GetBySpoSponsorFeeItemId(transactionManager, _spoSponsorFeeItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SPO_SPONSOR_FEE_ITEM index.
		/// </summary>
		/// <param name="_spoSponsorFeeItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoSponsorFeeItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoSponsorFeeItem GetBySpoSponsorFeeItemId(System.Decimal _spoSponsorFeeItemId, int start, int pageLength, out int count)
		{
			return GetBySpoSponsorFeeItemId(null, _spoSponsorFeeItemId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SPO_SPONSOR_FEE_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorFeeItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoSponsorFeeItem"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SpoSponsorFeeItem GetBySpoSponsorFeeItemId(TransactionManager transactionManager, System.Decimal _spoSponsorFeeItemId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_SPO_SPONSOR_FEE_ITEM index.
		/// </summary>
		/// <param name="_spoSponsorOfferId"></param>
		/// <param name="_feeCodeItemId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoSponsorFeeItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoSponsorFeeItem GetBySpoSponsorOfferIdFeeCodeItemId(System.Decimal _spoSponsorOfferId, System.Decimal _feeCodeItemId)
		{
			int count = -1;
			return GetBySpoSponsorOfferIdFeeCodeItemId(null,_spoSponsorOfferId, _feeCodeItemId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SPO_SPONSOR_FEE_ITEM index.
		/// </summary>
		/// <param name="_spoSponsorOfferId"></param>
		/// <param name="_feeCodeItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoSponsorFeeItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoSponsorFeeItem GetBySpoSponsorOfferIdFeeCodeItemId(System.Decimal _spoSponsorOfferId, System.Decimal _feeCodeItemId, int start, int pageLength)
		{
			int count = -1;
			return GetBySpoSponsorOfferIdFeeCodeItemId(null, _spoSponsorOfferId, _feeCodeItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SPO_SPONSOR_FEE_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorOfferId"></param>
		/// <param name="_feeCodeItemId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoSponsorFeeItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoSponsorFeeItem GetBySpoSponsorOfferIdFeeCodeItemId(TransactionManager transactionManager, System.Decimal _spoSponsorOfferId, System.Decimal _feeCodeItemId)
		{
			int count = -1;
			return GetBySpoSponsorOfferIdFeeCodeItemId(transactionManager, _spoSponsorOfferId, _feeCodeItemId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SPO_SPONSOR_FEE_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorOfferId"></param>
		/// <param name="_feeCodeItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoSponsorFeeItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoSponsorFeeItem GetBySpoSponsorOfferIdFeeCodeItemId(TransactionManager transactionManager, System.Decimal _spoSponsorOfferId, System.Decimal _feeCodeItemId, int start, int pageLength)
		{
			int count = -1;
			return GetBySpoSponsorOfferIdFeeCodeItemId(transactionManager, _spoSponsorOfferId, _feeCodeItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SPO_SPONSOR_FEE_ITEM index.
		/// </summary>
		/// <param name="_spoSponsorOfferId"></param>
		/// <param name="_feeCodeItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoSponsorFeeItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SpoSponsorFeeItem GetBySpoSponsorOfferIdFeeCodeItemId(System.Decimal _spoSponsorOfferId, System.Decimal _feeCodeItemId, int start, int pageLength, out int count)
		{
			return GetBySpoSponsorOfferIdFeeCodeItemId(null, _spoSponsorOfferId, _feeCodeItemId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_SPO_SPONSOR_FEE_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_spoSponsorOfferId"></param>
		/// <param name="_feeCodeItemId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SpoSponsorFeeItem"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SpoSponsorFeeItem GetBySpoSponsorOfferIdFeeCodeItemId(TransactionManager transactionManager, System.Decimal _spoSponsorOfferId, System.Decimal _feeCodeItemId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SpoSponsorFeeItem&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SpoSponsorFeeItem&gt;"/></returns>
		public static TList<SpoSponsorFeeItem> Fill(IDataReader reader, TList<SpoSponsorFeeItem> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SpoSponsorFeeItem c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SpoSponsorFeeItem")
					.Append("|").Append((System.Decimal)reader["SPO_SPONSOR_FEE_ITEM_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SpoSponsorFeeItem>(
					key.ToString(), // EntityTrackingKey
					"SpoSponsorFeeItem",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SpoSponsorFeeItem();
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
					c.SpoSponsorFeeItemId = (System.Decimal)reader["SPO_SPONSOR_FEE_ITEM_ID"];
					c.OriginalSpoSponsorFeeItemId = c.SpoSponsorFeeItemId;
					c.SpoSponsorOfferId = (System.Decimal)reader["SPO_SPONSOR_OFFER_ID"];
					c.FeeCodeItemId = (System.Decimal)reader["FEE_CODE_ITEM_ID"];
					c.SpoPercent = Convert.IsDBNull(reader["SPO_PERCENT"]) ? null : (System.Decimal?)reader["SPO_PERCENT"];
					c.SpoAmount = Convert.IsDBNull(reader["SPO_AMOUNT"]) ? null : (System.Decimal?)reader["SPO_AMOUNT"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
					c.SeUserId = Convert.IsDBNull(reader["SE_USER_ID"]) ? null : (System.Decimal?)reader["SE_USER_ID"];
					c.LastDate = Convert.IsDBNull(reader["LAST_DATE"]) ? null : (System.DateTime?)reader["LAST_DATE"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SpoSponsorFeeItem"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SpoSponsorFeeItem"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SpoSponsorFeeItem entity)
		{
			if (!reader.Read()) return;
			
			entity.SpoSponsorFeeItemId = (System.Decimal)reader[((int)SpoSponsorFeeItemColumn.SpoSponsorFeeItemId - 1)];
			entity.OriginalSpoSponsorFeeItemId = (System.Decimal)reader["SPO_SPONSOR_FEE_ITEM_ID"];
			entity.SpoSponsorOfferId = (System.Decimal)reader[((int)SpoSponsorFeeItemColumn.SpoSponsorOfferId - 1)];
			entity.FeeCodeItemId = (System.Decimal)reader[((int)SpoSponsorFeeItemColumn.FeeCodeItemId - 1)];
			entity.SpoPercent = (reader.IsDBNull(((int)SpoSponsorFeeItemColumn.SpoPercent - 1)))?null:(System.Decimal?)reader[((int)SpoSponsorFeeItemColumn.SpoPercent - 1)];
			entity.SpoAmount = (reader.IsDBNull(((int)SpoSponsorFeeItemColumn.SpoAmount - 1)))?null:(System.Decimal?)reader[((int)SpoSponsorFeeItemColumn.SpoAmount - 1)];
			entity.Notes = (reader.IsDBNull(((int)SpoSponsorFeeItemColumn.Notes - 1)))?null:(System.String)reader[((int)SpoSponsorFeeItemColumn.Notes - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)SpoSponsorFeeItemColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)SpoSponsorFeeItemColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)SpoSponsorFeeItemColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)SpoSponsorFeeItemColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SpoSponsorFeeItem"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SpoSponsorFeeItem"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SpoSponsorFeeItem entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SpoSponsorFeeItemId = (System.Decimal)dataRow["SPO_SPONSOR_FEE_ITEM_ID"];
			entity.OriginalSpoSponsorFeeItemId = (System.Decimal)dataRow["SPO_SPONSOR_FEE_ITEM_ID"];
			entity.SpoSponsorOfferId = (System.Decimal)dataRow["SPO_SPONSOR_OFFER_ID"];
			entity.FeeCodeItemId = (System.Decimal)dataRow["FEE_CODE_ITEM_ID"];
			entity.SpoPercent = Convert.IsDBNull(dataRow["SPO_PERCENT"]) ? null : (System.Decimal?)dataRow["SPO_PERCENT"];
			entity.SpoAmount = Convert.IsDBNull(dataRow["SPO_AMOUNT"]) ? null : (System.Decimal?)dataRow["SPO_AMOUNT"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
			entity.SeUserId = Convert.IsDBNull(dataRow["SE_USER_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_ID"];
			entity.LastDate = Convert.IsDBNull(dataRow["LAST_DATE"]) ? null : (System.DateTime?)dataRow["LAST_DATE"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SpoSponsorFeeItem"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SpoSponsorFeeItem Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SpoSponsorFeeItem entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region FeeCodeItemIdSource	
			if (CanDeepLoad(entity, "FeeCodeItem|FeeCodeItemIdSource", deepLoadType, innerList) 
				&& entity.FeeCodeItemIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.FeeCodeItemId;
				FeeCodeItem tmpEntity = EntityManager.LocateEntity<FeeCodeItem>(EntityLocator.ConstructKeyFromPkItems(typeof(FeeCodeItem), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.FeeCodeItemIdSource = tmpEntity;
				else
					entity.FeeCodeItemIdSource = DataRepository.FeeCodeItemProvider.GetByFeeCodeItemId(transactionManager, entity.FeeCodeItemId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeCodeItemIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.FeeCodeItemIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.FeeCodeItemProvider.DeepLoad(transactionManager, entity.FeeCodeItemIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion FeeCodeItemIdSource

			#region SpoSponsorOfferIdSource	
			if (CanDeepLoad(entity, "SpoSponsorOffer|SpoSponsorOfferIdSource", deepLoadType, innerList) 
				&& entity.SpoSponsorOfferIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.SpoSponsorOfferId;
				SpoSponsorOffer tmpEntity = EntityManager.LocateEntity<SpoSponsorOffer>(EntityLocator.ConstructKeyFromPkItems(typeof(SpoSponsorOffer), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SpoSponsorOfferIdSource = tmpEntity;
				else
					entity.SpoSponsorOfferIdSource = DataRepository.SpoSponsorOfferProvider.GetBySpoSponsorOfferId(transactionManager, entity.SpoSponsorOfferId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SpoSponsorOfferIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SpoSponsorOfferIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SpoSponsorOfferProvider.DeepLoad(transactionManager, entity.SpoSponsorOfferIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SpoSponsorOfferIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SpoSponsorFeeItem object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SpoSponsorFeeItem instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SpoSponsorFeeItem Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SpoSponsorFeeItem entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region FeeCodeItemIdSource
			if (CanDeepSave(entity, "FeeCodeItem|FeeCodeItemIdSource", deepSaveType, innerList) 
				&& entity.FeeCodeItemIdSource != null)
			{
				DataRepository.FeeCodeItemProvider.Save(transactionManager, entity.FeeCodeItemIdSource);
				entity.FeeCodeItemId = entity.FeeCodeItemIdSource.FeeCodeItemId;
			}
			#endregion 
			
			#region SpoSponsorOfferIdSource
			if (CanDeepSave(entity, "SpoSponsorOffer|SpoSponsorOfferIdSource", deepSaveType, innerList) 
				&& entity.SpoSponsorOfferIdSource != null)
			{
				DataRepository.SpoSponsorOfferProvider.Save(transactionManager, entity.SpoSponsorOfferIdSource);
				entity.SpoSponsorOfferId = entity.SpoSponsorOfferIdSource.SpoSponsorOfferId;
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
	
	#region SpoSponsorFeeItemChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SpoSponsorFeeItem</c>
	///</summary>
	public enum SpoSponsorFeeItemChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>FeeCodeItem</c> at FeeCodeItemIdSource
		///</summary>
		[ChildEntityType(typeof(FeeCodeItem))]
		FeeCodeItem,
		
		///<summary>
		/// Composite Property for <c>SpoSponsorOffer</c> at SpoSponsorOfferIdSource
		///</summary>
		[ChildEntityType(typeof(SpoSponsorOffer))]
		SpoSponsorOffer,
	}
	
	#endregion SpoSponsorFeeItemChildEntityTypes
	
	#region SpoSponsorFeeItemFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SpoSponsorFeeItemColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SpoSponsorFeeItem"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SpoSponsorFeeItemFilterBuilder : SqlFilterBuilder<SpoSponsorFeeItemColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SpoSponsorFeeItemFilterBuilder class.
		/// </summary>
		public SpoSponsorFeeItemFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SpoSponsorFeeItemFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SpoSponsorFeeItemFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SpoSponsorFeeItemFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SpoSponsorFeeItemFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SpoSponsorFeeItemFilterBuilder
	
	#region SpoSponsorFeeItemParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SpoSponsorFeeItemColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SpoSponsorFeeItem"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SpoSponsorFeeItemParameterBuilder : ParameterizedSqlFilterBuilder<SpoSponsorFeeItemColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SpoSponsorFeeItemParameterBuilder class.
		/// </summary>
		public SpoSponsorFeeItemParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SpoSponsorFeeItemParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SpoSponsorFeeItemParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SpoSponsorFeeItemParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SpoSponsorFeeItemParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SpoSponsorFeeItemParameterBuilder
	
	#region SpoSponsorFeeItemSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SpoSponsorFeeItemColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SpoSponsorFeeItem"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SpoSponsorFeeItemSortBuilder : SqlSortBuilder<SpoSponsorFeeItemColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SpoSponsorFeeItemSqlSortBuilder class.
		/// </summary>
		public SpoSponsorFeeItemSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SpoSponsorFeeItemSortBuilder
	
} // end namespace
