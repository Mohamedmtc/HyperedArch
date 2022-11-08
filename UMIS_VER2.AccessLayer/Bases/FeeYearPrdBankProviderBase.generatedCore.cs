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
	/// This class is the base class for any <see cref="FeeYearPrdBankProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class FeeYearPrdBankProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.FeeYearPrdBank, UMIS_VER2.BusinessLyer.FeeYearPrdBankKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeYearPrdBankKey key)
		{
			return Delete(transactionManager, key.FeeYearPrdBankId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_feeYearPrdBankId">اختيار بنك معين  او اكثر من بنك يتم اغلاقه خلال هذه الفترة. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _feeYearPrdBankId)
		{
			return Delete(null, _feeYearPrdBankId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeYearPrdBankId">اختيار بنك معين  او اكثر من بنك يتم اغلاقه خلال هذه الفترة. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _feeYearPrdBankId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_YEAR_PRD_BANK_FEE_ACCNT_YEAR_PERIOD key.
		///		FK_FEE_YEAR_PRD_BANK_FEE_ACCNT_YEAR_PERIOD Description: 
		/// </summary>
		/// <param name="_feeAccntYearPeriodId">الفترات المالية</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeYearPrdBank objects.</returns>
		public TList<FeeYearPrdBank> GetByFeeAccntYearPeriodId(System.Decimal _feeAccntYearPeriodId)
		{
			int count = -1;
			return GetByFeeAccntYearPeriodId(_feeAccntYearPeriodId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_YEAR_PRD_BANK_FEE_ACCNT_YEAR_PERIOD key.
		///		FK_FEE_YEAR_PRD_BANK_FEE_ACCNT_YEAR_PERIOD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeAccntYearPeriodId">الفترات المالية</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeYearPrdBank objects.</returns>
		/// <remarks></remarks>
		public TList<FeeYearPrdBank> GetByFeeAccntYearPeriodId(TransactionManager transactionManager, System.Decimal _feeAccntYearPeriodId)
		{
			int count = -1;
			return GetByFeeAccntYearPeriodId(transactionManager, _feeAccntYearPeriodId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_YEAR_PRD_BANK_FEE_ACCNT_YEAR_PERIOD key.
		///		FK_FEE_YEAR_PRD_BANK_FEE_ACCNT_YEAR_PERIOD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeAccntYearPeriodId">الفترات المالية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeYearPrdBank objects.</returns>
		public TList<FeeYearPrdBank> GetByFeeAccntYearPeriodId(TransactionManager transactionManager, System.Decimal _feeAccntYearPeriodId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeAccntYearPeriodId(transactionManager, _feeAccntYearPeriodId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_YEAR_PRD_BANK_FEE_ACCNT_YEAR_PERIOD key.
		///		fkFeeYearPrdBankFeeAccntYearPeriod Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeAccntYearPeriodId">الفترات المالية</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeYearPrdBank objects.</returns>
		public TList<FeeYearPrdBank> GetByFeeAccntYearPeriodId(System.Decimal _feeAccntYearPeriodId, int start, int pageLength)
		{
			int count =  -1;
			return GetByFeeAccntYearPeriodId(null, _feeAccntYearPeriodId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_YEAR_PRD_BANK_FEE_ACCNT_YEAR_PERIOD key.
		///		fkFeeYearPrdBankFeeAccntYearPeriod Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeAccntYearPeriodId">الفترات المالية</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeYearPrdBank objects.</returns>
		public TList<FeeYearPrdBank> GetByFeeAccntYearPeriodId(System.Decimal _feeAccntYearPeriodId, int start, int pageLength,out int count)
		{
			return GetByFeeAccntYearPeriodId(null, _feeAccntYearPeriodId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_YEAR_PRD_BANK_FEE_ACCNT_YEAR_PERIOD key.
		///		FK_FEE_YEAR_PRD_BANK_FEE_ACCNT_YEAR_PERIOD Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeAccntYearPeriodId">الفترات المالية</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeYearPrdBank objects.</returns>
		public abstract TList<FeeYearPrdBank> GetByFeeAccntYearPeriodId(TransactionManager transactionManager, System.Decimal _feeAccntYearPeriodId, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_YEAR_PRD_BANK_FEE_CODE_BANKS key.
		///		FK_FEE_YEAR_PRD_BANK_FEE_CODE_BANKS Description: 
		/// </summary>
		/// <param name="_feeCodeBankId">NULL=Cash else bank</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeYearPrdBank objects.</returns>
		public TList<FeeYearPrdBank> GetByFeeCodeBankId(System.Decimal? _feeCodeBankId)
		{
			int count = -1;
			return GetByFeeCodeBankId(_feeCodeBankId, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_YEAR_PRD_BANK_FEE_CODE_BANKS key.
		///		FK_FEE_YEAR_PRD_BANK_FEE_CODE_BANKS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeBankId">NULL=Cash else bank</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeYearPrdBank objects.</returns>
		/// <remarks></remarks>
		public TList<FeeYearPrdBank> GetByFeeCodeBankId(TransactionManager transactionManager, System.Decimal? _feeCodeBankId)
		{
			int count = -1;
			return GetByFeeCodeBankId(transactionManager, _feeCodeBankId, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_YEAR_PRD_BANK_FEE_CODE_BANKS key.
		///		FK_FEE_YEAR_PRD_BANK_FEE_CODE_BANKS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeBankId">NULL=Cash else bank</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeYearPrdBank objects.</returns>
		public TList<FeeYearPrdBank> GetByFeeCodeBankId(TransactionManager transactionManager, System.Decimal? _feeCodeBankId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeCodeBankId(transactionManager, _feeCodeBankId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_YEAR_PRD_BANK_FEE_CODE_BANKS key.
		///		fkFeeYearPrdBankFeeCodeBanks Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeCodeBankId">NULL=Cash else bank</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeYearPrdBank objects.</returns>
		public TList<FeeYearPrdBank> GetByFeeCodeBankId(System.Decimal? _feeCodeBankId, int start, int pageLength)
		{
			int count =  -1;
			return GetByFeeCodeBankId(null, _feeCodeBankId, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_YEAR_PRD_BANK_FEE_CODE_BANKS key.
		///		fkFeeYearPrdBankFeeCodeBanks Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_feeCodeBankId">NULL=Cash else bank</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeYearPrdBank objects.</returns>
		public TList<FeeYearPrdBank> GetByFeeCodeBankId(System.Decimal? _feeCodeBankId, int start, int pageLength,out int count)
		{
			return GetByFeeCodeBankId(null, _feeCodeBankId, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_FEE_YEAR_PRD_BANK_FEE_CODE_BANKS key.
		///		FK_FEE_YEAR_PRD_BANK_FEE_CODE_BANKS Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeCodeBankId">NULL=Cash else bank</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeYearPrdBank objects.</returns>
		public abstract TList<FeeYearPrdBank> GetByFeeCodeBankId(TransactionManager transactionManager, System.Decimal? _feeCodeBankId, int start, int pageLength, out int count);
		
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
		public override UMIS_VER2.BusinessLyer.FeeYearPrdBank Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeYearPrdBankKey key, int start, int pageLength)
		{
			return GetByFeeYearPrdBankId(transactionManager, key.FeeYearPrdBankId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_FEE_YEAR_PRD_BANK index.
		/// </summary>
		/// <param name="_feeYearPrdBankId">اختيار بنك معين  او اكثر من بنك يتم اغلاقه خلال هذه الفترة</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeYearPrdBank"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeYearPrdBank GetByFeeYearPrdBankId(System.Decimal _feeYearPrdBankId)
		{
			int count = -1;
			return GetByFeeYearPrdBankId(null,_feeYearPrdBankId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_YEAR_PRD_BANK index.
		/// </summary>
		/// <param name="_feeYearPrdBankId">اختيار بنك معين  او اكثر من بنك يتم اغلاقه خلال هذه الفترة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeYearPrdBank"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeYearPrdBank GetByFeeYearPrdBankId(System.Decimal _feeYearPrdBankId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeYearPrdBankId(null, _feeYearPrdBankId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_YEAR_PRD_BANK index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeYearPrdBankId">اختيار بنك معين  او اكثر من بنك يتم اغلاقه خلال هذه الفترة</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeYearPrdBank"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeYearPrdBank GetByFeeYearPrdBankId(TransactionManager transactionManager, System.Decimal _feeYearPrdBankId)
		{
			int count = -1;
			return GetByFeeYearPrdBankId(transactionManager, _feeYearPrdBankId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_YEAR_PRD_BANK index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeYearPrdBankId">اختيار بنك معين  او اكثر من بنك يتم اغلاقه خلال هذه الفترة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeYearPrdBank"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeYearPrdBank GetByFeeYearPrdBankId(TransactionManager transactionManager, System.Decimal _feeYearPrdBankId, int start, int pageLength)
		{
			int count = -1;
			return GetByFeeYearPrdBankId(transactionManager, _feeYearPrdBankId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_YEAR_PRD_BANK index.
		/// </summary>
		/// <param name="_feeYearPrdBankId">اختيار بنك معين  او اكثر من بنك يتم اغلاقه خلال هذه الفترة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeYearPrdBank"/> class.</returns>
		public UMIS_VER2.BusinessLyer.FeeYearPrdBank GetByFeeYearPrdBankId(System.Decimal _feeYearPrdBankId, int start, int pageLength, out int count)
		{
			return GetByFeeYearPrdBankId(null, _feeYearPrdBankId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_FEE_YEAR_PRD_BANK index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_feeYearPrdBankId">اختيار بنك معين  او اكثر من بنك يتم اغلاقه خلال هذه الفترة</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.FeeYearPrdBank"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.FeeYearPrdBank GetByFeeYearPrdBankId(TransactionManager transactionManager, System.Decimal _feeYearPrdBankId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;FeeYearPrdBank&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;FeeYearPrdBank&gt;"/></returns>
		public static TList<FeeYearPrdBank> Fill(IDataReader reader, TList<FeeYearPrdBank> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.FeeYearPrdBank c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("FeeYearPrdBank")
					.Append("|").Append((System.Decimal)reader["FEE_YEAR_PRD_BANK_ID"]).ToString();
					c = EntityManager.LocateOrCreate<FeeYearPrdBank>(
					key.ToString(), // EntityTrackingKey
					"FeeYearPrdBank",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.FeeYearPrdBank();
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
					c.FeeYearPrdBankId = (System.Decimal)reader["FEE_YEAR_PRD_BANK_ID"];
					c.OriginalFeeYearPrdBankId = c.FeeYearPrdBankId;
					c.FeeAccntYearPeriodId = (System.Decimal)reader["FEE_ACCNT_YEAR_PERIOD_ID"];
					c.FeeCodeBankId = Convert.IsDBNull(reader["FEE_CODE_BANK_ID"]) ? null : (System.Decimal?)reader["FEE_CODE_BANK_ID"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeYearPrdBank"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeYearPrdBank"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.FeeYearPrdBank entity)
		{
			if (!reader.Read()) return;
			
			entity.FeeYearPrdBankId = (System.Decimal)reader[((int)FeeYearPrdBankColumn.FeeYearPrdBankId - 1)];
			entity.OriginalFeeYearPrdBankId = (System.Decimal)reader["FEE_YEAR_PRD_BANK_ID"];
			entity.FeeAccntYearPeriodId = (System.Decimal)reader[((int)FeeYearPrdBankColumn.FeeAccntYearPeriodId - 1)];
			entity.FeeCodeBankId = (reader.IsDBNull(((int)FeeYearPrdBankColumn.FeeCodeBankId - 1)))?null:(System.Decimal?)reader[((int)FeeYearPrdBankColumn.FeeCodeBankId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.FeeYearPrdBank"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeYearPrdBank"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.FeeYearPrdBank entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.FeeYearPrdBankId = (System.Decimal)dataRow["FEE_YEAR_PRD_BANK_ID"];
			entity.OriginalFeeYearPrdBankId = (System.Decimal)dataRow["FEE_YEAR_PRD_BANK_ID"];
			entity.FeeAccntYearPeriodId = (System.Decimal)dataRow["FEE_ACCNT_YEAR_PERIOD_ID"];
			entity.FeeCodeBankId = Convert.IsDBNull(dataRow["FEE_CODE_BANK_ID"]) ? null : (System.Decimal?)dataRow["FEE_CODE_BANK_ID"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.FeeYearPrdBank"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeYearPrdBank Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeYearPrdBank entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region FeeAccntYearPeriodIdSource	
			if (CanDeepLoad(entity, "FeeAccntYearPeriod|FeeAccntYearPeriodIdSource", deepLoadType, innerList) 
				&& entity.FeeAccntYearPeriodIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = entity.FeeAccntYearPeriodId;
				FeeAccntYearPeriod tmpEntity = EntityManager.LocateEntity<FeeAccntYearPeriod>(EntityLocator.ConstructKeyFromPkItems(typeof(FeeAccntYearPeriod), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.FeeAccntYearPeriodIdSource = tmpEntity;
				else
					entity.FeeAccntYearPeriodIdSource = DataRepository.FeeAccntYearPeriodProvider.GetByFeeAccntYearPeriodId(transactionManager, entity.FeeAccntYearPeriodId);		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'FeeAccntYearPeriodIdSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.FeeAccntYearPeriodIdSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.FeeAccntYearPeriodProvider.DeepLoad(transactionManager, entity.FeeAccntYearPeriodIdSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion FeeAccntYearPeriodIdSource

			#region FeeCodeBankIdSource	
			if (CanDeepLoad(entity, "FeeCodeBanks|FeeCodeBankIdSource", deepLoadType, innerList) 
				&& entity.FeeCodeBankIdSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.FeeCodeBankId ?? 0.0m);
				FeeCodeBanks tmpEntity = EntityManager.LocateEntity<FeeCodeBanks>(EntityLocator.ConstructKeyFromPkItems(typeof(FeeCodeBanks), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.FeeCodeBankIdSource = tmpEntity;
				else
					entity.FeeCodeBankIdSource = DataRepository.FeeCodeBanksProvider.GetByFeeCodeBankId(transactionManager, (entity.FeeCodeBankId ?? 0.0m));		
				
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.FeeYearPrdBank object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.FeeYearPrdBank instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.FeeYearPrdBank Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.FeeYearPrdBank entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region FeeAccntYearPeriodIdSource
			if (CanDeepSave(entity, "FeeAccntYearPeriod|FeeAccntYearPeriodIdSource", deepSaveType, innerList) 
				&& entity.FeeAccntYearPeriodIdSource != null)
			{
				DataRepository.FeeAccntYearPeriodProvider.Save(transactionManager, entity.FeeAccntYearPeriodIdSource);
				entity.FeeAccntYearPeriodId = entity.FeeAccntYearPeriodIdSource.FeeAccntYearPeriodId;
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
	
	#region FeeYearPrdBankChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.FeeYearPrdBank</c>
	///</summary>
	public enum FeeYearPrdBankChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>FeeAccntYearPeriod</c> at FeeAccntYearPeriodIdSource
		///</summary>
		[ChildEntityType(typeof(FeeAccntYearPeriod))]
		FeeAccntYearPeriod,
		
		///<summary>
		/// Composite Property for <c>FeeCodeBanks</c> at FeeCodeBankIdSource
		///</summary>
		[ChildEntityType(typeof(FeeCodeBanks))]
		FeeCodeBanks,
	}
	
	#endregion FeeYearPrdBankChildEntityTypes
	
	#region FeeYearPrdBankFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;FeeYearPrdBankColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeYearPrdBank"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeYearPrdBankFilterBuilder : SqlFilterBuilder<FeeYearPrdBankColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeYearPrdBankFilterBuilder class.
		/// </summary>
		public FeeYearPrdBankFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeYearPrdBankFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeYearPrdBankFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeYearPrdBankFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeYearPrdBankFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeYearPrdBankFilterBuilder
	
	#region FeeYearPrdBankParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;FeeYearPrdBankColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeYearPrdBank"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class FeeYearPrdBankParameterBuilder : ParameterizedSqlFilterBuilder<FeeYearPrdBankColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeYearPrdBankParameterBuilder class.
		/// </summary>
		public FeeYearPrdBankParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the FeeYearPrdBankParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public FeeYearPrdBankParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the FeeYearPrdBankParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public FeeYearPrdBankParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion FeeYearPrdBankParameterBuilder
	
	#region FeeYearPrdBankSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;FeeYearPrdBankColumn&gt;"/> class
	/// that is used exclusively with a <see cref="FeeYearPrdBank"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class FeeYearPrdBankSortBuilder : SqlSortBuilder<FeeYearPrdBankColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FeeYearPrdBankSqlSortBuilder class.
		/// </summary>
		public FeeYearPrdBankSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion FeeYearPrdBankSortBuilder
	
} // end namespace
