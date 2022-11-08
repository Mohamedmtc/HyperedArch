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
	/// This class is the base class for any <see cref="FeeCdeBankAccntProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class FeeCdeBankAccntProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.FeeCdeBankAccnt, UMIS_VER2.BusinessLyer.FeeCdeBankAccntKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeCdeBankAccntKey key)
		{
			return Delete(transactionManager, key.FeeCdeBankAccntId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_feeCdeBankAccntId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _feeCdeBankAccntId)
		{
			return Delete(null, _feeCdeBankAccntId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeBankAccntId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _feeCdeBankAccntId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_CDE_BANK_ACCNT_FEE_CODE_BANKS key.
		///		FK_FEE_CDE_BANK_ACCNT_FEE_CODE_BANKS Description: 
		/// </summary>
		/// <param name="_feeCodeBankId">اكواد  البنوك</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeCdeBankAccnt objects.</returns>
		public TList<FeeCdeBankAccnt> GetByFeeCodeBankId(System.Decimal _feeCodeBankId)
		{
			int count = -1;
			return GetByFeeCodeBankId(_feeCodeBankId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_CDE_BANK_ACCNT_FEE_CODE_BANKS key.
		///		FK_FEE_CDE_BANK_ACCNT_FEE_CODE_BANKS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeBankId">اكواد  البنوك</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeCdeBankAccnt objects.</returns>
		/// <remarks></remarks>
		public TList<FeeCdeBankAccnt> GetByFeeCodeBankId(TransactionManager transactionManager, System.Decimal _feeCodeBankId)
		{
			int count = -1;
			return GetByFeeCodeBankId(transactionManager, _feeCodeBankId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_CDE_BANK_ACCNT_FEE_CODE_BANKS key.
		///		FK_FEE_CDE_BANK_ACCNT_FEE_CODE_BANKS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeBankId">اكواد  البنوك</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeCdeBankAccnt objects.</returns>
		public TList<FeeCdeBankAccnt> GetByFeeCodeBankId(TransactionManager transactionManager, System.Decimal _feeCodeBankId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCodeBankId(transactionManager, _feeCodeBankId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_CDE_BANK_ACCNT_FEE_CODE_BANKS key.
		///		fkFeeCdeBankAccntFeeCodeBanks Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeCodeBankId">اكواد  البنوك</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeCdeBankAccnt objects.</returns>
		public TList<FeeCdeBankAccnt> GetByFeeCodeBankId(System.Decimal _feeCodeBankId, int start, int pageLength)
		{
			int count =  -1;
			return GetByFeeCodeBankId(null, _feeCodeBankId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_CDE_BANK_ACCNT_FEE_CODE_BANKS key.
		///		fkFeeCdeBankAccntFeeCodeBanks Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeCodeBankId">اكواد  البنوك</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeCdeBankAccnt objects.</returns>
		public TList<FeeCdeBankAccnt> GetByFeeCodeBankId(System.Decimal _feeCodeBankId, int start, int pageLength,out int count)
		{
			return GetByFeeCodeBankId(null, _feeCodeBankId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_CDE_BANK_ACCNT_FEE_CODE_BANKS key.
		///		FK_FEE_CDE_BANK_ACCNT_FEE_CODE_BANKS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeBankId">اكواد  البنوك</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeCdeBankAccnt objects.</returns>
		public abstract TList<FeeCdeBankAccnt> GetByFeeCodeBankId(TransactionManager transactionManager, System.Decimal _feeCodeBankId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_CDE_BANK_ACCNT_GS_CODE_CURRENCY key.
		///		FK_FEE_CDE_BANK_ACCNT_GS_CODE_CURRENCY Description: 
		/// </summary>
		/// <param name="_gsCodeCurrencyId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeCdeBankAccnt objects.</returns>
		public TList<FeeCdeBankAccnt> GetByGsCodeCurrencyId(System.Decimal _gsCodeCurrencyId)
		{
			int count = -1;
			return GetByGsCodeCurrencyId(_gsCodeCurrencyId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_CDE_BANK_ACCNT_GS_CODE_CURRENCY key.
		///		FK_FEE_CDE_BANK_ACCNT_GS_CODE_CURRENCY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeCurrencyId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeCdeBankAccnt objects.</returns>
		/// <remarks></remarks>
		public TList<FeeCdeBankAccnt> GetByGsCodeCurrencyId(TransactionManager transactionManager, System.Decimal _gsCodeCurrencyId)
		{
			int count = -1;
			return GetByGsCodeCurrencyId(transactionManager, _gsCodeCurrencyId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_CDE_BANK_ACCNT_GS_CODE_CURRENCY key.
		///		FK_FEE_CDE_BANK_ACCNT_GS_CODE_CURRENCY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeCurrencyId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeCdeBankAccnt objects.</returns>
		public TList<FeeCdeBankAccnt> GetByGsCodeCurrencyId(TransactionManager transactionManager, System.Decimal _gsCodeCurrencyId, int start, int pageLength)
		{
			int count = -1;
			return GetByGsCodeCurrencyId(transactionManager, _gsCodeCurrencyId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_CDE_BANK_ACCNT_GS_CODE_CURRENCY key.
		///		fkFeeCdeBankAccntGsCodeCurrency Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeCurrencyId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeCdeBankAccnt objects.</returns>
		public TList<FeeCdeBankAccnt> GetByGsCodeCurrencyId(System.Decimal _gsCodeCurrencyId, int start, int pageLength)
		{
			int count =  -1;
			return GetByGsCodeCurrencyId(null, _gsCodeCurrencyId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_CDE_BANK_ACCNT_GS_CODE_CURRENCY key.
		///		fkFeeCdeBankAccntGsCodeCurrency Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_gsCodeCurrencyId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeCdeBankAccnt objects.</returns>
		public TList<FeeCdeBankAccnt> GetByGsCodeCurrencyId(System.Decimal _gsCodeCurrencyId, int start, int pageLength,out int count)
		{
			return GetByGsCodeCurrencyId(null, _gsCodeCurrencyId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_CDE_BANK_ACCNT_GS_CODE_CURRENCY key.
		///		FK_FEE_CDE_BANK_ACCNT_GS_CODE_CURRENCY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_gsCodeCurrencyId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeCdeBankAccnt objects.</returns>
		public abstract TList<FeeCdeBankAccnt> GetByGsCodeCurrencyId(TransactionManager transactionManager, System.Decimal _gsCodeCurrencyId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.FeeCdeBankAccnt Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeCdeBankAccntKey key, int start, int pageLength)
		{
			return GetByFeeCdeBankAccntId(transactionManager, key.FeeCdeBankAccntId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_FEE_CDE_BANK_ACCNT index.
		/// </summary>
		/// <param name="_feeCdeBankAccntId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCdeBankAccnt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCdeBankAccnt GetByFeeCdeBankAccntId(System.Decimal _feeCdeBankAccntId)
		{
			int count = -1;
			return GetByFeeCdeBankAccntId(null,_feeCdeBankAccntId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_CDE_BANK_ACCNT index.
		/// </summary>
		/// <param name="_feeCdeBankAccntId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCdeBankAccnt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCdeBankAccnt GetByFeeCdeBankAccntId(System.Decimal _feeCdeBankAccntId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCdeBankAccntId(null, _feeCdeBankAccntId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_CDE_BANK_ACCNT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeBankAccntId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCdeBankAccnt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCdeBankAccnt GetByFeeCdeBankAccntId(TransactionManager transactionManager, System.Decimal _feeCdeBankAccntId)
		{
			int count = -1;
			return GetByFeeCdeBankAccntId(transactionManager, _feeCdeBankAccntId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_CDE_BANK_ACCNT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeBankAccntId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCdeBankAccnt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCdeBankAccnt GetByFeeCdeBankAccntId(TransactionManager transactionManager, System.Decimal _feeCdeBankAccntId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCdeBankAccntId(transactionManager, _feeCdeBankAccntId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_CDE_BANK_ACCNT index.
		/// </summary>
		/// <param name="_feeCdeBankAccntId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCdeBankAccnt"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeCdeBankAccnt GetByFeeCdeBankAccntId(System.Decimal _feeCdeBankAccntId, int start, int pageLength, out int count)
		{
			return GetByFeeCdeBankAccntId(null, _feeCdeBankAccntId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_CDE_BANK_ACCNT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeBankAccntId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeCdeBankAccnt"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.FeeCdeBankAccnt GetByFeeCdeBankAccntId(TransactionManager transactionManager, System.Decimal _feeCdeBankAccntId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_FEE_CDE_BANK_ACCNT index.
		/// </summary>
		/// <param name="_feeCodeBankId">اكواد  البنوك</param>
		/// <param name="_accountNo"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeCdeBankAccnt&gt;"/> class.</returns>
		public TList<FeeCdeBankAccnt> GetByFeeCodeBankIdAccountNo(System.Decimal _feeCodeBankId, System.String _accountNo)
		{
			int count = -1;
			return GetByFeeCodeBankIdAccountNo(null,_feeCodeBankId, _accountNo, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_CDE_BANK_ACCNT index.
		/// </summary>
		/// <param name="_feeCodeBankId">اكواد  البنوك</param>
		/// <param name="_accountNo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeCdeBankAccnt&gt;"/> class.</returns>
		public TList<FeeCdeBankAccnt> GetByFeeCodeBankIdAccountNo(System.Decimal _feeCodeBankId, System.String _accountNo, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCodeBankIdAccountNo(null, _feeCodeBankId, _accountNo, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_CDE_BANK_ACCNT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeBankId">اكواد  البنوك</param>
		/// <param name="_accountNo"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeCdeBankAccnt&gt;"/> class.</returns>
		public TList<FeeCdeBankAccnt> GetByFeeCodeBankIdAccountNo(TransactionManager transactionManager, System.Decimal _feeCodeBankId, System.String _accountNo)
		{
			int count = -1;
			return GetByFeeCodeBankIdAccountNo(transactionManager, _feeCodeBankId, _accountNo, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_CDE_BANK_ACCNT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeBankId">اكواد  البنوك</param>
		/// <param name="_accountNo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeCdeBankAccnt&gt;"/> class.</returns>
		public TList<FeeCdeBankAccnt> GetByFeeCodeBankIdAccountNo(TransactionManager transactionManager, System.Decimal _feeCodeBankId, System.String _accountNo, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCodeBankIdAccountNo(transactionManager, _feeCodeBankId, _accountNo, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_CDE_BANK_ACCNT index.
		/// </summary>
		/// <param name="_feeCodeBankId">اكواد  البنوك</param>
		/// <param name="_accountNo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeCdeBankAccnt&gt;"/> class.</returns>
		public TList<FeeCdeBankAccnt> GetByFeeCodeBankIdAccountNo(System.Decimal _feeCodeBankId, System.String _accountNo, int start, int pageLength, out int count)
		{
			return GetByFeeCodeBankIdAccountNo(null, _feeCodeBankId, _accountNo, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_CDE_BANK_ACCNT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeBankId">اكواد  البنوك</param>
		/// <param name="_accountNo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;FeeCdeBankAccnt&gt;"/> class.</returns>
		public abstract TList<FeeCdeBankAccnt> GetByFeeCodeBankIdAccountNo(TransactionManager transactionManager, System.Decimal _feeCodeBankId, System.String _accountNo, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;FeeCdeBankAccnt&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;FeeCdeBankAccnt&gt;"/></returns>
		public static TList<FeeCdeBankAccnt> Fill(IDataReader reader, TList<FeeCdeBankAccnt> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.FeeCdeBankAccnt c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("FeeCdeBankAccnt")
					.Append("|").Append((System.Decimal)reader["FEE_CDE_BANK_ACCNT_ID"]).ToString();
					c = EntityManager.LocateOrCreate<FeeCdeBankAccnt>(
					key.ToString(), // EntityTrackingKey
					"FeeCdeBankAccnt",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.FeeCdeBankAccnt();
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
					c.FeeCdeBankAccntId = (System.Decimal)reader["FEE_CDE_BANK_ACCNT_ID"];
					c.OriginalFeeCdeBankAccntId = c.FeeCdeBankAccntId;
					c.FeeCodeBankId = (System.Decimal)reader["FEE_CODE_BANK_ID"];
					c.GsCodeCurrencyId = (System.Decimal)reader["GS_CODE_CURRENCY_ID"];
					c.AccountNo = Convert.IsDBNull(reader["ACCOUNT_NO"]) ? null : (System.String)reader["ACCOUNT_NO"];
					c.SeUserId = Convert.IsDBNull(reader["SE_USER_ID"]) ? null : (System.Decimal?)reader["SE_USER_ID"];
					c.DfultFlg = Convert.IsDBNull(reader["DFULT_FLG"]) ? null : (System.Boolean?)reader["DFULT_FLG"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeCdeBankAccnt"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeCdeBankAccnt"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.FeeCdeBankAccnt entity)
		{
			if (!reader.Read()) return;
			
			entity.FeeCdeBankAccntId = (System.Decimal)reader[((int)FeeCdeBankAccntColumn.FeeCdeBankAccntId - 1)];
			entity.OriginalFeeCdeBankAccntId = (System.Decimal)reader["FEE_CDE_BANK_ACCNT_ID"];
			entity.FeeCodeBankId = (System.Decimal)reader[((int)FeeCdeBankAccntColumn.FeeCodeBankId - 1)];
			entity.GsCodeCurrencyId = (System.Decimal)reader[((int)FeeCdeBankAccntColumn.GsCodeCurrencyId - 1)];
			entity.AccountNo = (reader.IsDBNull(((int)FeeCdeBankAccntColumn.AccountNo - 1)))?null:(System.String)reader[((int)FeeCdeBankAccntColumn.AccountNo - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)FeeCdeBankAccntColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)FeeCdeBankAccntColumn.SeUserId - 1)];
			entity.DfultFlg = (reader.IsDBNull(((int)FeeCdeBankAccntColumn.DfultFlg - 1)))?null:(System.Boolean?)reader[((int)FeeCdeBankAccntColumn.DfultFlg - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeCdeBankAccnt"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeCdeBankAccnt"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.FeeCdeBankAccnt entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.FeeCdeBankAccntId = (System.Decimal)dataRow["FEE_CDE_BANK_ACCNT_ID"];
			entity.OriginalFeeCdeBankAccntId = (System.Decimal)dataRow["FEE_CDE_BANK_ACCNT_ID"];
			entity.FeeCodeBankId = (System.Decimal)dataRow["FEE_CODE_BANK_ID"];
			entity.GsCodeCurrencyId = (System.Decimal)dataRow["GS_CODE_CURRENCY_ID"];
			entity.AccountNo = Convert.IsDBNull(dataRow["ACCOUNT_NO"]) ? null : (System.String)dataRow["ACCOUNT_NO"];
			entity.SeUserId = Convert.IsDBNull(dataRow["SE_USER_ID"]) ? null : (System.Decimal?)dataRow["SE_USER_ID"];
			entity.DfultFlg = Convert.IsDBNull(dataRow["DFULT_FLG"]) ? null : (System.Boolean?)dataRow["DFULT_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeCdeBankAccnt"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeCdeBankAccnt Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeCdeBankAccnt entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region FeeCodeBankIdSource	
			if (CanDeepLoad(entity, "FeeCodeBanks|FeeCodeBankIdSource", deepLoadType, innerList) 
				&& entity.FeeCodeBankIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.FeeCodeBankId;
				FeeCodeBanks tmpEntity = EntityManager.LocateEntity<FeeCodeBanks>(EntityLocator.ConstructKeyFromPkItems(typeof(FeeCodeBanks), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.FeeCodeBankIdSource = tmpEntity;
				else
					entity.FeeCodeBankIdSource = DataRepository.FeeCodeBanksProvider.GetByFeeCodeBankId(transactionManager, entity.FeeCodeBankId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeCodeBankIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.FeeCodeBankIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.FeeCodeBanksProvider.DeepLoad(transactionManager, entity.FeeCodeBankIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion FeeCodeBankIdSource

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
			// Deep load child collections  - Call GetByFeeCdeBankAccntId methods when available
			
			#region FeeItemPaymentWaysCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeItemPaymentWays>|FeeItemPaymentWaysCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeItemPaymentWaysCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeItemPaymentWaysCollection = DataRepository.FeeItemPaymentWaysProvider.GetByFeeCdeBankAccntId(transactionManager, entity.FeeCdeBankAccntId);

				if (deep && entity.FeeItemPaymentWaysCollection.Count > 0)
				{
					deepHandles.Add("FeeItemPaymentWaysCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeItemPaymentWays>) DataRepository.FeeItemPaymentWaysProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeItemPaymentWaysCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.FeeCdeBankAccnt object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.FeeCdeBankAccnt instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeCdeBankAccnt Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeCdeBankAccnt entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region FeeCodeBankIdSource
			if (CanDeepSave(entity, "FeeCodeBanks|FeeCodeBankIdSource", deepSaveType, innerList) 
				&& entity.FeeCodeBankIdSource != null)
			{
				DataRepository.FeeCodeBanksProvider.Save(transactionManager, entity.FeeCodeBankIdSource);
				entity.FeeCodeBankId = entity.FeeCodeBankIdSource.FeeCodeBankId;
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
	
			#region List<FeeItemPaymentWays>
				if (CanDeepSave(entity.FeeItemPaymentWaysCollection, "List<FeeItemPaymentWays>|FeeItemPaymentWaysCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeItemPaymentWays child in entity.FeeItemPaymentWaysCollection)
					{
						if(child.FeeCdeBankAccntIdSource != null)
						{
							child.FeeCdeBankAccntId = child.FeeCdeBankAccntIdSource.FeeCdeBankAccntId;
						}
						else
						{
							child.FeeCdeBankAccntId = entity.FeeCdeBankAccntId;
						}

					}

					if (entity.FeeItemPaymentWaysCollection.Count > 0 || entity.FeeItemPaymentWaysCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeItemPaymentWaysProvider.Save(transactionManager, entity.FeeItemPaymentWaysCollection);
						
						deepHandles.Add("FeeItemPaymentWaysCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeItemPaymentWays >) DataRepository.FeeItemPaymentWaysProvider.DeepSave,
							new object[] { transactionManager, entity.FeeItemPaymentWaysCollection, deepSaveType, childTypes, innerList }
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
	
	#region FeeCdeBankAccntChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.FeeCdeBankAccnt</c>
	///</summary>
	public enum FeeCdeBankAccntChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>FeeCodeBanks</c> at FeeCodeBankIdSource
		///</summary>
		[ChildEntityType(typeof(FeeCodeBanks))]
		FeeCodeBanks,
		
		///<summary>
		/// Composite Property for <c>GsCodeCurrency</c> at GsCodeCurrencyIdSource
		///</summary>
		[ChildEntityType(typeof(GsCodeCurrency))]
		GsCodeCurrency,
		///<summary>
		/// Collection of <c>FeeCdeBankAccnt</c> as OneToMany for FeeItemPaymentWaysCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeItemPaymentWays>))]
		FeeItemPaymentWaysCollection,
	}
	
	#endregion FeeCdeBankAccntChildEntityTypes
	
	#region FeeCdeBankAccntFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;FeeCdeBankAccntColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeCdeBankAccnt"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeCdeBankAccntFilterBuilder : SqlFilterBuilder<FeeCdeBankAccntColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeCdeBankAccntFilterBuilder class.
		/// </summary>
		public FeeCdeBankAccntFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeCdeBankAccntFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeCdeBankAccntFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeCdeBankAccntFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeCdeBankAccntFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeCdeBankAccntFilterBuilder
	
	#region FeeCdeBankAccntParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;FeeCdeBankAccntColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeCdeBankAccnt"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeCdeBankAccntParameterBuilder : ParameterizedSqlFilterBuilder<FeeCdeBankAccntColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeCdeBankAccntParameterBuilder class.
		/// </summary>
		public FeeCdeBankAccntParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeCdeBankAccntParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeCdeBankAccntParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeCdeBankAccntParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeCdeBankAccntParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeCdeBankAccntParameterBuilder
	
	#region FeeCdeBankAccntSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;FeeCdeBankAccntColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeCdeBankAccnt"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class FeeCdeBankAccntSortBuilder : SqlSortBuilder<FeeCdeBankAccntColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeCdeBankAccntSqlSortBuilder class.
		/// </summary>
		public FeeCdeBankAccntSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion FeeCdeBankAccntSortBuilder
	
} // end namespace
