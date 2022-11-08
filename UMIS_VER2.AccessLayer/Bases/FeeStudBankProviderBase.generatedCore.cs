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
	/// This class is the base class for any <see cref="FeeStudBankProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class FeeStudBankProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.FeeStudBank, UMIS_VER2.BusinessLyer.FeeStudBankKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeStudBankKey key)
		{
			return Delete(transactionManager, key.FeeStudBankId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_feeStudBankId">بيانات الحساب البنكي للطلاب. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _feeStudBankId)
		{
			return Delete(null, _feeStudBankId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudBankId">بيانات الحساب البنكي للطلاب. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _feeStudBankId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_BANK_FEE_CODE_BANKS key.
		///		FK_FEE_STUD_BANK_FEE_CODE_BANKS Description: 
		/// </summary>
		/// <param name="_feeCodeBankId">اكواد  البنوك</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudBank objects.</returns>
		public TList<FeeStudBank> GetByFeeCodeBankId(System.Decimal _feeCodeBankId)
		{
			int count = -1;
			return GetByFeeCodeBankId(_feeCodeBankId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_BANK_FEE_CODE_BANKS key.
		///		FK_FEE_STUD_BANK_FEE_CODE_BANKS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeBankId">اكواد  البنوك</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudBank objects.</returns>
		/// <remarks></remarks>
		public TList<FeeStudBank> GetByFeeCodeBankId(TransactionManager transactionManager, System.Decimal _feeCodeBankId)
		{
			int count = -1;
			return GetByFeeCodeBankId(transactionManager, _feeCodeBankId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_BANK_FEE_CODE_BANKS key.
		///		FK_FEE_STUD_BANK_FEE_CODE_BANKS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeBankId">اكواد  البنوك</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudBank objects.</returns>
		public TList<FeeStudBank> GetByFeeCodeBankId(TransactionManager transactionManager, System.Decimal _feeCodeBankId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCodeBankId(transactionManager, _feeCodeBankId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_BANK_FEE_CODE_BANKS key.
		///		fkFeeStudBankFeeCodeBanks Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeCodeBankId">اكواد  البنوك</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudBank objects.</returns>
		public TList<FeeStudBank> GetByFeeCodeBankId(System.Decimal _feeCodeBankId, int start, int pageLength)
		{
			int count =  -1;
			return GetByFeeCodeBankId(null, _feeCodeBankId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_BANK_FEE_CODE_BANKS key.
		///		fkFeeStudBankFeeCodeBanks Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeCodeBankId">اكواد  البنوك</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudBank objects.</returns>
		public TList<FeeStudBank> GetByFeeCodeBankId(System.Decimal _feeCodeBankId, int start, int pageLength,out int count)
		{
			return GetByFeeCodeBankId(null, _feeCodeBankId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_STUD_BANK_FEE_CODE_BANKS key.
		///		FK_FEE_STUD_BANK_FEE_CODE_BANKS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeBankId">اكواد  البنوك</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeStudBank objects.</returns>
		public abstract TList<FeeStudBank> GetByFeeCodeBankId(TransactionManager transactionManager, System.Decimal _feeCodeBankId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.FeeStudBank Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeStudBankKey key, int start, int pageLength)
		{
			return GetByFeeStudBankId(transactionManager, key.FeeStudBankId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_FEE_STUD_BANK index.
		/// </summary>
		/// <param name="_feeStudBankId">بيانات الحساب البنكي للطلاب</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudBank"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudBank GetByFeeStudBankId(System.Decimal _feeStudBankId)
		{
			int count = -1;
			return GetByFeeStudBankId(null,_feeStudBankId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_STUD_BANK index.
		/// </summary>
		/// <param name="_feeStudBankId">بيانات الحساب البنكي للطلاب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudBank"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudBank GetByFeeStudBankId(System.Decimal _feeStudBankId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeStudBankId(null, _feeStudBankId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_STUD_BANK index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudBankId">بيانات الحساب البنكي للطلاب</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudBank"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudBank GetByFeeStudBankId(TransactionManager transactionManager, System.Decimal _feeStudBankId)
		{
			int count = -1;
			return GetByFeeStudBankId(transactionManager, _feeStudBankId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_STUD_BANK index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudBankId">بيانات الحساب البنكي للطلاب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudBank"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudBank GetByFeeStudBankId(TransactionManager transactionManager, System.Decimal _feeStudBankId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeStudBankId(transactionManager, _feeStudBankId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_STUD_BANK index.
		/// </summary>
		/// <param name="_feeStudBankId">بيانات الحساب البنكي للطلاب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudBank"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudBank GetByFeeStudBankId(System.Decimal _feeStudBankId, int start, int pageLength, out int count)
		{
			return GetByFeeStudBankId(null, _feeStudBankId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_STUD_BANK index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudBankId">بيانات الحساب البنكي للطلاب</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudBank"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.FeeStudBank GetByFeeStudBankId(TransactionManager transactionManager, System.Decimal _feeStudBankId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_FEE_STUD_BANK index.
		/// </summary>
		/// <param name="_accountNo"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudBank"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudBank GetByAccountNo(System.String _accountNo)
		{
			int count = -1;
			return GetByAccountNo(null,_accountNo, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_STUD_BANK index.
		/// </summary>
		/// <param name="_accountNo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudBank"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudBank GetByAccountNo(System.String _accountNo, int start, int pageLength)
		{
			int count = -1;
			return GetByAccountNo(null, _accountNo, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_STUD_BANK index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accountNo"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudBank"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudBank GetByAccountNo(TransactionManager transactionManager, System.String _accountNo)
		{
			int count = -1;
			return GetByAccountNo(transactionManager, _accountNo, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_STUD_BANK index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accountNo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudBank"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudBank GetByAccountNo(TransactionManager transactionManager, System.String _accountNo, int start, int pageLength)
		{
			int count = -1;
			return GetByAccountNo(transactionManager, _accountNo, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_STUD_BANK index.
		/// </summary>
		/// <param name="_accountNo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudBank"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudBank GetByAccountNo(System.String _accountNo, int start, int pageLength, out int count)
		{
			return GetByAccountNo(null, _accountNo, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_STUD_BANK index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_accountNo"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudBank"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.FeeStudBank GetByAccountNo(TransactionManager transactionManager, System.String _accountNo, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_FEE_STUD_BANK_STUD index.
		/// </summary>
		/// <param name="_edStudId">PG Student</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudBank"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudBank GetByEdStudId(System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(null,_edStudId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_STUD_BANK_STUD index.
		/// </summary>
		/// <param name="_edStudId">PG Student</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudBank"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudBank GetByEdStudId(System.Decimal _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_STUD_BANK_STUD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">PG Student</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudBank"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudBank GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_STUD_BANK_STUD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">PG Student</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudBank"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudBank GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdStudId(transactionManager, _edStudId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_STUD_BANK_STUD index.
		/// </summary>
		/// <param name="_edStudId">PG Student</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudBank"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeStudBank GetByEdStudId(System.Decimal _edStudId, int start, int pageLength, out int count)
		{
			return GetByEdStudId(null, _edStudId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_STUD_BANK_STUD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edStudId">PG Student</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeStudBank"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.FeeStudBank GetByEdStudId(TransactionManager transactionManager, System.Decimal _edStudId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;FeeStudBank&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;FeeStudBank&gt;"/></returns>
		public static TList<FeeStudBank> Fill(IDataReader reader, TList<FeeStudBank> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.FeeStudBank c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("FeeStudBank")
					.Append("|").Append((System.Decimal)reader["FEE_STUD_BANK_ID"]).ToString();
					c = EntityManager.LocateOrCreate<FeeStudBank>(
					key.ToString(), // EntityTrackingKey
					"FeeStudBank",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.FeeStudBank();
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
					c.FeeStudBankId = (System.Decimal)reader["FEE_STUD_BANK_ID"];
					c.OriginalFeeStudBankId = c.FeeStudBankId;
					c.EdStudId = (System.Decimal)reader["ED_STUD_ID"];
					c.PayrollCardFlg = (System.Boolean)reader["PAYROLL_CARD_FLG"];
					c.FeeCodeBankId = (System.Decimal)reader["FEE_CODE_BANK_ID"];
					c.Branch = Convert.IsDBNull(reader["BRANCH"]) ? null : (System.String)reader["BRANCH"];
					c.AccountNo = Convert.IsDBNull(reader["ACCOUNT_NO"]) ? null : (System.String)reader["ACCOUNT_NO"];
					c.AttchdDocPath = Convert.IsDBNull(reader["ATTCHD_DOC_PATH"]) ? null : (System.String)reader["ATTCHD_DOC_PATH"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeStudBank"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeStudBank"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.FeeStudBank entity)
		{
			if (!reader.Read()) return;
			
			entity.FeeStudBankId = (System.Decimal)reader[((int)FeeStudBankColumn.FeeStudBankId - 1)];
			entity.OriginalFeeStudBankId = (System.Decimal)reader["FEE_STUD_BANK_ID"];
			entity.EdStudId = (System.Decimal)reader[((int)FeeStudBankColumn.EdStudId - 1)];
			entity.PayrollCardFlg = (System.Boolean)reader[((int)FeeStudBankColumn.PayrollCardFlg - 1)];
			entity.FeeCodeBankId = (System.Decimal)reader[((int)FeeStudBankColumn.FeeCodeBankId - 1)];
			entity.Branch = (reader.IsDBNull(((int)FeeStudBankColumn.Branch - 1)))?null:(System.String)reader[((int)FeeStudBankColumn.Branch - 1)];
			entity.AccountNo = (reader.IsDBNull(((int)FeeStudBankColumn.AccountNo - 1)))?null:(System.String)reader[((int)FeeStudBankColumn.AccountNo - 1)];
			entity.AttchdDocPath = (reader.IsDBNull(((int)FeeStudBankColumn.AttchdDocPath - 1)))?null:(System.String)reader[((int)FeeStudBankColumn.AttchdDocPath - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)FeeStudBankColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)FeeStudBankColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)FeeStudBankColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)FeeStudBankColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeStudBank"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeStudBank"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.FeeStudBank entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.FeeStudBankId = (System.Decimal)dataRow["FEE_STUD_BANK_ID"];
			entity.OriginalFeeStudBankId = (System.Decimal)dataRow["FEE_STUD_BANK_ID"];
			entity.EdStudId = (System.Decimal)dataRow["ED_STUD_ID"];
			entity.PayrollCardFlg = (System.Boolean)dataRow["PAYROLL_CARD_FLG"];
			entity.FeeCodeBankId = (System.Decimal)dataRow["FEE_CODE_BANK_ID"];
			entity.Branch = Convert.IsDBNull(dataRow["BRANCH"]) ? null : (System.String)dataRow["BRANCH"];
			entity.AccountNo = Convert.IsDBNull(dataRow["ACCOUNT_NO"]) ? null : (System.String)dataRow["ACCOUNT_NO"];
			entity.AttchdDocPath = Convert.IsDBNull(dataRow["ATTCHD_DOC_PATH"]) ? null : (System.String)dataRow["ATTCHD_DOC_PATH"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeStudBank"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeStudBank Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeStudBank entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region EdStudIdSource	
			if (CanDeepLoad(entity, "EdStud|EdStudIdSource", deepLoadType, innerList) 
				&& entity.EdStudIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdStudId;
				EdStud tmpEntity = EntityManager.LocateEntity<EdStud>(EntityLocator.ConstructKeyFromPkItems(typeof(EdStud), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdStudIdSource = tmpEntity;
				else
					entity.EdStudIdSource = DataRepository.EdStudProvider.GetByEdStudId(transactionManager, entity.EdStudId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdStudIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdStudIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdStudProvider.DeepLoad(transactionManager, entity.EdStudIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdStudIdSource

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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.FeeStudBank object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.FeeStudBank instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeStudBank Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeStudBank entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region EdStudIdSource
			if (CanDeepSave(entity, "EdStud|EdStudIdSource", deepSaveType, innerList) 
				&& entity.EdStudIdSource != null)
			{
				DataRepository.EdStudProvider.Save(transactionManager, entity.EdStudIdSource);
				entity.EdStudId = entity.EdStudIdSource.EdStudId;
			}
			#endregion 
			
			#region FeeCodeBankIdSource
			if (CanDeepSave(entity, "FeeCodeBanks|FeeCodeBankIdSource", deepSaveType, innerList) 
				&& entity.FeeCodeBankIdSource != null)
			{
				DataRepository.FeeCodeBanksProvider.Save(transactionManager, entity.FeeCodeBankIdSource);
				entity.FeeCodeBankId = entity.FeeCodeBankIdSource.FeeCodeBankId;
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
	
	#region FeeStudBankChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.FeeStudBank</c>
	///</summary>
	public enum FeeStudBankChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdStud</c> at EdStudIdSource
		///</summary>
		[ChildEntityType(typeof(EdStud))]
		EdStud,
		
		///<summary>
		/// Composite Property for <c>FeeCodeBanks</c> at FeeCodeBankIdSource
		///</summary>
		[ChildEntityType(typeof(FeeCodeBanks))]
		FeeCodeBanks,
	}
	
	#endregion FeeStudBankChildEntityTypes
	
	#region FeeStudBankFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;FeeStudBankColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeStudBank"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeStudBankFilterBuilder : SqlFilterBuilder<FeeStudBankColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeStudBankFilterBuilder class.
		/// </summary>
		public FeeStudBankFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeStudBankFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeStudBankFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeStudBankFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeStudBankFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeStudBankFilterBuilder
	
	#region FeeStudBankParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;FeeStudBankColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeStudBank"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeStudBankParameterBuilder : ParameterizedSqlFilterBuilder<FeeStudBankColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeStudBankParameterBuilder class.
		/// </summary>
		public FeeStudBankParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeStudBankParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeStudBankParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeStudBankParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeStudBankParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeStudBankParameterBuilder
	
	#region FeeStudBankSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;FeeStudBankColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeStudBank"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class FeeStudBankSortBuilder : SqlSortBuilder<FeeStudBankColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeStudBankSqlSortBuilder class.
		/// </summary>
		public FeeStudBankSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion FeeStudBankSortBuilder
	
} // end namespace
