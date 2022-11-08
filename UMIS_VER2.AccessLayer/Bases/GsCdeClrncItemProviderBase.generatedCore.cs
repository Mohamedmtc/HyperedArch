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
	/// This class is the base class for any <see cref="GsCdeClrncItemProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GsCdeClrncItemProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.GsCdeClrncItem, UMIS_VER2.BusinessLyer.GsCdeClrncItemKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeClrncItemKey key)
		{
			return Delete(transactionManager, key.GsCdeClrncItemId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_gsCdeClrncItemId">بنود اخلاء الطرف. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _gsCdeClrncItemId)
		{
			return Delete(null, _gsCdeClrncItemId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeClrncItemId">بنود اخلاء الطرف. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _gsCdeClrncItemId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CDE_CLRNC_ITEM_GS_CDE_CLRNC_REASON key.
		///		FK_GS_CDE_CLRNC_ITEM_GS_CDE_CLRNC_REASON Description: 
		/// </summary>
		/// <param name="_gsCdeClrncReasonId">سبب اخلاء الطرف</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCdeClrncItem objects.</returns>
		public TList<GsCdeClrncItem> GetByGsCdeClrncReasonId(System.Decimal? _gsCdeClrncReasonId)
		{
			int count = -1;
			return GetByGsCdeClrncReasonId(_gsCdeClrncReasonId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CDE_CLRNC_ITEM_GS_CDE_CLRNC_REASON key.
		///		FK_GS_CDE_CLRNC_ITEM_GS_CDE_CLRNC_REASON Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeClrncReasonId">سبب اخلاء الطرف</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCdeClrncItem objects.</returns>
		/// <remarks></remarks>
		public TList<GsCdeClrncItem> GetByGsCdeClrncReasonId(TransactionManager transactionManager, System.Decimal? _gsCdeClrncReasonId)
		{
			int count = -1;
			return GetByGsCdeClrncReasonId(transactionManager, _gsCdeClrncReasonId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CDE_CLRNC_ITEM_GS_CDE_CLRNC_REASON key.
		///		FK_GS_CDE_CLRNC_ITEM_GS_CDE_CLRNC_REASON Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeClrncReasonId">سبب اخلاء الطرف</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCdeClrncItem objects.</returns>
		public TList<GsCdeClrncItem> GetByGsCdeClrncReasonId(TransactionManager transactionManager, System.Decimal? _gsCdeClrncReasonId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeClrncReasonId(transactionManager, _gsCdeClrncReasonId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CDE_CLRNC_ITEM_GS_CDE_CLRNC_REASON key.
		///		fkGsCdeClrncItemGsCdeClrncReason Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCdeClrncReasonId">سبب اخلاء الطرف</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCdeClrncItem objects.</returns>
		public TList<GsCdeClrncItem> GetByGsCdeClrncReasonId(System.Decimal? _gsCdeClrncReasonId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCdeClrncReasonId(null, _gsCdeClrncReasonId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CDE_CLRNC_ITEM_GS_CDE_CLRNC_REASON key.
		///		fkGsCdeClrncItemGsCdeClrncReason Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCdeClrncReasonId">سبب اخلاء الطرف</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCdeClrncItem objects.</returns>
		public TList<GsCdeClrncItem> GetByGsCdeClrncReasonId(System.Decimal? _gsCdeClrncReasonId, int start, int pageLength,out int count)
		{
			return GetByGsCdeClrncReasonId(null, _gsCdeClrncReasonId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CDE_CLRNC_ITEM_GS_CDE_CLRNC_REASON key.
		///		FK_GS_CDE_CLRNC_ITEM_GS_CDE_CLRNC_REASON Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeClrncReasonId">سبب اخلاء الطرف</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCdeClrncItem objects.</returns>
		public abstract TList<GsCdeClrncItem> GetByGsCdeClrncReasonId(TransactionManager transactionManager, System.Decimal? _gsCdeClrncReasonId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CDE_CLRNC_ITEM_GS_CODE_GENDER key.
		///		FK_GS_CDE_CLRNC_ITEM_GS_CODE_GENDER Description: 
		/// </summary>
		/// <param name="_gsCodeGenderId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCdeClrncItem objects.</returns>
		public TList<GsCdeClrncItem> GetByGsCodeGenderId(System.Decimal? _gsCodeGenderId)
		{
			int count = -1;
			return GetByGsCodeGenderId(_gsCodeGenderId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CDE_CLRNC_ITEM_GS_CODE_GENDER key.
		///		FK_GS_CDE_CLRNC_ITEM_GS_CODE_GENDER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeGenderId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCdeClrncItem objects.</returns>
		/// <remarks></remarks>
		public TList<GsCdeClrncItem> GetByGsCodeGenderId(TransactionManager transactionManager, System.Decimal? _gsCodeGenderId)
		{
			int count = -1;
			return GetByGsCodeGenderId(transactionManager, _gsCodeGenderId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CDE_CLRNC_ITEM_GS_CODE_GENDER key.
		///		FK_GS_CDE_CLRNC_ITEM_GS_CODE_GENDER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeGenderId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCdeClrncItem objects.</returns>
		public TList<GsCdeClrncItem> GetByGsCodeGenderId(TransactionManager transactionManager, System.Decimal? _gsCodeGenderId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeGenderId(transactionManager, _gsCodeGenderId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CDE_CLRNC_ITEM_GS_CODE_GENDER key.
		///		fkGsCdeClrncItemGsCodeGender Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeGenderId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCdeClrncItem objects.</returns>
		public TList<GsCdeClrncItem> GetByGsCodeGenderId(System.Decimal? _gsCodeGenderId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodeGenderId(null, _gsCodeGenderId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CDE_CLRNC_ITEM_GS_CODE_GENDER key.
		///		fkGsCdeClrncItemGsCodeGender Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeGenderId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCdeClrncItem objects.</returns>
		public TList<GsCdeClrncItem> GetByGsCodeGenderId(System.Decimal? _gsCodeGenderId, int start, int pageLength,out int count)
		{
			return GetByGsCodeGenderId(null, _gsCodeGenderId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CDE_CLRNC_ITEM_GS_CODE_GENDER key.
		///		FK_GS_CDE_CLRNC_ITEM_GS_CODE_GENDER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeGenderId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCdeClrncItem objects.</returns>
		public abstract TList<GsCdeClrncItem> GetByGsCodeGenderId(TransactionManager transactionManager, System.Decimal? _gsCodeGenderId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CDE_CLRNC_ITEM_SE_CODE_USER_TYPE1 key.
		///		FK_GS_CDE_CLRNC_ITEM_SE_CODE_USER_TYPE1 Description: 
		/// </summary>
		/// <param name="_seCodeUserTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCdeClrncItem objects.</returns>
		public TList<GsCdeClrncItem> GetBySeCodeUserTypeId(System.Decimal? _seCodeUserTypeId)
		{
			int count = -1;
			return GetBySeCodeUserTypeId(_seCodeUserTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CDE_CLRNC_ITEM_SE_CODE_USER_TYPE1 key.
		///		FK_GS_CDE_CLRNC_ITEM_SE_CODE_USER_TYPE1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seCodeUserTypeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCdeClrncItem objects.</returns>
		/// <remarks></remarks>
		public TList<GsCdeClrncItem> GetBySeCodeUserTypeId(TransactionManager transactionManager, System.Decimal? _seCodeUserTypeId)
		{
			int count = -1;
			return GetBySeCodeUserTypeId(transactionManager, _seCodeUserTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CDE_CLRNC_ITEM_SE_CODE_USER_TYPE1 key.
		///		FK_GS_CDE_CLRNC_ITEM_SE_CODE_USER_TYPE1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seCodeUserTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCdeClrncItem objects.</returns>
		public TList<GsCdeClrncItem> GetBySeCodeUserTypeId(TransactionManager transactionManager, System.Decimal? _seCodeUserTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetBySeCodeUserTypeId(transactionManager, _seCodeUserTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CDE_CLRNC_ITEM_SE_CODE_USER_TYPE1 key.
		///		fkGsCdeClrncItemSeCodeUserType1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seCodeUserTypeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCdeClrncItem objects.</returns>
		public TList<GsCdeClrncItem> GetBySeCodeUserTypeId(System.Decimal? _seCodeUserTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetBySeCodeUserTypeId(null, _seCodeUserTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CDE_CLRNC_ITEM_SE_CODE_USER_TYPE1 key.
		///		fkGsCdeClrncItemSeCodeUserType1 Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_seCodeUserTypeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCdeClrncItem objects.</returns>
		public TList<GsCdeClrncItem> GetBySeCodeUserTypeId(System.Decimal? _seCodeUserTypeId, int start, int pageLength,out int count)
		{
			return GetBySeCodeUserTypeId(null, _seCodeUserTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_GS_CDE_CLRNC_ITEM_SE_CODE_USER_TYPE1 key.
		///		FK_GS_CDE_CLRNC_ITEM_SE_CODE_USER_TYPE1 Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_seCodeUserTypeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.GsCdeClrncItem objects.</returns>
		public abstract TList<GsCdeClrncItem> GetBySeCodeUserTypeId(TransactionManager transactionManager, System.Decimal? _seCodeUserTypeId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.GsCdeClrncItem Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeClrncItemKey key, int start, int pageLength)
		{
			return GetByGsCdeClrncItemId(transactionManager, key.GsCdeClrncItemId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_CDE_CLRNC_ITEM index.
		/// </summary>
		/// <param name="_gsCdeClrncItemId">بنود اخلاء الطرف</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeClrncItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeClrncItem GetByGsCdeClrncItemId(System.Decimal _gsCdeClrncItemId)
		{
			int count = -1;
			return GetByGsCdeClrncItemId(null,_gsCdeClrncItemId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CDE_CLRNC_ITEM index.
		/// </summary>
		/// <param name="_gsCdeClrncItemId">بنود اخلاء الطرف</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeClrncItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeClrncItem GetByGsCdeClrncItemId(System.Decimal _gsCdeClrncItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeClrncItemId(null, _gsCdeClrncItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CDE_CLRNC_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeClrncItemId">بنود اخلاء الطرف</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeClrncItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeClrncItem GetByGsCdeClrncItemId(TransactionManager transactionManager, System.Decimal _gsCdeClrncItemId)
		{
			int count = -1;
			return GetByGsCdeClrncItemId(transactionManager, _gsCdeClrncItemId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CDE_CLRNC_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeClrncItemId">بنود اخلاء الطرف</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeClrncItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeClrncItem GetByGsCdeClrncItemId(TransactionManager transactionManager, System.Decimal _gsCdeClrncItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCdeClrncItemId(transactionManager, _gsCdeClrncItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CDE_CLRNC_ITEM index.
		/// </summary>
		/// <param name="_gsCdeClrncItemId">بنود اخلاء الطرف</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeClrncItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.GsCdeClrncItem GetByGsCdeClrncItemId(System.Decimal _gsCdeClrncItemId, int start, int pageLength, out int count)
		{
			return GetByGsCdeClrncItemId(null, _gsCdeClrncItemId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CDE_CLRNC_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCdeClrncItemId">بنود اخلاء الطرف</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.GsCdeClrncItem"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.GsCdeClrncItem GetByGsCdeClrncItemId(TransactionManager transactionManager, System.Decimal _gsCdeClrncItemId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;GsCdeClrncItem&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;GsCdeClrncItem&gt;"/></returns>
		public static TList<GsCdeClrncItem> Fill(IDataReader reader, TList<GsCdeClrncItem> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.GsCdeClrncItem c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("GsCdeClrncItem")
					.Append("|").Append((System.Decimal)reader["GS_CDE_CLRNC_ITEM_ID"]).ToString();
					c = EntityManager.LocateOrCreate<GsCdeClrncItem>(
					key.ToString(), // EntityTrackingKey
					"GsCdeClrncItem",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.GsCdeClrncItem();
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
					c.GsCdeClrncItemId = (System.Decimal)reader["GS_CDE_CLRNC_ITEM_ID"];
					c.OriginalGsCdeClrncItemId = c.GsCdeClrncItemId;
					c.DescrAr = (System.String)reader["DESCR_AR"];
					c.DescrEn = Convert.IsDBNull(reader["DESCR_EN"]) ? null : (System.String)reader["DESCR_EN"];
					c.DbSpCheck = Convert.IsDBNull(reader["DB_SP_CHECK"]) ? null : (System.String)reader["DB_SP_CHECK"];
					c.SeCodeUserTypeId = Convert.IsDBNull(reader["SE_CODE_USER_TYPE_ID"]) ? null : (System.Decimal?)reader["SE_CODE_USER_TYPE_ID"];
					c.SignFlg = Convert.IsDBNull(reader["SIGN_FLG"]) ? null : (System.Boolean?)reader["SIGN_FLG"];
					c.GsCodeGenderId = Convert.IsDBNull(reader["GS_CODE_GENDER_ID"]) ? null : (System.Decimal?)reader["GS_CODE_GENDER_ID"];
					c.GsCdeClrncReasonId = Convert.IsDBNull(reader["GS_CDE_CLRNC_REASON_ID"]) ? null : (System.Decimal?)reader["GS_CDE_CLRNC_REASON_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCdeClrncItem"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCdeClrncItem"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.GsCdeClrncItem entity)
		{
			if (!reader.Read()) return;
			
			entity.GsCdeClrncItemId = (System.Decimal)reader[((int)GsCdeClrncItemColumn.GsCdeClrncItemId - 1)];
			entity.OriginalGsCdeClrncItemId = (System.Decimal)reader["GS_CDE_CLRNC_ITEM_ID"];
			entity.DescrAr = (System.String)reader[((int)GsCdeClrncItemColumn.DescrAr - 1)];
			entity.DescrEn = (reader.IsDBNull(((int)GsCdeClrncItemColumn.DescrEn - 1)))?null:(System.String)reader[((int)GsCdeClrncItemColumn.DescrEn - 1)];
			entity.DbSpCheck = (reader.IsDBNull(((int)GsCdeClrncItemColumn.DbSpCheck - 1)))?null:(System.String)reader[((int)GsCdeClrncItemColumn.DbSpCheck - 1)];
			entity.SeCodeUserTypeId = (reader.IsDBNull(((int)GsCdeClrncItemColumn.SeCodeUserTypeId - 1)))?null:(System.Decimal?)reader[((int)GsCdeClrncItemColumn.SeCodeUserTypeId - 1)];
			entity.SignFlg = (reader.IsDBNull(((int)GsCdeClrncItemColumn.SignFlg - 1)))?null:(System.Boolean?)reader[((int)GsCdeClrncItemColumn.SignFlg - 1)];
			entity.GsCodeGenderId = (reader.IsDBNull(((int)GsCdeClrncItemColumn.GsCodeGenderId - 1)))?null:(System.Decimal?)reader[((int)GsCdeClrncItemColumn.GsCodeGenderId - 1)];
			entity.GsCdeClrncReasonId = (reader.IsDBNull(((int)GsCdeClrncItemColumn.GsCdeClrncReasonId - 1)))?null:(System.Decimal?)reader[((int)GsCdeClrncItemColumn.GsCdeClrncReasonId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.GsCdeClrncItem"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCdeClrncItem"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.GsCdeClrncItem entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.GsCdeClrncItemId = (System.Decimal)dataRow["GS_CDE_CLRNC_ITEM_ID"];
			entity.OriginalGsCdeClrncItemId = (System.Decimal)dataRow["GS_CDE_CLRNC_ITEM_ID"];
			entity.DescrAr = (System.String)dataRow["DESCR_AR"];
			entity.DescrEn = Convert.IsDBNull(dataRow["DESCR_EN"]) ? null : (System.String)dataRow["DESCR_EN"];
			entity.DbSpCheck = Convert.IsDBNull(dataRow["DB_SP_CHECK"]) ? null : (System.String)dataRow["DB_SP_CHECK"];
			entity.SeCodeUserTypeId = Convert.IsDBNull(dataRow["SE_CODE_USER_TYPE_ID"]) ? null : (System.Decimal?)dataRow["SE_CODE_USER_TYPE_ID"];
			entity.SignFlg = Convert.IsDBNull(dataRow["SIGN_FLG"]) ? null : (System.Boolean?)dataRow["SIGN_FLG"];
			entity.GsCodeGenderId = Convert.IsDBNull(dataRow["GS_CODE_GENDER_ID"]) ? null : (System.Decimal?)dataRow["GS_CODE_GENDER_ID"];
			entity.GsCdeClrncReasonId = Convert.IsDBNull(dataRow["GS_CDE_CLRNC_REASON_ID"]) ? null : (System.Decimal?)dataRow["GS_CDE_CLRNC_REASON_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.GsCdeClrncItem"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCdeClrncItem Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeClrncItem entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region GsCdeClrncReasonIdSource	
			if (CanDeepLoad(entity, "GsCdeClrncReason|GsCdeClrncReasonIdSource", deepLoadType, innerList) 
				&& entity.GsCdeClrncReasonIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCdeClrncReasonId ?? 0.0m);
				GsCdeClrncReason tmpEntity = EntityManager.LocateEntity<GsCdeClrncReason>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCdeClrncReason), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCdeClrncReasonIdSource = tmpEntity;
				else
					entity.GsCdeClrncReasonIdSource = DataRepository.GsCdeClrncReasonProvider.GetByGsCdeClrncReasonId(transactionManager, (entity.GsCdeClrncReasonId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCdeClrncReasonIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCdeClrncReasonIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCdeClrncReasonProvider.DeepLoad(transactionManager, entity.GsCdeClrncReasonIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCdeClrncReasonIdSource

			#region GsCodeGenderIdSource	
			if (CanDeepLoad(entity, "GsCodeGender|GsCodeGenderIdSource", deepLoadType, innerList) 
				&& entity.GsCodeGenderIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.GsCodeGenderId ?? 0.0m);
				GsCodeGender tmpEntity = EntityManager.LocateEntity<GsCodeGender>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodeGender), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodeGenderIdSource = tmpEntity;
				else
					entity.GsCodeGenderIdSource = DataRepository.GsCodeGenderProvider.GetByGsCodeGenderId(transactionManager, (entity.GsCodeGenderId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodeGenderIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCodeGenderIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodeGenderProvider.DeepLoad(transactionManager, entity.GsCodeGenderIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCodeGenderIdSource

			#region SeCodeUserTypeIdSource	
			if (CanDeepLoad(entity, "SeCodeUserType|SeCodeUserTypeIdSource", deepLoadType, innerList) 
				&& entity.SeCodeUserTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.SeCodeUserTypeId ?? 0.0m);
				SeCodeUserType tmpEntity = EntityManager.LocateEntity<SeCodeUserType>(EntityLocator.ConstructKeyFromPkItems(typeof(SeCodeUserType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.SeCodeUserTypeIdSource = tmpEntity;
				else
					entity.SeCodeUserTypeIdSource = DataRepository.SeCodeUserTypeProvider.GetBySeCodeUserTypeId(transactionManager, (entity.SeCodeUserTypeId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SeCodeUserTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.SeCodeUserTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.SeCodeUserTypeProvider.DeepLoad(transactionManager, entity.SeCodeUserTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion SeCodeUserTypeIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByGsCdeClrncItemId methods when available
			
			#region GsCdeClrncItemFacCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<GsCdeClrncItemFac>|GsCdeClrncItemFacCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCdeClrncItemFacCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.GsCdeClrncItemFacCollection = DataRepository.GsCdeClrncItemFacProvider.GetByGsCdeClrncItemId(transactionManager, entity.GsCdeClrncItemId);

				if (deep && entity.GsCdeClrncItemFacCollection.Count > 0)
				{
					deepHandles.Add("GsCdeClrncItemFacCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<GsCdeClrncItemFac>) DataRepository.GsCdeClrncItemFacProvider.DeepLoad,
						new object[] { transactionManager, entity.GsCdeClrncItemFacCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region EdStudClrncItemCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<EdStudClrncItem>|EdStudClrncItemCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudClrncItemCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.EdStudClrncItemCollection = DataRepository.EdStudClrncItemProvider.GetByGsCdeClrncItemId(transactionManager, entity.GsCdeClrncItemId);

				if (deep && entity.EdStudClrncItemCollection.Count > 0)
				{
					deepHandles.Add("EdStudClrncItemCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<EdStudClrncItem>) DataRepository.EdStudClrncItemProvider.DeepLoad,
						new object[] { transactionManager, entity.EdStudClrncItemCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.GsCdeClrncItem object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.GsCdeClrncItem instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.GsCdeClrncItem Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.GsCdeClrncItem entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region GsCdeClrncReasonIdSource
			if (CanDeepSave(entity, "GsCdeClrncReason|GsCdeClrncReasonIdSource", deepSaveType, innerList) 
				&& entity.GsCdeClrncReasonIdSource != null)
			{
				DataRepository.GsCdeClrncReasonProvider.Save(transactionManager, entity.GsCdeClrncReasonIdSource);
				entity.GsCdeClrncReasonId = entity.GsCdeClrncReasonIdSource.GsCdeClrncReasonId;
			}
			#endregion 
			
			#region GsCodeGenderIdSource
			if (CanDeepSave(entity, "GsCodeGender|GsCodeGenderIdSource", deepSaveType, innerList) 
				&& entity.GsCodeGenderIdSource != null)
			{
				DataRepository.GsCodeGenderProvider.Save(transactionManager, entity.GsCodeGenderIdSource);
				entity.GsCodeGenderId = entity.GsCodeGenderIdSource.GsCodeGenderId;
			}
			#endregion 
			
			#region SeCodeUserTypeIdSource
			if (CanDeepSave(entity, "SeCodeUserType|SeCodeUserTypeIdSource", deepSaveType, innerList) 
				&& entity.SeCodeUserTypeIdSource != null)
			{
				DataRepository.SeCodeUserTypeProvider.Save(transactionManager, entity.SeCodeUserTypeIdSource);
				entity.SeCodeUserTypeId = entity.SeCodeUserTypeIdSource.SeCodeUserTypeId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<GsCdeClrncItemFac>
				if (CanDeepSave(entity.GsCdeClrncItemFacCollection, "List<GsCdeClrncItemFac>|GsCdeClrncItemFacCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(GsCdeClrncItemFac child in entity.GsCdeClrncItemFacCollection)
					{
						if(child.GsCdeClrncItemIdSource != null)
						{
							child.GsCdeClrncItemId = child.GsCdeClrncItemIdSource.GsCdeClrncItemId;
						}
						else
						{
							child.GsCdeClrncItemId = entity.GsCdeClrncItemId;
						}

					}

					if (entity.GsCdeClrncItemFacCollection.Count > 0 || entity.GsCdeClrncItemFacCollection.DeletedItems.Count > 0)
					{
						//DataRepository.GsCdeClrncItemFacProvider.Save(transactionManager, entity.GsCdeClrncItemFacCollection);
						
						deepHandles.Add("GsCdeClrncItemFacCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< GsCdeClrncItemFac >) DataRepository.GsCdeClrncItemFacProvider.DeepSave,
							new object[] { transactionManager, entity.GsCdeClrncItemFacCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<EdStudClrncItem>
				if (CanDeepSave(entity.EdStudClrncItemCollection, "List<EdStudClrncItem>|EdStudClrncItemCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(EdStudClrncItem child in entity.EdStudClrncItemCollection)
					{
						if(child.GsCdeClrncItemIdSource != null)
						{
							child.GsCdeClrncItemId = child.GsCdeClrncItemIdSource.GsCdeClrncItemId;
						}
						else
						{
							child.GsCdeClrncItemId = entity.GsCdeClrncItemId;
						}

					}

					if (entity.EdStudClrncItemCollection.Count > 0 || entity.EdStudClrncItemCollection.DeletedItems.Count > 0)
					{
						//DataRepository.EdStudClrncItemProvider.Save(transactionManager, entity.EdStudClrncItemCollection);
						
						deepHandles.Add("EdStudClrncItemCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< EdStudClrncItem >) DataRepository.EdStudClrncItemProvider.DeepSave,
							new object[] { transactionManager, entity.EdStudClrncItemCollection, deepSaveType, childTypes, innerList }
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
	
	#region GsCdeClrncItemChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.GsCdeClrncItem</c>
	///</summary>
	public enum GsCdeClrncItemChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>GsCdeClrncReason</c> at GsCdeClrncReasonIdSource
		///</summary>
		[ChildEntityType(typeof(GsCdeClrncReason))]
		GsCdeClrncReason,
		
		///<summary>
		/// Composite Property for <c>GsCodeGender</c> at GsCodeGenderIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeGender))]
		GsCodeGender,
		
		///<summary>
		/// Composite Property for <c>SeCodeUserType</c> at SeCodeUserTypeIdSource
		///</summary>
		[ChildEntityType(typeof(SeCodeUserType))]
		SeCodeUserType,
		///<summary>
		/// Collection of <c>GsCdeClrncItem</c> as OneToMany for GsCdeClrncItemFacCollection
		///</summary>
		[ChildEntityType(typeof(TList<GsCdeClrncItemFac>))]
		GsCdeClrncItemFacCollection,
		///<summary>
		/// Collection of <c>GsCdeClrncItem</c> as OneToMany for EdStudClrncItemCollection
		///</summary>
		[ChildEntityType(typeof(TList<EdStudClrncItem>))]
		EdStudClrncItemCollection,
	}
	
	#endregion GsCdeClrncItemChildEntityTypes
	
	#region GsCdeClrncItemFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;GsCdeClrncItemColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCdeClrncItem"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCdeClrncItemFilterBuilder : SqlFilterBuilder<GsCdeClrncItemColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCdeClrncItemFilterBuilder class.
		/// </summary>
		public GsCdeClrncItemFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCdeClrncItemFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCdeClrncItemFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCdeClrncItemFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCdeClrncItemFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCdeClrncItemFilterBuilder
	
	#region GsCdeClrncItemParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;GsCdeClrncItemColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCdeClrncItem"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GsCdeClrncItemParameterBuilder : ParameterizedSqlFilterBuilder<GsCdeClrncItemColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCdeClrncItemParameterBuilder class.
		/// </summary>
		public GsCdeClrncItemParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GsCdeClrncItemParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GsCdeClrncItemParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GsCdeClrncItemParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GsCdeClrncItemParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GsCdeClrncItemParameterBuilder
	
	#region GsCdeClrncItemSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;GsCdeClrncItemColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GsCdeClrncItem"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GsCdeClrncItemSortBuilder : SqlSortBuilder<GsCdeClrncItemColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GsCdeClrncItemSqlSortBuilder class.
		/// </summary>
		public GsCdeClrncItemSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GsCdeClrncItemSortBuilder
	
} // end namespace
