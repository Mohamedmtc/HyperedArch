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
	/// This class is the base class for any <see cref="FeeAccntYearPeriodProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class FeeAccntYearPeriodProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.FeeAccntYearPeriod, UMIS_VER2.BusinessLyer.FeeAccntYearPeriodKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeAccntYearPeriodKey key)
		{
			return Delete(transactionManager, key.FeeAccntYearPeriodId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_feeAccntYearPeriodId">الفترات المالية. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _feeAccntYearPeriodId)
		{
			return Delete(null, _feeAccntYearPeriodId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeAccntYearPeriodId">الفترات المالية. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _feeAccntYearPeriodId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ACCNT_YEAR_PERIOD_FEE_ACCNT_YEAR key.
		///		FK_FEE_ACCNT_YEAR_PERIOD_FEE_ACCNT_YEAR Description: 
		/// </summary>
		/// <param name="_feeAccntYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeAccntYearPeriod objects.</returns>
		public TList<FeeAccntYearPeriod> GetByFeeAccntYearId(System.Decimal _feeAccntYearId)
		{
			int count = -1;
			return GetByFeeAccntYearId(_feeAccntYearId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ACCNT_YEAR_PERIOD_FEE_ACCNT_YEAR key.
		///		FK_FEE_ACCNT_YEAR_PERIOD_FEE_ACCNT_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeAccntYearId"></param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeAccntYearPeriod objects.</returns>
		/// <remarks></remarks>
		public TList<FeeAccntYearPeriod> GetByFeeAccntYearId(TransactionManager transactionManager, System.Decimal _feeAccntYearId)
		{
			int count = -1;
			return GetByFeeAccntYearId(transactionManager, _feeAccntYearId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ACCNT_YEAR_PERIOD_FEE_ACCNT_YEAR key.
		///		FK_FEE_ACCNT_YEAR_PERIOD_FEE_ACCNT_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeAccntYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeAccntYearPeriod objects.</returns>
		public TList<FeeAccntYearPeriod> GetByFeeAccntYearId(TransactionManager transactionManager, System.Decimal _feeAccntYearId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeAccntYearId(transactionManager, _feeAccntYearId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ACCNT_YEAR_PERIOD_FEE_ACCNT_YEAR key.
		///		fkFeeAccntYearPeriodFeeAccntYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeAccntYearId"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeAccntYearPeriod objects.</returns>
		public TList<FeeAccntYearPeriod> GetByFeeAccntYearId(System.Decimal _feeAccntYearId, int start, int pageLength)
		{
			int count =  -1;
			return GetByFeeAccntYearId(null, _feeAccntYearId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ACCNT_YEAR_PERIOD_FEE_ACCNT_YEAR key.
		///		fkFeeAccntYearPeriodFeeAccntYear Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeAccntYearId"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeAccntYearPeriod objects.</returns>
		public TList<FeeAccntYearPeriod> GetByFeeAccntYearId(System.Decimal _feeAccntYearId, int start, int pageLength,out int count)
		{
			return GetByFeeAccntYearId(null, _feeAccntYearId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_ACCNT_YEAR_PERIOD_FEE_ACCNT_YEAR key.
		///		FK_FEE_ACCNT_YEAR_PERIOD_FEE_ACCNT_YEAR Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeAccntYearId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeAccntYearPeriod objects.</returns>
		public abstract TList<FeeAccntYearPeriod> GetByFeeAccntYearId(TransactionManager transactionManager, System.Decimal _feeAccntYearId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.FeeAccntYearPeriod Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeAccntYearPeriodKey key, int start, int pageLength)
		{
			return GetByFeeAccntYearPeriodId(transactionManager, key.FeeAccntYearPeriodId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_FEE_ACCNT_YEAR_PERIOD index.
		/// </summary>
		/// <param name="_feeAccntYearPeriodId">الفترات المالية</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeAccntYearPeriod"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeAccntYearPeriod GetByFeeAccntYearPeriodId(System.Decimal _feeAccntYearPeriodId)
		{
			int count = -1;
			return GetByFeeAccntYearPeriodId(null,_feeAccntYearPeriodId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_ACCNT_YEAR_PERIOD index.
		/// </summary>
		/// <param name="_feeAccntYearPeriodId">الفترات المالية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeAccntYearPeriod"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeAccntYearPeriod GetByFeeAccntYearPeriodId(System.Decimal _feeAccntYearPeriodId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeAccntYearPeriodId(null, _feeAccntYearPeriodId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_ACCNT_YEAR_PERIOD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeAccntYearPeriodId">الفترات المالية</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeAccntYearPeriod"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeAccntYearPeriod GetByFeeAccntYearPeriodId(TransactionManager transactionManager, System.Decimal _feeAccntYearPeriodId)
		{
			int count = -1;
			return GetByFeeAccntYearPeriodId(transactionManager, _feeAccntYearPeriodId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_ACCNT_YEAR_PERIOD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeAccntYearPeriodId">الفترات المالية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeAccntYearPeriod"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeAccntYearPeriod GetByFeeAccntYearPeriodId(TransactionManager transactionManager, System.Decimal _feeAccntYearPeriodId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeAccntYearPeriodId(transactionManager, _feeAccntYearPeriodId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_ACCNT_YEAR_PERIOD index.
		/// </summary>
		/// <param name="_feeAccntYearPeriodId">الفترات المالية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeAccntYearPeriod"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeAccntYearPeriod GetByFeeAccntYearPeriodId(System.Decimal _feeAccntYearPeriodId, int start, int pageLength, out int count)
		{
			return GetByFeeAccntYearPeriodId(null, _feeAccntYearPeriodId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_ACCNT_YEAR_PERIOD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeAccntYearPeriodId">الفترات المالية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeAccntYearPeriod"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.FeeAccntYearPeriod GetByFeeAccntYearPeriodId(TransactionManager transactionManager, System.Decimal _feeAccntYearPeriodId, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key UK_FEE_ACCNT_YEAR_PERIOD index.
		/// </summary>
		/// <param name="_feeAccntYearId"></param>
		/// <param name="_periodFromDt"></param>
		/// <param name="_periodToDt"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeAccntYearPeriod"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeAccntYearPeriod GetByFeeAccntYearIdPeriodFromDtPeriodToDt(System.Decimal _feeAccntYearId, System.DateTime _periodFromDt, System.DateTime _periodToDt)
		{
			int count = -1;
			return GetByFeeAccntYearIdPeriodFromDtPeriodToDt(null,_feeAccntYearId, _periodFromDt, _periodToDt, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_ACCNT_YEAR_PERIOD index.
		/// </summary>
		/// <param name="_feeAccntYearId"></param>
		/// <param name="_periodFromDt"></param>
		/// <param name="_periodToDt"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeAccntYearPeriod"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeAccntYearPeriod GetByFeeAccntYearIdPeriodFromDtPeriodToDt(System.Decimal _feeAccntYearId, System.DateTime _periodFromDt, System.DateTime _periodToDt, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeAccntYearIdPeriodFromDtPeriodToDt(null, _feeAccntYearId, _periodFromDt, _periodToDt, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_ACCNT_YEAR_PERIOD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeAccntYearId"></param>
		/// <param name="_periodFromDt"></param>
		/// <param name="_periodToDt"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeAccntYearPeriod"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeAccntYearPeriod GetByFeeAccntYearIdPeriodFromDtPeriodToDt(TransactionManager transactionManager, System.Decimal _feeAccntYearId, System.DateTime _periodFromDt, System.DateTime _periodToDt)
		{
			int count = -1;
			return GetByFeeAccntYearIdPeriodFromDtPeriodToDt(transactionManager, _feeAccntYearId, _periodFromDt, _periodToDt, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_ACCNT_YEAR_PERIOD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeAccntYearId"></param>
		/// <param name="_periodFromDt"></param>
		/// <param name="_periodToDt"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeAccntYearPeriod"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeAccntYearPeriod GetByFeeAccntYearIdPeriodFromDtPeriodToDt(TransactionManager transactionManager, System.Decimal _feeAccntYearId, System.DateTime _periodFromDt, System.DateTime _periodToDt, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeAccntYearIdPeriodFromDtPeriodToDt(transactionManager, _feeAccntYearId, _periodFromDt, _periodToDt, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_ACCNT_YEAR_PERIOD index.
		/// </summary>
		/// <param name="_feeAccntYearId"></param>
		/// <param name="_periodFromDt"></param>
		/// <param name="_periodToDt"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeAccntYearPeriod"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeAccntYearPeriod GetByFeeAccntYearIdPeriodFromDtPeriodToDt(System.Decimal _feeAccntYearId, System.DateTime _periodFromDt, System.DateTime _periodToDt, int start, int pageLength, out int count)
		{
			return GetByFeeAccntYearIdPeriodFromDtPeriodToDt(null, _feeAccntYearId, _periodFromDt, _periodToDt, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the UK_FEE_ACCNT_YEAR_PERIOD index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeAccntYearId"></param>
		/// <param name="_periodFromDt"></param>
		/// <param name="_periodToDt"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeAccntYearPeriod"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.FeeAccntYearPeriod GetByFeeAccntYearIdPeriodFromDtPeriodToDt(TransactionManager transactionManager, System.Decimal _feeAccntYearId, System.DateTime _periodFromDt, System.DateTime _periodToDt, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;FeeAccntYearPeriod&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;FeeAccntYearPeriod&gt;"/></returns>
		public static TList<FeeAccntYearPeriod> Fill(IDataReader reader, TList<FeeAccntYearPeriod> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.FeeAccntYearPeriod c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("FeeAccntYearPeriod")
					.Append("|").Append((System.Decimal)reader["FEE_ACCNT_YEAR_PERIOD_ID"]).ToString();
					c = EntityManager.LocateOrCreate<FeeAccntYearPeriod>(
					key.ToString(), // EntityTrackingKey
					"FeeAccntYearPeriod",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.FeeAccntYearPeriod();
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
					c.FeeAccntYearPeriodId = (System.Decimal)reader["FEE_ACCNT_YEAR_PERIOD_ID"];
					c.OriginalFeeAccntYearPeriodId = c.FeeAccntYearPeriodId;
					c.FeeAccntYearId = (System.Decimal)reader["FEE_ACCNT_YEAR_ID"];
					c.PeriodFromDt = (System.DateTime)reader["PERIOD_FROM_DT"];
					c.PeriodToDt = (System.DateTime)reader["PERIOD_TO_DT"];
					c.PeriodNote = Convert.IsDBNull(reader["PERIOD_NOTE"]) ? null : (System.String)reader["PERIOD_NOTE"];
					c.CloseFlg = (System.Boolean)reader["CLOSE_FLG"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeAccntYearPeriod"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeAccntYearPeriod"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.FeeAccntYearPeriod entity)
		{
			if (!reader.Read()) return;
			
			entity.FeeAccntYearPeriodId = (System.Decimal)reader[((int)FeeAccntYearPeriodColumn.FeeAccntYearPeriodId - 1)];
			entity.OriginalFeeAccntYearPeriodId = (System.Decimal)reader["FEE_ACCNT_YEAR_PERIOD_ID"];
			entity.FeeAccntYearId = (System.Decimal)reader[((int)FeeAccntYearPeriodColumn.FeeAccntYearId - 1)];
			entity.PeriodFromDt = (System.DateTime)reader[((int)FeeAccntYearPeriodColumn.PeriodFromDt - 1)];
			entity.PeriodToDt = (System.DateTime)reader[((int)FeeAccntYearPeriodColumn.PeriodToDt - 1)];
			entity.PeriodNote = (reader.IsDBNull(((int)FeeAccntYearPeriodColumn.PeriodNote - 1)))?null:(System.String)reader[((int)FeeAccntYearPeriodColumn.PeriodNote - 1)];
			entity.CloseFlg = (System.Boolean)reader[((int)FeeAccntYearPeriodColumn.CloseFlg - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeAccntYearPeriod"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeAccntYearPeriod"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.FeeAccntYearPeriod entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.FeeAccntYearPeriodId = (System.Decimal)dataRow["FEE_ACCNT_YEAR_PERIOD_ID"];
			entity.OriginalFeeAccntYearPeriodId = (System.Decimal)dataRow["FEE_ACCNT_YEAR_PERIOD_ID"];
			entity.FeeAccntYearId = (System.Decimal)dataRow["FEE_ACCNT_YEAR_ID"];
			entity.PeriodFromDt = (System.DateTime)dataRow["PERIOD_FROM_DT"];
			entity.PeriodToDt = (System.DateTime)dataRow["PERIOD_TO_DT"];
			entity.PeriodNote = Convert.IsDBNull(dataRow["PERIOD_NOTE"]) ? null : (System.String)dataRow["PERIOD_NOTE"];
			entity.CloseFlg = (System.Boolean)dataRow["CLOSE_FLG"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeAccntYearPeriod"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeAccntYearPeriod Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeAccntYearPeriod entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region FeeAccntYearIdSource	
			if (CanDeepLoad(entity, "FeeAccntYear|FeeAccntYearIdSource", deepLoadType, innerList) 
				&& entity.FeeAccntYearIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.FeeAccntYearId;
				FeeAccntYear tmpEntity = EntityManager.LocateEntity<FeeAccntYear>(EntityLocator.ConstructKeyFromPkItems(typeof(FeeAccntYear), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.FeeAccntYearIdSource = tmpEntity;
				else
					entity.FeeAccntYearIdSource = DataRepository.FeeAccntYearProvider.GetByFeeAccntYearId(transactionManager, entity.FeeAccntYearId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeAccntYearIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.FeeAccntYearIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.FeeAccntYearProvider.DeepLoad(transactionManager, entity.FeeAccntYearIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion FeeAccntYearIdSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByFeeAccntYearPeriodId methods when available
			
			#region FeeYearPrdBankCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<FeeYearPrdBank>|FeeYearPrdBankCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeYearPrdBankCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.FeeYearPrdBankCollection = DataRepository.FeeYearPrdBankProvider.GetByFeeAccntYearPeriodId(transactionManager, entity.FeeAccntYearPeriodId);

				if (deep && entity.FeeYearPrdBankCollection.Count > 0)
				{
					deepHandles.Add("FeeYearPrdBankCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<FeeYearPrdBank>) DataRepository.FeeYearPrdBankProvider.DeepLoad,
						new object[] { transactionManager, entity.FeeYearPrdBankCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.FeeAccntYearPeriod object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.FeeAccntYearPeriod instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeAccntYearPeriod Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeAccntYearPeriod entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region FeeAccntYearIdSource
			if (CanDeepSave(entity, "FeeAccntYear|FeeAccntYearIdSource", deepSaveType, innerList) 
				&& entity.FeeAccntYearIdSource != null)
			{
				DataRepository.FeeAccntYearProvider.Save(transactionManager, entity.FeeAccntYearIdSource);
				entity.FeeAccntYearId = entity.FeeAccntYearIdSource.FeeAccntYearId;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<FeeYearPrdBank>
				if (CanDeepSave(entity.FeeYearPrdBankCollection, "List<FeeYearPrdBank>|FeeYearPrdBankCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(FeeYearPrdBank child in entity.FeeYearPrdBankCollection)
					{
						if(child.FeeAccntYearPeriodIdSource != null)
						{
							child.FeeAccntYearPeriodId = child.FeeAccntYearPeriodIdSource.FeeAccntYearPeriodId;
						}
						else
						{
							child.FeeAccntYearPeriodId = entity.FeeAccntYearPeriodId;
						}

					}

					if (entity.FeeYearPrdBankCollection.Count > 0 || entity.FeeYearPrdBankCollection.DeletedItems.Count > 0)
					{
						//DataRepository.FeeYearPrdBankProvider.Save(transactionManager, entity.FeeYearPrdBankCollection);
						
						deepHandles.Add("FeeYearPrdBankCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< FeeYearPrdBank >) DataRepository.FeeYearPrdBankProvider.DeepSave,
							new object[] { transactionManager, entity.FeeYearPrdBankCollection, deepSaveType, childTypes, innerList }
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
	
	#region FeeAccntYearPeriodChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.FeeAccntYearPeriod</c>
	///</summary>
	public enum FeeAccntYearPeriodChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>FeeAccntYear</c> at FeeAccntYearIdSource
		///</summary>
		[ChildEntityType(typeof(FeeAccntYear))]
		FeeAccntYear,
		///<summary>
		/// Collection of <c>FeeAccntYearPeriod</c> as OneToMany for FeeYearPrdBankCollection
		///</summary>
		[ChildEntityType(typeof(TList<FeeYearPrdBank>))]
		FeeYearPrdBankCollection,
	}
	
	#endregion FeeAccntYearPeriodChildEntityTypes
	
	#region FeeAccntYearPeriodFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;FeeAccntYearPeriodColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeAccntYearPeriod"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeAccntYearPeriodFilterBuilder : SqlFilterBuilder<FeeAccntYearPeriodColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeAccntYearPeriodFilterBuilder class.
		/// </summary>
		public FeeAccntYearPeriodFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeAccntYearPeriodFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeAccntYearPeriodFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeAccntYearPeriodFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeAccntYearPeriodFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeAccntYearPeriodFilterBuilder
	
	#region FeeAccntYearPeriodParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;FeeAccntYearPeriodColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeAccntYearPeriod"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeAccntYearPeriodParameterBuilder : ParameterizedSqlFilterBuilder<FeeAccntYearPeriodColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeAccntYearPeriodParameterBuilder class.
		/// </summary>
		public FeeAccntYearPeriodParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeAccntYearPeriodParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeAccntYearPeriodParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeAccntYearPeriodParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeAccntYearPeriodParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeAccntYearPeriodParameterBuilder
	
	#region FeeAccntYearPeriodSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;FeeAccntYearPeriodColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeAccntYearPeriod"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class FeeAccntYearPeriodSortBuilder : SqlSortBuilder<FeeAccntYearPeriodColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeAccntYearPeriodSqlSortBuilder class.
		/// </summary>
		public FeeAccntYearPeriodSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion FeeAccntYearPeriodSortBuilder
	
} // end namespace
