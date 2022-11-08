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
	/// This class is the base class for any <see cref="FeeUserFundReqProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class FeeUserFundReqProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.FeeUserFundReq, UMIS_VER2.BusinessLyer.FeeUserFundReqKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeUserFundReqKey key)
		{
			return Delete(transactionManager, key.FeeUserFundReqId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_feeUserFundReqId">طلبات السلف. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _feeUserFundReqId)
		{
			return Delete(null, _feeUserFundReqId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeUserFundReqId">طلبات السلف. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _feeUserFundReqId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_USER_FUND_REQ_ED_ACAD_YEAR key.
		///		FK_FEE_USER_FUND_REQ_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeUserFundReq objects.</returns>
		public TList<FeeUserFundReq> GetByEdAcadYearId(System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(_edAcadYearId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_USER_FUND_REQ_ED_ACAD_YEAR key.
		///		FK_FEE_USER_FUND_REQ_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeUserFundReq objects.</returns>
		/// <remarks></remarks>
		public TList<FeeUserFundReq> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_USER_FUND_REQ_ED_ACAD_YEAR key.
		///		FK_FEE_USER_FUND_REQ_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeUserFundReq objects.</returns>
		public TList<FeeUserFundReq> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_USER_FUND_REQ_ED_ACAD_YEAR key.
		///		fkFeeUserFundReqEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeUserFundReq objects.</returns>
		public TList<FeeUserFundReq> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_USER_FUND_REQ_ED_ACAD_YEAR key.
		///		fkFeeUserFundReqEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeUserFundReq objects.</returns>
		public TList<FeeUserFundReq> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_USER_FUND_REQ_ED_ACAD_YEAR key.
		///		FK_FEE_USER_FUND_REQ_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeUserFundReq objects.</returns>
		public abstract TList<FeeUserFundReq> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_USER_FUND_REQ_FEE_CDE_BOND_ITEM key.
		///		FK_FEE_USER_FUND_REQ_FEE_CDE_BOND_ITEM Description: 
		/// </summary>
		/// <param name="_feeCdeBondItemId">بند السند</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeUserFundReq objects.</returns>
		public TList<FeeUserFundReq> GetByFeeCdeBondItemId(System.Int32 _feeCdeBondItemId)
		{
			int count = -1;
			return GetByFeeCdeBondItemId(_feeCdeBondItemId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_USER_FUND_REQ_FEE_CDE_BOND_ITEM key.
		///		FK_FEE_USER_FUND_REQ_FEE_CDE_BOND_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeBondItemId">بند السند</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeUserFundReq objects.</returns>
		/// <remarks></remarks>
		public TList<FeeUserFundReq> GetByFeeCdeBondItemId(TransactionManager transactionManager, System.Int32 _feeCdeBondItemId)
		{
			int count = -1;
			return GetByFeeCdeBondItemId(transactionManager, _feeCdeBondItemId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_USER_FUND_REQ_FEE_CDE_BOND_ITEM key.
		///		FK_FEE_USER_FUND_REQ_FEE_CDE_BOND_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeBondItemId">بند السند</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeUserFundReq objects.</returns>
		public TList<FeeUserFundReq> GetByFeeCdeBondItemId(TransactionManager transactionManager, System.Int32 _feeCdeBondItemId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCdeBondItemId(transactionManager, _feeCdeBondItemId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_USER_FUND_REQ_FEE_CDE_BOND_ITEM key.
		///		fkFeeUserFundReqFeeCdeBondItem Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeCdeBondItemId">بند السند</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeUserFundReq objects.</returns>
		public TList<FeeUserFundReq> GetByFeeCdeBondItemId(System.Int32 _feeCdeBondItemId, int start, int pageLength)
		{
			int count =  -1;
			return GetByFeeCdeBondItemId(null, _feeCdeBondItemId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_USER_FUND_REQ_FEE_CDE_BOND_ITEM key.
		///		fkFeeUserFundReqFeeCdeBondItem Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeCdeBondItemId">بند السند</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeUserFundReq objects.</returns>
		public TList<FeeUserFundReq> GetByFeeCdeBondItemId(System.Int32 _feeCdeBondItemId, int start, int pageLength,out int count)
		{
			return GetByFeeCdeBondItemId(null, _feeCdeBondItemId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_USER_FUND_REQ_FEE_CDE_BOND_ITEM key.
		///		FK_FEE_USER_FUND_REQ_FEE_CDE_BOND_ITEM Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeBondItemId">بند السند</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeUserFundReq objects.</returns>
		public abstract TList<FeeUserFundReq> GetByFeeCdeBondItemId(TransactionManager transactionManager, System.Int32 _feeCdeBondItemId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_USER_FUND_REQ_GS_CODE_CURRENCY key.
		///		FK_FEE_USER_FUND_REQ_GS_CODE_CURRENCY Description: 
		/// </summary>
		/// <param name="_gsCodeCurrencyId">العملة الحالية</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeUserFundReq objects.</returns>
		public TList<FeeUserFundReq> GetByGsCodeCurrencyId(System.Decimal _gsCodeCurrencyId)
		{
			int count = -1;
			return GetByGsCodeCurrencyId(_gsCodeCurrencyId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_USER_FUND_REQ_GS_CODE_CURRENCY key.
		///		FK_FEE_USER_FUND_REQ_GS_CODE_CURRENCY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeCurrencyId">العملة الحالية</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeUserFundReq objects.</returns>
		/// <remarks></remarks>
		public TList<FeeUserFundReq> GetByGsCodeCurrencyId(TransactionManager transactionManager, System.Decimal _gsCodeCurrencyId)
		{
			int count = -1;
			return GetByGsCodeCurrencyId(transactionManager, _gsCodeCurrencyId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_USER_FUND_REQ_GS_CODE_CURRENCY key.
		///		FK_FEE_USER_FUND_REQ_GS_CODE_CURRENCY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeCurrencyId">العملة الحالية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeUserFundReq objects.</returns>
		public TList<FeeUserFundReq> GetByGsCodeCurrencyId(TransactionManager transactionManager, System.Decimal _gsCodeCurrencyId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeCurrencyId(transactionManager, _gsCodeCurrencyId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_USER_FUND_REQ_GS_CODE_CURRENCY key.
		///		fkFeeUserFundReqGsCodeCurrency Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeCurrencyId">العملة الحالية</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeUserFundReq objects.</returns>
		public TList<FeeUserFundReq> GetByGsCodeCurrencyId(System.Decimal _gsCodeCurrencyId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodeCurrencyId(null, _gsCodeCurrencyId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_USER_FUND_REQ_GS_CODE_CURRENCY key.
		///		fkFeeUserFundReqGsCodeCurrency Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeCurrencyId">العملة الحالية</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeUserFundReq objects.</returns>
		public TList<FeeUserFundReq> GetByGsCodeCurrencyId(System.Decimal _gsCodeCurrencyId, int start, int pageLength,out int count)
		{
			return GetByGsCodeCurrencyId(null, _gsCodeCurrencyId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_USER_FUND_REQ_GS_CODE_CURRENCY key.
		///		FK_FEE_USER_FUND_REQ_GS_CODE_CURRENCY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeCurrencyId">العملة الحالية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeUserFundReq objects.</returns>
		public abstract TList<FeeUserFundReq> GetByGsCodeCurrencyId(TransactionManager transactionManager, System.Decimal _gsCodeCurrencyId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.FeeUserFundReq Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeUserFundReqKey key, int start, int pageLength)
		{
			return GetByFeeUserFundReqId(transactionManager, key.FeeUserFundReqId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_FEE_USER_FUND_REQ index.
		/// </summary>
		/// <param name="_feeUserFundReqId">طلبات السلف</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeUserFundReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeUserFundReq GetByFeeUserFundReqId(System.Decimal _feeUserFundReqId)
		{
			int count = -1;
			return GetByFeeUserFundReqId(null,_feeUserFundReqId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_USER_FUND_REQ index.
		/// </summary>
		/// <param name="_feeUserFundReqId">طلبات السلف</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeUserFundReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeUserFundReq GetByFeeUserFundReqId(System.Decimal _feeUserFundReqId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeUserFundReqId(null, _feeUserFundReqId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_USER_FUND_REQ index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeUserFundReqId">طلبات السلف</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeUserFundReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeUserFundReq GetByFeeUserFundReqId(TransactionManager transactionManager, System.Decimal _feeUserFundReqId)
		{
			int count = -1;
			return GetByFeeUserFundReqId(transactionManager, _feeUserFundReqId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_USER_FUND_REQ index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeUserFundReqId">طلبات السلف</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeUserFundReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeUserFundReq GetByFeeUserFundReqId(TransactionManager transactionManager, System.Decimal _feeUserFundReqId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeUserFundReqId(transactionManager, _feeUserFundReqId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_USER_FUND_REQ index.
		/// </summary>
		/// <param name="_feeUserFundReqId">طلبات السلف</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeUserFundReq"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeUserFundReq GetByFeeUserFundReqId(System.Decimal _feeUserFundReqId, int start, int pageLength, out int count)
		{
			return GetByFeeUserFundReqId(null, _feeUserFundReqId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_USER_FUND_REQ index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeUserFundReqId">طلبات السلف</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeUserFundReq"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.FeeUserFundReq GetByFeeUserFundReqId(TransactionManager transactionManager, System.Decimal _feeUserFundReqId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;FeeUserFundReq&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;FeeUserFundReq&gt;"/></returns>
		public static TList<FeeUserFundReq> Fill(IDataReader reader, TList<FeeUserFundReq> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.FeeUserFundReq c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("FeeUserFundReq")
					.Append("|").Append((System.Decimal)reader["FEE_USER_FUND_REQ_ID"]).ToString();
					c = EntityManager.LocateOrCreate<FeeUserFundReq>(
					key.ToString(), // EntityTrackingKey
					"FeeUserFundReq",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.FeeUserFundReq();
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
					c.FeeUserFundReqId = (System.Decimal)reader["FEE_USER_FUND_REQ_ID"];
					c.OriginalFeeUserFundReqId = c.FeeUserFundReqId;
					c.EdAcadYearId = (System.Decimal)reader["ED_ACAD_YEAR_ID"];
					c.ReqNum = (System.Decimal)reader["REQ_NUM"];
					c.ReqDate = (System.DateTime)reader["REQ_DATE"];
					c.UserName = (System.String)reader["USER_NAME"];
					c.FeeCdeBondItemId = (System.Int32)reader["FEE_CDE_BOND_ITEM_ID"];
					c.GsCodeCurrencyId = (System.Decimal)reader["GS_CODE_CURRENCY_ID"];
					c.TempAmount = Convert.IsDBNull(reader["TEMP_AMOUNT"]) ? null : (System.Decimal?)reader["TEMP_AMOUNT"];
					c.ReqAmount = Convert.IsDBNull(reader["REQ_AMOUNT"]) ? null : (System.Decimal?)reader["REQ_AMOUNT"];
					c.RemainAmount = Convert.IsDBNull(reader["REMAIN_AMOUNT"]) ? null : (System.Decimal?)reader["REMAIN_AMOUNT"];
					c.AttchdDocPath = Convert.IsDBNull(reader["ATTCHD_DOC_PATH"]) ? null : (System.String)reader["ATTCHD_DOC_PATH"];
					c.Notes = Convert.IsDBNull(reader["NOTES"]) ? null : (System.String)reader["NOTES"];
					c.ApproveFlg = Convert.IsDBNull(reader["APPROVE_FLG"]) ? null : (System.Int32?)reader["APPROVE_FLG"];
					c.ApproveDate = Convert.IsDBNull(reader["APPROVE_DATE"]) ? null : (System.DateTime?)reader["APPROVE_DATE"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeUserFundReq"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeUserFundReq"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.FeeUserFundReq entity)
		{
			if (!reader.Read()) return;
			
			entity.FeeUserFundReqId = (System.Decimal)reader[((int)FeeUserFundReqColumn.FeeUserFundReqId - 1)];
			entity.OriginalFeeUserFundReqId = (System.Decimal)reader["FEE_USER_FUND_REQ_ID"];
			entity.EdAcadYearId = (System.Decimal)reader[((int)FeeUserFundReqColumn.EdAcadYearId - 1)];
			entity.ReqNum = (System.Decimal)reader[((int)FeeUserFundReqColumn.ReqNum - 1)];
			entity.ReqDate = (System.DateTime)reader[((int)FeeUserFundReqColumn.ReqDate - 1)];
			entity.UserName = (System.String)reader[((int)FeeUserFundReqColumn.UserName - 1)];
			entity.FeeCdeBondItemId = (System.Int32)reader[((int)FeeUserFundReqColumn.FeeCdeBondItemId - 1)];
			entity.GsCodeCurrencyId = (System.Decimal)reader[((int)FeeUserFundReqColumn.GsCodeCurrencyId - 1)];
			entity.TempAmount = (reader.IsDBNull(((int)FeeUserFundReqColumn.TempAmount - 1)))?null:(System.Decimal?)reader[((int)FeeUserFundReqColumn.TempAmount - 1)];
			entity.ReqAmount = (reader.IsDBNull(((int)FeeUserFundReqColumn.ReqAmount - 1)))?null:(System.Decimal?)reader[((int)FeeUserFundReqColumn.ReqAmount - 1)];
			entity.RemainAmount = (reader.IsDBNull(((int)FeeUserFundReqColumn.RemainAmount - 1)))?null:(System.Decimal?)reader[((int)FeeUserFundReqColumn.RemainAmount - 1)];
			entity.AttchdDocPath = (reader.IsDBNull(((int)FeeUserFundReqColumn.AttchdDocPath - 1)))?null:(System.String)reader[((int)FeeUserFundReqColumn.AttchdDocPath - 1)];
			entity.Notes = (reader.IsDBNull(((int)FeeUserFundReqColumn.Notes - 1)))?null:(System.String)reader[((int)FeeUserFundReqColumn.Notes - 1)];
			entity.ApproveFlg = (reader.IsDBNull(((int)FeeUserFundReqColumn.ApproveFlg - 1)))?null:(System.Int32?)reader[((int)FeeUserFundReqColumn.ApproveFlg - 1)];
			entity.ApproveDate = (reader.IsDBNull(((int)FeeUserFundReqColumn.ApproveDate - 1)))?null:(System.DateTime?)reader[((int)FeeUserFundReqColumn.ApproveDate - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)FeeUserFundReqColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)FeeUserFundReqColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)FeeUserFundReqColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)FeeUserFundReqColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeUserFundReq"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeUserFundReq"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.FeeUserFundReq entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.FeeUserFundReqId = (System.Decimal)dataRow["FEE_USER_FUND_REQ_ID"];
			entity.OriginalFeeUserFundReqId = (System.Decimal)dataRow["FEE_USER_FUND_REQ_ID"];
			entity.EdAcadYearId = (System.Decimal)dataRow["ED_ACAD_YEAR_ID"];
			entity.ReqNum = (System.Decimal)dataRow["REQ_NUM"];
			entity.ReqDate = (System.DateTime)dataRow["REQ_DATE"];
			entity.UserName = (System.String)dataRow["USER_NAME"];
			entity.FeeCdeBondItemId = (System.Int32)dataRow["FEE_CDE_BOND_ITEM_ID"];
			entity.GsCodeCurrencyId = (System.Decimal)dataRow["GS_CODE_CURRENCY_ID"];
			entity.TempAmount = Convert.IsDBNull(dataRow["TEMP_AMOUNT"]) ? null : (System.Decimal?)dataRow["TEMP_AMOUNT"];
			entity.ReqAmount = Convert.IsDBNull(dataRow["REQ_AMOUNT"]) ? null : (System.Decimal?)dataRow["REQ_AMOUNT"];
			entity.RemainAmount = Convert.IsDBNull(dataRow["REMAIN_AMOUNT"]) ? null : (System.Decimal?)dataRow["REMAIN_AMOUNT"];
			entity.AttchdDocPath = Convert.IsDBNull(dataRow["ATTCHD_DOC_PATH"]) ? null : (System.String)dataRow["ATTCHD_DOC_PATH"];
			entity.Notes = Convert.IsDBNull(dataRow["NOTES"]) ? null : (System.String)dataRow["NOTES"];
			entity.ApproveFlg = Convert.IsDBNull(dataRow["APPROVE_FLG"]) ? null : (System.Int32?)dataRow["APPROVE_FLG"];
			entity.ApproveDate = Convert.IsDBNull(dataRow["APPROVE_DATE"]) ? null : (System.DateTime?)dataRow["APPROVE_DATE"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeUserFundReq"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeUserFundReq Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeUserFundReq entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdAcadYearIdSource	
			if (CanDeepLoad(entity, "EdAcadYear|EdAcadYearIdSource", deepLoadType, innerList) 
				&& entity.EdAcadYearIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdAcadYearId;
				EdAcadYear tmpEntity = EntityManager.LocateEntity<EdAcadYear>(EntityLocator.ConstructKeyFromPkItems(typeof(EdAcadYear), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdAcadYearIdSource = tmpEntity;
				else
					entity.EdAcadYearIdSource = DataRepository.EdAcadYearProvider.GetByEdAcadYearId(transactionManager, entity.EdAcadYearId);		
				
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

			#region FeeCdeBondItemIdSource	
			if (CanDeepLoad(entity, "FeeCdeBondItem|FeeCdeBondItemIdSource", deepLoadType, innerList) 
				&& entity.FeeCdeBondItemIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.FeeCdeBondItemId;
				FeeCdeBondItem tmpEntity = EntityManager.LocateEntity<FeeCdeBondItem>(EntityLocator.ConstructKeyFromPkItems(typeof(FeeCdeBondItem), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.FeeCdeBondItemIdSource = tmpEntity;
				else
					entity.FeeCdeBondItemIdSource = DataRepository.FeeCdeBondItemProvider.GetByFeeCdeBondItemId(transactionManager, entity.FeeCdeBondItemId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeCdeBondItemIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.FeeCdeBondItemIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.FeeCdeBondItemProvider.DeepLoad(transactionManager, entity.FeeCdeBondItemIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion FeeCdeBondItemIdSource

			#region GsCodeCurrencyIdSource	
			if (CanDeepLoad(entity, "GsCodeCurrency|GsCodeCurrencyIdSource", deepLoadType, innerList) 
				&& entity.GsCodeCurrencyIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.GsCodeCurrencyId;
				GsCodeCurrency tmpEntity = EntityManager.LocateEntity<GsCodeCurrency>(EntityLocator.ConstructKeyFromPkItems(typeof(GsCodeCurrency), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.GsCodeCurrencyIdSource = tmpEntity;
				else
					entity.GsCodeCurrencyIdSource = DataRepository.GsCodeCurrencyProvider.GetByGsCodeCurrencyId(transactionManager, entity.GsCodeCurrencyId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'GsCodeCurrencyIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.GsCodeCurrencyIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.GsCodeCurrencyProvider.DeepLoad(transactionManager, entity.GsCodeCurrencyIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion GsCodeCurrencyIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.FeeUserFundReq object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.FeeUserFundReq instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeUserFundReq Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeUserFundReq entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region FeeCdeBondItemIdSource
			if (CanDeepSave(entity, "FeeCdeBondItem|FeeCdeBondItemIdSource", deepSaveType, innerList) 
				&& entity.FeeCdeBondItemIdSource != null)
			{
				DataRepository.FeeCdeBondItemProvider.Save(transactionManager, entity.FeeCdeBondItemIdSource);
				entity.FeeCdeBondItemId = entity.FeeCdeBondItemIdSource.FeeCdeBondItemId;
			}
			#endregion 
			
			#region GsCodeCurrencyIdSource
			if (CanDeepSave(entity, "GsCodeCurrency|GsCodeCurrencyIdSource", deepSaveType, innerList) 
				&& entity.GsCodeCurrencyIdSource != null)
			{
				DataRepository.GsCodeCurrencyProvider.Save(transactionManager, entity.GsCodeCurrencyIdSource);
				entity.GsCodeCurrencyId = entity.GsCodeCurrencyIdSource.GsCodeCurrencyId;
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
	
	#region FeeUserFundReqChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.FeeUserFundReq</c>
	///</summary>
	public enum FeeUserFundReqChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdAcadYear</c> at EdAcadYearIdSource
		///</summary>
		[ChildEntityType(typeof(EdAcadYear))]
		EdAcadYear,
		
		///<summary>
		/// Composite Property for <c>FeeCdeBondItem</c> at FeeCdeBondItemIdSource
		///</summary>
		[ChildEntityType(typeof(FeeCdeBondItem))]
		FeeCdeBondItem,
		
		///<summary>
		/// Composite Property for <c>GsCodeCurrency</c> at GsCodeCurrencyIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeCurrency))]
		GsCodeCurrency,
	}
	
	#endregion FeeUserFundReqChildEntityTypes
	
	#region FeeUserFundReqFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;FeeUserFundReqColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeUserFundReq"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeUserFundReqFilterBuilder : SqlFilterBuilder<FeeUserFundReqColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeUserFundReqFilterBuilder class.
		/// </summary>
		public FeeUserFundReqFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeUserFundReqFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeUserFundReqFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeUserFundReqFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeUserFundReqFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeUserFundReqFilterBuilder
	
	#region FeeUserFundReqParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;FeeUserFundReqColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeUserFundReq"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeUserFundReqParameterBuilder : ParameterizedSqlFilterBuilder<FeeUserFundReqColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeUserFundReqParameterBuilder class.
		/// </summary>
		public FeeUserFundReqParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeUserFundReqParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeUserFundReqParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeUserFundReqParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeUserFundReqParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeUserFundReqParameterBuilder
	
	#region FeeUserFundReqSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;FeeUserFundReqColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeUserFundReq"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class FeeUserFundReqSortBuilder : SqlSortBuilder<FeeUserFundReqColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeUserFundReqSqlSortBuilder class.
		/// </summary>
		public FeeUserFundReqSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion FeeUserFundReqSortBuilder
	
} // end namespace
