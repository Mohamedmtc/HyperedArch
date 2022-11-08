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
	/// This class is the base class for any <see cref="FeeBusLineItemProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class FeeBusLineItemProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.FeeBusLineItem, UMIS_VER2.BusinessLyer.FeeBusLineItemKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeBusLineItemKey key)
		{
			return Delete(transactionManager, key.FeeBusLineItemId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_feeBusLineItemId">مصروفات خطوط الباص. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _feeBusLineItemId)
		{
			return Delete(null, _feeBusLineItemId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeBusLineItemId">مصروفات خطوط الباص. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _feeBusLineItemId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_BUS_LINE_ITEM_ED_ACAD_YEAR key.
		///		FK_FEE_BUS_LINE_ITEM_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="_edAcadYearId">العام الأكاديمى</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeBusLineItem objects.</returns>
		public TList<FeeBusLineItem> GetByEdAcadYearId(System.Decimal? _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(_edAcadYearId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_BUS_LINE_ITEM_ED_ACAD_YEAR key.
		///		FK_FEE_BUS_LINE_ITEM_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">العام الأكاديمى</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeBusLineItem objects.</returns>
		/// <remarks></remarks>
		public TList<FeeBusLineItem> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal? _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_BUS_LINE_ITEM_ED_ACAD_YEAR key.
		///		FK_FEE_BUS_LINE_ITEM_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">العام الأكاديمى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeBusLineItem objects.</returns>
		public TList<FeeBusLineItem> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal? _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_BUS_LINE_ITEM_ED_ACAD_YEAR key.
		///		fkFeeBusLineItemEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId">العام الأكاديمى</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeBusLineItem objects.</returns>
		public TList<FeeBusLineItem> GetByEdAcadYearId(System.Decimal? _edAcadYearId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_BUS_LINE_ITEM_ED_ACAD_YEAR key.
		///		fkFeeBusLineItemEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId">العام الأكاديمى</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeBusLineItem objects.</returns>
		public TList<FeeBusLineItem> GetByEdAcadYearId(System.Decimal? _edAcadYearId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_BUS_LINE_ITEM_ED_ACAD_YEAR key.
		///		FK_FEE_BUS_LINE_ITEM_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">العام الأكاديمى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeBusLineItem objects.</returns>
		public abstract TList<FeeBusLineItem> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal? _edAcadYearId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_BUS_LINE_ITEM_FEE_CODE_ITEM key.
		///		FK_FEE_BUS_LINE_ITEM_FEE_CODE_ITEM Description: 
		/// </summary>
		/// <param name="_feeCodeItemId">بند مصروف خدمة باص</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeBusLineItem objects.</returns>
		public TList<FeeBusLineItem> GetByFeeCodeItemId(System.Decimal _feeCodeItemId)
		{
			int count = -1;
			return GetByFeeCodeItemId(_feeCodeItemId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_BUS_LINE_ITEM_FEE_CODE_ITEM key.
		///		FK_FEE_BUS_LINE_ITEM_FEE_CODE_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeItemId">بند مصروف خدمة باص</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeBusLineItem objects.</returns>
		/// <remarks></remarks>
		public TList<FeeBusLineItem> GetByFeeCodeItemId(TransactionManager transactionManager, System.Decimal _feeCodeItemId)
		{
			int count = -1;
			return GetByFeeCodeItemId(transactionManager, _feeCodeItemId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_BUS_LINE_ITEM_FEE_CODE_ITEM key.
		///		FK_FEE_BUS_LINE_ITEM_FEE_CODE_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeItemId">بند مصروف خدمة باص</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeBusLineItem objects.</returns>
		public TList<FeeBusLineItem> GetByFeeCodeItemId(TransactionManager transactionManager, System.Decimal _feeCodeItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCodeItemId(transactionManager, _feeCodeItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_BUS_LINE_ITEM_FEE_CODE_ITEM key.
		///		fkFeeBusLineItemFeeCodeItem Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeCodeItemId">بند مصروف خدمة باص</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeBusLineItem objects.</returns>
		public TList<FeeBusLineItem> GetByFeeCodeItemId(System.Decimal _feeCodeItemId, int start, int pageLength)
		{
			int count =  -1;
			return GetByFeeCodeItemId(null, _feeCodeItemId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_BUS_LINE_ITEM_FEE_CODE_ITEM key.
		///		fkFeeBusLineItemFeeCodeItem Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeCodeItemId">بند مصروف خدمة باص</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeBusLineItem objects.</returns>
		public TList<FeeBusLineItem> GetByFeeCodeItemId(System.Decimal _feeCodeItemId, int start, int pageLength,out int count)
		{
			return GetByFeeCodeItemId(null, _feeCodeItemId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_BUS_LINE_ITEM_FEE_CODE_ITEM key.
		///		FK_FEE_BUS_LINE_ITEM_FEE_CODE_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeItemId">بند مصروف خدمة باص</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeBusLineItem objects.</returns>
		public abstract TList<FeeBusLineItem> GetByFeeCodeItemId(TransactionManager transactionManager, System.Decimal _feeCodeItemId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_BUS_LINE_ITEM_TRNS_LINE key.
		///		FK_FEE_BUS_LINE_ITEM_TRNS_LINE Description: 
		/// </summary>
		/// <param name="_trnsLineId">اسم الخط</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeBusLineItem objects.</returns>
		public TList<FeeBusLineItem> GetByTrnsLineId(System.Decimal _trnsLineId)
		{
			int count = -1;
			return GetByTrnsLineId(_trnsLineId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_BUS_LINE_ITEM_TRNS_LINE key.
		///		FK_FEE_BUS_LINE_ITEM_TRNS_LINE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_trnsLineId">اسم الخط</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeBusLineItem objects.</returns>
		/// <remarks></remarks>
		public TList<FeeBusLineItem> GetByTrnsLineId(TransactionManager transactionManager, System.Decimal _trnsLineId)
		{
			int count = -1;
			return GetByTrnsLineId(transactionManager, _trnsLineId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_BUS_LINE_ITEM_TRNS_LINE key.
		///		FK_FEE_BUS_LINE_ITEM_TRNS_LINE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_trnsLineId">اسم الخط</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeBusLineItem objects.</returns>
		public TList<FeeBusLineItem> GetByTrnsLineId(TransactionManager transactionManager, System.Decimal _trnsLineId, int start, int pageLength)
		{
			int count = -1;
			return GetByTrnsLineId(transactionManager, _trnsLineId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_BUS_LINE_ITEM_TRNS_LINE key.
		///		fkFeeBusLineItemTrnsLine Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_trnsLineId">اسم الخط</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeBusLineItem objects.</returns>
		public TList<FeeBusLineItem> GetByTrnsLineId(System.Decimal _trnsLineId, int start, int pageLength)
		{
			int count =  -1;
			return GetByTrnsLineId(null, _trnsLineId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_BUS_LINE_ITEM_TRNS_LINE key.
		///		fkFeeBusLineItemTrnsLine Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_trnsLineId">اسم الخط</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeBusLineItem objects.</returns>
		public TList<FeeBusLineItem> GetByTrnsLineId(System.Decimal _trnsLineId, int start, int pageLength,out int count)
		{
			return GetByTrnsLineId(null, _trnsLineId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_BUS_LINE_ITEM_TRNS_LINE key.
		///		FK_FEE_BUS_LINE_ITEM_TRNS_LINE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_trnsLineId">اسم الخط</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeBusLineItem objects.</returns>
		public abstract TList<FeeBusLineItem> GetByTrnsLineId(TransactionManager transactionManager, System.Decimal _trnsLineId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.FeeBusLineItem Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeBusLineItemKey key, int start, int pageLength)
		{
			return GetByFeeBusLineItemId(transactionManager, key.FeeBusLineItemId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_FEE_BUS_LINE_ITEM index.
		/// </summary>
		/// <param name="_feeBusLineItemId">مصروفات خطوط الباص</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeBusLineItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeBusLineItem GetByFeeBusLineItemId(System.Decimal _feeBusLineItemId)
		{
			int count = -1;
			return GetByFeeBusLineItemId(null,_feeBusLineItemId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_BUS_LINE_ITEM index.
		/// </summary>
		/// <param name="_feeBusLineItemId">مصروفات خطوط الباص</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeBusLineItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeBusLineItem GetByFeeBusLineItemId(System.Decimal _feeBusLineItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeBusLineItemId(null, _feeBusLineItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_BUS_LINE_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeBusLineItemId">مصروفات خطوط الباص</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeBusLineItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeBusLineItem GetByFeeBusLineItemId(TransactionManager transactionManager, System.Decimal _feeBusLineItemId)
		{
			int count = -1;
			return GetByFeeBusLineItemId(transactionManager, _feeBusLineItemId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_BUS_LINE_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeBusLineItemId">مصروفات خطوط الباص</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeBusLineItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeBusLineItem GetByFeeBusLineItemId(TransactionManager transactionManager, System.Decimal _feeBusLineItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeBusLineItemId(transactionManager, _feeBusLineItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_BUS_LINE_ITEM index.
		/// </summary>
		/// <param name="_feeBusLineItemId">مصروفات خطوط الباص</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeBusLineItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeBusLineItem GetByFeeBusLineItemId(System.Decimal _feeBusLineItemId, int start, int pageLength, out int count)
		{
			return GetByFeeBusLineItemId(null, _feeBusLineItemId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_BUS_LINE_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeBusLineItemId">مصروفات خطوط الباص</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeBusLineItem"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.FeeBusLineItem GetByFeeBusLineItemId(TransactionManager transactionManager, System.Decimal _feeBusLineItemId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;FeeBusLineItem&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;FeeBusLineItem&gt;"/></returns>
		public static TList<FeeBusLineItem> Fill(IDataReader reader, TList<FeeBusLineItem> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.FeeBusLineItem c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("FeeBusLineItem")
					.Append("|").Append((System.Decimal)reader["FEE_BUS_LINE_ITEM_ID"]).ToString();
					c = EntityManager.LocateOrCreate<FeeBusLineItem>(
					key.ToString(), // EntityTrackingKey
					"FeeBusLineItem",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.FeeBusLineItem();
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
					c.FeeBusLineItemId = (System.Decimal)reader["FEE_BUS_LINE_ITEM_ID"];
					c.OriginalFeeBusLineItemId = c.FeeBusLineItemId;
					c.EdAcadYearId = Convert.IsDBNull(reader["ED_ACAD_YEAR_ID"]) ? null : (System.Decimal?)reader["ED_ACAD_YEAR_ID"];
					c.TrnsLineId = (System.Decimal)reader["TRNS_LINE_ID"];
					c.FeeCodeItemId = (System.Decimal)reader["FEE_CODE_ITEM_ID"];
					c.FeeItemValue = Convert.IsDBNull(reader["FEE_ITEM_VALUE"]) ? null : (System.Decimal?)reader["FEE_ITEM_VALUE"];
					c.FeeItemValueSummar = Convert.IsDBNull(reader["FEE_ITEM_VALUE_SUMMAR"]) ? null : (System.Decimal?)reader["FEE_ITEM_VALUE_SUMMAR"];
					c.FeeItemValueYear = Convert.IsDBNull(reader["FEE_ITEM_VALUE_YEAR"]) ? null : (System.Decimal?)reader["FEE_ITEM_VALUE_YEAR"];
					c.LastDate = Convert.IsDBNull(reader["LAST_DATE"]) ? null : (System.DateTime?)reader["LAST_DATE"];
					c.SeUserId = Convert.IsDBNull(reader["SE_USER_ID"]) ? null : (System.Decimal?)reader["SE_USER_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeBusLineItem"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeBusLineItem"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.FeeBusLineItem entity)
		{
			if (!reader.Read()) return;
			
			entity.FeeBusLineItemId = (System.Decimal)reader[((int)FeeBusLineItemColumn.FeeBusLineItemId - 1)];
			entity.OriginalFeeBusLineItemId = (System.Decimal)reader["FEE_BUS_LINE_ITEM_ID"];
			entity.EdAcadYearId = (reader.IsDBNull(((int)FeeBusLineItemColumn.EdAcadYearId - 1)))?null:(System.Decimal?)reader[((int)FeeBusLineItemColumn.EdAcadYearId - 1)];
			entity.TrnsLineId = (System.Decimal)reader[((int)FeeBusLineItemColumn.TrnsLineId - 1)];
			entity.FeeCodeItemId = (System.Decimal)reader[((int)FeeBusLineItemColumn.FeeCodeItemId - 1)];
			entity.FeeItemValue = (reader.IsDBNull(((int)FeeBusLineItemColumn.FeeItemValue - 1)))?null:(System.Decimal?)reader[((int)FeeBusLineItemColumn.FeeItemValue - 1)];
			entity.FeeItemValueSummar = (reader.IsDBNull(((int)FeeBusLineItemColumn.FeeItemValueSummar - 1)))?null:(System.Decimal?)reader[((int)FeeBusLineItemColumn.FeeItemValueSummar - 1)];
			entity.FeeItemValueYear = (reader.IsDBNull(((int)FeeBusLineItemColumn.FeeItemValueYear - 1)))?null:(System.Decimal?)reader[((int)FeeBusLineItemColumn.FeeItemValueYear - 1)];
			entity.LastDate = (reader.IsDBNull(((int)FeeBusLineItemColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)FeeBusLineItemColumn.LastDate - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)FeeBusLineItemColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)FeeBusLineItemColumn.SeUserId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeBusLineItem"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeBusLineItem"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.FeeBusLineItem entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.FeeBusLineItemId = (System.Decimal)dataRow["FEE_BUS_LINE_ITEM_ID"];
			entity.OriginalFeeBusLineItemId = (System.Decimal)dataRow["FEE_BUS_LINE_ITEM_ID"];
			entity.EdAcadYearId = Convert.IsDBNull(dataRow["ED_ACAD_YEAR_ID"]) ? null : (System.Decimal?)dataRow["ED_ACAD_YEAR_ID"];
			entity.TrnsLineId = (System.Decimal)dataRow["TRNS_LINE_ID"];
			entity.FeeCodeItemId = (System.Decimal)dataRow["FEE_CODE_ITEM_ID"];
			entity.FeeItemValue = Convert.IsDBNull(dataRow["FEE_ITEM_VALUE"]) ? null : (System.Decimal?)dataRow["FEE_ITEM_VALUE"];
			entity.FeeItemValueSummar = Convert.IsDBNull(dataRow["FEE_ITEM_VALUE_SUMMAR"]) ? null : (System.Decimal?)dataRow["FEE_ITEM_VALUE_SUMMAR"];
			entity.FeeItemValueYear = Convert.IsDBNull(dataRow["FEE_ITEM_VALUE_YEAR"]) ? null : (System.Decimal?)dataRow["FEE_ITEM_VALUE_YEAR"];
			entity.LastDate = Convert.IsDBNull(dataRow["LAST_DATE"]) ? null : (System.DateTime?)dataRow["LAST_DATE"];
			entity.SeUserId = Convert.IsDBNull(dataRow["SE_USER_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeBusLineItem"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeBusLineItem Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeBusLineItem entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdAcadYearIdSource	
			if (CanDeepLoad(entity, "EdAcadYear|EdAcadYearIdSource", deepLoadType, innerList) 
				&& entity.EdAcadYearIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.EdAcadYearId ?? 0.0m);
				EdAcadYear tmpEntity = EntityManager.LocateEntity<EdAcadYear>(EntityLocator.ConstructKeyFromPkItems(typeof(EdAcadYear), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdAcadYearIdSource = tmpEntity;
				else
					entity.EdAcadYearIdSource = DataRepository.EdAcadYearProvider.GetByEdAcadYearId(transactionManager, (entity.EdAcadYearId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdAcadYearIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdAcadYearIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdAcadYearProvider.DeepLoad(transactionManager, entity.EdAcadYearIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdAcadYearIdSource

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

			#region TrnsLineIdSource	
			if (CanDeepLoad(entity, "TrnsLine|TrnsLineIdSource", deepLoadType, innerList) 
				&& entity.TrnsLineIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.TrnsLineId;
				TrnsLine tmpEntity = EntityManager.LocateEntity<TrnsLine>(EntityLocator.ConstructKeyFromPkItems(typeof(TrnsLine), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.TrnsLineIdSource = tmpEntity;
				else
					entity.TrnsLineIdSource = DataRepository.TrnsLineProvider.GetByTrnsLineId(transactionManager, entity.TrnsLineId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'TrnsLineIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.TrnsLineIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.TrnsLineProvider.DeepLoad(transactionManager, entity.TrnsLineIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion TrnsLineIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.FeeBusLineItem object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.FeeBusLineItem instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeBusLineItem Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeBusLineItem entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdAcadYearIdSource
			if (CanDeepSave(entity, "EdAcadYear|EdAcadYearIdSource", deepSaveType, innerList) 
				&& entity.EdAcadYearIdSource != null)
			{
				DataRepository.EdAcadYearProvider.Save(transactionManager, entity.EdAcadYearIdSource);
				entity.EdAcadYearId = entity.EdAcadYearIdSource.EdAcadYearId;
			}
			#endregion 
			
			#region FeeCodeItemIdSource
			if (CanDeepSave(entity, "FeeCodeItem|FeeCodeItemIdSource", deepSaveType, innerList) 
				&& entity.FeeCodeItemIdSource != null)
			{
				DataRepository.FeeCodeItemProvider.Save(transactionManager, entity.FeeCodeItemIdSource);
				entity.FeeCodeItemId = entity.FeeCodeItemIdSource.FeeCodeItemId;
			}
			#endregion 
			
			#region TrnsLineIdSource
			if (CanDeepSave(entity, "TrnsLine|TrnsLineIdSource", deepSaveType, innerList) 
				&& entity.TrnsLineIdSource != null)
			{
				DataRepository.TrnsLineProvider.Save(transactionManager, entity.TrnsLineIdSource);
				entity.TrnsLineId = entity.TrnsLineIdSource.TrnsLineId;
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
	
	#region FeeBusLineItemChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.FeeBusLineItem</c>
	///</summary>
	public enum FeeBusLineItemChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdAcadYear</c> at EdAcadYearIdSource
		///</summary>
		[ChildEntityType(typeof(EdAcadYear))]
		EdAcadYear,
		
		///<summary>
		/// Composite Property for <c>FeeCodeItem</c> at FeeCodeItemIdSource
		///</summary>
		[ChildEntityType(typeof(FeeCodeItem))]
		FeeCodeItem,
		
		///<summary>
		/// Composite Property for <c>TrnsLine</c> at TrnsLineIdSource
		///</summary>
		[ChildEntityType(typeof(TrnsLine))]
		TrnsLine,
	}
	
	#endregion FeeBusLineItemChildEntityTypes
	
	#region FeeBusLineItemFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;FeeBusLineItemColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeBusLineItem"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeBusLineItemFilterBuilder : SqlFilterBuilder<FeeBusLineItemColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeBusLineItemFilterBuilder class.
		/// </summary>
		public FeeBusLineItemFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeBusLineItemFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeBusLineItemFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeBusLineItemFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeBusLineItemFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeBusLineItemFilterBuilder
	
	#region FeeBusLineItemParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;FeeBusLineItemColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeBusLineItem"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeBusLineItemParameterBuilder : ParameterizedSqlFilterBuilder<FeeBusLineItemColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeBusLineItemParameterBuilder class.
		/// </summary>
		public FeeBusLineItemParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeBusLineItemParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeBusLineItemParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeBusLineItemParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeBusLineItemParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeBusLineItemParameterBuilder
	
	#region FeeBusLineItemSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;FeeBusLineItemColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeBusLineItem"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class FeeBusLineItemSortBuilder : SqlSortBuilder<FeeBusLineItemColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeBusLineItemSqlSortBuilder class.
		/// </summary>
		public FeeBusLineItemSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion FeeBusLineItemSortBuilder
	
} // end namespace
