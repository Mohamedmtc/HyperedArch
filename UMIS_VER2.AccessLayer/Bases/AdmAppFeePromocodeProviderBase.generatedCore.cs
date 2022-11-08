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
	/// This class is the base class for any <see cref="AdmAppFeePromocodeProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AdmAppFeePromocodeProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.AdmAppFeePromocode, UMIS_VER2.BusinessLyer.AdmAppFeePromocodeKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppFeePromocodeKey key)
		{
			return Delete(transactionManager, key.AdmAppFeePromocodeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_admAppFeePromocodeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _admAppFeePromocodeId)
		{
			return Delete(null, _admAppFeePromocodeId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppFeePromocodeId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _admAppFeePromocodeId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_FEE_PROMOCODE_ADM_APP_REG_HISTORY key.
		///		FK_ADM_APP_FEE_PROMOCODE_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="_admAppRegHistoryId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppFeePromocode objects.</returns>
		public TList<AdmAppFeePromocode> GetByAdmAppRegHistoryId(System.Decimal? _admAppRegHistoryId)
		{
			int count = -1;
			return GetByAdmAppRegHistoryId(_admAppRegHistoryId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_FEE_PROMOCODE_ADM_APP_REG_HISTORY key.
		///		FK_ADM_APP_FEE_PROMOCODE_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppFeePromocode objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAppFeePromocode> GetByAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal? _admAppRegHistoryId)
		{
			int count = -1;
			return GetByAdmAppRegHistoryId(transactionManager, _admAppRegHistoryId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_FEE_PROMOCODE_ADM_APP_REG_HISTORY key.
		///		FK_ADM_APP_FEE_PROMOCODE_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppFeePromocode objects.</returns>
		public TList<AdmAppFeePromocode> GetByAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal? _admAppRegHistoryId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppRegHistoryId(transactionManager, _admAppRegHistoryId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_FEE_PROMOCODE_ADM_APP_REG_HISTORY key.
		///		fkAdmAppFeePromocodeAdmAppRegHistory Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppFeePromocode objects.</returns>
		public TList<AdmAppFeePromocode> GetByAdmAppRegHistoryId(System.Decimal? _admAppRegHistoryId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmAppRegHistoryId(null, _admAppRegHistoryId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_FEE_PROMOCODE_ADM_APP_REG_HISTORY key.
		///		fkAdmAppFeePromocodeAdmAppRegHistory Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppFeePromocode objects.</returns>
		public TList<AdmAppFeePromocode> GetByAdmAppRegHistoryId(System.Decimal? _admAppRegHistoryId, int start, int pageLength,out int count)
		{
			return GetByAdmAppRegHistoryId(null, _admAppRegHistoryId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_FEE_PROMOCODE_ADM_APP_REG_HISTORY key.
		///		FK_ADM_APP_FEE_PROMOCODE_ADM_APP_REG_HISTORY Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppFeePromocode objects.</returns>
		public abstract TList<AdmAppFeePromocode> GetByAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal? _admAppRegHistoryId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_FEE_PROMOCODE_ADM_FEE_PROMOCODE key.
		///		FK_ADM_APP_FEE_PROMOCODE_ADM_FEE_PROMOCODE Description: 
		/// </summary>
		/// <param name="_admFeePromocodeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppFeePromocode objects.</returns>
		public TList<AdmAppFeePromocode> GetByAdmFeePromocodeId(System.Decimal _admFeePromocodeId)
		{
			int count = -1;
			return GetByAdmFeePromocodeId(_admFeePromocodeId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_FEE_PROMOCODE_ADM_FEE_PROMOCODE key.
		///		FK_ADM_APP_FEE_PROMOCODE_ADM_FEE_PROMOCODE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admFeePromocodeId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppFeePromocode objects.</returns>
		/// <remarks></remarks>
		public TList<AdmAppFeePromocode> GetByAdmFeePromocodeId(TransactionManager transactionManager, System.Decimal _admFeePromocodeId)
		{
			int count = -1;
			return GetByAdmFeePromocodeId(transactionManager, _admFeePromocodeId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_FEE_PROMOCODE_ADM_FEE_PROMOCODE key.
		///		FK_ADM_APP_FEE_PROMOCODE_ADM_FEE_PROMOCODE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admFeePromocodeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppFeePromocode objects.</returns>
		public TList<AdmAppFeePromocode> GetByAdmFeePromocodeId(TransactionManager transactionManager, System.Decimal _admFeePromocodeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmFeePromocodeId(transactionManager, _admFeePromocodeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_FEE_PROMOCODE_ADM_FEE_PROMOCODE key.
		///		fkAdmAppFeePromocodeAdmFeePromocode Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admFeePromocodeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppFeePromocode objects.</returns>
		public TList<AdmAppFeePromocode> GetByAdmFeePromocodeId(System.Decimal _admFeePromocodeId, int start, int pageLength)
		{
			int count =  -1;
			return GetByAdmFeePromocodeId(null, _admFeePromocodeId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_FEE_PROMOCODE_ADM_FEE_PROMOCODE key.
		///		fkAdmAppFeePromocodeAdmFeePromocode Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_admFeePromocodeId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppFeePromocode objects.</returns>
		public TList<AdmAppFeePromocode> GetByAdmFeePromocodeId(System.Decimal _admFeePromocodeId, int start, int pageLength,out int count)
		{
			return GetByAdmFeePromocodeId(null, _admFeePromocodeId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_ADM_APP_FEE_PROMOCODE_ADM_FEE_PROMOCODE key.
		///		FK_ADM_APP_FEE_PROMOCODE_ADM_FEE_PROMOCODE Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admFeePromocodeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.AdmAppFeePromocode objects.</returns>
		public abstract TList<AdmAppFeePromocode> GetByAdmFeePromocodeId(TransactionManager transactionManager, System.Decimal _admFeePromocodeId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.AdmAppFeePromocode Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppFeePromocodeKey key, int start, int pageLength)
		{
			return GetByAdmAppFeePromocodeId(transactionManager, key.AdmAppFeePromocodeId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_ADM_APP_FEE_PROMOCODE index.
		/// </summary>
		/// <param name="_admAppFeePromocodeId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppFeePromocode"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppFeePromocode GetByAdmAppFeePromocodeId(System.Decimal _admAppFeePromocodeId)
		{
			int count = -1;
			return GetByAdmAppFeePromocodeId(null,_admAppFeePromocodeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_FEE_PROMOCODE index.
		/// </summary>
		/// <param name="_admAppFeePromocodeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppFeePromocode"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppFeePromocode GetByAdmAppFeePromocodeId(System.Decimal _admAppFeePromocodeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppFeePromocodeId(null, _admAppFeePromocodeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_FEE_PROMOCODE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppFeePromocodeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppFeePromocode"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppFeePromocode GetByAdmAppFeePromocodeId(TransactionManager transactionManager, System.Decimal _admAppFeePromocodeId)
		{
			int count = -1;
			return GetByAdmAppFeePromocodeId(transactionManager, _admAppFeePromocodeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_FEE_PROMOCODE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppFeePromocodeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppFeePromocode"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppFeePromocode GetByAdmAppFeePromocodeId(TransactionManager transactionManager, System.Decimal _admAppFeePromocodeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppFeePromocodeId(transactionManager, _admAppFeePromocodeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_FEE_PROMOCODE index.
		/// </summary>
		/// <param name="_admAppFeePromocodeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppFeePromocode"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppFeePromocode GetByAdmAppFeePromocodeId(System.Decimal _admAppFeePromocodeId, int start, int pageLength, out int count)
		{
			return GetByAdmAppFeePromocodeId(null, _admAppFeePromocodeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_ADM_APP_FEE_PROMOCODE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppFeePromocodeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppFeePromocode"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmAppFeePromocode GetByAdmAppFeePromocodeId(TransactionManager transactionManager, System.Decimal _admAppFeePromocodeId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_ADM_APP_FEE_PROMOCODE index.
		/// </summary>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="_admFeePromocodeId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppFeePromocode"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppFeePromocode GetByAdmAppRegHistoryIdAdmFeePromocodeId(System.Decimal? _admAppRegHistoryId, System.Decimal _admFeePromocodeId)
		{
			int count = -1;
			return GetByAdmAppRegHistoryIdAdmFeePromocodeId(null,_admAppRegHistoryId, _admFeePromocodeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_APP_FEE_PROMOCODE index.
		/// </summary>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="_admFeePromocodeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppFeePromocode"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppFeePromocode GetByAdmAppRegHistoryIdAdmFeePromocodeId(System.Decimal? _admAppRegHistoryId, System.Decimal _admFeePromocodeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppRegHistoryIdAdmFeePromocodeId(null, _admAppRegHistoryId, _admFeePromocodeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_APP_FEE_PROMOCODE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="_admFeePromocodeId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppFeePromocode"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppFeePromocode GetByAdmAppRegHistoryIdAdmFeePromocodeId(TransactionManager transactionManager, System.Decimal? _admAppRegHistoryId, System.Decimal _admFeePromocodeId)
		{
			int count = -1;
			return GetByAdmAppRegHistoryIdAdmFeePromocodeId(transactionManager, _admAppRegHistoryId, _admFeePromocodeId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_APP_FEE_PROMOCODE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="_admFeePromocodeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppFeePromocode"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppFeePromocode GetByAdmAppRegHistoryIdAdmFeePromocodeId(TransactionManager transactionManager, System.Decimal? _admAppRegHistoryId, System.Decimal _admFeePromocodeId, int start, int pageLength)
		{
			int count = -1;
			return GetByAdmAppRegHistoryIdAdmFeePromocodeId(transactionManager, _admAppRegHistoryId, _admFeePromocodeId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_APP_FEE_PROMOCODE index.
		/// </summary>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="_admFeePromocodeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppFeePromocode"/> class.</returns>
		public UMIS_VER2.BusinessLyer.AdmAppFeePromocode GetByAdmAppRegHistoryIdAdmFeePromocodeId(System.Decimal? _admAppRegHistoryId, System.Decimal _admFeePromocodeId, int start, int pageLength, out int count)
		{
			return GetByAdmAppRegHistoryIdAdmFeePromocodeId(null, _admAppRegHistoryId, _admFeePromocodeId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_ADM_APP_FEE_PROMOCODE index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_admAppRegHistoryId"></param>
		/// <param name="_admFeePromocodeId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.AdmAppFeePromocode"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.AdmAppFeePromocode GetByAdmAppRegHistoryIdAdmFeePromocodeId(TransactionManager transactionManager, System.Decimal? _admAppRegHistoryId, System.Decimal _admFeePromocodeId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;AdmAppFeePromocode&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;AdmAppFeePromocode&gt;"/></returns>
		public static TList<AdmAppFeePromocode> Fill(IDataReader reader, TList<AdmAppFeePromocode> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.AdmAppFeePromocode c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("AdmAppFeePromocode")
					.Append("|").Append((System.Decimal)reader["ADM_APP_FEE_PROMOCODE_ID"]).ToString();
					c = EntityManager.LocateOrCreate<AdmAppFeePromocode>(
					key.ToString(), // EntityTrackingKey
					"AdmAppFeePromocode",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.AdmAppFeePromocode();
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
					c.AdmAppFeePromocodeId = (System.Decimal)reader["ADM_APP_FEE_PROMOCODE_ID"];
					c.OriginalAdmAppFeePromocodeId = c.AdmAppFeePromocodeId;
					c.AdmFeePromocodeId = (System.Decimal)reader["ADM_FEE_PROMOCODE_ID"];
					c.AdmAppRegHistoryId = Convert.IsDBNull(reader["ADM_APP_REG_HISTORY_ID"]) ? null : (System.Decimal?)reader["ADM_APP_REG_HISTORY_ID"];
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
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmAppFeePromocode"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAppFeePromocode"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.AdmAppFeePromocode entity)
		{
			if (!reader.Read()) return;
			
			entity.AdmAppFeePromocodeId = (System.Decimal)reader[((int)AdmAppFeePromocodeColumn.AdmAppFeePromocodeId - 1)];
			entity.OriginalAdmAppFeePromocodeId = (System.Decimal)reader["ADM_APP_FEE_PROMOCODE_ID"];
			entity.AdmFeePromocodeId = (System.Decimal)reader[((int)AdmAppFeePromocodeColumn.AdmFeePromocodeId - 1)];
			entity.AdmAppRegHistoryId = (reader.IsDBNull(((int)AdmAppFeePromocodeColumn.AdmAppRegHistoryId - 1)))?null:(System.Decimal?)reader[((int)AdmAppFeePromocodeColumn.AdmAppRegHistoryId - 1)];
			entity.SeUserId = (reader.IsDBNull(((int)AdmAppFeePromocodeColumn.SeUserId - 1)))?null:(System.Decimal?)reader[((int)AdmAppFeePromocodeColumn.SeUserId - 1)];
			entity.LastDate = (reader.IsDBNull(((int)AdmAppFeePromocodeColumn.LastDate - 1)))?null:(System.DateTime?)reader[((int)AdmAppFeePromocodeColumn.LastDate - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.AdmAppFeePromocode"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAppFeePromocode"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.AdmAppFeePromocode entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AdmAppFeePromocodeId = (System.Decimal)dataRow["ADM_APP_FEE_PROMOCODE_ID"];
			entity.OriginalAdmAppFeePromocodeId = (System.Decimal)dataRow["ADM_APP_FEE_PROMOCODE_ID"];
			entity.AdmFeePromocodeId = (System.Decimal)dataRow["ADM_FEE_PROMOCODE_ID"];
			entity.AdmAppRegHistoryId = Convert.IsDBNull(dataRow["ADM_APP_REG_HISTORY_ID"]) ? null : (System.Decimal?)dataRow["ADM_APP_REG_HISTORY_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.AdmAppFeePromocode"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmAppFeePromocode Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppFeePromocode entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region AdmAppRegHistoryIdSource	
			if (CanDeepLoad(entity, "AdmAppRegHistory|AdmAppRegHistoryIdSource", deepLoadType, innerList) 
				&& entity.AdmAppRegHistoryIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.AdmAppRegHistoryId ?? 0.0m);
				AdmAppRegHistory tmpEntity = EntityManager.LocateEntity<AdmAppRegHistory>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmAppRegHistory), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmAppRegHistoryIdSource = tmpEntity;
				else
					entity.AdmAppRegHistoryIdSource = DataRepository.AdmAppRegHistoryProvider.GetByAdmAppRegHistoryId(transactionManager, (entity.AdmAppRegHistoryId ?? 0.0m));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmAppRegHistoryIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmAppRegHistoryIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmAppRegHistoryProvider.DeepLoad(transactionManager, entity.AdmAppRegHistoryIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmAppRegHistoryIdSource

			#region AdmFeePromocodeIdSource	
			if (CanDeepLoad(entity, "AdmFeePromocode|AdmFeePromocodeIdSource", deepLoadType, innerList) 
				&& entity.AdmFeePromocodeIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.AdmFeePromocodeId;
				AdmFeePromocode tmpEntity = EntityManager.LocateEntity<AdmFeePromocode>(EntityLocator.ConstructKeyFromPkItems(typeof(AdmFeePromocode), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.AdmFeePromocodeIdSource = tmpEntity;
				else
					entity.AdmFeePromocodeIdSource = DataRepository.AdmFeePromocodeProvider.GetByAdmFeePromocodeId(transactionManager, entity.AdmFeePromocodeId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'AdmFeePromocodeIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.AdmFeePromocodeIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.AdmFeePromocodeProvider.DeepLoad(transactionManager, entity.AdmFeePromocodeIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion AdmFeePromocodeIdSource
			
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.AdmAppFeePromocode object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.AdmAppFeePromocode instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.AdmAppFeePromocode Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmAppFeePromocode entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region AdmAppRegHistoryIdSource
			if (CanDeepSave(entity, "AdmAppRegHistory|AdmAppRegHistoryIdSource", deepSaveType, innerList) 
				&& entity.AdmAppRegHistoryIdSource != null)
			{
				DataRepository.AdmAppRegHistoryProvider.Save(transactionManager, entity.AdmAppRegHistoryIdSource);
				entity.AdmAppRegHistoryId = entity.AdmAppRegHistoryIdSource.AdmAppRegHistoryId;
			}
			#endregion 
			
			#region AdmFeePromocodeIdSource
			if (CanDeepSave(entity, "AdmFeePromocode|AdmFeePromocodeIdSource", deepSaveType, innerList) 
				&& entity.AdmFeePromocodeIdSource != null)
			{
				DataRepository.AdmFeePromocodeProvider.Save(transactionManager, entity.AdmFeePromocodeIdSource);
				entity.AdmFeePromocodeId = entity.AdmFeePromocodeIdSource.AdmFeePromocodeId;
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
	
	#region AdmAppFeePromocodeChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.AdmAppFeePromocode</c>
	///</summary>
	public enum AdmAppFeePromocodeChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>AdmAppRegHistory</c> at AdmAppRegHistoryIdSource
		///</summary>
		[ChildEntityType(typeof(AdmAppRegHistory))]
		AdmAppRegHistory,
		
		///<summary>
		/// Composite Property for <c>AdmFeePromocode</c> at AdmFeePromocodeIdSource
		///</summary>
		[ChildEntityType(typeof(AdmFeePromocode))]
		AdmFeePromocode,
	}
	
	#endregion AdmAppFeePromocodeChildEntityTypes
	
	#region AdmAppFeePromocodeFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;AdmAppFeePromocodeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAppFeePromocode"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmAppFeePromocodeFilterBuilder : SqlFilterBuilder<AdmAppFeePromocodeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAppFeePromocodeFilterBuilder class.
		/// </summary>
		public AdmAppFeePromocodeFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmAppFeePromocodeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmAppFeePromocodeFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmAppFeePromocodeFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmAppFeePromocodeFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmAppFeePromocodeFilterBuilder
	
	#region AdmAppFeePromocodeParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;AdmAppFeePromocodeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAppFeePromocode"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AdmAppFeePromocodeParameterBuilder : ParameterizedSqlFilterBuilder<AdmAppFeePromocodeColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAppFeePromocodeParameterBuilder class.
		/// </summary>
		public AdmAppFeePromocodeParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AdmAppFeePromocodeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AdmAppFeePromocodeParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AdmAppFeePromocodeParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AdmAppFeePromocodeParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AdmAppFeePromocodeParameterBuilder
	
	#region AdmAppFeePromocodeSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;AdmAppFeePromocodeColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AdmAppFeePromocode"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AdmAppFeePromocodeSortBuilder : SqlSortBuilder<AdmAppFeePromocodeColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AdmAppFeePromocodeSqlSortBuilder class.
		/// </summary>
		public AdmAppFeePromocodeSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AdmAppFeePromocodeSortBuilder
	
} // end namespace
