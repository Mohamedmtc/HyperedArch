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
	/// This class is the base class for any <see cref="SaCodeScDegProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SaCodeScDegProviderBaseCore : EntityProviderBase<UMIS_VER2.BusinessLyer.SaCodeScDeg, UMIS_VER2.BusinessLyer.SaCodeScDegKey>
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
		public override bool Delete(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeScDegKey key)
		{
			return Delete(transactionManager, key.SaCodeScDegId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_saCodeScDegId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Decimal _saCodeScDegId)
		{
			return Delete(null, _saCodeScDegId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeScDegId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Decimal _saCodeScDegId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
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
		public override UMIS_VER2.BusinessLyer.SaCodeScDeg Get(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeScDegKey key, int start, int pageLength)
		{
			return GetBySaCodeScDegId(transactionManager, key.SaCodeScDegId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key COS_SA_CODE_SC_DEG2 index.
		/// </summary>
		/// <param name="_scDegDescrAr"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeScDeg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeScDeg GetByScDegDescrAr(System.String _scDegDescrAr)
		{
			int count = -1;
			return GetByScDegDescrAr(null,_scDegDescrAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SA_CODE_SC_DEG2 index.
		/// </summary>
		/// <param name="_scDegDescrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeScDeg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeScDeg GetByScDegDescrAr(System.String _scDegDescrAr, int start, int pageLength)
		{
			int count = -1;
			return GetByScDegDescrAr(null, _scDegDescrAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SA_CODE_SC_DEG2 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scDegDescrAr"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeScDeg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeScDeg GetByScDegDescrAr(TransactionManager transactionManager, System.String _scDegDescrAr)
		{
			int count = -1;
			return GetByScDegDescrAr(transactionManager, _scDegDescrAr, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SA_CODE_SC_DEG2 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scDegDescrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeScDeg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeScDeg GetByScDegDescrAr(TransactionManager transactionManager, System.String _scDegDescrAr, int start, int pageLength)
		{
			int count = -1;
			return GetByScDegDescrAr(transactionManager, _scDegDescrAr, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SA_CODE_SC_DEG2 index.
		/// </summary>
		/// <param name="_scDegDescrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeScDeg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeScDeg GetByScDegDescrAr(System.String _scDegDescrAr, int start, int pageLength, out int count)
		{
			return GetByScDegDescrAr(null, _scDegDescrAr, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SA_CODE_SC_DEG2 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_scDegDescrAr"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeScDeg"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SaCodeScDeg GetByScDegDescrAr(TransactionManager transactionManager, System.String _scDegDescrAr, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key COS_SA_CODE_SC_DEG4 index.
		/// </summary>
		/// <param name="_degOrder"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeScDeg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeScDeg GetByDegOrder(System.Decimal _degOrder)
		{
			int count = -1;
			return GetByDegOrder(null,_degOrder, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SA_CODE_SC_DEG4 index.
		/// </summary>
		/// <param name="_degOrder"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeScDeg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeScDeg GetByDegOrder(System.Decimal _degOrder, int start, int pageLength)
		{
			int count = -1;
			return GetByDegOrder(null, _degOrder, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SA_CODE_SC_DEG4 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_degOrder"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeScDeg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeScDeg GetByDegOrder(TransactionManager transactionManager, System.Decimal _degOrder)
		{
			int count = -1;
			return GetByDegOrder(transactionManager, _degOrder, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SA_CODE_SC_DEG4 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_degOrder"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeScDeg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeScDeg GetByDegOrder(TransactionManager transactionManager, System.Decimal _degOrder, int start, int pageLength)
		{
			int count = -1;
			return GetByDegOrder(transactionManager, _degOrder, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SA_CODE_SC_DEG4 index.
		/// </summary>
		/// <param name="_degOrder"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeScDeg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeScDeg GetByDegOrder(System.Decimal _degOrder, int start, int pageLength, out int count)
		{
			return GetByDegOrder(null, _degOrder, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the COS_SA_CODE_SC_DEG4 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_degOrder"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeScDeg"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SaCodeScDeg GetByDegOrder(TransactionManager transactionManager, System.Decimal _degOrder, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_STAFF_FLAG_1 index.
		/// </summary>
		/// <param name="_staffFlag"></param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCodeScDeg&gt;"/> class.</returns>
		public TList<SaCodeScDeg> GetByStaffFlag(System.Decimal? _staffFlag)
		{
			int count = -1;
			return GetByStaffFlag(null,_staffFlag, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_STAFF_FLAG_1 index.
		/// </summary>
		/// <param name="_staffFlag"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCodeScDeg&gt;"/> class.</returns>
		public TList<SaCodeScDeg> GetByStaffFlag(System.Decimal? _staffFlag, int start, int pageLength)
		{
			int count = -1;
			return GetByStaffFlag(null, _staffFlag, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_STAFF_FLAG_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_staffFlag"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCodeScDeg&gt;"/> class.</returns>
		public TList<SaCodeScDeg> GetByStaffFlag(TransactionManager transactionManager, System.Decimal? _staffFlag)
		{
			int count = -1;
			return GetByStaffFlag(transactionManager, _staffFlag, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_STAFF_FLAG_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_staffFlag"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCodeScDeg&gt;"/> class.</returns>
		public TList<SaCodeScDeg> GetByStaffFlag(TransactionManager transactionManager, System.Decimal? _staffFlag, int start, int pageLength)
		{
			int count = -1;
			return GetByStaffFlag(transactionManager, _staffFlag, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_STAFF_FLAG_1 index.
		/// </summary>
		/// <param name="_staffFlag"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCodeScDeg&gt;"/> class.</returns>
		public TList<SaCodeScDeg> GetByStaffFlag(System.Decimal? _staffFlag, int start, int pageLength, out int count)
		{
			return GetByStaffFlag(null, _staffFlag, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_STAFF_FLAG_1 index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_staffFlag"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="TList&lt;SaCodeScDeg&gt;"/> class.</returns>
		public abstract TList<SaCodeScDeg> GetByStaffFlag(TransactionManager transactionManager, System.Decimal? _staffFlag, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_SA_CODE_SC_DEG index.
		/// </summary>
		/// <param name="_saCodeScDegId"></param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeScDeg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeScDeg GetBySaCodeScDegId(System.Decimal _saCodeScDegId)
		{
			int count = -1;
			return GetBySaCodeScDegId(null,_saCodeScDegId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_SC_DEG index.
		/// </summary>
		/// <param name="_saCodeScDegId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeScDeg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeScDeg GetBySaCodeScDegId(System.Decimal _saCodeScDegId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeScDegId(null, _saCodeScDegId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_SC_DEG index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeScDegId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeScDeg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeScDeg GetBySaCodeScDegId(TransactionManager transactionManager, System.Decimal _saCodeScDegId)
		{
			int count = -1;
			return GetBySaCodeScDegId(transactionManager, _saCodeScDegId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_SC_DEG index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeScDegId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeScDeg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeScDeg GetBySaCodeScDegId(TransactionManager transactionManager, System.Decimal _saCodeScDegId, int start, int pageLength)
		{
			int count = -1;
			return GetBySaCodeScDegId(transactionManager, _saCodeScDegId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_SC_DEG index.
		/// </summary>
		/// <param name="_saCodeScDegId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeScDeg"/> class.</returns>
		public UMIS_VER2.BusinessLyer.SaCodeScDeg GetBySaCodeScDegId(System.Decimal _saCodeScDegId, int start, int pageLength, out int count)
		{
			return GetBySaCodeScDegId(null, _saCodeScDegId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_SA_CODE_SC_DEG index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_saCodeScDegId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="UMIS_VER2.BusinessLyer.SaCodeScDeg"/> class.</returns>
		public abstract UMIS_VER2.BusinessLyer.SaCodeScDeg GetBySaCodeScDegId(TransactionManager transactionManager, System.Decimal _saCodeScDegId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;SaCodeScDeg&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;SaCodeScDeg&gt;"/></returns>
		public static TList<SaCodeScDeg> Fill(IDataReader reader, TList<SaCodeScDeg> rows, int start, int pageLength)
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
				
				UMIS_VER2.BusinessLyer.SaCodeScDeg c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("SaCodeScDeg")
					.Append("|").Append((System.Decimal)reader["SA_CODE_SC_DEG_ID"]).ToString();
					c = EntityManager.LocateOrCreate<SaCodeScDeg>(
					key.ToString(), // EntityTrackingKey
					"SaCodeScDeg",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new UMIS_VER2.BusinessLyer.SaCodeScDeg();
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
					c.SaCodeScDegId = (System.Decimal)reader["SA_CODE_SC_DEG_ID"];
					c.OriginalSaCodeScDegId = c.SaCodeScDegId;
					c.ScDegCode = Convert.IsDBNull(reader["SC_DEG_CODE"]) ? null : (System.String)reader["SC_DEG_CODE"];
					c.ScDegDescrAr = (System.String)reader["SC_DEG_DESCR_AR"];
					c.ScDegDescrEn = Convert.IsDBNull(reader["SC_DEG_DESCR_EN"]) ? null : (System.String)reader["SC_DEG_DESCR_EN"];
					c.StartSal = Convert.IsDBNull(reader["START_SAL"]) ? null : (System.Decimal?)reader["START_SAL"];
					c.EndSal = Convert.IsDBNull(reader["END_SAL"]) ? null : (System.Decimal?)reader["END_SAL"];
					c.DegPeriod = (System.Decimal)reader["DEG_PERIOD"];
					c.StaffFlag = Convert.IsDBNull(reader["STAFF_FLAG"]) ? null : (System.Decimal?)reader["STAFF_FLAG"];
					c.DegOrder = (System.Decimal)reader["DEG_ORDER"];
					c.DegPeriodMonth = (System.Decimal)reader["DEG_PERIOD_Month"];
					c.Constant = Convert.IsDBNull(reader["Constant"]) ? null : (System.Decimal?)reader["Constant"];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaCodeScDeg"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCodeScDeg"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, UMIS_VER2.BusinessLyer.SaCodeScDeg entity)
		{
			if (!reader.Read()) return;
			
			entity.SaCodeScDegId = (System.Decimal)reader[((int)SaCodeScDegColumn.SaCodeScDegId - 1)];
			entity.OriginalSaCodeScDegId = (System.Decimal)reader["SA_CODE_SC_DEG_ID"];
			entity.ScDegCode = (reader.IsDBNull(((int)SaCodeScDegColumn.ScDegCode - 1)))?null:(System.String)reader[((int)SaCodeScDegColumn.ScDegCode - 1)];
			entity.ScDegDescrAr = (System.String)reader[((int)SaCodeScDegColumn.ScDegDescrAr - 1)];
			entity.ScDegDescrEn = (reader.IsDBNull(((int)SaCodeScDegColumn.ScDegDescrEn - 1)))?null:(System.String)reader[((int)SaCodeScDegColumn.ScDegDescrEn - 1)];
			entity.StartSal = (reader.IsDBNull(((int)SaCodeScDegColumn.StartSal - 1)))?null:(System.Decimal?)reader[((int)SaCodeScDegColumn.StartSal - 1)];
			entity.EndSal = (reader.IsDBNull(((int)SaCodeScDegColumn.EndSal - 1)))?null:(System.Decimal?)reader[((int)SaCodeScDegColumn.EndSal - 1)];
			entity.DegPeriod = (System.Decimal)reader[((int)SaCodeScDegColumn.DegPeriod - 1)];
			entity.StaffFlag = (reader.IsDBNull(((int)SaCodeScDegColumn.StaffFlag - 1)))?null:(System.Decimal?)reader[((int)SaCodeScDegColumn.StaffFlag - 1)];
			entity.DegOrder = (System.Decimal)reader[((int)SaCodeScDegColumn.DegOrder - 1)];
			entity.DegPeriodMonth = (System.Decimal)reader[((int)SaCodeScDegColumn.DegPeriodMonth - 1)];
			entity.Constant = (reader.IsDBNull(((int)SaCodeScDegColumn.Constant - 1)))?null:(System.Decimal?)reader[((int)SaCodeScDegColumn.Constant - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="UMIS_VER2.BusinessLyer.SaCodeScDeg"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCodeScDeg"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, UMIS_VER2.BusinessLyer.SaCodeScDeg entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.SaCodeScDegId = (System.Decimal)dataRow["SA_CODE_SC_DEG_ID"];
			entity.OriginalSaCodeScDegId = (System.Decimal)dataRow["SA_CODE_SC_DEG_ID"];
			entity.ScDegCode = Convert.IsDBNull(dataRow["SC_DEG_CODE"]) ? null : (System.String)dataRow["SC_DEG_CODE"];
			entity.ScDegDescrAr = (System.String)dataRow["SC_DEG_DESCR_AR"];
			entity.ScDegDescrEn = Convert.IsDBNull(dataRow["SC_DEG_DESCR_EN"]) ? null : (System.String)dataRow["SC_DEG_DESCR_EN"];
			entity.StartSal = Convert.IsDBNull(dataRow["START_SAL"]) ? null : (System.Decimal?)dataRow["START_SAL"];
			entity.EndSal = Convert.IsDBNull(dataRow["END_SAL"]) ? null : (System.Decimal?)dataRow["END_SAL"];
			entity.DegPeriod = (System.Decimal)dataRow["DEG_PERIOD"];
			entity.StaffFlag = Convert.IsDBNull(dataRow["STAFF_FLAG"]) ? null : (System.Decimal?)dataRow["STAFF_FLAG"];
			entity.DegOrder = (System.Decimal)dataRow["DEG_ORDER"];
			entity.DegPeriodMonth = (System.Decimal)dataRow["DEG_PERIOD_Month"];
			entity.Constant = Convert.IsDBNull(dataRow["Constant"]) ? null : (System.Decimal?)dataRow["Constant"];
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
		/// <param name="entity">The <see cref="UMIS_VER2.BusinessLyer.SaCodeScDeg"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaCodeScDeg Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeScDeg entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetBySaCodeScDegId methods when available
			
			#region SaEmploymentCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaEmployment>|SaEmploymentCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaEmploymentCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaEmploymentCollection = DataRepository.SaEmploymentProvider.GetBySaCodeScDegId(transactionManager, entity.SaCodeScDegId);

				if (deep && entity.SaEmploymentCollection.Count > 0)
				{
					deepHandles.Add("SaEmploymentCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaEmployment>) DataRepository.SaEmploymentProvider.DeepLoad,
						new object[] { transactionManager, entity.SaEmploymentCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region PgExtMemberCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgExtMember>|PgExtMemberCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgExtMemberCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgExtMemberCollection = DataRepository.PgExtMemberProvider.GetBySaCodeScDegId(transactionManager, entity.SaCodeScDegId);

				if (deep && entity.PgExtMemberCollection.Count > 0)
				{
					deepHandles.Add("PgExtMemberCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgExtMember>) DataRepository.PgExtMemberProvider.DeepLoad,
						new object[] { transactionManager, entity.PgExtMemberCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaResearchTeamCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaResearchTeam>|SaResearchTeamCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaResearchTeamCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaResearchTeamCollection = DataRepository.SaResearchTeamProvider.GetBySaCodeScDegId(transactionManager, entity.SaCodeScDegId);

				if (deep && entity.SaResearchTeamCollection.Count > 0)
				{
					deepHandles.Add("SaResearchTeamCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaResearchTeam>) DataRepository.SaResearchTeamProvider.DeepLoad,
						new object[] { transactionManager, entity.SaResearchTeamCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region CoControlMemberCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<CoControlMember>|CoControlMemberCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CoControlMemberCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.CoControlMemberCollection = DataRepository.CoControlMemberProvider.GetBySaCodeScDegId(transactionManager, entity.SaCodeScDegId);

				if (deep && entity.CoControlMemberCollection.Count > 0)
				{
					deepHandles.Add("CoControlMemberCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CoControlMember>) DataRepository.CoControlMemberProvider.DeepLoad,
						new object[] { transactionManager, entity.CoControlMemberCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaCommMemberCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaCommMember>|SaCommMemberCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaCommMemberCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaCommMemberCollection = DataRepository.SaCommMemberProvider.GetBySaCodeScDegId(transactionManager, entity.SaCodeScDegId);

				if (deep && entity.SaCommMemberCollection.Count > 0)
				{
					deepHandles.Add("SaCommMemberCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaCommMember>) DataRepository.SaCommMemberProvider.DeepLoad,
						new object[] { transactionManager, entity.SaCommMemberCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaPromotionCondCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaPromotionCond>|SaPromotionCondCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaPromotionCondCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaPromotionCondCollection = DataRepository.SaPromotionCondProvider.GetBySaCodeScDegId(transactionManager, entity.SaCodeScDegId);

				if (deep && entity.SaPromotionCondCollection.Count > 0)
				{
					deepHandles.Add("SaPromotionCondCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaPromotionCond>) DataRepository.SaPromotionCondProvider.DeepLoad,
						new object[] { transactionManager, entity.SaPromotionCondCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaServTerminCollectionGetBySaCodeScDegOldId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaServTermin>|SaServTerminCollectionGetBySaCodeScDegOldId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaServTerminCollectionGetBySaCodeScDegOldId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaServTerminCollectionGetBySaCodeScDegOldId = DataRepository.SaServTerminProvider.GetBySaCodeScDegOldId(transactionManager, entity.SaCodeScDegId);

				if (deep && entity.SaServTerminCollectionGetBySaCodeScDegOldId.Count > 0)
				{
					deepHandles.Add("SaServTerminCollectionGetBySaCodeScDegOldId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaServTermin>) DataRepository.SaServTerminProvider.DeepLoad,
						new object[] { transactionManager, entity.SaServTerminCollectionGetBySaCodeScDegOldId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaEmpHierarchyCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaEmpHierarchy>|SaEmpHierarchyCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaEmpHierarchyCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaEmpHierarchyCollection = DataRepository.SaEmpHierarchyProvider.GetBySaCodeScDegId(transactionManager, entity.SaCodeScDegId);

				if (deep && entity.SaEmpHierarchyCollection.Count > 0)
				{
					deepHandles.Add("SaEmpHierarchyCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaEmpHierarchy>) DataRepository.SaEmpHierarchyProvider.DeepLoad,
						new object[] { transactionManager, entity.SaEmpHierarchyCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region PgStfRoleDegCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<PgStfRoleDeg>|PgStfRoleDegCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'PgStfRoleDegCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.PgStfRoleDegCollection = DataRepository.PgStfRoleDegProvider.GetBySaCodeScDegId(transactionManager, entity.SaCodeScDegId);

				if (deep && entity.PgStfRoleDegCollection.Count > 0)
				{
					deepHandles.Add("PgStfRoleDegCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<PgStfRoleDeg>) DataRepository.PgStfRoleDegProvider.DeepLoad,
						new object[] { transactionManager, entity.PgStfRoleDegCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaSupervisingJobsCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaSupervisingJobs>|SaSupervisingJobsCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaSupervisingJobsCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaSupervisingJobsCollection = DataRepository.SaSupervisingJobsProvider.GetBySaCodeScDegId(transactionManager, entity.SaCodeScDegId);

				if (deep && entity.SaSupervisingJobsCollection.Count > 0)
				{
					deepHandles.Add("SaSupervisingJobsCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaSupervisingJobs>) DataRepository.SaSupervisingJobsProvider.DeepLoad,
						new object[] { transactionManager, entity.SaSupervisingJobsCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region CoExaminerCorectorCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<CoExaminerCorector>|CoExaminerCorectorCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CoExaminerCorectorCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.CoExaminerCorectorCollection = DataRepository.CoExaminerCorectorProvider.GetBySaCodeScDegId(transactionManager, entity.SaCodeScDegId);

				if (deep && entity.CoExaminerCorectorCollection.Count > 0)
				{
					deepHandles.Add("CoExaminerCorectorCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CoExaminerCorector>) DataRepository.CoExaminerCorectorProvider.DeepLoad,
						new object[] { transactionManager, entity.CoExaminerCorectorCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region CoContRoomMemberCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<CoContRoomMember>|CoContRoomMemberCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'CoContRoomMemberCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.CoContRoomMemberCollection = DataRepository.CoContRoomMemberProvider.GetBySaCodeScDegId(transactionManager, entity.SaCodeScDegId);

				if (deep && entity.CoContRoomMemberCollection.Count > 0)
				{
					deepHandles.Add("CoContRoomMemberCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<CoContRoomMember>) DataRepository.CoContRoomMemberProvider.DeepLoad,
						new object[] { transactionManager, entity.CoContRoomMemberCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaPromotionCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaPromotion>|SaPromotionCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaPromotionCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaPromotionCollection = DataRepository.SaPromotionProvider.GetBySaCodeScDegId(transactionManager, entity.SaCodeScDegId);

				if (deep && entity.SaPromotionCollection.Count > 0)
				{
					deepHandles.Add("SaPromotionCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaPromotion>) DataRepository.SaPromotionProvider.DeepLoad,
						new object[] { transactionManager, entity.SaPromotionCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaServTerminCollectionGetBySaCodeScDegId
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaServTermin>|SaServTerminCollectionGetBySaCodeScDegId", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaServTerminCollectionGetBySaCodeScDegId' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaServTerminCollectionGetBySaCodeScDegId = DataRepository.SaServTerminProvider.GetBySaCodeScDegId(transactionManager, entity.SaCodeScDegId);

				if (deep && entity.SaServTerminCollectionGetBySaCodeScDegId.Count > 0)
				{
					deepHandles.Add("SaServTerminCollectionGetBySaCodeScDegId",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaServTermin>) DataRepository.SaServTerminProvider.DeepLoad,
						new object[] { transactionManager, entity.SaServTerminCollectionGetBySaCodeScDegId, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaStfMemberCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaStfMember>|SaStfMemberCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaStfMemberCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaStfMemberCollection = DataRepository.SaStfMemberProvider.GetBySaCodeScDegId(transactionManager, entity.SaCodeScDegId);

				if (deep && entity.SaStfMemberCollection.Count > 0)
				{
					deepHandles.Add("SaStfMemberCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaStfMember>) DataRepository.SaStfMemberProvider.DeepLoad,
						new object[] { transactionManager, entity.SaStfMemberCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaPromotionRequestCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaPromotionRequest>|SaPromotionRequestCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaPromotionRequestCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaPromotionRequestCollection = DataRepository.SaPromotionRequestProvider.GetBySaCodeScDegId(transactionManager, entity.SaCodeScDegId);

				if (deep && entity.SaPromotionRequestCollection.Count > 0)
				{
					deepHandles.Add("SaPromotionRequestCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaPromotionRequest>) DataRepository.SaPromotionRequestProvider.DeepLoad,
						new object[] { transactionManager, entity.SaPromotionRequestCollection, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region SaCdeAcadLoadCollection
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<SaCdeAcadLoad>|SaCdeAcadLoadCollection", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'SaCdeAcadLoadCollection' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.SaCdeAcadLoadCollection = DataRepository.SaCdeAcadLoadProvider.GetBySaCodeScDegId(transactionManager, entity.SaCodeScDegId);

				if (deep && entity.SaCdeAcadLoadCollection.Count > 0)
				{
					deepHandles.Add("SaCdeAcadLoadCollection",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<SaCdeAcadLoad>) DataRepository.SaCdeAcadLoadProvider.DeepLoad,
						new object[] { transactionManager, entity.SaCdeAcadLoadCollection, deep, deepLoadType, childTypes, innerList }
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
		/// Deep Save the entire object graph of the UMIS_VER2.BusinessLyer.SaCodeScDeg object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">UMIS_VER2.BusinessLyer.SaCodeScDeg instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">UMIS_VER2.BusinessLyer.SaCodeScDeg Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaCodeScDeg entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<SaEmployment>
				if (CanDeepSave(entity.SaEmploymentCollection, "List<SaEmployment>|SaEmploymentCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaEmployment child in entity.SaEmploymentCollection)
					{
						if(child.SaCodeScDegIdSource != null)
						{
							child.SaCodeScDegId = child.SaCodeScDegIdSource.SaCodeScDegId;
						}
						else
						{
							child.SaCodeScDegId = entity.SaCodeScDegId;
						}

					}

					if (entity.SaEmploymentCollection.Count > 0 || entity.SaEmploymentCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaEmploymentProvider.Save(transactionManager, entity.SaEmploymentCollection);
						
						deepHandles.Add("SaEmploymentCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaEmployment >) DataRepository.SaEmploymentProvider.DeepSave,
							new object[] { transactionManager, entity.SaEmploymentCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<PgExtMember>
				if (CanDeepSave(entity.PgExtMemberCollection, "List<PgExtMember>|PgExtMemberCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgExtMember child in entity.PgExtMemberCollection)
					{
						if(child.SaCodeScDegIdSource != null)
						{
							child.SaCodeScDegId = child.SaCodeScDegIdSource.SaCodeScDegId;
						}
						else
						{
							child.SaCodeScDegId = entity.SaCodeScDegId;
						}

					}

					if (entity.PgExtMemberCollection.Count > 0 || entity.PgExtMemberCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgExtMemberProvider.Save(transactionManager, entity.PgExtMemberCollection);
						
						deepHandles.Add("PgExtMemberCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgExtMember >) DataRepository.PgExtMemberProvider.DeepSave,
							new object[] { transactionManager, entity.PgExtMemberCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaResearchTeam>
				if (CanDeepSave(entity.SaResearchTeamCollection, "List<SaResearchTeam>|SaResearchTeamCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaResearchTeam child in entity.SaResearchTeamCollection)
					{
						if(child.SaCodeScDegIdSource != null)
						{
							child.SaCodeScDegId = child.SaCodeScDegIdSource.SaCodeScDegId;
						}
						else
						{
							child.SaCodeScDegId = entity.SaCodeScDegId;
						}

					}

					if (entity.SaResearchTeamCollection.Count > 0 || entity.SaResearchTeamCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaResearchTeamProvider.Save(transactionManager, entity.SaResearchTeamCollection);
						
						deepHandles.Add("SaResearchTeamCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaResearchTeam >) DataRepository.SaResearchTeamProvider.DeepSave,
							new object[] { transactionManager, entity.SaResearchTeamCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<CoControlMember>
				if (CanDeepSave(entity.CoControlMemberCollection, "List<CoControlMember>|CoControlMemberCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CoControlMember child in entity.CoControlMemberCollection)
					{
						if(child.SaCodeScDegIdSource != null)
						{
							child.SaCodeScDegId = child.SaCodeScDegIdSource.SaCodeScDegId;
						}
						else
						{
							child.SaCodeScDegId = entity.SaCodeScDegId;
						}

					}

					if (entity.CoControlMemberCollection.Count > 0 || entity.CoControlMemberCollection.DeletedItems.Count > 0)
					{
						//DataRepository.CoControlMemberProvider.Save(transactionManager, entity.CoControlMemberCollection);
						
						deepHandles.Add("CoControlMemberCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< CoControlMember >) DataRepository.CoControlMemberProvider.DeepSave,
							new object[] { transactionManager, entity.CoControlMemberCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaCommMember>
				if (CanDeepSave(entity.SaCommMemberCollection, "List<SaCommMember>|SaCommMemberCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaCommMember child in entity.SaCommMemberCollection)
					{
						if(child.SaCodeScDegIdSource != null)
						{
							child.SaCodeScDegId = child.SaCodeScDegIdSource.SaCodeScDegId;
						}
						else
						{
							child.SaCodeScDegId = entity.SaCodeScDegId;
						}

					}

					if (entity.SaCommMemberCollection.Count > 0 || entity.SaCommMemberCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaCommMemberProvider.Save(transactionManager, entity.SaCommMemberCollection);
						
						deepHandles.Add("SaCommMemberCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaCommMember >) DataRepository.SaCommMemberProvider.DeepSave,
							new object[] { transactionManager, entity.SaCommMemberCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaPromotionCond>
				if (CanDeepSave(entity.SaPromotionCondCollection, "List<SaPromotionCond>|SaPromotionCondCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaPromotionCond child in entity.SaPromotionCondCollection)
					{
						if(child.SaCodeScDegIdSource != null)
						{
							child.SaCodeScDegId = child.SaCodeScDegIdSource.SaCodeScDegId;
						}
						else
						{
							child.SaCodeScDegId = entity.SaCodeScDegId;
						}

					}

					if (entity.SaPromotionCondCollection.Count > 0 || entity.SaPromotionCondCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaPromotionCondProvider.Save(transactionManager, entity.SaPromotionCondCollection);
						
						deepHandles.Add("SaPromotionCondCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaPromotionCond >) DataRepository.SaPromotionCondProvider.DeepSave,
							new object[] { transactionManager, entity.SaPromotionCondCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaServTermin>
				if (CanDeepSave(entity.SaServTerminCollectionGetBySaCodeScDegOldId, "List<SaServTermin>|SaServTerminCollectionGetBySaCodeScDegOldId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaServTermin child in entity.SaServTerminCollectionGetBySaCodeScDegOldId)
					{
						if(child.SaCodeScDegOldIdSource != null)
						{
							child.SaCodeScDegOldId = child.SaCodeScDegOldIdSource.SaCodeScDegId;
						}
						else
						{
							child.SaCodeScDegOldId = entity.SaCodeScDegId;
						}

					}

					if (entity.SaServTerminCollectionGetBySaCodeScDegOldId.Count > 0 || entity.SaServTerminCollectionGetBySaCodeScDegOldId.DeletedItems.Count > 0)
					{
						//DataRepository.SaServTerminProvider.Save(transactionManager, entity.SaServTerminCollectionGetBySaCodeScDegOldId);
						
						deepHandles.Add("SaServTerminCollectionGetBySaCodeScDegOldId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaServTermin >) DataRepository.SaServTerminProvider.DeepSave,
							new object[] { transactionManager, entity.SaServTerminCollectionGetBySaCodeScDegOldId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaEmpHierarchy>
				if (CanDeepSave(entity.SaEmpHierarchyCollection, "List<SaEmpHierarchy>|SaEmpHierarchyCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaEmpHierarchy child in entity.SaEmpHierarchyCollection)
					{
						if(child.SaCodeScDegIdSource != null)
						{
							child.SaCodeScDegId = child.SaCodeScDegIdSource.SaCodeScDegId;
						}
						else
						{
							child.SaCodeScDegId = entity.SaCodeScDegId;
						}

					}

					if (entity.SaEmpHierarchyCollection.Count > 0 || entity.SaEmpHierarchyCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaEmpHierarchyProvider.Save(transactionManager, entity.SaEmpHierarchyCollection);
						
						deepHandles.Add("SaEmpHierarchyCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaEmpHierarchy >) DataRepository.SaEmpHierarchyProvider.DeepSave,
							new object[] { transactionManager, entity.SaEmpHierarchyCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<PgStfRoleDeg>
				if (CanDeepSave(entity.PgStfRoleDegCollection, "List<PgStfRoleDeg>|PgStfRoleDegCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(PgStfRoleDeg child in entity.PgStfRoleDegCollection)
					{
						if(child.SaCodeScDegIdSource != null)
						{
							child.SaCodeScDegId = child.SaCodeScDegIdSource.SaCodeScDegId;
						}
						else
						{
							child.SaCodeScDegId = entity.SaCodeScDegId;
						}

					}

					if (entity.PgStfRoleDegCollection.Count > 0 || entity.PgStfRoleDegCollection.DeletedItems.Count > 0)
					{
						//DataRepository.PgStfRoleDegProvider.Save(transactionManager, entity.PgStfRoleDegCollection);
						
						deepHandles.Add("PgStfRoleDegCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< PgStfRoleDeg >) DataRepository.PgStfRoleDegProvider.DeepSave,
							new object[] { transactionManager, entity.PgStfRoleDegCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaSupervisingJobs>
				if (CanDeepSave(entity.SaSupervisingJobsCollection, "List<SaSupervisingJobs>|SaSupervisingJobsCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaSupervisingJobs child in entity.SaSupervisingJobsCollection)
					{
						if(child.SaCodeScDegIdSource != null)
						{
							child.SaCodeScDegId = child.SaCodeScDegIdSource.SaCodeScDegId;
						}
						else
						{
							child.SaCodeScDegId = entity.SaCodeScDegId;
						}

					}

					if (entity.SaSupervisingJobsCollection.Count > 0 || entity.SaSupervisingJobsCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaSupervisingJobsProvider.Save(transactionManager, entity.SaSupervisingJobsCollection);
						
						deepHandles.Add("SaSupervisingJobsCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaSupervisingJobs >) DataRepository.SaSupervisingJobsProvider.DeepSave,
							new object[] { transactionManager, entity.SaSupervisingJobsCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<CoExaminerCorector>
				if (CanDeepSave(entity.CoExaminerCorectorCollection, "List<CoExaminerCorector>|CoExaminerCorectorCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CoExaminerCorector child in entity.CoExaminerCorectorCollection)
					{
						if(child.SaCodeScDegIdSource != null)
						{
							child.SaCodeScDegId = child.SaCodeScDegIdSource.SaCodeScDegId;
						}
						else
						{
							child.SaCodeScDegId = entity.SaCodeScDegId;
						}

					}

					if (entity.CoExaminerCorectorCollection.Count > 0 || entity.CoExaminerCorectorCollection.DeletedItems.Count > 0)
					{
						//DataRepository.CoExaminerCorectorProvider.Save(transactionManager, entity.CoExaminerCorectorCollection);
						
						deepHandles.Add("CoExaminerCorectorCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< CoExaminerCorector >) DataRepository.CoExaminerCorectorProvider.DeepSave,
							new object[] { transactionManager, entity.CoExaminerCorectorCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<CoContRoomMember>
				if (CanDeepSave(entity.CoContRoomMemberCollection, "List<CoContRoomMember>|CoContRoomMemberCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(CoContRoomMember child in entity.CoContRoomMemberCollection)
					{
						if(child.SaCodeScDegIdSource != null)
						{
							child.SaCodeScDegId = child.SaCodeScDegIdSource.SaCodeScDegId;
						}
						else
						{
							child.SaCodeScDegId = entity.SaCodeScDegId;
						}

					}

					if (entity.CoContRoomMemberCollection.Count > 0 || entity.CoContRoomMemberCollection.DeletedItems.Count > 0)
					{
						//DataRepository.CoContRoomMemberProvider.Save(transactionManager, entity.CoContRoomMemberCollection);
						
						deepHandles.Add("CoContRoomMemberCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< CoContRoomMember >) DataRepository.CoContRoomMemberProvider.DeepSave,
							new object[] { transactionManager, entity.CoContRoomMemberCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaPromotion>
				if (CanDeepSave(entity.SaPromotionCollection, "List<SaPromotion>|SaPromotionCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaPromotion child in entity.SaPromotionCollection)
					{
						if(child.SaCodeScDegIdSource != null)
						{
							child.SaCodeScDegId = child.SaCodeScDegIdSource.SaCodeScDegId;
						}
						else
						{
							child.SaCodeScDegId = entity.SaCodeScDegId;
						}

					}

					if (entity.SaPromotionCollection.Count > 0 || entity.SaPromotionCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaPromotionProvider.Save(transactionManager, entity.SaPromotionCollection);
						
						deepHandles.Add("SaPromotionCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaPromotion >) DataRepository.SaPromotionProvider.DeepSave,
							new object[] { transactionManager, entity.SaPromotionCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaServTermin>
				if (CanDeepSave(entity.SaServTerminCollectionGetBySaCodeScDegId, "List<SaServTermin>|SaServTerminCollectionGetBySaCodeScDegId", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaServTermin child in entity.SaServTerminCollectionGetBySaCodeScDegId)
					{
						if(child.SaCodeScDegIdSource != null)
						{
							child.SaCodeScDegId = child.SaCodeScDegIdSource.SaCodeScDegId;
						}
						else
						{
							child.SaCodeScDegId = entity.SaCodeScDegId;
						}

					}

					if (entity.SaServTerminCollectionGetBySaCodeScDegId.Count > 0 || entity.SaServTerminCollectionGetBySaCodeScDegId.DeletedItems.Count > 0)
					{
						//DataRepository.SaServTerminProvider.Save(transactionManager, entity.SaServTerminCollectionGetBySaCodeScDegId);
						
						deepHandles.Add("SaServTerminCollectionGetBySaCodeScDegId",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaServTermin >) DataRepository.SaServTerminProvider.DeepSave,
							new object[] { transactionManager, entity.SaServTerminCollectionGetBySaCodeScDegId, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaStfMember>
				if (CanDeepSave(entity.SaStfMemberCollection, "List<SaStfMember>|SaStfMemberCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaStfMember child in entity.SaStfMemberCollection)
					{
						if(child.SaCodeScDegIdSource != null)
						{
							child.SaCodeScDegId = child.SaCodeScDegIdSource.SaCodeScDegId;
						}
						else
						{
							child.SaCodeScDegId = entity.SaCodeScDegId;
						}

					}

					if (entity.SaStfMemberCollection.Count > 0 || entity.SaStfMemberCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaStfMemberProvider.Save(transactionManager, entity.SaStfMemberCollection);
						
						deepHandles.Add("SaStfMemberCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaStfMember >) DataRepository.SaStfMemberProvider.DeepSave,
							new object[] { transactionManager, entity.SaStfMemberCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaPromotionRequest>
				if (CanDeepSave(entity.SaPromotionRequestCollection, "List<SaPromotionRequest>|SaPromotionRequestCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaPromotionRequest child in entity.SaPromotionRequestCollection)
					{
						if(child.SaCodeScDegIdSource != null)
						{
							child.SaCodeScDegId = child.SaCodeScDegIdSource.SaCodeScDegId;
						}
						else
						{
							child.SaCodeScDegId = entity.SaCodeScDegId;
						}

					}

					if (entity.SaPromotionRequestCollection.Count > 0 || entity.SaPromotionRequestCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaPromotionRequestProvider.Save(transactionManager, entity.SaPromotionRequestCollection);
						
						deepHandles.Add("SaPromotionRequestCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaPromotionRequest >) DataRepository.SaPromotionRequestProvider.DeepSave,
							new object[] { transactionManager, entity.SaPromotionRequestCollection, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<SaCdeAcadLoad>
				if (CanDeepSave(entity.SaCdeAcadLoadCollection, "List<SaCdeAcadLoad>|SaCdeAcadLoadCollection", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(SaCdeAcadLoad child in entity.SaCdeAcadLoadCollection)
					{
						if(child.SaCodeScDegIdSource != null)
						{
							child.SaCodeScDegId = child.SaCodeScDegIdSource.SaCodeScDegId;
						}
						else
						{
							child.SaCodeScDegId = entity.SaCodeScDegId;
						}

					}

					if (entity.SaCdeAcadLoadCollection.Count > 0 || entity.SaCdeAcadLoadCollection.DeletedItems.Count > 0)
					{
						//DataRepository.SaCdeAcadLoadProvider.Save(transactionManager, entity.SaCdeAcadLoadCollection);
						
						deepHandles.Add("SaCdeAcadLoadCollection",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< SaCdeAcadLoad >) DataRepository.SaCdeAcadLoadProvider.DeepSave,
							new object[] { transactionManager, entity.SaCdeAcadLoadCollection, deepSaveType, childTypes, innerList }
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
	
	#region SaCodeScDegChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>UMIS_VER2.BusinessLyer.SaCodeScDeg</c>
	///</summary>
	public enum SaCodeScDegChildEntityTypes
	{
		///<summary>
		/// Collection of <c>SaCodeScDeg</c> as OneToMany for SaEmploymentCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaEmployment>))]
		SaEmploymentCollection,
		///<summary>
		/// Collection of <c>SaCodeScDeg</c> as OneToMany for PgExtMemberCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgExtMember>))]
		PgExtMemberCollection,
		///<summary>
		/// Collection of <c>SaCodeScDeg</c> as OneToMany for SaResearchTeamCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaResearchTeam>))]
		SaResearchTeamCollection,
		///<summary>
		/// Collection of <c>SaCodeScDeg</c> as OneToMany for CoControlMemberCollection
		///</summary>
		[ChildEntityType(typeof(TList<CoControlMember>))]
		CoControlMemberCollection,
		///<summary>
		/// Collection of <c>SaCodeScDeg</c> as OneToMany for SaCommMemberCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaCommMember>))]
		SaCommMemberCollection,
		///<summary>
		/// Collection of <c>SaCodeScDeg</c> as OneToMany for SaPromotionCondCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaPromotionCond>))]
		SaPromotionCondCollection,
		///<summary>
		/// Collection of <c>SaCodeScDeg</c> as OneToMany for SaServTerminCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaServTermin>))]
		SaServTerminCollectionGetBySaCodeScDegOldId,
		///<summary>
		/// Collection of <c>SaCodeScDeg</c> as OneToMany for SaEmpHierarchyCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaEmpHierarchy>))]
		SaEmpHierarchyCollection,
		///<summary>
		/// Collection of <c>SaCodeScDeg</c> as OneToMany for PgStfRoleDegCollection
		///</summary>
		[ChildEntityType(typeof(TList<PgStfRoleDeg>))]
		PgStfRoleDegCollection,
		///<summary>
		/// Collection of <c>SaCodeScDeg</c> as OneToMany for SaSupervisingJobsCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaSupervisingJobs>))]
		SaSupervisingJobsCollection,
		///<summary>
		/// Collection of <c>SaCodeScDeg</c> as OneToMany for CoExaminerCorectorCollection
		///</summary>
		[ChildEntityType(typeof(TList<CoExaminerCorector>))]
		CoExaminerCorectorCollection,
		///<summary>
		/// Collection of <c>SaCodeScDeg</c> as OneToMany for CoContRoomMemberCollection
		///</summary>
		[ChildEntityType(typeof(TList<CoContRoomMember>))]
		CoContRoomMemberCollection,
		///<summary>
		/// Collection of <c>SaCodeScDeg</c> as OneToMany for SaPromotionCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaPromotion>))]
		SaPromotionCollection,
		///<summary>
		/// Collection of <c>SaCodeScDeg</c> as OneToMany for SaServTerminCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaServTermin>))]
		SaServTerminCollectionGetBySaCodeScDegId,
		///<summary>
		/// Collection of <c>SaCodeScDeg</c> as OneToMany for SaStfMemberCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaStfMember>))]
		SaStfMemberCollection,
		///<summary>
		/// Collection of <c>SaCodeScDeg</c> as OneToMany for SaPromotionRequestCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaPromotionRequest>))]
		SaPromotionRequestCollection,
		///<summary>
		/// Collection of <c>SaCodeScDeg</c> as OneToMany for SaCdeAcadLoadCollection
		///</summary>
		[ChildEntityType(typeof(TList<SaCdeAcadLoad>))]
		SaCdeAcadLoadCollection,
	}
	
	#endregion SaCodeScDegChildEntityTypes
	
	#region SaCodeScDegFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;SaCodeScDegColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCodeScDeg"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaCodeScDegFilterBuilder : SqlFilterBuilder<SaCodeScDegColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCodeScDegFilterBuilder class.
		/// </summary>
		public SaCodeScDegFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaCodeScDegFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaCodeScDegFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaCodeScDegFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaCodeScDegFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaCodeScDegFilterBuilder
	
	#region SaCodeScDegParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;SaCodeScDegColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCodeScDeg"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SaCodeScDegParameterBuilder : ParameterizedSqlFilterBuilder<SaCodeScDegColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCodeScDegParameterBuilder class.
		/// </summary>
		public SaCodeScDegParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the SaCodeScDegParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public SaCodeScDegParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the SaCodeScDegParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public SaCodeScDegParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion SaCodeScDegParameterBuilder
	
	#region SaCodeScDegSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;SaCodeScDegColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SaCodeScDeg"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class SaCodeScDegSortBuilder : SqlSortBuilder<SaCodeScDegColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SaCodeScDegSqlSortBuilder class.
		/// </summary>
		public SaCodeScDegSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion SaCodeScDegSortBuilder
	
} // end namespace
