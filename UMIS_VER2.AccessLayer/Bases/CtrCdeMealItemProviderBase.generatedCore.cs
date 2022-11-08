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
	/// This class is the base class for any <see cref="CtrCdeMealItemProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class CtrCdeMealItemProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.CtrCdeMealItem, UMIS_VER2.BusinessLyer.CtrCdeMealItemKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CtrCdeMealItemKey key)
		{
			return Delete(transactionManager, key.CtrCdeMealItemId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_ctrCdeMealItemId">عناصر الطعام. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _ctrCdeMealItemId)
		{
			return Delete(null, _ctrCdeMealItemId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrCdeMealItemId">عناصر الطعام. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _ctrCdeMealItemId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_CDE_MEAL_ITEM_CTR_CDE_ITEM_TYPE key.
		///		FK_CTR_CDE_MEAL_ITEM_CTR_CDE_ITEM_TYPE Description: 
		/// </summary>
		/// <param name="_ctrCdeItemTypeId">نوع العنصر</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrCdeMealItem objects.</returns>
		public TList<CtrCdeMealItem> GetByCtrCdeItemTypeId(System.Decimal _ctrCdeItemTypeId)
		{
			int count = -1;
			return GetByCtrCdeItemTypeId(_ctrCdeItemTypeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_CDE_MEAL_ITEM_CTR_CDE_ITEM_TYPE key.
		///		FK_CTR_CDE_MEAL_ITEM_CTR_CDE_ITEM_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrCdeItemTypeId">نوع العنصر</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrCdeMealItem objects.</returns>
		/// <remarks></remarks>
		public TList<CtrCdeMealItem> GetByCtrCdeItemTypeId(TransactionManager transactionManager, System.Decimal _ctrCdeItemTypeId)
		{
			int count = -1;
			return GetByCtrCdeItemTypeId(transactionManager, _ctrCdeItemTypeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_CDE_MEAL_ITEM_CTR_CDE_ITEM_TYPE key.
		///		FK_CTR_CDE_MEAL_ITEM_CTR_CDE_ITEM_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrCdeItemTypeId">نوع العنصر</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrCdeMealItem objects.</returns>
		public TList<CtrCdeMealItem> GetByCtrCdeItemTypeId(TransactionManager transactionManager, System.Decimal _ctrCdeItemTypeId, int start, int pageLength)
		{
			int count = -1;
			return GetByCtrCdeItemTypeId(transactionManager, _ctrCdeItemTypeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_CDE_MEAL_ITEM_CTR_CDE_ITEM_TYPE key.
		///		fkCtrCdeMealItemCtrCdeItemType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_ctrCdeItemTypeId">نوع العنصر</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrCdeMealItem objects.</returns>
		public TList<CtrCdeMealItem> GetByCtrCdeItemTypeId(System.Decimal _ctrCdeItemTypeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByCtrCdeItemTypeId(null, _ctrCdeItemTypeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_CDE_MEAL_ITEM_CTR_CDE_ITEM_TYPE key.
		///		fkCtrCdeMealItemCtrCdeItemType Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_ctrCdeItemTypeId">نوع العنصر</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrCdeMealItem objects.</returns>
		public TList<CtrCdeMealItem> GetByCtrCdeItemTypeId(System.Decimal _ctrCdeItemTypeId, int start, int pageLength,out int count)
		{
			return GetByCtrCdeItemTypeId(null, _ctrCdeItemTypeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_CDE_MEAL_ITEM_CTR_CDE_ITEM_TYPE key.
		///		FK_CTR_CDE_MEAL_ITEM_CTR_CDE_ITEM_TYPE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrCdeItemTypeId">نوع العنصر</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrCdeMealItem objects.</returns>
		public abstract TList<CtrCdeMealItem> GetByCtrCdeItemTypeId(TransactionManager transactionManager, System.Decimal _ctrCdeItemTypeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_CDE_MEAL_ITEM_CTR_CDE_SRV_MTHD key.
		///		FK_CTR_CDE_MEAL_ITEM_CTR_CDE_SRV_MTHD Description: 
		/// </summary>
		/// <param name="_ctrCdeSrvMthdId">انواع تقديم</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrCdeMealItem objects.</returns>
		public TList<CtrCdeMealItem> GetByCtrCdeSrvMthdId(System.Decimal? _ctrCdeSrvMthdId)
		{
			int count = -1;
			return GetByCtrCdeSrvMthdId(_ctrCdeSrvMthdId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_CDE_MEAL_ITEM_CTR_CDE_SRV_MTHD key.
		///		FK_CTR_CDE_MEAL_ITEM_CTR_CDE_SRV_MTHD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrCdeSrvMthdId">انواع تقديم</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrCdeMealItem objects.</returns>
		/// <remarks></remarks>
		public TList<CtrCdeMealItem> GetByCtrCdeSrvMthdId(TransactionManager transactionManager, System.Decimal? _ctrCdeSrvMthdId)
		{
			int count = -1;
			return GetByCtrCdeSrvMthdId(transactionManager, _ctrCdeSrvMthdId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_CDE_MEAL_ITEM_CTR_CDE_SRV_MTHD key.
		///		FK_CTR_CDE_MEAL_ITEM_CTR_CDE_SRV_MTHD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrCdeSrvMthdId">انواع تقديم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrCdeMealItem objects.</returns>
		public TList<CtrCdeMealItem> GetByCtrCdeSrvMthdId(TransactionManager transactionManager, System.Decimal? _ctrCdeSrvMthdId, int start, int pageLength)
		{
			int count = -1;
			return GetByCtrCdeSrvMthdId(transactionManager, _ctrCdeSrvMthdId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_CDE_MEAL_ITEM_CTR_CDE_SRV_MTHD key.
		///		fkCtrCdeMealItemCtrCdeSrvMthd Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_ctrCdeSrvMthdId">انواع تقديم</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrCdeMealItem objects.</returns>
		public TList<CtrCdeMealItem> GetByCtrCdeSrvMthdId(System.Decimal? _ctrCdeSrvMthdId, int start, int pageLength)
		{
			int count =  -1;
			return GetByCtrCdeSrvMthdId(null, _ctrCdeSrvMthdId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_CDE_MEAL_ITEM_CTR_CDE_SRV_MTHD key.
		///		fkCtrCdeMealItemCtrCdeSrvMthd Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_ctrCdeSrvMthdId">انواع تقديم</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrCdeMealItem objects.</returns>
		public TList<CtrCdeMealItem> GetByCtrCdeSrvMthdId(System.Decimal? _ctrCdeSrvMthdId, int start, int pageLength,out int count)
		{
			return GetByCtrCdeSrvMthdId(null, _ctrCdeSrvMthdId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_CDE_MEAL_ITEM_CTR_CDE_SRV_MTHD key.
		///		FK_CTR_CDE_MEAL_ITEM_CTR_CDE_SRV_MTHD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrCdeSrvMthdId">انواع تقديم</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrCdeMealItem objects.</returns>
		public abstract TList<CtrCdeMealItem> GetByCtrCdeSrvMthdId(TransactionManager transactionManager, System.Decimal? _ctrCdeSrvMthdId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_CDE_MEAL_ITEM_CTR_CDE_UNIT key.
		///		FK_CTR_CDE_MEAL_ITEM_CTR_CDE_UNIT Description: 
		/// </summary>
		/// <param name="_ctrCdeUnitId">اكواد وحدات الصرف</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrCdeMealItem objects.</returns>
		public TList<CtrCdeMealItem> GetByCtrCdeUnitId(System.Decimal? _ctrCdeUnitId)
		{
			int count = -1;
			return GetByCtrCdeUnitId(_ctrCdeUnitId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_CDE_MEAL_ITEM_CTR_CDE_UNIT key.
		///		FK_CTR_CDE_MEAL_ITEM_CTR_CDE_UNIT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrCdeUnitId">اكواد وحدات الصرف</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrCdeMealItem objects.</returns>
		/// <remarks></remarks>
		public TList<CtrCdeMealItem> GetByCtrCdeUnitId(TransactionManager transactionManager, System.Decimal? _ctrCdeUnitId)
		{
			int count = -1;
			return GetByCtrCdeUnitId(transactionManager, _ctrCdeUnitId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_CDE_MEAL_ITEM_CTR_CDE_UNIT key.
		///		FK_CTR_CDE_MEAL_ITEM_CTR_CDE_UNIT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrCdeUnitId">اكواد وحدات الصرف</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrCdeMealItem objects.</returns>
		public TList<CtrCdeMealItem> GetByCtrCdeUnitId(TransactionManager transactionManager, System.Decimal? _ctrCdeUnitId, int start, int pageLength)
		{
			int count = -1;
			return GetByCtrCdeUnitId(transactionManager, _ctrCdeUnitId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_CDE_MEAL_ITEM_CTR_CDE_UNIT key.
		///		fkCtrCdeMealItemCtrCdeUnit Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_ctrCdeUnitId">اكواد وحدات الصرف</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrCdeMealItem objects.</returns>
		public TList<CtrCdeMealItem> GetByCtrCdeUnitId(System.Decimal? _ctrCdeUnitId, int start, int pageLength)
		{
			int count =  -1;
			return GetByCtrCdeUnitId(null, _ctrCdeUnitId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_CDE_MEAL_ITEM_CTR_CDE_UNIT key.
		///		fkCtrCdeMealItemCtrCdeUnit Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_ctrCdeUnitId">اكواد وحدات الصرف</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrCdeMealItem objects.</returns>
		public TList<CtrCdeMealItem> GetByCtrCdeUnitId(System.Decimal? _ctrCdeUnitId, int start, int pageLength,out int count)
		{
			return GetByCtrCdeUnitId(null, _ctrCdeUnitId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_CTR_CDE_MEAL_ITEM_CTR_CDE_UNIT key.
		///		FK_CTR_CDE_MEAL_ITEM_CTR_CDE_UNIT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrCdeUnitId">اكواد وحدات الصرف</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.CtrCdeMealItem objects.</returns>
		public abstract TList<CtrCdeMealItem> GetByCtrCdeUnitId(TransactionManager transactionManager, System.Decimal? _ctrCdeUnitId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.CtrCdeMealItem Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CtrCdeMealItemKey key, int start, int pageLength)
		{
			return GetByCtrCdeMealItemId(transactionManager, key.CtrCdeMealItemId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_CTR_CDE_MEAL_ITEM index.
		/// </summary>
		/// <param name="_ctrCdeMealItemId">عناصر الطعام</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeMealItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeMealItem GetByCtrCdeMealItemId(System.Decimal _ctrCdeMealItemId)
		{
			int count = -1;
			return GetByCtrCdeMealItemId(null,_ctrCdeMealItemId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_CDE_MEAL_ITEM index.
		/// </summary>
		/// <param name="_ctrCdeMealItemId">عناصر الطعام</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeMealItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeMealItem GetByCtrCdeMealItemId(System.Decimal _ctrCdeMealItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByCtrCdeMealItemId(null, _ctrCdeMealItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_CDE_MEAL_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrCdeMealItemId">عناصر الطعام</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeMealItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeMealItem GetByCtrCdeMealItemId(TransactionManager transactionManager, System.Decimal _ctrCdeMealItemId)
		{
			int count = -1;
			return GetByCtrCdeMealItemId(transactionManager, _ctrCdeMealItemId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_CDE_MEAL_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrCdeMealItemId">عناصر الطعام</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeMealItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeMealItem GetByCtrCdeMealItemId(TransactionManager transactionManager, System.Decimal _ctrCdeMealItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByCtrCdeMealItemId(transactionManager, _ctrCdeMealItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_CDE_MEAL_ITEM index.
		/// </summary>
		/// <param name="_ctrCdeMealItemId">عناصر الطعام</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeMealItem"/> class.</returns>
		public UMIS_VER2.BusinessLyer.CtrCdeMealItem GetByCtrCdeMealItemId(System.Decimal _ctrCdeMealItemId, int start, int pageLength, out int count)
		{
			return GetByCtrCdeMealItemId(null, _ctrCdeMealItemId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_CTR_CDE_MEAL_ITEM index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_ctrCdeMealItemId">عناصر الطعام</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.CtrCdeMealItem"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.CtrCdeMealItem GetByCtrCdeMealItemId(TransactionManager transactionManager, System.Decimal _ctrCdeMealItemId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;CtrCdeMealItem&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;CtrCdeMealItem&gt;"/></returns>
		public static TList<CtrCdeMealItem> Fill(IDataReader reader, TList<CtrCdeMealItem> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.CtrCdeMealItem c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("CtrCdeMealItem")
					.Append("|").Append((System.Decimal)reader["CTR_CDE_MEAL_ITEM_ID"]).ToString();
					c = EntityManager.LocateOrCreate<CtrCdeMealItem>(
					key.ToString(), // EntityTrackingKey
					"CtrCdeMealItem",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.CtrCdeMealItem();
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
					c.CtrCdeMealItemId = (System.Decimal)reader["CTR_CDE_MEAL_ITEM_ID"];
					c.OriginalCtrCdeMealItemId = c.CtrCdeMealItemId;
					c.CtrCdeItemTypeId = (System.Decimal)reader["CTR_CDE_ITEM_TYPE_ID"];
					c.MealItemAr = (System.String)reader["MEAL_ITEM_AR"];
					c.MealItemEn = (System.String)reader["MEAL_ITEM_EN"];
					c.ItemCal = Convert.IsDBNull(reader["ITEM_CAL"]) ? null : (System.Decimal?)reader["ITEM_CAL"];
					c.CtrCdeUnitId = Convert.IsDBNull(reader["CTR_CDE_UNIT_ID"]) ? null : (System.Decimal?)reader["CTR_CDE_UNIT_ID"];
					c.CtrCdeSrvMthdId = Convert.IsDBNull(reader["CTR_CDE_SRV_MTHD_ID"]) ? null : (System.Decimal?)reader["CTR_CDE_SRV_MTHD_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.CtrCdeMealItem"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CtrCdeMealItem"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.CtrCdeMealItem entity)
		{
			if (!reader.Read()) return;
			
			entity.CtrCdeMealItemId = (System.Decimal)reader[((int)CtrCdeMealItemColumn.CtrCdeMealItemId - 1)];
			entity.OriginalCtrCdeMealItemId = (System.Decimal)reader["CTR_CDE_MEAL_ITEM_ID"];
			entity.CtrCdeItemTypeId = (System.Decimal)reader[((int)CtrCdeMealItemColumn.CtrCdeItemTypeId - 1)];
			entity.MealItemAr = (System.String)reader[((int)CtrCdeMealItemColumn.MealItemAr - 1)];
			entity.MealItemEn = (System.String)reader[((int)CtrCdeMealItemColumn.MealItemEn - 1)];
			entity.ItemCal = (reader.IsDBNull(((int)CtrCdeMealItemColumn.ItemCal - 1)))?null:(System.Decimal?)reader[((int)CtrCdeMealItemColumn.ItemCal - 1)];
			entity.CtrCdeUnitId = (reader.IsDBNull(((int)CtrCdeMealItemColumn.CtrCdeUnitId - 1)))?null:(System.Decimal?)reader[((int)CtrCdeMealItemColumn.CtrCdeUnitId - 1)];
			entity.CtrCdeSrvMthdId = (reader.IsDBNull(((int)CtrCdeMealItemColumn.CtrCdeSrvMthdId - 1)))?null:(System.Decimal?)reader[((int)CtrCdeMealItemColumn.CtrCdeSrvMthdId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.CtrCdeMealItem"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CtrCdeMealItem"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.CtrCdeMealItem entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.CtrCdeMealItemId = (System.Decimal)dataRow["CTR_CDE_MEAL_ITEM_ID"];
			entity.OriginalCtrCdeMealItemId = (System.Decimal)dataRow["CTR_CDE_MEAL_ITEM_ID"];
			entity.CtrCdeItemTypeId = (System.Decimal)dataRow["CTR_CDE_ITEM_TYPE_ID"];
			entity.MealItemAr = (System.String)dataRow["MEAL_ITEM_AR"];
			entity.MealItemEn = (System.String)dataRow["MEAL_ITEM_EN"];
			entity.ItemCal = Convert.IsDBNull(dataRow["ITEM_CAL"]) ? null : (System.Decimal?)dataRow["ITEM_CAL"];
			entity.CtrCdeUnitId = Convert.IsDBNull(dataRow["CTR_CDE_UNIT_ID"]) ? null : (System.Decimal?)dataRow["CTR_CDE_UNIT_ID"];
			entity.CtrCdeSrvMthdId = Convert.IsDBNull(dataRow["CTR_CDE_SRV_MTHD_ID"]) ? null : (System.Decimal?)dataRow["CTR_CDE_SRV_MTHD_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.CtrCdeMealItem"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.CtrCdeMealItem Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CtrCdeMealItem entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region CtrCdeItemTypeIdSource	
			if (CanDeepLoad(entity, "CtrCdeItemType|CtrCdeItemTypeIdSource", deepLoadType, innerList) 
				&& entity.CtrCdeItemTypeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.CtrCdeItemTypeId;
				CtrCdeItemType tmpEntity = EntityManager.LocateEntity<CtrCdeItemType>(EntityLocator.ConstructKeyFromPkItems(typeof(CtrCdeItemType), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.CtrCdeItemTypeIdSource = tmpEntity;
				else
					entity.CtrCdeItemTypeIdSource = DataRepository.CtrCdeItemTypeProvider.GetByCtrCdeItemTypeId(transactionManager, entity.CtrCdeItemTypeId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CtrCdeItemTypeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.CtrCdeItemTypeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.CtrCdeItemTypeProvider.DeepLoad(transactionManager, entity.CtrCdeItemTypeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion CtrCdeItemTypeIdSource

			#region CtrCdeSrvMthdIdSource	
			if (CanDeepLoad(entity, "CtrCdeSrvMthd|CtrCdeSrvMthdIdSource", deepLoadType, innerList) 
				&& entity.CtrCdeSrvMthdIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.CtrCdeSrvMthdId ?? 0.0m);
				CtrCdeSrvMthd tmpEntity = EntityManager.LocateEntity<CtrCdeSrvMthd>(EntityLocator.ConstructKeyFromPkItems(typeof(CtrCdeSrvMthd), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.CtrCdeSrvMthdIdSource = tmpEntity;
				else
					entity.CtrCdeSrvMthdIdSource = DataRepository.CtrCdeSrvMthdProvider.GetByCtrCdeSrvMthdId(transactionManager, (entity.CtrCdeSrvMthdId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CtrCdeSrvMthdIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.CtrCdeSrvMthdIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.CtrCdeSrvMthdProvider.DeepLoad(transactionManager, entity.CtrCdeSrvMthdIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion CtrCdeSrvMthdIdSource

			#region CtrCdeUnitIdSource	
			if (CanDeepLoad(entity, "CtrCdeUnit|CtrCdeUnitIdSource", deepLoadType, innerList) 
				&& entity.CtrCdeUnitIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.CtrCdeUnitId ?? 0.0m);
				CtrCdeUnit tmpEntity = EntityManager.LocateEntity<CtrCdeUnit>(EntityLocator.ConstructKeyFromPkItems(typeof(CtrCdeUnit), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.CtrCdeUnitIdSource = tmpEntity;
				else
					entity.CtrCdeUnitIdSource = DataRepository.CtrCdeUnitProvider.GetByCtrCdeUnitId(transactionManager, (entity.CtrCdeUnitId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CtrCdeUnitIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.CtrCdeUnitIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.CtrCdeUnitProvider.DeepLoad(transactionManager, entity.CtrCdeUnitIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion CtrCdeUnitIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByCtrCdeMealItemId methods when available
			
			#region CtrMenuActItemCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<CtrMenuActItem>|CtrMenuActItemCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CtrMenuActItemCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.CtrMenuActItemCollection = DataRepository.CtrMenuActItemProvider.GetByCtrCdeMealItemId(transactionManager, entity.CtrCdeMealItemId);

				if (deep && entity.CtrMenuActItemCollection.Count > 0)
				{
					deepHandles.Add("CtrMenuActItemCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CtrMenuActItem>) DataRepository.CtrMenuActItemProvider.DeepLoad,
						new object[] { transactionManager, entity.CtrMenuActItemCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region CtrMealItemCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<CtrMealItem>|CtrMealItemCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CtrMealItemCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.CtrMealItemCollection = DataRepository.CtrMealItemProvider.GetByCtrCdeMealItemId(transactionManager, entity.CtrCdeMealItemId);

				if (deep && entity.CtrMealItemCollection.Count > 0)
				{
					deepHandles.Add("CtrMealItemCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CtrMealItem>) DataRepository.CtrMealItemProvider.DeepLoad,
						new object[] { transactionManager, entity.CtrMealItemCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region CtrMenuItemCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<CtrMenuItem>|CtrMenuItemCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CtrMenuItemCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.CtrMenuItemCollection = DataRepository.CtrMenuItemProvider.GetByCtrCdeMealItemId(transactionManager, entity.CtrCdeMealItemId);

				if (deep && entity.CtrMenuItemCollection.Count > 0)
				{
					deepHandles.Add("CtrMenuItemCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CtrMenuItem>) DataRepository.CtrMenuItemProvider.DeepLoad,
						new object[] { transactionManager, entity.CtrMenuItemCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.CtrCdeMealItem object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.CtrCdeMealItem instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.CtrCdeMealItem Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.CtrCdeMealItem entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region CtrCdeItemTypeIdSource
			if (CanDeepSave(entity, "CtrCdeItemType|CtrCdeItemTypeIdSource", deepSaveType, innerList) 
				&& entity.CtrCdeItemTypeIdSource != null)
			{
				DataRepository.CtrCdeItemTypeProvider.Save(transactionManager, entity.CtrCdeItemTypeIdSource);
				entity.CtrCdeItemTypeId = entity.CtrCdeItemTypeIdSource.CtrCdeItemTypeId;
			}
			#endregion 
			
			#region CtrCdeSrvMthdIdSource
			if (CanDeepSave(entity, "CtrCdeSrvMthd|CtrCdeSrvMthdIdSource", deepSaveType, innerList) 
				&& entity.CtrCdeSrvMthdIdSource != null)
			{
				DataRepository.CtrCdeSrvMthdProvider.Save(transactionManager, entity.CtrCdeSrvMthdIdSource);
				entity.CtrCdeSrvMthdId = entity.CtrCdeSrvMthdIdSource.CtrCdeSrvMthdId;
			}
			#endregion 
			
			#region CtrCdeUnitIdSource
			if (CanDeepSave(entity, "CtrCdeUnit|CtrCdeUnitIdSource", deepSaveType, innerList) 
				&& entity.CtrCdeUnitIdSource != null)
			{
				DataRepository.CtrCdeUnitProvider.Save(transactionManager, entity.CtrCdeUnitIdSource);
				entity.CtrCdeUnitId = entity.CtrCdeUnitIdSource.CtrCdeUnitId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<CtrMenuActItem>
				if (CanDeepSave(entity.CtrMenuActItemCollection, "List<CtrMenuActItem>|CtrMenuActItemCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CtrMenuActItem child in entity.CtrMenuActItemCollection)
					{
						if(child.CtrCdeMealItemIdSource != null)
						{
							child.CtrCdeMealItemId = child.CtrCdeMealItemIdSource.CtrCdeMealItemId;
						}
						else
						{
							child.CtrCdeMealItemId = entity.CtrCdeMealItemId;
						}

					}

					if (entity.CtrMenuActItemCollection.Count > 0 || entity.CtrMenuActItemCollection.DeletedItems.Count > 0)
					{
						//DataRepository.CtrMenuActItemProvider.Save(transactionManager, entity.CtrMenuActItemCollection);
						
						deepHandles.Add("CtrMenuActItemCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< CtrMenuActItem >) DataRepository.CtrMenuActItemProvider.DeepSave,
							new object[] { transactionManager, entity.CtrMenuActItemCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<CtrMealItem>
				if (CanDeepSave(entity.CtrMealItemCollection, "List<CtrMealItem>|CtrMealItemCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CtrMealItem child in entity.CtrMealItemCollection)
					{
						if(child.CtrCdeMealItemIdSource != null)
						{
							child.CtrCdeMealItemId = child.CtrCdeMealItemIdSource.CtrCdeMealItemId;
						}
						else
						{
							child.CtrCdeMealItemId = entity.CtrCdeMealItemId;
						}

					}

					if (entity.CtrMealItemCollection.Count > 0 || entity.CtrMealItemCollection.DeletedItems.Count > 0)
					{
						//DataRepository.CtrMealItemProvider.Save(transactionManager, entity.CtrMealItemCollection);
						
						deepHandles.Add("CtrMealItemCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< CtrMealItem >) DataRepository.CtrMealItemProvider.DeepSave,
							new object[] { transactionManager, entity.CtrMealItemCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<CtrMenuItem>
				if (CanDeepSave(entity.CtrMenuItemCollection, "List<CtrMenuItem>|CtrMenuItemCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CtrMenuItem child in entity.CtrMenuItemCollection)
					{
						if(child.CtrCdeMealItemIdSource != null)
						{
							child.CtrCdeMealItemId = child.CtrCdeMealItemIdSource.CtrCdeMealItemId;
						}
						else
						{
							child.CtrCdeMealItemId = entity.CtrCdeMealItemId;
						}

					}

					if (entity.CtrMenuItemCollection.Count > 0 || entity.CtrMenuItemCollection.DeletedItems.Count > 0)
					{
						//DataRepository.CtrMenuItemProvider.Save(transactionManager, entity.CtrMenuItemCollection);
						
						deepHandles.Add("CtrMenuItemCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< CtrMenuItem >) DataRepository.CtrMenuItemProvider.DeepSave,
							new object[] { transactionManager, entity.CtrMenuItemCollection, deepSaveType, childTypes, innerList }
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
	
	#region CtrCdeMealItemChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.CtrCdeMealItem</c>
	///</summary>
	public enum CtrCdeMealItemChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>CtrCdeItemType</c> at CtrCdeItemTypeIdSource
		///</summary>
		[ChildEntityType(typeof(CtrCdeItemType))]
		CtrCdeItemType,
		
		///<summary>
		/// Composite Property for <c>CtrCdeSrvMthd</c> at CtrCdeSrvMthdIdSource
		///</summary>
		[ChildEntityType(typeof(CtrCdeSrvMthd))]
		CtrCdeSrvMthd,
		
		///<summary>
		/// Composite Property for <c>CtrCdeUnit</c> at CtrCdeUnitIdSource
		///</summary>
		[ChildEntityType(typeof(CtrCdeUnit))]
		CtrCdeUnit,
		///<summary>
		/// Collection of <c>CtrCdeMealItem</c> as OneToMany for CtrMenuActItemCollection
		///</summary>
		[ChildEntityType(typeof(TList<CtrMenuActItem>))]
		CtrMenuActItemCollection,
		///<summary>
		/// Collection of <c>CtrCdeMealItem</c> as OneToMany for CtrMealItemCollection
		///</summary>
		[ChildEntityType(typeof(TList<CtrMealItem>))]
		CtrMealItemCollection,
		///<summary>
		/// Collection of <c>CtrCdeMealItem</c> as OneToMany for CtrMenuItemCollection
		///</summary>
		[ChildEntityType(typeof(TList<CtrMenuItem>))]
		CtrMenuItemCollection,
	}
	
	#endregion CtrCdeMealItemChildEntityTypes
	
	#region CtrCdeMealItemFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;CtrCdeMealItemColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CtrCdeMealItem"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CtrCdeMealItemFilterBuilder : SqlFilterBuilder<CtrCdeMealItemColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CtrCdeMealItemFilterBuilder class.
		/// </summary>
		public CtrCdeMealItemFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CtrCdeMealItemFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CtrCdeMealItemFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CtrCdeMealItemFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CtrCdeMealItemFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CtrCdeMealItemFilterBuilder
	
	#region CtrCdeMealItemParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;CtrCdeMealItemColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CtrCdeMealItem"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CtrCdeMealItemParameterBuilder : ParameterizedSqlFilterBuilder<CtrCdeMealItemColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CtrCdeMealItemParameterBuilder class.
		/// </summary>
		public CtrCdeMealItemParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CtrCdeMealItemParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CtrCdeMealItemParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CtrCdeMealItemParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CtrCdeMealItemParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CtrCdeMealItemParameterBuilder
	
	#region CtrCdeMealItemSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;CtrCdeMealItemColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CtrCdeMealItem"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class CtrCdeMealItemSortBuilder : SqlSortBuilder<CtrCdeMealItemColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CtrCdeMealItemSqlSortBuilder class.
		/// </summary>
		public CtrCdeMealItemSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion CtrCdeMealItemSortBuilder
	
} // end namespace
