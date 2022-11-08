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
	/// This class is the base class for any <see cref="AdmFeeQualCatProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AdmFeeQualCatProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AdmFeeQualCat, UMIS_VER2.BusinessLyer.AdmFeeQualCatKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmFeeQualCatKey key)
		{
			return Delete(transactionManager, key.AdmFeeQualCatId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_admFeeQualCatId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _admFeeQualCatId)
		{
			return Delete(null, _admFeeQualCatId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admFeeQualCatId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _admFeeQualCatId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_FEE_QUAL_CAT_ADM_CDE_FEE key.
		///		FK_ADM_FEE_QUAL_CAT_ADM_CDE_FEE Description: 
		/// </summary>
		/// <param name="_admCdeFeeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmFeeQualCat objects.</returns>
		public TList<AdmFeeQualCat> GetByAdmCdeFeeId(System.Decimal _admCdeFeeId)
		{
			int count = -1;
			return GetByAdmCdeFeeId(_admCdeFeeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_FEE_QUAL_CAT_ADM_CDE_FEE key.
		///		FK_ADM_FEE_QUAL_CAT_ADM_CDE_FEE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeFeeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmFeeQualCat objects.</returns>
		/// <remarks></remarks>
		public TList<AdmFeeQualCat> GetByAdmCdeFeeId(TransactionManager transactionManager, System.Decimal _admCdeFeeId)
		{
			int count = -1;
			return GetByAdmCdeFeeId(transactionManager, _admCdeFeeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_FEE_QUAL_CAT_ADM_CDE_FEE key.
		///		FK_ADM_FEE_QUAL_CAT_ADM_CDE_FEE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeFeeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmFeeQualCat objects.</returns>
		public TList<AdmFeeQualCat> GetByAdmCdeFeeId(TransactionManager transactionManager, System.Decimal _admCdeFeeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCdeFeeId(transactionManager, _admCdeFeeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_FEE_QUAL_CAT_ADM_CDE_FEE key.
		///		fkAdmFeeQualCatAdmCdeFee Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admCdeFeeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmFeeQualCat objects.</returns>
		public TList<AdmFeeQualCat> GetByAdmCdeFeeId(System.Decimal _admCdeFeeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmCdeFeeId(null, _admCdeFeeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_FEE_QUAL_CAT_ADM_CDE_FEE key.
		///		fkAdmFeeQualCatAdmCdeFee Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admCdeFeeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmFeeQualCat objects.</returns>
		public TList<AdmFeeQualCat> GetByAdmCdeFeeId(System.Decimal _admCdeFeeId, int start, int pageLength,out int count)
		{
			return GetByAdmCdeFeeId(null, _admCdeFeeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_FEE_QUAL_CAT_ADM_CDE_FEE key.
		///		FK_ADM_FEE_QUAL_CAT_ADM_CDE_FEE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeFeeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmFeeQualCat objects.</returns>
		public abstract TList<AdmFeeQualCat> GetByAdmCdeFeeId(TransactionManager transactionManager, System.Decimal _admCdeFeeId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_FEE_QUAL_CAT_ED_CDE_QUAL_CAT key.
		///		FK_ADM_FEE_QUAL_CAT_ED_CDE_QUAL_CAT Description: 
		/// </summary>
		/// <param name="_edCdeQualCatId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmFeeQualCat objects.</returns>
		public TList<AdmFeeQualCat> GetByEdCdeQualCatId(System.Decimal _edCdeQualCatId)
		{
			int count = -1;
			return GetByEdCdeQualCatId(_edCdeQualCatId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_FEE_QUAL_CAT_ED_CDE_QUAL_CAT key.
		///		FK_ADM_FEE_QUAL_CAT_ED_CDE_QUAL_CAT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeQualCatId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmFeeQualCat objects.</returns>
		/// <remarks></remarks>
		public TList<AdmFeeQualCat> GetByEdCdeQualCatId(TransactionManager transactionManager, System.Decimal _edCdeQualCatId)
		{
			int count = -1;
			return GetByEdCdeQualCatId(transactionManager, _edCdeQualCatId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_FEE_QUAL_CAT_ED_CDE_QUAL_CAT key.
		///		FK_ADM_FEE_QUAL_CAT_ED_CDE_QUAL_CAT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeQualCatId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmFeeQualCat objects.</returns>
		public TList<AdmFeeQualCat> GetByEdCdeQualCatId(TransactionManager transactionManager, System.Decimal _edCdeQualCatId, int start, int pageLength)
		{
			int count = -1;
			return GetByEdCdeQualCatId(transactionManager, _edCdeQualCatId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_FEE_QUAL_CAT_ED_CDE_QUAL_CAT key.
		///		fkAdmFeeQualCatEdCdeQualCat Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCdeQualCatId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmFeeQualCat objects.</returns>
		public TList<AdmFeeQualCat> GetByEdCdeQualCatId(System.Decimal _edCdeQualCatId, int start, int pageLength)
		{
			int count =  -1;
			return GetByEdCdeQualCatId(null, _edCdeQualCatId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_FEE_QUAL_CAT_ED_CDE_QUAL_CAT key.
		///		fkAdmFeeQualCatEdCdeQualCat Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_edCdeQualCatId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmFeeQualCat objects.</returns>
		public TList<AdmFeeQualCat> GetByEdCdeQualCatId(System.Decimal _edCdeQualCatId, int start, int pageLength,out int count)
		{
			return GetByEdCdeQualCatId(null, _edCdeQualCatId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_FEE_QUAL_CAT_ED_CDE_QUAL_CAT key.
		///		FK_ADM_FEE_QUAL_CAT_ED_CDE_QUAL_CAT Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_edCdeQualCatId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmFeeQualCat objects.</returns>
		public abstract TList<AdmFeeQualCat> GetByEdCdeQualCatId(TransactionManager transactionManager, System.Decimal _edCdeQualCatId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.AdmFeeQualCat Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmFeeQualCatKey key, int start, int pageLength)
		{
			return GetByAdmFeeQualCatId(transactionManager, key.AdmFeeQualCatId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ADM_FEE_QUAL_CAT index.
		/// </summary>
		/// <param name="_admFeeQualCatId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmFeeQualCat"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmFeeQualCat GetByAdmFeeQualCatId(System.Decimal _admFeeQualCatId)
		{
			int count = -1;
			return GetByAdmFeeQualCatId(null,_admFeeQualCatId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_FEE_QUAL_CAT index.
		/// </summary>
		/// <param name="_admFeeQualCatId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmFeeQualCat"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmFeeQualCat GetByAdmFeeQualCatId(System.Decimal _admFeeQualCatId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmFeeQualCatId(null, _admFeeQualCatId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_FEE_QUAL_CAT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admFeeQualCatId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmFeeQualCat"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmFeeQualCat GetByAdmFeeQualCatId(TransactionManager transactionManager, System.Decimal _admFeeQualCatId)
		{
			int count = -1;
			return GetByAdmFeeQualCatId(transactionManager, _admFeeQualCatId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_FEE_QUAL_CAT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admFeeQualCatId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmFeeQualCat"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmFeeQualCat GetByAdmFeeQualCatId(TransactionManager transactionManager, System.Decimal _admFeeQualCatId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmFeeQualCatId(transactionManager, _admFeeQualCatId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_FEE_QUAL_CAT index.
		/// </summary>
		/// <param name="_admFeeQualCatId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmFeeQualCat"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmFeeQualCat GetByAdmFeeQualCatId(System.Decimal _admFeeQualCatId, int start, int pageLength, out int count)
		{
			return GetByAdmFeeQualCatId(null, _admFeeQualCatId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_FEE_QUAL_CAT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admFeeQualCatId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmFeeQualCat"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmFeeQualCat GetByAdmFeeQualCatId(TransactionManager transactionManager, System.Decimal _admFeeQualCatId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ADM_CDE_FEE_ED_CDE_QUAL_CAT index.
		/// </summary>
		/// <param name="_admCdeFeeId"></param>
		/// <param name="_edCdeQualCatId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmFeeQualCat"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmFeeQualCat GetByAdmCdeFeeIdEdCdeQualCatId(System.Decimal _admCdeFeeId, System.Decimal _edCdeQualCatId)
		{
			int count = -1;
			return GetByAdmCdeFeeIdEdCdeQualCatId(null,_admCdeFeeId, _edCdeQualCatId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_CDE_FEE_ED_CDE_QUAL_CAT index.
		/// </summary>
		/// <param name="_admCdeFeeId"></param>
		/// <param name="_edCdeQualCatId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmFeeQualCat"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmFeeQualCat GetByAdmCdeFeeIdEdCdeQualCatId(System.Decimal _admCdeFeeId, System.Decimal _edCdeQualCatId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCdeFeeIdEdCdeQualCatId(null, _admCdeFeeId, _edCdeQualCatId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_CDE_FEE_ED_CDE_QUAL_CAT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeFeeId"></param>
		/// <param name="_edCdeQualCatId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmFeeQualCat"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmFeeQualCat GetByAdmCdeFeeIdEdCdeQualCatId(TransactionManager transactionManager, System.Decimal _admCdeFeeId, System.Decimal _edCdeQualCatId)
		{
			int count = -1;
			return GetByAdmCdeFeeIdEdCdeQualCatId(transactionManager, _admCdeFeeId, _edCdeQualCatId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_CDE_FEE_ED_CDE_QUAL_CAT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeFeeId"></param>
		/// <param name="_edCdeQualCatId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmFeeQualCat"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmFeeQualCat GetByAdmCdeFeeIdEdCdeQualCatId(TransactionManager transactionManager, System.Decimal _admCdeFeeId, System.Decimal _edCdeQualCatId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmCdeFeeIdEdCdeQualCatId(transactionManager, _admCdeFeeId, _edCdeQualCatId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_CDE_FEE_ED_CDE_QUAL_CAT index.
		/// </summary>
		/// <param name="_admCdeFeeId"></param>
		/// <param name="_edCdeQualCatId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmFeeQualCat"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmFeeQualCat GetByAdmCdeFeeIdEdCdeQualCatId(System.Decimal _admCdeFeeId, System.Decimal _edCdeQualCatId, int start, int pageLength, out int count)
		{
			return GetByAdmCdeFeeIdEdCdeQualCatId(null, _admCdeFeeId, _edCdeQualCatId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_CDE_FEE_ED_CDE_QUAL_CAT index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admCdeFeeId"></param>
		/// <param name="_edCdeQualCatId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmFeeQualCat"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmFeeQualCat GetByAdmCdeFeeIdEdCdeQualCatId(TransactionManager transactionManager, System.Decimal _admCdeFeeId, System.Decimal _edCdeQualCatId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AdmFeeQualCat&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AdmFeeQualCat&gt;"/></returns>
		public static TList<AdmFeeQualCat> Fill(IDataReader reader, TList<AdmFeeQualCat> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AdmFeeQualCat c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AdmFeeQualCat")
					.Append("|").Append((System.Decimal)reader["ADM_FEE_QUAL_CAT_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AdmFeeQualCat>(
					key.ToString(), // EntityTrackingKey
					"AdmFeeQualCat",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AdmFeeQualCat();
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
					c.AdmFeeQualCatId = (System.Decimal)reader["ADM_FEE_QUAL_CAT_ID"];
					c.OriginalAdmFeeQualCatId = c.AdmFeeQualCatId;
					c.AdmCdeFeeId = (System.Decimal)reader["ADM_CDE_FEE_ID"];
					c.EdCdeQualCatId = (System.Decimal)reader["ED_CDE_QUAL_CAT_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmFeeQualCat"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmFeeQualCat"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AdmFeeQualCat entity)
		{
			if (!reader.Read()) return;
			
			entity.AdmFeeQualCatId = (System.Decimal)reader[((int)AdmFeeQualCatColumn.AdmFeeQualCatId - 1)];
			entity.OriginalAdmFeeQualCatId = (System.Decimal)reader["ADM_FEE_QUAL_CAT_ID"];
			entity.AdmCdeFeeId = (System.Decimal)reader[((int)AdmFeeQualCatColumn.AdmCdeFeeId - 1)];
			entity.EdCdeQualCatId = (System.Decimal)reader[((int)AdmFeeQualCatColumn.EdCdeQualCatId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmFeeQualCat"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmFeeQualCat"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AdmFeeQualCat entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AdmFeeQualCatId = (System.Decimal)dataRow["ADM_FEE_QUAL_CAT_ID"];
			entity.OriginalAdmFeeQualCatId = (System.Decimal)dataRow["ADM_FEE_QUAL_CAT_ID"];
			entity.AdmCdeFeeId = (System.Decimal)dataRow["ADM_CDE_FEE_ID"];
			entity.EdCdeQualCatId = (System.Decimal)dataRow["ED_CDE_QUAL_CAT_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmFeeQualCat"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmFeeQualCat Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmFeeQualCat entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AdmCdeFeeIdSource	
			if (CanDeepLoad(entity, "AdmCdeFee|AdmCdeFeeIdSource", deepLoadType, innerList) 
				&& entity.AdmCdeFeeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AdmCdeFeeId;
				AdmCdeFee tmpEntity = EntityManager.LocateEntity<AdmCdeFee>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmCdeFee), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmCdeFeeIdSource = tmpEntity;
				else
					entity.AdmCdeFeeIdSource = DataRepository.AdmCdeFeeProvider.GetByAdmCdeFeeId(transactionManager, entity.AdmCdeFeeId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmCdeFeeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmCdeFeeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmCdeFeeProvider.DeepLoad(transactionManager, entity.AdmCdeFeeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmCdeFeeIdSource

			#region EdCdeQualCatIdSource	
			if (CanDeepLoad(entity, "EdCdeQualCat|EdCdeQualCatIdSource", deepLoadType, innerList) 
				&& entity.EdCdeQualCatIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.EdCdeQualCatId;
				EdCdeQualCat tmpEntity = EntityManager.LocateEntity<EdCdeQualCat>(EntityLocator.ConstructKeyFromPkItems(typeof(EdCdeQualCat), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.EdCdeQualCatIdSource = tmpEntity;
				else
					entity.EdCdeQualCatIdSource = DataRepository.EdCdeQualCatProvider.GetByEdCdeQualCatId(transactionManager, entity.EdCdeQualCatId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'EdCdeQualCatIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.EdCdeQualCatIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.EdCdeQualCatProvider.DeepLoad(transactionManager, entity.EdCdeQualCatIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion EdCdeQualCatIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AdmFeeQualCat object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AdmFeeQualCat instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmFeeQualCat Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmFeeQualCat entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AdmCdeFeeIdSource
			if (CanDeepSave(entity, "AdmCdeFee|AdmCdeFeeIdSource", deepSaveType, innerList) 
				&& entity.AdmCdeFeeIdSource != null)
			{
				DataRepository.AdmCdeFeeProvider.Save(transactionManager, entity.AdmCdeFeeIdSource);
				entity.AdmCdeFeeId = entity.AdmCdeFeeIdSource.AdmCdeFeeId;
			}
			#endregion 
			
			#region EdCdeQualCatIdSource
			if (CanDeepSave(entity, "EdCdeQualCat|EdCdeQualCatIdSource", deepSaveType, innerList) 
				&& entity.EdCdeQualCatIdSource != null)
			{
				DataRepository.EdCdeQualCatProvider.Save(transactionManager, entity.EdCdeQualCatIdSource);
				entity.EdCdeQualCatId = entity.EdCdeQualCatIdSource.EdCdeQualCatId;
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
	
	#region AdmFeeQualCatChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AdmFeeQualCat</c>
	///</summary>
	public enum AdmFeeQualCatChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AdmCdeFee</c> at AdmCdeFeeIdSource
		///</summary>
		[ChildEntityType(typeof(AdmCdeFee))]
		AdmCdeFee,
		
		///<summary>
		/// Composite Property for <c>EdCdeQualCat</c> at EdCdeQualCatIdSource
		///</summary>
		[ChildEntityType(typeof(EdCdeQualCat))]
		EdCdeQualCat,
	}
	
	#endregion AdmFeeQualCatChildEntityTypes
	
	#region AdmFeeQualCatFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AdmFeeQualCatColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmFeeQualCat"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmFeeQualCatFilterBuilder : SqlFilterBuilder<AdmFeeQualCatColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmFeeQualCatFilterBuilder class.
		/// </summary>
		public AdmFeeQualCatFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmFeeQualCatFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmFeeQualCatFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmFeeQualCatFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmFeeQualCatFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmFeeQualCatFilterBuilder
	
	#region AdmFeeQualCatParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AdmFeeQualCatColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmFeeQualCat"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmFeeQualCatParameterBuilder : ParameterizedSqlFilterBuilder<AdmFeeQualCatColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmFeeQualCatParameterBuilder class.
		/// </summary>
		public AdmFeeQualCatParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmFeeQualCatParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmFeeQualCatParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmFeeQualCatParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmFeeQualCatParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmFeeQualCatParameterBuilder
	
	#region AdmFeeQualCatSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AdmFeeQualCatColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmFeeQualCat"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AdmFeeQualCatSortBuilder : SqlSortBuilder<AdmFeeQualCatColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmFeeQualCatSqlSortBuilder class.
		/// </summary>
		public AdmFeeQualCatSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AdmFeeQualCatSortBuilder
	
} // end namespace
