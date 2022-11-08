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
	/// This class is the base class for any <see cref="FeeTreasuryProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class FeeTreasuryProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.FeeTreasury, UMIS_VER2.BusinessLyer.FeeTreasuryKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeTreasuryKey key)
		{
			return Delete(transactionManager, key.FeeTreasuryId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_feeTreasuryId">الخزنة  الايرادات والمنصرف. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _feeTreasuryId)
		{
			return Delete(null, _feeTreasuryId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeTreasuryId">الخزنة  الايرادات والمنصرف. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _feeTreasuryId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_TREASURY_ED_ACAD_YEAR key.
		///		FK_FEE_TREASURY_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeTreasury objects.</returns>
		public TList<FeeTreasury> GetByEdAcadYearId(System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(_edAcadYearId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_TREASURY_ED_ACAD_YEAR key.
		///		FK_FEE_TREASURY_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeTreasury objects.</returns>
		/// <remarks></remarks>
		public TList<FeeTreasury> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_TREASURY_ED_ACAD_YEAR key.
		///		FK_FEE_TREASURY_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeTreasury objects.</returns>
		public TList<FeeTreasury> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdAcadYearId(transactionManager, _edAcadYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_TREASURY_ED_ACAD_YEAR key.
		///		fkFeeTreasuryEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeTreasury objects.</returns>
		public TList<FeeTreasury> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_TREASURY_ED_ACAD_YEAR key.
		///		fkFeeTreasuryEdAcadYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeTreasury objects.</returns>
		public TList<FeeTreasury> GetByEdAcadYearId(System.Decimal _edAcadYearId, int start, int pageLength,out int count)
		{
			return GetByEdAcadYearId(null, _edAcadYearId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_TREASURY_ED_ACAD_YEAR key.
		///		FK_FEE_TREASURY_ED_ACAD_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edAcadYearId">العام الاكاديمى</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeTreasury objects.</returns>
		public abstract TList<FeeTreasury> GetByEdAcadYearId(TransactionManager transactionManager, System.Decimal _edAcadYearId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_TREASURY_FEE_CDE_TRSRY key.
		///		FK_FEE_TREASURY_FEE_CDE_TRSRY Description: 
		/// </summary>
		/// <param name="_feeCdeTrsryId">XXX</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeTreasury objects.</returns>
		public TList<FeeTreasury> GetByFeeCdeTrsryId(System.Int32? _feeCdeTrsryId)
		{
			int count = -1;
			return GetByFeeCdeTrsryId(_feeCdeTrsryId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_TREASURY_FEE_CDE_TRSRY key.
		///		FK_FEE_TREASURY_FEE_CDE_TRSRY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeTrsryId">XXX</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeTreasury objects.</returns>
		/// <remarks></remarks>
		public TList<FeeTreasury> GetByFeeCdeTrsryId(TransactionManager transactionManager, System.Int32? _feeCdeTrsryId)
		{
			int count = -1;
			return GetByFeeCdeTrsryId(transactionManager, _feeCdeTrsryId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_TREASURY_FEE_CDE_TRSRY key.
		///		FK_FEE_TREASURY_FEE_CDE_TRSRY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeTrsryId">XXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeTreasury objects.</returns>
		public TList<FeeTreasury> GetByFeeCdeTrsryId(TransactionManager transactionManager, System.Int32? _feeCdeTrsryId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCdeTrsryId(transactionManager, _feeCdeTrsryId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_TREASURY_FEE_CDE_TRSRY key.
		///		fkFeeTreasuryFeeCdeTrsry Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeCdeTrsryId">XXX</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeTreasury objects.</returns>
		public TList<FeeTreasury> GetByFeeCdeTrsryId(System.Int32? _feeCdeTrsryId, int start, int pageLength)
		{
			int count =  -1;
			return GetByFeeCdeTrsryId(null, _feeCdeTrsryId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_TREASURY_FEE_CDE_TRSRY key.
		///		fkFeeTreasuryFeeCdeTrsry Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeCdeTrsryId">XXX</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeTreasury objects.</returns>
		public TList<FeeTreasury> GetByFeeCdeTrsryId(System.Int32? _feeCdeTrsryId, int start, int pageLength,out int count)
		{
			return GetByFeeCdeTrsryId(null, _feeCdeTrsryId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_TREASURY_FEE_CDE_TRSRY key.
		///		FK_FEE_TREASURY_FEE_CDE_TRSRY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCdeTrsryId">XXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeTreasury objects.</returns>
		public abstract TList<FeeTreasury> GetByFeeCdeTrsryId(TransactionManager transactionManager, System.Int32? _feeCdeTrsryId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_TREASURY_FEE_STUD_VOUCHER key.
		///		FK_FEE_TREASURY_FEE_STUD_VOUCHER Description: 
		/// </summary>
		/// <param name="_feeStudVoucherId">XXXاذن دفع/ايصال سدادXXX</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeTreasury objects.</returns>
		public TList<FeeTreasury> GetByFeeStudVoucherId(System.Decimal? _feeStudVoucherId)
		{
			int count = -1;
			return GetByFeeStudVoucherId(_feeStudVoucherId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_TREASURY_FEE_STUD_VOUCHER key.
		///		FK_FEE_TREASURY_FEE_STUD_VOUCHER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudVoucherId">XXXاذن دفع/ايصال سدادXXX</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeTreasury objects.</returns>
		/// <remarks></remarks>
		public TList<FeeTreasury> GetByFeeStudVoucherId(TransactionManager transactionManager, System.Decimal? _feeStudVoucherId)
		{
			int count = -1;
			return GetByFeeStudVoucherId(transactionManager, _feeStudVoucherId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_TREASURY_FEE_STUD_VOUCHER key.
		///		FK_FEE_TREASURY_FEE_STUD_VOUCHER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudVoucherId">XXXاذن دفع/ايصال سدادXXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeTreasury objects.</returns>
		public TList<FeeTreasury> GetByFeeStudVoucherId(TransactionManager transactionManager, System.Decimal? _feeStudVoucherId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeStudVoucherId(transactionManager, _feeStudVoucherId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_TREASURY_FEE_STUD_VOUCHER key.
		///		fkFeeTreasuryFeeStudVoucher Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeStudVoucherId">XXXاذن دفع/ايصال سدادXXX</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeTreasury objects.</returns>
		public TList<FeeTreasury> GetByFeeStudVoucherId(System.Decimal? _feeStudVoucherId, int start, int pageLength)
		{
			int count =  -1;
			return GetByFeeStudVoucherId(null, _feeStudVoucherId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_TREASURY_FEE_STUD_VOUCHER key.
		///		fkFeeTreasuryFeeStudVoucher Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeStudVoucherId">XXXاذن دفع/ايصال سدادXXX</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeTreasury objects.</returns>
		public TList<FeeTreasury> GetByFeeStudVoucherId(System.Decimal? _feeStudVoucherId, int start, int pageLength,out int count)
		{
			return GetByFeeStudVoucherId(null, _feeStudVoucherId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_TREASURY_FEE_STUD_VOUCHER key.
		///		FK_FEE_TREASURY_FEE_STUD_VOUCHER Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeStudVoucherId">XXXاذن دفع/ايصال سدادXXX</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeTreasury objects.</returns>
		public abstract TList<FeeTreasury> GetByFeeStudVoucherId(TransactionManager transactionManager, System.Decimal? _feeStudVoucherId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.FeeTreasury Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeTreasuryKey key, int start, int pageLength)
		{
			return GetByFeeTreasuryId(transactionManager, key.FeeTreasuryId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_FEE_TREASURY index.
		/// </summary>
		/// <param name="_feeTreasuryId">الخزنة  الايرادات والمنصرف</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeTreasury"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeTreasury GetByFeeTreasuryId(System.Decimal _feeTreasuryId)
		{
			int count = -1;
			return GetByFeeTreasuryId(null,_feeTreasuryId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_TREASURY index.
		/// </summary>
		/// <param name="_feeTreasuryId">الخزنة  الايرادات والمنصرف</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeTreasury"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeTreasury GetByFeeTreasuryId(System.Decimal _feeTreasuryId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeTreasuryId(null, _feeTreasuryId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_TREASURY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeTreasuryId">الخزنة  الايرادات والمنصرف</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeTreasury"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeTreasury GetByFeeTreasuryId(TransactionManager transactionManager, System.Decimal _feeTreasuryId)
		{
			int count = -1;
			return GetByFeeTreasuryId(transactionManager, _feeTreasuryId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_TREASURY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeTreasuryId">الخزنة  الايرادات والمنصرف</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeTreasury"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeTreasury GetByFeeTreasuryId(TransactionManager transactionManager, System.Decimal _feeTreasuryId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeTreasuryId(transactionManager, _feeTreasuryId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_TREASURY index.
		/// </summary>
		/// <param name="_feeTreasuryId">الخزنة  الايرادات والمنصرف</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeTreasury"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeTreasury GetByFeeTreasuryId(System.Decimal _feeTreasuryId, int start, int pageLength, out int count)
		{
			return GetByFeeTreasuryId(null, _feeTreasuryId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_TREASURY index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeTreasuryId">الخزنة  الايرادات والمنصرف</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeTreasury"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.FeeTreasury GetByFeeTreasuryId(TransactionManager transactionManager, System.Decimal _feeTreasuryId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;FeeTreasury&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;FeeTreasury&gt;"/></returns>
		public static TList<FeeTreasury> Fill(IDataReader reader, TList<FeeTreasury> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.FeeTreasury c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("FeeTreasury")
					.Append("|").Append((System.Decimal)reader["FEE_TREASURY_ID"]).ToString();
					c = EntityManager.LocateOrCreate<FeeTreasury>(
					key.ToString(), // EntityTrackingKey
					"FeeTreasury",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.FeeTreasury();
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
					c.FeeTreasuryId = (System.Decimal)reader["FEE_TREASURY_ID"];
					c.OriginalFeeTreasuryId = c.FeeTreasuryId;
					c.EdAcadYearId = (System.Decimal)reader["ED_ACAD_YEAR_ID"];
					c.TrsNumber = Convert.IsDBNull(reader["TRS_NUMBER"]) ? null : (System.String)reader["TRS_NUMBER"];
					c.TrsName = Convert.IsDBNull(reader["TRS_NAME"]) ? null : (System.String)reader["TRS_NAME"];
					c.TrsDescrAr = Convert.IsDBNull(reader["TRS_DESCR_AR"]) ? null : (System.String)reader["TRS_DESCR_AR"];
					c.TrsDescrEn = Convert.IsDBNull(reader["TRS_DESCR_EN"]) ? null : (System.String)reader["TRS_DESCR_EN"];
					c.OutAmount = Convert.IsDBNull(reader["OUT_AMOUNT"]) ? null : (System.Decimal?)reader["OUT_AMOUNT"];
					c.InAmount = Convert.IsDBNull(reader["IN_AMOUNT"]) ? null : (System.Decimal?)reader["IN_AMOUNT"];
					c.RemainAmount = Convert.IsDBNull(reader["REMAIN_AMOUNT"]) ? null : (System.Decimal?)reader["REMAIN_AMOUNT"];
					c.TransDate = Convert.IsDBNull(reader["TRANS_DATE"]) ? null : (System.DateTime?)reader["TRANS_DATE"];
					c.TransSeUserId = Convert.IsDBNull(reader["TRANS_SE_USER_ID"]) ? null : (System.Decimal?)reader["TRANS_SE_USER_ID"];
					c.TransUsrName = Convert.IsDBNull(reader["TRANS_USR_NAME"]) ? null : (System.String)reader["TRANS_USR_NAME"];
					c.FeeStudVoucherId = Convert.IsDBNull(reader["FEE_STUD_VOUCHER_ID"]) ? null : (System.Decimal?)reader["FEE_STUD_VOUCHER_ID"];
					c.FeeCdeTrsryId = Convert.IsDBNull(reader["FEE_CDE_TRSRY_ID"]) ? null : (System.Int32?)reader["FEE_CDE_TRSRY_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeTreasury"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeTreasury"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.FeeTreasury entity)
		{
			if (!reader.Read()) return;
			
			entity.FeeTreasuryId = (System.Decimal)reader[((int)FeeTreasuryColumn.FeeTreasuryId - 1)];
			entity.OriginalFeeTreasuryId = (System.Decimal)reader["FEE_TREASURY_ID"];
			entity.EdAcadYearId = (System.Decimal)reader[((int)FeeTreasuryColumn.EdAcadYearId - 1)];
			entity.TrsNumber = (reader.IsDBNull(((int)FeeTreasuryColumn.TrsNumber - 1)))?null:(System.String)reader[((int)FeeTreasuryColumn.TrsNumber - 1)];
			entity.TrsName = (reader.IsDBNull(((int)FeeTreasuryColumn.TrsName - 1)))?null:(System.String)reader[((int)FeeTreasuryColumn.TrsName - 1)];
			entity.TrsDescrAr = (reader.IsDBNull(((int)FeeTreasuryColumn.TrsDescrAr - 1)))?null:(System.String)reader[((int)FeeTreasuryColumn.TrsDescrAr - 1)];
			entity.TrsDescrEn = (reader.IsDBNull(((int)FeeTreasuryColumn.TrsDescrEn - 1)))?null:(System.String)reader[((int)FeeTreasuryColumn.TrsDescrEn - 1)];
			entity.OutAmount = (reader.IsDBNull(((int)FeeTreasuryColumn.OutAmount - 1)))?null:(System.Decimal?)reader[((int)FeeTreasuryColumn.OutAmount - 1)];
			entity.InAmount = (reader.IsDBNull(((int)FeeTreasuryColumn.InAmount - 1)))?null:(System.Decimal?)reader[((int)FeeTreasuryColumn.InAmount - 1)];
			entity.RemainAmount = (reader.IsDBNull(((int)FeeTreasuryColumn.RemainAmount - 1)))?null:(System.Decimal?)reader[((int)FeeTreasuryColumn.RemainAmount - 1)];
			entity.TransDate = (reader.IsDBNull(((int)FeeTreasuryColumn.TransDate - 1)))?null:(System.DateTime?)reader[((int)FeeTreasuryColumn.TransDate - 1)];
			entity.TransSeUserId = (reader.IsDBNull(((int)FeeTreasuryColumn.TransSeUserId - 1)))?null:(System.Decimal?)reader[((int)FeeTreasuryColumn.TransSeUserId - 1)];
			entity.TransUsrName = (reader.IsDBNull(((int)FeeTreasuryColumn.TransUsrName - 1)))?null:(System.String)reader[((int)FeeTreasuryColumn.TransUsrName - 1)];
			entity.FeeStudVoucherId = (reader.IsDBNull(((int)FeeTreasuryColumn.FeeStudVoucherId - 1)))?null:(System.Decimal?)reader[((int)FeeTreasuryColumn.FeeStudVoucherId - 1)];
			entity.FeeCdeTrsryId = (reader.IsDBNull(((int)FeeTreasuryColumn.FeeCdeTrsryId - 1)))?null:(System.Int32?)reader[((int)FeeTreasuryColumn.FeeCdeTrsryId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeTreasury"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeTreasury"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.FeeTreasury entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.FeeTreasuryId = (System.Decimal)dataRow["FEE_TREASURY_ID"];
			entity.OriginalFeeTreasuryId = (System.Decimal)dataRow["FEE_TREASURY_ID"];
			entity.EdAcadYearId = (System.Decimal)dataRow["ED_ACAD_YEAR_ID"];
			entity.TrsNumber = Convert.IsDBNull(dataRow["TRS_NUMBER"]) ? null : (System.String)dataRow["TRS_NUMBER"];
			entity.TrsName = Convert.IsDBNull(dataRow["TRS_NAME"]) ? null : (System.String)dataRow["TRS_NAME"];
			entity.TrsDescrAr = Convert.IsDBNull(dataRow["TRS_DESCR_AR"]) ? null : (System.String)dataRow["TRS_DESCR_AR"];
			entity.TrsDescrEn = Convert.IsDBNull(dataRow["TRS_DESCR_EN"]) ? null : (System.String)dataRow["TRS_DESCR_EN"];
			entity.OutAmount = Convert.IsDBNull(dataRow["OUT_AMOUNT"]) ? null : (System.Decimal?)dataRow["OUT_AMOUNT"];
			entity.InAmount = Convert.IsDBNull(dataRow["IN_AMOUNT"]) ? null : (System.Decimal?)dataRow["IN_AMOUNT"];
			entity.RemainAmount = Convert.IsDBNull(dataRow["REMAIN_AMOUNT"]) ? null : (System.Decimal?)dataRow["REMAIN_AMOUNT"];
			entity.TransDate = Convert.IsDBNull(dataRow["TRANS_DATE"]) ? null : (System.DateTime?)dataRow["TRANS_DATE"];
			entity.TransSeUserId = Convert.IsDBNull(dataRow["TRANS_SE_USER_ID"]) ? null : (System.Decimal?)dataRow["TRANS_SE_USER_ID"];
			entity.TransUsrName = Convert.IsDBNull(dataRow["TRANS_USR_NAME"]) ? null : (System.String)dataRow["TRANS_USR_NAME"];
			entity.FeeStudVoucherId = Convert.IsDBNull(dataRow["FEE_STUD_VOUCHER_ID"]) ? null : (System.Decimal?)dataRow["FEE_STUD_VOUCHER_ID"];
			entity.FeeCdeTrsryId = Convert.IsDBNull(dataRow["FEE_CDE_TRSRY_ID"]) ? null : (System.Int32?)dataRow["FEE_CDE_TRSRY_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeTreasury"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeTreasury Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeTreasury entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
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

			#region FeeCdeTrsryIdSource	
			if (CanDeepLoad(entity, "FeeCdeTrsry|FeeCdeTrsryIdSource", deepLoadType, innerList) 
				&& entity.FeeCdeTrsryIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.FeeCdeTrsryId ?? (int)0);
				FeeCdeTrsry tmpEntity = EntityManager.LocateEntity<FeeCdeTrsry>(EntityLocator.ConstructKeyFromPkItems(typeof(FeeCdeTrsry), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.FeeCdeTrsryIdSource = tmpEntity;
				else
					entity.FeeCdeTrsryIdSource = DataRepository.FeeCdeTrsryProvider.GetByFeeCdeTrsryId(transactionManager, (entity.FeeCdeTrsryId ?? (int)0));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeCdeTrsryIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.FeeCdeTrsryIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.FeeCdeTrsryProvider.DeepLoad(transactionManager, entity.FeeCdeTrsryIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion FeeCdeTrsryIdSource

			#region FeeStudVoucherIdSource	
			if (CanDeepLoad(entity, "FeeStudVoucher|FeeStudVoucherIdSource", deepLoadType, innerList) 
				&& entity.FeeStudVoucherIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.FeeStudVoucherId ?? 0.0m);
				FeeStudVoucher tmpEntity = EntityManager.LocateEntity<FeeStudVoucher>(EntityLocator.ConstructKeyFromPkItems(typeof(FeeStudVoucher), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.FeeStudVoucherIdSource = tmpEntity;
				else
					entity.FeeStudVoucherIdSource = DataRepository.FeeStudVoucherProvider.GetByFeeStudVoucherId(transactionManager, (entity.FeeStudVoucherId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeStudVoucherIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.FeeStudVoucherIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.FeeStudVoucherProvider.DeepLoad(transactionManager, entity.FeeStudVoucherIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion FeeStudVoucherIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.FeeTreasury object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.FeeTreasury instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeTreasury Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeTreasury entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
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
			
			#region FeeCdeTrsryIdSource
			if (CanDeepSave(entity, "FeeCdeTrsry|FeeCdeTrsryIdSource", deepSaveType, innerList) 
				&& entity.FeeCdeTrsryIdSource != null)
			{
				DataRepository.FeeCdeTrsryProvider.Save(transactionManager, entity.FeeCdeTrsryIdSource);
				entity.FeeCdeTrsryId = entity.FeeCdeTrsryIdSource.FeeCdeTrsryId;
			}
			#endregion 
			
			#region FeeStudVoucherIdSource
			if (CanDeepSave(entity, "FeeStudVoucher|FeeStudVoucherIdSource", deepSaveType, innerList) 
				&& entity.FeeStudVoucherIdSource != null)
			{
				DataRepository.FeeStudVoucherProvider.Save(transactionManager, entity.FeeStudVoucherIdSource);
				entity.FeeStudVoucherId = entity.FeeStudVoucherIdSource.FeeStudVoucherId;
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
	
	#region FeeTreasuryChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.FeeTreasury</c>
	///</summary>
	public enum FeeTreasuryChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>EdAcadYear</c> at EdAcadYearIdSource
		///</summary>
		[ChildEntityType(typeof(EdAcadYear))]
		EdAcadYear,
		
		///<summary>
		/// Composite Property for <c>FeeCdeTrsry</c> at FeeCdeTrsryIdSource
		///</summary>
		[ChildEntityType(typeof(FeeCdeTrsry))]
		FeeCdeTrsry,
		
		///<summary>
		/// Composite Property for <c>FeeStudVoucher</c> at FeeStudVoucherIdSource
		///</summary>
		[ChildEntityType(typeof(FeeStudVoucher))]
		FeeStudVoucher,
	}
	
	#endregion FeeTreasuryChildEntityTypes
	
	#region FeeTreasuryFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;FeeTreasuryColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeTreasury"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeTreasuryFilterBuilder : SqlFilterBuilder<FeeTreasuryColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeTreasuryFilterBuilder class.
		/// </summary>
		public FeeTreasuryFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeTreasuryFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeTreasuryFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeTreasuryFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeTreasuryFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeTreasuryFilterBuilder
	
	#region FeeTreasuryParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;FeeTreasuryColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeTreasury"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeTreasuryParameterBuilder : ParameterizedSqlFilterBuilder<FeeTreasuryColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeTreasuryParameterBuilder class.
		/// </summary>
		public FeeTreasuryParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeTreasuryParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeTreasuryParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeTreasuryParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeTreasuryParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeTreasuryParameterBuilder
	
	#region FeeTreasurySortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;FeeTreasuryColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeTreasury"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class FeeTreasurySortBuilder : SqlSortBuilder<FeeTreasuryColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeTreasurySqlSortBuilder class.
		/// </summary>
		public FeeTreasurySortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion FeeTreasurySortBuilder
	
} // end namespace
